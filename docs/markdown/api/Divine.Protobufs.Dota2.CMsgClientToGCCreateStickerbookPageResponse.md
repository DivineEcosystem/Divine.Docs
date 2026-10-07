# <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStickerbookPageResponse"></a> Class CMsgClientToGCCreateStickerbookPageResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCCreateStickerbookPageResponse : IMessage<CMsgClientToGCCreateStickerbookPageResponse>, IEquatable<CMsgClientToGCCreateStickerbookPageResponse>, IDeepCloneable<CMsgClientToGCCreateStickerbookPageResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCCreateStickerbookPageResponse](Divine.Protobufs.Dota2.CMsgClientToGCCreateStickerbookPageResponse.md)

#### Implements

IMessage<CMsgClientToGCCreateStickerbookPageResponse\>, 
[IEquatable<CMsgClientToGCCreateStickerbookPageResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCCreateStickerbookPageResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCCreateStickerbookPageResponse\>\(CMsgClientToGCCreateStickerbookPageResponse, params CMsgClientToGCCreateStickerbookPageResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStickerbookPageResponse__ctor"></a> CMsgClientToGCCreateStickerbookPageResponse\(\)

```csharp
public CMsgClientToGCCreateStickerbookPageResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStickerbookPageResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCCreateStickerbookPageResponse_"></a> CMsgClientToGCCreateStickerbookPageResponse\(CMsgClientToGCCreateStickerbookPageResponse\)

```csharp
public CMsgClientToGCCreateStickerbookPageResponse(CMsgClientToGCCreateStickerbookPageResponse other)
```

#### Parameters

`other` [CMsgClientToGCCreateStickerbookPageResponse](Divine.Protobufs.Dota2.CMsgClientToGCCreateStickerbookPageResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStickerbookPageResponse_PageNumberFieldNumber"></a> PageNumberFieldNumber

```csharp
public const int PageNumberFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStickerbookPageResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStickerbookPageResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStickerbookPageResponse_HasPageNumber"></a> HasPageNumber

```csharp
public bool HasPageNumber { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStickerbookPageResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStickerbookPageResponse_PageNumber"></a> PageNumber

```csharp
public uint PageNumber { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStickerbookPageResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCCreateStickerbookPageResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCCreateStickerbookPageResponse](Divine.Protobufs.Dota2.CMsgClientToGCCreateStickerbookPageResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStickerbookPageResponse_Response"></a> Response

```csharp
public CMsgClientToGCCreateStickerbookPageResponse.Types.EResponse Response { get; set; }
```

#### Property Value

 [CMsgClientToGCCreateStickerbookPageResponse](Divine.Protobufs.Dota2.CMsgClientToGCCreateStickerbookPageResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCCreateStickerbookPageResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCCreateStickerbookPageResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStickerbookPageResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStickerbookPageResponse_ClearPageNumber"></a> ClearPageNumber\(\)

```csharp
public void ClearPageNumber()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStickerbookPageResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStickerbookPageResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCCreateStickerbookPageResponse Clone()
```

#### Returns

 [CMsgClientToGCCreateStickerbookPageResponse](Divine.Protobufs.Dota2.CMsgClientToGCCreateStickerbookPageResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStickerbookPageResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStickerbookPageResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCCreateStickerbookPageResponse_"></a> Equals\(CMsgClientToGCCreateStickerbookPageResponse\)

```csharp
public bool Equals(CMsgClientToGCCreateStickerbookPageResponse other)
```

#### Parameters

`other` [CMsgClientToGCCreateStickerbookPageResponse](Divine.Protobufs.Dota2.CMsgClientToGCCreateStickerbookPageResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStickerbookPageResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStickerbookPageResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCCreateStickerbookPageResponse_"></a> MergeFrom\(CMsgClientToGCCreateStickerbookPageResponse\)

```csharp
public void MergeFrom(CMsgClientToGCCreateStickerbookPageResponse other)
```

#### Parameters

`other` [CMsgClientToGCCreateStickerbookPageResponse](Divine.Protobufs.Dota2.CMsgClientToGCCreateStickerbookPageResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStickerbookPageResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStickerbookPageResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStickerbookPageResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

