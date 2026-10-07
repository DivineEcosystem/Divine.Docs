# <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEvent"></a> Class CMsgSource1LegacyGameEvent

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSource1LegacyGameEvent : IMessage<CMsgSource1LegacyGameEvent>, IEquatable<CMsgSource1LegacyGameEvent>, IDeepCloneable<CMsgSource1LegacyGameEvent>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSource1LegacyGameEvent](Divine.Protobufs.Dota2.CMsgSource1LegacyGameEvent.md)

#### Implements

IMessage<CMsgSource1LegacyGameEvent\>, 
[IEquatable<CMsgSource1LegacyGameEvent\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSource1LegacyGameEvent\>, 
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
[EnumerableExtensions.In<CMsgSource1LegacyGameEvent\>\(CMsgSource1LegacyGameEvent, params CMsgSource1LegacyGameEvent\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEvent__ctor"></a> CMsgSource1LegacyGameEvent\(\)

```csharp
public CMsgSource1LegacyGameEvent()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEvent__ctor_Divine_Protobufs_Dota2_CMsgSource1LegacyGameEvent_"></a> CMsgSource1LegacyGameEvent\(CMsgSource1LegacyGameEvent\)

```csharp
public CMsgSource1LegacyGameEvent(CMsgSource1LegacyGameEvent other)
```

#### Parameters

`other` [CMsgSource1LegacyGameEvent](Divine.Protobufs.Dota2.CMsgSource1LegacyGameEvent.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEvent_EventidFieldNumber"></a> EventidFieldNumber

```csharp
public const int EventidFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEvent_EventNameFieldNumber"></a> EventNameFieldNumber

```csharp
public const int EventNameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEvent_KeysFieldNumber"></a> KeysFieldNumber

```csharp
public const int KeysFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEvent_PassthroughFieldNumber"></a> PassthroughFieldNumber

```csharp
public const int PassthroughFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEvent_ServerTickFieldNumber"></a> ServerTickFieldNumber

```csharp
public const int ServerTickFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEvent_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEvent_Eventid"></a> Eventid

```csharp
public int Eventid { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEvent_EventName"></a> EventName

```csharp
public string EventName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEvent_HasEventid"></a> HasEventid

```csharp
public bool HasEventid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEvent_HasEventName"></a> HasEventName

```csharp
public bool HasEventName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEvent_HasPassthrough"></a> HasPassthrough

```csharp
public bool HasPassthrough { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEvent_HasServerTick"></a> HasServerTick

```csharp
public bool HasServerTick { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEvent_Keys"></a> Keys

```csharp
public RepeatedField<CMsgSource1LegacyGameEvent.Types.key_t> Keys { get; }
```

#### Property Value

 RepeatedField<[CMsgSource1LegacyGameEvent](Divine.Protobufs.Dota2.CMsgSource1LegacyGameEvent.md).[Types](Divine.Protobufs.Dota2.CMsgSource1LegacyGameEvent.Types.md).[key\_t](Divine.Protobufs.Dota2.CMsgSource1LegacyGameEvent.Types.key\_t.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEvent_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSource1LegacyGameEvent> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSource1LegacyGameEvent](Divine.Protobufs.Dota2.CMsgSource1LegacyGameEvent.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEvent_Passthrough"></a> Passthrough

```csharp
public int Passthrough { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEvent_ServerTick"></a> ServerTick

```csharp
public int ServerTick { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEvent_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEvent_ClearEventid"></a> ClearEventid\(\)

```csharp
public void ClearEventid()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEvent_ClearEventName"></a> ClearEventName\(\)

```csharp
public void ClearEventName()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEvent_ClearPassthrough"></a> ClearPassthrough\(\)

```csharp
public void ClearPassthrough()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEvent_ClearServerTick"></a> ClearServerTick\(\)

```csharp
public void ClearServerTick()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEvent_Clone"></a> Clone\(\)

```csharp
public CMsgSource1LegacyGameEvent Clone()
```

#### Returns

 [CMsgSource1LegacyGameEvent](Divine.Protobufs.Dota2.CMsgSource1LegacyGameEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEvent_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEvent_Equals_Divine_Protobufs_Dota2_CMsgSource1LegacyGameEvent_"></a> Equals\(CMsgSource1LegacyGameEvent\)

```csharp
public bool Equals(CMsgSource1LegacyGameEvent other)
```

#### Parameters

`other` [CMsgSource1LegacyGameEvent](Divine.Protobufs.Dota2.CMsgSource1LegacyGameEvent.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEvent_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEvent_MergeFrom_Divine_Protobufs_Dota2_CMsgSource1LegacyGameEvent_"></a> MergeFrom\(CMsgSource1LegacyGameEvent\)

```csharp
public void MergeFrom(CMsgSource1LegacyGameEvent other)
```

#### Parameters

`other` [CMsgSource1LegacyGameEvent](Divine.Protobufs.Dota2.CMsgSource1LegacyGameEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEvent_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEvent_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyGameEvent_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

