# <a id="Divine_Protobufs_Dota2_CMsgExtractGemsResponse"></a> Class CMsgExtractGemsResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgExtractGemsResponse : IMessage<CMsgExtractGemsResponse>, IEquatable<CMsgExtractGemsResponse>, IDeepCloneable<CMsgExtractGemsResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgExtractGemsResponse](Divine.Protobufs.Dota2.CMsgExtractGemsResponse.md)

#### Implements

IMessage<CMsgExtractGemsResponse\>, 
[IEquatable<CMsgExtractGemsResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgExtractGemsResponse\>, 
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
[EnumerableExtensions.In<CMsgExtractGemsResponse\>\(CMsgExtractGemsResponse, params CMsgExtractGemsResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgExtractGemsResponse__ctor"></a> CMsgExtractGemsResponse\(\)

```csharp
public CMsgExtractGemsResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgExtractGemsResponse__ctor_Divine_Protobufs_Dota2_CMsgExtractGemsResponse_"></a> CMsgExtractGemsResponse\(CMsgExtractGemsResponse\)

```csharp
public CMsgExtractGemsResponse(CMsgExtractGemsResponse other)
```

#### Parameters

`other` [CMsgExtractGemsResponse](Divine.Protobufs.Dota2.CMsgExtractGemsResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgExtractGemsResponse_ItemIdFieldNumber"></a> ItemIdFieldNumber

```csharp
public const int ItemIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgExtractGemsResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgExtractGemsResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgExtractGemsResponse_HasItemId"></a> HasItemId

```csharp
public bool HasItemId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgExtractGemsResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgExtractGemsResponse_ItemId"></a> ItemId

```csharp
public ulong ItemId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgExtractGemsResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgExtractGemsResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgExtractGemsResponse](Divine.Protobufs.Dota2.CMsgExtractGemsResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgExtractGemsResponse_Response"></a> Response

```csharp
public CMsgExtractGemsResponse.Types.EExtractGems Response { get; set; }
```

#### Property Value

 [CMsgExtractGemsResponse](Divine.Protobufs.Dota2.CMsgExtractGemsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgExtractGemsResponse.Types.md).[EExtractGems](Divine.Protobufs.Dota2.CMsgExtractGemsResponse.Types.EExtractGems.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgExtractGemsResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgExtractGemsResponse_ClearItemId"></a> ClearItemId\(\)

```csharp
public void ClearItemId()
```

### <a id="Divine_Protobufs_Dota2_CMsgExtractGemsResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgExtractGemsResponse_Clone"></a> Clone\(\)

```csharp
public CMsgExtractGemsResponse Clone()
```

#### Returns

 [CMsgExtractGemsResponse](Divine.Protobufs.Dota2.CMsgExtractGemsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgExtractGemsResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgExtractGemsResponse_Equals_Divine_Protobufs_Dota2_CMsgExtractGemsResponse_"></a> Equals\(CMsgExtractGemsResponse\)

```csharp
public bool Equals(CMsgExtractGemsResponse other)
```

#### Parameters

`other` [CMsgExtractGemsResponse](Divine.Protobufs.Dota2.CMsgExtractGemsResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgExtractGemsResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgExtractGemsResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgExtractGemsResponse_"></a> MergeFrom\(CMsgExtractGemsResponse\)

```csharp
public void MergeFrom(CMsgExtractGemsResponse other)
```

#### Parameters

`other` [CMsgExtractGemsResponse](Divine.Protobufs.Dota2.CMsgExtractGemsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgExtractGemsResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgExtractGemsResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgExtractGemsResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

