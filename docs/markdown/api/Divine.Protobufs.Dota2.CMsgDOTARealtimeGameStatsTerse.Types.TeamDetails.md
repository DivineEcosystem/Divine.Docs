# <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_TeamDetails"></a> Class CMsgDOTARealtimeGameStatsTerse.Types.TeamDetails

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTARealtimeGameStatsTerse.Types.TeamDetails : IMessage<CMsgDOTARealtimeGameStatsTerse.Types.TeamDetails>, IEquatable<CMsgDOTARealtimeGameStatsTerse.Types.TeamDetails>, IDeepCloneable<CMsgDOTARealtimeGameStatsTerse.Types.TeamDetails>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTARealtimeGameStatsTerse.Types.TeamDetails](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.Types.TeamDetails.md)

#### Implements

IMessage<CMsgDOTARealtimeGameStatsTerse.Types.TeamDetails\>, 
[IEquatable<CMsgDOTARealtimeGameStatsTerse.Types.TeamDetails\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTARealtimeGameStatsTerse.Types.TeamDetails\>, 
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
[EnumerableExtensions.In<CMsgDOTARealtimeGameStatsTerse.Types.TeamDetails\>\(CMsgDOTARealtimeGameStatsTerse.Types.TeamDetails, params CMsgDOTARealtimeGameStatsTerse.Types.TeamDetails\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_TeamDetails__ctor"></a> TeamDetails\(\)

```csharp
public TeamDetails()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_TeamDetails__ctor_Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_TeamDetails_"></a> TeamDetails\(TeamDetails\)

```csharp
public TeamDetails(CMsgDOTARealtimeGameStatsTerse.Types.TeamDetails other)
```

#### Parameters

`other` [CMsgDOTARealtimeGameStatsTerse](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.Types.md).[TeamDetails](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.Types.TeamDetails.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_TeamDetails_NetWorthFieldNumber"></a> NetWorthFieldNumber

```csharp
public const int NetWorthFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_TeamDetails_PlayersFieldNumber"></a> PlayersFieldNumber

```csharp
public const int PlayersFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_TeamDetails_ScoreFieldNumber"></a> ScoreFieldNumber

```csharp
public const int ScoreFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_TeamDetails_TeamIdFieldNumber"></a> TeamIdFieldNumber

```csharp
public const int TeamIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_TeamDetails_TeamLogoFieldNumber"></a> TeamLogoFieldNumber

```csharp
public const int TeamLogoFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_TeamDetails_TeamLogoUrlFieldNumber"></a> TeamLogoUrlFieldNumber

```csharp
public const int TeamLogoUrlFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_TeamDetails_TeamNameFieldNumber"></a> TeamNameFieldNumber

```csharp
public const int TeamNameFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_TeamDetails_TeamNumberFieldNumber"></a> TeamNumberFieldNumber

```csharp
public const int TeamNumberFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_TeamDetails_TeamTagFieldNumber"></a> TeamTagFieldNumber

```csharp
public const int TeamTagFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_TeamDetails_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_TeamDetails_HasNetWorth"></a> HasNetWorth

```csharp
public bool HasNetWorth { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_TeamDetails_HasScore"></a> HasScore

```csharp
public bool HasScore { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_TeamDetails_HasTeamId"></a> HasTeamId

```csharp
public bool HasTeamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_TeamDetails_HasTeamLogo"></a> HasTeamLogo

```csharp
public bool HasTeamLogo { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_TeamDetails_HasTeamLogoUrl"></a> HasTeamLogoUrl

```csharp
public bool HasTeamLogoUrl { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_TeamDetails_HasTeamName"></a> HasTeamName

```csharp
public bool HasTeamName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_TeamDetails_HasTeamNumber"></a> HasTeamNumber

```csharp
public bool HasTeamNumber { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_TeamDetails_HasTeamTag"></a> HasTeamTag

```csharp
public bool HasTeamTag { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_TeamDetails_NetWorth"></a> NetWorth

```csharp
public uint NetWorth { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_TeamDetails_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTARealtimeGameStatsTerse.Types.TeamDetails> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTARealtimeGameStatsTerse](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.Types.md).[TeamDetails](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.Types.TeamDetails.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_TeamDetails_Players"></a> Players

```csharp
public RepeatedField<CMsgDOTARealtimeGameStatsTerse.Types.PlayerDetails> Players { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTARealtimeGameStatsTerse](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.Types.md).[PlayerDetails](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.Types.PlayerDetails.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_TeamDetails_Score"></a> Score

```csharp
public uint Score { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_TeamDetails_TeamId"></a> TeamId

```csharp
public uint TeamId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_TeamDetails_TeamLogo"></a> TeamLogo

```csharp
public ulong TeamLogo { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_TeamDetails_TeamLogoUrl"></a> TeamLogoUrl

```csharp
public string TeamLogoUrl { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_TeamDetails_TeamName"></a> TeamName

```csharp
public string TeamName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_TeamDetails_TeamNumber"></a> TeamNumber

```csharp
public uint TeamNumber { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_TeamDetails_TeamTag"></a> TeamTag

```csharp
public string TeamTag { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_TeamDetails_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_TeamDetails_ClearNetWorth"></a> ClearNetWorth\(\)

```csharp
public void ClearNetWorth()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_TeamDetails_ClearScore"></a> ClearScore\(\)

```csharp
public void ClearScore()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_TeamDetails_ClearTeamId"></a> ClearTeamId\(\)

```csharp
public void ClearTeamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_TeamDetails_ClearTeamLogo"></a> ClearTeamLogo\(\)

```csharp
public void ClearTeamLogo()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_TeamDetails_ClearTeamLogoUrl"></a> ClearTeamLogoUrl\(\)

```csharp
public void ClearTeamLogoUrl()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_TeamDetails_ClearTeamName"></a> ClearTeamName\(\)

```csharp
public void ClearTeamName()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_TeamDetails_ClearTeamNumber"></a> ClearTeamNumber\(\)

```csharp
public void ClearTeamNumber()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_TeamDetails_ClearTeamTag"></a> ClearTeamTag\(\)

```csharp
public void ClearTeamTag()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_TeamDetails_Clone"></a> Clone\(\)

```csharp
public CMsgDOTARealtimeGameStatsTerse.Types.TeamDetails Clone()
```

#### Returns

 [CMsgDOTARealtimeGameStatsTerse](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.Types.md).[TeamDetails](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.Types.TeamDetails.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_TeamDetails_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_TeamDetails_Equals_Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_TeamDetails_"></a> Equals\(TeamDetails\)

```csharp
public bool Equals(CMsgDOTARealtimeGameStatsTerse.Types.TeamDetails other)
```

#### Parameters

`other` [CMsgDOTARealtimeGameStatsTerse](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.Types.md).[TeamDetails](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.Types.TeamDetails.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_TeamDetails_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_TeamDetails_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_TeamDetails_"></a> MergeFrom\(TeamDetails\)

```csharp
public void MergeFrom(CMsgDOTARealtimeGameStatsTerse.Types.TeamDetails other)
```

#### Parameters

`other` [CMsgDOTARealtimeGameStatsTerse](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.Types.md).[TeamDetails](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.Types.TeamDetails.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_TeamDetails_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_TeamDetails_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_TeamDetails_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

