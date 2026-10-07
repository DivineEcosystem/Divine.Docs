# <a id="Divine_Protobufs_Dota2_CMsgCandyShopExchangeRecipe"></a> Class CMsgCandyShopExchangeRecipe

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgCandyShopExchangeRecipe : IMessage<CMsgCandyShopExchangeRecipe>, IEquatable<CMsgCandyShopExchangeRecipe>, IDeepCloneable<CMsgCandyShopExchangeRecipe>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgCandyShopExchangeRecipe](Divine.Protobufs.Dota2.CMsgCandyShopExchangeRecipe.md)

#### Implements

IMessage<CMsgCandyShopExchangeRecipe\>, 
[IEquatable<CMsgCandyShopExchangeRecipe\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgCandyShopExchangeRecipe\>, 
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
[EnumerableExtensions.In<CMsgCandyShopExchangeRecipe\>\(CMsgCandyShopExchangeRecipe, params CMsgCandyShopExchangeRecipe\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopExchangeRecipe__ctor"></a> CMsgCandyShopExchangeRecipe\(\)

```csharp
public CMsgCandyShopExchangeRecipe()
```

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopExchangeRecipe__ctor_Divine_Protobufs_Dota2_CMsgCandyShopExchangeRecipe_"></a> CMsgCandyShopExchangeRecipe\(CMsgCandyShopExchangeRecipe\)

```csharp
public CMsgCandyShopExchangeRecipe(CMsgCandyShopExchangeRecipe other)
```

#### Parameters

`other` [CMsgCandyShopExchangeRecipe](Divine.Protobufs.Dota2.CMsgCandyShopExchangeRecipe.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopExchangeRecipe_InputFieldNumber"></a> InputFieldNumber

```csharp
public const int InputFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopExchangeRecipe_OutputFieldNumber"></a> OutputFieldNumber

```csharp
public const int OutputFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopExchangeRecipe_RecipeIdFieldNumber"></a> RecipeIdFieldNumber

```csharp
public const int RecipeIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopExchangeRecipe_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopExchangeRecipe_HasRecipeId"></a> HasRecipeId

```csharp
public bool HasRecipeId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopExchangeRecipe_Input"></a> Input

```csharp
public CMsgCandyShopCandyQuantity Input { get; set; }
```

#### Property Value

 [CMsgCandyShopCandyQuantity](Divine.Protobufs.Dota2.CMsgCandyShopCandyQuantity.md)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopExchangeRecipe_Output"></a> Output

```csharp
public CMsgCandyShopCandyQuantity Output { get; set; }
```

#### Property Value

 [CMsgCandyShopCandyQuantity](Divine.Protobufs.Dota2.CMsgCandyShopCandyQuantity.md)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopExchangeRecipe_Parser"></a> Parser

```csharp
public static MessageParser<CMsgCandyShopExchangeRecipe> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgCandyShopExchangeRecipe](Divine.Protobufs.Dota2.CMsgCandyShopExchangeRecipe.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopExchangeRecipe_RecipeId"></a> RecipeId

```csharp
public uint RecipeId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopExchangeRecipe_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopExchangeRecipe_ClearRecipeId"></a> ClearRecipeId\(\)

```csharp
public void ClearRecipeId()
```

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopExchangeRecipe_Clone"></a> Clone\(\)

```csharp
public CMsgCandyShopExchangeRecipe Clone()
```

#### Returns

 [CMsgCandyShopExchangeRecipe](Divine.Protobufs.Dota2.CMsgCandyShopExchangeRecipe.md)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopExchangeRecipe_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopExchangeRecipe_Equals_Divine_Protobufs_Dota2_CMsgCandyShopExchangeRecipe_"></a> Equals\(CMsgCandyShopExchangeRecipe\)

```csharp
public bool Equals(CMsgCandyShopExchangeRecipe other)
```

#### Parameters

`other` [CMsgCandyShopExchangeRecipe](Divine.Protobufs.Dota2.CMsgCandyShopExchangeRecipe.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopExchangeRecipe_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopExchangeRecipe_MergeFrom_Divine_Protobufs_Dota2_CMsgCandyShopExchangeRecipe_"></a> MergeFrom\(CMsgCandyShopExchangeRecipe\)

```csharp
public void MergeFrom(CMsgCandyShopExchangeRecipe other)
```

#### Parameters

`other` [CMsgCandyShopExchangeRecipe](Divine.Protobufs.Dota2.CMsgCandyShopExchangeRecipe.md)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopExchangeRecipe_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopExchangeRecipe_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopExchangeRecipe_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

