# <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyRichPresence"></a> Class CMsgDOTALobbyRichPresence

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTALobbyRichPresence : IMessage<CMsgDOTALobbyRichPresence>, IEquatable<CMsgDOTALobbyRichPresence>, IDeepCloneable<CMsgDOTALobbyRichPresence>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTALobbyRichPresence](Divine.Protobufs.Dota2.CMsgDOTALobbyRichPresence.md)

#### Implements

IMessage<CMsgDOTALobbyRichPresence\>, 
[IEquatable<CMsgDOTALobbyRichPresence\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTALobbyRichPresence\>, 
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
[EnumerableExtensions.In<CMsgDOTALobbyRichPresence\>\(CMsgDOTALobbyRichPresence, params CMsgDOTALobbyRichPresence\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyRichPresence__ctor"></a> CMsgDOTALobbyRichPresence\(\)

```csharp
public CMsgDOTALobbyRichPresence()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyRichPresence__ctor_Divine_Protobufs_Dota2_CMsgDOTALobbyRichPresence_"></a> CMsgDOTALobbyRichPresence\(CMsgDOTALobbyRichPresence\)

```csharp
public CMsgDOTALobbyRichPresence(CMsgDOTALobbyRichPresence other)
```

#### Parameters

`other` [CMsgDOTALobbyRichPresence](Divine.Protobufs.Dota2.CMsgDOTALobbyRichPresence.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyRichPresence_CustomGameIdFieldNumber"></a> CustomGameIdFieldNumber

```csharp
public const int CustomGameIdFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyRichPresence_GameModeFieldNumber"></a> GameModeFieldNumber

```csharp
public const int GameModeFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyRichPresence_LobbyIdFieldNumber"></a> LobbyIdFieldNumber

```csharp
public const int LobbyIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyRichPresence_LobbyStateFieldNumber"></a> LobbyStateFieldNumber

```csharp
public const int LobbyStateFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyRichPresence_LobbyTypeFieldNumber"></a> LobbyTypeFieldNumber

```csharp
public const int LobbyTypeFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyRichPresence_MaxMemberCountFieldNumber"></a> MaxMemberCountFieldNumber

```csharp
public const int MaxMemberCountFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyRichPresence_MemberCountFieldNumber"></a> MemberCountFieldNumber

```csharp
public const int MemberCountFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyRichPresence_NameFieldNumber"></a> NameFieldNumber

```csharp
public const int NameFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyRichPresence_PasswordFieldNumber"></a> PasswordFieldNumber

```csharp
public const int PasswordFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyRichPresence_CustomGameId"></a> CustomGameId

```csharp
public ulong CustomGameId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyRichPresence_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyRichPresence_GameMode"></a> GameMode

```csharp
public DOTA_GameMode GameMode { get; set; }
```

#### Property Value

 [DOTA\_GameMode](Divine.Protobufs.Dota2.DOTA\_GameMode.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyRichPresence_HasCustomGameId"></a> HasCustomGameId

```csharp
public bool HasCustomGameId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyRichPresence_HasGameMode"></a> HasGameMode

```csharp
public bool HasGameMode { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyRichPresence_HasLobbyId"></a> HasLobbyId

```csharp
public bool HasLobbyId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyRichPresence_HasLobbyState"></a> HasLobbyState

```csharp
public bool HasLobbyState { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyRichPresence_HasLobbyType"></a> HasLobbyType

```csharp
public bool HasLobbyType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyRichPresence_HasMaxMemberCount"></a> HasMaxMemberCount

```csharp
public bool HasMaxMemberCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyRichPresence_HasMemberCount"></a> HasMemberCount

```csharp
public bool HasMemberCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyRichPresence_HasName"></a> HasName

```csharp
public bool HasName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyRichPresence_HasPassword"></a> HasPassword

```csharp
public bool HasPassword { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyRichPresence_LobbyId"></a> LobbyId

```csharp
public ulong LobbyId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyRichPresence_LobbyState"></a> LobbyState

```csharp
public CSODOTALobby.Types.State LobbyState { get; set; }
```

#### Property Value

 [CSODOTALobby](Divine.Protobufs.Dota2.CSODOTALobby.md).[Types](Divine.Protobufs.Dota2.CSODOTALobby.Types.md).[State](Divine.Protobufs.Dota2.CSODOTALobby.Types.State.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyRichPresence_LobbyType"></a> LobbyType

```csharp
public uint LobbyType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyRichPresence_MaxMemberCount"></a> MaxMemberCount

```csharp
public uint MaxMemberCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyRichPresence_MemberCount"></a> MemberCount

```csharp
public uint MemberCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyRichPresence_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyRichPresence_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTALobbyRichPresence> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTALobbyRichPresence](Divine.Protobufs.Dota2.CMsgDOTALobbyRichPresence.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyRichPresence_Password"></a> Password

```csharp
public bool Password { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyRichPresence_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyRichPresence_ClearCustomGameId"></a> ClearCustomGameId\(\)

```csharp
public void ClearCustomGameId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyRichPresence_ClearGameMode"></a> ClearGameMode\(\)

```csharp
public void ClearGameMode()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyRichPresence_ClearLobbyId"></a> ClearLobbyId\(\)

```csharp
public void ClearLobbyId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyRichPresence_ClearLobbyState"></a> ClearLobbyState\(\)

```csharp
public void ClearLobbyState()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyRichPresence_ClearLobbyType"></a> ClearLobbyType\(\)

```csharp
public void ClearLobbyType()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyRichPresence_ClearMaxMemberCount"></a> ClearMaxMemberCount\(\)

```csharp
public void ClearMaxMemberCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyRichPresence_ClearMemberCount"></a> ClearMemberCount\(\)

```csharp
public void ClearMemberCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyRichPresence_ClearName"></a> ClearName\(\)

```csharp
public void ClearName()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyRichPresence_ClearPassword"></a> ClearPassword\(\)

```csharp
public void ClearPassword()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyRichPresence_Clone"></a> Clone\(\)

```csharp
public CMsgDOTALobbyRichPresence Clone()
```

#### Returns

 [CMsgDOTALobbyRichPresence](Divine.Protobufs.Dota2.CMsgDOTALobbyRichPresence.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyRichPresence_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyRichPresence_Equals_Divine_Protobufs_Dota2_CMsgDOTALobbyRichPresence_"></a> Equals\(CMsgDOTALobbyRichPresence\)

```csharp
public bool Equals(CMsgDOTALobbyRichPresence other)
```

#### Parameters

`other` [CMsgDOTALobbyRichPresence](Divine.Protobufs.Dota2.CMsgDOTALobbyRichPresence.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyRichPresence_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyRichPresence_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTALobbyRichPresence_"></a> MergeFrom\(CMsgDOTALobbyRichPresence\)

```csharp
public void MergeFrom(CMsgDOTALobbyRichPresence other)
```

#### Parameters

`other` [CMsgDOTALobbyRichPresence](Divine.Protobufs.Dota2.CMsgDOTALobbyRichPresence.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyRichPresence_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyRichPresence_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyRichPresence_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

