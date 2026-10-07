# <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectOK"></a> Class CMsgSteamDatagramConnectOK

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamDatagramConnectOK : IMessage<CMsgSteamDatagramConnectOK>, IEquatable<CMsgSteamDatagramConnectOK>, IDeepCloneable<CMsgSteamDatagramConnectOK>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamDatagramConnectOK](Divine.Protobufs.Steam.CMsgSteamDatagramConnectOK.md)

#### Implements

IMessage<CMsgSteamDatagramConnectOK\>, 
[IEquatable<CMsgSteamDatagramConnectOK\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamDatagramConnectOK\>, 
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
[EnumerableExtensions.In<CMsgSteamDatagramConnectOK\>\(CMsgSteamDatagramConnectOK, params CMsgSteamDatagramConnectOK\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectOK__ctor"></a> CMsgSteamDatagramConnectOK\(\)

```csharp
public CMsgSteamDatagramConnectOK()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectOK__ctor_Divine_Protobufs_Steam_CMsgSteamDatagramConnectOK_"></a> CMsgSteamDatagramConnectOK\(CMsgSteamDatagramConnectOK\)

```csharp
public CMsgSteamDatagramConnectOK(CMsgSteamDatagramConnectOK other)
```

#### Parameters

`other` [CMsgSteamDatagramConnectOK](Divine.Protobufs.Steam.CMsgSteamDatagramConnectOK.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectOK_CertFieldNumber"></a> CertFieldNumber

```csharp
public const int CertFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectOK_ClientConnectionIdFieldNumber"></a> ClientConnectionIdFieldNumber

```csharp
public const int ClientConnectionIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectOK_CryptFieldNumber"></a> CryptFieldNumber

```csharp
public const int CryptFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectOK_DelayTimeUsecFieldNumber"></a> DelayTimeUsecFieldNumber

```csharp
public const int DelayTimeUsecFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectOK_GameserverRelaySessionIdFieldNumber"></a> GameserverRelaySessionIdFieldNumber

```csharp
public const int GameserverRelaySessionIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectOK_ServerConnectionIdFieldNumber"></a> ServerConnectionIdFieldNumber

```csharp
public const int ServerConnectionIdFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectOK_YourTimestampFieldNumber"></a> YourTimestampFieldNumber

```csharp
public const int YourTimestampFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectOK_Cert"></a> Cert

```csharp
public CMsgSteamDatagramCertificateSigned Cert { get; set; }
```

#### Property Value

 [CMsgSteamDatagramCertificateSigned](Divine.Protobufs.Steam.CMsgSteamDatagramCertificateSigned.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectOK_ClientConnectionId"></a> ClientConnectionId

```csharp
public uint ClientConnectionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectOK_Crypt"></a> Crypt

```csharp
public CMsgSteamDatagramSessionCryptInfoSigned Crypt { get; set; }
```

#### Property Value

 [CMsgSteamDatagramSessionCryptInfoSigned](Divine.Protobufs.Steam.CMsgSteamDatagramSessionCryptInfoSigned.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectOK_DelayTimeUsec"></a> DelayTimeUsec

```csharp
public uint DelayTimeUsec { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectOK_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectOK_GameserverRelaySessionId"></a> GameserverRelaySessionId

```csharp
public uint GameserverRelaySessionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectOK_HasClientConnectionId"></a> HasClientConnectionId

```csharp
public bool HasClientConnectionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectOK_HasDelayTimeUsec"></a> HasDelayTimeUsec

```csharp
public bool HasDelayTimeUsec { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectOK_HasGameserverRelaySessionId"></a> HasGameserverRelaySessionId

```csharp
public bool HasGameserverRelaySessionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectOK_HasServerConnectionId"></a> HasServerConnectionId

```csharp
public bool HasServerConnectionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectOK_HasYourTimestamp"></a> HasYourTimestamp

```csharp
public bool HasYourTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectOK_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamDatagramConnectOK> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamDatagramConnectOK](Divine.Protobufs.Steam.CMsgSteamDatagramConnectOK.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectOK_ServerConnectionId"></a> ServerConnectionId

```csharp
public uint ServerConnectionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectOK_YourTimestamp"></a> YourTimestamp

```csharp
public ulong YourTimestamp { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectOK_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectOK_ClearClientConnectionId"></a> ClearClientConnectionId\(\)

```csharp
public void ClearClientConnectionId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectOK_ClearDelayTimeUsec"></a> ClearDelayTimeUsec\(\)

```csharp
public void ClearDelayTimeUsec()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectOK_ClearGameserverRelaySessionId"></a> ClearGameserverRelaySessionId\(\)

```csharp
public void ClearGameserverRelaySessionId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectOK_ClearServerConnectionId"></a> ClearServerConnectionId\(\)

```csharp
public void ClearServerConnectionId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectOK_ClearYourTimestamp"></a> ClearYourTimestamp\(\)

```csharp
public void ClearYourTimestamp()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectOK_Clone"></a> Clone\(\)

```csharp
public CMsgSteamDatagramConnectOK Clone()
```

#### Returns

 [CMsgSteamDatagramConnectOK](Divine.Protobufs.Steam.CMsgSteamDatagramConnectOK.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectOK_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectOK_Equals_Divine_Protobufs_Steam_CMsgSteamDatagramConnectOK_"></a> Equals\(CMsgSteamDatagramConnectOK\)

```csharp
public bool Equals(CMsgSteamDatagramConnectOK other)
```

#### Parameters

`other` [CMsgSteamDatagramConnectOK](Divine.Protobufs.Steam.CMsgSteamDatagramConnectOK.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectOK_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectOK_MergeFrom_Divine_Protobufs_Steam_CMsgSteamDatagramConnectOK_"></a> MergeFrom\(CMsgSteamDatagramConnectOK\)

```csharp
public void MergeFrom(CMsgSteamDatagramConnectOK other)
```

#### Parameters

`other` [CMsgSteamDatagramConnectOK](Divine.Protobufs.Steam.CMsgSteamDatagramConnectOK.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectOK_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectOK_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectOK_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

