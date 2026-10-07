# <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSubmitReportResponse"></a> Class CMsgClientToGCShowcaseSubmitReportResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCShowcaseSubmitReportResponse : IMessage<CMsgClientToGCShowcaseSubmitReportResponse>, IEquatable<CMsgClientToGCShowcaseSubmitReportResponse>, IDeepCloneable<CMsgClientToGCShowcaseSubmitReportResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCShowcaseSubmitReportResponse](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseSubmitReportResponse.md)

#### Implements

IMessage<CMsgClientToGCShowcaseSubmitReportResponse\>, 
[IEquatable<CMsgClientToGCShowcaseSubmitReportResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCShowcaseSubmitReportResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCShowcaseSubmitReportResponse\>\(CMsgClientToGCShowcaseSubmitReportResponse, params CMsgClientToGCShowcaseSubmitReportResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSubmitReportResponse__ctor"></a> CMsgClientToGCShowcaseSubmitReportResponse\(\)

```csharp
public CMsgClientToGCShowcaseSubmitReportResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSubmitReportResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSubmitReportResponse_"></a> CMsgClientToGCShowcaseSubmitReportResponse\(CMsgClientToGCShowcaseSubmitReportResponse\)

```csharp
public CMsgClientToGCShowcaseSubmitReportResponse(CMsgClientToGCShowcaseSubmitReportResponse other)
```

#### Parameters

`other` [CMsgClientToGCShowcaseSubmitReportResponse](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseSubmitReportResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSubmitReportResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSubmitReportResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSubmitReportResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSubmitReportResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCShowcaseSubmitReportResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCShowcaseSubmitReportResponse](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseSubmitReportResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSubmitReportResponse_Response"></a> Response

```csharp
public CMsgClientToGCShowcaseSubmitReportResponse.Types.EResponse Response { get; set; }
```

#### Property Value

 [CMsgClientToGCShowcaseSubmitReportResponse](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseSubmitReportResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseSubmitReportResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseSubmitReportResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSubmitReportResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSubmitReportResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSubmitReportResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCShowcaseSubmitReportResponse Clone()
```

#### Returns

 [CMsgClientToGCShowcaseSubmitReportResponse](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseSubmitReportResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSubmitReportResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSubmitReportResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSubmitReportResponse_"></a> Equals\(CMsgClientToGCShowcaseSubmitReportResponse\)

```csharp
public bool Equals(CMsgClientToGCShowcaseSubmitReportResponse other)
```

#### Parameters

`other` [CMsgClientToGCShowcaseSubmitReportResponse](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseSubmitReportResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSubmitReportResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSubmitReportResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSubmitReportResponse_"></a> MergeFrom\(CMsgClientToGCShowcaseSubmitReportResponse\)

```csharp
public void MergeFrom(CMsgClientToGCShowcaseSubmitReportResponse other)
```

#### Parameters

`other` [CMsgClientToGCShowcaseSubmitReportResponse](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseSubmitReportResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSubmitReportResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSubmitReportResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSubmitReportResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

