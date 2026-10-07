# <a id="Divine_Protobufs_Dota2_CMsgSignOutMapStats"></a> Class CMsgSignOutMapStats

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSignOutMapStats : IMessage<CMsgSignOutMapStats>, IEquatable<CMsgSignOutMapStats>, IDeepCloneable<CMsgSignOutMapStats>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSignOutMapStats](Divine.Protobufs.Dota2.CMsgSignOutMapStats.md)

#### Implements

IMessage<CMsgSignOutMapStats\>, 
[IEquatable<CMsgSignOutMapStats\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSignOutMapStats\>, 
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
[EnumerableExtensions.In<CMsgSignOutMapStats\>\(CMsgSignOutMapStats, params CMsgSignOutMapStats\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMapStats__ctor"></a> CMsgSignOutMapStats\(\)

```csharp
public CMsgSignOutMapStats()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMapStats__ctor_Divine_Protobufs_Dota2_CMsgSignOutMapStats_"></a> CMsgSignOutMapStats\(CMsgSignOutMapStats\)

```csharp
public CMsgSignOutMapStats(CMsgSignOutMapStats other)
```

#### Parameters

`other` [CMsgSignOutMapStats](Divine.Protobufs.Dota2.CMsgSignOutMapStats.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMapStats_GlobalStatsFieldNumber"></a> GlobalStatsFieldNumber

```csharp
public const int GlobalStatsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMapStats_PlayersFieldNumber"></a> PlayersFieldNumber

```csharp
public const int PlayersFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMapStats_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMapStats_GlobalStats"></a> GlobalStats

```csharp
public CMsgMapStatsSnapshot GlobalStats { get; set; }
```

#### Property Value

 [CMsgMapStatsSnapshot](Divine.Protobufs.Dota2.CMsgMapStatsSnapshot.md)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMapStats_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSignOutMapStats> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSignOutMapStats](Divine.Protobufs.Dota2.CMsgSignOutMapStats.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMapStats_Players"></a> Players

```csharp
public RepeatedField<CMsgSignOutMapStats.Types.Player> Players { get; }
```

#### Property Value

 RepeatedField<[CMsgSignOutMapStats](Divine.Protobufs.Dota2.CMsgSignOutMapStats.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutMapStats.Types.md).[Player](Divine.Protobufs.Dota2.CMsgSignOutMapStats.Types.Player.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMapStats_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMapStats_Clone"></a> Clone\(\)

```csharp
public CMsgSignOutMapStats Clone()
```

#### Returns

 [CMsgSignOutMapStats](Divine.Protobufs.Dota2.CMsgSignOutMapStats.md)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMapStats_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMapStats_Equals_Divine_Protobufs_Dota2_CMsgSignOutMapStats_"></a> Equals\(CMsgSignOutMapStats\)

```csharp
public bool Equals(CMsgSignOutMapStats other)
```

#### Parameters

`other` [CMsgSignOutMapStats](Divine.Protobufs.Dota2.CMsgSignOutMapStats.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMapStats_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMapStats_MergeFrom_Divine_Protobufs_Dota2_CMsgSignOutMapStats_"></a> MergeFrom\(CMsgSignOutMapStats\)

```csharp
public void MergeFrom(CMsgSignOutMapStats other)
```

#### Parameters

`other` [CMsgSignOutMapStats](Divine.Protobufs.Dota2.CMsgSignOutMapStats.md)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMapStats_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMapStats_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutMapStats_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

