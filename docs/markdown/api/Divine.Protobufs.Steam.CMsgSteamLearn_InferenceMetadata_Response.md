# <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response"></a> Class CMsgSteamLearn\_InferenceMetadata\_Response

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamLearn_InferenceMetadata_Response : IMessage<CMsgSteamLearn_InferenceMetadata_Response>, IEquatable<CMsgSteamLearn_InferenceMetadata_Response>, IDeepCloneable<CMsgSteamLearn_InferenceMetadata_Response>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamLearn\_InferenceMetadata\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.md)

#### Implements

IMessage<CMsgSteamLearn\_InferenceMetadata\_Response\>, 
[IEquatable<CMsgSteamLearn\_InferenceMetadata\_Response\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamLearn\_InferenceMetadata\_Response\>, 
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
[EnumerableExtensions.In<CMsgSteamLearn\_InferenceMetadata\_Response\>\(CMsgSteamLearn\_InferenceMetadata\_Response, params CMsgSteamLearn\_InferenceMetadata\_Response\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response__ctor"></a> CMsgSteamLearn\_InferenceMetadata\_Response\(\)

```csharp
public CMsgSteamLearn_InferenceMetadata_Response()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response__ctor_Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_"></a> CMsgSteamLearn\_InferenceMetadata\_Response\(CMsgSteamLearn\_InferenceMetadata\_Response\)

```csharp
public CMsgSteamLearn_InferenceMetadata_Response(CMsgSteamLearn_InferenceMetadata_Response other)
```

#### Parameters

`other` [CMsgSteamLearn\_InferenceMetadata\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_AppInfoFieldNumber"></a> AppInfoFieldNumber

```csharp
public const int AppInfoFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_CompactTablesFieldNumber"></a> CompactTablesFieldNumber

```csharp
public const int CompactTablesFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_InferenceMetadataResultFieldNumber"></a> InferenceMetadataResultFieldNumber

```csharp
public const int InferenceMetadataResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_KmeansFieldNumber"></a> KmeansFieldNumber

```csharp
public const int KmeansFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_RangesFieldNumber"></a> RangesFieldNumber

```csharp
public const int RangesFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_RowRangeFieldNumber"></a> RowRangeFieldNumber

```csharp
public const int RowRangeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_SequenceTablesFieldNumber"></a> SequenceTablesFieldNumber

```csharp
public const int SequenceTablesFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_SnapshotHistogramFieldNumber"></a> SnapshotHistogramFieldNumber

```csharp
public const int SnapshotHistogramFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_StdDevsFieldNumber"></a> StdDevsFieldNumber

```csharp
public const int StdDevsFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_AppInfo"></a> AppInfo

```csharp
public MapField<uint, CMsgSteamLearn_InferenceMetadata_Response.Types.AppInfo> AppInfo { get; }
```

#### Property Value

 MapField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32), [CMsgSteamLearn\_InferenceMetadata\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.md).[AppInfo](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.AppInfo.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_CompactTables"></a> CompactTables

```csharp
public RepeatedField<CMsgSteamLearn_InferenceMetadata_Response.Types.CompactTable> CompactTables { get; }
```

#### Property Value

 RepeatedField<[CMsgSteamLearn\_InferenceMetadata\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.md).[CompactTable](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.CompactTable.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_HasInferenceMetadataResult"></a> HasInferenceMetadataResult

```csharp
public bool HasInferenceMetadataResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_InferenceMetadataResult"></a> InferenceMetadataResult

```csharp
public ESteamLearnInferenceMetadataResult InferenceMetadataResult { get; set; }
```

#### Property Value

 [ESteamLearnInferenceMetadataResult](Divine.Protobufs.Steam.ESteamLearnInferenceMetadataResult.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Kmeans"></a> Kmeans

```csharp
public RepeatedField<CMsgSteamLearn_InferenceMetadata_Response.Types.KMeans> Kmeans { get; }
```

#### Property Value

 RepeatedField<[CMsgSteamLearn\_InferenceMetadata\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.md).[KMeans](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.KMeans.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamLearn_InferenceMetadata_Response> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamLearn\_InferenceMetadata\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Ranges"></a> Ranges

```csharp
public RepeatedField<CMsgSteamLearn_InferenceMetadata_Response.Types.Range> Ranges { get; }
```

#### Property Value

 RepeatedField<[CMsgSteamLearn\_InferenceMetadata\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.md).[Range](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.Range.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_RowRange"></a> RowRange

```csharp
public CMsgSteamLearn_InferenceMetadata_Response.Types.RowRange RowRange { get; set; }
```

#### Property Value

 [CMsgSteamLearn\_InferenceMetadata\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.md).[RowRange](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.RowRange.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_SequenceTables"></a> SequenceTables

```csharp
public RepeatedField<CMsgSteamLearn_InferenceMetadata_Response.Types.SequenceTable> SequenceTables { get; }
```

#### Property Value

 RepeatedField<[CMsgSteamLearn\_InferenceMetadata\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.md).[SequenceTable](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.SequenceTable.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_SnapshotHistogram"></a> SnapshotHistogram

```csharp
public CMsgSteamLearn_InferenceMetadata_Response.Types.SnapshotHistogram SnapshotHistogram { get; set; }
```

#### Property Value

 [CMsgSteamLearn\_InferenceMetadata\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.md).[SnapshotHistogram](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.SnapshotHistogram.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_StdDevs"></a> StdDevs

```csharp
public RepeatedField<CMsgSteamLearn_InferenceMetadata_Response.Types.StdDev> StdDevs { get; }
```

#### Property Value

 RepeatedField<[CMsgSteamLearn\_InferenceMetadata\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.md).[StdDev](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.StdDev.md)\>

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_ClearInferenceMetadataResult"></a> ClearInferenceMetadataResult\(\)

```csharp
public void ClearInferenceMetadataResult()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Clone"></a> Clone\(\)

```csharp
public CMsgSteamLearn_InferenceMetadata_Response Clone()
```

#### Returns

 [CMsgSteamLearn\_InferenceMetadata\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Equals_Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_"></a> Equals\(CMsgSteamLearn\_InferenceMetadata\_Response\)

```csharp
public bool Equals(CMsgSteamLearn_InferenceMetadata_Response other)
```

#### Parameters

`other` [CMsgSteamLearn\_InferenceMetadata\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_MergeFrom_Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_"></a> MergeFrom\(CMsgSteamLearn\_InferenceMetadata\_Response\)

```csharp
public void MergeFrom(CMsgSteamLearn_InferenceMetadata_Response other)
```

#### Parameters

`other` [CMsgSteamLearn\_InferenceMetadata\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

