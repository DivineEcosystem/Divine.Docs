# <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFavoritePlayersResponse"></a> Class CMsgGCToClientGetFavoritePlayersResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientGetFavoritePlayersResponse : IMessage<CMsgGCToClientGetFavoritePlayersResponse>, IEquatable<CMsgGCToClientGetFavoritePlayersResponse>, IDeepCloneable<CMsgGCToClientGetFavoritePlayersResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientGetFavoritePlayersResponse](Divine.Protobufs.Dota2.CMsgGCToClientGetFavoritePlayersResponse.md)

#### Implements

IMessage<CMsgGCToClientGetFavoritePlayersResponse\>, 
[IEquatable<CMsgGCToClientGetFavoritePlayersResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientGetFavoritePlayersResponse\>, 
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
[EnumerableExtensions.In<CMsgGCToClientGetFavoritePlayersResponse\>\(CMsgGCToClientGetFavoritePlayersResponse, params CMsgGCToClientGetFavoritePlayersResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFavoritePlayersResponse__ctor"></a> CMsgGCToClientGetFavoritePlayersResponse\(\)

```csharp
public CMsgGCToClientGetFavoritePlayersResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFavoritePlayersResponse__ctor_Divine_Protobufs_Dota2_CMsgGCToClientGetFavoritePlayersResponse_"></a> CMsgGCToClientGetFavoritePlayersResponse\(CMsgGCToClientGetFavoritePlayersResponse\)

```csharp
public CMsgGCToClientGetFavoritePlayersResponse(CMsgGCToClientGetFavoritePlayersResponse other)
```

#### Parameters

`other` [CMsgGCToClientGetFavoritePlayersResponse](Divine.Protobufs.Dota2.CMsgGCToClientGetFavoritePlayersResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFavoritePlayersResponse_NextPaginationKeyFieldNumber"></a> NextPaginationKeyFieldNumber

```csharp
public const int NextPaginationKeyFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFavoritePlayersResponse_PlayersFieldNumber"></a> PlayersFieldNumber

```csharp
public const int PlayersFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFavoritePlayersResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFavoritePlayersResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFavoritePlayersResponse_HasNextPaginationKey"></a> HasNextPaginationKey

```csharp
public bool HasNextPaginationKey { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFavoritePlayersResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFavoritePlayersResponse_NextPaginationKey"></a> NextPaginationKey

```csharp
public ulong NextPaginationKey { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFavoritePlayersResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientGetFavoritePlayersResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientGetFavoritePlayersResponse](Divine.Protobufs.Dota2.CMsgGCToClientGetFavoritePlayersResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFavoritePlayersResponse_Players"></a> Players

```csharp
public RepeatedField<CMsgPartySearchPlayer> Players { get; }
```

#### Property Value

 RepeatedField<[CMsgPartySearchPlayer](Divine.Protobufs.Dota2.CMsgPartySearchPlayer.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFavoritePlayersResponse_Response"></a> Response

```csharp
public CMsgGCToClientGetFavoritePlayersResponse.Types.EResponse Response { get; set; }
```

#### Property Value

 [CMsgGCToClientGetFavoritePlayersResponse](Divine.Protobufs.Dota2.CMsgGCToClientGetFavoritePlayersResponse.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientGetFavoritePlayersResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgGCToClientGetFavoritePlayersResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFavoritePlayersResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFavoritePlayersResponse_ClearNextPaginationKey"></a> ClearNextPaginationKey\(\)

```csharp
public void ClearNextPaginationKey()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFavoritePlayersResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFavoritePlayersResponse_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientGetFavoritePlayersResponse Clone()
```

#### Returns

 [CMsgGCToClientGetFavoritePlayersResponse](Divine.Protobufs.Dota2.CMsgGCToClientGetFavoritePlayersResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFavoritePlayersResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFavoritePlayersResponse_Equals_Divine_Protobufs_Dota2_CMsgGCToClientGetFavoritePlayersResponse_"></a> Equals\(CMsgGCToClientGetFavoritePlayersResponse\)

```csharp
public bool Equals(CMsgGCToClientGetFavoritePlayersResponse other)
```

#### Parameters

`other` [CMsgGCToClientGetFavoritePlayersResponse](Divine.Protobufs.Dota2.CMsgGCToClientGetFavoritePlayersResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFavoritePlayersResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFavoritePlayersResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientGetFavoritePlayersResponse_"></a> MergeFrom\(CMsgGCToClientGetFavoritePlayersResponse\)

```csharp
public void MergeFrom(CMsgGCToClientGetFavoritePlayersResponse other)
```

#### Parameters

`other` [CMsgGCToClientGetFavoritePlayersResponse](Divine.Protobufs.Dota2.CMsgGCToClientGetFavoritePlayersResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFavoritePlayersResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFavoritePlayersResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGetFavoritePlayersResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

