# <a id="Divine_Protobufs_Dota2_CMsgItemBattlerFightEvent"></a> Class CMsgItemBattlerFightEvent

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgItemBattlerFightEvent : IMessage<CMsgItemBattlerFightEvent>, IEquatable<CMsgItemBattlerFightEvent>, IDeepCloneable<CMsgItemBattlerFightEvent>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgItemBattlerFightEvent](Divine.Protobufs.Dota2.CMsgItemBattlerFightEvent.md)

#### Implements

IMessage<CMsgItemBattlerFightEvent\>, 
[IEquatable<CMsgItemBattlerFightEvent\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgItemBattlerFightEvent\>, 
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
[EnumerableExtensions.In<CMsgItemBattlerFightEvent\>\(CMsgItemBattlerFightEvent, params CMsgItemBattlerFightEvent\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerFightEvent__ctor"></a> CMsgItemBattlerFightEvent\(\)

```csharp
public CMsgItemBattlerFightEvent()
```

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerFightEvent__ctor_Divine_Protobufs_Dota2_CMsgItemBattlerFightEvent_"></a> CMsgItemBattlerFightEvent\(CMsgItemBattlerFightEvent\)

```csharp
public CMsgItemBattlerFightEvent(CMsgItemBattlerFightEvent other)
```

#### Parameters

`other` [CMsgItemBattlerFightEvent](Divine.Protobufs.Dota2.CMsgItemBattlerFightEvent.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerFightEvent_CriticalFieldNumber"></a> CriticalFieldNumber

```csharp
public const int CriticalFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerFightEvent_EffectFieldNumber"></a> EffectFieldNumber

```csharp
public const int EffectFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerFightEvent_ItemInstanceIdFieldNumber"></a> ItemInstanceIdFieldNumber

```csharp
public const int ItemInstanceIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerFightEvent_ItemTargetInstanceIdsFieldNumber"></a> ItemTargetInstanceIdsFieldNumber

```csharp
public const int ItemTargetInstanceIdsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerFightEvent_LifestealHealingFieldNumber"></a> LifestealHealingFieldNumber

```csharp
public const int LifestealHealingFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerFightEvent_TickFieldNumber"></a> TickFieldNumber

```csharp
public const int TickFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerFightEvent_ValueFieldNumber"></a> ValueFieldNumber

```csharp
public const int ValueFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerFightEvent_Critical"></a> Critical

```csharp
public bool Critical { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerFightEvent_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerFightEvent_Effect"></a> Effect

```csharp
public uint Effect { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerFightEvent_HasCritical"></a> HasCritical

```csharp
public bool HasCritical { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerFightEvent_HasEffect"></a> HasEffect

```csharp
public bool HasEffect { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerFightEvent_HasItemInstanceId"></a> HasItemInstanceId

```csharp
public bool HasItemInstanceId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerFightEvent_HasLifestealHealing"></a> HasLifestealHealing

```csharp
public bool HasLifestealHealing { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerFightEvent_HasTick"></a> HasTick

```csharp
public bool HasTick { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerFightEvent_HasValue"></a> HasValue

```csharp
public bool HasValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerFightEvent_ItemInstanceId"></a> ItemInstanceId

```csharp
public uint ItemInstanceId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerFightEvent_ItemTargetInstanceIds"></a> ItemTargetInstanceIds

```csharp
public RepeatedField<uint> ItemTargetInstanceIds { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerFightEvent_LifestealHealing"></a> LifestealHealing

```csharp
public uint LifestealHealing { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerFightEvent_Parser"></a> Parser

```csharp
public static MessageParser<CMsgItemBattlerFightEvent> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgItemBattlerFightEvent](Divine.Protobufs.Dota2.CMsgItemBattlerFightEvent.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerFightEvent_Tick"></a> Tick

```csharp
public uint Tick { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerFightEvent_Value"></a> Value

```csharp
public int Value { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerFightEvent_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerFightEvent_ClearCritical"></a> ClearCritical\(\)

```csharp
public void ClearCritical()
```

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerFightEvent_ClearEffect"></a> ClearEffect\(\)

```csharp
public void ClearEffect()
```

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerFightEvent_ClearItemInstanceId"></a> ClearItemInstanceId\(\)

```csharp
public void ClearItemInstanceId()
```

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerFightEvent_ClearLifestealHealing"></a> ClearLifestealHealing\(\)

```csharp
public void ClearLifestealHealing()
```

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerFightEvent_ClearTick"></a> ClearTick\(\)

```csharp
public void ClearTick()
```

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerFightEvent_ClearValue"></a> ClearValue\(\)

```csharp
public void ClearValue()
```

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerFightEvent_Clone"></a> Clone\(\)

```csharp
public CMsgItemBattlerFightEvent Clone()
```

#### Returns

 [CMsgItemBattlerFightEvent](Divine.Protobufs.Dota2.CMsgItemBattlerFightEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerFightEvent_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerFightEvent_Equals_Divine_Protobufs_Dota2_CMsgItemBattlerFightEvent_"></a> Equals\(CMsgItemBattlerFightEvent\)

```csharp
public bool Equals(CMsgItemBattlerFightEvent other)
```

#### Parameters

`other` [CMsgItemBattlerFightEvent](Divine.Protobufs.Dota2.CMsgItemBattlerFightEvent.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerFightEvent_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerFightEvent_MergeFrom_Divine_Protobufs_Dota2_CMsgItemBattlerFightEvent_"></a> MergeFrom\(CMsgItemBattlerFightEvent\)

```csharp
public void MergeFrom(CMsgItemBattlerFightEvent other)
```

#### Parameters

`other` [CMsgItemBattlerFightEvent](Divine.Protobufs.Dota2.CMsgItemBattlerFightEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerFightEvent_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerFightEvent_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerFightEvent_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

