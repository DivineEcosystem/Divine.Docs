# <a id="Divine_Protobufs_Dota2_CMsgGCToRelayConnect"></a> Class CMsgGCToRelayConnect

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToRelayConnect : IMessage<CMsgGCToRelayConnect>, IEquatable<CMsgGCToRelayConnect>, IDeepCloneable<CMsgGCToRelayConnect>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToRelayConnect](Divine.Protobufs.Dota2.CMsgGCToRelayConnect.md)

#### Implements

IMessage<CMsgGCToRelayConnect\>, 
[IEquatable<CMsgGCToRelayConnect\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToRelayConnect\>, 
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
[EnumerableExtensions.In<CMsgGCToRelayConnect\>\(CMsgGCToRelayConnect, params CMsgGCToRelayConnect\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToRelayConnect__ctor"></a> CMsgGCToRelayConnect\(\)

```csharp
public CMsgGCToRelayConnect()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToRelayConnect__ctor_Divine_Protobufs_Dota2_CMsgGCToRelayConnect_"></a> CMsgGCToRelayConnect\(CMsgGCToRelayConnect\)

```csharp
public CMsgGCToRelayConnect(CMsgGCToRelayConnect other)
```

#### Parameters

`other` [CMsgGCToRelayConnect](Divine.Protobufs.Dota2.CMsgGCToRelayConnect.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToRelayConnect_GameServerSteamIdFieldNumber"></a> GameServerSteamIdFieldNumber

```csharp
public const int GameServerSteamIdFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToRelayConnect_ParentCountFieldNumber"></a> ParentCountFieldNumber

```csharp
public const int ParentCountFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToRelayConnect_SourceTvPortFieldNumber"></a> SourceTvPortFieldNumber

```csharp
public const int SourceTvPortFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToRelayConnect_SourceTvPrivateAddrFieldNumber"></a> SourceTvPrivateAddrFieldNumber

```csharp
public const int SourceTvPrivateAddrFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToRelayConnect_SourceTvPublicAddrFieldNumber"></a> SourceTvPublicAddrFieldNumber

```csharp
public const int SourceTvPublicAddrFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToRelayConnect_SourceTvSteamidFieldNumber"></a> SourceTvSteamidFieldNumber

```csharp
public const int SourceTvSteamidFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToRelayConnect_TvUniqueSecretCodeFieldNumber"></a> TvUniqueSecretCodeFieldNumber

```csharp
public const int TvUniqueSecretCodeFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToRelayConnect_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToRelayConnect_GameServerSteamId"></a> GameServerSteamId

```csharp
public ulong GameServerSteamId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgGCToRelayConnect_HasGameServerSteamId"></a> HasGameServerSteamId

```csharp
public bool HasGameServerSteamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToRelayConnect_HasParentCount"></a> HasParentCount

```csharp
public bool HasParentCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToRelayConnect_HasSourceTvPort"></a> HasSourceTvPort

```csharp
public bool HasSourceTvPort { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToRelayConnect_HasSourceTvPrivateAddr"></a> HasSourceTvPrivateAddr

```csharp
public bool HasSourceTvPrivateAddr { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToRelayConnect_HasSourceTvPublicAddr"></a> HasSourceTvPublicAddr

```csharp
public bool HasSourceTvPublicAddr { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToRelayConnect_HasSourceTvSteamid"></a> HasSourceTvSteamid

```csharp
public bool HasSourceTvSteamid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToRelayConnect_HasTvUniqueSecretCode"></a> HasTvUniqueSecretCode

```csharp
public bool HasTvUniqueSecretCode { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToRelayConnect_ParentCount"></a> ParentCount

```csharp
public uint ParentCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToRelayConnect_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToRelayConnect> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToRelayConnect](Divine.Protobufs.Dota2.CMsgGCToRelayConnect.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToRelayConnect_SourceTvPort"></a> SourceTvPort

```csharp
public uint SourceTvPort { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToRelayConnect_SourceTvPrivateAddr"></a> SourceTvPrivateAddr

```csharp
public uint SourceTvPrivateAddr { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToRelayConnect_SourceTvPublicAddr"></a> SourceTvPublicAddr

```csharp
public uint SourceTvPublicAddr { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToRelayConnect_SourceTvSteamid"></a> SourceTvSteamid

```csharp
public ulong SourceTvSteamid { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgGCToRelayConnect_TvUniqueSecretCode"></a> TvUniqueSecretCode

```csharp
public ulong TvUniqueSecretCode { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToRelayConnect_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToRelayConnect_ClearGameServerSteamId"></a> ClearGameServerSteamId\(\)

```csharp
public void ClearGameServerSteamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToRelayConnect_ClearParentCount"></a> ClearParentCount\(\)

```csharp
public void ClearParentCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToRelayConnect_ClearSourceTvPort"></a> ClearSourceTvPort\(\)

```csharp
public void ClearSourceTvPort()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToRelayConnect_ClearSourceTvPrivateAddr"></a> ClearSourceTvPrivateAddr\(\)

```csharp
public void ClearSourceTvPrivateAddr()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToRelayConnect_ClearSourceTvPublicAddr"></a> ClearSourceTvPublicAddr\(\)

```csharp
public void ClearSourceTvPublicAddr()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToRelayConnect_ClearSourceTvSteamid"></a> ClearSourceTvSteamid\(\)

```csharp
public void ClearSourceTvSteamid()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToRelayConnect_ClearTvUniqueSecretCode"></a> ClearTvUniqueSecretCode\(\)

```csharp
public void ClearTvUniqueSecretCode()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToRelayConnect_Clone"></a> Clone\(\)

```csharp
public CMsgGCToRelayConnect Clone()
```

#### Returns

 [CMsgGCToRelayConnect](Divine.Protobufs.Dota2.CMsgGCToRelayConnect.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToRelayConnect_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToRelayConnect_Equals_Divine_Protobufs_Dota2_CMsgGCToRelayConnect_"></a> Equals\(CMsgGCToRelayConnect\)

```csharp
public bool Equals(CMsgGCToRelayConnect other)
```

#### Parameters

`other` [CMsgGCToRelayConnect](Divine.Protobufs.Dota2.CMsgGCToRelayConnect.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToRelayConnect_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToRelayConnect_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToRelayConnect_"></a> MergeFrom\(CMsgGCToRelayConnect\)

```csharp
public void MergeFrom(CMsgGCToRelayConnect other)
```

#### Parameters

`other` [CMsgGCToRelayConnect](Divine.Protobufs.Dota2.CMsgGCToRelayConnect.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToRelayConnect_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToRelayConnect_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToRelayConnect_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

