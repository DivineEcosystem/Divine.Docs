# <a id="Divine_Protobufs_Dota2_CMsgClientToGCStopWatchingOverwatch"></a> Class CMsgClientToGCStopWatchingOverwatch

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCStopWatchingOverwatch : IMessage<CMsgClientToGCStopWatchingOverwatch>, IEquatable<CMsgClientToGCStopWatchingOverwatch>, IDeepCloneable<CMsgClientToGCStopWatchingOverwatch>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCStopWatchingOverwatch](Divine.Protobufs.Dota2.CMsgClientToGCStopWatchingOverwatch.md)

#### Implements

IMessage<CMsgClientToGCStopWatchingOverwatch\>, 
[IEquatable<CMsgClientToGCStopWatchingOverwatch\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCStopWatchingOverwatch\>, 
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
[EnumerableExtensions.In<CMsgClientToGCStopWatchingOverwatch\>\(CMsgClientToGCStopWatchingOverwatch, params CMsgClientToGCStopWatchingOverwatch\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCStopWatchingOverwatch__ctor"></a> CMsgClientToGCStopWatchingOverwatch\(\)

```csharp
public CMsgClientToGCStopWatchingOverwatch()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCStopWatchingOverwatch__ctor_Divine_Protobufs_Dota2_CMsgClientToGCStopWatchingOverwatch_"></a> CMsgClientToGCStopWatchingOverwatch\(CMsgClientToGCStopWatchingOverwatch\)

```csharp
public CMsgClientToGCStopWatchingOverwatch(CMsgClientToGCStopWatchingOverwatch other)
```

#### Parameters

`other` [CMsgClientToGCStopWatchingOverwatch](Divine.Protobufs.Dota2.CMsgClientToGCStopWatchingOverwatch.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCStopWatchingOverwatch_OverwatchReplayIdFieldNumber"></a> OverwatchReplayIdFieldNumber

```csharp
public const int OverwatchReplayIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCStopWatchingOverwatch_TargetPlayerSlotFieldNumber"></a> TargetPlayerSlotFieldNumber

```csharp
public const int TargetPlayerSlotFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCStopWatchingOverwatch_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCStopWatchingOverwatch_HasOverwatchReplayId"></a> HasOverwatchReplayId

```csharp
public bool HasOverwatchReplayId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCStopWatchingOverwatch_HasTargetPlayerSlot"></a> HasTargetPlayerSlot

```csharp
public bool HasTargetPlayerSlot { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCStopWatchingOverwatch_OverwatchReplayId"></a> OverwatchReplayId

```csharp
public ulong OverwatchReplayId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCStopWatchingOverwatch_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCStopWatchingOverwatch> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCStopWatchingOverwatch](Divine.Protobufs.Dota2.CMsgClientToGCStopWatchingOverwatch.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCStopWatchingOverwatch_TargetPlayerSlot"></a> TargetPlayerSlot

```csharp
public uint TargetPlayerSlot { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCStopWatchingOverwatch_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCStopWatchingOverwatch_ClearOverwatchReplayId"></a> ClearOverwatchReplayId\(\)

```csharp
public void ClearOverwatchReplayId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCStopWatchingOverwatch_ClearTargetPlayerSlot"></a> ClearTargetPlayerSlot\(\)

```csharp
public void ClearTargetPlayerSlot()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCStopWatchingOverwatch_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCStopWatchingOverwatch Clone()
```

#### Returns

 [CMsgClientToGCStopWatchingOverwatch](Divine.Protobufs.Dota2.CMsgClientToGCStopWatchingOverwatch.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCStopWatchingOverwatch_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCStopWatchingOverwatch_Equals_Divine_Protobufs_Dota2_CMsgClientToGCStopWatchingOverwatch_"></a> Equals\(CMsgClientToGCStopWatchingOverwatch\)

```csharp
public bool Equals(CMsgClientToGCStopWatchingOverwatch other)
```

#### Parameters

`other` [CMsgClientToGCStopWatchingOverwatch](Divine.Protobufs.Dota2.CMsgClientToGCStopWatchingOverwatch.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCStopWatchingOverwatch_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCStopWatchingOverwatch_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCStopWatchingOverwatch_"></a> MergeFrom\(CMsgClientToGCStopWatchingOverwatch\)

```csharp
public void MergeFrom(CMsgClientToGCStopWatchingOverwatch other)
```

#### Parameters

`other` [CMsgClientToGCStopWatchingOverwatch](Divine.Protobufs.Dota2.CMsgClientToGCStopWatchingOverwatch.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCStopWatchingOverwatch_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCStopWatchingOverwatch_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCStopWatchingOverwatch_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

