# <a id="Divine_Entity_Entities_EventArgs_NetworkPropertyChangedEventArgs"></a> Class NetworkPropertyChangedEventArgs

Namespace: [Divine.Entity.Entities.EventArgs](Divine.Entity.Entities.EventArgs.md)  
Assembly: Divine.dll  

```csharp
public sealed class NetworkPropertyChangedEventArgs : EventArgs
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[EventArgs](https://learn.microsoft.com/dotnet/api/system.eventargs) ← 
[NetworkPropertyChangedEventArgs](Divine.Entity.Entities.EventArgs.NetworkPropertyChangedEventArgs.md)

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
[EnumerableExtensions.In<NetworkPropertyChangedEventArgs\>\(NetworkPropertyChangedEventArgs, params NetworkPropertyChangedEventArgs\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Properties

### <a id="Divine_Entity_Entities_EventArgs_NetworkPropertyChangedEventArgs_NewValue"></a> NewValue

```csharp
public NetworkPropertyValue NewValue { get; }
```

#### Property Value

 [NetworkPropertyValue](Divine.Entity.Entities.Components.NetworkPropertyValue.md)

### <a id="Divine_Entity_Entities_EventArgs_NetworkPropertyChangedEventArgs_OldValue"></a> OldValue

```csharp
public NetworkPropertyValue OldValue { get; }
```

#### Property Value

 [NetworkPropertyValue](Divine.Entity.Entities.Components.NetworkPropertyValue.md)

### <a id="Divine_Entity_Entities_EventArgs_NetworkPropertyChangedEventArgs_PropertyName"></a> PropertyName

```csharp
public string PropertyName { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Entity_Entities_EventArgs_NetworkPropertyChangedEventArgs_ValueTypeName"></a> ValueTypeName

```csharp
public string ValueTypeName { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

