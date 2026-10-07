# <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response"></a> Class CPlayer\_GetFriendsGameplayInfo\_Response

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CPlayer_GetFriendsGameplayInfo_Response : IMessage<CPlayer_GetFriendsGameplayInfo_Response>, IEquatable<CPlayer_GetFriendsGameplayInfo_Response>, IDeepCloneable<CPlayer_GetFriendsGameplayInfo_Response>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CPlayer\_GetFriendsGameplayInfo\_Response](Divine.Protobufs.Steam.CPlayer\_GetFriendsGameplayInfo\_Response.md)

#### Implements

IMessage<CPlayer\_GetFriendsGameplayInfo\_Response\>, 
[IEquatable<CPlayer\_GetFriendsGameplayInfo\_Response\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CPlayer\_GetFriendsGameplayInfo\_Response\>, 
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
[EnumerableExtensions.In<CPlayer\_GetFriendsGameplayInfo\_Response\>\(CPlayer\_GetFriendsGameplayInfo\_Response, params CPlayer\_GetFriendsGameplayInfo\_Response\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response__ctor"></a> CPlayer\_GetFriendsGameplayInfo\_Response\(\)

```csharp
public CPlayer_GetFriendsGameplayInfo_Response()
```

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response__ctor_Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_"></a> CPlayer\_GetFriendsGameplayInfo\_Response\(CPlayer\_GetFriendsGameplayInfo\_Response\)

```csharp
public CPlayer_GetFriendsGameplayInfo_Response(CPlayer_GetFriendsGameplayInfo_Response other)
```

#### Parameters

`other` [CPlayer\_GetFriendsGameplayInfo\_Response](Divine.Protobufs.Steam.CPlayer\_GetFriendsGameplayInfo\_Response.md)

## Fields

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_InGameFieldNumber"></a> InGameFieldNumber

```csharp
public const int InGameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_InWishlistFieldNumber"></a> InWishlistFieldNumber

```csharp
public const int InWishlistFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_OwnsFieldNumber"></a> OwnsFieldNumber

```csharp
public const int OwnsFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_PlayedEverFieldNumber"></a> PlayedEverFieldNumber

```csharp
public const int PlayedEverFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_PlayedRecentlyFieldNumber"></a> PlayedRecentlyFieldNumber

```csharp
public const int PlayedRecentlyFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_YourInfoFieldNumber"></a> YourInfoFieldNumber

```csharp
public const int YourInfoFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_InGame"></a> InGame

```csharp
public RepeatedField<CPlayer_GetFriendsGameplayInfo_Response.Types.FriendsGameplayInfo> InGame { get; }
```

#### Property Value

 RepeatedField<[CPlayer\_GetFriendsGameplayInfo\_Response](Divine.Protobufs.Steam.CPlayer\_GetFriendsGameplayInfo\_Response.md).[Types](Divine.Protobufs.Steam.CPlayer\_GetFriendsGameplayInfo\_Response.Types.md).[FriendsGameplayInfo](Divine.Protobufs.Steam.CPlayer\_GetFriendsGameplayInfo\_Response.Types.FriendsGameplayInfo.md)\>

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_InWishlist"></a> InWishlist

```csharp
public RepeatedField<CPlayer_GetFriendsGameplayInfo_Response.Types.FriendsGameplayInfo> InWishlist { get; }
```

#### Property Value

 RepeatedField<[CPlayer\_GetFriendsGameplayInfo\_Response](Divine.Protobufs.Steam.CPlayer\_GetFriendsGameplayInfo\_Response.md).[Types](Divine.Protobufs.Steam.CPlayer\_GetFriendsGameplayInfo\_Response.Types.md).[FriendsGameplayInfo](Divine.Protobufs.Steam.CPlayer\_GetFriendsGameplayInfo\_Response.Types.FriendsGameplayInfo.md)\>

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Owns"></a> Owns

```csharp
public RepeatedField<CPlayer_GetFriendsGameplayInfo_Response.Types.FriendsGameplayInfo> Owns { get; }
```

#### Property Value

 RepeatedField<[CPlayer\_GetFriendsGameplayInfo\_Response](Divine.Protobufs.Steam.CPlayer\_GetFriendsGameplayInfo\_Response.md).[Types](Divine.Protobufs.Steam.CPlayer\_GetFriendsGameplayInfo\_Response.Types.md).[FriendsGameplayInfo](Divine.Protobufs.Steam.CPlayer\_GetFriendsGameplayInfo\_Response.Types.FriendsGameplayInfo.md)\>

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Parser"></a> Parser

```csharp
public static MessageParser<CPlayer_GetFriendsGameplayInfo_Response> Parser { get; }
```

#### Property Value

 MessageParser<[CPlayer\_GetFriendsGameplayInfo\_Response](Divine.Protobufs.Steam.CPlayer\_GetFriendsGameplayInfo\_Response.md)\>

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_PlayedEver"></a> PlayedEver

```csharp
public RepeatedField<CPlayer_GetFriendsGameplayInfo_Response.Types.FriendsGameplayInfo> PlayedEver { get; }
```

#### Property Value

 RepeatedField<[CPlayer\_GetFriendsGameplayInfo\_Response](Divine.Protobufs.Steam.CPlayer\_GetFriendsGameplayInfo\_Response.md).[Types](Divine.Protobufs.Steam.CPlayer\_GetFriendsGameplayInfo\_Response.Types.md).[FriendsGameplayInfo](Divine.Protobufs.Steam.CPlayer\_GetFriendsGameplayInfo\_Response.Types.FriendsGameplayInfo.md)\>

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_PlayedRecently"></a> PlayedRecently

```csharp
public RepeatedField<CPlayer_GetFriendsGameplayInfo_Response.Types.FriendsGameplayInfo> PlayedRecently { get; }
```

#### Property Value

 RepeatedField<[CPlayer\_GetFriendsGameplayInfo\_Response](Divine.Protobufs.Steam.CPlayer\_GetFriendsGameplayInfo\_Response.md).[Types](Divine.Protobufs.Steam.CPlayer\_GetFriendsGameplayInfo\_Response.Types.md).[FriendsGameplayInfo](Divine.Protobufs.Steam.CPlayer\_GetFriendsGameplayInfo\_Response.Types.FriendsGameplayInfo.md)\>

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_YourInfo"></a> YourInfo

```csharp
public CPlayer_GetFriendsGameplayInfo_Response.Types.OwnGameplayInfo YourInfo { get; set; }
```

#### Property Value

 [CPlayer\_GetFriendsGameplayInfo\_Response](Divine.Protobufs.Steam.CPlayer\_GetFriendsGameplayInfo\_Response.md).[Types](Divine.Protobufs.Steam.CPlayer\_GetFriendsGameplayInfo\_Response.Types.md).[OwnGameplayInfo](Divine.Protobufs.Steam.CPlayer\_GetFriendsGameplayInfo\_Response.Types.OwnGameplayInfo.md)

## Methods

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Clone"></a> Clone\(\)

```csharp
public CPlayer_GetFriendsGameplayInfo_Response Clone()
```

#### Returns

 [CPlayer\_GetFriendsGameplayInfo\_Response](Divine.Protobufs.Steam.CPlayer\_GetFriendsGameplayInfo\_Response.md)

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_Equals_Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_"></a> Equals\(CPlayer\_GetFriendsGameplayInfo\_Response\)

```csharp
public bool Equals(CPlayer_GetFriendsGameplayInfo_Response other)
```

#### Parameters

`other` [CPlayer\_GetFriendsGameplayInfo\_Response](Divine.Protobufs.Steam.CPlayer\_GetFriendsGameplayInfo\_Response.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_MergeFrom_Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_"></a> MergeFrom\(CPlayer\_GetFriendsGameplayInfo\_Response\)

```csharp
public void MergeFrom(CPlayer_GetFriendsGameplayInfo_Response other)
```

#### Parameters

`other` [CPlayer\_GetFriendsGameplayInfo\_Response](Divine.Protobufs.Steam.CPlayer\_GetFriendsGameplayInfo\_Response.md)

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CPlayer_GetFriendsGameplayInfo_Response_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

