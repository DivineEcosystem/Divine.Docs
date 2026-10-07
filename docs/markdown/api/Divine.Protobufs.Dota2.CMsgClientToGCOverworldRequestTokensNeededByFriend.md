# <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestTokensNeededByFriend"></a> Class CMsgClientToGCOverworldRequestTokensNeededByFriend

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCOverworldRequestTokensNeededByFriend : IMessage<CMsgClientToGCOverworldRequestTokensNeededByFriend>, IEquatable<CMsgClientToGCOverworldRequestTokensNeededByFriend>, IDeepCloneable<CMsgClientToGCOverworldRequestTokensNeededByFriend>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCOverworldRequestTokensNeededByFriend](Divine.Protobufs.Dota2.CMsgClientToGCOverworldRequestTokensNeededByFriend.md)

#### Implements

IMessage<CMsgClientToGCOverworldRequestTokensNeededByFriend\>, 
[IEquatable<CMsgClientToGCOverworldRequestTokensNeededByFriend\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCOverworldRequestTokensNeededByFriend\>, 
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
[EnumerableExtensions.In<CMsgClientToGCOverworldRequestTokensNeededByFriend\>\(CMsgClientToGCOverworldRequestTokensNeededByFriend, params CMsgClientToGCOverworldRequestTokensNeededByFriend\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestTokensNeededByFriend__ctor"></a> CMsgClientToGCOverworldRequestTokensNeededByFriend\(\)

```csharp
public CMsgClientToGCOverworldRequestTokensNeededByFriend()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestTokensNeededByFriend__ctor_Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestTokensNeededByFriend_"></a> CMsgClientToGCOverworldRequestTokensNeededByFriend\(CMsgClientToGCOverworldRequestTokensNeededByFriend\)

```csharp
public CMsgClientToGCOverworldRequestTokensNeededByFriend(CMsgClientToGCOverworldRequestTokensNeededByFriend other)
```

#### Parameters

`other` [CMsgClientToGCOverworldRequestTokensNeededByFriend](Divine.Protobufs.Dota2.CMsgClientToGCOverworldRequestTokensNeededByFriend.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestTokensNeededByFriend_FriendAccountIdFieldNumber"></a> FriendAccountIdFieldNumber

```csharp
public const int FriendAccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestTokensNeededByFriend_OverworldIdFieldNumber"></a> OverworldIdFieldNumber

```csharp
public const int OverworldIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestTokensNeededByFriend_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestTokensNeededByFriend_FriendAccountId"></a> FriendAccountId

```csharp
public uint FriendAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestTokensNeededByFriend_HasFriendAccountId"></a> HasFriendAccountId

```csharp
public bool HasFriendAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestTokensNeededByFriend_HasOverworldId"></a> HasOverworldId

```csharp
public bool HasOverworldId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestTokensNeededByFriend_OverworldId"></a> OverworldId

```csharp
public uint OverworldId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestTokensNeededByFriend_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCOverworldRequestTokensNeededByFriend> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCOverworldRequestTokensNeededByFriend](Divine.Protobufs.Dota2.CMsgClientToGCOverworldRequestTokensNeededByFriend.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestTokensNeededByFriend_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestTokensNeededByFriend_ClearFriendAccountId"></a> ClearFriendAccountId\(\)

```csharp
public void ClearFriendAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestTokensNeededByFriend_ClearOverworldId"></a> ClearOverworldId\(\)

```csharp
public void ClearOverworldId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestTokensNeededByFriend_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCOverworldRequestTokensNeededByFriend Clone()
```

#### Returns

 [CMsgClientToGCOverworldRequestTokensNeededByFriend](Divine.Protobufs.Dota2.CMsgClientToGCOverworldRequestTokensNeededByFriend.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestTokensNeededByFriend_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestTokensNeededByFriend_Equals_Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestTokensNeededByFriend_"></a> Equals\(CMsgClientToGCOverworldRequestTokensNeededByFriend\)

```csharp
public bool Equals(CMsgClientToGCOverworldRequestTokensNeededByFriend other)
```

#### Parameters

`other` [CMsgClientToGCOverworldRequestTokensNeededByFriend](Divine.Protobufs.Dota2.CMsgClientToGCOverworldRequestTokensNeededByFriend.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestTokensNeededByFriend_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestTokensNeededByFriend_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestTokensNeededByFriend_"></a> MergeFrom\(CMsgClientToGCOverworldRequestTokensNeededByFriend\)

```csharp
public void MergeFrom(CMsgClientToGCOverworldRequestTokensNeededByFriend other)
```

#### Parameters

`other` [CMsgClientToGCOverworldRequestTokensNeededByFriend](Divine.Protobufs.Dota2.CMsgClientToGCOverworldRequestTokensNeededByFriend.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestTokensNeededByFriend_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestTokensNeededByFriend_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldRequestTokensNeededByFriend_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

