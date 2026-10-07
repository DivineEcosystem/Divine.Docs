# <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStaticRecipe"></a> Class CMsgClientToGCCreateStaticRecipe

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCCreateStaticRecipe : IMessage<CMsgClientToGCCreateStaticRecipe>, IEquatable<CMsgClientToGCCreateStaticRecipe>, IDeepCloneable<CMsgClientToGCCreateStaticRecipe>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCCreateStaticRecipe](Divine.Protobufs.Dota2.CMsgClientToGCCreateStaticRecipe.md)

#### Implements

IMessage<CMsgClientToGCCreateStaticRecipe\>, 
[IEquatable<CMsgClientToGCCreateStaticRecipe\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCCreateStaticRecipe\>, 
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
[EnumerableExtensions.In<CMsgClientToGCCreateStaticRecipe\>\(CMsgClientToGCCreateStaticRecipe, params CMsgClientToGCCreateStaticRecipe\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStaticRecipe__ctor"></a> CMsgClientToGCCreateStaticRecipe\(\)

```csharp
public CMsgClientToGCCreateStaticRecipe()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStaticRecipe__ctor_Divine_Protobufs_Dota2_CMsgClientToGCCreateStaticRecipe_"></a> CMsgClientToGCCreateStaticRecipe\(CMsgClientToGCCreateStaticRecipe\)

```csharp
public CMsgClientToGCCreateStaticRecipe(CMsgClientToGCCreateStaticRecipe other)
```

#### Parameters

`other` [CMsgClientToGCCreateStaticRecipe](Divine.Protobufs.Dota2.CMsgClientToGCCreateStaticRecipe.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStaticRecipe_ItemsFieldNumber"></a> ItemsFieldNumber

```csharp
public const int ItemsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStaticRecipe_RecipeDefIndexFieldNumber"></a> RecipeDefIndexFieldNumber

```csharp
public const int RecipeDefIndexFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStaticRecipe_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStaticRecipe_HasRecipeDefIndex"></a> HasRecipeDefIndex

```csharp
public bool HasRecipeDefIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStaticRecipe_Items"></a> Items

```csharp
public RepeatedField<CMsgClientToGCCreateStaticRecipe.Types.Item> Items { get; }
```

#### Property Value

 RepeatedField<[CMsgClientToGCCreateStaticRecipe](Divine.Protobufs.Dota2.CMsgClientToGCCreateStaticRecipe.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCCreateStaticRecipe.Types.md).[Item](Divine.Protobufs.Dota2.CMsgClientToGCCreateStaticRecipe.Types.Item.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStaticRecipe_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCCreateStaticRecipe> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCCreateStaticRecipe](Divine.Protobufs.Dota2.CMsgClientToGCCreateStaticRecipe.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStaticRecipe_RecipeDefIndex"></a> RecipeDefIndex

```csharp
public uint RecipeDefIndex { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStaticRecipe_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStaticRecipe_ClearRecipeDefIndex"></a> ClearRecipeDefIndex\(\)

```csharp
public void ClearRecipeDefIndex()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStaticRecipe_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCCreateStaticRecipe Clone()
```

#### Returns

 [CMsgClientToGCCreateStaticRecipe](Divine.Protobufs.Dota2.CMsgClientToGCCreateStaticRecipe.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStaticRecipe_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStaticRecipe_Equals_Divine_Protobufs_Dota2_CMsgClientToGCCreateStaticRecipe_"></a> Equals\(CMsgClientToGCCreateStaticRecipe\)

```csharp
public bool Equals(CMsgClientToGCCreateStaticRecipe other)
```

#### Parameters

`other` [CMsgClientToGCCreateStaticRecipe](Divine.Protobufs.Dota2.CMsgClientToGCCreateStaticRecipe.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStaticRecipe_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStaticRecipe_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCCreateStaticRecipe_"></a> MergeFrom\(CMsgClientToGCCreateStaticRecipe\)

```csharp
public void MergeFrom(CMsgClientToGCCreateStaticRecipe other)
```

#### Parameters

`other` [CMsgClientToGCCreateStaticRecipe](Divine.Protobufs.Dota2.CMsgClientToGCCreateStaticRecipe.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStaticRecipe_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStaticRecipe_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStaticRecipe_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

