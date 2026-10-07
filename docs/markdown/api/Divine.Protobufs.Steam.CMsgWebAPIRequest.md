# <a id="Divine_Protobufs_Steam_CMsgWebAPIRequest"></a> Class CMsgWebAPIRequest

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgWebAPIRequest : IMessage<CMsgWebAPIRequest>, IEquatable<CMsgWebAPIRequest>, IDeepCloneable<CMsgWebAPIRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgWebAPIRequest](Divine.Protobufs.Steam.CMsgWebAPIRequest.md)

#### Implements

IMessage<CMsgWebAPIRequest\>, 
[IEquatable<CMsgWebAPIRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgWebAPIRequest\>, 
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
[EnumerableExtensions.In<CMsgWebAPIRequest\>\(CMsgWebAPIRequest, params CMsgWebAPIRequest\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgWebAPIRequest__ctor"></a> CMsgWebAPIRequest\(\)

```csharp
public CMsgWebAPIRequest()
```

### <a id="Divine_Protobufs_Steam_CMsgWebAPIRequest__ctor_Divine_Protobufs_Steam_CMsgWebAPIRequest_"></a> CMsgWebAPIRequest\(CMsgWebAPIRequest\)

```csharp
public CMsgWebAPIRequest(CMsgWebAPIRequest other)
```

#### Parameters

`other` [CMsgWebAPIRequest](Divine.Protobufs.Steam.CMsgWebAPIRequest.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgWebAPIRequest_ApiKeyFieldNumber"></a> ApiKeyFieldNumber

```csharp
public const int ApiKeyFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgWebAPIRequest_InterfaceNameFieldNumber"></a> InterfaceNameFieldNumber

```csharp
public const int InterfaceNameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgWebAPIRequest_MethodNameFieldNumber"></a> MethodNameFieldNumber

```csharp
public const int MethodNameFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgWebAPIRequest_RequestFieldNumber"></a> RequestFieldNumber

```csharp
public const int RequestFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgWebAPIRequest_RoutingAppIdFieldNumber"></a> RoutingAppIdFieldNumber

```csharp
public const int RoutingAppIdFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgWebAPIRequest_VersionFieldNumber"></a> VersionFieldNumber

```csharp
public const int VersionFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgWebAPIRequest_ApiKey"></a> ApiKey

```csharp
public CMsgWebAPIKey ApiKey { get; set; }
```

#### Property Value

 [CMsgWebAPIKey](Divine.Protobufs.Steam.CMsgWebAPIKey.md)

### <a id="Divine_Protobufs_Steam_CMsgWebAPIRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgWebAPIRequest_HasInterfaceName"></a> HasInterfaceName

```csharp
public bool HasInterfaceName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgWebAPIRequest_HasMethodName"></a> HasMethodName

```csharp
public bool HasMethodName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgWebAPIRequest_HasRoutingAppId"></a> HasRoutingAppId

```csharp
public bool HasRoutingAppId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgWebAPIRequest_HasVersion"></a> HasVersion

```csharp
public bool HasVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgWebAPIRequest_InterfaceName"></a> InterfaceName

```csharp
public string InterfaceName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgWebAPIRequest_MethodName"></a> MethodName

```csharp
public string MethodName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgWebAPIRequest_Parser"></a> Parser

```csharp
public static MessageParser<CMsgWebAPIRequest> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgWebAPIRequest](Divine.Protobufs.Steam.CMsgWebAPIRequest.md)\>

### <a id="Divine_Protobufs_Steam_CMsgWebAPIRequest_Request"></a> Request

```csharp
public CMsgHttpRequest Request { get; set; }
```

#### Property Value

 [CMsgHttpRequest](Divine.Protobufs.Steam.CMsgHttpRequest.md)

### <a id="Divine_Protobufs_Steam_CMsgWebAPIRequest_RoutingAppId"></a> RoutingAppId

```csharp
public uint RoutingAppId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgWebAPIRequest_Version"></a> Version

```csharp
public uint Version { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgWebAPIRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgWebAPIRequest_ClearInterfaceName"></a> ClearInterfaceName\(\)

```csharp
public void ClearInterfaceName()
```

### <a id="Divine_Protobufs_Steam_CMsgWebAPIRequest_ClearMethodName"></a> ClearMethodName\(\)

```csharp
public void ClearMethodName()
```

### <a id="Divine_Protobufs_Steam_CMsgWebAPIRequest_ClearRoutingAppId"></a> ClearRoutingAppId\(\)

```csharp
public void ClearRoutingAppId()
```

### <a id="Divine_Protobufs_Steam_CMsgWebAPIRequest_ClearVersion"></a> ClearVersion\(\)

```csharp
public void ClearVersion()
```

### <a id="Divine_Protobufs_Steam_CMsgWebAPIRequest_Clone"></a> Clone\(\)

```csharp
public CMsgWebAPIRequest Clone()
```

#### Returns

 [CMsgWebAPIRequest](Divine.Protobufs.Steam.CMsgWebAPIRequest.md)

### <a id="Divine_Protobufs_Steam_CMsgWebAPIRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgWebAPIRequest_Equals_Divine_Protobufs_Steam_CMsgWebAPIRequest_"></a> Equals\(CMsgWebAPIRequest\)

```csharp
public bool Equals(CMsgWebAPIRequest other)
```

#### Parameters

`other` [CMsgWebAPIRequest](Divine.Protobufs.Steam.CMsgWebAPIRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgWebAPIRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgWebAPIRequest_MergeFrom_Divine_Protobufs_Steam_CMsgWebAPIRequest_"></a> MergeFrom\(CMsgWebAPIRequest\)

```csharp
public void MergeFrom(CMsgWebAPIRequest other)
```

#### Parameters

`other` [CMsgWebAPIRequest](Divine.Protobufs.Steam.CMsgWebAPIRequest.md)

### <a id="Divine_Protobufs_Steam_CMsgWebAPIRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgWebAPIRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgWebAPIRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

