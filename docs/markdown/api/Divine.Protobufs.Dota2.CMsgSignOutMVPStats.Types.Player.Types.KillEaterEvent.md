# <a id="Divine_Protobufs_Dota2_CMsgSignOutMVPStats_Types_Player_Types_KillEaterEvent"></a> Class CMsgSignOutMVPStats.Types.Player.Types.KillEaterEvent

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSignOutMVPStats.Types.Player.Types.KillEaterEvent : IMessage<CMsgSignOutMVPStats.Types.Player.Types.KillEaterEvent>, IEquatable<CMsgSignOutMVPStats.Types.Player.Types.KillEaterEvent>, IDeepCloneable<CMsgSignOutMVPStats.Types.Player.Types.KillEaterEvent>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSignOutMVPStats.Types.Player.Types.KillEaterEvent](Divine.Protobufs.Dota2.CMsgSignOutMVPStats.Types.Player.Types.KillEaterEvent.md)

#### Implements

IMessage<CMsgSignOutMVPStats.Types.Player.Types.KillEaterEvent\>, 
[IEquatable<CMsgSignOutMVPStats.Types.Player.Types.KillEaterEvent\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSignOutMVPStats.Types.Player.Types.KillEaterEvent\>, 
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
[EnumerableExtensions.In<CMsgSignOutMVPStats.Types.Player.Types.KillEaterEvent\>\(CMsgSignOutMVPStats.Types.Player.Types.KillEaterEvent, params CMsgSignOutMVPStats.Types.Player.Types.KillEaterEvent\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMVPStats_Types_Player_Types_KillEaterEvent__ctor"></a> KillEaterEvent\(\)

```csharp
public KillEaterEvent()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMVPStats_Types_Player_Types_KillEaterEvent__ctor_Divine_Protobufs_Dota2_CMsgSignOutMVPStats_Types_Player_Types_KillEaterEvent_"></a> KillEaterEvent\(KillEaterEvent\)

```csharp
public KillEaterEvent(CMsgSignOutMVPStats.Types.Player.Types.KillEaterEvent other)
```

#### Parameters

`other` [CMsgSignOutMVPStats](Divine.Protobufs.Dota2.CMsgSignOutMVPStats.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutMVPStats.Types.md).[Player](Divine.Protobufs.Dota2.CMsgSignOutMVPStats.Types.Player.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutMVPStats.Types.Player.Types.md).[KillEaterEvent](Divine.Protobufs.Dota2.CMsgSignOutMVPStats.Types.Player.Types.KillEaterEvent.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMVPStats_Types_Player_Types_KillEaterEvent_AmountFieldNumber"></a> AmountFieldNumber

```csharp
public const int AmountFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMVPStats_Types_Player_Types_KillEaterEvent_EventTypeFieldNumber"></a> EventTypeFieldNumber

```csharp
public const int EventTypeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMVPStats_Types_Player_Types_KillEaterEvent_Amount"></a> Amount

```csharp
public uint Amount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMVPStats_Types_Player_Types_KillEaterEvent_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMVPStats_Types_Player_Types_KillEaterEvent_EventType"></a> EventType

```csharp
public uint EventType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMVPStats_Types_Player_Types_KillEaterEvent_HasAmount"></a> HasAmount

```csharp
public bool HasAmount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMVPStats_Types_Player_Types_KillEaterEvent_HasEventType"></a> HasEventType

```csharp
public bool HasEventType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMVPStats_Types_Player_Types_KillEaterEvent_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSignOutMVPStats.Types.Player.Types.KillEaterEvent> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSignOutMVPStats](Divine.Protobufs.Dota2.CMsgSignOutMVPStats.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutMVPStats.Types.md).[Player](Divine.Protobufs.Dota2.CMsgSignOutMVPStats.Types.Player.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutMVPStats.Types.Player.Types.md).[KillEaterEvent](Divine.Protobufs.Dota2.CMsgSignOutMVPStats.Types.Player.Types.KillEaterEvent.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMVPStats_Types_Player_Types_KillEaterEvent_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMVPStats_Types_Player_Types_KillEaterEvent_ClearAmount"></a> ClearAmount\(\)

```csharp
public void ClearAmount()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMVPStats_Types_Player_Types_KillEaterEvent_ClearEventType"></a> ClearEventType\(\)

```csharp
public void ClearEventType()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMVPStats_Types_Player_Types_KillEaterEvent_Clone"></a> Clone\(\)

```csharp
public CMsgSignOutMVPStats.Types.Player.Types.KillEaterEvent Clone()
```

#### Returns

 [CMsgSignOutMVPStats](Divine.Protobufs.Dota2.CMsgSignOutMVPStats.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutMVPStats.Types.md).[Player](Divine.Protobufs.Dota2.CMsgSignOutMVPStats.Types.Player.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutMVPStats.Types.Player.Types.md).[KillEaterEvent](Divine.Protobufs.Dota2.CMsgSignOutMVPStats.Types.Player.Types.KillEaterEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMVPStats_Types_Player_Types_KillEaterEvent_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMVPStats_Types_Player_Types_KillEaterEvent_Equals_Divine_Protobufs_Dota2_CMsgSignOutMVPStats_Types_Player_Types_KillEaterEvent_"></a> Equals\(KillEaterEvent\)

```csharp
public bool Equals(CMsgSignOutMVPStats.Types.Player.Types.KillEaterEvent other)
```

#### Parameters

`other` [CMsgSignOutMVPStats](Divine.Protobufs.Dota2.CMsgSignOutMVPStats.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutMVPStats.Types.md).[Player](Divine.Protobufs.Dota2.CMsgSignOutMVPStats.Types.Player.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutMVPStats.Types.Player.Types.md).[KillEaterEvent](Divine.Protobufs.Dota2.CMsgSignOutMVPStats.Types.Player.Types.KillEaterEvent.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMVPStats_Types_Player_Types_KillEaterEvent_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMVPStats_Types_Player_Types_KillEaterEvent_MergeFrom_Divine_Protobufs_Dota2_CMsgSignOutMVPStats_Types_Player_Types_KillEaterEvent_"></a> MergeFrom\(KillEaterEvent\)

```csharp
public void MergeFrom(CMsgSignOutMVPStats.Types.Player.Types.KillEaterEvent other)
```

#### Parameters

`other` [CMsgSignOutMVPStats](Divine.Protobufs.Dota2.CMsgSignOutMVPStats.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutMVPStats.Types.md).[Player](Divine.Protobufs.Dota2.CMsgSignOutMVPStats.Types.Player.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutMVPStats.Types.Player.Types.md).[KillEaterEvent](Divine.Protobufs.Dota2.CMsgSignOutMVPStats.Types.Player.Types.KillEaterEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMVPStats_Types_Player_Types_KillEaterEvent_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMVPStats_Types_Player_Types_KillEaterEvent_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMVPStats_Types_Player_Types_KillEaterEvent_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

