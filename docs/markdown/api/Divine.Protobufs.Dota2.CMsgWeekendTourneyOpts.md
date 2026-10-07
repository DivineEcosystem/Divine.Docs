# <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneyOpts"></a> Class CMsgWeekendTourneyOpts

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgWeekendTourneyOpts : IMessage<CMsgWeekendTourneyOpts>, IEquatable<CMsgWeekendTourneyOpts>, IDeepCloneable<CMsgWeekendTourneyOpts>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgWeekendTourneyOpts](Divine.Protobufs.Dota2.CMsgWeekendTourneyOpts.md)

#### Implements

IMessage<CMsgWeekendTourneyOpts\>, 
[IEquatable<CMsgWeekendTourneyOpts\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgWeekendTourneyOpts\>, 
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
[EnumerableExtensions.In<CMsgWeekendTourneyOpts\>\(CMsgWeekendTourneyOpts, params CMsgWeekendTourneyOpts\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneyOpts__ctor"></a> CMsgWeekendTourneyOpts\(\)

```csharp
public CMsgWeekendTourneyOpts()
```

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneyOpts__ctor_Divine_Protobufs_Dota2_CMsgWeekendTourneyOpts_"></a> CMsgWeekendTourneyOpts\(CMsgWeekendTourneyOpts\)

```csharp
public CMsgWeekendTourneyOpts(CMsgWeekendTourneyOpts other)
```

#### Parameters

`other` [CMsgWeekendTourneyOpts](Divine.Protobufs.Dota2.CMsgWeekendTourneyOpts.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneyOpts_BuyinFieldNumber"></a> BuyinFieldNumber

```csharp
public const int BuyinFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneyOpts_DivisionIdFieldNumber"></a> DivisionIdFieldNumber

```csharp
public const int DivisionIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneyOpts_MatchGroupsFieldNumber"></a> MatchGroupsFieldNumber

```csharp
public const int MatchGroupsFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneyOpts_ParticipatingFieldNumber"></a> ParticipatingFieldNumber

```csharp
public const int ParticipatingFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneyOpts_PickupTeamLogoFieldNumber"></a> PickupTeamLogoFieldNumber

```csharp
public const int PickupTeamLogoFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneyOpts_PickupTeamNameFieldNumber"></a> PickupTeamNameFieldNumber

```csharp
public const int PickupTeamNameFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneyOpts_SkillLevelFieldNumber"></a> SkillLevelFieldNumber

```csharp
public const int SkillLevelFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneyOpts_TeamIdFieldNumber"></a> TeamIdFieldNumber

```csharp
public const int TeamIdFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneyOpts_Buyin"></a> Buyin

```csharp
public uint Buyin { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneyOpts_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneyOpts_DivisionId"></a> DivisionId

```csharp
public uint DivisionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneyOpts_HasBuyin"></a> HasBuyin

```csharp
public bool HasBuyin { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneyOpts_HasDivisionId"></a> HasDivisionId

```csharp
public bool HasDivisionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneyOpts_HasMatchGroups"></a> HasMatchGroups

```csharp
public bool HasMatchGroups { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneyOpts_HasParticipating"></a> HasParticipating

```csharp
public bool HasParticipating { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneyOpts_HasPickupTeamLogo"></a> HasPickupTeamLogo

```csharp
public bool HasPickupTeamLogo { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneyOpts_HasPickupTeamName"></a> HasPickupTeamName

```csharp
public bool HasPickupTeamName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneyOpts_HasSkillLevel"></a> HasSkillLevel

```csharp
public bool HasSkillLevel { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneyOpts_HasTeamId"></a> HasTeamId

```csharp
public bool HasTeamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneyOpts_MatchGroups"></a> MatchGroups

```csharp
public uint MatchGroups { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneyOpts_Parser"></a> Parser

```csharp
public static MessageParser<CMsgWeekendTourneyOpts> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgWeekendTourneyOpts](Divine.Protobufs.Dota2.CMsgWeekendTourneyOpts.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneyOpts_Participating"></a> Participating

```csharp
public bool Participating { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneyOpts_PickupTeamLogo"></a> PickupTeamLogo

```csharp
public ulong PickupTeamLogo { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneyOpts_PickupTeamName"></a> PickupTeamName

```csharp
public string PickupTeamName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneyOpts_SkillLevel"></a> SkillLevel

```csharp
public uint SkillLevel { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneyOpts_TeamId"></a> TeamId

```csharp
public uint TeamId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneyOpts_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneyOpts_ClearBuyin"></a> ClearBuyin\(\)

```csharp
public void ClearBuyin()
```

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneyOpts_ClearDivisionId"></a> ClearDivisionId\(\)

```csharp
public void ClearDivisionId()
```

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneyOpts_ClearMatchGroups"></a> ClearMatchGroups\(\)

```csharp
public void ClearMatchGroups()
```

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneyOpts_ClearParticipating"></a> ClearParticipating\(\)

```csharp
public void ClearParticipating()
```

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneyOpts_ClearPickupTeamLogo"></a> ClearPickupTeamLogo\(\)

```csharp
public void ClearPickupTeamLogo()
```

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneyOpts_ClearPickupTeamName"></a> ClearPickupTeamName\(\)

```csharp
public void ClearPickupTeamName()
```

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneyOpts_ClearSkillLevel"></a> ClearSkillLevel\(\)

```csharp
public void ClearSkillLevel()
```

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneyOpts_ClearTeamId"></a> ClearTeamId\(\)

```csharp
public void ClearTeamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneyOpts_Clone"></a> Clone\(\)

```csharp
public CMsgWeekendTourneyOpts Clone()
```

#### Returns

 [CMsgWeekendTourneyOpts](Divine.Protobufs.Dota2.CMsgWeekendTourneyOpts.md)

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneyOpts_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneyOpts_Equals_Divine_Protobufs_Dota2_CMsgWeekendTourneyOpts_"></a> Equals\(CMsgWeekendTourneyOpts\)

```csharp
public bool Equals(CMsgWeekendTourneyOpts other)
```

#### Parameters

`other` [CMsgWeekendTourneyOpts](Divine.Protobufs.Dota2.CMsgWeekendTourneyOpts.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneyOpts_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneyOpts_MergeFrom_Divine_Protobufs_Dota2_CMsgWeekendTourneyOpts_"></a> MergeFrom\(CMsgWeekendTourneyOpts\)

```csharp
public void MergeFrom(CMsgWeekendTourneyOpts other)
```

#### Parameters

`other` [CMsgWeekendTourneyOpts](Divine.Protobufs.Dota2.CMsgWeekendTourneyOpts.md)

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneyOpts_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneyOpts_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneyOpts_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

