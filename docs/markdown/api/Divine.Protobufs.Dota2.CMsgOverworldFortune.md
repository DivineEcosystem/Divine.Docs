# <a id="Divine_Protobufs_Dota2_CMsgOverworldFortune"></a> Class CMsgOverworldFortune

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgOverworldFortune : IMessage<CMsgOverworldFortune>, IEquatable<CMsgOverworldFortune>, IDeepCloneable<CMsgOverworldFortune>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgOverworldFortune](Divine.Protobufs.Dota2.CMsgOverworldFortune.md)

#### Implements

IMessage<CMsgOverworldFortune\>, 
[IEquatable<CMsgOverworldFortune\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgOverworldFortune\>, 
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
[EnumerableExtensions.In<CMsgOverworldFortune\>\(CMsgOverworldFortune, params CMsgOverworldFortune\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgOverworldFortune__ctor"></a> CMsgOverworldFortune\(\)

```csharp
public CMsgOverworldFortune()
```

### <a id="Divine_Protobufs_Dota2_CMsgOverworldFortune__ctor_Divine_Protobufs_Dota2_CMsgOverworldFortune_"></a> CMsgOverworldFortune\(CMsgOverworldFortune\)

```csharp
public CMsgOverworldFortune(CMsgOverworldFortune other)
```

#### Parameters

`other` [CMsgOverworldFortune](Divine.Protobufs.Dota2.CMsgOverworldFortune.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgOverworldFortune_FortuneCountFieldNumber"></a> FortuneCountFieldNumber

```csharp
public const int FortuneCountFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldFortune_FortuneCountsFieldNumber"></a> FortuneCountsFieldNumber

```csharp
public const int FortuneCountsFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldFortune_FortuneFieldNumber"></a> FortuneFieldNumber

```csharp
public const int FortuneFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldFortune_RewardClaimedFieldNumber"></a> RewardClaimedFieldNumber

```csharp
public const int RewardClaimedFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldFortune_TimesCompletedFieldNumber"></a> TimesCompletedFieldNumber

```csharp
public const int TimesCompletedFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldFortune_TimestampFieldNumber"></a> TimestampFieldNumber

```csharp
public const int TimestampFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgOverworldFortune_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgOverworldFortune_Fortune"></a> Fortune

```csharp
public uint Fortune { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldFortune_FortuneCount"></a> FortuneCount

```csharp
public uint FortuneCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldFortune_FortuneCounts"></a> FortuneCounts

```csharp
public RepeatedField<CMsgOverworldFortune.Types.CMsgFortuneCount> FortuneCounts { get; }
```

#### Property Value

 RepeatedField<[CMsgOverworldFortune](Divine.Protobufs.Dota2.CMsgOverworldFortune.md).[Types](Divine.Protobufs.Dota2.CMsgOverworldFortune.Types.md).[CMsgFortuneCount](Divine.Protobufs.Dota2.CMsgOverworldFortune.Types.CMsgFortuneCount.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgOverworldFortune_HasFortune"></a> HasFortune

```csharp
public bool HasFortune { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldFortune_HasFortuneCount"></a> HasFortuneCount

```csharp
public bool HasFortuneCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldFortune_HasRewardClaimed"></a> HasRewardClaimed

```csharp
public bool HasRewardClaimed { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldFortune_HasTimesCompleted"></a> HasTimesCompleted

```csharp
public bool HasTimesCompleted { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldFortune_HasTimestamp"></a> HasTimestamp

```csharp
public bool HasTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldFortune_Parser"></a> Parser

```csharp
public static MessageParser<CMsgOverworldFortune> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgOverworldFortune](Divine.Protobufs.Dota2.CMsgOverworldFortune.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgOverworldFortune_RewardClaimed"></a> RewardClaimed

```csharp
public bool RewardClaimed { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldFortune_TimesCompleted"></a> TimesCompleted

```csharp
public uint TimesCompleted { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldFortune_Timestamp"></a> Timestamp

```csharp
public uint Timestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgOverworldFortune_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldFortune_ClearFortune"></a> ClearFortune\(\)

```csharp
public void ClearFortune()
```

### <a id="Divine_Protobufs_Dota2_CMsgOverworldFortune_ClearFortuneCount"></a> ClearFortuneCount\(\)

```csharp
public void ClearFortuneCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgOverworldFortune_ClearRewardClaimed"></a> ClearRewardClaimed\(\)

```csharp
public void ClearRewardClaimed()
```

### <a id="Divine_Protobufs_Dota2_CMsgOverworldFortune_ClearTimesCompleted"></a> ClearTimesCompleted\(\)

```csharp
public void ClearTimesCompleted()
```

### <a id="Divine_Protobufs_Dota2_CMsgOverworldFortune_ClearTimestamp"></a> ClearTimestamp\(\)

```csharp
public void ClearTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgOverworldFortune_Clone"></a> Clone\(\)

```csharp
public CMsgOverworldFortune Clone()
```

#### Returns

 [CMsgOverworldFortune](Divine.Protobufs.Dota2.CMsgOverworldFortune.md)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldFortune_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldFortune_Equals_Divine_Protobufs_Dota2_CMsgOverworldFortune_"></a> Equals\(CMsgOverworldFortune\)

```csharp
public bool Equals(CMsgOverworldFortune other)
```

#### Parameters

`other` [CMsgOverworldFortune](Divine.Protobufs.Dota2.CMsgOverworldFortune.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldFortune_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldFortune_MergeFrom_Divine_Protobufs_Dota2_CMsgOverworldFortune_"></a> MergeFrom\(CMsgOverworldFortune\)

```csharp
public void MergeFrom(CMsgOverworldFortune other)
```

#### Parameters

`other` [CMsgOverworldFortune](Divine.Protobufs.Dota2.CMsgOverworldFortune.md)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldFortune_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgOverworldFortune_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldFortune_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

