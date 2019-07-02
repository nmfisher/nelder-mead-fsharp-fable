namespace Examples

open Browser

module HTML =

  let graphId = "graph"

  let graph = document.createElement "div"
  graph.id <- graphId

  document.body.appendChild(graph) |> ignore

  let initButton = document.createElement "button"
  initButton.innerText <- "Reset"
  document.body.appendChild(initButton) |> ignore

  let stepButton = document.createElement "button"
  stepButton.innerText <- "Step"
  document.body.appendChild(stepButton) |> ignore