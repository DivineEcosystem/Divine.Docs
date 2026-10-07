# <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetHeroStickerResponse"></a> Class CMsgClientToGCSetHeroStickerResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCSetHeroStickerResponse : IMessage<CMsgClientToGCSetHeroStickerResponse>, IEquatable<CMsgClientToGCSetHeroStickerResponse>, IDeepCloneable<CMsgClientToGCSetHeroStickerResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCSetHeroStickerResponse](Divine.Protobufs.Dota2.CMsgClientToGCSetHeroStickerResponse.md)

#### Implements

IMessage<CMsgClientToGCSetHeroStickerResponse\>, 
[IEquatable<CMsgClientToGCSetHeroStickerResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCSetHeroStickerResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCSetHeroStickerResponse\>\(CMsgClientToGCSetHeroStickerResponse, params CMsgClientToGCSetHeroStickerResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetHeroStickerResponse__ctor"></a> CMsgClientToGCSetHeroStickerResponse\(\)

```csharp
public CMsgClientToGCSetHeroStickerResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetHeroStickerResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCSetHeroStickerResponse_"></a> CMsgClientToGCSetHeroStickerResponse\(CMsgClientToGCSetHeroStickerResponse\)

```csharp
public CMsgClientToGCSetHeroStickerResponse(CMsgClientToGCSetHeroStickerResponse other)
```

#### Parameters

`other` [CMsgClientToGCSetHeroStickerResponse](Divine.Protobufs.Dota2.CMsgClientToGCSetHeroStickerResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetHeroStickerResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetHeroStickerResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetHeroStickerResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetHeroStickerResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCSetHeroStickerResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCSetHeroStickerResponse](Divine.Protobufs.Dota2.CMsgClientToGCSetHeroStickerResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetHeroStickerResponse_Response"></a> Response

```csharp
public CMsgClientToGCSetHeroStickerResponse.Types.EResponse Response { get; set; }
```

#### Property Value

 [CMsgClientToGCSetHeroStickerResponse](Divine.Protobufs.Dota2.CMsgClientToGCSetHeroStickerResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCSetHeroStickerResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCSetHeroStickerResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetHeroStickerResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetHeroStickerResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetHeroStickerResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCSetHeroStickerResponse Clone()
```

#### Returns

 [CMsgClientToGCSetHeroStickerResponse](Divine.Protobufs.Dota2.CMsgClientToGCSetHeroStickerResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetHeroStickerResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetHeroStickerResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCSetHeroStickerResponse_"></a> Equals\(CMsgClientToGCSetHeroStickerResponse\)

```csharp
public bool Equals(CMsgClientToGCSetHeroStickerResponse other)
```

#### Parameters

`other` [CMsgClientToGCSetHeroStickerResponse](Divine.Protobufs.Dota2.CMsgClientToGCSetHeroStickerResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetHeroStickerResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetHeroStickerResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCSetHeroStickerResponse_"></a> MergeFrom\(CMsgClientToGCSetHeroStickerResponse\)

```csharp
public void MergeFrom(CMsgClientToGCSetHeroStickerResponse other)
```

#### Parameters

`other` [CMsgClientToGCSetHeroStickerResponse](Divine.Protobufs.Dota2.CMsgClientToGCSetHeroStickerResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetHeroStickerResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetHeroStickerResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetHeroStickerResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

