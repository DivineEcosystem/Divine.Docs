# <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetReportsRollupResponse"></a> Class CMsgClientToGCShowcaseAdminGetReportsRollupResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCShowcaseAdminGetReportsRollupResponse : IMessage<CMsgClientToGCShowcaseAdminGetReportsRollupResponse>, IEquatable<CMsgClientToGCShowcaseAdminGetReportsRollupResponse>, IDeepCloneable<CMsgClientToGCShowcaseAdminGetReportsRollupResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCShowcaseAdminGetReportsRollupResponse](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseAdminGetReportsRollupResponse.md)

#### Implements

IMessage<CMsgClientToGCShowcaseAdminGetReportsRollupResponse\>, 
[IEquatable<CMsgClientToGCShowcaseAdminGetReportsRollupResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCShowcaseAdminGetReportsRollupResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCShowcaseAdminGetReportsRollupResponse\>\(CMsgClientToGCShowcaseAdminGetReportsRollupResponse, params CMsgClientToGCShowcaseAdminGetReportsRollupResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetReportsRollupResponse__ctor"></a> CMsgClientToGCShowcaseAdminGetReportsRollupResponse\(\)

```csharp
public CMsgClientToGCShowcaseAdminGetReportsRollupResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetReportsRollupResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetReportsRollupResponse_"></a> CMsgClientToGCShowcaseAdminGetReportsRollupResponse\(CMsgClientToGCShowcaseAdminGetReportsRollupResponse\)

```csharp
public CMsgClientToGCShowcaseAdminGetReportsRollupResponse(CMsgClientToGCShowcaseAdminGetReportsRollupResponse other)
```

#### Parameters

`other` [CMsgClientToGCShowcaseAdminGetReportsRollupResponse](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseAdminGetReportsRollupResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetReportsRollupResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetReportsRollupResponse_RollupFieldNumber"></a> RollupFieldNumber

```csharp
public const int RollupFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetReportsRollupResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetReportsRollupResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetReportsRollupResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCShowcaseAdminGetReportsRollupResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCShowcaseAdminGetReportsRollupResponse](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseAdminGetReportsRollupResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetReportsRollupResponse_Response"></a> Response

```csharp
public CMsgClientToGCShowcaseAdminGetReportsRollupResponse.Types.EResponse Response { get; set; }
```

#### Property Value

 [CMsgClientToGCShowcaseAdminGetReportsRollupResponse](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseAdminGetReportsRollupResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseAdminGetReportsRollupResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseAdminGetReportsRollupResponse.Types.EResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetReportsRollupResponse_Rollup"></a> Rollup

```csharp
public CMsgShowcaseReportsRollup Rollup { get; set; }
```

#### Property Value

 [CMsgShowcaseReportsRollup](Divine.Protobufs.Dota2.CMsgShowcaseReportsRollup.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetReportsRollupResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetReportsRollupResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetReportsRollupResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCShowcaseAdminGetReportsRollupResponse Clone()
```

#### Returns

 [CMsgClientToGCShowcaseAdminGetReportsRollupResponse](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseAdminGetReportsRollupResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetReportsRollupResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetReportsRollupResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetReportsRollupResponse_"></a> Equals\(CMsgClientToGCShowcaseAdminGetReportsRollupResponse\)

```csharp
public bool Equals(CMsgClientToGCShowcaseAdminGetReportsRollupResponse other)
```

#### Parameters

`other` [CMsgClientToGCShowcaseAdminGetReportsRollupResponse](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseAdminGetReportsRollupResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetReportsRollupResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetReportsRollupResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetReportsRollupResponse_"></a> MergeFrom\(CMsgClientToGCShowcaseAdminGetReportsRollupResponse\)

```csharp
public void MergeFrom(CMsgClientToGCShowcaseAdminGetReportsRollupResponse other)
```

#### Parameters

`other` [CMsgClientToGCShowcaseAdminGetReportsRollupResponse](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseAdminGetReportsRollupResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetReportsRollupResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetReportsRollupResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetReportsRollupResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

