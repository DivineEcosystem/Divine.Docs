# <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Player_Types_CombatSegment"></a> Class CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.CombatSegment

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.CombatSegment : IMessage<CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.CombatSegment>, IEquatable<CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.CombatSegment>, IDeepCloneable<CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.CombatSegment>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.CombatSegment](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.CombatSegment.md)

#### Implements

IMessage<CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.CombatSegment\>, 
[IEquatable<CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.CombatSegment\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.CombatSegment\>, 
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
[EnumerableExtensions.In<CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.CombatSegment\>\(CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.CombatSegment, params CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.CombatSegment\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Player_Types_CombatSegment__ctor"></a> CombatSegment\(\)

```csharp
public CombatSegment()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Player_Types_CombatSegment__ctor_Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Player_Types_CombatSegment_"></a> CombatSegment\(CombatSegment\)

```csharp
public CombatSegment(CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.CombatSegment other)
```

#### Parameters

`other` [CDOTAMatchPrivateMetadata](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.md).[Team](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.md).[Player](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.Player.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.md).[CombatSegment](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.CombatSegment.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Player_Types_CombatSegment_DamageByAbilityFieldNumber"></a> DamageByAbilityFieldNumber

```csharp
public const int DamageByAbilityFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Player_Types_CombatSegment_GameTimeFieldNumber"></a> GameTimeFieldNumber

```csharp
public const int GameTimeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Player_Types_CombatSegment_HealingByAbilityFieldNumber"></a> HealingByAbilityFieldNumber

```csharp
public const int HealingByAbilityFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Player_Types_CombatSegment_DamageByAbility"></a> DamageByAbility

```csharp
public RepeatedField<CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.CombatSegment.Types.DamageByAbility> DamageByAbility { get; }
```

#### Property Value

 RepeatedField<[CDOTAMatchPrivateMetadata](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.md).[Team](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.md).[Player](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.Player.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.md).[CombatSegment](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.CombatSegment.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.CombatSegment.Types.md).[DamageByAbility](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.CombatSegment.Types.DamageByAbility.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Player_Types_CombatSegment_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Player_Types_CombatSegment_GameTime"></a> GameTime

```csharp
public int GameTime { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Player_Types_CombatSegment_HasGameTime"></a> HasGameTime

```csharp
public bool HasGameTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Player_Types_CombatSegment_HealingByAbility"></a> HealingByAbility

```csharp
public RepeatedField<CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.CombatSegment.Types.HealingByAbility> HealingByAbility { get; }
```

#### Property Value

 RepeatedField<[CDOTAMatchPrivateMetadata](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.md).[Team](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.md).[Player](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.Player.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.md).[CombatSegment](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.CombatSegment.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.CombatSegment.Types.md).[HealingByAbility](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.CombatSegment.Types.HealingByAbility.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Player_Types_CombatSegment_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.CombatSegment> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAMatchPrivateMetadata](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.md).[Team](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.md).[Player](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.Player.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.md).[CombatSegment](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.CombatSegment.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Player_Types_CombatSegment_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Player_Types_CombatSegment_ClearGameTime"></a> ClearGameTime\(\)

```csharp
public void ClearGameTime()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Player_Types_CombatSegment_Clone"></a> Clone\(\)

```csharp
public CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.CombatSegment Clone()
```

#### Returns

 [CDOTAMatchPrivateMetadata](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.md).[Team](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.md).[Player](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.Player.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.md).[CombatSegment](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.CombatSegment.md)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Player_Types_CombatSegment_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Player_Types_CombatSegment_Equals_Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Player_Types_CombatSegment_"></a> Equals\(CombatSegment\)

```csharp
public bool Equals(CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.CombatSegment other)
```

#### Parameters

`other` [CDOTAMatchPrivateMetadata](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.md).[Team](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.md).[Player](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.Player.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.md).[CombatSegment](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.CombatSegment.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Player_Types_CombatSegment_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Player_Types_CombatSegment_MergeFrom_Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Player_Types_CombatSegment_"></a> MergeFrom\(CombatSegment\)

```csharp
public void MergeFrom(CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.CombatSegment other)
```

#### Parameters

`other` [CDOTAMatchPrivateMetadata](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.md).[Team](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.md).[Player](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.Player.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.md).[CombatSegment](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.Player.Types.CombatSegment.md)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Player_Types_CombatSegment_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Player_Types_CombatSegment_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Types_Player_Types_CombatSegment_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

