# <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsGameTelemetryData"></a> Class CMsgClientToGCSurvivorsGameTelemetryData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCSurvivorsGameTelemetryData : IMessage<CMsgClientToGCSurvivorsGameTelemetryData>, IEquatable<CMsgClientToGCSurvivorsGameTelemetryData>, IDeepCloneable<CMsgClientToGCSurvivorsGameTelemetryData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCSurvivorsGameTelemetryData](Divine.Protobufs.Dota2.CMsgClientToGCSurvivorsGameTelemetryData.md)

#### Implements

IMessage<CMsgClientToGCSurvivorsGameTelemetryData\>, 
[IEquatable<CMsgClientToGCSurvivorsGameTelemetryData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCSurvivorsGameTelemetryData\>, 
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
[EnumerableExtensions.In<CMsgClientToGCSurvivorsGameTelemetryData\>\(CMsgClientToGCSurvivorsGameTelemetryData, params CMsgClientToGCSurvivorsGameTelemetryData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsGameTelemetryData__ctor"></a> CMsgClientToGCSurvivorsGameTelemetryData\(\)

```csharp
public CMsgClientToGCSurvivorsGameTelemetryData()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsGameTelemetryData__ctor_Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsGameTelemetryData_"></a> CMsgClientToGCSurvivorsGameTelemetryData\(CMsgClientToGCSurvivorsGameTelemetryData\)

```csharp
public CMsgClientToGCSurvivorsGameTelemetryData(CMsgClientToGCSurvivorsGameTelemetryData other)
```

#### Parameters

`other` [CMsgClientToGCSurvivorsGameTelemetryData](Divine.Protobufs.Dota2.CMsgClientToGCSurvivorsGameTelemetryData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsGameTelemetryData_DifficultyFieldNumber"></a> DifficultyFieldNumber

```csharp
public const int DifficultyFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsGameTelemetryData_GameResultFieldNumber"></a> GameResultFieldNumber

```csharp
public const int GameResultFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsGameTelemetryData_GoldEarnedFieldNumber"></a> GoldEarnedFieldNumber

```csharp
public const int GoldEarnedFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsGameTelemetryData_MetaprogressionLevelFieldNumber"></a> MetaprogressionLevelFieldNumber

```csharp
public const int MetaprogressionLevelFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsGameTelemetryData_PlayerLevelFieldNumber"></a> PlayerLevelFieldNumber

```csharp
public const int PlayerLevelFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsGameTelemetryData_PowerupsFieldNumber"></a> PowerupsFieldNumber

```csharp
public const int PowerupsFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsGameTelemetryData_TimeSurvivedFieldNumber"></a> TimeSurvivedFieldNumber

```csharp
public const int TimeSurvivedFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsGameTelemetryData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsGameTelemetryData_Difficulty"></a> Difficulty

```csharp
public uint Difficulty { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsGameTelemetryData_GameResult"></a> GameResult

```csharp
public uint GameResult { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsGameTelemetryData_GoldEarned"></a> GoldEarned

```csharp
public uint GoldEarned { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsGameTelemetryData_HasDifficulty"></a> HasDifficulty

```csharp
public bool HasDifficulty { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsGameTelemetryData_HasGameResult"></a> HasGameResult

```csharp
public bool HasGameResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsGameTelemetryData_HasGoldEarned"></a> HasGoldEarned

```csharp
public bool HasGoldEarned { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsGameTelemetryData_HasMetaprogressionLevel"></a> HasMetaprogressionLevel

```csharp
public bool HasMetaprogressionLevel { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsGameTelemetryData_HasPlayerLevel"></a> HasPlayerLevel

```csharp
public bool HasPlayerLevel { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsGameTelemetryData_HasTimeSurvived"></a> HasTimeSurvived

```csharp
public bool HasTimeSurvived { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsGameTelemetryData_MetaprogressionLevel"></a> MetaprogressionLevel

```csharp
public uint MetaprogressionLevel { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsGameTelemetryData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCSurvivorsGameTelemetryData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCSurvivorsGameTelemetryData](Divine.Protobufs.Dota2.CMsgClientToGCSurvivorsGameTelemetryData.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsGameTelemetryData_PlayerLevel"></a> PlayerLevel

```csharp
public uint PlayerLevel { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsGameTelemetryData_Powerups"></a> Powerups

```csharp
public RepeatedField<CMsgClientToGCSurvivorsPowerUpTelemetryData> Powerups { get; }
```

#### Property Value

 RepeatedField<[CMsgClientToGCSurvivorsPowerUpTelemetryData](Divine.Protobufs.Dota2.CMsgClientToGCSurvivorsPowerUpTelemetryData.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsGameTelemetryData_TimeSurvived"></a> TimeSurvived

```csharp
public uint TimeSurvived { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsGameTelemetryData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsGameTelemetryData_ClearDifficulty"></a> ClearDifficulty\(\)

```csharp
public void ClearDifficulty()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsGameTelemetryData_ClearGameResult"></a> ClearGameResult\(\)

```csharp
public void ClearGameResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsGameTelemetryData_ClearGoldEarned"></a> ClearGoldEarned\(\)

```csharp
public void ClearGoldEarned()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsGameTelemetryData_ClearMetaprogressionLevel"></a> ClearMetaprogressionLevel\(\)

```csharp
public void ClearMetaprogressionLevel()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsGameTelemetryData_ClearPlayerLevel"></a> ClearPlayerLevel\(\)

```csharp
public void ClearPlayerLevel()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsGameTelemetryData_ClearTimeSurvived"></a> ClearTimeSurvived\(\)

```csharp
public void ClearTimeSurvived()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsGameTelemetryData_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCSurvivorsGameTelemetryData Clone()
```

#### Returns

 [CMsgClientToGCSurvivorsGameTelemetryData](Divine.Protobufs.Dota2.CMsgClientToGCSurvivorsGameTelemetryData.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsGameTelemetryData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsGameTelemetryData_Equals_Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsGameTelemetryData_"></a> Equals\(CMsgClientToGCSurvivorsGameTelemetryData\)

```csharp
public bool Equals(CMsgClientToGCSurvivorsGameTelemetryData other)
```

#### Parameters

`other` [CMsgClientToGCSurvivorsGameTelemetryData](Divine.Protobufs.Dota2.CMsgClientToGCSurvivorsGameTelemetryData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsGameTelemetryData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsGameTelemetryData_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsGameTelemetryData_"></a> MergeFrom\(CMsgClientToGCSurvivorsGameTelemetryData\)

```csharp
public void MergeFrom(CMsgClientToGCSurvivorsGameTelemetryData other)
```

#### Parameters

`other` [CMsgClientToGCSurvivorsGameTelemetryData](Divine.Protobufs.Dota2.CMsgClientToGCSurvivorsGameTelemetryData.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsGameTelemetryData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsGameTelemetryData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsGameTelemetryData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

