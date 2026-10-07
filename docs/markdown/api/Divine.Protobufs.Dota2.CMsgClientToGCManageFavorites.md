# <a id="Divine_Protobufs_Dota2_CMsgClientToGCManageFavorites"></a> Class CMsgClientToGCManageFavorites

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCManageFavorites : IMessage<CMsgClientToGCManageFavorites>, IEquatable<CMsgClientToGCManageFavorites>, IDeepCloneable<CMsgClientToGCManageFavorites>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCManageFavorites](Divine.Protobufs.Dota2.CMsgClientToGCManageFavorites.md)

#### Implements

IMessage<CMsgClientToGCManageFavorites\>, 
[IEquatable<CMsgClientToGCManageFavorites\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCManageFavorites\>, 
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
[EnumerableExtensions.In<CMsgClientToGCManageFavorites\>\(CMsgClientToGCManageFavorites, params CMsgClientToGCManageFavorites\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCManageFavorites__ctor"></a> CMsgClientToGCManageFavorites\(\)

```csharp
public CMsgClientToGCManageFavorites()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCManageFavorites__ctor_Divine_Protobufs_Dota2_CMsgClientToGCManageFavorites_"></a> CMsgClientToGCManageFavorites\(CMsgClientToGCManageFavorites\)

```csharp
public CMsgClientToGCManageFavorites(CMsgClientToGCManageFavorites other)
```

#### Parameters

`other` [CMsgClientToGCManageFavorites](Divine.Protobufs.Dota2.CMsgClientToGCManageFavorites.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCManageFavorites_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCManageFavorites_ActionFieldNumber"></a> ActionFieldNumber

```csharp
public const int ActionFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCManageFavorites_FavoriteNameFieldNumber"></a> FavoriteNameFieldNumber

```csharp
public const int FavoriteNameFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCManageFavorites_FromFriendlistFieldNumber"></a> FromFriendlistFieldNumber

```csharp
public const int FromFriendlistFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCManageFavorites_InviteResponseFieldNumber"></a> InviteResponseFieldNumber

```csharp
public const int InviteResponseFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCManageFavorites_LobbyIdFieldNumber"></a> LobbyIdFieldNumber

```csharp
public const int LobbyIdFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCManageFavorites_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCManageFavorites_Action"></a> Action

```csharp
public CMsgClientToGCManageFavorites.Types.Action Action { get; set; }
```

#### Property Value

 [CMsgClientToGCManageFavorites](Divine.Protobufs.Dota2.CMsgClientToGCManageFavorites.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCManageFavorites.Types.md).[Action](Divine.Protobufs.Dota2.CMsgClientToGCManageFavorites.Types.Action.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCManageFavorites_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCManageFavorites_FavoriteName"></a> FavoriteName

```csharp
public string FavoriteName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCManageFavorites_FromFriendlist"></a> FromFriendlist

```csharp
public bool FromFriendlist { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCManageFavorites_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCManageFavorites_HasAction"></a> HasAction

```csharp
public bool HasAction { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCManageFavorites_HasFavoriteName"></a> HasFavoriteName

```csharp
public bool HasFavoriteName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCManageFavorites_HasFromFriendlist"></a> HasFromFriendlist

```csharp
public bool HasFromFriendlist { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCManageFavorites_HasInviteResponse"></a> HasInviteResponse

```csharp
public bool HasInviteResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCManageFavorites_HasLobbyId"></a> HasLobbyId

```csharp
public bool HasLobbyId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCManageFavorites_InviteResponse"></a> InviteResponse

```csharp
public bool InviteResponse { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCManageFavorites_LobbyId"></a> LobbyId

```csharp
public ulong LobbyId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCManageFavorites_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCManageFavorites> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCManageFavorites](Divine.Protobufs.Dota2.CMsgClientToGCManageFavorites.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCManageFavorites_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCManageFavorites_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCManageFavorites_ClearAction"></a> ClearAction\(\)

```csharp
public void ClearAction()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCManageFavorites_ClearFavoriteName"></a> ClearFavoriteName\(\)

```csharp
public void ClearFavoriteName()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCManageFavorites_ClearFromFriendlist"></a> ClearFromFriendlist\(\)

```csharp
public void ClearFromFriendlist()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCManageFavorites_ClearInviteResponse"></a> ClearInviteResponse\(\)

```csharp
public void ClearInviteResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCManageFavorites_ClearLobbyId"></a> ClearLobbyId\(\)

```csharp
public void ClearLobbyId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCManageFavorites_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCManageFavorites Clone()
```

#### Returns

 [CMsgClientToGCManageFavorites](Divine.Protobufs.Dota2.CMsgClientToGCManageFavorites.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCManageFavorites_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCManageFavorites_Equals_Divine_Protobufs_Dota2_CMsgClientToGCManageFavorites_"></a> Equals\(CMsgClientToGCManageFavorites\)

```csharp
public bool Equals(CMsgClientToGCManageFavorites other)
```

#### Parameters

`other` [CMsgClientToGCManageFavorites](Divine.Protobufs.Dota2.CMsgClientToGCManageFavorites.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCManageFavorites_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCManageFavorites_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCManageFavorites_"></a> MergeFrom\(CMsgClientToGCManageFavorites\)

```csharp
public void MergeFrom(CMsgClientToGCManageFavorites other)
```

#### Parameters

`other` [CMsgClientToGCManageFavorites](Divine.Protobufs.Dota2.CMsgClientToGCManageFavorites.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCManageFavorites_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCManageFavorites_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCManageFavorites_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

