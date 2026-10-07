# <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterTradeMaterials"></a> Class CMsgClientToGCMonsterHunterTradeMaterials

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCMonsterHunterTradeMaterials : IMessage<CMsgClientToGCMonsterHunterTradeMaterials>, IEquatable<CMsgClientToGCMonsterHunterTradeMaterials>, IDeepCloneable<CMsgClientToGCMonsterHunterTradeMaterials>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCMonsterHunterTradeMaterials](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterTradeMaterials.md)

#### Implements

IMessage<CMsgClientToGCMonsterHunterTradeMaterials\>, 
[IEquatable<CMsgClientToGCMonsterHunterTradeMaterials\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCMonsterHunterTradeMaterials\>, 
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
[EnumerableExtensions.In<CMsgClientToGCMonsterHunterTradeMaterials\>\(CMsgClientToGCMonsterHunterTradeMaterials, params CMsgClientToGCMonsterHunterTradeMaterials\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterTradeMaterials__ctor"></a> CMsgClientToGCMonsterHunterTradeMaterials\(\)

```csharp
public CMsgClientToGCMonsterHunterTradeMaterials()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterTradeMaterials__ctor_Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterTradeMaterials_"></a> CMsgClientToGCMonsterHunterTradeMaterials\(CMsgClientToGCMonsterHunterTradeMaterials\)

```csharp
public CMsgClientToGCMonsterHunterTradeMaterials(CMsgClientToGCMonsterHunterTradeMaterials other)
```

#### Parameters

`other` [CMsgClientToGCMonsterHunterTradeMaterials](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterTradeMaterials.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterTradeMaterials_MaterialOfferFieldNumber"></a> MaterialOfferFieldNumber

```csharp
public const int MaterialOfferFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterTradeMaterials_MaterialRequestFieldNumber"></a> MaterialRequestFieldNumber

```csharp
public const int MaterialRequestFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterTradeMaterials_RecipeIdFieldNumber"></a> RecipeIdFieldNumber

```csharp
public const int RecipeIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterTradeMaterials_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterTradeMaterials_HasRecipeId"></a> HasRecipeId

```csharp
public bool HasRecipeId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterTradeMaterials_MaterialOffer"></a> MaterialOffer

```csharp
public CMsgMonsterHunterMaterialQuantity MaterialOffer { get; set; }
```

#### Property Value

 [CMsgMonsterHunterMaterialQuantity](Divine.Protobufs.Dota2.CMsgMonsterHunterMaterialQuantity.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterTradeMaterials_MaterialRequest"></a> MaterialRequest

```csharp
public CMsgMonsterHunterMaterialQuantity MaterialRequest { get; set; }
```

#### Property Value

 [CMsgMonsterHunterMaterialQuantity](Divine.Protobufs.Dota2.CMsgMonsterHunterMaterialQuantity.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterTradeMaterials_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCMonsterHunterTradeMaterials> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCMonsterHunterTradeMaterials](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterTradeMaterials.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterTradeMaterials_RecipeId"></a> RecipeId

```csharp
public uint RecipeId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterTradeMaterials_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterTradeMaterials_ClearRecipeId"></a> ClearRecipeId\(\)

```csharp
public void ClearRecipeId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterTradeMaterials_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCMonsterHunterTradeMaterials Clone()
```

#### Returns

 [CMsgClientToGCMonsterHunterTradeMaterials](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterTradeMaterials.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterTradeMaterials_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterTradeMaterials_Equals_Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterTradeMaterials_"></a> Equals\(CMsgClientToGCMonsterHunterTradeMaterials\)

```csharp
public bool Equals(CMsgClientToGCMonsterHunterTradeMaterials other)
```

#### Parameters

`other` [CMsgClientToGCMonsterHunterTradeMaterials](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterTradeMaterials.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterTradeMaterials_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterTradeMaterials_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterTradeMaterials_"></a> MergeFrom\(CMsgClientToGCMonsterHunterTradeMaterials\)

```csharp
public void MergeFrom(CMsgClientToGCMonsterHunterTradeMaterials other)
```

#### Parameters

`other` [CMsgClientToGCMonsterHunterTradeMaterials](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterTradeMaterials.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterTradeMaterials_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterTradeMaterials_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterTradeMaterials_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

