# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsMatchDetails"></a> Class CDOTAUserMsg\_StatsMatchDetails

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_StatsMatchDetails : IMessage<CDOTAUserMsg_StatsMatchDetails>, IEquatable<CDOTAUserMsg_StatsMatchDetails>, IDeepCloneable<CDOTAUserMsg_StatsMatchDetails>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_StatsMatchDetails](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsMatchDetails.md)

#### Implements

IMessage<CDOTAUserMsg\_StatsMatchDetails\>, 
[IEquatable<CDOTAUserMsg\_StatsMatchDetails\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_StatsMatchDetails\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_StatsMatchDetails\>\(CDOTAUserMsg\_StatsMatchDetails, params CDOTAUserMsg\_StatsMatchDetails\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsMatchDetails__ctor"></a> CDOTAUserMsg\_StatsMatchDetails\(\)

```csharp
public CDOTAUserMsg_StatsMatchDetails()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsMatchDetails__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_StatsMatchDetails_"></a> CDOTAUserMsg\_StatsMatchDetails\(CDOTAUserMsg\_StatsMatchDetails\)

```csharp
public CDOTAUserMsg_StatsMatchDetails(CDOTAUserMsg_StatsMatchDetails other)
```

#### Parameters

`other` [CDOTAUserMsg\_StatsMatchDetails](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsMatchDetails.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsMatchDetails_DireKillsFieldNumber"></a> DireKillsFieldNumber

```csharp
public const int DireKillsFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsMatchDetails_DireStatsFieldNumber"></a> DireStatsFieldNumber

```csharp
public const int DireStatsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsMatchDetails_FightDetailsFieldNumber"></a> FightDetailsFieldNumber

```csharp
public const int FightDetailsFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsMatchDetails_HeroLookupFieldNumber"></a> HeroLookupFieldNumber

```csharp
public const int HeroLookupFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsMatchDetails_RadiantKillsFieldNumber"></a> RadiantKillsFieldNumber

```csharp
public const int RadiantKillsFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsMatchDetails_RadiantStatsFieldNumber"></a> RadiantStatsFieldNumber

```csharp
public const int RadiantStatsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsMatchDetails_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsMatchDetails_DireKills"></a> DireKills

```csharp
public RepeatedField<CDOTAUserMsg_StatsKillDetails> DireKills { get; }
```

#### Property Value

 RepeatedField<[CDOTAUserMsg\_StatsKillDetails](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsKillDetails.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsMatchDetails_DireStats"></a> DireStats

```csharp
public RepeatedField<CDOTAUserMsg_StatsTeamMinuteDetails> DireStats { get; }
```

#### Property Value

 RepeatedField<[CDOTAUserMsg\_StatsTeamMinuteDetails](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsTeamMinuteDetails.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsMatchDetails_FightDetails"></a> FightDetails

```csharp
public RepeatedField<CDOTAUserMsg_StatsMatchDetails.Types.CDOTAUserMsg_StatsFightDetails> FightDetails { get; }
```

#### Property Value

 RepeatedField<[CDOTAUserMsg\_StatsMatchDetails](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsMatchDetails.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsMatchDetails.Types.md).[CDOTAUserMsg\_StatsFightDetails](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsMatchDetails.Types.CDOTAUserMsg\_StatsFightDetails.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsMatchDetails_HeroLookup"></a> HeroLookup

```csharp
public RepeatedField<CDOTAUserMsg_StatsHeroLookup> HeroLookup { get; }
```

#### Property Value

 RepeatedField<[CDOTAUserMsg\_StatsHeroLookup](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsHeroLookup.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsMatchDetails_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_StatsMatchDetails> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_StatsMatchDetails](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsMatchDetails.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsMatchDetails_RadiantKills"></a> RadiantKills

```csharp
public RepeatedField<CDOTAUserMsg_StatsKillDetails> RadiantKills { get; }
```

#### Property Value

 RepeatedField<[CDOTAUserMsg\_StatsKillDetails](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsKillDetails.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsMatchDetails_RadiantStats"></a> RadiantStats

```csharp
public RepeatedField<CDOTAUserMsg_StatsTeamMinuteDetails> RadiantStats { get; }
```

#### Property Value

 RepeatedField<[CDOTAUserMsg\_StatsTeamMinuteDetails](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsTeamMinuteDetails.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsMatchDetails_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsMatchDetails_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_StatsMatchDetails Clone()
```

#### Returns

 [CDOTAUserMsg\_StatsMatchDetails](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsMatchDetails.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsMatchDetails_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsMatchDetails_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_StatsMatchDetails_"></a> Equals\(CDOTAUserMsg\_StatsMatchDetails\)

```csharp
public bool Equals(CDOTAUserMsg_StatsMatchDetails other)
```

#### Parameters

`other` [CDOTAUserMsg\_StatsMatchDetails](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsMatchDetails.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsMatchDetails_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsMatchDetails_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_StatsMatchDetails_"></a> MergeFrom\(CDOTAUserMsg\_StatsMatchDetails\)

```csharp
public void MergeFrom(CDOTAUserMsg_StatsMatchDetails other)
```

#### Parameters

`other` [CDOTAUserMsg\_StatsMatchDetails](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsMatchDetails.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsMatchDetails_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsMatchDetails_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsMatchDetails_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

