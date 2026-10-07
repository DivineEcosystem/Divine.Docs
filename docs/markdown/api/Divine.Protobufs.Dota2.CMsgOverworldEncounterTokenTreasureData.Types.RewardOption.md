# <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterTokenTreasureData_Types_RewardOption"></a> Class CMsgOverworldEncounterTokenTreasureData.Types.RewardOption

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgOverworldEncounterTokenTreasureData.Types.RewardOption : IMessage<CMsgOverworldEncounterTokenTreasureData.Types.RewardOption>, IEquatable<CMsgOverworldEncounterTokenTreasureData.Types.RewardOption>, IDeepCloneable<CMsgOverworldEncounterTokenTreasureData.Types.RewardOption>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgOverworldEncounterTokenTreasureData.Types.RewardOption](Divine.Protobufs.Dota2.CMsgOverworldEncounterTokenTreasureData.Types.RewardOption.md)

#### Implements

IMessage<CMsgOverworldEncounterTokenTreasureData.Types.RewardOption\>, 
[IEquatable<CMsgOverworldEncounterTokenTreasureData.Types.RewardOption\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgOverworldEncounterTokenTreasureData.Types.RewardOption\>, 
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
[EnumerableExtensions.In<CMsgOverworldEncounterTokenTreasureData.Types.RewardOption\>\(CMsgOverworldEncounterTokenTreasureData.Types.RewardOption, params CMsgOverworldEncounterTokenTreasureData.Types.RewardOption\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterTokenTreasureData_Types_RewardOption__ctor"></a> RewardOption\(\)

```csharp
public RewardOption()
```

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterTokenTreasureData_Types_RewardOption__ctor_Divine_Protobufs_Dota2_CMsgOverworldEncounterTokenTreasureData_Types_RewardOption_"></a> RewardOption\(RewardOption\)

```csharp
public RewardOption(CMsgOverworldEncounterTokenTreasureData.Types.RewardOption other)
```

#### Parameters

`other` [CMsgOverworldEncounterTokenTreasureData](Divine.Protobufs.Dota2.CMsgOverworldEncounterTokenTreasureData.md).[Types](Divine.Protobufs.Dota2.CMsgOverworldEncounterTokenTreasureData.Types.md).[RewardOption](Divine.Protobufs.Dota2.CMsgOverworldEncounterTokenTreasureData.Types.RewardOption.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterTokenTreasureData_Types_RewardOption_RewardDataFieldNumber"></a> RewardDataFieldNumber

```csharp
public const int RewardDataFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterTokenTreasureData_Types_RewardOption_TokenCostFieldNumber"></a> TokenCostFieldNumber

```csharp
public const int TokenCostFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterTokenTreasureData_Types_RewardOption_TokenRewardFieldNumber"></a> TokenRewardFieldNumber

```csharp
public const int TokenRewardFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterTokenTreasureData_Types_RewardOption_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterTokenTreasureData_Types_RewardOption_HasRewardData"></a> HasRewardData

```csharp
public bool HasRewardData { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterTokenTreasureData_Types_RewardOption_Parser"></a> Parser

```csharp
public static MessageParser<CMsgOverworldEncounterTokenTreasureData.Types.RewardOption> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgOverworldEncounterTokenTreasureData](Divine.Protobufs.Dota2.CMsgOverworldEncounterTokenTreasureData.md).[Types](Divine.Protobufs.Dota2.CMsgOverworldEncounterTokenTreasureData.Types.md).[RewardOption](Divine.Protobufs.Dota2.CMsgOverworldEncounterTokenTreasureData.Types.RewardOption.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterTokenTreasureData_Types_RewardOption_RewardData"></a> RewardData

```csharp
public uint RewardData { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterTokenTreasureData_Types_RewardOption_TokenCost"></a> TokenCost

```csharp
public CMsgOverworldTokenQuantity TokenCost { get; set; }
```

#### Property Value

 [CMsgOverworldTokenQuantity](Divine.Protobufs.Dota2.CMsgOverworldTokenQuantity.md)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterTokenTreasureData_Types_RewardOption_TokenReward"></a> TokenReward

```csharp
public CMsgOverworldTokenQuantity TokenReward { get; set; }
```

#### Property Value

 [CMsgOverworldTokenQuantity](Divine.Protobufs.Dota2.CMsgOverworldTokenQuantity.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterTokenTreasureData_Types_RewardOption_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterTokenTreasureData_Types_RewardOption_ClearRewardData"></a> ClearRewardData\(\)

```csharp
public void ClearRewardData()
```

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterTokenTreasureData_Types_RewardOption_Clone"></a> Clone\(\)

```csharp
public CMsgOverworldEncounterTokenTreasureData.Types.RewardOption Clone()
```

#### Returns

 [CMsgOverworldEncounterTokenTreasureData](Divine.Protobufs.Dota2.CMsgOverworldEncounterTokenTreasureData.md).[Types](Divine.Protobufs.Dota2.CMsgOverworldEncounterTokenTreasureData.Types.md).[RewardOption](Divine.Protobufs.Dota2.CMsgOverworldEncounterTokenTreasureData.Types.RewardOption.md)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterTokenTreasureData_Types_RewardOption_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterTokenTreasureData_Types_RewardOption_Equals_Divine_Protobufs_Dota2_CMsgOverworldEncounterTokenTreasureData_Types_RewardOption_"></a> Equals\(RewardOption\)

```csharp
public bool Equals(CMsgOverworldEncounterTokenTreasureData.Types.RewardOption other)
```

#### Parameters

`other` [CMsgOverworldEncounterTokenTreasureData](Divine.Protobufs.Dota2.CMsgOverworldEncounterTokenTreasureData.md).[Types](Divine.Protobufs.Dota2.CMsgOverworldEncounterTokenTreasureData.Types.md).[RewardOption](Divine.Protobufs.Dota2.CMsgOverworldEncounterTokenTreasureData.Types.RewardOption.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterTokenTreasureData_Types_RewardOption_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterTokenTreasureData_Types_RewardOption_MergeFrom_Divine_Protobufs_Dota2_CMsgOverworldEncounterTokenTreasureData_Types_RewardOption_"></a> MergeFrom\(RewardOption\)

```csharp
public void MergeFrom(CMsgOverworldEncounterTokenTreasureData.Types.RewardOption other)
```

#### Parameters

`other` [CMsgOverworldEncounterTokenTreasureData](Divine.Protobufs.Dota2.CMsgOverworldEncounterTokenTreasureData.md).[Types](Divine.Protobufs.Dota2.CMsgOverworldEncounterTokenTreasureData.Types.md).[RewardOption](Divine.Protobufs.Dota2.CMsgOverworldEncounterTokenTreasureData.Types.RewardOption.md)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterTokenTreasureData_Types_RewardOption_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterTokenTreasureData_Types_RewardOption_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterTokenTreasureData_Types_RewardOption_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

