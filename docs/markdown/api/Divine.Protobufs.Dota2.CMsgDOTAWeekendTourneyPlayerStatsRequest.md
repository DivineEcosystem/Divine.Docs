# <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerStatsRequest"></a> Class CMsgDOTAWeekendTourneyPlayerStatsRequest

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAWeekendTourneyPlayerStatsRequest : IMessage<CMsgDOTAWeekendTourneyPlayerStatsRequest>, IEquatable<CMsgDOTAWeekendTourneyPlayerStatsRequest>, IDeepCloneable<CMsgDOTAWeekendTourneyPlayerStatsRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAWeekendTourneyPlayerStatsRequest](Divine.Protobufs.Dota2.CMsgDOTAWeekendTourneyPlayerStatsRequest.md)

#### Implements

IMessage<CMsgDOTAWeekendTourneyPlayerStatsRequest\>, 
[IEquatable<CMsgDOTAWeekendTourneyPlayerStatsRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAWeekendTourneyPlayerStatsRequest\>, 
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
[EnumerableExtensions.In<CMsgDOTAWeekendTourneyPlayerStatsRequest\>\(CMsgDOTAWeekendTourneyPlayerStatsRequest, params CMsgDOTAWeekendTourneyPlayerStatsRequest\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerStatsRequest__ctor"></a> CMsgDOTAWeekendTourneyPlayerStatsRequest\(\)

```csharp
public CMsgDOTAWeekendTourneyPlayerStatsRequest()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerStatsRequest__ctor_Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerStatsRequest_"></a> CMsgDOTAWeekendTourneyPlayerStatsRequest\(CMsgDOTAWeekendTourneyPlayerStatsRequest\)

```csharp
public CMsgDOTAWeekendTourneyPlayerStatsRequest(CMsgDOTAWeekendTourneyPlayerStatsRequest other)
```

#### Parameters

`other` [CMsgDOTAWeekendTourneyPlayerStatsRequest](Divine.Protobufs.Dota2.CMsgDOTAWeekendTourneyPlayerStatsRequest.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerStatsRequest_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerStatsRequest_SeasonTrophyIdFieldNumber"></a> SeasonTrophyIdFieldNumber

```csharp
public const int SeasonTrophyIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerStatsRequest_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerStatsRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerStatsRequest_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerStatsRequest_HasSeasonTrophyId"></a> HasSeasonTrophyId

```csharp
public bool HasSeasonTrophyId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerStatsRequest_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAWeekendTourneyPlayerStatsRequest> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAWeekendTourneyPlayerStatsRequest](Divine.Protobufs.Dota2.CMsgDOTAWeekendTourneyPlayerStatsRequest.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerStatsRequest_SeasonTrophyId"></a> SeasonTrophyId

```csharp
public uint SeasonTrophyId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerStatsRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerStatsRequest_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerStatsRequest_ClearSeasonTrophyId"></a> ClearSeasonTrophyId\(\)

```csharp
public void ClearSeasonTrophyId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerStatsRequest_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAWeekendTourneyPlayerStatsRequest Clone()
```

#### Returns

 [CMsgDOTAWeekendTourneyPlayerStatsRequest](Divine.Protobufs.Dota2.CMsgDOTAWeekendTourneyPlayerStatsRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerStatsRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerStatsRequest_Equals_Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerStatsRequest_"></a> Equals\(CMsgDOTAWeekendTourneyPlayerStatsRequest\)

```csharp
public bool Equals(CMsgDOTAWeekendTourneyPlayerStatsRequest other)
```

#### Parameters

`other` [CMsgDOTAWeekendTourneyPlayerStatsRequest](Divine.Protobufs.Dota2.CMsgDOTAWeekendTourneyPlayerStatsRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerStatsRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerStatsRequest_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerStatsRequest_"></a> MergeFrom\(CMsgDOTAWeekendTourneyPlayerStatsRequest\)

```csharp
public void MergeFrom(CMsgDOTAWeekendTourneyPlayerStatsRequest other)
```

#### Parameters

`other` [CMsgDOTAWeekendTourneyPlayerStatsRequest](Divine.Protobufs.Dota2.CMsgDOTAWeekendTourneyPlayerStatsRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerStatsRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerStatsRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAWeekendTourneyPlayerStatsRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

