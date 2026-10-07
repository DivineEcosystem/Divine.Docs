# <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_CompactTable_Types_Entry"></a> Class CMsgSteamLearn\_InferenceMetadata\_Response.Types.CompactTable.Types.Entry

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamLearn_InferenceMetadata_Response.Types.CompactTable.Types.Entry : IMessage<CMsgSteamLearn_InferenceMetadata_Response.Types.CompactTable.Types.Entry>, IEquatable<CMsgSteamLearn_InferenceMetadata_Response.Types.CompactTable.Types.Entry>, IDeepCloneable<CMsgSteamLearn_InferenceMetadata_Response.Types.CompactTable.Types.Entry>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamLearn\_InferenceMetadata\_Response.Types.CompactTable.Types.Entry](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.CompactTable.Types.Entry.md)

#### Implements

IMessage<CMsgSteamLearn\_InferenceMetadata\_Response.Types.CompactTable.Types.Entry\>, 
[IEquatable<CMsgSteamLearn\_InferenceMetadata\_Response.Types.CompactTable.Types.Entry\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamLearn\_InferenceMetadata\_Response.Types.CompactTable.Types.Entry\>, 
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
[EnumerableExtensions.In<CMsgSteamLearn\_InferenceMetadata\_Response.Types.CompactTable.Types.Entry\>\(CMsgSteamLearn\_InferenceMetadata\_Response.Types.CompactTable.Types.Entry, params CMsgSteamLearn\_InferenceMetadata\_Response.Types.CompactTable.Types.Entry\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_CompactTable_Types_Entry__ctor"></a> Entry\(\)

```csharp
public Entry()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_CompactTable_Types_Entry__ctor_Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_CompactTable_Types_Entry_"></a> Entry\(Entry\)

```csharp
public Entry(CMsgSteamLearn_InferenceMetadata_Response.Types.CompactTable.Types.Entry other)
```

#### Parameters

`other` [CMsgSteamLearn\_InferenceMetadata\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.md).[CompactTable](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.CompactTable.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.CompactTable.Types.md).[Entry](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.CompactTable.Types.Entry.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_CompactTable_Types_Entry_CountFieldNumber"></a> CountFieldNumber

```csharp
public const int CountFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_CompactTable_Types_Entry_MappingFieldNumber"></a> MappingFieldNumber

```csharp
public const int MappingFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_CompactTable_Types_Entry_ValueFieldNumber"></a> ValueFieldNumber

```csharp
public const int ValueFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_CompactTable_Types_Entry_Count"></a> Count

```csharp
public ulong Count { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_CompactTable_Types_Entry_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_CompactTable_Types_Entry_HasCount"></a> HasCount

```csharp
public bool HasCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_CompactTable_Types_Entry_HasMapping"></a> HasMapping

```csharp
public bool HasMapping { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_CompactTable_Types_Entry_HasValue"></a> HasValue

```csharp
public bool HasValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_CompactTable_Types_Entry_Mapping"></a> Mapping

```csharp
public uint Mapping { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_CompactTable_Types_Entry_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamLearn_InferenceMetadata_Response.Types.CompactTable.Types.Entry> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamLearn\_InferenceMetadata\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.md).[CompactTable](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.CompactTable.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.CompactTable.Types.md).[Entry](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.CompactTable.Types.Entry.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_CompactTable_Types_Entry_Value"></a> Value

```csharp
public uint Value { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_CompactTable_Types_Entry_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_CompactTable_Types_Entry_ClearCount"></a> ClearCount\(\)

```csharp
public void ClearCount()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_CompactTable_Types_Entry_ClearMapping"></a> ClearMapping\(\)

```csharp
public void ClearMapping()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_CompactTable_Types_Entry_ClearValue"></a> ClearValue\(\)

```csharp
public void ClearValue()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_CompactTable_Types_Entry_Clone"></a> Clone\(\)

```csharp
public CMsgSteamLearn_InferenceMetadata_Response.Types.CompactTable.Types.Entry Clone()
```

#### Returns

 [CMsgSteamLearn\_InferenceMetadata\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.md).[CompactTable](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.CompactTable.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.CompactTable.Types.md).[Entry](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.CompactTable.Types.Entry.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_CompactTable_Types_Entry_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_CompactTable_Types_Entry_Equals_Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_CompactTable_Types_Entry_"></a> Equals\(Entry\)

```csharp
public bool Equals(CMsgSteamLearn_InferenceMetadata_Response.Types.CompactTable.Types.Entry other)
```

#### Parameters

`other` [CMsgSteamLearn\_InferenceMetadata\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.md).[CompactTable](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.CompactTable.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.CompactTable.Types.md).[Entry](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.CompactTable.Types.Entry.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_CompactTable_Types_Entry_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_CompactTable_Types_Entry_MergeFrom_Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_CompactTable_Types_Entry_"></a> MergeFrom\(Entry\)

```csharp
public void MergeFrom(CMsgSteamLearn_InferenceMetadata_Response.Types.CompactTable.Types.Entry other)
```

#### Parameters

`other` [CMsgSteamLearn\_InferenceMetadata\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.md).[CompactTable](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.CompactTable.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.CompactTable.Types.md).[Entry](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.CompactTable.Types.Entry.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_CompactTable_Types_Entry_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_CompactTable_Types_Entry_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_CompactTable_Types_Entry_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

