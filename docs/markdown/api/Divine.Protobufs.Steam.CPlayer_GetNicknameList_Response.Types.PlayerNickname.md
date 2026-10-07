# <a id="Divine_Protobufs_Steam_CPlayer_GetNicknameList_Response_Types_PlayerNickname"></a> Class CPlayer\_GetNicknameList\_Response.Types.PlayerNickname

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CPlayer_GetNicknameList_Response.Types.PlayerNickname : IMessage<CPlayer_GetNicknameList_Response.Types.PlayerNickname>, IEquatable<CPlayer_GetNicknameList_Response.Types.PlayerNickname>, IDeepCloneable<CPlayer_GetNicknameList_Response.Types.PlayerNickname>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CPlayer\_GetNicknameList\_Response.Types.PlayerNickname](Divine.Protobufs.Steam.CPlayer\_GetNicknameList\_Response.Types.PlayerNickname.md)

#### Implements

IMessage<CPlayer\_GetNicknameList\_Response.Types.PlayerNickname\>, 
[IEquatable<CPlayer\_GetNicknameList\_Response.Types.PlayerNickname\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CPlayer\_GetNicknameList\_Response.Types.PlayerNickname\>, 
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
[EnumerableExtensions.In<CPlayer\_GetNicknameList\_Response.Types.PlayerNickname\>\(CPlayer\_GetNicknameList\_Response.Types.PlayerNickname, params CPlayer\_GetNicknameList\_Response.Types.PlayerNickname\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CPlayer_GetNicknameList_Response_Types_PlayerNickname__ctor"></a> PlayerNickname\(\)

```csharp
public PlayerNickname()
```

### <a id="Divine_Protobufs_Steam_CPlayer_GetNicknameList_Response_Types_PlayerNickname__ctor_Divine_Protobufs_Steam_CPlayer_GetNicknameList_Response_Types_PlayerNickname_"></a> PlayerNickname\(PlayerNickname\)

```csharp
public PlayerNickname(CPlayer_GetNicknameList_Response.Types.PlayerNickname other)
```

#### Parameters

`other` [CPlayer\_GetNicknameList\_Response](Divine.Protobufs.Steam.CPlayer\_GetNicknameList\_Response.md).[Types](Divine.Protobufs.Steam.CPlayer\_GetNicknameList\_Response.Types.md).[PlayerNickname](Divine.Protobufs.Steam.CPlayer\_GetNicknameList\_Response.Types.PlayerNickname.md)

## Fields

### <a id="Divine_Protobufs_Steam_CPlayer_GetNicknameList_Response_Types_PlayerNickname_AccountidFieldNumber"></a> AccountidFieldNumber

```csharp
public const int AccountidFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPlayer_GetNicknameList_Response_Types_PlayerNickname_NicknameFieldNumber"></a> NicknameFieldNumber

```csharp
public const int NicknameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CPlayer_GetNicknameList_Response_Types_PlayerNickname_Accountid"></a> Accountid

```csharp
public uint Accountid { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CPlayer_GetNicknameList_Response_Types_PlayerNickname_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CPlayer_GetNicknameList_Response_Types_PlayerNickname_HasAccountid"></a> HasAccountid

```csharp
public bool HasAccountid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPlayer_GetNicknameList_Response_Types_PlayerNickname_HasNickname"></a> HasNickname

```csharp
public bool HasNickname { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPlayer_GetNicknameList_Response_Types_PlayerNickname_Nickname"></a> Nickname

```csharp
public string Nickname { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CPlayer_GetNicknameList_Response_Types_PlayerNickname_Parser"></a> Parser

```csharp
public static MessageParser<CPlayer_GetNicknameList_Response.Types.PlayerNickname> Parser { get; }
```

#### Property Value

 MessageParser<[CPlayer\_GetNicknameList\_Response](Divine.Protobufs.Steam.CPlayer\_GetNicknameList\_Response.md).[Types](Divine.Protobufs.Steam.CPlayer\_GetNicknameList\_Response.Types.md).[PlayerNickname](Divine.Protobufs.Steam.CPlayer\_GetNicknameList\_Response.Types.PlayerNickname.md)\>

## Methods

### <a id="Divine_Protobufs_Steam_CPlayer_GetNicknameList_Response_Types_PlayerNickname_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPlayer_GetNicknameList_Response_Types_PlayerNickname_ClearAccountid"></a> ClearAccountid\(\)

```csharp
public void ClearAccountid()
```

### <a id="Divine_Protobufs_Steam_CPlayer_GetNicknameList_Response_Types_PlayerNickname_ClearNickname"></a> ClearNickname\(\)

```csharp
public void ClearNickname()
```

### <a id="Divine_Protobufs_Steam_CPlayer_GetNicknameList_Response_Types_PlayerNickname_Clone"></a> Clone\(\)

```csharp
public CPlayer_GetNicknameList_Response.Types.PlayerNickname Clone()
```

#### Returns

 [CPlayer\_GetNicknameList\_Response](Divine.Protobufs.Steam.CPlayer\_GetNicknameList\_Response.md).[Types](Divine.Protobufs.Steam.CPlayer\_GetNicknameList\_Response.Types.md).[PlayerNickname](Divine.Protobufs.Steam.CPlayer\_GetNicknameList\_Response.Types.PlayerNickname.md)

### <a id="Divine_Protobufs_Steam_CPlayer_GetNicknameList_Response_Types_PlayerNickname_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPlayer_GetNicknameList_Response_Types_PlayerNickname_Equals_Divine_Protobufs_Steam_CPlayer_GetNicknameList_Response_Types_PlayerNickname_"></a> Equals\(PlayerNickname\)

```csharp
public bool Equals(CPlayer_GetNicknameList_Response.Types.PlayerNickname other)
```

#### Parameters

`other` [CPlayer\_GetNicknameList\_Response](Divine.Protobufs.Steam.CPlayer\_GetNicknameList\_Response.md).[Types](Divine.Protobufs.Steam.CPlayer\_GetNicknameList\_Response.Types.md).[PlayerNickname](Divine.Protobufs.Steam.CPlayer\_GetNicknameList\_Response.Types.PlayerNickname.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPlayer_GetNicknameList_Response_Types_PlayerNickname_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPlayer_GetNicknameList_Response_Types_PlayerNickname_MergeFrom_Divine_Protobufs_Steam_CPlayer_GetNicknameList_Response_Types_PlayerNickname_"></a> MergeFrom\(PlayerNickname\)

```csharp
public void MergeFrom(CPlayer_GetNicknameList_Response.Types.PlayerNickname other)
```

#### Parameters

`other` [CPlayer\_GetNicknameList\_Response](Divine.Protobufs.Steam.CPlayer\_GetNicknameList\_Response.md).[Types](Divine.Protobufs.Steam.CPlayer\_GetNicknameList\_Response.Types.md).[PlayerNickname](Divine.Protobufs.Steam.CPlayer\_GetNicknameList\_Response.Types.PlayerNickname.md)

### <a id="Divine_Protobufs_Steam_CPlayer_GetNicknameList_Response_Types_PlayerNickname_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CPlayer_GetNicknameList_Response_Types_PlayerNickname_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CPlayer_GetNicknameList_Response_Types_PlayerNickname_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

