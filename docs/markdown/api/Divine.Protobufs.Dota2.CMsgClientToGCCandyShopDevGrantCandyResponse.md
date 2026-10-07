# <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantCandyResponse"></a> Class CMsgClientToGCCandyShopDevGrantCandyResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCCandyShopDevGrantCandyResponse : IMessage<CMsgClientToGCCandyShopDevGrantCandyResponse>, IEquatable<CMsgClientToGCCandyShopDevGrantCandyResponse>, IDeepCloneable<CMsgClientToGCCandyShopDevGrantCandyResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCCandyShopDevGrantCandyResponse](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopDevGrantCandyResponse.md)

#### Implements

IMessage<CMsgClientToGCCandyShopDevGrantCandyResponse\>, 
[IEquatable<CMsgClientToGCCandyShopDevGrantCandyResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCCandyShopDevGrantCandyResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCCandyShopDevGrantCandyResponse\>\(CMsgClientToGCCandyShopDevGrantCandyResponse, params CMsgClientToGCCandyShopDevGrantCandyResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantCandyResponse__ctor"></a> CMsgClientToGCCandyShopDevGrantCandyResponse\(\)

```csharp
public CMsgClientToGCCandyShopDevGrantCandyResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantCandyResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantCandyResponse_"></a> CMsgClientToGCCandyShopDevGrantCandyResponse\(CMsgClientToGCCandyShopDevGrantCandyResponse\)

```csharp
public CMsgClientToGCCandyShopDevGrantCandyResponse(CMsgClientToGCCandyShopDevGrantCandyResponse other)
```

#### Parameters

`other` [CMsgClientToGCCandyShopDevGrantCandyResponse](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopDevGrantCandyResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantCandyResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantCandyResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantCandyResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantCandyResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCCandyShopDevGrantCandyResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCCandyShopDevGrantCandyResponse](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopDevGrantCandyResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantCandyResponse_Response"></a> Response

```csharp
public CCandyShopDev.Types.EResponse Response { get; set; }
```

#### Property Value

 [CCandyShopDev](Divine.Protobufs.Dota2.CCandyShopDev.md).[Types](Divine.Protobufs.Dota2.CCandyShopDev.Types.md).[EResponse](Divine.Protobufs.Dota2.CCandyShopDev.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantCandyResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantCandyResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantCandyResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCCandyShopDevGrantCandyResponse Clone()
```

#### Returns

 [CMsgClientToGCCandyShopDevGrantCandyResponse](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopDevGrantCandyResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantCandyResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantCandyResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantCandyResponse_"></a> Equals\(CMsgClientToGCCandyShopDevGrantCandyResponse\)

```csharp
public bool Equals(CMsgClientToGCCandyShopDevGrantCandyResponse other)
```

#### Parameters

`other` [CMsgClientToGCCandyShopDevGrantCandyResponse](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopDevGrantCandyResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantCandyResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantCandyResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantCandyResponse_"></a> MergeFrom\(CMsgClientToGCCandyShopDevGrantCandyResponse\)

```csharp
public void MergeFrom(CMsgClientToGCCandyShopDevGrantCandyResponse other)
```

#### Parameters

`other` [CMsgClientToGCCandyShopDevGrantCandyResponse](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopDevGrantCandyResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantCandyResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantCandyResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDevGrantCandyResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

