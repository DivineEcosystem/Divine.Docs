# <a id="Divine_Menu_Styles_Default_SelectorStyle"></a> Class SelectorStyle

Namespace: [Divine.Menu.Styles.Default](Divine.Menu.Styles.Default.md)  
Assembly: Divine.dll  

```csharp
public class SelectorStyle : TextStyle, ISelectorStyle, ITextStyle, IStyle
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Style](Divine.Menu.Styles.Default.Style.md) ← 
[TextStyle](Divine.Menu.Styles.Default.TextStyle.md) ← 
[SelectorStyle](Divine.Menu.Styles.Default.SelectorStyle.md)

#### Implements

[ISelectorStyle](Divine.Menu.Styles.ISelectorStyle.md), 
[ITextStyle](Divine.Menu.Styles.ITextStyle.md), 
[IStyle](Divine.Menu.Styles.IStyle.md)

#### Inherited Members

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
[EnumerableExtensions.In<SelectorStyle\>\(SelectorStyle, params SelectorStyle\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Properties

### <a id="Divine_Menu_Styles_Default_SelectorStyle_SelectArrowMarginRight"></a> SelectArrowMarginRight

```csharp
[ScaleFloor(false)]
public virtual float SelectArrowMarginRight { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Styles_Default_SelectorStyle_SelectArrowSize"></a> SelectArrowSize

```csharp
[ScaleFloor(false)]
public virtual Size SelectArrowSize { get; set; }
```

#### Property Value

 [Size](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Size.cs)

### <a id="Divine_Menu_Styles_Default_SelectorStyle_SelectColor"></a> SelectColor

```csharp
public virtual Color SelectColor { get; }
```

#### Property Value

 [Color](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Color.cs)

### <a id="Divine_Menu_Styles_Default_SelectorStyle_SelectCornerRadius"></a> SelectCornerRadius

```csharp
public virtual CornerRadius SelectCornerRadius { get; set; }
```

#### Property Value

 [CornerRadius](Divine.Renderer.Numerics.CornerRadius.md)

### <a id="Divine_Menu_Styles_Default_SelectorStyle_SelectSize"></a> SelectSize

```csharp
[ScaleFloor(false)]
public virtual Size SelectSize { get; set; }
```

#### Property Value

 [Size](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Size.cs)

### <a id="Divine_Menu_Styles_Default_SelectorStyle_SelectTextFontColor"></a> SelectTextFontColor

```csharp
public virtual Color SelectTextFontColor { get; }
```

#### Property Value

 [Color](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Color.cs)

### <a id="Divine_Menu_Styles_Default_SelectorStyle_SelectTextFontSize"></a> SelectTextFontSize

```csharp
[ScaleFloor(false)]
public virtual float SelectTextFontSize { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Styles_Default_SelectorStyle_SelectTextMarginLeftRight"></a> SelectTextMarginLeftRight

```csharp
[ScaleFloor(false)]
public virtual float SelectTextMarginLeftRight { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

