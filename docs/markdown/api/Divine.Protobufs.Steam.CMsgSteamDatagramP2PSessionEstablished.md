# <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionEstablished"></a> Class CMsgSteamDatagramP2PSessionEstablished

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamDatagramP2PSessionEstablished : IMessage<CMsgSteamDatagramP2PSessionEstablished>, IEquatable<CMsgSteamDatagramP2PSessionEstablished>, IDeepCloneable<CMsgSteamDatagramP2PSessionEstablished>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamDatagramP2PSessionEstablished](Divine.Protobufs.Steam.CMsgSteamDatagramP2PSessionEstablished.md)

#### Implements

IMessage<CMsgSteamDatagramP2PSessionEstablished\>, 
[IEquatable<CMsgSteamDatagramP2PSessionEstablished\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamDatagramP2PSessionEstablished\>, 
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
[EnumerableExtensions.In<CMsgSteamDatagramP2PSessionEstablished\>\(CMsgSteamDatagramP2PSessionEstablished, params CMsgSteamDatagramP2PSessionEstablished\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionEstablished__ctor"></a> CMsgSteamDatagramP2PSessionEstablished\(\)

```csharp
public CMsgSteamDatagramP2PSessionEstablished()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionEstablished__ctor_Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionEstablished_"></a> CMsgSteamDatagramP2PSessionEstablished\(CMsgSteamDatagramP2PSessionEstablished\)

```csharp
public CMsgSteamDatagramP2PSessionEstablished(CMsgSteamDatagramP2PSessionEstablished other)
```

#### Parameters

`other` [CMsgSteamDatagramP2PSessionEstablished](Divine.Protobufs.Steam.CMsgSteamDatagramP2PSessionEstablished.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionEstablished_ConnectionIdFieldNumber"></a> ConnectionIdFieldNumber

```csharp
public const int ConnectionIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionEstablished_RelayRoutingTokenFieldNumber"></a> RelayRoutingTokenFieldNumber

```csharp
public const int RelayRoutingTokenFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionEstablished_SecondsUntilShutdownFieldNumber"></a> SecondsUntilShutdownFieldNumber

```csharp
public const int SecondsUntilShutdownFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionEstablished_SeqNumR2CFieldNumber"></a> SeqNumR2CFieldNumber

```csharp
public const int SeqNumR2CFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionEstablished_ConnectionId"></a> ConnectionId

```csharp
public uint ConnectionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionEstablished_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionEstablished_HasConnectionId"></a> HasConnectionId

```csharp
public bool HasConnectionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionEstablished_HasRelayRoutingToken"></a> HasRelayRoutingToken

```csharp
public bool HasRelayRoutingToken { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionEstablished_HasSecondsUntilShutdown"></a> HasSecondsUntilShutdown

```csharp
public bool HasSecondsUntilShutdown { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionEstablished_HasSeqNumR2C"></a> HasSeqNumR2C

```csharp
public bool HasSeqNumR2C { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionEstablished_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamDatagramP2PSessionEstablished> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamDatagramP2PSessionEstablished](Divine.Protobufs.Steam.CMsgSteamDatagramP2PSessionEstablished.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionEstablished_RelayRoutingToken"></a> RelayRoutingToken

```csharp
public ByteString RelayRoutingToken { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionEstablished_SecondsUntilShutdown"></a> SecondsUntilShutdown

```csharp
public uint SecondsUntilShutdown { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionEstablished_SeqNumR2C"></a> SeqNumR2C

```csharp
public uint SeqNumR2C { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionEstablished_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionEstablished_ClearConnectionId"></a> ClearConnectionId\(\)

```csharp
public void ClearConnectionId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionEstablished_ClearRelayRoutingToken"></a> ClearRelayRoutingToken\(\)

```csharp
public void ClearRelayRoutingToken()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionEstablished_ClearSecondsUntilShutdown"></a> ClearSecondsUntilShutdown\(\)

```csharp
public void ClearSecondsUntilShutdown()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionEstablished_ClearSeqNumR2C"></a> ClearSeqNumR2C\(\)

```csharp
public void ClearSeqNumR2C()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionEstablished_Clone"></a> Clone\(\)

```csharp
public CMsgSteamDatagramP2PSessionEstablished Clone()
```

#### Returns

 [CMsgSteamDatagramP2PSessionEstablished](Divine.Protobufs.Steam.CMsgSteamDatagramP2PSessionEstablished.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionEstablished_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionEstablished_Equals_Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionEstablished_"></a> Equals\(CMsgSteamDatagramP2PSessionEstablished\)

```csharp
public bool Equals(CMsgSteamDatagramP2PSessionEstablished other)
```

#### Parameters

`other` [CMsgSteamDatagramP2PSessionEstablished](Divine.Protobufs.Steam.CMsgSteamDatagramP2PSessionEstablished.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionEstablished_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionEstablished_MergeFrom_Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionEstablished_"></a> MergeFrom\(CMsgSteamDatagramP2PSessionEstablished\)

```csharp
public void MergeFrom(CMsgSteamDatagramP2PSessionEstablished other)
```

#### Parameters

`other` [CMsgSteamDatagramP2PSessionEstablished](Divine.Protobufs.Steam.CMsgSteamDatagramP2PSessionEstablished.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionEstablished_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionEstablished_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionEstablished_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

