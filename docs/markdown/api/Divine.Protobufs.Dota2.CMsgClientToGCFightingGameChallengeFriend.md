# <a id="Divine_Protobufs_Dota2_CMsgClientToGCFightingGameChallengeFriend"></a> Class CMsgClientToGCFightingGameChallengeFriend

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCFightingGameChallengeFriend : IMessage<CMsgClientToGCFightingGameChallengeFriend>, IEquatable<CMsgClientToGCFightingGameChallengeFriend>, IDeepCloneable<CMsgClientToGCFightingGameChallengeFriend>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCFightingGameChallengeFriend](Divine.Protobufs.Dota2.CMsgClientToGCFightingGameChallengeFriend.md)

#### Implements

IMessage<CMsgClientToGCFightingGameChallengeFriend\>, 
[IEquatable<CMsgClientToGCFightingGameChallengeFriend\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCFightingGameChallengeFriend\>, 
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
[EnumerableExtensions.In<CMsgClientToGCFightingGameChallengeFriend\>\(CMsgClientToGCFightingGameChallengeFriend, params CMsgClientToGCFightingGameChallengeFriend\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFightingGameChallengeFriend__ctor"></a> CMsgClientToGCFightingGameChallengeFriend\(\)

```csharp
public CMsgClientToGCFightingGameChallengeFriend()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFightingGameChallengeFriend__ctor_Divine_Protobufs_Dota2_CMsgClientToGCFightingGameChallengeFriend_"></a> CMsgClientToGCFightingGameChallengeFriend\(CMsgClientToGCFightingGameChallengeFriend\)

```csharp
public CMsgClientToGCFightingGameChallengeFriend(CMsgClientToGCFightingGameChallengeFriend other)
```

#### Parameters

`other` [CMsgClientToGCFightingGameChallengeFriend](Divine.Protobufs.Dota2.CMsgClientToGCFightingGameChallengeFriend.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFightingGameChallengeFriend_FriendAccountIdFieldNumber"></a> FriendAccountIdFieldNumber

```csharp
public const int FriendAccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFightingGameChallengeFriend_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFightingGameChallengeFriend_FriendAccountId"></a> FriendAccountId

```csharp
public uint FriendAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFightingGameChallengeFriend_HasFriendAccountId"></a> HasFriendAccountId

```csharp
public bool HasFriendAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFightingGameChallengeFriend_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCFightingGameChallengeFriend> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCFightingGameChallengeFriend](Divine.Protobufs.Dota2.CMsgClientToGCFightingGameChallengeFriend.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFightingGameChallengeFriend_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFightingGameChallengeFriend_ClearFriendAccountId"></a> ClearFriendAccountId\(\)

```csharp
public void ClearFriendAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFightingGameChallengeFriend_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCFightingGameChallengeFriend Clone()
```

#### Returns

 [CMsgClientToGCFightingGameChallengeFriend](Divine.Protobufs.Dota2.CMsgClientToGCFightingGameChallengeFriend.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFightingGameChallengeFriend_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFightingGameChallengeFriend_Equals_Divine_Protobufs_Dota2_CMsgClientToGCFightingGameChallengeFriend_"></a> Equals\(CMsgClientToGCFightingGameChallengeFriend\)

```csharp
public bool Equals(CMsgClientToGCFightingGameChallengeFriend other)
```

#### Parameters

`other` [CMsgClientToGCFightingGameChallengeFriend](Divine.Protobufs.Dota2.CMsgClientToGCFightingGameChallengeFriend.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFightingGameChallengeFriend_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFightingGameChallengeFriend_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCFightingGameChallengeFriend_"></a> MergeFrom\(CMsgClientToGCFightingGameChallengeFriend\)

```csharp
public void MergeFrom(CMsgClientToGCFightingGameChallengeFriend other)
```

#### Parameters

`other` [CMsgClientToGCFightingGameChallengeFriend](Divine.Protobufs.Dota2.CMsgClientToGCFightingGameChallengeFriend.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFightingGameChallengeFriend_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFightingGameChallengeFriend_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFightingGameChallengeFriend_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

