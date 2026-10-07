# <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemContainer"></a> Class CMsgItemBattlerItemContainer

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgItemBattlerItemContainer : IMessage<CMsgItemBattlerItemContainer>, IEquatable<CMsgItemBattlerItemContainer>, IDeepCloneable<CMsgItemBattlerItemContainer>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgItemBattlerItemContainer](Divine.Protobufs.Dota2.CMsgItemBattlerItemContainer.md)

#### Implements

IMessage<CMsgItemBattlerItemContainer\>, 
[IEquatable<CMsgItemBattlerItemContainer\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgItemBattlerItemContainer\>, 
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
[EnumerableExtensions.In<CMsgItemBattlerItemContainer\>\(CMsgItemBattlerItemContainer, params CMsgItemBattlerItemContainer\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemContainer__ctor"></a> CMsgItemBattlerItemContainer\(\)

```csharp
public CMsgItemBattlerItemContainer()
```

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemContainer__ctor_Divine_Protobufs_Dota2_CMsgItemBattlerItemContainer_"></a> CMsgItemBattlerItemContainer\(CMsgItemBattlerItemContainer\)

```csharp
public CMsgItemBattlerItemContainer(CMsgItemBattlerItemContainer other)
```

#### Parameters

`other` [CMsgItemBattlerItemContainer](Divine.Protobufs.Dota2.CMsgItemBattlerItemContainer.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemContainer_HeightFieldNumber"></a> HeightFieldNumber

```csharp
public const int HeightFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemContainer_IsShopFieldNumber"></a> IsShopFieldNumber

```csharp
public const int IsShopFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemContainer_ItemContainerIdFieldNumber"></a> ItemContainerIdFieldNumber

```csharp
public const int ItemContainerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemContainer_ItemSlotIdsFieldNumber"></a> ItemSlotIdsFieldNumber

```csharp
public const int ItemSlotIdsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemContainer_WidthFieldNumber"></a> WidthFieldNumber

```csharp
public const int WidthFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemContainer_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemContainer_HasHeight"></a> HasHeight

```csharp
public bool HasHeight { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemContainer_HasIsShop"></a> HasIsShop

```csharp
public bool HasIsShop { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemContainer_HasItemContainerId"></a> HasItemContainerId

```csharp
public bool HasItemContainerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemContainer_HasWidth"></a> HasWidth

```csharp
public bool HasWidth { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemContainer_Height"></a> Height

```csharp
public int Height { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemContainer_IsShop"></a> IsShop

```csharp
public bool IsShop { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemContainer_ItemContainerId"></a> ItemContainerId

```csharp
public uint ItemContainerId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemContainer_ItemSlotIds"></a> ItemSlotIds

```csharp
public RepeatedField<uint> ItemSlotIds { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemContainer_Parser"></a> Parser

```csharp
public static MessageParser<CMsgItemBattlerItemContainer> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgItemBattlerItemContainer](Divine.Protobufs.Dota2.CMsgItemBattlerItemContainer.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemContainer_Width"></a> Width

```csharp
public int Width { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemContainer_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemContainer_ClearHeight"></a> ClearHeight\(\)

```csharp
public void ClearHeight()
```

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemContainer_ClearIsShop"></a> ClearIsShop\(\)

```csharp
public void ClearIsShop()
```

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemContainer_ClearItemContainerId"></a> ClearItemContainerId\(\)

```csharp
public void ClearItemContainerId()
```

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemContainer_ClearWidth"></a> ClearWidth\(\)

```csharp
public void ClearWidth()
```

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemContainer_Clone"></a> Clone\(\)

```csharp
public CMsgItemBattlerItemContainer Clone()
```

#### Returns

 [CMsgItemBattlerItemContainer](Divine.Protobufs.Dota2.CMsgItemBattlerItemContainer.md)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemContainer_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemContainer_Equals_Divine_Protobufs_Dota2_CMsgItemBattlerItemContainer_"></a> Equals\(CMsgItemBattlerItemContainer\)

```csharp
public bool Equals(CMsgItemBattlerItemContainer other)
```

#### Parameters

`other` [CMsgItemBattlerItemContainer](Divine.Protobufs.Dota2.CMsgItemBattlerItemContainer.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemContainer_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemContainer_MergeFrom_Divine_Protobufs_Dota2_CMsgItemBattlerItemContainer_"></a> MergeFrom\(CMsgItemBattlerItemContainer\)

```csharp
public void MergeFrom(CMsgItemBattlerItemContainer other)
```

#### Parameters

`other` [CMsgItemBattlerItemContainer](Divine.Protobufs.Dota2.CMsgItemBattlerItemContainer.md)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemContainer_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemContainer_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemContainer_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

