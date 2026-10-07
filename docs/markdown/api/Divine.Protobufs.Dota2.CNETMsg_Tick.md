# <a id="Divine_Protobufs_Dota2_CNETMsg_Tick"></a> Class CNETMsg\_Tick

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CNETMsg_Tick : IMessage<CNETMsg_Tick>, IEquatable<CNETMsg_Tick>, IDeepCloneable<CNETMsg_Tick>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CNETMsg\_Tick](Divine.Protobufs.Dota2.CNETMsg\_Tick.md)

#### Implements

IMessage<CNETMsg\_Tick\>, 
[IEquatable<CNETMsg\_Tick\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CNETMsg\_Tick\>, 
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
[EnumerableExtensions.In<CNETMsg\_Tick\>\(CNETMsg\_Tick, params CNETMsg\_Tick\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CNETMsg_Tick__ctor"></a> CNETMsg\_Tick\(\)

```csharp
public CNETMsg_Tick()
```

### <a id="Divine_Protobufs_Dota2_CNETMsg_Tick__ctor_Divine_Protobufs_Dota2_CNETMsg_Tick_"></a> CNETMsg\_Tick\(CNETMsg\_Tick\)

```csharp
public CNETMsg_Tick(CNETMsg_Tick other)
```

#### Parameters

`other` [CNETMsg\_Tick](Divine.Protobufs.Dota2.CNETMsg\_Tick.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CNETMsg_Tick_ExpectedLongTickFieldNumber"></a> ExpectedLongTickFieldNumber

```csharp
public const int ExpectedLongTickFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_Tick_ExpectedLongTickReasonFieldNumber"></a> ExpectedLongTickReasonFieldNumber

```csharp
public const int ExpectedLongTickReasonFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_Tick_HltvReplayFlagsFieldNumber"></a> HltvReplayFlagsFieldNumber

```csharp
public const int HltvReplayFlagsFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_Tick_HostComputationtimeFieldNumber"></a> HostComputationtimeFieldNumber

```csharp
public const int HostComputationtimeFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_Tick_HostComputationtimeStdDeviationFieldNumber"></a> HostComputationtimeStdDeviationFieldNumber

```csharp
public const int HostComputationtimeStdDeviationFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_Tick_HostFrameDroppedPctX10FieldNumber"></a> HostFrameDroppedPctX10FieldNumber

```csharp
public const int HostFrameDroppedPctX10FieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_Tick_HostFrameIrregularArrivalPctX10FieldNumber"></a> HostFrameIrregularArrivalPctX10FieldNumber

```csharp
public const int HostFrameIrregularArrivalPctX10FieldNumber = 13
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_Tick_HostUnfilteredFrametimeFieldNumber"></a> HostUnfilteredFrametimeFieldNumber

```csharp
public const int HostUnfilteredFrametimeFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_Tick_LegacyHostLossFieldNumber"></a> LegacyHostLossFieldNumber

```csharp
public const int LegacyHostLossFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_Tick_TickFieldNumber"></a> TickFieldNumber

```csharp
public const int TickFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CNETMsg_Tick_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CNETMsg_Tick_ExpectedLongTick"></a> ExpectedLongTick

```csharp
public uint ExpectedLongTick { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_Tick_ExpectedLongTickReason"></a> ExpectedLongTickReason

```csharp
public string ExpectedLongTickReason { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CNETMsg_Tick_HasExpectedLongTick"></a> HasExpectedLongTick

```csharp
public bool HasExpectedLongTick { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_Tick_HasExpectedLongTickReason"></a> HasExpectedLongTickReason

```csharp
public bool HasExpectedLongTickReason { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_Tick_HasHltvReplayFlags"></a> HasHltvReplayFlags

```csharp
public bool HasHltvReplayFlags { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_Tick_HasHostComputationtime"></a> HasHostComputationtime

```csharp
public bool HasHostComputationtime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_Tick_HasHostComputationtimeStdDeviation"></a> HasHostComputationtimeStdDeviation

```csharp
public bool HasHostComputationtimeStdDeviation { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_Tick_HasHostFrameDroppedPctX10"></a> HasHostFrameDroppedPctX10

```csharp
public bool HasHostFrameDroppedPctX10 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_Tick_HasHostFrameIrregularArrivalPctX10"></a> HasHostFrameIrregularArrivalPctX10

```csharp
public bool HasHostFrameIrregularArrivalPctX10 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_Tick_HasHostUnfilteredFrametime"></a> HasHostUnfilteredFrametime

```csharp
public bool HasHostUnfilteredFrametime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_Tick_HasLegacyHostLoss"></a> HasLegacyHostLoss

```csharp
public bool HasLegacyHostLoss { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_Tick_HasTick"></a> HasTick

```csharp
public bool HasTick { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_Tick_HltvReplayFlags"></a> HltvReplayFlags

```csharp
public uint HltvReplayFlags { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_Tick_HostComputationtime"></a> HostComputationtime

```csharp
public uint HostComputationtime { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_Tick_HostComputationtimeStdDeviation"></a> HostComputationtimeStdDeviation

```csharp
public uint HostComputationtimeStdDeviation { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_Tick_HostFrameDroppedPctX10"></a> HostFrameDroppedPctX10

```csharp
public uint HostFrameDroppedPctX10 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_Tick_HostFrameIrregularArrivalPctX10"></a> HostFrameIrregularArrivalPctX10

```csharp
public uint HostFrameIrregularArrivalPctX10 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_Tick_HostUnfilteredFrametime"></a> HostUnfilteredFrametime

```csharp
public uint HostUnfilteredFrametime { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_Tick_LegacyHostLoss"></a> LegacyHostLoss

```csharp
public uint LegacyHostLoss { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_Tick_Parser"></a> Parser

```csharp
public static MessageParser<CNETMsg_Tick> Parser { get; }
```

#### Property Value

 MessageParser<[CNETMsg\_Tick](Divine.Protobufs.Dota2.CNETMsg\_Tick.md)\>

### <a id="Divine_Protobufs_Dota2_CNETMsg_Tick_Tick"></a> Tick

```csharp
public uint Tick { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CNETMsg_Tick_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_Tick_ClearExpectedLongTick"></a> ClearExpectedLongTick\(\)

```csharp
public void ClearExpectedLongTick()
```

### <a id="Divine_Protobufs_Dota2_CNETMsg_Tick_ClearExpectedLongTickReason"></a> ClearExpectedLongTickReason\(\)

```csharp
public void ClearExpectedLongTickReason()
```

### <a id="Divine_Protobufs_Dota2_CNETMsg_Tick_ClearHltvReplayFlags"></a> ClearHltvReplayFlags\(\)

```csharp
public void ClearHltvReplayFlags()
```

### <a id="Divine_Protobufs_Dota2_CNETMsg_Tick_ClearHostComputationtime"></a> ClearHostComputationtime\(\)

```csharp
public void ClearHostComputationtime()
```

### <a id="Divine_Protobufs_Dota2_CNETMsg_Tick_ClearHostComputationtimeStdDeviation"></a> ClearHostComputationtimeStdDeviation\(\)

```csharp
public void ClearHostComputationtimeStdDeviation()
```

### <a id="Divine_Protobufs_Dota2_CNETMsg_Tick_ClearHostFrameDroppedPctX10"></a> ClearHostFrameDroppedPctX10\(\)

```csharp
public void ClearHostFrameDroppedPctX10()
```

### <a id="Divine_Protobufs_Dota2_CNETMsg_Tick_ClearHostFrameIrregularArrivalPctX10"></a> ClearHostFrameIrregularArrivalPctX10\(\)

```csharp
public void ClearHostFrameIrregularArrivalPctX10()
```

### <a id="Divine_Protobufs_Dota2_CNETMsg_Tick_ClearHostUnfilteredFrametime"></a> ClearHostUnfilteredFrametime\(\)

```csharp
public void ClearHostUnfilteredFrametime()
```

### <a id="Divine_Protobufs_Dota2_CNETMsg_Tick_ClearLegacyHostLoss"></a> ClearLegacyHostLoss\(\)

```csharp
public void ClearLegacyHostLoss()
```

### <a id="Divine_Protobufs_Dota2_CNETMsg_Tick_ClearTick"></a> ClearTick\(\)

```csharp
public void ClearTick()
```

### <a id="Divine_Protobufs_Dota2_CNETMsg_Tick_Clone"></a> Clone\(\)

```csharp
public CNETMsg_Tick Clone()
```

#### Returns

 [CNETMsg\_Tick](Divine.Protobufs.Dota2.CNETMsg\_Tick.md)

### <a id="Divine_Protobufs_Dota2_CNETMsg_Tick_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_Tick_Equals_Divine_Protobufs_Dota2_CNETMsg_Tick_"></a> Equals\(CNETMsg\_Tick\)

```csharp
public bool Equals(CNETMsg_Tick other)
```

#### Parameters

`other` [CNETMsg\_Tick](Divine.Protobufs.Dota2.CNETMsg\_Tick.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_Tick_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_Tick_MergeFrom_Divine_Protobufs_Dota2_CNETMsg_Tick_"></a> MergeFrom\(CNETMsg\_Tick\)

```csharp
public void MergeFrom(CNETMsg_Tick other)
```

#### Parameters

`other` [CNETMsg\_Tick](Divine.Protobufs.Dota2.CNETMsg\_Tick.md)

### <a id="Divine_Protobufs_Dota2_CNETMsg_Tick_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CNETMsg_Tick_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CNETMsg_Tick_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

