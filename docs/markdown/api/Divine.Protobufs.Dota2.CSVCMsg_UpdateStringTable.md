# <a id="Divine_Protobufs_Dota2_CSVCMsg_UpdateStringTable"></a> Class CSVCMsg\_UpdateStringTable

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSVCMsg_UpdateStringTable : IMessage<CSVCMsg_UpdateStringTable>, IEquatable<CSVCMsg_UpdateStringTable>, IDeepCloneable<CSVCMsg_UpdateStringTable>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSVCMsg\_UpdateStringTable](Divine.Protobufs.Dota2.CSVCMsg\_UpdateStringTable.md)

#### Implements

IMessage<CSVCMsg\_UpdateStringTable\>, 
[IEquatable<CSVCMsg\_UpdateStringTable\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSVCMsg\_UpdateStringTable\>, 
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
[EnumerableExtensions.In<CSVCMsg\_UpdateStringTable\>\(CSVCMsg\_UpdateStringTable, params CSVCMsg\_UpdateStringTable\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSVCMsg_UpdateStringTable__ctor"></a> CSVCMsg\_UpdateStringTable\(\)

```csharp
public CSVCMsg_UpdateStringTable()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_UpdateStringTable__ctor_Divine_Protobufs_Dota2_CSVCMsg_UpdateStringTable_"></a> CSVCMsg\_UpdateStringTable\(CSVCMsg\_UpdateStringTable\)

```csharp
public CSVCMsg_UpdateStringTable(CSVCMsg_UpdateStringTable other)
```

#### Parameters

`other` [CSVCMsg\_UpdateStringTable](Divine.Protobufs.Dota2.CSVCMsg\_UpdateStringTable.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSVCMsg_UpdateStringTable_NumChangedEntriesFieldNumber"></a> NumChangedEntriesFieldNumber

```csharp
public const int NumChangedEntriesFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_UpdateStringTable_StringDataFieldNumber"></a> StringDataFieldNumber

```csharp
public const int StringDataFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_UpdateStringTable_TableIdFieldNumber"></a> TableIdFieldNumber

```csharp
public const int TableIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSVCMsg_UpdateStringTable_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSVCMsg_UpdateStringTable_HasNumChangedEntries"></a> HasNumChangedEntries

```csharp
public bool HasNumChangedEntries { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_UpdateStringTable_HasStringData"></a> HasStringData

```csharp
public bool HasStringData { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_UpdateStringTable_HasTableId"></a> HasTableId

```csharp
public bool HasTableId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_UpdateStringTable_NumChangedEntries"></a> NumChangedEntries

```csharp
public int NumChangedEntries { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_UpdateStringTable_Parser"></a> Parser

```csharp
public static MessageParser<CSVCMsg_UpdateStringTable> Parser { get; }
```

#### Property Value

 MessageParser<[CSVCMsg\_UpdateStringTable](Divine.Protobufs.Dota2.CSVCMsg\_UpdateStringTable.md)\>

### <a id="Divine_Protobufs_Dota2_CSVCMsg_UpdateStringTable_StringData"></a> StringData

```csharp
public ByteString StringData { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Dota2_CSVCMsg_UpdateStringTable_TableId"></a> TableId

```csharp
public int TableId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CSVCMsg_UpdateStringTable_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_UpdateStringTable_ClearNumChangedEntries"></a> ClearNumChangedEntries\(\)

```csharp
public void ClearNumChangedEntries()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_UpdateStringTable_ClearStringData"></a> ClearStringData\(\)

```csharp
public void ClearStringData()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_UpdateStringTable_ClearTableId"></a> ClearTableId\(\)

```csharp
public void ClearTableId()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_UpdateStringTable_Clone"></a> Clone\(\)

```csharp
public CSVCMsg_UpdateStringTable Clone()
```

#### Returns

 [CSVCMsg\_UpdateStringTable](Divine.Protobufs.Dota2.CSVCMsg\_UpdateStringTable.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_UpdateStringTable_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_UpdateStringTable_Equals_Divine_Protobufs_Dota2_CSVCMsg_UpdateStringTable_"></a> Equals\(CSVCMsg\_UpdateStringTable\)

```csharp
public bool Equals(CSVCMsg_UpdateStringTable other)
```

#### Parameters

`other` [CSVCMsg\_UpdateStringTable](Divine.Protobufs.Dota2.CSVCMsg\_UpdateStringTable.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_UpdateStringTable_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_UpdateStringTable_MergeFrom_Divine_Protobufs_Dota2_CSVCMsg_UpdateStringTable_"></a> MergeFrom\(CSVCMsg\_UpdateStringTable\)

```csharp
public void MergeFrom(CSVCMsg_UpdateStringTable other)
```

#### Parameters

`other` [CSVCMsg\_UpdateStringTable](Divine.Protobufs.Dota2.CSVCMsg\_UpdateStringTable.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_UpdateStringTable_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSVCMsg_UpdateStringTable_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_UpdateStringTable_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

