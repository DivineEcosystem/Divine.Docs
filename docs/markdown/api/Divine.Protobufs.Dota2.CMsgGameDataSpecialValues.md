# <a id="Divine_Protobufs_Dota2_CMsgGameDataSpecialValues"></a> Class CMsgGameDataSpecialValues

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGameDataSpecialValues : IMessage<CMsgGameDataSpecialValues>, IEquatable<CMsgGameDataSpecialValues>, IDeepCloneable<CMsgGameDataSpecialValues>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGameDataSpecialValues](Divine.Protobufs.Dota2.CMsgGameDataSpecialValues.md)

#### Implements

IMessage<CMsgGameDataSpecialValues\>, 
[IEquatable<CMsgGameDataSpecialValues\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGameDataSpecialValues\>, 
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
[EnumerableExtensions.In<CMsgGameDataSpecialValues\>\(CMsgGameDataSpecialValues, params CMsgGameDataSpecialValues\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGameDataSpecialValues__ctor"></a> CMsgGameDataSpecialValues\(\)

```csharp
public CMsgGameDataSpecialValues()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataSpecialValues__ctor_Divine_Protobufs_Dota2_CMsgGameDataSpecialValues_"></a> CMsgGameDataSpecialValues\(CMsgGameDataSpecialValues\)

```csharp
public CMsgGameDataSpecialValues(CMsgGameDataSpecialValues other)
```

#### Parameters

`other` [CMsgGameDataSpecialValues](Divine.Protobufs.Dota2.CMsgGameDataSpecialValues.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGameDataSpecialValues_BonusesFieldNumber"></a> BonusesFieldNumber

```csharp
public const int BonusesFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataSpecialValues_FacetBonusFieldNumber"></a> FacetBonusFieldNumber

```csharp
public const int FacetBonusFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataSpecialValues_HeadingLocFieldNumber"></a> HeadingLocFieldNumber

```csharp
public const int HeadingLocFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataSpecialValues_IsPercentageFieldNumber"></a> IsPercentageFieldNumber

```csharp
public const int IsPercentageFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataSpecialValues_NameFieldNumber"></a> NameFieldNumber

```csharp
public const int NameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataSpecialValues_RequiredFacetFieldNumber"></a> RequiredFacetFieldNumber

```csharp
public const int RequiredFacetFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataSpecialValues_ValuesFloatFieldNumber"></a> ValuesFloatFieldNumber

```csharp
public const int ValuesFloatFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataSpecialValues_ValuesScepterFieldNumber"></a> ValuesScepterFieldNumber

```csharp
public const int ValuesScepterFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataSpecialValues_ValuesShardFieldNumber"></a> ValuesShardFieldNumber

```csharp
public const int ValuesShardFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGameDataSpecialValues_Bonuses"></a> Bonuses

```csharp
public RepeatedField<CMsgGameDataSpecialValueBonus> Bonuses { get; }
```

#### Property Value

 RepeatedField<[CMsgGameDataSpecialValueBonus](Divine.Protobufs.Dota2.CMsgGameDataSpecialValueBonus.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGameDataSpecialValues_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGameDataSpecialValues_FacetBonus"></a> FacetBonus

```csharp
public CMsgGameDataFacetAbilityBonus FacetBonus { get; set; }
```

#### Property Value

 [CMsgGameDataFacetAbilityBonus](Divine.Protobufs.Dota2.CMsgGameDataFacetAbilityBonus.md)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataSpecialValues_HasHeadingLoc"></a> HasHeadingLoc

```csharp
public bool HasHeadingLoc { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataSpecialValues_HasIsPercentage"></a> HasIsPercentage

```csharp
public bool HasIsPercentage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataSpecialValues_HasName"></a> HasName

```csharp
public bool HasName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataSpecialValues_HasRequiredFacet"></a> HasRequiredFacet

```csharp
public bool HasRequiredFacet { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataSpecialValues_HeadingLoc"></a> HeadingLoc

```csharp
public string HeadingLoc { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataSpecialValues_IsPercentage"></a> IsPercentage

```csharp
public bool IsPercentage { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataSpecialValues_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataSpecialValues_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGameDataSpecialValues> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGameDataSpecialValues](Divine.Protobufs.Dota2.CMsgGameDataSpecialValues.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGameDataSpecialValues_RequiredFacet"></a> RequiredFacet

```csharp
public string RequiredFacet { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataSpecialValues_ValuesFloat"></a> ValuesFloat

```csharp
public RepeatedField<float> ValuesFloat { get; }
```

#### Property Value

 RepeatedField<[float](https://learn.microsoft.com/dotnet/api/system.single)\>

### <a id="Divine_Protobufs_Dota2_CMsgGameDataSpecialValues_ValuesScepter"></a> ValuesScepter

```csharp
public RepeatedField<float> ValuesScepter { get; }
```

#### Property Value

 RepeatedField<[float](https://learn.microsoft.com/dotnet/api/system.single)\>

### <a id="Divine_Protobufs_Dota2_CMsgGameDataSpecialValues_ValuesShard"></a> ValuesShard

```csharp
public RepeatedField<float> ValuesShard { get; }
```

#### Property Value

 RepeatedField<[float](https://learn.microsoft.com/dotnet/api/system.single)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGameDataSpecialValues_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataSpecialValues_ClearHeadingLoc"></a> ClearHeadingLoc\(\)

```csharp
public void ClearHeadingLoc()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataSpecialValues_ClearIsPercentage"></a> ClearIsPercentage\(\)

```csharp
public void ClearIsPercentage()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataSpecialValues_ClearName"></a> ClearName\(\)

```csharp
public void ClearName()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataSpecialValues_ClearRequiredFacet"></a> ClearRequiredFacet\(\)

```csharp
public void ClearRequiredFacet()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataSpecialValues_Clone"></a> Clone\(\)

```csharp
public CMsgGameDataSpecialValues Clone()
```

#### Returns

 [CMsgGameDataSpecialValues](Divine.Protobufs.Dota2.CMsgGameDataSpecialValues.md)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataSpecialValues_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataSpecialValues_Equals_Divine_Protobufs_Dota2_CMsgGameDataSpecialValues_"></a> Equals\(CMsgGameDataSpecialValues\)

```csharp
public bool Equals(CMsgGameDataSpecialValues other)
```

#### Parameters

`other` [CMsgGameDataSpecialValues](Divine.Protobufs.Dota2.CMsgGameDataSpecialValues.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataSpecialValues_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataSpecialValues_MergeFrom_Divine_Protobufs_Dota2_CMsgGameDataSpecialValues_"></a> MergeFrom\(CMsgGameDataSpecialValues\)

```csharp
public void MergeFrom(CMsgGameDataSpecialValues other)
```

#### Parameters

`other` [CMsgGameDataSpecialValues](Divine.Protobufs.Dota2.CMsgGameDataSpecialValues.md)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataSpecialValues_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGameDataSpecialValues_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataSpecialValues_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

