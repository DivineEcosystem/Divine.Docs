# <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyLivePlayerStats"></a> Class CMsgDOTAFantasyLivePlayerStats

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAFantasyLivePlayerStats : IMessage<CMsgDOTAFantasyLivePlayerStats>, IEquatable<CMsgDOTAFantasyLivePlayerStats>, IDeepCloneable<CMsgDOTAFantasyLivePlayerStats>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAFantasyLivePlayerStats](Divine.Protobufs.Dota2.CMsgDOTAFantasyLivePlayerStats.md)

#### Implements

IMessage<CMsgDOTAFantasyLivePlayerStats\>, 
[IEquatable<CMsgDOTAFantasyLivePlayerStats\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAFantasyLivePlayerStats\>, 
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
[EnumerableExtensions.In<CMsgDOTAFantasyLivePlayerStats\>\(CMsgDOTAFantasyLivePlayerStats, params CMsgDOTAFantasyLivePlayerStats\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyLivePlayerStats__ctor"></a> CMsgDOTAFantasyLivePlayerStats\(\)

```csharp
public CMsgDOTAFantasyLivePlayerStats()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyLivePlayerStats__ctor_Divine_Protobufs_Dota2_CMsgDOTAFantasyLivePlayerStats_"></a> CMsgDOTAFantasyLivePlayerStats\(CMsgDOTAFantasyLivePlayerStats\)

```csharp
public CMsgDOTAFantasyLivePlayerStats(CMsgDOTAFantasyLivePlayerStats other)
```

#### Parameters

`other` [CMsgDOTAFantasyLivePlayerStats](Divine.Protobufs.Dota2.CMsgDOTAFantasyLivePlayerStats.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyLivePlayerStats_StatsFieldNumber"></a> StatsFieldNumber

```csharp
public const int StatsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyLivePlayerStats_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyLivePlayerStats_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAFantasyLivePlayerStats> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAFantasyLivePlayerStats](Divine.Protobufs.Dota2.CMsgDOTAFantasyLivePlayerStats.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyLivePlayerStats_Stats"></a> Stats

```csharp
public RepeatedField<CMsgDOTAFantasyPlayerStats> Stats { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTAFantasyPlayerStats](Divine.Protobufs.Dota2.CMsgDOTAFantasyPlayerStats.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyLivePlayerStats_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyLivePlayerStats_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAFantasyLivePlayerStats Clone()
```

#### Returns

 [CMsgDOTAFantasyLivePlayerStats](Divine.Protobufs.Dota2.CMsgDOTAFantasyLivePlayerStats.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyLivePlayerStats_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyLivePlayerStats_Equals_Divine_Protobufs_Dota2_CMsgDOTAFantasyLivePlayerStats_"></a> Equals\(CMsgDOTAFantasyLivePlayerStats\)

```csharp
public bool Equals(CMsgDOTAFantasyLivePlayerStats other)
```

#### Parameters

`other` [CMsgDOTAFantasyLivePlayerStats](Divine.Protobufs.Dota2.CMsgDOTAFantasyLivePlayerStats.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyLivePlayerStats_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyLivePlayerStats_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAFantasyLivePlayerStats_"></a> MergeFrom\(CMsgDOTAFantasyLivePlayerStats\)

```csharp
public void MergeFrom(CMsgDOTAFantasyLivePlayerStats other)
```

#### Parameters

`other` [CMsgDOTAFantasyLivePlayerStats](Divine.Protobufs.Dota2.CMsgDOTAFantasyLivePlayerStats.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyLivePlayerStats_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyLivePlayerStats_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyLivePlayerStats_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

