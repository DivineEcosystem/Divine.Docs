# <a id="Divine_Protobufs_Dota2_CMsgWatchGameResponse"></a> Class CMsgWatchGameResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgWatchGameResponse : IMessage<CMsgWatchGameResponse>, IEquatable<CMsgWatchGameResponse>, IDeepCloneable<CMsgWatchGameResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgWatchGameResponse](Divine.Protobufs.Dota2.CMsgWatchGameResponse.md)

#### Implements

IMessage<CMsgWatchGameResponse\>, 
[IEquatable<CMsgWatchGameResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgWatchGameResponse\>, 
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
[EnumerableExtensions.In<CMsgWatchGameResponse\>\(CMsgWatchGameResponse, params CMsgWatchGameResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgWatchGameResponse__ctor"></a> CMsgWatchGameResponse\(\)

```csharp
public CMsgWatchGameResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgWatchGameResponse__ctor_Divine_Protobufs_Dota2_CMsgWatchGameResponse_"></a> CMsgWatchGameResponse\(CMsgWatchGameResponse\)

```csharp
public CMsgWatchGameResponse(CMsgWatchGameResponse other)
```

#### Parameters

`other` [CMsgWatchGameResponse](Divine.Protobufs.Dota2.CMsgWatchGameResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgWatchGameResponse_BroadcastUrlFieldNumber"></a> BroadcastUrlFieldNumber

```csharp
public const int BroadcastUrlFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgWatchGameResponse_GameServerSteamidFieldNumber"></a> GameServerSteamidFieldNumber

```csharp
public const int GameServerSteamidFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgWatchGameResponse_SourceTvPortFieldNumber"></a> SourceTvPortFieldNumber

```csharp
public const int SourceTvPortFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgWatchGameResponse_SourceTvPrivateAddrFieldNumber"></a> SourceTvPrivateAddrFieldNumber

```csharp
public const int SourceTvPrivateAddrFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgWatchGameResponse_SourceTvPublicAddrFieldNumber"></a> SourceTvPublicAddrFieldNumber

```csharp
public const int SourceTvPublicAddrFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgWatchGameResponse_WatchGameResultFieldNumber"></a> WatchGameResultFieldNumber

```csharp
public const int WatchGameResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgWatchGameResponse_WatchServerSteamidFieldNumber"></a> WatchServerSteamidFieldNumber

```csharp
public const int WatchServerSteamidFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgWatchGameResponse_WatchTvUniqueSecretCodeFieldNumber"></a> WatchTvUniqueSecretCodeFieldNumber

```csharp
public const int WatchTvUniqueSecretCodeFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgWatchGameResponse_BroadcastUrl"></a> BroadcastUrl

```csharp
public string BroadcastUrl { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgWatchGameResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgWatchGameResponse_GameServerSteamid"></a> GameServerSteamid

```csharp
public ulong GameServerSteamid { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgWatchGameResponse_HasBroadcastUrl"></a> HasBroadcastUrl

```csharp
public bool HasBroadcastUrl { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgWatchGameResponse_HasGameServerSteamid"></a> HasGameServerSteamid

```csharp
public bool HasGameServerSteamid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgWatchGameResponse_HasSourceTvPort"></a> HasSourceTvPort

```csharp
public bool HasSourceTvPort { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgWatchGameResponse_HasSourceTvPrivateAddr"></a> HasSourceTvPrivateAddr

```csharp
public bool HasSourceTvPrivateAddr { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgWatchGameResponse_HasSourceTvPublicAddr"></a> HasSourceTvPublicAddr

```csharp
public bool HasSourceTvPublicAddr { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgWatchGameResponse_HasWatchGameResult"></a> HasWatchGameResult

```csharp
public bool HasWatchGameResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgWatchGameResponse_HasWatchServerSteamid"></a> HasWatchServerSteamid

```csharp
public bool HasWatchServerSteamid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgWatchGameResponse_HasWatchTvUniqueSecretCode"></a> HasWatchTvUniqueSecretCode

```csharp
public bool HasWatchTvUniqueSecretCode { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgWatchGameResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgWatchGameResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgWatchGameResponse](Divine.Protobufs.Dota2.CMsgWatchGameResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgWatchGameResponse_SourceTvPort"></a> SourceTvPort

```csharp
public uint SourceTvPort { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgWatchGameResponse_SourceTvPrivateAddr"></a> SourceTvPrivateAddr

```csharp
public uint SourceTvPrivateAddr { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgWatchGameResponse_SourceTvPublicAddr"></a> SourceTvPublicAddr

```csharp
public uint SourceTvPublicAddr { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgWatchGameResponse_WatchGameResult"></a> WatchGameResult

```csharp
public CMsgWatchGameResponse.Types.WatchGameResult WatchGameResult { get; set; }
```

#### Property Value

 [CMsgWatchGameResponse](Divine.Protobufs.Dota2.CMsgWatchGameResponse.md).[Types](Divine.Protobufs.Dota2.CMsgWatchGameResponse.Types.md).[WatchGameResult](Divine.Protobufs.Dota2.CMsgWatchGameResponse.Types.WatchGameResult.md)

### <a id="Divine_Protobufs_Dota2_CMsgWatchGameResponse_WatchServerSteamid"></a> WatchServerSteamid

```csharp
public ulong WatchServerSteamid { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgWatchGameResponse_WatchTvUniqueSecretCode"></a> WatchTvUniqueSecretCode

```csharp
public ulong WatchTvUniqueSecretCode { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgWatchGameResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgWatchGameResponse_ClearBroadcastUrl"></a> ClearBroadcastUrl\(\)

```csharp
public void ClearBroadcastUrl()
```

### <a id="Divine_Protobufs_Dota2_CMsgWatchGameResponse_ClearGameServerSteamid"></a> ClearGameServerSteamid\(\)

```csharp
public void ClearGameServerSteamid()
```

### <a id="Divine_Protobufs_Dota2_CMsgWatchGameResponse_ClearSourceTvPort"></a> ClearSourceTvPort\(\)

```csharp
public void ClearSourceTvPort()
```

### <a id="Divine_Protobufs_Dota2_CMsgWatchGameResponse_ClearSourceTvPrivateAddr"></a> ClearSourceTvPrivateAddr\(\)

```csharp
public void ClearSourceTvPrivateAddr()
```

### <a id="Divine_Protobufs_Dota2_CMsgWatchGameResponse_ClearSourceTvPublicAddr"></a> ClearSourceTvPublicAddr\(\)

```csharp
public void ClearSourceTvPublicAddr()
```

### <a id="Divine_Protobufs_Dota2_CMsgWatchGameResponse_ClearWatchGameResult"></a> ClearWatchGameResult\(\)

```csharp
public void ClearWatchGameResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgWatchGameResponse_ClearWatchServerSteamid"></a> ClearWatchServerSteamid\(\)

```csharp
public void ClearWatchServerSteamid()
```

### <a id="Divine_Protobufs_Dota2_CMsgWatchGameResponse_ClearWatchTvUniqueSecretCode"></a> ClearWatchTvUniqueSecretCode\(\)

```csharp
public void ClearWatchTvUniqueSecretCode()
```

### <a id="Divine_Protobufs_Dota2_CMsgWatchGameResponse_Clone"></a> Clone\(\)

```csharp
public CMsgWatchGameResponse Clone()
```

#### Returns

 [CMsgWatchGameResponse](Divine.Protobufs.Dota2.CMsgWatchGameResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgWatchGameResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgWatchGameResponse_Equals_Divine_Protobufs_Dota2_CMsgWatchGameResponse_"></a> Equals\(CMsgWatchGameResponse\)

```csharp
public bool Equals(CMsgWatchGameResponse other)
```

#### Parameters

`other` [CMsgWatchGameResponse](Divine.Protobufs.Dota2.CMsgWatchGameResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgWatchGameResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgWatchGameResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgWatchGameResponse_"></a> MergeFrom\(CMsgWatchGameResponse\)

```csharp
public void MergeFrom(CMsgWatchGameResponse other)
```

#### Parameters

`other` [CMsgWatchGameResponse](Divine.Protobufs.Dota2.CMsgWatchGameResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgWatchGameResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgWatchGameResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgWatchGameResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

