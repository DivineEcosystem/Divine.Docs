# <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCachedCredentialsForApp"></a> Class CMsgSteamDatagramCachedCredentialsForApp

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamDatagramCachedCredentialsForApp : IMessage<CMsgSteamDatagramCachedCredentialsForApp>, IEquatable<CMsgSteamDatagramCachedCredentialsForApp>, IDeepCloneable<CMsgSteamDatagramCachedCredentialsForApp>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamDatagramCachedCredentialsForApp](Divine.Protobufs.Steam.CMsgSteamDatagramCachedCredentialsForApp.md)

#### Implements

IMessage<CMsgSteamDatagramCachedCredentialsForApp\>, 
[IEquatable<CMsgSteamDatagramCachedCredentialsForApp\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamDatagramCachedCredentialsForApp\>, 
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
[EnumerableExtensions.In<CMsgSteamDatagramCachedCredentialsForApp\>\(CMsgSteamDatagramCachedCredentialsForApp, params CMsgSteamDatagramCachedCredentialsForApp\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCachedCredentialsForApp__ctor"></a> CMsgSteamDatagramCachedCredentialsForApp\(\)

```csharp
public CMsgSteamDatagramCachedCredentialsForApp()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCachedCredentialsForApp__ctor_Divine_Protobufs_Steam_CMsgSteamDatagramCachedCredentialsForApp_"></a> CMsgSteamDatagramCachedCredentialsForApp\(CMsgSteamDatagramCachedCredentialsForApp\)

```csharp
public CMsgSteamDatagramCachedCredentialsForApp(CMsgSteamDatagramCachedCredentialsForApp other)
```

#### Parameters

`other` [CMsgSteamDatagramCachedCredentialsForApp](Divine.Protobufs.Steam.CMsgSteamDatagramCachedCredentialsForApp.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCachedCredentialsForApp_CertFieldNumber"></a> CertFieldNumber

```csharp
public const int CertFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCachedCredentialsForApp_PrivateKeyFieldNumber"></a> PrivateKeyFieldNumber

```csharp
public const int PrivateKeyFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCachedCredentialsForApp_RelayTicketsFieldNumber"></a> RelayTicketsFieldNumber

```csharp
public const int RelayTicketsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCachedCredentialsForApp_Cert"></a> Cert

```csharp
public ByteString Cert { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCachedCredentialsForApp_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCachedCredentialsForApp_HasCert"></a> HasCert

```csharp
public bool HasCert { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCachedCredentialsForApp_HasPrivateKey"></a> HasPrivateKey

```csharp
public bool HasPrivateKey { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCachedCredentialsForApp_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamDatagramCachedCredentialsForApp> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamDatagramCachedCredentialsForApp](Divine.Protobufs.Steam.CMsgSteamDatagramCachedCredentialsForApp.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCachedCredentialsForApp_PrivateKey"></a> PrivateKey

```csharp
public ByteString PrivateKey { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCachedCredentialsForApp_RelayTickets"></a> RelayTickets

```csharp
public RepeatedField<ByteString> RelayTickets { get; }
```

#### Property Value

 RepeatedField<ByteString\>

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCachedCredentialsForApp_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCachedCredentialsForApp_ClearCert"></a> ClearCert\(\)

```csharp
public void ClearCert()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCachedCredentialsForApp_ClearPrivateKey"></a> ClearPrivateKey\(\)

```csharp
public void ClearPrivateKey()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCachedCredentialsForApp_Clone"></a> Clone\(\)

```csharp
public CMsgSteamDatagramCachedCredentialsForApp Clone()
```

#### Returns

 [CMsgSteamDatagramCachedCredentialsForApp](Divine.Protobufs.Steam.CMsgSteamDatagramCachedCredentialsForApp.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCachedCredentialsForApp_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCachedCredentialsForApp_Equals_Divine_Protobufs_Steam_CMsgSteamDatagramCachedCredentialsForApp_"></a> Equals\(CMsgSteamDatagramCachedCredentialsForApp\)

```csharp
public bool Equals(CMsgSteamDatagramCachedCredentialsForApp other)
```

#### Parameters

`other` [CMsgSteamDatagramCachedCredentialsForApp](Divine.Protobufs.Steam.CMsgSteamDatagramCachedCredentialsForApp.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCachedCredentialsForApp_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCachedCredentialsForApp_MergeFrom_Divine_Protobufs_Steam_CMsgSteamDatagramCachedCredentialsForApp_"></a> MergeFrom\(CMsgSteamDatagramCachedCredentialsForApp\)

```csharp
public void MergeFrom(CMsgSteamDatagramCachedCredentialsForApp other)
```

#### Parameters

`other` [CMsgSteamDatagramCachedCredentialsForApp](Divine.Protobufs.Steam.CMsgSteamDatagramCachedCredentialsForApp.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCachedCredentialsForApp_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCachedCredentialsForApp_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramCachedCredentialsForApp_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

