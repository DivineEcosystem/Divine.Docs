# <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoExchange"></a> Class CMsgClientToGCCandyShopDoExchange

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCCandyShopDoExchange : IMessage<CMsgClientToGCCandyShopDoExchange>, IEquatable<CMsgClientToGCCandyShopDoExchange>, IDeepCloneable<CMsgClientToGCCandyShopDoExchange>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCCandyShopDoExchange](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopDoExchange.md)

#### Implements

IMessage<CMsgClientToGCCandyShopDoExchange\>, 
[IEquatable<CMsgClientToGCCandyShopDoExchange\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCCandyShopDoExchange\>, 
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
[EnumerableExtensions.In<CMsgClientToGCCandyShopDoExchange\>\(CMsgClientToGCCandyShopDoExchange, params CMsgClientToGCCandyShopDoExchange\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoExchange__ctor"></a> CMsgClientToGCCandyShopDoExchange\(\)

```csharp
public CMsgClientToGCCandyShopDoExchange()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoExchange__ctor_Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoExchange_"></a> CMsgClientToGCCandyShopDoExchange\(CMsgClientToGCCandyShopDoExchange\)

```csharp
public CMsgClientToGCCandyShopDoExchange(CMsgClientToGCCandyShopDoExchange other)
```

#### Parameters

`other` [CMsgClientToGCCandyShopDoExchange](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopDoExchange.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoExchange_CandyShopIdFieldNumber"></a> CandyShopIdFieldNumber

```csharp
public const int CandyShopIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoExchange_RecipeIdFieldNumber"></a> RecipeIdFieldNumber

```csharp
public const int RecipeIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoExchange_CandyShopId"></a> CandyShopId

```csharp
public uint CandyShopId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoExchange_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoExchange_HasCandyShopId"></a> HasCandyShopId

```csharp
public bool HasCandyShopId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoExchange_HasRecipeId"></a> HasRecipeId

```csharp
public bool HasRecipeId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoExchange_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCCandyShopDoExchange> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCCandyShopDoExchange](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopDoExchange.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoExchange_RecipeId"></a> RecipeId

```csharp
public uint RecipeId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoExchange_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoExchange_ClearCandyShopId"></a> ClearCandyShopId\(\)

```csharp
public void ClearCandyShopId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoExchange_ClearRecipeId"></a> ClearRecipeId\(\)

```csharp
public void ClearRecipeId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoExchange_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCCandyShopDoExchange Clone()
```

#### Returns

 [CMsgClientToGCCandyShopDoExchange](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopDoExchange.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoExchange_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoExchange_Equals_Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoExchange_"></a> Equals\(CMsgClientToGCCandyShopDoExchange\)

```csharp
public bool Equals(CMsgClientToGCCandyShopDoExchange other)
```

#### Parameters

`other` [CMsgClientToGCCandyShopDoExchange](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopDoExchange.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoExchange_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoExchange_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoExchange_"></a> MergeFrom\(CMsgClientToGCCandyShopDoExchange\)

```csharp
public void MergeFrom(CMsgClientToGCCandyShopDoExchange other)
```

#### Parameters

`other` [CMsgClientToGCCandyShopDoExchange](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopDoExchange.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoExchange_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoExchange_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoExchange_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

