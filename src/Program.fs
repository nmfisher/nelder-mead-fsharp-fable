module App

open System
open Fable.Core
open Fable.Core.JsInterop
open Browser
open Plotly
open Plotly.Index
open Examples.Graphing
open Examples.HTML
open Examples.NelderMead

let obj x = x ** 2.0

let xMin = -100.0
let xMax = 100.0

let layout = createObj [
      "xaxis" ==> createObj [ "range" ==>  struct(xMin, xMax) ]
      "yaxis" ==> createObj [ "range" ==>  struct(-(xMin*xMin), (xMax*xMax)) ]
    ]

let x = seq { xMin..xMax } |> Array.ofSeq
let y = x |> Array.map obj

plot !^ graph x y layout

let rnd = System.Random()

let getStartingPoints () = 
    [|0;1;2|]
    |> Array.map (fun x -> 
        let x = rnd.Next(int(xMin), int(xMax)) |> float
        Point([x;])
    )

let mutable simplex = Simplex(getStartingPoints(), (fun p -> obj p.data.[0]))

let restyle (simplex:Simplex) = 
  let xs = simplex.points |> Array.map (fun p -> p.data.[0]) |> (fun x -> Array.append x x)
  let ys = simplex.points |> Array.map (fun p -> obj p.data.[0]) |> (fun x -> Array.append x x)
  restyle !^ graph x y xs ys layout

initButton.onclick <- (fun _ -> 
  let points = getStartingPoints()
  simplex <- Simplex(points, (fun p -> obj p.data.[0]))
  restyle simplex
)

stepButton.onclick <- (fun _ -> 
  // console.log(simplex.points |> Array.map(fun x -> x.data |> Array.ofList))
  simplex <- simplex.compute()
  // console.log(simplex.points |> Array.map(fun x -> x.data |> Array.ofList))
  restyle simplex
)


