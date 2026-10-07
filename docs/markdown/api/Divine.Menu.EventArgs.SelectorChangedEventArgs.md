# <a id="Divine_Menu_EventArgs_SelectorChangedEventArgs"></a> Class SelectorChangedEventArgs

Namespace: [Divine.Menu.EventArgs](Divine.Menu.EventArgs.md)  
Assembly: Divine.dll  

```csharp
public sealed class SelectorChangedEventArgs : SelectorChangedEventArgs<string>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[EventArgs](https://learn.microsoft.com/dotnet/api/system.eventargs) ← 
[MenuEventArgs](Divine.Menu.EventArgs.MenuEventArgs.md) ← 
[MenuValueEventArgs<string\>](Divine.Menu.EventArgs.MenuValueEventArgs\-1.md) ← 
[MenuNewOldValueEventArgs<string\>](Divine.Menu.EventArgs.MenuNewOldValueEventArgs\-1.md) ← 
[SelectorChangedEventArgs<string\>](Divine.Menu.EventArgs.SelectorChangedEventArgs\-1.md) ← 
[SelectorChangedEventArgs](Divine.Menu.EventArgs.SelectorChangedEventArgs.md)

#### Inherited Members

[SelectorChangedEventArgs<string\>.Index](Divine.Menu.EventArgs.SelectorChangedEventArgs\-1.md\#Divine\_Menu\_EventArgs\_SelectorChangedEventArgs\_1\_Index), 
[SelectorChangedEventArgs<string\>.Key](Divine.Menu.EventArgs.SelectorChangedEventArgs\-1.md\#Divine\_Menu\_EventArgs\_SelectorChangedEventArgs\_1\_Key), 
[SelectorChangedEventArgs<string\>.OldIndex](Divine.Menu.EventArgs.SelectorChangedEventArgs\-1.md\#Divine\_Menu\_EventArgs\_SelectorChangedEventArgs\_1\_OldIndex), 
[SelectorChangedEventArgs<string\>.OldKey](Divine.Menu.EventArgs.SelectorChangedEventArgs\-1.md\#Divine\_Menu\_EventArgs\_SelectorChangedEventArgs\_1\_OldKey), 
[MenuNewOldValueEventArgs<string\>.OldValue](Divine.Menu.EventArgs.MenuNewOldValueEventArgs\-1.md\#Divine\_Menu\_EventArgs\_MenuNewOldValueEventArgs\_1\_OldValue), 
[MenuValueEventArgs<string\>.Value](Divine.Menu.EventArgs.MenuValueEventArgs\-1.md\#Divine\_Menu\_EventArgs\_MenuValueEventArgs\_1\_Value), 
[MenuEventArgs.Behavior](Divine.Menu.EventArgs.MenuEventArgs.md\#Divine\_Menu\_EventArgs\_MenuEventArgs\_Behavior), 
[MenuEventArgs.IsEvent](Divine.Menu.EventArgs.MenuEventArgs.md\#Divine\_Menu\_EventArgs\_MenuEventArgs\_IsEvent), 
[MenuEventArgs.IsAddEvent](Divine.Menu.EventArgs.MenuEventArgs.md\#Divine\_Menu\_EventArgs\_MenuEventArgs\_IsAddEvent), 
[MenuEventArgs.IsRemoveEvent](Divine.Menu.EventArgs.MenuEventArgs.md\#Divine\_Menu\_EventArgs\_MenuEventArgs\_IsRemoveEvent), 
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
[EnumerableExtensions.In<SelectorChangedEventArgs\>\(SelectorChangedEventArgs, params SelectorChangedEventArgs\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Menu_EventArgs_SelectorChangedEventArgs__ctor"></a> SelectorChangedEventArgs\(\)

```csharp
public SelectorChangedEventArgs()
```

### <a id="Divine_Menu_EventArgs_SelectorChangedEventArgs__ctor_System_Int32_System_String_System_String_System_Int32_System_String_System_String_"></a> SelectorChangedEventArgs\(int, string, string, int, string, string\)

```csharp
[SetsRequiredMembers]
public SelectorChangedEventArgs(int index, string key, string value, int oldIndex, string oldKey, string oldValue)
```

#### Parameters

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`key` [string](https://learn.microsoft.com/dotnet/api/system.string)

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)

`oldIndex` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`oldKey` [string](https://learn.microsoft.com/dotnet/api/system.string)

`oldValue` [string](https://learn.microsoft.com/dotnet/api/system.string)

