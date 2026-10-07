# <a id="Divine_Menu_Views_IContextView"></a> Interface IContextView

Namespace: [Divine.Menu.Views](Divine.Menu.Views.md)  
Assembly: Divine.dll  

```csharp
public interface IContextView : IMenuView, IExpanderView, ITextView, IView
```

#### Implements

[IMenuView](Divine.Menu.Views.IMenuView.md), 
[IExpanderView](Divine.Menu.Views.IExpanderView.md), 
[ITextView](Divine.Menu.Views.ITextView.md), 
[IView](Divine.Menu.Views.IView.md)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<IContextView\>\(IContextView, params IContextView\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Properties

### <a id="Divine_Menu_Views_IContextView_Owner"></a> Owner

```csharp
MenuContext Owner { get; }
```

#### Property Value

 [MenuContext](Divine.Menu.Items.MenuContext.md)

### <a id="Divine_Menu_Views_IContextView_ShowOpacityProgress"></a> ShowOpacityProgress

```csharp
float ShowOpacityProgress { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Views_IContextView_Style"></a> Style

```csharp
IContextStyle Style { get; }
```

#### Property Value

 [IContextStyle](Divine.Menu.Styles.IContextStyle.md)

## Methods

### <a id="Divine_Menu_Views_IContextView_GetTotalRectangle"></a> GetTotalRectangle\(\)

```csharp
Rect GetTotalRectangle()
```

#### Returns

 [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

### <a id="Divine_Menu_Views_IContextView_OnSetPosition"></a> OnSetPosition\(\)

```csharp
void OnSetPosition()
```

