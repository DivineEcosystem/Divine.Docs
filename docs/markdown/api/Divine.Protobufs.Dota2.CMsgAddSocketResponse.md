# <a id="Divine_Protobufs_Dota2_CMsgAddSocketResponse"></a> Class CMsgAddSocketResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgAddSocketResponse : IMessage<CMsgAddSocketResponse>, IEquatable<CMsgAddSocketResponse>, IDeepCloneable<CMsgAddSocketResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgAddSocketResponse](Divine.Protobufs.Dota2.CMsgAddSocketResponse.md)

#### Implements

IMessage<CMsgAddSocketResponse\>, 
[IEquatable<CMsgAddSocketResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgAddSocketResponse\>, 
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
[EnumerableExtensions.In<CMsgAddSocketResponse\>\(CMsgAddSocketResponse, params CMsgAddSocketResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgAddSocketResponse__ctor"></a> CMsgAddSocketResponse\(\)

```csharp
public CMsgAddSocketResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgAddSocketResponse__ctor_Divine_Protobufs_Dota2_CMsgAddSocketResponse_"></a> CMsgAddSocketResponse\(CMsgAddSocketResponse\)

```csharp
public CMsgAddSocketResponse(CMsgAddSocketResponse other)
```

#### Parameters

`other` [CMsgAddSocketResponse](Divine.Protobufs.Dota2.CMsgAddSocketResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgAddSocketResponse_ItemIdFieldNumber"></a> ItemIdFieldNumber

```csharp
public const int ItemIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgAddSocketResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgAddSocketResponse_UpdatedSocketIndexFieldNumber"></a> UpdatedSocketIndexFieldNumber

```csharp
public const int UpdatedSocketIndexFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgAddSocketResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgAddSocketResponse_HasItemId"></a> HasItemId

```csharp
public bool HasItemId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgAddSocketResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgAddSocketResponse_ItemId"></a> ItemId

```csharp
public ulong ItemId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgAddSocketResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgAddSocketResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgAddSocketResponse](Divine.Protobufs.Dota2.CMsgAddSocketResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgAddSocketResponse_Response"></a> Response

```csharp
public CMsgAddSocketResponse.Types.EAddSocket Response { get; set; }
```

#### Property Value

 [CMsgAddSocketResponse](Divine.Protobufs.Dota2.CMsgAddSocketResponse.md).[Types](Divine.Protobufs.Dota2.CMsgAddSocketResponse.Types.md).[EAddSocket](Divine.Protobufs.Dota2.CMsgAddSocketResponse.Types.EAddSocket.md)

### <a id="Divine_Protobufs_Dota2_CMsgAddSocketResponse_UpdatedSocketIndex"></a> UpdatedSocketIndex

```csharp
public RepeatedField<uint> UpdatedSocketIndex { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgAddSocketResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgAddSocketResponse_ClearItemId"></a> ClearItemId\(\)

```csharp
public void ClearItemId()
```

### <a id="Divine_Protobufs_Dota2_CMsgAddSocketResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgAddSocketResponse_Clone"></a> Clone\(\)

```csharp
public CMsgAddSocketResponse Clone()
```

#### Returns

 [CMsgAddSocketResponse](Divine.Protobufs.Dota2.CMsgAddSocketResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgAddSocketResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgAddSocketResponse_Equals_Divine_Protobufs_Dota2_CMsgAddSocketResponse_"></a> Equals\(CMsgAddSocketResponse\)

```csharp
public bool Equals(CMsgAddSocketResponse other)
```

#### Parameters

`other` [CMsgAddSocketResponse](Divine.Protobufs.Dota2.CMsgAddSocketResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgAddSocketResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgAddSocketResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgAddSocketResponse_"></a> MergeFrom\(CMsgAddSocketResponse\)

```csharp
public void MergeFrom(CMsgAddSocketResponse other)
```

#### Parameters

`other` [CMsgAddSocketResponse](Divine.Protobufs.Dota2.CMsgAddSocketResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgAddSocketResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgAddSocketResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgAddSocketResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

