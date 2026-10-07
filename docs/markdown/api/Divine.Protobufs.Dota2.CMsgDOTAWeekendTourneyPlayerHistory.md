# <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerHistory"></a> Class CMsgDOTAWeekendTourneyPlayerHistory

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAWeekendTourneyPlayerHistory : IMessage<CMsgDOTAWeekendTourneyPlayerHistory>, IEquatable<CMsgDOTAWeekendTourneyPlayerHistory>, IDeepCloneable<CMsgDOTAWeekendTourneyPlayerHistory>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAWeekendTourneyPlayerHistory](Divine.Protobufs.Dota2.CMsgDOTAWeekendTourneyPlayerHistory.md)

#### Implements

IMessage<CMsgDOTAWeekendTourneyPlayerHistory\>, 
[IEquatable<CMsgDOTAWeekendTourneyPlayerHistory\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAWeekendTourneyPlayerHistory\>, 
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
[EnumerableExtensions.In<CMsgDOTAWeekendTourneyPlayerHistory\>\(CMsgDOTAWeekendTourneyPlayerHistory, params CMsgDOTAWeekendTourneyPlayerHistory\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerHistory__ctor"></a> CMsgDOTAWeekendTourneyPlayerHistory\(\)

```csharp
public CMsgDOTAWeekendTourneyPlayerHistory()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerHistory__ctor_Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerHistory_"></a> CMsgDOTAWeekendTourneyPlayerHistory\(CMsgDOTAWeekendTourneyPlayerHistory\)

```csharp
public CMsgDOTAWeekendTourneyPlayerHistory(CMsgDOTAWeekendTourneyPlayerHistory other)
```

#### Parameters

`other` [CMsgDOTAWeekendTourneyPlayerHistory](Divine.Protobufs.Dota2.CMsgDOTAWeekendTourneyPlayerHistory.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerHistory_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerHistory_TournamentsFieldNumber"></a> TournamentsFieldNumber

```csharp
public const int TournamentsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerHistory_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerHistory_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerHistory_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerHistory_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAWeekendTourneyPlayerHistory> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAWeekendTourneyPlayerHistory](Divine.Protobufs.Dota2.CMsgDOTAWeekendTourneyPlayerHistory.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerHistory_Tournaments"></a> Tournaments

```csharp
public RepeatedField<CMsgDOTAWeekendTourneyPlayerHistory.Types.Tournament> Tournaments { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTAWeekendTourneyPlayerHistory](Divine.Protobufs.Dota2.CMsgDOTAWeekendTourneyPlayerHistory.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAWeekendTourneyPlayerHistory.Types.md).[Tournament](Divine.Protobufs.Dota2.CMsgDOTAWeekendTourneyPlayerHistory.Types.Tournament.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerHistory_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerHistory_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerHistory_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAWeekendTourneyPlayerHistory Clone()
```

#### Returns

 [CMsgDOTAWeekendTourneyPlayerHistory](Divine.Protobufs.Dota2.CMsgDOTAWeekendTourneyPlayerHistory.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerHistory_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerHistory_Equals_Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerHistory_"></a> Equals\(CMsgDOTAWeekendTourneyPlayerHistory\)

```csharp
public bool Equals(CMsgDOTAWeekendTourneyPlayerHistory other)
```

#### Parameters

`other` [CMsgDOTAWeekendTourneyPlayerHistory](Divine.Protobufs.Dota2.CMsgDOTAWeekendTourneyPlayerHistory.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerHistory_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerHistory_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerHistory_"></a> MergeFrom\(CMsgDOTAWeekendTourneyPlayerHistory\)

```csharp
public void MergeFrom(CMsgDOTAWeekendTourneyPlayerHistory other)
```

#### Parameters

`other` [CMsgDOTAWeekendTourneyPlayerHistory](Divine.Protobufs.Dota2.CMsgDOTAWeekendTourneyPlayerHistory.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerHistory_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerHistory_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerHistory_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

