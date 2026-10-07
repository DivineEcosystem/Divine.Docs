# <a id="Divine_Menu_Views_Default_InputTextView"></a> Class InputTextView

Namespace: [Divine.Menu.Views.Default](Divine.Menu.Views.Default.md)  
Assembly: Divine.dll  

```csharp
public class InputTextView : TextView, IInputTextView, ITextView, IView
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[BaseView](Divine.Menu.Views.BaseView.md) ← 
[View](Divine.Menu.Views.Default.View.md) ← 
[TextView](Divine.Menu.Views.Default.TextView.md) ← 
[InputTextView](Divine.Menu.Views.Default.InputTextView.md)

#### Derived

[SearcherView](Divine.Menu.Views.Default.SearcherView.md)

#### Implements

[IInputTextView](Divine.Menu.Views.IInputTextView.md), 
[ITextView](Divine.Menu.Views.ITextView.md), 
[IView](Divine.Menu.Views.IView.md)

#### Inherited Members

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
[EnumerableExtensions.In<InputTextView\>\(InputTextView, params InputTextView\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Menu_Views_Default_InputTextView__ctor_Divine_Menu_Items_MenuItem_Divine_Menu_Styles_IStyle_Divine_Menu_Styles_IGeneralStyle_Divine_Menu_Renderers_IMenuRenderer_"></a> InputTextView\(MenuItem, IStyle, IGeneralStyle, IMenuRenderer\)

```csharp
public InputTextView(MenuItem owner, IStyle style, IGeneralStyle generalStyle, IMenuRenderer menuRenderer)
```

#### Parameters

`owner` [MenuItem](Divine.Menu.Items.MenuItem.md)

`style` [IStyle](Divine.Menu.Styles.IStyle.md)

`generalStyle` [IGeneralStyle](Divine.Menu.Styles.IGeneralStyle.md)

`menuRenderer` [IMenuRenderer](Divine.Menu.Renderers.IMenuRenderer.md)

## Fields

### <a id="Divine_Menu_Views_Default_InputTextView_isFocused"></a> isFocused

```csharp
public bool isFocused
```

#### Field Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Properties

### <a id="Divine_Menu_Views_Default_InputTextView_CursorPosition"></a> CursorPosition

```csharp
public int CursorPosition { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Menu_Views_Default_InputTextView_DisplayText"></a> DisplayText

```csharp
public override string DisplayText { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Menu_Views_Default_InputTextView_IsFocused"></a> IsFocused

```csharp
public bool IsFocused { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Menu_Views_Default_InputTextView_Owner"></a> Owner

```csharp
public MenuInputText Owner { get; }
```

#### Property Value

 [MenuInputText](Divine.Menu.Items.MenuInputText.md)

### <a id="Divine_Menu_Views_Default_InputTextView_SelectionEnd"></a> SelectionEnd

```csharp
public int SelectionEnd { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Menu_Views_Default_InputTextView_SelectionLength"></a> SelectionLength

```csharp
public int SelectionLength { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Menu_Views_Default_InputTextView_SelectionStart"></a> SelectionStart

```csharp
public int SelectionStart { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Menu_Views_Default_InputTextView_Style"></a> Style

```csharp
public InputTextStyle Style { get; }
```

#### Property Value

 [InputTextStyle](Divine.Menu.Styles.Default.InputTextStyle.md)

### <a id="Divine_Menu_Views_Default_InputTextView_Text"></a> Text

```csharp
public virtual string Text { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Menu_Views_Default_InputTextView_TextLayout"></a> TextLayout

```csharp
public IDWriteTextLayout* TextLayout { get; }
```

#### Property Value

 IDWriteTextLayout\*

## Methods

### <a id="Divine_Menu_Views_Default_InputTextView_Clear"></a> Clear\(\)

```csharp
public void Clear()
```

### <a id="Divine_Menu_Views_Default_InputTextView_Copy"></a> Copy\(\)

```csharp
public void Copy()
```

### <a id="Divine_Menu_Views_Default_InputTextView_Dispose"></a> Dispose\(\)

```csharp
protected override void Dispose()
```

### <a id="Divine_Menu_Views_Default_InputTextView_Insert_System_String_"></a> Insert\(string\)

```csharp
public void Insert(string value)
```

#### Parameters

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Menu_Views_Default_InputTextView_OnContextHide"></a> OnContextHide\(\)

```csharp
protected override void OnContextHide()
```

### <a id="Divine_Menu_Views_Default_InputTextView_OnDrawDisplayText"></a> OnDrawDisplayText\(\)

```csharp
protected override void OnDrawDisplayText()
```

### <a id="Divine_Menu_Views_Default_InputTextView_OnMouseKeyDown_System_Boolean_System_Numerics_Vector2_"></a> OnMouseKeyDown\(bool, Vector2\)

```csharp
protected override bool OnMouseKeyDown(bool right, Vector2 position)
```

#### Parameters

`right` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Menu_Views_Default_InputTextView_OnMouseKeyUp_System_Boolean_System_Numerics_Vector2_"></a> OnMouseKeyUp\(bool, Vector2\)

```csharp
protected override bool OnMouseKeyUp(bool right, Vector2 position)
```

#### Parameters

`right` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Menu_Views_Default_InputTextView_OnMouseMove_System_Numerics_Vector2_"></a> OnMouseMove\(Vector2\)

```csharp
protected override bool OnMouseMove(Vector2 position)
```

#### Parameters

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Menu_Views_Default_InputTextView_OnRefresh"></a> OnRefresh\(\)

```csharp
protected override void OnRefresh()
```

### <a id="Divine_Menu_Views_Default_InputTextView_OnTextChanged"></a> OnTextChanged\(\)

```csharp
protected virtual void OnTextChanged()
```

### <a id="Divine_Menu_Views_Default_InputTextView_Past"></a> Past\(\)

```csharp
public void Past()
```

### <a id="Divine_Menu_Views_Default_InputTextView_Remove_System_Int32_"></a> Remove\(int\)

```csharp
public void Remove(int count = 1)
```

#### Parameters

`count` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Menu_Views_Default_InputTextView_SelectAll"></a> SelectAll\(\)

```csharp
public void SelectAll()
```

### <a id="Divine_Menu_Views_Default_InputTextView_Сut"></a> Сut\(\)

```csharp
public void Сut()
```

