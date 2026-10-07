# <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed"></a> Class CMsgSteamDatagramConnectionClosed

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamDatagramConnectionClosed : IMessage<CMsgSteamDatagramConnectionClosed>, IEquatable<CMsgSteamDatagramConnectionClosed>, IDeepCloneable<CMsgSteamDatagramConnectionClosed>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamDatagramConnectionClosed](Divine.Protobufs.Steam.CMsgSteamDatagramConnectionClosed.md)

#### Implements

IMessage<CMsgSteamDatagramConnectionClosed\>, 
[IEquatable<CMsgSteamDatagramConnectionClosed\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamDatagramConnectionClosed\>, 
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
[EnumerableExtensions.In<CMsgSteamDatagramConnectionClosed\>\(CMsgSteamDatagramConnectionClosed, params CMsgSteamDatagramConnectionClosed\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed__ctor"></a> CMsgSteamDatagramConnectionClosed\(\)

```csharp
public CMsgSteamDatagramConnectionClosed()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed__ctor_Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_"></a> CMsgSteamDatagramConnectionClosed\(CMsgSteamDatagramConnectionClosed\)

```csharp
public CMsgSteamDatagramConnectionClosed(CMsgSteamDatagramConnectionClosed other)
```

#### Parameters

`other` [CMsgSteamDatagramConnectionClosed](Divine.Protobufs.Steam.CMsgSteamDatagramConnectionClosed.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_DebugFieldNumber"></a> DebugFieldNumber

```csharp
public const int DebugFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_ForwardTargetRelayRoutingTokenFieldNumber"></a> ForwardTargetRelayRoutingTokenFieldNumber

```csharp
public const int ForwardTargetRelayRoutingTokenFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_ForwardTargetRevisionFieldNumber"></a> ForwardTargetRevisionFieldNumber

```csharp
public const int ForwardTargetRevisionFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_FromConnectionIdFieldNumber"></a> FromConnectionIdFieldNumber

```csharp
public const int FromConnectionIdFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_FromIdentityStringFieldNumber"></a> FromIdentityStringFieldNumber

```csharp
public const int FromIdentityStringFieldNumber = 15
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_FromRelaySessionIdFieldNumber"></a> FromRelaySessionIdFieldNumber

```csharp
public const int FromRelaySessionIdFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_LegacyFromIdentityBinaryFieldNumber"></a> LegacyFromIdentityBinaryFieldNumber

```csharp
public const int LegacyFromIdentityBinaryFieldNumber = 13
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_LegacyFromSteamIdFieldNumber"></a> LegacyFromSteamIdFieldNumber

```csharp
public const int LegacyFromSteamIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_LegacyGameserverRelaySessionIdFieldNumber"></a> LegacyGameserverRelaySessionIdFieldNumber

```csharp
public const int LegacyGameserverRelaySessionIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_NotPrimarySessionFieldNumber"></a> NotPrimarySessionFieldNumber

```csharp
public const int NotPrimarySessionFieldNumber = 16
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_NotPrimaryTransportFieldNumber"></a> NotPrimaryTransportFieldNumber

```csharp
public const int NotPrimaryTransportFieldNumber = 19
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_P2PRoutingSummaryFieldNumber"></a> P2PRoutingSummaryFieldNumber

```csharp
public const int P2PRoutingSummaryFieldNumber = 21
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_QualityE2EFieldNumber"></a> QualityE2EFieldNumber

```csharp
public const int QualityE2EFieldNumber = 18
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_QualityRelayFieldNumber"></a> QualityRelayFieldNumber

```csharp
public const int QualityRelayFieldNumber = 17
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_ReasonCodeFieldNumber"></a> ReasonCodeFieldNumber

```csharp
public const int ReasonCodeFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_RelayModeFieldNumber"></a> RelayModeFieldNumber

```csharp
public const int RelayModeFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_RelayOverrideActiveFieldNumber"></a> RelayOverrideActiveFieldNumber

```csharp
public const int RelayOverrideActiveFieldNumber = 22
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_RoutingSecretFieldNumber"></a> RoutingSecretFieldNumber

```csharp
public const int RoutingSecretFieldNumber = 14
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_ToConnectionIdFieldNumber"></a> ToConnectionIdFieldNumber

```csharp
public const int ToConnectionIdFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_ToRelaySessionIdFieldNumber"></a> ToRelaySessionIdFieldNumber

```csharp
public const int ToRelaySessionIdFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_Debug"></a> Debug

```csharp
public string Debug { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_ForwardTargetRelayRoutingToken"></a> ForwardTargetRelayRoutingToken

```csharp
public ByteString ForwardTargetRelayRoutingToken { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_ForwardTargetRevision"></a> ForwardTargetRevision

```csharp
public uint ForwardTargetRevision { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_FromConnectionId"></a> FromConnectionId

```csharp
public uint FromConnectionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_FromIdentityString"></a> FromIdentityString

```csharp
public string FromIdentityString { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_FromRelaySessionId"></a> FromRelaySessionId

```csharp
public uint FromRelaySessionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_HasDebug"></a> HasDebug

```csharp
public bool HasDebug { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_HasForwardTargetRelayRoutingToken"></a> HasForwardTargetRelayRoutingToken

```csharp
public bool HasForwardTargetRelayRoutingToken { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_HasForwardTargetRevision"></a> HasForwardTargetRevision

```csharp
public bool HasForwardTargetRevision { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_HasFromConnectionId"></a> HasFromConnectionId

```csharp
public bool HasFromConnectionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_HasFromIdentityString"></a> HasFromIdentityString

```csharp
public bool HasFromIdentityString { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_HasFromRelaySessionId"></a> HasFromRelaySessionId

```csharp
public bool HasFromRelaySessionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_HasLegacyFromSteamId"></a> HasLegacyFromSteamId

```csharp
public bool HasLegacyFromSteamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_HasLegacyGameserverRelaySessionId"></a> HasLegacyGameserverRelaySessionId

```csharp
public bool HasLegacyGameserverRelaySessionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_HasNotPrimarySession"></a> HasNotPrimarySession

```csharp
public bool HasNotPrimarySession { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_HasNotPrimaryTransport"></a> HasNotPrimaryTransport

```csharp
public bool HasNotPrimaryTransport { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_HasReasonCode"></a> HasReasonCode

```csharp
public bool HasReasonCode { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_HasRelayMode"></a> HasRelayMode

```csharp
public bool HasRelayMode { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_HasRelayOverrideActive"></a> HasRelayOverrideActive

```csharp
public bool HasRelayOverrideActive { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_HasRoutingSecret"></a> HasRoutingSecret

```csharp
public bool HasRoutingSecret { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_HasToConnectionId"></a> HasToConnectionId

```csharp
public bool HasToConnectionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_HasToRelaySessionId"></a> HasToRelaySessionId

```csharp
public bool HasToRelaySessionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_LegacyFromIdentityBinary"></a> LegacyFromIdentityBinary

```csharp
public CMsgSteamNetworkingIdentityLegacyBinary LegacyFromIdentityBinary { get; set; }
```

#### Property Value

 [CMsgSteamNetworkingIdentityLegacyBinary](Divine.Protobufs.Steam.CMsgSteamNetworkingIdentityLegacyBinary.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_LegacyFromSteamId"></a> LegacyFromSteamId

```csharp
public ulong LegacyFromSteamId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_LegacyGameserverRelaySessionId"></a> LegacyGameserverRelaySessionId

```csharp
public uint LegacyGameserverRelaySessionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_NotPrimarySession"></a> NotPrimarySession

```csharp
public bool NotPrimarySession { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_NotPrimaryTransport"></a> NotPrimaryTransport

```csharp
public bool NotPrimaryTransport { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_P2PRoutingSummary"></a> P2PRoutingSummary

```csharp
public CMsgSteamDatagramP2PRoutingSummary P2PRoutingSummary { get; set; }
```

#### Property Value

 [CMsgSteamDatagramP2PRoutingSummary](Divine.Protobufs.Steam.CMsgSteamDatagramP2PRoutingSummary.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamDatagramConnectionClosed> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamDatagramConnectionClosed](Divine.Protobufs.Steam.CMsgSteamDatagramConnectionClosed.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_QualityE2E"></a> QualityE2E

```csharp
public CMsgSteamDatagramConnectionQuality QualityE2E { get; set; }
```

#### Property Value

 [CMsgSteamDatagramConnectionQuality](Divine.Protobufs.Steam.CMsgSteamDatagramConnectionQuality.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_QualityRelay"></a> QualityRelay

```csharp
public CMsgSteamDatagramConnectionQuality QualityRelay { get; set; }
```

#### Property Value

 [CMsgSteamDatagramConnectionQuality](Divine.Protobufs.Steam.CMsgSteamDatagramConnectionQuality.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_ReasonCode"></a> ReasonCode

```csharp
public uint ReasonCode { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_RelayMode"></a> RelayMode

```csharp
public CMsgSteamDatagramConnectionClosed.Types.ERelayMode RelayMode { get; set; }
```

#### Property Value

 [CMsgSteamDatagramConnectionClosed](Divine.Protobufs.Steam.CMsgSteamDatagramConnectionClosed.md).[Types](Divine.Protobufs.Steam.CMsgSteamDatagramConnectionClosed.Types.md).[ERelayMode](Divine.Protobufs.Steam.CMsgSteamDatagramConnectionClosed.Types.ERelayMode.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_RelayOverrideActive"></a> RelayOverrideActive

```csharp
public bool RelayOverrideActive { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_RoutingSecret"></a> RoutingSecret

```csharp
public ulong RoutingSecret { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_ToConnectionId"></a> ToConnectionId

```csharp
public uint ToConnectionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_ToRelaySessionId"></a> ToRelaySessionId

```csharp
public uint ToRelaySessionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_ClearDebug"></a> ClearDebug\(\)

```csharp
public void ClearDebug()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_ClearForwardTargetRelayRoutingToken"></a> ClearForwardTargetRelayRoutingToken\(\)

```csharp
public void ClearForwardTargetRelayRoutingToken()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_ClearForwardTargetRevision"></a> ClearForwardTargetRevision\(\)

```csharp
public void ClearForwardTargetRevision()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_ClearFromConnectionId"></a> ClearFromConnectionId\(\)

```csharp
public void ClearFromConnectionId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_ClearFromIdentityString"></a> ClearFromIdentityString\(\)

```csharp
public void ClearFromIdentityString()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_ClearFromRelaySessionId"></a> ClearFromRelaySessionId\(\)

```csharp
public void ClearFromRelaySessionId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_ClearLegacyFromSteamId"></a> ClearLegacyFromSteamId\(\)

```csharp
public void ClearLegacyFromSteamId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_ClearLegacyGameserverRelaySessionId"></a> ClearLegacyGameserverRelaySessionId\(\)

```csharp
public void ClearLegacyGameserverRelaySessionId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_ClearNotPrimarySession"></a> ClearNotPrimarySession\(\)

```csharp
public void ClearNotPrimarySession()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_ClearNotPrimaryTransport"></a> ClearNotPrimaryTransport\(\)

```csharp
public void ClearNotPrimaryTransport()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_ClearReasonCode"></a> ClearReasonCode\(\)

```csharp
public void ClearReasonCode()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_ClearRelayMode"></a> ClearRelayMode\(\)

```csharp
public void ClearRelayMode()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_ClearRelayOverrideActive"></a> ClearRelayOverrideActive\(\)

```csharp
public void ClearRelayOverrideActive()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_ClearRoutingSecret"></a> ClearRoutingSecret\(\)

```csharp
public void ClearRoutingSecret()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_ClearToConnectionId"></a> ClearToConnectionId\(\)

```csharp
public void ClearToConnectionId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_ClearToRelaySessionId"></a> ClearToRelaySessionId\(\)

```csharp
public void ClearToRelaySessionId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_Clone"></a> Clone\(\)

```csharp
public CMsgSteamDatagramConnectionClosed Clone()
```

#### Returns

 [CMsgSteamDatagramConnectionClosed](Divine.Protobufs.Steam.CMsgSteamDatagramConnectionClosed.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_Equals_Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_"></a> Equals\(CMsgSteamDatagramConnectionClosed\)

```csharp
public bool Equals(CMsgSteamDatagramConnectionClosed other)
```

#### Parameters

`other` [CMsgSteamDatagramConnectionClosed](Divine.Protobufs.Steam.CMsgSteamDatagramConnectionClosed.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_MergeFrom_Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_"></a> MergeFrom\(CMsgSteamDatagramConnectionClosed\)

```csharp
public void MergeFrom(CMsgSteamDatagramConnectionClosed other)
```

#### Parameters

`other` [CMsgSteamDatagramConnectionClosed](Divine.Protobufs.Steam.CMsgSteamDatagramConnectionClosed.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramConnectionClosed_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

