# <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItem"></a> Class CMsgItemBattlerItem

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgItemBattlerItem : IMessage<CMsgItemBattlerItem>, IEquatable<CMsgItemBattlerItem>, IDeepCloneable<CMsgItemBattlerItem>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgItemBattlerItem](Divine.Protobufs.Dota2.CMsgItemBattlerItem.md)

#### Implements

IMessage<CMsgItemBattlerItem\>, 
[IEquatable<CMsgItemBattlerItem\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgItemBattlerItem\>, 
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
[EnumerableExtensions.In<CMsgItemBattlerItem\>\(CMsgItemBattlerItem, params CMsgItemBattlerItem\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItem__ctor"></a> CMsgItemBattlerItem\(\)

```csharp
public CMsgItemBattlerItem()
```

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItem__ctor_Divine_Protobufs_Dota2_CMsgItemBattlerItem_"></a> CMsgItemBattlerItem\(CMsgItemBattlerItem\)

```csharp
public CMsgItemBattlerItem(CMsgItemBattlerItem other)
```

#### Parameters

`other` [CMsgItemBattlerItem](Divine.Protobufs.Dota2.CMsgItemBattlerItem.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItem_ItemContainerIdFieldNumber"></a> ItemContainerIdFieldNumber

```csharp
public const int ItemContainerIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItem_ItemDefinitionIdFieldNumber"></a> ItemDefinitionIdFieldNumber

```csharp
public const int ItemDefinitionIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItem_ItemInstanceIdFieldNumber"></a> ItemInstanceIdFieldNumber

```csharp
public const int ItemInstanceIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItem_PermanentModifiersFieldNumber"></a> PermanentModifiersFieldNumber

```csharp
public const int PermanentModifiersFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItem_PositionXFieldNumber"></a> PositionXFieldNumber

```csharp
public const int PositionXFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItem_PositionYFieldNumber"></a> PositionYFieldNumber

```csharp
public const int PositionYFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItem_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItem_HasItemContainerId"></a> HasItemContainerId

```csharp
public bool HasItemContainerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItem_HasItemDefinitionId"></a> HasItemDefinitionId

```csharp
public bool HasItemDefinitionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItem_HasItemInstanceId"></a> HasItemInstanceId

```csharp
public bool HasItemInstanceId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItem_HasPositionX"></a> HasPositionX

```csharp
public bool HasPositionX { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItem_HasPositionY"></a> HasPositionY

```csharp
public bool HasPositionY { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItem_ItemContainerId"></a> ItemContainerId

```csharp
public uint ItemContainerId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItem_ItemDefinitionId"></a> ItemDefinitionId

```csharp
public uint ItemDefinitionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItem_ItemInstanceId"></a> ItemInstanceId

```csharp
public uint ItemInstanceId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItem_Parser"></a> Parser

```csharp
public static MessageParser<CMsgItemBattlerItem> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgItemBattlerItem](Divine.Protobufs.Dota2.CMsgItemBattlerItem.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItem_PermanentModifiers"></a> PermanentModifiers

```csharp
public RepeatedField<CMsgItemBattlerItemModifier> PermanentModifiers { get; }
```

#### Property Value

 RepeatedField<[CMsgItemBattlerItemModifier](Divine.Protobufs.Dota2.CMsgItemBattlerItemModifier.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItem_PositionX"></a> PositionX

```csharp
public uint PositionX { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItem_PositionY"></a> PositionY

```csharp
public uint PositionY { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItem_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItem_ClearItemContainerId"></a> ClearItemContainerId\(\)

```csharp
public void ClearItemContainerId()
```

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItem_ClearItemDefinitionId"></a> ClearItemDefinitionId\(\)

```csharp
public void ClearItemDefinitionId()
```

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItem_ClearItemInstanceId"></a> ClearItemInstanceId\(\)

```csharp
public void ClearItemInstanceId()
```

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItem_ClearPositionX"></a> ClearPositionX\(\)

```csharp
public void ClearPositionX()
```

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItem_ClearPositionY"></a> ClearPositionY\(\)

```csharp
public void ClearPositionY()
```

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItem_Clone"></a> Clone\(\)

```csharp
public CMsgItemBattlerItem Clone()
```

#### Returns

 [CMsgItemBattlerItem](Divine.Protobufs.Dota2.CMsgItemBattlerItem.md)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItem_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItem_Equals_Divine_Protobufs_Dota2_CMsgItemBattlerItem_"></a> Equals\(CMsgItemBattlerItem\)

```csharp
public bool Equals(CMsgItemBattlerItem other)
```

#### Parameters

`other` [CMsgItemBattlerItem](Divine.Protobufs.Dota2.CMsgItemBattlerItem.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItem_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItem_MergeFrom_Divine_Protobufs_Dota2_CMsgItemBattlerItem_"></a> MergeFrom\(CMsgItemBattlerItem\)

```csharp
public void MergeFrom(CMsgItemBattlerItem other)
```

#### Parameters

`other` [CMsgItemBattlerItem](Divine.Protobufs.Dota2.CMsgItemBattlerItem.md)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItem_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItem_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItem_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

