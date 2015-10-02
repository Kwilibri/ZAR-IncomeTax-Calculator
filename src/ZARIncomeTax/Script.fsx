#load "TaxCalcUtilities.fs"
#load "ZARTaxRateTables.fs"
#load "ZARIncomeTax.fs"

open System
open Kwilibri.ZARIncomeTax

let calc = new TaxCalculator()

//This is not correct or tested yet.  Is not allocating the primary discount or taking age into account.
System.Console.WriteLine( calc.ZARIncomeTax2016 100000)


