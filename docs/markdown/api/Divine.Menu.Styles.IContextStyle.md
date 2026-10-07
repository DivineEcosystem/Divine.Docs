# <a id="Divine_Menu_Styles_IContextStyle"></a> Interface IContextStyle

Namespace: [Divine.Menu.Styles](Divine.Menu.Styles.md)  
Assembly: Divine.dll  

```csharp
public interface IContextStyle : IStyle
```

#### Implements

[IStyle](Divine.Menu.Styles.IStyle.md)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<IContextStyle\>\(IContextStyle, params IContextStyle\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Properties

### <a id="Divine_Menu_Styles_IContextStyle_ButtonStyle"></a> ButtonStyle

```csharp
IButtonStyle ButtonStyle { get; }
```

#### Property Value

 [IButtonStyle](Divine.Menu.Styles.IButtonStyle.md)

### <a id="Divine_Menu_Styles_IContextStyle_ChildExtraWidth"></a> ChildExtraWidth

```csharp
float ChildExtraWidth { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Styles_IContextStyle_ChildMarginLeft"></a> ChildMarginLeft

```csharp
float ChildMarginLeft { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Styles_IContextStyle_ChildWidth"></a> ChildWidth

```csharp
float ChildWidth { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Styles_IContextStyle_GeneralStyle"></a> GeneralStyle

```csharp
IGeneralStyle GeneralStyle { get; }
```

#### Property Value

 [IGeneralStyle](Divine.Menu.Styles.IGeneralStyle.md)

### <a id="Divine_Menu_Styles_IContextStyle_HoldKeyStyle"></a> HoldKeyStyle

```csharp
IHoldKeyStyle HoldKeyStyle { get; }
```

#### Property Value

 [IHoldKeyStyle](Divine.Menu.Styles.IHoldKeyStyle.md)

### <a id="Divine_Menu_Styles_IContextStyle_InnerButtonStyle"></a> InnerButtonStyle

```csharp
IInnerButtonStyle InnerButtonStyle { get; }
```

#### Property Value

 [IInnerButtonStyle](Divine.Menu.Styles.IInnerButtonStyle.md)

### <a id="Divine_Menu_Styles_IContextStyle_InputKeyStyle"></a> InputKeyStyle

```csharp
IInputKeyStyle InputKeyStyle { get; }
```

#### Property Value

 [IInputKeyStyle](Divine.Menu.Styles.IInputKeyStyle.md)

### <a id="Divine_Menu_Styles_IContextStyle_InputTextStyle"></a> InputTextStyle

```csharp
IInputTextStyle InputTextStyle { get; }
```

#### Property Value

 [IInputTextStyle](Divine.Menu.Styles.IInputTextStyle.md)

### <a id="Divine_Menu_Styles_IContextStyle_MenuStyle"></a> MenuStyle

```csharp
IMenuStyle MenuStyle { get; }
```

#### Property Value

 [IMenuStyle](Divine.Menu.Styles.IMenuStyle.md)

### <a id="Divine_Menu_Styles_IContextStyle_SearcherStyle"></a> SearcherStyle

```csharp
ISearcherStyle SearcherStyle { get; }
```

#### Property Value

 [ISearcherStyle](Divine.Menu.Styles.ISearcherStyle.md)

### <a id="Divine_Menu_Styles_IContextStyle_SelectorStyle"></a> SelectorStyle

```csharp
ISelectorStyle SelectorStyle { get; }
```

#### Property Value

 [ISelectorStyle](Divine.Menu.Styles.ISelectorStyle.md)

### <a id="Divine_Menu_Styles_IContextStyle_SliderStyle"></a> SliderStyle

```csharp
ISliderStyle SliderStyle { get; }
```

#### Property Value

 [ISliderStyle](Divine.Menu.Styles.ISliderStyle.md)

### <a id="Divine_Menu_Styles_IContextStyle_SwitcherStyle"></a> SwitcherStyle

```csharp
ISwitcherStyle SwitcherStyle { get; }
```

#### Property Value

 [ISwitcherStyle](Divine.Menu.Styles.ISwitcherStyle.md)

### <a id="Divine_Menu_Styles_IContextStyle_TextStyle"></a> TextStyle

```csharp
ITextStyle TextStyle { get; }
```

#### Property Value

 [ITextStyle](Divine.Menu.Styles.ITextStyle.md)

### <a id="Divine_Menu_Styles_IContextStyle_ToggleKeyStyle"></a> ToggleKeyStyle

```csharp
IToggleKeyStyle ToggleKeyStyle { get; }
```

#### Property Value

 [IToggleKeyStyle](Divine.Menu.Styles.IToggleKeyStyle.md)

### <a id="Divine_Menu_Styles_IContextStyle_TogglerStyle"></a> TogglerStyle

```csharp
ITogglerStyle TogglerStyle { get; }
```

#### Property Value

 [ITogglerStyle](Divine.Menu.Styles.ITogglerStyle.md)

### <a id="Divine_Menu_Styles_IContextStyle_Width"></a> Width

```csharp
float Width { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Styles_IContextStyle_WithSwitcherStyle"></a> WithSwitcherStyle

```csharp
IWithSwitcherStyle WithSwitcherStyle { get; }
```

#### Property Value

 [IWithSwitcherStyle](Divine.Menu.Styles.IWithSwitcherStyle.md)

## Methods

### <a id="Divine_Menu_Styles_IContextStyle_CreateButtonView_Divine_Menu_Items_MenuItem_"></a> CreateButtonView\(MenuItem\)

```csharp
IButtonView CreateButtonView(MenuItem owner)
```

#### Parameters

`owner` [MenuItem](Divine.Menu.Items.MenuItem.md)

#### Returns

 [IButtonView](Divine.Menu.Views.IButtonView.md)

### <a id="Divine_Menu_Styles_IContextStyle_CreateContextView_Divine_Menu_Items_MenuItem_"></a> CreateContextView\(MenuItem\)

```csharp
IContextView CreateContextView(MenuItem owner)
```

#### Parameters

`owner` [MenuItem](Divine.Menu.Items.MenuItem.md)

#### Returns

 [IContextView](Divine.Menu.Views.IContextView.md)

### <a id="Divine_Menu_Styles_IContextStyle_CreateHoldKeyView_Divine_Menu_Items_MenuItem_"></a> CreateHoldKeyView\(MenuItem\)

```csharp
IHoldKeyView CreateHoldKeyView(MenuItem owner)
```

#### Parameters

`owner` [MenuItem](Divine.Menu.Items.MenuItem.md)

#### Returns

 [IHoldKeyView](Divine.Menu.Views.IHoldKeyView.md)

### <a id="Divine_Menu_Styles_IContextStyle_CreateInnerButtonView_Divine_Menu_Items_MenuItem_"></a> CreateInnerButtonView\(MenuItem\)

```csharp
IInnerButtonView CreateInnerButtonView(MenuItem owner)
```

#### Parameters

`owner` [MenuItem](Divine.Menu.Items.MenuItem.md)

#### Returns

 [IInnerButtonView](Divine.Menu.Views.IInnerButtonView.md)

### <a id="Divine_Menu_Styles_IContextStyle_CreateInputKeyView_Divine_Menu_Items_MenuItem_"></a> CreateInputKeyView\(MenuItem\)

```csharp
IInputKeyView CreateInputKeyView(MenuItem owner)
```

#### Parameters

`owner` [MenuItem](Divine.Menu.Items.MenuItem.md)

#### Returns

 [IInputKeyView](Divine.Menu.Views.IInputKeyView.md)

### <a id="Divine_Menu_Styles_IContextStyle_CreateInputTextView_Divine_Menu_Items_MenuItem_"></a> CreateInputTextView\(MenuItem\)

```csharp
IInputTextView CreateInputTextView(MenuItem owner)
```

#### Parameters

`owner` [MenuItem](Divine.Menu.Items.MenuItem.md)

#### Returns

 [IInputTextView](Divine.Menu.Views.IInputTextView.md)

### <a id="Divine_Menu_Styles_IContextStyle_CreateMenuView_Divine_Menu_Items_MenuItem_"></a> CreateMenuView\(MenuItem\)

```csharp
IMenuView CreateMenuView(MenuItem owner)
```

#### Parameters

`owner` [MenuItem](Divine.Menu.Items.MenuItem.md)

#### Returns

 [IMenuView](Divine.Menu.Views.IMenuView.md)

### <a id="Divine_Menu_Styles_IContextStyle_CreateSearcherView_Divine_Menu_Items_MenuItem_"></a> CreateSearcherView\(MenuItem\)

```csharp
ISearcherView CreateSearcherView(MenuItem owner)
```

#### Parameters

`owner` [MenuItem](Divine.Menu.Items.MenuItem.md)

#### Returns

 [ISearcherView](Divine.Menu.Views.ISearcherView.md)

### <a id="Divine_Menu_Styles_IContextStyle_CreateSelectorView__1_Divine_Menu_Items_MenuItem_"></a> CreateSelectorView<T\>\(MenuItem\)

```csharp
ISelectorView<T> CreateSelectorView<T>(MenuItem owner) where T : notnull
```

#### Parameters

`owner` [MenuItem](Divine.Menu.Items.MenuItem.md)

#### Returns

 [ISelectorView](Divine.Menu.Views.ISelectorView\-1.md)<T\>

#### Type Parameters

`T` 

### <a id="Divine_Menu_Styles_IContextStyle_CreateSliderView_Divine_Menu_Items_MenuItem_"></a> CreateSliderView\(MenuItem\)

```csharp
ISliderView CreateSliderView(MenuItem owner)
```

#### Parameters

`owner` [MenuItem](Divine.Menu.Items.MenuItem.md)

#### Returns

 [ISliderView](Divine.Menu.Views.ISliderView.md)

### <a id="Divine_Menu_Styles_IContextStyle_CreateSwitcherView_Divine_Menu_Items_MenuItem_"></a> CreateSwitcherView\(MenuItem\)

```csharp
ISwitcherView CreateSwitcherView(MenuItem owner)
```

#### Parameters

`owner` [MenuItem](Divine.Menu.Items.MenuItem.md)

#### Returns

 [ISwitcherView](Divine.Menu.Views.ISwitcherView.md)

### <a id="Divine_Menu_Styles_IContextStyle_CreateTextView_Divine_Menu_Items_MenuItem_"></a> CreateTextView\(MenuItem\)

```csharp
ITextView CreateTextView(MenuItem owner)
```

#### Parameters

`owner` [MenuItem](Divine.Menu.Items.MenuItem.md)

#### Returns

 [ITextView](Divine.Menu.Views.ITextView.md)

### <a id="Divine_Menu_Styles_IContextStyle_CreateToggleKeyView_Divine_Menu_Items_MenuItem_"></a> CreateToggleKeyView\(MenuItem\)

```csharp
IToggleKeyView CreateToggleKeyView(MenuItem owner)
```

#### Parameters

`owner` [MenuItem](Divine.Menu.Items.MenuItem.md)

#### Returns

 [IToggleKeyView](Divine.Menu.Views.IToggleKeyView.md)

### <a id="Divine_Menu_Styles_IContextStyle_CreateTogglerView__1_Divine_Menu_Items_MenuItem_"></a> CreateTogglerView<T\>\(MenuItem\)

```csharp
ITogglerView<T> CreateTogglerView<T>(MenuItem owner) where T : notnull
```

#### Parameters

`owner` [MenuItem](Divine.Menu.Items.MenuItem.md)

#### Returns

 [ITogglerView](Divine.Menu.Views.ITogglerView\-1.md)<T\>

#### Type Parameters

`T` 

### <a id="Divine_Menu_Styles_IContextStyle_CreateWithSwitcherView_Divine_Menu_Items_MenuItem_"></a> CreateWithSwitcherView\(MenuItem\)

```csharp
IWithSwitcherView CreateWithSwitcherView(MenuItem owner)
```

#### Parameters

`owner` [MenuItem](Divine.Menu.Items.MenuItem.md)

#### Returns

 [IWithSwitcherView](Divine.Menu.Views.IWithSwitcherView.md)

