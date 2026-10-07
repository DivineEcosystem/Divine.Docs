# <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_CharacterSelect_Types_Item"></a> Class CMsgFightingGame\_GameData\_CharacterSelect.Types.Item

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgFightingGame_GameData_CharacterSelect.Types.Item : IMessage<CMsgFightingGame_GameData_CharacterSelect.Types.Item>, IEquatable<CMsgFightingGame_GameData_CharacterSelect.Types.Item>, IDeepCloneable<CMsgFightingGame_GameData_CharacterSelect.Types.Item>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgFightingGame\_GameData\_CharacterSelect.Types.Item](Divine.Protobufs.Dota2.CMsgFightingGame\_GameData\_CharacterSelect.Types.Item.md)

#### Implements

IMessage<CMsgFightingGame\_GameData\_CharacterSelect.Types.Item\>, 
[IEquatable<CMsgFightingGame\_GameData\_CharacterSelect.Types.Item\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgFightingGame\_GameData\_CharacterSelect.Types.Item\>, 
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
[EnumerableExtensions.In<CMsgFightingGame\_GameData\_CharacterSelect.Types.Item\>\(CMsgFightingGame\_GameData\_CharacterSelect.Types.Item, params CMsgFightingGame\_GameData\_CharacterSelect.Types.Item\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_CharacterSelect_Types_Item__ctor"></a> Item\(\)

```csharp
public Item()
```

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_CharacterSelect_Types_Item__ctor_Divine_Protobufs_Dota2_CMsgFightingGame_GameData_CharacterSelect_Types_Item_"></a> Item\(Item\)

```csharp
public Item(CMsgFightingGame_GameData_CharacterSelect.Types.Item other)
```

#### Parameters

`other` [CMsgFightingGame\_GameData\_CharacterSelect](Divine.Protobufs.Dota2.CMsgFightingGame\_GameData\_CharacterSelect.md).[Types](Divine.Protobufs.Dota2.CMsgFightingGame\_GameData\_CharacterSelect.Types.md).[Item](Divine.Protobufs.Dota2.CMsgFightingGame\_GameData\_CharacterSelect.Types.Item.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_CharacterSelect_Types_Item_ItemDefFieldNumber"></a> ItemDefFieldNumber

```csharp
public const int ItemDefFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_CharacterSelect_Types_Item_StyleIndexFieldNumber"></a> StyleIndexFieldNumber

```csharp
public const int StyleIndexFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_CharacterSelect_Types_Item_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_CharacterSelect_Types_Item_HasItemDef"></a> HasItemDef

```csharp
public bool HasItemDef { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_CharacterSelect_Types_Item_HasStyleIndex"></a> HasStyleIndex

```csharp
public bool HasStyleIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_CharacterSelect_Types_Item_ItemDef"></a> ItemDef

```csharp
public uint ItemDef { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_CharacterSelect_Types_Item_Parser"></a> Parser

```csharp
public static MessageParser<CMsgFightingGame_GameData_CharacterSelect.Types.Item> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgFightingGame\_GameData\_CharacterSelect](Divine.Protobufs.Dota2.CMsgFightingGame\_GameData\_CharacterSelect.md).[Types](Divine.Protobufs.Dota2.CMsgFightingGame\_GameData\_CharacterSelect.Types.md).[Item](Divine.Protobufs.Dota2.CMsgFightingGame\_GameData\_CharacterSelect.Types.Item.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_CharacterSelect_Types_Item_StyleIndex"></a> StyleIndex

```csharp
public uint StyleIndex { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_CharacterSelect_Types_Item_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_CharacterSelect_Types_Item_ClearItemDef"></a> ClearItemDef\(\)

```csharp
public void ClearItemDef()
```

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_CharacterSelect_Types_Item_ClearStyleIndex"></a> ClearStyleIndex\(\)

```csharp
public void ClearStyleIndex()
```

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_CharacterSelect_Types_Item_Clone"></a> Clone\(\)

```csharp
public CMsgFightingGame_GameData_CharacterSelect.Types.Item Clone()
```

#### Returns

 [CMsgFightingGame\_GameData\_CharacterSelect](Divine.Protobufs.Dota2.CMsgFightingGame\_GameData\_CharacterSelect.md).[Types](Divine.Protobufs.Dota2.CMsgFightingGame\_GameData\_CharacterSelect.Types.md).[Item](Divine.Protobufs.Dota2.CMsgFightingGame\_GameData\_CharacterSelect.Types.Item.md)

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_CharacterSelect_Types_Item_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_CharacterSelect_Types_Item_Equals_Divine_Protobufs_Dota2_CMsgFightingGame_GameData_CharacterSelect_Types_Item_"></a> Equals\(Item\)

```csharp
public bool Equals(CMsgFightingGame_GameData_CharacterSelect.Types.Item other)
```

#### Parameters

`other` [CMsgFightingGame\_GameData\_CharacterSelect](Divine.Protobufs.Dota2.CMsgFightingGame\_GameData\_CharacterSelect.md).[Types](Divine.Protobufs.Dota2.CMsgFightingGame\_GameData\_CharacterSelect.Types.md).[Item](Divine.Protobufs.Dota2.CMsgFightingGame\_GameData\_CharacterSelect.Types.Item.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_CharacterSelect_Types_Item_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_CharacterSelect_Types_Item_MergeFrom_Divine_Protobufs_Dota2_CMsgFightingGame_GameData_CharacterSelect_Types_Item_"></a> MergeFrom\(Item\)

```csharp
public void MergeFrom(CMsgFightingGame_GameData_CharacterSelect.Types.Item other)
```

#### Parameters

`other` [CMsgFightingGame\_GameData\_CharacterSelect](Divine.Protobufs.Dota2.CMsgFightingGame\_GameData\_CharacterSelect.md).[Types](Divine.Protobufs.Dota2.CMsgFightingGame\_GameData\_CharacterSelect.Types.md).[Item](Divine.Protobufs.Dota2.CMsgFightingGame\_GameData\_CharacterSelect.Types.Item.md)

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_CharacterSelect_Types_Item_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_CharacterSelect_Types_Item_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgFightingGame_GameData_CharacterSelect_Types_Item_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

