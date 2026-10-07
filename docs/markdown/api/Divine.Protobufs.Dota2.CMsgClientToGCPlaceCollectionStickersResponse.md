# <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceCollectionStickersResponse"></a> Class CMsgClientToGCPlaceCollectionStickersResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCPlaceCollectionStickersResponse : IMessage<CMsgClientToGCPlaceCollectionStickersResponse>, IEquatable<CMsgClientToGCPlaceCollectionStickersResponse>, IDeepCloneable<CMsgClientToGCPlaceCollectionStickersResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCPlaceCollectionStickersResponse](Divine.Protobufs.Dota2.CMsgClientToGCPlaceCollectionStickersResponse.md)

#### Implements

IMessage<CMsgClientToGCPlaceCollectionStickersResponse\>, 
[IEquatable<CMsgClientToGCPlaceCollectionStickersResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCPlaceCollectionStickersResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCPlaceCollectionStickersResponse\>\(CMsgClientToGCPlaceCollectionStickersResponse, params CMsgClientToGCPlaceCollectionStickersResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceCollectionStickersResponse__ctor"></a> CMsgClientToGCPlaceCollectionStickersResponse\(\)

```csharp
public CMsgClientToGCPlaceCollectionStickersResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceCollectionStickersResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCPlaceCollectionStickersResponse_"></a> CMsgClientToGCPlaceCollectionStickersResponse\(CMsgClientToGCPlaceCollectionStickersResponse\)

```csharp
public CMsgClientToGCPlaceCollectionStickersResponse(CMsgClientToGCPlaceCollectionStickersResponse other)
```

#### Parameters

`other` [CMsgClientToGCPlaceCollectionStickersResponse](Divine.Protobufs.Dota2.CMsgClientToGCPlaceCollectionStickersResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceCollectionStickersResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceCollectionStickersResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceCollectionStickersResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceCollectionStickersResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCPlaceCollectionStickersResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCPlaceCollectionStickersResponse](Divine.Protobufs.Dota2.CMsgClientToGCPlaceCollectionStickersResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceCollectionStickersResponse_Response"></a> Response

```csharp
public CMsgClientToGCPlaceCollectionStickersResponse.Types.EResponse Response { get; set; }
```

#### Property Value

 [CMsgClientToGCPlaceCollectionStickersResponse](Divine.Protobufs.Dota2.CMsgClientToGCPlaceCollectionStickersResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCPlaceCollectionStickersResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCPlaceCollectionStickersResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceCollectionStickersResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceCollectionStickersResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceCollectionStickersResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCPlaceCollectionStickersResponse Clone()
```

#### Returns

 [CMsgClientToGCPlaceCollectionStickersResponse](Divine.Protobufs.Dota2.CMsgClientToGCPlaceCollectionStickersResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceCollectionStickersResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceCollectionStickersResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCPlaceCollectionStickersResponse_"></a> Equals\(CMsgClientToGCPlaceCollectionStickersResponse\)

```csharp
public bool Equals(CMsgClientToGCPlaceCollectionStickersResponse other)
```

#### Parameters

`other` [CMsgClientToGCPlaceCollectionStickersResponse](Divine.Protobufs.Dota2.CMsgClientToGCPlaceCollectionStickersResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceCollectionStickersResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceCollectionStickersResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCPlaceCollectionStickersResponse_"></a> MergeFrom\(CMsgClientToGCPlaceCollectionStickersResponse\)

```csharp
public void MergeFrom(CMsgClientToGCPlaceCollectionStickersResponse other)
```

#### Parameters

`other` [CMsgClientToGCPlaceCollectionStickersResponse](Divine.Protobufs.Dota2.CMsgClientToGCPlaceCollectionStickersResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceCollectionStickersResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceCollectionStickersResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceCollectionStickersResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

