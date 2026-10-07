# <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_TreasureMap"></a> Class CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.TreasureMap

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.TreasureMap : IMessage<CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.TreasureMap>, IEquatable<CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.TreasureMap>, IDeepCloneable<CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.TreasureMap>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.TreasureMap](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.TreasureMap.md)

#### Implements

IMessage<CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.TreasureMap\>, 
[IEquatable<CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.TreasureMap\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.TreasureMap\>, 
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
[EnumerableExtensions.In<CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.TreasureMap\>\(CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.TreasureMap, params CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.TreasureMap\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_TreasureMap__ctor"></a> TreasureMap\(\)

```csharp
public TreasureMap()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_TreasureMap__ctor_Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_TreasureMap_"></a> TreasureMap\(TreasureMap\)

```csharp
public TreasureMap(CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.TreasureMap other)
```

#### Parameters

`other` [CMsgClientToGCCavernCrawlRequestMapStateResponse](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlRequestMapStateResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.md).[TreasureMap](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.TreasureMap.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_TreasureMap_MapRoomIdFieldNumber"></a> MapRoomIdFieldNumber

```csharp
public const int MapRoomIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_TreasureMap_RevealedRoomIdFieldNumber"></a> RevealedRoomIdFieldNumber

```csharp
public const int RevealedRoomIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_TreasureMap_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_TreasureMap_HasMapRoomId"></a> HasMapRoomId

```csharp
public bool HasMapRoomId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_TreasureMap_HasRevealedRoomId"></a> HasRevealedRoomId

```csharp
public bool HasRevealedRoomId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_TreasureMap_MapRoomId"></a> MapRoomId

```csharp
public uint MapRoomId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_TreasureMap_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.TreasureMap> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCCavernCrawlRequestMapStateResponse](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlRequestMapStateResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.md).[TreasureMap](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.TreasureMap.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_TreasureMap_RevealedRoomId"></a> RevealedRoomId

```csharp
public uint RevealedRoomId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_TreasureMap_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_TreasureMap_ClearMapRoomId"></a> ClearMapRoomId\(\)

```csharp
public void ClearMapRoomId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_TreasureMap_ClearRevealedRoomId"></a> ClearRevealedRoomId\(\)

```csharp
public void ClearRevealedRoomId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_TreasureMap_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.TreasureMap Clone()
```

#### Returns

 [CMsgClientToGCCavernCrawlRequestMapStateResponse](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlRequestMapStateResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.md).[TreasureMap](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.TreasureMap.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_TreasureMap_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_TreasureMap_Equals_Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_TreasureMap_"></a> Equals\(TreasureMap\)

```csharp
public bool Equals(CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.TreasureMap other)
```

#### Parameters

`other` [CMsgClientToGCCavernCrawlRequestMapStateResponse](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlRequestMapStateResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.md).[TreasureMap](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.TreasureMap.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_TreasureMap_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_TreasureMap_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_TreasureMap_"></a> MergeFrom\(TreasureMap\)

```csharp
public void MergeFrom(CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.TreasureMap other)
```

#### Parameters

`other` [CMsgClientToGCCavernCrawlRequestMapStateResponse](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlRequestMapStateResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.md).[TreasureMap](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.TreasureMap.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_TreasureMap_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_TreasureMap_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Types_TreasureMap_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

