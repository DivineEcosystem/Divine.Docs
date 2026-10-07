# <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_SeriesInfo"></a> Class CMsgDOTALeague.Types.SeriesInfo

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTALeague.Types.SeriesInfo : IMessage<CMsgDOTALeague.Types.SeriesInfo>, IEquatable<CMsgDOTALeague.Types.SeriesInfo>, IDeepCloneable<CMsgDOTALeague.Types.SeriesInfo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTALeague.Types.SeriesInfo](Divine.Protobufs.Dota2.CMsgDOTALeague.Types.SeriesInfo.md)

#### Implements

IMessage<CMsgDOTALeague.Types.SeriesInfo\>, 
[IEquatable<CMsgDOTALeague.Types.SeriesInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTALeague.Types.SeriesInfo\>, 
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
[EnumerableExtensions.In<CMsgDOTALeague.Types.SeriesInfo\>\(CMsgDOTALeague.Types.SeriesInfo, params CMsgDOTALeague.Types.SeriesInfo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_SeriesInfo__ctor"></a> SeriesInfo\(\)

```csharp
public SeriesInfo()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_SeriesInfo__ctor_Divine_Protobufs_Dota2_CMsgDOTALeague_Types_SeriesInfo_"></a> SeriesInfo\(SeriesInfo\)

```csharp
public SeriesInfo(CMsgDOTALeague.Types.SeriesInfo other)
```

#### Parameters

`other` [CMsgDOTALeague](Divine.Protobufs.Dota2.CMsgDOTALeague.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeague.Types.md).[SeriesInfo](Divine.Protobufs.Dota2.CMsgDOTALeague.Types.SeriesInfo.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_SeriesInfo_MatchIdsFieldNumber"></a> MatchIdsFieldNumber

```csharp
public const int MatchIdsFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_SeriesInfo_SeriesIdFieldNumber"></a> SeriesIdFieldNumber

```csharp
public const int SeriesIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_SeriesInfo_SeriesTypeFieldNumber"></a> SeriesTypeFieldNumber

```csharp
public const int SeriesTypeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_SeriesInfo_StartTimeFieldNumber"></a> StartTimeFieldNumber

```csharp
public const int StartTimeFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_SeriesInfo_TeamId1FieldNumber"></a> TeamId1FieldNumber

```csharp
public const int TeamId1FieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_SeriesInfo_TeamId2FieldNumber"></a> TeamId2FieldNumber

```csharp
public const int TeamId2FieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_SeriesInfo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_SeriesInfo_HasSeriesId"></a> HasSeriesId

```csharp
public bool HasSeriesId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_SeriesInfo_HasSeriesType"></a> HasSeriesType

```csharp
public bool HasSeriesType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_SeriesInfo_HasStartTime"></a> HasStartTime

```csharp
public bool HasStartTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_SeriesInfo_HasTeamId1"></a> HasTeamId1

```csharp
public bool HasTeamId1 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_SeriesInfo_HasTeamId2"></a> HasTeamId2

```csharp
public bool HasTeamId2 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_SeriesInfo_MatchIds"></a> MatchIds

```csharp
public RepeatedField<ulong> MatchIds { get; }
```

#### Property Value

 RepeatedField<[ulong](https://learn.microsoft.com/dotnet/api/system.uint64)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_SeriesInfo_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTALeague.Types.SeriesInfo> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTALeague](Divine.Protobufs.Dota2.CMsgDOTALeague.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeague.Types.md).[SeriesInfo](Divine.Protobufs.Dota2.CMsgDOTALeague.Types.SeriesInfo.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_SeriesInfo_SeriesId"></a> SeriesId

```csharp
public uint SeriesId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_SeriesInfo_SeriesType"></a> SeriesType

```csharp
public uint SeriesType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_SeriesInfo_StartTime"></a> StartTime

```csharp
public uint StartTime { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_SeriesInfo_TeamId1"></a> TeamId1

```csharp
public uint TeamId1 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_SeriesInfo_TeamId2"></a> TeamId2

```csharp
public uint TeamId2 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_SeriesInfo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_SeriesInfo_ClearSeriesId"></a> ClearSeriesId\(\)

```csharp
public void ClearSeriesId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_SeriesInfo_ClearSeriesType"></a> ClearSeriesType\(\)

```csharp
public void ClearSeriesType()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_SeriesInfo_ClearStartTime"></a> ClearStartTime\(\)

```csharp
public void ClearStartTime()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_SeriesInfo_ClearTeamId1"></a> ClearTeamId1\(\)

```csharp
public void ClearTeamId1()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_SeriesInfo_ClearTeamId2"></a> ClearTeamId2\(\)

```csharp
public void ClearTeamId2()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_SeriesInfo_Clone"></a> Clone\(\)

```csharp
public CMsgDOTALeague.Types.SeriesInfo Clone()
```

#### Returns

 [CMsgDOTALeague](Divine.Protobufs.Dota2.CMsgDOTALeague.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeague.Types.md).[SeriesInfo](Divine.Protobufs.Dota2.CMsgDOTALeague.Types.SeriesInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_SeriesInfo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_SeriesInfo_Equals_Divine_Protobufs_Dota2_CMsgDOTALeague_Types_SeriesInfo_"></a> Equals\(SeriesInfo\)

```csharp
public bool Equals(CMsgDOTALeague.Types.SeriesInfo other)
```

#### Parameters

`other` [CMsgDOTALeague](Divine.Protobufs.Dota2.CMsgDOTALeague.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeague.Types.md).[SeriesInfo](Divine.Protobufs.Dota2.CMsgDOTALeague.Types.SeriesInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_SeriesInfo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_SeriesInfo_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTALeague_Types_SeriesInfo_"></a> MergeFrom\(SeriesInfo\)

```csharp
public void MergeFrom(CMsgDOTALeague.Types.SeriesInfo other)
```

#### Parameters

`other` [CMsgDOTALeague](Divine.Protobufs.Dota2.CMsgDOTALeague.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeague.Types.md).[SeriesInfo](Divine.Protobufs.Dota2.CMsgDOTALeague.Types.SeriesInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_SeriesInfo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_SeriesInfo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeague_Types_SeriesInfo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

