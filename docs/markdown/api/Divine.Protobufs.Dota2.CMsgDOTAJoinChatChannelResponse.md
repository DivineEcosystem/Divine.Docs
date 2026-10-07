# <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannelResponse"></a> Class CMsgDOTAJoinChatChannelResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAJoinChatChannelResponse : IMessage<CMsgDOTAJoinChatChannelResponse>, IEquatable<CMsgDOTAJoinChatChannelResponse>, IDeepCloneable<CMsgDOTAJoinChatChannelResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAJoinChatChannelResponse](Divine.Protobufs.Dota2.CMsgDOTAJoinChatChannelResponse.md)

#### Implements

IMessage<CMsgDOTAJoinChatChannelResponse\>, 
[IEquatable<CMsgDOTAJoinChatChannelResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAJoinChatChannelResponse\>, 
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
[EnumerableExtensions.In<CMsgDOTAJoinChatChannelResponse\>\(CMsgDOTAJoinChatChannelResponse, params CMsgDOTAJoinChatChannelResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannelResponse__ctor"></a> CMsgDOTAJoinChatChannelResponse\(\)

```csharp
public CMsgDOTAJoinChatChannelResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannelResponse__ctor_Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannelResponse_"></a> CMsgDOTAJoinChatChannelResponse\(CMsgDOTAJoinChatChannelResponse\)

```csharp
public CMsgDOTAJoinChatChannelResponse(CMsgDOTAJoinChatChannelResponse other)
```

#### Parameters

`other` [CMsgDOTAJoinChatChannelResponse](Divine.Protobufs.Dota2.CMsgDOTAJoinChatChannelResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannelResponse_ChannelIdFieldNumber"></a> ChannelIdFieldNumber

```csharp
public const int ChannelIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannelResponse_ChannelNameFieldNumber"></a> ChannelNameFieldNumber

```csharp
public const int ChannelNameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannelResponse_ChannelTypeFieldNumber"></a> ChannelTypeFieldNumber

```csharp
public const int ChannelTypeFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannelResponse_ChannelUserIdFieldNumber"></a> ChannelUserIdFieldNumber

```csharp
public const int ChannelUserIdFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannelResponse_GcInitiatedJoinFieldNumber"></a> GcInitiatedJoinFieldNumber

```csharp
public const int GcInitiatedJoinFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannelResponse_MaxMembersFieldNumber"></a> MaxMembersFieldNumber

```csharp
public const int MaxMembersFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannelResponse_MembersFieldNumber"></a> MembersFieldNumber

```csharp
public const int MembersFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannelResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannelResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannelResponse_SpecialPrivilegesFieldNumber"></a> SpecialPrivilegesFieldNumber

```csharp
public const int SpecialPrivilegesFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannelResponse_WelcomeMessageFieldNumber"></a> WelcomeMessageFieldNumber

```csharp
public const int WelcomeMessageFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannelResponse_ChannelId"></a> ChannelId

```csharp
public ulong ChannelId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannelResponse_ChannelName"></a> ChannelName

```csharp
public string ChannelName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannelResponse_ChannelType"></a> ChannelType

```csharp
public DOTAChatChannelType_t ChannelType { get; set; }
```

#### Property Value

 [DOTAChatChannelType\_t](Divine.Protobufs.Dota2.DOTAChatChannelType\_t.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannelResponse_ChannelUserId"></a> ChannelUserId

```csharp
public uint ChannelUserId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannelResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannelResponse_GcInitiatedJoin"></a> GcInitiatedJoin

```csharp
public bool GcInitiatedJoin { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannelResponse_HasChannelId"></a> HasChannelId

```csharp
public bool HasChannelId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannelResponse_HasChannelName"></a> HasChannelName

```csharp
public bool HasChannelName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannelResponse_HasChannelType"></a> HasChannelType

```csharp
public bool HasChannelType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannelResponse_HasChannelUserId"></a> HasChannelUserId

```csharp
public bool HasChannelUserId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannelResponse_HasGcInitiatedJoin"></a> HasGcInitiatedJoin

```csharp
public bool HasGcInitiatedJoin { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannelResponse_HasMaxMembers"></a> HasMaxMembers

```csharp
public bool HasMaxMembers { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannelResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannelResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannelResponse_HasSpecialPrivileges"></a> HasSpecialPrivileges

```csharp
public bool HasSpecialPrivileges { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannelResponse_HasWelcomeMessage"></a> HasWelcomeMessage

```csharp
public bool HasWelcomeMessage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannelResponse_MaxMembers"></a> MaxMembers

```csharp
public uint MaxMembers { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannelResponse_Members"></a> Members

```csharp
public RepeatedField<CMsgDOTAChatMember> Members { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTAChatMember](Divine.Protobufs.Dota2.CMsgDOTAChatMember.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannelResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAJoinChatChannelResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAJoinChatChannelResponse](Divine.Protobufs.Dota2.CMsgDOTAJoinChatChannelResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannelResponse_Response"></a> Response

```csharp
public uint Response { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannelResponse_Result"></a> Result

```csharp
public CMsgDOTAJoinChatChannelResponse.Types.Result Result { get; set; }
```

#### Property Value

 [CMsgDOTAJoinChatChannelResponse](Divine.Protobufs.Dota2.CMsgDOTAJoinChatChannelResponse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAJoinChatChannelResponse.Types.md).[Result](Divine.Protobufs.Dota2.CMsgDOTAJoinChatChannelResponse.Types.Result.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannelResponse_SpecialPrivileges"></a> SpecialPrivileges

```csharp
public EChatSpecialPrivileges SpecialPrivileges { get; set; }
```

#### Property Value

 [EChatSpecialPrivileges](Divine.Protobufs.Dota2.EChatSpecialPrivileges.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannelResponse_WelcomeMessage"></a> WelcomeMessage

```csharp
public string WelcomeMessage { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannelResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannelResponse_ClearChannelId"></a> ClearChannelId\(\)

```csharp
public void ClearChannelId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannelResponse_ClearChannelName"></a> ClearChannelName\(\)

```csharp
public void ClearChannelName()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannelResponse_ClearChannelType"></a> ClearChannelType\(\)

```csharp
public void ClearChannelType()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannelResponse_ClearChannelUserId"></a> ClearChannelUserId\(\)

```csharp
public void ClearChannelUserId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannelResponse_ClearGcInitiatedJoin"></a> ClearGcInitiatedJoin\(\)

```csharp
public void ClearGcInitiatedJoin()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannelResponse_ClearMaxMembers"></a> ClearMaxMembers\(\)

```csharp
public void ClearMaxMembers()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannelResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannelResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannelResponse_ClearSpecialPrivileges"></a> ClearSpecialPrivileges\(\)

```csharp
public void ClearSpecialPrivileges()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannelResponse_ClearWelcomeMessage"></a> ClearWelcomeMessage\(\)

```csharp
public void ClearWelcomeMessage()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannelResponse_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAJoinChatChannelResponse Clone()
```

#### Returns

 [CMsgDOTAJoinChatChannelResponse](Divine.Protobufs.Dota2.CMsgDOTAJoinChatChannelResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannelResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannelResponse_Equals_Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannelResponse_"></a> Equals\(CMsgDOTAJoinChatChannelResponse\)

```csharp
public bool Equals(CMsgDOTAJoinChatChannelResponse other)
```

#### Parameters

`other` [CMsgDOTAJoinChatChannelResponse](Divine.Protobufs.Dota2.CMsgDOTAJoinChatChannelResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannelResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannelResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannelResponse_"></a> MergeFrom\(CMsgDOTAJoinChatChannelResponse\)

```csharp
public void MergeFrom(CMsgDOTAJoinChatChannelResponse other)
```

#### Parameters

`other` [CMsgDOTAJoinChatChannelResponse](Divine.Protobufs.Dota2.CMsgDOTAJoinChatChannelResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannelResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannelResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAJoinChatChannelResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

