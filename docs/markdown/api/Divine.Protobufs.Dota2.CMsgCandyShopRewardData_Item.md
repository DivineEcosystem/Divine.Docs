# <a id="Divine_Protobufs_Dota2_CMsgCandyShopRewardData_Item"></a> Class CMsgCandyShopRewardData\_Item

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgCandyShopRewardData_Item : IMessage<CMsgCandyShopRewardData_Item>, IEquatable<CMsgCandyShopRewardData_Item>, IDeepCloneable<CMsgCandyShopRewardData_Item>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgCandyShopRewardData\_Item](Divine.Protobufs.Dota2.CMsgCandyShopRewardData\_Item.md)

#### Implements

IMessage<CMsgCandyShopRewardData\_Item\>, 
[IEquatable<CMsgCandyShopRewardData\_Item\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgCandyShopRewardData\_Item\>, 
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
[EnumerableExtensions.In<CMsgCandyShopRewardData\_Item\>\(CMsgCandyShopRewardData\_Item, params CMsgCandyShopRewardData\_Item\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopRewardData_Item__ctor"></a> CMsgCandyShopRewardData\_Item\(\)

```csharp
public CMsgCandyShopRewardData_Item()
```

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopRewardData_Item__ctor_Divine_Protobufs_Dota2_CMsgCandyShopRewardData_Item_"></a> CMsgCandyShopRewardData\_Item\(CMsgCandyShopRewardData\_Item\)

```csharp
public CMsgCandyShopRewardData_Item(CMsgCandyShopRewardData_Item other)
```

#### Parameters

`other` [CMsgCandyShopRewardData\_Item](Divine.Protobufs.Dota2.CMsgCandyShopRewardData\_Item.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopRewardData_Item_ItemDefFieldNumber"></a> ItemDefFieldNumber

```csharp
public const int ItemDefFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopRewardData_Item_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopRewardData_Item_HasItemDef"></a> HasItemDef

```csharp
public bool HasItemDef { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopRewardData_Item_ItemDef"></a> ItemDef

```csharp
public uint ItemDef { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopRewardData_Item_Parser"></a> Parser

```csharp
public static MessageParser<CMsgCandyShopRewardData_Item> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgCandyShopRewardData\_Item](Divine.Protobufs.Dota2.CMsgCandyShopRewardData\_Item.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopRewardData_Item_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopRewardData_Item_ClearItemDef"></a> ClearItemDef\(\)

```csharp
public void ClearItemDef()
```

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopRewardData_Item_Clone"></a> Clone\(\)

```csharp
public CMsgCandyShopRewardData_Item Clone()
```

#### Returns

 [CMsgCandyShopRewardData\_Item](Divine.Protobufs.Dota2.CMsgCandyShopRewardData\_Item.md)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopRewardData_Item_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopRewardData_Item_Equals_Divine_Protobufs_Dota2_CMsgCandyShopRewardData_Item_"></a> Equals\(CMsgCandyShopRewardData\_Item\)

```csharp
public bool Equals(CMsgCandyShopRewardData_Item other)
```

#### Parameters

`other` [CMsgCandyShopRewardData\_Item](Divine.Protobufs.Dota2.CMsgCandyShopRewardData\_Item.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopRewardData_Item_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopRewardData_Item_MergeFrom_Divine_Protobufs_Dota2_CMsgCandyShopRewardData_Item_"></a> MergeFrom\(CMsgCandyShopRewardData\_Item\)

```csharp
public void MergeFrom(CMsgCandyShopRewardData_Item other)
```

#### Parameters

`other` [CMsgCandyShopRewardData\_Item](Divine.Protobufs.Dota2.CMsgCandyShopRewardData\_Item.md)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopRewardData_Item_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopRewardData_Item_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopRewardData_Item_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

