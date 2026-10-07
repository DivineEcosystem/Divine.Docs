# <a id="Divine_Menu_EventArgs_TogglerPriorityChangedEventArgs_1"></a> Class TogglerPriorityChangedEventArgs<T\>

Namespace: [Divine.Menu.EventArgs](Divine.Menu.EventArgs.md)  
Assembly: Divine.dll  

```csharp
public class TogglerPriorityChangedEventArgs<T> : TogglerKeyValueEventArgs<T>
```

#### Type Parameters

`T` 

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[EventArgs](https://learn.microsoft.com/dotnet/api/system.eventargs) ← 
[MenuEventArgs](Divine.Menu.EventArgs.MenuEventArgs.md) ← 
[MenuValueEventArgs<bool\>](Divine.Menu.EventArgs.MenuValueEventArgs\-1.md) ← 
[TogglerKeyValueEventArgs<T\>](Divine.Menu.EventArgs.TogglerKeyValueEventArgs\-1.md) ← 
[TogglerPriorityChangedEventArgs<T\>](Divine.Menu.EventArgs.TogglerPriorityChangedEventArgs\-1.md)

#### Inherited Members

[TogglerKeyValueEventArgs<T\>.Key](Divine.Menu.EventArgs.TogglerKeyValueEventArgs\-1.md\#Divine\_Menu\_EventArgs\_TogglerKeyValueEventArgs\_1\_Key), 
[MenuValueEventArgs<bool\>.Value](Divine.Menu.EventArgs.MenuValueEventArgs\-1.md\#Divine\_Menu\_EventArgs\_MenuValueEventArgs\_1\_Value), 
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
[EnumerableExtensions.In<TogglerPriorityChangedEventArgs<T\>\>\(TogglerPriorityChangedEventArgs<T\>, params TogglerPriorityChangedEventArgs<T\>\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Menu_EventArgs_TogglerPriorityChangedEventArgs_1__ctor"></a> TogglerPriorityChangedEventArgs\(\)

```csharp
public TogglerPriorityChangedEventArgs()
```

### <a id="Divine_Menu_EventArgs_TogglerPriorityChangedEventArgs_1__ctor__0_System_Boolean_System_Int32_System_Int32_"></a> TogglerPriorityChangedEventArgs\(T, bool, int, int\)

```csharp
[SetsRequiredMembers]
public TogglerPriorityChangedEventArgs(T key, bool value, int priority, int oldPriority)
```

#### Parameters

`key` T

`value` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`priority` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`oldPriority` [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Menu_EventArgs_TogglerPriorityChangedEventArgs_1_OldPriority"></a> OldPriority

```csharp
public required int OldPriority { get; init; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Menu_EventArgs_TogglerPriorityChangedEventArgs_1_Priority"></a> Priority

```csharp
public required int Priority { get; init; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

