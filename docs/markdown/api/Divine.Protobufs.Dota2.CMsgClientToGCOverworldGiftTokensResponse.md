# <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGiftTokensResponse"></a> Class CMsgClientToGCOverworldGiftTokensResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCOverworldGiftTokensResponse : IMessage<CMsgClientToGCOverworldGiftTokensResponse>, IEquatable<CMsgClientToGCOverworldGiftTokensResponse>, IDeepCloneable<CMsgClientToGCOverworldGiftTokensResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCOverworldGiftTokensResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldGiftTokensResponse.md)

#### Implements

IMessage<CMsgClientToGCOverworldGiftTokensResponse\>, 
[IEquatable<CMsgClientToGCOverworldGiftTokensResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCOverworldGiftTokensResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCOverworldGiftTokensResponse\>\(CMsgClientToGCOverworldGiftTokensResponse, params CMsgClientToGCOverworldGiftTokensResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGiftTokensResponse__ctor"></a> CMsgClientToGCOverworldGiftTokensResponse\(\)

```csharp
public CMsgClientToGCOverworldGiftTokensResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGiftTokensResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCOverworldGiftTokensResponse_"></a> CMsgClientToGCOverworldGiftTokensResponse\(CMsgClientToGCOverworldGiftTokensResponse\)

```csharp
public CMsgClientToGCOverworldGiftTokensResponse(CMsgClientToGCOverworldGiftTokensResponse other)
```

#### Parameters

`other` [CMsgClientToGCOverworldGiftTokensResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldGiftTokensResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGiftTokensResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGiftTokensResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGiftTokensResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGiftTokensResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCOverworldGiftTokensResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCOverworldGiftTokensResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldGiftTokensResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGiftTokensResponse_Response"></a> Response

```csharp
public CMsgClientToGCOverworldGiftTokensResponse.Types.EResponse Response { get; set; }
```

#### Property Value

 [CMsgClientToGCOverworldGiftTokensResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldGiftTokensResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCOverworldGiftTokensResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldGiftTokensResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGiftTokensResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGiftTokensResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGiftTokensResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCOverworldGiftTokensResponse Clone()
```

#### Returns

 [CMsgClientToGCOverworldGiftTokensResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldGiftTokensResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGiftTokensResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGiftTokensResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCOverworldGiftTokensResponse_"></a> Equals\(CMsgClientToGCOverworldGiftTokensResponse\)

```csharp
public bool Equals(CMsgClientToGCOverworldGiftTokensResponse other)
```

#### Parameters

`other` [CMsgClientToGCOverworldGiftTokensResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldGiftTokensResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGiftTokensResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGiftTokensResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCOverworldGiftTokensResponse_"></a> MergeFrom\(CMsgClientToGCOverworldGiftTokensResponse\)

```csharp
public void MergeFrom(CMsgClientToGCOverworldGiftTokensResponse other)
```

#### Parameters

`other` [CMsgClientToGCOverworldGiftTokensResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldGiftTokensResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGiftTokensResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGiftTokensResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGiftTokensResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

