# <a id="Divine_Menu_Styles_Default_TogglerStyle"></a> Class TogglerStyle

Namespace: [Divine.Menu.Styles.Default](Divine.Menu.Styles.Default.md)  
Assembly: Divine.dll  

```csharp
public class TogglerStyle : ExpanderStyle, ITogglerStyle, IExpanderStyle, ITextStyle, IStyle
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Style](Divine.Menu.Styles.Default.Style.md) ← 
[TextStyle](Divine.Menu.Styles.Default.TextStyle.md) ← 
[ExpanderStyle](Divine.Menu.Styles.Default.ExpanderStyle.md) ← 
[TogglerStyle](Divine.Menu.Styles.Default.TogglerStyle.md)

#### Implements

[ITogglerStyle](Divine.Menu.Styles.ITogglerStyle.md), 
[IExpanderStyle](Divine.Menu.Styles.IExpanderStyle.md), 
[ITextStyle](Divine.Menu.Styles.ITextStyle.md), 
[IStyle](Divine.Menu.Styles.IStyle.md)

#### Inherited Members

[ExpanderStyle.ArrowSize](Divine.Menu.Styles.Default.ExpanderStyle.md\#Divine\_Menu\_Styles\_Default\_ExpanderStyle\_ArrowSize), 
[ExpanderStyle.ArrowMarginRight](Divine.Menu.Styles.Default.ExpanderStyle.md\#Divine\_Menu\_Styles\_Default\_ExpanderStyle\_ArrowMarginRight), 
[ExpanderStyle.ArrowMoveLeft](Divine.Menu.Styles.Default.ExpanderStyle.md\#Divine\_Menu\_Styles\_Default\_ExpanderStyle\_ArrowMoveLeft), 
[ExpanderStyle.StrokeWidth](Divine.Menu.Styles.Default.ExpanderStyle.md\#Divine\_Menu\_Styles\_Default\_ExpanderStyle\_StrokeWidth), 
[TextStyle.DisplayTextFontSize](Divine.Menu.Styles.Default.TextStyle.md\#Divine\_Menu\_Styles\_Default\_TextStyle\_DisplayTextFontSize), 
[TextStyle.DisplayTextFontColor](Divine.Menu.Styles.Default.TextStyle.md\#Divine\_Menu\_Styles\_Default\_TextStyle\_DisplayTextFontColor), 
[TextStyle.DisabledDisplayTextFontColorMultiply](Divine.Menu.Styles.Default.TextStyle.md\#Divine\_Menu\_Styles\_Default\_TextStyle\_DisabledDisplayTextFontColorMultiply), 
[TextStyle.SearchMarkDisplayTextFontColorMultiply](Divine.Menu.Styles.Default.TextStyle.md\#Divine\_Menu\_Styles\_Default\_TextStyle\_SearchMarkDisplayTextFontColorMultiply), 
[Style.Height](Divine.Menu.Styles.Default.Style.md\#Divine\_Menu\_Styles\_Default\_Style\_Height), 
[Style.CornerRadius](Divine.Menu.Styles.Default.Style.md\#Divine\_Menu\_Styles\_Default\_Style\_CornerRadius), 
[Style.StrokeCornerRadius](Divine.Menu.Styles.Default.Style.md\#Divine\_Menu\_Styles\_Default\_Style\_StrokeCornerRadius), 
[Style.TopCornerRadius](Divine.Menu.Styles.Default.Style.md\#Divine\_Menu\_Styles\_Default\_Style\_TopCornerRadius), 
[Style.BottomCornerRadius](Divine.Menu.Styles.Default.Style.md\#Divine\_Menu\_Styles\_Default\_Style\_BottomCornerRadius), 
[Style.SingleCornerRadius](Divine.Menu.Styles.Default.Style.md\#Divine\_Menu\_Styles\_Default\_Style\_SingleCornerRadius), 
[Style.ElementMarginLeft](Divine.Menu.Styles.Default.Style.md\#Divine\_Menu\_Styles\_Default\_Style\_ElementMarginLeft), 
[Style.ElementMarginMiddle](Divine.Menu.Styles.Default.Style.md\#Divine\_Menu\_Styles\_Default\_Style\_ElementMarginMiddle), 
[Style.ElementMarginRight](Divine.Menu.Styles.Default.Style.md\#Divine\_Menu\_Styles\_Default\_Style\_ElementMarginRight), 
[Style.ElementMarginTopBottom](Divine.Menu.Styles.Default.Style.md\#Divine\_Menu\_Styles\_Default\_Style\_ElementMarginTopBottom), 
[Style.ImageHeight](Divine.Menu.Styles.Default.Style.md\#Divine\_Menu\_Styles\_Default\_Style\_ImageHeight), 
[Style.ImageCornerRadius](Divine.Menu.Styles.Default.Style.md\#Divine\_Menu\_Styles\_Default\_Style\_ImageCornerRadius), 
[Style.Color](Divine.Menu.Styles.Default.Style.md\#Divine\_Menu\_Styles\_Default\_Style\_Color), 
[Style.HoverColor](Divine.Menu.Styles.Default.Style.md\#Divine\_Menu\_Styles\_Default\_Style\_HoverColor), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<TogglerStyle\>\(TogglerStyle, params TogglerStyle\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Properties

### <a id="Divine_Menu_Styles_Default_TogglerStyle_TogglerCornerRadius"></a> TogglerCornerRadius

```csharp
public virtual CornerRadius TogglerCornerRadius { get; set; }
```

#### Property Value

 [CornerRadius](Divine.Renderer.Numerics.CornerRadius.md)

### <a id="Divine_Menu_Styles_Default_TogglerStyle_TogglerDisabledFrameColor"></a> TogglerDisabledFrameColor

```csharp
public virtual Color TogglerDisabledFrameColor { get; set; }
```

#### Property Value

 [Color](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Color.cs)

### <a id="Divine_Menu_Styles_Default_TogglerStyle_TogglerFrameColor"></a> TogglerFrameColor

```csharp
public virtual Color TogglerFrameColor { get; set; }
```

#### Property Value

 [Color](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Color.cs)

### <a id="Divine_Menu_Styles_Default_TogglerStyle_TogglerFrameWidth"></a> TogglerFrameWidth

```csharp
public virtual float TogglerFrameWidth { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Styles_Default_TogglerStyle_TogglerHeight"></a> TogglerHeight

```csharp
public virtual float TogglerHeight { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Styles_Default_TogglerStyle_TogglerHeightItem"></a> TogglerHeightItem

```csharp
public virtual float TogglerHeightItem { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Styles_Default_TogglerStyle_TogglerMarginBottom"></a> TogglerMarginBottom

```csharp
public virtual float TogglerMarginBottom { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Styles_Default_TogglerStyle_TogglerMarginMiddle"></a> TogglerMarginMiddle

```csharp
public virtual float TogglerMarginMiddle { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Styles_Default_TogglerStyle_TogglerPriorityDragBackgroundColor"></a> TogglerPriorityDragBackgroundColor

```csharp
public virtual Color TogglerPriorityDragBackgroundColor { get; }
```

#### Property Value

 [Color](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Color.cs)

### <a id="Divine_Menu_Styles_Default_TogglerStyle_TogglerPriorityNumberFontColor"></a> TogglerPriorityNumberFontColor

```csharp
public virtual Color TogglerPriorityNumberFontColor { get; }
```

#### Property Value

 [Color](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Color.cs)

### <a id="Divine_Menu_Styles_Default_TogglerStyle_TogglerPriorityNumberFontSize"></a> TogglerPriorityNumberFontSize

```csharp
public virtual float TogglerPriorityNumberFontSize { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Styles_Default_TogglerStyle_TogglerPriorityNumberMarginBottom"></a> TogglerPriorityNumberMarginBottom

```csharp
public virtual float TogglerPriorityNumberMarginBottom { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Styles_Default_TogglerStyle_TogglerPriorityNumberMarginLeft"></a> TogglerPriorityNumberMarginLeft

```csharp
public virtual float TogglerPriorityNumberMarginLeft { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Styles_Default_TogglerStyle_TogglerPriorityNumberShadowOffset"></a> TogglerPriorityNumberShadowOffset

```csharp
public virtual float TogglerPriorityNumberShadowOffset { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Styles_Default_TogglerStyle_TogglerWidth"></a> TogglerWidth

```csharp
public virtual float TogglerWidth { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Styles_Default_TogglerStyle_TogglerWidthItem"></a> TogglerWidthItem

```csharp
public virtual float TogglerWidthItem { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

