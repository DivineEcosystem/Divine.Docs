# <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobby"></a> Class CMsgQuickJoinCustomLobby

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgQuickJoinCustomLobby : IMessage<CMsgQuickJoinCustomLobby>, IEquatable<CMsgQuickJoinCustomLobby>, IDeepCloneable<CMsgQuickJoinCustomLobby>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgQuickJoinCustomLobby](Divine.Protobufs.Dota2.CMsgQuickJoinCustomLobby.md)

#### Implements

IMessage<CMsgQuickJoinCustomLobby\>, 
[IEquatable<CMsgQuickJoinCustomLobby\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgQuickJoinCustomLobby\>, 
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
[EnumerableExtensions.In<CMsgQuickJoinCustomLobby\>\(CMsgQuickJoinCustomLobby, params CMsgQuickJoinCustomLobby\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobby__ctor"></a> CMsgQuickJoinCustomLobby\(\)

```csharp
public CMsgQuickJoinCustomLobby()
```

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobby__ctor_Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobby_"></a> CMsgQuickJoinCustomLobby\(CMsgQuickJoinCustomLobby\)

```csharp
public CMsgQuickJoinCustomLobby(CMsgQuickJoinCustomLobby other)
```

#### Parameters

`other` [CMsgQuickJoinCustomLobby](Divine.Protobufs.Dota2.CMsgQuickJoinCustomLobby.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobby_AllowAnyMapFieldNumber"></a> AllowAnyMapFieldNumber

```csharp
public const int AllowAnyMapFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobby_ClientVersionFieldNumber"></a> ClientVersionFieldNumber

```csharp
public const int ClientVersionFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobby_CreateLobbyDetailsFieldNumber"></a> CreateLobbyDetailsFieldNumber

```csharp
public const int CreateLobbyDetailsFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobby_CustomGameIdFieldNumber"></a> CustomGameIdFieldNumber

```csharp
public const int CustomGameIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobby_LegacyRegionPingsFieldNumber"></a> LegacyRegionPingsFieldNumber

```csharp
public const int LegacyRegionPingsFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobby_LegacyServerRegionFieldNumber"></a> LegacyServerRegionFieldNumber

```csharp
public const int LegacyServerRegionFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobby_PingDataFieldNumber"></a> PingDataFieldNumber

```csharp
public const int PingDataFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobby_AllowAnyMap"></a> AllowAnyMap

```csharp
public bool AllowAnyMap { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobby_ClientVersion"></a> ClientVersion

```csharp
public uint ClientVersion { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobby_CreateLobbyDetails"></a> CreateLobbyDetails

```csharp
public CMsgPracticeLobbySetDetails CreateLobbyDetails { get; set; }
```

#### Property Value

 [CMsgPracticeLobbySetDetails](Divine.Protobufs.Dota2.CMsgPracticeLobbySetDetails.md)

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobby_CustomGameId"></a> CustomGameId

```csharp
public ulong CustomGameId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobby_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobby_HasAllowAnyMap"></a> HasAllowAnyMap

```csharp
public bool HasAllowAnyMap { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobby_HasClientVersion"></a> HasClientVersion

```csharp
public bool HasClientVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobby_HasCustomGameId"></a> HasCustomGameId

```csharp
public bool HasCustomGameId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobby_HasLegacyServerRegion"></a> HasLegacyServerRegion

```csharp
public bool HasLegacyServerRegion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobby_LegacyRegionPings"></a> LegacyRegionPings

```csharp
public RepeatedField<CMsgQuickJoinCustomLobby.Types.LegacyRegionPing> LegacyRegionPings { get; }
```

#### Property Value

 RepeatedField<[CMsgQuickJoinCustomLobby](Divine.Protobufs.Dota2.CMsgQuickJoinCustomLobby.md).[Types](Divine.Protobufs.Dota2.CMsgQuickJoinCustomLobby.Types.md).[LegacyRegionPing](Divine.Protobufs.Dota2.CMsgQuickJoinCustomLobby.Types.LegacyRegionPing.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobby_LegacyServerRegion"></a> LegacyServerRegion

```csharp
public uint LegacyServerRegion { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobby_Parser"></a> Parser

```csharp
public static MessageParser<CMsgQuickJoinCustomLobby> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgQuickJoinCustomLobby](Divine.Protobufs.Dota2.CMsgQuickJoinCustomLobby.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobby_PingData"></a> PingData

```csharp
public CMsgClientPingData PingData { get; set; }
```

#### Property Value

 [CMsgClientPingData](Divine.Protobufs.Dota2.CMsgClientPingData.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobby_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobby_ClearAllowAnyMap"></a> ClearAllowAnyMap\(\)

```csharp
public void ClearAllowAnyMap()
```

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobby_ClearClientVersion"></a> ClearClientVersion\(\)

```csharp
public void ClearClientVersion()
```

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobby_ClearCustomGameId"></a> ClearCustomGameId\(\)

```csharp
public void ClearCustomGameId()
```

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobby_ClearLegacyServerRegion"></a> ClearLegacyServerRegion\(\)

```csharp
public void ClearLegacyServerRegion()
```

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobby_Clone"></a> Clone\(\)

```csharp
public CMsgQuickJoinCustomLobby Clone()
```

#### Returns

 [CMsgQuickJoinCustomLobby](Divine.Protobufs.Dota2.CMsgQuickJoinCustomLobby.md)

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobby_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobby_Equals_Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobby_"></a> Equals\(CMsgQuickJoinCustomLobby\)

```csharp
public bool Equals(CMsgQuickJoinCustomLobby other)
```

#### Parameters

`other` [CMsgQuickJoinCustomLobby](Divine.Protobufs.Dota2.CMsgQuickJoinCustomLobby.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobby_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobby_MergeFrom_Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobby_"></a> MergeFrom\(CMsgQuickJoinCustomLobby\)

```csharp
public void MergeFrom(CMsgQuickJoinCustomLobby other)
```

#### Parameters

`other` [CMsgQuickJoinCustomLobby](Divine.Protobufs.Dota2.CMsgQuickJoinCustomLobby.md)

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobby_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobby_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobby_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

