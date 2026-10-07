# <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetPlayerCardRosterRequest"></a> Class CMsgClientToGCSetPlayerCardRosterRequest

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCSetPlayerCardRosterRequest : IMessage<CMsgClientToGCSetPlayerCardRosterRequest>, IEquatable<CMsgClientToGCSetPlayerCardRosterRequest>, IDeepCloneable<CMsgClientToGCSetPlayerCardRosterRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCSetPlayerCardRosterRequest](Divine.Protobufs.Dota2.CMsgClientToGCSetPlayerCardRosterRequest.md)

#### Implements

IMessage<CMsgClientToGCSetPlayerCardRosterRequest\>, 
[IEquatable<CMsgClientToGCSetPlayerCardRosterRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCSetPlayerCardRosterRequest\>, 
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
[EnumerableExtensions.In<CMsgClientToGCSetPlayerCardRosterRequest\>\(CMsgClientToGCSetPlayerCardRosterRequest, params CMsgClientToGCSetPlayerCardRosterRequest\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetPlayerCardRosterRequest__ctor"></a> CMsgClientToGCSetPlayerCardRosterRequest\(\)

```csharp
public CMsgClientToGCSetPlayerCardRosterRequest()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetPlayerCardRosterRequest__ctor_Divine_Protobufs_Dota2_CMsgClientToGCSetPlayerCardRosterRequest_"></a> CMsgClientToGCSetPlayerCardRosterRequest\(CMsgClientToGCSetPlayerCardRosterRequest\)

```csharp
public CMsgClientToGCSetPlayerCardRosterRequest(CMsgClientToGCSetPlayerCardRosterRequest other)
```

#### Parameters

`other` [CMsgClientToGCSetPlayerCardRosterRequest](Divine.Protobufs.Dota2.CMsgClientToGCSetPlayerCardRosterRequest.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetPlayerCardRosterRequest_DeprecatedTimestampFieldNumber"></a> DeprecatedTimestampFieldNumber

```csharp
public const int DeprecatedTimestampFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetPlayerCardRosterRequest_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetPlayerCardRosterRequest_FantasyPeriodFieldNumber"></a> FantasyPeriodFieldNumber

```csharp
public const int FantasyPeriodFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetPlayerCardRosterRequest_LeagueIdFieldNumber"></a> LeagueIdFieldNumber

```csharp
public const int LeagueIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetPlayerCardRosterRequest_PlayerCardItemIdFieldNumber"></a> PlayerCardItemIdFieldNumber

```csharp
public const int PlayerCardItemIdFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetPlayerCardRosterRequest_SlotFieldNumber"></a> SlotFieldNumber

```csharp
public const int SlotFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetPlayerCardRosterRequest_DeprecatedTimestamp"></a> DeprecatedTimestamp

```csharp
public uint DeprecatedTimestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetPlayerCardRosterRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetPlayerCardRosterRequest_EventId"></a> EventId

```csharp
public uint EventId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetPlayerCardRosterRequest_FantasyPeriod"></a> FantasyPeriod

```csharp
public uint FantasyPeriod { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetPlayerCardRosterRequest_HasDeprecatedTimestamp"></a> HasDeprecatedTimestamp

```csharp
public bool HasDeprecatedTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetPlayerCardRosterRequest_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetPlayerCardRosterRequest_HasFantasyPeriod"></a> HasFantasyPeriod

```csharp
public bool HasFantasyPeriod { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetPlayerCardRosterRequest_HasLeagueId"></a> HasLeagueId

```csharp
public bool HasLeagueId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetPlayerCardRosterRequest_HasPlayerCardItemId"></a> HasPlayerCardItemId

```csharp
public bool HasPlayerCardItemId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetPlayerCardRosterRequest_HasSlot"></a> HasSlot

```csharp
public bool HasSlot { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetPlayerCardRosterRequest_LeagueId"></a> LeagueId

```csharp
public uint LeagueId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetPlayerCardRosterRequest_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCSetPlayerCardRosterRequest> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCSetPlayerCardRosterRequest](Divine.Protobufs.Dota2.CMsgClientToGCSetPlayerCardRosterRequest.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetPlayerCardRosterRequest_PlayerCardItemId"></a> PlayerCardItemId

```csharp
public ulong PlayerCardItemId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetPlayerCardRosterRequest_Slot"></a> Slot

```csharp
public uint Slot { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetPlayerCardRosterRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetPlayerCardRosterRequest_ClearDeprecatedTimestamp"></a> ClearDeprecatedTimestamp\(\)

```csharp
public void ClearDeprecatedTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetPlayerCardRosterRequest_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetPlayerCardRosterRequest_ClearFantasyPeriod"></a> ClearFantasyPeriod\(\)

```csharp
public void ClearFantasyPeriod()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetPlayerCardRosterRequest_ClearLeagueId"></a> ClearLeagueId\(\)

```csharp
public void ClearLeagueId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetPlayerCardRosterRequest_ClearPlayerCardItemId"></a> ClearPlayerCardItemId\(\)

```csharp
public void ClearPlayerCardItemId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetPlayerCardRosterRequest_ClearSlot"></a> ClearSlot\(\)

```csharp
public void ClearSlot()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetPlayerCardRosterRequest_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCSetPlayerCardRosterRequest Clone()
```

#### Returns

 [CMsgClientToGCSetPlayerCardRosterRequest](Divine.Protobufs.Dota2.CMsgClientToGCSetPlayerCardRosterRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetPlayerCardRosterRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetPlayerCardRosterRequest_Equals_Divine_Protobufs_Dota2_CMsgClientToGCSetPlayerCardRosterRequest_"></a> Equals\(CMsgClientToGCSetPlayerCardRosterRequest\)

```csharp
public bool Equals(CMsgClientToGCSetPlayerCardRosterRequest other)
```

#### Parameters

`other` [CMsgClientToGCSetPlayerCardRosterRequest](Divine.Protobufs.Dota2.CMsgClientToGCSetPlayerCardRosterRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetPlayerCardRosterRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetPlayerCardRosterRequest_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCSetPlayerCardRosterRequest_"></a> MergeFrom\(CMsgClientToGCSetPlayerCardRosterRequest\)

```csharp
public void MergeFrom(CMsgClientToGCSetPlayerCardRosterRequest other)
```

#### Parameters

`other` [CMsgClientToGCSetPlayerCardRosterRequest](Divine.Protobufs.Dota2.CMsgClientToGCSetPlayerCardRosterRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetPlayerCardRosterRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetPlayerCardRosterRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetPlayerCardRosterRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

