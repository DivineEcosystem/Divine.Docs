# <a id="Divine_Protobufs_Dota2_CMsgSQLUpgradeBattleBooster"></a> Class CMsgSQLUpgradeBattleBooster

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSQLUpgradeBattleBooster : IMessage<CMsgSQLUpgradeBattleBooster>, IEquatable<CMsgSQLUpgradeBattleBooster>, IDeepCloneable<CMsgSQLUpgradeBattleBooster>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSQLUpgradeBattleBooster](Divine.Protobufs.Dota2.CMsgSQLUpgradeBattleBooster.md)

#### Implements

IMessage<CMsgSQLUpgradeBattleBooster\>, 
[IEquatable<CMsgSQLUpgradeBattleBooster\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSQLUpgradeBattleBooster\>, 
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
[EnumerableExtensions.In<CMsgSQLUpgradeBattleBooster\>\(CMsgSQLUpgradeBattleBooster, params CMsgSQLUpgradeBattleBooster\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSQLUpgradeBattleBooster__ctor"></a> CMsgSQLUpgradeBattleBooster\(\)

```csharp
public CMsgSQLUpgradeBattleBooster()
```

### <a id="Divine_Protobufs_Dota2_CMsgSQLUpgradeBattleBooster__ctor_Divine_Protobufs_Dota2_CMsgSQLUpgradeBattleBooster_"></a> CMsgSQLUpgradeBattleBooster\(CMsgSQLUpgradeBattleBooster\)

```csharp
public CMsgSQLUpgradeBattleBooster(CMsgSQLUpgradeBattleBooster other)
```

#### Parameters

`other` [CMsgSQLUpgradeBattleBooster](Divine.Protobufs.Dota2.CMsgSQLUpgradeBattleBooster.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSQLUpgradeBattleBooster_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSQLUpgradeBattleBooster_BonusToAddFieldNumber"></a> BonusToAddFieldNumber

```csharp
public const int BonusToAddFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSQLUpgradeBattleBooster_BoosterTypeFieldNumber"></a> BoosterTypeFieldNumber

```csharp
public const int BoosterTypeFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSQLUpgradeBattleBooster_ItemDefFieldNumber"></a> ItemDefFieldNumber

```csharp
public const int ItemDefFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSQLUpgradeBattleBooster_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSQLUpgradeBattleBooster_BonusToAdd"></a> BonusToAdd

```csharp
public float BonusToAdd { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgSQLUpgradeBattleBooster_BoosterType"></a> BoosterType

```csharp
public uint BoosterType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSQLUpgradeBattleBooster_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSQLUpgradeBattleBooster_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSQLUpgradeBattleBooster_HasBonusToAdd"></a> HasBonusToAdd

```csharp
public bool HasBonusToAdd { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSQLUpgradeBattleBooster_HasBoosterType"></a> HasBoosterType

```csharp
public bool HasBoosterType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSQLUpgradeBattleBooster_HasItemDef"></a> HasItemDef

```csharp
public bool HasItemDef { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSQLUpgradeBattleBooster_ItemDef"></a> ItemDef

```csharp
public uint ItemDef { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSQLUpgradeBattleBooster_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSQLUpgradeBattleBooster> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSQLUpgradeBattleBooster](Divine.Protobufs.Dota2.CMsgSQLUpgradeBattleBooster.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSQLUpgradeBattleBooster_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSQLUpgradeBattleBooster_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSQLUpgradeBattleBooster_ClearBonusToAdd"></a> ClearBonusToAdd\(\)

```csharp
public void ClearBonusToAdd()
```

### <a id="Divine_Protobufs_Dota2_CMsgSQLUpgradeBattleBooster_ClearBoosterType"></a> ClearBoosterType\(\)

```csharp
public void ClearBoosterType()
```

### <a id="Divine_Protobufs_Dota2_CMsgSQLUpgradeBattleBooster_ClearItemDef"></a> ClearItemDef\(\)

```csharp
public void ClearItemDef()
```

### <a id="Divine_Protobufs_Dota2_CMsgSQLUpgradeBattleBooster_Clone"></a> Clone\(\)

```csharp
public CMsgSQLUpgradeBattleBooster Clone()
```

#### Returns

 [CMsgSQLUpgradeBattleBooster](Divine.Protobufs.Dota2.CMsgSQLUpgradeBattleBooster.md)

### <a id="Divine_Protobufs_Dota2_CMsgSQLUpgradeBattleBooster_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSQLUpgradeBattleBooster_Equals_Divine_Protobufs_Dota2_CMsgSQLUpgradeBattleBooster_"></a> Equals\(CMsgSQLUpgradeBattleBooster\)

```csharp
public bool Equals(CMsgSQLUpgradeBattleBooster other)
```

#### Parameters

`other` [CMsgSQLUpgradeBattleBooster](Divine.Protobufs.Dota2.CMsgSQLUpgradeBattleBooster.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSQLUpgradeBattleBooster_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSQLUpgradeBattleBooster_MergeFrom_Divine_Protobufs_Dota2_CMsgSQLUpgradeBattleBooster_"></a> MergeFrom\(CMsgSQLUpgradeBattleBooster\)

```csharp
public void MergeFrom(CMsgSQLUpgradeBattleBooster other)
```

#### Parameters

`other` [CMsgSQLUpgradeBattleBooster](Divine.Protobufs.Dota2.CMsgSQLUpgradeBattleBooster.md)

### <a id="Divine_Protobufs_Dota2_CMsgSQLUpgradeBattleBooster_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSQLUpgradeBattleBooster_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSQLUpgradeBattleBooster_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

