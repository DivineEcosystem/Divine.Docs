# <a id="Divine_Menu_Views_IMainView"></a> Interface IMainView

Namespace: [Divine.Menu.Views](Divine.Menu.Views.md)  
Assembly: Divine.dll  

```csharp
public interface IMainView : IContextView, IMenuView, IExpanderView, ITextView, IView
```

#### Implements

[IContextView](Divine.Menu.Views.IContextView.md), 
[IMenuView](Divine.Menu.Views.IMenuView.md), 
[IExpanderView](Divine.Menu.Views.IExpanderView.md), 
[ITextView](Divine.Menu.Views.ITextView.md), 
[IView](Divine.Menu.Views.IView.md)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<IMainView\>\(IMainView, params IMainView\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Properties

### <a id="Divine_Menu_Views_IMainView_BottomView"></a> BottomView

```csharp
IView BottomView { get; }
```

#### Property Value

 [IView](Divine.Menu.Views.IView.md)

### <a id="Divine_Menu_Views_IMainView_FullRectangle"></a> FullRectangle

```csharp
Rect FullRectangle { get; }
```

#### Property Value

 [Rect](https://github.com/amerkoleci/Vortice.Mathematics/blob/main/src/Vortice.Mathematics/Rect.cs)

