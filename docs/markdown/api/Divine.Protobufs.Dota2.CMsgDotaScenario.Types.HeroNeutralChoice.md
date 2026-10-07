# <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroNeutralChoice"></a> Class CMsgDotaScenario.Types.HeroNeutralChoice

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDotaScenario.Types.HeroNeutralChoice : IMessage<CMsgDotaScenario.Types.HeroNeutralChoice>, IEquatable<CMsgDotaScenario.Types.HeroNeutralChoice>, IDeepCloneable<CMsgDotaScenario.Types.HeroNeutralChoice>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDotaScenario.Types.HeroNeutralChoice](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.HeroNeutralChoice.md)

#### Implements

IMessage<CMsgDotaScenario.Types.HeroNeutralChoice\>, 
[IEquatable<CMsgDotaScenario.Types.HeroNeutralChoice\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDotaScenario.Types.HeroNeutralChoice\>, 
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
[EnumerableExtensions.In<CMsgDotaScenario.Types.HeroNeutralChoice\>\(CMsgDotaScenario.Types.HeroNeutralChoice, params CMsgDotaScenario.Types.HeroNeutralChoice\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroNeutralChoice__ctor"></a> HeroNeutralChoice\(\)

```csharp
public HeroNeutralChoice()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroNeutralChoice__ctor_Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroNeutralChoice_"></a> HeroNeutralChoice\(HeroNeutralChoice\)

```csharp
public HeroNeutralChoice(CMsgDotaScenario.Types.HeroNeutralChoice other)
```

#### Parameters

`other` [CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[HeroNeutralChoice](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.HeroNeutralChoice.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroNeutralChoice_ArtifactNameFieldNumber"></a> ArtifactNameFieldNumber

```csharp
public const int ArtifactNameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroNeutralChoice_ChoiceIndexFieldNumber"></a> ChoiceIndexFieldNumber

```csharp
public const int ChoiceIndexFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroNeutralChoice_EnchantmentNameFieldNumber"></a> EnchantmentNameFieldNumber

```csharp
public const int EnchantmentNameFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroNeutralChoice_ArtifactName"></a> ArtifactName

```csharp
public string ArtifactName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroNeutralChoice_ChoiceIndex"></a> ChoiceIndex

```csharp
public int ChoiceIndex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroNeutralChoice_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroNeutralChoice_EnchantmentName"></a> EnchantmentName

```csharp
public string EnchantmentName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroNeutralChoice_HasArtifactName"></a> HasArtifactName

```csharp
public bool HasArtifactName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroNeutralChoice_HasChoiceIndex"></a> HasChoiceIndex

```csharp
public bool HasChoiceIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroNeutralChoice_HasEnchantmentName"></a> HasEnchantmentName

```csharp
public bool HasEnchantmentName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroNeutralChoice_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDotaScenario.Types.HeroNeutralChoice> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[HeroNeutralChoice](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.HeroNeutralChoice.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroNeutralChoice_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroNeutralChoice_ClearArtifactName"></a> ClearArtifactName\(\)

```csharp
public void ClearArtifactName()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroNeutralChoice_ClearChoiceIndex"></a> ClearChoiceIndex\(\)

```csharp
public void ClearChoiceIndex()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroNeutralChoice_ClearEnchantmentName"></a> ClearEnchantmentName\(\)

```csharp
public void ClearEnchantmentName()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroNeutralChoice_Clone"></a> Clone\(\)

```csharp
public CMsgDotaScenario.Types.HeroNeutralChoice Clone()
```

#### Returns

 [CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[HeroNeutralChoice](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.HeroNeutralChoice.md)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroNeutralChoice_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroNeutralChoice_Equals_Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroNeutralChoice_"></a> Equals\(HeroNeutralChoice\)

```csharp
public bool Equals(CMsgDotaScenario.Types.HeroNeutralChoice other)
```

#### Parameters

`other` [CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[HeroNeutralChoice](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.HeroNeutralChoice.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroNeutralChoice_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroNeutralChoice_MergeFrom_Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroNeutralChoice_"></a> MergeFrom\(HeroNeutralChoice\)

```csharp
public void MergeFrom(CMsgDotaScenario.Types.HeroNeutralChoice other)
```

#### Parameters

`other` [CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[HeroNeutralChoice](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.HeroNeutralChoice.md)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroNeutralChoice_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroNeutralChoice_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_HeroNeutralChoice_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

