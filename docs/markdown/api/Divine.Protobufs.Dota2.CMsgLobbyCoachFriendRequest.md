# <a id="Divine_Protobufs_Dota2_CMsgLobbyCoachFriendRequest"></a> Class CMsgLobbyCoachFriendRequest

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgLobbyCoachFriendRequest : IMessage<CMsgLobbyCoachFriendRequest>, IEquatable<CMsgLobbyCoachFriendRequest>, IDeepCloneable<CMsgLobbyCoachFriendRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgLobbyCoachFriendRequest](Divine.Protobufs.Dota2.CMsgLobbyCoachFriendRequest.md)

#### Implements

IMessage<CMsgLobbyCoachFriendRequest\>, 
[IEquatable<CMsgLobbyCoachFriendRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgLobbyCoachFriendRequest\>, 
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
[EnumerableExtensions.In<CMsgLobbyCoachFriendRequest\>\(CMsgLobbyCoachFriendRequest, params CMsgLobbyCoachFriendRequest\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgLobbyCoachFriendRequest__ctor"></a> CMsgLobbyCoachFriendRequest\(\)

```csharp
public CMsgLobbyCoachFriendRequest()
```

### <a id="Divine_Protobufs_Dota2_CMsgLobbyCoachFriendRequest__ctor_Divine_Protobufs_Dota2_CMsgLobbyCoachFriendRequest_"></a> CMsgLobbyCoachFriendRequest\(CMsgLobbyCoachFriendRequest\)

```csharp
public CMsgLobbyCoachFriendRequest(CMsgLobbyCoachFriendRequest other)
```

#### Parameters

`other` [CMsgLobbyCoachFriendRequest](Divine.Protobufs.Dota2.CMsgLobbyCoachFriendRequest.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgLobbyCoachFriendRequest_CoachAccountIdFieldNumber"></a> CoachAccountIdFieldNumber

```csharp
public const int CoachAccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyCoachFriendRequest_PlayerAccountIdFieldNumber"></a> PlayerAccountIdFieldNumber

```csharp
public const int PlayerAccountIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyCoachFriendRequest_RequestStateFieldNumber"></a> RequestStateFieldNumber

```csharp
public const int RequestStateFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgLobbyCoachFriendRequest_CoachAccountId"></a> CoachAccountId

```csharp
public uint CoachAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyCoachFriendRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgLobbyCoachFriendRequest_HasCoachAccountId"></a> HasCoachAccountId

```csharp
public bool HasCoachAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyCoachFriendRequest_HasPlayerAccountId"></a> HasPlayerAccountId

```csharp
public bool HasPlayerAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyCoachFriendRequest_HasRequestState"></a> HasRequestState

```csharp
public bool HasRequestState { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyCoachFriendRequest_Parser"></a> Parser

```csharp
public static MessageParser<CMsgLobbyCoachFriendRequest> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgLobbyCoachFriendRequest](Divine.Protobufs.Dota2.CMsgLobbyCoachFriendRequest.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgLobbyCoachFriendRequest_PlayerAccountId"></a> PlayerAccountId

```csharp
public uint PlayerAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyCoachFriendRequest_RequestState"></a> RequestState

```csharp
public ELobbyMemberCoachRequestState RequestState { get; set; }
```

#### Property Value

 [ELobbyMemberCoachRequestState](Divine.Protobufs.Dota2.ELobbyMemberCoachRequestState.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgLobbyCoachFriendRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyCoachFriendRequest_ClearCoachAccountId"></a> ClearCoachAccountId\(\)

```csharp
public void ClearCoachAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgLobbyCoachFriendRequest_ClearPlayerAccountId"></a> ClearPlayerAccountId\(\)

```csharp
public void ClearPlayerAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgLobbyCoachFriendRequest_ClearRequestState"></a> ClearRequestState\(\)

```csharp
public void ClearRequestState()
```

### <a id="Divine_Protobufs_Dota2_CMsgLobbyCoachFriendRequest_Clone"></a> Clone\(\)

```csharp
public CMsgLobbyCoachFriendRequest Clone()
```

#### Returns

 [CMsgLobbyCoachFriendRequest](Divine.Protobufs.Dota2.CMsgLobbyCoachFriendRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyCoachFriendRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyCoachFriendRequest_Equals_Divine_Protobufs_Dota2_CMsgLobbyCoachFriendRequest_"></a> Equals\(CMsgLobbyCoachFriendRequest\)

```csharp
public bool Equals(CMsgLobbyCoachFriendRequest other)
```

#### Parameters

`other` [CMsgLobbyCoachFriendRequest](Divine.Protobufs.Dota2.CMsgLobbyCoachFriendRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyCoachFriendRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyCoachFriendRequest_MergeFrom_Divine_Protobufs_Dota2_CMsgLobbyCoachFriendRequest_"></a> MergeFrom\(CMsgLobbyCoachFriendRequest\)

```csharp
public void MergeFrom(CMsgLobbyCoachFriendRequest other)
```

#### Parameters

`other` [CMsgLobbyCoachFriendRequest](Divine.Protobufs.Dota2.CMsgLobbyCoachFriendRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyCoachFriendRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgLobbyCoachFriendRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyCoachFriendRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

