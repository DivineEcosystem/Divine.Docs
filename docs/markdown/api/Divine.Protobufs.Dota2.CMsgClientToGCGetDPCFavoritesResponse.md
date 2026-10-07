# <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetDPCFavoritesResponse"></a> Class CMsgClientToGCGetDPCFavoritesResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCGetDPCFavoritesResponse : IMessage<CMsgClientToGCGetDPCFavoritesResponse>, IEquatable<CMsgClientToGCGetDPCFavoritesResponse>, IDeepCloneable<CMsgClientToGCGetDPCFavoritesResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCGetDPCFavoritesResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetDPCFavoritesResponse.md)

#### Implements

IMessage<CMsgClientToGCGetDPCFavoritesResponse\>, 
[IEquatable<CMsgClientToGCGetDPCFavoritesResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCGetDPCFavoritesResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCGetDPCFavoritesResponse\>\(CMsgClientToGCGetDPCFavoritesResponse, params CMsgClientToGCGetDPCFavoritesResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetDPCFavoritesResponse__ctor"></a> CMsgClientToGCGetDPCFavoritesResponse\(\)

```csharp
public CMsgClientToGCGetDPCFavoritesResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetDPCFavoritesResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCGetDPCFavoritesResponse_"></a> CMsgClientToGCGetDPCFavoritesResponse\(CMsgClientToGCGetDPCFavoritesResponse\)

```csharp
public CMsgClientToGCGetDPCFavoritesResponse(CMsgClientToGCGetDPCFavoritesResponse other)
```

#### Parameters

`other` [CMsgClientToGCGetDPCFavoritesResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetDPCFavoritesResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetDPCFavoritesResponse_FavoritesFieldNumber"></a> FavoritesFieldNumber

```csharp
public const int FavoritesFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetDPCFavoritesResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetDPCFavoritesResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetDPCFavoritesResponse_Favorites"></a> Favorites

```csharp
public RepeatedField<CMsgClientToGCGetDPCFavoritesResponse.Types.Favorite> Favorites { get; }
```

#### Property Value

 RepeatedField<[CMsgClientToGCGetDPCFavoritesResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetDPCFavoritesResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCGetDPCFavoritesResponse.Types.md).[Favorite](Divine.Protobufs.Dota2.CMsgClientToGCGetDPCFavoritesResponse.Types.Favorite.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetDPCFavoritesResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetDPCFavoritesResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCGetDPCFavoritesResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCGetDPCFavoritesResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetDPCFavoritesResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetDPCFavoritesResponse_Result"></a> Result

```csharp
public CMsgClientToGCGetDPCFavoritesResponse.Types.EResponse Result { get; set; }
```

#### Property Value

 [CMsgClientToGCGetDPCFavoritesResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetDPCFavoritesResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCGetDPCFavoritesResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetDPCFavoritesResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetDPCFavoritesResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetDPCFavoritesResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetDPCFavoritesResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCGetDPCFavoritesResponse Clone()
```

#### Returns

 [CMsgClientToGCGetDPCFavoritesResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetDPCFavoritesResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetDPCFavoritesResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetDPCFavoritesResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCGetDPCFavoritesResponse_"></a> Equals\(CMsgClientToGCGetDPCFavoritesResponse\)

```csharp
public bool Equals(CMsgClientToGCGetDPCFavoritesResponse other)
```

#### Parameters

`other` [CMsgClientToGCGetDPCFavoritesResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetDPCFavoritesResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetDPCFavoritesResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetDPCFavoritesResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCGetDPCFavoritesResponse_"></a> MergeFrom\(CMsgClientToGCGetDPCFavoritesResponse\)

```csharp
public void MergeFrom(CMsgClientToGCGetDPCFavoritesResponse other)
```

#### Parameters

`other` [CMsgClientToGCGetDPCFavoritesResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetDPCFavoritesResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetDPCFavoritesResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetDPCFavoritesResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetDPCFavoritesResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

