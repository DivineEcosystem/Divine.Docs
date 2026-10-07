# <a id="Divine_Protobufs_Dota2_CMsgDOTARedeemItemResponse"></a> Class CMsgDOTARedeemItemResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTARedeemItemResponse : IMessage<CMsgDOTARedeemItemResponse>, IEquatable<CMsgDOTARedeemItemResponse>, IDeepCloneable<CMsgDOTARedeemItemResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTARedeemItemResponse](Divine.Protobufs.Dota2.CMsgDOTARedeemItemResponse.md)

#### Implements

IMessage<CMsgDOTARedeemItemResponse\>, 
[IEquatable<CMsgDOTARedeemItemResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTARedeemItemResponse\>, 
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
[EnumerableExtensions.In<CMsgDOTARedeemItemResponse\>\(CMsgDOTARedeemItemResponse, params CMsgDOTARedeemItemResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTARedeemItemResponse__ctor"></a> CMsgDOTARedeemItemResponse\(\)

```csharp
public CMsgDOTARedeemItemResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARedeemItemResponse__ctor_Divine_Protobufs_Dota2_CMsgDOTARedeemItemResponse_"></a> CMsgDOTARedeemItemResponse\(CMsgDOTARedeemItemResponse\)

```csharp
public CMsgDOTARedeemItemResponse(CMsgDOTARedeemItemResponse other)
```

#### Parameters

`other` [CMsgDOTARedeemItemResponse](Divine.Protobufs.Dota2.CMsgDOTARedeemItemResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTARedeemItemResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTARedeemItemResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTARedeemItemResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARedeemItemResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTARedeemItemResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTARedeemItemResponse](Divine.Protobufs.Dota2.CMsgDOTARedeemItemResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTARedeemItemResponse_Response"></a> Response

```csharp
public CMsgDOTARedeemItemResponse.Types.EResultCode Response { get; set; }
```

#### Property Value

 [CMsgDOTARedeemItemResponse](Divine.Protobufs.Dota2.CMsgDOTARedeemItemResponse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARedeemItemResponse.Types.md).[EResultCode](Divine.Protobufs.Dota2.CMsgDOTARedeemItemResponse.Types.EResultCode.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTARedeemItemResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARedeemItemResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARedeemItemResponse_Clone"></a> Clone\(\)

```csharp
public CMsgDOTARedeemItemResponse Clone()
```

#### Returns

 [CMsgDOTARedeemItemResponse](Divine.Protobufs.Dota2.CMsgDOTARedeemItemResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARedeemItemResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARedeemItemResponse_Equals_Divine_Protobufs_Dota2_CMsgDOTARedeemItemResponse_"></a> Equals\(CMsgDOTARedeemItemResponse\)

```csharp
public bool Equals(CMsgDOTARedeemItemResponse other)
```

#### Parameters

`other` [CMsgDOTARedeemItemResponse](Divine.Protobufs.Dota2.CMsgDOTARedeemItemResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARedeemItemResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARedeemItemResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTARedeemItemResponse_"></a> MergeFrom\(CMsgDOTARedeemItemResponse\)

```csharp
public void MergeFrom(CMsgDOTARedeemItemResponse other)
```

#### Parameters

`other` [CMsgDOTARedeemItemResponse](Divine.Protobufs.Dota2.CMsgDOTARedeemItemResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARedeemItemResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTARedeemItemResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARedeemItemResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

