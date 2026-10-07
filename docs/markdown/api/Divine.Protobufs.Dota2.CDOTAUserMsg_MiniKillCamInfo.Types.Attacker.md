# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_Types_Attacker"></a> Class CDOTAUserMsg\_MiniKillCamInfo.Types.Attacker

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_MiniKillCamInfo.Types.Attacker : IMessage<CDOTAUserMsg_MiniKillCamInfo.Types.Attacker>, IEquatable<CDOTAUserMsg_MiniKillCamInfo.Types.Attacker>, IDeepCloneable<CDOTAUserMsg_MiniKillCamInfo.Types.Attacker>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_MiniKillCamInfo.Types.Attacker](Divine.Protobufs.Dota2.CDOTAUserMsg\_MiniKillCamInfo.Types.Attacker.md)

#### Implements

IMessage<CDOTAUserMsg\_MiniKillCamInfo.Types.Attacker\>, 
[IEquatable<CDOTAUserMsg\_MiniKillCamInfo.Types.Attacker\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_MiniKillCamInfo.Types.Attacker\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_MiniKillCamInfo.Types.Attacker\>\(CDOTAUserMsg\_MiniKillCamInfo.Types.Attacker, params CDOTAUserMsg\_MiniKillCamInfo.Types.Attacker\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_Types_Attacker__ctor"></a> Attacker\(\)

```csharp
public Attacker()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_Types_Attacker__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_Types_Attacker_"></a> Attacker\(Attacker\)

```csharp
public Attacker(CDOTAUserMsg_MiniKillCamInfo.Types.Attacker other)
```

#### Parameters

`other` [CDOTAUserMsg\_MiniKillCamInfo](Divine.Protobufs.Dota2.CDOTAUserMsg\_MiniKillCamInfo.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_MiniKillCamInfo.Types.md).[Attacker](Divine.Protobufs.Dota2.CDOTAUserMsg\_MiniKillCamInfo.Types.Attacker.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_Types_Attacker_AbilitiesFieldNumber"></a> AbilitiesFieldNumber

```csharp
public const int AbilitiesFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_Types_Attacker_Attacker_FieldNumber"></a> Attacker\_FieldNumber

```csharp
public const int Attacker_FieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_Types_Attacker_AttackerNameFieldNumber"></a> AttackerNameFieldNumber

```csharp
public const int AttackerNameFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_Types_Attacker_TotalDamageFieldNumber"></a> TotalDamageFieldNumber

```csharp
public const int TotalDamageFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_Types_Attacker_Abilities"></a> Abilities

```csharp
public RepeatedField<CDOTAUserMsg_MiniKillCamInfo.Types.Attacker.Types.Ability> Abilities { get; }
```

#### Property Value

 RepeatedField<[CDOTAUserMsg\_MiniKillCamInfo](Divine.Protobufs.Dota2.CDOTAUserMsg\_MiniKillCamInfo.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_MiniKillCamInfo.Types.md).[Attacker](Divine.Protobufs.Dota2.CDOTAUserMsg\_MiniKillCamInfo.Types.Attacker.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_MiniKillCamInfo.Types.Attacker.Types.md).[Ability](Divine.Protobufs.Dota2.CDOTAUserMsg\_MiniKillCamInfo.Types.Attacker.Types.Ability.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_Types_Attacker_Attacker_"></a> Attacker\_

```csharp
public uint Attacker_ { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_Types_Attacker_AttackerName"></a> AttackerName

```csharp
public string AttackerName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_Types_Attacker_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_Types_Attacker_HasAttacker_"></a> HasAttacker\_

```csharp
public bool HasAttacker_ { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_Types_Attacker_HasAttackerName"></a> HasAttackerName

```csharp
public bool HasAttackerName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_Types_Attacker_HasTotalDamage"></a> HasTotalDamage

```csharp
public bool HasTotalDamage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_Types_Attacker_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_MiniKillCamInfo.Types.Attacker> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_MiniKillCamInfo](Divine.Protobufs.Dota2.CDOTAUserMsg\_MiniKillCamInfo.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_MiniKillCamInfo.Types.md).[Attacker](Divine.Protobufs.Dota2.CDOTAUserMsg\_MiniKillCamInfo.Types.Attacker.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_Types_Attacker_TotalDamage"></a> TotalDamage

```csharp
public int TotalDamage { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_Types_Attacker_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_Types_Attacker_ClearAttacker_"></a> ClearAttacker\_\(\)

```csharp
public void ClearAttacker_()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_Types_Attacker_ClearAttackerName"></a> ClearAttackerName\(\)

```csharp
public void ClearAttackerName()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_Types_Attacker_ClearTotalDamage"></a> ClearTotalDamage\(\)

```csharp
public void ClearTotalDamage()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_Types_Attacker_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_MiniKillCamInfo.Types.Attacker Clone()
```

#### Returns

 [CDOTAUserMsg\_MiniKillCamInfo](Divine.Protobufs.Dota2.CDOTAUserMsg\_MiniKillCamInfo.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_MiniKillCamInfo.Types.md).[Attacker](Divine.Protobufs.Dota2.CDOTAUserMsg\_MiniKillCamInfo.Types.Attacker.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_Types_Attacker_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_Types_Attacker_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_Types_Attacker_"></a> Equals\(Attacker\)

```csharp
public bool Equals(CDOTAUserMsg_MiniKillCamInfo.Types.Attacker other)
```

#### Parameters

`other` [CDOTAUserMsg\_MiniKillCamInfo](Divine.Protobufs.Dota2.CDOTAUserMsg\_MiniKillCamInfo.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_MiniKillCamInfo.Types.md).[Attacker](Divine.Protobufs.Dota2.CDOTAUserMsg\_MiniKillCamInfo.Types.Attacker.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_Types_Attacker_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_Types_Attacker_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_Types_Attacker_"></a> MergeFrom\(Attacker\)

```csharp
public void MergeFrom(CDOTAUserMsg_MiniKillCamInfo.Types.Attacker other)
```

#### Parameters

`other` [CDOTAUserMsg\_MiniKillCamInfo](Divine.Protobufs.Dota2.CDOTAUserMsg\_MiniKillCamInfo.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_MiniKillCamInfo.Types.md).[Attacker](Divine.Protobufs.Dota2.CDOTAUserMsg\_MiniKillCamInfo.Types.Attacker.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_Types_Attacker_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_Types_Attacker_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_Types_Attacker_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

