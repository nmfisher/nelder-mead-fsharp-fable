namespace rec Browser.Types

open Fable.Core

type [<AllowNullLiteral>] SVGAElement =
    inherit SVGElement
    inherit SVGStylable
    inherit SVGTransformable
    inherit SVGTests
    inherit SVGLangSpace
    inherit SVGExternalResourcesRequired
    inherit SVGURIReference
    abstract target: SVGAnimatedString with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGAElementType =
    abstract prototype: SVGAElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGAElement

and [<AllowNullLiteral>] SVGAngle =
    abstract unitType: float with get, set
    abstract value: float with get, set
    abstract valueAsString: string with get, set
    abstract valueInSpecifiedUnits: float with get, set
    abstract SVG_ANGLETYPE_DEG: float with get, set
    abstract SVG_ANGLETYPE_GRAD: float with get, set
    abstract SVG_ANGLETYPE_RAD: float with get, set
    abstract SVG_ANGLETYPE_UNKNOWN: float with get, set
    abstract SVG_ANGLETYPE_UNSPECIFIED: float with get, set
    abstract convertToSpecifiedUnits: unitType: float -> unit
    abstract newValueSpecifiedUnits: unitType: float * valueInSpecifiedUnits: float -> unit

and [<AllowNullLiteral>] SVGAngleType =
    abstract prototype: SVGAngle with get, set
    abstract SVG_ANGLETYPE_DEG: float with get, set
    abstract SVG_ANGLETYPE_GRAD: float with get, set
    abstract SVG_ANGLETYPE_RAD: float with get, set
    abstract SVG_ANGLETYPE_UNKNOWN: float with get, set
    abstract SVG_ANGLETYPE_UNSPECIFIED: float with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGAngle

and [<AllowNullLiteral>] SVGAnimatedAngle =
    abstract animVal: SVGAngle with get, set
    abstract baseVal: SVGAngle with get, set

and [<AllowNullLiteral>] SVGAnimatedAngleType =
    abstract prototype: SVGAnimatedAngle with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGAnimatedAngle

and [<AllowNullLiteral>] SVGAnimatedBoolean =
    abstract animVal: bool with get, set
    abstract baseVal: bool with get, set

and [<AllowNullLiteral>] SVGAnimatedBooleanType =
    abstract prototype: SVGAnimatedBoolean with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGAnimatedBoolean

and [<AllowNullLiteral>] SVGAnimatedEnumeration =
    abstract animVal: float with get, set
    abstract baseVal: float with get, set

and [<AllowNullLiteral>] SVGAnimatedEnumerationType =
    abstract prototype: SVGAnimatedEnumeration with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGAnimatedEnumeration

and [<AllowNullLiteral>] SVGAnimatedInteger =
    abstract animVal: float with get, set
    abstract baseVal: float with get, set

and [<AllowNullLiteral>] SVGAnimatedIntegerType =
    abstract prototype: SVGAnimatedInteger with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGAnimatedInteger

and [<AllowNullLiteral>] SVGAnimatedLength =
    abstract animVal: SVGLength with get, set
    abstract baseVal: SVGLength with get, set

and [<AllowNullLiteral>] SVGAnimatedLengthType =
    abstract prototype: SVGAnimatedLength with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGAnimatedLength

and [<AllowNullLiteral>] SVGAnimatedLengthList =
    abstract animVal: SVGLengthList with get, set
    abstract baseVal: SVGLengthList with get, set

and [<AllowNullLiteral>] SVGAnimatedLengthListType =
    abstract prototype: SVGAnimatedLengthList with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGAnimatedLengthList

and [<AllowNullLiteral>] SVGAnimatedNumber =
    abstract animVal: float with get, set
    abstract baseVal: float with get, set

and [<AllowNullLiteral>] SVGAnimatedNumberType =
    abstract prototype: SVGAnimatedNumber with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGAnimatedNumber

and [<AllowNullLiteral>] SVGAnimatedNumberList =
    abstract animVal: SVGNumberList with get, set
    abstract baseVal: SVGNumberList with get, set

and [<AllowNullLiteral>] SVGAnimatedNumberListType =
    abstract prototype: SVGAnimatedNumberList with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGAnimatedNumberList

and [<AllowNullLiteral>] SVGAnimatedPreserveAspectRatio =
    abstract animVal: SVGPreserveAspectRatio with get, set
    abstract baseVal: SVGPreserveAspectRatio with get, set

and [<AllowNullLiteral>] SVGAnimatedPreserveAspectRatioType =
    abstract prototype: SVGAnimatedPreserveAspectRatio with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGAnimatedPreserveAspectRatio

and [<AllowNullLiteral>] SVGAnimatedRect =
    abstract animVal: SVGRect with get, set
    abstract baseVal: SVGRect with get, set

and [<AllowNullLiteral>] SVGAnimatedRectType =
    abstract prototype: SVGAnimatedRect with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGAnimatedRect

and [<AllowNullLiteral>] SVGAnimatedString =
    abstract animVal: string with get, set
    abstract baseVal: string with get, set

and [<AllowNullLiteral>] SVGAnimatedStringType =
    abstract prototype: SVGAnimatedString with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGAnimatedString

and [<AllowNullLiteral>] SVGAnimatedTransformList =
    abstract animVal: SVGTransformList with get, set
    abstract baseVal: SVGTransformList with get, set

and [<AllowNullLiteral>] SVGAnimatedTransformListType =
    abstract prototype: SVGAnimatedTransformList with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGAnimatedTransformList

and [<AllowNullLiteral>] SVGCircleElement =
    inherit SVGElement
    inherit SVGStylable
    inherit SVGTransformable
    inherit SVGTests
    inherit SVGLangSpace
    inherit SVGExternalResourcesRequired
    abstract cx: SVGAnimatedLength with get, set
    abstract cy: SVGAnimatedLength with get, set
    abstract r: SVGAnimatedLength with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGCircleElementType =
    abstract prototype: SVGCircleElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGCircleElement

and [<AllowNullLiteral>] SVGClipPathElement =
    inherit SVGElement
    inherit SVGStylable
    inherit SVGTransformable
    inherit SVGTests
    inherit SVGLangSpace
    inherit SVGExternalResourcesRequired
    inherit SVGUnitTypes
    abstract clipPathUnits: SVGAnimatedEnumeration with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGClipPathElementType =
    abstract prototype: SVGClipPathElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGClipPathElement

and [<AllowNullLiteral>] SVGComponentTransferFunctionElement =
    inherit SVGElement
    abstract amplitude: SVGAnimatedNumber with get, set
    abstract exponent: SVGAnimatedNumber with get, set
    abstract intercept: SVGAnimatedNumber with get, set
    abstract offset: SVGAnimatedNumber with get, set
    abstract slope: SVGAnimatedNumber with get, set
    abstract tableValues: SVGAnimatedNumberList with get, set
    abstract ``type``: SVGAnimatedEnumeration with get, set
    abstract SVG_FECOMPONENTTRANSFER_TYPE_DISCRETE: float with get, set
    abstract SVG_FECOMPONENTTRANSFER_TYPE_GAMMA: float with get, set
    abstract SVG_FECOMPONENTTRANSFER_TYPE_IDENTITY: float with get, set
    abstract SVG_FECOMPONENTTRANSFER_TYPE_LINEAR: float with get, set
    abstract SVG_FECOMPONENTTRANSFER_TYPE_TABLE: float with get, set
    abstract SVG_FECOMPONENTTRANSFER_TYPE_UNKNOWN: float with get, set

and [<AllowNullLiteral>] SVGComponentTransferFunctionElementType =
    abstract prototype: SVGComponentTransferFunctionElement with get, set
    abstract SVG_FECOMPONENTTRANSFER_TYPE_DISCRETE: float with get, set
    abstract SVG_FECOMPONENTTRANSFER_TYPE_GAMMA: float with get, set
    abstract SVG_FECOMPONENTTRANSFER_TYPE_IDENTITY: float with get, set
    abstract SVG_FECOMPONENTTRANSFER_TYPE_LINEAR: float with get, set
    abstract SVG_FECOMPONENTTRANSFER_TYPE_TABLE: float with get, set
    abstract SVG_FECOMPONENTTRANSFER_TYPE_UNKNOWN: float with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGComponentTransferFunctionElement

and [<AllowNullLiteral>] SVGDefsElement =
    inherit SVGElement
    inherit SVGStylable
    inherit SVGTransformable
    inherit SVGTests
    inherit SVGLangSpace
    inherit SVGExternalResourcesRequired
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGDefsElementType =
    abstract prototype: SVGDefsElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGDefsElement

and [<AllowNullLiteral>] SVGDescElement =
    inherit SVGElement
    inherit SVGStylable
    inherit SVGLangSpace
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGDescElementType =
    abstract prototype: SVGDescElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGDescElement

and [<AllowNullLiteral>] SVGElement =
    inherit Element
    abstract id: string with get, set
    abstract onclick: (MouseEvent -> 'Out) with get, set
    abstract ondblclick: (MouseEvent -> 'Out) with get, set
    abstract onfocusin: (FocusEvent -> 'Out) with get, set
    abstract onfocusout: (FocusEvent -> 'Out) with get, set
    abstract onload: (Event -> 'Out) with get, set
    abstract onmousedown: (MouseEvent -> 'Out) with get, set
    abstract onmousemove: (MouseEvent -> 'Out) with get, set
    abstract onmouseout: (MouseEvent -> 'Out) with get, set
    abstract onmouseover: (MouseEvent -> 'Out) with get, set
    abstract onmouseup: (MouseEvent -> 'Out) with get, set
    abstract ownerSVGElement: SVGSVGElement with get, set
    abstract viewportElement: SVGElement with get, set
    abstract xmlbase: string with get, set
    abstract className: obj with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGElementType =
    abstract prototype: SVGElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGElement

and [<AllowNullLiteral>] SVGElementInstance =
    inherit EventTarget
    abstract childNodes: SVGElementInstanceList with get, set
    abstract correspondingElement: SVGElement with get, set
    abstract correspondingUseElement: SVGUseElement with get, set
    abstract firstChild: SVGElementInstance with get, set
    abstract lastChild: SVGElementInstance with get, set
    abstract nextSibling: SVGElementInstance with get, set
    abstract parentNode: SVGElementInstance with get, set
    abstract previousSibling: SVGElementInstance with get, set

and [<AllowNullLiteral>] SVGElementInstanceType =
    abstract prototype: SVGElementInstance with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGElementInstance

and [<AllowNullLiteral>] SVGElementInstanceList =
    abstract length: float with get, set
    abstract item: index: float -> SVGElementInstance

and [<AllowNullLiteral>] SVGElementInstanceListType =
    abstract prototype: SVGElementInstanceList with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGElementInstanceList

and [<AllowNullLiteral>] SVGEllipseElement =
    inherit SVGElement
    inherit SVGStylable
    inherit SVGTransformable
    inherit SVGTests
    inherit SVGLangSpace
    inherit SVGExternalResourcesRequired
    abstract cx: SVGAnimatedLength with get, set
    abstract cy: SVGAnimatedLength with get, set
    abstract rx: SVGAnimatedLength with get, set
    abstract ry: SVGAnimatedLength with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGEllipseElementType =
    abstract prototype: SVGEllipseElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGEllipseElement

and [<AllowNullLiteral>] SVGFEBlendElement =
    inherit SVGElement
    inherit SVGFilterPrimitiveStandardAttributes
    abstract in1: SVGAnimatedString with get, set
    abstract in2: SVGAnimatedString with get, set
    abstract mode: SVGAnimatedEnumeration with get, set
    abstract SVG_FEBLEND_MODE_COLOR: float with get, set
    abstract SVG_FEBLEND_MODE_COLOR_BURN: float with get, set
    abstract SVG_FEBLEND_MODE_COLOR_DODGE: float with get, set
    abstract SVG_FEBLEND_MODE_DARKEN: float with get, set
    abstract SVG_FEBLEND_MODE_DIFFERENCE: float with get, set
    abstract SVG_FEBLEND_MODE_EXCLUSION: float with get, set
    abstract SVG_FEBLEND_MODE_HARD_LIGHT: float with get, set
    abstract SVG_FEBLEND_MODE_HUE: float with get, set
    abstract SVG_FEBLEND_MODE_LIGHTEN: float with get, set
    abstract SVG_FEBLEND_MODE_LUMINOSITY: float with get, set
    abstract SVG_FEBLEND_MODE_MULTIPLY: float with get, set
    abstract SVG_FEBLEND_MODE_NORMAL: float with get, set
    abstract SVG_FEBLEND_MODE_OVERLAY: float with get, set
    abstract SVG_FEBLEND_MODE_SATURATION: float with get, set
    abstract SVG_FEBLEND_MODE_SCREEN: float with get, set
    abstract SVG_FEBLEND_MODE_SOFT_LIGHT: float with get, set
    abstract SVG_FEBLEND_MODE_UNKNOWN: float with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGFEBlendElementType =
    abstract prototype: SVGFEBlendElement with get, set
    abstract SVG_FEBLEND_MODE_COLOR: float with get, set
    abstract SVG_FEBLEND_MODE_COLOR_BURN: float with get, set
    abstract SVG_FEBLEND_MODE_COLOR_DODGE: float with get, set
    abstract SVG_FEBLEND_MODE_DARKEN: float with get, set
    abstract SVG_FEBLEND_MODE_DIFFERENCE: float with get, set
    abstract SVG_FEBLEND_MODE_EXCLUSION: float with get, set
    abstract SVG_FEBLEND_MODE_HARD_LIGHT: float with get, set
    abstract SVG_FEBLEND_MODE_HUE: float with get, set
    abstract SVG_FEBLEND_MODE_LIGHTEN: float with get, set
    abstract SVG_FEBLEND_MODE_LUMINOSITY: float with get, set
    abstract SVG_FEBLEND_MODE_MULTIPLY: float with get, set
    abstract SVG_FEBLEND_MODE_NORMAL: float with get, set
    abstract SVG_FEBLEND_MODE_OVERLAY: float with get, set
    abstract SVG_FEBLEND_MODE_SATURATION: float with get, set
    abstract SVG_FEBLEND_MODE_SCREEN: float with get, set
    abstract SVG_FEBLEND_MODE_SOFT_LIGHT: float with get, set
    abstract SVG_FEBLEND_MODE_UNKNOWN: float with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFEBlendElement

and [<AllowNullLiteral>] SVGFEColorMatrixElement =
    inherit SVGElement
    inherit SVGFilterPrimitiveStandardAttributes
    abstract in1: SVGAnimatedString with get, set
    abstract ``type``: SVGAnimatedEnumeration with get, set
    abstract values: SVGAnimatedNumberList with get, set
    abstract SVG_FECOLORMATRIX_TYPE_HUEROTATE: float with get, set
    abstract SVG_FECOLORMATRIX_TYPE_LUMINANCETOALPHA: float with get, set
    abstract SVG_FECOLORMATRIX_TYPE_MATRIX: float with get, set
    abstract SVG_FECOLORMATRIX_TYPE_SATURATE: float with get, set
    abstract SVG_FECOLORMATRIX_TYPE_UNKNOWN: float with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGFEColorMatrixElementType =
    abstract prototype: SVGFEColorMatrixElement with get, set
    abstract SVG_FECOLORMATRIX_TYPE_HUEROTATE: float with get, set
    abstract SVG_FECOLORMATRIX_TYPE_LUMINANCETOALPHA: float with get, set
    abstract SVG_FECOLORMATRIX_TYPE_MATRIX: float with get, set
    abstract SVG_FECOLORMATRIX_TYPE_SATURATE: float with get, set
    abstract SVG_FECOLORMATRIX_TYPE_UNKNOWN: float with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFEColorMatrixElement

and [<AllowNullLiteral>] SVGFEComponentTransferElement =
    inherit SVGElement
    inherit SVGFilterPrimitiveStandardAttributes
    abstract in1: SVGAnimatedString with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGFEComponentTransferElementType =
    abstract prototype: SVGFEComponentTransferElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFEComponentTransferElement

and [<AllowNullLiteral>] SVGFECompositeElement =
    inherit SVGElement
    inherit SVGFilterPrimitiveStandardAttributes
    abstract in1: SVGAnimatedString with get, set
    abstract in2: SVGAnimatedString with get, set
    abstract k1: SVGAnimatedNumber with get, set
    abstract k2: SVGAnimatedNumber with get, set
    abstract k3: SVGAnimatedNumber with get, set
    abstract k4: SVGAnimatedNumber with get, set
    abstract operator: SVGAnimatedEnumeration with get, set
    abstract SVG_FECOMPOSITE_OPERATOR_ARITHMETIC: float with get, set
    abstract SVG_FECOMPOSITE_OPERATOR_ATOP: float with get, set
    abstract SVG_FECOMPOSITE_OPERATOR_IN: float with get, set
    abstract SVG_FECOMPOSITE_OPERATOR_OUT: float with get, set
    abstract SVG_FECOMPOSITE_OPERATOR_OVER: float with get, set
    abstract SVG_FECOMPOSITE_OPERATOR_UNKNOWN: float with get, set
    abstract SVG_FECOMPOSITE_OPERATOR_XOR: float with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGFECompositeElementType =
    abstract prototype: SVGFECompositeElement with get, set
    abstract SVG_FECOMPOSITE_OPERATOR_ARITHMETIC: float with get, set
    abstract SVG_FECOMPOSITE_OPERATOR_ATOP: float with get, set
    abstract SVG_FECOMPOSITE_OPERATOR_IN: float with get, set
    abstract SVG_FECOMPOSITE_OPERATOR_OUT: float with get, set
    abstract SVG_FECOMPOSITE_OPERATOR_OVER: float with get, set
    abstract SVG_FECOMPOSITE_OPERATOR_UNKNOWN: float with get, set
    abstract SVG_FECOMPOSITE_OPERATOR_XOR: float with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFECompositeElement

and [<AllowNullLiteral>] SVGFEConvolveMatrixElement =
    inherit SVGElement
    inherit SVGFilterPrimitiveStandardAttributes
    abstract bias: SVGAnimatedNumber with get, set
    abstract divisor: SVGAnimatedNumber with get, set
    abstract edgeMode: SVGAnimatedEnumeration with get, set
    abstract in1: SVGAnimatedString with get, set
    abstract kernelMatrix: SVGAnimatedNumberList with get, set
    abstract kernelUnitLengthX: SVGAnimatedNumber with get, set
    abstract kernelUnitLengthY: SVGAnimatedNumber with get, set
    abstract orderX: SVGAnimatedInteger with get, set
    abstract orderY: SVGAnimatedInteger with get, set
    abstract preserveAlpha: SVGAnimatedBoolean with get, set
    abstract targetX: SVGAnimatedInteger with get, set
    abstract targetY: SVGAnimatedInteger with get, set
    abstract SVG_EDGEMODE_DUPLICATE: float with get, set
    abstract SVG_EDGEMODE_NONE: float with get, set
    abstract SVG_EDGEMODE_UNKNOWN: float with get, set
    abstract SVG_EDGEMODE_WRAP: float with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGFEConvolveMatrixElementType =
    abstract prototype: SVGFEConvolveMatrixElement with get, set
    abstract SVG_EDGEMODE_DUPLICATE: float with get, set
    abstract SVG_EDGEMODE_NONE: float with get, set
    abstract SVG_EDGEMODE_UNKNOWN: float with get, set
    abstract SVG_EDGEMODE_WRAP: float with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFEConvolveMatrixElement

and [<AllowNullLiteral>] SVGFEDiffuseLightingElement =
    inherit SVGElement
    inherit SVGFilterPrimitiveStandardAttributes
    abstract diffuseConstant: SVGAnimatedNumber with get, set
    abstract in1: SVGAnimatedString with get, set
    abstract kernelUnitLengthX: SVGAnimatedNumber with get, set
    abstract kernelUnitLengthY: SVGAnimatedNumber with get, set
    abstract surfaceScale: SVGAnimatedNumber with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGFEDiffuseLightingElementType =
    abstract prototype: SVGFEDiffuseLightingElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFEDiffuseLightingElement

and [<AllowNullLiteral>] SVGFEDisplacementMapElement =
    inherit SVGElement
    inherit SVGFilterPrimitiveStandardAttributes
    abstract in1: SVGAnimatedString with get, set
    abstract in2: SVGAnimatedString with get, set
    abstract scale: SVGAnimatedNumber with get, set
    abstract xChannelSelector: SVGAnimatedEnumeration with get, set
    abstract yChannelSelector: SVGAnimatedEnumeration with get, set
    abstract SVG_CHANNEL_A: float with get, set
    abstract SVG_CHANNEL_B: float with get, set
    abstract SVG_CHANNEL_G: float with get, set
    abstract SVG_CHANNEL_R: float with get, set
    abstract SVG_CHANNEL_UNKNOWN: float with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGFEDisplacementMapElementType =
    abstract prototype: SVGFEDisplacementMapElement with get, set
    abstract SVG_CHANNEL_A: float with get, set
    abstract SVG_CHANNEL_B: float with get, set
    abstract SVG_CHANNEL_G: float with get, set
    abstract SVG_CHANNEL_R: float with get, set
    abstract SVG_CHANNEL_UNKNOWN: float with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFEDisplacementMapElement

and [<AllowNullLiteral>] SVGFEDistantLightElement =
    inherit SVGElement
    abstract azimuth: SVGAnimatedNumber with get, set
    abstract elevation: SVGAnimatedNumber with get, set

and [<AllowNullLiteral>] SVGFEDistantLightElementType =
    abstract prototype: SVGFEDistantLightElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFEDistantLightElement

and [<AllowNullLiteral>] SVGFEFloodElement =
    inherit SVGElement
    inherit SVGFilterPrimitiveStandardAttributes
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGFEFloodElementType =
    abstract prototype: SVGFEFloodElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFEFloodElement

and [<AllowNullLiteral>] SVGFEFuncAElement =
    inherit SVGComponentTransferFunctionElement


and [<AllowNullLiteral>] SVGFEFuncAElementType =
    abstract prototype: SVGFEFuncAElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFEFuncAElement

and [<AllowNullLiteral>] SVGFEFuncBElement =
    inherit SVGComponentTransferFunctionElement


and [<AllowNullLiteral>] SVGFEFuncBElementType =
    abstract prototype: SVGFEFuncBElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFEFuncBElement

and [<AllowNullLiteral>] SVGFEFuncGElement =
    inherit SVGComponentTransferFunctionElement


and [<AllowNullLiteral>] SVGFEFuncGElementType =
    abstract prototype: SVGFEFuncGElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFEFuncGElement

and [<AllowNullLiteral>] SVGFEFuncRElement =
    inherit SVGComponentTransferFunctionElement


and [<AllowNullLiteral>] SVGFEFuncRElementType =
    abstract prototype: SVGFEFuncRElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFEFuncRElement

and [<AllowNullLiteral>] SVGFEGaussianBlurElement =
    inherit SVGElement
    inherit SVGFilterPrimitiveStandardAttributes
    abstract in1: SVGAnimatedString with get, set
    abstract stdDeviationX: SVGAnimatedNumber with get, set
    abstract stdDeviationY: SVGAnimatedNumber with get, set
    abstract setStdDeviation: stdDeviationX: float * stdDeviationY: float -> unit
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGFEGaussianBlurElementType =
    abstract prototype: SVGFEGaussianBlurElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFEGaussianBlurElement

and [<AllowNullLiteral>] SVGFEImageElement =
    inherit SVGElement
    inherit SVGFilterPrimitiveStandardAttributes
    inherit SVGLangSpace
    inherit SVGURIReference
    inherit SVGExternalResourcesRequired
    abstract preserveAspectRatio: SVGAnimatedPreserveAspectRatio with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGFEImageElementType =
    abstract prototype: SVGFEImageElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFEImageElement

and [<AllowNullLiteral>] SVGFEMergeElement =
    inherit SVGElement
    inherit SVGFilterPrimitiveStandardAttributes
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGFEMergeElementType =
    abstract prototype: SVGFEMergeElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFEMergeElement

and [<AllowNullLiteral>] SVGFEMergeNodeElement =
    inherit SVGElement
    abstract in1: SVGAnimatedString with get, set

and [<AllowNullLiteral>] SVGFEMergeNodeElementType =
    abstract prototype: SVGFEMergeNodeElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFEMergeNodeElement

and [<AllowNullLiteral>] SVGFEMorphologyElement =
    inherit SVGElement
    inherit SVGFilterPrimitiveStandardAttributes
    abstract in1: SVGAnimatedString with get, set
    abstract operator: SVGAnimatedEnumeration with get, set
    abstract radiusX: SVGAnimatedNumber with get, set
    abstract radiusY: SVGAnimatedNumber with get, set
    abstract SVG_MORPHOLOGY_OPERATOR_DILATE: float with get, set
    abstract SVG_MORPHOLOGY_OPERATOR_ERODE: float with get, set
    abstract SVG_MORPHOLOGY_OPERATOR_UNKNOWN: float with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGFEMorphologyElementType =
    abstract prototype: SVGFEMorphologyElement with get, set
    abstract SVG_MORPHOLOGY_OPERATOR_DILATE: float with get, set
    abstract SVG_MORPHOLOGY_OPERATOR_ERODE: float with get, set
    abstract SVG_MORPHOLOGY_OPERATOR_UNKNOWN: float with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFEMorphologyElement

and [<AllowNullLiteral>] SVGFEOffsetElement =
    inherit SVGElement
    inherit SVGFilterPrimitiveStandardAttributes
    abstract dx: SVGAnimatedNumber with get, set
    abstract dy: SVGAnimatedNumber with get, set
    abstract in1: SVGAnimatedString with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGFEOffsetElementType =
    abstract prototype: SVGFEOffsetElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFEOffsetElement

and [<AllowNullLiteral>] SVGFEPointLightElement =
    inherit SVGElement
    abstract x: SVGAnimatedNumber with get, set
    abstract y: SVGAnimatedNumber with get, set
    abstract z: SVGAnimatedNumber with get, set

and [<AllowNullLiteral>] SVGFEPointLightElementType =
    abstract prototype: SVGFEPointLightElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFEPointLightElement

and [<AllowNullLiteral>] SVGFESpecularLightingElement =
    inherit SVGElement
    inherit SVGFilterPrimitiveStandardAttributes
    abstract in1: SVGAnimatedString with get, set
    abstract kernelUnitLengthX: SVGAnimatedNumber with get, set
    abstract kernelUnitLengthY: SVGAnimatedNumber with get, set
    abstract specularConstant: SVGAnimatedNumber with get, set
    abstract specularExponent: SVGAnimatedNumber with get, set
    abstract surfaceScale: SVGAnimatedNumber with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGFESpecularLightingElementType =
    abstract prototype: SVGFESpecularLightingElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFESpecularLightingElement

and [<AllowNullLiteral>] SVGFESpotLightElement =
    inherit SVGElement
    abstract limitingConeAngle: SVGAnimatedNumber with get, set
    abstract pointsAtX: SVGAnimatedNumber with get, set
    abstract pointsAtY: SVGAnimatedNumber with get, set
    abstract pointsAtZ: SVGAnimatedNumber with get, set
    abstract specularExponent: SVGAnimatedNumber with get, set
    abstract x: SVGAnimatedNumber with get, set
    abstract y: SVGAnimatedNumber with get, set
    abstract z: SVGAnimatedNumber with get, set

and [<AllowNullLiteral>] SVGFESpotLightElementType =
    abstract prototype: SVGFESpotLightElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFESpotLightElement

and [<AllowNullLiteral>] SVGFETileElement =
    inherit SVGElement
    inherit SVGFilterPrimitiveStandardAttributes
    abstract in1: SVGAnimatedString with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGFETileElementType =
    abstract prototype: SVGFETileElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFETileElement

and [<AllowNullLiteral>] SVGFETurbulenceElement =
    inherit SVGElement
    inherit SVGFilterPrimitiveStandardAttributes
    abstract baseFrequencyX: SVGAnimatedNumber with get, set
    abstract baseFrequencyY: SVGAnimatedNumber with get, set
    abstract numOctaves: SVGAnimatedInteger with get, set
    abstract seed: SVGAnimatedNumber with get, set
    abstract stitchTiles: SVGAnimatedEnumeration with get, set
    abstract ``type``: SVGAnimatedEnumeration with get, set
    abstract SVG_STITCHTYPE_NOSTITCH: float with get, set
    abstract SVG_STITCHTYPE_STITCH: float with get, set
    abstract SVG_STITCHTYPE_UNKNOWN: float with get, set
    abstract SVG_TURBULENCE_TYPE_FRACTALNOISE: float with get, set
    abstract SVG_TURBULENCE_TYPE_TURBULENCE: float with get, set
    abstract SVG_TURBULENCE_TYPE_UNKNOWN: float with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGFETurbulenceElementType =
    abstract prototype: SVGFETurbulenceElement with get, set
    abstract SVG_STITCHTYPE_NOSTITCH: float with get, set
    abstract SVG_STITCHTYPE_STITCH: float with get, set
    abstract SVG_STITCHTYPE_UNKNOWN: float with get, set
    abstract SVG_TURBULENCE_TYPE_FRACTALNOISE: float with get, set
    abstract SVG_TURBULENCE_TYPE_TURBULENCE: float with get, set
    abstract SVG_TURBULENCE_TYPE_UNKNOWN: float with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFETurbulenceElement

and [<AllowNullLiteral>] SVGFilterElement =
    inherit SVGElement
    inherit SVGUnitTypes
    inherit SVGStylable
    inherit SVGLangSpace
    inherit SVGURIReference
    inherit SVGExternalResourcesRequired
    abstract filterResX: SVGAnimatedInteger with get, set
    abstract filterResY: SVGAnimatedInteger with get, set
    abstract filterUnits: SVGAnimatedEnumeration with get, set
    abstract height: SVGAnimatedLength with get, set
    abstract primitiveUnits: SVGAnimatedEnumeration with get, set
    abstract width: SVGAnimatedLength with get, set
    abstract x: SVGAnimatedLength with get, set
    abstract y: SVGAnimatedLength with get, set
    abstract setFilterRes: filterResX: float * filterResY: float -> unit
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGFilterElementType =
    abstract prototype: SVGFilterElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFilterElement

and [<AllowNullLiteral>] SVGForeignObjectElement =
    inherit SVGElement
    inherit SVGStylable
    inherit SVGTransformable
    inherit SVGTests
    inherit SVGLangSpace
    inherit SVGExternalResourcesRequired
    abstract height: SVGAnimatedLength with get, set
    abstract width: SVGAnimatedLength with get, set
    abstract x: SVGAnimatedLength with get, set
    abstract y: SVGAnimatedLength with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGForeignObjectElementType =
    abstract prototype: SVGForeignObjectElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGForeignObjectElement

and [<AllowNullLiteral>] SVGGElement =
    inherit SVGElement
    inherit SVGStylable
    inherit SVGTransformable
    inherit SVGTests
    inherit SVGLangSpace
    inherit SVGExternalResourcesRequired
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGGElementType =
    abstract prototype: SVGGElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGGElement

and [<AllowNullLiteral>] SVGGradientElement =
    inherit SVGElement
    inherit SVGStylable
    inherit SVGExternalResourcesRequired
    inherit SVGURIReference
    inherit SVGUnitTypes
    abstract gradientTransform: SVGAnimatedTransformList with get, set
    abstract gradientUnits: SVGAnimatedEnumeration with get, set
    abstract spreadMethod: SVGAnimatedEnumeration with get, set
    abstract SVG_SPREADMETHOD_PAD: float with get, set
    abstract SVG_SPREADMETHOD_REFLECT: float with get, set
    abstract SVG_SPREADMETHOD_REPEAT: float with get, set
    abstract SVG_SPREADMETHOD_UNKNOWN: float with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGGradientElementType =
    abstract prototype: SVGGradientElement with get, set
    abstract SVG_SPREADMETHOD_PAD: float with get, set
    abstract SVG_SPREADMETHOD_REFLECT: float with get, set
    abstract SVG_SPREADMETHOD_REPEAT: float with get, set
    abstract SVG_SPREADMETHOD_UNKNOWN: float with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGGradientElement

and [<AllowNullLiteral>] SVGImageElement =
    inherit SVGElement
    inherit SVGStylable
    inherit SVGTransformable
    inherit SVGTests
    inherit SVGLangSpace
    inherit SVGExternalResourcesRequired
    inherit SVGURIReference
    abstract height: SVGAnimatedLength with get, set
    abstract preserveAspectRatio: SVGAnimatedPreserveAspectRatio with get, set
    abstract width: SVGAnimatedLength with get, set
    abstract x: SVGAnimatedLength with get, set
    abstract y: SVGAnimatedLength with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGImageElementType =
    abstract prototype: SVGImageElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGImageElement

and [<AllowNullLiteral>] SVGLength =
    abstract unitType: float with get, set
    abstract value: float with get, set
    abstract valueAsString: string with get, set
    abstract valueInSpecifiedUnits: float with get, set
    abstract SVG_LENGTHTYPE_CM: float with get, set
    abstract SVG_LENGTHTYPE_EMS: float with get, set
    abstract SVG_LENGTHTYPE_EXS: float with get, set
    abstract SVG_LENGTHTYPE_IN: float with get, set
    abstract SVG_LENGTHTYPE_MM: float with get, set
    abstract SVG_LENGTHTYPE_NUMBER: float with get, set
    abstract SVG_LENGTHTYPE_PC: float with get, set
    abstract SVG_LENGTHTYPE_PERCENTAGE: float with get, set
    abstract SVG_LENGTHTYPE_PT: float with get, set
    abstract SVG_LENGTHTYPE_PX: float with get, set
    abstract SVG_LENGTHTYPE_UNKNOWN: float with get, set
    abstract convertToSpecifiedUnits: unitType: float -> unit
    abstract newValueSpecifiedUnits: unitType: float * valueInSpecifiedUnits: float -> unit

and [<AllowNullLiteral>] SVGLengthType =
    abstract prototype: SVGLength with get, set
    abstract SVG_LENGTHTYPE_CM: float with get, set
    abstract SVG_LENGTHTYPE_EMS: float with get, set
    abstract SVG_LENGTHTYPE_EXS: float with get, set
    abstract SVG_LENGTHTYPE_IN: float with get, set
    abstract SVG_LENGTHTYPE_MM: float with get, set
    abstract SVG_LENGTHTYPE_NUMBER: float with get, set
    abstract SVG_LENGTHTYPE_PC: float with get, set
    abstract SVG_LENGTHTYPE_PERCENTAGE: float with get, set
    abstract SVG_LENGTHTYPE_PT: float with get, set
    abstract SVG_LENGTHTYPE_PX: float with get, set
    abstract SVG_LENGTHTYPE_UNKNOWN: float with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGLength

and [<AllowNullLiteral>] SVGLengthList =
    abstract numberOfItems: float with get, set
    abstract appendItem: newItem: SVGLength -> SVGLength
    abstract clear: unit -> unit
    abstract getItem: index: float -> SVGLength
    abstract initialize: newItem: SVGLength -> SVGLength
    abstract insertItemBefore: newItem: SVGLength * index: float -> SVGLength
    abstract removeItem: index: float -> SVGLength
    abstract replaceItem: newItem: SVGLength * index: float -> SVGLength

and [<AllowNullLiteral>] SVGLengthListType =
    abstract prototype: SVGLengthList with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGLengthList

and [<AllowNullLiteral>] SVGLineElement =
    inherit SVGElement
    inherit SVGStylable
    inherit SVGTransformable
    inherit SVGTests
    inherit SVGLangSpace
    inherit SVGExternalResourcesRequired
    abstract x1: SVGAnimatedLength with get, set
    abstract x2: SVGAnimatedLength with get, set
    abstract y1: SVGAnimatedLength with get, set
    abstract y2: SVGAnimatedLength with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGLineElementType =
    abstract prototype: SVGLineElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGLineElement

and [<AllowNullLiteral>] SVGLinearGradientElement =
    inherit SVGGradientElement
    abstract x1: SVGAnimatedLength with get, set
    abstract x2: SVGAnimatedLength with get, set
    abstract y1: SVGAnimatedLength with get, set
    abstract y2: SVGAnimatedLength with get, set

and [<AllowNullLiteral>] SVGLinearGradientElementType =
    abstract prototype: SVGLinearGradientElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGLinearGradientElement

and [<AllowNullLiteral>] SVGMarkerElement =
    inherit SVGElement
    inherit SVGStylable
    inherit SVGLangSpace
    inherit SVGExternalResourcesRequired
    inherit SVGFitToViewBox
    abstract markerHeight: SVGAnimatedLength with get, set
    abstract markerUnits: SVGAnimatedEnumeration with get, set
    abstract markerWidth: SVGAnimatedLength with get, set
    abstract orientAngle: SVGAnimatedAngle with get, set
    abstract orientType: SVGAnimatedEnumeration with get, set
    abstract refX: SVGAnimatedLength with get, set
    abstract refY: SVGAnimatedLength with get, set
    abstract SVG_MARKERUNITS_STROKEWIDTH: float with get, set
    abstract SVG_MARKERUNITS_UNKNOWN: float with get, set
    abstract SVG_MARKERUNITS_USERSPACEONUSE: float with get, set
    abstract SVG_MARKER_ORIENT_ANGLE: float with get, set
    abstract SVG_MARKER_ORIENT_AUTO: float with get, set
    abstract SVG_MARKER_ORIENT_UNKNOWN: float with get, set
    abstract setOrientToAngle: angle: SVGAngle -> unit
    abstract setOrientToAuto: unit -> unit
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGMarkerElementType =
    abstract prototype: SVGMarkerElement with get, set
    abstract SVG_MARKERUNITS_STROKEWIDTH: float with get, set
    abstract SVG_MARKERUNITS_UNKNOWN: float with get, set
    abstract SVG_MARKERUNITS_USERSPACEONUSE: float with get, set
    abstract SVG_MARKER_ORIENT_ANGLE: float with get, set
    abstract SVG_MARKER_ORIENT_AUTO: float with get, set
    abstract SVG_MARKER_ORIENT_UNKNOWN: float with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGMarkerElement

and [<AllowNullLiteral>] SVGMaskElement =
    inherit SVGElement
    inherit SVGStylable
    inherit SVGTests
    inherit SVGLangSpace
    inherit SVGExternalResourcesRequired
    inherit SVGUnitTypes
    abstract height: SVGAnimatedLength with get, set
    abstract maskContentUnits: SVGAnimatedEnumeration with get, set
    abstract maskUnits: SVGAnimatedEnumeration with get, set
    abstract width: SVGAnimatedLength with get, set
    abstract x: SVGAnimatedLength with get, set
    abstract y: SVGAnimatedLength with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGMaskElementType =
    abstract prototype: SVGMaskElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGMaskElement

and [<AllowNullLiteral>] SVGMatrix =
    abstract a: float with get, set
    abstract b: float with get, set
    abstract c: float with get, set
    abstract d: float with get, set
    abstract e: float with get, set
    abstract f: float with get, set
    abstract flipX: unit -> SVGMatrix
    abstract flipY: unit -> SVGMatrix
    abstract inverse: unit -> SVGMatrix
    abstract multiply: secondMatrix: SVGMatrix -> SVGMatrix
    abstract rotate: angle: float -> SVGMatrix
    abstract rotateFromVector: x: float * y: float -> SVGMatrix
    abstract scale: scaleFactor: float -> SVGMatrix
    abstract scaleNonUniform: scaleFactorX: float * scaleFactorY: float -> SVGMatrix
    abstract skewX: angle: float -> SVGMatrix
    abstract skewY: angle: float -> SVGMatrix
    abstract translate: x: float * y: float -> SVGMatrix

and [<AllowNullLiteral>] SVGMatrixType =
    abstract prototype: SVGMatrix with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGMatrix

and [<AllowNullLiteral>] SVGMetadataElement =
    inherit SVGElement


and [<AllowNullLiteral>] SVGMetadataElementType =
    abstract prototype: SVGMetadataElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGMetadataElement

and [<AllowNullLiteral>] SVGNumber =
    abstract value: float with get, set

and [<AllowNullLiteral>] SVGNumberType =
    abstract prototype: SVGNumber with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGNumber

and [<AllowNullLiteral>] SVGNumberList =
    abstract numberOfItems: float with get, set
    abstract appendItem: newItem: SVGNumber -> SVGNumber
    abstract clear: unit -> unit
    abstract getItem: index: float -> SVGNumber
    abstract initialize: newItem: SVGNumber -> SVGNumber
    abstract insertItemBefore: newItem: SVGNumber * index: float -> SVGNumber
    abstract removeItem: index: float -> SVGNumber
    abstract replaceItem: newItem: SVGNumber * index: float -> SVGNumber

and [<AllowNullLiteral>] SVGNumberListType =
    abstract prototype: SVGNumberList with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGNumberList

and [<AllowNullLiteral>] SVGPathElement =
    inherit SVGElement
    inherit SVGStylable
    inherit SVGTransformable
    inherit SVGTests
    inherit SVGLangSpace
    inherit SVGExternalResourcesRequired
    inherit SVGAnimatedPathData
    abstract createSVGPathSegArcAbs: x: float * y: float * r1: float * r2: float * angle: float * largeArcFlag: bool * sweepFlag: bool -> SVGPathSegArcAbs
    abstract createSVGPathSegArcRel: x: float * y: float * r1: float * r2: float * angle: float * largeArcFlag: bool * sweepFlag: bool -> SVGPathSegArcRel
    abstract createSVGPathSegClosePath: unit -> SVGPathSegClosePath
    abstract createSVGPathSegCurvetoCubicAbs: x: float * y: float * x1: float * y1: float * x2: float * y2: float -> SVGPathSegCurvetoCubicAbs
    abstract createSVGPathSegCurvetoCubicRel: x: float * y: float * x1: float * y1: float * x2: float * y2: float -> SVGPathSegCurvetoCubicRel
    abstract createSVGPathSegCurvetoCubicSmoothAbs: x: float * y: float * x2: float * y2: float -> SVGPathSegCurvetoCubicSmoothAbs
    abstract createSVGPathSegCurvetoCubicSmoothRel: x: float * y: float * x2: float * y2: float -> SVGPathSegCurvetoCubicSmoothRel
    abstract createSVGPathSegCurvetoQuadraticAbs: x: float * y: float * x1: float * y1: float -> SVGPathSegCurvetoQuadraticAbs
    abstract createSVGPathSegCurvetoQuadraticRel: x: float * y: float * x1: float * y1: float -> SVGPathSegCurvetoQuadraticRel
    abstract createSVGPathSegCurvetoQuadraticSmoothAbs: x: float * y: float -> SVGPathSegCurvetoQuadraticSmoothAbs
    abstract createSVGPathSegCurvetoQuadraticSmoothRel: x: float * y: float -> SVGPathSegCurvetoQuadraticSmoothRel
    abstract createSVGPathSegLinetoAbs: x: float * y: float -> SVGPathSegLinetoAbs
    abstract createSVGPathSegLinetoHorizontalAbs: x: float -> SVGPathSegLinetoHorizontalAbs
    abstract createSVGPathSegLinetoHorizontalRel: x: float -> SVGPathSegLinetoHorizontalRel
    abstract createSVGPathSegLinetoRel: x: float * y: float -> SVGPathSegLinetoRel
    abstract createSVGPathSegLinetoVerticalAbs: y: float -> SVGPathSegLinetoVerticalAbs
    abstract createSVGPathSegLinetoVerticalRel: y: float -> SVGPathSegLinetoVerticalRel
    abstract createSVGPathSegMovetoAbs: x: float * y: float -> SVGPathSegMovetoAbs
    abstract createSVGPathSegMovetoRel: x: float * y: float -> SVGPathSegMovetoRel
    abstract getPathSegAtLength: distance: float -> float
    abstract getPointAtLength: distance: float -> SVGPoint
    abstract getTotalLength: unit -> float
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGPathElementType =
    abstract prototype: SVGPathElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPathElement

and [<AllowNullLiteral>] SVGPathSeg =
    abstract pathSegType: float with get, set
    abstract pathSegTypeAsLetter: string with get, set
    abstract PATHSEG_ARC_ABS: float with get, set
    abstract PATHSEG_ARC_REL: float with get, set
    abstract PATHSEG_CLOSEPATH: float with get, set
    abstract PATHSEG_CURVETO_CUBIC_ABS: float with get, set
    abstract PATHSEG_CURVETO_CUBIC_REL: float with get, set
    abstract PATHSEG_CURVETO_CUBIC_SMOOTH_ABS: float with get, set
    abstract PATHSEG_CURVETO_CUBIC_SMOOTH_REL: float with get, set
    abstract PATHSEG_CURVETO_QUADRATIC_ABS: float with get, set
    abstract PATHSEG_CURVETO_QUADRATIC_REL: float with get, set
    abstract PATHSEG_CURVETO_QUADRATIC_SMOOTH_ABS: float with get, set
    abstract PATHSEG_CURVETO_QUADRATIC_SMOOTH_REL: float with get, set
    abstract PATHSEG_LINETO_ABS: float with get, set
    abstract PATHSEG_LINETO_HORIZONTAL_ABS: float with get, set
    abstract PATHSEG_LINETO_HORIZONTAL_REL: float with get, set
    abstract PATHSEG_LINETO_REL: float with get, set
    abstract PATHSEG_LINETO_VERTICAL_ABS: float with get, set
    abstract PATHSEG_LINETO_VERTICAL_REL: float with get, set
    abstract PATHSEG_MOVETO_ABS: float with get, set
    abstract PATHSEG_MOVETO_REL: float with get, set
    abstract PATHSEG_UNKNOWN: float with get, set

and [<AllowNullLiteral>] SVGPathSegType =
    abstract prototype: SVGPathSeg with get, set
    abstract PATHSEG_ARC_ABS: float with get, set
    abstract PATHSEG_ARC_REL: float with get, set
    abstract PATHSEG_CLOSEPATH: float with get, set
    abstract PATHSEG_CURVETO_CUBIC_ABS: float with get, set
    abstract PATHSEG_CURVETO_CUBIC_REL: float with get, set
    abstract PATHSEG_CURVETO_CUBIC_SMOOTH_ABS: float with get, set
    abstract PATHSEG_CURVETO_CUBIC_SMOOTH_REL: float with get, set
    abstract PATHSEG_CURVETO_QUADRATIC_ABS: float with get, set
    abstract PATHSEG_CURVETO_QUADRATIC_REL: float with get, set
    abstract PATHSEG_CURVETO_QUADRATIC_SMOOTH_ABS: float with get, set
    abstract PATHSEG_CURVETO_QUADRATIC_SMOOTH_REL: float with get, set
    abstract PATHSEG_LINETO_ABS: float with get, set
    abstract PATHSEG_LINETO_HORIZONTAL_ABS: float with get, set
    abstract PATHSEG_LINETO_HORIZONTAL_REL: float with get, set
    abstract PATHSEG_LINETO_REL: float with get, set
    abstract PATHSEG_LINETO_VERTICAL_ABS: float with get, set
    abstract PATHSEG_LINETO_VERTICAL_REL: float with get, set
    abstract PATHSEG_MOVETO_ABS: float with get, set
    abstract PATHSEG_MOVETO_REL: float with get, set
    abstract PATHSEG_UNKNOWN: float with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPathSeg

and [<AllowNullLiteral>] SVGPathSegArcAbs =
    inherit SVGPathSeg
    abstract angle: float with get, set
    abstract largeArcFlag: bool with get, set
    abstract r1: float with get, set
    abstract r2: float with get, set
    abstract sweepFlag: bool with get, set
    abstract x: float with get, set
    abstract y: float with get, set

and [<AllowNullLiteral>] SVGPathSegArcAbsType =
    abstract prototype: SVGPathSegArcAbs with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPathSegArcAbs

and [<AllowNullLiteral>] SVGPathSegArcRel =
    inherit SVGPathSeg
    abstract angle: float with get, set
    abstract largeArcFlag: bool with get, set
    abstract r1: float with get, set
    abstract r2: float with get, set
    abstract sweepFlag: bool with get, set
    abstract x: float with get, set
    abstract y: float with get, set

and [<AllowNullLiteral>] SVGPathSegArcRelType =
    abstract prototype: SVGPathSegArcRel with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPathSegArcRel

and [<AllowNullLiteral>] SVGPathSegClosePath =
    inherit SVGPathSeg


and [<AllowNullLiteral>] SVGPathSegClosePathType =
    abstract prototype: SVGPathSegClosePath with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPathSegClosePath

and [<AllowNullLiteral>] SVGPathSegCurvetoCubicAbs =
    inherit SVGPathSeg
    abstract x: float with get, set
    abstract x1: float with get, set
    abstract x2: float with get, set
    abstract y: float with get, set
    abstract y1: float with get, set
    abstract y2: float with get, set

and [<AllowNullLiteral>] SVGPathSegCurvetoCubicAbsType =
    abstract prototype: SVGPathSegCurvetoCubicAbs with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPathSegCurvetoCubicAbs

and [<AllowNullLiteral>] SVGPathSegCurvetoCubicRel =
    inherit SVGPathSeg
    abstract x: float with get, set
    abstract x1: float with get, set
    abstract x2: float with get, set
    abstract y: float with get, set
    abstract y1: float with get, set
    abstract y2: float with get, set

and [<AllowNullLiteral>] SVGPathSegCurvetoCubicRelType =
    abstract prototype: SVGPathSegCurvetoCubicRel with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPathSegCurvetoCubicRel

and [<AllowNullLiteral>] SVGPathSegCurvetoCubicSmoothAbs =
    inherit SVGPathSeg
    abstract x: float with get, set
    abstract x2: float with get, set
    abstract y: float with get, set
    abstract y2: float with get, set

and [<AllowNullLiteral>] SVGPathSegCurvetoCubicSmoothAbsType =
    abstract prototype: SVGPathSegCurvetoCubicSmoothAbs with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPathSegCurvetoCubicSmoothAbs

and [<AllowNullLiteral>] SVGPathSegCurvetoCubicSmoothRel =
    inherit SVGPathSeg
    abstract x: float with get, set
    abstract x2: float with get, set
    abstract y: float with get, set
    abstract y2: float with get, set

and [<AllowNullLiteral>] SVGPathSegCurvetoCubicSmoothRelType =
    abstract prototype: SVGPathSegCurvetoCubicSmoothRel with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPathSegCurvetoCubicSmoothRel

and [<AllowNullLiteral>] SVGPathSegCurvetoQuadraticAbs =
    inherit SVGPathSeg
    abstract x: float with get, set
    abstract x1: float with get, set
    abstract y: float with get, set
    abstract y1: float with get, set

and [<AllowNullLiteral>] SVGPathSegCurvetoQuadraticAbsType =
    abstract prototype: SVGPathSegCurvetoQuadraticAbs with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPathSegCurvetoQuadraticAbs

and [<AllowNullLiteral>] SVGPathSegCurvetoQuadraticRel =
    inherit SVGPathSeg
    abstract x: float with get, set
    abstract x1: float with get, set
    abstract y: float with get, set
    abstract y1: float with get, set

and [<AllowNullLiteral>] SVGPathSegCurvetoQuadraticRelType =
    abstract prototype: SVGPathSegCurvetoQuadraticRel with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPathSegCurvetoQuadraticRel

and [<AllowNullLiteral>] SVGPathSegCurvetoQuadraticSmoothAbs =
    inherit SVGPathSeg
    abstract x: float with get, set
    abstract y: float with get, set

and [<AllowNullLiteral>] SVGPathSegCurvetoQuadraticSmoothAbsType =
    abstract prototype: SVGPathSegCurvetoQuadraticSmoothAbs with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPathSegCurvetoQuadraticSmoothAbs

and [<AllowNullLiteral>] SVGPathSegCurvetoQuadraticSmoothRel =
    inherit SVGPathSeg
    abstract x: float with get, set
    abstract y: float with get, set

and [<AllowNullLiteral>] SVGPathSegCurvetoQuadraticSmoothRelType =
    abstract prototype: SVGPathSegCurvetoQuadraticSmoothRel with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPathSegCurvetoQuadraticSmoothRel

and [<AllowNullLiteral>] SVGPathSegLinetoAbs =
    inherit SVGPathSeg
    abstract x: float with get, set
    abstract y: float with get, set

and [<AllowNullLiteral>] SVGPathSegLinetoAbsType =
    abstract prototype: SVGPathSegLinetoAbs with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPathSegLinetoAbs

and [<AllowNullLiteral>] SVGPathSegLinetoHorizontalAbs =
    inherit SVGPathSeg
    abstract x: float with get, set

and [<AllowNullLiteral>] SVGPathSegLinetoHorizontalAbsType =
    abstract prototype: SVGPathSegLinetoHorizontalAbs with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPathSegLinetoHorizontalAbs

and [<AllowNullLiteral>] SVGPathSegLinetoHorizontalRel =
    inherit SVGPathSeg
    abstract x: float with get, set

and [<AllowNullLiteral>] SVGPathSegLinetoHorizontalRelType =
    abstract prototype: SVGPathSegLinetoHorizontalRel with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPathSegLinetoHorizontalRel

and [<AllowNullLiteral>] SVGPathSegLinetoRel =
    inherit SVGPathSeg
    abstract x: float with get, set
    abstract y: float with get, set

and [<AllowNullLiteral>] SVGPathSegLinetoRelType =
    abstract prototype: SVGPathSegLinetoRel with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPathSegLinetoRel

and [<AllowNullLiteral>] SVGPathSegLinetoVerticalAbs =
    inherit SVGPathSeg
    abstract y: float with get, set

and [<AllowNullLiteral>] SVGPathSegLinetoVerticalAbsType =
    abstract prototype: SVGPathSegLinetoVerticalAbs with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPathSegLinetoVerticalAbs

and [<AllowNullLiteral>] SVGPathSegLinetoVerticalRel =
    inherit SVGPathSeg
    abstract y: float with get, set

and [<AllowNullLiteral>] SVGPathSegLinetoVerticalRelType =
    abstract prototype: SVGPathSegLinetoVerticalRel with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPathSegLinetoVerticalRel

and [<AllowNullLiteral>] SVGPathSegList =
    abstract numberOfItems: float with get, set
    abstract appendItem: newItem: SVGPathSeg -> SVGPathSeg
    abstract clear: unit -> unit
    abstract getItem: index: float -> SVGPathSeg
    abstract initialize: newItem: SVGPathSeg -> SVGPathSeg
    abstract insertItemBefore: newItem: SVGPathSeg * index: float -> SVGPathSeg
    abstract removeItem: index: float -> SVGPathSeg
    abstract replaceItem: newItem: SVGPathSeg * index: float -> SVGPathSeg

and [<AllowNullLiteral>] SVGPathSegListType =
    abstract prototype: SVGPathSegList with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPathSegList

and [<AllowNullLiteral>] SVGPathSegMovetoAbs =
    inherit SVGPathSeg
    abstract x: float with get, set
    abstract y: float with get, set

and [<AllowNullLiteral>] SVGPathSegMovetoAbsType =
    abstract prototype: SVGPathSegMovetoAbs with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPathSegMovetoAbs

and [<AllowNullLiteral>] SVGPathSegMovetoRel =
    inherit SVGPathSeg
    abstract x: float with get, set
    abstract y: float with get, set

and [<AllowNullLiteral>] SVGPathSegMovetoRelType =
    abstract prototype: SVGPathSegMovetoRel with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPathSegMovetoRel

and [<AllowNullLiteral>] SVGPatternElement =
    inherit SVGElement
    inherit SVGStylable
    inherit SVGTests
    inherit SVGLangSpace
    inherit SVGExternalResourcesRequired
    inherit SVGFitToViewBox
    inherit SVGURIReference
    inherit SVGUnitTypes
    abstract height: SVGAnimatedLength with get, set
    abstract patternContentUnits: SVGAnimatedEnumeration with get, set
    abstract patternTransform: SVGAnimatedTransformList with get, set
    abstract patternUnits: SVGAnimatedEnumeration with get, set
    abstract width: SVGAnimatedLength with get, set
    abstract x: SVGAnimatedLength with get, set
    abstract y: SVGAnimatedLength with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGPatternElementType =
    abstract prototype: SVGPatternElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPatternElement

and [<AllowNullLiteral>] SVGPoint =
    abstract x: float with get, set
    abstract y: float with get, set
    abstract matrixTransform: matrix: SVGMatrix -> SVGPoint

and [<AllowNullLiteral>] SVGPointType =
    abstract prototype: SVGPoint with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPoint

and [<AllowNullLiteral>] SVGPointList =
    abstract numberOfItems: float with get, set
    abstract appendItem: newItem: SVGPoint -> SVGPoint
    abstract clear: unit -> unit
    abstract getItem: index: float -> SVGPoint
    abstract initialize: newItem: SVGPoint -> SVGPoint
    abstract insertItemBefore: newItem: SVGPoint * index: float -> SVGPoint
    abstract removeItem: index: float -> SVGPoint
    abstract replaceItem: newItem: SVGPoint * index: float -> SVGPoint

and [<AllowNullLiteral>] SVGPointListType =
    abstract prototype: SVGPointList with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPointList

and [<AllowNullLiteral>] SVGPolygonElement =
    inherit SVGElement
    inherit SVGStylable
    inherit SVGTransformable
    inherit SVGTests
    inherit SVGLangSpace
    inherit SVGExternalResourcesRequired
    inherit SVGAnimatedPoints
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGPolygonElementType =
    abstract prototype: SVGPolygonElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPolygonElement

and [<AllowNullLiteral>] SVGPolylineElement =
    inherit SVGElement
    inherit SVGStylable
    inherit SVGTransformable
    inherit SVGTests
    inherit SVGLangSpace
    inherit SVGExternalResourcesRequired
    inherit SVGAnimatedPoints
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGPolylineElementType =
    abstract prototype: SVGPolylineElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPolylineElement

and [<AllowNullLiteral>] SVGPreserveAspectRatio =
    abstract align: float with get, set
    abstract meetOrSlice: float with get, set
    abstract SVG_MEETORSLICE_MEET: float with get, set
    abstract SVG_MEETORSLICE_SLICE: float with get, set
    abstract SVG_MEETORSLICE_UNKNOWN: float with get, set
    abstract SVG_PRESERVEASPECTRATIO_NONE: float with get, set
    abstract SVG_PRESERVEASPECTRATIO_UNKNOWN: float with get, set
    abstract SVG_PRESERVEASPECTRATIO_XMAXYMAX: float with get, set
    abstract SVG_PRESERVEASPECTRATIO_XMAXYMID: float with get, set
    abstract SVG_PRESERVEASPECTRATIO_XMAXYMIN: float with get, set
    abstract SVG_PRESERVEASPECTRATIO_XMIDYMAX: float with get, set
    abstract SVG_PRESERVEASPECTRATIO_XMIDYMID: float with get, set
    abstract SVG_PRESERVEASPECTRATIO_XMIDYMIN: float with get, set
    abstract SVG_PRESERVEASPECTRATIO_XMINYMAX: float with get, set
    abstract SVG_PRESERVEASPECTRATIO_XMINYMID: float with get, set
    abstract SVG_PRESERVEASPECTRATIO_XMINYMIN: float with get, set

and [<AllowNullLiteral>] SVGPreserveAspectRatioType =
    abstract prototype: SVGPreserveAspectRatio with get, set
    abstract SVG_MEETORSLICE_MEET: float with get, set
    abstract SVG_MEETORSLICE_SLICE: float with get, set
    abstract SVG_MEETORSLICE_UNKNOWN: float with get, set
    abstract SVG_PRESERVEASPECTRATIO_NONE: float with get, set
    abstract SVG_PRESERVEASPECTRATIO_UNKNOWN: float with get, set
    abstract SVG_PRESERVEASPECTRATIO_XMAXYMAX: float with get, set
    abstract SVG_PRESERVEASPECTRATIO_XMAXYMID: float with get, set
    abstract SVG_PRESERVEASPECTRATIO_XMAXYMIN: float with get, set
    abstract SVG_PRESERVEASPECTRATIO_XMIDYMAX: float with get, set
    abstract SVG_PRESERVEASPECTRATIO_XMIDYMID: float with get, set
    abstract SVG_PRESERVEASPECTRATIO_XMIDYMIN: float with get, set
    abstract SVG_PRESERVEASPECTRATIO_XMINYMAX: float with get, set
    abstract SVG_PRESERVEASPECTRATIO_XMINYMID: float with get, set
    abstract SVG_PRESERVEASPECTRATIO_XMINYMIN: float with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPreserveAspectRatio

and [<AllowNullLiteral>] SVGRadialGradientElement =
    inherit SVGGradientElement
    abstract cx: SVGAnimatedLength with get, set
    abstract cy: SVGAnimatedLength with get, set
    abstract fx: SVGAnimatedLength with get, set
    abstract fy: SVGAnimatedLength with get, set
    abstract r: SVGAnimatedLength with get, set

and [<AllowNullLiteral>] SVGRadialGradientElementType =
    abstract prototype: SVGRadialGradientElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGRadialGradientElement

and [<AllowNullLiteral>] SVGRect =
    abstract height: float with get, set
    abstract width: float with get, set
    abstract x: float with get, set
    abstract y: float with get, set

and [<AllowNullLiteral>] SVGRectType =
    abstract prototype: SVGRect with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGRect

and [<AllowNullLiteral>] SVGRectElement =
    inherit SVGElement
    inherit SVGStylable
    inherit SVGTransformable
    inherit SVGTests
    inherit SVGLangSpace
    inherit SVGExternalResourcesRequired
    abstract height: SVGAnimatedLength with get, set
    abstract rx: SVGAnimatedLength with get, set
    abstract ry: SVGAnimatedLength with get, set
    abstract width: SVGAnimatedLength with get, set
    abstract x: SVGAnimatedLength with get, set
    abstract y: SVGAnimatedLength with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGRectElementType =
    abstract prototype: SVGRectElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGRectElement

and [<AllowNullLiteral>] SVGSVGElement =
    inherit SVGElement
    inherit DocumentEvent
    inherit SVGLocatable
    inherit SVGTests
    inherit SVGStylable
    inherit SVGLangSpace
    inherit SVGExternalResourcesRequired
    inherit SVGFitToViewBox
    inherit SVGZoomAndPan
    abstract contentScriptType: string with get, set
    abstract contentStyleType: string with get, set
    abstract currentScale: float with get, set
    abstract currentTranslate: SVGPoint with get, set
    abstract height: SVGAnimatedLength with get, set
    abstract onabort: (Event -> 'Out) with get, set
    abstract onerror: (Event -> 'Out) with get, set
    abstract onresize: (UIEvent -> 'Out) with get, set
    abstract onscroll: (UIEvent -> 'Out) with get, set
    abstract onunload: (Event -> 'Out) with get, set
    abstract onzoom: (SVGZoomEvent -> 'Out) with get, set
    abstract pixelUnitToMillimeterX: float with get, set
    abstract pixelUnitToMillimeterY: float with get, set
    abstract screenPixelToMillimeterX: float with get, set
    abstract screenPixelToMillimeterY: float with get, set
    abstract viewport: SVGRect with get, set
    abstract width: SVGAnimatedLength with get, set
    abstract x: SVGAnimatedLength with get, set
    abstract y: SVGAnimatedLength with get, set
    abstract checkEnclosure: element: SVGElement * rect: SVGRect -> bool
    abstract checkIntersection: element: SVGElement * rect: SVGRect -> bool
    abstract createSVGAngle: unit -> SVGAngle
    abstract createSVGLength: unit -> SVGLength
    abstract createSVGMatrix: unit -> SVGMatrix
    abstract createSVGNumber: unit -> SVGNumber
    abstract createSVGPoint: unit -> SVGPoint
    abstract createSVGRect: unit -> SVGRect
    abstract createSVGTransform: unit -> SVGTransform
    abstract createSVGTransformFromMatrix: matrix: SVGMatrix -> SVGTransform
    abstract deselectAll: unit -> unit
    abstract forceRedraw: unit -> unit
    // TODO
    // abstract getComputedStyle: elt: Element * ?pseudoElt: string -> CSSStyleDeclaration
    abstract getCurrentTime: unit -> float
    abstract getElementById: elementId: string -> Element
    abstract getEnclosureList: rect: SVGRect * referenceElement: SVGElement -> NodeList
    abstract getIntersectionList: rect: SVGRect * referenceElement: SVGElement -> NodeList
    abstract pauseAnimations: unit -> unit
    abstract setCurrentTime: seconds: float -> unit
    abstract suspendRedraw: maxWaitMilliseconds: float -> float
    abstract unpauseAnimations: unit -> unit
    abstract unsuspendRedraw: suspendHandleID: float -> unit
    abstract unsuspendRedrawAll: unit -> unit
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGSVGElementType =
    abstract prototype: SVGSVGElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGSVGElement

and [<AllowNullLiteral>] SVGScriptElement =
    inherit SVGElement
    inherit SVGExternalResourcesRequired
    inherit SVGURIReference
    abstract ``type``: string with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGScriptElementType =
    abstract prototype: SVGScriptElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGScriptElement

and [<AllowNullLiteral>] SVGStopElement =
    inherit SVGElement
    inherit SVGStylable
    abstract offset: SVGAnimatedNumber with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGStopElementType =
    abstract prototype: SVGStopElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGStopElement

and [<AllowNullLiteral>] SVGStringList =
    abstract numberOfItems: float with get, set
    abstract appendItem: newItem: string -> string
    abstract clear: unit -> unit
    abstract getItem: index: float -> string
    abstract initialize: newItem: string -> string
    abstract insertItemBefore: newItem: string * index: float -> string
    abstract removeItem: index: float -> string
    abstract replaceItem: newItem: string * index: float -> string

and [<AllowNullLiteral>] SVGStringListType =
    abstract prototype: SVGStringList with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGStringList

and [<AllowNullLiteral>] SVGStyleElement =
    inherit SVGElement
    inherit SVGLangSpace
    abstract media: string with get, set
    abstract title: string with get, set
    abstract ``type``: string with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGStyleElementType =
    abstract prototype: SVGStyleElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGStyleElement

and [<AllowNullLiteral>] SVGSwitchElement =
    inherit SVGElement
    inherit SVGStylable
    inherit SVGTransformable
    inherit SVGTests
    inherit SVGLangSpace
    inherit SVGExternalResourcesRequired
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGSwitchElementType =
    abstract prototype: SVGSwitchElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGSwitchElement

and [<AllowNullLiteral>] SVGSymbolElement =
    inherit SVGElement
    inherit SVGStylable
    inherit SVGLangSpace
    inherit SVGExternalResourcesRequired
    inherit SVGFitToViewBox
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGSymbolElementType =
    abstract prototype: SVGSymbolElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGSymbolElement

and [<AllowNullLiteral>] SVGTSpanElement =
    inherit SVGTextPositioningElement


and [<AllowNullLiteral>] SVGTSpanElementType =
    abstract prototype: SVGTSpanElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGTSpanElement

and [<AllowNullLiteral>] SVGTextContentElement =
    inherit SVGElement
    inherit SVGStylable
    inherit SVGTests
    inherit SVGLangSpace
    inherit SVGExternalResourcesRequired
    abstract lengthAdjust: SVGAnimatedEnumeration with get, set
    abstract textLength: SVGAnimatedLength with get, set
    abstract LENGTHADJUST_SPACING: float with get, set
    abstract LENGTHADJUST_SPACINGANDGLYPHS: float with get, set
    abstract LENGTHADJUST_UNKNOWN: float with get, set
    abstract getCharNumAtPosition: point: SVGPoint -> float
    abstract getComputedTextLength: unit -> float
    abstract getEndPositionOfChar: charnum: float -> SVGPoint
    abstract getExtentOfChar: charnum: float -> SVGRect
    abstract getNumberOfChars: unit -> float
    abstract getRotationOfChar: charnum: float -> float
    abstract getStartPositionOfChar: charnum: float -> SVGPoint
    abstract getSubStringLength: charnum: float * nchars: float -> float
    abstract selectSubString: charnum: float * nchars: float -> unit
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGTextContentElementType =
    abstract prototype: SVGTextContentElement with get, set
    abstract LENGTHADJUST_SPACING: float with get, set
    abstract LENGTHADJUST_SPACINGANDGLYPHS: float with get, set
    abstract LENGTHADJUST_UNKNOWN: float with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGTextContentElement

and [<AllowNullLiteral>] SVGTextElement =
    inherit SVGTextPositioningElement
    inherit SVGTransformable
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGTextElementType =
    abstract prototype: SVGTextElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGTextElement

and [<AllowNullLiteral>] SVGTextPathElement =
    inherit SVGTextContentElement
    inherit SVGURIReference
    abstract ``method``: SVGAnimatedEnumeration with get, set
    abstract spacing: SVGAnimatedEnumeration with get, set
    abstract startOffset: SVGAnimatedLength with get, set
    abstract TEXTPATH_METHODTYPE_ALIGN: float with get, set
    abstract TEXTPATH_METHODTYPE_STRETCH: float with get, set
    abstract TEXTPATH_METHODTYPE_UNKNOWN: float with get, set
    abstract TEXTPATH_SPACINGTYPE_AUTO: float with get, set
    abstract TEXTPATH_SPACINGTYPE_EXACT: float with get, set
    abstract TEXTPATH_SPACINGTYPE_UNKNOWN: float with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGTextPathElementType =
    abstract prototype: SVGTextPathElement with get, set
    abstract TEXTPATH_METHODTYPE_ALIGN: float with get, set
    abstract TEXTPATH_METHODTYPE_STRETCH: float with get, set
    abstract TEXTPATH_METHODTYPE_UNKNOWN: float with get, set
    abstract TEXTPATH_SPACINGTYPE_AUTO: float with get, set
    abstract TEXTPATH_SPACINGTYPE_EXACT: float with get, set
    abstract TEXTPATH_SPACINGTYPE_UNKNOWN: float with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGTextPathElement

and [<AllowNullLiteral>] SVGTextPositioningElement =
    inherit SVGTextContentElement
    abstract dx: SVGAnimatedLengthList with get, set
    abstract dy: SVGAnimatedLengthList with get, set
    abstract rotate: SVGAnimatedNumberList with get, set
    abstract x: SVGAnimatedLengthList with get, set
    abstract y: SVGAnimatedLengthList with get, set

and [<AllowNullLiteral>] SVGTextPositioningElementType =
    abstract prototype: SVGTextPositioningElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGTextPositioningElement

and [<AllowNullLiteral>] SVGTitleElement =
    inherit SVGElement
    inherit SVGStylable
    inherit SVGLangSpace
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGTitleElementType =
    abstract prototype: SVGTitleElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGTitleElement

and [<AllowNullLiteral>] SVGTransform =
    abstract angle: float with get, set
    abstract matrix: SVGMatrix with get, set
    abstract ``type``: float with get, set
    abstract SVG_TRANSFORM_MATRIX: float with get, set
    abstract SVG_TRANSFORM_ROTATE: float with get, set
    abstract SVG_TRANSFORM_SCALE: float with get, set
    abstract SVG_TRANSFORM_SKEWX: float with get, set
    abstract SVG_TRANSFORM_SKEWY: float with get, set
    abstract SVG_TRANSFORM_TRANSLATE: float with get, set
    abstract SVG_TRANSFORM_UNKNOWN: float with get, set
    abstract setMatrix: matrix: SVGMatrix -> unit
    abstract setRotate: angle: float * cx: float * cy: float -> unit
    abstract setScale: sx: float * sy: float -> unit
    abstract setSkewX: angle: float -> unit
    abstract setSkewY: angle: float -> unit
    abstract setTranslate: tx: float * ty: float -> unit

and [<AllowNullLiteral>] SVGTransformType =
    abstract prototype: SVGTransform with get, set
    abstract SVG_TRANSFORM_MATRIX: float with get, set
    abstract SVG_TRANSFORM_ROTATE: float with get, set
    abstract SVG_TRANSFORM_SCALE: float with get, set
    abstract SVG_TRANSFORM_SKEWX: float with get, set
    abstract SVG_TRANSFORM_SKEWY: float with get, set
    abstract SVG_TRANSFORM_TRANSLATE: float with get, set
    abstract SVG_TRANSFORM_UNKNOWN: float with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGTransform

and [<AllowNullLiteral>] SVGTransformList =
    abstract numberOfItems: float with get, set
    abstract appendItem: newItem: SVGTransform -> SVGTransform
    abstract clear: unit -> unit
    abstract consolidate: unit -> SVGTransform
    abstract createSVGTransformFromMatrix: matrix: SVGMatrix -> SVGTransform
    abstract getItem: index: float -> SVGTransform
    abstract initialize: newItem: SVGTransform -> SVGTransform
    abstract insertItemBefore: newItem: SVGTransform * index: float -> SVGTransform
    abstract removeItem: index: float -> SVGTransform
    abstract replaceItem: newItem: SVGTransform * index: float -> SVGTransform

and [<AllowNullLiteral>] SVGTransformListType =
    abstract prototype: SVGTransformList with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGTransformList

and [<AllowNullLiteral>] SVGUnitTypes =
    abstract SVG_UNIT_TYPE_OBJECTBOUNDINGBOX: float with get, set
    abstract SVG_UNIT_TYPE_UNKNOWN: float with get, set
    abstract SVG_UNIT_TYPE_USERSPACEONUSE: float with get, set

and [<AllowNullLiteral>] SVGUseElement =
    inherit SVGElement
    inherit SVGStylable
    inherit SVGTransformable
    inherit SVGTests
    inherit SVGLangSpace
    inherit SVGExternalResourcesRequired
    inherit SVGURIReference
    abstract animatedInstanceRoot: SVGElementInstance with get, set
    abstract height: SVGAnimatedLength with get, set
    abstract instanceRoot: SVGElementInstance with get, set
    abstract width: SVGAnimatedLength with get, set
    abstract x: SVGAnimatedLength with get, set
    abstract y: SVGAnimatedLength with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGUseElementType =
    abstract prototype: SVGUseElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGUseElement

and [<AllowNullLiteral>] SVGViewElement =
    inherit SVGElement
    inherit SVGExternalResourcesRequired
    inherit SVGFitToViewBox
    inherit SVGZoomAndPan
    abstract viewTarget: SVGStringList with get, set
    abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

and [<AllowNullLiteral>] SVGViewElementType =
    abstract prototype: SVGViewElement with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGViewElement

and [<AllowNullLiteral>] SVGZoomAndPan =
    abstract zoomAndPan: float with get, set

and [<AllowNullLiteral>] SVGZoomAndPanType =
    abstract SVG_ZOOMANDPAN_DISABLE: float with get, set
    abstract SVG_ZOOMANDPAN_MAGNIFY: float with get, set
    abstract SVG_ZOOMANDPAN_UNKNOWN: float with get, set

and [<AllowNullLiteral>] SVGZoomEvent =
    inherit UIEvent
    abstract newScale: float with get, set
    abstract newTranslate: SVGPoint with get, set
    abstract previousScale: float with get, set
    abstract previousTranslate: SVGPoint with get, set
    abstract zoomRectScreen: SVGRect with get, set

and [<AllowNullLiteral>] SVGZoomEventType =
    abstract prototype: SVGZoomEvent with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> SVGZoomEvent

and [<AllowNullLiteral>] SVGAnimatedPathData =
        abstract pathSegList: SVGPathSegList with get, set

    and [<AllowNullLiteral>] SVGAnimatedPoints =
        abstract animatedPoints: SVGPointList with get, set
        abstract points: SVGPointList with get, set

    and [<AllowNullLiteral>] SVGExternalResourcesRequired =
        abstract externalResourcesRequired: SVGAnimatedBoolean with get, set

    and [<AllowNullLiteral>] SVGFilterPrimitiveStandardAttributes =
        inherit SVGStylable
        abstract height: SVGAnimatedLength with get, set
        abstract result: SVGAnimatedString with get, set
        abstract width: SVGAnimatedLength with get, set
        abstract x: SVGAnimatedLength with get, set
        abstract y: SVGAnimatedLength with get, set

    and [<AllowNullLiteral>] SVGFitToViewBox =
        abstract preserveAspectRatio: SVGAnimatedPreserveAspectRatio with get, set
        abstract viewBox: SVGAnimatedRect with get, set

    and [<AllowNullLiteral>] SVGLangSpace =
        abstract xmllang: string with get, set
        abstract xmlspace: string with get, set

    and [<AllowNullLiteral>] SVGLocatable =
        abstract farthestViewportElement: SVGElement with get, set
        abstract nearestViewportElement: SVGElement with get, set
        abstract getBBox: unit -> SVGRect
        abstract getCTM: unit -> SVGMatrix
        abstract getScreenCTM: unit -> SVGMatrix
        abstract getTransformToElement: element: SVGElement -> SVGMatrix

    and [<AllowNullLiteral>] SVGStylable =
        abstract className: obj with get, set
        // TODO
        // abstract style: CSSStyleDeclaration with get, set

    and [<AllowNullLiteral>] SVGTests =
        abstract requiredExtensions: SVGStringList with get, set
        abstract requiredFeatures: SVGStringList with get, set
        abstract systemLanguage: SVGStringList with get, set
        abstract hasExtension: extension: string -> bool

    and [<AllowNullLiteral>] SVGTransformable =
        inherit SVGLocatable
        abstract transform: SVGAnimatedTransformList with get, set

    and [<AllowNullLiteral>] SVGURIReference =
        abstract href: SVGAnimatedString with get, set
