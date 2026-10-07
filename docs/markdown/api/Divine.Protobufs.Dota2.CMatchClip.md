# <a id="Divine_Protobufs_Dota2_CMatchClip"></a> Class CMatchClip

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMatchClip : IMessage<CMatchClip>, IEquatable<CMatchClip>, IDeepCloneable<CMatchClip>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMatchClip](Divine.Protobufs.Dota2.CMatchClip.md)

#### Implements

IMessage<CMatchClip\>, 
[IEquatable<CMatchClip\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMatchClip\>, 
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
[EnumerableExtensions.In<CMatchClip\>\(CMatchClip, params CMatchClip\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMatchClip__ctor"></a> CMatchClip\(\)

```csharp
public CMatchClip()
```

### <a id="Divine_Protobufs_Dota2_CMatchClip__ctor_Divine_Protobufs_Dota2_CMatchClip_"></a> CMatchClip\(CMatchClip\)

```csharp
public CMatchClip(CMatchClip other)
```

#### Parameters

`other` [CMatchClip](Divine.Protobufs.Dota2.CMatchClip.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMatchClip_AbilityIdFieldNumber"></a> AbilityIdFieldNumber

```csharp
public const int AbilityIdFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMatchClip_CameraModeFieldNumber"></a> CameraModeFieldNumber

```csharp
public const int CameraModeFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMatchClip_CommentFieldNumber"></a> CommentFieldNumber

```csharp
public const int CommentFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMatchClip_DurationSecondsFieldNumber"></a> DurationSecondsFieldNumber

```csharp
public const int DurationSecondsFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMatchClip_GameTimeSecondsFieldNumber"></a> GameTimeSecondsFieldNumber

```csharp
public const int GameTimeSecondsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMatchClip_HeroIdFieldNumber"></a> HeroIdFieldNumber

```csharp
public const int HeroIdFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMatchClip_MatchIdFieldNumber"></a> MatchIdFieldNumber

```csharp
public const int MatchIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMatchClip_PlayerAccountIdFieldNumber"></a> PlayerAccountIdFieldNumber

```csharp
public const int PlayerAccountIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMatchClip_PlayerIdFieldNumber"></a> PlayerIdFieldNumber

```csharp
public const int PlayerIdFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMatchClip_AbilityId"></a> AbilityId

```csharp
public int AbilityId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMatchClip_CameraMode"></a> CameraMode

```csharp
public uint CameraMode { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMatchClip_Comment"></a> Comment

```csharp
public string Comment { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMatchClip_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMatchClip_DurationSeconds"></a> DurationSeconds

```csharp
public uint DurationSeconds { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMatchClip_GameTimeSeconds"></a> GameTimeSeconds

```csharp
public uint GameTimeSeconds { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMatchClip_HasAbilityId"></a> HasAbilityId

```csharp
public bool HasAbilityId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMatchClip_HasCameraMode"></a> HasCameraMode

```csharp
public bool HasCameraMode { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMatchClip_HasComment"></a> HasComment

```csharp
public bool HasComment { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMatchClip_HasDurationSeconds"></a> HasDurationSeconds

```csharp
public bool HasDurationSeconds { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMatchClip_HasGameTimeSeconds"></a> HasGameTimeSeconds

```csharp
public bool HasGameTimeSeconds { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMatchClip_HasHeroId"></a> HasHeroId

```csharp
public bool HasHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMatchClip_HasMatchId"></a> HasMatchId

```csharp
public bool HasMatchId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMatchClip_HasPlayerAccountId"></a> HasPlayerAccountId

```csharp
public bool HasPlayerAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMatchClip_HasPlayerId"></a> HasPlayerId

```csharp
public bool HasPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMatchClip_HeroId"></a> HeroId

```csharp
public int HeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMatchClip_MatchId"></a> MatchId

```csharp
public ulong MatchId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMatchClip_Parser"></a> Parser

```csharp
public static MessageParser<CMatchClip> Parser { get; }
```

#### Property Value

 MessageParser<[CMatchClip](Divine.Protobufs.Dota2.CMatchClip.md)\>

### <a id="Divine_Protobufs_Dota2_CMatchClip_PlayerAccountId"></a> PlayerAccountId

```csharp
public uint PlayerAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMatchClip_PlayerId"></a> PlayerId

```csharp
public uint PlayerId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMatchClip_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMatchClip_ClearAbilityId"></a> ClearAbilityId\(\)

```csharp
public void ClearAbilityId()
```

### <a id="Divine_Protobufs_Dota2_CMatchClip_ClearCameraMode"></a> ClearCameraMode\(\)

```csharp
public void ClearCameraMode()
```

### <a id="Divine_Protobufs_Dota2_CMatchClip_ClearComment"></a> ClearComment\(\)

```csharp
public void ClearComment()
```

### <a id="Divine_Protobufs_Dota2_CMatchClip_ClearDurationSeconds"></a> ClearDurationSeconds\(\)

```csharp
public void ClearDurationSeconds()
```

### <a id="Divine_Protobufs_Dota2_CMatchClip_ClearGameTimeSeconds"></a> ClearGameTimeSeconds\(\)

```csharp
public void ClearGameTimeSeconds()
```

### <a id="Divine_Protobufs_Dota2_CMatchClip_ClearHeroId"></a> ClearHeroId\(\)

```csharp
public void ClearHeroId()
```

### <a id="Divine_Protobufs_Dota2_CMatchClip_ClearMatchId"></a> ClearMatchId\(\)

```csharp
public void ClearMatchId()
```

### <a id="Divine_Protobufs_Dota2_CMatchClip_ClearPlayerAccountId"></a> ClearPlayerAccountId\(\)

```csharp
public void ClearPlayerAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMatchClip_ClearPlayerId"></a> ClearPlayerId\(\)

```csharp
public void ClearPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CMatchClip_Clone"></a> Clone\(\)

```csharp
public CMatchClip Clone()
```

#### Returns

 [CMatchClip](Divine.Protobufs.Dota2.CMatchClip.md)

### <a id="Divine_Protobufs_Dota2_CMatchClip_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMatchClip_Equals_Divine_Protobufs_Dota2_CMatchClip_"></a> Equals\(CMatchClip\)

```csharp
public bool Equals(CMatchClip other)
```

#### Parameters

`other` [CMatchClip](Divine.Protobufs.Dota2.CMatchClip.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMatchClip_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMatchClip_MergeFrom_Divine_Protobufs_Dota2_CMatchClip_"></a> MergeFrom\(CMatchClip\)

```csharp
public void MergeFrom(CMatchClip other)
```

#### Parameters

`other` [CMatchClip](Divine.Protobufs.Dota2.CMatchClip.md)

### <a id="Divine_Protobufs_Dota2_CMatchClip_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMatchClip_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMatchClip_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

