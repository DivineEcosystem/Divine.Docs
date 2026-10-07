# <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroNeutralTier"></a> Class CMsgDotaScenario.Types.HeroNeutralTier

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDotaScenario.Types.HeroNeutralTier : IMessage<CMsgDotaScenario.Types.HeroNeutralTier>, IEquatable<CMsgDotaScenario.Types.HeroNeutralTier>, IDeepCloneable<CMsgDotaScenario.Types.HeroNeutralTier>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDotaScenario.Types.HeroNeutralTier](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.HeroNeutralTier.md)

#### Implements

IMessage<CMsgDotaScenario.Types.HeroNeutralTier\>, 
[IEquatable<CMsgDotaScenario.Types.HeroNeutralTier\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDotaScenario.Types.HeroNeutralTier\>, 
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
[EnumerableExtensions.In<CMsgDotaScenario.Types.HeroNeutralTier\>\(CMsgDotaScenario.Types.HeroNeutralTier, params CMsgDotaScenario.Types.HeroNeutralTier\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroNeutralTier__ctor"></a> HeroNeutralTier\(\)

```csharp
public HeroNeutralTier()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroNeutralTier__ctor_Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroNeutralTier_"></a> HeroNeutralTier\(HeroNeutralTier\)

```csharp
public HeroNeutralTier(CMsgDotaScenario.Types.HeroNeutralTier other)
```

#### Parameters

`other` [CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[HeroNeutralTier](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.HeroNeutralTier.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroNeutralTier_ChoicesFieldNumber"></a> ChoicesFieldNumber

```csharp
public const int ChoicesFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroNeutralTier_SelectedArtifactFieldNumber"></a> SelectedArtifactFieldNumber

```csharp
public const int SelectedArtifactFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroNeutralTier_SelectedEnchantmentFieldNumber"></a> SelectedEnchantmentFieldNumber

```csharp
public const int SelectedEnchantmentFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroNeutralTier_TierFieldNumber"></a> TierFieldNumber

```csharp
public const int TierFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroNeutralTier_Choices"></a> Choices

```csharp
public RepeatedField<CMsgDotaScenario.Types.HeroNeutralChoice> Choices { get; }
```

#### Property Value

 RepeatedField<[CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[HeroNeutralChoice](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.HeroNeutralChoice.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroNeutralTier_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroNeutralTier_HasSelectedArtifact"></a> HasSelectedArtifact

```csharp
public bool HasSelectedArtifact { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroNeutralTier_HasSelectedEnchantment"></a> HasSelectedEnchantment

```csharp
public bool HasSelectedEnchantment { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroNeutralTier_HasTier"></a> HasTier

```csharp
public bool HasTier { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroNeutralTier_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDotaScenario.Types.HeroNeutralTier> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[HeroNeutralTier](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.HeroNeutralTier.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroNeutralTier_SelectedArtifact"></a> SelectedArtifact

```csharp
public int SelectedArtifact { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroNeutralTier_SelectedEnchantment"></a> SelectedEnchantment

```csharp
public int SelectedEnchantment { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroNeutralTier_Tier"></a> Tier

```csharp
public uint Tier { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroNeutralTier_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroNeutralTier_ClearSelectedArtifact"></a> ClearSelectedArtifact\(\)

```csharp
public void ClearSelectedArtifact()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroNeutralTier_ClearSelectedEnchantment"></a> ClearSelectedEnchantment\(\)

```csharp
public void ClearSelectedEnchantment()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroNeutralTier_ClearTier"></a> ClearTier\(\)

```csharp
public void ClearTier()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroNeutralTier_Clone"></a> Clone\(\)

```csharp
public CMsgDotaScenario.Types.HeroNeutralTier Clone()
```

#### Returns

 [CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[HeroNeutralTier](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.HeroNeutralTier.md)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroNeutralTier_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroNeutralTier_Equals_Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroNeutralTier_"></a> Equals\(HeroNeutralTier\)

```csharp
public bool Equals(CMsgDotaScenario.Types.HeroNeutralTier other)
```

#### Parameters

`other` [CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[HeroNeutralTier](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.HeroNeutralTier.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroNeutralTier_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroNeutralTier_MergeFrom_Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroNeutralTier_"></a> MergeFrom\(HeroNeutralTier\)

```csharp
public void MergeFrom(CMsgDotaScenario.Types.HeroNeutralTier other)
```

#### Parameters

`other` [CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[HeroNeutralTier](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.HeroNeutralTier.md)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroNeutralTier_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroNeutralTier_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroNeutralTier_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

