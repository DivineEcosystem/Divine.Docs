# <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Types_FriendsGameplayInfo"></a> Class CPlayer\_GetFriendsGameplayInfo\_Response.Types.FriendsGameplayInfo

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CPlayer_GetFriendsGameplayInfo_Response.Types.FriendsGameplayInfo : IMessage<CPlayer_GetFriendsGameplayInfo_Response.Types.FriendsGameplayInfo>, IEquatable<CPlayer_GetFriendsGameplayInfo_Response.Types.FriendsGameplayInfo>, IDeepCloneable<CPlayer_GetFriendsGameplayInfo_Response.Types.FriendsGameplayInfo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CPlayer\_GetFriendsGameplayInfo\_Response.Types.FriendsGameplayInfo](Divine.Protobufs.Steam.CPlayer\_GetFriendsGameplayInfo\_Response.Types.FriendsGameplayInfo.md)

#### Implements

IMessage<CPlayer\_GetFriendsGameplayInfo\_Response.Types.FriendsGameplayInfo\>, 
[IEquatable<CPlayer\_GetFriendsGameplayInfo\_Response.Types.FriendsGameplayInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CPlayer\_GetFriendsGameplayInfo\_Response.Types.FriendsGameplayInfo\>, 
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
[EnumerableExtensions.In<CPlayer\_GetFriendsGameplayInfo\_Response.Types.FriendsGameplayInfo\>\(CPlayer\_GetFriendsGameplayInfo\_Response.Types.FriendsGameplayInfo, params CPlayer\_GetFriendsGameplayInfo\_Response.Types.FriendsGameplayInfo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Types_FriendsGameplayInfo__ctor"></a> FriendsGameplayInfo\(\)

```csharp
public FriendsGameplayInfo()
```

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Types_FriendsGameplayInfo__ctor_Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Types_FriendsGameplayInfo_"></a> FriendsGameplayInfo\(FriendsGameplayInfo\)

```csharp
public FriendsGameplayInfo(CPlayer_GetFriendsGameplayInfo_Response.Types.FriendsGameplayInfo other)
```

#### Parameters

`other` [CPlayer\_GetFriendsGameplayInfo\_Response](Divine.Protobufs.Steam.CPlayer\_GetFriendsGameplayInfo\_Response.md).[Types](Divine.Protobufs.Steam.CPlayer\_GetFriendsGameplayInfo\_Response.Types.md).[FriendsGameplayInfo](Divine.Protobufs.Steam.CPlayer\_GetFriendsGameplayInfo\_Response.Types.FriendsGameplayInfo.md)

## Fields

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Types_FriendsGameplayInfo_MinutesPlayedFieldNumber"></a> MinutesPlayedFieldNumber

```csharp
public const int MinutesPlayedFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Types_FriendsGameplayInfo_MinutesPlayedForeverFieldNumber"></a> MinutesPlayedForeverFieldNumber

```csharp
public const int MinutesPlayedForeverFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Types_FriendsGameplayInfo_SteamidFieldNumber"></a> SteamidFieldNumber

```csharp
public const int SteamidFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Types_FriendsGameplayInfo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Types_FriendsGameplayInfo_HasMinutesPlayed"></a> HasMinutesPlayed

```csharp
public bool HasMinutesPlayed { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Types_FriendsGameplayInfo_HasMinutesPlayedForever"></a> HasMinutesPlayedForever

```csharp
public bool HasMinutesPlayedForever { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Types_FriendsGameplayInfo_HasSteamid"></a> HasSteamid

```csharp
public bool HasSteamid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Types_FriendsGameplayInfo_MinutesPlayed"></a> MinutesPlayed

```csharp
public uint MinutesPlayed { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Types_FriendsGameplayInfo_MinutesPlayedForever"></a> MinutesPlayedForever

```csharp
public uint MinutesPlayedForever { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Types_FriendsGameplayInfo_Parser"></a> Parser

```csharp
public static MessageParser<CPlayer_GetFriendsGameplayInfo_Response.Types.FriendsGameplayInfo> Parser { get; }
```

#### Property Value

 MessageParser<[CPlayer\_GetFriendsGameplayInfo\_Response](Divine.Protobufs.Steam.CPlayer\_GetFriendsGameplayInfo\_Response.md).[Types](Divine.Protobufs.Steam.CPlayer\_GetFriendsGameplayInfo\_Response.Types.md).[FriendsGameplayInfo](Divine.Protobufs.Steam.CPlayer\_GetFriendsGameplayInfo\_Response.Types.FriendsGameplayInfo.md)\>

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Types_FriendsGameplayInfo_Steamid"></a> Steamid

```csharp
public ulong Steamid { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Types_FriendsGameplayInfo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Types_FriendsGameplayInfo_ClearMinutesPlayed"></a> ClearMinutesPlayed\(\)

```csharp
public void ClearMinutesPlayed()
```

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Types_FriendsGameplayInfo_ClearMinutesPlayedForever"></a> ClearMinutesPlayedForever\(\)

```csharp
public void ClearMinutesPlayedForever()
```

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Types_FriendsGameplayInfo_ClearSteamid"></a> ClearSteamid\(\)

```csharp
public void ClearSteamid()
```

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Types_FriendsGameplayInfo_Clone"></a> Clone\(\)

```csharp
public CPlayer_GetFriendsGameplayInfo_Response.Types.FriendsGameplayInfo Clone()
```

#### Returns

 [CPlayer\_GetFriendsGameplayInfo\_Response](Divine.Protobufs.Steam.CPlayer\_GetFriendsGameplayInfo\_Response.md).[Types](Divine.Protobufs.Steam.CPlayer\_GetFriendsGameplayInfo\_Response.Types.md).[FriendsGameplayInfo](Divine.Protobufs.Steam.CPlayer\_GetFriendsGameplayInfo\_Response.Types.FriendsGameplayInfo.md)

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Types_FriendsGameplayInfo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Types_FriendsGameplayInfo_Equals_Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Types_FriendsGameplayInfo_"></a> Equals\(FriendsGameplayInfo\)

```csharp
public bool Equals(CPlayer_GetFriendsGameplayInfo_Response.Types.FriendsGameplayInfo other)
```

#### Parameters

`other` [CPlayer\_GetFriendsGameplayInfo\_Response](Divine.Protobufs.Steam.CPlayer\_GetFriendsGameplayInfo\_Response.md).[Types](Divine.Protobufs.Steam.CPlayer\_GetFriendsGameplayInfo\_Response.Types.md).[FriendsGameplayInfo](Divine.Protobufs.Steam.CPlayer\_GetFriendsGameplayInfo\_Response.Types.FriendsGameplayInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Types_FriendsGameplayInfo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Types_FriendsGameplayInfo_MergeFrom_Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Types_FriendsGameplayInfo_"></a> MergeFrom\(FriendsGameplayInfo\)

```csharp
public void MergeFrom(CPlayer_GetFriendsGameplayInfo_Response.Types.FriendsGameplayInfo other)
```

#### Parameters

`other` [CPlayer\_GetFriendsGameplayInfo\_Response](Divine.Protobufs.Steam.CPlayer\_GetFriendsGameplayInfo\_Response.md).[Types](Divine.Protobufs.Steam.CPlayer\_GetFriendsGameplayInfo\_Response.Types.md).[FriendsGameplayInfo](Divine.Protobufs.Steam.CPlayer\_GetFriendsGameplayInfo\_Response.Types.FriendsGameplayInfo.md)

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Types_FriendsGameplayInfo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Types_FriendsGameplayInfo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Types_FriendsGameplayInfo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

