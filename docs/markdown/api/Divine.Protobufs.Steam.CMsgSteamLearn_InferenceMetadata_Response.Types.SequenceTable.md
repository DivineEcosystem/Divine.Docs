# <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_SequenceTable"></a> Class CMsgSteamLearn\_InferenceMetadata\_Response.Types.SequenceTable

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamLearn_InferenceMetadata_Response.Types.SequenceTable : IMessage<CMsgSteamLearn_InferenceMetadata_Response.Types.SequenceTable>, IEquatable<CMsgSteamLearn_InferenceMetadata_Response.Types.SequenceTable>, IDeepCloneable<CMsgSteamLearn_InferenceMetadata_Response.Types.SequenceTable>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamLearn\_InferenceMetadata\_Response.Types.SequenceTable](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.SequenceTable.md)

#### Implements

IMessage<CMsgSteamLearn\_InferenceMetadata\_Response.Types.SequenceTable\>, 
[IEquatable<CMsgSteamLearn\_InferenceMetadata\_Response.Types.SequenceTable\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamLearn\_InferenceMetadata\_Response.Types.SequenceTable\>, 
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
[EnumerableExtensions.In<CMsgSteamLearn\_InferenceMetadata\_Response.Types.SequenceTable\>\(CMsgSteamLearn\_InferenceMetadata\_Response.Types.SequenceTable, params CMsgSteamLearn\_InferenceMetadata\_Response.Types.SequenceTable\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_SequenceTable__ctor"></a> SequenceTable\(\)

```csharp
public SequenceTable()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_SequenceTable__ctor_Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_SequenceTable_"></a> SequenceTable\(SequenceTable\)

```csharp
public SequenceTable(CMsgSteamLearn_InferenceMetadata_Response.Types.SequenceTable other)
```

#### Parameters

`other` [CMsgSteamLearn\_InferenceMetadata\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.md).[SequenceTable](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.SequenceTable.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_SequenceTable_MapMappingsFieldNumber"></a> MapMappingsFieldNumber

```csharp
public const int MapMappingsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_SequenceTable_MapValuesFieldNumber"></a> MapValuesFieldNumber

```csharp
public const int MapValuesFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_SequenceTable_NameFieldNumber"></a> NameFieldNumber

```csharp
public const int NameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_SequenceTable_TotalCountFieldNumber"></a> TotalCountFieldNumber

```csharp
public const int TotalCountFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_SequenceTable_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_SequenceTable_HasName"></a> HasName

```csharp
public bool HasName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_SequenceTable_HasTotalCount"></a> HasTotalCount

```csharp
public bool HasTotalCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_SequenceTable_MapMappings"></a> MapMappings

```csharp
public MapField<string, CMsgSteamLearn_InferenceMetadata_Response.Types.SequenceTable.Types.Entry> MapMappings { get; }
```

#### Property Value

 MapField<[string](https://learn.microsoft.com/dotnet/api/system.string), [CMsgSteamLearn\_InferenceMetadata\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.md).[SequenceTable](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.SequenceTable.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.SequenceTable.Types.md).[Entry](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.SequenceTable.Types.Entry.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_SequenceTable_MapValues"></a> MapValues

```csharp
public MapField<uint, CMsgSteamLearn_InferenceMetadata_Response.Types.SequenceTable.Types.Entry> MapValues { get; }
```

#### Property Value

 MapField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32), [CMsgSteamLearn\_InferenceMetadata\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.md).[SequenceTable](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.SequenceTable.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.SequenceTable.Types.md).[Entry](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.SequenceTable.Types.Entry.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_SequenceTable_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_SequenceTable_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamLearn_InferenceMetadata_Response.Types.SequenceTable> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamLearn\_InferenceMetadata\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.md).[SequenceTable](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.SequenceTable.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_SequenceTable_TotalCount"></a> TotalCount

```csharp
public ulong TotalCount { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_SequenceTable_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_SequenceTable_ClearName"></a> ClearName\(\)

```csharp
public void ClearName()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_SequenceTable_ClearTotalCount"></a> ClearTotalCount\(\)

```csharp
public void ClearTotalCount()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_SequenceTable_Clone"></a> Clone\(\)

```csharp
public CMsgSteamLearn_InferenceMetadata_Response.Types.SequenceTable Clone()
```

#### Returns

 [CMsgSteamLearn\_InferenceMetadata\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.md).[SequenceTable](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.SequenceTable.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_SequenceTable_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_SequenceTable_Equals_Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_SequenceTable_"></a> Equals\(SequenceTable\)

```csharp
public bool Equals(CMsgSteamLearn_InferenceMetadata_Response.Types.SequenceTable other)
```

#### Parameters

`other` [CMsgSteamLearn\_InferenceMetadata\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.md).[SequenceTable](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.SequenceTable.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_SequenceTable_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_SequenceTable_MergeFrom_Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_SequenceTable_"></a> MergeFrom\(SequenceTable\)

```csharp
public void MergeFrom(CMsgSteamLearn_InferenceMetadata_Response.Types.SequenceTable other)
```

#### Parameters

`other` [CMsgSteamLearn\_InferenceMetadata\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.md).[SequenceTable](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.SequenceTable.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_SequenceTable_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_SequenceTable_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_SequenceTable_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

