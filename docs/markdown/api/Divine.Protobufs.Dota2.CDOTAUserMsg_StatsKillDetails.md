# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsKillDetails"></a> Class CDOTAUserMsg\_StatsKillDetails

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_StatsKillDetails : IMessage<CDOTAUserMsg_StatsKillDetails>, IEquatable<CDOTAUserMsg_StatsKillDetails>, IDeepCloneable<CDOTAUserMsg_StatsKillDetails>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_StatsKillDetails](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsKillDetails.md)

#### Implements

IMessage<CDOTAUserMsg\_StatsKillDetails\>, 
[IEquatable<CDOTAUserMsg\_StatsKillDetails\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_StatsKillDetails\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_StatsKillDetails\>\(CDOTAUserMsg\_StatsKillDetails, params CDOTAUserMsg\_StatsKillDetails\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsKillDetails__ctor"></a> CDOTAUserMsg\_StatsKillDetails\(\)

```csharp
public CDOTAUserMsg_StatsKillDetails()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsKillDetails__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_StatsKillDetails_"></a> CDOTAUserMsg\_StatsKillDetails\(CDOTAUserMsg\_StatsKillDetails\)

```csharp
public CDOTAUserMsg_StatsKillDetails(CDOTAUserMsg_StatsKillDetails other)
```

#### Parameters

`other` [CDOTAUserMsg\_StatsKillDetails](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsKillDetails.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsKillDetails_DamageToKillFieldNumber"></a> DamageToKillFieldNumber

```csharp
public const int DamageToKillFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsKillDetails_DeathTimeFieldNumber"></a> DeathTimeFieldNumber

```csharp
public const int DeathTimeFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsKillDetails_EffectiveHealthFieldNumber"></a> EffectiveHealthFieldNumber

```csharp
public const int EffectiveHealthFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsKillDetails_KillerIdFieldNumber"></a> KillerIdFieldNumber

```csharp
public const int KillerIdFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsKillDetails_KillSharesFieldNumber"></a> KillSharesFieldNumber

```csharp
public const int KillSharesFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsKillDetails_VictimIdFieldNumber"></a> VictimIdFieldNumber

```csharp
public const int VictimIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsKillDetails_DamageToKill"></a> DamageToKill

```csharp
public uint DamageToKill { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsKillDetails_DeathTime"></a> DeathTime

```csharp
public float DeathTime { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsKillDetails_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsKillDetails_EffectiveHealth"></a> EffectiveHealth

```csharp
public uint EffectiveHealth { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsKillDetails_HasDamageToKill"></a> HasDamageToKill

```csharp
public bool HasDamageToKill { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsKillDetails_HasDeathTime"></a> HasDeathTime

```csharp
public bool HasDeathTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsKillDetails_HasEffectiveHealth"></a> HasEffectiveHealth

```csharp
public bool HasEffectiveHealth { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsKillDetails_HasKillerId"></a> HasKillerId

```csharp
public bool HasKillerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsKillDetails_HasVictimId"></a> HasVictimId

```csharp
public bool HasVictimId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsKillDetails_KillerId"></a> KillerId

```csharp
public int KillerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsKillDetails_KillShares"></a> KillShares

```csharp
public RepeatedField<CDOTAUserMsg_StatsPlayerKillShare> KillShares { get; }
```

#### Property Value

 RepeatedField<[CDOTAUserMsg\_StatsPlayerKillShare](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsPlayerKillShare.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsKillDetails_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_StatsKillDetails> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_StatsKillDetails](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsKillDetails.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsKillDetails_VictimId"></a> VictimId

```csharp
public int VictimId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsKillDetails_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsKillDetails_ClearDamageToKill"></a> ClearDamageToKill\(\)

```csharp
public void ClearDamageToKill()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsKillDetails_ClearDeathTime"></a> ClearDeathTime\(\)

```csharp
public void ClearDeathTime()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsKillDetails_ClearEffectiveHealth"></a> ClearEffectiveHealth\(\)

```csharp
public void ClearEffectiveHealth()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsKillDetails_ClearKillerId"></a> ClearKillerId\(\)

```csharp
public void ClearKillerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsKillDetails_ClearVictimId"></a> ClearVictimId\(\)

```csharp
public void ClearVictimId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsKillDetails_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_StatsKillDetails Clone()
```

#### Returns

 [CDOTAUserMsg\_StatsKillDetails](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsKillDetails.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsKillDetails_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsKillDetails_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_StatsKillDetails_"></a> Equals\(CDOTAUserMsg\_StatsKillDetails\)

```csharp
public bool Equals(CDOTAUserMsg_StatsKillDetails other)
```

#### Parameters

`other` [CDOTAUserMsg\_StatsKillDetails](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsKillDetails.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsKillDetails_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsKillDetails_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_StatsKillDetails_"></a> MergeFrom\(CDOTAUserMsg\_StatsKillDetails\)

```csharp
public void MergeFrom(CDOTAUserMsg_StatsKillDetails other)
```

#### Parameters

`other` [CDOTAUserMsg\_StatsKillDetails](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsKillDetails.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsKillDetails_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsKillDetails_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsKillDetails_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

