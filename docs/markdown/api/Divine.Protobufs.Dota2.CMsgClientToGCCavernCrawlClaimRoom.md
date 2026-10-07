# <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlClaimRoom"></a> Class CMsgClientToGCCavernCrawlClaimRoom

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCCavernCrawlClaimRoom : IMessage<CMsgClientToGCCavernCrawlClaimRoom>, IEquatable<CMsgClientToGCCavernCrawlClaimRoom>, IDeepCloneable<CMsgClientToGCCavernCrawlClaimRoom>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCCavernCrawlClaimRoom](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlClaimRoom.md)

#### Implements

IMessage<CMsgClientToGCCavernCrawlClaimRoom\>, 
[IEquatable<CMsgClientToGCCavernCrawlClaimRoom\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCCavernCrawlClaimRoom\>, 
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
[EnumerableExtensions.In<CMsgClientToGCCavernCrawlClaimRoom\>\(CMsgClientToGCCavernCrawlClaimRoom, params CMsgClientToGCCavernCrawlClaimRoom\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlClaimRoom__ctor"></a> CMsgClientToGCCavernCrawlClaimRoom\(\)

```csharp
public CMsgClientToGCCavernCrawlClaimRoom()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlClaimRoom__ctor_Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlClaimRoom_"></a> CMsgClientToGCCavernCrawlClaimRoom\(CMsgClientToGCCavernCrawlClaimRoom\)

```csharp
public CMsgClientToGCCavernCrawlClaimRoom(CMsgClientToGCCavernCrawlClaimRoom other)
```

#### Parameters

`other` [CMsgClientToGCCavernCrawlClaimRoom](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlClaimRoom.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlClaimRoom_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlClaimRoom_MapVariantFieldNumber"></a> MapVariantFieldNumber

```csharp
public const int MapVariantFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlClaimRoom_RoomIdFieldNumber"></a> RoomIdFieldNumber

```csharp
public const int RoomIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlClaimRoom_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlClaimRoom_EventId"></a> EventId

```csharp
public uint EventId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlClaimRoom_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlClaimRoom_HasMapVariant"></a> HasMapVariant

```csharp
public bool HasMapVariant { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlClaimRoom_HasRoomId"></a> HasRoomId

```csharp
public bool HasRoomId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlClaimRoom_MapVariant"></a> MapVariant

```csharp
public uint MapVariant { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlClaimRoom_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCCavernCrawlClaimRoom> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCCavernCrawlClaimRoom](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlClaimRoom.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlClaimRoom_RoomId"></a> RoomId

```csharp
public uint RoomId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlClaimRoom_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlClaimRoom_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlClaimRoom_ClearMapVariant"></a> ClearMapVariant\(\)

```csharp
public void ClearMapVariant()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlClaimRoom_ClearRoomId"></a> ClearRoomId\(\)

```csharp
public void ClearRoomId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlClaimRoom_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCCavernCrawlClaimRoom Clone()
```

#### Returns

 [CMsgClientToGCCavernCrawlClaimRoom](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlClaimRoom.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlClaimRoom_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlClaimRoom_Equals_Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlClaimRoom_"></a> Equals\(CMsgClientToGCCavernCrawlClaimRoom\)

```csharp
public bool Equals(CMsgClientToGCCavernCrawlClaimRoom other)
```

#### Parameters

`other` [CMsgClientToGCCavernCrawlClaimRoom](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlClaimRoom.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlClaimRoom_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlClaimRoom_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlClaimRoom_"></a> MergeFrom\(CMsgClientToGCCavernCrawlClaimRoom\)

```csharp
public void MergeFrom(CMsgClientToGCCavernCrawlClaimRoom other)
```

#### Parameters

`other` [CMsgClientToGCCavernCrawlClaimRoom](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlClaimRoom.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlClaimRoom_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlClaimRoom_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlClaimRoom_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

