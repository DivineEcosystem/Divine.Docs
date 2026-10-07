# <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetStickerHeroesResponse_Types_Player"></a> Class CMsgServerToGCGetStickerHeroesResponse.Types.Player

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgServerToGCGetStickerHeroesResponse.Types.Player : IMessage<CMsgServerToGCGetStickerHeroesResponse.Types.Player>, IEquatable<CMsgServerToGCGetStickerHeroesResponse.Types.Player>, IDeepCloneable<CMsgServerToGCGetStickerHeroesResponse.Types.Player>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgServerToGCGetStickerHeroesResponse.Types.Player](Divine.Protobufs.Dota2.CMsgServerToGCGetStickerHeroesResponse.Types.Player.md)

#### Implements

IMessage<CMsgServerToGCGetStickerHeroesResponse.Types.Player\>, 
[IEquatable<CMsgServerToGCGetStickerHeroesResponse.Types.Player\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgServerToGCGetStickerHeroesResponse.Types.Player\>, 
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
[EnumerableExtensions.In<CMsgServerToGCGetStickerHeroesResponse.Types.Player\>\(CMsgServerToGCGetStickerHeroesResponse.Types.Player, params CMsgServerToGCGetStickerHeroesResponse.Types.Player\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetStickerHeroesResponse_Types_Player__ctor"></a> Player\(\)

```csharp
public Player()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetStickerHeroesResponse_Types_Player__ctor_Divine_Protobufs_Dota2_CMsgServerToGCGetStickerHeroesResponse_Types_Player_"></a> Player\(Player\)

```csharp
public Player(CMsgServerToGCGetStickerHeroesResponse.Types.Player other)
```

#### Parameters

`other` [CMsgServerToGCGetStickerHeroesResponse](Divine.Protobufs.Dota2.CMsgServerToGCGetStickerHeroesResponse.md).[Types](Divine.Protobufs.Dota2.CMsgServerToGCGetStickerHeroesResponse.Types.md).[Player](Divine.Protobufs.Dota2.CMsgServerToGCGetStickerHeroesResponse.Types.Player.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetStickerHeroesResponse_Types_Player_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetStickerHeroesResponse_Types_Player_StickersFieldNumber"></a> StickersFieldNumber

```csharp
public const int StickersFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetStickerHeroesResponse_Types_Player_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetStickerHeroesResponse_Types_Player_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetStickerHeroesResponse_Types_Player_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetStickerHeroesResponse_Types_Player_Parser"></a> Parser

```csharp
public static MessageParser<CMsgServerToGCGetStickerHeroesResponse.Types.Player> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgServerToGCGetStickerHeroesResponse](Divine.Protobufs.Dota2.CMsgServerToGCGetStickerHeroesResponse.md).[Types](Divine.Protobufs.Dota2.CMsgServerToGCGetStickerHeroesResponse.Types.md).[Player](Divine.Protobufs.Dota2.CMsgServerToGCGetStickerHeroesResponse.Types.Player.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetStickerHeroesResponse_Types_Player_Stickers"></a> Stickers

```csharp
public CMsgStickerHeroes Stickers { get; set; }
```

#### Property Value

 [CMsgStickerHeroes](Divine.Protobufs.Dota2.CMsgStickerHeroes.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetStickerHeroesResponse_Types_Player_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetStickerHeroesResponse_Types_Player_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetStickerHeroesResponse_Types_Player_Clone"></a> Clone\(\)

```csharp
public CMsgServerToGCGetStickerHeroesResponse.Types.Player Clone()
```

#### Returns

 [CMsgServerToGCGetStickerHeroesResponse](Divine.Protobufs.Dota2.CMsgServerToGCGetStickerHeroesResponse.md).[Types](Divine.Protobufs.Dota2.CMsgServerToGCGetStickerHeroesResponse.Types.md).[Player](Divine.Protobufs.Dota2.CMsgServerToGCGetStickerHeroesResponse.Types.Player.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetStickerHeroesResponse_Types_Player_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetStickerHeroesResponse_Types_Player_Equals_Divine_Protobufs_Dota2_CMsgServerToGCGetStickerHeroesResponse_Types_Player_"></a> Equals\(Player\)

```csharp
public bool Equals(CMsgServerToGCGetStickerHeroesResponse.Types.Player other)
```

#### Parameters

`other` [CMsgServerToGCGetStickerHeroesResponse](Divine.Protobufs.Dota2.CMsgServerToGCGetStickerHeroesResponse.md).[Types](Divine.Protobufs.Dota2.CMsgServerToGCGetStickerHeroesResponse.Types.md).[Player](Divine.Protobufs.Dota2.CMsgServerToGCGetStickerHeroesResponse.Types.Player.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetStickerHeroesResponse_Types_Player_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetStickerHeroesResponse_Types_Player_MergeFrom_Divine_Protobufs_Dota2_CMsgServerToGCGetStickerHeroesResponse_Types_Player_"></a> MergeFrom\(Player\)

```csharp
public void MergeFrom(CMsgServerToGCGetStickerHeroesResponse.Types.Player other)
```

#### Parameters

`other` [CMsgServerToGCGetStickerHeroesResponse](Divine.Protobufs.Dota2.CMsgServerToGCGetStickerHeroesResponse.md).[Types](Divine.Protobufs.Dota2.CMsgServerToGCGetStickerHeroesResponse.Types.md).[Player](Divine.Protobufs.Dota2.CMsgServerToGCGetStickerHeroesResponse.Types.Player.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetStickerHeroesResponse_Types_Player_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetStickerHeroesResponse_Types_Player_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetStickerHeroesResponse_Types_Player_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

