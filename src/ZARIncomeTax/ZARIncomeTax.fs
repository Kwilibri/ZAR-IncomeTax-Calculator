namespace Kwilibri.ZARIncomeTax

open System
open Kwilibri.ZARIncomeTax.TaxCalcUtilities
open Kwilibri.ZARIncomeTax.ZARTaxRateTables

type TaxCalculator() = 
    member this.ZARIncomeTax2016 incomeAmount age =
        let mutable result = ZARTaxRates2016 |> taxOf incomeAmount
        let PrimaryRebate = 13257m
        let SecondaryRebate = 7407m
        let TertiaryRebate = 2466m

        match age with
        |i when i < 65 -> result <- result - PrimaryRebate
        |j when j >= 65 && j<75 -> result <- result - PrimaryRebate - SecondaryRebate
        |k when k >= 75 -> result <- result - PrimaryRebate - SecondaryRebate - TertiaryRebate

        if (result <0m) then
            result <- 0m
        result
        
