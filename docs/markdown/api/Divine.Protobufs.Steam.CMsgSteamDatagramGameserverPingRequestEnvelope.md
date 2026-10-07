# <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestEnvelope"></a> Class CMsgSteamDatagramGameserverPingRequestEnvelope

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamDatagramGameserverPingRequestEnvelope : IMessage<CMsgSteamDatagramGameserverPingRequestEnvelope>, IEquatable<CMsgSteamDatagramGameserverPingRequestEnvelope>, IDeepCloneable<CMsgSteamDatagramGameserverPingRequestEnvelope>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamDatagramGameserverPingRequestEnvelope](Divine.Protobufs.Steam.CMsgSteamDatagramGameserverPingRequestEnvelope.md)

#### Implements

IMessage<CMsgSteamDatagramGameserverPingRequestEnvelope\>, 
[IEquatable<CMsgSteamDatagramGameserverPingRequestEnvelope\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamDatagramGameserverPingRequestEnvelope\>, 
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
[EnumerableExtensions.In<CMsgSteamDatagramGameserverPingRequestEnvelope\>\(CMsgSteamDatagramGameserverPingRequestEnvelope, params CMsgSteamDatagramGameserverPingRequestEnvelope\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestEnvelope__ctor"></a> CMsgSteamDatagramGameserverPingRequestEnvelope\(\)

```csharp
public CMsgSteamDatagramGameserverPingRequestEnvelope()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestEnvelope__ctor_Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestEnvelope_"></a> CMsgSteamDatagramGameserverPingRequestEnvelope\(CMsgSteamDatagramGameserverPingRequestEnvelope\)

```csharp
public CMsgSteamDatagramGameserverPingRequestEnvelope(CMsgSteamDatagramGameserverPingRequestEnvelope other)
```

#### Parameters

`other` [CMsgSteamDatagramGameserverPingRequestEnvelope](Divine.Protobufs.Steam.CMsgSteamDatagramGameserverPingRequestEnvelope.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestEnvelope_CertFieldNumber"></a> CertFieldNumber

```csharp
public const int CertFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestEnvelope_DummyPadFieldNumber"></a> DummyPadFieldNumber

```csharp
public const int DummyPadFieldNumber = 1023
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestEnvelope_LegacyChallengeFieldNumber"></a> LegacyChallengeFieldNumber

```csharp
public const int LegacyChallengeFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestEnvelope_LegacyRelayUnixTimeFieldNumber"></a> LegacyRelayUnixTimeFieldNumber

```csharp
public const int LegacyRelayUnixTimeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestEnvelope_LegacyRouterTimestampFieldNumber"></a> LegacyRouterTimestampFieldNumber

```csharp
public const int LegacyRouterTimestampFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestEnvelope_LegacyYourPublicIpFieldNumber"></a> LegacyYourPublicIpFieldNumber

```csharp
public const int LegacyYourPublicIpFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestEnvelope_LegacyYourPublicPortFieldNumber"></a> LegacyYourPublicPortFieldNumber

```csharp
public const int LegacyYourPublicPortFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestEnvelope_SignatureFieldNumber"></a> SignatureFieldNumber

```csharp
public const int SignatureFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestEnvelope_SignedDataFieldNumber"></a> SignedDataFieldNumber

```csharp
public const int SignedDataFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestEnvelope_Cert"></a> Cert

```csharp
public CMsgSteamDatagramCertificateSigned Cert { get; set; }
```

#### Property Value

 [CMsgSteamDatagramCertificateSigned](Divine.Protobufs.Steam.CMsgSteamDatagramCertificateSigned.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestEnvelope_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestEnvelope_DummyPad"></a> DummyPad

```csharp
public ByteString DummyPad { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestEnvelope_HasDummyPad"></a> HasDummyPad

```csharp
public bool HasDummyPad { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestEnvelope_HasLegacyChallenge"></a> HasLegacyChallenge

```csharp
public bool HasLegacyChallenge { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestEnvelope_HasLegacyRelayUnixTime"></a> HasLegacyRelayUnixTime

```csharp
public bool HasLegacyRelayUnixTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestEnvelope_HasLegacyRouterTimestamp"></a> HasLegacyRouterTimestamp

```csharp
public bool HasLegacyRouterTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestEnvelope_HasLegacyYourPublicIp"></a> HasLegacyYourPublicIp

```csharp
public bool HasLegacyYourPublicIp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestEnvelope_HasLegacyYourPublicPort"></a> HasLegacyYourPublicPort

```csharp
public bool HasLegacyYourPublicPort { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestEnvelope_HasSignature"></a> HasSignature

```csharp
public bool HasSignature { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestEnvelope_HasSignedData"></a> HasSignedData

```csharp
public bool HasSignedData { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestEnvelope_LegacyChallenge"></a> LegacyChallenge

```csharp
public ulong LegacyChallenge { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestEnvelope_LegacyRelayUnixTime"></a> LegacyRelayUnixTime

```csharp
public uint LegacyRelayUnixTime { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestEnvelope_LegacyRouterTimestamp"></a> LegacyRouterTimestamp

```csharp
public uint LegacyRouterTimestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestEnvelope_LegacyYourPublicIp"></a> LegacyYourPublicIp

```csharp
public uint LegacyYourPublicIp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestEnvelope_LegacyYourPublicPort"></a> LegacyYourPublicPort

```csharp
public uint LegacyYourPublicPort { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestEnvelope_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamDatagramGameserverPingRequestEnvelope> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamDatagramGameserverPingRequestEnvelope](Divine.Protobufs.Steam.CMsgSteamDatagramGameserverPingRequestEnvelope.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestEnvelope_Signature"></a> Signature

```csharp
public ByteString Signature { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestEnvelope_SignedData"></a> SignedData

```csharp
public ByteString SignedData { get; set; }
```

#### Property Value

 ByteString

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestEnvelope_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestEnvelope_ClearDummyPad"></a> ClearDummyPad\(\)

```csharp
public void ClearDummyPad()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestEnvelope_ClearLegacyChallenge"></a> ClearLegacyChallenge\(\)

```csharp
public void ClearLegacyChallenge()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestEnvelope_ClearLegacyRelayUnixTime"></a> ClearLegacyRelayUnixTime\(\)

```csharp
public void ClearLegacyRelayUnixTime()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestEnvelope_ClearLegacyRouterTimestamp"></a> ClearLegacyRouterTimestamp\(\)

```csharp
public void ClearLegacyRouterTimestamp()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestEnvelope_ClearLegacyYourPublicIp"></a> ClearLegacyYourPublicIp\(\)

```csharp
public void ClearLegacyYourPublicIp()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestEnvelope_ClearLegacyYourPublicPort"></a> ClearLegacyYourPublicPort\(\)

```csharp
public void ClearLegacyYourPublicPort()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestEnvelope_ClearSignature"></a> ClearSignature\(\)

```csharp
public void ClearSignature()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestEnvelope_ClearSignedData"></a> ClearSignedData\(\)

```csharp
public void ClearSignedData()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestEnvelope_Clone"></a> Clone\(\)

```csharp
public CMsgSteamDatagramGameserverPingRequestEnvelope Clone()
```

#### Returns

 [CMsgSteamDatagramGameserverPingRequestEnvelope](Divine.Protobufs.Steam.CMsgSteamDatagramGameserverPingRequestEnvelope.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestEnvelope_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestEnvelope_Equals_Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestEnvelope_"></a> Equals\(CMsgSteamDatagramGameserverPingRequestEnvelope\)

```csharp
public bool Equals(CMsgSteamDatagramGameserverPingRequestEnvelope other)
```

#### Parameters

`other` [CMsgSteamDatagramGameserverPingRequestEnvelope](Divine.Protobufs.Steam.CMsgSteamDatagramGameserverPingRequestEnvelope.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestEnvelope_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestEnvelope_MergeFrom_Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestEnvelope_"></a> MergeFrom\(CMsgSteamDatagramGameserverPingRequestEnvelope\)

```csharp
public void MergeFrom(CMsgSteamDatagramGameserverPingRequestEnvelope other)
```

#### Parameters

`other` [CMsgSteamDatagramGameserverPingRequestEnvelope](Divine.Protobufs.Steam.CMsgSteamDatagramGameserverPingRequestEnvelope.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestEnvelope_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestEnvelope_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingRequestEnvelope_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

