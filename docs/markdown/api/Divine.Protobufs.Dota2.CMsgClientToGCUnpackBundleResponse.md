# <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnpackBundleResponse"></a> Class CMsgClientToGCUnpackBundleResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCUnpackBundleResponse : IMessage<CMsgClientToGCUnpackBundleResponse>, IEquatable<CMsgClientToGCUnpackBundleResponse>, IDeepCloneable<CMsgClientToGCUnpackBundleResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCUnpackBundleResponse](Divine.Protobufs.Dota2.CMsgClientToGCUnpackBundleResponse.md)

#### Implements

IMessage<CMsgClientToGCUnpackBundleResponse\>, 
[IEquatable<CMsgClientToGCUnpackBundleResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCUnpackBundleResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCUnpackBundleResponse\>\(CMsgClientToGCUnpackBundleResponse, params CMsgClientToGCUnpackBundleResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnpackBundleResponse__ctor"></a> CMsgClientToGCUnpackBundleResponse\(\)

```csharp
public CMsgClientToGCUnpackBundleResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnpackBundleResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCUnpackBundleResponse_"></a> CMsgClientToGCUnpackBundleResponse\(CMsgClientToGCUnpackBundleResponse\)

```csharp
public CMsgClientToGCUnpackBundleResponse(CMsgClientToGCUnpackBundleResponse other)
```

#### Parameters

`other` [CMsgClientToGCUnpackBundleResponse](Divine.Protobufs.Dota2.CMsgClientToGCUnpackBundleResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnpackBundleResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnpackBundleResponse_UnpackedItemDefIndexesFieldNumber"></a> UnpackedItemDefIndexesFieldNumber

```csharp
public const int UnpackedItemDefIndexesFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnpackBundleResponse_UnpackedItemIdsFieldNumber"></a> UnpackedItemIdsFieldNumber

```csharp
public const int UnpackedItemIdsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnpackBundleResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnpackBundleResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnpackBundleResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCUnpackBundleResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCUnpackBundleResponse](Divine.Protobufs.Dota2.CMsgClientToGCUnpackBundleResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnpackBundleResponse_Response"></a> Response

```csharp
public CMsgClientToGCUnpackBundleResponse.Types.EUnpackBundle Response { get; set; }
```

#### Property Value

 [CMsgClientToGCUnpackBundleResponse](Divine.Protobufs.Dota2.CMsgClientToGCUnpackBundleResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCUnpackBundleResponse.Types.md).[EUnpackBundle](Divine.Protobufs.Dota2.CMsgClientToGCUnpackBundleResponse.Types.EUnpackBundle.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnpackBundleResponse_UnpackedItemDefIndexes"></a> UnpackedItemDefIndexes

```csharp
public RepeatedField<uint> UnpackedItemDefIndexes { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnpackBundleResponse_UnpackedItemIds"></a> UnpackedItemIds

```csharp
public RepeatedField<ulong> UnpackedItemIds { get; }
```

#### Property Value

 RepeatedField<[ulong](https://learn.microsoft.com/dotnet/api/system.uint64)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnpackBundleResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnpackBundleResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnpackBundleResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCUnpackBundleResponse Clone()
```

#### Returns

 [CMsgClientToGCUnpackBundleResponse](Divine.Protobufs.Dota2.CMsgClientToGCUnpackBundleResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnpackBundleResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnpackBundleResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCUnpackBundleResponse_"></a> Equals\(CMsgClientToGCUnpackBundleResponse\)

```csharp
public bool Equals(CMsgClientToGCUnpackBundleResponse other)
```

#### Parameters

`other` [CMsgClientToGCUnpackBundleResponse](Divine.Protobufs.Dota2.CMsgClientToGCUnpackBundleResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnpackBundleResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnpackBundleResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCUnpackBundleResponse_"></a> MergeFrom\(CMsgClientToGCUnpackBundleResponse\)

```csharp
public void MergeFrom(CMsgClientToGCUnpackBundleResponse other)
```

#### Parameters

`other` [CMsgClientToGCUnpackBundleResponse](Divine.Protobufs.Dota2.CMsgClientToGCUnpackBundleResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnpackBundleResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnpackBundleResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnpackBundleResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

