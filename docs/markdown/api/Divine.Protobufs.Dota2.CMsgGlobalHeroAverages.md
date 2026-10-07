# <a id="Divine_Protobufs_Dota2_CMsgGlobalHeroAverages"></a> Class CMsgGlobalHeroAverages

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGlobalHeroAverages : IMessage<CMsgGlobalHeroAverages>, IEquatable<CMsgGlobalHeroAverages>, IDeepCloneable<CMsgGlobalHeroAverages>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGlobalHeroAverages](Divine.Protobufs.Dota2.CMsgGlobalHeroAverages.md)

#### Implements

IMessage<CMsgGlobalHeroAverages\>, 
[IEquatable<CMsgGlobalHeroAverages\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGlobalHeroAverages\>, 
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
[EnumerableExtensions.In<CMsgGlobalHeroAverages\>\(CMsgGlobalHeroAverages, params CMsgGlobalHeroAverages\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGlobalHeroAverages__ctor"></a> CMsgGlobalHeroAverages\(\)

```csharp
public CMsgGlobalHeroAverages()
```

### <a id="Divine_Protobufs_Dota2_CMsgGlobalHeroAverages__ctor_Divine_Protobufs_Dota2_CMsgGlobalHeroAverages_"></a> CMsgGlobalHeroAverages\(CMsgGlobalHeroAverages\)

```csharp
public CMsgGlobalHeroAverages(CMsgGlobalHeroAverages other)
```

#### Parameters

`other` [CMsgGlobalHeroAverages](Divine.Protobufs.Dota2.CMsgGlobalHeroAverages.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGlobalHeroAverages_AvgAssistsFieldNumber"></a> AvgAssistsFieldNumber

```csharp
public const int AvgAssistsFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGlobalHeroAverages_AvgDeathsFieldNumber"></a> AvgDeathsFieldNumber

```csharp
public const int AvgDeathsFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGlobalHeroAverages_AvgDeniesFieldNumber"></a> AvgDeniesFieldNumber

```csharp
public const int AvgDeniesFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGlobalHeroAverages_AvgGoldPerMinFieldNumber"></a> AvgGoldPerMinFieldNumber

```csharp
public const int AvgGoldPerMinFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGlobalHeroAverages_AvgKillsFieldNumber"></a> AvgKillsFieldNumber

```csharp
public const int AvgKillsFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGlobalHeroAverages_AvgLastHitsFieldNumber"></a> AvgLastHitsFieldNumber

```csharp
public const int AvgLastHitsFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGlobalHeroAverages_AvgNetWorthFieldNumber"></a> AvgNetWorthFieldNumber

```csharp
public const int AvgNetWorthFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGlobalHeroAverages_AvgXpPerMinFieldNumber"></a> AvgXpPerMinFieldNumber

```csharp
public const int AvgXpPerMinFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGlobalHeroAverages_LastRunFieldNumber"></a> LastRunFieldNumber

```csharp
public const int LastRunFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGlobalHeroAverages_AvgAssists"></a> AvgAssists

```csharp
public uint AvgAssists { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGlobalHeroAverages_AvgDeaths"></a> AvgDeaths

```csharp
public uint AvgDeaths { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGlobalHeroAverages_AvgDenies"></a> AvgDenies

```csharp
public uint AvgDenies { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGlobalHeroAverages_AvgGoldPerMin"></a> AvgGoldPerMin

```csharp
public uint AvgGoldPerMin { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGlobalHeroAverages_AvgKills"></a> AvgKills

```csharp
public uint AvgKills { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGlobalHeroAverages_AvgLastHits"></a> AvgLastHits

```csharp
public uint AvgLastHits { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGlobalHeroAverages_AvgNetWorth"></a> AvgNetWorth

```csharp
public uint AvgNetWorth { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGlobalHeroAverages_AvgXpPerMin"></a> AvgXpPerMin

```csharp
public uint AvgXpPerMin { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGlobalHeroAverages_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGlobalHeroAverages_HasAvgAssists"></a> HasAvgAssists

```csharp
public bool HasAvgAssists { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGlobalHeroAverages_HasAvgDeaths"></a> HasAvgDeaths

```csharp
public bool HasAvgDeaths { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGlobalHeroAverages_HasAvgDenies"></a> HasAvgDenies

```csharp
public bool HasAvgDenies { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGlobalHeroAverages_HasAvgGoldPerMin"></a> HasAvgGoldPerMin

```csharp
public bool HasAvgGoldPerMin { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGlobalHeroAverages_HasAvgKills"></a> HasAvgKills

```csharp
public bool HasAvgKills { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGlobalHeroAverages_HasAvgLastHits"></a> HasAvgLastHits

```csharp
public bool HasAvgLastHits { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGlobalHeroAverages_HasAvgNetWorth"></a> HasAvgNetWorth

```csharp
public bool HasAvgNetWorth { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGlobalHeroAverages_HasAvgXpPerMin"></a> HasAvgXpPerMin

```csharp
public bool HasAvgXpPerMin { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGlobalHeroAverages_HasLastRun"></a> HasLastRun

```csharp
public bool HasLastRun { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGlobalHeroAverages_LastRun"></a> LastRun

```csharp
public uint LastRun { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGlobalHeroAverages_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGlobalHeroAverages> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGlobalHeroAverages](Divine.Protobufs.Dota2.CMsgGlobalHeroAverages.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGlobalHeroAverages_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGlobalHeroAverages_ClearAvgAssists"></a> ClearAvgAssists\(\)

```csharp
public void ClearAvgAssists()
```

### <a id="Divine_Protobufs_Dota2_CMsgGlobalHeroAverages_ClearAvgDeaths"></a> ClearAvgDeaths\(\)

```csharp
public void ClearAvgDeaths()
```

### <a id="Divine_Protobufs_Dota2_CMsgGlobalHeroAverages_ClearAvgDenies"></a> ClearAvgDenies\(\)

```csharp
public void ClearAvgDenies()
```

### <a id="Divine_Protobufs_Dota2_CMsgGlobalHeroAverages_ClearAvgGoldPerMin"></a> ClearAvgGoldPerMin\(\)

```csharp
public void ClearAvgGoldPerMin()
```

### <a id="Divine_Protobufs_Dota2_CMsgGlobalHeroAverages_ClearAvgKills"></a> ClearAvgKills\(\)

```csharp
public void ClearAvgKills()
```

### <a id="Divine_Protobufs_Dota2_CMsgGlobalHeroAverages_ClearAvgLastHits"></a> ClearAvgLastHits\(\)

```csharp
public void ClearAvgLastHits()
```

### <a id="Divine_Protobufs_Dota2_CMsgGlobalHeroAverages_ClearAvgNetWorth"></a> ClearAvgNetWorth\(\)

```csharp
public void ClearAvgNetWorth()
```

### <a id="Divine_Protobufs_Dota2_CMsgGlobalHeroAverages_ClearAvgXpPerMin"></a> ClearAvgXpPerMin\(\)

```csharp
public void ClearAvgXpPerMin()
```

### <a id="Divine_Protobufs_Dota2_CMsgGlobalHeroAverages_ClearLastRun"></a> ClearLastRun\(\)

```csharp
public void ClearLastRun()
```

### <a id="Divine_Protobufs_Dota2_CMsgGlobalHeroAverages_Clone"></a> Clone\(\)

```csharp
public CMsgGlobalHeroAverages Clone()
```

#### Returns

 [CMsgGlobalHeroAverages](Divine.Protobufs.Dota2.CMsgGlobalHeroAverages.md)

### <a id="Divine_Protobufs_Dota2_CMsgGlobalHeroAverages_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGlobalHeroAverages_Equals_Divine_Protobufs_Dota2_CMsgGlobalHeroAverages_"></a> Equals\(CMsgGlobalHeroAverages\)

```csharp
public bool Equals(CMsgGlobalHeroAverages other)
```

#### Parameters

`other` [CMsgGlobalHeroAverages](Divine.Protobufs.Dota2.CMsgGlobalHeroAverages.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGlobalHeroAverages_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGlobalHeroAverages_MergeFrom_Divine_Protobufs_Dota2_CMsgGlobalHeroAverages_"></a> MergeFrom\(CMsgGlobalHeroAverages\)

```csharp
public void MergeFrom(CMsgGlobalHeroAverages other)
```

#### Parameters

`other` [CMsgGlobalHeroAverages](Divine.Protobufs.Dota2.CMsgGlobalHeroAverages.md)

### <a id="Divine_Protobufs_Dota2_CMsgGlobalHeroAverages_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGlobalHeroAverages_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGlobalHeroAverages_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

