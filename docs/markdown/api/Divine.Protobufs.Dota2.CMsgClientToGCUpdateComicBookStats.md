# <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats"></a> Class CMsgClientToGCUpdateComicBookStats

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCUpdateComicBookStats : IMessage<CMsgClientToGCUpdateComicBookStats>, IEquatable<CMsgClientToGCUpdateComicBookStats>, IDeepCloneable<CMsgClientToGCUpdateComicBookStats>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCUpdateComicBookStats](Divine.Protobufs.Dota2.CMsgClientToGCUpdateComicBookStats.md)

#### Implements

IMessage<CMsgClientToGCUpdateComicBookStats\>, 
[IEquatable<CMsgClientToGCUpdateComicBookStats\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCUpdateComicBookStats\>, 
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
[EnumerableExtensions.In<CMsgClientToGCUpdateComicBookStats\>\(CMsgClientToGCUpdateComicBookStats, params CMsgClientToGCUpdateComicBookStats\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats__ctor"></a> CMsgClientToGCUpdateComicBookStats\(\)

```csharp
public CMsgClientToGCUpdateComicBookStats()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats__ctor_Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_"></a> CMsgClientToGCUpdateComicBookStats\(CMsgClientToGCUpdateComicBookStats\)

```csharp
public CMsgClientToGCUpdateComicBookStats(CMsgClientToGCUpdateComicBookStats other)
```

#### Parameters

`other` [CMsgClientToGCUpdateComicBookStats](Divine.Protobufs.Dota2.CMsgClientToGCUpdateComicBookStats.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_ComicIdFieldNumber"></a> ComicIdFieldNumber

```csharp
public const int ComicIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_LanguageStatsFieldNumber"></a> LanguageStatsFieldNumber

```csharp
public const int LanguageStatsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_StatsFieldNumber"></a> StatsFieldNumber

```csharp
public const int StatsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_ComicId"></a> ComicId

```csharp
public uint ComicId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_HasComicId"></a> HasComicId

```csharp
public bool HasComicId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_LanguageStats"></a> LanguageStats

```csharp
public CMsgClientToGCUpdateComicBookStats.Types.LanguageStats LanguageStats { get; set; }
```

#### Property Value

 [CMsgClientToGCUpdateComicBookStats](Divine.Protobufs.Dota2.CMsgClientToGCUpdateComicBookStats.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCUpdateComicBookStats.Types.md).[LanguageStats](Divine.Protobufs.Dota2.CMsgClientToGCUpdateComicBookStats.Types.LanguageStats.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCUpdateComicBookStats> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCUpdateComicBookStats](Divine.Protobufs.Dota2.CMsgClientToGCUpdateComicBookStats.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_Stats"></a> Stats

```csharp
public RepeatedField<CMsgClientToGCUpdateComicBookStats.Types.SingleStat> Stats { get; }
```

#### Property Value

 RepeatedField<[CMsgClientToGCUpdateComicBookStats](Divine.Protobufs.Dota2.CMsgClientToGCUpdateComicBookStats.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCUpdateComicBookStats.Types.md).[SingleStat](Divine.Protobufs.Dota2.CMsgClientToGCUpdateComicBookStats.Types.SingleStat.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_ClearComicId"></a> ClearComicId\(\)

```csharp
public void ClearComicId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCUpdateComicBookStats Clone()
```

#### Returns

 [CMsgClientToGCUpdateComicBookStats](Divine.Protobufs.Dota2.CMsgClientToGCUpdateComicBookStats.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_Equals_Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_"></a> Equals\(CMsgClientToGCUpdateComicBookStats\)

```csharp
public bool Equals(CMsgClientToGCUpdateComicBookStats other)
```

#### Parameters

`other` [CMsgClientToGCUpdateComicBookStats](Divine.Protobufs.Dota2.CMsgClientToGCUpdateComicBookStats.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_"></a> MergeFrom\(CMsgClientToGCUpdateComicBookStats\)

```csharp
public void MergeFrom(CMsgClientToGCUpdateComicBookStats other)
```

#### Parameters

`other` [CMsgClientToGCUpdateComicBookStats](Divine.Protobufs.Dota2.CMsgClientToGCUpdateComicBookStats.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

