# <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Period"></a> Class CMsgDOTAFantasyCardLineup.Types.Period

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAFantasyCardLineup.Types.Period : IMessage<CMsgDOTAFantasyCardLineup.Types.Period>, IEquatable<CMsgDOTAFantasyCardLineup.Types.Period>, IDeepCloneable<CMsgDOTAFantasyCardLineup.Types.Period>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAFantasyCardLineup.Types.Period](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardLineup.Types.Period.md)

#### Implements

IMessage<CMsgDOTAFantasyCardLineup.Types.Period\>, 
[IEquatable<CMsgDOTAFantasyCardLineup.Types.Period\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAFantasyCardLineup.Types.Period\>, 
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
[EnumerableExtensions.In<CMsgDOTAFantasyCardLineup.Types.Period\>\(CMsgDOTAFantasyCardLineup.Types.Period, params CMsgDOTAFantasyCardLineup.Types.Period\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Period__ctor"></a> Period\(\)

```csharp
public Period()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Period__ctor_Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Period_"></a> Period\(Period\)

```csharp
public Period(CMsgDOTAFantasyCardLineup.Types.Period other)
```

#### Parameters

`other` [CMsgDOTAFantasyCardLineup](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardLineup.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardLineup.Types.md).[Period](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardLineup.Types.Period.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Period_FantasyPeriodFieldNumber"></a> FantasyPeriodFieldNumber

```csharp
public const int FantasyPeriodFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Period_LeaguesFieldNumber"></a> LeaguesFieldNumber

```csharp
public const int LeaguesFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Period_TimestampEndFieldNumber"></a> TimestampEndFieldNumber

```csharp
public const int TimestampEndFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Period_TimestampStartFieldNumber"></a> TimestampStartFieldNumber

```csharp
public const int TimestampStartFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Period_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Period_FantasyPeriod"></a> FantasyPeriod

```csharp
public uint FantasyPeriod { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Period_HasFantasyPeriod"></a> HasFantasyPeriod

```csharp
public bool HasFantasyPeriod { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Period_HasTimestampEnd"></a> HasTimestampEnd

```csharp
public bool HasTimestampEnd { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Period_HasTimestampStart"></a> HasTimestampStart

```csharp
public bool HasTimestampStart { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Period_Leagues"></a> Leagues

```csharp
public RepeatedField<CMsgDOTAFantasyCardLineup.Types.League> Leagues { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTAFantasyCardLineup](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardLineup.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardLineup.Types.md).[League](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardLineup.Types.League.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Period_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAFantasyCardLineup.Types.Period> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAFantasyCardLineup](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardLineup.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardLineup.Types.md).[Period](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardLineup.Types.Period.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Period_TimestampEnd"></a> TimestampEnd

```csharp
public uint TimestampEnd { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Period_TimestampStart"></a> TimestampStart

```csharp
public uint TimestampStart { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Period_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Period_ClearFantasyPeriod"></a> ClearFantasyPeriod\(\)

```csharp
public void ClearFantasyPeriod()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Period_ClearTimestampEnd"></a> ClearTimestampEnd\(\)

```csharp
public void ClearTimestampEnd()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Period_ClearTimestampStart"></a> ClearTimestampStart\(\)

```csharp
public void ClearTimestampStart()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Period_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAFantasyCardLineup.Types.Period Clone()
```

#### Returns

 [CMsgDOTAFantasyCardLineup](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardLineup.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardLineup.Types.md).[Period](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardLineup.Types.Period.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Period_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Period_Equals_Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Period_"></a> Equals\(Period\)

```csharp
public bool Equals(CMsgDOTAFantasyCardLineup.Types.Period other)
```

#### Parameters

`other` [CMsgDOTAFantasyCardLineup](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardLineup.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardLineup.Types.md).[Period](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardLineup.Types.Period.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Period_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Period_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Period_"></a> MergeFrom\(Period\)

```csharp
public void MergeFrom(CMsgDOTAFantasyCardLineup.Types.Period other)
```

#### Parameters

`other` [CMsgDOTAFantasyCardLineup](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardLineup.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardLineup.Types.md).[Period](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardLineup.Types.Period.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Period_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Period_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Types_Period_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

