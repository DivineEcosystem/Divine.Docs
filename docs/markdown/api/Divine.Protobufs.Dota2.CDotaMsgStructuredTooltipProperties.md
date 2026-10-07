# <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties"></a> Class CDotaMsgStructuredTooltipProperties

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDotaMsgStructuredTooltipProperties : IMessage<CDotaMsgStructuredTooltipProperties>, IEquatable<CDotaMsgStructuredTooltipProperties>, IDeepCloneable<CDotaMsgStructuredTooltipProperties>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md)

#### Implements

IMessage<CDotaMsgStructuredTooltipProperties\>, 
[IEquatable<CDotaMsgStructuredTooltipProperties\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDotaMsgStructuredTooltipProperties\>, 
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
[EnumerableExtensions.In<CDotaMsgStructuredTooltipProperties\>\(CDotaMsgStructuredTooltipProperties, params CDotaMsgStructuredTooltipProperties\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties__ctor"></a> CDotaMsgStructuredTooltipProperties\(\)

```csharp
public CDotaMsgStructuredTooltipProperties()
```

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties__ctor_Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_"></a> CDotaMsgStructuredTooltipProperties\(CDotaMsgStructuredTooltipProperties\)

```csharp
public CDotaMsgStructuredTooltipProperties(CDotaMsgStructuredTooltipProperties other)
```

#### Parameters

`other` [CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_AbilityCategoryFieldNumber"></a> AbilityCategoryFieldNumber

```csharp
public const int AbilityCategoryFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_AbilityLevelFieldNumber"></a> AbilityLevelFieldNumber

```csharp
public const int AbilityLevelFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_AbilityNameLocTokenFieldNumber"></a> AbilityNameLocTokenFieldNumber

```csharp
public const int AbilityNameLocTokenFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_ChunksFieldNumber"></a> ChunksFieldNumber

```csharp
public const int ChunksFieldNumber = 20
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_CurrentCooldownFieldNumber"></a> CurrentCooldownFieldNumber

```csharp
public const int CurrentCooldownFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_CurrentHealthCostFieldNumber"></a> CurrentHealthCostFieldNumber

```csharp
public const int CurrentHealthCostFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_CurrentManaCostFieldNumber"></a> CurrentManaCostFieldNumber

```csharp
public const int CurrentManaCostFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_PreviewVideoUrlFieldNumber"></a> PreviewVideoUrlFieldNumber

```csharp
public const int PreviewVideoUrlFieldNumber = 13
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_SummaryDescriptionAghsScepterFieldNumber"></a> SummaryDescriptionAghsScepterFieldNumber

```csharp
public const int SummaryDescriptionAghsScepterFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_SummaryDescriptionAghsShardFieldNumber"></a> SummaryDescriptionAghsShardFieldNumber

```csharp
public const int SummaryDescriptionAghsShardFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_SummaryDescriptionEmbeddedSubAbilitiesFieldNumber"></a> SummaryDescriptionEmbeddedSubAbilitiesFieldNumber

```csharp
public const int SummaryDescriptionEmbeddedSubAbilitiesFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_SummaryDescriptionEmbedValuesFieldNumber"></a> SummaryDescriptionEmbedValuesFieldNumber

```csharp
public const int SummaryDescriptionEmbedValuesFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_SummaryDescriptionLocTokenFieldNumber"></a> SummaryDescriptionLocTokenFieldNumber

```csharp
public const int SummaryDescriptionLocTokenFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_SummaryDescriptionSurfacedLinesFieldNumber"></a> SummaryDescriptionSurfacedLinesFieldNumber

```csharp
public const int SummaryDescriptionSurfacedLinesFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_AbilityCategory"></a> AbilityCategory

```csharp
public CDotaMsgStructuredTooltipProperties.Types.EAbilityTooltipCategory AbilityCategory { get; set; }
```

#### Property Value

 [CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md).[Types](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.md).[EAbilityTooltipCategory](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.EAbilityTooltipCategory.md)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_AbilityLevel"></a> AbilityLevel

```csharp
public int AbilityLevel { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_AbilityNameLocToken"></a> AbilityNameLocToken

```csharp
public string AbilityNameLocToken { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Chunks"></a> Chunks

```csharp
public RepeatedField<CDotaMsgStructuredTooltipProperties.Types.TooltipContentChunk> Chunks { get; }
```

#### Property Value

 RepeatedField<[CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md).[Types](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.md).[TooltipContentChunk](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.TooltipContentChunk.md)\>

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_CurrentCooldown"></a> CurrentCooldown

```csharp
public float CurrentCooldown { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_CurrentHealthCost"></a> CurrentHealthCost

```csharp
public int CurrentHealthCost { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_CurrentManaCost"></a> CurrentManaCost

```csharp
public int CurrentManaCost { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_HasAbilityCategory"></a> HasAbilityCategory

```csharp
public bool HasAbilityCategory { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_HasAbilityLevel"></a> HasAbilityLevel

```csharp
public bool HasAbilityLevel { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_HasAbilityNameLocToken"></a> HasAbilityNameLocToken

```csharp
public bool HasAbilityNameLocToken { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_HasCurrentCooldown"></a> HasCurrentCooldown

```csharp
public bool HasCurrentCooldown { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_HasCurrentHealthCost"></a> HasCurrentHealthCost

```csharp
public bool HasCurrentHealthCost { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_HasCurrentManaCost"></a> HasCurrentManaCost

```csharp
public bool HasCurrentManaCost { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_HasPreviewVideoUrl"></a> HasPreviewVideoUrl

```csharp
public bool HasPreviewVideoUrl { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_HasSummaryDescriptionAghsScepter"></a> HasSummaryDescriptionAghsScepter

```csharp
public bool HasSummaryDescriptionAghsScepter { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_HasSummaryDescriptionAghsShard"></a> HasSummaryDescriptionAghsShard

```csharp
public bool HasSummaryDescriptionAghsShard { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_HasSummaryDescriptionLocToken"></a> HasSummaryDescriptionLocToken

```csharp
public bool HasSummaryDescriptionLocToken { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Parser"></a> Parser

```csharp
public static MessageParser<CDotaMsgStructuredTooltipProperties> Parser { get; }
```

#### Property Value

 MessageParser<[CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md)\>

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_PreviewVideoUrl"></a> PreviewVideoUrl

```csharp
public string PreviewVideoUrl { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_SummaryDescriptionAghsScepter"></a> SummaryDescriptionAghsScepter

```csharp
public string SummaryDescriptionAghsScepter { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_SummaryDescriptionAghsShard"></a> SummaryDescriptionAghsShard

```csharp
public string SummaryDescriptionAghsShard { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_SummaryDescriptionEmbeddedSubAbilities"></a> SummaryDescriptionEmbeddedSubAbilities

```csharp
public RepeatedField<CDotaMsgStructuredTooltipProperties.Types.SummaryDescriptionEmbeddedSubAbility> SummaryDescriptionEmbeddedSubAbilities { get; }
```

#### Property Value

 RepeatedField<[CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md).[Types](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.md).[SummaryDescriptionEmbeddedSubAbility](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.SummaryDescriptionEmbeddedSubAbility.md)\>

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_SummaryDescriptionEmbedValues"></a> SummaryDescriptionEmbedValues

```csharp
public RepeatedField<CDotaMsgStructuredTooltipProperties.Types.Attribute> SummaryDescriptionEmbedValues { get; }
```

#### Property Value

 RepeatedField<[CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md).[Types](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.md).[Attribute](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.Types.Attribute.md)\>

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_SummaryDescriptionLocToken"></a> SummaryDescriptionLocToken

```csharp
public string SummaryDescriptionLocToken { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_SummaryDescriptionSurfacedLines"></a> SummaryDescriptionSurfacedLines

```csharp
public RepeatedField<string> SummaryDescriptionSurfacedLines { get; }
```

#### Property Value

 RepeatedField<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_ClearAbilityCategory"></a> ClearAbilityCategory\(\)

```csharp
public void ClearAbilityCategory()
```

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_ClearAbilityLevel"></a> ClearAbilityLevel\(\)

```csharp
public void ClearAbilityLevel()
```

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_ClearAbilityNameLocToken"></a> ClearAbilityNameLocToken\(\)

```csharp
public void ClearAbilityNameLocToken()
```

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_ClearCurrentCooldown"></a> ClearCurrentCooldown\(\)

```csharp
public void ClearCurrentCooldown()
```

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_ClearCurrentHealthCost"></a> ClearCurrentHealthCost\(\)

```csharp
public void ClearCurrentHealthCost()
```

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_ClearCurrentManaCost"></a> ClearCurrentManaCost\(\)

```csharp
public void ClearCurrentManaCost()
```

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_ClearPreviewVideoUrl"></a> ClearPreviewVideoUrl\(\)

```csharp
public void ClearPreviewVideoUrl()
```

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_ClearSummaryDescriptionAghsScepter"></a> ClearSummaryDescriptionAghsScepter\(\)

```csharp
public void ClearSummaryDescriptionAghsScepter()
```

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_ClearSummaryDescriptionAghsShard"></a> ClearSummaryDescriptionAghsShard\(\)

```csharp
public void ClearSummaryDescriptionAghsShard()
```

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_ClearSummaryDescriptionLocToken"></a> ClearSummaryDescriptionLocToken\(\)

```csharp
public void ClearSummaryDescriptionLocToken()
```

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Clone"></a> Clone\(\)

```csharp
public CDotaMsgStructuredTooltipProperties Clone()
```

#### Returns

 [CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_Equals_Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_"></a> Equals\(CDotaMsgStructuredTooltipProperties\)

```csharp
public bool Equals(CDotaMsgStructuredTooltipProperties other)
```

#### Parameters

`other` [CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_MergeFrom_Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_"></a> MergeFrom\(CDotaMsgStructuredTooltipProperties\)

```csharp
public void MergeFrom(CDotaMsgStructuredTooltipProperties other)
```

#### Parameters

`other` [CDotaMsgStructuredTooltipProperties](Divine.Protobufs.Dota2.CDotaMsgStructuredTooltipProperties.md)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDotaMsgStructuredTooltipProperties_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

