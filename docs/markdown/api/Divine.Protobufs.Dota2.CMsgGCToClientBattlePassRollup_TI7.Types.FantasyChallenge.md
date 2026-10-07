# <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI7_Types_FantasyChallenge"></a> Class CMsgGCToClientBattlePassRollup\_TI7.Types.FantasyChallenge

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientBattlePassRollup_TI7.Types.FantasyChallenge : IMessage<CMsgGCToClientBattlePassRollup_TI7.Types.FantasyChallenge>, IEquatable<CMsgGCToClientBattlePassRollup_TI7.Types.FantasyChallenge>, IDeepCloneable<CMsgGCToClientBattlePassRollup_TI7.Types.FantasyChallenge>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientBattlePassRollup\_TI7.Types.FantasyChallenge](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_TI7.Types.FantasyChallenge.md)

#### Implements

IMessage<CMsgGCToClientBattlePassRollup\_TI7.Types.FantasyChallenge\>, 
[IEquatable<CMsgGCToClientBattlePassRollup\_TI7.Types.FantasyChallenge\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientBattlePassRollup\_TI7.Types.FantasyChallenge\>, 
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
[EnumerableExtensions.In<CMsgGCToClientBattlePassRollup\_TI7.Types.FantasyChallenge\>\(CMsgGCToClientBattlePassRollup\_TI7.Types.FantasyChallenge, params CMsgGCToClientBattlePassRollup\_TI7.Types.FantasyChallenge\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI7_Types_FantasyChallenge__ctor"></a> FantasyChallenge\(\)

```csharp
public FantasyChallenge()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI7_Types_FantasyChallenge__ctor_Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI7_Types_FantasyChallenge_"></a> FantasyChallenge\(FantasyChallenge\)

```csharp
public FantasyChallenge(CMsgGCToClientBattlePassRollup_TI7.Types.FantasyChallenge other)
```

#### Parameters

`other` [CMsgGCToClientBattlePassRollup\_TI7](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_TI7.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_TI7.Types.md).[FantasyChallenge](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_TI7.Types.FantasyChallenge.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI7_Types_FantasyChallenge_PercentileFieldNumber"></a> PercentileFieldNumber

```csharp
public const int PercentileFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI7_Types_FantasyChallenge_TotalScoreFieldNumber"></a> TotalScoreFieldNumber

```csharp
public const int TotalScoreFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI7_Types_FantasyChallenge_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI7_Types_FantasyChallenge_HasPercentile"></a> HasPercentile

```csharp
public bool HasPercentile { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI7_Types_FantasyChallenge_HasTotalScore"></a> HasTotalScore

```csharp
public bool HasTotalScore { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI7_Types_FantasyChallenge_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientBattlePassRollup_TI7.Types.FantasyChallenge> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientBattlePassRollup\_TI7](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_TI7.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_TI7.Types.md).[FantasyChallenge](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_TI7.Types.FantasyChallenge.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI7_Types_FantasyChallenge_Percentile"></a> Percentile

```csharp
public float Percentile { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI7_Types_FantasyChallenge_TotalScore"></a> TotalScore

```csharp
public float TotalScore { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI7_Types_FantasyChallenge_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI7_Types_FantasyChallenge_ClearPercentile"></a> ClearPercentile\(\)

```csharp
public void ClearPercentile()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI7_Types_FantasyChallenge_ClearTotalScore"></a> ClearTotalScore\(\)

```csharp
public void ClearTotalScore()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI7_Types_FantasyChallenge_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientBattlePassRollup_TI7.Types.FantasyChallenge Clone()
```

#### Returns

 [CMsgGCToClientBattlePassRollup\_TI7](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_TI7.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_TI7.Types.md).[FantasyChallenge](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_TI7.Types.FantasyChallenge.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI7_Types_FantasyChallenge_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI7_Types_FantasyChallenge_Equals_Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI7_Types_FantasyChallenge_"></a> Equals\(FantasyChallenge\)

```csharp
public bool Equals(CMsgGCToClientBattlePassRollup_TI7.Types.FantasyChallenge other)
```

#### Parameters

`other` [CMsgGCToClientBattlePassRollup\_TI7](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_TI7.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_TI7.Types.md).[FantasyChallenge](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_TI7.Types.FantasyChallenge.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI7_Types_FantasyChallenge_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI7_Types_FantasyChallenge_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI7_Types_FantasyChallenge_"></a> MergeFrom\(FantasyChallenge\)

```csharp
public void MergeFrom(CMsgGCToClientBattlePassRollup_TI7.Types.FantasyChallenge other)
```

#### Parameters

`other` [CMsgGCToClientBattlePassRollup\_TI7](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_TI7.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_TI7.Types.md).[FantasyChallenge](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_TI7.Types.FantasyChallenge.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI7_Types_FantasyChallenge_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI7_Types_FantasyChallenge_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI7_Types_FantasyChallenge_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

