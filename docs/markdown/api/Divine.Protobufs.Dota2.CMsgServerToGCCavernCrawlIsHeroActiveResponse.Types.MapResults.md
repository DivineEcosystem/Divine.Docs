# <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActiveResponse_Types_MapResults"></a> Class CMsgServerToGCCavernCrawlIsHeroActiveResponse.Types.MapResults

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgServerToGCCavernCrawlIsHeroActiveResponse.Types.MapResults : IMessage<CMsgServerToGCCavernCrawlIsHeroActiveResponse.Types.MapResults>, IEquatable<CMsgServerToGCCavernCrawlIsHeroActiveResponse.Types.MapResults>, IDeepCloneable<CMsgServerToGCCavernCrawlIsHeroActiveResponse.Types.MapResults>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgServerToGCCavernCrawlIsHeroActiveResponse.Types.MapResults](Divine.Protobufs.Dota2.CMsgServerToGCCavernCrawlIsHeroActiveResponse.Types.MapResults.md)

#### Implements

IMessage<CMsgServerToGCCavernCrawlIsHeroActiveResponse.Types.MapResults\>, 
[IEquatable<CMsgServerToGCCavernCrawlIsHeroActiveResponse.Types.MapResults\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgServerToGCCavernCrawlIsHeroActiveResponse.Types.MapResults\>, 
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
[EnumerableExtensions.In<CMsgServerToGCCavernCrawlIsHeroActiveResponse.Types.MapResults\>\(CMsgServerToGCCavernCrawlIsHeroActiveResponse.Types.MapResults, params CMsgServerToGCCavernCrawlIsHeroActiveResponse.Types.MapResults\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActiveResponse_Types_MapResults__ctor"></a> MapResults\(\)

```csharp
public MapResults()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActiveResponse_Types_MapResults__ctor_Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActiveResponse_Types_MapResults_"></a> MapResults\(MapResults\)

```csharp
public MapResults(CMsgServerToGCCavernCrawlIsHeroActiveResponse.Types.MapResults other)
```

#### Parameters

`other` [CMsgServerToGCCavernCrawlIsHeroActiveResponse](Divine.Protobufs.Dota2.CMsgServerToGCCavernCrawlIsHeroActiveResponse.md).[Types](Divine.Protobufs.Dota2.CMsgServerToGCCavernCrawlIsHeroActiveResponse.Types.md).[MapResults](Divine.Protobufs.Dota2.CMsgServerToGCCavernCrawlIsHeroActiveResponse.Types.MapResults.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActiveResponse_Types_MapResults_PathIdCompletedFieldNumber"></a> PathIdCompletedFieldNumber

```csharp
public const int PathIdCompletedFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActiveResponse_Types_MapResults_RoomIdClaimedFieldNumber"></a> RoomIdClaimedFieldNumber

```csharp
public const int RoomIdClaimedFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActiveResponse_Types_MapResults_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActiveResponse_Types_MapResults_HasPathIdCompleted"></a> HasPathIdCompleted

```csharp
public bool HasPathIdCompleted { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActiveResponse_Types_MapResults_HasRoomIdClaimed"></a> HasRoomIdClaimed

```csharp
public bool HasRoomIdClaimed { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActiveResponse_Types_MapResults_Parser"></a> Parser

```csharp
public static MessageParser<CMsgServerToGCCavernCrawlIsHeroActiveResponse.Types.MapResults> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgServerToGCCavernCrawlIsHeroActiveResponse](Divine.Protobufs.Dota2.CMsgServerToGCCavernCrawlIsHeroActiveResponse.md).[Types](Divine.Protobufs.Dota2.CMsgServerToGCCavernCrawlIsHeroActiveResponse.Types.md).[MapResults](Divine.Protobufs.Dota2.CMsgServerToGCCavernCrawlIsHeroActiveResponse.Types.MapResults.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActiveResponse_Types_MapResults_PathIdCompleted"></a> PathIdCompleted

```csharp
public uint PathIdCompleted { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActiveResponse_Types_MapResults_RoomIdClaimed"></a> RoomIdClaimed

```csharp
public uint RoomIdClaimed { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActiveResponse_Types_MapResults_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActiveResponse_Types_MapResults_ClearPathIdCompleted"></a> ClearPathIdCompleted\(\)

```csharp
public void ClearPathIdCompleted()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActiveResponse_Types_MapResults_ClearRoomIdClaimed"></a> ClearRoomIdClaimed\(\)

```csharp
public void ClearRoomIdClaimed()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActiveResponse_Types_MapResults_Clone"></a> Clone\(\)

```csharp
public CMsgServerToGCCavernCrawlIsHeroActiveResponse.Types.MapResults Clone()
```

#### Returns

 [CMsgServerToGCCavernCrawlIsHeroActiveResponse](Divine.Protobufs.Dota2.CMsgServerToGCCavernCrawlIsHeroActiveResponse.md).[Types](Divine.Protobufs.Dota2.CMsgServerToGCCavernCrawlIsHeroActiveResponse.Types.md).[MapResults](Divine.Protobufs.Dota2.CMsgServerToGCCavernCrawlIsHeroActiveResponse.Types.MapResults.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActiveResponse_Types_MapResults_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActiveResponse_Types_MapResults_Equals_Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActiveResponse_Types_MapResults_"></a> Equals\(MapResults\)

```csharp
public bool Equals(CMsgServerToGCCavernCrawlIsHeroActiveResponse.Types.MapResults other)
```

#### Parameters

`other` [CMsgServerToGCCavernCrawlIsHeroActiveResponse](Divine.Protobufs.Dota2.CMsgServerToGCCavernCrawlIsHeroActiveResponse.md).[Types](Divine.Protobufs.Dota2.CMsgServerToGCCavernCrawlIsHeroActiveResponse.Types.md).[MapResults](Divine.Protobufs.Dota2.CMsgServerToGCCavernCrawlIsHeroActiveResponse.Types.MapResults.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActiveResponse_Types_MapResults_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActiveResponse_Types_MapResults_MergeFrom_Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActiveResponse_Types_MapResults_"></a> MergeFrom\(MapResults\)

```csharp
public void MergeFrom(CMsgServerToGCCavernCrawlIsHeroActiveResponse.Types.MapResults other)
```

#### Parameters

`other` [CMsgServerToGCCavernCrawlIsHeroActiveResponse](Divine.Protobufs.Dota2.CMsgServerToGCCavernCrawlIsHeroActiveResponse.md).[Types](Divine.Protobufs.Dota2.CMsgServerToGCCavernCrawlIsHeroActiveResponse.Types.md).[MapResults](Divine.Protobufs.Dota2.CMsgServerToGCCavernCrawlIsHeroActiveResponse.Types.MapResults.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActiveResponse_Types_MapResults_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActiveResponse_Types_MapResults_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActiveResponse_Types_MapResults_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

