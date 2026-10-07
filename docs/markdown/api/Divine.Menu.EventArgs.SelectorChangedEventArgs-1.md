# <a id="Divine_Menu_EventArgs_SelectorChangedEventArgs_1"></a> Class SelectorChangedEventArgs<T\>

Namespace: [Divine.Menu.EventArgs](Divine.Menu.EventArgs.md)  
Assembly: Divine.dll  

```csharp
public class SelectorChangedEventArgs<T> : MenuNewOldValueEventArgs<T>
```

#### Type Parameters

`T` 

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[EventArgs](https://learn.microsoft.com/dotnet/api/system.eventargs) ← 
[MenuEventArgs](Divine.Menu.EventArgs.MenuEventArgs.md) ← 
[MenuValueEventArgs<T\>](Divine.Menu.EventArgs.MenuValueEventArgs\-1.md) ← 
[MenuNewOldValueEventArgs<T\>](Divine.Menu.EventArgs.MenuNewOldValueEventArgs\-1.md) ← 
[SelectorChangedEventArgs<T\>](Divine.Menu.EventArgs.SelectorChangedEventArgs\-1.md)

#### Inherited Members

[MenuNewOldValueEventArgs<T\>.OldValue](Divine.Menu.EventArgs.MenuNewOldValueEventArgs\-1.md\#Divine\_Menu\_EventArgs\_MenuNewOldValueEventArgs\_1\_OldValue), 
[MenuValueEventArgs<T\>.Value](Divine.Menu.EventArgs.MenuValueEventArgs\-1.md\#Divine\_Menu\_EventArgs\_MenuValueEventArgs\_1\_Value), 
[MenuEventArgs.Behavior](Divine.Menu.EventArgs.MenuEventArgs.md\#Divine\_Menu\_EventArgs\_MenuEventArgs\_Behavior), 
[MenuEventArgs.IsEvent](Divine.Menu.EventArgs.MenuEventArgs.md\#Divine\_Menu\_EventArgs\_MenuEventArgs\_IsEvent), 
[MenuEventArgs.IsAddEvent](Divine.Menu.EventArgs.MenuEventArgs.md\#Divine\_Menu\_EventArgs\_MenuEventArgs\_IsAddEvent), 
[MenuEventArgs.IsRemoveEvent](Divine.Menu.EventArgs.MenuEventArgs.md\#Divine\_Menu\_EventArgs\_MenuEventArgs\_IsRemoveEvent), 
[EventArgs.Empty](https://learn.microsoft.com/dotnet/api/system.eventargs.empty), 
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
[EnumerableExtensions.In<SelectorChangedEventArgs<T\>\>\(SelectorChangedEventArgs<T\>, params SelectorChangedEventArgs<T\>\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Menu_EventArgs_SelectorChangedEventArgs_1__ctor"></a> SelectorChangedEventArgs\(\)

```csharp
public SelectorChangedEventArgs()
```

### <a id="Divine_Menu_EventArgs_SelectorChangedEventArgs_1__ctor_System_Int32_System_String__0_System_Int32_System_String__0_"></a> SelectorChangedEventArgs\(int, string, T, int, string, T\)

```csharp
[SetsRequiredMembers]
public SelectorChangedEventArgs(int index, string key, T value, int oldIndex, string oldKey, T oldValue)
```

#### Parameters

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`key` [string](https://learn.microsoft.com/dotnet/api/system.string)

`value` T

`oldIndex` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`oldKey` [string](https://learn.microsoft.com/dotnet/api/system.string)

`oldValue` T

## Properties

### <a id="Divine_Menu_EventArgs_SelectorChangedEventArgs_1_Index"></a> Index

```csharp
public required int Index { get; init; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Menu_EventArgs_SelectorChangedEventArgs_1_Key"></a> Key

```csharp
public required string Key { get; init; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Menu_EventArgs_SelectorChangedEventArgs_1_OldIndex"></a> OldIndex

```csharp
public required int OldIndex { get; init; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Menu_EventArgs_SelectorChangedEventArgs_1_OldKey"></a> OldKey

```csharp
public required string OldKey { get; init; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

