# <a id="Divine_Protobufs_Dota2_CMsgGCToGCGetInfuxIntervalStatsResponse"></a> Class CMsgGCToGCGetInfuxIntervalStatsResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToGCGetInfuxIntervalStatsResponse : IMessage<CMsgGCToGCGetInfuxIntervalStatsResponse>, IEquatable<CMsgGCToGCGetInfuxIntervalStatsResponse>, IDeepCloneable<CMsgGCToGCGetInfuxIntervalStatsResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToGCGetInfuxIntervalStatsResponse](Divine.Protobufs.Dota2.CMsgGCToGCGetInfuxIntervalStatsResponse.md)

#### Implements

IMessage<CMsgGCToGCGetInfuxIntervalStatsResponse\>, 
[IEquatable<CMsgGCToGCGetInfuxIntervalStatsResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToGCGetInfuxIntervalStatsResponse\>, 
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
[EnumerableExtensions.In<CMsgGCToGCGetInfuxIntervalStatsResponse\>\(CMsgGCToGCGetInfuxIntervalStatsResponse, params CMsgGCToGCGetInfuxIntervalStatsResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGetInfuxIntervalStatsResponse__ctor"></a> CMsgGCToGCGetInfuxIntervalStatsResponse\(\)

```csharp
public CMsgGCToGCGetInfuxIntervalStatsResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGetInfuxIntervalStatsResponse__ctor_Divine_Protobufs_Dota2_CMsgGCToGCGetInfuxIntervalStatsResponse_"></a> CMsgGCToGCGetInfuxIntervalStatsResponse\(CMsgGCToGCGetInfuxIntervalStatsResponse\)

```csharp
public CMsgGCToGCGetInfuxIntervalStatsResponse(CMsgGCToGCGetInfuxIntervalStatsResponse other)
```

#### Parameters

`other` [CMsgGCToGCGetInfuxIntervalStatsResponse](Divine.Protobufs.Dota2.CMsgGCToGCGetInfuxIntervalStatsResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGetInfuxIntervalStatsResponse_SampleDurationMsFieldNumber"></a> SampleDurationMsFieldNumber

```csharp
public const int SampleDurationMsFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGetInfuxIntervalStatsResponse_StatIdsFieldNumber"></a> StatIdsFieldNumber

```csharp
public const int StatIdsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGetInfuxIntervalStatsResponse_StatMaxFieldNumber"></a> StatMaxFieldNumber

```csharp
public const int StatMaxFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGetInfuxIntervalStatsResponse_StatSamplesFieldNumber"></a> StatSamplesFieldNumber

```csharp
public const int StatSamplesFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGetInfuxIntervalStatsResponse_StatTotalFieldNumber"></a> StatTotalFieldNumber

```csharp
public const int StatTotalFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGetInfuxIntervalStatsResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGetInfuxIntervalStatsResponse_HasSampleDurationMs"></a> HasSampleDurationMs

```csharp
public bool HasSampleDurationMs { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGetInfuxIntervalStatsResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToGCGetInfuxIntervalStatsResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToGCGetInfuxIntervalStatsResponse](Divine.Protobufs.Dota2.CMsgGCToGCGetInfuxIntervalStatsResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGetInfuxIntervalStatsResponse_SampleDurationMs"></a> SampleDurationMs

```csharp
public uint SampleDurationMs { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGetInfuxIntervalStatsResponse_StatIds"></a> StatIds

```csharp
public RepeatedField<uint> StatIds { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGetInfuxIntervalStatsResponse_StatMax"></a> StatMax

```csharp
public RepeatedField<uint> StatMax { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGetInfuxIntervalStatsResponse_StatSamples"></a> StatSamples

```csharp
public RepeatedField<uint> StatSamples { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGetInfuxIntervalStatsResponse_StatTotal"></a> StatTotal

```csharp
public RepeatedField<ulong> StatTotal { get; }
```

#### Property Value

 RepeatedField<[ulong](https://learn.microsoft.com/dotnet/api/system.uint64)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGetInfuxIntervalStatsResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGetInfuxIntervalStatsResponse_ClearSampleDurationMs"></a> ClearSampleDurationMs\(\)

```csharp
public void ClearSampleDurationMs()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGetInfuxIntervalStatsResponse_Clone"></a> Clone\(\)

```csharp
public CMsgGCToGCGetInfuxIntervalStatsResponse Clone()
```

#### Returns

 [CMsgGCToGCGetInfuxIntervalStatsResponse](Divine.Protobufs.Dota2.CMsgGCToGCGetInfuxIntervalStatsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGetInfuxIntervalStatsResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGetInfuxIntervalStatsResponse_Equals_Divine_Protobufs_Dota2_CMsgGCToGCGetInfuxIntervalStatsResponse_"></a> Equals\(CMsgGCToGCGetInfuxIntervalStatsResponse\)

```csharp
public bool Equals(CMsgGCToGCGetInfuxIntervalStatsResponse other)
```

#### Parameters

`other` [CMsgGCToGCGetInfuxIntervalStatsResponse](Divine.Protobufs.Dota2.CMsgGCToGCGetInfuxIntervalStatsResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGetInfuxIntervalStatsResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGetInfuxIntervalStatsResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToGCGetInfuxIntervalStatsResponse_"></a> MergeFrom\(CMsgGCToGCGetInfuxIntervalStatsResponse\)

```csharp
public void MergeFrom(CMsgGCToGCGetInfuxIntervalStatsResponse other)
```

#### Parameters

`other` [CMsgGCToGCGetInfuxIntervalStatsResponse](Divine.Protobufs.Dota2.CMsgGCToGCGetInfuxIntervalStatsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGetInfuxIntervalStatsResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGetInfuxIntervalStatsResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGetInfuxIntervalStatsResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

