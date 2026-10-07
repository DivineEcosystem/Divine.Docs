# <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetStickerbookResponse"></a> Class CMsgClientToGCGetStickerbookResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCGetStickerbookResponse : IMessage<CMsgClientToGCGetStickerbookResponse>, IEquatable<CMsgClientToGCGetStickerbookResponse>, IDeepCloneable<CMsgClientToGCGetStickerbookResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCGetStickerbookResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetStickerbookResponse.md)

#### Implements

IMessage<CMsgClientToGCGetStickerbookResponse\>, 
[IEquatable<CMsgClientToGCGetStickerbookResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCGetStickerbookResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCGetStickerbookResponse\>\(CMsgClientToGCGetStickerbookResponse, params CMsgClientToGCGetStickerbookResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetStickerbookResponse__ctor"></a> CMsgClientToGCGetStickerbookResponse\(\)

```csharp
public CMsgClientToGCGetStickerbookResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetStickerbookResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCGetStickerbookResponse_"></a> CMsgClientToGCGetStickerbookResponse\(CMsgClientToGCGetStickerbookResponse\)

```csharp
public CMsgClientToGCGetStickerbookResponse(CMsgClientToGCGetStickerbookResponse other)
```

#### Parameters

`other` [CMsgClientToGCGetStickerbookResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetStickerbookResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetStickerbookResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetStickerbookResponse_StickerbookFieldNumber"></a> StickerbookFieldNumber

```csharp
public const int StickerbookFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetStickerbookResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetStickerbookResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetStickerbookResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCGetStickerbookResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCGetStickerbookResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetStickerbookResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetStickerbookResponse_Response"></a> Response

```csharp
public CMsgClientToGCGetStickerbookResponse.Types.EResponse Response { get; set; }
```

#### Property Value

 [CMsgClientToGCGetStickerbookResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetStickerbookResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCGetStickerbookResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetStickerbookResponse.Types.EResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetStickerbookResponse_Stickerbook"></a> Stickerbook

```csharp
public CMsgStickerbook Stickerbook { get; set; }
```

#### Property Value

 [CMsgStickerbook](Divine.Protobufs.Dota2.CMsgStickerbook.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetStickerbookResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetStickerbookResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetStickerbookResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCGetStickerbookResponse Clone()
```

#### Returns

 [CMsgClientToGCGetStickerbookResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetStickerbookResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetStickerbookResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetStickerbookResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCGetStickerbookResponse_"></a> Equals\(CMsgClientToGCGetStickerbookResponse\)

```csharp
public bool Equals(CMsgClientToGCGetStickerbookResponse other)
```

#### Parameters

`other` [CMsgClientToGCGetStickerbookResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetStickerbookResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetStickerbookResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetStickerbookResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCGetStickerbookResponse_"></a> MergeFrom\(CMsgClientToGCGetStickerbookResponse\)

```csharp
public void MergeFrom(CMsgClientToGCGetStickerbookResponse other)
```

#### Parameters

`other` [CMsgClientToGCGetStickerbookResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetStickerbookResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetStickerbookResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetStickerbookResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetStickerbookResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

