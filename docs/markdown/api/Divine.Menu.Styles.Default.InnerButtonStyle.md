# <a id="Divine_Menu_Styles_Default_InnerButtonStyle"></a> Class InnerButtonStyle

Namespace: [Divine.Menu.Styles.Default](Divine.Menu.Styles.Default.md)  
Assembly: Divine.dll  

```csharp
public class InnerButtonStyle : ButtonStyle, IInnerButtonStyle, IButtonStyle, ITextStyle, IStyle
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Style](Divine.Menu.Styles.Default.Style.md) ← 
[TextStyle](Divine.Menu.Styles.Default.TextStyle.md) ← 
[ButtonStyle](Divine.Menu.Styles.Default.ButtonStyle.md) ← 
[InnerButtonStyle](Divine.Menu.Styles.Default.InnerButtonStyle.md)

#### Implements

[IInnerButtonStyle](Divine.Menu.Styles.IInnerButtonStyle.md), 
[IButtonStyle](Divine.Menu.Styles.IButtonStyle.md), 
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
[EnumerableExtensions.In<InnerButtonStyle\>\(InnerButtonStyle, params InnerButtonStyle\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Properties

### <a id="Divine_Menu_Styles_Default_InnerButtonStyle_ElementMarginTopBottom"></a> ElementMarginTopBottom

```csharp
public override float ElementMarginTopBottom { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Styles_Default_InnerButtonStyle_InnerColor"></a> InnerColor

```csharp
public virtual Color InnerColor { get; }
```

#### Property Value

 [Color](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Color.cs)

### <a id="Divine_Menu_Styles_Default_InnerButtonStyle_InnerCornerRadius"></a> InnerCornerRadius

```csharp
public virtual CornerRadius InnerCornerRadius { get; set; }
```

#### Property Value

 [CornerRadius](Divine.Renderer.Numerics.CornerRadius.md)

### <a id="Divine_Menu_Styles_Default_InnerButtonStyle_InnerMargin"></a> InnerMargin

```csharp
public Vector2 InnerMargin { get; }
```

#### Property Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Divine_Menu_Styles_Default_InnerButtonStyle_InnerMarginLeftRight"></a> InnerMarginLeftRight

```csharp
public virtual float InnerMarginLeftRight { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Styles_Default_InnerButtonStyle_InnerMarginTopBottom"></a> InnerMarginTopBottom

```csharp
public virtual float InnerMarginTopBottom { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

