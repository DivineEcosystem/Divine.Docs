# <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminResetResponse"></a> Class CMsgClientToGCShowcaseAdminResetResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCShowcaseAdminResetResponse : IMessage<CMsgClientToGCShowcaseAdminResetResponse>, IEquatable<CMsgClientToGCShowcaseAdminResetResponse>, IDeepCloneable<CMsgClientToGCShowcaseAdminResetResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCShowcaseAdminResetResponse](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseAdminResetResponse.md)

#### Implements

IMessage<CMsgClientToGCShowcaseAdminResetResponse\>, 
[IEquatable<CMsgClientToGCShowcaseAdminResetResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCShowcaseAdminResetResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCShowcaseAdminResetResponse\>\(CMsgClientToGCShowcaseAdminResetResponse, params CMsgClientToGCShowcaseAdminResetResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminResetResponse__ctor"></a> CMsgClientToGCShowcaseAdminResetResponse\(\)

```csharp
public CMsgClientToGCShowcaseAdminResetResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminResetResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminResetResponse_"></a> CMsgClientToGCShowcaseAdminResetResponse\(CMsgClientToGCShowcaseAdminResetResponse\)

```csharp
public CMsgClientToGCShowcaseAdminResetResponse(CMsgClientToGCShowcaseAdminResetResponse other)
```

#### Parameters

`other` [CMsgClientToGCShowcaseAdminResetResponse](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseAdminResetResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminResetResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminResetResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminResetResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminResetResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCShowcaseAdminResetResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCShowcaseAdminResetResponse](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseAdminResetResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminResetResponse_Response"></a> Response

```csharp
public CMsgClientToGCShowcaseAdminResetResponse.Types.EResponse Response { get; set; }
```

#### Property Value

 [CMsgClientToGCShowcaseAdminResetResponse](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseAdminResetResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseAdminResetResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseAdminResetResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminResetResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminResetResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminResetResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCShowcaseAdminResetResponse Clone()
```

#### Returns

 [CMsgClientToGCShowcaseAdminResetResponse](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseAdminResetResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminResetResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminResetResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminResetResponse_"></a> Equals\(CMsgClientToGCShowcaseAdminResetResponse\)

```csharp
public bool Equals(CMsgClientToGCShowcaseAdminResetResponse other)
```

#### Parameters

`other` [CMsgClientToGCShowcaseAdminResetResponse](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseAdminResetResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminResetResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminResetResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminResetResponse_"></a> MergeFrom\(CMsgClientToGCShowcaseAdminResetResponse\)

```csharp
public void MergeFrom(CMsgClientToGCShowcaseAdminResetResponse other)
```

#### Parameters

`other` [CMsgClientToGCShowcaseAdminResetResponse](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseAdminResetResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminResetResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminResetResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminResetResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

