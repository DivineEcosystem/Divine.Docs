# <a id="Divine_Protobufs_Steam_CMsgGCGetAppFriendsList"></a> Class CMsgGCGetAppFriendsList

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCGetAppFriendsList : IMessage<CMsgGCGetAppFriendsList>, IEquatable<CMsgGCGetAppFriendsList>, IDeepCloneable<CMsgGCGetAppFriendsList>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCGetAppFriendsList](Divine.Protobufs.Steam.CMsgGCGetAppFriendsList.md)

#### Implements

IMessage<CMsgGCGetAppFriendsList\>, 
[IEquatable<CMsgGCGetAppFriendsList\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCGetAppFriendsList\>, 
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
[EnumerableExtensions.In<CMsgGCGetAppFriendsList\>\(CMsgGCGetAppFriendsList, params CMsgGCGetAppFriendsList\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgGCGetAppFriendsList__ctor"></a> CMsgGCGetAppFriendsList\(\)

```csharp
public CMsgGCGetAppFriendsList()
```

### <a id="Divine_Protobufs_Steam_CMsgGCGetAppFriendsList__ctor_Divine_Protobufs_Steam_CMsgGCGetAppFriendsList_"></a> CMsgGCGetAppFriendsList\(CMsgGCGetAppFriendsList\)

```csharp
public CMsgGCGetAppFriendsList(CMsgGCGetAppFriendsList other)
```

#### Parameters

`other` [CMsgGCGetAppFriendsList](Divine.Protobufs.Steam.CMsgGCGetAppFriendsList.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgGCGetAppFriendsList_IncludeFriendshipTimestampsFieldNumber"></a> IncludeFriendshipTimestampsFieldNumber

```csharp
public const int IncludeFriendshipTimestampsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCGetAppFriendsList_IncludeFriendsWithNoPlayTimeFieldNumber"></a> IncludeFriendsWithNoPlayTimeFieldNumber

```csharp
public const int IncludeFriendsWithNoPlayTimeFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCGetAppFriendsList_SteamidFieldNumber"></a> SteamidFieldNumber

```csharp
public const int SteamidFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgGCGetAppFriendsList_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgGCGetAppFriendsList_HasIncludeFriendshipTimestamps"></a> HasIncludeFriendshipTimestamps

```csharp
public bool HasIncludeFriendshipTimestamps { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCGetAppFriendsList_HasIncludeFriendsWithNoPlayTime"></a> HasIncludeFriendsWithNoPlayTime

```csharp
public bool HasIncludeFriendsWithNoPlayTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCGetAppFriendsList_HasSteamid"></a> HasSteamid

```csharp
public bool HasSteamid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCGetAppFriendsList_IncludeFriendshipTimestamps"></a> IncludeFriendshipTimestamps

```csharp
public bool IncludeFriendshipTimestamps { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCGetAppFriendsList_IncludeFriendsWithNoPlayTime"></a> IncludeFriendsWithNoPlayTime

```csharp
public bool IncludeFriendsWithNoPlayTime { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCGetAppFriendsList_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCGetAppFriendsList> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCGetAppFriendsList](Divine.Protobufs.Steam.CMsgGCGetAppFriendsList.md)\>

### <a id="Divine_Protobufs_Steam_CMsgGCGetAppFriendsList_Steamid"></a> Steamid

```csharp
public ulong Steamid { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgGCGetAppFriendsList_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCGetAppFriendsList_ClearIncludeFriendshipTimestamps"></a> ClearIncludeFriendshipTimestamps\(\)

```csharp
public void ClearIncludeFriendshipTimestamps()
```

### <a id="Divine_Protobufs_Steam_CMsgGCGetAppFriendsList_ClearIncludeFriendsWithNoPlayTime"></a> ClearIncludeFriendsWithNoPlayTime\(\)

```csharp
public void ClearIncludeFriendsWithNoPlayTime()
```

### <a id="Divine_Protobufs_Steam_CMsgGCGetAppFriendsList_ClearSteamid"></a> ClearSteamid\(\)

```csharp
public void ClearSteamid()
```

### <a id="Divine_Protobufs_Steam_CMsgGCGetAppFriendsList_Clone"></a> Clone\(\)

```csharp
public CMsgGCGetAppFriendsList Clone()
```

#### Returns

 [CMsgGCGetAppFriendsList](Divine.Protobufs.Steam.CMsgGCGetAppFriendsList.md)

### <a id="Divine_Protobufs_Steam_CMsgGCGetAppFriendsList_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCGetAppFriendsList_Equals_Divine_Protobufs_Steam_CMsgGCGetAppFriendsList_"></a> Equals\(CMsgGCGetAppFriendsList\)

```csharp
public bool Equals(CMsgGCGetAppFriendsList other)
```

#### Parameters

`other` [CMsgGCGetAppFriendsList](Divine.Protobufs.Steam.CMsgGCGetAppFriendsList.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCGetAppFriendsList_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCGetAppFriendsList_MergeFrom_Divine_Protobufs_Steam_CMsgGCGetAppFriendsList_"></a> MergeFrom\(CMsgGCGetAppFriendsList\)

```csharp
public void MergeFrom(CMsgGCGetAppFriendsList other)
```

#### Parameters

`other` [CMsgGCGetAppFriendsList](Divine.Protobufs.Steam.CMsgGCGetAppFriendsList.md)

### <a id="Divine_Protobufs_Steam_CMsgGCGetAppFriendsList_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgGCGetAppFriendsList_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgGCGetAppFriendsList_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

