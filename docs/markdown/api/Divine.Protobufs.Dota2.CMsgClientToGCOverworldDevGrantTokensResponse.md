# <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantTokensResponse"></a> Class CMsgClientToGCOverworldDevGrantTokensResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCOverworldDevGrantTokensResponse : IMessage<CMsgClientToGCOverworldDevGrantTokensResponse>, IEquatable<CMsgClientToGCOverworldDevGrantTokensResponse>, IDeepCloneable<CMsgClientToGCOverworldDevGrantTokensResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCOverworldDevGrantTokensResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevGrantTokensResponse.md)

#### Implements

IMessage<CMsgClientToGCOverworldDevGrantTokensResponse\>, 
[IEquatable<CMsgClientToGCOverworldDevGrantTokensResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCOverworldDevGrantTokensResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCOverworldDevGrantTokensResponse\>\(CMsgClientToGCOverworldDevGrantTokensResponse, params CMsgClientToGCOverworldDevGrantTokensResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantTokensResponse__ctor"></a> CMsgClientToGCOverworldDevGrantTokensResponse\(\)

```csharp
public CMsgClientToGCOverworldDevGrantTokensResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantTokensResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantTokensResponse_"></a> CMsgClientToGCOverworldDevGrantTokensResponse\(CMsgClientToGCOverworldDevGrantTokensResponse\)

```csharp
public CMsgClientToGCOverworldDevGrantTokensResponse(CMsgClientToGCOverworldDevGrantTokensResponse other)
```

#### Parameters

`other` [CMsgClientToGCOverworldDevGrantTokensResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevGrantTokensResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantTokensResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantTokensResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantTokensResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantTokensResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCOverworldDevGrantTokensResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCOverworldDevGrantTokensResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevGrantTokensResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantTokensResponse_Response"></a> Response

```csharp
public CMsgClientToGCOverworldDevGrantTokensResponse.Types.EResponse Response { get; set; }
```

#### Property Value

 [CMsgClientToGCOverworldDevGrantTokensResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevGrantTokensResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevGrantTokensResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevGrantTokensResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantTokensResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantTokensResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantTokensResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCOverworldDevGrantTokensResponse Clone()
```

#### Returns

 [CMsgClientToGCOverworldDevGrantTokensResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevGrantTokensResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantTokensResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantTokensResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantTokensResponse_"></a> Equals\(CMsgClientToGCOverworldDevGrantTokensResponse\)

```csharp
public bool Equals(CMsgClientToGCOverworldDevGrantTokensResponse other)
```

#### Parameters

`other` [CMsgClientToGCOverworldDevGrantTokensResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevGrantTokensResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantTokensResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantTokensResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantTokensResponse_"></a> MergeFrom\(CMsgClientToGCOverworldDevGrantTokensResponse\)

```csharp
public void MergeFrom(CMsgClientToGCOverworldDevGrantTokensResponse other)
```

#### Parameters

`other` [CMsgClientToGCOverworldDevGrantTokensResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevGrantTokensResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantTokensResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantTokensResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantTokensResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

