# <a id="Divine_Protobufs_Dota2_CMsgServerToGCRealtimeStats"></a> Class CMsgServerToGCRealtimeStats

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgServerToGCRealtimeStats : IMessage<CMsgServerToGCRealtimeStats>, IEquatable<CMsgServerToGCRealtimeStats>, IDeepCloneable<CMsgServerToGCRealtimeStats>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgServerToGCRealtimeStats](Divine.Protobufs.Dota2.CMsgServerToGCRealtimeStats.md)

#### Implements

IMessage<CMsgServerToGCRealtimeStats\>, 
[IEquatable<CMsgServerToGCRealtimeStats\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgServerToGCRealtimeStats\>, 
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
[EnumerableExtensions.In<CMsgServerToGCRealtimeStats\>\(CMsgServerToGCRealtimeStats, params CMsgServerToGCRealtimeStats\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRealtimeStats__ctor"></a> CMsgServerToGCRealtimeStats\(\)

```csharp
public CMsgServerToGCRealtimeStats()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRealtimeStats__ctor_Divine_Protobufs_Dota2_CMsgServerToGCRealtimeStats_"></a> CMsgServerToGCRealtimeStats\(CMsgServerToGCRealtimeStats\)

```csharp
public CMsgServerToGCRealtimeStats(CMsgServerToGCRealtimeStats other)
```

#### Parameters

`other` [CMsgServerToGCRealtimeStats](Divine.Protobufs.Dota2.CMsgServerToGCRealtimeStats.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRealtimeStats_DelayedFieldNumber"></a> DelayedFieldNumber

```csharp
public const int DelayedFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRealtimeStats_Delayed"></a> Delayed

```csharp
public CMsgDOTARealtimeGameStatsTerse Delayed { get; set; }
```

#### Property Value

 [CMsgDOTARealtimeGameStatsTerse](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRealtimeStats_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRealtimeStats_Parser"></a> Parser

```csharp
public static MessageParser<CMsgServerToGCRealtimeStats> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgServerToGCRealtimeStats](Divine.Protobufs.Dota2.CMsgServerToGCRealtimeStats.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRealtimeStats_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRealtimeStats_Clone"></a> Clone\(\)

```csharp
public CMsgServerToGCRealtimeStats Clone()
```

#### Returns

 [CMsgServerToGCRealtimeStats](Divine.Protobufs.Dota2.CMsgServerToGCRealtimeStats.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRealtimeStats_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRealtimeStats_Equals_Divine_Protobufs_Dota2_CMsgServerToGCRealtimeStats_"></a> Equals\(CMsgServerToGCRealtimeStats\)

```csharp
public bool Equals(CMsgServerToGCRealtimeStats other)
```

#### Parameters

`other` [CMsgServerToGCRealtimeStats](Divine.Protobufs.Dota2.CMsgServerToGCRealtimeStats.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRealtimeStats_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRealtimeStats_MergeFrom_Divine_Protobufs_Dota2_CMsgServerToGCRealtimeStats_"></a> MergeFrom\(CMsgServerToGCRealtimeStats\)

```csharp
public void MergeFrom(CMsgServerToGCRealtimeStats other)
```

#### Parameters

`other` [CMsgServerToGCRealtimeStats](Divine.Protobufs.Dota2.CMsgServerToGCRealtimeStats.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRealtimeStats_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRealtimeStats_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRealtimeStats_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

