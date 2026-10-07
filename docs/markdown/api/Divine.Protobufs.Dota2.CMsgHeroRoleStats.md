# <a id="Divine_Protobufs_Dota2_CMsgHeroRoleStats"></a> Class CMsgHeroRoleStats

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgHeroRoleStats : IMessage<CMsgHeroRoleStats>, IEquatable<CMsgHeroRoleStats>, IDeepCloneable<CMsgHeroRoleStats>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgHeroRoleStats](Divine.Protobufs.Dota2.CMsgHeroRoleStats.md)

#### Implements

IMessage<CMsgHeroRoleStats\>, 
[IEquatable<CMsgHeroRoleStats\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgHeroRoleStats\>, 
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
[EnumerableExtensions.In<CMsgHeroRoleStats\>\(CMsgHeroRoleStats, params CMsgHeroRoleStats\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleStats__ctor"></a> CMsgHeroRoleStats\(\)

```csharp
public CMsgHeroRoleStats()
```

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleStats__ctor_Divine_Protobufs_Dota2_CMsgHeroRoleStats_"></a> CMsgHeroRoleStats\(CMsgHeroRoleStats\)

```csharp
public CMsgHeroRoleStats(CMsgHeroRoleStats other)
```

#### Parameters

`other` [CMsgHeroRoleStats](Divine.Protobufs.Dota2.CMsgHeroRoleStats.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleStats_LaneSelectionFlagsFieldNumber"></a> LaneSelectionFlagsFieldNumber

```csharp
public const int LaneSelectionFlagsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleStats_MatchCountFieldNumber"></a> MatchCountFieldNumber

```csharp
public const int MatchCountFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleStats_WinCountFieldNumber"></a> WinCountFieldNumber

```csharp
public const int WinCountFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleStats_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleStats_HasLaneSelectionFlags"></a> HasLaneSelectionFlags

```csharp
public bool HasLaneSelectionFlags { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleStats_HasMatchCount"></a> HasMatchCount

```csharp
public bool HasMatchCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleStats_HasWinCount"></a> HasWinCount

```csharp
public bool HasWinCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleStats_LaneSelectionFlags"></a> LaneSelectionFlags

```csharp
public uint LaneSelectionFlags { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleStats_MatchCount"></a> MatchCount

```csharp
public uint MatchCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleStats_Parser"></a> Parser

```csharp
public static MessageParser<CMsgHeroRoleStats> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgHeroRoleStats](Divine.Protobufs.Dota2.CMsgHeroRoleStats.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleStats_WinCount"></a> WinCount

```csharp
public uint WinCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleStats_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleStats_ClearLaneSelectionFlags"></a> ClearLaneSelectionFlags\(\)

```csharp
public void ClearLaneSelectionFlags()
```

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleStats_ClearMatchCount"></a> ClearMatchCount\(\)

```csharp
public void ClearMatchCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleStats_ClearWinCount"></a> ClearWinCount\(\)

```csharp
public void ClearWinCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleStats_Clone"></a> Clone\(\)

```csharp
public CMsgHeroRoleStats Clone()
```

#### Returns

 [CMsgHeroRoleStats](Divine.Protobufs.Dota2.CMsgHeroRoleStats.md)

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleStats_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleStats_Equals_Divine_Protobufs_Dota2_CMsgHeroRoleStats_"></a> Equals\(CMsgHeroRoleStats\)

```csharp
public bool Equals(CMsgHeroRoleStats other)
```

#### Parameters

`other` [CMsgHeroRoleStats](Divine.Protobufs.Dota2.CMsgHeroRoleStats.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleStats_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleStats_MergeFrom_Divine_Protobufs_Dota2_CMsgHeroRoleStats_"></a> MergeFrom\(CMsgHeroRoleStats\)

```csharp
public void MergeFrom(CMsgHeroRoleStats other)
```

#### Parameters

`other` [CMsgHeroRoleStats](Divine.Protobufs.Dota2.CMsgHeroRoleStats.md)

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleStats_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleStats_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleStats_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

