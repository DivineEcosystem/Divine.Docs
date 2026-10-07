# <a id="Divine_Protobufs_Dota2_CMsgClientToGCRespondToCoachFriendRequest"></a> Class CMsgClientToGCRespondToCoachFriendRequest

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCRespondToCoachFriendRequest : IMessage<CMsgClientToGCRespondToCoachFriendRequest>, IEquatable<CMsgClientToGCRespondToCoachFriendRequest>, IDeepCloneable<CMsgClientToGCRespondToCoachFriendRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCRespondToCoachFriendRequest](Divine.Protobufs.Dota2.CMsgClientToGCRespondToCoachFriendRequest.md)

#### Implements

IMessage<CMsgClientToGCRespondToCoachFriendRequest\>, 
[IEquatable<CMsgClientToGCRespondToCoachFriendRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCRespondToCoachFriendRequest\>, 
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
[EnumerableExtensions.In<CMsgClientToGCRespondToCoachFriendRequest\>\(CMsgClientToGCRespondToCoachFriendRequest, params CMsgClientToGCRespondToCoachFriendRequest\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRespondToCoachFriendRequest__ctor"></a> CMsgClientToGCRespondToCoachFriendRequest\(\)

```csharp
public CMsgClientToGCRespondToCoachFriendRequest()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRespondToCoachFriendRequest__ctor_Divine_Protobufs_Dota2_CMsgClientToGCRespondToCoachFriendRequest_"></a> CMsgClientToGCRespondToCoachFriendRequest\(CMsgClientToGCRespondToCoachFriendRequest\)

```csharp
public CMsgClientToGCRespondToCoachFriendRequest(CMsgClientToGCRespondToCoachFriendRequest other)
```

#### Parameters

`other` [CMsgClientToGCRespondToCoachFriendRequest](Divine.Protobufs.Dota2.CMsgClientToGCRespondToCoachFriendRequest.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRespondToCoachFriendRequest_CoachAccountIdFieldNumber"></a> CoachAccountIdFieldNumber

```csharp
public const int CoachAccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRespondToCoachFriendRequest_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRespondToCoachFriendRequest_CoachAccountId"></a> CoachAccountId

```csharp
public uint CoachAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRespondToCoachFriendRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRespondToCoachFriendRequest_HasCoachAccountId"></a> HasCoachAccountId

```csharp
public bool HasCoachAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRespondToCoachFriendRequest_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRespondToCoachFriendRequest_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCRespondToCoachFriendRequest> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCRespondToCoachFriendRequest](Divine.Protobufs.Dota2.CMsgClientToGCRespondToCoachFriendRequest.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRespondToCoachFriendRequest_Response"></a> Response

```csharp
public ELobbyMemberCoachRequestState Response { get; set; }
```

#### Property Value

 [ELobbyMemberCoachRequestState](Divine.Protobufs.Dota2.ELobbyMemberCoachRequestState.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRespondToCoachFriendRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRespondToCoachFriendRequest_ClearCoachAccountId"></a> ClearCoachAccountId\(\)

```csharp
public void ClearCoachAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRespondToCoachFriendRequest_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRespondToCoachFriendRequest_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCRespondToCoachFriendRequest Clone()
```

#### Returns

 [CMsgClientToGCRespondToCoachFriendRequest](Divine.Protobufs.Dota2.CMsgClientToGCRespondToCoachFriendRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRespondToCoachFriendRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRespondToCoachFriendRequest_Equals_Divine_Protobufs_Dota2_CMsgClientToGCRespondToCoachFriendRequest_"></a> Equals\(CMsgClientToGCRespondToCoachFriendRequest\)

```csharp
public bool Equals(CMsgClientToGCRespondToCoachFriendRequest other)
```

#### Parameters

`other` [CMsgClientToGCRespondToCoachFriendRequest](Divine.Protobufs.Dota2.CMsgClientToGCRespondToCoachFriendRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRespondToCoachFriendRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRespondToCoachFriendRequest_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCRespondToCoachFriendRequest_"></a> MergeFrom\(CMsgClientToGCRespondToCoachFriendRequest\)

```csharp
public void MergeFrom(CMsgClientToGCRespondToCoachFriendRequest other)
```

#### Parameters

`other` [CMsgClientToGCRespondToCoachFriendRequest](Divine.Protobufs.Dota2.CMsgClientToGCRespondToCoachFriendRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRespondToCoachFriendRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRespondToCoachFriendRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRespondToCoachFriendRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

