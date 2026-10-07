# <a id="Divine_Protobufs_Dota2_CMsgGCToClientCustomGamesFriendsPlayedResponse_Types_CustomGame"></a> Class CMsgGCToClientCustomGamesFriendsPlayedResponse.Types.CustomGame

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientCustomGamesFriendsPlayedResponse.Types.CustomGame : IMessage<CMsgGCToClientCustomGamesFriendsPlayedResponse.Types.CustomGame>, IEquatable<CMsgGCToClientCustomGamesFriendsPlayedResponse.Types.CustomGame>, IDeepCloneable<CMsgGCToClientCustomGamesFriendsPlayedResponse.Types.CustomGame>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientCustomGamesFriendsPlayedResponse.Types.CustomGame](Divine.Protobufs.Dota2.CMsgGCToClientCustomGamesFriendsPlayedResponse.Types.CustomGame.md)

#### Implements

IMessage<CMsgGCToClientCustomGamesFriendsPlayedResponse.Types.CustomGame\>, 
[IEquatable<CMsgGCToClientCustomGamesFriendsPlayedResponse.Types.CustomGame\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientCustomGamesFriendsPlayedResponse.Types.CustomGame\>, 
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
[EnumerableExtensions.In<CMsgGCToClientCustomGamesFriendsPlayedResponse.Types.CustomGame\>\(CMsgGCToClientCustomGamesFriendsPlayedResponse.Types.CustomGame, params CMsgGCToClientCustomGamesFriendsPlayedResponse.Types.CustomGame\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCustomGamesFriendsPlayedResponse_Types_CustomGame__ctor"></a> CustomGame\(\)

```csharp
public CustomGame()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCustomGamesFriendsPlayedResponse_Types_CustomGame__ctor_Divine_Protobufs_Dota2_CMsgGCToClientCustomGamesFriendsPlayedResponse_Types_CustomGame_"></a> CustomGame\(CustomGame\)

```csharp
public CustomGame(CMsgGCToClientCustomGamesFriendsPlayedResponse.Types.CustomGame other)
```

#### Parameters

`other` [CMsgGCToClientCustomGamesFriendsPlayedResponse](Divine.Protobufs.Dota2.CMsgGCToClientCustomGamesFriendsPlayedResponse.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientCustomGamesFriendsPlayedResponse.Types.md).[CustomGame](Divine.Protobufs.Dota2.CMsgGCToClientCustomGamesFriendsPlayedResponse.Types.CustomGame.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCustomGamesFriendsPlayedResponse_Types_CustomGame_AccountIdsFieldNumber"></a> AccountIdsFieldNumber

```csharp
public const int AccountIdsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCustomGamesFriendsPlayedResponse_Types_CustomGame_CustomGameIdFieldNumber"></a> CustomGameIdFieldNumber

```csharp
public const int CustomGameIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCustomGamesFriendsPlayedResponse_Types_CustomGame_AccountIds"></a> AccountIds

```csharp
public RepeatedField<uint> AccountIds { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCustomGamesFriendsPlayedResponse_Types_CustomGame_CustomGameId"></a> CustomGameId

```csharp
public ulong CustomGameId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCustomGamesFriendsPlayedResponse_Types_CustomGame_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCustomGamesFriendsPlayedResponse_Types_CustomGame_HasCustomGameId"></a> HasCustomGameId

```csharp
public bool HasCustomGameId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCustomGamesFriendsPlayedResponse_Types_CustomGame_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientCustomGamesFriendsPlayedResponse.Types.CustomGame> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientCustomGamesFriendsPlayedResponse](Divine.Protobufs.Dota2.CMsgGCToClientCustomGamesFriendsPlayedResponse.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientCustomGamesFriendsPlayedResponse.Types.md).[CustomGame](Divine.Protobufs.Dota2.CMsgGCToClientCustomGamesFriendsPlayedResponse.Types.CustomGame.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCustomGamesFriendsPlayedResponse_Types_CustomGame_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCustomGamesFriendsPlayedResponse_Types_CustomGame_ClearCustomGameId"></a> ClearCustomGameId\(\)

```csharp
public void ClearCustomGameId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCustomGamesFriendsPlayedResponse_Types_CustomGame_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientCustomGamesFriendsPlayedResponse.Types.CustomGame Clone()
```

#### Returns

 [CMsgGCToClientCustomGamesFriendsPlayedResponse](Divine.Protobufs.Dota2.CMsgGCToClientCustomGamesFriendsPlayedResponse.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientCustomGamesFriendsPlayedResponse.Types.md).[CustomGame](Divine.Protobufs.Dota2.CMsgGCToClientCustomGamesFriendsPlayedResponse.Types.CustomGame.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCustomGamesFriendsPlayedResponse_Types_CustomGame_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCustomGamesFriendsPlayedResponse_Types_CustomGame_Equals_Divine_Protobufs_Dota2_CMsgGCToClientCustomGamesFriendsPlayedResponse_Types_CustomGame_"></a> Equals\(CustomGame\)

```csharp
public bool Equals(CMsgGCToClientCustomGamesFriendsPlayedResponse.Types.CustomGame other)
```

#### Parameters

`other` [CMsgGCToClientCustomGamesFriendsPlayedResponse](Divine.Protobufs.Dota2.CMsgGCToClientCustomGamesFriendsPlayedResponse.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientCustomGamesFriendsPlayedResponse.Types.md).[CustomGame](Divine.Protobufs.Dota2.CMsgGCToClientCustomGamesFriendsPlayedResponse.Types.CustomGame.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCustomGamesFriendsPlayedResponse_Types_CustomGame_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCustomGamesFriendsPlayedResponse_Types_CustomGame_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientCustomGamesFriendsPlayedResponse_Types_CustomGame_"></a> MergeFrom\(CustomGame\)

```csharp
public void MergeFrom(CMsgGCToClientCustomGamesFriendsPlayedResponse.Types.CustomGame other)
```

#### Parameters

`other` [CMsgGCToClientCustomGamesFriendsPlayedResponse](Divine.Protobufs.Dota2.CMsgGCToClientCustomGamesFriendsPlayedResponse.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientCustomGamesFriendsPlayedResponse.Types.md).[CustomGame](Divine.Protobufs.Dota2.CMsgGCToClientCustomGamesFriendsPlayedResponse.Types.CustomGame.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCustomGamesFriendsPlayedResponse_Types_CustomGame_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCustomGamesFriendsPlayedResponse_Types_CustomGame_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCustomGamesFriendsPlayedResponse_Types_CustomGame_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

