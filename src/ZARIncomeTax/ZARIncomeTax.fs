namespace Kwilibri.ZARIncomeTax

open System
open Kwilibri.ZARIncomeTax.TaxCalcUtilities
open Kwilibri.ZARIncomeTax.ZARTaxRateTables

type TaxCalculator() = 
    member this.ZARIncomeTax2016 incomeAmount =
        let result = ZARTaxRates2016 |> taxOf incomeAmount
        result
        
