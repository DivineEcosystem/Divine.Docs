# <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_ContributionsCombatSegment_Types_KillingBlow"></a> Class CDOTAMatchPrivateMetadata.Types.ContributionsCombatSegment.Types.KillingBlow

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAMatchPrivateMetadata.Types.ContributionsCombatSegment.Types.KillingBlow : IMessage<CDOTAMatchPrivateMetadata.Types.ContributionsCombatSegment.Types.KillingBlow>, IEquatable<CDOTAMatchPrivateMetadata.Types.ContributionsCombatSegment.Types.KillingBlow>, IDeepCloneable<CDOTAMatchPrivateMetadata.Types.ContributionsCombatSegment.Types.KillingBlow>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAMatchPrivateMetadata.Types.ContributionsCombatSegment.Types.KillingBlow](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.ContributionsCombatSegment.Types.KillingBlow.md)

#### Implements

IMessage<CDOTAMatchPrivateMetadata.Types.ContributionsCombatSegment.Types.KillingBlow\>, 
[IEquatable<CDOTAMatchPrivateMetadata.Types.ContributionsCombatSegment.Types.KillingBlow\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAMatchPrivateMetadata.Types.ContributionsCombatSegment.Types.KillingBlow\>, 
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
[EnumerableExtensions.In<CDOTAMatchPrivateMetadata.Types.ContributionsCombatSegment.Types.KillingBlow\>\(CDOTAMatchPrivateMetadata.Types.ContributionsCombatSegment.Types.KillingBlow, params CDOTAMatchPrivateMetadata.Types.ContributionsCombatSegment.Types.KillingBlow\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_ContributionsCombatSegment_Types_KillingBlow__ctor"></a> KillingBlow\(\)

```csharp
public KillingBlow()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_ContributionsCombatSegment_Types_KillingBlow__ctor_Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_ContributionsCombatSegment_Types_KillingBlow_"></a> KillingBlow\(KillingBlow\)

```csharp
public KillingBlow(CDOTAMatchPrivateMetadata.Types.ContributionsCombatSegment.Types.KillingBlow other)
```

#### Parameters

`other` [CDOTAMatchPrivateMetadata](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.md).[ContributionsCombatSegment](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.ContributionsCombatSegment.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.ContributionsCombatSegment.Types.md).[KillingBlow](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.ContributionsCombatSegment.Types.KillingBlow.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_ContributionsCombatSegment_Types_KillingBlow_AttackerHeroIdFieldNumber"></a> AttackerHeroIdFieldNumber

```csharp
public const int AttackerHeroIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_ContributionsCombatSegment_Types_KillingBlow_InflictorAbilityIdFieldNumber"></a> InflictorAbilityIdFieldNumber

```csharp
public const int InflictorAbilityIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_ContributionsCombatSegment_Types_KillingBlow_TargetHeroIdFieldNumber"></a> TargetHeroIdFieldNumber

```csharp
public const int TargetHeroIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_ContributionsCombatSegment_Types_KillingBlow_AttackerHeroId"></a> AttackerHeroId

```csharp
public int AttackerHeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_ContributionsCombatSegment_Types_KillingBlow_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_ContributionsCombatSegment_Types_KillingBlow_HasAttackerHeroId"></a> HasAttackerHeroId

```csharp
public bool HasAttackerHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_ContributionsCombatSegment_Types_KillingBlow_HasInflictorAbilityId"></a> HasInflictorAbilityId

```csharp
public bool HasInflictorAbilityId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_ContributionsCombatSegment_Types_KillingBlow_HasTargetHeroId"></a> HasTargetHeroId

```csharp
public bool HasTargetHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_ContributionsCombatSegment_Types_KillingBlow_InflictorAbilityId"></a> InflictorAbilityId

```csharp
public int InflictorAbilityId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_ContributionsCombatSegment_Types_KillingBlow_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAMatchPrivateMetadata.Types.ContributionsCombatSegment.Types.KillingBlow> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAMatchPrivateMetadata](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.md).[ContributionsCombatSegment](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.ContributionsCombatSegment.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.ContributionsCombatSegment.Types.md).[KillingBlow](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.ContributionsCombatSegment.Types.KillingBlow.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_ContributionsCombatSegment_Types_KillingBlow_TargetHeroId"></a> TargetHeroId

```csharp
public int TargetHeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_ContributionsCombatSegment_Types_KillingBlow_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_ContributionsCombatSegment_Types_KillingBlow_ClearAttackerHeroId"></a> ClearAttackerHeroId\(\)

```csharp
public void ClearAttackerHeroId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_ContributionsCombatSegment_Types_KillingBlow_ClearInflictorAbilityId"></a> ClearInflictorAbilityId\(\)

```csharp
public void ClearInflictorAbilityId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_ContributionsCombatSegment_Types_KillingBlow_ClearTargetHeroId"></a> ClearTargetHeroId\(\)

```csharp
public void ClearTargetHeroId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_ContributionsCombatSegment_Types_KillingBlow_Clone"></a> Clone\(\)

```csharp
public CDOTAMatchPrivateMetadata.Types.ContributionsCombatSegment.Types.KillingBlow Clone()
```

#### Returns

 [CDOTAMatchPrivateMetadata](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.md).[ContributionsCombatSegment](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.ContributionsCombatSegment.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.ContributionsCombatSegment.Types.md).[KillingBlow](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.ContributionsCombatSegment.Types.KillingBlow.md)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_ContributionsCombatSegment_Types_KillingBlow_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_ContributionsCombatSegment_Types_KillingBlow_Equals_Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_ContributionsCombatSegment_Types_KillingBlow_"></a> Equals\(KillingBlow\)

```csharp
public bool Equals(CDOTAMatchPrivateMetadata.Types.ContributionsCombatSegment.Types.KillingBlow other)
```

#### Parameters

`other` [CDOTAMatchPrivateMetadata](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.md).[ContributionsCombatSegment](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.ContributionsCombatSegment.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.ContributionsCombatSegment.Types.md).[KillingBlow](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.ContributionsCombatSegment.Types.KillingBlow.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_ContributionsCombatSegment_Types_KillingBlow_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_ContributionsCombatSegment_Types_KillingBlow_MergeFrom_Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_ContributionsCombatSegment_Types_KillingBlow_"></a> MergeFrom\(KillingBlow\)

```csharp
public void MergeFrom(CDOTAMatchPrivateMetadata.Types.ContributionsCombatSegment.Types.KillingBlow other)
```

#### Parameters

`other` [CDOTAMatchPrivateMetadata](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.md).[ContributionsCombatSegment](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.ContributionsCombatSegment.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.ContributionsCombatSegment.Types.md).[KillingBlow](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.ContributionsCombatSegment.Types.KillingBlow.md)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_ContributionsCombatSegment_Types_KillingBlow_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_ContributionsCombatSegment_Types_KillingBlow_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_ContributionsCombatSegment_Types_KillingBlow_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

