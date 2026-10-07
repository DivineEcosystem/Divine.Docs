# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_Types_Attacker_Types_Ability"></a> Class CDOTAUserMsg\_MiniKillCamInfo.Types.Attacker.Types.Ability

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_MiniKillCamInfo.Types.Attacker.Types.Ability : IMessage<CDOTAUserMsg_MiniKillCamInfo.Types.Attacker.Types.Ability>, IEquatable<CDOTAUserMsg_MiniKillCamInfo.Types.Attacker.Types.Ability>, IDeepCloneable<CDOTAUserMsg_MiniKillCamInfo.Types.Attacker.Types.Ability>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_MiniKillCamInfo.Types.Attacker.Types.Ability](Divine.Protobufs.Dota2.CDOTAUserMsg\_MiniKillCamInfo.Types.Attacker.Types.Ability.md)

#### Implements

IMessage<CDOTAUserMsg\_MiniKillCamInfo.Types.Attacker.Types.Ability\>, 
[IEquatable<CDOTAUserMsg\_MiniKillCamInfo.Types.Attacker.Types.Ability\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_MiniKillCamInfo.Types.Attacker.Types.Ability\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_MiniKillCamInfo.Types.Attacker.Types.Ability\>\(CDOTAUserMsg\_MiniKillCamInfo.Types.Attacker.Types.Ability, params CDOTAUserMsg\_MiniKillCamInfo.Types.Attacker.Types.Ability\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_Types_Attacker_Types_Ability__ctor"></a> Ability\(\)

```csharp
public Ability()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_Types_Attacker_Types_Ability__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_Types_Attacker_Types_Ability_"></a> Ability\(Ability\)

```csharp
public Ability(CDOTAUserMsg_MiniKillCamInfo.Types.Attacker.Types.Ability other)
```

#### Parameters

`other` [CDOTAUserMsg\_MiniKillCamInfo](Divine.Protobufs.Dota2.CDOTAUserMsg\_MiniKillCamInfo.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_MiniKillCamInfo.Types.md).[Attacker](Divine.Protobufs.Dota2.CDOTAUserMsg\_MiniKillCamInfo.Types.Attacker.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_MiniKillCamInfo.Types.Attacker.Types.md).[Ability](Divine.Protobufs.Dota2.CDOTAUserMsg\_MiniKillCamInfo.Types.Attacker.Types.Ability.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_Types_Attacker_Types_Ability_AbilityIdFieldNumber"></a> AbilityIdFieldNumber

```csharp
public const int AbilityIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_Types_Attacker_Types_Ability_DamageFieldNumber"></a> DamageFieldNumber

```csharp
public const int DamageFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_Types_Attacker_Types_Ability_AbilityId"></a> AbilityId

```csharp
public int AbilityId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_Types_Attacker_Types_Ability_Damage"></a> Damage

```csharp
public int Damage { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_Types_Attacker_Types_Ability_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_Types_Attacker_Types_Ability_HasAbilityId"></a> HasAbilityId

```csharp
public bool HasAbilityId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_Types_Attacker_Types_Ability_HasDamage"></a> HasDamage

```csharp
public bool HasDamage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_Types_Attacker_Types_Ability_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_MiniKillCamInfo.Types.Attacker.Types.Ability> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_MiniKillCamInfo](Divine.Protobufs.Dota2.CDOTAUserMsg\_MiniKillCamInfo.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_MiniKillCamInfo.Types.md).[Attacker](Divine.Protobufs.Dota2.CDOTAUserMsg\_MiniKillCamInfo.Types.Attacker.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_MiniKillCamInfo.Types.Attacker.Types.md).[Ability](Divine.Protobufs.Dota2.CDOTAUserMsg\_MiniKillCamInfo.Types.Attacker.Types.Ability.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_Types_Attacker_Types_Ability_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_Types_Attacker_Types_Ability_ClearAbilityId"></a> ClearAbilityId\(\)

```csharp
public void ClearAbilityId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_Types_Attacker_Types_Ability_ClearDamage"></a> ClearDamage\(\)

```csharp
public void ClearDamage()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_Types_Attacker_Types_Ability_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_MiniKillCamInfo.Types.Attacker.Types.Ability Clone()
```

#### Returns

 [CDOTAUserMsg\_MiniKillCamInfo](Divine.Protobufs.Dota2.CDOTAUserMsg\_MiniKillCamInfo.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_MiniKillCamInfo.Types.md).[Attacker](Divine.Protobufs.Dota2.CDOTAUserMsg\_MiniKillCamInfo.Types.Attacker.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_MiniKillCamInfo.Types.Attacker.Types.md).[Ability](Divine.Protobufs.Dota2.CDOTAUserMsg\_MiniKillCamInfo.Types.Attacker.Types.Ability.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_Types_Attacker_Types_Ability_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_Types_Attacker_Types_Ability_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_Types_Attacker_Types_Ability_"></a> Equals\(Ability\)

```csharp
public bool Equals(CDOTAUserMsg_MiniKillCamInfo.Types.Attacker.Types.Ability other)
```

#### Parameters

`other` [CDOTAUserMsg\_MiniKillCamInfo](Divine.Protobufs.Dota2.CDOTAUserMsg\_MiniKillCamInfo.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_MiniKillCamInfo.Types.md).[Attacker](Divine.Protobufs.Dota2.CDOTAUserMsg\_MiniKillCamInfo.Types.Attacker.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_MiniKillCamInfo.Types.Attacker.Types.md).[Ability](Divine.Protobufs.Dota2.CDOTAUserMsg\_MiniKillCamInfo.Types.Attacker.Types.Ability.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_Types_Attacker_Types_Ability_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_Types_Attacker_Types_Ability_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_Types_Attacker_Types_Ability_"></a> MergeFrom\(Ability\)

```csharp
public void MergeFrom(CDOTAUserMsg_MiniKillCamInfo.Types.Attacker.Types.Ability other)
```

#### Parameters

`other` [CDOTAUserMsg\_MiniKillCamInfo](Divine.Protobufs.Dota2.CDOTAUserMsg\_MiniKillCamInfo.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_MiniKillCamInfo.Types.md).[Attacker](Divine.Protobufs.Dota2.CDOTAUserMsg\_MiniKillCamInfo.Types.Attacker.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_MiniKillCamInfo.Types.Attacker.Types.md).[Ability](Divine.Protobufs.Dota2.CDOTAUserMsg\_MiniKillCamInfo.Types.Attacker.Types.Ability.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_Types_Attacker_Types_Ability_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_Types_Attacker_Types_Ability_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_Types_Attacker_Types_Ability_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

