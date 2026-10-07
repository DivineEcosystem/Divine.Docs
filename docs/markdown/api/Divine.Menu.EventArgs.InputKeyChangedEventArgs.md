# <a id="Divine_Menu_EventArgs_InputKeyChangedEventArgs"></a> Class InputKeyChangedEventArgs

Namespace: [Divine.Menu.EventArgs](Divine.Menu.EventArgs.md)  
Assembly: Divine.dll  

```csharp
public sealed class InputKeyChangedEventArgs : EventArgs
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[EventArgs](https://learn.microsoft.com/dotnet/api/system.eventargs) ← 
[InputKeyChangedEventArgs](Divine.Menu.EventArgs.InputKeyChangedEventArgs.md)

#### Inherited Members

[EventArgs.Empty](https://learn.microsoft.com/dotnet/api/system.eventargs.empty), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<InputKeyChangedEventArgs\>\(InputKeyChangedEventArgs, params InputKeyChangedEventArgs\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Menu_EventArgs_InputKeyChangedEventArgs__ctor"></a> InputKeyChangedEventArgs\(\)

```csharp
public InputKeyChangedEventArgs()
```

### <a id="Divine_Menu_EventArgs_InputKeyChangedEventArgs__ctor_Divine_Input_Key_Divine_Input_Key_"></a> InputKeyChangedEventArgs\(Key, Key\)

```csharp
[SetsRequiredMembers]
public InputKeyChangedEventArgs(Key key, Key oldKey)
```

#### Parameters

`key` [Key](Divine.Input.Key.md)

`oldKey` [Key](Divine.Input.Key.md)

## Properties

### <a id="Divine_Menu_EventArgs_InputKeyChangedEventArgs_Key"></a> Key

```csharp
public required Key Key { get; init; }
```

#### Property Value

 [Key](Divine.Input.Key.md)

### <a id="Divine_Menu_EventArgs_InputKeyChangedEventArgs_OldKey"></a> OldKey

```csharp
public required Key OldKey { get; init; }
```

#### Property Value

 [Key](Divine.Input.Key.md)

