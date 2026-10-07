# <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyDPCLeagueStatus_Types_LeagueInfo"></a> Class CMsgDOTAFantasyDPCLeagueStatus.Types.LeagueInfo

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAFantasyDPCLeagueStatus.Types.LeagueInfo : IMessage<CMsgDOTAFantasyDPCLeagueStatus.Types.LeagueInfo>, IEquatable<CMsgDOTAFantasyDPCLeagueStatus.Types.LeagueInfo>, IDeepCloneable<CMsgDOTAFantasyDPCLeagueStatus.Types.LeagueInfo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAFantasyDPCLeagueStatus.Types.LeagueInfo](Divine.Protobufs.Dota2.CMsgDOTAFantasyDPCLeagueStatus.Types.LeagueInfo.md)

#### Implements

IMessage<CMsgDOTAFantasyDPCLeagueStatus.Types.LeagueInfo\>, 
[IEquatable<CMsgDOTAFantasyDPCLeagueStatus.Types.LeagueInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAFantasyDPCLeagueStatus.Types.LeagueInfo\>, 
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
[EnumerableExtensions.In<CMsgDOTAFantasyDPCLeagueStatus.Types.LeagueInfo\>\(CMsgDOTAFantasyDPCLeagueStatus.Types.LeagueInfo, params CMsgDOTAFantasyDPCLeagueStatus.Types.LeagueInfo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyDPCLeagueStatus_Types_LeagueInfo__ctor"></a> LeagueInfo\(\)

```csharp
public LeagueInfo()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyDPCLeagueStatus_Types_LeagueInfo__ctor_Divine_Protobufs_Dota2_CMsgDOTAFantasyDPCLeagueStatus_Types_LeagueInfo_"></a> LeagueInfo\(LeagueInfo\)

```csharp
public LeagueInfo(CMsgDOTAFantasyDPCLeagueStatus.Types.LeagueInfo other)
```

#### Parameters

`other` [CMsgDOTAFantasyDPCLeagueStatus](Divine.Protobufs.Dota2.CMsgDOTAFantasyDPCLeagueStatus.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAFantasyDPCLeagueStatus.Types.md).[LeagueInfo](Divine.Protobufs.Dota2.CMsgDOTAFantasyDPCLeagueStatus.Types.LeagueInfo.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyDPCLeagueStatus_Types_LeagueInfo_DayTimestampsFieldNumber"></a> DayTimestampsFieldNumber

```csharp
public const int DayTimestampsFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyDPCLeagueStatus_Types_LeagueInfo_EndTimestampFieldNumber"></a> EndTimestampFieldNumber

```csharp
public const int EndTimestampFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyDPCLeagueStatus_Types_LeagueInfo_LeagueIdFieldNumber"></a> LeagueIdFieldNumber

```csharp
public const int LeagueIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyDPCLeagueStatus_Types_LeagueInfo_LeagueNameFieldNumber"></a> LeagueNameFieldNumber

```csharp
public const int LeagueNameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyDPCLeagueStatus_Types_LeagueInfo_StartTimestampFieldNumber"></a> StartTimestampFieldNumber

```csharp
public const int StartTimestampFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyDPCLeagueStatus_Types_LeagueInfo_StatusFieldNumber"></a> StatusFieldNumber

```csharp
public const int StatusFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyDPCLeagueStatus_Types_LeagueInfo_DayTimestamps"></a> DayTimestamps

```csharp
public RepeatedField<uint> DayTimestamps { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyDPCLeagueStatus_Types_LeagueInfo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyDPCLeagueStatus_Types_LeagueInfo_EndTimestamp"></a> EndTimestamp

```csharp
public uint EndTimestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyDPCLeagueStatus_Types_LeagueInfo_HasEndTimestamp"></a> HasEndTimestamp

```csharp
public bool HasEndTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyDPCLeagueStatus_Types_LeagueInfo_HasLeagueId"></a> HasLeagueId

```csharp
public bool HasLeagueId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyDPCLeagueStatus_Types_LeagueInfo_HasLeagueName"></a> HasLeagueName

```csharp
public bool HasLeagueName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyDPCLeagueStatus_Types_LeagueInfo_HasStartTimestamp"></a> HasStartTimestamp

```csharp
public bool HasStartTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyDPCLeagueStatus_Types_LeagueInfo_HasStatus"></a> HasStatus

```csharp
public bool HasStatus { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyDPCLeagueStatus_Types_LeagueInfo_LeagueId"></a> LeagueId

```csharp
public uint LeagueId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyDPCLeagueStatus_Types_LeagueInfo_LeagueName"></a> LeagueName

```csharp
public string LeagueName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyDPCLeagueStatus_Types_LeagueInfo_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAFantasyDPCLeagueStatus.Types.LeagueInfo> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAFantasyDPCLeagueStatus](Divine.Protobufs.Dota2.CMsgDOTAFantasyDPCLeagueStatus.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAFantasyDPCLeagueStatus.Types.md).[LeagueInfo](Divine.Protobufs.Dota2.CMsgDOTAFantasyDPCLeagueStatus.Types.LeagueInfo.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyDPCLeagueStatus_Types_LeagueInfo_StartTimestamp"></a> StartTimestamp

```csharp
public uint StartTimestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyDPCLeagueStatus_Types_LeagueInfo_Status"></a> Status

```csharp
public CMsgDOTAFantasyDPCLeagueStatus.Types.ERosterStatus Status { get; set; }
```

#### Property Value

 [CMsgDOTAFantasyDPCLeagueStatus](Divine.Protobufs.Dota2.CMsgDOTAFantasyDPCLeagueStatus.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAFantasyDPCLeagueStatus.Types.md).[ERosterStatus](Divine.Protobufs.Dota2.CMsgDOTAFantasyDPCLeagueStatus.Types.ERosterStatus.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyDPCLeagueStatus_Types_LeagueInfo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyDPCLeagueStatus_Types_LeagueInfo_ClearEndTimestamp"></a> ClearEndTimestamp\(\)

```csharp
public void ClearEndTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyDPCLeagueStatus_Types_LeagueInfo_ClearLeagueId"></a> ClearLeagueId\(\)

```csharp
public void ClearLeagueId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyDPCLeagueStatus_Types_LeagueInfo_ClearLeagueName"></a> ClearLeagueName\(\)

```csharp
public void ClearLeagueName()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyDPCLeagueStatus_Types_LeagueInfo_ClearStartTimestamp"></a> ClearStartTimestamp\(\)

```csharp
public void ClearStartTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyDPCLeagueStatus_Types_LeagueInfo_ClearStatus"></a> ClearStatus\(\)

```csharp
public void ClearStatus()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyDPCLeagueStatus_Types_LeagueInfo_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAFantasyDPCLeagueStatus.Types.LeagueInfo Clone()
```

#### Returns

 [CMsgDOTAFantasyDPCLeagueStatus](Divine.Protobufs.Dota2.CMsgDOTAFantasyDPCLeagueStatus.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAFantasyDPCLeagueStatus.Types.md).[LeagueInfo](Divine.Protobufs.Dota2.CMsgDOTAFantasyDPCLeagueStatus.Types.LeagueInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyDPCLeagueStatus_Types_LeagueInfo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyDPCLeagueStatus_Types_LeagueInfo_Equals_Divine_Protobufs_Dota2_CMsgDOTAFantasyDPCLeagueStatus_Types_LeagueInfo_"></a> Equals\(LeagueInfo\)

```csharp
public bool Equals(CMsgDOTAFantasyDPCLeagueStatus.Types.LeagueInfo other)
```

#### Parameters

`other` [CMsgDOTAFantasyDPCLeagueStatus](Divine.Protobufs.Dota2.CMsgDOTAFantasyDPCLeagueStatus.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAFantasyDPCLeagueStatus.Types.md).[LeagueInfo](Divine.Protobufs.Dota2.CMsgDOTAFantasyDPCLeagueStatus.Types.LeagueInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyDPCLeagueStatus_Types_LeagueInfo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyDPCLeagueStatus_Types_LeagueInfo_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAFantasyDPCLeagueStatus_Types_LeagueInfo_"></a> MergeFrom\(LeagueInfo\)

```csharp
public void MergeFrom(CMsgDOTAFantasyDPCLeagueStatus.Types.LeagueInfo other)
```

#### Parameters

`other` [CMsgDOTAFantasyDPCLeagueStatus](Divine.Protobufs.Dota2.CMsgDOTAFantasyDPCLeagueStatus.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAFantasyDPCLeagueStatus.Types.md).[LeagueInfo](Divine.Protobufs.Dota2.CMsgDOTAFantasyDPCLeagueStatus.Types.LeagueInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyDPCLeagueStatus_Types_LeagueInfo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyDPCLeagueStatus_Types_LeagueInfo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyDPCLeagueStatus_Types_LeagueInfo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

