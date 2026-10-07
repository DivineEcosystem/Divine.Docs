# <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminExonerateResponse"></a> Class CMsgClientToGCShowcaseAdminExonerateResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCShowcaseAdminExonerateResponse : IMessage<CMsgClientToGCShowcaseAdminExonerateResponse>, IEquatable<CMsgClientToGCShowcaseAdminExonerateResponse>, IDeepCloneable<CMsgClientToGCShowcaseAdminExonerateResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCShowcaseAdminExonerateResponse](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseAdminExonerateResponse.md)

#### Implements

IMessage<CMsgClientToGCShowcaseAdminExonerateResponse\>, 
[IEquatable<CMsgClientToGCShowcaseAdminExonerateResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCShowcaseAdminExonerateResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCShowcaseAdminExonerateResponse\>\(CMsgClientToGCShowcaseAdminExonerateResponse, params CMsgClientToGCShowcaseAdminExonerateResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminExonerateResponse__ctor"></a> CMsgClientToGCShowcaseAdminExonerateResponse\(\)

```csharp
public CMsgClientToGCShowcaseAdminExonerateResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminExonerateResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminExonerateResponse_"></a> CMsgClientToGCShowcaseAdminExonerateResponse\(CMsgClientToGCShowcaseAdminExonerateResponse\)

```csharp
public CMsgClientToGCShowcaseAdminExonerateResponse(CMsgClientToGCShowcaseAdminExonerateResponse other)
```

#### Parameters

`other` [CMsgClientToGCShowcaseAdminExonerateResponse](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseAdminExonerateResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminExonerateResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminExonerateResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminExonerateResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminExonerateResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCShowcaseAdminExonerateResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCShowcaseAdminExonerateResponse](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseAdminExonerateResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminExonerateResponse_Response"></a> Response

```csharp
public CMsgClientToGCShowcaseAdminExonerateResponse.Types.EResponse Response { get; set; }
```

#### Property Value

 [CMsgClientToGCShowcaseAdminExonerateResponse](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseAdminExonerateResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseAdminExonerateResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseAdminExonerateResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminExonerateResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminExonerateResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminExonerateResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCShowcaseAdminExonerateResponse Clone()
```

#### Returns

 [CMsgClientToGCShowcaseAdminExonerateResponse](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseAdminExonerateResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminExonerateResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminExonerateResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminExonerateResponse_"></a> Equals\(CMsgClientToGCShowcaseAdminExonerateResponse\)

```csharp
public bool Equals(CMsgClientToGCShowcaseAdminExonerateResponse other)
```

#### Parameters

`other` [CMsgClientToGCShowcaseAdminExonerateResponse](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseAdminExonerateResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminExonerateResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminExonerateResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminExonerateResponse_"></a> MergeFrom\(CMsgClientToGCShowcaseAdminExonerateResponse\)

```csharp
public void MergeFrom(CMsgClientToGCShowcaseAdminExonerateResponse other)
```

#### Parameters

`other` [CMsgClientToGCShowcaseAdminExonerateResponse](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseAdminExonerateResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminExonerateResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminExonerateResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminExonerateResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

