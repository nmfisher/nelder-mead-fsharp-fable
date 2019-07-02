namespace Examples

open System
open Fable.Core
open Fable.Core.JsInterop
open Browser

module NelderMead =

  type Point(data:float list) =
      member this.data = data
      member this.dim = List.length data
      
      static member (+) (point1:Point, point2:Point)  =
        (point1.data, point2.data) 
          ||> List.zip 
          |> List.map (fun (x,y) -> x+y)
          |> Point

      static member (-) (point1:Point, point2:Point)  =
        (point1.data, point2.data) 
          ||> List.zip 
          |> List.map (fun (x,y) -> x-y)
          |> Point
      
      static member (/) (point1:Point, divisor:float)  =
        point1.data
          |> List.map (fun x -> x / divisor)
          |> Point

      static member (/) (point1:Point, divisor:int)  =
         point1.data
          |> List.map (fun x -> x / float(divisor))
          |> Point

      static member (*) (point1:Point, scalar:float)  =
         point1.data
          |> List.map (fun x -> x * scalar)
          |> Point

      static member (*) (point1:Point, scalar:int)  =
        point1.data
          |> List.map (fun x -> x * float(scalar))
          |> Point

      static member (~%%) (point:Point) =
        point.data
          |> List.map (fun x -> x ** 2.0)
          |> Point

  let average points =
      points |> Seq.reduce (+) |> (fun x -> x / (Seq.length points))

  type Simplex(points:Point[], objective:Point -> float) =

      let scored = points 
                  |> Array.map( fun x -> x, objective x)
                  |> Array.sortBy (fun (x,y) -> y)

      let best = fst scored.[0]
      let f_best = snd scored.[0]
      let good = fst scored.[1]
      let f_good = snd scored.[1]
      let worst = fst scored.[2]
      let f_worst = snd scored.[2]


      let midpoint = (best + good) / 2.0
      
      member this.compute () = 
        let reflect = (midpoint * 2.0) - worst
        let f_reflect = objective reflect
        match f_reflect < f_good with
        | true ->
          match f_best < f_reflect with
          | true -> 
            Simplex([|best; good; reflect|], objective)    
          | false ->
            let extension = (reflect * 2) - midpoint
            let f_extension = objective extension
            match f_extension < f_reflect with
            | true ->
              Simplex([|best; good; extension|], objective)    
             | false ->
              Simplex([|best; good; reflect|], objective)     
        | false ->
          match f_reflect < f_worst with
          | true ->         
            Simplex([|best; good; reflect|], objective)     
          | false ->
            let c1 = (midpoint + worst) / 2
            let c2 = (midpoint + reflect) / 2
            let contraction = match objective c1 > objective c2 with | true -> c2 | false -> c1
            let f_contraction = objective contraction
            match f_contraction < f_worst with
            | true ->
              Simplex([|best; good; contraction|], objective)     
            | false ->          
              let shrinkage = (best + worst) / 2
              let f_shrinkage = objective shrinkage
              Simplex([|best; midpoint; shrinkage|], objective)     
        member this.points = points
          
          