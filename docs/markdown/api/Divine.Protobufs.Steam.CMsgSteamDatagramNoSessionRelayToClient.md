# <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToClient"></a> Class CMsgSteamDatagramNoSessionRelayToClient

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamDatagramNoSessionRelayToClient : IMessage<CMsgSteamDatagramNoSessionRelayToClient>, IEquatable<CMsgSteamDatagramNoSessionRelayToClient>, IDeepCloneable<CMsgSteamDatagramNoSessionRelayToClient>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamDatagramNoSessionRelayToClient](Divine.Protobufs.Steam.CMsgSteamDatagramNoSessionRelayToClient.md)

#### Implements

IMessage<CMsgSteamDatagramNoSessionRelayToClient\>, 
[IEquatable<CMsgSteamDatagramNoSessionRelayToClient\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamDatagramNoSessionRelayToClient\>, 
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
[EnumerableExtensions.In<CMsgSteamDatagramNoSessionRelayToClient\>\(CMsgSteamDatagramNoSessionRelayToClient, params CMsgSteamDatagramNoSessionRelayToClient\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToClient__ctor"></a> CMsgSteamDatagramNoSessionRelayToClient\(\)

```csharp
public CMsgSteamDatagramNoSessionRelayToClient()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToClient__ctor_Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToClient_"></a> CMsgSteamDatagramNoSessionRelayToClient\(CMsgSteamDatagramNoSessionRelayToClient\)

```csharp
public CMsgSteamDatagramNoSessionRelayToClient(CMsgSteamDatagramNoSessionRelayToClient other)
```

#### Parameters

`other` [CMsgSteamDatagramNoSessionRelayToClient](Divine.Protobufs.Steam.CMsgSteamDatagramNoSessionRelayToClient.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToClient_ChallengeFieldNumber"></a> ChallengeFieldNumber

```csharp
public const int ChallengeFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToClient_ConnectionIdFieldNumber"></a> ConnectionIdFieldNumber

```csharp
public const int ConnectionIdFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToClient_SecondsUntilShutdownFieldNumber"></a> SecondsUntilShutdownFieldNumber

```csharp
public const int SecondsUntilShutdownFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToClient_ServerTimeFieldNumber"></a> ServerTimeFieldNumber

```csharp
public const int ServerTimeFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToClient_YourPublicIpFieldNumber"></a> YourPublicIpFieldNumber

```csharp
public const int YourPublicIpFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToClient_YourPublicPortFieldNumber"></a> YourPublicPortFieldNumber

```csharp
public const int YourPublicPortFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToClient_Challenge"></a> Challenge

```csharp
public ulong Challenge { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToClient_ConnectionId"></a> ConnectionId

```csharp
public uint ConnectionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToClient_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToClient_HasChallenge"></a> HasChallenge

```csharp
public bool HasChallenge { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToClient_HasConnectionId"></a> HasConnectionId

```csharp
public bool HasConnectionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToClient_HasSecondsUntilShutdown"></a> HasSecondsUntilShutdown

```csharp
public bool HasSecondsUntilShutdown { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToClient_HasServerTime"></a> HasServerTime

```csharp
public bool HasServerTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToClient_HasYourPublicIp"></a> HasYourPublicIp

```csharp
public bool HasYourPublicIp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToClient_HasYourPublicPort"></a> HasYourPublicPort

```csharp
public bool HasYourPublicPort { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToClient_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamDatagramNoSessionRelayToClient> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamDatagramNoSessionRelayToClient](Divine.Protobufs.Steam.CMsgSteamDatagramNoSessionRelayToClient.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToClient_SecondsUntilShutdown"></a> SecondsUntilShutdown

```csharp
public uint SecondsUntilShutdown { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToClient_ServerTime"></a> ServerTime

```csharp
public uint ServerTime { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToClient_YourPublicIp"></a> YourPublicIp

```csharp
public uint YourPublicIp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToClient_YourPublicPort"></a> YourPublicPort

```csharp
public uint YourPublicPort { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToClient_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToClient_ClearChallenge"></a> ClearChallenge\(\)

```csharp
public void ClearChallenge()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToClient_ClearConnectionId"></a> ClearConnectionId\(\)

```csharp
public void ClearConnectionId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToClient_ClearSecondsUntilShutdown"></a> ClearSecondsUntilShutdown\(\)

```csharp
public void ClearSecondsUntilShutdown()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToClient_ClearServerTime"></a> ClearServerTime\(\)

```csharp
public void ClearServerTime()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToClient_ClearYourPublicIp"></a> ClearYourPublicIp\(\)

```csharp
public void ClearYourPublicIp()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToClient_ClearYourPublicPort"></a> ClearYourPublicPort\(\)

```csharp
public void ClearYourPublicPort()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToClient_Clone"></a> Clone\(\)

```csharp
public CMsgSteamDatagramNoSessionRelayToClient Clone()
```

#### Returns

 [CMsgSteamDatagramNoSessionRelayToClient](Divine.Protobufs.Steam.CMsgSteamDatagramNoSessionRelayToClient.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToClient_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToClient_Equals_Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToClient_"></a> Equals\(CMsgSteamDatagramNoSessionRelayToClient\)

```csharp
public bool Equals(CMsgSteamDatagramNoSessionRelayToClient other)
```

#### Parameters

`other` [CMsgSteamDatagramNoSessionRelayToClient](Divine.Protobufs.Steam.CMsgSteamDatagramNoSessionRelayToClient.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToClient_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToClient_MergeFrom_Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToClient_"></a> MergeFrom\(CMsgSteamDatagramNoSessionRelayToClient\)

```csharp
public void MergeFrom(CMsgSteamDatagramNoSessionRelayToClient other)
```

#### Parameters

`other` [CMsgSteamDatagramNoSessionRelayToClient](Divine.Protobufs.Steam.CMsgSteamDatagramNoSessionRelayToClient.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToClient_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToClient_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramNoSessionRelayToClient_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

