# <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnRoom"></a> Class CMsgClientToGCCavernCrawlUseItemOnRoom

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCCavernCrawlUseItemOnRoom : IMessage<CMsgClientToGCCavernCrawlUseItemOnRoom>, IEquatable<CMsgClientToGCCavernCrawlUseItemOnRoom>, IDeepCloneable<CMsgClientToGCCavernCrawlUseItemOnRoom>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCCavernCrawlUseItemOnRoom](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlUseItemOnRoom.md)

#### Implements

IMessage<CMsgClientToGCCavernCrawlUseItemOnRoom\>, 
[IEquatable<CMsgClientToGCCavernCrawlUseItemOnRoom\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCCavernCrawlUseItemOnRoom\>, 
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
[EnumerableExtensions.In<CMsgClientToGCCavernCrawlUseItemOnRoom\>\(CMsgClientToGCCavernCrawlUseItemOnRoom, params CMsgClientToGCCavernCrawlUseItemOnRoom\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnRoom__ctor"></a> CMsgClientToGCCavernCrawlUseItemOnRoom\(\)

```csharp
public CMsgClientToGCCavernCrawlUseItemOnRoom()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnRoom__ctor_Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnRoom_"></a> CMsgClientToGCCavernCrawlUseItemOnRoom\(CMsgClientToGCCavernCrawlUseItemOnRoom\)

```csharp
public CMsgClientToGCCavernCrawlUseItemOnRoom(CMsgClientToGCCavernCrawlUseItemOnRoom other)
```

#### Parameters

`other` [CMsgClientToGCCavernCrawlUseItemOnRoom](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlUseItemOnRoom.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnRoom_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnRoom_ItemTypeFieldNumber"></a> ItemTypeFieldNumber

```csharp
public const int ItemTypeFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnRoom_MapVariantFieldNumber"></a> MapVariantFieldNumber

```csharp
public const int MapVariantFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnRoom_RoomIdFieldNumber"></a> RoomIdFieldNumber

```csharp
public const int RoomIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnRoom_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnRoom_EventId"></a> EventId

```csharp
public uint EventId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnRoom_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnRoom_HasItemType"></a> HasItemType

```csharp
public bool HasItemType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnRoom_HasMapVariant"></a> HasMapVariant

```csharp
public bool HasMapVariant { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnRoom_HasRoomId"></a> HasRoomId

```csharp
public bool HasRoomId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnRoom_ItemType"></a> ItemType

```csharp
public uint ItemType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnRoom_MapVariant"></a> MapVariant

```csharp
public uint MapVariant { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnRoom_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCCavernCrawlUseItemOnRoom> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCCavernCrawlUseItemOnRoom](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlUseItemOnRoom.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnRoom_RoomId"></a> RoomId

```csharp
public uint RoomId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnRoom_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnRoom_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnRoom_ClearItemType"></a> ClearItemType\(\)

```csharp
public void ClearItemType()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnRoom_ClearMapVariant"></a> ClearMapVariant\(\)

```csharp
public void ClearMapVariant()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnRoom_ClearRoomId"></a> ClearRoomId\(\)

```csharp
public void ClearRoomId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnRoom_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCCavernCrawlUseItemOnRoom Clone()
```

#### Returns

 [CMsgClientToGCCavernCrawlUseItemOnRoom](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlUseItemOnRoom.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnRoom_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnRoom_Equals_Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnRoom_"></a> Equals\(CMsgClientToGCCavernCrawlUseItemOnRoom\)

```csharp
public bool Equals(CMsgClientToGCCavernCrawlUseItemOnRoom other)
```

#### Parameters

`other` [CMsgClientToGCCavernCrawlUseItemOnRoom](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlUseItemOnRoom.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnRoom_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnRoom_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnRoom_"></a> MergeFrom\(CMsgClientToGCCavernCrawlUseItemOnRoom\)

```csharp
public void MergeFrom(CMsgClientToGCCavernCrawlUseItemOnRoom other)
```

#### Parameters

`other` [CMsgClientToGCCavernCrawlUseItemOnRoom](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlUseItemOnRoom.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnRoom_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnRoom_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnRoom_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

