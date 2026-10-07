# <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_Types_CTeam"></a> Class CMsgSignOutGameplayStats.Types.CTeam

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSignOutGameplayStats.Types.CTeam : IMessage<CMsgSignOutGameplayStats.Types.CTeam>, IEquatable<CMsgSignOutGameplayStats.Types.CTeam>, IDeepCloneable<CMsgSignOutGameplayStats.Types.CTeam>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSignOutGameplayStats.Types.CTeam](Divine.Protobufs.Dota2.CMsgSignOutGameplayStats.Types.CTeam.md)

#### Implements

IMessage<CMsgSignOutGameplayStats.Types.CTeam\>, 
[IEquatable<CMsgSignOutGameplayStats.Types.CTeam\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSignOutGameplayStats.Types.CTeam\>, 
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
[EnumerableExtensions.In<CMsgSignOutGameplayStats.Types.CTeam\>\(CMsgSignOutGameplayStats.Types.CTeam, params CMsgSignOutGameplayStats.Types.CTeam\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_Types_CTeam__ctor"></a> CTeam\(\)

```csharp
public CTeam()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_Types_CTeam__ctor_Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_Types_CTeam_"></a> CTeam\(CTeam\)

```csharp
public CTeam(CMsgSignOutGameplayStats.Types.CTeam other)
```

#### Parameters

`other` [CMsgSignOutGameplayStats](Divine.Protobufs.Dota2.CMsgSignOutGameplayStats.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutGameplayStats.Types.md).[CTeam](Divine.Protobufs.Dota2.CMsgSignOutGameplayStats.Types.CTeam.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_Types_CTeam_IsRadiantTeamFieldNumber"></a> IsRadiantTeamFieldNumber

```csharp
public const int IsRadiantTeamFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_Types_CTeam_IsWinningTeamFieldNumber"></a> IsWinningTeamFieldNumber

```csharp
public const int IsWinningTeamFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_Types_CTeam_PlayersFieldNumber"></a> PlayersFieldNumber

```csharp
public const int PlayersFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_Types_CTeam_TimedTeamStatsFieldNumber"></a> TimedTeamStatsFieldNumber

```csharp
public const int TimedTeamStatsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_Types_CTeam_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_Types_CTeam_HasIsRadiantTeam"></a> HasIsRadiantTeam

```csharp
public bool HasIsRadiantTeam { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_Types_CTeam_HasIsWinningTeam"></a> HasIsWinningTeam

```csharp
public bool HasIsWinningTeam { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_Types_CTeam_IsRadiantTeam"></a> IsRadiantTeam

```csharp
public bool IsRadiantTeam { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_Types_CTeam_IsWinningTeam"></a> IsWinningTeam

```csharp
public bool IsWinningTeam { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_Types_CTeam_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSignOutGameplayStats.Types.CTeam> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSignOutGameplayStats](Divine.Protobufs.Dota2.CMsgSignOutGameplayStats.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutGameplayStats.Types.md).[CTeam](Divine.Protobufs.Dota2.CMsgSignOutGameplayStats.Types.CTeam.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_Types_CTeam_Players"></a> Players

```csharp
public RepeatedField<CMsgSignOutGameplayStats.Types.CPlayer> Players { get; }
```

#### Property Value

 RepeatedField<[CMsgSignOutGameplayStats](Divine.Protobufs.Dota2.CMsgSignOutGameplayStats.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutGameplayStats.Types.md).[CPlayer](Divine.Protobufs.Dota2.CMsgSignOutGameplayStats.Types.CPlayer.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_Types_CTeam_TimedTeamStats"></a> TimedTeamStats

```csharp
public RepeatedField<CMatchTeamTimedStats> TimedTeamStats { get; }
```

#### Property Value

 RepeatedField<[CMatchTeamTimedStats](Divine.Protobufs.Dota2.CMatchTeamTimedStats.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_Types_CTeam_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_Types_CTeam_ClearIsRadiantTeam"></a> ClearIsRadiantTeam\(\)

```csharp
public void ClearIsRadiantTeam()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_Types_CTeam_ClearIsWinningTeam"></a> ClearIsWinningTeam\(\)

```csharp
public void ClearIsWinningTeam()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_Types_CTeam_Clone"></a> Clone\(\)

```csharp
public CMsgSignOutGameplayStats.Types.CTeam Clone()
```

#### Returns

 [CMsgSignOutGameplayStats](Divine.Protobufs.Dota2.CMsgSignOutGameplayStats.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutGameplayStats.Types.md).[CTeam](Divine.Protobufs.Dota2.CMsgSignOutGameplayStats.Types.CTeam.md)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_Types_CTeam_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_Types_CTeam_Equals_Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_Types_CTeam_"></a> Equals\(CTeam\)

```csharp
public bool Equals(CMsgSignOutGameplayStats.Types.CTeam other)
```

#### Parameters

`other` [CMsgSignOutGameplayStats](Divine.Protobufs.Dota2.CMsgSignOutGameplayStats.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutGameplayStats.Types.md).[CTeam](Divine.Protobufs.Dota2.CMsgSignOutGameplayStats.Types.CTeam.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_Types_CTeam_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_Types_CTeam_MergeFrom_Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_Types_CTeam_"></a> MergeFrom\(CTeam\)

```csharp
public void MergeFrom(CMsgSignOutGameplayStats.Types.CTeam other)
```

#### Parameters

`other` [CMsgSignOutGameplayStats](Divine.Protobufs.Dota2.CMsgSignOutGameplayStats.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutGameplayStats.Types.md).[CTeam](Divine.Protobufs.Dota2.CMsgSignOutGameplayStats.Types.CTeam.md)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_Types_CTeam_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_Types_CTeam_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_Types_CTeam_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

