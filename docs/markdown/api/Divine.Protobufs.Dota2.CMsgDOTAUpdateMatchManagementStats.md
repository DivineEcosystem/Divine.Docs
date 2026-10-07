# <a id="Divine_Protobufs_Dota2_CMsgDOTAUpdateMatchManagementStats"></a> Class CMsgDOTAUpdateMatchManagementStats

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAUpdateMatchManagementStats : IMessage<CMsgDOTAUpdateMatchManagementStats>, IEquatable<CMsgDOTAUpdateMatchManagementStats>, IDeepCloneable<CMsgDOTAUpdateMatchManagementStats>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAUpdateMatchManagementStats](Divine.Protobufs.Dota2.CMsgDOTAUpdateMatchManagementStats.md)

#### Implements

IMessage<CMsgDOTAUpdateMatchManagementStats\>, 
[IEquatable<CMsgDOTAUpdateMatchManagementStats\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAUpdateMatchManagementStats\>, 
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
[EnumerableExtensions.In<CMsgDOTAUpdateMatchManagementStats\>\(CMsgDOTAUpdateMatchManagementStats, params CMsgDOTAUpdateMatchManagementStats\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAUpdateMatchManagementStats__ctor"></a> CMsgDOTAUpdateMatchManagementStats\(\)

```csharp
public CMsgDOTAUpdateMatchManagementStats()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAUpdateMatchManagementStats__ctor_Divine_Protobufs_Dota2_CMsgDOTAUpdateMatchManagementStats_"></a> CMsgDOTAUpdateMatchManagementStats\(CMsgDOTAUpdateMatchManagementStats\)

```csharp
public CMsgDOTAUpdateMatchManagementStats(CMsgDOTAUpdateMatchManagementStats other)
```

#### Parameters

`other` [CMsgDOTAUpdateMatchManagementStats](Divine.Protobufs.Dota2.CMsgDOTAUpdateMatchManagementStats.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAUpdateMatchManagementStats_StatsFieldNumber"></a> StatsFieldNumber

```csharp
public const int StatsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAUpdateMatchManagementStats_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAUpdateMatchManagementStats_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAUpdateMatchManagementStats> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAUpdateMatchManagementStats](Divine.Protobufs.Dota2.CMsgDOTAUpdateMatchManagementStats.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAUpdateMatchManagementStats_Stats"></a> Stats

```csharp
public CMsgDOTAMatchmakingStatsResponse Stats { get; set; }
```

#### Property Value

 [CMsgDOTAMatchmakingStatsResponse](Divine.Protobufs.Dota2.CMsgDOTAMatchmakingStatsResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAUpdateMatchManagementStats_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAUpdateMatchManagementStats_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAUpdateMatchManagementStats Clone()
```

#### Returns

 [CMsgDOTAUpdateMatchManagementStats](Divine.Protobufs.Dota2.CMsgDOTAUpdateMatchManagementStats.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAUpdateMatchManagementStats_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAUpdateMatchManagementStats_Equals_Divine_Protobufs_Dota2_CMsgDOTAUpdateMatchManagementStats_"></a> Equals\(CMsgDOTAUpdateMatchManagementStats\)

```csharp
public bool Equals(CMsgDOTAUpdateMatchManagementStats other)
```

#### Parameters

`other` [CMsgDOTAUpdateMatchManagementStats](Divine.Protobufs.Dota2.CMsgDOTAUpdateMatchManagementStats.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAUpdateMatchManagementStats_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAUpdateMatchManagementStats_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAUpdateMatchManagementStats_"></a> MergeFrom\(CMsgDOTAUpdateMatchManagementStats\)

```csharp
public void MergeFrom(CMsgDOTAUpdateMatchManagementStats other)
```

#### Parameters

`other` [CMsgDOTAUpdateMatchManagementStats](Divine.Protobufs.Dota2.CMsgDOTAUpdateMatchManagementStats.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAUpdateMatchManagementStats_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAUpdateMatchManagementStats_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAUpdateMatchManagementStats_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

