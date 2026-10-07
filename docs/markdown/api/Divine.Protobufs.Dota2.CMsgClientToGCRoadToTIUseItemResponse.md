# <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIUseItemResponse"></a> Class CMsgClientToGCRoadToTIUseItemResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCRoadToTIUseItemResponse : IMessage<CMsgClientToGCRoadToTIUseItemResponse>, IEquatable<CMsgClientToGCRoadToTIUseItemResponse>, IDeepCloneable<CMsgClientToGCRoadToTIUseItemResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCRoadToTIUseItemResponse](Divine.Protobufs.Dota2.CMsgClientToGCRoadToTIUseItemResponse.md)

#### Implements

IMessage<CMsgClientToGCRoadToTIUseItemResponse\>, 
[IEquatable<CMsgClientToGCRoadToTIUseItemResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCRoadToTIUseItemResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCRoadToTIUseItemResponse\>\(CMsgClientToGCRoadToTIUseItemResponse, params CMsgClientToGCRoadToTIUseItemResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIUseItemResponse__ctor"></a> CMsgClientToGCRoadToTIUseItemResponse\(\)

```csharp
public CMsgClientToGCRoadToTIUseItemResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIUseItemResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIUseItemResponse_"></a> CMsgClientToGCRoadToTIUseItemResponse\(CMsgClientToGCRoadToTIUseItemResponse\)

```csharp
public CMsgClientToGCRoadToTIUseItemResponse(CMsgClientToGCRoadToTIUseItemResponse other)
```

#### Parameters

`other` [CMsgClientToGCRoadToTIUseItemResponse](Divine.Protobufs.Dota2.CMsgClientToGCRoadToTIUseItemResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIUseItemResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIUseItemResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIUseItemResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIUseItemResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCRoadToTIUseItemResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCRoadToTIUseItemResponse](Divine.Protobufs.Dota2.CMsgClientToGCRoadToTIUseItemResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIUseItemResponse_Response"></a> Response

```csharp
public CMsgClientToGCRoadToTIUseItemResponse.Types.EResponse Response { get; set; }
```

#### Property Value

 [CMsgClientToGCRoadToTIUseItemResponse](Divine.Protobufs.Dota2.CMsgClientToGCRoadToTIUseItemResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCRoadToTIUseItemResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCRoadToTIUseItemResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIUseItemResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIUseItemResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIUseItemResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCRoadToTIUseItemResponse Clone()
```

#### Returns

 [CMsgClientToGCRoadToTIUseItemResponse](Divine.Protobufs.Dota2.CMsgClientToGCRoadToTIUseItemResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIUseItemResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIUseItemResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIUseItemResponse_"></a> Equals\(CMsgClientToGCRoadToTIUseItemResponse\)

```csharp
public bool Equals(CMsgClientToGCRoadToTIUseItemResponse other)
```

#### Parameters

`other` [CMsgClientToGCRoadToTIUseItemResponse](Divine.Protobufs.Dota2.CMsgClientToGCRoadToTIUseItemResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIUseItemResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIUseItemResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIUseItemResponse_"></a> MergeFrom\(CMsgClientToGCRoadToTIUseItemResponse\)

```csharp
public void MergeFrom(CMsgClientToGCRoadToTIUseItemResponse other)
```

#### Parameters

`other` [CMsgClientToGCRoadToTIUseItemResponse](Divine.Protobufs.Dota2.CMsgClientToGCRoadToTIUseItemResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIUseItemResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIUseItemResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIUseItemResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

