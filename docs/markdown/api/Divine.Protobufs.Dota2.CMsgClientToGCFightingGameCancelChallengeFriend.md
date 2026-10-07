# <a id="Divine_Protobufs_Dota2_CMsgClientToGCFightingGameCancelChallengeFriend"></a> Class CMsgClientToGCFightingGameCancelChallengeFriend

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCFightingGameCancelChallengeFriend : IMessage<CMsgClientToGCFightingGameCancelChallengeFriend>, IEquatable<CMsgClientToGCFightingGameCancelChallengeFriend>, IDeepCloneable<CMsgClientToGCFightingGameCancelChallengeFriend>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCFightingGameCancelChallengeFriend](Divine.Protobufs.Dota2.CMsgClientToGCFightingGameCancelChallengeFriend.md)

#### Implements

IMessage<CMsgClientToGCFightingGameCancelChallengeFriend\>, 
[IEquatable<CMsgClientToGCFightingGameCancelChallengeFriend\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCFightingGameCancelChallengeFriend\>, 
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
[EnumerableExtensions.In<CMsgClientToGCFightingGameCancelChallengeFriend\>\(CMsgClientToGCFightingGameCancelChallengeFriend, params CMsgClientToGCFightingGameCancelChallengeFriend\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFightingGameCancelChallengeFriend__ctor"></a> CMsgClientToGCFightingGameCancelChallengeFriend\(\)

```csharp
public CMsgClientToGCFightingGameCancelChallengeFriend()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFightingGameCancelChallengeFriend__ctor_Divine_Protobufs_Dota2_CMsgClientToGCFightingGameCancelChallengeFriend_"></a> CMsgClientToGCFightingGameCancelChallengeFriend\(CMsgClientToGCFightingGameCancelChallengeFriend\)

```csharp
public CMsgClientToGCFightingGameCancelChallengeFriend(CMsgClientToGCFightingGameCancelChallengeFriend other)
```

#### Parameters

`other` [CMsgClientToGCFightingGameCancelChallengeFriend](Divine.Protobufs.Dota2.CMsgClientToGCFightingGameCancelChallengeFriend.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFightingGameCancelChallengeFriend_FriendAccountIdFieldNumber"></a> FriendAccountIdFieldNumber

```csharp
public const int FriendAccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFightingGameCancelChallengeFriend_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFightingGameCancelChallengeFriend_FriendAccountId"></a> FriendAccountId

```csharp
public uint FriendAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFightingGameCancelChallengeFriend_HasFriendAccountId"></a> HasFriendAccountId

```csharp
public bool HasFriendAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFightingGameCancelChallengeFriend_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCFightingGameCancelChallengeFriend> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCFightingGameCancelChallengeFriend](Divine.Protobufs.Dota2.CMsgClientToGCFightingGameCancelChallengeFriend.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFightingGameCancelChallengeFriend_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFightingGameCancelChallengeFriend_ClearFriendAccountId"></a> ClearFriendAccountId\(\)

```csharp
public void ClearFriendAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFightingGameCancelChallengeFriend_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCFightingGameCancelChallengeFriend Clone()
```

#### Returns

 [CMsgClientToGCFightingGameCancelChallengeFriend](Divine.Protobufs.Dota2.CMsgClientToGCFightingGameCancelChallengeFriend.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFightingGameCancelChallengeFriend_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFightingGameCancelChallengeFriend_Equals_Divine_Protobufs_Dota2_CMsgClientToGCFightingGameCancelChallengeFriend_"></a> Equals\(CMsgClientToGCFightingGameCancelChallengeFriend\)

```csharp
public bool Equals(CMsgClientToGCFightingGameCancelChallengeFriend other)
```

#### Parameters

`other` [CMsgClientToGCFightingGameCancelChallengeFriend](Divine.Protobufs.Dota2.CMsgClientToGCFightingGameCancelChallengeFriend.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFightingGameCancelChallengeFriend_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFightingGameCancelChallengeFriend_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCFightingGameCancelChallengeFriend_"></a> MergeFrom\(CMsgClientToGCFightingGameCancelChallengeFriend\)

```csharp
public void MergeFrom(CMsgClientToGCFightingGameCancelChallengeFriend other)
```

#### Parameters

`other` [CMsgClientToGCFightingGameCancelChallengeFriend](Divine.Protobufs.Dota2.CMsgClientToGCFightingGameCancelChallengeFriend.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFightingGameCancelChallengeFriend_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFightingGameCancelChallengeFriend_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFightingGameCancelChallengeFriend_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

