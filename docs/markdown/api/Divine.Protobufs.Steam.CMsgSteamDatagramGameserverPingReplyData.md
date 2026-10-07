# <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingReplyData"></a> Class CMsgSteamDatagramGameserverPingReplyData

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamDatagramGameserverPingReplyData : IMessage<CMsgSteamDatagramGameserverPingReplyData>, IEquatable<CMsgSteamDatagramGameserverPingReplyData>, IDeepCloneable<CMsgSteamDatagramGameserverPingReplyData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamDatagramGameserverPingReplyData](Divine.Protobufs.Steam.CMsgSteamDatagramGameserverPingReplyData.md)

#### Implements

IMessage<CMsgSteamDatagramGameserverPingReplyData\>, 
[IEquatable<CMsgSteamDatagramGameserverPingReplyData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamDatagramGameserverPingReplyData\>, 
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
[EnumerableExtensions.In<CMsgSteamDatagramGameserverPingReplyData\>\(CMsgSteamDatagramGameserverPingReplyData, params CMsgSteamDatagramGameserverPingReplyData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingReplyData__ctor"></a> CMsgSteamDatagramGameserverPingReplyData\(\)

```csharp
public CMsgSteamDatagramGameserverPingReplyData()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingReplyData__ctor_Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingReplyData_"></a> CMsgSteamDatagramGameserverPingReplyData\(CMsgSteamDatagramGameserverPingReplyData\)

```csharp
public CMsgSteamDatagramGameserverPingReplyData(CMsgSteamDatagramGameserverPingReplyData other)
```

#### Parameters

`other` [CMsgSteamDatagramGameserverPingReplyData](Divine.Protobufs.Steam.CMsgSteamDatagramGameserverPingReplyData.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingReplyData_AppidFieldNumber"></a> AppidFieldNumber

```csharp
public const int AppidFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingReplyData_BuildFieldNumber"></a> BuildFieldNumber

```csharp
public const int BuildFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingReplyData_DataCenterIdFieldNumber"></a> DataCenterIdFieldNumber

```csharp
public const int DataCenterIdFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingReplyData_EchoFieldNumber"></a> EchoFieldNumber

```csharp
public const int EchoFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingReplyData_EchoRelayUnixTimeFieldNumber"></a> EchoRelayUnixTimeFieldNumber

```csharp
public const int EchoRelayUnixTimeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingReplyData_LegacyChallengeFieldNumber"></a> LegacyChallengeFieldNumber

```csharp
public const int LegacyChallengeFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingReplyData_LegacyRouterTimestampFieldNumber"></a> LegacyRouterTimestampFieldNumber

```csharp
public const int LegacyRouterTimestampFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingReplyData_MyUnixTimeFieldNumber"></a> MyUnixTimeFieldNumber

```csharp
public const int MyUnixTimeFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingReplyData_NetworkConfigVersionFieldNumber"></a> NetworkConfigVersionFieldNumber

```csharp
public const int NetworkConfigVersionFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingReplyData_ProtocolVersionFieldNumber"></a> ProtocolVersionFieldNumber

```csharp
public const int ProtocolVersionFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingReplyData_RoutingBlobFieldNumber"></a> RoutingBlobFieldNumber

```csharp
public const int RoutingBlobFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingReplyData_Appid"></a> Appid

```csharp
public uint Appid { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingReplyData_Build"></a> Build

```csharp
public string Build { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingReplyData_DataCenterId"></a> DataCenterId

```csharp
public uint DataCenterId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingReplyData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingReplyData_Echo"></a> Echo

```csharp
public ByteString Echo { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingReplyData_EchoRelayUnixTime"></a> EchoRelayUnixTime

```csharp
public uint EchoRelayUnixTime { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingReplyData_HasAppid"></a> HasAppid

```csharp
public bool HasAppid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingReplyData_HasBuild"></a> HasBuild

```csharp
public bool HasBuild { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingReplyData_HasDataCenterId"></a> HasDataCenterId

```csharp
public bool HasDataCenterId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingReplyData_HasEcho"></a> HasEcho

```csharp
public bool HasEcho { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingReplyData_HasEchoRelayUnixTime"></a> HasEchoRelayUnixTime

```csharp
public bool HasEchoRelayUnixTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingReplyData_HasLegacyChallenge"></a> HasLegacyChallenge

```csharp
public bool HasLegacyChallenge { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingReplyData_HasLegacyRouterTimestamp"></a> HasLegacyRouterTimestamp

```csharp
public bool HasLegacyRouterTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingReplyData_HasMyUnixTime"></a> HasMyUnixTime

```csharp
public bool HasMyUnixTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingReplyData_HasNetworkConfigVersion"></a> HasNetworkConfigVersion

```csharp
public bool HasNetworkConfigVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingReplyData_HasProtocolVersion"></a> HasProtocolVersion

```csharp
public bool HasProtocolVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingReplyData_HasRoutingBlob"></a> HasRoutingBlob

```csharp
public bool HasRoutingBlob { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingReplyData_LegacyChallenge"></a> LegacyChallenge

```csharp
public ulong LegacyChallenge { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingReplyData_LegacyRouterTimestamp"></a> LegacyRouterTimestamp

```csharp
public uint LegacyRouterTimestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingReplyData_MyUnixTime"></a> MyUnixTime

```csharp
public uint MyUnixTime { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingReplyData_NetworkConfigVersion"></a> NetworkConfigVersion

```csharp
public ulong NetworkConfigVersion { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingReplyData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamDatagramGameserverPingReplyData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamDatagramGameserverPingReplyData](Divine.Protobufs.Steam.CMsgSteamDatagramGameserverPingReplyData.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingReplyData_ProtocolVersion"></a> ProtocolVersion

```csharp
public uint ProtocolVersion { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingReplyData_RoutingBlob"></a> RoutingBlob

```csharp
public ByteString RoutingBlob { get; set; }
```

#### Property Value

 ByteString

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingReplyData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingReplyData_ClearAppid"></a> ClearAppid\(\)

```csharp
public void ClearAppid()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingReplyData_ClearBuild"></a> ClearBuild\(\)

```csharp
public void ClearBuild()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingReplyData_ClearDataCenterId"></a> ClearDataCenterId\(\)

```csharp
public void ClearDataCenterId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingReplyData_ClearEcho"></a> ClearEcho\(\)

```csharp
public void ClearEcho()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingReplyData_ClearEchoRelayUnixTime"></a> ClearEchoRelayUnixTime\(\)

```csharp
public void ClearEchoRelayUnixTime()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingReplyData_ClearLegacyChallenge"></a> ClearLegacyChallenge\(\)

```csharp
public void ClearLegacyChallenge()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingReplyData_ClearLegacyRouterTimestamp"></a> ClearLegacyRouterTimestamp\(\)

```csharp
public void ClearLegacyRouterTimestamp()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingReplyData_ClearMyUnixTime"></a> ClearMyUnixTime\(\)

```csharp
public void ClearMyUnixTime()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingReplyData_ClearNetworkConfigVersion"></a> ClearNetworkConfigVersion\(\)

```csharp
public void ClearNetworkConfigVersion()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingReplyData_ClearProtocolVersion"></a> ClearProtocolVersion\(\)

```csharp
public void ClearProtocolVersion()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingReplyData_ClearRoutingBlob"></a> ClearRoutingBlob\(\)

```csharp
public void ClearRoutingBlob()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingReplyData_Clone"></a> Clone\(\)

```csharp
public CMsgSteamDatagramGameserverPingReplyData Clone()
```

#### Returns

 [CMsgSteamDatagramGameserverPingReplyData](Divine.Protobufs.Steam.CMsgSteamDatagramGameserverPingReplyData.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingReplyData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingReplyData_Equals_Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingReplyData_"></a> Equals\(CMsgSteamDatagramGameserverPingReplyData\)

```csharp
public bool Equals(CMsgSteamDatagramGameserverPingReplyData other)
```

#### Parameters

`other` [CMsgSteamDatagramGameserverPingReplyData](Divine.Protobufs.Steam.CMsgSteamDatagramGameserverPingReplyData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingReplyData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingReplyData_MergeFrom_Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingReplyData_"></a> MergeFrom\(CMsgSteamDatagramGameserverPingReplyData\)

```csharp
public void MergeFrom(CMsgSteamDatagramGameserverPingReplyData other)
```

#### Parameters

`other` [CMsgSteamDatagramGameserverPingReplyData](Divine.Protobufs.Steam.CMsgSteamDatagramGameserverPingReplyData.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingReplyData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingReplyData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramGameserverPingReplyData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

