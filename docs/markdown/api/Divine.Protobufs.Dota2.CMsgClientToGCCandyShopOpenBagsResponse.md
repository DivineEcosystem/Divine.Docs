# <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopOpenBagsResponse"></a> Class CMsgClientToGCCandyShopOpenBagsResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCCandyShopOpenBagsResponse : IMessage<CMsgClientToGCCandyShopOpenBagsResponse>, IEquatable<CMsgClientToGCCandyShopOpenBagsResponse>, IDeepCloneable<CMsgClientToGCCandyShopOpenBagsResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCCandyShopOpenBagsResponse](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopOpenBagsResponse.md)

#### Implements

IMessage<CMsgClientToGCCandyShopOpenBagsResponse\>, 
[IEquatable<CMsgClientToGCCandyShopOpenBagsResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCCandyShopOpenBagsResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCCandyShopOpenBagsResponse\>\(CMsgClientToGCCandyShopOpenBagsResponse, params CMsgClientToGCCandyShopOpenBagsResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopOpenBagsResponse__ctor"></a> CMsgClientToGCCandyShopOpenBagsResponse\(\)

```csharp
public CMsgClientToGCCandyShopOpenBagsResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopOpenBagsResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCCandyShopOpenBagsResponse_"></a> CMsgClientToGCCandyShopOpenBagsResponse\(CMsgClientToGCCandyShopOpenBagsResponse\)

```csharp
public CMsgClientToGCCandyShopOpenBagsResponse(CMsgClientToGCCandyShopOpenBagsResponse other)
```

#### Parameters

`other` [CMsgClientToGCCandyShopOpenBagsResponse](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopOpenBagsResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopOpenBagsResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopOpenBagsResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopOpenBagsResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopOpenBagsResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCCandyShopOpenBagsResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCCandyShopOpenBagsResponse](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopOpenBagsResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopOpenBagsResponse_Response"></a> Response

```csharp
public CMsgClientToGCCandyShopOpenBagsResponse.Types.EResponse Response { get; set; }
```

#### Property Value

 [CMsgClientToGCCandyShopOpenBagsResponse](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopOpenBagsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopOpenBagsResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopOpenBagsResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopOpenBagsResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopOpenBagsResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopOpenBagsResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCCandyShopOpenBagsResponse Clone()
```

#### Returns

 [CMsgClientToGCCandyShopOpenBagsResponse](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopOpenBagsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopOpenBagsResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopOpenBagsResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCCandyShopOpenBagsResponse_"></a> Equals\(CMsgClientToGCCandyShopOpenBagsResponse\)

```csharp
public bool Equals(CMsgClientToGCCandyShopOpenBagsResponse other)
```

#### Parameters

`other` [CMsgClientToGCCandyShopOpenBagsResponse](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopOpenBagsResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopOpenBagsResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopOpenBagsResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCCandyShopOpenBagsResponse_"></a> MergeFrom\(CMsgClientToGCCandyShopOpenBagsResponse\)

```csharp
public void MergeFrom(CMsgClientToGCCandyShopOpenBagsResponse other)
```

#### Parameters

`other` [CMsgClientToGCCandyShopOpenBagsResponse](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopOpenBagsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopOpenBagsResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopOpenBagsResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopOpenBagsResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

