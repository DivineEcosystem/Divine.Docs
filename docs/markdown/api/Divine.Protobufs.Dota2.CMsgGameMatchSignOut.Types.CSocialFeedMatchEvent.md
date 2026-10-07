# <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CSocialFeedMatchEvent"></a> Class CMsgGameMatchSignOut.Types.CSocialFeedMatchEvent

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGameMatchSignOut.Types.CSocialFeedMatchEvent : IMessage<CMsgGameMatchSignOut.Types.CSocialFeedMatchEvent>, IEquatable<CMsgGameMatchSignOut.Types.CSocialFeedMatchEvent>, IDeepCloneable<CMsgGameMatchSignOut.Types.CSocialFeedMatchEvent>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGameMatchSignOut.Types.CSocialFeedMatchEvent](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.CSocialFeedMatchEvent.md)

#### Implements

IMessage<CMsgGameMatchSignOut.Types.CSocialFeedMatchEvent\>, 
[IEquatable<CMsgGameMatchSignOut.Types.CSocialFeedMatchEvent\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGameMatchSignOut.Types.CSocialFeedMatchEvent\>, 
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
[EnumerableExtensions.In<CMsgGameMatchSignOut.Types.CSocialFeedMatchEvent\>\(CMsgGameMatchSignOut.Types.CSocialFeedMatchEvent, params CMsgGameMatchSignOut.Types.CSocialFeedMatchEvent\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CSocialFeedMatchEvent__ctor"></a> CSocialFeedMatchEvent\(\)

```csharp
public CSocialFeedMatchEvent()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CSocialFeedMatchEvent__ctor_Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CSocialFeedMatchEvent_"></a> CSocialFeedMatchEvent\(CSocialFeedMatchEvent\)

```csharp
public CSocialFeedMatchEvent(CMsgGameMatchSignOut.Types.CSocialFeedMatchEvent other)
```

#### Parameters

`other` [CMsgGameMatchSignOut](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.md).[Types](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.md).[CSocialFeedMatchEvent](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.CSocialFeedMatchEvent.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CSocialFeedMatchEvent_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CSocialFeedMatchEvent_EventTypeFieldNumber"></a> EventTypeFieldNumber

```csharp
public const int EventTypeFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CSocialFeedMatchEvent_GameTimeFieldNumber"></a> GameTimeFieldNumber

```csharp
public const int GameTimeFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CSocialFeedMatchEvent_TimestampFieldNumber"></a> TimestampFieldNumber

```csharp
public const int TimestampFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CSocialFeedMatchEvent_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CSocialFeedMatchEvent_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CSocialFeedMatchEvent_EventType"></a> EventType

```csharp
public uint EventType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CSocialFeedMatchEvent_GameTime"></a> GameTime

```csharp
public int GameTime { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CSocialFeedMatchEvent_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CSocialFeedMatchEvent_HasEventType"></a> HasEventType

```csharp
public bool HasEventType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CSocialFeedMatchEvent_HasGameTime"></a> HasGameTime

```csharp
public bool HasGameTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CSocialFeedMatchEvent_HasTimestamp"></a> HasTimestamp

```csharp
public bool HasTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CSocialFeedMatchEvent_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGameMatchSignOut.Types.CSocialFeedMatchEvent> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGameMatchSignOut](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.md).[Types](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.md).[CSocialFeedMatchEvent](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.CSocialFeedMatchEvent.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CSocialFeedMatchEvent_Timestamp"></a> Timestamp

```csharp
public uint Timestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CSocialFeedMatchEvent_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CSocialFeedMatchEvent_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CSocialFeedMatchEvent_ClearEventType"></a> ClearEventType\(\)

```csharp
public void ClearEventType()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CSocialFeedMatchEvent_ClearGameTime"></a> ClearGameTime\(\)

```csharp
public void ClearGameTime()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CSocialFeedMatchEvent_ClearTimestamp"></a> ClearTimestamp\(\)

```csharp
public void ClearTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CSocialFeedMatchEvent_Clone"></a> Clone\(\)

```csharp
public CMsgGameMatchSignOut.Types.CSocialFeedMatchEvent Clone()
```

#### Returns

 [CMsgGameMatchSignOut](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.md).[Types](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.md).[CSocialFeedMatchEvent](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.CSocialFeedMatchEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CSocialFeedMatchEvent_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CSocialFeedMatchEvent_Equals_Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CSocialFeedMatchEvent_"></a> Equals\(CSocialFeedMatchEvent\)

```csharp
public bool Equals(CMsgGameMatchSignOut.Types.CSocialFeedMatchEvent other)
```

#### Parameters

`other` [CMsgGameMatchSignOut](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.md).[Types](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.md).[CSocialFeedMatchEvent](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.CSocialFeedMatchEvent.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CSocialFeedMatchEvent_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CSocialFeedMatchEvent_MergeFrom_Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CSocialFeedMatchEvent_"></a> MergeFrom\(CSocialFeedMatchEvent\)

```csharp
public void MergeFrom(CMsgGameMatchSignOut.Types.CSocialFeedMatchEvent other)
```

#### Parameters

`other` [CMsgGameMatchSignOut](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.md).[Types](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.md).[CSocialFeedMatchEvent](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.CSocialFeedMatchEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CSocialFeedMatchEvent_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CSocialFeedMatchEvent_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CSocialFeedMatchEvent_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

