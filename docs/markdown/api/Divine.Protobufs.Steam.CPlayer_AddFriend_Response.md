# <a id="Divine_Protobufs_Steam_CPlayer_AddFriend_Response"></a> Class CPlayer\_AddFriend\_Response

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CPlayer_AddFriend_Response : IMessage<CPlayer_AddFriend_Response>, IEquatable<CPlayer_AddFriend_Response>, IDeepCloneable<CPlayer_AddFriend_Response>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CPlayer\_AddFriend\_Response](Divine.Protobufs.Steam.CPlayer\_AddFriend\_Response.md)

#### Implements

IMessage<CPlayer\_AddFriend\_Response\>, 
[IEquatable<CPlayer\_AddFriend\_Response\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CPlayer\_AddFriend\_Response\>, 
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
[EnumerableExtensions.In<CPlayer\_AddFriend\_Response\>\(CPlayer\_AddFriend\_Response, params CPlayer\_AddFriend\_Response\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CPlayer_AddFriend_Response__ctor"></a> CPlayer\_AddFriend\_Response\(\)

```csharp
public CPlayer_AddFriend_Response()
```

### <a id="Divine_Protobufs_Steam_CPlayer_AddFriend_Response__ctor_Divine_Protobufs_Steam_CPlayer_AddFriend_Response_"></a> CPlayer\_AddFriend\_Response\(CPlayer\_AddFriend\_Response\)

```csharp
public CPlayer_AddFriend_Response(CPlayer_AddFriend_Response other)
```

#### Parameters

`other` [CPlayer\_AddFriend\_Response](Divine.Protobufs.Steam.CPlayer\_AddFriend\_Response.md)

## Fields

### <a id="Divine_Protobufs_Steam_CPlayer_AddFriend_Response_FriendRelationshipFieldNumber"></a> FriendRelationshipFieldNumber

```csharp
public const int FriendRelationshipFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPlayer_AddFriend_Response_InviteSentFieldNumber"></a> InviteSentFieldNumber

```csharp
public const int InviteSentFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CPlayer_AddFriend_Response_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CPlayer_AddFriend_Response_FriendRelationship"></a> FriendRelationship

```csharp
public uint FriendRelationship { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CPlayer_AddFriend_Response_HasFriendRelationship"></a> HasFriendRelationship

```csharp
public bool HasFriendRelationship { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPlayer_AddFriend_Response_HasInviteSent"></a> HasInviteSent

```csharp
public bool HasInviteSent { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPlayer_AddFriend_Response_InviteSent"></a> InviteSent

```csharp
public bool InviteSent { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPlayer_AddFriend_Response_Parser"></a> Parser

```csharp
public static MessageParser<CPlayer_AddFriend_Response> Parser { get; }
```

#### Property Value

 MessageParser<[CPlayer\_AddFriend\_Response](Divine.Protobufs.Steam.CPlayer\_AddFriend\_Response.md)\>

## Methods

### <a id="Divine_Protobufs_Steam_CPlayer_AddFriend_Response_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPlayer_AddFriend_Response_ClearFriendRelationship"></a> ClearFriendRelationship\(\)

```csharp
public void ClearFriendRelationship()
```

### <a id="Divine_Protobufs_Steam_CPlayer_AddFriend_Response_ClearInviteSent"></a> ClearInviteSent\(\)

```csharp
public void ClearInviteSent()
```

### <a id="Divine_Protobufs_Steam_CPlayer_AddFriend_Response_Clone"></a> Clone\(\)

```csharp
public CPlayer_AddFriend_Response Clone()
```

#### Returns

 [CPlayer\_AddFriend\_Response](Divine.Protobufs.Steam.CPlayer\_AddFriend\_Response.md)

### <a id="Divine_Protobufs_Steam_CPlayer_AddFriend_Response_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPlayer_AddFriend_Response_Equals_Divine_Protobufs_Steam_CPlayer_AddFriend_Response_"></a> Equals\(CPlayer\_AddFriend\_Response\)

```csharp
public bool Equals(CPlayer_AddFriend_Response other)
```

#### Parameters

`other` [CPlayer\_AddFriend\_Response](Divine.Protobufs.Steam.CPlayer\_AddFriend\_Response.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPlayer_AddFriend_Response_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPlayer_AddFriend_Response_MergeFrom_Divine_Protobufs_Steam_CPlayer_AddFriend_Response_"></a> MergeFrom\(CPlayer\_AddFriend\_Response\)

```csharp
public void MergeFrom(CPlayer_AddFriend_Response other)
```

#### Parameters

`other` [CPlayer\_AddFriend\_Response](Divine.Protobufs.Steam.CPlayer\_AddFriend\_Response.md)

### <a id="Divine_Protobufs_Steam_CPlayer_AddFriend_Response_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CPlayer_AddFriend_Response_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CPlayer_AddFriend_Response_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

