# <a id="Divine_Menu_Styles_Default_MenuStyle"></a> Class MenuStyle

Namespace: [Divine.Menu.Styles.Default](Divine.Menu.Styles.Default.md)  
Assembly: Divine.dll  

```csharp
public class MenuStyle : ExpanderStyle, IMenuStyle, IExpanderStyle, ITextStyle, IStyle
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Style](Divine.Menu.Styles.Default.Style.md) ← 
[TextStyle](Divine.Menu.Styles.Default.TextStyle.md) ← 
[ExpanderStyle](Divine.Menu.Styles.Default.ExpanderStyle.md) ← 
[MenuStyle](Divine.Menu.Styles.Default.MenuStyle.md)

#### Derived

[ContextStyle](Divine.Menu.Styles.Default.ContextStyle.md), 
[WithSwitcherStyle](Divine.Menu.Styles.Default.WithSwitcherStyle.md)

#### Implements

[IMenuStyle](Divine.Menu.Styles.IMenuStyle.md), 
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
[EnumerableExtensions.In<MenuStyle\>\(MenuStyle, params MenuStyle\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Properties

### <a id="Divine_Menu_Styles_Default_MenuStyle_ElementMarginLeft"></a> ElementMarginLeft

```csharp
public override float ElementMarginLeft { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Styles_Default_MenuStyle_SideLineMarginMiddle"></a> SideLineMarginMiddle

```csharp
public virtual float SideLineMarginMiddle { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Styles_Default_MenuStyle_SideLineSize"></a> SideLineSize

```csharp
public virtual Size SideLineSize { get; set; }
```

#### Property Value

 [Size](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Size.cs)

