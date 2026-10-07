# <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetDPCFavoritesResponse_Types_Favorite"></a> Class CMsgClientToGCGetDPCFavoritesResponse.Types.Favorite

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCGetDPCFavoritesResponse.Types.Favorite : IMessage<CMsgClientToGCGetDPCFavoritesResponse.Types.Favorite>, IEquatable<CMsgClientToGCGetDPCFavoritesResponse.Types.Favorite>, IDeepCloneable<CMsgClientToGCGetDPCFavoritesResponse.Types.Favorite>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCGetDPCFavoritesResponse.Types.Favorite](Divine.Protobufs.Dota2.CMsgClientToGCGetDPCFavoritesResponse.Types.Favorite.md)

#### Implements

IMessage<CMsgClientToGCGetDPCFavoritesResponse.Types.Favorite\>, 
[IEquatable<CMsgClientToGCGetDPCFavoritesResponse.Types.Favorite\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCGetDPCFavoritesResponse.Types.Favorite\>, 
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
[EnumerableExtensions.In<CMsgClientToGCGetDPCFavoritesResponse.Types.Favorite\>\(CMsgClientToGCGetDPCFavoritesResponse.Types.Favorite, params CMsgClientToGCGetDPCFavoritesResponse.Types.Favorite\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetDPCFavoritesResponse_Types_Favorite__ctor"></a> Favorite\(\)

```csharp
public Favorite()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetDPCFavoritesResponse_Types_Favorite__ctor_Divine_Protobufs_Dota2_CMsgClientToGCGetDPCFavoritesResponse_Types_Favorite_"></a> Favorite\(Favorite\)

```csharp
public Favorite(CMsgClientToGCGetDPCFavoritesResponse.Types.Favorite other)
```

#### Parameters

`other` [CMsgClientToGCGetDPCFavoritesResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetDPCFavoritesResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCGetDPCFavoritesResponse.Types.md).[Favorite](Divine.Protobufs.Dota2.CMsgClientToGCGetDPCFavoritesResponse.Types.Favorite.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetDPCFavoritesResponse_Types_Favorite_FavoriteIdFieldNumber"></a> FavoriteIdFieldNumber

```csharp
public const int FavoriteIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetDPCFavoritesResponse_Types_Favorite_FavoriteTypeFieldNumber"></a> FavoriteTypeFieldNumber

```csharp
public const int FavoriteTypeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetDPCFavoritesResponse_Types_Favorite_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetDPCFavoritesResponse_Types_Favorite_FavoriteId"></a> FavoriteId

```csharp
public uint FavoriteId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetDPCFavoritesResponse_Types_Favorite_FavoriteType"></a> FavoriteType

```csharp
public EDPCFavoriteType FavoriteType { get; set; }
```

#### Property Value

 [EDPCFavoriteType](Divine.Protobufs.Dota2.EDPCFavoriteType.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetDPCFavoritesResponse_Types_Favorite_HasFavoriteId"></a> HasFavoriteId

```csharp
public bool HasFavoriteId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetDPCFavoritesResponse_Types_Favorite_HasFavoriteType"></a> HasFavoriteType

```csharp
public bool HasFavoriteType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetDPCFavoritesResponse_Types_Favorite_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCGetDPCFavoritesResponse.Types.Favorite> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCGetDPCFavoritesResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetDPCFavoritesResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCGetDPCFavoritesResponse.Types.md).[Favorite](Divine.Protobufs.Dota2.CMsgClientToGCGetDPCFavoritesResponse.Types.Favorite.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetDPCFavoritesResponse_Types_Favorite_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetDPCFavoritesResponse_Types_Favorite_ClearFavoriteId"></a> ClearFavoriteId\(\)

```csharp
public void ClearFavoriteId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetDPCFavoritesResponse_Types_Favorite_ClearFavoriteType"></a> ClearFavoriteType\(\)

```csharp
public void ClearFavoriteType()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetDPCFavoritesResponse_Types_Favorite_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCGetDPCFavoritesResponse.Types.Favorite Clone()
```

#### Returns

 [CMsgClientToGCGetDPCFavoritesResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetDPCFavoritesResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCGetDPCFavoritesResponse.Types.md).[Favorite](Divine.Protobufs.Dota2.CMsgClientToGCGetDPCFavoritesResponse.Types.Favorite.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetDPCFavoritesResponse_Types_Favorite_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetDPCFavoritesResponse_Types_Favorite_Equals_Divine_Protobufs_Dota2_CMsgClientToGCGetDPCFavoritesResponse_Types_Favorite_"></a> Equals\(Favorite\)

```csharp
public bool Equals(CMsgClientToGCGetDPCFavoritesResponse.Types.Favorite other)
```

#### Parameters

`other` [CMsgClientToGCGetDPCFavoritesResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetDPCFavoritesResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCGetDPCFavoritesResponse.Types.md).[Favorite](Divine.Protobufs.Dota2.CMsgClientToGCGetDPCFavoritesResponse.Types.Favorite.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetDPCFavoritesResponse_Types_Favorite_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetDPCFavoritesResponse_Types_Favorite_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCGetDPCFavoritesResponse_Types_Favorite_"></a> MergeFrom\(Favorite\)

```csharp
public void MergeFrom(CMsgClientToGCGetDPCFavoritesResponse.Types.Favorite other)
```

#### Parameters

`other` [CMsgClientToGCGetDPCFavoritesResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetDPCFavoritesResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCGetDPCFavoritesResponse.Types.md).[Favorite](Divine.Protobufs.Dota2.CMsgClientToGCGetDPCFavoritesResponse.Types.Favorite.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetDPCFavoritesResponse_Types_Favorite_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetDPCFavoritesResponse_Types_Favorite_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetDPCFavoritesResponse_Types_Favorite_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

