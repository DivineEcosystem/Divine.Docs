# <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_Types_League"></a> Class CMsgDPCEvent.Types.League

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDPCEvent.Types.League : IMessage<CMsgDPCEvent.Types.League>, IEquatable<CMsgDPCEvent.Types.League>, IDeepCloneable<CMsgDPCEvent.Types.League>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDPCEvent.Types.League](Divine.Protobufs.Dota2.CMsgDPCEvent.Types.League.md)

#### Implements

IMessage<CMsgDPCEvent.Types.League\>, 
[IEquatable<CMsgDPCEvent.Types.League\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDPCEvent.Types.League\>, 
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
[EnumerableExtensions.In<CMsgDPCEvent.Types.League\>\(CMsgDPCEvent.Types.League, params CMsgDPCEvent.Types.League\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_Types_League__ctor"></a> League\(\)

```csharp
public League()
```

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_Types_League__ctor_Divine_Protobufs_Dota2_CMsgDPCEvent_Types_League_"></a> League\(League\)

```csharp
public League(CMsgDPCEvent.Types.League other)
```

#### Parameters

`other` [CMsgDPCEvent](Divine.Protobufs.Dota2.CMsgDPCEvent.md).[Types](Divine.Protobufs.Dota2.CMsgDPCEvent.Types.md).[League](Divine.Protobufs.Dota2.CMsgDPCEvent.Types.League.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_Types_League_DivisionFieldNumber"></a> DivisionFieldNumber

```csharp
public const int DivisionFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_Types_League_LeagueIdFieldNumber"></a> LeagueIdFieldNumber

```csharp
public const int LeagueIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_Types_League_PhasesFieldNumber"></a> PhasesFieldNumber

```csharp
public const int PhasesFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_Types_League_RegionFieldNumber"></a> RegionFieldNumber

```csharp
public const int RegionFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_Types_League_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_Types_League_Division"></a> Division

```csharp
public ELeagueDivision Division { get; set; }
```

#### Property Value

 [ELeagueDivision](Divine.Protobufs.Dota2.ELeagueDivision.md)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_Types_League_HasDivision"></a> HasDivision

```csharp
public bool HasDivision { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_Types_League_HasLeagueId"></a> HasLeagueId

```csharp
public bool HasLeagueId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_Types_League_HasRegion"></a> HasRegion

```csharp
public bool HasRegion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_Types_League_LeagueId"></a> LeagueId

```csharp
public uint LeagueId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_Types_League_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDPCEvent.Types.League> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDPCEvent](Divine.Protobufs.Dota2.CMsgDPCEvent.md).[Types](Divine.Protobufs.Dota2.CMsgDPCEvent.Types.md).[League](Divine.Protobufs.Dota2.CMsgDPCEvent.Types.League.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_Types_League_Phases"></a> Phases

```csharp
public RepeatedField<CMsgDPCEvent.Types.PhaseInfo> Phases { get; }
```

#### Property Value

 RepeatedField<[CMsgDPCEvent](Divine.Protobufs.Dota2.CMsgDPCEvent.md).[Types](Divine.Protobufs.Dota2.CMsgDPCEvent.Types.md).[PhaseInfo](Divine.Protobufs.Dota2.CMsgDPCEvent.Types.PhaseInfo.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_Types_League_Region"></a> Region

```csharp
public ELeagueRegion Region { get; set; }
```

#### Property Value

 [ELeagueRegion](Divine.Protobufs.Dota2.ELeagueRegion.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_Types_League_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_Types_League_ClearDivision"></a> ClearDivision\(\)

```csharp
public void ClearDivision()
```

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_Types_League_ClearLeagueId"></a> ClearLeagueId\(\)

```csharp
public void ClearLeagueId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_Types_League_ClearRegion"></a> ClearRegion\(\)

```csharp
public void ClearRegion()
```

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_Types_League_Clone"></a> Clone\(\)

```csharp
public CMsgDPCEvent.Types.League Clone()
```

#### Returns

 [CMsgDPCEvent](Divine.Protobufs.Dota2.CMsgDPCEvent.md).[Types](Divine.Protobufs.Dota2.CMsgDPCEvent.Types.md).[League](Divine.Protobufs.Dota2.CMsgDPCEvent.Types.League.md)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_Types_League_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_Types_League_Equals_Divine_Protobufs_Dota2_CMsgDPCEvent_Types_League_"></a> Equals\(League\)

```csharp
public bool Equals(CMsgDPCEvent.Types.League other)
```

#### Parameters

`other` [CMsgDPCEvent](Divine.Protobufs.Dota2.CMsgDPCEvent.md).[Types](Divine.Protobufs.Dota2.CMsgDPCEvent.Types.md).[League](Divine.Protobufs.Dota2.CMsgDPCEvent.Types.League.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_Types_League_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_Types_League_MergeFrom_Divine_Protobufs_Dota2_CMsgDPCEvent_Types_League_"></a> MergeFrom\(League\)

```csharp
public void MergeFrom(CMsgDPCEvent.Types.League other)
```

#### Parameters

`other` [CMsgDPCEvent](Divine.Protobufs.Dota2.CMsgDPCEvent.md).[Types](Divine.Protobufs.Dota2.CMsgDPCEvent.Types.md).[League](Divine.Protobufs.Dota2.CMsgDPCEvent.Types.League.md)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_Types_League_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_Types_League_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEvent_Types_League_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

