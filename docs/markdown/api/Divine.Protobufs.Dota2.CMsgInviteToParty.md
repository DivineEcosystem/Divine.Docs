# <a id="Divine_Protobufs_Dota2_CMsgInviteToParty"></a> Class CMsgInviteToParty

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgInviteToParty : IMessage<CMsgInviteToParty>, IEquatable<CMsgInviteToParty>, IDeepCloneable<CMsgInviteToParty>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgInviteToParty](Divine.Protobufs.Dota2.CMsgInviteToParty.md)

#### Implements

IMessage<CMsgInviteToParty\>, 
[IEquatable<CMsgInviteToParty\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgInviteToParty\>, 
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
[EnumerableExtensions.In<CMsgInviteToParty\>\(CMsgInviteToParty, params CMsgInviteToParty\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgInviteToParty__ctor"></a> CMsgInviteToParty\(\)

```csharp
public CMsgInviteToParty()
```

### <a id="Divine_Protobufs_Dota2_CMsgInviteToParty__ctor_Divine_Protobufs_Dota2_CMsgInviteToParty_"></a> CMsgInviteToParty\(CMsgInviteToParty\)

```csharp
public CMsgInviteToParty(CMsgInviteToParty other)
```

#### Parameters

`other` [CMsgInviteToParty](Divine.Protobufs.Dota2.CMsgInviteToParty.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgInviteToParty_AsCoachFieldNumber"></a> AsCoachFieldNumber

```csharp
public const int AsCoachFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgInviteToParty_ClientVersionFieldNumber"></a> ClientVersionFieldNumber

```csharp
public const int ClientVersionFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgInviteToParty_PingDataFieldNumber"></a> PingDataFieldNumber

```csharp
public const int PingDataFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgInviteToParty_SteamIdFieldNumber"></a> SteamIdFieldNumber

```csharp
public const int SteamIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgInviteToParty_TeamIdFieldNumber"></a> TeamIdFieldNumber

```csharp
public const int TeamIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgInviteToParty_AsCoach"></a> AsCoach

```csharp
public bool AsCoach { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgInviteToParty_ClientVersion"></a> ClientVersion

```csharp
public uint ClientVersion { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgInviteToParty_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgInviteToParty_HasAsCoach"></a> HasAsCoach

```csharp
public bool HasAsCoach { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgInviteToParty_HasClientVersion"></a> HasClientVersion

```csharp
public bool HasClientVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgInviteToParty_HasSteamId"></a> HasSteamId

```csharp
public bool HasSteamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgInviteToParty_HasTeamId"></a> HasTeamId

```csharp
public bool HasTeamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgInviteToParty_Parser"></a> Parser

```csharp
public static MessageParser<CMsgInviteToParty> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgInviteToParty](Divine.Protobufs.Dota2.CMsgInviteToParty.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgInviteToParty_PingData"></a> PingData

```csharp
public CMsgClientPingData PingData { get; set; }
```

#### Property Value

 [CMsgClientPingData](Divine.Protobufs.Dota2.CMsgClientPingData.md)

### <a id="Divine_Protobufs_Dota2_CMsgInviteToParty_SteamId"></a> SteamId

```csharp
public ulong SteamId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgInviteToParty_TeamId"></a> TeamId

```csharp
public uint TeamId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgInviteToParty_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgInviteToParty_ClearAsCoach"></a> ClearAsCoach\(\)

```csharp
public void ClearAsCoach()
```

### <a id="Divine_Protobufs_Dota2_CMsgInviteToParty_ClearClientVersion"></a> ClearClientVersion\(\)

```csharp
public void ClearClientVersion()
```

### <a id="Divine_Protobufs_Dota2_CMsgInviteToParty_ClearSteamId"></a> ClearSteamId\(\)

```csharp
public void ClearSteamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgInviteToParty_ClearTeamId"></a> ClearTeamId\(\)

```csharp
public void ClearTeamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgInviteToParty_Clone"></a> Clone\(\)

```csharp
public CMsgInviteToParty Clone()
```

#### Returns

 [CMsgInviteToParty](Divine.Protobufs.Dota2.CMsgInviteToParty.md)

### <a id="Divine_Protobufs_Dota2_CMsgInviteToParty_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgInviteToParty_Equals_Divine_Protobufs_Dota2_CMsgInviteToParty_"></a> Equals\(CMsgInviteToParty\)

```csharp
public bool Equals(CMsgInviteToParty other)
```

#### Parameters

`other` [CMsgInviteToParty](Divine.Protobufs.Dota2.CMsgInviteToParty.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgInviteToParty_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgInviteToParty_MergeFrom_Divine_Protobufs_Dota2_CMsgInviteToParty_"></a> MergeFrom\(CMsgInviteToParty\)

```csharp
public void MergeFrom(CMsgInviteToParty other)
```

#### Parameters

`other` [CMsgInviteToParty](Divine.Protobufs.Dota2.CMsgInviteToParty.md)

### <a id="Divine_Protobufs_Dota2_CMsgInviteToParty_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgInviteToParty_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgInviteToParty_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

