# <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous"></a> Class CMsgSteamNetworkingP2PRendezvous

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamNetworkingP2PRendezvous : IMessage<CMsgSteamNetworkingP2PRendezvous>, IEquatable<CMsgSteamNetworkingP2PRendezvous>, IDeepCloneable<CMsgSteamNetworkingP2PRendezvous>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamNetworkingP2PRendezvous](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.md)

#### Implements

IMessage<CMsgSteamNetworkingP2PRendezvous\>, 
[IEquatable<CMsgSteamNetworkingP2PRendezvous\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamNetworkingP2PRendezvous\>, 
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
[EnumerableExtensions.In<CMsgSteamNetworkingP2PRendezvous\>\(CMsgSteamNetworkingP2PRendezvous, params CMsgSteamNetworkingP2PRendezvous\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous__ctor"></a> CMsgSteamNetworkingP2PRendezvous\(\)

```csharp
public CMsgSteamNetworkingP2PRendezvous()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous__ctor_Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_"></a> CMsgSteamNetworkingP2PRendezvous\(CMsgSteamNetworkingP2PRendezvous\)

```csharp
public CMsgSteamNetworkingP2PRendezvous(CMsgSteamNetworkingP2PRendezvous other)
```

#### Parameters

`other` [CMsgSteamNetworkingP2PRendezvous](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_AckPeerRoutesRevisionFieldNumber"></a> AckPeerRoutesRevisionFieldNumber

```csharp
public const int AckPeerRoutesRevisionFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_AckReliableMsgFieldNumber"></a> AckReliableMsgFieldNumber

```csharp
public const int AckReliableMsgFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_ApplicationMessagesFieldNumber"></a> ApplicationMessagesFieldNumber

```csharp
public const int ApplicationMessagesFieldNumber = 15
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_ConnectionClosedFieldNumber"></a> ConnectionClosedFieldNumber

```csharp
public const int ConnectionClosedFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_ConnectOkFieldNumber"></a> ConnectOkFieldNumber

```csharp
public const int ConnectOkFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_ConnectRequestFieldNumber"></a> ConnectRequestFieldNumber

```csharp
public const int ConnectRequestFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_FirstReliableMsgFieldNumber"></a> FirstReliableMsgFieldNumber

```csharp
public const int FirstReliableMsgFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_FromConnectionIdFieldNumber"></a> FromConnectionIdFieldNumber

```csharp
public const int FromConnectionIdFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_FromIdentityFieldNumber"></a> FromIdentityFieldNumber

```csharp
public const int FromIdentityFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_HostedServerTicketFieldNumber"></a> HostedServerTicketFieldNumber

```csharp
public const int HostedServerTicketFieldNumber = 14
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_IceEnabledFieldNumber"></a> IceEnabledFieldNumber

```csharp
public const int IceEnabledFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_ReliableMessagesFieldNumber"></a> ReliableMessagesFieldNumber

```csharp
public const int ReliableMessagesFieldNumber = 13
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_SdrRoutesFieldNumber"></a> SdrRoutesFieldNumber

```csharp
public const int SdrRoutesFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_ToConnectionIdFieldNumber"></a> ToConnectionIdFieldNumber

```csharp
public const int ToConnectionIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_ToIdentityFieldNumber"></a> ToIdentityFieldNumber

```csharp
public const int ToIdentityFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_AckPeerRoutesRevision"></a> AckPeerRoutesRevision

```csharp
public uint AckPeerRoutesRevision { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_AckReliableMsg"></a> AckReliableMsg

```csharp
public uint AckReliableMsg { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_ApplicationMessages"></a> ApplicationMessages

```csharp
public RepeatedField<CMsgSteamNetworkingP2PRendezvous.Types.ApplicationMessage> ApplicationMessages { get; }
```

#### Property Value

 RepeatedField<[CMsgSteamNetworkingP2PRendezvous](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.md).[Types](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.Types.md).[ApplicationMessage](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.Types.ApplicationMessage.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_ConnectionClosed"></a> ConnectionClosed

```csharp
public CMsgSteamNetworkingP2PRendezvous.Types.ConnectionClosed ConnectionClosed { get; set; }
```

#### Property Value

 [CMsgSteamNetworkingP2PRendezvous](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.md).[Types](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.Types.md).[ConnectionClosed](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.Types.ConnectionClosed.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_ConnectOk"></a> ConnectOk

```csharp
public CMsgSteamNetworkingP2PRendezvous.Types.ConnectOK ConnectOk { get; set; }
```

#### Property Value

 [CMsgSteamNetworkingP2PRendezvous](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.md).[Types](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.Types.md).[ConnectOK](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.Types.ConnectOK.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_ConnectRequest"></a> ConnectRequest

```csharp
public CMsgSteamNetworkingP2PRendezvous.Types.ConnectRequest ConnectRequest { get; set; }
```

#### Property Value

 [CMsgSteamNetworkingP2PRendezvous](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.md).[Types](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.Types.md).[ConnectRequest](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.Types.ConnectRequest.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_FirstReliableMsg"></a> FirstReliableMsg

```csharp
public uint FirstReliableMsg { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_FromConnectionId"></a> FromConnectionId

```csharp
public uint FromConnectionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_FromIdentity"></a> FromIdentity

```csharp
public string FromIdentity { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_HasAckPeerRoutesRevision"></a> HasAckPeerRoutesRevision

```csharp
public bool HasAckPeerRoutesRevision { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_HasAckReliableMsg"></a> HasAckReliableMsg

```csharp
public bool HasAckReliableMsg { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_HasFirstReliableMsg"></a> HasFirstReliableMsg

```csharp
public bool HasFirstReliableMsg { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_HasFromConnectionId"></a> HasFromConnectionId

```csharp
public bool HasFromConnectionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_HasFromIdentity"></a> HasFromIdentity

```csharp
public bool HasFromIdentity { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_HasHostedServerTicket"></a> HasHostedServerTicket

```csharp
public bool HasHostedServerTicket { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_HasIceEnabled"></a> HasIceEnabled

```csharp
public bool HasIceEnabled { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_HasSdrRoutes"></a> HasSdrRoutes

```csharp
public bool HasSdrRoutes { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_HasToConnectionId"></a> HasToConnectionId

```csharp
public bool HasToConnectionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_HasToIdentity"></a> HasToIdentity

```csharp
public bool HasToIdentity { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_HostedServerTicket"></a> HostedServerTicket

```csharp
public ByteString HostedServerTicket { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_IceEnabled"></a> IceEnabled

```csharp
public bool IceEnabled { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamNetworkingP2PRendezvous> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamNetworkingP2PRendezvous](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_ReliableMessages"></a> ReliableMessages

```csharp
public RepeatedField<CMsgSteamNetworkingP2PRendezvous.Types.ReliableMessage> ReliableMessages { get; }
```

#### Property Value

 RepeatedField<[CMsgSteamNetworkingP2PRendezvous](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.md).[Types](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.Types.md).[ReliableMessage](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.Types.ReliableMessage.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_SdrRoutes"></a> SdrRoutes

```csharp
public ByteString SdrRoutes { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_ToConnectionId"></a> ToConnectionId

```csharp
public uint ToConnectionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_ToIdentity"></a> ToIdentity

```csharp
public string ToIdentity { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_ClearAckPeerRoutesRevision"></a> ClearAckPeerRoutesRevision\(\)

```csharp
public void ClearAckPeerRoutesRevision()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_ClearAckReliableMsg"></a> ClearAckReliableMsg\(\)

```csharp
public void ClearAckReliableMsg()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_ClearFirstReliableMsg"></a> ClearFirstReliableMsg\(\)

```csharp
public void ClearFirstReliableMsg()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_ClearFromConnectionId"></a> ClearFromConnectionId\(\)

```csharp
public void ClearFromConnectionId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_ClearFromIdentity"></a> ClearFromIdentity\(\)

```csharp
public void ClearFromIdentity()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_ClearHostedServerTicket"></a> ClearHostedServerTicket\(\)

```csharp
public void ClearHostedServerTicket()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_ClearIceEnabled"></a> ClearIceEnabled\(\)

```csharp
public void ClearIceEnabled()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_ClearSdrRoutes"></a> ClearSdrRoutes\(\)

```csharp
public void ClearSdrRoutes()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_ClearToConnectionId"></a> ClearToConnectionId\(\)

```csharp
public void ClearToConnectionId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_ClearToIdentity"></a> ClearToIdentity\(\)

```csharp
public void ClearToIdentity()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Clone"></a> Clone\(\)

```csharp
public CMsgSteamNetworkingP2PRendezvous Clone()
```

#### Returns

 [CMsgSteamNetworkingP2PRendezvous](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_Equals_Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_"></a> Equals\(CMsgSteamNetworkingP2PRendezvous\)

```csharp
public bool Equals(CMsgSteamNetworkingP2PRendezvous other)
```

#### Parameters

`other` [CMsgSteamNetworkingP2PRendezvous](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_MergeFrom_Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_"></a> MergeFrom\(CMsgSteamNetworkingP2PRendezvous\)

```csharp
public void MergeFrom(CMsgSteamNetworkingP2PRendezvous other)
```

#### Parameters

`other` [CMsgSteamNetworkingP2PRendezvous](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PRendezvous.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingP2PRendezvous_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

