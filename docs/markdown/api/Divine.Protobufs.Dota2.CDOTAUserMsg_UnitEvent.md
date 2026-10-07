# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent"></a> Class CDOTAUserMsg\_UnitEvent

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_UnitEvent : IMessage<CDOTAUserMsg_UnitEvent>, IEquatable<CDOTAUserMsg_UnitEvent>, IDeepCloneable<CDOTAUserMsg_UnitEvent>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_UnitEvent](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.md)

#### Implements

IMessage<CDOTAUserMsg\_UnitEvent\>, 
[IEquatable<CDOTAUserMsg\_UnitEvent\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_UnitEvent\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_UnitEvent\>\(CDOTAUserMsg\_UnitEvent, params CDOTAUserMsg\_UnitEvent\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent__ctor"></a> CDOTAUserMsg\_UnitEvent\(\)

```csharp
public CDOTAUserMsg_UnitEvent()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_"></a> CDOTAUserMsg\_UnitEvent\(CDOTAUserMsg\_UnitEvent\)

```csharp
public CDOTAUserMsg_UnitEvent(CDOTAUserMsg_UnitEvent other)
```

#### Parameters

`other` [CDOTAUserMsg\_UnitEvent](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_AddGestureFieldNumber"></a> AddGestureFieldNumber

```csharp
public const int AddGestureFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_BloodImpactFieldNumber"></a> BloodImpactFieldNumber

```csharp
public const int BloodImpactFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_EntityIndexFieldNumber"></a> EntityIndexFieldNumber

```csharp
public const int EntityIndexFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_FadeGestureFieldNumber"></a> FadeGestureFieldNumber

```csharp
public const int FadeGestureFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_MsgTypeFieldNumber"></a> MsgTypeFieldNumber

```csharp
public const int MsgTypeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_RemoveGestureFieldNumber"></a> RemoveGestureFieldNumber

```csharp
public const int RemoveGestureFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_SpeechFieldNumber"></a> SpeechFieldNumber

```csharp
public const int SpeechFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_SpeechMatchOnClientFieldNumber"></a> SpeechMatchOnClientFieldNumber

```csharp
public const int SpeechMatchOnClientFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_SpeechMuteFieldNumber"></a> SpeechMuteFieldNumber

```csharp
public const int SpeechMuteFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_AddGesture"></a> AddGesture

```csharp
public CDOTAUserMsg_UnitEvent.Types.AddGesture AddGesture { get; set; }
```

#### Property Value

 [CDOTAUserMsg\_UnitEvent](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.Types.md).[AddGesture](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.Types.AddGesture.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_BloodImpact"></a> BloodImpact

```csharp
public CDOTAUserMsg_UnitEvent.Types.BloodImpact BloodImpact { get; set; }
```

#### Property Value

 [CDOTAUserMsg\_UnitEvent](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.Types.md).[BloodImpact](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.Types.BloodImpact.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_EntityIndex"></a> EntityIndex

```csharp
public int EntityIndex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_FadeGesture"></a> FadeGesture

```csharp
public CDOTAUserMsg_UnitEvent.Types.FadeGesture FadeGesture { get; set; }
```

#### Property Value

 [CDOTAUserMsg\_UnitEvent](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.Types.md).[FadeGesture](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.Types.FadeGesture.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_HasEntityIndex"></a> HasEntityIndex

```csharp
public bool HasEntityIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_HasMsgType"></a> HasMsgType

```csharp
public bool HasMsgType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_MsgType"></a> MsgType

```csharp
public EDotaEntityMessages MsgType { get; set; }
```

#### Property Value

 [EDotaEntityMessages](Divine.Protobufs.Dota2.EDotaEntityMessages.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_UnitEvent> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_UnitEvent](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_RemoveGesture"></a> RemoveGesture

```csharp
public CDOTAUserMsg_UnitEvent.Types.RemoveGesture RemoveGesture { get; set; }
```

#### Property Value

 [CDOTAUserMsg\_UnitEvent](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.Types.md).[RemoveGesture](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.Types.RemoveGesture.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Speech"></a> Speech

```csharp
public CDOTAUserMsg_UnitEvent.Types.Speech Speech { get; set; }
```

#### Property Value

 [CDOTAUserMsg\_UnitEvent](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.Types.md).[Speech](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.Types.Speech.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_SpeechMatchOnClient"></a> SpeechMatchOnClient

```csharp
public CDOTASpeechMatchOnClient SpeechMatchOnClient { get; set; }
```

#### Property Value

 [CDOTASpeechMatchOnClient](Divine.Protobufs.Dota2.CDOTASpeechMatchOnClient.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_SpeechMute"></a> SpeechMute

```csharp
public CDOTAUserMsg_UnitEvent.Types.SpeechMute SpeechMute { get; set; }
```

#### Property Value

 [CDOTAUserMsg\_UnitEvent](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.Types.md).[SpeechMute](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.Types.SpeechMute.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_ClearEntityIndex"></a> ClearEntityIndex\(\)

```csharp
public void ClearEntityIndex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_ClearMsgType"></a> ClearMsgType\(\)

```csharp
public void ClearMsgType()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_UnitEvent Clone()
```

#### Returns

 [CDOTAUserMsg\_UnitEvent](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_"></a> Equals\(CDOTAUserMsg\_UnitEvent\)

```csharp
public bool Equals(CDOTAUserMsg_UnitEvent other)
```

#### Parameters

`other` [CDOTAUserMsg\_UnitEvent](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_"></a> MergeFrom\(CDOTAUserMsg\_UnitEvent\)

```csharp
public void MergeFrom(CDOTAUserMsg_UnitEvent other)
```

#### Parameters

`other` [CDOTAUserMsg\_UnitEvent](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

