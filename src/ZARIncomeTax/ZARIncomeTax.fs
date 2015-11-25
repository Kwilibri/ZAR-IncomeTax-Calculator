namespace Kwilibri.ZARIncomeTax

open System
open Kwilibri.ZARIncomeTax.TaxCalcUtilities
open Kwilibri.ZARIncomeTax.ZARTaxRateTables

type TaxCalculator() = 
    member this.ZARIncomeTax2016 incomeAmount age =
        let mutable result = ZARTaxRates2016 |> taxOf incomeAmount
        let primaryRebate = 13257m
        let secondaryRebate = 7407m
        let tertiaryRebate = 2466m

        match age with
        |i when i < 65 -> result <- result - primaryRebate
        |i when i >= 65 && i <75 -> result <- result - primaryRebate - secondaryRebate
        |i when i >= 75 -> result <- result - primaryRebate - secondaryRebate - tertiaryRebate
        | _ -> result <- System.Decimal.MinValue

        if (result <0m) then
            result <- 0m
        result
        
