# <a id="Divine_Protobufs_Dota2_CMsgCheerConfig"></a> Class CMsgCheerConfig

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgCheerConfig : IMessage<CMsgCheerConfig>, IEquatable<CMsgCheerConfig>, IDeepCloneable<CMsgCheerConfig>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgCheerConfig](Divine.Protobufs.Dota2.CMsgCheerConfig.md)

#### Implements

IMessage<CMsgCheerConfig\>, 
[IEquatable<CMsgCheerConfig\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgCheerConfig\>, 
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
[EnumerableExtensions.In<CMsgCheerConfig\>\(CMsgCheerConfig, params CMsgCheerConfig\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig__ctor"></a> CMsgCheerConfig\(\)

```csharp
public CMsgCheerConfig()
```

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig__ctor_Divine_Protobufs_Dota2_CMsgCheerConfig_"></a> CMsgCheerConfig\(CMsgCheerConfig\)

```csharp
public CMsgCheerConfig(CMsgCheerConfig other)
```

#### Parameters

`other` [CMsgCheerConfig](Divine.Protobufs.Dota2.CMsgCheerConfig.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_CheerFactorBronzeFieldNumber"></a> CheerFactorBronzeFieldNumber

```csharp
public const int CheerFactorBronzeFieldNumber = 18
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_CheerFactorGoldFieldNumber"></a> CheerFactorGoldFieldNumber

```csharp
public const int CheerFactorGoldFieldNumber = 20
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_CheerFactorSilverFieldNumber"></a> CheerFactorSilverFieldNumber

```csharp
public const int CheerFactorSilverFieldNumber = 19
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_CheerScaleDampenerLerpTimeFieldNumber"></a> CheerScaleDampenerLerpTimeFieldNumber

```csharp
public const int CheerScaleDampenerLerpTimeFieldNumber = 22
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_CheerScaleDampenerValueFieldNumber"></a> CheerScaleDampenerValueFieldNumber

```csharp
public const int CheerScaleDampenerValueFieldNumber = 21
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_CheerScalePctOfMaxCpsClampFieldNumber"></a> CheerScalePctOfMaxCpsClampFieldNumber

```csharp
public const int CheerScalePctOfMaxCpsClampFieldNumber = 17
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_CheerScalePullMarkFieldNumber"></a> CheerScalePullMarkFieldNumber

```csharp
public const int CheerScalePullMarkFieldNumber = 16
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_CheerScalePushMarkFieldNumber"></a> CheerScalePushMarkFieldNumber

```csharp
public const int CheerScalePushMarkFieldNumber = 15
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_CheerScaleSpeedFieldNumber"></a> CheerScaleSpeedFieldNumber

```csharp
public const int CheerScaleSpeedFieldNumber = 14
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_CheerScaleStartFieldNumber"></a> CheerScaleStartFieldNumber

```csharp
public const int CheerScaleStartFieldNumber = 13
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_CheersEnabledFieldNumber"></a> CheersEnabledFieldNumber

```csharp
public const int CheersEnabledFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_CrowdLevelHighFieldNumber"></a> CrowdLevelHighFieldNumber

```csharp
public const int CrowdLevelHighFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_CrowdLevelLowFieldNumber"></a> CrowdLevelLowFieldNumber

```csharp
public const int CrowdLevelLowFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_CrowdLevelMediumFieldNumber"></a> CrowdLevelMediumFieldNumber

```csharp
public const int CrowdLevelMediumFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_CrowdLevelPushTimeFieldNumber"></a> CrowdLevelPushTimeFieldNumber

```csharp
public const int CrowdLevelPushTimeFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_IsValidLeagueIdFieldNumber"></a> IsValidLeagueIdFieldNumber

```csharp
public const int IsValidLeagueIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_WindowBucketCountFieldNumber"></a> WindowBucketCountFieldNumber

```csharp
public const int WindowBucketCountFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_WindowDurationFieldNumber"></a> WindowDurationFieldNumber

```csharp
public const int WindowDurationFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_CheerFactorBronze"></a> CheerFactorBronze

```csharp
public float CheerFactorBronze { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_CheerFactorGold"></a> CheerFactorGold

```csharp
public float CheerFactorGold { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_CheerFactorSilver"></a> CheerFactorSilver

```csharp
public float CheerFactorSilver { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_CheerScaleDampenerLerpTime"></a> CheerScaleDampenerLerpTime

```csharp
public uint CheerScaleDampenerLerpTime { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_CheerScaleDampenerValue"></a> CheerScaleDampenerValue

```csharp
public float CheerScaleDampenerValue { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_CheerScalePctOfMaxCpsClamp"></a> CheerScalePctOfMaxCpsClamp

```csharp
public float CheerScalePctOfMaxCpsClamp { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_CheerScalePullMark"></a> CheerScalePullMark

```csharp
public uint CheerScalePullMark { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_CheerScalePushMark"></a> CheerScalePushMark

```csharp
public uint CheerScalePushMark { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_CheerScaleSpeed"></a> CheerScaleSpeed

```csharp
public float CheerScaleSpeed { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_CheerScaleStart"></a> CheerScaleStart

```csharp
public float CheerScaleStart { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_CheersEnabled"></a> CheersEnabled

```csharp
public bool CheersEnabled { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_CrowdLevelHigh"></a> CrowdLevelHigh

```csharp
public uint CrowdLevelHigh { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_CrowdLevelLow"></a> CrowdLevelLow

```csharp
public uint CrowdLevelLow { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_CrowdLevelMedium"></a> CrowdLevelMedium

```csharp
public uint CrowdLevelMedium { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_CrowdLevelPushTime"></a> CrowdLevelPushTime

```csharp
public float CrowdLevelPushTime { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_HasCheerFactorBronze"></a> HasCheerFactorBronze

```csharp
public bool HasCheerFactorBronze { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_HasCheerFactorGold"></a> HasCheerFactorGold

```csharp
public bool HasCheerFactorGold { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_HasCheerFactorSilver"></a> HasCheerFactorSilver

```csharp
public bool HasCheerFactorSilver { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_HasCheerScaleDampenerLerpTime"></a> HasCheerScaleDampenerLerpTime

```csharp
public bool HasCheerScaleDampenerLerpTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_HasCheerScaleDampenerValue"></a> HasCheerScaleDampenerValue

```csharp
public bool HasCheerScaleDampenerValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_HasCheerScalePctOfMaxCpsClamp"></a> HasCheerScalePctOfMaxCpsClamp

```csharp
public bool HasCheerScalePctOfMaxCpsClamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_HasCheerScalePullMark"></a> HasCheerScalePullMark

```csharp
public bool HasCheerScalePullMark { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_HasCheerScalePushMark"></a> HasCheerScalePushMark

```csharp
public bool HasCheerScalePushMark { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_HasCheerScaleSpeed"></a> HasCheerScaleSpeed

```csharp
public bool HasCheerScaleSpeed { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_HasCheerScaleStart"></a> HasCheerScaleStart

```csharp
public bool HasCheerScaleStart { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_HasCheersEnabled"></a> HasCheersEnabled

```csharp
public bool HasCheersEnabled { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_HasCrowdLevelHigh"></a> HasCrowdLevelHigh

```csharp
public bool HasCrowdLevelHigh { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_HasCrowdLevelLow"></a> HasCrowdLevelLow

```csharp
public bool HasCrowdLevelLow { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_HasCrowdLevelMedium"></a> HasCrowdLevelMedium

```csharp
public bool HasCrowdLevelMedium { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_HasCrowdLevelPushTime"></a> HasCrowdLevelPushTime

```csharp
public bool HasCrowdLevelPushTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_HasIsValidLeagueId"></a> HasIsValidLeagueId

```csharp
public bool HasIsValidLeagueId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_HasWindowBucketCount"></a> HasWindowBucketCount

```csharp
public bool HasWindowBucketCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_HasWindowDuration"></a> HasWindowDuration

```csharp
public bool HasWindowDuration { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_IsValidLeagueId"></a> IsValidLeagueId

```csharp
public bool IsValidLeagueId { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_Parser"></a> Parser

```csharp
public static MessageParser<CMsgCheerConfig> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgCheerConfig](Divine.Protobufs.Dota2.CMsgCheerConfig.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_WindowBucketCount"></a> WindowBucketCount

```csharp
public uint WindowBucketCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_WindowDuration"></a> WindowDuration

```csharp
public float WindowDuration { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_ClearCheerFactorBronze"></a> ClearCheerFactorBronze\(\)

```csharp
public void ClearCheerFactorBronze()
```

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_ClearCheerFactorGold"></a> ClearCheerFactorGold\(\)

```csharp
public void ClearCheerFactorGold()
```

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_ClearCheerFactorSilver"></a> ClearCheerFactorSilver\(\)

```csharp
public void ClearCheerFactorSilver()
```

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_ClearCheerScaleDampenerLerpTime"></a> ClearCheerScaleDampenerLerpTime\(\)

```csharp
public void ClearCheerScaleDampenerLerpTime()
```

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_ClearCheerScaleDampenerValue"></a> ClearCheerScaleDampenerValue\(\)

```csharp
public void ClearCheerScaleDampenerValue()
```

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_ClearCheerScalePctOfMaxCpsClamp"></a> ClearCheerScalePctOfMaxCpsClamp\(\)

```csharp
public void ClearCheerScalePctOfMaxCpsClamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_ClearCheerScalePullMark"></a> ClearCheerScalePullMark\(\)

```csharp
public void ClearCheerScalePullMark()
```

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_ClearCheerScalePushMark"></a> ClearCheerScalePushMark\(\)

```csharp
public void ClearCheerScalePushMark()
```

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_ClearCheerScaleSpeed"></a> ClearCheerScaleSpeed\(\)

```csharp
public void ClearCheerScaleSpeed()
```

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_ClearCheerScaleStart"></a> ClearCheerScaleStart\(\)

```csharp
public void ClearCheerScaleStart()
```

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_ClearCheersEnabled"></a> ClearCheersEnabled\(\)

```csharp
public void ClearCheersEnabled()
```

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_ClearCrowdLevelHigh"></a> ClearCrowdLevelHigh\(\)

```csharp
public void ClearCrowdLevelHigh()
```

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_ClearCrowdLevelLow"></a> ClearCrowdLevelLow\(\)

```csharp
public void ClearCrowdLevelLow()
```

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_ClearCrowdLevelMedium"></a> ClearCrowdLevelMedium\(\)

```csharp
public void ClearCrowdLevelMedium()
```

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_ClearCrowdLevelPushTime"></a> ClearCrowdLevelPushTime\(\)

```csharp
public void ClearCrowdLevelPushTime()
```

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_ClearIsValidLeagueId"></a> ClearIsValidLeagueId\(\)

```csharp
public void ClearIsValidLeagueId()
```

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_ClearWindowBucketCount"></a> ClearWindowBucketCount\(\)

```csharp
public void ClearWindowBucketCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_ClearWindowDuration"></a> ClearWindowDuration\(\)

```csharp
public void ClearWindowDuration()
```

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_Clone"></a> Clone\(\)

```csharp
public CMsgCheerConfig Clone()
```

#### Returns

 [CMsgCheerConfig](Divine.Protobufs.Dota2.CMsgCheerConfig.md)

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_Equals_Divine_Protobufs_Dota2_CMsgCheerConfig_"></a> Equals\(CMsgCheerConfig\)

```csharp
public bool Equals(CMsgCheerConfig other)
```

#### Parameters

`other` [CMsgCheerConfig](Divine.Protobufs.Dota2.CMsgCheerConfig.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_MergeFrom_Divine_Protobufs_Dota2_CMsgCheerConfig_"></a> MergeFrom\(CMsgCheerConfig\)

```csharp
public void MergeFrom(CMsgCheerConfig other)
```

#### Parameters

`other` [CMsgCheerConfig](Divine.Protobufs.Dota2.CMsgCheerConfig.md)

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgCheerConfig_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

