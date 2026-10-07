# <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardList_Types_CardBonus"></a> Class CMsgDOTAFantasyCardList.Types.CardBonus

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAFantasyCardList.Types.CardBonus : IMessage<CMsgDOTAFantasyCardList.Types.CardBonus>, IEquatable<CMsgDOTAFantasyCardList.Types.CardBonus>, IDeepCloneable<CMsgDOTAFantasyCardList.Types.CardBonus>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAFantasyCardList.Types.CardBonus](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardList.Types.CardBonus.md)

#### Implements

IMessage<CMsgDOTAFantasyCardList.Types.CardBonus\>, 
[IEquatable<CMsgDOTAFantasyCardList.Types.CardBonus\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAFantasyCardList.Types.CardBonus\>, 
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
[EnumerableExtensions.In<CMsgDOTAFantasyCardList.Types.CardBonus\>\(CMsgDOTAFantasyCardList.Types.CardBonus, params CMsgDOTAFantasyCardList.Types.CardBonus\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardList_Types_CardBonus__ctor"></a> CardBonus\(\)

```csharp
public CardBonus()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardList_Types_CardBonus__ctor_Divine_Protobufs_Dota2_CMsgDOTAFantasyCardList_Types_CardBonus_"></a> CardBonus\(CardBonus\)

```csharp
public CardBonus(CMsgDOTAFantasyCardList.Types.CardBonus other)
```

#### Parameters

`other` [CMsgDOTAFantasyCardList](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardList.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardList.Types.md).[CardBonus](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardList.Types.CardBonus.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardList_Types_CardBonus_BonusStatFieldNumber"></a> BonusStatFieldNumber

```csharp
public const int BonusStatFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardList_Types_CardBonus_BonusValueFieldNumber"></a> BonusValueFieldNumber

```csharp
public const int BonusValueFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardList_Types_CardBonus_BonusStat"></a> BonusStat

```csharp
public uint BonusStat { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardList_Types_CardBonus_BonusValue"></a> BonusValue

```csharp
public uint BonusValue { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardList_Types_CardBonus_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardList_Types_CardBonus_HasBonusStat"></a> HasBonusStat

```csharp
public bool HasBonusStat { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardList_Types_CardBonus_HasBonusValue"></a> HasBonusValue

```csharp
public bool HasBonusValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardList_Types_CardBonus_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAFantasyCardList.Types.CardBonus> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAFantasyCardList](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardList.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardList.Types.md).[CardBonus](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardList.Types.CardBonus.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardList_Types_CardBonus_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardList_Types_CardBonus_ClearBonusStat"></a> ClearBonusStat\(\)

```csharp
public void ClearBonusStat()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardList_Types_CardBonus_ClearBonusValue"></a> ClearBonusValue\(\)

```csharp
public void ClearBonusValue()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardList_Types_CardBonus_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAFantasyCardList.Types.CardBonus Clone()
```

#### Returns

 [CMsgDOTAFantasyCardList](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardList.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardList.Types.md).[CardBonus](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardList.Types.CardBonus.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardList_Types_CardBonus_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardList_Types_CardBonus_Equals_Divine_Protobufs_Dota2_CMsgDOTAFantasyCardList_Types_CardBonus_"></a> Equals\(CardBonus\)

```csharp
public bool Equals(CMsgDOTAFantasyCardList.Types.CardBonus other)
```

#### Parameters

`other` [CMsgDOTAFantasyCardList](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardList.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardList.Types.md).[CardBonus](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardList.Types.CardBonus.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardList_Types_CardBonus_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardList_Types_CardBonus_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAFantasyCardList_Types_CardBonus_"></a> MergeFrom\(CardBonus\)

```csharp
public void MergeFrom(CMsgDOTAFantasyCardList.Types.CardBonus other)
```

#### Parameters

`other` [CMsgDOTAFantasyCardList](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardList.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardList.Types.md).[CardBonus](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardList.Types.CardBonus.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardList_Types_CardBonus_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardList_Types_CardBonus_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardList_Types_CardBonus_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

