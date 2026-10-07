# <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyParticipationDetails_Types_Division"></a> Class CMsgDOTAWeekendTourneyParticipationDetails.Types.Division

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAWeekendTourneyParticipationDetails.Types.Division : IMessage<CMsgDOTAWeekendTourneyParticipationDetails.Types.Division>, IEquatable<CMsgDOTAWeekendTourneyParticipationDetails.Types.Division>, IDeepCloneable<CMsgDOTAWeekendTourneyParticipationDetails.Types.Division>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAWeekendTourneyParticipationDetails.Types.Division](Divine.Protobufs.Dota2.CMsgDOTAWeekendTourneyParticipationDetails.Types.Division.md)

#### Implements

IMessage<CMsgDOTAWeekendTourneyParticipationDetails.Types.Division\>, 
[IEquatable<CMsgDOTAWeekendTourneyParticipationDetails.Types.Division\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAWeekendTourneyParticipationDetails.Types.Division\>, 
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
[EnumerableExtensions.In<CMsgDOTAWeekendTourneyParticipationDetails.Types.Division\>\(CMsgDOTAWeekendTourneyParticipationDetails.Types.Division, params CMsgDOTAWeekendTourneyParticipationDetails.Types.Division\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyParticipationDetails_Types_Division__ctor"></a> Division\(\)

```csharp
public Division()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyParticipationDetails_Types_Division__ctor_Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyParticipationDetails_Types_Division_"></a> Division\(Division\)

```csharp
public Division(CMsgDOTAWeekendTourneyParticipationDetails.Types.Division other)
```

#### Parameters

`other` [CMsgDOTAWeekendTourneyParticipationDetails](Divine.Protobufs.Dota2.CMsgDOTAWeekendTourneyParticipationDetails.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAWeekendTourneyParticipationDetails.Types.md).[Division](Divine.Protobufs.Dota2.CMsgDOTAWeekendTourneyParticipationDetails.Types.Division.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyParticipationDetails_Types_Division_DivisionIdFieldNumber"></a> DivisionIdFieldNumber

```csharp
public const int DivisionIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyParticipationDetails_Types_Division_ScheduleTimeFieldNumber"></a> ScheduleTimeFieldNumber

```csharp
public const int ScheduleTimeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyParticipationDetails_Types_Division_TiersFieldNumber"></a> TiersFieldNumber

```csharp
public const int TiersFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyParticipationDetails_Types_Division_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyParticipationDetails_Types_Division_DivisionId"></a> DivisionId

```csharp
public uint DivisionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyParticipationDetails_Types_Division_HasDivisionId"></a> HasDivisionId

```csharp
public bool HasDivisionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyParticipationDetails_Types_Division_HasScheduleTime"></a> HasScheduleTime

```csharp
public bool HasScheduleTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyParticipationDetails_Types_Division_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAWeekendTourneyParticipationDetails.Types.Division> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAWeekendTourneyParticipationDetails](Divine.Protobufs.Dota2.CMsgDOTAWeekendTourneyParticipationDetails.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAWeekendTourneyParticipationDetails.Types.md).[Division](Divine.Protobufs.Dota2.CMsgDOTAWeekendTourneyParticipationDetails.Types.Division.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyParticipationDetails_Types_Division_ScheduleTime"></a> ScheduleTime

```csharp
public uint ScheduleTime { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyParticipationDetails_Types_Division_Tiers"></a> Tiers

```csharp
public RepeatedField<CMsgDOTAWeekendTourneyParticipationDetails.Types.Tier> Tiers { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTAWeekendTourneyParticipationDetails](Divine.Protobufs.Dota2.CMsgDOTAWeekendTourneyParticipationDetails.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAWeekendTourneyParticipationDetails.Types.md).[Tier](Divine.Protobufs.Dota2.CMsgDOTAWeekendTourneyParticipationDetails.Types.Tier.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyParticipationDetails_Types_Division_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyParticipationDetails_Types_Division_ClearDivisionId"></a> ClearDivisionId\(\)

```csharp
public void ClearDivisionId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyParticipationDetails_Types_Division_ClearScheduleTime"></a> ClearScheduleTime\(\)

```csharp
public void ClearScheduleTime()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyParticipationDetails_Types_Division_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAWeekendTourneyParticipationDetails.Types.Division Clone()
```

#### Returns

 [CMsgDOTAWeekendTourneyParticipationDetails](Divine.Protobufs.Dota2.CMsgDOTAWeekendTourneyParticipationDetails.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAWeekendTourneyParticipationDetails.Types.md).[Division](Divine.Protobufs.Dota2.CMsgDOTAWeekendTourneyParticipationDetails.Types.Division.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyParticipationDetails_Types_Division_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyParticipationDetails_Types_Division_Equals_Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyParticipationDetails_Types_Division_"></a> Equals\(Division\)

```csharp
public bool Equals(CMsgDOTAWeekendTourneyParticipationDetails.Types.Division other)
```

#### Parameters

`other` [CMsgDOTAWeekendTourneyParticipationDetails](Divine.Protobufs.Dota2.CMsgDOTAWeekendTourneyParticipationDetails.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAWeekendTourneyParticipationDetails.Types.md).[Division](Divine.Protobufs.Dota2.CMsgDOTAWeekendTourneyParticipationDetails.Types.Division.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyParticipationDetails_Types_Division_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyParticipationDetails_Types_Division_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyParticipationDetails_Types_Division_"></a> MergeFrom\(Division\)

```csharp
public void MergeFrom(CMsgDOTAWeekendTourneyParticipationDetails.Types.Division other)
```

#### Parameters

`other` [CMsgDOTAWeekendTourneyParticipationDetails](Divine.Protobufs.Dota2.CMsgDOTAWeekendTourneyParticipationDetails.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAWeekendTourneyParticipationDetails.Types.md).[Division](Divine.Protobufs.Dota2.CMsgDOTAWeekendTourneyParticipationDetails.Types.Division.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyParticipationDetails_Types_Division_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyParticipationDetails_Types_Division_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyParticipationDetails_Types_Division_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

