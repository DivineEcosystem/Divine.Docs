# <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Types_OwnGameplayInfo"></a> Class CPlayer\_GetFriendsGameplayInfo\_Response.Types.OwnGameplayInfo

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CPlayer_GetFriendsGameplayInfo_Response.Types.OwnGameplayInfo : IMessage<CPlayer_GetFriendsGameplayInfo_Response.Types.OwnGameplayInfo>, IEquatable<CPlayer_GetFriendsGameplayInfo_Response.Types.OwnGameplayInfo>, IDeepCloneable<CPlayer_GetFriendsGameplayInfo_Response.Types.OwnGameplayInfo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CPlayer\_GetFriendsGameplayInfo\_Response.Types.OwnGameplayInfo](Divine.Protobufs.Steam.CPlayer\_GetFriendsGameplayInfo\_Response.Types.OwnGameplayInfo.md)

#### Implements

IMessage<CPlayer\_GetFriendsGameplayInfo\_Response.Types.OwnGameplayInfo\>, 
[IEquatable<CPlayer\_GetFriendsGameplayInfo\_Response.Types.OwnGameplayInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CPlayer\_GetFriendsGameplayInfo\_Response.Types.OwnGameplayInfo\>, 
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
[EnumerableExtensions.In<CPlayer\_GetFriendsGameplayInfo\_Response.Types.OwnGameplayInfo\>\(CPlayer\_GetFriendsGameplayInfo\_Response.Types.OwnGameplayInfo, params CPlayer\_GetFriendsGameplayInfo\_Response.Types.OwnGameplayInfo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Types_OwnGameplayInfo__ctor"></a> OwnGameplayInfo\(\)

```csharp
public OwnGameplayInfo()
```

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Types_OwnGameplayInfo__ctor_Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Types_OwnGameplayInfo_"></a> OwnGameplayInfo\(OwnGameplayInfo\)

```csharp
public OwnGameplayInfo(CPlayer_GetFriendsGameplayInfo_Response.Types.OwnGameplayInfo other)
```

#### Parameters

`other` [CPlayer\_GetFriendsGameplayInfo\_Response](Divine.Protobufs.Steam.CPlayer\_GetFriendsGameplayInfo\_Response.md).[Types](Divine.Protobufs.Steam.CPlayer\_GetFriendsGameplayInfo\_Response.Types.md).[OwnGameplayInfo](Divine.Protobufs.Steam.CPlayer\_GetFriendsGameplayInfo\_Response.Types.OwnGameplayInfo.md)

## Fields

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Types_OwnGameplayInfo_InWishlistFieldNumber"></a> InWishlistFieldNumber

```csharp
public const int InWishlistFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Types_OwnGameplayInfo_MinutesPlayedFieldNumber"></a> MinutesPlayedFieldNumber

```csharp
public const int MinutesPlayedFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Types_OwnGameplayInfo_MinutesPlayedForeverFieldNumber"></a> MinutesPlayedForeverFieldNumber

```csharp
public const int MinutesPlayedForeverFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Types_OwnGameplayInfo_OwnedFieldNumber"></a> OwnedFieldNumber

```csharp
public const int OwnedFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Types_OwnGameplayInfo_SteamidFieldNumber"></a> SteamidFieldNumber

```csharp
public const int SteamidFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Types_OwnGameplayInfo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Types_OwnGameplayInfo_HasInWishlist"></a> HasInWishlist

```csharp
public bool HasInWishlist { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Types_OwnGameplayInfo_HasMinutesPlayed"></a> HasMinutesPlayed

```csharp
public bool HasMinutesPlayed { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Types_OwnGameplayInfo_HasMinutesPlayedForever"></a> HasMinutesPlayedForever

```csharp
public bool HasMinutesPlayedForever { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Types_OwnGameplayInfo_HasOwned"></a> HasOwned

```csharp
public bool HasOwned { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Types_OwnGameplayInfo_HasSteamid"></a> HasSteamid

```csharp
public bool HasSteamid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Types_OwnGameplayInfo_InWishlist"></a> InWishlist

```csharp
public bool InWishlist { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Types_OwnGameplayInfo_MinutesPlayed"></a> MinutesPlayed

```csharp
public uint MinutesPlayed { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Types_OwnGameplayInfo_MinutesPlayedForever"></a> MinutesPlayedForever

```csharp
public uint MinutesPlayedForever { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Types_OwnGameplayInfo_Owned"></a> Owned

```csharp
public bool Owned { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Types_OwnGameplayInfo_Parser"></a> Parser

```csharp
public static MessageParser<CPlayer_GetFriendsGameplayInfo_Response.Types.OwnGameplayInfo> Parser { get; }
```

#### Property Value

 MessageParser<[CPlayer\_GetFriendsGameplayInfo\_Response](Divine.Protobufs.Steam.CPlayer\_GetFriendsGameplayInfo\_Response.md).[Types](Divine.Protobufs.Steam.CPlayer\_GetFriendsGameplayInfo\_Response.Types.md).[OwnGameplayInfo](Divine.Protobufs.Steam.CPlayer\_GetFriendsGameplayInfo\_Response.Types.OwnGameplayInfo.md)\>

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Types_OwnGameplayInfo_Steamid"></a> Steamid

```csharp
public ulong Steamid { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Types_OwnGameplayInfo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Types_OwnGameplayInfo_ClearInWishlist"></a> ClearInWishlist\(\)

```csharp
public void ClearInWishlist()
```

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Types_OwnGameplayInfo_ClearMinutesPlayed"></a> ClearMinutesPlayed\(\)

```csharp
public void ClearMinutesPlayed()
```

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Types_OwnGameplayInfo_ClearMinutesPlayedForever"></a> ClearMinutesPlayedForever\(\)

```csharp
public void ClearMinutesPlayedForever()
```

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Types_OwnGameplayInfo_ClearOwned"></a> ClearOwned\(\)

```csharp
public void ClearOwned()
```

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Types_OwnGameplayInfo_ClearSteamid"></a> ClearSteamid\(\)

```csharp
public void ClearSteamid()
```

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Types_OwnGameplayInfo_Clone"></a> Clone\(\)

```csharp
public CPlayer_GetFriendsGameplayInfo_Response.Types.OwnGameplayInfo Clone()
```

#### Returns

 [CPlayer\_GetFriendsGameplayInfo\_Response](Divine.Protobufs.Steam.CPlayer\_GetFriendsGameplayInfo\_Response.md).[Types](Divine.Protobufs.Steam.CPlayer\_GetFriendsGameplayInfo\_Response.Types.md).[OwnGameplayInfo](Divine.Protobufs.Steam.CPlayer\_GetFriendsGameplayInfo\_Response.Types.OwnGameplayInfo.md)

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Types_OwnGameplayInfo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Types_OwnGameplayInfo_Equals_Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Types_OwnGameplayInfo_"></a> Equals\(OwnGameplayInfo\)

```csharp
public bool Equals(CPlayer_GetFriendsGameplayInfo_Response.Types.OwnGameplayInfo other)
```

#### Parameters

`other` [CPlayer\_GetFriendsGameplayInfo\_Response](Divine.Protobufs.Steam.CPlayer\_GetFriendsGameplayInfo\_Response.md).[Types](Divine.Protobufs.Steam.CPlayer\_GetFriendsGameplayInfo\_Response.Types.md).[OwnGameplayInfo](Divine.Protobufs.Steam.CPlayer\_GetFriendsGameplayInfo\_Response.Types.OwnGameplayInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Types_OwnGameplayInfo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Types_OwnGameplayInfo_MergeFrom_Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Types_OwnGameplayInfo_"></a> MergeFrom\(OwnGameplayInfo\)

```csharp
public void MergeFrom(CPlayer_GetFriendsGameplayInfo_Response.Types.OwnGameplayInfo other)
```

#### Parameters

`other` [CPlayer\_GetFriendsGameplayInfo\_Response](Divine.Protobufs.Steam.CPlayer\_GetFriendsGameplayInfo\_Response.md).[Types](Divine.Protobufs.Steam.CPlayer\_GetFriendsGameplayInfo\_Response.Types.md).[OwnGameplayInfo](Divine.Protobufs.Steam.CPlayer\_GetFriendsGameplayInfo\_Response.Types.OwnGameplayInfo.md)

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Types_OwnGameplayInfo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Types_OwnGameplayInfo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Types_OwnGameplayInfo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

