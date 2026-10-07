# <a id="Divine_Protobufs_Dota2_CMsgGCToServerRealtimeStatsStartStop"></a> Class CMsgGCToServerRealtimeStatsStartStop

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToServerRealtimeStatsStartStop : IMessage<CMsgGCToServerRealtimeStatsStartStop>, IEquatable<CMsgGCToServerRealtimeStatsStartStop>, IDeepCloneable<CMsgGCToServerRealtimeStatsStartStop>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToServerRealtimeStatsStartStop](Divine.Protobufs.Dota2.CMsgGCToServerRealtimeStatsStartStop.md)

#### Implements

IMessage<CMsgGCToServerRealtimeStatsStartStop\>, 
[IEquatable<CMsgGCToServerRealtimeStatsStartStop\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToServerRealtimeStatsStartStop\>, 
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
[EnumerableExtensions.In<CMsgGCToServerRealtimeStatsStartStop\>\(CMsgGCToServerRealtimeStatsStartStop, params CMsgGCToServerRealtimeStatsStartStop\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerRealtimeStatsStartStop__ctor"></a> CMsgGCToServerRealtimeStatsStartStop\(\)

```csharp
public CMsgGCToServerRealtimeStatsStartStop()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerRealtimeStatsStartStop__ctor_Divine_Protobufs_Dota2_CMsgGCToServerRealtimeStatsStartStop_"></a> CMsgGCToServerRealtimeStatsStartStop\(CMsgGCToServerRealtimeStatsStartStop\)

```csharp
public CMsgGCToServerRealtimeStatsStartStop(CMsgGCToServerRealtimeStatsStartStop other)
```

#### Parameters

`other` [CMsgGCToServerRealtimeStatsStartStop](Divine.Protobufs.Dota2.CMsgGCToServerRealtimeStatsStartStop.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerRealtimeStatsStartStop_DelayedFieldNumber"></a> DelayedFieldNumber

```csharp
public const int DelayedFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerRealtimeStatsStartStop_Delayed"></a> Delayed

```csharp
public bool Delayed { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerRealtimeStatsStartStop_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerRealtimeStatsStartStop_HasDelayed"></a> HasDelayed

```csharp
public bool HasDelayed { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerRealtimeStatsStartStop_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToServerRealtimeStatsStartStop> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToServerRealtimeStatsStartStop](Divine.Protobufs.Dota2.CMsgGCToServerRealtimeStatsStartStop.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerRealtimeStatsStartStop_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerRealtimeStatsStartStop_ClearDelayed"></a> ClearDelayed\(\)

```csharp
public void ClearDelayed()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerRealtimeStatsStartStop_Clone"></a> Clone\(\)

```csharp
public CMsgGCToServerRealtimeStatsStartStop Clone()
```

#### Returns

 [CMsgGCToServerRealtimeStatsStartStop](Divine.Protobufs.Dota2.CMsgGCToServerRealtimeStatsStartStop.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerRealtimeStatsStartStop_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerRealtimeStatsStartStop_Equals_Divine_Protobufs_Dota2_CMsgGCToServerRealtimeStatsStartStop_"></a> Equals\(CMsgGCToServerRealtimeStatsStartStop\)

```csharp
public bool Equals(CMsgGCToServerRealtimeStatsStartStop other)
```

#### Parameters

`other` [CMsgGCToServerRealtimeStatsStartStop](Divine.Protobufs.Dota2.CMsgGCToServerRealtimeStatsStartStop.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerRealtimeStatsStartStop_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerRealtimeStatsStartStop_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToServerRealtimeStatsStartStop_"></a> MergeFrom\(CMsgGCToServerRealtimeStatsStartStop\)

```csharp
public void MergeFrom(CMsgGCToServerRealtimeStatsStartStop other)
```

#### Parameters

`other` [CMsgGCToServerRealtimeStatsStartStop](Divine.Protobufs.Dota2.CMsgGCToServerRealtimeStatsStartStop.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerRealtimeStatsStartStop_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerRealtimeStatsStartStop_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerRealtimeStatsStartStop_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

