# <a id="Divine_Protobufs_Dota2_CSVCMsg_HltvReplay"></a> Class CSVCMsg\_HltvReplay

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSVCMsg_HltvReplay : IMessage<CSVCMsg_HltvReplay>, IEquatable<CSVCMsg_HltvReplay>, IDeepCloneable<CSVCMsg_HltvReplay>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSVCMsg\_HltvReplay](Divine.Protobufs.Dota2.CSVCMsg\_HltvReplay.md)

#### Implements

IMessage<CSVCMsg\_HltvReplay\>, 
[IEquatable<CSVCMsg\_HltvReplay\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSVCMsg\_HltvReplay\>, 
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
[EnumerableExtensions.In<CSVCMsg\_HltvReplay\>\(CSVCMsg\_HltvReplay, params CSVCMsg\_HltvReplay\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HltvReplay__ctor"></a> CSVCMsg\_HltvReplay\(\)

```csharp
public CSVCMsg_HltvReplay()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HltvReplay__ctor_Divine_Protobufs_Dota2_CSVCMsg_HltvReplay_"></a> CSVCMsg\_HltvReplay\(CSVCMsg\_HltvReplay\)

```csharp
public CSVCMsg_HltvReplay(CSVCMsg_HltvReplay other)
```

#### Parameters

`other` [CSVCMsg\_HltvReplay](Divine.Protobufs.Dota2.CSVCMsg\_HltvReplay.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HltvReplay_DelayFieldNumber"></a> DelayFieldNumber

```csharp
public const int DelayFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HltvReplay_PrimaryTargetFieldNumber"></a> PrimaryTargetFieldNumber

```csharp
public const int PrimaryTargetFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HltvReplay_ReasonFieldNumber"></a> ReasonFieldNumber

```csharp
public const int ReasonFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HltvReplay_ReplaySlowdownBeginFieldNumber"></a> ReplaySlowdownBeginFieldNumber

```csharp
public const int ReplaySlowdownBeginFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HltvReplay_ReplaySlowdownEndFieldNumber"></a> ReplaySlowdownEndFieldNumber

```csharp
public const int ReplaySlowdownEndFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HltvReplay_ReplaySlowdownRateFieldNumber"></a> ReplaySlowdownRateFieldNumber

```csharp
public const int ReplaySlowdownRateFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HltvReplay_ReplayStartAtFieldNumber"></a> ReplayStartAtFieldNumber

```csharp
public const int ReplayStartAtFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HltvReplay_ReplayStopAtFieldNumber"></a> ReplayStopAtFieldNumber

```csharp
public const int ReplayStopAtFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HltvReplay_Delay"></a> Delay

```csharp
public int Delay { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HltvReplay_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HltvReplay_HasDelay"></a> HasDelay

```csharp
public bool HasDelay { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HltvReplay_HasPrimaryTarget"></a> HasPrimaryTarget

```csharp
public bool HasPrimaryTarget { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HltvReplay_HasReason"></a> HasReason

```csharp
public bool HasReason { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HltvReplay_HasReplaySlowdownBegin"></a> HasReplaySlowdownBegin

```csharp
public bool HasReplaySlowdownBegin { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HltvReplay_HasReplaySlowdownEnd"></a> HasReplaySlowdownEnd

```csharp
public bool HasReplaySlowdownEnd { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HltvReplay_HasReplaySlowdownRate"></a> HasReplaySlowdownRate

```csharp
public bool HasReplaySlowdownRate { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HltvReplay_HasReplayStartAt"></a> HasReplayStartAt

```csharp
public bool HasReplayStartAt { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HltvReplay_HasReplayStopAt"></a> HasReplayStopAt

```csharp
public bool HasReplayStopAt { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HltvReplay_Parser"></a> Parser

```csharp
public static MessageParser<CSVCMsg_HltvReplay> Parser { get; }
```

#### Property Value

 MessageParser<[CSVCMsg\_HltvReplay](Divine.Protobufs.Dota2.CSVCMsg\_HltvReplay.md)\>

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HltvReplay_PrimaryTarget"></a> PrimaryTarget

```csharp
public int PrimaryTarget { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HltvReplay_Reason"></a> Reason

```csharp
public int Reason { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HltvReplay_ReplaySlowdownBegin"></a> ReplaySlowdownBegin

```csharp
public int ReplaySlowdownBegin { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HltvReplay_ReplaySlowdownEnd"></a> ReplaySlowdownEnd

```csharp
public int ReplaySlowdownEnd { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HltvReplay_ReplaySlowdownRate"></a> ReplaySlowdownRate

```csharp
public float ReplaySlowdownRate { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HltvReplay_ReplayStartAt"></a> ReplayStartAt

```csharp
public int ReplayStartAt { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HltvReplay_ReplayStopAt"></a> ReplayStopAt

```csharp
public int ReplayStopAt { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HltvReplay_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HltvReplay_ClearDelay"></a> ClearDelay\(\)

```csharp
public void ClearDelay()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HltvReplay_ClearPrimaryTarget"></a> ClearPrimaryTarget\(\)

```csharp
public void ClearPrimaryTarget()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HltvReplay_ClearReason"></a> ClearReason\(\)

```csharp
public void ClearReason()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HltvReplay_ClearReplaySlowdownBegin"></a> ClearReplaySlowdownBegin\(\)

```csharp
public void ClearReplaySlowdownBegin()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HltvReplay_ClearReplaySlowdownEnd"></a> ClearReplaySlowdownEnd\(\)

```csharp
public void ClearReplaySlowdownEnd()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HltvReplay_ClearReplaySlowdownRate"></a> ClearReplaySlowdownRate\(\)

```csharp
public void ClearReplaySlowdownRate()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HltvReplay_ClearReplayStartAt"></a> ClearReplayStartAt\(\)

```csharp
public void ClearReplayStartAt()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HltvReplay_ClearReplayStopAt"></a> ClearReplayStopAt\(\)

```csharp
public void ClearReplayStopAt()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HltvReplay_Clone"></a> Clone\(\)

```csharp
public CSVCMsg_HltvReplay Clone()
```

#### Returns

 [CSVCMsg\_HltvReplay](Divine.Protobufs.Dota2.CSVCMsg\_HltvReplay.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HltvReplay_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HltvReplay_Equals_Divine_Protobufs_Dota2_CSVCMsg_HltvReplay_"></a> Equals\(CSVCMsg\_HltvReplay\)

```csharp
public bool Equals(CSVCMsg_HltvReplay other)
```

#### Parameters

`other` [CSVCMsg\_HltvReplay](Divine.Protobufs.Dota2.CSVCMsg\_HltvReplay.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HltvReplay_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HltvReplay_MergeFrom_Divine_Protobufs_Dota2_CSVCMsg_HltvReplay_"></a> MergeFrom\(CSVCMsg\_HltvReplay\)

```csharp
public void MergeFrom(CSVCMsg_HltvReplay other)
```

#### Parameters

`other` [CSVCMsg\_HltvReplay](Divine.Protobufs.Dota2.CSVCMsg\_HltvReplay.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HltvReplay_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HltvReplay_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HltvReplay_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

