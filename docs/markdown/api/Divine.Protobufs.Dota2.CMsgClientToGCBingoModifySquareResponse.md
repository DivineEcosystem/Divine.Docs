# <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoModifySquareResponse"></a> Class CMsgClientToGCBingoModifySquareResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCBingoModifySquareResponse : IMessage<CMsgClientToGCBingoModifySquareResponse>, IEquatable<CMsgClientToGCBingoModifySquareResponse>, IDeepCloneable<CMsgClientToGCBingoModifySquareResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCBingoModifySquareResponse](Divine.Protobufs.Dota2.CMsgClientToGCBingoModifySquareResponse.md)

#### Implements

IMessage<CMsgClientToGCBingoModifySquareResponse\>, 
[IEquatable<CMsgClientToGCBingoModifySquareResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCBingoModifySquareResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCBingoModifySquareResponse\>\(CMsgClientToGCBingoModifySquareResponse, params CMsgClientToGCBingoModifySquareResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoModifySquareResponse__ctor"></a> CMsgClientToGCBingoModifySquareResponse\(\)

```csharp
public CMsgClientToGCBingoModifySquareResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoModifySquareResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCBingoModifySquareResponse_"></a> CMsgClientToGCBingoModifySquareResponse\(CMsgClientToGCBingoModifySquareResponse\)

```csharp
public CMsgClientToGCBingoModifySquareResponse(CMsgClientToGCBingoModifySquareResponse other)
```

#### Parameters

`other` [CMsgClientToGCBingoModifySquareResponse](Divine.Protobufs.Dota2.CMsgClientToGCBingoModifySquareResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoModifySquareResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoModifySquareResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoModifySquareResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoModifySquareResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCBingoModifySquareResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCBingoModifySquareResponse](Divine.Protobufs.Dota2.CMsgClientToGCBingoModifySquareResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoModifySquareResponse_Response"></a> Response

```csharp
public CMsgClientToGCBingoModifySquareResponse.Types.EResponse Response { get; set; }
```

#### Property Value

 [CMsgClientToGCBingoModifySquareResponse](Divine.Protobufs.Dota2.CMsgClientToGCBingoModifySquareResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCBingoModifySquareResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCBingoModifySquareResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoModifySquareResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoModifySquareResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoModifySquareResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCBingoModifySquareResponse Clone()
```

#### Returns

 [CMsgClientToGCBingoModifySquareResponse](Divine.Protobufs.Dota2.CMsgClientToGCBingoModifySquareResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoModifySquareResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoModifySquareResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCBingoModifySquareResponse_"></a> Equals\(CMsgClientToGCBingoModifySquareResponse\)

```csharp
public bool Equals(CMsgClientToGCBingoModifySquareResponse other)
```

#### Parameters

`other` [CMsgClientToGCBingoModifySquareResponse](Divine.Protobufs.Dota2.CMsgClientToGCBingoModifySquareResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoModifySquareResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoModifySquareResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCBingoModifySquareResponse_"></a> MergeFrom\(CMsgClientToGCBingoModifySquareResponse\)

```csharp
public void MergeFrom(CMsgClientToGCBingoModifySquareResponse other)
```

#### Parameters

`other` [CMsgClientToGCBingoModifySquareResponse](Divine.Protobufs.Dota2.CMsgClientToGCBingoModifySquareResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoModifySquareResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoModifySquareResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoModifySquareResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

