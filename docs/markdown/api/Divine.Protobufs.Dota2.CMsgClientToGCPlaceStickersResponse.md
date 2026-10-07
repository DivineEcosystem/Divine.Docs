# <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceStickersResponse"></a> Class CMsgClientToGCPlaceStickersResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCPlaceStickersResponse : IMessage<CMsgClientToGCPlaceStickersResponse>, IEquatable<CMsgClientToGCPlaceStickersResponse>, IDeepCloneable<CMsgClientToGCPlaceStickersResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCPlaceStickersResponse](Divine.Protobufs.Dota2.CMsgClientToGCPlaceStickersResponse.md)

#### Implements

IMessage<CMsgClientToGCPlaceStickersResponse\>, 
[IEquatable<CMsgClientToGCPlaceStickersResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCPlaceStickersResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCPlaceStickersResponse\>\(CMsgClientToGCPlaceStickersResponse, params CMsgClientToGCPlaceStickersResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceStickersResponse__ctor"></a> CMsgClientToGCPlaceStickersResponse\(\)

```csharp
public CMsgClientToGCPlaceStickersResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceStickersResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCPlaceStickersResponse_"></a> CMsgClientToGCPlaceStickersResponse\(CMsgClientToGCPlaceStickersResponse\)

```csharp
public CMsgClientToGCPlaceStickersResponse(CMsgClientToGCPlaceStickersResponse other)
```

#### Parameters

`other` [CMsgClientToGCPlaceStickersResponse](Divine.Protobufs.Dota2.CMsgClientToGCPlaceStickersResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceStickersResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceStickersResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceStickersResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceStickersResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCPlaceStickersResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCPlaceStickersResponse](Divine.Protobufs.Dota2.CMsgClientToGCPlaceStickersResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceStickersResponse_Response"></a> Response

```csharp
public CMsgClientToGCPlaceStickersResponse.Types.EResponse Response { get; set; }
```

#### Property Value

 [CMsgClientToGCPlaceStickersResponse](Divine.Protobufs.Dota2.CMsgClientToGCPlaceStickersResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCPlaceStickersResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCPlaceStickersResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceStickersResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceStickersResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceStickersResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCPlaceStickersResponse Clone()
```

#### Returns

 [CMsgClientToGCPlaceStickersResponse](Divine.Protobufs.Dota2.CMsgClientToGCPlaceStickersResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceStickersResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceStickersResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCPlaceStickersResponse_"></a> Equals\(CMsgClientToGCPlaceStickersResponse\)

```csharp
public bool Equals(CMsgClientToGCPlaceStickersResponse other)
```

#### Parameters

`other` [CMsgClientToGCPlaceStickersResponse](Divine.Protobufs.Dota2.CMsgClientToGCPlaceStickersResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceStickersResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceStickersResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCPlaceStickersResponse_"></a> MergeFrom\(CMsgClientToGCPlaceStickersResponse\)

```csharp
public void MergeFrom(CMsgClientToGCPlaceStickersResponse other)
```

#### Parameters

`other` [CMsgClientToGCPlaceStickersResponse](Divine.Protobufs.Dota2.CMsgClientToGCPlaceStickersResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceStickersResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceStickersResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceStickersResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

