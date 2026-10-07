# <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSessionStatus"></a> Class CMsgPrivateCoachingSessionStatus

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgPrivateCoachingSessionStatus : IMessage<CMsgPrivateCoachingSessionStatus>, IEquatable<CMsgPrivateCoachingSessionStatus>, IDeepCloneable<CMsgPrivateCoachingSessionStatus>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgPrivateCoachingSessionStatus](Divine.Protobufs.Dota2.CMsgPrivateCoachingSessionStatus.md)

#### Implements

IMessage<CMsgPrivateCoachingSessionStatus\>, 
[IEquatable<CMsgPrivateCoachingSessionStatus\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgPrivateCoachingSessionStatus\>, 
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
[EnumerableExtensions.In<CMsgPrivateCoachingSessionStatus\>\(CMsgPrivateCoachingSessionStatus, params CMsgPrivateCoachingSessionStatus\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSessionStatus__ctor"></a> CMsgPrivateCoachingSessionStatus\(\)

```csharp
public CMsgPrivateCoachingSessionStatus()
```

### <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSessionStatus__ctor_Divine_Protobufs_Dota2_CMsgPrivateCoachingSessionStatus_"></a> CMsgPrivateCoachingSessionStatus\(CMsgPrivateCoachingSessionStatus\)

```csharp
public CMsgPrivateCoachingSessionStatus(CMsgPrivateCoachingSessionStatus other)
```

#### Parameters

`other` [CMsgPrivateCoachingSessionStatus](Divine.Protobufs.Dota2.CMsgPrivateCoachingSessionStatus.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSessionStatus_RequesterCompetitiveRankTierFieldNumber"></a> RequesterCompetitiveRankTierFieldNumber

```csharp
public const int RequesterCompetitiveRankTierFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSessionStatus_RequesterGamesPlayedFieldNumber"></a> RequesterGamesPlayedFieldNumber

```csharp
public const int RequesterGamesPlayedFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSessionStatus_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSessionStatus_HasRequesterCompetitiveRankTier"></a> HasRequesterCompetitiveRankTier

```csharp
public bool HasRequesterCompetitiveRankTier { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSessionStatus_HasRequesterGamesPlayed"></a> HasRequesterGamesPlayed

```csharp
public bool HasRequesterGamesPlayed { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSessionStatus_Parser"></a> Parser

```csharp
public static MessageParser<CMsgPrivateCoachingSessionStatus> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgPrivateCoachingSessionStatus](Divine.Protobufs.Dota2.CMsgPrivateCoachingSessionStatus.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSessionStatus_RequesterCompetitiveRankTier"></a> RequesterCompetitiveRankTier

```csharp
public uint RequesterCompetitiveRankTier { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSessionStatus_RequesterGamesPlayed"></a> RequesterGamesPlayed

```csharp
public uint RequesterGamesPlayed { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSessionStatus_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSessionStatus_ClearRequesterCompetitiveRankTier"></a> ClearRequesterCompetitiveRankTier\(\)

```csharp
public void ClearRequesterCompetitiveRankTier()
```

### <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSessionStatus_ClearRequesterGamesPlayed"></a> ClearRequesterGamesPlayed\(\)

```csharp
public void ClearRequesterGamesPlayed()
```

### <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSessionStatus_Clone"></a> Clone\(\)

```csharp
public CMsgPrivateCoachingSessionStatus Clone()
```

#### Returns

 [CMsgPrivateCoachingSessionStatus](Divine.Protobufs.Dota2.CMsgPrivateCoachingSessionStatus.md)

### <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSessionStatus_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSessionStatus_Equals_Divine_Protobufs_Dota2_CMsgPrivateCoachingSessionStatus_"></a> Equals\(CMsgPrivateCoachingSessionStatus\)

```csharp
public bool Equals(CMsgPrivateCoachingSessionStatus other)
```

#### Parameters

`other` [CMsgPrivateCoachingSessionStatus](Divine.Protobufs.Dota2.CMsgPrivateCoachingSessionStatus.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSessionStatus_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSessionStatus_MergeFrom_Divine_Protobufs_Dota2_CMsgPrivateCoachingSessionStatus_"></a> MergeFrom\(CMsgPrivateCoachingSessionStatus\)

```csharp
public void MergeFrom(CMsgPrivateCoachingSessionStatus other)
```

#### Parameters

`other` [CMsgPrivateCoachingSessionStatus](Divine.Protobufs.Dota2.CMsgPrivateCoachingSessionStatus.md)

### <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSessionStatus_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSessionStatus_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSessionStatus_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

