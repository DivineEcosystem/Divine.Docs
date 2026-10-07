# <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_SnapshotHistogram"></a> Class CMsgSteamLearn\_InferenceMetadata\_Response.Types.SnapshotHistogram

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamLearn_InferenceMetadata_Response.Types.SnapshotHistogram : IMessage<CMsgSteamLearn_InferenceMetadata_Response.Types.SnapshotHistogram>, IEquatable<CMsgSteamLearn_InferenceMetadata_Response.Types.SnapshotHistogram>, IDeepCloneable<CMsgSteamLearn_InferenceMetadata_Response.Types.SnapshotHistogram>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamLearn\_InferenceMetadata\_Response.Types.SnapshotHistogram](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.SnapshotHistogram.md)

#### Implements

IMessage<CMsgSteamLearn\_InferenceMetadata\_Response.Types.SnapshotHistogram\>, 
[IEquatable<CMsgSteamLearn\_InferenceMetadata\_Response.Types.SnapshotHistogram\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamLearn\_InferenceMetadata\_Response.Types.SnapshotHistogram\>, 
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
[EnumerableExtensions.In<CMsgSteamLearn\_InferenceMetadata\_Response.Types.SnapshotHistogram\>\(CMsgSteamLearn\_InferenceMetadata\_Response.Types.SnapshotHistogram, params CMsgSteamLearn\_InferenceMetadata\_Response.Types.SnapshotHistogram\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_SnapshotHistogram__ctor"></a> SnapshotHistogram\(\)

```csharp
public SnapshotHistogram()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_SnapshotHistogram__ctor_Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_SnapshotHistogram_"></a> SnapshotHistogram\(SnapshotHistogram\)

```csharp
public SnapshotHistogram(CMsgSteamLearn_InferenceMetadata_Response.Types.SnapshotHistogram other)
```

#### Parameters

`other` [CMsgSteamLearn\_InferenceMetadata\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.md).[SnapshotHistogram](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.SnapshotHistogram.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_SnapshotHistogram_BucketCountsFieldNumber"></a> BucketCountsFieldNumber

```csharp
public const int BucketCountsFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_SnapshotHistogram_MaxValueFieldNumber"></a> MaxValueFieldNumber

```csharp
public const int MaxValueFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_SnapshotHistogram_MinValueFieldNumber"></a> MinValueFieldNumber

```csharp
public const int MinValueFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_SnapshotHistogram_NumBucketsFieldNumber"></a> NumBucketsFieldNumber

```csharp
public const int NumBucketsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_SnapshotHistogram_BucketCounts"></a> BucketCounts

```csharp
public RepeatedField<uint> BucketCounts { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_SnapshotHistogram_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_SnapshotHistogram_HasMaxValue"></a> HasMaxValue

```csharp
public bool HasMaxValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_SnapshotHistogram_HasMinValue"></a> HasMinValue

```csharp
public bool HasMinValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_SnapshotHistogram_HasNumBuckets"></a> HasNumBuckets

```csharp
public bool HasNumBuckets { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_SnapshotHistogram_MaxValue"></a> MaxValue

```csharp
public float MaxValue { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_SnapshotHistogram_MinValue"></a> MinValue

```csharp
public float MinValue { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_SnapshotHistogram_NumBuckets"></a> NumBuckets

```csharp
public uint NumBuckets { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_SnapshotHistogram_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamLearn_InferenceMetadata_Response.Types.SnapshotHistogram> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamLearn\_InferenceMetadata\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.md).[SnapshotHistogram](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.SnapshotHistogram.md)\>

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_SnapshotHistogram_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_SnapshotHistogram_ClearMaxValue"></a> ClearMaxValue\(\)

```csharp
public void ClearMaxValue()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_SnapshotHistogram_ClearMinValue"></a> ClearMinValue\(\)

```csharp
public void ClearMinValue()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_SnapshotHistogram_ClearNumBuckets"></a> ClearNumBuckets\(\)

```csharp
public void ClearNumBuckets()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_SnapshotHistogram_Clone"></a> Clone\(\)

```csharp
public CMsgSteamLearn_InferenceMetadata_Response.Types.SnapshotHistogram Clone()
```

#### Returns

 [CMsgSteamLearn\_InferenceMetadata\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.md).[SnapshotHistogram](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.SnapshotHistogram.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_SnapshotHistogram_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_SnapshotHistogram_Equals_Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_SnapshotHistogram_"></a> Equals\(SnapshotHistogram\)

```csharp
public bool Equals(CMsgSteamLearn_InferenceMetadata_Response.Types.SnapshotHistogram other)
```

#### Parameters

`other` [CMsgSteamLearn\_InferenceMetadata\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.md).[SnapshotHistogram](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.SnapshotHistogram.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_SnapshotHistogram_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_SnapshotHistogram_MergeFrom_Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_SnapshotHistogram_"></a> MergeFrom\(SnapshotHistogram\)

```csharp
public void MergeFrom(CMsgSteamLearn_InferenceMetadata_Response.Types.SnapshotHistogram other)
```

#### Parameters

`other` [CMsgSteamLearn\_InferenceMetadata\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.md).[SnapshotHistogram](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.SnapshotHistogram.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_SnapshotHistogram_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_SnapshotHistogram_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_SnapshotHistogram_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

