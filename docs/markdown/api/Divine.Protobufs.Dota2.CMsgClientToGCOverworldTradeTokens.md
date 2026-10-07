# <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldTradeTokens"></a> Class CMsgClientToGCOverworldTradeTokens

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCOverworldTradeTokens : IMessage<CMsgClientToGCOverworldTradeTokens>, IEquatable<CMsgClientToGCOverworldTradeTokens>, IDeepCloneable<CMsgClientToGCOverworldTradeTokens>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCOverworldTradeTokens](Divine.Protobufs.Dota2.CMsgClientToGCOverworldTradeTokens.md)

#### Implements

IMessage<CMsgClientToGCOverworldTradeTokens\>, 
[IEquatable<CMsgClientToGCOverworldTradeTokens\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCOverworldTradeTokens\>, 
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
[EnumerableExtensions.In<CMsgClientToGCOverworldTradeTokens\>\(CMsgClientToGCOverworldTradeTokens, params CMsgClientToGCOverworldTradeTokens\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldTradeTokens__ctor"></a> CMsgClientToGCOverworldTradeTokens\(\)

```csharp
public CMsgClientToGCOverworldTradeTokens()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldTradeTokens__ctor_Divine_Protobufs_Dota2_CMsgClientToGCOverworldTradeTokens_"></a> CMsgClientToGCOverworldTradeTokens\(CMsgClientToGCOverworldTradeTokens\)

```csharp
public CMsgClientToGCOverworldTradeTokens(CMsgClientToGCOverworldTradeTokens other)
```

#### Parameters

`other` [CMsgClientToGCOverworldTradeTokens](Divine.Protobufs.Dota2.CMsgClientToGCOverworldTradeTokens.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldTradeTokens_EncounterIdFieldNumber"></a> EncounterIdFieldNumber

```csharp
public const int EncounterIdFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldTradeTokens_OverworldIdFieldNumber"></a> OverworldIdFieldNumber

```csharp
public const int OverworldIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldTradeTokens_RecipeFieldNumber"></a> RecipeFieldNumber

```csharp
public const int RecipeFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldTradeTokens_TokenOfferFieldNumber"></a> TokenOfferFieldNumber

```csharp
public const int TokenOfferFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldTradeTokens_TokenRequestFieldNumber"></a> TokenRequestFieldNumber

```csharp
public const int TokenRequestFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldTradeTokens_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldTradeTokens_EncounterId"></a> EncounterId

```csharp
public uint EncounterId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldTradeTokens_HasEncounterId"></a> HasEncounterId

```csharp
public bool HasEncounterId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldTradeTokens_HasOverworldId"></a> HasOverworldId

```csharp
public bool HasOverworldId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldTradeTokens_HasRecipe"></a> HasRecipe

```csharp
public bool HasRecipe { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldTradeTokens_OverworldId"></a> OverworldId

```csharp
public uint OverworldId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldTradeTokens_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCOverworldTradeTokens> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCOverworldTradeTokens](Divine.Protobufs.Dota2.CMsgClientToGCOverworldTradeTokens.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldTradeTokens_Recipe"></a> Recipe

```csharp
public uint Recipe { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldTradeTokens_TokenOffer"></a> TokenOffer

```csharp
public CMsgOverworldTokenQuantity TokenOffer { get; set; }
```

#### Property Value

 [CMsgOverworldTokenQuantity](Divine.Protobufs.Dota2.CMsgOverworldTokenQuantity.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldTradeTokens_TokenRequest"></a> TokenRequest

```csharp
public CMsgOverworldTokenQuantity TokenRequest { get; set; }
```

#### Property Value

 [CMsgOverworldTokenQuantity](Divine.Protobufs.Dota2.CMsgOverworldTokenQuantity.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldTradeTokens_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldTradeTokens_ClearEncounterId"></a> ClearEncounterId\(\)

```csharp
public void ClearEncounterId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldTradeTokens_ClearOverworldId"></a> ClearOverworldId\(\)

```csharp
public void ClearOverworldId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldTradeTokens_ClearRecipe"></a> ClearRecipe\(\)

```csharp
public void ClearRecipe()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldTradeTokens_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCOverworldTradeTokens Clone()
```

#### Returns

 [CMsgClientToGCOverworldTradeTokens](Divine.Protobufs.Dota2.CMsgClientToGCOverworldTradeTokens.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldTradeTokens_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldTradeTokens_Equals_Divine_Protobufs_Dota2_CMsgClientToGCOverworldTradeTokens_"></a> Equals\(CMsgClientToGCOverworldTradeTokens\)

```csharp
public bool Equals(CMsgClientToGCOverworldTradeTokens other)
```

#### Parameters

`other` [CMsgClientToGCOverworldTradeTokens](Divine.Protobufs.Dota2.CMsgClientToGCOverworldTradeTokens.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldTradeTokens_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldTradeTokens_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCOverworldTradeTokens_"></a> MergeFrom\(CMsgClientToGCOverworldTradeTokens\)

```csharp
public void MergeFrom(CMsgClientToGCOverworldTradeTokens other)
```

#### Parameters

`other` [CMsgClientToGCOverworldTradeTokens](Divine.Protobufs.Dota2.CMsgClientToGCOverworldTradeTokens.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldTradeTokens_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldTradeTokens_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldTradeTokens_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

