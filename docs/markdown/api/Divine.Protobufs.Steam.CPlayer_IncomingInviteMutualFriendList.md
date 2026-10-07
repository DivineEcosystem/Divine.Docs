# <a id="Divine_Protobufs_Steam_CPlayer_IncomingInviteMutualFriendList"></a> Class CPlayer\_IncomingInviteMutualFriendList

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CPlayer_IncomingInviteMutualFriendList : IMessage<CPlayer_IncomingInviteMutualFriendList>, IEquatable<CPlayer_IncomingInviteMutualFriendList>, IDeepCloneable<CPlayer_IncomingInviteMutualFriendList>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CPlayer\_IncomingInviteMutualFriendList](Divine.Protobufs.Steam.CPlayer\_IncomingInviteMutualFriendList.md)

#### Implements

IMessage<CPlayer\_IncomingInviteMutualFriendList\>, 
[IEquatable<CPlayer\_IncomingInviteMutualFriendList\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CPlayer\_IncomingInviteMutualFriendList\>, 
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
[EnumerableExtensions.In<CPlayer\_IncomingInviteMutualFriendList\>\(CPlayer\_IncomingInviteMutualFriendList, params CPlayer\_IncomingInviteMutualFriendList\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CPlayer_IncomingInviteMutualFriendList__ctor"></a> CPlayer\_IncomingInviteMutualFriendList\(\)

```csharp
public CPlayer_IncomingInviteMutualFriendList()
```

### <a id="Divine_Protobufs_Steam_CPlayer_IncomingInviteMutualFriendList__ctor_Divine_Protobufs_Steam_CPlayer_IncomingInviteMutualFriendList_"></a> CPlayer\_IncomingInviteMutualFriendList\(CPlayer\_IncomingInviteMutualFriendList\)

```csharp
public CPlayer_IncomingInviteMutualFriendList(CPlayer_IncomingInviteMutualFriendList other)
```

#### Parameters

`other` [CPlayer\_IncomingInviteMutualFriendList](Divine.Protobufs.Steam.CPlayer\_IncomingInviteMutualFriendList.md)

## Fields

### <a id="Divine_Protobufs_Steam_CPlayer_IncomingInviteMutualFriendList_MutualFriendAccountIdsFieldNumber"></a> MutualFriendAccountIdsFieldNumber

```csharp
public const int MutualFriendAccountIdsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPlayer_IncomingInviteMutualFriendList_SteamidFieldNumber"></a> SteamidFieldNumber

```csharp
public const int SteamidFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CPlayer_IncomingInviteMutualFriendList_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CPlayer_IncomingInviteMutualFriendList_HasSteamid"></a> HasSteamid

```csharp
public bool HasSteamid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPlayer_IncomingInviteMutualFriendList_MutualFriendAccountIds"></a> MutualFriendAccountIds

```csharp
public RepeatedField<uint> MutualFriendAccountIds { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Steam_CPlayer_IncomingInviteMutualFriendList_Parser"></a> Parser

```csharp
public static MessageParser<CPlayer_IncomingInviteMutualFriendList> Parser { get; }
```

#### Property Value

 MessageParser<[CPlayer\_IncomingInviteMutualFriendList](Divine.Protobufs.Steam.CPlayer\_IncomingInviteMutualFriendList.md)\>

### <a id="Divine_Protobufs_Steam_CPlayer_IncomingInviteMutualFriendList_Steamid"></a> Steamid

```csharp
public ulong Steamid { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Steam_CPlayer_IncomingInviteMutualFriendList_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPlayer_IncomingInviteMutualFriendList_ClearSteamid"></a> ClearSteamid\(\)

```csharp
public void ClearSteamid()
```

### <a id="Divine_Protobufs_Steam_CPlayer_IncomingInviteMutualFriendList_Clone"></a> Clone\(\)

```csharp
public CPlayer_IncomingInviteMutualFriendList Clone()
```

#### Returns

 [CPlayer\_IncomingInviteMutualFriendList](Divine.Protobufs.Steam.CPlayer\_IncomingInviteMutualFriendList.md)

### <a id="Divine_Protobufs_Steam_CPlayer_IncomingInviteMutualFriendList_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPlayer_IncomingInviteMutualFriendList_Equals_Divine_Protobufs_Steam_CPlayer_IncomingInviteMutualFriendList_"></a> Equals\(CPlayer\_IncomingInviteMutualFriendList\)

```csharp
public bool Equals(CPlayer_IncomingInviteMutualFriendList other)
```

#### Parameters

`other` [CPlayer\_IncomingInviteMutualFriendList](Divine.Protobufs.Steam.CPlayer\_IncomingInviteMutualFriendList.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPlayer_IncomingInviteMutualFriendList_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPlayer_IncomingInviteMutualFriendList_MergeFrom_Divine_Protobufs_Steam_CPlayer_IncomingInviteMutualFriendList_"></a> MergeFrom\(CPlayer\_IncomingInviteMutualFriendList\)

```csharp
public void MergeFrom(CPlayer_IncomingInviteMutualFriendList other)
```

#### Parameters

`other` [CPlayer\_IncomingInviteMutualFriendList](Divine.Protobufs.Steam.CPlayer\_IncomingInviteMutualFriendList.md)

### <a id="Divine_Protobufs_Steam_CPlayer_IncomingInviteMutualFriendList_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CPlayer_IncomingInviteMutualFriendList_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CPlayer_IncomingInviteMutualFriendList_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

