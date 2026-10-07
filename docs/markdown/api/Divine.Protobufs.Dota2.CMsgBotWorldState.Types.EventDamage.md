# <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventDamage"></a> Class CMsgBotWorldState.Types.EventDamage

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgBotWorldState.Types.EventDamage : IMessage<CMsgBotWorldState.Types.EventDamage>, IEquatable<CMsgBotWorldState.Types.EventDamage>, IDeepCloneable<CMsgBotWorldState.Types.EventDamage>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgBotWorldState.Types.EventDamage](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.EventDamage.md)

#### Implements

IMessage<CMsgBotWorldState.Types.EventDamage\>, 
[IEquatable<CMsgBotWorldState.Types.EventDamage\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgBotWorldState.Types.EventDamage\>, 
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
[EnumerableExtensions.In<CMsgBotWorldState.Types.EventDamage\>\(CMsgBotWorldState.Types.EventDamage, params CMsgBotWorldState.Types.EventDamage\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventDamage__ctor"></a> EventDamage\(\)

```csharp
public EventDamage()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventDamage__ctor_Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventDamage_"></a> EventDamage\(EventDamage\)

```csharp
public EventDamage(CMsgBotWorldState.Types.EventDamage other)
```

#### Parameters

`other` [CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[EventDamage](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.EventDamage.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventDamage_AbilityIdFieldNumber"></a> AbilityIdFieldNumber

```csharp
public const int AbilityIdFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventDamage_AttackerPlayerIdFieldNumber"></a> AttackerPlayerIdFieldNumber

```csharp
public const int AttackerPlayerIdFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventDamage_AttackerUnitHandleFieldNumber"></a> AttackerUnitHandleFieldNumber

```csharp
public const int AttackerUnitHandleFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventDamage_DamageFieldNumber"></a> DamageFieldNumber

```csharp
public const int DamageFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventDamage_VictimPlayerIdFieldNumber"></a> VictimPlayerIdFieldNumber

```csharp
public const int VictimPlayerIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventDamage_VictimUnitHandleFieldNumber"></a> VictimUnitHandleFieldNumber

```csharp
public const int VictimUnitHandleFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventDamage_AbilityId"></a> AbilityId

```csharp
public int AbilityId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventDamage_AttackerPlayerId"></a> AttackerPlayerId

```csharp
public int AttackerPlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventDamage_AttackerUnitHandle"></a> AttackerUnitHandle

```csharp
public uint AttackerUnitHandle { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventDamage_Damage"></a> Damage

```csharp
public uint Damage { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventDamage_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventDamage_HasAbilityId"></a> HasAbilityId

```csharp
public bool HasAbilityId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventDamage_HasAttackerPlayerId"></a> HasAttackerPlayerId

```csharp
public bool HasAttackerPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventDamage_HasAttackerUnitHandle"></a> HasAttackerUnitHandle

```csharp
public bool HasAttackerUnitHandle { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventDamage_HasDamage"></a> HasDamage

```csharp
public bool HasDamage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventDamage_HasVictimPlayerId"></a> HasVictimPlayerId

```csharp
public bool HasVictimPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventDamage_HasVictimUnitHandle"></a> HasVictimUnitHandle

```csharp
public bool HasVictimUnitHandle { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventDamage_Parser"></a> Parser

```csharp
public static MessageParser<CMsgBotWorldState.Types.EventDamage> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[EventDamage](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.EventDamage.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventDamage_VictimPlayerId"></a> VictimPlayerId

```csharp
public int VictimPlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventDamage_VictimUnitHandle"></a> VictimUnitHandle

```csharp
public uint VictimUnitHandle { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventDamage_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventDamage_ClearAbilityId"></a> ClearAbilityId\(\)

```csharp
public void ClearAbilityId()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventDamage_ClearAttackerPlayerId"></a> ClearAttackerPlayerId\(\)

```csharp
public void ClearAttackerPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventDamage_ClearAttackerUnitHandle"></a> ClearAttackerUnitHandle\(\)

```csharp
public void ClearAttackerUnitHandle()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventDamage_ClearDamage"></a> ClearDamage\(\)

```csharp
public void ClearDamage()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventDamage_ClearVictimPlayerId"></a> ClearVictimPlayerId\(\)

```csharp
public void ClearVictimPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventDamage_ClearVictimUnitHandle"></a> ClearVictimUnitHandle\(\)

```csharp
public void ClearVictimUnitHandle()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventDamage_Clone"></a> Clone\(\)

```csharp
public CMsgBotWorldState.Types.EventDamage Clone()
```

#### Returns

 [CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[EventDamage](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.EventDamage.md)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventDamage_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventDamage_Equals_Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventDamage_"></a> Equals\(EventDamage\)

```csharp
public bool Equals(CMsgBotWorldState.Types.EventDamage other)
```

#### Parameters

`other` [CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[EventDamage](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.EventDamage.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventDamage_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventDamage_MergeFrom_Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventDamage_"></a> MergeFrom\(EventDamage\)

```csharp
public void MergeFrom(CMsgBotWorldState.Types.EventDamage other)
```

#### Parameters

`other` [CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[EventDamage](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.EventDamage.md)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventDamage_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventDamage_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventDamage_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

