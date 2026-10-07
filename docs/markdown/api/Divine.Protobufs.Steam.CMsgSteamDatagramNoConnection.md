# <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection"></a> Class CMsgSteamDatagramNoConnection

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamDatagramNoConnection : IMessage<CMsgSteamDatagramNoConnection>, IEquatable<CMsgSteamDatagramNoConnection>, IDeepCloneable<CMsgSteamDatagramNoConnection>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamDatagramNoConnection](Divine.Protobufs.Steam.CMsgSteamDatagramNoConnection.md)

#### Implements

IMessage<CMsgSteamDatagramNoConnection\>, 
[IEquatable<CMsgSteamDatagramNoConnection\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamDatagramNoConnection\>, 
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
[EnumerableExtensions.In<CMsgSteamDatagramNoConnection\>\(CMsgSteamDatagramNoConnection, params CMsgSteamDatagramNoConnection\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection__ctor"></a> CMsgSteamDatagramNoConnection\(\)

```csharp
public CMsgSteamDatagramNoConnection()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection__ctor_Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_"></a> CMsgSteamDatagramNoConnection\(CMsgSteamDatagramNoConnection\)

```csharp
public CMsgSteamDatagramNoConnection(CMsgSteamDatagramNoConnection other)
```

#### Parameters

`other` [CMsgSteamDatagramNoConnection](Divine.Protobufs.Steam.CMsgSteamDatagramNoConnection.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_DummyPadFieldNumber"></a> DummyPadFieldNumber

```csharp
public const int DummyPadFieldNumber = 1023
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_EndToEndFieldNumber"></a> EndToEndFieldNumber

```csharp
public const int EndToEndFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_FromConnectionIdFieldNumber"></a> FromConnectionIdFieldNumber

```csharp
public const int FromConnectionIdFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_FromIdentityStringFieldNumber"></a> FromIdentityStringFieldNumber

```csharp
public const int FromIdentityStringFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_FromRelaySessionIdFieldNumber"></a> FromRelaySessionIdFieldNumber

```csharp
public const int FromRelaySessionIdFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_LegacyFromSteamIdFieldNumber"></a> LegacyFromSteamIdFieldNumber

```csharp
public const int LegacyFromSteamIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_LegacyGameserverRelaySessionIdFieldNumber"></a> LegacyGameserverRelaySessionIdFieldNumber

```csharp
public const int LegacyGameserverRelaySessionIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_NotPrimarySessionFieldNumber"></a> NotPrimarySessionFieldNumber

```csharp
public const int NotPrimarySessionFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_NotPrimaryTransportFieldNumber"></a> NotPrimaryTransportFieldNumber

```csharp
public const int NotPrimaryTransportFieldNumber = 15
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_P2PRoutingSummaryFieldNumber"></a> P2PRoutingSummaryFieldNumber

```csharp
public const int P2PRoutingSummaryFieldNumber = 16
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_QualityE2EFieldNumber"></a> QualityE2EFieldNumber

```csharp
public const int QualityE2EFieldNumber = 14
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_QualityRelayFieldNumber"></a> QualityRelayFieldNumber

```csharp
public const int QualityRelayFieldNumber = 13
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_RelayOverrideActiveFieldNumber"></a> RelayOverrideActiveFieldNumber

```csharp
public const int RelayOverrideActiveFieldNumber = 17
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_RoutingSecretFieldNumber"></a> RoutingSecretFieldNumber

```csharp
public const int RoutingSecretFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_ToConnectionIdFieldNumber"></a> ToConnectionIdFieldNumber

```csharp
public const int ToConnectionIdFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_ToRelaySessionIdFieldNumber"></a> ToRelaySessionIdFieldNumber

```csharp
public const int ToRelaySessionIdFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_DummyPad"></a> DummyPad

```csharp
public uint DummyPad { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_EndToEnd"></a> EndToEnd

```csharp
public bool EndToEnd { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_FromConnectionId"></a> FromConnectionId

```csharp
public uint FromConnectionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_FromIdentityString"></a> FromIdentityString

```csharp
public string FromIdentityString { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_FromRelaySessionId"></a> FromRelaySessionId

```csharp
public uint FromRelaySessionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_HasDummyPad"></a> HasDummyPad

```csharp
public bool HasDummyPad { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_HasEndToEnd"></a> HasEndToEnd

```csharp
public bool HasEndToEnd { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_HasFromConnectionId"></a> HasFromConnectionId

```csharp
public bool HasFromConnectionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_HasFromIdentityString"></a> HasFromIdentityString

```csharp
public bool HasFromIdentityString { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_HasFromRelaySessionId"></a> HasFromRelaySessionId

```csharp
public bool HasFromRelaySessionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_HasLegacyFromSteamId"></a> HasLegacyFromSteamId

```csharp
public bool HasLegacyFromSteamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_HasLegacyGameserverRelaySessionId"></a> HasLegacyGameserverRelaySessionId

```csharp
public bool HasLegacyGameserverRelaySessionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_HasNotPrimarySession"></a> HasNotPrimarySession

```csharp
public bool HasNotPrimarySession { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_HasNotPrimaryTransport"></a> HasNotPrimaryTransport

```csharp
public bool HasNotPrimaryTransport { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_HasRelayOverrideActive"></a> HasRelayOverrideActive

```csharp
public bool HasRelayOverrideActive { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_HasRoutingSecret"></a> HasRoutingSecret

```csharp
public bool HasRoutingSecret { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_HasToConnectionId"></a> HasToConnectionId

```csharp
public bool HasToConnectionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_HasToRelaySessionId"></a> HasToRelaySessionId

```csharp
public bool HasToRelaySessionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_LegacyFromSteamId"></a> LegacyFromSteamId

```csharp
public ulong LegacyFromSteamId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_LegacyGameserverRelaySessionId"></a> LegacyGameserverRelaySessionId

```csharp
public uint LegacyGameserverRelaySessionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_NotPrimarySession"></a> NotPrimarySession

```csharp
public bool NotPrimarySession { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_NotPrimaryTransport"></a> NotPrimaryTransport

```csharp
public bool NotPrimaryTransport { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_P2PRoutingSummary"></a> P2PRoutingSummary

```csharp
public CMsgSteamDatagramP2PRoutingSummary P2PRoutingSummary { get; set; }
```

#### Property Value

 [CMsgSteamDatagramP2PRoutingSummary](Divine.Protobufs.Steam.CMsgSteamDatagramP2PRoutingSummary.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamDatagramNoConnection> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamDatagramNoConnection](Divine.Protobufs.Steam.CMsgSteamDatagramNoConnection.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_QualityE2E"></a> QualityE2E

```csharp
public CMsgSteamDatagramConnectionQuality QualityE2E { get; set; }
```

#### Property Value

 [CMsgSteamDatagramConnectionQuality](Divine.Protobufs.Steam.CMsgSteamDatagramConnectionQuality.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_QualityRelay"></a> QualityRelay

```csharp
public CMsgSteamDatagramConnectionQuality QualityRelay { get; set; }
```

#### Property Value

 [CMsgSteamDatagramConnectionQuality](Divine.Protobufs.Steam.CMsgSteamDatagramConnectionQuality.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_RelayOverrideActive"></a> RelayOverrideActive

```csharp
public bool RelayOverrideActive { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_RoutingSecret"></a> RoutingSecret

```csharp
public ulong RoutingSecret { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_ToConnectionId"></a> ToConnectionId

```csharp
public uint ToConnectionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_ToRelaySessionId"></a> ToRelaySessionId

```csharp
public uint ToRelaySessionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_ClearDummyPad"></a> ClearDummyPad\(\)

```csharp
public void ClearDummyPad()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_ClearEndToEnd"></a> ClearEndToEnd\(\)

```csharp
public void ClearEndToEnd()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_ClearFromConnectionId"></a> ClearFromConnectionId\(\)

```csharp
public void ClearFromConnectionId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_ClearFromIdentityString"></a> ClearFromIdentityString\(\)

```csharp
public void ClearFromIdentityString()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_ClearFromRelaySessionId"></a> ClearFromRelaySessionId\(\)

```csharp
public void ClearFromRelaySessionId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_ClearLegacyFromSteamId"></a> ClearLegacyFromSteamId\(\)

```csharp
public void ClearLegacyFromSteamId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_ClearLegacyGameserverRelaySessionId"></a> ClearLegacyGameserverRelaySessionId\(\)

```csharp
public void ClearLegacyGameserverRelaySessionId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_ClearNotPrimarySession"></a> ClearNotPrimarySession\(\)

```csharp
public void ClearNotPrimarySession()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_ClearNotPrimaryTransport"></a> ClearNotPrimaryTransport\(\)

```csharp
public void ClearNotPrimaryTransport()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_ClearRelayOverrideActive"></a> ClearRelayOverrideActive\(\)

```csharp
public void ClearRelayOverrideActive()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_ClearRoutingSecret"></a> ClearRoutingSecret\(\)

```csharp
public void ClearRoutingSecret()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_ClearToConnectionId"></a> ClearToConnectionId\(\)

```csharp
public void ClearToConnectionId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_ClearToRelaySessionId"></a> ClearToRelaySessionId\(\)

```csharp
public void ClearToRelaySessionId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_Clone"></a> Clone\(\)

```csharp
public CMsgSteamDatagramNoConnection Clone()
```

#### Returns

 [CMsgSteamDatagramNoConnection](Divine.Protobufs.Steam.CMsgSteamDatagramNoConnection.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_Equals_Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_"></a> Equals\(CMsgSteamDatagramNoConnection\)

```csharp
public bool Equals(CMsgSteamDatagramNoConnection other)
```

#### Parameters

`other` [CMsgSteamDatagramNoConnection](Divine.Protobufs.Steam.CMsgSteamDatagramNoConnection.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_MergeFrom_Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_"></a> MergeFrom\(CMsgSteamDatagramNoConnection\)

```csharp
public void MergeFrom(CMsgSteamDatagramNoConnection other)
```

#### Parameters

`other` [CMsgSteamDatagramNoConnection](Divine.Protobufs.Steam.CMsgSteamDatagramNoConnection.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoConnection_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

