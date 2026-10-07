# <a id="Divine_Protobufs_Dota2_CMsgGCRequestSubGCSessionInfoResponse"></a> Class CMsgGCRequestSubGCSessionInfoResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCRequestSubGCSessionInfoResponse : IMessage<CMsgGCRequestSubGCSessionInfoResponse>, IEquatable<CMsgGCRequestSubGCSessionInfoResponse>, IDeepCloneable<CMsgGCRequestSubGCSessionInfoResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCRequestSubGCSessionInfoResponse](Divine.Protobufs.Dota2.CMsgGCRequestSubGCSessionInfoResponse.md)

#### Implements

IMessage<CMsgGCRequestSubGCSessionInfoResponse\>, 
[IEquatable<CMsgGCRequestSubGCSessionInfoResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCRequestSubGCSessionInfoResponse\>, 
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
[EnumerableExtensions.In<CMsgGCRequestSubGCSessionInfoResponse\>\(CMsgGCRequestSubGCSessionInfoResponse, params CMsgGCRequestSubGCSessionInfoResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestSubGCSessionInfoResponse__ctor"></a> CMsgGCRequestSubGCSessionInfoResponse\(\)

```csharp
public CMsgGCRequestSubGCSessionInfoResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestSubGCSessionInfoResponse__ctor_Divine_Protobufs_Dota2_CMsgGCRequestSubGCSessionInfoResponse_"></a> CMsgGCRequestSubGCSessionInfoResponse\(CMsgGCRequestSubGCSessionInfoResponse\)

```csharp
public CMsgGCRequestSubGCSessionInfoResponse(CMsgGCRequestSubGCSessionInfoResponse other)
```

#### Parameters

`other` [CMsgGCRequestSubGCSessionInfoResponse](Divine.Protobufs.Dota2.CMsgGCRequestSubGCSessionInfoResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestSubGCSessionInfoResponse_IpFieldNumber"></a> IpFieldNumber

```csharp
public const int IpFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestSubGCSessionInfoResponse_PortFieldNumber"></a> PortFieldNumber

```csharp
public const int PortFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestSubGCSessionInfoResponse_SuccessFieldNumber"></a> SuccessFieldNumber

```csharp
public const int SuccessFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestSubGCSessionInfoResponse_TrustedFieldNumber"></a> TrustedFieldNumber

```csharp
public const int TrustedFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestSubGCSessionInfoResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestSubGCSessionInfoResponse_HasIp"></a> HasIp

```csharp
public bool HasIp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestSubGCSessionInfoResponse_HasPort"></a> HasPort

```csharp
public bool HasPort { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestSubGCSessionInfoResponse_HasSuccess"></a> HasSuccess

```csharp
public bool HasSuccess { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestSubGCSessionInfoResponse_HasTrusted"></a> HasTrusted

```csharp
public bool HasTrusted { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestSubGCSessionInfoResponse_Ip"></a> Ip

```csharp
public uint Ip { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestSubGCSessionInfoResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCRequestSubGCSessionInfoResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCRequestSubGCSessionInfoResponse](Divine.Protobufs.Dota2.CMsgGCRequestSubGCSessionInfoResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestSubGCSessionInfoResponse_Port"></a> Port

```csharp
public uint Port { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestSubGCSessionInfoResponse_Success"></a> Success

```csharp
public bool Success { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestSubGCSessionInfoResponse_Trusted"></a> Trusted

```csharp
public bool Trusted { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestSubGCSessionInfoResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestSubGCSessionInfoResponse_ClearIp"></a> ClearIp\(\)

```csharp
public void ClearIp()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestSubGCSessionInfoResponse_ClearPort"></a> ClearPort\(\)

```csharp
public void ClearPort()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestSubGCSessionInfoResponse_ClearSuccess"></a> ClearSuccess\(\)

```csharp
public void ClearSuccess()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestSubGCSessionInfoResponse_ClearTrusted"></a> ClearTrusted\(\)

```csharp
public void ClearTrusted()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestSubGCSessionInfoResponse_Clone"></a> Clone\(\)

```csharp
public CMsgGCRequestSubGCSessionInfoResponse Clone()
```

#### Returns

 [CMsgGCRequestSubGCSessionInfoResponse](Divine.Protobufs.Dota2.CMsgGCRequestSubGCSessionInfoResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestSubGCSessionInfoResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestSubGCSessionInfoResponse_Equals_Divine_Protobufs_Dota2_CMsgGCRequestSubGCSessionInfoResponse_"></a> Equals\(CMsgGCRequestSubGCSessionInfoResponse\)

```csharp
public bool Equals(CMsgGCRequestSubGCSessionInfoResponse other)
```

#### Parameters

`other` [CMsgGCRequestSubGCSessionInfoResponse](Divine.Protobufs.Dota2.CMsgGCRequestSubGCSessionInfoResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestSubGCSessionInfoResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestSubGCSessionInfoResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgGCRequestSubGCSessionInfoResponse_"></a> MergeFrom\(CMsgGCRequestSubGCSessionInfoResponse\)

```csharp
public void MergeFrom(CMsgGCRequestSubGCSessionInfoResponse other)
```

#### Parameters

`other` [CMsgGCRequestSubGCSessionInfoResponse](Divine.Protobufs.Dota2.CMsgGCRequestSubGCSessionInfoResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestSubGCSessionInfoResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestSubGCSessionInfoResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestSubGCSessionInfoResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

