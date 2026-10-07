# <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_CharacterSelect"></a> Class CMsgFightingGame\_GameData\_CharacterSelect

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgFightingGame_GameData_CharacterSelect : IMessage<CMsgFightingGame_GameData_CharacterSelect>, IEquatable<CMsgFightingGame_GameData_CharacterSelect>, IDeepCloneable<CMsgFightingGame_GameData_CharacterSelect>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgFightingGame\_GameData\_CharacterSelect](Divine.Protobufs.Dota2.CMsgFightingGame\_GameData\_CharacterSelect.md)

#### Implements

IMessage<CMsgFightingGame\_GameData\_CharacterSelect\>, 
[IEquatable<CMsgFightingGame\_GameData\_CharacterSelect\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgFightingGame\_GameData\_CharacterSelect\>, 
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
[EnumerableExtensions.In<CMsgFightingGame\_GameData\_CharacterSelect\>\(CMsgFightingGame\_GameData\_CharacterSelect, params CMsgFightingGame\_GameData\_CharacterSelect\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_CharacterSelect__ctor"></a> CMsgFightingGame\_GameData\_CharacterSelect\(\)

```csharp
public CMsgFightingGame_GameData_CharacterSelect()
```

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_CharacterSelect__ctor_Divine_Protobufs_Dota2_CMsgFightingGame_GameData_CharacterSelect_"></a> CMsgFightingGame\_GameData\_CharacterSelect\(CMsgFightingGame\_GameData\_CharacterSelect\)

```csharp
public CMsgFightingGame_GameData_CharacterSelect(CMsgFightingGame_GameData_CharacterSelect other)
```

#### Parameters

`other` [CMsgFightingGame\_GameData\_CharacterSelect](Divine.Protobufs.Dota2.CMsgFightingGame\_GameData\_CharacterSelect.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_CharacterSelect_ConfirmedStyleFieldNumber"></a> ConfirmedStyleFieldNumber

```csharp
public const int ConfirmedStyleFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_CharacterSelect_CursorIndexFieldNumber"></a> CursorIndexFieldNumber

```csharp
public const int CursorIndexFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_CharacterSelect_EconItemRefsFieldNumber"></a> EconItemRefsFieldNumber

```csharp
public const int EconItemRefsFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_CharacterSelect_MessageAckFieldNumber"></a> MessageAckFieldNumber

```csharp
public const int MessageAckFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_CharacterSelect_SelectedHeroIdFieldNumber"></a> SelectedHeroIdFieldNumber

```csharp
public const int SelectedHeroIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_CharacterSelect_SelectedStyleFieldNumber"></a> SelectedStyleFieldNumber

```csharp
public const int SelectedStyleFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_CharacterSelect_ConfirmedStyle"></a> ConfirmedStyle

```csharp
public bool ConfirmedStyle { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_CharacterSelect_CursorIndex"></a> CursorIndex

```csharp
public uint CursorIndex { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_CharacterSelect_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_CharacterSelect_EconItemRefs"></a> EconItemRefs

```csharp
public RepeatedField<CMsgFightingGame_GameData_CharacterSelect.Types.Item> EconItemRefs { get; }
```

#### Property Value

 RepeatedField<[CMsgFightingGame\_GameData\_CharacterSelect](Divine.Protobufs.Dota2.CMsgFightingGame\_GameData\_CharacterSelect.md).[Types](Divine.Protobufs.Dota2.CMsgFightingGame\_GameData\_CharacterSelect.Types.md).[Item](Divine.Protobufs.Dota2.CMsgFightingGame\_GameData\_CharacterSelect.Types.Item.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_CharacterSelect_HasConfirmedStyle"></a> HasConfirmedStyle

```csharp
public bool HasConfirmedStyle { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_CharacterSelect_HasCursorIndex"></a> HasCursorIndex

```csharp
public bool HasCursorIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_CharacterSelect_HasMessageAck"></a> HasMessageAck

```csharp
public bool HasMessageAck { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_CharacterSelect_HasSelectedHeroId"></a> HasSelectedHeroId

```csharp
public bool HasSelectedHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_CharacterSelect_HasSelectedStyle"></a> HasSelectedStyle

```csharp
public bool HasSelectedStyle { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_CharacterSelect_MessageAck"></a> MessageAck

```csharp
public long MessageAck { get; set; }
```

#### Property Value

 [long](https://learn.microsoft.com/dotnet/api/system.int64)

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_CharacterSelect_Parser"></a> Parser

```csharp
public static MessageParser<CMsgFightingGame_GameData_CharacterSelect> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgFightingGame\_GameData\_CharacterSelect](Divine.Protobufs.Dota2.CMsgFightingGame\_GameData\_CharacterSelect.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_CharacterSelect_SelectedHeroId"></a> SelectedHeroId

```csharp
public int SelectedHeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_CharacterSelect_SelectedStyle"></a> SelectedStyle

```csharp
public uint SelectedStyle { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_CharacterSelect_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_CharacterSelect_ClearConfirmedStyle"></a> ClearConfirmedStyle\(\)

```csharp
public void ClearConfirmedStyle()
```

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_CharacterSelect_ClearCursorIndex"></a> ClearCursorIndex\(\)

```csharp
public void ClearCursorIndex()
```

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_CharacterSelect_ClearMessageAck"></a> ClearMessageAck\(\)

```csharp
public void ClearMessageAck()
```

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_CharacterSelect_ClearSelectedHeroId"></a> ClearSelectedHeroId\(\)

```csharp
public void ClearSelectedHeroId()
```

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_CharacterSelect_ClearSelectedStyle"></a> ClearSelectedStyle\(\)

```csharp
public void ClearSelectedStyle()
```

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_CharacterSelect_Clone"></a> Clone\(\)

```csharp
public CMsgFightingGame_GameData_CharacterSelect Clone()
```

#### Returns

 [CMsgFightingGame\_GameData\_CharacterSelect](Divine.Protobufs.Dota2.CMsgFightingGame\_GameData\_CharacterSelect.md)

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_CharacterSelect_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_CharacterSelect_Equals_Divine_Protobufs_Dota2_CMsgFightingGame_GameData_CharacterSelect_"></a> Equals\(CMsgFightingGame\_GameData\_CharacterSelect\)

```csharp
public bool Equals(CMsgFightingGame_GameData_CharacterSelect other)
```

#### Parameters

`other` [CMsgFightingGame\_GameData\_CharacterSelect](Divine.Protobufs.Dota2.CMsgFightingGame\_GameData\_CharacterSelect.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_CharacterSelect_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_CharacterSelect_MergeFrom_Divine_Protobufs_Dota2_CMsgFightingGame_GameData_CharacterSelect_"></a> MergeFrom\(CMsgFightingGame\_GameData\_CharacterSelect\)

```csharp
public void MergeFrom(CMsgFightingGame_GameData_CharacterSelect other)
```

#### Parameters

`other` [CMsgFightingGame\_GameData\_CharacterSelect](Divine.Protobufs.Dota2.CMsgFightingGame\_GameData\_CharacterSelect.md)

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_CharacterSelect_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_CharacterSelect_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_CharacterSelect_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

