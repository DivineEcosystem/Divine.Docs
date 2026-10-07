# <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneySchedule"></a> Class CMsgWeekendTourneySchedule

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgWeekendTourneySchedule : IMessage<CMsgWeekendTourneySchedule>, IEquatable<CMsgWeekendTourneySchedule>, IDeepCloneable<CMsgWeekendTourneySchedule>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgWeekendTourneySchedule](Divine.Protobufs.Dota2.CMsgWeekendTourneySchedule.md)

#### Implements

IMessage<CMsgWeekendTourneySchedule\>, 
[IEquatable<CMsgWeekendTourneySchedule\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgWeekendTourneySchedule\>, 
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
[EnumerableExtensions.In<CMsgWeekendTourneySchedule\>\(CMsgWeekendTourneySchedule, params CMsgWeekendTourneySchedule\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneySchedule__ctor"></a> CMsgWeekendTourneySchedule\(\)

```csharp
public CMsgWeekendTourneySchedule()
```

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneySchedule__ctor_Divine_Protobufs_Dota2_CMsgWeekendTourneySchedule_"></a> CMsgWeekendTourneySchedule\(CMsgWeekendTourneySchedule\)

```csharp
public CMsgWeekendTourneySchedule(CMsgWeekendTourneySchedule other)
```

#### Parameters

`other` [CMsgWeekendTourneySchedule](Divine.Protobufs.Dota2.CMsgWeekendTourneySchedule.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneySchedule_DivisionsFieldNumber"></a> DivisionsFieldNumber

```csharp
public const int DivisionsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneySchedule_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneySchedule_Divisions"></a> Divisions

```csharp
public RepeatedField<CMsgWeekendTourneySchedule.Types.Division> Divisions { get; }
```

#### Property Value

 RepeatedField<[CMsgWeekendTourneySchedule](Divine.Protobufs.Dota2.CMsgWeekendTourneySchedule.md).[Types](Divine.Protobufs.Dota2.CMsgWeekendTourneySchedule.Types.md).[Division](Divine.Protobufs.Dota2.CMsgWeekendTourneySchedule.Types.Division.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneySchedule_Parser"></a> Parser

```csharp
public static MessageParser<CMsgWeekendTourneySchedule> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgWeekendTourneySchedule](Divine.Protobufs.Dota2.CMsgWeekendTourneySchedule.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneySchedule_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneySchedule_Clone"></a> Clone\(\)

```csharp
public CMsgWeekendTourneySchedule Clone()
```

#### Returns

 [CMsgWeekendTourneySchedule](Divine.Protobufs.Dota2.CMsgWeekendTourneySchedule.md)

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneySchedule_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneySchedule_Equals_Divine_Protobufs_Dota2_CMsgWeekendTourneySchedule_"></a> Equals\(CMsgWeekendTourneySchedule\)

```csharp
public bool Equals(CMsgWeekendTourneySchedule other)
```

#### Parameters

`other` [CMsgWeekendTourneySchedule](Divine.Protobufs.Dota2.CMsgWeekendTourneySchedule.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneySchedule_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneySchedule_MergeFrom_Divine_Protobufs_Dota2_CMsgWeekendTourneySchedule_"></a> MergeFrom\(CMsgWeekendTourneySchedule\)

```csharp
public void MergeFrom(CMsgWeekendTourneySchedule other)
```

#### Parameters

`other` [CMsgWeekendTourneySchedule](Divine.Protobufs.Dota2.CMsgWeekendTourneySchedule.md)

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneySchedule_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneySchedule_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneySchedule_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

