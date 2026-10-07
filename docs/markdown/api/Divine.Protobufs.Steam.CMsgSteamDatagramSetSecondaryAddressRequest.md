# <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSetSecondaryAddressRequest"></a> Class CMsgSteamDatagramSetSecondaryAddressRequest

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamDatagramSetSecondaryAddressRequest : IMessage<CMsgSteamDatagramSetSecondaryAddressRequest>, IEquatable<CMsgSteamDatagramSetSecondaryAddressRequest>, IDeepCloneable<CMsgSteamDatagramSetSecondaryAddressRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamDatagramSetSecondaryAddressRequest](Divine.Protobufs.Steam.CMsgSteamDatagramSetSecondaryAddressRequest.md)

#### Implements

IMessage<CMsgSteamDatagramSetSecondaryAddressRequest\>, 
[IEquatable<CMsgSteamDatagramSetSecondaryAddressRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamDatagramSetSecondaryAddressRequest\>, 
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
[EnumerableExtensions.In<CMsgSteamDatagramSetSecondaryAddressRequest\>\(CMsgSteamDatagramSetSecondaryAddressRequest, params CMsgSteamDatagramSetSecondaryAddressRequest\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSetSecondaryAddressRequest__ctor"></a> CMsgSteamDatagramSetSecondaryAddressRequest\(\)

```csharp
public CMsgSteamDatagramSetSecondaryAddressRequest()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSetSecondaryAddressRequest__ctor_Divine_Protobufs_Steam_CMsgSteamDatagramSetSecondaryAddressRequest_"></a> CMsgSteamDatagramSetSecondaryAddressRequest\(CMsgSteamDatagramSetSecondaryAddressRequest\)

```csharp
public CMsgSteamDatagramSetSecondaryAddressRequest(CMsgSteamDatagramSetSecondaryAddressRequest other)
```

#### Parameters

`other` [CMsgSteamDatagramSetSecondaryAddressRequest](Divine.Protobufs.Steam.CMsgSteamDatagramSetSecondaryAddressRequest.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSetSecondaryAddressRequest_ClientConnectionIdFieldNumber"></a> ClientConnectionIdFieldNumber

```csharp
public const int ClientConnectionIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSetSecondaryAddressRequest_ClientIdentityFieldNumber"></a> ClientIdentityFieldNumber

```csharp
public const int ClientIdentityFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSetSecondaryAddressRequest_ClientMainIpFieldNumber"></a> ClientMainIpFieldNumber

```csharp
public const int ClientMainIpFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSetSecondaryAddressRequest_ClientMainPortFieldNumber"></a> ClientMainPortFieldNumber

```csharp
public const int ClientMainPortFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSetSecondaryAddressRequest_KludgePadFieldNumber"></a> KludgePadFieldNumber

```csharp
public const int KludgePadFieldNumber = 99
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSetSecondaryAddressRequest_RequestSendDuplicationFieldNumber"></a> RequestSendDuplicationFieldNumber

```csharp
public const int RequestSendDuplicationFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSetSecondaryAddressRequest_ClientConnectionId"></a> ClientConnectionId

```csharp
public uint ClientConnectionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSetSecondaryAddressRequest_ClientIdentity"></a> ClientIdentity

```csharp
public string ClientIdentity { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSetSecondaryAddressRequest_ClientMainIp"></a> ClientMainIp

```csharp
public uint ClientMainIp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSetSecondaryAddressRequest_ClientMainPort"></a> ClientMainPort

```csharp
public uint ClientMainPort { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSetSecondaryAddressRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSetSecondaryAddressRequest_HasClientConnectionId"></a> HasClientConnectionId

```csharp
public bool HasClientConnectionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSetSecondaryAddressRequest_HasClientIdentity"></a> HasClientIdentity

```csharp
public bool HasClientIdentity { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSetSecondaryAddressRequest_HasClientMainIp"></a> HasClientMainIp

```csharp
public bool HasClientMainIp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSetSecondaryAddressRequest_HasClientMainPort"></a> HasClientMainPort

```csharp
public bool HasClientMainPort { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSetSecondaryAddressRequest_HasKludgePad"></a> HasKludgePad

```csharp
public bool HasKludgePad { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSetSecondaryAddressRequest_HasRequestSendDuplication"></a> HasRequestSendDuplication

```csharp
public bool HasRequestSendDuplication { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSetSecondaryAddressRequest_KludgePad"></a> KludgePad

```csharp
public ByteString KludgePad { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSetSecondaryAddressRequest_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamDatagramSetSecondaryAddressRequest> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamDatagramSetSecondaryAddressRequest](Divine.Protobufs.Steam.CMsgSteamDatagramSetSecondaryAddressRequest.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSetSecondaryAddressRequest_RequestSendDuplication"></a> RequestSendDuplication

```csharp
public bool RequestSendDuplication { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSetSecondaryAddressRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSetSecondaryAddressRequest_ClearClientConnectionId"></a> ClearClientConnectionId\(\)

```csharp
public void ClearClientConnectionId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSetSecondaryAddressRequest_ClearClientIdentity"></a> ClearClientIdentity\(\)

```csharp
public void ClearClientIdentity()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSetSecondaryAddressRequest_ClearClientMainIp"></a> ClearClientMainIp\(\)

```csharp
public void ClearClientMainIp()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSetSecondaryAddressRequest_ClearClientMainPort"></a> ClearClientMainPort\(\)

```csharp
public void ClearClientMainPort()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSetSecondaryAddressRequest_ClearKludgePad"></a> ClearKludgePad\(\)

```csharp
public void ClearKludgePad()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSetSecondaryAddressRequest_ClearRequestSendDuplication"></a> ClearRequestSendDuplication\(\)

```csharp
public void ClearRequestSendDuplication()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSetSecondaryAddressRequest_Clone"></a> Clone\(\)

```csharp
public CMsgSteamDatagramSetSecondaryAddressRequest Clone()
```

#### Returns

 [CMsgSteamDatagramSetSecondaryAddressRequest](Divine.Protobufs.Steam.CMsgSteamDatagramSetSecondaryAddressRequest.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSetSecondaryAddressRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSetSecondaryAddressRequest_Equals_Divine_Protobufs_Steam_CMsgSteamDatagramSetSecondaryAddressRequest_"></a> Equals\(CMsgSteamDatagramSetSecondaryAddressRequest\)

```csharp
public bool Equals(CMsgSteamDatagramSetSecondaryAddressRequest other)
```

#### Parameters

`other` [CMsgSteamDatagramSetSecondaryAddressRequest](Divine.Protobufs.Steam.CMsgSteamDatagramSetSecondaryAddressRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSetSecondaryAddressRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSetSecondaryAddressRequest_MergeFrom_Divine_Protobufs_Steam_CMsgSteamDatagramSetSecondaryAddressRequest_"></a> MergeFrom\(CMsgSteamDatagramSetSecondaryAddressRequest\)

```csharp
public void MergeFrom(CMsgSteamDatagramSetSecondaryAddressRequest other)
```

#### Parameters

`other` [CMsgSteamDatagramSetSecondaryAddressRequest](Divine.Protobufs.Steam.CMsgSteamDatagramSetSecondaryAddressRequest.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSetSecondaryAddressRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSetSecondaryAddressRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSetSecondaryAddressRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

