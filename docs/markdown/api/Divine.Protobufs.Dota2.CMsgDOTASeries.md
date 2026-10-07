# <a id="Divine_Protobufs_Dota2_CMsgDOTASeries"></a> Class CMsgDOTASeries

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTASeries : IMessage<CMsgDOTASeries>, IEquatable<CMsgDOTASeries>, IDeepCloneable<CMsgDOTASeries>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTASeries](Divine.Protobufs.Dota2.CMsgDOTASeries.md)

#### Implements

IMessage<CMsgDOTASeries\>, 
[IEquatable<CMsgDOTASeries\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTASeries\>, 
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
[EnumerableExtensions.In<CMsgDOTASeries\>\(CMsgDOTASeries, params CMsgDOTASeries\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries__ctor"></a> CMsgDOTASeries\(\)

```csharp
public CMsgDOTASeries()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries__ctor_Divine_Protobufs_Dota2_CMsgDOTASeries_"></a> CMsgDOTASeries\(CMsgDOTASeries\)

```csharp
public CMsgDOTASeries(CMsgDOTASeries other)
```

#### Parameters

`other` [CMsgDOTASeries](Divine.Protobufs.Dota2.CMsgDOTASeries.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_LiveGameFieldNumber"></a> LiveGameFieldNumber

```csharp
public const int LiveGameFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_MatchMinimalFieldNumber"></a> MatchMinimalFieldNumber

```csharp
public const int MatchMinimalFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_SeriesIdFieldNumber"></a> SeriesIdFieldNumber

```csharp
public const int SeriesIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_SeriesTypeFieldNumber"></a> SeriesTypeFieldNumber

```csharp
public const int SeriesTypeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_Team1FieldNumber"></a> Team1FieldNumber

```csharp
public const int Team1FieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_Team2FieldNumber"></a> Team2FieldNumber

```csharp
public const int Team2FieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_HasSeriesId"></a> HasSeriesId

```csharp
public bool HasSeriesId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_HasSeriesType"></a> HasSeriesType

```csharp
public bool HasSeriesType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_LiveGame"></a> LiveGame

```csharp
public CMsgDOTASeries.Types.LiveGame LiveGame { get; set; }
```

#### Property Value

 [CMsgDOTASeries](Divine.Protobufs.Dota2.CMsgDOTASeries.md).[Types](Divine.Protobufs.Dota2.CMsgDOTASeries.Types.md).[LiveGame](Divine.Protobufs.Dota2.CMsgDOTASeries.Types.LiveGame.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_MatchMinimal"></a> MatchMinimal

```csharp
public RepeatedField<CMsgDOTAMatchMinimal> MatchMinimal { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTAMatchMinimal](Divine.Protobufs.Dota2.CMsgDOTAMatchMinimal.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTASeries> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTASeries](Divine.Protobufs.Dota2.CMsgDOTASeries.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_SeriesId"></a> SeriesId

```csharp
public uint SeriesId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_SeriesType"></a> SeriesType

```csharp
public uint SeriesType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_Team1"></a> Team1

```csharp
public CMsgDOTASeries.Types.TeamInfo Team1 { get; set; }
```

#### Property Value

 [CMsgDOTASeries](Divine.Protobufs.Dota2.CMsgDOTASeries.md).[Types](Divine.Protobufs.Dota2.CMsgDOTASeries.Types.md).[TeamInfo](Divine.Protobufs.Dota2.CMsgDOTASeries.Types.TeamInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_Team2"></a> Team2

```csharp
public CMsgDOTASeries.Types.TeamInfo Team2 { get; set; }
```

#### Property Value

 [CMsgDOTASeries](Divine.Protobufs.Dota2.CMsgDOTASeries.md).[Types](Divine.Protobufs.Dota2.CMsgDOTASeries.Types.md).[TeamInfo](Divine.Protobufs.Dota2.CMsgDOTASeries.Types.TeamInfo.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_ClearSeriesId"></a> ClearSeriesId\(\)

```csharp
public void ClearSeriesId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_ClearSeriesType"></a> ClearSeriesType\(\)

```csharp
public void ClearSeriesType()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_Clone"></a> Clone\(\)

```csharp
public CMsgDOTASeries Clone()
```

#### Returns

 [CMsgDOTASeries](Divine.Protobufs.Dota2.CMsgDOTASeries.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_Equals_Divine_Protobufs_Dota2_CMsgDOTASeries_"></a> Equals\(CMsgDOTASeries\)

```csharp
public bool Equals(CMsgDOTASeries other)
```

#### Parameters

`other` [CMsgDOTASeries](Divine.Protobufs.Dota2.CMsgDOTASeries.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTASeries_"></a> MergeFrom\(CMsgDOTASeries\)

```csharp
public void MergeFrom(CMsgDOTASeries other)
```

#### Parameters

`other` [CMsgDOTASeries](Divine.Protobufs.Dota2.CMsgDOTASeries.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASeries_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

