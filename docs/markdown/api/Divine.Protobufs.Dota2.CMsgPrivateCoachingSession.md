# <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSession"></a> Class CMsgPrivateCoachingSession

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgPrivateCoachingSession : IMessage<CMsgPrivateCoachingSession>, IEquatable<CMsgPrivateCoachingSession>, IDeepCloneable<CMsgPrivateCoachingSession>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgPrivateCoachingSession](Divine.Protobufs.Dota2.CMsgPrivateCoachingSession.md)

#### Implements

IMessage<CMsgPrivateCoachingSession\>, 
[IEquatable<CMsgPrivateCoachingSession\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgPrivateCoachingSession\>, 
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
[EnumerableExtensions.In<CMsgPrivateCoachingSession\>\(CMsgPrivateCoachingSession, params CMsgPrivateCoachingSession\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSession__ctor"></a> CMsgPrivateCoachingSession\(\)

```csharp
public CMsgPrivateCoachingSession()
```

### <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSession__ctor_Divine_Protobufs_Dota2_CMsgPrivateCoachingSession_"></a> CMsgPrivateCoachingSession\(CMsgPrivateCoachingSession\)

```csharp
public CMsgPrivateCoachingSession(CMsgPrivateCoachingSession other)
```

#### Parameters

`other` [CMsgPrivateCoachingSession](Divine.Protobufs.Dota2.CMsgPrivateCoachingSession.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSession_AcceptedTimestampFieldNumber"></a> AcceptedTimestampFieldNumber

```csharp
public const int AcceptedTimestampFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSession_CoachingSessionStateFieldNumber"></a> CoachingSessionStateFieldNumber

```csharp
public const int CoachingSessionStateFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSession_CompletedTimestampFieldNumber"></a> CompletedTimestampFieldNumber

```csharp
public const int CompletedTimestampFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSession_CurrentLobbyIdFieldNumber"></a> CurrentLobbyIdFieldNumber

```csharp
public const int CurrentLobbyIdFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSession_CurrentServerSteamIdFieldNumber"></a> CurrentServerSteamIdFieldNumber

```csharp
public const int CurrentServerSteamIdFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSession_PrivateCoachingSessionIdFieldNumber"></a> PrivateCoachingSessionIdFieldNumber

```csharp
public const int PrivateCoachingSessionIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSession_RequestedLanguageFieldNumber"></a> RequestedLanguageFieldNumber

```csharp
public const int RequestedLanguageFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSession_RequestedTimestampFieldNumber"></a> RequestedTimestampFieldNumber

```csharp
public const int RequestedTimestampFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSession_SessionMembersFieldNumber"></a> SessionMembersFieldNumber

```csharp
public const int SessionMembersFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSession_AcceptedTimestamp"></a> AcceptedTimestamp

```csharp
public uint AcceptedTimestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSession_CoachingSessionState"></a> CoachingSessionState

```csharp
public EPrivateCoachingSessionState CoachingSessionState { get; set; }
```

#### Property Value

 [EPrivateCoachingSessionState](Divine.Protobufs.Dota2.EPrivateCoachingSessionState.md)

### <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSession_CompletedTimestamp"></a> CompletedTimestamp

```csharp
public uint CompletedTimestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSession_CurrentLobbyId"></a> CurrentLobbyId

```csharp
public ulong CurrentLobbyId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSession_CurrentServerSteamId"></a> CurrentServerSteamId

```csharp
public ulong CurrentServerSteamId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSession_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSession_HasAcceptedTimestamp"></a> HasAcceptedTimestamp

```csharp
public bool HasAcceptedTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSession_HasCoachingSessionState"></a> HasCoachingSessionState

```csharp
public bool HasCoachingSessionState { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSession_HasCompletedTimestamp"></a> HasCompletedTimestamp

```csharp
public bool HasCompletedTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSession_HasCurrentLobbyId"></a> HasCurrentLobbyId

```csharp
public bool HasCurrentLobbyId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSession_HasCurrentServerSteamId"></a> HasCurrentServerSteamId

```csharp
public bool HasCurrentServerSteamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSession_HasPrivateCoachingSessionId"></a> HasPrivateCoachingSessionId

```csharp
public bool HasPrivateCoachingSessionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSession_HasRequestedLanguage"></a> HasRequestedLanguage

```csharp
public bool HasRequestedLanguage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSession_HasRequestedTimestamp"></a> HasRequestedTimestamp

```csharp
public bool HasRequestedTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSession_Parser"></a> Parser

```csharp
public static MessageParser<CMsgPrivateCoachingSession> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgPrivateCoachingSession](Divine.Protobufs.Dota2.CMsgPrivateCoachingSession.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSession_PrivateCoachingSessionId"></a> PrivateCoachingSessionId

```csharp
public ulong PrivateCoachingSessionId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSession_RequestedLanguage"></a> RequestedLanguage

```csharp
public uint RequestedLanguage { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSession_RequestedTimestamp"></a> RequestedTimestamp

```csharp
public uint RequestedTimestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSession_SessionMembers"></a> SessionMembers

```csharp
public RepeatedField<CMsgPrivateCoachingSessionMember> SessionMembers { get; }
```

#### Property Value

 RepeatedField<[CMsgPrivateCoachingSessionMember](Divine.Protobufs.Dota2.CMsgPrivateCoachingSessionMember.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSession_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSession_ClearAcceptedTimestamp"></a> ClearAcceptedTimestamp\(\)

```csharp
public void ClearAcceptedTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSession_ClearCoachingSessionState"></a> ClearCoachingSessionState\(\)

```csharp
public void ClearCoachingSessionState()
```

### <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSession_ClearCompletedTimestamp"></a> ClearCompletedTimestamp\(\)

```csharp
public void ClearCompletedTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSession_ClearCurrentLobbyId"></a> ClearCurrentLobbyId\(\)

```csharp
public void ClearCurrentLobbyId()
```

### <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSession_ClearCurrentServerSteamId"></a> ClearCurrentServerSteamId\(\)

```csharp
public void ClearCurrentServerSteamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSession_ClearPrivateCoachingSessionId"></a> ClearPrivateCoachingSessionId\(\)

```csharp
public void ClearPrivateCoachingSessionId()
```

### <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSession_ClearRequestedLanguage"></a> ClearRequestedLanguage\(\)

```csharp
public void ClearRequestedLanguage()
```

### <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSession_ClearRequestedTimestamp"></a> ClearRequestedTimestamp\(\)

```csharp
public void ClearRequestedTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSession_Clone"></a> Clone\(\)

```csharp
public CMsgPrivateCoachingSession Clone()
```

#### Returns

 [CMsgPrivateCoachingSession](Divine.Protobufs.Dota2.CMsgPrivateCoachingSession.md)

### <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSession_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSession_Equals_Divine_Protobufs_Dota2_CMsgPrivateCoachingSession_"></a> Equals\(CMsgPrivateCoachingSession\)

```csharp
public bool Equals(CMsgPrivateCoachingSession other)
```

#### Parameters

`other` [CMsgPrivateCoachingSession](Divine.Protobufs.Dota2.CMsgPrivateCoachingSession.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSession_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSession_MergeFrom_Divine_Protobufs_Dota2_CMsgPrivateCoachingSession_"></a> MergeFrom\(CMsgPrivateCoachingSession\)

```csharp
public void MergeFrom(CMsgPrivateCoachingSession other)
```

#### Parameters

`other` [CMsgPrivateCoachingSession](Divine.Protobufs.Dota2.CMsgPrivateCoachingSession.md)

### <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSession_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSession_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgPrivateCoachingSession_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

