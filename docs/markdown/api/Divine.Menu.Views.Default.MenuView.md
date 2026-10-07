# <a id="Divine_Menu_Views_Default_MenuView"></a> Class MenuView

Namespace: [Divine.Menu.Views.Default](Divine.Menu.Views.Default.md)  
Assembly: Divine.dll  

```csharp
public class MenuView : ExpanderView, IMenuView, IExpanderView, ITextView, IView
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[BaseView](Divine.Menu.Views.BaseView.md) ← 
[View](Divine.Menu.Views.Default.View.md) ← 
[TextView](Divine.Menu.Views.Default.TextView.md) ← 
[ExpanderView](Divine.Menu.Views.Default.ExpanderView.md) ← 
[MenuView](Divine.Menu.Views.Default.MenuView.md)

#### Derived

[ContextView](Divine.Menu.Views.Default.ContextView.md)

#### Implements

[IMenuView](Divine.Menu.Views.IMenuView.md), 
[IExpanderView](Divine.Menu.Views.IExpanderView.md), 
[ITextView](Divine.Menu.Views.ITextView.md), 
[IView](Divine.Menu.Views.IView.md)

#### Inherited Members

[ExpanderView.Owner](Divine.Menu.Views.Default.ExpanderView.md\#Divine\_Menu\_Views\_Default\_ExpanderView\_Owner), 
[ExpanderView.Style](Divine.Menu.Views.Default.ExpanderView.md\#Divine\_Menu\_Views\_Default\_ExpanderView\_Style), 
[ExpanderView.IsExpanded](Divine.Menu.Views.Default.ExpanderView.md\#Divine\_Menu\_Views\_Default\_ExpanderView\_IsExpanded), 
[ExpanderView.UnderChildRectangleCheck](Divine.Menu.Views.Default.ExpanderView.md\#Divine\_Menu\_Views\_Default\_ExpanderView\_UnderChildRectangleCheck), 
[ExpanderView.ElementsWidth](Divine.Menu.Views.Default.ExpanderView.md\#Divine\_Menu\_Views\_Default\_ExpanderView\_ElementsWidth), 
[ExpanderView.Scroll](Divine.Menu.Views.Default.ExpanderView.md\#Divine\_Menu\_Views\_Default\_ExpanderView\_Scroll), 
[ExpanderView.ChildSize](Divine.Menu.Views.Default.ExpanderView.md\#Divine\_Menu\_Views\_Default\_ExpanderView\_ChildSize), 
[ExpanderView.ChildRectangle](Divine.Menu.Views.Default.ExpanderView.md\#Divine\_Menu\_Views\_Default\_ExpanderView\_ChildRectangle), 
[ExpanderView.ArrowRectangle](Divine.Menu.Views.Default.ExpanderView.md\#Divine\_Menu\_Views\_Default\_ExpanderView\_ArrowRectangle), 
[ExpanderView.OnRefresh\(\)](Divine.Menu.Views.Default.ExpanderView.md\#Divine\_Menu\_Views\_Default\_ExpanderView\_OnRefresh), 
[ExpanderView.OnDrawSpecial\(\)](Divine.Menu.Views.Default.ExpanderView.md\#Divine\_Menu\_Views\_Default\_ExpanderView\_OnDrawSpecial), 
[ExpanderView.OnDrawStroke\(\)](Divine.Menu.Views.Default.ExpanderView.md\#Divine\_Menu\_Views\_Default\_ExpanderView\_OnDrawStroke), 
[ExpanderView.OnDrawArrow\(\)](Divine.Menu.Views.Default.ExpanderView.md\#Divine\_Menu\_Views\_Default\_ExpanderView\_OnDrawArrow), 
[ExpanderView.OnDrawChild\(\)](Divine.Menu.Views.Default.ExpanderView.md\#Divine\_Menu\_Views\_Default\_ExpanderView\_OnDrawChild), 
[ExpanderView.OnDrawChildBackground\(\)](Divine.Menu.Views.Default.ExpanderView.md\#Divine\_Menu\_Views\_Default\_ExpanderView\_OnDrawChildBackground), 
[ExpanderView.OnDrawChildEmptyText\(\)](Divine.Menu.Views.Default.ExpanderView.md\#Divine\_Menu\_Views\_Default\_ExpanderView\_OnDrawChildEmptyText), 
[ExpanderView.OnMouseKeyDown\(bool, Vector2\)](Divine.Menu.Views.Default.ExpanderView.md\#Divine\_Menu\_Views\_Default\_ExpanderView\_OnMouseKeyDown\_System\_Boolean\_System\_Numerics\_Vector2\_), 
[ExpanderView.OnMouseKeyUp\(bool, Vector2\)](Divine.Menu.Views.Default.ExpanderView.md\#Divine\_Menu\_Views\_Default\_ExpanderView\_OnMouseKeyUp\_System\_Boolean\_System\_Numerics\_Vector2\_), 
[ExpanderView.OnMouseMove\(Vector2\)](Divine.Menu.Views.Default.ExpanderView.md\#Divine\_Menu\_Views\_Default\_ExpanderView\_OnMouseMove\_System\_Numerics\_Vector2\_), 
[ExpanderView.OnMouseWheel\(bool, Vector2\)](Divine.Menu.Views.Default.ExpanderView.md\#Divine\_Menu\_Views\_Default\_ExpanderView\_OnMouseWheel\_System\_Boolean\_System\_Numerics\_Vector2\_), 
[ExpanderView.OnShowTooltip\(\)](Divine.Menu.Views.Default.ExpanderView.md\#Divine\_Menu\_Views\_Default\_ExpanderView\_OnShowTooltip), 
[ExpanderView.OnHoverAnimationEnd\(\)](Divine.Menu.Views.Default.ExpanderView.md\#Divine\_Menu\_Views\_Default\_ExpanderView\_OnHoverAnimationEnd), 
[ExpanderView.OnDisable\(\)](Divine.Menu.Views.Default.ExpanderView.md\#Divine\_Menu\_Views\_Default\_ExpanderView\_OnDisable), 
[ExpanderView.OnExpand\(\)](Divine.Menu.Views.Default.ExpanderView.md\#Divine\_Menu\_Views\_Default\_ExpanderView\_OnExpand), 
[ExpanderView.OnCollapse\(\)](Divine.Menu.Views.Default.ExpanderView.md\#Divine\_Menu\_Views\_Default\_ExpanderView\_OnCollapse), 
[ExpanderView.OnCalculateArrowRectangle\(\)](Divine.Menu.Views.Default.ExpanderView.md\#Divine\_Menu\_Views\_Default\_ExpanderView\_OnCalculateArrowRectangle), 
[ExpanderView.OnCalculateChildSize\(\)](Divine.Menu.Views.Default.ExpanderView.md\#Divine\_Menu\_Views\_Default\_ExpanderView\_OnCalculateChildSize), 
[ExpanderView.OnCalculateChildRectangle\(\)](Divine.Menu.Views.Default.ExpanderView.md\#Divine\_Menu\_Views\_Default\_ExpanderView\_OnCalculateChildRectangle), 
[TextView.Owner](Divine.Menu.Views.Default.TextView.md\#Divine\_Menu\_Views\_Default\_TextView\_Owner), 
[TextView.Linked](Divine.Menu.Views.Default.TextView.md\#Divine\_Menu\_Views\_Default\_TextView\_Linked), 
[TextView.Style](Divine.Menu.Views.Default.TextView.md\#Divine\_Menu\_Views\_Default\_TextView\_Style), 
[TextView.DisplayText](Divine.Menu.Views.Default.TextView.md\#Divine\_Menu\_Views\_Default\_TextView\_DisplayText), 
[TextView.ElementsWidth](Divine.Menu.Views.Default.TextView.md\#Divine\_Menu\_Views\_Default\_TextView\_ElementsWidth), 
[TextView.ElementsWidthWithDisplayText](Divine.Menu.Views.Default.TextView.md\#Divine\_Menu\_Views\_Default\_TextView\_ElementsWidthWithDisplayText), 
[TextView.DisplayTextFontColor](Divine.Menu.Views.Default.TextView.md\#Divine\_Menu\_Views\_Default\_TextView\_DisplayTextFontColor), 
[TextView.DisplayTextSize](Divine.Menu.Views.Default.TextView.md\#Divine\_Menu\_Views\_Default\_TextView\_DisplayTextSize), 
[TextView.DisplayTextRectangle](Divine.Menu.Views.Default.TextView.md\#Divine\_Menu\_Views\_Default\_TextView\_DisplayTextRectangle), 
[TextView.OnRefreshSize\(\)](Divine.Menu.Views.Default.TextView.md\#Divine\_Menu\_Views\_Default\_TextView\_OnRefreshSize), 
[TextView.OnRefresh\(\)](Divine.Menu.Views.Default.TextView.md\#Divine\_Menu\_Views\_Default\_TextView\_OnRefresh), 
[TextView.OnDrawSpecialText\(\)](Divine.Menu.Views.Default.TextView.md\#Divine\_Menu\_Views\_Default\_TextView\_OnDrawSpecialText), 
[TextView.OnDrawDisplayText\(\)](Divine.Menu.Views.Default.TextView.md\#Divine\_Menu\_Views\_Default\_TextView\_OnDrawDisplayText), 
[TextView.OnCalculateDisplayTextSize\(\)](Divine.Menu.Views.Default.TextView.md\#Divine\_Menu\_Views\_Default\_TextView\_OnCalculateDisplayTextSize), 
[TextView.OnCalculateSize\(\)](Divine.Menu.Views.Default.TextView.md\#Divine\_Menu\_Views\_Default\_TextView\_OnCalculateSize), 
[TextView.OnCalculateRectangle\(\)](Divine.Menu.Views.Default.TextView.md\#Divine\_Menu\_Views\_Default\_TextView\_OnCalculateRectangle), 
[TextView.OnCalculateDisplayTextRectangle\(\)](Divine.Menu.Views.Default.TextView.md\#Divine\_Menu\_Views\_Default\_TextView\_OnCalculateDisplayTextRectangle), 
[View.Context](Divine.Menu.Views.Default.View.md\#Divine\_Menu\_Views\_Default\_View\_Context), 
[View.Parent](Divine.Menu.Views.Default.View.md\#Divine\_Menu\_Views\_Default\_View\_Parent), 
[View.GeneralStyle](Divine.Menu.Views.Default.View.md\#Divine\_Menu\_Views\_Default\_View\_GeneralStyle), 
[View.Style](Divine.Menu.Views.Default.View.md\#Divine\_Menu\_Views\_Default\_View\_Style), 
[View.Renderer](Divine.Menu.Views.Default.View.md\#Divine\_Menu\_Views\_Default\_View\_Renderer), 
[View.ElementsWidth](Divine.Menu.Views.Default.View.md\#Divine\_Menu\_Views\_Default\_View\_ElementsWidth), 
[View.ElementMarginTopBottom](Divine.Menu.Views.Default.View.md\#Divine\_Menu\_Views\_Default\_View\_ElementMarginTopBottom), 
[View.TooltipPosition](Divine.Menu.Views.Default.View.md\#Divine\_Menu\_Views\_Default\_View\_TooltipPosition), 
[View.OnRefreshSize\(\)](Divine.Menu.Views.Default.View.md\#Divine\_Menu\_Views\_Default\_View\_OnRefreshSize), 
[View.OnRefresh\(\)](Divine.Menu.Views.Default.View.md\#Divine\_Menu\_Views\_Default\_View\_OnRefresh), 
[View.OnDrawBackground\(\)](Divine.Menu.Views.Default.View.md\#Divine\_Menu\_Views\_Default\_View\_OnDrawBackground), 
[View.OnDrawHover\(\)](Divine.Menu.Views.Default.View.md\#Divine\_Menu\_Views\_Default\_View\_OnDrawHover), 
[View.OnDrawImage\(\)](Divine.Menu.Views.Default.View.md\#Divine\_Menu\_Views\_Default\_View\_OnDrawImage), 
[View.OnMouseKeyDown\(bool, Vector2\)](Divine.Menu.Views.Default.View.md\#Divine\_Menu\_Views\_Default\_View\_OnMouseKeyDown\_System\_Boolean\_System\_Numerics\_Vector2\_), 
[View.OnMouseKeyUp\(bool, Vector2\)](Divine.Menu.Views.Default.View.md\#Divine\_Menu\_Views\_Default\_View\_OnMouseKeyUp\_System\_Boolean\_System\_Numerics\_Vector2\_), 
[View.OnMouseMove\(Vector2\)](Divine.Menu.Views.Default.View.md\#Divine\_Menu\_Views\_Default\_View\_OnMouseMove\_System\_Numerics\_Vector2\_), 
[View.OnMouseWheel\(bool, Vector2\)](Divine.Menu.Views.Default.View.md\#Divine\_Menu\_Views\_Default\_View\_OnMouseWheel\_System\_Boolean\_System\_Numerics\_Vector2\_), 
[View.OnHoverStart\(\)](Divine.Menu.Views.Default.View.md\#Divine\_Menu\_Views\_Default\_View\_OnHoverStart), 
[View.OnHoverEnd\(\)](Divine.Menu.Views.Default.View.md\#Divine\_Menu\_Views\_Default\_View\_OnHoverEnd), 
[View.OnHoverAnimationStart\(\)](Divine.Menu.Views.Default.View.md\#Divine\_Menu\_Views\_Default\_View\_OnHoverAnimationStart), 
[View.OnHoverAnimationEnd\(\)](Divine.Menu.Views.Default.View.md\#Divine\_Menu\_Views\_Default\_View\_OnHoverAnimationEnd), 
[View.OnShowTooltip\(\)](Divine.Menu.Views.Default.View.md\#Divine\_Menu\_Views\_Default\_View\_OnShowTooltip), 
[View.OnHideTooltip\(\)](Divine.Menu.Views.Default.View.md\#Divine\_Menu\_Views\_Default\_View\_OnHideTooltip), 
[View.GetHoverValue\(\)](Divine.Menu.Views.Default.View.md\#Divine\_Menu\_Views\_Default\_View\_GetHoverValue), 
[View.CreateMiniMenu\(string, Vector2\)](Divine.Menu.Views.Default.View.md\#Divine\_Menu\_Views\_Default\_View\_CreateMiniMenu\_System\_String\_System\_Numerics\_Vector2\_), 
[View.RemoveMiniMenu\(\)](Divine.Menu.Views.Default.View.md\#Divine\_Menu\_Views\_Default\_View\_RemoveMiniMenu), 
[View.OnShowMiniMenu\(MiniMenu\)](Divine.Menu.Views.Default.View.md\#Divine\_Menu\_Views\_Default\_View\_OnShowMiniMenu\_Divine\_Menu\_Items\_MiniMenu\_), 
[View.OnHideMiniMenu\(MiniMenu\)](Divine.Menu.Views.Default.View.md\#Divine\_Menu\_Views\_Default\_View\_OnHideMiniMenu\_Divine\_Menu\_Items\_MiniMenu\_), 
[View.OnCalculateExtraHeight\(\)](Divine.Menu.Views.Default.View.md\#Divine\_Menu\_Views\_Default\_View\_OnCalculateExtraHeight), 
[View.OnCalculateSize\(\)](Divine.Menu.Views.Default.View.md\#Divine\_Menu\_Views\_Default\_View\_OnCalculateSize), 
[View.OnCalculateRectangle\(\)](Divine.Menu.Views.Default.View.md\#Divine\_Menu\_Views\_Default\_View\_OnCalculateRectangle), 
[View.OnCalculateImageSize\(\)](Divine.Menu.Views.Default.View.md\#Divine\_Menu\_Views\_Default\_View\_OnCalculateImageSize), 
[View.OnCalculateImageRectangle\(\)](Divine.Menu.Views.Default.View.md\#Divine\_Menu\_Views\_Default\_View\_OnCalculateImageRectangle), 
[BaseView.Owner](Divine.Menu.Views.BaseView.md\#Divine\_Menu\_Views\_BaseView\_Owner), 
[BaseView.Linked](Divine.Menu.Views.BaseView.md\#Divine\_Menu\_Views\_BaseView\_Linked), 
[BaseView.Context](Divine.Menu.Views.BaseView.md\#Divine\_Menu\_Views\_BaseView\_Context), 
[BaseView.Parent](Divine.Menu.Views.BaseView.md\#Divine\_Menu\_Views\_BaseView\_Parent), 
[BaseView.Style](Divine.Menu.Views.BaseView.md\#Divine\_Menu\_Views\_BaseView\_Style), 
[BaseView.GeneralStyle](Divine.Menu.Views.BaseView.md\#Divine\_Menu\_Views\_BaseView\_GeneralStyle), 
[BaseView.Renderer](Divine.Menu.Views.BaseView.md\#Divine\_Menu\_Views\_BaseView\_Renderer), 
[BaseView.Prev](Divine.Menu.Views.BaseView.md\#Divine\_Menu\_Views\_BaseView\_Prev), 
[BaseView.Next](Divine.Menu.Views.BaseView.md\#Divine\_Menu\_Views\_BaseView\_Next), 
[BaseView.IsRoot](Divine.Menu.Views.BaseView.md\#Divine\_Menu\_Views\_BaseView\_IsRoot), 
[BaseView.CanVisible](Divine.Menu.Views.BaseView.md\#Divine\_Menu\_Views\_BaseView\_CanVisible), 
[BaseView.IsVisible](Divine.Menu.Views.BaseView.md\#Divine\_Menu\_Views\_BaseView\_IsVisible), 
[BaseView.IsDisabled](Divine.Menu.Views.BaseView.md\#Divine\_Menu\_Views\_BaseView\_IsDisabled), 
[BaseView.IsSearcherMark](Divine.Menu.Views.BaseView.md\#Divine\_Menu\_Views\_BaseView\_IsSearcherMark), 
[BaseView.Flags](Divine.Menu.Views.BaseView.md\#Divine\_Menu\_Views\_BaseView\_Flags), 
[BaseView.ContextStyle](Divine.Menu.Views.BaseView.md\#Divine\_Menu\_Views\_BaseView\_ContextStyle), 
[BaseView.ContextPosition](Divine.Menu.Views.BaseView.md\#Divine\_Menu\_Views\_BaseView\_ContextPosition), 
[BaseView.ImageKey](Divine.Menu.Views.BaseView.md\#Divine\_Menu\_Views\_BaseView\_ImageKey), 
[BaseView.Tooltip](Divine.Menu.Views.BaseView.md\#Divine\_Menu\_Views\_BaseView\_Tooltip), 
[BaseView.IsSelected](Divine.Menu.Views.BaseView.md\#Divine\_Menu\_Views\_BaseView\_IsSelected), 
[BaseView.IsHovered](Divine.Menu.Views.BaseView.md\#Divine\_Menu\_Views\_BaseView\_IsHovered), 
[BaseView.SelectedView](Divine.Menu.Views.BaseView.md\#Divine\_Menu\_Views\_BaseView\_SelectedView), 
[BaseView.ExtraHeight](Divine.Menu.Views.BaseView.md\#Divine\_Menu\_Views\_BaseView\_ExtraHeight), 
[BaseView.Rectangle](Divine.Menu.Views.BaseView.md\#Divine\_Menu\_Views\_BaseView\_Rectangle), 
[BaseView.ImageSize](Divine.Menu.Views.BaseView.md\#Divine\_Menu\_Views\_BaseView\_ImageSize), 
[BaseView.ImageRectangle](Divine.Menu.Views.BaseView.md\#Divine\_Menu\_Views\_BaseView\_ImageRectangle), 
[BaseView.Position](Divine.Menu.Views.BaseView.md\#Divine\_Menu\_Views\_BaseView\_Position), 
[BaseView.Left](Divine.Menu.Views.BaseView.md\#Divine\_Menu\_Views\_BaseView\_Left), 
[BaseView.Top](Divine.Menu.Views.BaseView.md\#Divine\_Menu\_Views\_BaseView\_Top), 
[BaseView.Right](Divine.Menu.Views.BaseView.md\#Divine\_Menu\_Views\_BaseView\_Right), 
[BaseView.Bottom](Divine.Menu.Views.BaseView.md\#Divine\_Menu\_Views\_BaseView\_Bottom), 
[BaseView.TopLeft](Divine.Menu.Views.BaseView.md\#Divine\_Menu\_Views\_BaseView\_TopLeft), 
[BaseView.TopRight](Divine.Menu.Views.BaseView.md\#Divine\_Menu\_Views\_BaseView\_TopRight), 
[BaseView.BottomLeft](Divine.Menu.Views.BaseView.md\#Divine\_Menu\_Views\_BaseView\_BottomLeft), 
[BaseView.BottomRight](Divine.Menu.Views.BaseView.md\#Divine\_Menu\_Views\_BaseView\_BottomRight), 
[BaseView.Size](Divine.Menu.Views.BaseView.md\#Divine\_Menu\_Views\_BaseView\_Size), 
[BaseView.Width](Divine.Menu.Views.BaseView.md\#Divine\_Menu\_Views\_BaseView\_Width), 
[BaseView.Height](Divine.Menu.Views.BaseView.md\#Divine\_Menu\_Views\_BaseView\_Height), 
[BaseView.OnRefreshSize\(\)](Divine.Menu.Views.BaseView.md\#Divine\_Menu\_Views\_BaseView\_OnRefreshSize), 
[BaseView.OnRefresh\(BaseView?, BaseView?\)](Divine.Menu.Views.BaseView.md\#Divine\_Menu\_Views\_BaseView\_OnRefresh\_Divine\_Menu\_Views\_BaseView\_Divine\_Menu\_Views\_BaseView\_), 
[BaseView.OnRefresh\(\)](Divine.Menu.Views.BaseView.md\#Divine\_Menu\_Views\_BaseView\_OnRefresh), 
[BaseView.OnDraw\(\)](Divine.Menu.Views.BaseView.md\#Divine\_Menu\_Views\_BaseView\_OnDraw), 
[BaseView.OnDrawStart\(\)](Divine.Menu.Views.BaseView.md\#Divine\_Menu\_Views\_BaseView\_OnDrawStart), 
[BaseView.OnDrawBackground\(\)](Divine.Menu.Views.BaseView.md\#Divine\_Menu\_Views\_BaseView\_OnDrawBackground), 
[BaseView.OnDrawSpecialImage\(\)](Divine.Menu.Views.BaseView.md\#Divine\_Menu\_Views\_BaseView\_OnDrawSpecialImage), 
[BaseView.OnDrawSpecialText\(\)](Divine.Menu.Views.BaseView.md\#Divine\_Menu\_Views\_BaseView\_OnDrawSpecialText), 
[BaseView.OnDrawHover\(\)](Divine.Menu.Views.BaseView.md\#Divine\_Menu\_Views\_BaseView\_OnDrawHover), 
[BaseView.OnDrawSpecial\(\)](Divine.Menu.Views.BaseView.md\#Divine\_Menu\_Views\_BaseView\_OnDrawSpecial), 
[BaseView.OnDrawImage\(\)](Divine.Menu.Views.BaseView.md\#Divine\_Menu\_Views\_BaseView\_OnDrawImage), 
[BaseView.OnMouseKeyDown\(bool, Vector2\)](Divine.Menu.Views.BaseView.md\#Divine\_Menu\_Views\_BaseView\_OnMouseKeyDown\_System\_Boolean\_System\_Numerics\_Vector2\_), 
[BaseView.OnMouseKeyUp\(bool, Vector2\)](Divine.Menu.Views.BaseView.md\#Divine\_Menu\_Views\_BaseView\_OnMouseKeyUp\_System\_Boolean\_System\_Numerics\_Vector2\_), 
[BaseView.OnMouseMove\(Vector2\)](Divine.Menu.Views.BaseView.md\#Divine\_Menu\_Views\_BaseView\_OnMouseMove\_System\_Numerics\_Vector2\_), 
[BaseView.OnMouseWheel\(bool, Vector2\)](Divine.Menu.Views.BaseView.md\#Divine\_Menu\_Views\_BaseView\_OnMouseWheel\_System\_Boolean\_System\_Numerics\_Vector2\_), 
[BaseView.OnContextShow\(\)](Divine.Menu.Views.BaseView.md\#Divine\_Menu\_Views\_BaseView\_OnContextShow), 
[BaseView.OnContextHide\(\)](Divine.Menu.Views.BaseView.md\#Divine\_Menu\_Views\_BaseView\_OnContextHide), 
[BaseView.OnHoverStart\(\)](Divine.Menu.Views.BaseView.md\#Divine\_Menu\_Views\_BaseView\_OnHoverStart), 
[BaseView.OnHoverEnd\(\)](Divine.Menu.Views.BaseView.md\#Divine\_Menu\_Views\_BaseView\_OnHoverEnd), 
[BaseView.GetHoverValue\(\)](Divine.Menu.Views.BaseView.md\#Divine\_Menu\_Views\_BaseView\_GetHoverValue), 
[BaseView.CreateMiniMenu\(string, Vector2\)](Divine.Menu.Views.BaseView.md\#Divine\_Menu\_Views\_BaseView\_CreateMiniMenu\_System\_String\_System\_Numerics\_Vector2\_), 
[BaseView.RemoveMiniMenu\(\)](Divine.Menu.Views.BaseView.md\#Divine\_Menu\_Views\_BaseView\_RemoveMiniMenu), 
[BaseView.OnShowMiniMenu\(MiniMenu\)](Divine.Menu.Views.BaseView.md\#Divine\_Menu\_Views\_BaseView\_OnShowMiniMenu\_Divine\_Menu\_Items\_MiniMenu\_), 
[BaseView.OnHideMiniMenu\(MiniMenu\)](Divine.Menu.Views.BaseView.md\#Divine\_Menu\_Views\_BaseView\_OnHideMiniMenu\_Divine\_Menu\_Items\_MiniMenu\_), 
[BaseView.OnReset\(\)](Divine.Menu.Views.BaseView.md\#Divine\_Menu\_Views\_BaseView\_OnReset), 
[BaseView.OnShow\(\)](Divine.Menu.Views.BaseView.md\#Divine\_Menu\_Views\_BaseView\_OnShow), 
[BaseView.OnHide\(\)](Divine.Menu.Views.BaseView.md\#Divine\_Menu\_Views\_BaseView\_OnHide), 
[BaseView.OnEnable\(\)](Divine.Menu.Views.BaseView.md\#Divine\_Menu\_Views\_BaseView\_OnEnable), 
[BaseView.OnDisable\(\)](Divine.Menu.Views.BaseView.md\#Divine\_Menu\_Views\_BaseView\_OnDisable), 
[BaseView.Dispose\(\)](Divine.Menu.Views.BaseView.md\#Divine\_Menu\_Views\_BaseView\_Dispose), 
[BaseView.ToString\(\)](Divine.Menu.Views.BaseView.md\#Divine\_Menu\_Views\_BaseView\_ToString), 
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
[EnumerableExtensions.In<MenuView\>\(MenuView, params MenuView\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Menu_Views_Default_MenuView__ctor_Divine_Menu_Items_MenuItem_Divine_Menu_Styles_IStyle_Divine_Menu_Styles_IGeneralStyle_Divine_Menu_Renderers_IMenuRenderer_"></a> MenuView\(MenuItem, IStyle, IGeneralStyle, IMenuRenderer\)

```csharp
public MenuView(MenuItem owner, IStyle style, IGeneralStyle generalStyle, IMenuRenderer menuRenderer)
```

#### Parameters

`owner` [MenuItem](Divine.Menu.Items.MenuItem.md)

`style` [IStyle](Divine.Menu.Styles.IStyle.md)

`generalStyle` [IGeneralStyle](Divine.Menu.Styles.IGeneralStyle.md)

`menuRenderer` [IMenuRenderer](Divine.Menu.Renderers.IMenuRenderer.md)

## Properties

### <a id="Divine_Menu_Views_Default_MenuView_ElementsWidth"></a> ElementsWidth

```csharp
protected override float ElementsWidth { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Views_Default_MenuView_Owner"></a> Owner

```csharp
public Menu Owner { get; }
```

#### Property Value

 [Menu](Divine.Menu.Items.Menu.md)

### <a id="Divine_Menu_Views_Default_MenuView_Style"></a> Style

```csharp
public MenuStyle Style { get; }
```

#### Property Value

 [MenuStyle](Divine.Menu.Styles.Default.MenuStyle.md)

### <a id="Divine_Menu_Views_Default_MenuView_UnderChildRectangleCheck"></a> UnderChildRectangleCheck

```csharp
public override bool UnderChildRectangleCheck { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Menu_Views_Default_MenuView_Views"></a> Views

```csharp
public IView[] Views { get; }
```

#### Property Value

 [IView](Divine.Menu.Views.IView.md)\[\]

## Methods

### <a id="Divine_Menu_Views_Default_MenuView_GetSideAnimation"></a> GetSideAnimation\(\)

```csharp
protected float GetSideAnimation()
```

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Views_Default_MenuView_OnCalculateChildRectangle"></a> OnCalculateChildRectangle\(\)

```csharp
protected override Rect OnCalculateChildRectangle()
```

#### Returns

 [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

### <a id="Divine_Menu_Views_Default_MenuView_OnCalculateChildSize"></a> OnCalculateChildSize\(\)

```csharp
protected override Size OnCalculateChildSize()
```

#### Returns

 [Size](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Size.cs)

### <a id="Divine_Menu_Views_Default_MenuView_OnCalculateDisplayTextRectangle"></a> OnCalculateDisplayTextRectangle\(\)

```csharp
protected override Rect OnCalculateDisplayTextRectangle()
```

#### Returns

 [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

### <a id="Divine_Menu_Views_Default_MenuView_OnCalculateImageRectangle"></a> OnCalculateImageRectangle\(\)

```csharp
protected override RoundedRect OnCalculateImageRectangle()
```

#### Returns

 [RoundedRect](Divine.Renderer.Numerics.RoundedRect.md)

### <a id="Divine_Menu_Views_Default_MenuView_OnCollapse"></a> OnCollapse\(\)

```csharp
protected override void OnCollapse()
```

### <a id="Divine_Menu_Views_Default_MenuView_OnContextHide"></a> OnContextHide\(\)

```csharp
protected override void OnContextHide()
```

### <a id="Divine_Menu_Views_Default_MenuView_OnContextShow"></a> OnContextShow\(\)

```csharp
protected override void OnContextShow()
```

### <a id="Divine_Menu_Views_Default_MenuView_OnDrawAfterChild"></a> OnDrawAfterChild\(\)

```csharp
public void OnDrawAfterChild()
```

### <a id="Divine_Menu_Views_Default_MenuView_OnDrawChild"></a> OnDrawChild\(\)

```csharp
protected override void OnDrawChild()
```

### <a id="Divine_Menu_Views_Default_MenuView_OnDrawSpecial"></a> OnDrawSpecial\(\)

```csharp
protected override void OnDrawSpecial()
```

### <a id="Divine_Menu_Views_Default_MenuView_OnExpand"></a> OnExpand\(\)

```csharp
protected override void OnExpand()
```

### <a id="Divine_Menu_Views_Default_MenuView_OnRefresh"></a> OnRefresh\(\)

```csharp
protected override void OnRefresh()
```

### <a id="Divine_Menu_Views_Default_MenuView_OnShowMiniMenu_Divine_Menu_Items_MiniMenu_"></a> OnShowMiniMenu\(MiniMenu\)

```csharp
protected override void OnShowMiniMenu(MiniMenu miniMenu)
```

#### Parameters

`miniMenu` [MiniMenu](Divine.Menu.Items.MiniMenu.md)

### <a id="Divine_Menu_Views_Default_MenuView_OnSideForward"></a> OnSideForward\(\)

```csharp
protected void OnSideForward()
```

### <a id="Divine_Menu_Views_Default_MenuView_OnSideReset"></a> OnSideReset\(\)

```csharp
protected void OnSideReset()
```

