# <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyParticipationDetails"></a> Class CMsgDOTAWeekendTourneyParticipationDetails

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAWeekendTourneyParticipationDetails : IMessage<CMsgDOTAWeekendTourneyParticipationDetails>, IEquatable<CMsgDOTAWeekendTourneyParticipationDetails>, IDeepCloneable<CMsgDOTAWeekendTourneyParticipationDetails>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAWeekendTourneyParticipationDetails](Divine.Protobufs.Dota2.CMsgDOTAWeekendTourneyParticipationDetails.md)

#### Implements

IMessage<CMsgDOTAWeekendTourneyParticipationDetails\>, 
[IEquatable<CMsgDOTAWeekendTourneyParticipationDetails\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAWeekendTourneyParticipationDetails\>, 
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
[EnumerableExtensions.In<CMsgDOTAWeekendTourneyParticipationDetails\>\(CMsgDOTAWeekendTourneyParticipationDetails, params CMsgDOTAWeekendTourneyParticipationDetails\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyParticipationDetails__ctor"></a> CMsgDOTAWeekendTourneyParticipationDetails\(\)

```csharp
public CMsgDOTAWeekendTourneyParticipationDetails()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyParticipationDetails__ctor_Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyParticipationDetails_"></a> CMsgDOTAWeekendTourneyParticipationDetails\(CMsgDOTAWeekendTourneyParticipationDetails\)

```csharp
public CMsgDOTAWeekendTourneyParticipationDetails(CMsgDOTAWeekendTourneyParticipationDetails other)
```

#### Parameters

`other` [CMsgDOTAWeekendTourneyParticipationDetails](Divine.Protobufs.Dota2.CMsgDOTAWeekendTourneyParticipationDetails.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyParticipationDetails_DivisionsFieldNumber"></a> DivisionsFieldNumber

```csharp
public const int DivisionsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyParticipationDetails_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyParticipationDetails_Divisions"></a> Divisions

```csharp
public RepeatedField<CMsgDOTAWeekendTourneyParticipationDetails.Types.Division> Divisions { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTAWeekendTourneyParticipationDetails](Divine.Protobufs.Dota2.CMsgDOTAWeekendTourneyParticipationDetails.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAWeekendTourneyParticipationDetails.Types.md).[Division](Divine.Protobufs.Dota2.CMsgDOTAWeekendTourneyParticipationDetails.Types.Division.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyParticipationDetails_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAWeekendTourneyParticipationDetails> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAWeekendTourneyParticipationDetails](Divine.Protobufs.Dota2.CMsgDOTAWeekendTourneyParticipationDetails.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyParticipationDetails_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyParticipationDetails_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAWeekendTourneyParticipationDetails Clone()
```

#### Returns

 [CMsgDOTAWeekendTourneyParticipationDetails](Divine.Protobufs.Dota2.CMsgDOTAWeekendTourneyParticipationDetails.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyParticipationDetails_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyParticipationDetails_Equals_Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyParticipationDetails_"></a> Equals\(CMsgDOTAWeekendTourneyParticipationDetails\)

```csharp
public bool Equals(CMsgDOTAWeekendTourneyParticipationDetails other)
```

#### Parameters

`other` [CMsgDOTAWeekendTourneyParticipationDetails](Divine.Protobufs.Dota2.CMsgDOTAWeekendTourneyParticipationDetails.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyParticipationDetails_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyParticipationDetails_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyParticipationDetails_"></a> MergeFrom\(CMsgDOTAWeekendTourneyParticipationDetails\)

```csharp
public void MergeFrom(CMsgDOTAWeekendTourneyParticipationDetails other)
```

#### Parameters

`other` [CMsgDOTAWeekendTourneyParticipationDetails](Divine.Protobufs.Dota2.CMsgDOTAWeekendTourneyParticipationDetails.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyParticipationDetails_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyParticipationDetails_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyParticipationDetails_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

