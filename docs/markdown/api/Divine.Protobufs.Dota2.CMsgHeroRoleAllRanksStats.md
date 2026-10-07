# <a id="Divine_Protobufs_Dota2_CMsgHeroRoleAllRanksStats"></a> Class CMsgHeroRoleAllRanksStats

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgHeroRoleAllRanksStats : IMessage<CMsgHeroRoleAllRanksStats>, IEquatable<CMsgHeroRoleAllRanksStats>, IDeepCloneable<CMsgHeroRoleAllRanksStats>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgHeroRoleAllRanksStats](Divine.Protobufs.Dota2.CMsgHeroRoleAllRanksStats.md)

#### Implements

IMessage<CMsgHeroRoleAllRanksStats\>, 
[IEquatable<CMsgHeroRoleAllRanksStats\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgHeroRoleAllRanksStats\>, 
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
[EnumerableExtensions.In<CMsgHeroRoleAllRanksStats\>\(CMsgHeroRoleAllRanksStats, params CMsgHeroRoleAllRanksStats\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleAllRanksStats__ctor"></a> CMsgHeroRoleAllRanksStats\(\)

```csharp
public CMsgHeroRoleAllRanksStats()
```

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleAllRanksStats__ctor_Divine_Protobufs_Dota2_CMsgHeroRoleAllRanksStats_"></a> CMsgHeroRoleAllRanksStats\(CMsgHeroRoleAllRanksStats\)

```csharp
public CMsgHeroRoleAllRanksStats(CMsgHeroRoleAllRanksStats other)
```

#### Parameters

`other` [CMsgHeroRoleAllRanksStats](Divine.Protobufs.Dota2.CMsgHeroRoleAllRanksStats.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleAllRanksStats_EndTimestampFieldNumber"></a> EndTimestampFieldNumber

```csharp
public const int EndTimestampFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleAllRanksStats_RankStatsFieldNumber"></a> RankStatsFieldNumber

```csharp
public const int RankStatsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleAllRanksStats_StartTimestampFieldNumber"></a> StartTimestampFieldNumber

```csharp
public const int StartTimestampFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleAllRanksStats_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleAllRanksStats_EndTimestamp"></a> EndTimestamp

```csharp
public uint EndTimestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleAllRanksStats_HasEndTimestamp"></a> HasEndTimestamp

```csharp
public bool HasEndTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleAllRanksStats_HasStartTimestamp"></a> HasStartTimestamp

```csharp
public bool HasStartTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleAllRanksStats_Parser"></a> Parser

```csharp
public static MessageParser<CMsgHeroRoleAllRanksStats> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgHeroRoleAllRanksStats](Divine.Protobufs.Dota2.CMsgHeroRoleAllRanksStats.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleAllRanksStats_RankStats"></a> RankStats

```csharp
public RepeatedField<CMsgHeroRoleRankStats> RankStats { get; }
```

#### Property Value

 RepeatedField<[CMsgHeroRoleRankStats](Divine.Protobufs.Dota2.CMsgHeroRoleRankStats.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleAllRanksStats_StartTimestamp"></a> StartTimestamp

```csharp
public uint StartTimestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleAllRanksStats_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleAllRanksStats_ClearEndTimestamp"></a> ClearEndTimestamp\(\)

```csharp
public void ClearEndTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleAllRanksStats_ClearStartTimestamp"></a> ClearStartTimestamp\(\)

```csharp
public void ClearStartTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleAllRanksStats_Clone"></a> Clone\(\)

```csharp
public CMsgHeroRoleAllRanksStats Clone()
```

#### Returns

 [CMsgHeroRoleAllRanksStats](Divine.Protobufs.Dota2.CMsgHeroRoleAllRanksStats.md)

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleAllRanksStats_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleAllRanksStats_Equals_Divine_Protobufs_Dota2_CMsgHeroRoleAllRanksStats_"></a> Equals\(CMsgHeroRoleAllRanksStats\)

```csharp
public bool Equals(CMsgHeroRoleAllRanksStats other)
```

#### Parameters

`other` [CMsgHeroRoleAllRanksStats](Divine.Protobufs.Dota2.CMsgHeroRoleAllRanksStats.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleAllRanksStats_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleAllRanksStats_MergeFrom_Divine_Protobufs_Dota2_CMsgHeroRoleAllRanksStats_"></a> MergeFrom\(CMsgHeroRoleAllRanksStats\)

```csharp
public void MergeFrom(CMsgHeroRoleAllRanksStats other)
```

#### Parameters

`other` [CMsgHeroRoleAllRanksStats](Divine.Protobufs.Dota2.CMsgHeroRoleAllRanksStats.md)

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleAllRanksStats_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleAllRanksStats_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleAllRanksStats_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

