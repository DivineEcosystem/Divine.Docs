# <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_Standing"></a> Class CMsgDOTADPCSeasonResults.Types.Standing

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTADPCSeasonResults.Types.Standing : IMessage<CMsgDOTADPCSeasonResults.Types.Standing>, IEquatable<CMsgDOTADPCSeasonResults.Types.Standing>, IDeepCloneable<CMsgDOTADPCSeasonResults.Types.Standing>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTADPCSeasonResults.Types.Standing](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.Types.Standing.md)

#### Implements

IMessage<CMsgDOTADPCSeasonResults.Types.Standing\>, 
[IEquatable<CMsgDOTADPCSeasonResults.Types.Standing\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTADPCSeasonResults.Types.Standing\>, 
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
[EnumerableExtensions.In<CMsgDOTADPCSeasonResults.Types.Standing\>\(CMsgDOTADPCSeasonResults.Types.Standing, params CMsgDOTADPCSeasonResults.Types.Standing\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_Standing__ctor"></a> Standing\(\)

```csharp
public Standing()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_Standing__ctor_Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_Standing_"></a> Standing\(Standing\)

```csharp
public Standing(CMsgDOTADPCSeasonResults.Types.Standing other)
```

#### Parameters

`other` [CMsgDOTADPCSeasonResults](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.md).[Types](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.Types.md).[Standing](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.Types.Standing.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_Standing_DivisionFieldNumber"></a> DivisionFieldNumber

```csharp
public const int DivisionFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_Standing_EntriesFieldNumber"></a> EntriesFieldNumber

```csharp
public const int EntriesFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_Standing_RegionFieldNumber"></a> RegionFieldNumber

```csharp
public const int RegionFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_Standing_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_Standing_Division"></a> Division

```csharp
public ELeagueDivision Division { get; set; }
```

#### Property Value

 [ELeagueDivision](Divine.Protobufs.Dota2.ELeagueDivision.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_Standing_Entries"></a> Entries

```csharp
public RepeatedField<CMsgDOTADPCSeasonResults.Types.StandingEntry> Entries { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTADPCSeasonResults](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.md).[Types](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.Types.md).[StandingEntry](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.Types.StandingEntry.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_Standing_HasDivision"></a> HasDivision

```csharp
public bool HasDivision { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_Standing_HasRegion"></a> HasRegion

```csharp
public bool HasRegion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_Standing_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTADPCSeasonResults.Types.Standing> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTADPCSeasonResults](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.md).[Types](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.Types.md).[Standing](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.Types.Standing.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_Standing_Region"></a> Region

```csharp
public ELeagueRegion Region { get; set; }
```

#### Property Value

 [ELeagueRegion](Divine.Protobufs.Dota2.ELeagueRegion.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_Standing_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_Standing_ClearDivision"></a> ClearDivision\(\)

```csharp
public void ClearDivision()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_Standing_ClearRegion"></a> ClearRegion\(\)

```csharp
public void ClearRegion()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_Standing_Clone"></a> Clone\(\)

```csharp
public CMsgDOTADPCSeasonResults.Types.Standing Clone()
```

#### Returns

 [CMsgDOTADPCSeasonResults](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.md).[Types](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.Types.md).[Standing](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.Types.Standing.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_Standing_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_Standing_Equals_Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_Standing_"></a> Equals\(Standing\)

```csharp
public bool Equals(CMsgDOTADPCSeasonResults.Types.Standing other)
```

#### Parameters

`other` [CMsgDOTADPCSeasonResults](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.md).[Types](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.Types.md).[Standing](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.Types.Standing.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_Standing_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_Standing_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_Standing_"></a> MergeFrom\(Standing\)

```csharp
public void MergeFrom(CMsgDOTADPCSeasonResults.Types.Standing other)
```

#### Parameters

`other` [CMsgDOTADPCSeasonResults](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.md).[Types](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.Types.md).[Standing](Divine.Protobufs.Dota2.CMsgDOTADPCSeasonResults.Types.Standing.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_Standing_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_Standing_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSeasonResults_Types_Standing_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

