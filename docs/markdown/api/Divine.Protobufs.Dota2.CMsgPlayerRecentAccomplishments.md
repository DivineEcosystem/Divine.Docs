# <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentAccomplishments"></a> Class CMsgPlayerRecentAccomplishments

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgPlayerRecentAccomplishments : IMessage<CMsgPlayerRecentAccomplishments>, IEquatable<CMsgPlayerRecentAccomplishments>, IDeepCloneable<CMsgPlayerRecentAccomplishments>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgPlayerRecentAccomplishments](Divine.Protobufs.Dota2.CMsgPlayerRecentAccomplishments.md)

#### Implements

IMessage<CMsgPlayerRecentAccomplishments\>, 
[IEquatable<CMsgPlayerRecentAccomplishments\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgPlayerRecentAccomplishments\>, 
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
[EnumerableExtensions.In<CMsgPlayerRecentAccomplishments\>\(CMsgPlayerRecentAccomplishments, params CMsgPlayerRecentAccomplishments\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentAccomplishments__ctor"></a> CMsgPlayerRecentAccomplishments\(\)

```csharp
public CMsgPlayerRecentAccomplishments()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentAccomplishments__ctor_Divine_Protobufs_Dota2_CMsgPlayerRecentAccomplishments_"></a> CMsgPlayerRecentAccomplishments\(CMsgPlayerRecentAccomplishments\)

```csharp
public CMsgPlayerRecentAccomplishments(CMsgPlayerRecentAccomplishments other)
```

#### Parameters

`other` [CMsgPlayerRecentAccomplishments](Divine.Protobufs.Dota2.CMsgPlayerRecentAccomplishments.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentAccomplishments_FirstMatchTimestampFieldNumber"></a> FirstMatchTimestampFieldNumber

```csharp
public const int FirstMatchTimestampFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentAccomplishments_LastMatchFieldNumber"></a> LastMatchFieldNumber

```csharp
public const int LastMatchFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentAccomplishments_PlusPredictionStreakFieldNumber"></a> PlusPredictionStreakFieldNumber

```csharp
public const int PlusPredictionStreakFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentAccomplishments_PredictionStreakFieldNumber"></a> PredictionStreakFieldNumber

```csharp
public const int PredictionStreakFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentAccomplishments_RecentCommendsFieldNumber"></a> RecentCommendsFieldNumber

```csharp
public const int RecentCommendsFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentAccomplishments_RecentMvpsFieldNumber"></a> RecentMvpsFieldNumber

```csharp
public const int RecentMvpsFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentAccomplishments_RecentOutcomesFieldNumber"></a> RecentOutcomesFieldNumber

```csharp
public const int RecentOutcomesFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentAccomplishments_TotalRecordFieldNumber"></a> TotalRecordFieldNumber

```csharp
public const int TotalRecordFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentAccomplishments_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentAccomplishments_FirstMatchTimestamp"></a> FirstMatchTimestamp

```csharp
public uint FirstMatchTimestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentAccomplishments_HasFirstMatchTimestamp"></a> HasFirstMatchTimestamp

```csharp
public bool HasFirstMatchTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentAccomplishments_HasPlusPredictionStreak"></a> HasPlusPredictionStreak

```csharp
public bool HasPlusPredictionStreak { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentAccomplishments_HasPredictionStreak"></a> HasPredictionStreak

```csharp
public bool HasPredictionStreak { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentAccomplishments_LastMatch"></a> LastMatch

```csharp
public CMsgPlayerRecentMatchInfo LastMatch { get; set; }
```

#### Property Value

 [CMsgPlayerRecentMatchInfo](Divine.Protobufs.Dota2.CMsgPlayerRecentMatchInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentAccomplishments_Parser"></a> Parser

```csharp
public static MessageParser<CMsgPlayerRecentAccomplishments> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgPlayerRecentAccomplishments](Divine.Protobufs.Dota2.CMsgPlayerRecentAccomplishments.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentAccomplishments_PlusPredictionStreak"></a> PlusPredictionStreak

```csharp
public uint PlusPredictionStreak { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentAccomplishments_PredictionStreak"></a> PredictionStreak

```csharp
public uint PredictionStreak { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentAccomplishments_RecentCommends"></a> RecentCommends

```csharp
public CMsgPlayerRecentCommends RecentCommends { get; set; }
```

#### Property Value

 [CMsgPlayerRecentCommends](Divine.Protobufs.Dota2.CMsgPlayerRecentCommends.md)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentAccomplishments_RecentMvps"></a> RecentMvps

```csharp
public CMsgPlayerRecentMatchOutcomes RecentMvps { get; set; }
```

#### Property Value

 [CMsgPlayerRecentMatchOutcomes](Divine.Protobufs.Dota2.CMsgPlayerRecentMatchOutcomes.md)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentAccomplishments_RecentOutcomes"></a> RecentOutcomes

```csharp
public CMsgPlayerRecentMatchOutcomes RecentOutcomes { get; set; }
```

#### Property Value

 [CMsgPlayerRecentMatchOutcomes](Divine.Protobufs.Dota2.CMsgPlayerRecentMatchOutcomes.md)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentAccomplishments_TotalRecord"></a> TotalRecord

```csharp
public CMsgPlayerMatchRecord TotalRecord { get; set; }
```

#### Property Value

 [CMsgPlayerMatchRecord](Divine.Protobufs.Dota2.CMsgPlayerMatchRecord.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentAccomplishments_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentAccomplishments_ClearFirstMatchTimestamp"></a> ClearFirstMatchTimestamp\(\)

```csharp
public void ClearFirstMatchTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentAccomplishments_ClearPlusPredictionStreak"></a> ClearPlusPredictionStreak\(\)

```csharp
public void ClearPlusPredictionStreak()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentAccomplishments_ClearPredictionStreak"></a> ClearPredictionStreak\(\)

```csharp
public void ClearPredictionStreak()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentAccomplishments_Clone"></a> Clone\(\)

```csharp
public CMsgPlayerRecentAccomplishments Clone()
```

#### Returns

 [CMsgPlayerRecentAccomplishments](Divine.Protobufs.Dota2.CMsgPlayerRecentAccomplishments.md)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentAccomplishments_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentAccomplishments_Equals_Divine_Protobufs_Dota2_CMsgPlayerRecentAccomplishments_"></a> Equals\(CMsgPlayerRecentAccomplishments\)

```csharp
public bool Equals(CMsgPlayerRecentAccomplishments other)
```

#### Parameters

`other` [CMsgPlayerRecentAccomplishments](Divine.Protobufs.Dota2.CMsgPlayerRecentAccomplishments.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentAccomplishments_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentAccomplishments_MergeFrom_Divine_Protobufs_Dota2_CMsgPlayerRecentAccomplishments_"></a> MergeFrom\(CMsgPlayerRecentAccomplishments\)

```csharp
public void MergeFrom(CMsgPlayerRecentAccomplishments other)
```

#### Parameters

`other` [CMsgPlayerRecentAccomplishments](Divine.Protobufs.Dota2.CMsgPlayerRecentAccomplishments.md)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentAccomplishments_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentAccomplishments_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerRecentAccomplishments_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

