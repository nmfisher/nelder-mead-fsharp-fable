// ts2fable 0.0.0
module rec Plotly
open System
open Fable.Core
open Fable.Import.JS
open Fable.Import.Browser
open Fable.Core.JS
open Browser.Types


module Index =
    module _d3 = D3

    type [<AllowNullLiteral>] IExports =
        abstract Plots: StaticPlots
        abstract newPlot: root: Root * data: ResizeArray<Data> * ?layout: obj * ?config: obj -> Promise<PlotlyHTMLElement>
        abstract plot: root: Root * data: ResizeArray<Data> * ?layout: obj * ?config: obj -> Promise<PlotlyHTMLElement>
        abstract relayout: root: Root * layout: obj -> Promise<PlotlyHTMLElement>
        abstract redraw: root: Root -> Promise<PlotlyHTMLElement>
        abstract purge: root: Root -> unit
        abstract d3: obj
        abstract restyle: root: Root * aobj: Data * ?traces: U2<ResizeArray<float>, float> -> Promise<PlotlyHTMLElement>
        abstract update: root: Root * traceUpdate: Data * layoutUpdate: obj * ?traces: U2<ResizeArray<float>, float> -> Promise<PlotlyHTMLElement>
        abstract addTraces: root: Root * traces: U2<Data, ResizeArray<Data>> * ?newIndices: U2<ResizeArray<float>, float> -> Promise<PlotlyHTMLElement>
        abstract deleteTraces: root: Root * indices: U2<ResizeArray<float>, float> -> Promise<PlotlyHTMLElement>
        abstract moveTraces: root: Root * currentIndices: U2<ResizeArray<float>, float> * ?newIndices: U2<ResizeArray<float>, float> -> Promise<PlotlyHTMLElement>
        abstract extendTraces: root: Root * update: U2<Data, ResizeArray<Data>> * indices: U2<float, ResizeArray<float>> -> Promise<PlotlyHTMLElement>
        abstract prependTraces: root: Root * update: U2<Data, ResizeArray<Data>> * indices: U2<float, ResizeArray<float>> -> Promise<PlotlyHTMLElement>
        abstract toImage: root: Root * opts: ToImgopts -> Promise<string>
        abstract downloadImage: root: Root * opts: DownloadImgopts -> Promise<string>
        abstract react: root: Root * data: ResizeArray<Data> * ?layout: obj * ?config: obj -> Promise<PlotlyHTMLElement>
        abstract addFrames: root: Root * frames: Array -> Promise<PlotlyHTMLElement>
        abstract deleteFrames: root: Root * frames: ResizeArray<float> -> Promise<PlotlyHTMLElement>

    type [<AllowNullLiteral>] StaticPlots =
        abstract resize: root: Root -> unit

    type [<AllowNullLiteral>] Point =
        abstract x: float with get, set
        abstract y: float with get, set
        abstract z: float with get, set

    type [<AllowNullLiteral>] PlotScatterDataPoint =
        abstract curveNumber: float with get, set
        abstract data: PlotData with get, set
        abstract pointIndex: float with get, set
        abstract pointNumber: float with get, set
        abstract x: float with get, set
        abstract xaxis: LayoutAxis with get, set
        abstract y: float with get, set
        abstract yaxis: LayoutAxis with get, set

    type [<AllowNullLiteral>] PlotDatum =
        abstract curveNumber: float with get, set
        abstract data: PlotData with get, set
        abstract pointIndex: float with get, set
        abstract pointNumber: float with get, set
        abstract x: Datum with get, set
        abstract xaxis: LayoutAxis with get, set
        abstract y: Datum with get, set
        abstract yaxis: LayoutAxis with get, set

    type [<AllowNullLiteral>] PlotMouseEvent =
        abstract points: ResizeArray<PlotDatum> with get, set
        abstract ``event``: MouseEvent with get, set

    type [<AllowNullLiteral>] PlotCoordinate =
        abstract x: float with get, set
        abstract y: float with get, set
        abstract pointNumber: float with get, set

    type [<AllowNullLiteral>] SelectionRange =
        abstract x: ResizeArray<float> with get, set
        abstract y: ResizeArray<float> with get, set

    type PlotSelectedData =
        obj

    type [<AllowNullLiteral>] PlotSelectionEvent =
        abstract points: ResizeArray<PlotDatum> with get, set
        abstract range: SelectionRange option with get, set
        abstract lassoPoints: SelectionRange option with get, set

    type PlotRestyleEvent =
        obj option * ResizeArray<float>

    type [<AllowNullLiteral>] PlotAxis =
        abstract range: float * float with get, set
        abstract autorange: bool with get, set

    type [<AllowNullLiteral>] PlotScene =
        abstract center: Point with get, set
        abstract eye: Point with get, set
        abstract up: Point with get, set

    type [<AllowNullLiteral>] PlotRelayoutEvent =
        abstract xaxis: PlotAxis with get, set
        abstract yaxis: PlotAxis with get, set
        abstract scene: PlotScene with get, set

    type [<AllowNullLiteral>] ClickAnnotationEvent =
        abstract index: float with get, set
        abstract annotation: Annotations with get, set
        abstract fullAnnotation: Annotations with get, set
        abstract ``event``: MouseEvent with get, set

    type [<AllowNullLiteral>] FrameAnimationEvent =
        abstract name: string with get, set
        abstract frame: Frame with get, set
        abstract animation: TypeLiteral_02 with get, set

    type [<AllowNullLiteral>] LegendClickEvent =
        abstract ``event``: MouseEvent with get, set
        abstract node: PlotlyHTMLElement with get, set
        abstract curveNumber: float with get, set
        abstract expandedIndex: float with get, set
        abstract data: ResizeArray<Data> with get, set
        abstract layout: obj with get, set
        abstract frames: ResizeArray<Frame> with get, set
        abstract config: obj with get, set
        abstract fullData: ResizeArray<Data> with get, set
        abstract fullLayout: obj with get, set

    type [<AllowNullLiteral>] SliderChangeEvent =
        abstract slider: Slider with get, set
        abstract step: SliderStep with get, set
        abstract interaction: bool with get, set
        abstract previousActive: float with get, set

    type [<AllowNullLiteral>] SliderStartEvent =
        abstract slider: Slider with get, set

    type [<AllowNullLiteral>] SliderEndEvent =
        abstract slider: Slider with get, set
        abstract step: SliderStep with get, set

    type [<AllowNullLiteral>] BeforePlotEvent =
        abstract data: ResizeArray<Data> with get, set
        abstract layout: obj with get, set
        abstract config: obj with get, set

    type [<AllowNullLiteral>] PlotlyHTMLElement =
        inherit HTMLElement
        abstract on: ``event``: U3<string, string, string> * callback: (PlotMouseEvent -> unit) -> unit
        abstract on: ``event``: U2<string, string> * callback: (PlotSelectionEvent -> unit) -> unit
        [<Emit "$0.on('plotly_restyle',$1)">] abstract on_plotly_restyle: callback: (PlotRestyleEvent -> unit) -> unit
        [<Emit "$0.on('plotly_relayout',$1)">] abstract on_plotly_relayout: callback: (PlotRelayoutEvent -> unit) -> unit
        [<Emit "$0.on('plotly_clickannotation',$1)">] abstract on_plotly_clickannotation: callback: (ClickAnnotationEvent -> unit) -> unit
        [<Emit "$0.on('plotly_animatingframe',$1)">] abstract on_plotly_animatingframe: callback: (FrameAnimationEvent -> unit) -> unit
        abstract on: ``event``: U2<string, string> * callback: (LegendClickEvent -> bool) -> unit
        [<Emit "$0.on('plotly_sliderchange',$1)">] abstract on_plotly_sliderchange: callback: (SliderChangeEvent -> unit) -> unit
        [<Emit "$0.on('plotly_sliderend',$1)">] abstract on_plotly_sliderend: callback: (SliderEndEvent -> unit) -> unit
        [<Emit "$0.on('plotly_sliderstart',$1)">] abstract on_plotly_sliderstart: callback: (SliderStartEvent -> unit) -> unit
        [<Emit "$0.on('plotly_event',$1)">] abstract on_plotly_event: callback: (obj option -> unit) -> unit
        [<Emit "$0.on('plotly_beforeplot',$1)">] abstract on_plotly_beforeplot: callback: (BeforePlotEvent -> bool) -> unit
        abstract on: ``event``: obj * callback: (unit -> unit) -> unit
        abstract removeAllListeners: (string -> unit) with get, set

    type [<AllowNullLiteral>] ToImgopts =
        abstract format: U4<string, string, string, string> with get, set
        abstract width: float with get, set
        abstract height: float with get, set

    type [<AllowNullLiteral>] DownloadImgopts =
        abstract format: U4<string, string, string, string> with get, set
        abstract width: float with get, set
        abstract height: float with get, set
        abstract filename: string with get, set

    type Root =
        U2<string, HTMLElement>

    [<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
    module Root =
        let ofString v: Root = v |> U2.Case1
        let isString (v: Root) = match v with U2.Case1 _ -> true | _ -> false
        let asString (v: Root) = match v with U2.Case1 o -> Some o | _ -> None
        let ofHTMLElement v: Root = v |> U2.Case2
        let isHTMLElement (v: Root) = match v with U2.Case2 _ -> true | _ -> false
        let asHTMLElement (v: Root) = match v with U2.Case2 o -> Some o | _ -> None

    type [<AllowNullLiteral>] Layout =
        abstract title: U2<string, obj> with get, set
        abstract titlefont: obj with get, set
        abstract autosize: bool with get, set
        abstract showlegend: bool with get, set
        abstract paper_bgcolor: Color with get, set
        abstract plot_bgcolor: Color with get, set
        abstract separators: string with get, set
        abstract hidesources: bool with get, set
        abstract xaxis: obj with get, set
        abstract xaxis2: obj with get, set
        abstract xaxis3: obj with get, set
        abstract xaxis4: obj with get, set
        abstract xaxis5: obj with get, set
        abstract xaxis6: obj with get, set
        abstract xaxis7: obj with get, set
        abstract xaxis8: obj with get, set
        abstract xaxis9: obj with get, set
        abstract yaxis: obj with get, set
        abstract yaxis2: obj with get, set
        abstract yaxis3: obj with get, set
        abstract yaxis4: obj with get, set
        abstract yaxis5: obj with get, set
        abstract yaxis6: obj with get, set
        abstract yaxis7: obj with get, set
        abstract yaxis8: obj with get, set
        abstract yaxis9: obj with get, set
        abstract margin: obj with get, set
        abstract height: float with get, set
        abstract width: float with get, set
        abstract hovermode: U4<string, string, string, obj> with get, set
        abstract hoverlabel: obj with get, set
        abstract calendar: Calendar with get, set
        abstract xaxisrange: Datum * Datum with get, set
        abstract xaxisrange0: Datum with get, set
        abstract xaxisrange1: Datum with get, set
        abstract yaxisrange: Datum * Datum with get, set
        abstract yaxisrange0: Datum with get, set
        abstract yaxisrange1: Datum with get, set
        abstract yaxistype: AxisType with get, set
        abstract xaxistype: AxisType with get, set
        abstract xaxisautorange: bool with get, set
        abstract yaxisautorange: bool with get, set
        abstract ternary: TypeLiteral_03 with get, set
        abstract geo: TypeLiteral_03 with get, set
        abstract mapbox: TypeLiteral_03 with get, set
        abstract radialaxis: obj with get, set
        abstract angularaxis: TypeLiteral_03 with get, set
        abstract direction: U2<string, string> with get, set
        abstract dragmode: U6<string, string, string, string, string, string> with get, set
        abstract orientation: float with get, set
        abstract annotations: Array with get, set
        abstract shapes: Array with get, set
        abstract images: Array with get, set
        abstract updatemenus: TypeLiteral_03 with get, set
        abstract sliders: Array with get, set
        abstract legend: obj with get, set
        abstract font: obj with get, set
        abstract scene: obj with get, set
        abstract barmode: U4<string, string, string, string> with get, set
        abstract bargap: float with get, set
        abstract bargroupgap: float with get, set

    type [<AllowNullLiteral>] Legend =
        inherit Label
        abstract traceorder: U3<string, string, string> with get, set
        abstract x: float with get, set
        abstract y: float with get, set
        abstract borderwidth: float with get, set
        abstract orientation: U2<string, string> with get, set
        abstract tracegroupgap: float with get, set
        abstract xanchor: U4<string, string, string, string> with get, set
        abstract yanchor: U4<string, string, string, string> with get, set

    type [<StringEnum>] [<RequireQualifiedAccess>] AxisType = 
      | Linear
      | Log
      | Date
      | Category
      
    type [<AllowNullLiteral>] Axis =
        abstract visible: bool with get, set
        abstract color: Color with get, set
        abstract title: string with get, set
        abstract titlefont: obj with get, set
        abstract ``type``: AxisType with get, set
        abstract autorange: U2<obj, string> with get, set
        abstract rangemode: U3<string, string, string> with get, set
        abstract range: ResizeArray<obj option> with get, set
        abstract tickmode: U3<string, string, string> with get, set
        abstract nticks: float with get, set
        abstract tick0: U2<float, string> with get, set
        abstract dtick: U2<float, string> with get, set
        abstract tickvals: ResizeArray<obj option> with get, set
        abstract ticktext: ResizeArray<string> with get, set
        abstract ticks: U3<string, string, string> with get, set
        abstract mirror: U4<obj, string, string, string> with get, set
        abstract ticklen: float with get, set
        abstract tickwidth: float with get, set
        abstract tickcolor: Color with get, set
        abstract showticklabels: bool with get, set
        abstract showspikes: bool with get, set
        abstract spikecolor: Color with get, set
        abstract spikethickness: float with get, set
        abstract categoryorder: U4<string, string, string, string> with get, set
        abstract categoryarray: ResizeArray<obj option> with get, set
        abstract tickfont: obj with get, set
        abstract tickangle: float with get, set
        abstract tickprefix: string with get, set
        abstract showtickprefix: U4<string, string, string, string> with get, set
        abstract ticksuffix: string with get, set
        abstract showticksuffix: U4<string, string, string, string> with get, set
        abstract showexponent: U4<string, string, string, string> with get, set
        abstract exponentformat: U6<string, string, string, string, string, string> with get, set
        abstract separatethousands: bool with get, set
        abstract tickformat: string with get, set
        abstract hoverformat: string with get, set
        abstract showline: bool with get, set
        abstract linecolor: Color with get, set
        abstract linewidth: float with get, set
        abstract showgrid: bool with get, set
        abstract gridcolor: Color with get, set
        abstract gridwidth: float with get, set
        abstract zeroline: bool with get, set
        abstract zerolinecolor: Color with get, set
        abstract zerolinewidth: float with get, set
        abstract calendar: Calendar with get, set

    type [<StringEnum>] [<RequireQualifiedAccess>] Calendar =
        | Gregorian
        | Chinese
        | Coptic
        | Discworld
        | Ethiopian
        | Hebrew
        | Islamic
        | Julian
        | Mayan
        | Nanakshahi
        | Nepali
        | Persian
        | Jalali
        | Taiwan
        | Thai
        | Ummalqura

    type [<StringEnum>] [<RequireQualifiedAccess>] AxisName =
        | X
        | X2
        | X3
        | X4
        | X5
        | X6
        | X7
        | X8
        | X9
        | Y
        | Y2
        | Y3
        | Y4
        | Y5
        | Y6
        | Y7
        | Y8
        | Y9

    type [<AllowNullLiteral>] LayoutAxis =
        inherit Axis
        abstract fixedrange: bool with get, set
        abstract scaleanchor: AxisName with get, set
        abstract scaleratio: float with get, set
        abstract constrain: U2<string, string> with get, set
        abstract constraintoward: U6<string, string, string, string, string, string> with get, set
        abstract spikedash: string with get, set
        abstract spikemode: string with get, set
        abstract anchor: U2<string, AxisName> with get, set
        abstract side: U4<string, string, string, string> with get, set
        abstract overlaying: U2<string, AxisName> with get, set
        abstract layer: U2<string, string> with get, set
        abstract domain: ResizeArray<float> with get, set
        abstract position: float with get, set
        abstract rangeslider: obj with get, set
        abstract rangeselector: obj with get, set
        abstract automargin: bool with get, set

    type [<AllowNullLiteral>] SceneAxis =
        inherit Axis
        abstract spikesides: bool with get, set
        abstract showbackground: bool with get, set
        abstract backgroundcolor: Color with get, set
        abstract showaxeslabels: bool with get, set

    type [<AllowNullLiteral>] ShapeLine =
        abstract color: string with get, set
        abstract width: float with get, set
        abstract dash: Dash with get, set

    type [<AllowNullLiteral>] Shape =
        abstract visible: bool with get, set
        abstract layer: U2<string, string> with get, set
        abstract ``type``: U4<string, string, string, string> with get, set
        abstract path: string with get, set
        abstract xref: U2<string, string> with get, set
        abstract yref: U2<string, string> with get, set
        abstract x0: Datum with get, set
        abstract y0: Datum with get, set
        abstract x1: Datum with get, set
        abstract y1: Datum with get, set
        abstract fillcolor: string with get, set
        abstract opacity: float with get, set
        abstract line: obj with get, set

    type [<AllowNullLiteral>] Margin =
        abstract t: float with get, set
        abstract b: float with get, set
        abstract l: float with get, set
        abstract r: float with get, set

    type [<StringEnum>] [<RequireQualifiedAccess>] ModeBarDefaultButtons =
        | Lasso2d
        | Select2d
        | SendDataToCloud
        | Zoom2d
        | Pan2d
        | ZoomIn2d
        | ZoomOut2d
        | AutoScale2d
        | ResetScale2d
        | HoverClosestCartesian
        | HoverCompareCartesian
        | Zoom3d
        | Pan3d
        | OrbitRotation
        | TableRotation
        | ResetCameraDefault3d
        | ResetCameraLastSave3d
        | HoverClosest3d
        | ZoomInGeo
        | ZoomOutGeo
        | ResetGeo
        | HoverClosestGeo
        | HoverClosestGl2d
        | HoverClosestPie
        | ToggleHover
        | ToImage
        | ResetViews
        | ToggleSpikelines

    type [<AllowNullLiteral>] ButtonClickEvent =
        [<Emit "$0($1...)">] abstract Invoke: gd: PlotlyHTMLElement * ev: MouseEvent -> unit

    type [<AllowNullLiteral>] Icon =
        abstract width: float with get, set
        abstract path: string with get, set
        abstract ascent: float with get, set
        abstract descent: float with get, set

    type [<AllowNullLiteral>] ModeBarButton =
        /// name / id of the buttons (for tracking) 
        abstract name: string with get, set
        /// text that appears while hovering over the button,
        /// enter null, false or '' for no hover text
        abstract title: string with get, set
        /// svg icon object associated with the button
        /// can be linked to Plotly.Icons to use the default plotly icons
        abstract icon: U2<string, Icon> with get, set
        /// icon positioning 
        abstract gravity: string option with get, set
        /// click handler associated with the button, a function of
        /// 'gd' (the main graph object) and
        /// 'ev' (the event object)
        abstract click: ButtonClickEvent with get, set
        /// attribute associated with button,
        /// use this with 'val' to keep track of the state
        abstract attr: string option with get, set
        /// initial 'attr' value, can be a function of gd 
        abstract ``val``: obj option with get, set
        /// is the button a toggle button? 
        abstract toggle: bool option with get, set

    type Datum =
        U3<string, float, DateTime> option

    [<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
    module Datum =
        let ofStringOption v: Datum = v |> Microsoft.FSharp.Core.Option.map U3.Case1
        let ofString v: Datum = v |> U3.Case1 |> Some
        let isString (v: Datum) = match v with None -> false | Some o -> match o with U3.Case1 _ -> true | _ -> false
        let asString (v: Datum) = match v with None -> None | Some o -> match o with U3.Case1 o -> Some o | _ -> None
        let ofFloatOption v: Datum = v |> Microsoft.FSharp.Core.Option.map U3.Case2
        let ofFloat v: Datum = v |> U3.Case2 |> Some
        let isFloat (v: Datum) = match v with None -> false | Some o -> match o with U3.Case2 _ -> true | _ -> false
        let asFloat (v: Datum) = match v with None -> None | Some o -> match o with U3.Case2 o -> Some o | _ -> None
        let ofDateTimeOption v: Datum = v |> Microsoft.FSharp.Core.Option.map U3.Case3
        let ofDateTime v: Datum = v |> U3.Case3 |> Some
        let isDateTime (v: Datum) = match v with None -> false | Some o -> match o with U3.Case3 _ -> true | _ -> false
        let asDateTime (v: Datum) = match v with None -> None | Some o -> match o with U3.Case3 o -> Some o | _ -> None

    type TypedArray =
        obj

    type [<AllowNullLiteral>] ErrorOptions =
        abstract visible: bool with get, set
        abstract symmetric: bool with get, set
        abstract color: Color with get, set
        abstract thickness: float with get, set
        abstract width: float with get, set
        abstract opacity: float with get, set

    type [<AllowNullLiteral>] ErrorBar =
        interface end

    type [<StringEnum>] [<RequireQualifiedAccess>] Dash =
        | Solid
        | Dot
        | Dash
        | Longdash
        | Dashdot
        | Longdashdot

    type Data =
        obj

    type Color =
        U3<string, Array, Array>

    [<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
    module Color =
        let ofString v: Color = v |> U3.Case1
        let isString (v: Color) = match v with U3.Case1 _ -> true | _ -> false
        let asString (v: Color) = match v with U3.Case1 o -> Some o | _ -> None
        let ofArray v: Color = v |> U3.Case2
        let isArray (v: Color) = match v with U3.Case2 _ -> true | _ -> false
        let asArray (v: Color) = match v with U3.Case2 o -> Some o | _ -> None

    type DataTransform =
        obj

    type ScatterData =
        PlotData

    type [<AllowNullLiteral>] PlotData =
        abstract ``type``: obj with get, set
        abstract x: U3<ResizeArray<Datum>, ResizeArray<ResizeArray<Datum>>, TypedArray> with get, set
        abstract y: U3<ResizeArray<Datum>, ResizeArray<ResizeArray<Datum>>, TypedArray> with get, set
        abstract z: U4<ResizeArray<Datum>, ResizeArray<ResizeArray<Datum>>, ResizeArray<ResizeArray<ResizeArray<Datum>>>, TypedArray> with get, set
        abstract xy: Array with get, set
        abstract error_x: ErrorBar with get, set
        abstract error_y: ErrorBar with get, set
        abstract xaxis: string with get, set
        abstract yaxis: string with get, set
        abstract text: U2<string, ResizeArray<string>> with get, set
        abstract line: obj with get, set
        abstract linecolor: Color with get, set
        abstract linewidth: float with get, set
        abstract linedash: Dash with get, set
        abstract lineshape: U6<string, string, string, string, string, string> with get, set
        abstract linesmoothing: float with get, set
        abstract linesimplify: bool with get, set
        abstract marker: obj with get, set
        abstract markersymbol: U2<string, ResizeArray<string>> with get, set
        abstract markercolor: Color with get, set
        abstract markeropacity: U2<float, ResizeArray<float>> with get, set
        abstract markersize: U2<float, ResizeArray<float>> with get, set
        abstract markermaxdisplayed: float with get, set
        abstract markersizeref: float with get, set
        abstract markersizemax: float with get, set
        abstract markersizemin: float with get, set
        abstract markersizemode: U2<string, string> with get, set
        abstract markershowscale: bool with get, set
        abstract markerline: obj with get, set
        abstract markercolorbar: TypeLiteral_03 with get, set
        abstract mode: U8<string, string, string, string, string, string, string, string> with get, set
        abstract hoveron: U2<string, string> with get, set
        abstract hoverinfo: obj with get, set
        abstract hoverlabel: obj with get, set
        abstract hovertemplate: U2<string, ResizeArray<string>> with get, set
        abstract textinfo: obj with get, set
        abstract textposition: obj with get, set
        abstract fill: U7<string, string, string, string, string, string, string> with get, set
        abstract fillcolor: string with get, set
        abstract legendgroup: string with get, set
        abstract name: string with get, set
        abstract stackgroup: string with get, set
        abstract connectgaps: bool with get, set
        abstract visible: U2<bool, string> with get, set
        abstract transforms: ResizeArray<DataTransform> with get, set
        abstract orientation: U2<string, string> with get, set
        abstract width: U2<float, ResizeArray<float>> with get, set
        abstract boxmean: U2<bool, string> with get, set
        abstract colorscale: U2<string, Array> with get, set
        abstract zsmooth: U3<string, string, obj> with get, set
        abstract ygap: float with get, set
        abstract xgap: float with get, set
        abstract transpose: bool with get, set
        abstract autobinx: bool with get, set
        abstract xbins: TypeLiteral_04 with get, set
        abstract values: ResizeArray<Datum> with get, set
        abstract labels: ResizeArray<Datum> with get, set
        abstract hole: float with get, set
        abstract rotation: float with get, set
        abstract theta: ResizeArray<Datum> with get, set
        abstract r: ResizeArray<Datum> with get, set

    /// These interfaces are based on attribute descriptions in
    /// https://github.com/plotly/plotly.js/tree/9d6144304308fc3007f0facf2535d38ea3e9b26c/src/transforms
    type [<AllowNullLiteral>] TransformStyle =
        abstract target: U4<float, string, ResizeArray<float>, ResizeArray<string>> with get, set
        abstract value: obj with get, set

    type [<AllowNullLiteral>] TransformAggregation =
        abstract target: string with get, set
        abstract func: obj option with get, set
        abstract funcmode: U2<string, string> option with get, set
        abstract enabled: bool option with get, set

    type [<AllowNullLiteral>] Transform =
        abstract ``type``: U4<string, string, string, string> with get, set
        abstract enabled: bool with get, set
        abstract target: U4<float, string, ResizeArray<float>, ResizeArray<string>> with get, set
        abstract operation: string with get, set
        abstract aggregations: ResizeArray<TransformAggregation> with get, set
        abstract preservegaps: bool with get, set
        abstract groups: U3<string, ResizeArray<float>, ResizeArray<string>> with get, set
        abstract nameformat: string with get, set
        abstract styles: ResizeArray<TransformStyle> with get, set
        abstract value: obj option with get, set
        abstract order: U2<string, string> with get, set

    type [<AllowNullLiteral>] ColorBar =
        abstract thicknessmode: U2<string, string> with get, set
        abstract thickness: float with get, set
        abstract lenmode: U2<string, string> with get, set
        abstract len: float with get, set
        abstract x: float with get, set
        abstract xanchor: U3<string, string, string> with get, set
        abstract xpad: float with get, set
        abstract y: float with get, set
        abstract yanchor: U3<string, string, string> with get, set
        abstract ypad: float with get, set
        abstract outlinecolor: Color with get, set
        abstract outlinewidth: float with get, set
        abstract bordercolor: Color with get, set
        abstract borderwidth: Color with get, set
        abstract bgcolor: Color with get, set
        abstract tickmode: U3<string, string, string> with get, set
        abstract nticks: float with get, set
        abstract tick0: U2<float, string> with get, set
        abstract dtick: U2<float, string> with get, set
        abstract tickvals: U4<ResizeArray<Datum>, ResizeArray<ResizeArray<Datum>>, ResizeArray<ResizeArray<ResizeArray<Datum>>>, TypedArray> with get, set
        abstract ticktext: U4<ResizeArray<Datum>, ResizeArray<ResizeArray<Datum>>, ResizeArray<ResizeArray<ResizeArray<Datum>>>, TypedArray> with get, set
        abstract ticks: U3<string, string, string> with get, set
        abstract ticklen: float with get, set
        abstract tickwidth: float with get, set
        abstract tickcolor: Color with get, set
        abstract showticklabels: bool with get, set
        abstract tickfont: Font with get, set
        abstract tickangle: float with get, set
        abstract tickformat: string with get, set
        abstract tickformatstops: TypeLiteral_05 with get, set
        abstract tickprefix: string with get, set
        abstract showtickprefix: U4<string, string, string, string> with get, set
        abstract ticksuffix: string with get, set
        abstract showticksuffix: U4<string, string, string, string> with get, set
        abstract separatethousands: bool with get, set
        abstract exponentformat: U6<string, string, string, string, string, string> with get, set
        abstract showexponent: U4<string, string, string, string> with get, set
        abstract title: string with get, set
        abstract titlefont: Font with get, set
        abstract titleside: U3<string, string, string> with get, set
        abstract tickvalssrc: obj option with get, set
        abstract ticktextsrc: obj option with get, set

    /// Any combination of "x", "y", "z", "text", "name" joined with a "+" OR "all" or "none" or "skip".
    /// examples: "x", "y", "x+y", "x+y+z", "all"
    /// default: "all"
    type [<AllowNullLiteral>] PlotMarker =
        abstract symbol: U2<string, ResizeArray<string>> with get, set
        abstract color: U2<Color, ResizeArray<Color>> with get, set
        abstract colors: ResizeArray<Color> with get, set
        abstract colorscale: U3<string, ResizeArray<string>, Array> with get, set
        abstract cauto: bool with get, set
        abstract cmax: float with get, set
        abstract cmin: float with get, set
        abstract autocolorscale: bool with get, set
        abstract reversescale: bool with get, set
        abstract opacity: U2<float, ResizeArray<float>> with get, set
        abstract size: U2<float, ResizeArray<float>> with get, set
        abstract maxdisplayed: float with get, set
        abstract sizeref: float with get, set
        abstract sizemax: float with get, set
        abstract sizemin: float with get, set
        abstract sizemode: U2<string, string> with get, set
        abstract showscale: bool with get, set
        abstract line: obj with get, set
        abstract width: float with get, set
        abstract colorbar: obj with get, set
        abstract gradient: TypeLiteral_06 with get, set

    type ScatterMarker =
        PlotMarker

    type [<AllowNullLiteral>] ScatterMarkerLine =
        abstract width: U2<float, ResizeArray<float>> with get, set
        abstract color: Color with get, set
        abstract colorscale: U2<string, ResizeArray<string>> with get, set
        abstract cauto: bool with get, set
        abstract cmax: float with get, set
        abstract cmin: float with get, set
        abstract autocolorscale: bool with get, set
        abstract reversescale: bool with get, set

    type [<AllowNullLiteral>] ScatterLine =
        abstract color: Color with get, set
        abstract width: float with get, set
        abstract dash: Dash with get, set
        abstract shape: U6<string, string, string, string, string, string> with get, set
        abstract smoothing: float with get, set
        abstract simplify: bool with get, set

    type [<AllowNullLiteral>] Font =
        /// HTML font family - the typeface that will be applied by the web browser.
        /// The web browser will only be able to apply a font if it is available on the system
        /// which it operates. Provide multiple font families, separated by commas, to indicate
        /// the preference in which to apply fonts if they aren't available on the system.
        /// The plotly service (at https://plot.ly or on-premise) generates images on a server,
        /// where only a select number of fonts are installed and supported.
        /// These include *Arial*, *Balto*, *Courier New*, *Droid Sans*, *Droid Serif*,
        /// *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*,
        /// *PT Sans Narrow*, *Raleway*, *Times New Roman*.
        abstract family: string with get, set
        abstract size: float with get, set
        abstract color: Color with get, set

    type [<AllowNullLiteral>] Edits =
        abstract annotationPosition: bool with get, set
        abstract annotationTail: bool with get, set
        abstract annotationText: bool with get, set
        abstract axisTitleText: bool with get, set
        abstract colorbarPosition: bool with get, set
        abstract colorbarTitleText: bool with get, set
        abstract legendPosition: bool with get, set
        abstract legendText: bool with get, set
        abstract shapePosition: bool with get, set
        abstract titleText: bool with get, set

    type [<AllowNullLiteral>] Config =
        /// override the defaults for the toImageButton 
        abstract toImageButtonOptions: obj with get, set
        /// no interactivity, for export or image generation 
        abstract staticPlot: bool with get, set
        /// we can edit titles, move annotations, etc 
        abstract editable: bool with get, set
        abstract edits: obj with get, set
        /// DO autosize once regardless of layout.autosize (use default width or height values otherwise) 
        abstract autosizable: bool with get, set
        /// set the length of the undo/redo queue 
        abstract queueLength: float with get, set
        /// if we DO autosize, do we fill the container or the screen? 
        abstract fillFrame: bool with get, set
        /// if we DO autosize, set the frame margins in percents of plot size 
        abstract frameMargins: float with get, set
        /// mousewheel or two-finger scroll zooms the plot 
        abstract scrollZoom: bool with get, set
        /// double click interaction (false, 'reset', 'autosize' or 'reset+autosize') 
        abstract doubleClick: U4<string, string, string, obj> with get, set
        /// new users see some hints about interactivity 
        abstract showTips: bool with get, set
        /// enable axis pan/zoom drag handles 
        abstract showAxisDragHandles: bool with get, set
        /// enable direct range entry at the pan/zoom drag points (drag handles must be enabled above) 
        abstract showAxisRangeEntryBoxes: bool with get, set
        /// link to open this plot in plotly 
        abstract showLink: bool with get, set
        /// if we show a link, does it contain data or just link to a plotly file? 
        abstract sendData: bool with get, set
        /// text appearing in the sendData link 
        abstract linkText: string with get, set
        /// false or function adding source(s) to linkText <text> 
        abstract showSources: bool with get, set
        /// display the mode bar (true, false, or 'hover') 
        abstract displayModeBar: U2<string, bool> with get, set
        /// remove mode bar button by name (see ./components/modebar/buttons.js for the list of names) 
        abstract modeBarButtonsToRemove: ResizeArray<ModeBarDefaultButtons> with get, set
        /// add mode bar button using config objects (see ./components/modebar/buttons.js for list of arguments) 
        abstract modeBarButtonsToAdd: U2<ResizeArray<ModeBarDefaultButtons>, ResizeArray<ModeBarButton>> with get, set
        /// fully custom mode bar buttons as nested array, where the outer
        /// arrays represents button groups, and the inner arrays have
        /// buttons config objects or names of default buttons
        /// (see ./components/modebar/buttons.js for more info)
        abstract modeBarButtons: U3<ResizeArray<ResizeArray<ModeBarDefaultButtons>>, ResizeArray<ResizeArray<ModeBarButton>>, obj> with get, set
        /// add the plotly logo on the end of the mode bar 
        abstract displaylogo: bool with get, set
        /// increase the pixel ratio for Gl plot images 
        abstract plotGlPixelRatio: float with get, set
        /// function to add the background color to a different container
        /// or 'opaque' to ensure there's white behind it
        abstract setBackground: (unit -> U3<string, string, string>) with get, set
        /// URL to topojson files used in geo charts 
        abstract topojsonURL: string with get, set
        /// Mapbox access token (required to plot mapbox trace types)
        /// If using an Mapbox Atlas server, set this option to '',
        /// so that plotly.js won't attempt to authenticate to the public Mapbox server.
        abstract mapboxAccessToken: string with get, set
        /// Turn all console logging on or off (errors will be thrown)
        /// This should ONLY be set via Plotly.setPlotConfig
        abstract logging: U2<bool, obj> with get, set
        /// Set global transform to be applied to all traces with no specification needed 
        abstract globalTransforms: ResizeArray<obj option> with get, set
        /// Which localization should we use? Should be a string like 'en' or 'en-US' 
        abstract locale: string with get, set
        /// Make the chart responsive to window size 
        abstract responsive: bool with get, set

    type [<AllowNullLiteral>] RangeSlider =
        abstract visible: bool with get, set
        abstract thickness: float with get, set
        abstract range: Datum * Datum with get, set
        abstract borderwidth: float with get, set
        abstract bordercolor: string with get, set
        abstract bgcolor: string with get, set

    type [<AllowNullLiteral>] RangeSelectorButton =
        abstract step: U7<string, string, string, string, string, string, string> with get, set
        abstract stepmode: U2<string, string> with get, set
        abstract count: float with get, set
        abstract label: string with get, set

    type [<AllowNullLiteral>] RangeSelector =
        inherit Label
        abstract buttons: Array with get, set
        abstract visible: bool with get, set
        abstract x: float with get, set
        abstract xanchor: U4<string, string, string, string> with get, set
        abstract y: float with get, set
        abstract yanchor: U4<string, string, string, string> with get, set
        abstract activecolor: string with get, set
        abstract borderwidth: float with get, set

    type [<AllowNullLiteral>] Camera =
        abstract up: obj with get, set
        abstract center: obj with get, set
        abstract eye: obj with get, set

    type [<AllowNullLiteral>] Label =
        /// Sets the background color of all hover labels on graph. 
        abstract bgcolor: string with get, set
        /// Sets the border color of all hover labels on graph. 
        abstract bordercolor: string with get, set
        /// Sets the default hover label font used by all traces on the graph. 
        abstract font: obj with get, set

    type [<AllowNullLiteral>] HoverLabel =
        inherit Label
        /// Sets the horizontal alignment of the text content within hover label box. 
        abstract align: U3<string, string, string> with get, set
        /// Sets the default length (in number of characters) (default 15) of the trace name
        /// in the hover labels for all traces.
        /// -1 shows the whole name regardless of length.
        abstract namelength: float with get, set

    type [<AllowNullLiteral>] Annotations =
        inherit Label
        /// Determines whether or not this annotation is visible. 
        abstract visible: bool with get, set
        /// Sets the text associated with this annotation.
        /// Plotly uses a subset of HTML tags to do things like
        /// newline (<br>), bold (<b></b>), italics (<i></i>),
        /// hyperlinks (<a href='...'></a>). Tags <em>, <sup>, <sub>
        /// <span> are also supported.
        abstract text: string with get, set
        /// Sets the angle at which the `text` is drawn with respect to the horizontal. 
        abstract textangle: string with get, set
        /// Sets an explicit width for the text box. null (default) lets the
        /// text set the box width. Wider text will be clipped.
        /// There is no automatic wrapping; use <br> to start a new line.
        abstract width: float with get, set
        /// Sets an explicit height for the text box. null (default) lets the
        /// text set the box height. Taller text will be clipped.
        abstract height: float with get, set
        /// Sets the opacity of the annotation (text + arrow). 
        abstract opacity: float with get, set
        /// Sets the horizontal alignment of the `text` within the box.
        /// Has an effect only if `text` spans more two or more lines
        /// (i.e. `text` contains one or more <br> HTML tags) or if an
        /// explicit width is set to override the text width.
        abstract align: U3<string, string, string> with get, set
        /// Sets the vertical alignment of the `text` within the box.
        /// Has an effect only if an explicit height is set to override the text height.
        abstract valign: U3<string, string, string> with get, set
        /// Sets the padding (in px) between the `text` and the enclosing border. 
        abstract borderpad: float with get, set
        /// Sets the width (in px) of the border enclosing the annotation `text`. 
        abstract borderwidth: float with get, set
        /// Determines whether or not the annotation is drawn with an arrow.
        /// If *true*, `text` is placed near the arrow's tail.
        /// If *false*, `text` lines up with the `x` and `y` provided.
        abstract showarrow: bool with get, set
        /// Sets the color of the annotation arrow. 
        abstract arrowcolor: string with get, set
        /// Sets the end annotation arrow head style. 
        abstract arrowhead: float with get, set
        /// Sets the start annotation arrow head style. 
        abstract startarrowhead: float with get, set
        /// Sets the annotation arrow head position. 
        abstract arrowside: U2<string, string> with get, set
        /// Sets the size of the end annotation arrow head, relative to `arrowwidth`.
        /// A value of 1 (default) gives a head about 3x as wide as the line.
        abstract arrowsize: float with get, set
        /// Sets the size of the start annotation arrow head, relative to `arrowwidth`.
        /// A value of 1 (default) gives a head about 3x as wide as the line.
        abstract startarrowsize: float with get, set
        /// Sets the width (in px) of annotation arrow line. 
        abstract arrowwidth: float with get, set
        /// Sets a distance, in pixels, to move the end arrowhead away from the
        /// position it is pointing at, for example to point at the edge of
        /// a marker independent of zoom. Note that this shortens the arrow
        /// from the `ax` / `ay` vector, in contrast to `xshift` / `yshift`
        /// which moves everything by this amount.
        abstract standoff: float with get, set
        /// Sets a distance, in pixels, to move the start arrowhead away from the
        /// position it is pointing at, for example to point at the edge of
        /// a marker independent of zoom. Note that this shortens the arrow
        /// from the `ax` / `ay` vector, in contrast to `xshift` / `yshift`
        /// which moves everything by this amount.
        abstract startstandoff: float with get, set
        /// Sets the x component of the arrow tail about the arrow head.
        /// If `axref` is `pixel`, a positive (negative)
        /// component corresponds to an arrow pointing
        /// from right to left (left to right).
        /// If `axref` is an axis, this is an absolute value on that axis,
        /// like `x`, NOT a relative value.
        abstract ax: float with get, set
        /// Sets the y component of the arrow tail about the arrow head.
        /// If `ayref` is `pixel`, a positive (negative)
        /// component corresponds to an arrow pointing
        /// from bottom to top (top to bottom).
        /// If `ayref` is an axis, this is an absolute value on that axis,
        /// like `y`, NOT a relative value.
        abstract ay: float with get, set
        /// Indicates in what terms the tail of the annotation (ax,ay)
        /// is specified. If `pixel`, `ax` is a relative offset in pixels
        /// from `x`. If set to an x axis id (e.g. *x* or *x2*), `ax` is
        /// specified in the same terms as that axis. This is useful
        /// for trendline annotations which should continue to indicate
        /// the correct trend when zoomed.
        abstract axref: string with get, set
        /// Indicates in what terms the tail of the annotation (ax,ay)
        /// is specified. If `pixel`, `ay` is a relative offset in pixels
        /// from `y`. If set to a y axis id (e.g. *y* or *y2*), `ay` is
        /// specified in the same terms as that axis. This is useful
        /// for trendline annotations which should continue to indicate
        /// the correct trend when zoomed.
        abstract ayref: string with get, set
        /// Sets the annotation's x coordinate axis.
        /// If set to an x axis id (e.g. *x* or *x2*), the `x` position refers to an x coordinate
        /// If set to *paper*, the `x` position refers to the distance from
        /// the left side of the plotting area in normalized coordinates
        /// where 0 (1) corresponds to the left (right) side.
        abstract xref: U2<string, string> with get, set
        /// Sets the annotation's x position.
        /// If the axis `type` is *log*, then you must take the log of your desired range.
        /// If the axis `type` is *date*, it should be date strings, like date data,
        /// though Date objects and unix milliseconds will be accepted and converted to strings.
        /// If the axis `type` is *category*, it should be numbers, using the scale where each
        /// category is assigned a serial number from zero in the order it appears.
        abstract x: U2<float, string> with get, set
        /// Sets the text box's horizontal position anchor
        /// This anchor binds the `x` position to the *left*, *center* or *right* of the annotation.
        /// For example, if `x` is set to 1, `xref` to *paper* and `xanchor` to *right* then the
        /// right-most portion of the annotation lines up with the right-most edge of the plotting area.
        /// If *auto*, the anchor is equivalent to *center* for data-referenced annotations or if there
        /// is an arrow, whereas for paper-referenced with no arrow, the anchor picked corresponds to the closest side.
        abstract xanchor: U4<string, string, string, string> with get, set
        /// Shifts the position of the whole annotation and arrow to the
        /// right (positive) or left (negative) by this many pixels.
        abstract xshift: float with get, set
        /// Sets the annotation's y coordinate axis.
        /// If set to an y axis id (e.g. *y* or *y2*), the `y` position refers to an y coordinate
        /// If set to *paper*, the `y` position refers to the distance from
        /// the bottom of the plotting area in normalized coordinates
        /// where 0 (1) corresponds to the bottom (top).
        abstract yref: U2<string, string> with get, set
        /// Sets the annotation's y position.
        /// If the axis `type` is *log*, then you must take the log of your desired range.
        /// If the axis `type` is *date*, it should be date strings, like date data,
        /// though Date objects and unix milliseconds will be accepted and converted to strings.
        /// If the axis `type` is *category*, it should be numbers, using the scale where each
        /// category is assigned a serial number from zero in the order it appears.
        abstract y: U2<float, string> with get, set
        /// Sets the text box's vertical position anchor
        /// This anchor binds the `y` position to the *top*, *middle* or *bottom* of the annotation.
        /// For example, if `y` is set to 1, `yref` to *paper* and `yanchor` to *top* then the
        /// top-most portion of the annotation lines up with the top-most edge of the plotting area.
        /// If *auto*, the anchor is equivalent to *middle* for data-referenced annotations or if
        /// there is an arrow, whereas for paper-referenced with no arrow, the anchor picked
        /// corresponds to the closest side.
        abstract yanchor: U4<string, string, string, string> with get, set
        /// Shifts the position of the whole annotation and arrow up
        /// (positive) or down (negative) by this many pixels.
        abstract yshift: float with get, set
        /// Makes this annotation respond to clicks on the plot.
        /// If you click a data point that exactly matches the `x` and `y` values of this annotation,
        /// and it is hidden (visible: false), it will appear. In *onoff* mode, you must click the same
        /// point again to make it disappear, so if you click multiple points, you can show multiple
        /// annotations. In *onout* mode, a click anywhere else in the plot (on another data point or not)
        /// will hide this annotation. If you need to show/hide this annotation in response to different
        /// `x` or `y` values, you can set `xclick` and/or `yclick`. This is useful for example to label
        /// the side of a bar. To label markers though, `standoff` is preferred over `xclick` and `yclick`.
        abstract clicktoshow: U3<obj, string, string> with get, set
        /// Toggle this annotation when clicking a data point whose `x` value
        /// is `xclick` rather than the annotation's `x` value.
        abstract xclick: obj option with get, set
        /// Toggle this annotation when clicking a data point whose `y` value
        /// is `yclick` rather than the annotation's `y` value.
        abstract yclick: obj option with get, set
        /// Sets text to appear when hovering over this annotation.
        /// If omitted or blank, no hover label will appear.
        abstract hovertext: string with get, set
        abstract hoverlabel: obj with get, set
        /// Determines whether the annotation text box captures mouse move and click events,
        /// or allows those events to pass through to data points in the plot that may be
        /// behind the annotation. By default `captureevents` is *false* unless `hovertext`
        /// is provided. If you use the event `plotly_clickannotation` without `hovertext`
        /// you must explicitly enable `captureevents`.
        abstract captureevents: bool with get, set

    type [<AllowNullLiteral>] Image =
        abstract visible: bool with get, set
        abstract source: string with get, set
        abstract layer: U2<string, string> with get, set
        abstract sizex: float with get, set
        abstract sizey: float with get, set
        abstract sizing: U3<string, string, string> with get, set
        abstract opacity: float with get, set
        abstract x: U2<float, string> with get, set
        abstract y: U2<float, string> with get, set
        abstract xanchor: U3<string, string, string> with get, set
        abstract yanchor: U3<string, string, string> with get, set
        abstract xref: U2<string, string> with get, set
        abstract yref: U2<string, string> with get, set

    type [<AllowNullLiteral>] Scene =
        abstract bgcolor: string with get, set
        abstract camera: obj with get, set
        abstract domain: obj with get, set
        abstract aspectmode: U4<string, string, string, string> with get, set
        abstract aspectratio: obj with get, set
        abstract xaxis: obj with get, set
        abstract yaxis: obj with get, set
        abstract zaxis: obj with get, set
        abstract dragmode: U5<string, string, string, string, obj> with get, set
        abstract hovermode: U2<string, obj> with get, set
        abstract annotations: U2<obj, Array> with get, set
        abstract captureevents: bool with get, set

    type [<AllowNullLiteral>] Domain =
        abstract x: ResizeArray<float> with get, set
        abstract y: ResizeArray<float> with get, set

    type [<AllowNullLiteral>] Frame =
        /// An identifier that specifies the group to which the frame belongs,
        /// used by animate to select a subset of frames.
        abstract group: string with get, set
        /// A label by which to identify the frame
        abstract name: string with get, set
        /// A list of trace indices that identify the respective traces in the
        /// data attribute
        abstract traces: ResizeArray<float> with get, set
        /// The name of the frame into which this frame's properties are merged
        /// before applying. This is used to unify properties and avoid needing
        /// to specify the same values for the same properties in multiple frames.
        abstract baseframe: string with get, set
        /// A list of traces this frame modifies. The format is identical to the
        /// normal trace definition.
        abstract data: ResizeArray<Data> with get, set
        /// Layout properties which this frame modifies. The format is identical
        /// to the normal layout definition.
        abstract layout: obj with get, set

    type [<AllowNullLiteral>] Transition =
        /// Sets the duration of the slider transition
        abstract duration: float with get, set
        /// Sets the easing function of the slider transition
        abstract easing: obj with get, set

    type [<AllowNullLiteral>] SliderStep =
        /// Determines whether or not this step is included in the slider.
        abstract visible: bool with get, set
        /// Sets the Plotly method to be called when the slider value is changed.
        /// If the `skip` method is used, the API slider will function as normal
        /// but will perform no API calls and will not bind automatically to state
        /// updates. This may be used to create a component interface and attach to
        /// slider events manually via JavaScript.
        abstract ``method``: U5<string, string, string, string, string> with get, set
        /// Sets the arguments values to be passed to the Plotly
        /// method set in `method` on slide.
        abstract args: ResizeArray<obj option> with get, set
        /// Sets the text label to appear on the slider
        abstract label: string with get, set
        /// Sets the value of the slider step, used to refer to the step programatically.
        /// Defaults to the slider label if not provided.
        abstract value: string with get, set
        /// When true, the API method is executed. When false, all other behaviors are the same
        /// and command execution is skipped. This may be useful when hooking into, for example,
        /// the `plotly_sliderchange` method and executing the API command manually without losing
        /// the benefit of the slider automatically binding to the state of the plot through the
        /// specification of `method` and `args`.
        abstract execute: bool with get, set

    type [<AllowNullLiteral>] Padding =
        /// The amount of padding (in px) along the top of the component.
        abstract t: float with get, set
        /// The amount of padding (in px) on the right side of the component.
        abstract r: float with get, set
        /// The amount of padding (in px) along the bottom of the component.
        abstract b: float with get, set
        /// The amount of padding (in px) on the left side of the component.
        abstract l: float with get, set
        abstract editType: string with get, set

    type [<AllowNullLiteral>] Slider =
        /// Determines whether or not the slider is visible.
        abstract visible: bool with get, set
        /// Determines which button (by index starting from 0) is
        /// considered active.
        abstract active: float with get, set
        abstract steps: Array with get, set
        /// Determines whether this slider length
        /// is set in units of plot *fraction* or in *pixels.
        /// Use `len` to set the value.
        abstract lenmode: U2<string, string> with get, set
        /// Sets the length of the slider
        /// This measure excludes the padding of both ends.
        /// That is, the slider's length is this length minus the
        /// padding on both ends.
        abstract len: float with get, set
        /// Sets the x position (in normalized coordinates) of the slider.
        abstract x: float with get, set
        /// Sets the y position (in normalized coordinates) of the slider.
        abstract y: float with get, set
        /// Set the padding of the slider component along each side.
        abstract pad: obj with get, set
        /// Sets the slider's horizontal position anchor.
        /// This anchor binds the `x` position to the *left*, *center*
        /// or *right* of the range selector.
        abstract xanchor: U4<string, string, string, string> with get, set
        /// Sets the slider's vertical position anchor
        /// This anchor binds the `y` position to the *top*, *middle*
        /// or *bottom* of the range selector.
        abstract yanchor: U4<string, string, string, string> with get, set
        abstract transition: Transition with get, set
        abstract currentvalue: TypeLiteral_07 with get, set
        /// Sets the font of the slider step labels.
        abstract font: Font with get, set
        /// Sets the background color of the slider grip
        /// while dragging.
        abstract activebgcolor: Color with get, set
        /// Sets the background color of the slider.
        abstract bgcolor: Color with get, set
        /// Sets the color of the border enclosing the slider.
        abstract bordercolor: Color with get, set
        /// Sets the width (in px) of the border enclosing the slider.
        abstract borderwidth: float with get, set
        /// Sets the length in pixels of step tick marks
        abstract ticklen: float with get, set
        /// Sets the color of the border enclosing the slider.
        abstract tickcolor: Color with get, set
        /// Sets the tick width (in px).
        abstract tickwidth: float with get, set
        /// Sets the length in pixels of minor step tick marks
        abstract minorticklen: float with get, set

    type [<AllowNullLiteral>] TypeLiteral_03 =
        interface end

    type [<AllowNullLiteral>] TypeLiteral_06 =
        abstract ``type``: U4<string, string, string, string> with get, set
        abstract color: Color with get, set
        abstract typesrc: obj option with get, set
        abstract colorsrc: obj option with get, set

    type [<AllowNullLiteral>] TypeLiteral_05 =
        abstract dtickrange: ResizeArray<obj option> with get, set
        abstract value: string with get, set

    type [<AllowNullLiteral>] TypeLiteral_01 =
        abstract duration: float with get, set
        abstract redraw: bool with get, set

    type [<AllowNullLiteral>] TypeLiteral_02 =
        abstract frame: TypeLiteral_01 with get, set
        abstract transition: Transition with get, set

    type [<AllowNullLiteral>] TypeLiteral_04 =
        abstract start: U2<float, string> with get, set
        abstract ``end``: U2<float, string> with get, set
        abstract size: U2<float, string> with get, set

    type [<AllowNullLiteral>] TypeLiteral_07 =
        /// Shows the currently-selected value above the slider.
        abstract visible: bool with get, set
        /// The alignment of the value readout relative to the length of the slider.
        abstract xanchor: U3<string, string, string> with get, set
        /// The amount of space, in pixels, between the current value label
        /// and the slider.
        abstract offset: float with get, set
        /// When currentvalue.visible is true, this sets the prefix of the label.
        abstract prefix: string with get, set
        /// When currentvalue.visible is true, this sets the suffix of the label.
        abstract suffix: string with get, set
        /// Sets the font of the current value label text.
        abstract font: obj with get, set
