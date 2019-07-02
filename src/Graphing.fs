namespace Examples

open Plotly
open Plotly.Index
open Fable.Core
open Fable.Core.JsInterop
open Browser

module Graphing =
  
  [<Emit("Plotly")>]
  let plotly : Plotly.Index.IExports = jsNative 
    

  let plot id x y layout = 
    plotly.newPlot(
      id,
      [ createObj [ "x" ==> x; "y" ==> y; "line" ==> createObj [ "simplify" ==> false ] ] ] |> ResizeArray, 
      Some(layout))

  let restyle id x1 y1 x2 y2 layout =
    plotly.newPlot(
      id,
      [ 
        createObj [ "x" ==> x1; "y" ==> y1; "line" ==> createObj [ "simplify" ==> false ] ] 
        createObj [ "x" ==> x2; "y" ==> y2; "lines+markers" ==> createObj [ "simplify" ==> false ] ] 
      ] |> ResizeArray, 
      Some(layout))
        