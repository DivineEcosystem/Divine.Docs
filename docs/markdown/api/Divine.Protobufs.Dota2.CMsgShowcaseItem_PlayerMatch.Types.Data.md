# <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_Types_Data"></a> Class CMsgShowcaseItem\_PlayerMatch.Types.Data

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgShowcaseItem_PlayerMatch.Types.Data : IMessage<CMsgShowcaseItem_PlayerMatch.Types.Data>, IEquatable<CMsgShowcaseItem_PlayerMatch.Types.Data>, IDeepCloneable<CMsgShowcaseItem_PlayerMatch.Types.Data>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgShowcaseItem\_PlayerMatch.Types.Data](Divine.Protobufs.Dota2.CMsgShowcaseItem\_PlayerMatch.Types.Data.md)

#### Implements

IMessage<CMsgShowcaseItem\_PlayerMatch.Types.Data\>, 
[IEquatable<CMsgShowcaseItem\_PlayerMatch.Types.Data\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgShowcaseItem\_PlayerMatch.Types.Data\>, 
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
[EnumerableExtensions.In<CMsgShowcaseItem\_PlayerMatch.Types.Data\>\(CMsgShowcaseItem\_PlayerMatch.Types.Data, params CMsgShowcaseItem\_PlayerMatch.Types.Data\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_Types_Data__ctor"></a> Data\(\)

```csharp
public Data()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_Types_Data__ctor_Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_Types_Data_"></a> Data\(Data\)

```csharp
public Data(CMsgShowcaseItem_PlayerMatch.Types.Data other)
```

#### Parameters

`other` [CMsgShowcaseItem\_PlayerMatch](Divine.Protobufs.Dota2.CMsgShowcaseItem\_PlayerMatch.md).[Types](Divine.Protobufs.Dota2.CMsgShowcaseItem\_PlayerMatch.Types.md).[Data](Divine.Protobufs.Dota2.CMsgShowcaseItem\_PlayerMatch.Types.Data.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_Types_Data_AssistsFieldNumber"></a> AssistsFieldNumber

```csharp
public const int AssistsFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_Types_Data_DeathsFieldNumber"></a> DeathsFieldNumber

```csharp
public const int DeathsFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_Types_Data_DurationFieldNumber"></a> DurationFieldNumber

```csharp
public const int DurationFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_Types_Data_GameModeFieldNumber"></a> GameModeFieldNumber

```csharp
public const int GameModeFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_Types_Data_HeroIdFieldNumber"></a> HeroIdFieldNumber

```csharp
public const int HeroIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_Types_Data_KillsFieldNumber"></a> KillsFieldNumber

```csharp
public const int KillsFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_Types_Data_OutcomeFieldNumber"></a> OutcomeFieldNumber

```csharp
public const int OutcomeFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_Types_Data_TimestampFieldNumber"></a> TimestampFieldNumber

```csharp
public const int TimestampFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_Types_Data_Assists"></a> Assists

```csharp
public uint Assists { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_Types_Data_Deaths"></a> Deaths

```csharp
public uint Deaths { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_Types_Data_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_Types_Data_Duration"></a> Duration

```csharp
public uint Duration { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_Types_Data_GameMode"></a> GameMode

```csharp
public DOTA_GameMode GameMode { get; set; }
```

#### Property Value

 [DOTA\_GameMode](Divine.Protobufs.Dota2.DOTA\_GameMode.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_Types_Data_HasAssists"></a> HasAssists

```csharp
public bool HasAssists { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_Types_Data_HasDeaths"></a> HasDeaths

```csharp
public bool HasDeaths { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_Types_Data_HasDuration"></a> HasDuration

```csharp
public bool HasDuration { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_Types_Data_HasGameMode"></a> HasGameMode

```csharp
public bool HasGameMode { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_Types_Data_HasHeroId"></a> HasHeroId

```csharp
public bool HasHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_Types_Data_HasKills"></a> HasKills

```csharp
public bool HasKills { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_Types_Data_HasOutcome"></a> HasOutcome

```csharp
public bool HasOutcome { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_Types_Data_HasTimestamp"></a> HasTimestamp

```csharp
public bool HasTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_Types_Data_HeroId"></a> HeroId

```csharp
public int HeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_Types_Data_Kills"></a> Kills

```csharp
public uint Kills { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_Types_Data_Outcome"></a> Outcome

```csharp
public CMsgShowcaseItem_PlayerMatch.Types.EPlayerOutcome Outcome { get; set; }
```

#### Property Value

 [CMsgShowcaseItem\_PlayerMatch](Divine.Protobufs.Dota2.CMsgShowcaseItem\_PlayerMatch.md).[Types](Divine.Protobufs.Dota2.CMsgShowcaseItem\_PlayerMatch.Types.md).[EPlayerOutcome](Divine.Protobufs.Dota2.CMsgShowcaseItem\_PlayerMatch.Types.EPlayerOutcome.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_Types_Data_Parser"></a> Parser

```csharp
public static MessageParser<CMsgShowcaseItem_PlayerMatch.Types.Data> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgShowcaseItem\_PlayerMatch](Divine.Protobufs.Dota2.CMsgShowcaseItem\_PlayerMatch.md).[Types](Divine.Protobufs.Dota2.CMsgShowcaseItem\_PlayerMatch.Types.md).[Data](Divine.Protobufs.Dota2.CMsgShowcaseItem\_PlayerMatch.Types.Data.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_Types_Data_Timestamp"></a> Timestamp

```csharp
public uint Timestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_Types_Data_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_Types_Data_ClearAssists"></a> ClearAssists\(\)

```csharp
public void ClearAssists()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_Types_Data_ClearDeaths"></a> ClearDeaths\(\)

```csharp
public void ClearDeaths()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_Types_Data_ClearDuration"></a> ClearDuration\(\)

```csharp
public void ClearDuration()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_Types_Data_ClearGameMode"></a> ClearGameMode\(\)

```csharp
public void ClearGameMode()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_Types_Data_ClearHeroId"></a> ClearHeroId\(\)

```csharp
public void ClearHeroId()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_Types_Data_ClearKills"></a> ClearKills\(\)

```csharp
public void ClearKills()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_Types_Data_ClearOutcome"></a> ClearOutcome\(\)

```csharp
public void ClearOutcome()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_Types_Data_ClearTimestamp"></a> ClearTimestamp\(\)

```csharp
public void ClearTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_Types_Data_Clone"></a> Clone\(\)

```csharp
public CMsgShowcaseItem_PlayerMatch.Types.Data Clone()
```

#### Returns

 [CMsgShowcaseItem\_PlayerMatch](Divine.Protobufs.Dota2.CMsgShowcaseItem\_PlayerMatch.md).[Types](Divine.Protobufs.Dota2.CMsgShowcaseItem\_PlayerMatch.Types.md).[Data](Divine.Protobufs.Dota2.CMsgShowcaseItem\_PlayerMatch.Types.Data.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_Types_Data_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_Types_Data_Equals_Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_Types_Data_"></a> Equals\(Data\)

```csharp
public bool Equals(CMsgShowcaseItem_PlayerMatch.Types.Data other)
```

#### Parameters

`other` [CMsgShowcaseItem\_PlayerMatch](Divine.Protobufs.Dota2.CMsgShowcaseItem\_PlayerMatch.md).[Types](Divine.Protobufs.Dota2.CMsgShowcaseItem\_PlayerMatch.Types.md).[Data](Divine.Protobufs.Dota2.CMsgShowcaseItem\_PlayerMatch.Types.Data.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_Types_Data_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_Types_Data_MergeFrom_Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_Types_Data_"></a> MergeFrom\(Data\)

```csharp
public void MergeFrom(CMsgShowcaseItem_PlayerMatch.Types.Data other)
```

#### Parameters

`other` [CMsgShowcaseItem\_PlayerMatch](Divine.Protobufs.Dota2.CMsgShowcaseItem\_PlayerMatch.md).[Types](Divine.Protobufs.Dota2.CMsgShowcaseItem\_PlayerMatch.Types.md).[Data](Divine.Protobufs.Dota2.CMsgShowcaseItem\_PlayerMatch.Types.Data.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_Types_Data_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_Types_Data_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_Types_Data_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

