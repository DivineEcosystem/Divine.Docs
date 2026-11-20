# <a id="Divine_Protobufs_Dota2_CMsgGCUseItemResponse"></a> Class CMsgGCUseItemResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCUseItemResponse : IMessage<CMsgGCUseItemResponse>, IEquatable<CMsgGCUseItemResponse>, IDeepCloneable<CMsgGCUseItemResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCUseItemResponse](Divine.Protobufs.Dota2.CMsgGCUseItemResponse.md)

#### Implements

IMessage<CMsgGCUseItemResponse\>, 
[IEquatable<CMsgGCUseItemResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCUseItemResponse\>, 
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
[EnumerableExtensions.In<CMsgGCUseItemResponse\>\(CMsgGCUseItemResponse, params CMsgGCUseItemResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCUseItemResponse__ctor"></a> CMsgGCUseItemResponse\(\)

```csharp
public CMsgGCUseItemResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCUseItemResponse__ctor_Divine_Protobufs_Dota2_CMsgGCUseItemResponse_"></a> CMsgGCUseItemResponse\(CMsgGCUseItemResponse\)

```csharp
public CMsgGCUseItemResponse(CMsgGCUseItemResponse other)
```

#### Parameters

`other` [CMsgGCUseItemResponse](Divine.Protobufs.Dota2.CMsgGCUseItemResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCUseItemResponse_DefindexFieldNumber"></a> DefindexFieldNumber

```csharp
public const int DefindexFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCUseItemResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCUseItemResponse_Defindex"></a> Defindex

```csharp
public uint Defindex { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCUseItemResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCUseItemResponse_HasDefindex"></a> HasDefindex

```csharp
public bool HasDefindex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCUseItemResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCUseItemResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCUseItemResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCUseItemResponse](Divine.Protobufs.Dota2.CMsgGCUseItemResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCUseItemResponse_Response"></a> Response

```csharp
public EGCMsgUseItemResponse Response { get; set; }
```

#### Property Value

 [EGCMsgUseItemResponse](Divine.Protobufs.Dota2.EGCMsgUseItemResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCUseItemResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCUseItemResponse_ClearDefindex"></a> ClearDefindex\(\)

```csharp
public void ClearDefindex()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCUseItemResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCUseItemResponse_Clone"></a> Clone\(\)

```csharp
public CMsgGCUseItemResponse Clone()
```

#### Returns

 [CMsgGCUseItemResponse](Divine.Protobufs.Dota2.CMsgGCUseItemResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCUseItemResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCUseItemResponse_Equals_Divine_Protobufs_Dota2_CMsgGCUseItemResponse_"></a> Equals\(CMsgGCUseItemResponse\)

```csharp
public bool Equals(CMsgGCUseItemResponse other)
```

#### Parameters

`other` [CMsgGCUseItemResponse](Divine.Protobufs.Dota2.CMsgGCUseItemResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCUseItemResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCUseItemResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgGCUseItemResponse_"></a> MergeFrom\(CMsgGCUseItemResponse\)

```csharp
public void MergeFrom(CMsgGCUseItemResponse other)
```

#### Parameters

`other` [CMsgGCUseItemResponse](Divine.Protobufs.Dota2.CMsgGCUseItemResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCUseItemResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCUseItemResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCUseItemResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

