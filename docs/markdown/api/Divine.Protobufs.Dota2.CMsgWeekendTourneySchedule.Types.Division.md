# <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneySchedule_Types_Division"></a> Class CMsgWeekendTourneySchedule.Types.Division

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgWeekendTourneySchedule.Types.Division : IMessage<CMsgWeekendTourneySchedule.Types.Division>, IEquatable<CMsgWeekendTourneySchedule.Types.Division>, IDeepCloneable<CMsgWeekendTourneySchedule.Types.Division>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgWeekendTourneySchedule.Types.Division](Divine.Protobufs.Dota2.CMsgWeekendTourneySchedule.Types.Division.md)

#### Implements

IMessage<CMsgWeekendTourneySchedule.Types.Division\>, 
[IEquatable<CMsgWeekendTourneySchedule.Types.Division\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgWeekendTourneySchedule.Types.Division\>, 
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
[EnumerableExtensions.In<CMsgWeekendTourneySchedule.Types.Division\>\(CMsgWeekendTourneySchedule.Types.Division, params CMsgWeekendTourneySchedule.Types.Division\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneySchedule_Types_Division__ctor"></a> Division\(\)

```csharp
public Division()
```

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneySchedule_Types_Division__ctor_Divine_Protobufs_Dota2_CMsgWeekendTourneySchedule_Types_Division_"></a> Division\(Division\)

```csharp
public Division(CMsgWeekendTourneySchedule.Types.Division other)
```

#### Parameters

`other` [CMsgWeekendTourneySchedule](Divine.Protobufs.Dota2.CMsgWeekendTourneySchedule.md).[Types](Divine.Protobufs.Dota2.CMsgWeekendTourneySchedule.Types.md).[Division](Divine.Protobufs.Dota2.CMsgWeekendTourneySchedule.Types.Division.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneySchedule_Types_Division_DivisionCodeFieldNumber"></a> DivisionCodeFieldNumber

```csharp
public const int DivisionCodeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneySchedule_Types_Division_FreeWeekendFieldNumber"></a> FreeWeekendFieldNumber

```csharp
public const int FreeWeekendFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneySchedule_Types_Division_TimeWindowCloseFieldNumber"></a> TimeWindowCloseFieldNumber

```csharp
public const int TimeWindowCloseFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneySchedule_Types_Division_TimeWindowOpenFieldNumber"></a> TimeWindowOpenFieldNumber

```csharp
public const int TimeWindowOpenFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneySchedule_Types_Division_TimeWindowOpenNextFieldNumber"></a> TimeWindowOpenNextFieldNumber

```csharp
public const int TimeWindowOpenNextFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneySchedule_Types_Division_TrophyIdFieldNumber"></a> TrophyIdFieldNumber

```csharp
public const int TrophyIdFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneySchedule_Types_Division_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneySchedule_Types_Division_DivisionCode"></a> DivisionCode

```csharp
public uint DivisionCode { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneySchedule_Types_Division_FreeWeekend"></a> FreeWeekend

```csharp
public bool FreeWeekend { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneySchedule_Types_Division_HasDivisionCode"></a> HasDivisionCode

```csharp
public bool HasDivisionCode { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneySchedule_Types_Division_HasFreeWeekend"></a> HasFreeWeekend

```csharp
public bool HasFreeWeekend { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneySchedule_Types_Division_HasTimeWindowClose"></a> HasTimeWindowClose

```csharp
public bool HasTimeWindowClose { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneySchedule_Types_Division_HasTimeWindowOpen"></a> HasTimeWindowOpen

```csharp
public bool HasTimeWindowOpen { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneySchedule_Types_Division_HasTimeWindowOpenNext"></a> HasTimeWindowOpenNext

```csharp
public bool HasTimeWindowOpenNext { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneySchedule_Types_Division_HasTrophyId"></a> HasTrophyId

```csharp
public bool HasTrophyId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneySchedule_Types_Division_Parser"></a> Parser

```csharp
public static MessageParser<CMsgWeekendTourneySchedule.Types.Division> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgWeekendTourneySchedule](Divine.Protobufs.Dota2.CMsgWeekendTourneySchedule.md).[Types](Divine.Protobufs.Dota2.CMsgWeekendTourneySchedule.Types.md).[Division](Divine.Protobufs.Dota2.CMsgWeekendTourneySchedule.Types.Division.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneySchedule_Types_Division_TimeWindowClose"></a> TimeWindowClose

```csharp
public uint TimeWindowClose { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneySchedule_Types_Division_TimeWindowOpen"></a> TimeWindowOpen

```csharp
public uint TimeWindowOpen { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneySchedule_Types_Division_TimeWindowOpenNext"></a> TimeWindowOpenNext

```csharp
public uint TimeWindowOpenNext { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneySchedule_Types_Division_TrophyId"></a> TrophyId

```csharp
public uint TrophyId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneySchedule_Types_Division_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneySchedule_Types_Division_ClearDivisionCode"></a> ClearDivisionCode\(\)

```csharp
public void ClearDivisionCode()
```

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneySchedule_Types_Division_ClearFreeWeekend"></a> ClearFreeWeekend\(\)

```csharp
public void ClearFreeWeekend()
```

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneySchedule_Types_Division_ClearTimeWindowClose"></a> ClearTimeWindowClose\(\)

```csharp
public void ClearTimeWindowClose()
```

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneySchedule_Types_Division_ClearTimeWindowOpen"></a> ClearTimeWindowOpen\(\)

```csharp
public void ClearTimeWindowOpen()
```

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneySchedule_Types_Division_ClearTimeWindowOpenNext"></a> ClearTimeWindowOpenNext\(\)

```csharp
public void ClearTimeWindowOpenNext()
```

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneySchedule_Types_Division_ClearTrophyId"></a> ClearTrophyId\(\)

```csharp
public void ClearTrophyId()
```

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneySchedule_Types_Division_Clone"></a> Clone\(\)

```csharp
public CMsgWeekendTourneySchedule.Types.Division Clone()
```

#### Returns

 [CMsgWeekendTourneySchedule](Divine.Protobufs.Dota2.CMsgWeekendTourneySchedule.md).[Types](Divine.Protobufs.Dota2.CMsgWeekendTourneySchedule.Types.md).[Division](Divine.Protobufs.Dota2.CMsgWeekendTourneySchedule.Types.Division.md)

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneySchedule_Types_Division_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneySchedule_Types_Division_Equals_Divine_Protobufs_Dota2_CMsgWeekendTourneySchedule_Types_Division_"></a> Equals\(Division\)

```csharp
public bool Equals(CMsgWeekendTourneySchedule.Types.Division other)
```

#### Parameters

`other` [CMsgWeekendTourneySchedule](Divine.Protobufs.Dota2.CMsgWeekendTourneySchedule.md).[Types](Divine.Protobufs.Dota2.CMsgWeekendTourneySchedule.Types.md).[Division](Divine.Protobufs.Dota2.CMsgWeekendTourneySchedule.Types.Division.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneySchedule_Types_Division_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneySchedule_Types_Division_MergeFrom_Divine_Protobufs_Dota2_CMsgWeekendTourneySchedule_Types_Division_"></a> MergeFrom\(Division\)

```csharp
public void MergeFrom(CMsgWeekendTourneySchedule.Types.Division other)
```

#### Parameters

`other` [CMsgWeekendTourneySchedule](Divine.Protobufs.Dota2.CMsgWeekendTourneySchedule.md).[Types](Divine.Protobufs.Dota2.CMsgWeekendTourneySchedule.Types.md).[Division](Divine.Protobufs.Dota2.CMsgWeekendTourneySchedule.Types.Division.md)

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneySchedule_Types_Division_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneySchedule_Types_Division_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneySchedule_Types_Division_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

