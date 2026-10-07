# <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchmakingStatsResponse"></a> Class CMsgDOTAMatchmakingStatsResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAMatchmakingStatsResponse : IMessage<CMsgDOTAMatchmakingStatsResponse>, IEquatable<CMsgDOTAMatchmakingStatsResponse>, IDeepCloneable<CMsgDOTAMatchmakingStatsResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAMatchmakingStatsResponse](Divine.Protobufs.Dota2.CMsgDOTAMatchmakingStatsResponse.md)

#### Implements

IMessage<CMsgDOTAMatchmakingStatsResponse\>, 
[IEquatable<CMsgDOTAMatchmakingStatsResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAMatchmakingStatsResponse\>, 
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
[EnumerableExtensions.In<CMsgDOTAMatchmakingStatsResponse\>\(CMsgDOTAMatchmakingStatsResponse, params CMsgDOTAMatchmakingStatsResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchmakingStatsResponse__ctor"></a> CMsgDOTAMatchmakingStatsResponse\(\)

```csharp
public CMsgDOTAMatchmakingStatsResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchmakingStatsResponse__ctor_Divine_Protobufs_Dota2_CMsgDOTAMatchmakingStatsResponse_"></a> CMsgDOTAMatchmakingStatsResponse\(CMsgDOTAMatchmakingStatsResponse\)

```csharp
public CMsgDOTAMatchmakingStatsResponse(CMsgDOTAMatchmakingStatsResponse other)
```

#### Parameters

`other` [CMsgDOTAMatchmakingStatsResponse](Divine.Protobufs.Dota2.CMsgDOTAMatchmakingStatsResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchmakingStatsResponse_LegacySearchingPlayersByGroupSource2FieldNumber"></a> LegacySearchingPlayersByGroupSource2FieldNumber

```csharp
public const int LegacySearchingPlayersByGroupSource2FieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchmakingStatsResponse_MatchGroupsFieldNumber"></a> MatchGroupsFieldNumber

```csharp
public const int MatchGroupsFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchmakingStatsResponse_MatchgroupsVersionFieldNumber"></a> MatchgroupsVersionFieldNumber

```csharp
public const int MatchgroupsVersionFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchmakingStatsResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchmakingStatsResponse_HasMatchgroupsVersion"></a> HasMatchgroupsVersion

```csharp
public bool HasMatchgroupsVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchmakingStatsResponse_LegacySearchingPlayersByGroupSource2"></a> LegacySearchingPlayersByGroupSource2

```csharp
public RepeatedField<uint> LegacySearchingPlayersByGroupSource2 { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchmakingStatsResponse_MatchGroups"></a> MatchGroups

```csharp
public RepeatedField<CMsgMatchmakingMatchGroupInfo> MatchGroups { get; }
```

#### Property Value

 RepeatedField<[CMsgMatchmakingMatchGroupInfo](Divine.Protobufs.Dota2.CMsgMatchmakingMatchGroupInfo.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchmakingStatsResponse_MatchgroupsVersion"></a> MatchgroupsVersion

```csharp
public uint MatchgroupsVersion { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchmakingStatsResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAMatchmakingStatsResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAMatchmakingStatsResponse](Divine.Protobufs.Dota2.CMsgDOTAMatchmakingStatsResponse.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchmakingStatsResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchmakingStatsResponse_ClearMatchgroupsVersion"></a> ClearMatchgroupsVersion\(\)

```csharp
public void ClearMatchgroupsVersion()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchmakingStatsResponse_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAMatchmakingStatsResponse Clone()
```

#### Returns

 [CMsgDOTAMatchmakingStatsResponse](Divine.Protobufs.Dota2.CMsgDOTAMatchmakingStatsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchmakingStatsResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchmakingStatsResponse_Equals_Divine_Protobufs_Dota2_CMsgDOTAMatchmakingStatsResponse_"></a> Equals\(CMsgDOTAMatchmakingStatsResponse\)

```csharp
public bool Equals(CMsgDOTAMatchmakingStatsResponse other)
```

#### Parameters

`other` [CMsgDOTAMatchmakingStatsResponse](Divine.Protobufs.Dota2.CMsgDOTAMatchmakingStatsResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchmakingStatsResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchmakingStatsResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAMatchmakingStatsResponse_"></a> MergeFrom\(CMsgDOTAMatchmakingStatsResponse\)

```csharp
public void MergeFrom(CMsgDOTAMatchmakingStatsResponse other)
```

#### Parameters

`other` [CMsgDOTAMatchmakingStatsResponse](Divine.Protobufs.Dota2.CMsgDOTAMatchmakingStatsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchmakingStatsResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchmakingStatsResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchmakingStatsResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

