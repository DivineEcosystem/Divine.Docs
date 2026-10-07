# <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI8_Types_Wagering"></a> Class CMsgGCToClientBattlePassRollup\_TI8.Types.Wagering

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientBattlePassRollup_TI8.Types.Wagering : IMessage<CMsgGCToClientBattlePassRollup_TI8.Types.Wagering>, IEquatable<CMsgGCToClientBattlePassRollup_TI8.Types.Wagering>, IDeepCloneable<CMsgGCToClientBattlePassRollup_TI8.Types.Wagering>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientBattlePassRollup\_TI8.Types.Wagering](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_TI8.Types.Wagering.md)

#### Implements

IMessage<CMsgGCToClientBattlePassRollup\_TI8.Types.Wagering\>, 
[IEquatable<CMsgGCToClientBattlePassRollup\_TI8.Types.Wagering\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientBattlePassRollup\_TI8.Types.Wagering\>, 
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
[EnumerableExtensions.In<CMsgGCToClientBattlePassRollup\_TI8.Types.Wagering\>\(CMsgGCToClientBattlePassRollup\_TI8.Types.Wagering, params CMsgGCToClientBattlePassRollup\_TI8.Types.Wagering\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI8_Types_Wagering__ctor"></a> Wagering\(\)

```csharp
public Wagering()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI8_Types_Wagering__ctor_Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI8_Types_Wagering_"></a> Wagering\(Wagering\)

```csharp
public Wagering(CMsgGCToClientBattlePassRollup_TI8.Types.Wagering other)
```

#### Parameters

`other` [CMsgGCToClientBattlePassRollup\_TI8](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_TI8.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_TI8.Types.md).[Wagering](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_TI8.Types.Wagering.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI8_Types_Wagering_AverageWonFieldNumber"></a> AverageWonFieldNumber

```csharp
public const int AverageWonFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI8_Types_Wagering_SuccessRateFieldNumber"></a> SuccessRateFieldNumber

```csharp
public const int SuccessRateFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI8_Types_Wagering_TotalTipsFieldNumber"></a> TotalTipsFieldNumber

```csharp
public const int TotalTipsFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI8_Types_Wagering_TotalWageredFieldNumber"></a> TotalWageredFieldNumber

```csharp
public const int TotalWageredFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI8_Types_Wagering_TotalWonFieldNumber"></a> TotalWonFieldNumber

```csharp
public const int TotalWonFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI8_Types_Wagering_AverageWon"></a> AverageWon

```csharp
public uint AverageWon { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI8_Types_Wagering_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI8_Types_Wagering_HasAverageWon"></a> HasAverageWon

```csharp
public bool HasAverageWon { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI8_Types_Wagering_HasSuccessRate"></a> HasSuccessRate

```csharp
public bool HasSuccessRate { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI8_Types_Wagering_HasTotalTips"></a> HasTotalTips

```csharp
public bool HasTotalTips { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI8_Types_Wagering_HasTotalWagered"></a> HasTotalWagered

```csharp
public bool HasTotalWagered { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI8_Types_Wagering_HasTotalWon"></a> HasTotalWon

```csharp
public bool HasTotalWon { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI8_Types_Wagering_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientBattlePassRollup_TI8.Types.Wagering> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientBattlePassRollup\_TI8](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_TI8.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_TI8.Types.md).[Wagering](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_TI8.Types.Wagering.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI8_Types_Wagering_SuccessRate"></a> SuccessRate

```csharp
public uint SuccessRate { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI8_Types_Wagering_TotalTips"></a> TotalTips

```csharp
public uint TotalTips { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI8_Types_Wagering_TotalWagered"></a> TotalWagered

```csharp
public uint TotalWagered { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI8_Types_Wagering_TotalWon"></a> TotalWon

```csharp
public uint TotalWon { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI8_Types_Wagering_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI8_Types_Wagering_ClearAverageWon"></a> ClearAverageWon\(\)

```csharp
public void ClearAverageWon()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI8_Types_Wagering_ClearSuccessRate"></a> ClearSuccessRate\(\)

```csharp
public void ClearSuccessRate()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI8_Types_Wagering_ClearTotalTips"></a> ClearTotalTips\(\)

```csharp
public void ClearTotalTips()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI8_Types_Wagering_ClearTotalWagered"></a> ClearTotalWagered\(\)

```csharp
public void ClearTotalWagered()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI8_Types_Wagering_ClearTotalWon"></a> ClearTotalWon\(\)

```csharp
public void ClearTotalWon()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI8_Types_Wagering_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientBattlePassRollup_TI8.Types.Wagering Clone()
```

#### Returns

 [CMsgGCToClientBattlePassRollup\_TI8](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_TI8.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_TI8.Types.md).[Wagering](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_TI8.Types.Wagering.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI8_Types_Wagering_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI8_Types_Wagering_Equals_Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI8_Types_Wagering_"></a> Equals\(Wagering\)

```csharp
public bool Equals(CMsgGCToClientBattlePassRollup_TI8.Types.Wagering other)
```

#### Parameters

`other` [CMsgGCToClientBattlePassRollup\_TI8](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_TI8.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_TI8.Types.md).[Wagering](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_TI8.Types.Wagering.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI8_Types_Wagering_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI8_Types_Wagering_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI8_Types_Wagering_"></a> MergeFrom\(Wagering\)

```csharp
public void MergeFrom(CMsgGCToClientBattlePassRollup_TI8.Types.Wagering other)
```

#### Parameters

`other` [CMsgGCToClientBattlePassRollup\_TI8](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_TI8.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_TI8.Types.md).[Wagering](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_TI8.Types.Wagering.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI8_Types_Wagering_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI8_Types_Wagering_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI8_Types_Wagering_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

