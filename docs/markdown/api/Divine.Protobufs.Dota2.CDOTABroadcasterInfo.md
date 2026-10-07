# <a id="Divine_Protobufs_Dota2_CDOTABroadcasterInfo"></a> Class CDOTABroadcasterInfo

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTABroadcasterInfo : IMessage<CDOTABroadcasterInfo>, IEquatable<CDOTABroadcasterInfo>, IDeepCloneable<CDOTABroadcasterInfo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTABroadcasterInfo](Divine.Protobufs.Dota2.CDOTABroadcasterInfo.md)

#### Implements

IMessage<CDOTABroadcasterInfo\>, 
[IEquatable<CDOTABroadcasterInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTABroadcasterInfo\>, 
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
[EnumerableExtensions.In<CDOTABroadcasterInfo\>\(CDOTABroadcasterInfo, params CDOTABroadcasterInfo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTABroadcasterInfo__ctor"></a> CDOTABroadcasterInfo\(\)

```csharp
public CDOTABroadcasterInfo()
```

### <a id="Divine_Protobufs_Dota2_CDOTABroadcasterInfo__ctor_Divine_Protobufs_Dota2_CDOTABroadcasterInfo_"></a> CDOTABroadcasterInfo\(CDOTABroadcasterInfo\)

```csharp
public CDOTABroadcasterInfo(CDOTABroadcasterInfo other)
```

#### Parameters

`other` [CDOTABroadcasterInfo](Divine.Protobufs.Dota2.CDOTABroadcasterInfo.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTABroadcasterInfo_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcasterInfo_AllowLiveVideoFieldNumber"></a> AllowLiveVideoFieldNumber

```csharp
public const int AllowLiveVideoFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcasterInfo_LiveFieldNumber"></a> LiveFieldNumber

```csharp
public const int LiveFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcasterInfo_NodeNameFieldNumber"></a> NodeNameFieldNumber

```csharp
public const int NodeNameFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcasterInfo_NodeTypeFieldNumber"></a> NodeTypeFieldNumber

```csharp
public const int NodeTypeFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcasterInfo_SeriesGameFieldNumber"></a> SeriesGameFieldNumber

```csharp
public const int SeriesGameFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcasterInfo_ServerSteamIdFieldNumber"></a> ServerSteamIdFieldNumber

```csharp
public const int ServerSteamIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcasterInfo_TeamNameDireFieldNumber"></a> TeamNameDireFieldNumber

```csharp
public const int TeamNameDireFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcasterInfo_TeamNameRadiantFieldNumber"></a> TeamNameRadiantFieldNumber

```csharp
public const int TeamNameRadiantFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcasterInfo_UpcomingBroadcastTimestampFieldNumber"></a> UpcomingBroadcastTimestampFieldNumber

```csharp
public const int UpcomingBroadcastTimestampFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTABroadcasterInfo_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcasterInfo_AllowLiveVideo"></a> AllowLiveVideo

```csharp
public bool AllowLiveVideo { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcasterInfo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTABroadcasterInfo_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcasterInfo_HasAllowLiveVideo"></a> HasAllowLiveVideo

```csharp
public bool HasAllowLiveVideo { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcasterInfo_HasLive"></a> HasLive

```csharp
public bool HasLive { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcasterInfo_HasNodeName"></a> HasNodeName

```csharp
public bool HasNodeName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcasterInfo_HasNodeType"></a> HasNodeType

```csharp
public bool HasNodeType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcasterInfo_HasSeriesGame"></a> HasSeriesGame

```csharp
public bool HasSeriesGame { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcasterInfo_HasServerSteamId"></a> HasServerSteamId

```csharp
public bool HasServerSteamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcasterInfo_HasTeamNameDire"></a> HasTeamNameDire

```csharp
public bool HasTeamNameDire { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcasterInfo_HasTeamNameRadiant"></a> HasTeamNameRadiant

```csharp
public bool HasTeamNameRadiant { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcasterInfo_HasUpcomingBroadcastTimestamp"></a> HasUpcomingBroadcastTimestamp

```csharp
public bool HasUpcomingBroadcastTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcasterInfo_Live"></a> Live

```csharp
public bool Live { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcasterInfo_NodeName"></a> NodeName

```csharp
public string NodeName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcasterInfo_NodeType"></a> NodeType

```csharp
public uint NodeType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcasterInfo_Parser"></a> Parser

```csharp
public static MessageParser<CDOTABroadcasterInfo> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTABroadcasterInfo](Divine.Protobufs.Dota2.CDOTABroadcasterInfo.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTABroadcasterInfo_SeriesGame"></a> SeriesGame

```csharp
public uint SeriesGame { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcasterInfo_ServerSteamId"></a> ServerSteamId

```csharp
public ulong ServerSteamId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcasterInfo_TeamNameDire"></a> TeamNameDire

```csharp
public string TeamNameDire { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcasterInfo_TeamNameRadiant"></a> TeamNameRadiant

```csharp
public string TeamNameRadiant { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcasterInfo_UpcomingBroadcastTimestamp"></a> UpcomingBroadcastTimestamp

```csharp
public uint UpcomingBroadcastTimestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTABroadcasterInfo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcasterInfo_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CDOTABroadcasterInfo_ClearAllowLiveVideo"></a> ClearAllowLiveVideo\(\)

```csharp
public void ClearAllowLiveVideo()
```

### <a id="Divine_Protobufs_Dota2_CDOTABroadcasterInfo_ClearLive"></a> ClearLive\(\)

```csharp
public void ClearLive()
```

### <a id="Divine_Protobufs_Dota2_CDOTABroadcasterInfo_ClearNodeName"></a> ClearNodeName\(\)

```csharp
public void ClearNodeName()
```

### <a id="Divine_Protobufs_Dota2_CDOTABroadcasterInfo_ClearNodeType"></a> ClearNodeType\(\)

```csharp
public void ClearNodeType()
```

### <a id="Divine_Protobufs_Dota2_CDOTABroadcasterInfo_ClearSeriesGame"></a> ClearSeriesGame\(\)

```csharp
public void ClearSeriesGame()
```

### <a id="Divine_Protobufs_Dota2_CDOTABroadcasterInfo_ClearServerSteamId"></a> ClearServerSteamId\(\)

```csharp
public void ClearServerSteamId()
```

### <a id="Divine_Protobufs_Dota2_CDOTABroadcasterInfo_ClearTeamNameDire"></a> ClearTeamNameDire\(\)

```csharp
public void ClearTeamNameDire()
```

### <a id="Divine_Protobufs_Dota2_CDOTABroadcasterInfo_ClearTeamNameRadiant"></a> ClearTeamNameRadiant\(\)

```csharp
public void ClearTeamNameRadiant()
```

### <a id="Divine_Protobufs_Dota2_CDOTABroadcasterInfo_ClearUpcomingBroadcastTimestamp"></a> ClearUpcomingBroadcastTimestamp\(\)

```csharp
public void ClearUpcomingBroadcastTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CDOTABroadcasterInfo_Clone"></a> Clone\(\)

```csharp
public CDOTABroadcasterInfo Clone()
```

#### Returns

 [CDOTABroadcasterInfo](Divine.Protobufs.Dota2.CDOTABroadcasterInfo.md)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcasterInfo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcasterInfo_Equals_Divine_Protobufs_Dota2_CDOTABroadcasterInfo_"></a> Equals\(CDOTABroadcasterInfo\)

```csharp
public bool Equals(CDOTABroadcasterInfo other)
```

#### Parameters

`other` [CDOTABroadcasterInfo](Divine.Protobufs.Dota2.CDOTABroadcasterInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcasterInfo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcasterInfo_MergeFrom_Divine_Protobufs_Dota2_CDOTABroadcasterInfo_"></a> MergeFrom\(CDOTABroadcasterInfo\)

```csharp
public void MergeFrom(CDOTABroadcasterInfo other)
```

#### Parameters

`other` [CDOTABroadcasterInfo](Divine.Protobufs.Dota2.CDOTABroadcasterInfo.md)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcasterInfo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTABroadcasterInfo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTABroadcasterInfo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

