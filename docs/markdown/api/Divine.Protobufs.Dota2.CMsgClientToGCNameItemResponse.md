# <a id="Divine_Protobufs_Dota2_CMsgClientToGCNameItemResponse"></a> Class CMsgClientToGCNameItemResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCNameItemResponse : IMessage<CMsgClientToGCNameItemResponse>, IEquatable<CMsgClientToGCNameItemResponse>, IDeepCloneable<CMsgClientToGCNameItemResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCNameItemResponse](Divine.Protobufs.Dota2.CMsgClientToGCNameItemResponse.md)

#### Implements

IMessage<CMsgClientToGCNameItemResponse\>, 
[IEquatable<CMsgClientToGCNameItemResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCNameItemResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCNameItemResponse\>\(CMsgClientToGCNameItemResponse, params CMsgClientToGCNameItemResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCNameItemResponse__ctor"></a> CMsgClientToGCNameItemResponse\(\)

```csharp
public CMsgClientToGCNameItemResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCNameItemResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCNameItemResponse_"></a> CMsgClientToGCNameItemResponse\(CMsgClientToGCNameItemResponse\)

```csharp
public CMsgClientToGCNameItemResponse(CMsgClientToGCNameItemResponse other)
```

#### Parameters

`other` [CMsgClientToGCNameItemResponse](Divine.Protobufs.Dota2.CMsgClientToGCNameItemResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCNameItemResponse_ItemIdFieldNumber"></a> ItemIdFieldNumber

```csharp
public const int ItemIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCNameItemResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCNameItemResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCNameItemResponse_HasItemId"></a> HasItemId

```csharp
public bool HasItemId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCNameItemResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCNameItemResponse_ItemId"></a> ItemId

```csharp
public ulong ItemId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCNameItemResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCNameItemResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCNameItemResponse](Divine.Protobufs.Dota2.CMsgClientToGCNameItemResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCNameItemResponse_Response"></a> Response

```csharp
public CMsgClientToGCNameItemResponse.Types.ENameItem Response { get; set; }
```

#### Property Value

 [CMsgClientToGCNameItemResponse](Divine.Protobufs.Dota2.CMsgClientToGCNameItemResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCNameItemResponse.Types.md).[ENameItem](Divine.Protobufs.Dota2.CMsgClientToGCNameItemResponse.Types.ENameItem.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCNameItemResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCNameItemResponse_ClearItemId"></a> ClearItemId\(\)

```csharp
public void ClearItemId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCNameItemResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCNameItemResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCNameItemResponse Clone()
```

#### Returns

 [CMsgClientToGCNameItemResponse](Divine.Protobufs.Dota2.CMsgClientToGCNameItemResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCNameItemResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCNameItemResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCNameItemResponse_"></a> Equals\(CMsgClientToGCNameItemResponse\)

```csharp
public bool Equals(CMsgClientToGCNameItemResponse other)
```

#### Parameters

`other` [CMsgClientToGCNameItemResponse](Divine.Protobufs.Dota2.CMsgClientToGCNameItemResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCNameItemResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCNameItemResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCNameItemResponse_"></a> MergeFrom\(CMsgClientToGCNameItemResponse\)

```csharp
public void MergeFrom(CMsgClientToGCNameItemResponse other)
```

#### Parameters

`other` [CMsgClientToGCNameItemResponse](Divine.Protobufs.Dota2.CMsgClientToGCNameItemResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCNameItemResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCNameItemResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCNameItemResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

