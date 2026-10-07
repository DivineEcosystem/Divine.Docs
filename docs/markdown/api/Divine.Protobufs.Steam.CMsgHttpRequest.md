# <a id="Divine_Protobufs_Steam_CMsgHttpRequest"></a> Class CMsgHttpRequest

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgHttpRequest : IMessage<CMsgHttpRequest>, IEquatable<CMsgHttpRequest>, IDeepCloneable<CMsgHttpRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgHttpRequest](Divine.Protobufs.Steam.CMsgHttpRequest.md)

#### Implements

IMessage<CMsgHttpRequest\>, 
[IEquatable<CMsgHttpRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgHttpRequest\>, 
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
[EnumerableExtensions.In<CMsgHttpRequest\>\(CMsgHttpRequest, params CMsgHttpRequest\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgHttpRequest__ctor"></a> CMsgHttpRequest\(\)

```csharp
public CMsgHttpRequest()
```

### <a id="Divine_Protobufs_Steam_CMsgHttpRequest__ctor_Divine_Protobufs_Steam_CMsgHttpRequest_"></a> CMsgHttpRequest\(CMsgHttpRequest\)

```csharp
public CMsgHttpRequest(CMsgHttpRequest other)
```

#### Parameters

`other` [CMsgHttpRequest](Divine.Protobufs.Steam.CMsgHttpRequest.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgHttpRequest_AbsoluteTimeoutFieldNumber"></a> AbsoluteTimeoutFieldNumber

```csharp
public const int AbsoluteTimeoutFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgHttpRequest_BodyFieldNumber"></a> BodyFieldNumber

```csharp
public const int BodyFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgHttpRequest_GetParamsFieldNumber"></a> GetParamsFieldNumber

```csharp
public const int GetParamsFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgHttpRequest_HeadersFieldNumber"></a> HeadersFieldNumber

```csharp
public const int HeadersFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgHttpRequest_HostnameFieldNumber"></a> HostnameFieldNumber

```csharp
public const int HostnameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgHttpRequest_PostParamsFieldNumber"></a> PostParamsFieldNumber

```csharp
public const int PostParamsFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgHttpRequest_RequestMethodFieldNumber"></a> RequestMethodFieldNumber

```csharp
public const int RequestMethodFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgHttpRequest_UrlFieldNumber"></a> UrlFieldNumber

```csharp
public const int UrlFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgHttpRequest_UseHttpsFieldNumber"></a> UseHttpsFieldNumber

```csharp
public const int UseHttpsFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgHttpRequest_AbsoluteTimeout"></a> AbsoluteTimeout

```csharp
public uint AbsoluteTimeout { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgHttpRequest_Body"></a> Body

```csharp
public ByteString Body { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Steam_CMsgHttpRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgHttpRequest_GetParams"></a> GetParams

```csharp
public RepeatedField<CMsgHttpRequest.Types.QueryParam> GetParams { get; }
```

#### Property Value

 RepeatedField<[CMsgHttpRequest](Divine.Protobufs.Steam.CMsgHttpRequest.md).[Types](Divine.Protobufs.Steam.CMsgHttpRequest.Types.md).[QueryParam](Divine.Protobufs.Steam.CMsgHttpRequest.Types.QueryParam.md)\>

### <a id="Divine_Protobufs_Steam_CMsgHttpRequest_HasAbsoluteTimeout"></a> HasAbsoluteTimeout

```csharp
public bool HasAbsoluteTimeout { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgHttpRequest_HasBody"></a> HasBody

```csharp
public bool HasBody { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgHttpRequest_HasHostname"></a> HasHostname

```csharp
public bool HasHostname { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgHttpRequest_HasRequestMethod"></a> HasRequestMethod

```csharp
public bool HasRequestMethod { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgHttpRequest_HasUrl"></a> HasUrl

```csharp
public bool HasUrl { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgHttpRequest_HasUseHttps"></a> HasUseHttps

```csharp
public bool HasUseHttps { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgHttpRequest_Headers"></a> Headers

```csharp
public RepeatedField<CMsgHttpRequest.Types.RequestHeader> Headers { get; }
```

#### Property Value

 RepeatedField<[CMsgHttpRequest](Divine.Protobufs.Steam.CMsgHttpRequest.md).[Types](Divine.Protobufs.Steam.CMsgHttpRequest.Types.md).[RequestHeader](Divine.Protobufs.Steam.CMsgHttpRequest.Types.RequestHeader.md)\>

### <a id="Divine_Protobufs_Steam_CMsgHttpRequest_Hostname"></a> Hostname

```csharp
public string Hostname { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgHttpRequest_Parser"></a> Parser

```csharp
public static MessageParser<CMsgHttpRequest> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgHttpRequest](Divine.Protobufs.Steam.CMsgHttpRequest.md)\>

### <a id="Divine_Protobufs_Steam_CMsgHttpRequest_PostParams"></a> PostParams

```csharp
public RepeatedField<CMsgHttpRequest.Types.QueryParam> PostParams { get; }
```

#### Property Value

 RepeatedField<[CMsgHttpRequest](Divine.Protobufs.Steam.CMsgHttpRequest.md).[Types](Divine.Protobufs.Steam.CMsgHttpRequest.Types.md).[QueryParam](Divine.Protobufs.Steam.CMsgHttpRequest.Types.QueryParam.md)\>

### <a id="Divine_Protobufs_Steam_CMsgHttpRequest_RequestMethod"></a> RequestMethod

```csharp
public uint RequestMethod { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgHttpRequest_Url"></a> Url

```csharp
public string Url { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgHttpRequest_UseHttps"></a> UseHttps

```csharp
public bool UseHttps { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgHttpRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgHttpRequest_ClearAbsoluteTimeout"></a> ClearAbsoluteTimeout\(\)

```csharp
public void ClearAbsoluteTimeout()
```

### <a id="Divine_Protobufs_Steam_CMsgHttpRequest_ClearBody"></a> ClearBody\(\)

```csharp
public void ClearBody()
```

### <a id="Divine_Protobufs_Steam_CMsgHttpRequest_ClearHostname"></a> ClearHostname\(\)

```csharp
public void ClearHostname()
```

### <a id="Divine_Protobufs_Steam_CMsgHttpRequest_ClearRequestMethod"></a> ClearRequestMethod\(\)

```csharp
public void ClearRequestMethod()
```

### <a id="Divine_Protobufs_Steam_CMsgHttpRequest_ClearUrl"></a> ClearUrl\(\)

```csharp
public void ClearUrl()
```

### <a id="Divine_Protobufs_Steam_CMsgHttpRequest_ClearUseHttps"></a> ClearUseHttps\(\)

```csharp
public void ClearUseHttps()
```

### <a id="Divine_Protobufs_Steam_CMsgHttpRequest_Clone"></a> Clone\(\)

```csharp
public CMsgHttpRequest Clone()
```

#### Returns

 [CMsgHttpRequest](Divine.Protobufs.Steam.CMsgHttpRequest.md)

### <a id="Divine_Protobufs_Steam_CMsgHttpRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgHttpRequest_Equals_Divine_Protobufs_Steam_CMsgHttpRequest_"></a> Equals\(CMsgHttpRequest\)

```csharp
public bool Equals(CMsgHttpRequest other)
```

#### Parameters

`other` [CMsgHttpRequest](Divine.Protobufs.Steam.CMsgHttpRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgHttpRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgHttpRequest_MergeFrom_Divine_Protobufs_Steam_CMsgHttpRequest_"></a> MergeFrom\(CMsgHttpRequest\)

```csharp
public void MergeFrom(CMsgHttpRequest other)
```

#### Parameters

`other` [CMsgHttpRequest](Divine.Protobufs.Steam.CMsgHttpRequest.md)

### <a id="Divine_Protobufs_Steam_CMsgHttpRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgHttpRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgHttpRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

