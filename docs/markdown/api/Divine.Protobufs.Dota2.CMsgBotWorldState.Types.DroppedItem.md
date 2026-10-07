# <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_DroppedItem"></a> Class CMsgBotWorldState.Types.DroppedItem

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgBotWorldState.Types.DroppedItem : IMessage<CMsgBotWorldState.Types.DroppedItem>, IEquatable<CMsgBotWorldState.Types.DroppedItem>, IDeepCloneable<CMsgBotWorldState.Types.DroppedItem>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgBotWorldState.Types.DroppedItem](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.DroppedItem.md)

#### Implements

IMessage<CMsgBotWorldState.Types.DroppedItem\>, 
[IEquatable<CMsgBotWorldState.Types.DroppedItem\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgBotWorldState.Types.DroppedItem\>, 
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
[EnumerableExtensions.In<CMsgBotWorldState.Types.DroppedItem\>\(CMsgBotWorldState.Types.DroppedItem, params CMsgBotWorldState.Types.DroppedItem\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_DroppedItem__ctor"></a> DroppedItem\(\)

```csharp
public DroppedItem()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_DroppedItem__ctor_Divine_Protobufs_Dota2_CMsgBotWorldState_Types_DroppedItem_"></a> DroppedItem\(DroppedItem\)

```csharp
public DroppedItem(CMsgBotWorldState.Types.DroppedItem other)
```

#### Parameters

`other` [CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[DroppedItem](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.DroppedItem.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_DroppedItem_ItemIdFieldNumber"></a> ItemIdFieldNumber

```csharp
public const int ItemIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_DroppedItem_LocationFieldNumber"></a> LocationFieldNumber

```csharp
public const int LocationFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_DroppedItem_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_DroppedItem_HasItemId"></a> HasItemId

```csharp
public bool HasItemId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_DroppedItem_ItemId"></a> ItemId

```csharp
public int ItemId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_DroppedItem_Location"></a> Location

```csharp
public CMsgBotWorldState.Types.Vector Location { get; set; }
```

#### Property Value

 [CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[Vector](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.Vector.md)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_DroppedItem_Parser"></a> Parser

```csharp
public static MessageParser<CMsgBotWorldState.Types.DroppedItem> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[DroppedItem](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.DroppedItem.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_DroppedItem_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_DroppedItem_ClearItemId"></a> ClearItemId\(\)

```csharp
public void ClearItemId()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_DroppedItem_Clone"></a> Clone\(\)

```csharp
public CMsgBotWorldState.Types.DroppedItem Clone()
```

#### Returns

 [CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[DroppedItem](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.DroppedItem.md)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_DroppedItem_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_DroppedItem_Equals_Divine_Protobufs_Dota2_CMsgBotWorldState_Types_DroppedItem_"></a> Equals\(DroppedItem\)

```csharp
public bool Equals(CMsgBotWorldState.Types.DroppedItem other)
```

#### Parameters

`other` [CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[DroppedItem](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.DroppedItem.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_DroppedItem_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_DroppedItem_MergeFrom_Divine_Protobufs_Dota2_CMsgBotWorldState_Types_DroppedItem_"></a> MergeFrom\(DroppedItem\)

```csharp
public void MergeFrom(CMsgBotWorldState.Types.DroppedItem other)
```

#### Parameters

`other` [CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[DroppedItem](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.DroppedItem.md)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_DroppedItem_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_DroppedItem_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_DroppedItem_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

