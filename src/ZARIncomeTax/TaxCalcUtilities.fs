namespace Kwilibri.ZARIncomeTax

module TaxCalcUtilities = 

   let taxOf income taxRates =
        ((0m,0)::taxRates, taxRates)
            ||> Seq.zip
             |> Seq.map(fun ((_, prevBand),(rate, band)) -> (prevBand, rate, band))
             |> Seq.sumBy(fun (prevBand, rate, band) ->
                match income with
                    | x when x < prevBand -> 0m
                    | x when x > band -> decimal(band - prevBand) * rate
                    | x -> decimal(x - prevBand) * rate
                )

