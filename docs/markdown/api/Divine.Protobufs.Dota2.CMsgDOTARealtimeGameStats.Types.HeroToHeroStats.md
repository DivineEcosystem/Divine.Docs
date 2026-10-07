# <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_HeroToHeroStats"></a> Class CMsgDOTARealtimeGameStats.Types.HeroToHeroStats

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTARealtimeGameStats.Types.HeroToHeroStats : IMessage<CMsgDOTARealtimeGameStats.Types.HeroToHeroStats>, IEquatable<CMsgDOTARealtimeGameStats.Types.HeroToHeroStats>, IDeepCloneable<CMsgDOTARealtimeGameStats.Types.HeroToHeroStats>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTARealtimeGameStats.Types.HeroToHeroStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.HeroToHeroStats.md)

#### Implements

IMessage<CMsgDOTARealtimeGameStats.Types.HeroToHeroStats\>, 
[IEquatable<CMsgDOTARealtimeGameStats.Types.HeroToHeroStats\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTARealtimeGameStats.Types.HeroToHeroStats\>, 
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
[EnumerableExtensions.In<CMsgDOTARealtimeGameStats.Types.HeroToHeroStats\>\(CMsgDOTARealtimeGameStats.Types.HeroToHeroStats, params CMsgDOTARealtimeGameStats.Types.HeroToHeroStats\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_HeroToHeroStats__ctor"></a> HeroToHeroStats\(\)

```csharp
public HeroToHeroStats()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_HeroToHeroStats__ctor_Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_HeroToHeroStats_"></a> HeroToHeroStats\(HeroToHeroStats\)

```csharp
public HeroToHeroStats(CMsgDOTARealtimeGameStats.Types.HeroToHeroStats other)
```

#### Parameters

`other` [CMsgDOTARealtimeGameStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.md).[HeroToHeroStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.HeroToHeroStats.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_HeroToHeroStats_AssistsFieldNumber"></a> AssistsFieldNumber

```csharp
public const int AssistsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_HeroToHeroStats_KillsFieldNumber"></a> KillsFieldNumber

```csharp
public const int KillsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_HeroToHeroStats_VictimidFieldNumber"></a> VictimidFieldNumber

```csharp
public const int VictimidFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_HeroToHeroStats_Assists"></a> Assists

```csharp
public uint Assists { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_HeroToHeroStats_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_HeroToHeroStats_HasAssists"></a> HasAssists

```csharp
public bool HasAssists { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_HeroToHeroStats_HasKills"></a> HasKills

```csharp
public bool HasKills { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_HeroToHeroStats_HasVictimid"></a> HasVictimid

```csharp
public bool HasVictimid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_HeroToHeroStats_Kills"></a> Kills

```csharp
public uint Kills { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_HeroToHeroStats_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTARealtimeGameStats.Types.HeroToHeroStats> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTARealtimeGameStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.md).[HeroToHeroStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.HeroToHeroStats.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_HeroToHeroStats_Victimid"></a> Victimid

```csharp
public int Victimid { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_HeroToHeroStats_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_HeroToHeroStats_ClearAssists"></a> ClearAssists\(\)

```csharp
public void ClearAssists()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_HeroToHeroStats_ClearKills"></a> ClearKills\(\)

```csharp
public void ClearKills()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_HeroToHeroStats_ClearVictimid"></a> ClearVictimid\(\)

```csharp
public void ClearVictimid()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_HeroToHeroStats_Clone"></a> Clone\(\)

```csharp
public CMsgDOTARealtimeGameStats.Types.HeroToHeroStats Clone()
```

#### Returns

 [CMsgDOTARealtimeGameStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.md).[HeroToHeroStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.HeroToHeroStats.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_HeroToHeroStats_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_HeroToHeroStats_Equals_Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_HeroToHeroStats_"></a> Equals\(HeroToHeroStats\)

```csharp
public bool Equals(CMsgDOTARealtimeGameStats.Types.HeroToHeroStats other)
```

#### Parameters

`other` [CMsgDOTARealtimeGameStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.md).[HeroToHeroStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.HeroToHeroStats.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_HeroToHeroStats_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_HeroToHeroStats_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_HeroToHeroStats_"></a> MergeFrom\(HeroToHeroStats\)

```csharp
public void MergeFrom(CMsgDOTARealtimeGameStats.Types.HeroToHeroStats other)
```

#### Parameters

`other` [CMsgDOTARealtimeGameStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.md).[HeroToHeroStats](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStats.Types.HeroToHeroStats.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_HeroToHeroStats_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_HeroToHeroStats_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStats_Types_HeroToHeroStats_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

