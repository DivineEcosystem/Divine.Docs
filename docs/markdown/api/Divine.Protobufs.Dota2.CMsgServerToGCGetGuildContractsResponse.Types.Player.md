# <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Types_Player"></a> Class CMsgServerToGCGetGuildContractsResponse.Types.Player

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgServerToGCGetGuildContractsResponse.Types.Player : IMessage<CMsgServerToGCGetGuildContractsResponse.Types.Player>, IEquatable<CMsgServerToGCGetGuildContractsResponse.Types.Player>, IDeepCloneable<CMsgServerToGCGetGuildContractsResponse.Types.Player>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgServerToGCGetGuildContractsResponse.Types.Player](Divine.Protobufs.Dota2.CMsgServerToGCGetGuildContractsResponse.Types.Player.md)

#### Implements

IMessage<CMsgServerToGCGetGuildContractsResponse.Types.Player\>, 
[IEquatable<CMsgServerToGCGetGuildContractsResponse.Types.Player\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgServerToGCGetGuildContractsResponse.Types.Player\>, 
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
[EnumerableExtensions.In<CMsgServerToGCGetGuildContractsResponse.Types.Player\>\(CMsgServerToGCGetGuildContractsResponse.Types.Player, params CMsgServerToGCGetGuildContractsResponse.Types.Player\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Types_Player__ctor"></a> Player\(\)

```csharp
public Player()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Types_Player__ctor_Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Types_Player_"></a> Player\(Player\)

```csharp
public Player(CMsgServerToGCGetGuildContractsResponse.Types.Player other)
```

#### Parameters

`other` [CMsgServerToGCGetGuildContractsResponse](Divine.Protobufs.Dota2.CMsgServerToGCGetGuildContractsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgServerToGCGetGuildContractsResponse.Types.md).[Player](Divine.Protobufs.Dota2.CMsgServerToGCGetGuildContractsResponse.Types.Player.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Types_Player_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Types_Player_ContractsFieldNumber"></a> ContractsFieldNumber

```csharp
public const int ContractsFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Types_Player_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Types_Player_GuildIdFieldNumber"></a> GuildIdFieldNumber

```csharp
public const int GuildIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Types_Player_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Types_Player_Contracts"></a> Contracts

```csharp
public RepeatedField<CMsgServerToGCGetGuildContractsResponse.Types.ContractDetails> Contracts { get; }
```

#### Property Value

 RepeatedField<[CMsgServerToGCGetGuildContractsResponse](Divine.Protobufs.Dota2.CMsgServerToGCGetGuildContractsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgServerToGCGetGuildContractsResponse.Types.md).[ContractDetails](Divine.Protobufs.Dota2.CMsgServerToGCGetGuildContractsResponse.Types.ContractDetails.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Types_Player_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Types_Player_EventId"></a> EventId

```csharp
public EEvent EventId { get; set; }
```

#### Property Value

 [EEvent](Divine.Protobufs.Dota2.EEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Types_Player_GuildId"></a> GuildId

```csharp
public uint GuildId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Types_Player_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Types_Player_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Types_Player_HasGuildId"></a> HasGuildId

```csharp
public bool HasGuildId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Types_Player_Parser"></a> Parser

```csharp
public static MessageParser<CMsgServerToGCGetGuildContractsResponse.Types.Player> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgServerToGCGetGuildContractsResponse](Divine.Protobufs.Dota2.CMsgServerToGCGetGuildContractsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgServerToGCGetGuildContractsResponse.Types.md).[Player](Divine.Protobufs.Dota2.CMsgServerToGCGetGuildContractsResponse.Types.Player.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Types_Player_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Types_Player_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Types_Player_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Types_Player_ClearGuildId"></a> ClearGuildId\(\)

```csharp
public void ClearGuildId()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Types_Player_Clone"></a> Clone\(\)

```csharp
public CMsgServerToGCGetGuildContractsResponse.Types.Player Clone()
```

#### Returns

 [CMsgServerToGCGetGuildContractsResponse](Divine.Protobufs.Dota2.CMsgServerToGCGetGuildContractsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgServerToGCGetGuildContractsResponse.Types.md).[Player](Divine.Protobufs.Dota2.CMsgServerToGCGetGuildContractsResponse.Types.Player.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Types_Player_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Types_Player_Equals_Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Types_Player_"></a> Equals\(Player\)

```csharp
public bool Equals(CMsgServerToGCGetGuildContractsResponse.Types.Player other)
```

#### Parameters

`other` [CMsgServerToGCGetGuildContractsResponse](Divine.Protobufs.Dota2.CMsgServerToGCGetGuildContractsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgServerToGCGetGuildContractsResponse.Types.md).[Player](Divine.Protobufs.Dota2.CMsgServerToGCGetGuildContractsResponse.Types.Player.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Types_Player_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Types_Player_MergeFrom_Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Types_Player_"></a> MergeFrom\(Player\)

```csharp
public void MergeFrom(CMsgServerToGCGetGuildContractsResponse.Types.Player other)
```

#### Parameters

`other` [CMsgServerToGCGetGuildContractsResponse](Divine.Protobufs.Dota2.CMsgServerToGCGetGuildContractsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgServerToGCGetGuildContractsResponse.Types.md).[Player](Divine.Protobufs.Dota2.CMsgServerToGCGetGuildContractsResponse.Types.Player.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Types_Player_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Types_Player_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Types_Player_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

