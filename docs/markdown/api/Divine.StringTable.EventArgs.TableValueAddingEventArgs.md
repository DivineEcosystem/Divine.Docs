# <a id="Divine_StringTable_EventArgs_TableValueAddingEventArgs"></a> Class TableValueAddingEventArgs

Namespace: [Divine.StringTable.EventArgs](Divine.StringTable.EventArgs.md)  
Assembly: Divine.dll  

```csharp
public sealed class TableValueAddingEventArgs : EventArgs
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[EventArgs](https://learn.microsoft.com/dotnet/api/system.eventargs) ← 
[TableValueAddingEventArgs](Divine.StringTable.EventArgs.TableValueAddingEventArgs.md)

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
[EnumerableExtensions.In<TableValueAddingEventArgs\>\(TableValueAddingEventArgs, params TableValueAddingEventArgs\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Properties

### <a id="Divine_StringTable_EventArgs_TableValueAddingEventArgs_Data"></a> Data

```csharp
public ReadOnlySpan<byte> Data { get; }
```

#### Property Value

 [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[byte](https://learn.microsoft.com/dotnet/api/system.byte)\>

### <a id="Divine_StringTable_EventArgs_TableValueAddingEventArgs_IsCustom"></a> IsCustom

```csharp
public bool IsCustom { get; init; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_StringTable_EventArgs_TableValueAddingEventArgs_Process"></a> Process

```csharp
public bool Process { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_StringTable_EventArgs_TableValueAddingEventArgs_Table"></a> Table

```csharp
public required StringTable Table { get; init; }
```

#### Property Value

 [StringTable](Divine.StringTable.StringTable.md)

### <a id="Divine_StringTable_EventArgs_TableValueAddingEventArgs_Value"></a> Value

```csharp
public string Value { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

