# <a id="Divine_Menu_Views_IInputKeyView"></a> Interface IInputKeyView

Namespace: [Divine.Menu.Views](Divine.Menu.Views.md)  
Assembly: Divine.dll  

```csharp
public interface IInputKeyView : ITextView, IView
```

#### Implements

[ITextView](Divine.Menu.Views.ITextView.md), 
[IView](Divine.Menu.Views.IView.md)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<IInputKeyView\>\(IInputKeyView, params IInputKeyView\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Properties

### <a id="Divine_Menu_Views_IInputKeyView_IsAssigningNewKey"></a> IsAssigningNewKey

```csharp
bool IsAssigningNewKey { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Menu_Views_IInputKeyView_OnKeyChanged"></a> OnKeyChanged\(\)

```csharp
void OnKeyChanged()
```

