# <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevAddTokensResponse"></a> Class CMsgClientToGCBingoDevAddTokensResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCBingoDevAddTokensResponse : IMessage<CMsgClientToGCBingoDevAddTokensResponse>, IEquatable<CMsgClientToGCBingoDevAddTokensResponse>, IDeepCloneable<CMsgClientToGCBingoDevAddTokensResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCBingoDevAddTokensResponse](Divine.Protobufs.Dota2.CMsgClientToGCBingoDevAddTokensResponse.md)

#### Implements

IMessage<CMsgClientToGCBingoDevAddTokensResponse\>, 
[IEquatable<CMsgClientToGCBingoDevAddTokensResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCBingoDevAddTokensResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCBingoDevAddTokensResponse\>\(CMsgClientToGCBingoDevAddTokensResponse, params CMsgClientToGCBingoDevAddTokensResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevAddTokensResponse__ctor"></a> CMsgClientToGCBingoDevAddTokensResponse\(\)

```csharp
public CMsgClientToGCBingoDevAddTokensResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevAddTokensResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCBingoDevAddTokensResponse_"></a> CMsgClientToGCBingoDevAddTokensResponse\(CMsgClientToGCBingoDevAddTokensResponse\)

```csharp
public CMsgClientToGCBingoDevAddTokensResponse(CMsgClientToGCBingoDevAddTokensResponse other)
```

#### Parameters

`other` [CMsgClientToGCBingoDevAddTokensResponse](Divine.Protobufs.Dota2.CMsgClientToGCBingoDevAddTokensResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevAddTokensResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevAddTokensResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevAddTokensResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevAddTokensResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCBingoDevAddTokensResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCBingoDevAddTokensResponse](Divine.Protobufs.Dota2.CMsgClientToGCBingoDevAddTokensResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevAddTokensResponse_Response"></a> Response

```csharp
public CMsgClientToGCBingoDevAddTokensResponse.Types.EResponse Response { get; set; }
```

#### Property Value

 [CMsgClientToGCBingoDevAddTokensResponse](Divine.Protobufs.Dota2.CMsgClientToGCBingoDevAddTokensResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCBingoDevAddTokensResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCBingoDevAddTokensResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevAddTokensResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevAddTokensResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevAddTokensResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCBingoDevAddTokensResponse Clone()
```

#### Returns

 [CMsgClientToGCBingoDevAddTokensResponse](Divine.Protobufs.Dota2.CMsgClientToGCBingoDevAddTokensResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevAddTokensResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevAddTokensResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCBingoDevAddTokensResponse_"></a> Equals\(CMsgClientToGCBingoDevAddTokensResponse\)

```csharp
public bool Equals(CMsgClientToGCBingoDevAddTokensResponse other)
```

#### Parameters

`other` [CMsgClientToGCBingoDevAddTokensResponse](Divine.Protobufs.Dota2.CMsgClientToGCBingoDevAddTokensResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevAddTokensResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevAddTokensResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCBingoDevAddTokensResponse_"></a> MergeFrom\(CMsgClientToGCBingoDevAddTokensResponse\)

```csharp
public void MergeFrom(CMsgClientToGCBingoDevAddTokensResponse other)
```

#### Parameters

`other` [CMsgClientToGCBingoDevAddTokensResponse](Divine.Protobufs.Dota2.CMsgClientToGCBingoDevAddTokensResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevAddTokensResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevAddTokensResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevAddTokensResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

