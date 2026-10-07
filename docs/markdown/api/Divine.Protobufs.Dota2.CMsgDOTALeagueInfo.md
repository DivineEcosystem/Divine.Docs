# <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfo"></a> Class CMsgDOTALeagueInfo

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTALeagueInfo : IMessage<CMsgDOTALeagueInfo>, IEquatable<CMsgDOTALeagueInfo>, IDeepCloneable<CMsgDOTALeagueInfo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTALeagueInfo](Divine.Protobufs.Dota2.CMsgDOTALeagueInfo.md)

#### Implements

IMessage<CMsgDOTALeagueInfo\>, 
[IEquatable<CMsgDOTALeagueInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTALeagueInfo\>, 
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
[EnumerableExtensions.In<CMsgDOTALeagueInfo\>\(CMsgDOTALeagueInfo, params CMsgDOTALeagueInfo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfo__ctor"></a> CMsgDOTALeagueInfo\(\)

```csharp
public CMsgDOTALeagueInfo()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfo__ctor_Divine_Protobufs_Dota2_CMsgDOTALeagueInfo_"></a> CMsgDOTALeagueInfo\(CMsgDOTALeagueInfo\)

```csharp
public CMsgDOTALeagueInfo(CMsgDOTALeagueInfo other)
```

#### Parameters

`other` [CMsgDOTALeagueInfo](Divine.Protobufs.Dota2.CMsgDOTALeagueInfo.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfo_EndTimestampFieldNumber"></a> EndTimestampFieldNumber

```csharp
public const int EndTimestampFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfo_LeagueIdFieldNumber"></a> LeagueIdFieldNumber

```csharp
public const int LeagueIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfo_MostRecentActivityFieldNumber"></a> MostRecentActivityFieldNumber

```csharp
public const int MostRecentActivityFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfo_NameFieldNumber"></a> NameFieldNumber

```csharp
public const int NameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfo_RegionFieldNumber"></a> RegionFieldNumber

```csharp
public const int RegionFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfo_StartTimestampFieldNumber"></a> StartTimestampFieldNumber

```csharp
public const int StartTimestampFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfo_StatusFieldNumber"></a> StatusFieldNumber

```csharp
public const int StatusFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfo_TierFieldNumber"></a> TierFieldNumber

```csharp
public const int TierFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfo_TotalPrizePoolFieldNumber"></a> TotalPrizePoolFieldNumber

```csharp
public const int TotalPrizePoolFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfo_EndTimestamp"></a> EndTimestamp

```csharp
public uint EndTimestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfo_HasEndTimestamp"></a> HasEndTimestamp

```csharp
public bool HasEndTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfo_HasLeagueId"></a> HasLeagueId

```csharp
public bool HasLeagueId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfo_HasMostRecentActivity"></a> HasMostRecentActivity

```csharp
public bool HasMostRecentActivity { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfo_HasName"></a> HasName

```csharp
public bool HasName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfo_HasRegion"></a> HasRegion

```csharp
public bool HasRegion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfo_HasStartTimestamp"></a> HasStartTimestamp

```csharp
public bool HasStartTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfo_HasStatus"></a> HasStatus

```csharp
public bool HasStatus { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfo_HasTier"></a> HasTier

```csharp
public bool HasTier { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfo_HasTotalPrizePool"></a> HasTotalPrizePool

```csharp
public bool HasTotalPrizePool { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfo_LeagueId"></a> LeagueId

```csharp
public uint LeagueId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfo_MostRecentActivity"></a> MostRecentActivity

```csharp
public uint MostRecentActivity { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfo_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfo_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTALeagueInfo> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTALeagueInfo](Divine.Protobufs.Dota2.CMsgDOTALeagueInfo.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfo_Region"></a> Region

```csharp
public ELeagueRegion Region { get; set; }
```

#### Property Value

 [ELeagueRegion](Divine.Protobufs.Dota2.ELeagueRegion.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfo_StartTimestamp"></a> StartTimestamp

```csharp
public uint StartTimestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfo_Status"></a> Status

```csharp
public uint Status { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfo_Tier"></a> Tier

```csharp
public ELeagueTier Tier { get; set; }
```

#### Property Value

 [ELeagueTier](Divine.Protobufs.Dota2.ELeagueTier.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfo_TotalPrizePool"></a> TotalPrizePool

```csharp
public uint TotalPrizePool { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfo_ClearEndTimestamp"></a> ClearEndTimestamp\(\)

```csharp
public void ClearEndTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfo_ClearLeagueId"></a> ClearLeagueId\(\)

```csharp
public void ClearLeagueId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfo_ClearMostRecentActivity"></a> ClearMostRecentActivity\(\)

```csharp
public void ClearMostRecentActivity()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfo_ClearName"></a> ClearName\(\)

```csharp
public void ClearName()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfo_ClearRegion"></a> ClearRegion\(\)

```csharp
public void ClearRegion()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfo_ClearStartTimestamp"></a> ClearStartTimestamp\(\)

```csharp
public void ClearStartTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfo_ClearStatus"></a> ClearStatus\(\)

```csharp
public void ClearStatus()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfo_ClearTier"></a> ClearTier\(\)

```csharp
public void ClearTier()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfo_ClearTotalPrizePool"></a> ClearTotalPrizePool\(\)

```csharp
public void ClearTotalPrizePool()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfo_Clone"></a> Clone\(\)

```csharp
public CMsgDOTALeagueInfo Clone()
```

#### Returns

 [CMsgDOTALeagueInfo](Divine.Protobufs.Dota2.CMsgDOTALeagueInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfo_Equals_Divine_Protobufs_Dota2_CMsgDOTALeagueInfo_"></a> Equals\(CMsgDOTALeagueInfo\)

```csharp
public bool Equals(CMsgDOTALeagueInfo other)
```

#### Parameters

`other` [CMsgDOTALeagueInfo](Divine.Protobufs.Dota2.CMsgDOTALeagueInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfo_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTALeagueInfo_"></a> MergeFrom\(CMsgDOTALeagueInfo\)

```csharp
public void MergeFrom(CMsgDOTALeagueInfo other)
```

#### Parameters

`other` [CMsgDOTALeagueInfo](Divine.Protobufs.Dota2.CMsgDOTALeagueInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

