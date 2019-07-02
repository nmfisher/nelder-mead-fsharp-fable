module rec D3

open Fable.Core
open System

let [<Import("*","d3")>] d3 : Selection.IExports = jsNative

// ts2fable 0.6.2
module Selection =

    open Browser.Types

    let [<Import("selection","d3")>] selection: SelectionFn = jsNative
    let [<Import("event","d3")>] ``event``: obj option = jsNative
    let [<Import("namespaces","d3")>] namespaces: NamespaceMap = jsNative

    // Manual type declration to fix the binding
    type TouchList = obj list
    type ElementTagNameMap = obj
    type SVGSVGElement = obj
    type [<AllowNullLiteral>] SVGGElement =
        inherit SVGElement
        inherit SVGStylable
        inherit SVGTransformable
        inherit SVGTests
        inherit SVGLangSpace
        inherit SVGExternalResourcesRequired
        abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    type [<AllowNullLiteral>] IExports =
        /// <summary>Select the first element that matches the specified selector string. If no elements match the selector, returns an empty selection.
        /// If multiple elements match the selector, only the first matching element (in document order) will be selected.
        ///
        /// The first generic  "GElement" refers to the type of element to be selected. The second generic "OldDatum" refers to the type of the
        /// datum, on the selected element. This is useful when re-selecting an element with a previously set, know datum type.</summary>
        /// <param name="selector">CSS selector string</param>
        abstract select: selector: string -> Selection<'GElement, 'OldDatum, HTMLElement, obj option>
        /// <summary>Select the specified node element.
        ///
        /// The first generic  "GElement" refers to the type of element to be selected. The second generic "OldDatum" refers to the type of the
        /// datum, on the selected element. This is useful when re-selecting an element with a previously set, know datum type.</summary>
        /// <param name="node">An element to be selected</param>
        abstract select: node: 'GElement -> Selection<'GElement, 'OldDatum, obj, obj>
        /// Create an empty selection.
        abstract selectAll: unit -> Selection<obj, obj, obj, obj>
        /// Create an empty selection.
        abstract selectAll: selector: obj -> Selection<obj, obj, obj, obj>
        /// Create an empty selection.
        // abstract selectAll: selector: obj -> Selection<obj, obj, obj, obj>
        /// <summary>Select all elements that match the specified selector string. The elements will be selected in document order (top-to-bottom).
        /// If no elements in the document match the selector, returns an empty selection.
        ///
        /// The first generic "GElement" refers to the type of element to be selected. The second generic "OldDatum" refers to the type of the
        /// datum, of a selected element. This is useful when re-selecting elements with a previously set, know datum type.</summary>
        /// <param name="selector">CSS selector string</param>
        abstract selectAll: selector: string -> Selection<'GElement, 'OldDatum, HTMLElement, obj option>
        /// <summary>Select the specified array of nodes.
        ///
        /// The first generic "GElement" refers to the type of element to be selected. The second generic "OldDatum" refers to the type of the
        /// datum, of a selected element. This is useful when re-selecting elements with a previously set, know datum type.</summary>
        /// <param name="nodes">An Array of nodes</param>
        abstract selectAll: nodes: ResizeArray<'GElement> -> Selection<'GElement, 'OldDatum, obj, obj>
        /// <summary>Select the specified nodes. This signature allows the selection of nodes contained in a NodeList, HTMLCollection or similar data structure.
        ///
        /// The first generic "GElement" refers to the type of element to be selected. The second generic "OldDatum" refers to the type of the
        /// datum, of a selected element. This is useful when re-selecting elements with a previously set, know datum type.</summary>
        /// <param name="nodes">An Array-like collection of nodes</param>
        abstract selectAll: nodes: ArrayLike<'GElement> -> Selection<'GElement, 'OldDatum, obj, obj>
        /// <summary>Invokes the specified listener, using the specified "that" as "this" context and passing the specified arguments, if any.
        /// During the invocation, d3.event is set to the specified event; after the listener returns (or throws an error),
        /// d3.event is restored to its previous value.
        /// In addition, sets event.sourceEvent to the prior value of d3.event, allowing custom events to retain a reference to the originating native event.
        /// Returns the value returned by the listener.
        ///
        /// The first generic "Context" refers to the "this" context type in which the listener will be invoked.
        /// The second generic "Result" specifies the return type of the listener.</summary>
        /// <param name="event">The event to which d3.event will be set during the listener invocation.</param>
        /// <param name="listener">The event listener function to be invoked. This function will be invoked with the "this" context, provided
        /// by the "that" argument of customEvent(...). It will be passed all optional arguments passed to customEvent(...). The function returns
        /// a value corresponding to the type of the second generic type.</param>
        /// <param name="that">The "this"" context which will be used for the invocation of listener.</param>
        /// <param name="args">A list of optional arguments, which will be passed to listener.</param>
        abstract customEvent: ``event``: BaseEvent * listener: ('Context -> ResizeArray<obj option> -> 'Result) * that: 'Context * [<ParamArray>] args: ResizeArray<obj option> -> 'Result
        /// <summary>Get (x, y)-coordinates of the current event relative to the specified container element.
        /// The container may be an HTML or SVG container element, such as a G element or an SVG element.
        /// The coordinates are returned as a two-element array of numbers [x, y].</summary>
        /// <param name="container">Container element relative to which coordinates are calculated.</param>
        abstract mouse: container: ContainerElement -> float * float
        /// <summary>Returns the x and y coordinates of the touch with the specified identifier associated
        /// with the current event relative to the specified container.
        /// The container may be an HTML or SVG container element, such as a G element or an SVG element.
        /// The coordinates are returned as a two-element array of numbers [x, y] or null if there is no touch with
        /// the specified identifier in touches, returns null; this can be useful for ignoring touchmove events
        /// where the only some touches have moved.
        ///
        /// If touches is not specified, it defaults to the current event’s changedTouches property.</summary>
        /// <param name="container">Container element relative to which coordinates are calculated.</param>
        /// <param name="identifier">Touch Identifier associated with the current event.</param>
        abstract touch: container: ContainerElement * identifier: float -> float * float option
        /// <summary>Return the x and y coordinates of the touch with the specified identifier associated
        /// with the current event relative to the specified container.
        /// The container may be an HTML or SVG container element, such as a G element or an SVG element.
        /// The coordinates are returned as a two-element array of numbers [x, y] or null if there is no touch with
        /// the specified identifier in touches, returns null; this can be useful for ignoring touchmove events
        /// where the only some touches have moved.
        ///
        /// If touches is not specified, it defaults to the current event’s changedTouches property.</summary>
        /// <param name="container">Container element relative to which coordinates are calculated.</param>
        /// <param name="touches">TouchList to be used when identifying the touch.</param>
        /// <param name="identifier">Touch Identifier associated with the current event.</param>
        abstract touch: container: ContainerElement * touches: TouchList * identifier: float -> float * float option
        /// <summary>Return the x and y coordinates of the touches associated with the current event relative to the specified container.
        /// The container may be an HTML or SVG container element, such as a G element or an SVG element.
        /// The coordinates are returned as an array of two-element arrays of numbers [[x1, y1], [x2, y2], …].
        ///
        /// If touches is not specified, it defaults to the current event’s touches property.</summary>
        /// <param name="container">Container element relative to which coordinates are calculated.</param>
        /// <param name="touches">TouchList to be used.</param>
        abstract touches: container: ContainerElement * ?touches: TouchList -> (float * float) array
        /// <summary>Returns the x and y coordinates of the specified event relative to the specified container.
        /// (The event may also be a touch.) The container may be an HTML or SVG container element, such as a G element or an SVG element.
        /// The coordinates are returned as a two-element array of numbers [x, y].</summary>
        /// <param name="container">Container element relative to which coordinates are calculated.</param>
        /// <param name="event">A User interface event (e.g. mouse event, touch or MSGestureEvent) with captured clientX and clientY properties.</param>
        abstract clientPoint: container: ContainerElement * ``event``: ClientPointEvent -> float * float
        /// <summary>Returns the value of the style property with the specified name for the specified node.
        /// If the node has an inline style with the specified name, its value is returned; otherwise, the computed property value is returned.
        /// See also selection.style.</summary>
        /// <param name="node">A DOM node (e.g. HTMLElement, SVGElement) for which to retrieve the style property.</param>
        /// <param name="name">Style property name.</param>
        abstract style: node: Element * name: string -> string
        /// Obtain a new local variable
        ///
        /// The generic refers to the type of the variable to store locally.
        abstract local: unit -> Local<'T>
        /// <summary>Obtain an object with properties of fully qualified namespace string and
        /// name of local by parsing a shorthand string "prefix:local". If the prefix
        /// does not exist in the "namespaces" object provided by d3-selection, then
        /// the local name is returned as a simple string.</summary>
        /// <param name="prefixedLocal">A string composed of the namespace prefix and local
        /// name separated by colon, e.g. "svg:text".</param>
        abstract ``namespace``: prefixedLocal: string -> U2<NamespaceLocalObject, string>
        /// <summary>Returns the owner window for the specified node. If node is a node, returns the owner document’s default view;
        /// if node is a document, returns its default view; otherwise returns the node.</summary>
        /// <param name="DOMNode">A DOM element</param>
        abstract window: DOMNode: U3<Window, Document, Element> -> Window
        /// <summary>Given the specified element name, returns a single-element selection containing
        /// a detached element of the given name in the current document.</summary>
        /// <param name="name">tag name of the element to be added.</param>
        abstract create: name: 'K -> Selection<ElementTagNameMap, obj, obj, obj>
        /// <summary>Given the specified element name, returns a single-element selection containing
        /// a detached element of the given name in the current document.</summary>
        /// <param name="name">Tag name of the element to be added. See "namespace" for details on supported namespace prefixes,
        /// such as for SVG elements.</param>
        abstract create: name: string -> Selection<'NewGElement, obj, obj, obj>
        /// <summary>Given the specified element name, returns a function which creates an element of the given name,
        /// assuming that "this" is the parent element.</summary>
        /// <param name="name">Tag name of the element to be added.</param>
        abstract creator: name: 'K -> (BaseType -> ElementTagNameMap)
        /// <summary>Given the specified element name, returns a function which creates an element of the given name,
        /// assuming that "this" is the parent element.
        ///
        /// The generic refers to the type of the new element to be returned by the creator function.</summary>
        /// <param name="name">Tag name of the element to be added. See "namespace" for details on supported namespace prefixes,
        /// such as for SVG elements.</param>
        abstract creator: name: string -> (BaseType -> 'NewGElement)
        /// <summary>Given the specified selector, returns a function which returns true if "this" element matches the specified selector.</summary>
        /// <param name="selector">A CSS selector string.</param>
        abstract matcher: selector: string -> (BaseType -> bool)
        /// <summary>Given the specified selector, returns a function which returns the first descendant of "this" element
        /// that matches the specified selector.
        ///
        /// The generic refers to the type of the returned descendant element.</summary>
        /// <param name="selector">A CSS selector string.</param>
        abstract selector: selector: string -> (BaseType -> 'DescElement)
        /// <summary>Given the specified selector, returns a function which returns all descendants of "this" element that match the specified selector.
        ///
        /// The generic refers to the type of the returned descendant element.</summary>
        /// <param name="selector">A CSS selector string.</param>
        abstract selectorAll: selector: string -> (BaseType -> NodeListOf<'DescElement>)

    type BaseType =
        U4<Element, EnterElement, Document, Window> option

    [<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
    module BaseType =
        let ofElementOption v: BaseType = v |> Microsoft.FSharp.Core.Option.map U4.Case1
        let ofElement v: BaseType = v |> U4.Case1 |> Some
        let isElement (v: BaseType) = match v with None -> false | Some o -> match o with U4.Case1 _ -> true | _ -> false
        let asElement (v: BaseType) = match v with None -> None | Some o -> match o with U4.Case1 o -> Some o | _ -> None
        let ofEnterElementOption v: BaseType = v |> Microsoft.FSharp.Core.Option.map U4.Case2
        let ofEnterElement v: BaseType = v |> U4.Case2 |> Some
        let isEnterElement (v: BaseType) = match v with None -> false | Some o -> match o with U4.Case2 _ -> true | _ -> false
        let asEnterElement (v: BaseType) = match v with None -> None | Some o -> match o with U4.Case2 o -> Some o | _ -> None
        let ofDocumentOption v: BaseType = v |> Microsoft.FSharp.Core.Option.map U4.Case3
        let ofDocument v: BaseType = v |> U4.Case3 |> Some
        let isDocument (v: BaseType) = match v with None -> false | Some o -> match o with U4.Case3 _ -> true | _ -> false
        let asDocument (v: BaseType) = match v with None -> None | Some o -> match o with U4.Case3 o -> Some o | _ -> None
        let ofWindowOption v: BaseType = v |> Microsoft.FSharp.Core.Option.map U4.Case4
        let ofWindow v: BaseType = v |> U4.Case4 |> Some
        let isWindow (v: BaseType) = match v with None -> false | Some o -> match o with U4.Case4 _ -> true | _ -> false
        let asWindow (v: BaseType) = match v with None -> None | Some o -> match o with U4.Case4 o -> Some o | _ -> None

    /// A helper interface which covers arguments like NodeListOf<T> or HTMLCollectionOf<T>
    /// argument types
    type [<AllowNullLiteral>] ArrayLike<'T> =
        abstract length: float with get, set
        abstract item: index: float -> 'T option
        [<Emit "$0[$1]{{=$2}}">] abstract Item: index: float -> 'T with get, set

    /// An interface describing the element type of the Enter Selection group elements
    /// created when invoking selection.enter().
    type [<AllowNullLiteral>] EnterElement =
        abstract ownerDocument: Document with get, set
        abstract namespaceURI: string with get, set
        abstract appendChild: newChild: Node -> Node
        abstract insertBefore: newChild: Node * refChild: Node -> Node
        abstract querySelector: selectors: string -> Element
        abstract querySelectorAll: selectors: string -> NodeListOf<Element>

    type ContainerElement =
        U3<HTMLElement, SVGSVGElement, SVGGElement>

    // [<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
    // module ContainerElement =
    //     let ofHTMLElement v: ContainerElement = v |> U3.Case1
    //     let isHTMLElement (v: ContainerElement) = match v with U3.Case1 _ -> true | _ -> false
    //     let asHTMLElement (v: ContainerElement) = match v with U3.Case1 o -> Some o | _ -> None
    //     let ofSVGSVGElement v: ContainerElement = v |> U3.Case2
    //     let isSVGSVGElement (v: ContainerElement) = match v with U3.Case2 _ -> true | _ -> false
    //     let asSVGSVGElement (v: ContainerElement) = match v with U3.Case2 o -> Some o | _ -> None
    //     let ofSVGGElement v: ContainerElement = v |> U3.Case3
    //     let isSVGGElement (v: ContainerElement) = match v with U3.Case3 _ -> true | _ -> false
    //     let asSVGGElement (v: ContainerElement) = match v with U3.Case3 o -> Some o | _ -> None

    /// A User interface event (e.g. mouse event, touch or MSGestureEvent) with captured clientX and clientY properties.
    type [<AllowNullLiteral>] ClientPointEvent =
        abstract clientX: float with get, set
        abstract clientY: float with get, set

    /// Interface for optional parameters map, when dispatching custom events
    /// on a selection
    type [<AllowNullLiteral>] CustomEventParameters =
        /// If true, the event is dispatched to ancestors in reverse tree order
        abstract bubbles: bool with get, set
        /// If true, event.preventDefault is allowed
        abstract cancelable: bool with get, set
        /// Any custom data associated with the event
        abstract detail: obj option with get, set

    type [<AllowNullLiteral>] ValueFn<'T, 'Datum, 'Result> =
        [<Emit "$0($1...)">] abstract Invoke: this: 'T * datum: 'Datum * index: float * groups: U2<ResizeArray<'T>, ArrayLike<'T>> -> 'Result

    /// TransitionLike is a helper interface to represent a quasi-Transition, without specifying the full Transition  interface in this file.
    /// For example, wherever d3-zoom allows a Transition to be passed in as an argument, it internally immediately invokes its `selection()`
    /// method to retrieve the underlying Selection object before proceeding.
    /// d3-brush uses a subset of Transition methods internally.
    /// The use of this interface instead of the full imported Transition interface is [referred] to achieve
    /// two things:
    /// (1) the d3-transition module may not be required by a projects use case,
    /// (2) it avoids possible complications from 'module augmentation' from d3-transition to Selection.
    type [<AllowNullLiteral>] TransitionLike<'GElement, 'Datum> =
        abstract selection: unit -> Selection<'GElement, 'Datum, obj option, obj option>
        abstract on: ``type``: string * listener: obj -> TransitionLike<'GElement, 'Datum>
        abstract on: ``type``: string * listener: ValueFn<'GElement, 'Datum, unit> -> TransitionLike<'GElement, 'Datum>
        abstract tween: name: string * tweenFn: obj -> TransitionLike<'GElement, 'Datum>
        abstract tween: name: string * tweenFn: ValueFn<'GElement, 'Datum, (float -> unit)> -> TransitionLike<'GElement, 'Datum>

    /// A D3 Selection of elements.
    ///
    /// The first generic "GElement" refers to the type of the selected element(s).
    /// The second generic "Datum" refers to the type of the datum of a selected element(s).
    /// The third generic "PElement" refers to the type of the parent element(s) in the D3 selection.
    /// The fourth generic "PDatum" refers to the type of the datum of the parent element(s).
    type [<AllowNullLiteral>] Selection<'GElement, 'Datum, 'PElement, 'PDatum> =
        /// <summary>For each selected element, select the first descendant element that matches the specified selector string.
        /// If no element matches the specified selector for the current element, the element at the current index will
        /// be null in the returned selection. If multiple elements match the selector, only the first matching element
        /// in document order is selected. Selection.select does not affect grouping: it preserves the existing group
        /// structure and indexes, and propagates data (if any) to selected children.
        ///
        /// If the current element has associated data, this data is propagated to the
        /// corresponding selected element.
        ///
        /// The generic represents the type of the descendant element to be selected.</summary>
        /// <param name="selector">CSS selector string</param>
        abstract select: selector: string -> Selection<'DescElement, 'Datum, 'PElement, 'PDatum>
        /// Create an empty sub-selection. Selection.select does not affect grouping: it preserves the existing group
        /// structure and indexes.
        abstract select: selector: obj -> Selection<obj, obj, 'PElement, 'PDatum>
        /// <summary>For each selected element, select the descendant element returned by the selector function.
        /// If no element is returned by the selector function for the current element, the element at the
        /// current index will be null in the returned selection. Selection.select does not affect grouping:
        /// it preserves the existing group structure and indexes, and propagates data (if any) to selected children.
        ///
        /// If the current element has associated data, this data is propagated to the
        /// corresponding selected element.
        ///
        /// The generic represents the type of the descendant element to be selected.</summary>
        /// <param name="selector">A selector function, which is evaluated for each selected element, in order, being passed the current datum (d),
        /// the current index (i), and the current group (nodes), with this as the current DOM element (nodes[i]).
        /// It must return an element, or null if there is no matching element.</param>
        abstract select: selector: ValueFn<'GElement, 'Datum, 'DescElement> -> Selection<'DescElement, 'Datum, 'PElement, 'PDatum>
        /// Create an empty sub-selection. Selection.selectAll does affect grouping: The elements in the returned
        /// selection are grouped by their corresponding parent node in this selection, the group at the current index will be empty.
        abstract selectAll: unit -> Selection<obj, obj, 'GElement, 'Datum>
        /// Create an empty sub-selection. Selection.selectAll does affect grouping: The elements in the returned
        /// selection are grouped by their corresponding parent node in this selection, the group at the current index will be empty.
        abstract selectAll: selector: obj -> Selection<obj, obj, 'GElement, 'Datum>
        /// Create an empty sub-selection. Selection.selectAll does affect grouping: The elements in the returned
        /// selection are grouped by their corresponding parent node in this selection, the group at the current index will be empty.
        // abstract selectAll: selector: obj -> Selection<obj, obj, 'GElement, 'Datum>
        /// <summary>For each selected element, selects the descendant elements that match the specified selector string. The elements in the returned
        /// selection are grouped by their corresponding parent node in this selection. If no element matches the specified selector
        /// for the current element, the group at the current index will be empty. Selection.selectAll does affect grouping: each selected descendant
        /// is grouped by the parent element in the originating selection.
        ///
        /// The selected elements do not inherit data from this selection; use selection.data to propagate data to children.
        ///
        /// The first generic "DescElement" refers to the type of descendant element to be selected. The second generic "OldDatum" refers to the type of the
        /// datum, of a selected element. This is useful when re-selecting elements with a previously set, know datum type.</summary>
        /// <param name="selector">CSS selector string</param>
        abstract selectAll: selector: string -> Selection<'DescElement, 'OldDatum, 'GElement, 'Datum>
        /// <summary>For each selected element, selects the descendant elements returned by the selector function. The elements in the returned
        /// selection are grouped by their corresponding parent node in this selection. If no element matches the specified selector
        /// for the current element, the group at the current index will be empty. Selection.selectAll does affect grouping: each selected descendant
        /// is grouped by the parent element in the originating selection.
        ///
        /// The selected elements do not inherit data from this selection; use selection.data to propagate data to children.
        ///
        /// The first generic "DescElement" refers to the type of descendant element to be selected. The second generic "OldDatum" refers to the type of the
        /// datum, of a selected element. This is useful when re-selecting elements with a previously set, know datum type.</summary>
        /// <param name="selector">A selector function which is evaluated for each selected element, in order, being passed the current datum (d),
        /// the current index (i), and the current group (nodes), with this as the current DOM element (nodes[i]). It must return an array of elements
        /// (or a pseudo-array, such as a NodeList), or the empty array if there are no matching elements.</param>
        abstract selectAll: selector: ValueFn<'GElement, 'Datum, U2<ResizeArray<'DescElement>, ArrayLike<'DescElement>>> -> Selection<'DescElement, 'OldDatum, 'GElement, 'Datum>
        /// <summary>Return the current value of the specified attribute for the first (non-null) element in the selection.
        /// This is generally useful only if you know that the selection contains exactly one element.</summary>
        /// <param name="name">Name of the attribute</param>
        abstract attr: name: string -> string
        /// <summary>Clear the attribute with the specified name for the selected elements and returns this selection.</summary>
        /// <param name="name">Name of the attribute</param>
        /// <param name="value">null,to clear the attribute</param>
        abstract attr: name: string * value: obj -> Selection<'GElement, 'Datum, 'PElement, 'PDatum>
        /// <summary>Sets the value of the attribute with the specified name for the selected elements and returns this selection.
        /// All elements are given the same attribute value.</summary>
        /// <param name="name">Name of the attribute</param>
        /// <param name="value">Constant value for the attribute</param>
        abstract attr: name: string * value: U3<string, float, bool> -> Selection<'GElement, 'Datum, 'PElement, 'PDatum>
        /// <summary>Sets the value of the attribute with the specified name for the selected elements and returns this selection.
        /// The value for the individual selected elements is determined by the value function.</summary>
        /// <param name="name">Name of the attribute</param>
        /// <param name="value">A value function which is evaluated for each selected element, in order, being passed the current datum (d),
        /// the current index (i), and the current group (nodes), with this as the current DOM element (nodes[i]).  A null value will clear the attribute.</param>
        abstract attr: name: string * value: ValueFn<'GElement, 'Datum, U3<string, float, bool> option> -> Selection<'GElement, 'Datum, 'PElement, 'PDatum>
        /// Returns true if and only if the first (non-null) selected element has the specified classes.
        /// This is generally useful only if you know the selection contains exactly one element.
        abstract classed: names: string -> bool
        /// <summary>Assigns or unassigns the specified CSS class names on the selected elements by setting
        /// the class attribute or modifying the classList property and returns this selection.
        /// If the constant value is truthy, then all elements are assigned the specified classes; otherwise, the classes are unassigned.</summary>
        /// <param name="names">A string of space-separated class names.</param>
        /// <param name="value">A boolean flag (true = assign / false = unassign)</param>
        abstract classed: names: string * value: bool -> Selection<'GElement, 'Datum, 'PElement, 'PDatum>
        /// <summary>Assigns or unassigns the specified CSS class names on the selected elements by setting
        /// the class attribute or modifying the classList property and returns this selection.
        /// The assign/unassign status for the individual selected elements is determined by the boolean return
        /// value of the value function.</summary>
        /// <param name="names">A string of space-separated class names.</param>
        /// <param name="value">A value function which is evaluated for each selected element, in order,
        /// being passed the current datum (d), the current index (i), and the current group (nodes), with this as the current DOM element (nodes[i]).
        /// The function’s return value is then used to assign or unassign classes on each element.</param>
        abstract classed: names: string * value: ValueFn<'GElement, 'Datum, bool> -> Selection<'GElement, 'Datum, 'PElement, 'PDatum>
        /// <summary>Returns the current value of the specified style property for the first (non-null) element in the selection.
        /// The current value is defined as the element’s inline value, if present, and otherwise its computed value.
        /// Accessing the current style value is generally useful only if you know the selection contains exactly one element.</summary>
        /// <param name="name">Name of the style</param>
        abstract style: name: string -> string
        /// <summary>Clear the style with the specified name for the selected elements and returns this selection.</summary>
        /// <param name="name">Name of the style</param>
        /// <param name="value">null,to clear the style</param>
        abstract style: name: string * value: obj -> Selection<'GElement, 'Datum, 'PElement, 'PDatum>
        /// <summary>Sets the value of the style with the specified name for the selected elements and returns this selection.
        /// All elements are given the same style value.</summary>
        /// <param name="name">Name of the style</param>
        /// <param name="value">Constant value for the style</param>
        /// <param name="priority">An optional priority flag, either null or the string important (without the exclamation point)</param>
        abstract style: name: string * value: U3<string, float, bool> * ?priority: string -> Selection<'GElement, 'Datum, 'PElement, 'PDatum>
        /// <summary>Sets the value of the style with the specified name for the selected elements and returns this selection.
        /// The value for the individual selected elements is determined by the value function.</summary>
        /// <param name="name">Name of the style</param>
        /// <param name="value">A value function which is evaluated for each selected element, in order, being passed the current datum (d),
        /// the current index (i), and the current group (nodes), with this as the current DOM element (nodes[i]).  A null value will clear the style.</param>
        /// <param name="priority">An optional priority flag, either null or the string important (without the exclamation point)</param>
        abstract style: name: string * value: ValueFn<'GElement, 'Datum, U3<string, float, bool> option> * ?priority: string -> Selection<'GElement, 'Datum, 'PElement, 'PDatum>
        /// <summary>Return the current value of the specified property for the first (non-null) element in the selection.
        /// This is generally useful only if you know that the selection contains exactly one element.</summary>
        /// <param name="name">Name of the property</param>
        abstract property: name: string -> obj option
        /// <summary>Look up a local variable on the first node of this selection. Note that this is not equivalent to `local.get(selection.node())` in that it will not look up locals set on the parent node(s).</summary>
        /// <param name="name">The `d3.local` variable to look up.</param>
        abstract property: name: Local<'T> -> 'T option
        /// <summary>Sets the value of the property with the specified name for the selected elements and returns this selection.
        /// The value for the individual selected elements is determined by the value function.
        ///
        /// Some HTML elements have special properties that are not addressable using attributes or styles,
        /// such as a form field’s text value and a checkbox’s checked boolean. Use this method to get or set these properties.</summary>
        /// <param name="name">Name of the property</param>
        /// <param name="value">A value function which is evaluated for each selected element, in order, being passed the current datum (d),
        /// the current index (i), and the current group (nodes), with this as the current DOM element (nodes[i]).  A null value will clear the property.</param>
        abstract property: name: string * value: ValueFn<'GElement, 'Datum, obj option> -> Selection<'GElement, 'Datum, 'PElement, 'PDatum>
        /// <summary>Clears the property with the specified name for the selected elements and returns this selection.</summary>
        /// <param name="name">Name of the property</param>
        /// <param name="value">null,to clear the property</param>
        abstract property: name: string * value: obj -> Selection<'GElement, 'Datum, 'PElement, 'PDatum>
        /// <summary>Sets the value of the property with the specified name for the selected elements and returns this selection.
        /// All elements are given the same property value.</summary>
        /// <param name="name">Name of the property</param>
        /// <param name="value">Constant value for the property</param>
        abstract property: name: string * value: obj option -> Selection<'GElement, 'Datum, 'PElement, 'PDatum>
        /// <summary>Store a value in a `d3.local` variable.
        /// This is equivalent to `selection.each(function (d, i, g) { name.set(this, value.call(this, d, i, g)); })` but more concise.</summary>
        /// <param name="name">A `d3.local` variable</param>
        /// <param name="value">A callback that returns the value to store</param>
        abstract property: name: Local<'T> * value: ValueFn<'GElement, 'Datum, 'T> -> Selection<'GElement, 'Datum, 'PElement, 'PDatum>
        /// <summary>Store a value in a `d3.local` variable for each node in the selection.
        /// This is equivalent to `selection.each(function () { name.set(this, value); })` but more concise.</summary>
        /// <param name="name">A `d3.local` variable</param>
        /// <param name="value">A callback that returns the value to store</param>
        abstract property: name: Local<'T> * value: 'T -> Selection<'GElement, 'Datum, 'PElement, 'PDatum>
        /// Returns the text content for the first (non-null) element in the selection.
        /// This is generally useful only if you know the selection contains exactly one element.
        abstract text: unit -> string
        /// Clear the text content of the selected elements and return the selection.
        abstract text: value: obj -> Selection<'GElement, 'Datum, 'PElement, 'PDatum>
        /// <summary>Sets the text content to the specified value on all selected elements, replacing any existing child elements.
        /// All elements are given the same text content.</summary>
        /// <param name="value">Text content value for the elements.</param>
        abstract text: value: U3<string, float, bool> -> Selection<'GElement, 'Datum, 'PElement, 'PDatum>
        /// <summary>Sets the text content to the specified value on all selected elements, replacing any existing child elements.
        /// All elements are given the same text content.</summary>
        /// <param name="value">A value unction which is evaluated for each selected element, in order, being passed the current datum (d),
        /// the current index (i), and the current group (nodes), with this as the current DOM element (nodes[i]).
        /// The function’s return value is then used to set each element’s text content. A null value will clear the content.</param>
        abstract text: value: ValueFn<'GElement, 'Datum, U3<string, float, bool> option> -> Selection<'GElement, 'Datum, 'PElement, 'PDatum>
        /// Returns a string representation of the inner HTML for the first (non-null) element in the selection.
        /// This is generally useful only if you know the selection contains exactly one element.
        abstract html: unit -> string
        /// Clear the html content of the selected elements and return the selection.
        abstract html: value: obj -> Selection<'GElement, 'Datum, 'PElement, 'PDatum>
        /// <summary>Sets the inner HTML to the specified value on all selected elements, replacing any existing child elements.
        /// All elements are given the same inner HTML</summary>
        /// <param name="value">String representation of inner HTML.</param>
        abstract html: value: string -> Selection<'GElement, 'Datum, 'PElement, 'PDatum>
        /// <summary>Sets the inner HTML to the specified value on all selected elements, replacing any existing child elements.
        /// The inner HTML is determined for each individual element using a value function.</summary>
        /// <param name="value">A value function which is evaluated for each selected element, in order, being passed the current
        /// datum (d), the current index (i), and the current group (nodes), with this as the current DOM element (nodes[i]).
        /// The function’s return value is then used to set each element’s inner HTML. A null value will clear the content.</param>
        abstract html: value: ValueFn<'GElement, 'Datum, string option> -> Selection<'GElement, 'Datum, 'PElement, 'PDatum>
        /// <summary>Appends a new element of this type (tag name) as the last child of each selected element,
        /// or before the next following sibling in the update selection if this is an enter selection.
        /// The latter behavior for enter selections allows you to insert elements into the DOM in an order consistent with the new bound data;
        /// however, note that selection.order may still be required if updating elements change order
        /// (i.e., if the order of new data is inconsistent with old data).
        ///
        /// This method returns a new selection containing the appended elements.
        /// Each new element inherits the data of the current elements, if any.</summary>
        /// <param name="type">A string representing the tag name.</param>
        abstract append: ``type``: 'K -> Selection<ElementTagNameMap, 'Datum, 'PElement, 'PDatum>
        /// <summary>Appends a new element of this type (tag name) as the last child of each selected element,
        /// or before the next following sibling in the update selection if this is an enter selection.
        /// The latter behavior for enter selections allows you to insert elements into the DOM in an order consistent with the new bound data;
        /// however, note that selection.order may still be required if updating elements change order
        /// (i.e., if the order of new data is inconsistent with old data).
        ///
        /// This method returns a new selection containing the appended elements.
        /// Each new element inherits the data of the current elements, if any.
        ///
        /// The generic refers to the type of the child element to be appended.</summary>
        /// <param name="type">A string representing the tag name. The specified name may have a namespace prefix, such as svg:text
        /// to specify a text attribute in the SVG namespace. If no namespace is specified, the namespace will be inherited
        /// from the parent element; or, if the name is one of the known prefixes, the corresponding namespace will be used
        /// (for example, svg implies svg:svg)</param>
        abstract append: ``type``: string -> Selection<'ChildElement, 'Datum, 'PElement, 'PDatum>
        /// <summary>Appends a new element of the type provided by the element creator function as the last child of each selected element,
        /// or before the next following sibling in the update selection if this is an enter selection.
        /// The latter behavior for enter selections allows you to insert elements into the DOM in an order consistent with the new bound data;
        /// however, note that selection.order may still be required if updating elements change order
        /// (i.e., if the order of new data is inconsistent with old data).
        ///
        /// This method returns a new selection containing the appended elements.
        /// Each new element inherits the data of the current elements, if any.
        ///
        /// The generic refers to the type of the child element to be appended.</summary>
        /// <param name="type">A creator function which is evaluated for each selected element, in order, being passed the current datum (d),
        /// the current index (i), and the current group (nodes), with this as the current DOM element (nodes[i]). This function should return
        /// an element to be appended. (The function typically creates a new element, but it may instead return an existing element.)</param>
        abstract append: ``type``: ValueFn<'GElement, 'Datum, 'ChildElement> -> Selection<'ChildElement, 'Datum, 'PElement, 'PDatum>
        /// <summary>Inserts a new element of the specified type (tag name) before the first element matching the specified
        /// before selector for each selected element. For example, a before selector :first-child will prepend nodes before the first child.
        /// If before is not specified, it defaults to null. (To append elements in an order consistent with bound data, use selection.append.)
        ///
        /// This method returns a new selection containing the appended elements.
        /// Each new element inherits the data of the current elements, if any.
        ///
        /// The generic refers to the type of the child element to be appended.</summary>
        /// <param name="type">A string representing the tag name for the element type to be inserted.</param>
        /// <param name="before">One of:
        /// * A CSS selector string for the element before which the insertion should occur.
        /// * A child selector function which is evaluated for each selected element, in order, being passed the current datum (d),
        /// the current index (i), and the current group (nodes), with this as the current DOM element (nodes[i]). This function should return the child element
        /// before which the element should be inserted.</param>
        abstract insert: ``type``: 'K * ?before: U2<string, ValueFn<'GElement, 'Datum, BaseType>> -> Selection<ElementTagNameMap, 'Datum, 'PElement, 'PDatum>
        /// <summary>Inserts a new element of the specified type (tag name) before the first element matching the specified
        /// before selector for each selected element. For example, a before selector :first-child will prepend nodes before the first child.
        /// If before is not specified, it defaults to null. (To append elements in an order consistent with bound data, use selection.append.)
        ///
        /// This method returns a new selection containing the appended elements.
        /// Each new element inherits the data of the current elements, if any.
        ///
        /// The generic refers to the type of the child element to be appended.</summary>
        /// <param name="type">One of:
        /// * A string representing the tag name for the element type to be inserted. The specified name may have a namespace prefix,
        /// such as svg:text to specify a text attribute in the SVG namespace. If no namespace is specified, the namespace will be inherited
        /// from the parent element; or, if the name is one of the known prefixes, the corresponding namespace will be used
        /// (for example, svg implies svg:svg)
        /// * A creator function which is evaluated for each selected element, in order, being passed the current datum (d),
        /// the current index (i), and the current group (nodes), with this as the current DOM element (nodes[i]). This function should return
        /// an element to be inserted. (The function typically creates a new element, but it may instead return an existing element.)</param>
        /// <param name="before">One of:
        /// * A CSS selector string for the element before which the insertion should occur.
        /// * A child selector function which is evaluated for each selected element, in order, being passed the current datum (d),
        /// the current index (i), and the current group (nodes), with this as the current DOM element (nodes[i]). This function should return the child element
        /// before which the element should be inserted.</param>
        abstract insert: ``type``: U2<string, ValueFn<'GElement, 'Datum, 'ChildElement>> * ?before: U2<string, ValueFn<'GElement, 'Datum, BaseType>> -> Selection<'ChildElement, 'Datum, 'PElement, 'PDatum>
        /// Removes the selected elements from the document.
        /// Returns this selection (the removed elements) which are now detached from the DOM.
        abstract remove: unit -> Selection<'GElement, 'Datum, 'PElement, 'PDatum>
        /// <summary>Inserts clones of the selected elements immediately following the selected elements and returns a selection of the newly
        /// added clones. If deep is true, the descendant nodes of the selected elements will be cloned as well. Otherwise, only the elements
        /// themselves will be cloned.</summary>
        /// <param name="deep">Perform deep cloning if this flag is set to true.</param>
        abstract clone: ?deep: bool -> Selection<'GElement, 'Datum, 'PElement, 'PDatum>
        /// <summary>Returns a new selection merging this selection with the specified other selection.
        /// The returned selection has the same number of groups and the same parents as this selection.
        /// Any missing (null) elements in this selection are filled with the corresponding element,
        /// if present (not null), from the specified selection. (If the other selection has additional groups or parents,
        /// they are ignored.)
        ///
        /// This method is commonly used to merge the enter and update selections after a data-join.
        /// After modifying the entering and updating elements separately, you can merge the two selections and
        /// perform operations on both without duplicate code.
        ///
        /// This method is not intended for concatenating arbitrary selections, however: if both this selection
        /// and the specified other selection have (non-null) elements at the same index, this selection’s element
        /// is returned in the merge and the other selection’s element is ignored.</summary>
        /// <param name="other">Selection to be merged.</param>
        abstract merge: other: Selection<'GElement, 'Datum, 'PElement, 'PDatum> -> Selection<'GElement, 'Datum, 'PElement, 'PDatum>
        /// <summary>Filters the selection, returning a new selection that contains only the elements for
        /// which the specified filter is true.
        ///
        /// The returned filtered selection preserves the parents of this selection, but like array.filter,
        /// it does not preserve indexes as some elements may be removed; use selection.select to preserve the index, if needed.</summary>
        /// <param name="selector">A CSS selector string to match when filtering.</param>
        abstract filter: selector: string -> Selection<'GElement, 'Datum, 'PElement, 'PDatum>
        /// <summary>Filters the selection, returning a new selection that contains only the elements for
        /// which the specified filter is true.
        ///
        /// The returned filtered selection preserves the parents of this selection, but like array.filter,
        /// it does not preserve indexes as some elements may be removed; use selection.select to preserve the index, if needed.
        ///
        /// The generic refers to the type of element which will be selected after applying the filter, i.e. if the element types
        /// contained in a pre-filter selection are narrowed to a subset as part of the filtering.</summary>
        /// <param name="selector">A CSS selector string to match when filtering.</param>
        abstract filter: selector: string -> Selection<'FilteredElement, 'Datum, 'PElement, 'PDatum>
        /// <summary>Filter the selection, returning a new selection that contains only the elements for
        /// which the specified filter is true.
        ///
        /// The returned filtered selection preserves the parents of this selection, but like array.filter,
        /// it does not preserve indexes as some elements may be removed; use selection.select to preserve the index, if needed.</summary>
        /// <param name="selector">A value function which is evaluated for each selected element, in order, being passed the current datum (d),
        /// the current index (i), and the current group (nodes), with this as the current DOM element (nodes[i]). This function should return true
        /// for an element to be included, and false otherwise.</param>
        abstract filter: selector: ValueFn<'GElement, 'Datum, bool> -> Selection<'GElement, 'Datum, 'PElement, 'PDatum>
        /// <summary>Filter the selection, returning a new selection that contains only the elements for
        /// which the specified filter is true.
        ///
        /// The returned filtered selection preserves the parents of this selection, but like array.filter,
        /// it does not preserve indexes as some elements may be removed; use selection.select to preserve the index, if needed.</summary>
        /// <param name="selector">A value function which is evaluated for each selected element, in order, being passed the current datum (d),
        /// the current index (i), and the current group (nodes), with this as the current DOM element (nodes[i]). This function should return true
        /// for an element to be included, and false otherwise.</param>
        abstract filter: selector: ValueFn<'GElement, 'Datum, bool> -> Selection<'FilteredElement, 'Datum, 'PElement, 'PDatum>
        /// <summary>Return a new selection that contains a copy of each group in this selection sorted according
        /// to the compare function. After sorting, re-inserts elements to match the resulting order (per selection.order).
        ///
        /// Note that sorting is not guaranteed to be stable; however, it is guaranteed to have the same
        /// behavior as your browser’s built-in sort method on arrays.</summary>
        /// <param name="comparator">An optional comparator function, which defaults to "ascending". The function is passed
        /// two elements’ data a and b to compare. It should return either a negative, positive, or zero value.
        /// If negative, then a should be before b; if positive, then a should be after b; otherwise, a and b are
        /// considered equal and the order is arbitrary.</param>
        abstract sort: ?comparator: ('Datum -> 'Datum -> float) -> Selection<'GElement, 'Datum, 'PElement, 'PDatum>
        /// Re-insert elements into the document such that the document order of each group matches the selection order.
        /// This is equivalent to calling selection.sort if the data is already sorted, but much faster.
        abstract order: unit -> Selection<'GElement, 'Datum, 'PElement, 'PDatum>
        /// Re-insert each selected element, in order, as the last child of its parent.
        abstract raise: unit -> Selection<'GElement, 'Datum, 'PElement, 'PDatum>
        /// Re-insert each selected element, in order, as the first child of its parent.
        abstract lower: unit -> Selection<'GElement, 'Datum, 'PElement, 'PDatum>
        /// Returns the bound datum for the first (non-null) element in the selection.
        /// This is generally useful only if you know the selection contains exactly one element.
        abstract datum: unit -> 'Datum
        /// Delete the bound data for each element in the selection.
        abstract datum: value: obj -> Selection<'GElement, obj, 'PElement, 'PDatum>
        /// <summary>Sets the element’s bound data using the specified value function on all selected elements.
        /// Unlike selection.data, this method does not compute a join and does not affect
        /// indexes or the enter and exit selections.
        ///
        /// The generic refers to the type of the new datum to be used for the selected elements.</summary>
        /// <param name="value">A value function which is evaluated for each selected element, in order,
        /// being passed the current datum (d), the current index (i), and the current group (nodes),
        /// with this as the current DOM element (nodes[i]). The function is then used to set each element’s new data.
        /// A null value will delete the bound data.</param>
        abstract datum: value: ValueFn<'GElement, 'Datum, 'NewDatum> -> Selection<'GElement, 'NewDatum, 'PElement, 'PDatum>
        /// <summary>Sets the element’s bound data to the specified value on all selected elements.
        /// Unlike selection.data, this method does not compute a join and does not affect
        /// indexes or the enter and exit selections.
        ///
        /// The generic refers to the type of the new datum to be used for the selected elements.</summary>
        /// <param name="value">A value object to be used as the datum for each element.</param>
        abstract datum: value: 'NewDatum -> Selection<'GElement, 'NewDatum, 'PElement, 'PDatum>
        /// Returns the array of data for the selected elements.
        abstract data: unit -> ResizeArray<'Datum>
        /// <summary>Joins the specified array of data with the selected elements, returning a new selection that represents
        /// the update selection: the elements successfully bound to data. Also defines the enter and exit selections on
        /// the returned selection, which can be used to add or remove elements to correspond to the new data.
        ///
        /// The data is specified for each group in the selection. If the selection has multiple groups
        /// (such as d3.selectAll followed by selection.selectAll), then data should typically be specified as a function.
        ///
        /// If a key function is not specified, then the first datum in data is assigned to the first selected element,
        /// the second datum to the second selected element, and so on.
        /// A key function may be specified to control which datum is assigned to which element, replacing the default join-by-index,
        /// by computing a string identifier for each datum and element.
        ///
        /// The update and enter selections are returned in data order, while the exit selection preserves the selection
        /// order prior to the join. If a key function is specified, the order of elements in the selection may not match
        /// their order in the document; use selection.order or selection.sort as needed.
        ///
        /// This method cannot be used to clear bound data; use selection.datum instead.
        ///
        /// For details see: {@link https://github.com/d3/d3-selection#joining-data }
        ///
        /// The generic refers to the type of the new datum to be used for the selected elements.</summary>
        /// <param name="data">The specified data is an array of arbitrary values (e.g., numbers or objects).</param>
        /// <param name="key">An optional key function which is evaluated for each selected element, in order, being passed the
        /// current datum (d), the current index (i), and the current group (nodes), with this as the current DOM element (nodes[i]); the returned string is the element’s key.
        /// The key function is then also evaluated for each new datum in data, being passed the current datum (d),
        /// the current index (i), and the group’s new data, with this as the group’s parent DOM element (nodes[i]); the returned string is the datum’s key.
        /// The datum for a given key is assigned to the element with the matching key. If multiple elements have the same key,
        /// the duplicate elements are put into the exit selection; if multiple data have the same key, the duplicate data are put into the enter selection.</param>
        abstract data: data: ResizeArray<'NewDatum> * ?key: ValueFn<U2<'GElement, 'PElement>, U2<'Datum, 'NewDatum>, string> -> Selection<'GElement, 'NewDatum, 'PElement, 'PDatum>
        /// <summary>Joins the data returned by the specified value function with the selected elements, returning a new selection that it represents
        /// the update selection: the elements successfully bound to data. Also defines the enter and exit selections on
        /// the returned selection, which can be used to add or remove elements to correspond to the new data.
        ///
        /// The data is specified for each group in the selection.
        ///
        /// If a key function is not specified, then the first datum in data is assigned to the first selected element,
        /// the second datum to the second selected element, and so on.
        /// A key function may be specified to control which datum is assigned to which element, replacing the default join-by-index,
        /// by computing a string identifier for each datum and element.
        ///
        /// The update and enter selections are returned in data order, while the exit selection preserves the selection
        /// order prior to the join. If a key function is specified, the order of elements in the selection may not match
        /// their order in the document; use selection.order or selection.sort as needed.
        ///
        /// This method cannot be used to clear bound data; use selection.datum instead.
        ///
        /// For details see: {@link https://github.com/d3/d3-selection#joining-data }
        ///
        /// The generic refers to the type of the new datum to be used for the selected elements.</summary>
        /// <param name="data">A value function which will be evaluated for each group in order, being passed the group’s parent datum
        /// (d, which may be undefined), the group index (i), and the selection’s parent nodes (nodes),
        /// with this as the group’s parent element. The function returns an array of values for each group.</param>
        /// <param name="key">An optional key function which is evaluated for each selected element, in order, being passed the
        /// current datum (d), the current index (i), and the current group (nodes), with this as the current DOM element (nodes[i]); the returned string is the element’s key.
        /// The key function is then also evaluated for each new datum in data, being passed the current datum (d),
        /// the current index (i), and the group’s new data, with this as the group’s parent DOM element (nodes[i]); the returned string is the datum’s key.
        /// The datum for a given key is assigned to the element with the matching key. If multiple elements have the same key,
        /// the duplicate elements are put into the exit selection; if multiple data have the same key, the duplicate data are put into the enter selection.</param>
        abstract data: data: ValueFn<'PElement, 'PDatum, ResizeArray<'NewDatum>> * ?key: ValueFn<U2<'GElement, 'PElement>, U2<'Datum, 'NewDatum>, string> -> Selection<'GElement, 'NewDatum, 'PElement, 'PDatum>
        /// Appends, removes and reorders elements as necessary to match the data that was previously bound by `selection.data`, returning the merged enter and update selection.
        /// This method is a convenient alternative to the more explicit `selection.enter`, `selection.exit`, `selection.append` and `selection.remove`.
        ///
        /// The "matching" logic is determined by the key function passed to `selection.data`.
        abstract join: enter: 'K * ?update: (Selection<'GElement, 'Datum, 'PElement, 'PDatum> -> Selection<'GElement, 'Datum, 'PElement, 'PDatum> option) * ?exit: (Selection<'GElement, 'OldDatum, 'PElement, 'PDatum> -> unit) -> Selection<U2<'GElement, ElementTagNameMap>, 'Datum, 'PElement, 'PDatum>
        /// Appends, removes and reorders elements as necessary to match the data that was previously bound by `selection.data`, returning the merged enter and update selection.
        /// This method is a convenient alternative to the more explicit `selection.enter`, `selection.exit`, `selection.append` and `selection.remove`.
        ///
        /// The "matching" logic is determined by the key function passed to `selection.data`.
        abstract join: enter: string * ?update: (Selection<'GElement, 'Datum, 'PElement, 'PDatum> -> Selection<'GElement, 'Datum, 'PElement, 'PDatum> option) * ?exit: (Selection<'GElement, 'OldDatum, 'PElement, 'PDatum> -> unit) -> Selection<U2<'ChildElement, 'GElement>, 'Datum, 'PElement, 'PDatum>
        /// Appends, removes and reorders elements as necessary to match the data that was previously bound by `selection.data`, returning the merged enter and update selection.
        /// This method is a convenient alternative to the more explicit `selection.enter`, `selection.exit`, `selection.append` and `selection.remove`.
        ///
        /// The "matching" logic is determined by the key function passed to `selection.data`.
        abstract join: enter: (Selection<EnterElement, 'Datum, 'PElement, 'PDatum> -> Selection<'ChildElement, 'Datum, 'PElement, 'PDatum>) * ?update: (Selection<'GElement, 'Datum, 'PElement, 'PDatum> -> Selection<'GElement, 'Datum, 'PElement, 'PDatum> option) * ?exit: (Selection<'GElement, 'OldDatum, 'PElement, 'PDatum> -> unit) -> Selection<U2<'ChildElement, 'GElement>, 'Datum, 'PElement, 'PDatum>
        /// Return the enter selection: placeholder nodes for each datum that had no corresponding DOM element
        /// in the selection. (The enter selection is empty for selections not returned by selection.data.)
        abstract enter: unit -> Selection<EnterElement, 'Datum, 'PElement, 'PDatum>
        /// Returns the exit selection: existing DOM elements in the selection for which no new datum was found.
        /// (The exit selection is empty for selections not returned by selection.data.)
        ///
        /// IMPORTANT: The generic refers to the type of the old datum associated with the exit selection elements.
        /// Ensure you set the generic to the correct type, if you need to access the data on the exit selection in
        /// follow-up steps, e.g. to set styles as part of an exit transition before removing them.
        abstract exit: unit -> Selection<'GElement, 'OldDatum, 'PElement, 'PDatum>
        /// <summary>Return the currently-assigned listener for the specified event typename on the first (non-null) selected element,
        /// if any, If multiple typenames are specified, the first matching listener is returned.</summary>
        /// <param name="typenames">The typenames is a string event type, such as click, mouseover, or submit; any DOM event type supported by your browser may be used.
        /// The type may be optionally followed by a period (.) and a name; the optional name allows multiple callbacks to be registered
        /// to receive events of the same type, such as click.foo and click.bar. To specify multiple typenames, separate typenames with spaces,
        /// such as "input change"" or "click.foo click.bar".</param>
        abstract on: typenames: string -> ValueFn<'GElement, 'Datum, unit> option
        /// <summary>Remove a listener for the specified event type names. To remove all listeners for a given name,
        /// pass null as the listener and ".foo" as the typename, where foo is the name; to remove all listeners with no name, specify "." as the typename.</summary>
        /// <param name="typenames">The typenames is a string event type, such as click, mouseover, or submit; any DOM event type supported by your browser may be used.
        /// The type may be optionally followed by a period (.) and a name; the optional name allows multiple callbacks to be registered
        /// to receive events of the same type, such as click.foo and click.bar. To specify multiple typenames, separate typenames with spaces,
        /// such as "input change"" or "click.foo click.bar".</param>
        /// <param name="listener">null to indicate removal of listener</param>
        abstract on: typenames: string * listener: obj -> Selection<'GElement, 'Datum, 'PElement, 'PDatum>
        /// <summary>Add an event listener for the specified event type names. If an event listener was previously registered for the same typename
        /// on a selected element, the old listener is removed before the new listener is added.
        ///
        /// When a specified event is dispatched on a selected node, the specified listener will be evaluated for each selected element.
        ///
        /// An optional capture flag may be specified which corresponds to the W3C useCapture flag:
        /// "After initiating capture, all events of the specified type will be dispatched to the registered EventListener before being
        /// dispatched to any EventTargets beneath them in the tree. Events which are bubbling upward through the tree will not
        /// trigger an EventListener designated to use capture."</summary>
        /// <param name="typenames">The typenames is a string event type, such as click, mouseover, or submit; any DOM event type supported by your browser may be used.
        /// The type may be optionally followed by a period (.) and a name; the optional name allows multiple callbacks to be registered
        /// to receive events of the same type, such as click.foo and click.bar. To specify multiple typenames, separate typenames with spaces,
        /// such as "input change"" or "click.foo click.bar".</param>
        /// <param name="listener">A listener function which will be evaluated for each selected element, being passed the current datum (d), the current index (i),
        /// and the current group (nodes), with this as the current DOM element (nodes[i]). Listeners always see the latest datum for their element,
        /// but the index is a property of the selection and is fixed when the listener is assigned; to update the index, re-assign the listener.
        /// To access the current event within a listener, use d3.event.</param>
        /// <param name="capture">An optional capture flag which corresponds to the W3C useCapture flag.</param>
        abstract on: typenames: string * listener: ValueFn<'GElement, 'Datum, unit> * ?capture: bool -> Selection<'GElement, 'Datum, 'PElement, 'PDatum>
        /// <summary>Dispatches a custom event of the specified type to each selected element, in order.
        /// An optional parameters map may be specified to set additional properties of the event.</summary>
        /// <param name="type">Name of event to dispatch</param>
        /// <param name="parameters">An optional value map with custom event parameters</param>
        abstract dispatch: ``type``: string * ?parameters: CustomEventParameters -> Selection<'GElement, 'Datum, 'PElement, 'PDatum>
        /// <summary>Dispatches a custom event of the specified type to each selected element, in order.
        /// An optional value function returning a parameters map for each element in the selection may be specified to set additional properties of the event.</summary>
        /// <param name="type">Name of event to dispatch</param>
        /// <param name="parameters">A value function which is evaluated for each selected element, in order,
        /// being passed the current datum (d), the current index (i), and the current group (nodes),
        /// with this as the current DOM element (nodes[i]). It must return the parameters map for the current element.</param>
        abstract dispatch: ``type``: string * ?parameters: ValueFn<'GElement, 'Datum, CustomEventParameters> -> Selection<'GElement, 'Datum, 'PElement, 'PDatum>
        /// <summary>Invoke the specified function for each selected element, passing in the current datum (d),
        /// the current index (i), and the current group (nodes), with this of the current DOM element (nodes[i]).
        /// This method can be used to invoke arbitrary code for each selected element, and is useful for creating a context to access parent and child data simultaneously.</summary>
        /// <param name="func">A function which is invoked for each selected element,
        /// being passed the current datum (d), the current index (i), and the current group (nodes), with this of the current DOM element (nodes[i]).</param>
        abstract each: func: ValueFn<'GElement, 'Datum, unit> -> Selection<'GElement, 'Datum, 'PElement, 'PDatum>
        /// <summary>Invoke the specified function exactly once, passing in this selection along with any optional arguments.
        /// Returns this selection.</summary>
        /// <param name="func">A function which is passed this selection as the first argument along with any optional arguments.</param>
        /// <param name="args">List of optional arguments to be passed to the callback function.</param>
        abstract call: func: (Selection<'GElement, 'Datum, 'PElement, 'PDatum> -> ResizeArray<obj option> -> unit) * [<ParamArray>] args: ResizeArray<obj option> -> Selection<'GElement, 'Datum, 'PElement, 'PDatum>
        /// Return true if this selection contains no (non-null) elements.
        abstract empty: unit -> bool
        /// Return the first (non-null) element in this selection. If the selection is empty, returns null.
        abstract node: unit -> 'GElement option
        /// Return an array of all (non-null) elements in this selection.
        abstract nodes: unit -> ResizeArray<'GElement>
        /// Returns the total number of elements in this selection.
        abstract size: unit -> float


        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///
        /// The next members are coming from `d3-transition` module
        ///
        /////////////////////////////////////////////////////////////////////////////////////////////////////////

        /// <summary>Interrupts the active transition of the specified name on the selected elements, and cancels any pending transitions with the specified name, if any.
        /// If a name is not specified, null is used.
        ///
        /// IMPORTANT: Interrupting a transition on an element has no effect on any transitions on any descendant elements.
        /// For example, an axis transition consists of multiple independent, synchronized transitions on the descendants of the axis G element
        /// (the tick lines, the tick labels, the domain path, etc.). To interrupt the axis transition, you must therefore interrupt the descendants.</summary>
        /// <param name="name">Name of the transition.</param>
        abstract interrupt: ?name: string -> Transition.Transition<'GElement, 'Datum, 'PElement, 'PDatum>
        /// <summary>Returns a new transition on the given selection with the specified name. If a name is not specified, null is used.
        /// The new transition is only exclusive with other transitions of the same name.</summary>
        /// <param name="name">Name of the transition.</param>
        abstract transition: ?name: string -> Transition.Transition<'GElement, 'Datum, 'PElement, 'PDatum>
        /// <summary>Returns a new transition on the given selection.
        ///
        /// When using a transition instance, the returned transition has the same id and name as the specified transition.
        /// If a transition with the same id already exists on a selected element, the existing transition is returned for that element.
        /// Otherwise, the timing of the returned transition is inherited from the existing transition of the same id on the nearest ancestor of each selected element.
        /// Thus, this method can be used to synchronize a transition across multiple selections,
        /// or to re-select a transition for specific elements and modify its configuration.
        ///
        /// If the specified transition is not found on a selected node or its ancestors (such as if the transition already ended),
        /// the default timing parameters are used; however, in a future release, this will likely be changed to throw an error.</summary>
        /// <param name="transition">A transition instance.</param>
        abstract transition: transition: Transition.Transition<BaseType, obj option, obj option, obj option> -> Transition.Transition<'GElement, 'Datum, 'PElement, 'PDatum>

    type [<AllowNullLiteral>] SelectionFn =
        [<Emit "$0($1...)">] abstract Invoke: unit -> Selection<HTMLElement, obj option, obj, obj>

    /// A D3 Base Event
    type [<AllowNullLiteral>] BaseEvent =
        /// Event type
        abstract ``type``: string with get, set
        /// The prior value of d3.event, allowing custom events to retain a reference to the originating native event.
        abstract sourceEvent: obj option with get, set

    type [<AllowNullLiteral>] Local<'T> =
        /// <summary>Retrieves a local variable stored on the node (or one of its parents).</summary>
        /// <param name="node">A node element.</param>
        abstract get: node: Element -> 'T option
        /// <summary>Deletes the value associated with the given node. Values stored on ancestors are not affected, meaning that child nodes will still see inherited values.
        ///
        /// This function returns true if there was a value stored directly on the node, and false otherwise.</summary>
        /// <param name="node">A node element.</param>
        abstract remove: node: Element -> bool
        /// <summary>Store a value for this local variable. Calling `.get()` on children of this node will also retrieve the variable's value.</summary>
        /// <param name="node">A node element.</param>
        /// <param name="value">Value to store locally</param>
        abstract set: node: Element * value: 'T -> Element
        /// Obtain a string with the internally assigned property name for the local
        /// which is used to store the value on a node
        abstract toString: unit -> string

    /// Interface for object literal containing local name with related fully qualified namespace
    type [<AllowNullLiteral>] NamespaceLocalObject =
        /// Fully qualified namespace
        abstract space: string with get, set
        /// Name of the local to be namespaced.
        abstract local: string with get, set

    /// Interface for maps of namespace prefixes to corresponding fully qualified namespace strings
    type [<AllowNullLiteral>] NamespaceMap =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: prefix: string -> string with get, set

    /////////////////////////////////////////////////////////////////////////////////////////////////////////
    ///
    /// The next module is coming from `d3-transition` module
    ///
    /////////////////////////////////////////////////////////////////////////////////////////////////////////

    module Transition =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Return the active transition on the specified node with the specified name, if any.
            /// If no name is specified, null is used. Returns null if there is no such active transition on the specified node.
            /// This method is useful for creating chained transitions.
            ///
            /// The first generic "GElement" refers to the type of element on which the returned active transition was defined. The second generic "Datum" refers to the type of the
            /// datum, of a selected element on which the transition is defined. The third generic refers to the type of the parent elements in the returned Transition.
            /// The fourth generic refers to the type of the datum defined on the parent elements in the returned Transition.</summary>
            /// <param name="node">Element for which the active transition should be returned.</param>
            /// <param name="name">Name of the transition.</param>
            abstract active: node: 'GElement * ?name: string -> Transition<'GElement, 'Datum, 'PElement, 'PDatum> option
            /// <summary>Interrupts the active transition of the specified name on the specified node, and cancels any pending transitions with the specified name, if any.
            /// If a name is not specified, null is used.</summary>
            /// <param name="node">Element for which the transition should be interrupted.</param>
            /// <param name="name">Name of the transition to be interrupted. If a name is not specified, null is used.</param>
            abstract interrupt: node: BaseType * ?name: string -> unit
            /// <summary>Returns a new transition with the specified name. If a name is not specified, null is used.
            /// The new transition is only exclusive with other transitions of the same name.
            ///
            /// The generic "OldDatum" refers to the type of a previously-set datum of the selected HTML element in the Transition.</summary>
            /// <param name="name">Name of the transition.</param>
            abstract transition: ?name: string -> Transition<HTMLElement, 'OldDatum, obj, obj>
            /// <summary>Returns a new transition from an existing transition.
            ///
            /// When using a transition instance, the returned transition has the same id and name as the specified transition.
            ///
            /// The generic "OldDatum" refers to the type of a previously-set datum of the selected HTML element in the Transition.</summary>
            /// <param name="transition">A transition instance.</param>
            abstract transition: transition: Transition<BaseType, obj option, BaseType, obj option> -> Transition<HTMLElement, 'OldDatum, obj, obj>

        /// A D3 Transition.
        ///
        /// The first generic "GElement" refers to the type of the selected element(s) in the Transition.
        /// The second generic "Datum" refers to the type of the datum of a selected element(s) in the Transition.
        /// The third generic "PElement" refers to the type of the parent element(s) in the D3 selection in the Transition.
        /// The fourth generic "PDatum" refers to the type of the datum of the parent element(s) in the Transition.
        type [<AllowNullLiteral>] Transition<'GElement, 'Datum, 'PElement, 'PDatum> =
            /// <summary>For each selected element, select the first descendant element that matches the specified selector string, if any,
            /// and returns a transition on the resulting selection. The new transition has the same id, name and timing as this transition;
            /// however, if a transition with the same id already exists on a selected element,
            /// the existing transition is returned for that element.
            ///
            /// The generic represents the type of the descendant element to be selected.</summary>
            /// <param name="selector">CSS selector string</param>
            abstract select: selector: string -> Transition<'DescElement, 'Datum, 'PElement, 'PDatum>
            /// <summary>For each selected element, select the descendant element returned by the selector function, if any,
            /// and returns a transition on the resulting selection. The new transition has the same id, name and timing as this transition;
            /// however, if a transition with the same id already exists on a selected element,
            /// the existing transition is returned for that element.
            ///
            /// The generic represents the type of the descendant element to be selected.</summary>
            /// <param name="selector">A selector function, which is evaluated for each selected element, in order, being passed the current datum (d),
            /// the current index (i), and the current group (nodes), with this as the current DOM element (nodes[i]).
            /// It must return an element, or null if there is no matching element.</param>
            abstract select: selector: ValueFn<'GElement, 'Datum, 'DescElement> -> Transition<'DescElement, 'Datum, 'PElement, 'PDatum>
            /// <summary>For each selected element, select all descendant elements that match the specified selector string, if any,
            /// and returns a transition on the resulting selection. The new transition has the same id, name and timing as this transition;
            /// however, if a transition with the same id already exists on a selected element, the existing transition is returned for that element.
            ///
            /// The first generic "DescElement" refers to the type of descendant element to be selected. The second generic "OldDatum" refers to the type of the
            /// datum, of a selected element. This is useful when re-selecting elements with a previously set, know datum type.</summary>
            /// <param name="selector">CSS selector string</param>
            abstract selectAll: selector: string -> Transition<'DescElement, 'OldDatum, 'GElement, 'Datum>
            /// <summary>For each selected element, select all descendant elements returned by the selector function, if any,
            /// and returns a transition on the resulting selection. The new transition has the same id, name and timing as this transition;
            /// however, if a transition with the same id already exists on a selected element, the existing transition is returned for that element.
            ///
            /// The first generic "DescElement" refers to the type of descendant element to be selected. The second generic "OldDatum" refers to the type of the
            /// datum, of a selected element. This is useful when re-selecting elements with a previously set, know datum type.</summary>
            /// <param name="selector">A selector function which is evaluated for each selected element, in order, being passed the current datum (d),
            /// the current index (i), and the current group (nodes), with this as the current DOM element (nodes[i]). It must return an array of elements
            /// (or a pseudo-array, such as a NodeList), or the empty array if there are no matching elements.</param>
            abstract selectAll: selector: ValueFn<'GElement, 'Datum, U2<ResizeArray<'DescElement>, ArrayLike<'DescElement>>> -> Transition<'DescElement, 'OldDatum, 'GElement, 'Datum>
            /// Return the selection corresponding to this transition.
            abstract selection: unit -> Selection<'GElement, 'Datum, 'PElement, 'PDatum>
            /// Returns a new transition on the same selected elements as this transition, scheduled to start when this transition ends.
            /// The new transition inherits a reference time equal to this transition’s time plus its delay and duration.
            /// The new transition also inherits this transition’s name, duration, and easing.
            /// This method can be used to schedule a sequence of chained transitions.
            ///
            /// A delay configured for the new transition will be relative to the previous transition.
            abstract transition: unit -> Transition<'GElement, 'Datum, 'PElement, 'PDatum>
            /// <summary>For each selected element, the attribute with the specified name will be cleared at the start of the transition.</summary>
            /// <param name="name">Name of the attribute.</param>
            /// <param name="value">Use null to clear the attribute.</param>
            abstract attr: name: string * value: obj -> Transition<'GElement, 'Datum, 'PElement, 'PDatum>
            /// <summary>For each selected element, assigns the attribute tween for the attribute with the specified name to the specified target value.
            /// The starting value of the tween is the attribute’s value when the transition starts.
            /// The target value is the specified constant value for all elements.
            ///
            /// An interpolator is chosen based on the type of the target value, using the following algorithm:
            /// 1.) If value is a number, use interpolateNumber.
            /// 2.) If value is a color or a string coercible to a color, use interpolateRgb.
            /// 3.) Use interpolateString.
            ///
            /// To apply a different interpolator, use transition.attrTween.</summary>
            /// <param name="name">Name of the attribute.</param>
            /// <param name="value">Target value for the attribute.</param>
            abstract attr: name: string * value: U3<string, float, bool> -> Transition<'GElement, 'Datum, 'PElement, 'PDatum>
            /// <summary>For each selected element, assigns the attribute tween for the attribute with the specified name to the specified target value.
            /// The starting value of the tween is the attribute’s value when the transition starts.
            /// The target value is return value of the value function evaluated for the selected element.
            ///
            /// An interpolator is chosen based on the type of the target value, using the following algorithm:
            /// 1.) If value is a number, use interpolateNumber.
            /// 2.) If value is a color or a string coercible to a color, use interpolateRgb.
            /// 3.) Use interpolateString.
            ///
            /// To apply a different interpolator, use transition.attrTween.</summary>
            /// <param name="name">Name of the attribute.</param>
            /// <param name="value">A value function which is evaluated for each selected element, in order, being passed the current datum (d),
            /// the current index (i), and the current group (nodes), with this as the current DOM element (nodes[i]).
            /// A null value will clear the attribute at the start of the transition.</param>
            abstract attr: name: string * value: ValueFn<'GElement, 'Datum, U3<string, float, bool> option> -> Transition<'GElement, 'Datum, 'PElement, 'PDatum>
            /// <summary>Return the current interpolator factory for attribute with the specified name, or undefined if no such tween exists.</summary>
            /// <param name="name">Name of attribute.</param>
            abstract attrTween: name: string -> ValueFn<'GElement, 'Datum, (float -> string)> option
            /// <summary>Remove the previously-assigned attribute tween of the specified name, if any.</summary>
            /// <param name="name">Name of attribute.</param>
            /// <param name="factory">Use null to remove previously-assigned attribute tween.</param>
            abstract attrTween: name: string * factory: obj -> Transition<'GElement, 'Datum, 'PElement, 'PDatum>
            /// <summary>Assign the attribute tween for the attribute with the specified name to the specified interpolator factory.
            /// An interpolator factory is a function that returns an interpolator; when the transition starts, the factory is evaluated for each selected element.
            /// The returned interpolator will then be invoked for each frame of the transition, in order,
            /// being passed the eased time t, typically in the range [0, 1]. Lastly, the return value of the interpolator will be used to set the attribute value.
            /// The interpolator must return a string.</summary>
            /// <param name="name">Name of attribute.</param>
            /// <param name="factory">An interpolator factory which is evaluated for each selected element, in order, being passed the current datum (d),
            /// the current index (i), and the current group (nodes), with this as the current DOM element (nodes[i]). The interpolator factory returns a string interpolator,
            /// which takes as its argument eased time t, typically in the range [0, 1] and returns the interpolated string.</param>
            abstract attrTween: name: string * factory: ValueFn<'GElement, 'Datum, (float -> string)> -> Transition<'GElement, 'Datum, 'PElement, 'PDatum>
            /// <summary>For each selected element, the style with the specified name will be cleared at the start of the transition.</summary>
            /// <param name="name">Name of the style.</param>
            /// <param name="value">Use null to clear the style.</param>
            abstract style: name: string * value: obj -> Transition<'GElement, 'Datum, 'PElement, 'PDatum>
            /// <summary>For each selected element, assigns the style tween for the style with the specified name to the specified target value with the
            /// specified priority.
            /// The starting value of the tween is the style’s inline value if present, and otherwise its computed value.
            /// The target value is the specified constant value for all elements.
            ///
            /// An interpolator is chosen based on the type of the target value, using the following algorithm:
            /// 1.) If value is a number, use interpolateNumber.
            /// 2.) If value is a color or a string coercible to a color, use interpolateRgb.
            /// 3.) Use interpolateString.
            ///
            /// To apply a different interpolator, use transition.attrTween.</summary>
            /// <param name="name">Name of the style.</param>
            /// <param name="value">Target value for the style.</param>
            /// <param name="priority">An optional priority flag, either null or the string important (without the exclamation point)</param>
            abstract style: name: string * value: U3<string, float, bool> * ?priority: string -> Transition<'GElement, 'Datum, 'PElement, 'PDatum>
            /// <summary>For each selected element, assigns the style tween for the style with the specified name to the specified target value with the
            /// specified priority.
            /// The starting value of the tween is the style's inline value if present, and otherwise its computed value.
            /// The target value is return value of the value function evaluated for the selected element.
            ///
            /// An interpolator is chosen based on the type of the target value, using the following algorithm:
            /// 1.) If value is a number, use interpolateNumber.
            /// 2.) If value is a color or a string coercible to a color, use interpolateRgb.
            /// 3.) Use interpolateString.
            ///
            /// To apply a different interpolator, use transition.attrTween.</summary>
            /// <param name="name">Name of the style.</param>
            /// <param name="value">A value function which is evaluated for each selected element, in order, being passed the current datum (d),
            /// the current index (i), and the current group (nodes), with this as the current DOM element (nodes[i]).
            /// A null value will clear the style at the start of the transition.</param>
            /// <param name="priority">An optional priority flag, either null or the string important (without the exclamation point)</param>
            abstract style: name: string * value: ValueFn<'GElement, 'Datum, U3<string, float, bool> option> * ?priority: string -> Transition<'GElement, 'Datum, 'PElement, 'PDatum>
            /// <summary>Return the current interpolator factory for style with the specified name, or undefined if no such tween exists.</summary>
            /// <param name="name">Name of style.</param>
            abstract styleTween: name: string -> ValueFn<'GElement, 'Datum, (float -> string)> option
            /// <summary>Remove the previously-assigned style tween of the specified name, if any.</summary>
            /// <param name="name">Name of style.</param>
            /// <param name="factory">Use null to remove previously-assigned style tween.</param>
            abstract styleTween: name: string * factory: obj -> Transition<'GElement, 'Datum, 'PElement, 'PDatum>
            /// <summary>Assign the style tween for the style with the specified name to the specified interpolator factory.
            /// An interpolator factory is a function that returns an interpolator; when the transition starts, the factory is evaluated for each selected element.
            /// The returned interpolator will then be invoked for each frame of the transition, in order,
            /// being passed the eased time t, typically in the range [0, 1]. Lastly, the return value of the interpolator will be used to set the style value.
            /// The interpolator must return a string.</summary>
            /// <param name="name">Name of style.</param>
            /// <param name="factory">An interpolator factory which is evaluated for each selected element, in order, being passed the current datum (d),
            /// the current index (i), and the current group (nodes), with this as the current DOM element (nodes[i]). The interpolator factory returns a string interpolator,
            /// which takes as its argument eased time t, typically in the range [0, 1] and returns the interpolated string.</param>
            /// <param name="priority">An optional priority flag, either null or the string important (without the exclamation point)</param>
            abstract styleTween: name: string * factory: ValueFn<'GElement, 'Datum, (float -> string)> * ?priority: string -> Transition<'GElement, 'Datum, 'PElement, 'PDatum>
            /// <summary>For each selected element, the text content will be cleared, replacing any existing child elements.</summary>
            /// <param name="value">Use null to clear the text content.</param>
            abstract text: value: obj -> Transition<'GElement, 'Datum, 'PElement, 'PDatum>
            /// <summary>For each selected element, sets the text content to the specified target value when the transition starts.
            /// To interpolate text rather than to set it on start, use transition.tween (for example) or
            /// append a replacement element and cross-fade opacity (for example). Text is not interpolated by default because it is usually undesirable.</summary>
            /// <param name="value">Value used for text content</param>
            abstract text: value: U3<string, float, bool> -> Transition<'GElement, 'Datum, 'PElement, 'PDatum>
            /// <summary>For each selected element, sets the text content returned by the value function for each selected element when the transition starts.
            ///
            /// To interpolate text rather than to set it on start, use transition.tween (for example) or
            /// append a replacement element and cross-fade opacity (for example). Text is not interpolated by default because it is usually undesirable.</summary>
            /// <param name="value">A value function which is evaluated for each selected element, in order, being passed the current datum (d),
            /// the current index (i), and the current group (nodes), with this as the current DOM element (nodes[i]).
            /// A null value will clear the text content at the start of the transition.</param>
            abstract text: value: ValueFn<'GElement, 'Datum, U3<string, float, bool>> -> Transition<'GElement, 'Datum, 'PElement, 'PDatum>
            /// <summary>Returns the tween with the specified name, or undefined, if no tween was previously assigned to
            /// that name.</summary>
            /// <param name="name">Name of tween.</param>
            abstract tween: name: string -> ValueFn<'GElement, 'Datum, (float -> unit)> option
            /// <summary>Removes the tween with the specified name, if a tween was previously assigned to
            /// that name.</summary>
            /// <param name="name">Name of tween.</param>
            /// <param name="tweenFn">Use null to remove a previously-assigned tween.</param>
            abstract tween: name: string * tweenFn: obj -> Transition<'GElement, 'Datum, 'PElement, 'PDatum>
            /// <summary>For each selected element, assigns the tween with the specified name with the specified value function.
            /// The value must be specified as a function that returns a function.
            /// When the transition starts, the value function is evaluated for each selected element.
            /// The returned function is then invoked for each frame of the transition, in order,
            /// being passed the eased time t, typically in the range [0, 1].</summary>
            /// <param name="name">Name of tween.</param>
            /// <param name="tweenFn">A tween function which is evaluated for each selected element, in order, being passed the current datum (d),
            /// the current index (i), and the current group (nodes), with this as the current DOM element (nodes[i]). The tween function returns a function
            /// which takes as its argument eased time t, typically in the range [0, 1] and performs the tweening activities for each transition frame.</param>
            abstract tween: name: string * tweenFn: ValueFn<'GElement, 'Datum, (float -> unit)> -> Transition<'GElement, 'Datum, 'PElement, 'PDatum>
            /// For each selected element, removes the element when the transition ends, as long as the element has no other active or pending transitions.
            /// If the element has other active or pending transitions, does nothing.
            abstract remove: unit -> Transition<'GElement, 'Datum, 'PElement, 'PDatum>
            /// <summary>Returns a new transition merging this transition with the specified other transition,
            /// which must have the same id as this transition. The returned transition has the same number of groups,
            /// the same parents, the same name and the same id as this transition.
            /// Any missing (null) elements in this transition are filled with the corresponding element, if present (not null), from the other transition.</summary>
            /// <param name="other">The transition to be merged.</param>
            abstract merge: other: Transition<'GElement, 'Datum, 'PElement, 'PDatum> -> Transition<'GElement, 'Datum, 'PElement, 'PDatum>
            /// <summary>For each selected element, selects only the elements that match the specified filter, and returns a transition on the resulting selection.
            ///
            /// The new transition has the same id, name and timing as this transition; however, if a transition with the same id already exists on a selected element,
            /// the existing transition is returned for that element.</summary>
            /// <param name="filter">A CSS selector string.</param>
            abstract filter: filter: string -> Transition<'GElement, 'Datum, 'PElement, 'PDatum>
            /// <summary>For each selected element, selects only the elements that match the specified filter, and returns a transition on the resulting selection.
            ///
            /// The new transition has the same id, name and timing as this transition; however, if a transition with the same id already exists on a selected element,
            /// the existing transition is returned for that element.
            ///
            /// The generic refers to the type of element which will be selected after applying the filter, i.e. if the element types
            /// contained in a pre-filter selection are narrowed to a subset as part of the filtering.</summary>
            /// <param name="filter">A CSS selector string.</param>
            abstract filter: filter: string -> Transition<'FilteredElement, 'Datum, 'PElement, 'PDatum>
            /// <summary>For each selected element, selects only the elements that match the specified filter, and returns a transition on the resulting selection.
            ///
            /// The new transition has the same id, name and timing as this transition; however, if a transition with the same id already exists on a selected element,
            /// the existing transition is returned for that element.</summary>
            /// <param name="filter">A filter function which is evaluated for each selected element, in order, being passed the current datum (d),
            /// the current index (i), and the current group (nodes), with this as the current DOM element (nodes[i]). The filter function returns a boolean indicating,
            /// whether the selected element matches.</param>
            abstract filter: filter: ValueFn<'GElement, 'Datum, bool> -> Transition<'GElement, 'Datum, 'PElement, 'PDatum>
            /// <summary>For each selected element, selects only the elements that match the specified filter, and returns a transition on the resulting selection.
            ///
            /// The new transition has the same id, name and timing as this transition; however, if a transition with the same id already exists on a selected element,
            /// the existing transition is returned for that element.
            ///
            /// The generic refers to the type of element which will be selected after applying the filter, i.e. if the element types
            /// contained in a pre-filter selection are narrowed to a subset as part of the filtering.</summary>
            /// <param name="filter">A filter function which is evaluated for each selected element, in order, being passed the current datum (d),
            /// the current index (i), and the current group (nodes), with this as the current DOM element (nodes[i]). The filter function returns a boolean indicating,
            /// whether the selected element matches.</param>
            abstract filter: filter: ValueFn<'GElement, 'Datum, bool> -> Transition<'FilteredElement, 'Datum, 'PElement, 'PDatum>
            /// Return the currently-assigned listener for the specified event typename on the first (non-null) selected element, if any.
            /// If multiple typenames are specified, the first matching listener is returned.
            abstract on: ``type``: string -> ValueFn<'GElement, 'Datum, unit> option
            /// <summary>Remove all listeners for a given name.</summary>
            /// <param name="typenames">Name of the event type for which the listener should be removed. To remove all listeners for a given name use ".foo"
            /// as the typename, where foo is the name; to remove all listeners with no name, specify "." as the typename.</param>
            /// <param name="listener">Use null to remove listeners.</param>
            abstract on: typenames: string * listener: obj -> Transition<'GElement, 'Datum, 'PElement, 'PDatum>
            /// <summary>Add a listener to each selected element for the specified event typenames.
            ///
            /// When a specified transition event is dispatched on a selected node, the specified listener will be invoked for each transitioning element.
            /// Listeners always see the latest datum for their element, but the index is a property of the selection and is fixed when the listener is assigned;
            /// to update the index, re-assign the listener.</summary>
            /// <param name="listener">A listener function which will be evaluated for each selected element, being passed the current datum (d), the current index (i),
            /// and the current group (nodes), with this as the current DOM element (nodes[i]). Listeners always see the latest datum for their element,
            /// but the index is a property of the selection and is fixed when the listener is assigned; to update the index, re-assign the listener.</param>
            abstract on: ``type``: string * listener: ValueFn<'GElement, 'Datum, unit> -> Transition<'GElement, 'Datum, 'PElement, 'PDatum>
            /// <summary>Invoke the specified function for each selected element, passing the current datum (d),
            /// the current index (i), and the current group (nodes), with this of the current DOM element (nodes[i]).
            /// This method can be used to invoke arbitrary code for each selected element, and is useful for creating a context to access parent and child data simultaneously.</summary>
            /// <param name="func">A function which is invoked for each selected element,
            /// being passed the current datum (d), the current index (i), and the current group (nodes), with this of the current DOM element (nodes[i]).</param>
            abstract each: func: ValueFn<'GElement, 'Datum, unit> -> Transition<'GElement, 'Datum, 'PElement, 'PDatum>
            /// <summary>Invoke the specified function exactly once, passing in this transition along with any optional arguments.
            /// Returns this transition.</summary>
            /// <param name="func">A function which is passed this transition as the first argument along with any optional arguments.</param>
            /// <param name="args">List of optional arguments to be passed to the callback function.</param>
            abstract call: func: (Transition<'GElement, 'Datum, 'PElement, 'PDatum> -> ResizeArray<obj option> -> obj option) * [<ParamArray>] args: ResizeArray<obj option> -> Transition<'GElement, 'Datum, 'PElement, 'PDatum>
            /// Return true if this transition contains no (non-null) elements.
            abstract empty: unit -> bool
            /// Return the first (non-null) element in this transition. If the transition is empty, returns null.
            abstract node: unit -> 'GElement option
            /// Return an array of all (non-null) elements in this transition.
            abstract nodes: unit -> ResizeArray<'GElement>
            /// Returns the total number of elements in this transition.
            abstract size: unit -> float
            /// Returns the current value of the delay for the first (non-null) element in the transition.
            /// This is generally useful only if you know that the transition contains exactly one element.
            abstract delay: unit -> float
            /// <summary>For each selected element, sets the transition delay to the specified value in milliseconds.
            /// If a delay is not specified, it defaults to zero.</summary>
            /// <param name="milliseconds">Number of milliseconds for the delay.</param>
            abstract delay: milliseconds: float -> Transition<'GElement, 'Datum, 'PElement, 'PDatum>
            /// <summary>For each selected element, sets the transition delay to the value in milliseconds returned by the
            /// value function.</summary>
            /// <param name="milliseconds">A value function which is evaluated for each selected element, being passed the current datum (d),
            /// the current index (i), and the current group (nodes), with this of the current DOM element (nodes[i]). The return value is a number
            /// specifying the delay in milliseconds.</param>
            abstract delay: milliseconds: ValueFn<'GElement, 'Datum, float> -> Transition<'GElement, 'Datum, 'PElement, 'PDatum>
            /// Returns the current value of the duration for the first (non-null) element in the transition.
            /// This is generally useful only if you know that the transition contains exactly one element.
            abstract duration: unit -> float
            /// For each selected element, sets the transition duration to the specified value in milliseconds.
            /// If a duration is not specified, it defaults to 250ms.
            abstract duration: milliseconds: float -> Transition<'GElement, 'Datum, 'PElement, 'PDatum>
            /// <summary>For each selected element, sets the transition duration to the value in milliseconds returned by the
            /// value function.</summary>
            /// <param name="milliseconds">A value function which is evaluated for each selected element, being passed the current datum (d),
            /// the current index (i), and the current group (nodes), with this of the current DOM element (nodes[i]). The return value is a number
            /// specifying the duration in milliseconds.</param>
            abstract duration: milliseconds: ValueFn<'GElement, 'Datum, float> -> Transition<'GElement, 'Datum, 'PElement, 'PDatum>
            /// Returns the current easing function for the first (non-null) element in the transition.
            /// This is generally useful only if you know that the transition contains exactly one element.
            abstract ease: unit -> (float -> float)
            /// <summary>Specifies the transition easing function for all selected elements. The value must be specified as a function.
            /// The easing function is invoked for each frame of the animation, being passed the normalized time t in the range [0, 1];
            /// it must then return the eased time tʹ which is typically also in the range [0, 1].
            /// A good easing function should return 0 if t = 0 and 1 if t = 1. If an easing function is not specified,
            /// it defaults to d3.easeCubic.</summary>
            /// <param name="easingFn">An easing function which is passed the normalized time t in the range [0, 1];
            /// it must then return the eased time tʹ which is typically also in the range [0, 1].
            /// A good easing function should return 0 if t = 0 and 1 if t = 1.</param>
            abstract ease: easingFn: (float -> float) -> Transition<'GElement, 'Datum, 'PElement, 'PDatum>

        type SelectionOrTransition<'GElement, 'Datum, 'PElement, 'PDatum> =
            U2<Selection<'GElement, 'Datum, 'PElement, 'PDatum>, Transition<'GElement, 'Datum, 'PElement, 'PDatum>>
