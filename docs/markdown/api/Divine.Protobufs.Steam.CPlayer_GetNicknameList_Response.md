# <a id="Divine_Protobufs_Steam_CPlayer_GetNicknameList_Response"></a> Class CPlayer\_GetNicknameList\_Response

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CPlayer_GetNicknameList_Response : IMessage<CPlayer_GetNicknameList_Response>, IEquatable<CPlayer_GetNicknameList_Response>, IDeepCloneable<CPlayer_GetNicknameList_Response>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CPlayer\_GetNicknameList\_Response](Divine.Protobufs.Steam.CPlayer\_GetNicknameList\_Response.md)

#### Implements

IMessage<CPlayer\_GetNicknameList\_Response\>, 
[IEquatable<CPlayer\_GetNicknameList\_Response\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CPlayer\_GetNicknameList\_Response\>, 
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
[EnumerableExtensions.In<CPlayer\_GetNicknameList\_Response\>\(CPlayer\_GetNicknameList\_Response, params CPlayer\_GetNicknameList\_Response\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CPlayer_GetNicknameList_Response__ctor"></a> CPlayer\_GetNicknameList\_Response\(\)

```csharp
public CPlayer_GetNicknameList_Response()
```

### <a id="Divine_Protobufs_Steam_CPlayer_GetNicknameList_Response__ctor_Divine_Protobufs_Steam_CPlayer_GetNicknameList_Response_"></a> CPlayer\_GetNicknameList\_Response\(CPlayer\_GetNicknameList\_Response\)

```csharp
public CPlayer_GetNicknameList_Response(CPlayer_GetNicknameList_Response other)
```

#### Parameters

`other` [CPlayer\_GetNicknameList\_Response](Divine.Protobufs.Steam.CPlayer\_GetNicknameList\_Response.md)

## Fields

### <a id="Divine_Protobufs_Steam_CPlayer_GetNicknameList_Response_NicknamesFieldNumber"></a> NicknamesFieldNumber

```csharp
public const int NicknamesFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CPlayer_GetNicknameList_Response_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CPlayer_GetNicknameList_Response_Nicknames"></a> Nicknames

```csharp
public RepeatedField<CPlayer_GetNicknameList_Response.Types.PlayerNickname> Nicknames { get; }
```

#### Property Value

 RepeatedField<[CPlayer\_GetNicknameList\_Response](Divine.Protobufs.Steam.CPlayer\_GetNicknameList\_Response.md).[Types](Divine.Protobufs.Steam.CPlayer\_GetNicknameList\_Response.Types.md).[PlayerNickname](Divine.Protobufs.Steam.CPlayer\_GetNicknameList\_Response.Types.PlayerNickname.md)\>

### <a id="Divine_Protobufs_Steam_CPlayer_GetNicknameList_Response_Parser"></a> Parser

```csharp
public static MessageParser<CPlayer_GetNicknameList_Response> Parser { get; }
```

#### Property Value

 MessageParser<[CPlayer\_GetNicknameList\_Response](Divine.Protobufs.Steam.CPlayer\_GetNicknameList\_Response.md)\>

## Methods

### <a id="Divine_Protobufs_Steam_CPlayer_GetNicknameList_Response_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPlayer_GetNicknameList_Response_Clone"></a> Clone\(\)

```csharp
public CPlayer_GetNicknameList_Response Clone()
```

#### Returns

 [CPlayer\_GetNicknameList\_Response](Divine.Protobufs.Steam.CPlayer\_GetNicknameList\_Response.md)

### <a id="Divine_Protobufs_Steam_CPlayer_GetNicknameList_Response_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPlayer_GetNicknameList_Response_Equals_Divine_Protobufs_Steam_CPlayer_GetNicknameList_Response_"></a> Equals\(CPlayer\_GetNicknameList\_Response\)

```csharp
public bool Equals(CPlayer_GetNicknameList_Response other)
```

#### Parameters

`other` [CPlayer\_GetNicknameList\_Response](Divine.Protobufs.Steam.CPlayer\_GetNicknameList\_Response.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPlayer_GetNicknameList_Response_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPlayer_GetNicknameList_Response_MergeFrom_Divine_Protobufs_Steam_CPlayer_GetNicknameList_Response_"></a> MergeFrom\(CPlayer\_GetNicknameList\_Response\)

```csharp
public void MergeFrom(CPlayer_GetNicknameList_Response other)
```

#### Parameters

`other` [CPlayer\_GetNicknameList\_Response](Divine.Protobufs.Steam.CPlayer\_GetNicknameList\_Response.md)

### <a id="Divine_Protobufs_Steam_CPlayer_GetNicknameList_Response_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CPlayer_GetNicknameList_Response_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CPlayer_GetNicknameList_Response_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

