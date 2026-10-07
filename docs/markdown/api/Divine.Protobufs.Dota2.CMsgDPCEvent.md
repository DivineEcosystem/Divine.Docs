# <a id="Divine_Protobufs_Dota2_CMsgDPCEvent"></a> Class CMsgDPCEvent

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDPCEvent : IMessage<CMsgDPCEvent>, IEquatable<CMsgDPCEvent>, IDeepCloneable<CMsgDPCEvent>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDPCEvent](Divine.Protobufs.Dota2.CMsgDPCEvent.md)

#### Implements

IMessage<CMsgDPCEvent\>, 
[IEquatable<CMsgDPCEvent\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDPCEvent\>, 
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
[EnumerableExtensions.In<CMsgDPCEvent\>\(CMsgDPCEvent, params CMsgDPCEvent\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent__ctor"></a> CMsgDPCEvent\(\)

```csharp
public CMsgDPCEvent()
```

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent__ctor_Divine_Protobufs_Dota2_CMsgDPCEvent_"></a> CMsgDPCEvent\(CMsgDPCEvent\)

```csharp
public CMsgDPCEvent(CMsgDPCEvent other)
```

#### Parameters

`other` [CMsgDPCEvent](Divine.Protobufs.Dota2.CMsgDPCEvent.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_EventFieldNumber"></a> EventFieldNumber

```csharp
public const int EventFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_EventNameFieldNumber"></a> EventNameFieldNumber

```csharp
public const int EventNameFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_EventTypeFieldNumber"></a> EventTypeFieldNumber

```csharp
public const int EventTypeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_IsEventCompletedFieldNumber"></a> IsEventCompletedFieldNumber

```csharp
public const int IsEventCompletedFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_IsEventUpcomingFieldNumber"></a> IsEventUpcomingFieldNumber

```csharp
public const int IsEventUpcomingFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_IsFantasyEnabledFieldNumber"></a> IsFantasyEnabledFieldNumber

```csharp
public const int IsFantasyEnabledFieldNumber = 15
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_LeaguesFieldNumber"></a> LeaguesFieldNumber

```csharp
public const int LeaguesFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_MulticastLeagueIdFieldNumber"></a> MulticastLeagueIdFieldNumber

```csharp
public const int MulticastLeagueIdFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_MulticastStreamsFieldNumber"></a> MulticastStreamsFieldNumber

```csharp
public const int MulticastStreamsFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_RegistrationPeriodFieldNumber"></a> RegistrationPeriodFieldNumber

```csharp
public const int RegistrationPeriodFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_TimestampAddLockFieldNumber"></a> TimestampAddLockFieldNumber

```csharp
public const int TimestampAddLockFieldNumber = 13
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_TimestampContentDeadlineFieldNumber"></a> TimestampContentDeadlineFieldNumber

```csharp
public const int TimestampContentDeadlineFieldNumber = 14
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_TimestampContentReviewDeadlineFieldNumber"></a> TimestampContentReviewDeadlineFieldNumber

```csharp
public const int TimestampContentReviewDeadlineFieldNumber = 16
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_TimestampDropLockFieldNumber"></a> TimestampDropLockFieldNumber

```csharp
public const int TimestampDropLockFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_TourFieldNumber"></a> TourFieldNumber

```csharp
public const int TourFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_Event"></a> Event

```csharp
public CMsgDPCEvent.Types.ELeagueEvent Event { get; set; }
```

#### Property Value

 [CMsgDPCEvent](Divine.Protobufs.Dota2.CMsgDPCEvent.md).[Types](Divine.Protobufs.Dota2.CMsgDPCEvent.Types.md).[ELeagueEvent](Divine.Protobufs.Dota2.CMsgDPCEvent.Types.ELeagueEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_EventName"></a> EventName

```csharp
public string EventName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_EventType"></a> EventType

```csharp
public CMsgDPCEvent.Types.ELeagueEventType EventType { get; set; }
```

#### Property Value

 [CMsgDPCEvent](Divine.Protobufs.Dota2.CMsgDPCEvent.md).[Types](Divine.Protobufs.Dota2.CMsgDPCEvent.Types.md).[ELeagueEventType](Divine.Protobufs.Dota2.CMsgDPCEvent.Types.ELeagueEventType.md)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_HasEvent"></a> HasEvent

```csharp
public bool HasEvent { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_HasEventName"></a> HasEventName

```csharp
public bool HasEventName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_HasEventType"></a> HasEventType

```csharp
public bool HasEventType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_HasIsEventCompleted"></a> HasIsEventCompleted

```csharp
public bool HasIsEventCompleted { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_HasIsEventUpcoming"></a> HasIsEventUpcoming

```csharp
public bool HasIsEventUpcoming { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_HasIsFantasyEnabled"></a> HasIsFantasyEnabled

```csharp
public bool HasIsFantasyEnabled { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_HasMulticastLeagueId"></a> HasMulticastLeagueId

```csharp
public bool HasMulticastLeagueId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_HasRegistrationPeriod"></a> HasRegistrationPeriod

```csharp
public bool HasRegistrationPeriod { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_HasTimestampAddLock"></a> HasTimestampAddLock

```csharp
public bool HasTimestampAddLock { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_HasTimestampContentDeadline"></a> HasTimestampContentDeadline

```csharp
public bool HasTimestampContentDeadline { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_HasTimestampContentReviewDeadline"></a> HasTimestampContentReviewDeadline

```csharp
public bool HasTimestampContentReviewDeadline { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_HasTimestampDropLock"></a> HasTimestampDropLock

```csharp
public bool HasTimestampDropLock { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_HasTour"></a> HasTour

```csharp
public bool HasTour { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_IsEventCompleted"></a> IsEventCompleted

```csharp
public bool IsEventCompleted { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_IsEventUpcoming"></a> IsEventUpcoming

```csharp
public bool IsEventUpcoming { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_IsFantasyEnabled"></a> IsFantasyEnabled

```csharp
public bool IsFantasyEnabled { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_Leagues"></a> Leagues

```csharp
public RepeatedField<CMsgDPCEvent.Types.League> Leagues { get; }
```

#### Property Value

 RepeatedField<[CMsgDPCEvent](Divine.Protobufs.Dota2.CMsgDPCEvent.md).[Types](Divine.Protobufs.Dota2.CMsgDPCEvent.Types.md).[League](Divine.Protobufs.Dota2.CMsgDPCEvent.Types.League.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_MulticastLeagueId"></a> MulticastLeagueId

```csharp
public uint MulticastLeagueId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_MulticastStreams"></a> MulticastStreams

```csharp
public RepeatedField<uint> MulticastStreams { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDPCEvent> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDPCEvent](Divine.Protobufs.Dota2.CMsgDPCEvent.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_RegistrationPeriod"></a> RegistrationPeriod

```csharp
public uint RegistrationPeriod { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_TimestampAddLock"></a> TimestampAddLock

```csharp
public uint TimestampAddLock { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_TimestampContentDeadline"></a> TimestampContentDeadline

```csharp
public uint TimestampContentDeadline { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_TimestampContentReviewDeadline"></a> TimestampContentReviewDeadline

```csharp
public uint TimestampContentReviewDeadline { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_TimestampDropLock"></a> TimestampDropLock

```csharp
public uint TimestampDropLock { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_Tour"></a> Tour

```csharp
public CMsgDPCEvent.Types.ETour Tour { get; set; }
```

#### Property Value

 [CMsgDPCEvent](Divine.Protobufs.Dota2.CMsgDPCEvent.md).[Types](Divine.Protobufs.Dota2.CMsgDPCEvent.Types.md).[ETour](Divine.Protobufs.Dota2.CMsgDPCEvent.Types.ETour.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_ClearEvent"></a> ClearEvent\(\)

```csharp
public void ClearEvent()
```

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_ClearEventName"></a> ClearEventName\(\)

```csharp
public void ClearEventName()
```

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_ClearEventType"></a> ClearEventType\(\)

```csharp
public void ClearEventType()
```

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_ClearIsEventCompleted"></a> ClearIsEventCompleted\(\)

```csharp
public void ClearIsEventCompleted()
```

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_ClearIsEventUpcoming"></a> ClearIsEventUpcoming\(\)

```csharp
public void ClearIsEventUpcoming()
```

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_ClearIsFantasyEnabled"></a> ClearIsFantasyEnabled\(\)

```csharp
public void ClearIsFantasyEnabled()
```

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_ClearMulticastLeagueId"></a> ClearMulticastLeagueId\(\)

```csharp
public void ClearMulticastLeagueId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_ClearRegistrationPeriod"></a> ClearRegistrationPeriod\(\)

```csharp
public void ClearRegistrationPeriod()
```

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_ClearTimestampAddLock"></a> ClearTimestampAddLock\(\)

```csharp
public void ClearTimestampAddLock()
```

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_ClearTimestampContentDeadline"></a> ClearTimestampContentDeadline\(\)

```csharp
public void ClearTimestampContentDeadline()
```

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_ClearTimestampContentReviewDeadline"></a> ClearTimestampContentReviewDeadline\(\)

```csharp
public void ClearTimestampContentReviewDeadline()
```

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_ClearTimestampDropLock"></a> ClearTimestampDropLock\(\)

```csharp
public void ClearTimestampDropLock()
```

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_ClearTour"></a> ClearTour\(\)

```csharp
public void ClearTour()
```

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_Clone"></a> Clone\(\)

```csharp
public CMsgDPCEvent Clone()
```

#### Returns

 [CMsgDPCEvent](Divine.Protobufs.Dota2.CMsgDPCEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_Equals_Divine_Protobufs_Dota2_CMsgDPCEvent_"></a> Equals\(CMsgDPCEvent\)

```csharp
public bool Equals(CMsgDPCEvent other)
```

#### Parameters

`other` [CMsgDPCEvent](Divine.Protobufs.Dota2.CMsgDPCEvent.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_MergeFrom_Divine_Protobufs_Dota2_CMsgDPCEvent_"></a> MergeFrom\(CMsgDPCEvent\)

```csharp
public void MergeFrom(CMsgDPCEvent other)
```

#### Parameters

`other` [CMsgDPCEvent](Divine.Protobufs.Dota2.CMsgDPCEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

