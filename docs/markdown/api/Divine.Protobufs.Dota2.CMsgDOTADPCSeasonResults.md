# <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults"></a> Class CMsgDOTADPCSeasonResults

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTADPCSeasonResults : IMessage<CMsgDOTADPCSeasonResults>, IEquatable<CMsgDOTADPCSeasonResults>, IDeepCloneable<CMsgDOTADPCSeasonResults>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTADPCSeasonResults](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.md)

#### Implements

IMessage<CMsgDOTADPCSeasonResults\>, 
[IEquatable<CMsgDOTADPCSeasonResults\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTADPCSeasonResults\>, 
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
[EnumerableExtensions.In<CMsgDOTADPCSeasonResults\>\(CMsgDOTADPCSeasonResults, params CMsgDOTADPCSeasonResults\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults__ctor"></a> CMsgDOTADPCSeasonResults\(\)

```csharp
public CMsgDOTADPCSeasonResults()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults__ctor_Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_"></a> CMsgDOTADPCSeasonResults\(CMsgDOTADPCSeasonResults\)

```csharp
public CMsgDOTADPCSeasonResults(CMsgDOTADPCSeasonResults other)
```

#### Parameters

`other` [CMsgDOTADPCSeasonResults](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_MajorGroupStandingsFieldNumber"></a> MajorGroupStandingsFieldNumber

```csharp
public const int MajorGroupStandingsFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_MajorPlayoffStandingsFieldNumber"></a> MajorPlayoffStandingsFieldNumber

```csharp
public const int MajorPlayoffStandingsFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_MajorWildcardStandingsFieldNumber"></a> MajorWildcardStandingsFieldNumber

```csharp
public const int MajorWildcardStandingsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_ResultsFieldNumber"></a> ResultsFieldNumber

```csharp
public const int ResultsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_StandingsFieldNumber"></a> StandingsFieldNumber

```csharp
public const int StandingsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_MajorGroupStandings"></a> MajorGroupStandings

```csharp
public RepeatedField<CMsgDOTADPCSeasonResults.Types.StandingEntry> MajorGroupStandings { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTADPCSeasonResults](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.md).[Types](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.Types.md).[StandingEntry](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.Types.StandingEntry.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_MajorPlayoffStandings"></a> MajorPlayoffStandings

```csharp
public RepeatedField<CMsgDOTADPCSeasonResults.Types.StandingEntry> MajorPlayoffStandings { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTADPCSeasonResults](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.md).[Types](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.Types.md).[StandingEntry](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.Types.StandingEntry.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_MajorWildcardStandings"></a> MajorWildcardStandings

```csharp
public RepeatedField<CMsgDOTADPCSeasonResults.Types.StandingEntry> MajorWildcardStandings { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTADPCSeasonResults](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.md).[Types](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.Types.md).[StandingEntry](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.Types.StandingEntry.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTADPCSeasonResults> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTADPCSeasonResults](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Results"></a> Results

```csharp
public RepeatedField<CMsgDOTADPCSeasonResults.Types.TeamResult> Results { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTADPCSeasonResults](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.md).[Types](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.Types.md).[TeamResult](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.Types.TeamResult.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Standings"></a> Standings

```csharp
public RepeatedField<CMsgDOTADPCSeasonResults.Types.Standing> Standings { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTADPCSeasonResults](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.md).[Types](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.Types.md).[Standing](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.Types.Standing.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Clone"></a> Clone\(\)

```csharp
public CMsgDOTADPCSeasonResults Clone()
```

#### Returns

 [CMsgDOTADPCSeasonResults](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Equals_Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_"></a> Equals\(CMsgDOTADPCSeasonResults\)

```csharp
public bool Equals(CMsgDOTADPCSeasonResults other)
```

#### Parameters

`other` [CMsgDOTADPCSeasonResults](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_"></a> MergeFrom\(CMsgDOTADPCSeasonResults\)

```csharp
public void MergeFrom(CMsgDOTADPCSeasonResults other)
```

#### Parameters

`other` [CMsgDOTADPCSeasonResults](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

