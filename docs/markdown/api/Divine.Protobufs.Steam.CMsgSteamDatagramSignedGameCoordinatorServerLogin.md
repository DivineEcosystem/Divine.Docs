# <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedGameCoordinatorServerLogin"></a> Class CMsgSteamDatagramSignedGameCoordinatorServerLogin

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamDatagramSignedGameCoordinatorServerLogin : IMessage<CMsgSteamDatagramSignedGameCoordinatorServerLogin>, IEquatable<CMsgSteamDatagramSignedGameCoordinatorServerLogin>, IDeepCloneable<CMsgSteamDatagramSignedGameCoordinatorServerLogin>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamDatagramSignedGameCoordinatorServerLogin](Divine.Protobufs.Steam.CMsgSteamDatagramSignedGameCoordinatorServerLogin.md)

#### Implements

IMessage<CMsgSteamDatagramSignedGameCoordinatorServerLogin\>, 
[IEquatable<CMsgSteamDatagramSignedGameCoordinatorServerLogin\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamDatagramSignedGameCoordinatorServerLogin\>, 
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
[EnumerableExtensions.In<CMsgSteamDatagramSignedGameCoordinatorServerLogin\>\(CMsgSteamDatagramSignedGameCoordinatorServerLogin, params CMsgSteamDatagramSignedGameCoordinatorServerLogin\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedGameCoordinatorServerLogin__ctor"></a> CMsgSteamDatagramSignedGameCoordinatorServerLogin\(\)

```csharp
public CMsgSteamDatagramSignedGameCoordinatorServerLogin()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedGameCoordinatorServerLogin__ctor_Divine_Protobufs_Steam_CMsgSteamDatagramSignedGameCoordinatorServerLogin_"></a> CMsgSteamDatagramSignedGameCoordinatorServerLogin\(CMsgSteamDatagramSignedGameCoordinatorServerLogin\)

```csharp
public CMsgSteamDatagramSignedGameCoordinatorServerLogin(CMsgSteamDatagramSignedGameCoordinatorServerLogin other)
```

#### Parameters

`other` [CMsgSteamDatagramSignedGameCoordinatorServerLogin](Divine.Protobufs.Steam.CMsgSteamDatagramSignedGameCoordinatorServerLogin.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedGameCoordinatorServerLogin_CertFieldNumber"></a> CertFieldNumber

```csharp
public const int CertFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedGameCoordinatorServerLogin_LoginFieldNumber"></a> LoginFieldNumber

```csharp
public const int LoginFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedGameCoordinatorServerLogin_SignatureFieldNumber"></a> SignatureFieldNumber

```csharp
public const int SignatureFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedGameCoordinatorServerLogin_Cert"></a> Cert

```csharp
public CMsgSteamDatagramCertificateSigned Cert { get; set; }
```

#### Property Value

 [CMsgSteamDatagramCertificateSigned](Divine.Protobufs.Steam.CMsgSteamDatagramCertificateSigned.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedGameCoordinatorServerLogin_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedGameCoordinatorServerLogin_HasLogin"></a> HasLogin

```csharp
public bool HasLogin { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedGameCoordinatorServerLogin_HasSignature"></a> HasSignature

```csharp
public bool HasSignature { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedGameCoordinatorServerLogin_Login"></a> Login

```csharp
public ByteString Login { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedGameCoordinatorServerLogin_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamDatagramSignedGameCoordinatorServerLogin> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamDatagramSignedGameCoordinatorServerLogin](Divine.Protobufs.Steam.CMsgSteamDatagramSignedGameCoordinatorServerLogin.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedGameCoordinatorServerLogin_Signature"></a> Signature

```csharp
public ByteString Signature { get; set; }
```

#### Property Value

 ByteString

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedGameCoordinatorServerLogin_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedGameCoordinatorServerLogin_ClearLogin"></a> ClearLogin\(\)

```csharp
public void ClearLogin()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedGameCoordinatorServerLogin_ClearSignature"></a> ClearSignature\(\)

```csharp
public void ClearSignature()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedGameCoordinatorServerLogin_Clone"></a> Clone\(\)

```csharp
public CMsgSteamDatagramSignedGameCoordinatorServerLogin Clone()
```

#### Returns

 [CMsgSteamDatagramSignedGameCoordinatorServerLogin](Divine.Protobufs.Steam.CMsgSteamDatagramSignedGameCoordinatorServerLogin.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedGameCoordinatorServerLogin_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedGameCoordinatorServerLogin_Equals_Divine_Protobufs_Steam_CMsgSteamDatagramSignedGameCoordinatorServerLogin_"></a> Equals\(CMsgSteamDatagramSignedGameCoordinatorServerLogin\)

```csharp
public bool Equals(CMsgSteamDatagramSignedGameCoordinatorServerLogin other)
```

#### Parameters

`other` [CMsgSteamDatagramSignedGameCoordinatorServerLogin](Divine.Protobufs.Steam.CMsgSteamDatagramSignedGameCoordinatorServerLogin.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedGameCoordinatorServerLogin_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedGameCoordinatorServerLogin_MergeFrom_Divine_Protobufs_Steam_CMsgSteamDatagramSignedGameCoordinatorServerLogin_"></a> MergeFrom\(CMsgSteamDatagramSignedGameCoordinatorServerLogin\)

```csharp
public void MergeFrom(CMsgSteamDatagramSignedGameCoordinatorServerLogin other)
```

#### Parameters

`other` [CMsgSteamDatagramSignedGameCoordinatorServerLogin](Divine.Protobufs.Steam.CMsgSteamDatagramSignedGameCoordinatorServerLogin.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedGameCoordinatorServerLogin_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedGameCoordinatorServerLogin_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramSignedGameCoordinatorServerLogin_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

