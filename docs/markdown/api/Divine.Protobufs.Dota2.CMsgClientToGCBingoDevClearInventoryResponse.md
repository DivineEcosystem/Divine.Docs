# <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevClearInventoryResponse"></a> Class CMsgClientToGCBingoDevClearInventoryResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCBingoDevClearInventoryResponse : IMessage<CMsgClientToGCBingoDevClearInventoryResponse>, IEquatable<CMsgClientToGCBingoDevClearInventoryResponse>, IDeepCloneable<CMsgClientToGCBingoDevClearInventoryResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCBingoDevClearInventoryResponse](Divine.Protobufs.Dota2.CMsgClientToGCBingoDevClearInventoryResponse.md)

#### Implements

IMessage<CMsgClientToGCBingoDevClearInventoryResponse\>, 
[IEquatable<CMsgClientToGCBingoDevClearInventoryResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCBingoDevClearInventoryResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCBingoDevClearInventoryResponse\>\(CMsgClientToGCBingoDevClearInventoryResponse, params CMsgClientToGCBingoDevClearInventoryResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevClearInventoryResponse__ctor"></a> CMsgClientToGCBingoDevClearInventoryResponse\(\)

```csharp
public CMsgClientToGCBingoDevClearInventoryResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevClearInventoryResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCBingoDevClearInventoryResponse_"></a> CMsgClientToGCBingoDevClearInventoryResponse\(CMsgClientToGCBingoDevClearInventoryResponse\)

```csharp
public CMsgClientToGCBingoDevClearInventoryResponse(CMsgClientToGCBingoDevClearInventoryResponse other)
```

#### Parameters

`other` [CMsgClientToGCBingoDevClearInventoryResponse](Divine.Protobufs.Dota2.CMsgClientToGCBingoDevClearInventoryResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevClearInventoryResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevClearInventoryResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevClearInventoryResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevClearInventoryResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCBingoDevClearInventoryResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCBingoDevClearInventoryResponse](Divine.Protobufs.Dota2.CMsgClientToGCBingoDevClearInventoryResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevClearInventoryResponse_Response"></a> Response

```csharp
public CMsgClientToGCBingoDevClearInventoryResponse.Types.EResponse Response { get; set; }
```

#### Property Value

 [CMsgClientToGCBingoDevClearInventoryResponse](Divine.Protobufs.Dota2.CMsgClientToGCBingoDevClearInventoryResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCBingoDevClearInventoryResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCBingoDevClearInventoryResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevClearInventoryResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevClearInventoryResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevClearInventoryResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCBingoDevClearInventoryResponse Clone()
```

#### Returns

 [CMsgClientToGCBingoDevClearInventoryResponse](Divine.Protobufs.Dota2.CMsgClientToGCBingoDevClearInventoryResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevClearInventoryResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevClearInventoryResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCBingoDevClearInventoryResponse_"></a> Equals\(CMsgClientToGCBingoDevClearInventoryResponse\)

```csharp
public bool Equals(CMsgClientToGCBingoDevClearInventoryResponse other)
```

#### Parameters

`other` [CMsgClientToGCBingoDevClearInventoryResponse](Divine.Protobufs.Dota2.CMsgClientToGCBingoDevClearInventoryResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevClearInventoryResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevClearInventoryResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCBingoDevClearInventoryResponse_"></a> MergeFrom\(CMsgClientToGCBingoDevClearInventoryResponse\)

```csharp
public void MergeFrom(CMsgClientToGCBingoDevClearInventoryResponse other)
```

#### Parameters

`other` [CMsgClientToGCBingoDevClearInventoryResponse](Divine.Protobufs.Dota2.CMsgClientToGCBingoDevClearInventoryResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevClearInventoryResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevClearInventoryResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevClearInventoryResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

