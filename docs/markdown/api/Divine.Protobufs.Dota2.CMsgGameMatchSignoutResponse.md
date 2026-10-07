# <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignoutResponse"></a> Class CMsgGameMatchSignoutResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGameMatchSignoutResponse : IMessage<CMsgGameMatchSignoutResponse>, IEquatable<CMsgGameMatchSignoutResponse>, IDeepCloneable<CMsgGameMatchSignoutResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGameMatchSignoutResponse](Divine.Protobufs.Dota2.CMsgGameMatchSignoutResponse.md)

#### Implements

IMessage<CMsgGameMatchSignoutResponse\>, 
[IEquatable<CMsgGameMatchSignoutResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGameMatchSignoutResponse\>, 
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
[EnumerableExtensions.In<CMsgGameMatchSignoutResponse\>\(CMsgGameMatchSignoutResponse, params CMsgGameMatchSignoutResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignoutResponse__ctor"></a> CMsgGameMatchSignoutResponse\(\)

```csharp
public CMsgGameMatchSignoutResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignoutResponse__ctor_Divine_Protobufs_Dota2_CMsgGameMatchSignoutResponse_"></a> CMsgGameMatchSignoutResponse\(CMsgGameMatchSignoutResponse\)

```csharp
public CMsgGameMatchSignoutResponse(CMsgGameMatchSignoutResponse other)
```

#### Parameters

`other` [CMsgGameMatchSignoutResponse](Divine.Protobufs.Dota2.CMsgGameMatchSignoutResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignoutResponse_LeagueidFieldNumber"></a> LeagueidFieldNumber

```csharp
public const int LeagueidFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignoutResponse_MatchDetailsFieldNumber"></a> MatchDetailsFieldNumber

```csharp
public const int MatchDetailsFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignoutResponse_MatchIdFieldNumber"></a> MatchIdFieldNumber

```csharp
public const int MatchIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignoutResponse_MetadataPrivateKeyFieldNumber"></a> MetadataPrivateKeyFieldNumber

```csharp
public const int MetadataPrivateKeyFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignoutResponse_MonsterHunterRewardsFieldNumber"></a> MonsterHunterRewardsFieldNumber

```csharp
public const int MonsterHunterRewardsFieldNumber = 15
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignoutResponse_MvpDataFieldNumber"></a> MvpDataFieldNumber

```csharp
public const int MvpDataFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignoutResponse_OverworldRewardsFieldNumber"></a> OverworldRewardsFieldNumber

```csharp
public const int OverworldRewardsFieldNumber = 14
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignoutResponse_OwPrivateKeyFieldNumber"></a> OwPrivateKeyFieldNumber

```csharp
public const int OwPrivateKeyFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignoutResponse_OwReplayIdFieldNumber"></a> OwReplayIdFieldNumber

```csharp
public const int OwReplayIdFieldNumber = 13
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignoutResponse_OwSaltFieldNumber"></a> OwSaltFieldNumber

```csharp
public const int OwSaltFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignoutResponse_PlayersMetadataFieldNumber"></a> PlayersMetadataFieldNumber

```csharp
public const int PlayersMetadataFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignoutResponse_ReplaySaltFieldNumber"></a> ReplaySaltFieldNumber

```csharp
public const int ReplaySaltFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignoutResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignoutResponse_HasLeagueid"></a> HasLeagueid

```csharp
public bool HasLeagueid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignoutResponse_HasMatchId"></a> HasMatchId

```csharp
public bool HasMatchId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignoutResponse_HasMetadataPrivateKey"></a> HasMetadataPrivateKey

```csharp
public bool HasMetadataPrivateKey { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignoutResponse_HasOwPrivateKey"></a> HasOwPrivateKey

```csharp
public bool HasOwPrivateKey { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignoutResponse_HasOwReplayId"></a> HasOwReplayId

```csharp
public bool HasOwReplayId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignoutResponse_HasOwSalt"></a> HasOwSalt

```csharp
public bool HasOwSalt { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignoutResponse_HasReplaySalt"></a> HasReplaySalt

```csharp
public bool HasReplaySalt { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignoutResponse_Leagueid"></a> Leagueid

```csharp
public uint Leagueid { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignoutResponse_MatchDetails"></a> MatchDetails

```csharp
public CMsgDOTAMatch MatchDetails { get; set; }
```

#### Property Value

 [CMsgDOTAMatch](Divine.Protobufs.Dota2.CMsgDOTAMatch.md)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignoutResponse_MatchId"></a> MatchId

```csharp
public ulong MatchId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignoutResponse_MetadataPrivateKey"></a> MetadataPrivateKey

```csharp
public uint MetadataPrivateKey { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignoutResponse_MonsterHunterRewards"></a> MonsterHunterRewards

```csharp
public CMsgMonsterHunterMatchRewards MonsterHunterRewards { get; set; }
```

#### Property Value

 [CMsgMonsterHunterMatchRewards](Divine.Protobufs.Dota2.CMsgMonsterHunterMatchRewards.md)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignoutResponse_MvpData"></a> MvpData

```csharp
public CMvpData MvpData { get; set; }
```

#### Property Value

 [CMvpData](Divine.Protobufs.Dota2.CMvpData.md)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignoutResponse_OverworldRewards"></a> OverworldRewards

```csharp
public CMsgOverworldMatchRewards OverworldRewards { get; set; }
```

#### Property Value

 [CMsgOverworldMatchRewards](Divine.Protobufs.Dota2.CMsgOverworldMatchRewards.md)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignoutResponse_OwPrivateKey"></a> OwPrivateKey

```csharp
public ulong OwPrivateKey { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignoutResponse_OwReplayId"></a> OwReplayId

```csharp
public ulong OwReplayId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignoutResponse_OwSalt"></a> OwSalt

```csharp
public uint OwSalt { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignoutResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGameMatchSignoutResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGameMatchSignoutResponse](Divine.Protobufs.Dota2.CMsgGameMatchSignoutResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignoutResponse_PlayersMetadata"></a> PlayersMetadata

```csharp
public RepeatedField<CMsgGameMatchSignoutResponse.Types.PlayerMetadata> PlayersMetadata { get; }
```

#### Property Value

 RepeatedField<[CMsgGameMatchSignoutResponse](Divine.Protobufs.Dota2.CMsgGameMatchSignoutResponse.md).[Types](Divine.Protobufs.Dota2.CMsgGameMatchSignoutResponse.Types.md).[PlayerMetadata](Divine.Protobufs.Dota2.CMsgGameMatchSignoutResponse.Types.PlayerMetadata.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignoutResponse_ReplaySalt"></a> ReplaySalt

```csharp
public uint ReplaySalt { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignoutResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignoutResponse_ClearLeagueid"></a> ClearLeagueid\(\)

```csharp
public void ClearLeagueid()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignoutResponse_ClearMatchId"></a> ClearMatchId\(\)

```csharp
public void ClearMatchId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignoutResponse_ClearMetadataPrivateKey"></a> ClearMetadataPrivateKey\(\)

```csharp
public void ClearMetadataPrivateKey()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignoutResponse_ClearOwPrivateKey"></a> ClearOwPrivateKey\(\)

```csharp
public void ClearOwPrivateKey()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignoutResponse_ClearOwReplayId"></a> ClearOwReplayId\(\)

```csharp
public void ClearOwReplayId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignoutResponse_ClearOwSalt"></a> ClearOwSalt\(\)

```csharp
public void ClearOwSalt()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignoutResponse_ClearReplaySalt"></a> ClearReplaySalt\(\)

```csharp
public void ClearReplaySalt()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignoutResponse_Clone"></a> Clone\(\)

```csharp
public CMsgGameMatchSignoutResponse Clone()
```

#### Returns

 [CMsgGameMatchSignoutResponse](Divine.Protobufs.Dota2.CMsgGameMatchSignoutResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignoutResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignoutResponse_Equals_Divine_Protobufs_Dota2_CMsgGameMatchSignoutResponse_"></a> Equals\(CMsgGameMatchSignoutResponse\)

```csharp
public bool Equals(CMsgGameMatchSignoutResponse other)
```

#### Parameters

`other` [CMsgGameMatchSignoutResponse](Divine.Protobufs.Dota2.CMsgGameMatchSignoutResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignoutResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignoutResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgGameMatchSignoutResponse_"></a> MergeFrom\(CMsgGameMatchSignoutResponse\)

```csharp
public void MergeFrom(CMsgGameMatchSignoutResponse other)
```

#### Parameters

`other` [CMsgGameMatchSignoutResponse](Divine.Protobufs.Dota2.CMsgGameMatchSignoutResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignoutResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignoutResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignoutResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

