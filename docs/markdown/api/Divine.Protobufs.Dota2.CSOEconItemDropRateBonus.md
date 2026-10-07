# <a id="Divine_Protobufs_Dota2_CSOEconItemDropRateBonus"></a> Class CSOEconItemDropRateBonus

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSOEconItemDropRateBonus : IMessage<CSOEconItemDropRateBonus>, IEquatable<CSOEconItemDropRateBonus>, IDeepCloneable<CSOEconItemDropRateBonus>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSOEconItemDropRateBonus](Divine.Protobufs.Dota2.CSOEconItemDropRateBonus.md)

#### Implements

IMessage<CSOEconItemDropRateBonus\>, 
[IEquatable<CSOEconItemDropRateBonus\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSOEconItemDropRateBonus\>, 
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
[EnumerableExtensions.In<CSOEconItemDropRateBonus\>\(CSOEconItemDropRateBonus, params CSOEconItemDropRateBonus\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSOEconItemDropRateBonus__ctor"></a> CSOEconItemDropRateBonus\(\)

```csharp
public CSOEconItemDropRateBonus()
```

### <a id="Divine_Protobufs_Dota2_CSOEconItemDropRateBonus__ctor_Divine_Protobufs_Dota2_CSOEconItemDropRateBonus_"></a> CSOEconItemDropRateBonus\(CSOEconItemDropRateBonus\)

```csharp
public CSOEconItemDropRateBonus(CSOEconItemDropRateBonus other)
```

#### Parameters

`other` [CSOEconItemDropRateBonus](Divine.Protobufs.Dota2.CSOEconItemDropRateBonus.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSOEconItemDropRateBonus_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSOEconItemDropRateBonus_BonusCountFieldNumber"></a> BonusCountFieldNumber

```csharp
public const int BonusCountFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSOEconItemDropRateBonus_BonusFieldNumber"></a> BonusFieldNumber

```csharp
public const int BonusFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSOEconItemDropRateBonus_BoosterTypeFieldNumber"></a> BoosterTypeFieldNumber

```csharp
public const int BoosterTypeFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSOEconItemDropRateBonus_DefIndexFieldNumber"></a> DefIndexFieldNumber

```csharp
public const int DefIndexFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSOEconItemDropRateBonus_ExpirationDateFieldNumber"></a> ExpirationDateFieldNumber

```csharp
public const int ExpirationDateFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSOEconItemDropRateBonus_ItemIdFieldNumber"></a> ItemIdFieldNumber

```csharp
public const int ItemIdFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSOEconItemDropRateBonus_SecondsLeftFieldNumber"></a> SecondsLeftFieldNumber

```csharp
public const int SecondsLeftFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSOEconItemDropRateBonus_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSOEconItemDropRateBonus_Bonus"></a> Bonus

```csharp
public float Bonus { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CSOEconItemDropRateBonus_BonusCount"></a> BonusCount

```csharp
public uint BonusCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSOEconItemDropRateBonus_BoosterType"></a> BoosterType

```csharp
public uint BoosterType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSOEconItemDropRateBonus_DefIndex"></a> DefIndex

```csharp
public uint DefIndex { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSOEconItemDropRateBonus_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSOEconItemDropRateBonus_ExpirationDate"></a> ExpirationDate

```csharp
public uint ExpirationDate { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSOEconItemDropRateBonus_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSOEconItemDropRateBonus_HasBonus"></a> HasBonus

```csharp
public bool HasBonus { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSOEconItemDropRateBonus_HasBonusCount"></a> HasBonusCount

```csharp
public bool HasBonusCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSOEconItemDropRateBonus_HasBoosterType"></a> HasBoosterType

```csharp
public bool HasBoosterType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSOEconItemDropRateBonus_HasDefIndex"></a> HasDefIndex

```csharp
public bool HasDefIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSOEconItemDropRateBonus_HasExpirationDate"></a> HasExpirationDate

```csharp
public bool HasExpirationDate { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSOEconItemDropRateBonus_HasItemId"></a> HasItemId

```csharp
public bool HasItemId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSOEconItemDropRateBonus_HasSecondsLeft"></a> HasSecondsLeft

```csharp
public bool HasSecondsLeft { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSOEconItemDropRateBonus_ItemId"></a> ItemId

```csharp
public ulong ItemId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CSOEconItemDropRateBonus_Parser"></a> Parser

```csharp
public static MessageParser<CSOEconItemDropRateBonus> Parser { get; }
```

#### Property Value

 MessageParser<[CSOEconItemDropRateBonus](Divine.Protobufs.Dota2.CSOEconItemDropRateBonus.md)\>

### <a id="Divine_Protobufs_Dota2_CSOEconItemDropRateBonus_SecondsLeft"></a> SecondsLeft

```csharp
public uint SecondsLeft { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CSOEconItemDropRateBonus_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSOEconItemDropRateBonus_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CSOEconItemDropRateBonus_ClearBonus"></a> ClearBonus\(\)

```csharp
public void ClearBonus()
```

### <a id="Divine_Protobufs_Dota2_CSOEconItemDropRateBonus_ClearBonusCount"></a> ClearBonusCount\(\)

```csharp
public void ClearBonusCount()
```

### <a id="Divine_Protobufs_Dota2_CSOEconItemDropRateBonus_ClearBoosterType"></a> ClearBoosterType\(\)

```csharp
public void ClearBoosterType()
```

### <a id="Divine_Protobufs_Dota2_CSOEconItemDropRateBonus_ClearDefIndex"></a> ClearDefIndex\(\)

```csharp
public void ClearDefIndex()
```

### <a id="Divine_Protobufs_Dota2_CSOEconItemDropRateBonus_ClearExpirationDate"></a> ClearExpirationDate\(\)

```csharp
public void ClearExpirationDate()
```

### <a id="Divine_Protobufs_Dota2_CSOEconItemDropRateBonus_ClearItemId"></a> ClearItemId\(\)

```csharp
public void ClearItemId()
```

### <a id="Divine_Protobufs_Dota2_CSOEconItemDropRateBonus_ClearSecondsLeft"></a> ClearSecondsLeft\(\)

```csharp
public void ClearSecondsLeft()
```

### <a id="Divine_Protobufs_Dota2_CSOEconItemDropRateBonus_Clone"></a> Clone\(\)

```csharp
public CSOEconItemDropRateBonus Clone()
```

#### Returns

 [CSOEconItemDropRateBonus](Divine.Protobufs.Dota2.CSOEconItemDropRateBonus.md)

### <a id="Divine_Protobufs_Dota2_CSOEconItemDropRateBonus_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSOEconItemDropRateBonus_Equals_Divine_Protobufs_Dota2_CSOEconItemDropRateBonus_"></a> Equals\(CSOEconItemDropRateBonus\)

```csharp
public bool Equals(CSOEconItemDropRateBonus other)
```

#### Parameters

`other` [CSOEconItemDropRateBonus](Divine.Protobufs.Dota2.CSOEconItemDropRateBonus.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSOEconItemDropRateBonus_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSOEconItemDropRateBonus_MergeFrom_Divine_Protobufs_Dota2_CSOEconItemDropRateBonus_"></a> MergeFrom\(CSOEconItemDropRateBonus\)

```csharp
public void MergeFrom(CSOEconItemDropRateBonus other)
```

#### Parameters

`other` [CSOEconItemDropRateBonus](Divine.Protobufs.Dota2.CSOEconItemDropRateBonus.md)

### <a id="Divine_Protobufs_Dota2_CSOEconItemDropRateBonus_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSOEconItemDropRateBonus_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSOEconItemDropRateBonus_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

