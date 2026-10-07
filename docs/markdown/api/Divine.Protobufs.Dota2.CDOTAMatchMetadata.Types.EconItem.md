# <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_EconItem"></a> Class CDOTAMatchMetadata.Types.EconItem

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAMatchMetadata.Types.EconItem : IMessage<CDOTAMatchMetadata.Types.EconItem>, IEquatable<CDOTAMatchMetadata.Types.EconItem>, IDeepCloneable<CDOTAMatchMetadata.Types.EconItem>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAMatchMetadata.Types.EconItem](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.EconItem.md)

#### Implements

IMessage<CDOTAMatchMetadata.Types.EconItem\>, 
[IEquatable<CDOTAMatchMetadata.Types.EconItem\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAMatchMetadata.Types.EconItem\>, 
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
[EnumerableExtensions.In<CDOTAMatchMetadata.Types.EconItem\>\(CDOTAMatchMetadata.Types.EconItem, params CDOTAMatchMetadata.Types.EconItem\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_EconItem__ctor"></a> EconItem\(\)

```csharp
public EconItem()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_EconItem__ctor_Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_EconItem_"></a> EconItem\(EconItem\)

```csharp
public EconItem(CDOTAMatchMetadata.Types.EconItem other)
```

#### Parameters

`other` [CDOTAMatchMetadata](Divine.Protobufs.Dota2.CDOTAMatchMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.md).[EconItem](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.EconItem.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_EconItem_AttributeFieldNumber"></a> AttributeFieldNumber

```csharp
public const int AttributeFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_EconItem_DefIndexFieldNumber"></a> DefIndexFieldNumber

```csharp
public const int DefIndexFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_EconItem_EquippedStateFieldNumber"></a> EquippedStateFieldNumber

```csharp
public const int EquippedStateFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_EconItem_QualityFieldNumber"></a> QualityFieldNumber

```csharp
public const int QualityFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_EconItem_StyleFieldNumber"></a> StyleFieldNumber

```csharp
public const int StyleFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_EconItem_Attribute"></a> Attribute

```csharp
public RepeatedField<CSOEconItemAttribute> Attribute { get; }
```

#### Property Value

 RepeatedField<[CSOEconItemAttribute](Divine.Protobufs.Dota2.CSOEconItemAttribute.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_EconItem_DefIndex"></a> DefIndex

```csharp
public uint DefIndex { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_EconItem_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_EconItem_EquippedState"></a> EquippedState

```csharp
public RepeatedField<CSOEconItemEquipped> EquippedState { get; }
```

#### Property Value

 RepeatedField<[CSOEconItemEquipped](Divine.Protobufs.Dota2.CSOEconItemEquipped.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_EconItem_HasDefIndex"></a> HasDefIndex

```csharp
public bool HasDefIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_EconItem_HasQuality"></a> HasQuality

```csharp
public bool HasQuality { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_EconItem_HasStyle"></a> HasStyle

```csharp
public bool HasStyle { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_EconItem_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAMatchMetadata.Types.EconItem> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAMatchMetadata](Divine.Protobufs.Dota2.CDOTAMatchMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.md).[EconItem](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.EconItem.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_EconItem_Quality"></a> Quality

```csharp
public uint Quality { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_EconItem_Style"></a> Style

```csharp
public uint Style { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_EconItem_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_EconItem_ClearDefIndex"></a> ClearDefIndex\(\)

```csharp
public void ClearDefIndex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_EconItem_ClearQuality"></a> ClearQuality\(\)

```csharp
public void ClearQuality()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_EconItem_ClearStyle"></a> ClearStyle\(\)

```csharp
public void ClearStyle()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_EconItem_Clone"></a> Clone\(\)

```csharp
public CDOTAMatchMetadata.Types.EconItem Clone()
```

#### Returns

 [CDOTAMatchMetadata](Divine.Protobufs.Dota2.CDOTAMatchMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.md).[EconItem](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.EconItem.md)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_EconItem_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_EconItem_Equals_Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_EconItem_"></a> Equals\(EconItem\)

```csharp
public bool Equals(CDOTAMatchMetadata.Types.EconItem other)
```

#### Parameters

`other` [CDOTAMatchMetadata](Divine.Protobufs.Dota2.CDOTAMatchMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.md).[EconItem](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.EconItem.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_EconItem_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_EconItem_MergeFrom_Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_EconItem_"></a> MergeFrom\(EconItem\)

```csharp
public void MergeFrom(CDOTAMatchMetadata.Types.EconItem other)
```

#### Parameters

`other` [CDOTAMatchMetadata](Divine.Protobufs.Dota2.CDOTAMatchMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.md).[EconItem](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.EconItem.md)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_EconItem_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_EconItem_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_EconItem_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

