# <a id="Divine_Protobufs_Dota2_CSVCMsg_ClearAllStringTables"></a> Class CSVCMsg\_ClearAllStringTables

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSVCMsg_ClearAllStringTables : IMessage<CSVCMsg_ClearAllStringTables>, IEquatable<CSVCMsg_ClearAllStringTables>, IDeepCloneable<CSVCMsg_ClearAllStringTables>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSVCMsg\_ClearAllStringTables](Divine.Protobufs.Dota2.CSVCMsg\_ClearAllStringTables.md)

#### Implements

IMessage<CSVCMsg\_ClearAllStringTables\>, 
[IEquatable<CSVCMsg\_ClearAllStringTables\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSVCMsg\_ClearAllStringTables\>, 
IBufferMessage, 
IMessage

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<CSVCMsg\_ClearAllStringTables\>\(CSVCMsg\_ClearAllStringTables, params CSVCMsg\_ClearAllStringTables\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ClearAllStringTables__ctor"></a> CSVCMsg\_ClearAllStringTables\(\)

```csharp
public CSVCMsg_ClearAllStringTables()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ClearAllStringTables__ctor_Divine_Protobufs_Dota2_CSVCMsg_ClearAllStringTables_"></a> CSVCMsg\_ClearAllStringTables\(CSVCMsg\_ClearAllStringTables\)

```csharp
public CSVCMsg_ClearAllStringTables(CSVCMsg_ClearAllStringTables other)
```

#### Parameters

`other` [CSVCMsg\_ClearAllStringTables](Divine.Protobufs.Dota2.CSVCMsg\_ClearAllStringTables.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ClearAllStringTables_CreateTablesSkippedFieldNumber"></a> CreateTablesSkippedFieldNumber

```csharp
public const int CreateTablesSkippedFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ClearAllStringTables_MapnameFieldNumber"></a> MapnameFieldNumber

```csharp
public const int MapnameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ClearAllStringTables_CreateTablesSkipped"></a> CreateTablesSkipped

```csharp
public bool CreateTablesSkipped { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ClearAllStringTables_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ClearAllStringTables_HasCreateTablesSkipped"></a> HasCreateTablesSkipped

```csharp
public bool HasCreateTablesSkipped { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ClearAllStringTables_HasMapname"></a> HasMapname

```csharp
public bool HasMapname { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ClearAllStringTables_Mapname"></a> Mapname

```csharp
public string Mapname { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ClearAllStringTables_Parser"></a> Parser

```csharp
public static MessageParser<CSVCMsg_ClearAllStringTables> Parser { get; }
```

#### Property Value

 MessageParser<[CSVCMsg\_ClearAllStringTables](Divine.Protobufs.Dota2.CSVCMsg\_ClearAllStringTables.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ClearAllStringTables_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ClearAllStringTables_ClearCreateTablesSkipped"></a> ClearCreateTablesSkipped\(\)

```csharp
public void ClearCreateTablesSkipped()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ClearAllStringTables_ClearMapname"></a> ClearMapname\(\)

```csharp
public void ClearMapname()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ClearAllStringTables_Clone"></a> Clone\(\)

```csharp
public CSVCMsg_ClearAllStringTables Clone()
```

#### Returns

 [CSVCMsg\_ClearAllStringTables](Divine.Protobufs.Dota2.CSVCMsg\_ClearAllStringTables.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ClearAllStringTables_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ClearAllStringTables_Equals_Divine_Protobufs_Dota2_CSVCMsg_ClearAllStringTables_"></a> Equals\(CSVCMsg\_ClearAllStringTables\)

```csharp
public bool Equals(CSVCMsg_ClearAllStringTables other)
```

#### Parameters

`other` [CSVCMsg\_ClearAllStringTables](Divine.Protobufs.Dota2.CSVCMsg\_ClearAllStringTables.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ClearAllStringTables_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ClearAllStringTables_MergeFrom_Divine_Protobufs_Dota2_CSVCMsg_ClearAllStringTables_"></a> MergeFrom\(CSVCMsg\_ClearAllStringTables\)

```csharp
public void MergeFrom(CSVCMsg_ClearAllStringTables other)
```

#### Parameters

`other` [CSVCMsg\_ClearAllStringTables](Divine.Protobufs.Dota2.CSVCMsg\_ClearAllStringTables.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ClearAllStringTables_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ClearAllStringTables_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ClearAllStringTables_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

