# <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_International2016_Types_BattleCup"></a> Class CMsgGCToClientBattlePassRollup\_International2016.Types.BattleCup

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientBattlePassRollup_International2016.Types.BattleCup : IMessage<CMsgGCToClientBattlePassRollup_International2016.Types.BattleCup>, IEquatable<CMsgGCToClientBattlePassRollup_International2016.Types.BattleCup>, IDeepCloneable<CMsgGCToClientBattlePassRollup_International2016.Types.BattleCup>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientBattlePassRollup\_International2016.Types.BattleCup](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_International2016.Types.BattleCup.md)

#### Implements

IMessage<CMsgGCToClientBattlePassRollup\_International2016.Types.BattleCup\>, 
[IEquatable<CMsgGCToClientBattlePassRollup\_International2016.Types.BattleCup\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientBattlePassRollup\_International2016.Types.BattleCup\>, 
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
[EnumerableExtensions.In<CMsgGCToClientBattlePassRollup\_International2016.Types.BattleCup\>\(CMsgGCToClientBattlePassRollup\_International2016.Types.BattleCup, params CMsgGCToClientBattlePassRollup\_International2016.Types.BattleCup\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_International2016_Types_BattleCup__ctor"></a> BattleCup\(\)

```csharp
public BattleCup()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_International2016_Types_BattleCup__ctor_Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_International2016_Types_BattleCup_"></a> BattleCup\(BattleCup\)

```csharp
public BattleCup(CMsgGCToClientBattlePassRollup_International2016.Types.BattleCup other)
```

#### Parameters

`other` [CMsgGCToClientBattlePassRollup\_International2016](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_International2016.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_International2016.Types.md).[BattleCup](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_International2016.Types.BattleCup.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_International2016_Types_BattleCup_ScoreFieldNumber"></a> ScoreFieldNumber

```csharp
public const int ScoreFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_International2016_Types_BattleCup_WinsFieldNumber"></a> WinsFieldNumber

```csharp
public const int WinsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_International2016_Types_BattleCup_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_International2016_Types_BattleCup_HasScore"></a> HasScore

```csharp
public bool HasScore { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_International2016_Types_BattleCup_HasWins"></a> HasWins

```csharp
public bool HasWins { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_International2016_Types_BattleCup_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientBattlePassRollup_International2016.Types.BattleCup> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientBattlePassRollup\_International2016](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_International2016.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_International2016.Types.md).[BattleCup](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_International2016.Types.BattleCup.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_International2016_Types_BattleCup_Score"></a> Score

```csharp
public uint Score { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_International2016_Types_BattleCup_Wins"></a> Wins

```csharp
public uint Wins { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_International2016_Types_BattleCup_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_International2016_Types_BattleCup_ClearScore"></a> ClearScore\(\)

```csharp
public void ClearScore()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_International2016_Types_BattleCup_ClearWins"></a> ClearWins\(\)

```csharp
public void ClearWins()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_International2016_Types_BattleCup_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientBattlePassRollup_International2016.Types.BattleCup Clone()
```

#### Returns

 [CMsgGCToClientBattlePassRollup\_International2016](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_International2016.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_International2016.Types.md).[BattleCup](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_International2016.Types.BattleCup.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_International2016_Types_BattleCup_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_International2016_Types_BattleCup_Equals_Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_International2016_Types_BattleCup_"></a> Equals\(BattleCup\)

```csharp
public bool Equals(CMsgGCToClientBattlePassRollup_International2016.Types.BattleCup other)
```

#### Parameters

`other` [CMsgGCToClientBattlePassRollup\_International2016](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_International2016.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_International2016.Types.md).[BattleCup](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_International2016.Types.BattleCup.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_International2016_Types_BattleCup_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_International2016_Types_BattleCup_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_International2016_Types_BattleCup_"></a> MergeFrom\(BattleCup\)

```csharp
public void MergeFrom(CMsgGCToClientBattlePassRollup_International2016.Types.BattleCup other)
```

#### Parameters

`other` [CMsgGCToClientBattlePassRollup\_International2016](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_International2016.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_International2016.Types.md).[BattleCup](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_International2016.Types.BattleCup.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_International2016_Types_BattleCup_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_International2016_Types_BattleCup_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_International2016_Types_BattleCup_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

