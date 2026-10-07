# <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIUseItem"></a> Class CMsgClientToGCRoadToTIUseItem

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCRoadToTIUseItem : IMessage<CMsgClientToGCRoadToTIUseItem>, IEquatable<CMsgClientToGCRoadToTIUseItem>, IDeepCloneable<CMsgClientToGCRoadToTIUseItem>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCRoadToTIUseItem](Divine.Protobufs.Dota2.CMsgClientToGCRoadToTIUseItem.md)

#### Implements

IMessage<CMsgClientToGCRoadToTIUseItem\>, 
[IEquatable<CMsgClientToGCRoadToTIUseItem\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCRoadToTIUseItem\>, 
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
[EnumerableExtensions.In<CMsgClientToGCRoadToTIUseItem\>\(CMsgClientToGCRoadToTIUseItem, params CMsgClientToGCRoadToTIUseItem\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIUseItem__ctor"></a> CMsgClientToGCRoadToTIUseItem\(\)

```csharp
public CMsgClientToGCRoadToTIUseItem()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIUseItem__ctor_Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIUseItem_"></a> CMsgClientToGCRoadToTIUseItem\(CMsgClientToGCRoadToTIUseItem\)

```csharp
public CMsgClientToGCRoadToTIUseItem(CMsgClientToGCRoadToTIUseItem other)
```

#### Parameters

`other` [CMsgClientToGCRoadToTIUseItem](Divine.Protobufs.Dota2.CMsgClientToGCRoadToTIUseItem.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIUseItem_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIUseItem_HeroIndexFieldNumber"></a> HeroIndexFieldNumber

```csharp
public const int HeroIndexFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIUseItem_ItemTypeFieldNumber"></a> ItemTypeFieldNumber

```csharp
public const int ItemTypeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIUseItem_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIUseItem_EventId"></a> EventId

```csharp
public uint EventId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIUseItem_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIUseItem_HasHeroIndex"></a> HasHeroIndex

```csharp
public bool HasHeroIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIUseItem_HasItemType"></a> HasItemType

```csharp
public bool HasItemType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIUseItem_HeroIndex"></a> HeroIndex

```csharp
public uint HeroIndex { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIUseItem_ItemType"></a> ItemType

```csharp
public uint ItemType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIUseItem_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCRoadToTIUseItem> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCRoadToTIUseItem](Divine.Protobufs.Dota2.CMsgClientToGCRoadToTIUseItem.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIUseItem_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIUseItem_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIUseItem_ClearHeroIndex"></a> ClearHeroIndex\(\)

```csharp
public void ClearHeroIndex()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIUseItem_ClearItemType"></a> ClearItemType\(\)

```csharp
public void ClearItemType()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIUseItem_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCRoadToTIUseItem Clone()
```

#### Returns

 [CMsgClientToGCRoadToTIUseItem](Divine.Protobufs.Dota2.CMsgClientToGCRoadToTIUseItem.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIUseItem_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIUseItem_Equals_Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIUseItem_"></a> Equals\(CMsgClientToGCRoadToTIUseItem\)

```csharp
public bool Equals(CMsgClientToGCRoadToTIUseItem other)
```

#### Parameters

`other` [CMsgClientToGCRoadToTIUseItem](Divine.Protobufs.Dota2.CMsgClientToGCRoadToTIUseItem.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIUseItem_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIUseItem_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIUseItem_"></a> MergeFrom\(CMsgClientToGCRoadToTIUseItem\)

```csharp
public void MergeFrom(CMsgClientToGCRoadToTIUseItem other)
```

#### Parameters

`other` [CMsgClientToGCRoadToTIUseItem](Divine.Protobufs.Dota2.CMsgClientToGCRoadToTIUseItem.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIUseItem_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIUseItem_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIUseItem_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

