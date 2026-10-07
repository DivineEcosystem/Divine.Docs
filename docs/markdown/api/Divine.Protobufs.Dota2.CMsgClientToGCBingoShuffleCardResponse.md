# <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoShuffleCardResponse"></a> Class CMsgClientToGCBingoShuffleCardResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCBingoShuffleCardResponse : IMessage<CMsgClientToGCBingoShuffleCardResponse>, IEquatable<CMsgClientToGCBingoShuffleCardResponse>, IDeepCloneable<CMsgClientToGCBingoShuffleCardResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCBingoShuffleCardResponse](Divine.Protobufs.Dota2.CMsgClientToGCBingoShuffleCardResponse.md)

#### Implements

IMessage<CMsgClientToGCBingoShuffleCardResponse\>, 
[IEquatable<CMsgClientToGCBingoShuffleCardResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCBingoShuffleCardResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCBingoShuffleCardResponse\>\(CMsgClientToGCBingoShuffleCardResponse, params CMsgClientToGCBingoShuffleCardResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoShuffleCardResponse__ctor"></a> CMsgClientToGCBingoShuffleCardResponse\(\)

```csharp
public CMsgClientToGCBingoShuffleCardResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoShuffleCardResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCBingoShuffleCardResponse_"></a> CMsgClientToGCBingoShuffleCardResponse\(CMsgClientToGCBingoShuffleCardResponse\)

```csharp
public CMsgClientToGCBingoShuffleCardResponse(CMsgClientToGCBingoShuffleCardResponse other)
```

#### Parameters

`other` [CMsgClientToGCBingoShuffleCardResponse](Divine.Protobufs.Dota2.CMsgClientToGCBingoShuffleCardResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoShuffleCardResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoShuffleCardResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoShuffleCardResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoShuffleCardResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCBingoShuffleCardResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCBingoShuffleCardResponse](Divine.Protobufs.Dota2.CMsgClientToGCBingoShuffleCardResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoShuffleCardResponse_Response"></a> Response

```csharp
public CMsgClientToGCBingoShuffleCardResponse.Types.EResponse Response { get; set; }
```

#### Property Value

 [CMsgClientToGCBingoShuffleCardResponse](Divine.Protobufs.Dota2.CMsgClientToGCBingoShuffleCardResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCBingoShuffleCardResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCBingoShuffleCardResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoShuffleCardResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoShuffleCardResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoShuffleCardResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCBingoShuffleCardResponse Clone()
```

#### Returns

 [CMsgClientToGCBingoShuffleCardResponse](Divine.Protobufs.Dota2.CMsgClientToGCBingoShuffleCardResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoShuffleCardResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoShuffleCardResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCBingoShuffleCardResponse_"></a> Equals\(CMsgClientToGCBingoShuffleCardResponse\)

```csharp
public bool Equals(CMsgClientToGCBingoShuffleCardResponse other)
```

#### Parameters

`other` [CMsgClientToGCBingoShuffleCardResponse](Divine.Protobufs.Dota2.CMsgClientToGCBingoShuffleCardResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoShuffleCardResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoShuffleCardResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCBingoShuffleCardResponse_"></a> MergeFrom\(CMsgClientToGCBingoShuffleCardResponse\)

```csharp
public void MergeFrom(CMsgClientToGCBingoShuffleCardResponse other)
```

#### Parameters

`other` [CMsgClientToGCBingoShuffleCardResponse](Divine.Protobufs.Dota2.CMsgClientToGCBingoShuffleCardResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoShuffleCardResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoShuffleCardResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoShuffleCardResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

