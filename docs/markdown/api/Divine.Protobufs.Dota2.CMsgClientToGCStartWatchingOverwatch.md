# <a id="Divine_Protobufs_Dota2_CMsgClientToGCStartWatchingOverwatch"></a> Class CMsgClientToGCStartWatchingOverwatch

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCStartWatchingOverwatch : IMessage<CMsgClientToGCStartWatchingOverwatch>, IEquatable<CMsgClientToGCStartWatchingOverwatch>, IDeepCloneable<CMsgClientToGCStartWatchingOverwatch>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCStartWatchingOverwatch](Divine.Protobufs.Dota2.CMsgClientToGCStartWatchingOverwatch.md)

#### Implements

IMessage<CMsgClientToGCStartWatchingOverwatch\>, 
[IEquatable<CMsgClientToGCStartWatchingOverwatch\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCStartWatchingOverwatch\>, 
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
[EnumerableExtensions.In<CMsgClientToGCStartWatchingOverwatch\>\(CMsgClientToGCStartWatchingOverwatch, params CMsgClientToGCStartWatchingOverwatch\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCStartWatchingOverwatch__ctor"></a> CMsgClientToGCStartWatchingOverwatch\(\)

```csharp
public CMsgClientToGCStartWatchingOverwatch()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCStartWatchingOverwatch__ctor_Divine_Protobufs_Dota2_CMsgClientToGCStartWatchingOverwatch_"></a> CMsgClientToGCStartWatchingOverwatch\(CMsgClientToGCStartWatchingOverwatch\)

```csharp
public CMsgClientToGCStartWatchingOverwatch(CMsgClientToGCStartWatchingOverwatch other)
```

#### Parameters

`other` [CMsgClientToGCStartWatchingOverwatch](Divine.Protobufs.Dota2.CMsgClientToGCStartWatchingOverwatch.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCStartWatchingOverwatch_OverwatchReplayIdFieldNumber"></a> OverwatchReplayIdFieldNumber

```csharp
public const int OverwatchReplayIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCStartWatchingOverwatch_TargetPlayerSlotFieldNumber"></a> TargetPlayerSlotFieldNumber

```csharp
public const int TargetPlayerSlotFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCStartWatchingOverwatch_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCStartWatchingOverwatch_HasOverwatchReplayId"></a> HasOverwatchReplayId

```csharp
public bool HasOverwatchReplayId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCStartWatchingOverwatch_HasTargetPlayerSlot"></a> HasTargetPlayerSlot

```csharp
public bool HasTargetPlayerSlot { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCStartWatchingOverwatch_OverwatchReplayId"></a> OverwatchReplayId

```csharp
public ulong OverwatchReplayId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCStartWatchingOverwatch_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCStartWatchingOverwatch> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCStartWatchingOverwatch](Divine.Protobufs.Dota2.CMsgClientToGCStartWatchingOverwatch.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCStartWatchingOverwatch_TargetPlayerSlot"></a> TargetPlayerSlot

```csharp
public uint TargetPlayerSlot { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCStartWatchingOverwatch_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCStartWatchingOverwatch_ClearOverwatchReplayId"></a> ClearOverwatchReplayId\(\)

```csharp
public void ClearOverwatchReplayId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCStartWatchingOverwatch_ClearTargetPlayerSlot"></a> ClearTargetPlayerSlot\(\)

```csharp
public void ClearTargetPlayerSlot()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCStartWatchingOverwatch_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCStartWatchingOverwatch Clone()
```

#### Returns

 [CMsgClientToGCStartWatchingOverwatch](Divine.Protobufs.Dota2.CMsgClientToGCStartWatchingOverwatch.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCStartWatchingOverwatch_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCStartWatchingOverwatch_Equals_Divine_Protobufs_Dota2_CMsgClientToGCStartWatchingOverwatch_"></a> Equals\(CMsgClientToGCStartWatchingOverwatch\)

```csharp
public bool Equals(CMsgClientToGCStartWatchingOverwatch other)
```

#### Parameters

`other` [CMsgClientToGCStartWatchingOverwatch](Divine.Protobufs.Dota2.CMsgClientToGCStartWatchingOverwatch.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCStartWatchingOverwatch_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCStartWatchingOverwatch_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCStartWatchingOverwatch_"></a> MergeFrom\(CMsgClientToGCStartWatchingOverwatch\)

```csharp
public void MergeFrom(CMsgClientToGCStartWatchingOverwatch other)
```

#### Parameters

`other` [CMsgClientToGCStartWatchingOverwatch](Divine.Protobufs.Dota2.CMsgClientToGCStartWatchingOverwatch.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCStartWatchingOverwatch_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCStartWatchingOverwatch_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCStartWatchingOverwatch_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

