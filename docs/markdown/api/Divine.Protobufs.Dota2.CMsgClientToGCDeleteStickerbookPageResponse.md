# <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeleteStickerbookPageResponse"></a> Class CMsgClientToGCDeleteStickerbookPageResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCDeleteStickerbookPageResponse : IMessage<CMsgClientToGCDeleteStickerbookPageResponse>, IEquatable<CMsgClientToGCDeleteStickerbookPageResponse>, IDeepCloneable<CMsgClientToGCDeleteStickerbookPageResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCDeleteStickerbookPageResponse](Divine.Protobufs.Dota2.CMsgClientToGCDeleteStickerbookPageResponse.md)

#### Implements

IMessage<CMsgClientToGCDeleteStickerbookPageResponse\>, 
[IEquatable<CMsgClientToGCDeleteStickerbookPageResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCDeleteStickerbookPageResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCDeleteStickerbookPageResponse\>\(CMsgClientToGCDeleteStickerbookPageResponse, params CMsgClientToGCDeleteStickerbookPageResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeleteStickerbookPageResponse__ctor"></a> CMsgClientToGCDeleteStickerbookPageResponse\(\)

```csharp
public CMsgClientToGCDeleteStickerbookPageResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeleteStickerbookPageResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCDeleteStickerbookPageResponse_"></a> CMsgClientToGCDeleteStickerbookPageResponse\(CMsgClientToGCDeleteStickerbookPageResponse\)

```csharp
public CMsgClientToGCDeleteStickerbookPageResponse(CMsgClientToGCDeleteStickerbookPageResponse other)
```

#### Parameters

`other` [CMsgClientToGCDeleteStickerbookPageResponse](Divine.Protobufs.Dota2.CMsgClientToGCDeleteStickerbookPageResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeleteStickerbookPageResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeleteStickerbookPageResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeleteStickerbookPageResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeleteStickerbookPageResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCDeleteStickerbookPageResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCDeleteStickerbookPageResponse](Divine.Protobufs.Dota2.CMsgClientToGCDeleteStickerbookPageResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeleteStickerbookPageResponse_Response"></a> Response

```csharp
public CMsgClientToGCDeleteStickerbookPageResponse.Types.EResponse Response { get; set; }
```

#### Property Value

 [CMsgClientToGCDeleteStickerbookPageResponse](Divine.Protobufs.Dota2.CMsgClientToGCDeleteStickerbookPageResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCDeleteStickerbookPageResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCDeleteStickerbookPageResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeleteStickerbookPageResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeleteStickerbookPageResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeleteStickerbookPageResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCDeleteStickerbookPageResponse Clone()
```

#### Returns

 [CMsgClientToGCDeleteStickerbookPageResponse](Divine.Protobufs.Dota2.CMsgClientToGCDeleteStickerbookPageResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeleteStickerbookPageResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeleteStickerbookPageResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCDeleteStickerbookPageResponse_"></a> Equals\(CMsgClientToGCDeleteStickerbookPageResponse\)

```csharp
public bool Equals(CMsgClientToGCDeleteStickerbookPageResponse other)
```

#### Parameters

`other` [CMsgClientToGCDeleteStickerbookPageResponse](Divine.Protobufs.Dota2.CMsgClientToGCDeleteStickerbookPageResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeleteStickerbookPageResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeleteStickerbookPageResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCDeleteStickerbookPageResponse_"></a> MergeFrom\(CMsgClientToGCDeleteStickerbookPageResponse\)

```csharp
public void MergeFrom(CMsgClientToGCDeleteStickerbookPageResponse other)
```

#### Parameters

`other` [CMsgClientToGCDeleteStickerbookPageResponse](Divine.Protobufs.Dota2.CMsgClientToGCDeleteStickerbookPageResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeleteStickerbookPageResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeleteStickerbookPageResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeleteStickerbookPageResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

