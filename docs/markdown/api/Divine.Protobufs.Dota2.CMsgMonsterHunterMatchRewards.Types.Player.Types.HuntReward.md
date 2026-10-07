# <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_Types_Player_Types_HuntReward"></a> Class CMsgMonsterHunterMatchRewards.Types.Player.Types.HuntReward

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgMonsterHunterMatchRewards.Types.Player.Types.HuntReward : IMessage<CMsgMonsterHunterMatchRewards.Types.Player.Types.HuntReward>, IEquatable<CMsgMonsterHunterMatchRewards.Types.Player.Types.HuntReward>, IDeepCloneable<CMsgMonsterHunterMatchRewards.Types.Player.Types.HuntReward>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgMonsterHunterMatchRewards.Types.Player.Types.HuntReward](Divine.Protobufs.Dota2.CMsgMonsterHunterMatchRewards.Types.Player.Types.HuntReward.md)

#### Implements

IMessage<CMsgMonsterHunterMatchRewards.Types.Player.Types.HuntReward\>, 
[IEquatable<CMsgMonsterHunterMatchRewards.Types.Player.Types.HuntReward\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgMonsterHunterMatchRewards.Types.Player.Types.HuntReward\>, 
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
[EnumerableExtensions.In<CMsgMonsterHunterMatchRewards.Types.Player.Types.HuntReward\>\(CMsgMonsterHunterMatchRewards.Types.Player.Types.HuntReward, params CMsgMonsterHunterMatchRewards.Types.Player.Types.HuntReward\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_Types_Player_Types_HuntReward__ctor"></a> HuntReward\(\)

```csharp
public HuntReward()
```

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_Types_Player_Types_HuntReward__ctor_Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_Types_Player_Types_HuntReward_"></a> HuntReward\(HuntReward\)

```csharp
public HuntReward(CMsgMonsterHunterMatchRewards.Types.Player.Types.HuntReward other)
```

#### Parameters

`other` [CMsgMonsterHunterMatchRewards](Divine.Protobufs.Dota2.CMsgMonsterHunterMatchRewards.md).[Types](Divine.Protobufs.Dota2.CMsgMonsterHunterMatchRewards.Types.md).[Player](Divine.Protobufs.Dota2.CMsgMonsterHunterMatchRewards.Types.Player.md).[Types](Divine.Protobufs.Dota2.CMsgMonsterHunterMatchRewards.Types.Player.Types.md).[HuntReward](Divine.Protobufs.Dota2.CMsgMonsterHunterMatchRewards.Types.Player.Types.HuntReward.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_Types_Player_Types_HuntReward_HeroIdFieldNumber"></a> HeroIdFieldNumber

```csharp
public const int HeroIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_Types_Player_Types_HuntReward_MaterialsFieldNumber"></a> MaterialsFieldNumber

```csharp
public const int MaterialsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_Types_Player_Types_HuntReward_SuccessFieldNumber"></a> SuccessFieldNumber

```csharp
public const int SuccessFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_Types_Player_Types_HuntReward_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_Types_Player_Types_HuntReward_HasHeroId"></a> HasHeroId

```csharp
public bool HasHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_Types_Player_Types_HuntReward_HasSuccess"></a> HasSuccess

```csharp
public bool HasSuccess { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_Types_Player_Types_HuntReward_HeroId"></a> HeroId

```csharp
public int HeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_Types_Player_Types_HuntReward_Materials"></a> Materials

```csharp
public CMsgMonsterHunterMaterialQuantity Materials { get; set; }
```

#### Property Value

 [CMsgMonsterHunterMaterialQuantity](Divine.Protobufs.Dota2.CMsgMonsterHunterMaterialQuantity.md)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_Types_Player_Types_HuntReward_Parser"></a> Parser

```csharp
public static MessageParser<CMsgMonsterHunterMatchRewards.Types.Player.Types.HuntReward> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgMonsterHunterMatchRewards](Divine.Protobufs.Dota2.CMsgMonsterHunterMatchRewards.md).[Types](Divine.Protobufs.Dota2.CMsgMonsterHunterMatchRewards.Types.md).[Player](Divine.Protobufs.Dota2.CMsgMonsterHunterMatchRewards.Types.Player.md).[Types](Divine.Protobufs.Dota2.CMsgMonsterHunterMatchRewards.Types.Player.Types.md).[HuntReward](Divine.Protobufs.Dota2.CMsgMonsterHunterMatchRewards.Types.Player.Types.HuntReward.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_Types_Player_Types_HuntReward_Success"></a> Success

```csharp
public bool Success { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_Types_Player_Types_HuntReward_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_Types_Player_Types_HuntReward_ClearHeroId"></a> ClearHeroId\(\)

```csharp
public void ClearHeroId()
```

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_Types_Player_Types_HuntReward_ClearSuccess"></a> ClearSuccess\(\)

```csharp
public void ClearSuccess()
```

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_Types_Player_Types_HuntReward_Clone"></a> Clone\(\)

```csharp
public CMsgMonsterHunterMatchRewards.Types.Player.Types.HuntReward Clone()
```

#### Returns

 [CMsgMonsterHunterMatchRewards](Divine.Protobufs.Dota2.CMsgMonsterHunterMatchRewards.md).[Types](Divine.Protobufs.Dota2.CMsgMonsterHunterMatchRewards.Types.md).[Player](Divine.Protobufs.Dota2.CMsgMonsterHunterMatchRewards.Types.Player.md).[Types](Divine.Protobufs.Dota2.CMsgMonsterHunterMatchRewards.Types.Player.Types.md).[HuntReward](Divine.Protobufs.Dota2.CMsgMonsterHunterMatchRewards.Types.Player.Types.HuntReward.md)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_Types_Player_Types_HuntReward_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_Types_Player_Types_HuntReward_Equals_Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_Types_Player_Types_HuntReward_"></a> Equals\(HuntReward\)

```csharp
public bool Equals(CMsgMonsterHunterMatchRewards.Types.Player.Types.HuntReward other)
```

#### Parameters

`other` [CMsgMonsterHunterMatchRewards](Divine.Protobufs.Dota2.CMsgMonsterHunterMatchRewards.md).[Types](Divine.Protobufs.Dota2.CMsgMonsterHunterMatchRewards.Types.md).[Player](Divine.Protobufs.Dota2.CMsgMonsterHunterMatchRewards.Types.Player.md).[Types](Divine.Protobufs.Dota2.CMsgMonsterHunterMatchRewards.Types.Player.Types.md).[HuntReward](Divine.Protobufs.Dota2.CMsgMonsterHunterMatchRewards.Types.Player.Types.HuntReward.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_Types_Player_Types_HuntReward_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_Types_Player_Types_HuntReward_MergeFrom_Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_Types_Player_Types_HuntReward_"></a> MergeFrom\(HuntReward\)

```csharp
public void MergeFrom(CMsgMonsterHunterMatchRewards.Types.Player.Types.HuntReward other)
```

#### Parameters

`other` [CMsgMonsterHunterMatchRewards](Divine.Protobufs.Dota2.CMsgMonsterHunterMatchRewards.md).[Types](Divine.Protobufs.Dota2.CMsgMonsterHunterMatchRewards.Types.md).[Player](Divine.Protobufs.Dota2.CMsgMonsterHunterMatchRewards.Types.Player.md).[Types](Divine.Protobufs.Dota2.CMsgMonsterHunterMatchRewards.Types.Player.Types.md).[HuntReward](Divine.Protobufs.Dota2.CMsgMonsterHunterMatchRewards.Types.Player.Types.HuntReward.md)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_Types_Player_Types_HuntReward_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_Types_Player_Types_HuntReward_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMatchRewards_Types_Player_Types_HuntReward_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

