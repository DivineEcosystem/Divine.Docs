# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsTeamMinuteDetails_Types_LocationPerformance"></a> Class CDOTAUserMsg\_StatsTeamMinuteDetails.Types.LocationPerformance

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_StatsTeamMinuteDetails.Types.LocationPerformance : IMessage<CDOTAUserMsg_StatsTeamMinuteDetails.Types.LocationPerformance>, IEquatable<CDOTAUserMsg_StatsTeamMinuteDetails.Types.LocationPerformance>, IDeepCloneable<CDOTAUserMsg_StatsTeamMinuteDetails.Types.LocationPerformance>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_StatsTeamMinuteDetails.Types.LocationPerformance](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsTeamMinuteDetails.Types.LocationPerformance.md)

#### Implements

IMessage<CDOTAUserMsg\_StatsTeamMinuteDetails.Types.LocationPerformance\>, 
[IEquatable<CDOTAUserMsg\_StatsTeamMinuteDetails.Types.LocationPerformance\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_StatsTeamMinuteDetails.Types.LocationPerformance\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_StatsTeamMinuteDetails.Types.LocationPerformance\>\(CDOTAUserMsg\_StatsTeamMinuteDetails.Types.LocationPerformance, params CDOTAUserMsg\_StatsTeamMinuteDetails.Types.LocationPerformance\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsTeamMinuteDetails_Types_LocationPerformance__ctor"></a> LocationPerformance\(\)

```csharp
public LocationPerformance()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsTeamMinuteDetails_Types_LocationPerformance__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_StatsTeamMinuteDetails_Types_LocationPerformance_"></a> LocationPerformance\(LocationPerformance\)

```csharp
public LocationPerformance(CDOTAUserMsg_StatsTeamMinuteDetails.Types.LocationPerformance other)
```

#### Parameters

`other` [CDOTAUserMsg\_StatsTeamMinuteDetails](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsTeamMinuteDetails.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsTeamMinuteDetails.Types.md).[LocationPerformance](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsTeamMinuteDetails.Types.LocationPerformance.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsTeamMinuteDetails_Types_LocationPerformance_LocationCategoryFieldNumber"></a> LocationCategoryFieldNumber

```csharp
public const int LocationCategoryFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsTeamMinuteDetails_Types_LocationPerformance_StatTypeFieldNumber"></a> StatTypeFieldNumber

```csharp
public const int StatTypeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsTeamMinuteDetails_Types_LocationPerformance_ValueFieldNumber"></a> ValueFieldNumber

```csharp
public const int ValueFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsTeamMinuteDetails_Types_LocationPerformance_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsTeamMinuteDetails_Types_LocationPerformance_HasLocationCategory"></a> HasLocationCategory

```csharp
public bool HasLocationCategory { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsTeamMinuteDetails_Types_LocationPerformance_HasStatType"></a> HasStatType

```csharp
public bool HasStatType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsTeamMinuteDetails_Types_LocationPerformance_HasValue"></a> HasValue

```csharp
public bool HasValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsTeamMinuteDetails_Types_LocationPerformance_LocationCategory"></a> LocationCategory

```csharp
public uint LocationCategory { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsTeamMinuteDetails_Types_LocationPerformance_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_StatsTeamMinuteDetails.Types.LocationPerformance> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_StatsTeamMinuteDetails](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsTeamMinuteDetails.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsTeamMinuteDetails.Types.md).[LocationPerformance](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsTeamMinuteDetails.Types.LocationPerformance.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsTeamMinuteDetails_Types_LocationPerformance_StatType"></a> StatType

```csharp
public uint StatType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsTeamMinuteDetails_Types_LocationPerformance_Value"></a> Value

```csharp
public uint Value { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsTeamMinuteDetails_Types_LocationPerformance_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsTeamMinuteDetails_Types_LocationPerformance_ClearLocationCategory"></a> ClearLocationCategory\(\)

```csharp
public void ClearLocationCategory()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsTeamMinuteDetails_Types_LocationPerformance_ClearStatType"></a> ClearStatType\(\)

```csharp
public void ClearStatType()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsTeamMinuteDetails_Types_LocationPerformance_ClearValue"></a> ClearValue\(\)

```csharp
public void ClearValue()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsTeamMinuteDetails_Types_LocationPerformance_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_StatsTeamMinuteDetails.Types.LocationPerformance Clone()
```

#### Returns

 [CDOTAUserMsg\_StatsTeamMinuteDetails](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsTeamMinuteDetails.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsTeamMinuteDetails.Types.md).[LocationPerformance](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsTeamMinuteDetails.Types.LocationPerformance.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsTeamMinuteDetails_Types_LocationPerformance_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsTeamMinuteDetails_Types_LocationPerformance_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_StatsTeamMinuteDetails_Types_LocationPerformance_"></a> Equals\(LocationPerformance\)

```csharp
public bool Equals(CDOTAUserMsg_StatsTeamMinuteDetails.Types.LocationPerformance other)
```

#### Parameters

`other` [CDOTAUserMsg\_StatsTeamMinuteDetails](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsTeamMinuteDetails.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsTeamMinuteDetails.Types.md).[LocationPerformance](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsTeamMinuteDetails.Types.LocationPerformance.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsTeamMinuteDetails_Types_LocationPerformance_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsTeamMinuteDetails_Types_LocationPerformance_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_StatsTeamMinuteDetails_Types_LocationPerformance_"></a> MergeFrom\(LocationPerformance\)

```csharp
public void MergeFrom(CDOTAUserMsg_StatsTeamMinuteDetails.Types.LocationPerformance other)
```

#### Parameters

`other` [CDOTAUserMsg\_StatsTeamMinuteDetails](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsTeamMinuteDetails.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsTeamMinuteDetails.Types.md).[LocationPerformance](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsTeamMinuteDetails.Types.LocationPerformance.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsTeamMinuteDetails_Types_LocationPerformance_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsTeamMinuteDetails_Types_LocationPerformance_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsTeamMinuteDetails_Types_LocationPerformance_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

