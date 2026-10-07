# <a id="Divine_Protobufs_Dota2_CMsgDOTAUpdateMatchmakingStats"></a> Class CMsgDOTAUpdateMatchmakingStats

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAUpdateMatchmakingStats : IMessage<CMsgDOTAUpdateMatchmakingStats>, IEquatable<CMsgDOTAUpdateMatchmakingStats>, IDeepCloneable<CMsgDOTAUpdateMatchmakingStats>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAUpdateMatchmakingStats](Divine.Protobufs.Dota2.CMsgDOTAUpdateMatchmakingStats.md)

#### Implements

IMessage<CMsgDOTAUpdateMatchmakingStats\>, 
[IEquatable<CMsgDOTAUpdateMatchmakingStats\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAUpdateMatchmakingStats\>, 
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
[EnumerableExtensions.In<CMsgDOTAUpdateMatchmakingStats\>\(CMsgDOTAUpdateMatchmakingStats, params CMsgDOTAUpdateMatchmakingStats\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAUpdateMatchmakingStats__ctor"></a> CMsgDOTAUpdateMatchmakingStats\(\)

```csharp
public CMsgDOTAUpdateMatchmakingStats()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAUpdateMatchmakingStats__ctor_Divine_Protobufs_Dota2_CMsgDOTAUpdateMatchmakingStats_"></a> CMsgDOTAUpdateMatchmakingStats\(CMsgDOTAUpdateMatchmakingStats\)

```csharp
public CMsgDOTAUpdateMatchmakingStats(CMsgDOTAUpdateMatchmakingStats other)
```

#### Parameters

`other` [CMsgDOTAUpdateMatchmakingStats](Divine.Protobufs.Dota2.CMsgDOTAUpdateMatchmakingStats.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAUpdateMatchmakingStats_StatsFieldNumber"></a> StatsFieldNumber

```csharp
public const int StatsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAUpdateMatchmakingStats_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAUpdateMatchmakingStats_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAUpdateMatchmakingStats> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAUpdateMatchmakingStats](Divine.Protobufs.Dota2.CMsgDOTAUpdateMatchmakingStats.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAUpdateMatchmakingStats_Stats"></a> Stats

```csharp
public CMsgDOTAMatchmakingStatsResponse Stats { get; set; }
```

#### Property Value

 [CMsgDOTAMatchmakingStatsResponse](Divine.Protobufs.Dota2.CMsgDOTAMatchmakingStatsResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAUpdateMatchmakingStats_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAUpdateMatchmakingStats_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAUpdateMatchmakingStats Clone()
```

#### Returns

 [CMsgDOTAUpdateMatchmakingStats](Divine.Protobufs.Dota2.CMsgDOTAUpdateMatchmakingStats.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAUpdateMatchmakingStats_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAUpdateMatchmakingStats_Equals_Divine_Protobufs_Dota2_CMsgDOTAUpdateMatchmakingStats_"></a> Equals\(CMsgDOTAUpdateMatchmakingStats\)

```csharp
public bool Equals(CMsgDOTAUpdateMatchmakingStats other)
```

#### Parameters

`other` [CMsgDOTAUpdateMatchmakingStats](Divine.Protobufs.Dota2.CMsgDOTAUpdateMatchmakingStats.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAUpdateMatchmakingStats_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAUpdateMatchmakingStats_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAUpdateMatchmakingStats_"></a> MergeFrom\(CMsgDOTAUpdateMatchmakingStats\)

```csharp
public void MergeFrom(CMsgDOTAUpdateMatchmakingStats other)
```

#### Parameters

`other` [CMsgDOTAUpdateMatchmakingStats](Divine.Protobufs.Dota2.CMsgDOTAUpdateMatchmakingStats.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAUpdateMatchmakingStats_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAUpdateMatchmakingStats_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAUpdateMatchmakingStats_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

