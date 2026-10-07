# <a id="Divine_Protobufs_Dota2_CMsgRedeemCodeResponse"></a> Class CMsgRedeemCodeResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgRedeemCodeResponse : IMessage<CMsgRedeemCodeResponse>, IEquatable<CMsgRedeemCodeResponse>, IDeepCloneable<CMsgRedeemCodeResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgRedeemCodeResponse](Divine.Protobufs.Dota2.CMsgRedeemCodeResponse.md)

#### Implements

IMessage<CMsgRedeemCodeResponse\>, 
[IEquatable<CMsgRedeemCodeResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgRedeemCodeResponse\>, 
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
[EnumerableExtensions.In<CMsgRedeemCodeResponse\>\(CMsgRedeemCodeResponse, params CMsgRedeemCodeResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgRedeemCodeResponse__ctor"></a> CMsgRedeemCodeResponse\(\)

```csharp
public CMsgRedeemCodeResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgRedeemCodeResponse__ctor_Divine_Protobufs_Dota2_CMsgRedeemCodeResponse_"></a> CMsgRedeemCodeResponse\(CMsgRedeemCodeResponse\)

```csharp
public CMsgRedeemCodeResponse(CMsgRedeemCodeResponse other)
```

#### Parameters

`other` [CMsgRedeemCodeResponse](Divine.Protobufs.Dota2.CMsgRedeemCodeResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgRedeemCodeResponse_ItemIdFieldNumber"></a> ItemIdFieldNumber

```csharp
public const int ItemIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgRedeemCodeResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgRedeemCodeResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgRedeemCodeResponse_HasItemId"></a> HasItemId

```csharp
public bool HasItemId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgRedeemCodeResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgRedeemCodeResponse_ItemId"></a> ItemId

```csharp
public ulong ItemId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgRedeemCodeResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgRedeemCodeResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgRedeemCodeResponse](Divine.Protobufs.Dota2.CMsgRedeemCodeResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgRedeemCodeResponse_Response"></a> Response

```csharp
public uint Response { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgRedeemCodeResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgRedeemCodeResponse_ClearItemId"></a> ClearItemId\(\)

```csharp
public void ClearItemId()
```

### <a id="Divine_Protobufs_Dota2_CMsgRedeemCodeResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgRedeemCodeResponse_Clone"></a> Clone\(\)

```csharp
public CMsgRedeemCodeResponse Clone()
```

#### Returns

 [CMsgRedeemCodeResponse](Divine.Protobufs.Dota2.CMsgRedeemCodeResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgRedeemCodeResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgRedeemCodeResponse_Equals_Divine_Protobufs_Dota2_CMsgRedeemCodeResponse_"></a> Equals\(CMsgRedeemCodeResponse\)

```csharp
public bool Equals(CMsgRedeemCodeResponse other)
```

#### Parameters

`other` [CMsgRedeemCodeResponse](Divine.Protobufs.Dota2.CMsgRedeemCodeResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgRedeemCodeResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgRedeemCodeResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgRedeemCodeResponse_"></a> MergeFrom\(CMsgRedeemCodeResponse\)

```csharp
public void MergeFrom(CMsgRedeemCodeResponse other)
```

#### Parameters

`other` [CMsgRedeemCodeResponse](Divine.Protobufs.Dota2.CMsgRedeemCodeResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgRedeemCodeResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgRedeemCodeResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgRedeemCodeResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

