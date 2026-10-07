# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_NetworkStats"></a> Class CDOTAClientMsg\_NetworkStats

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_NetworkStats : IMessage<CDOTAClientMsg_NetworkStats>, IEquatable<CDOTAClientMsg_NetworkStats>, IDeepCloneable<CDOTAClientMsg_NetworkStats>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_NetworkStats](Divine.Protobufs.Dota2.CDOTAClientMsg\_NetworkStats.md)

#### Implements

IMessage<CDOTAClientMsg\_NetworkStats\>, 
[IEquatable<CDOTAClientMsg\_NetworkStats\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_NetworkStats\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_NetworkStats\>\(CDOTAClientMsg\_NetworkStats, params CDOTAClientMsg\_NetworkStats\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_NetworkStats__ctor"></a> CDOTAClientMsg\_NetworkStats\(\)

```csharp
public CDOTAClientMsg_NetworkStats()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_NetworkStats__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_NetworkStats_"></a> CDOTAClientMsg\_NetworkStats\(CDOTAClientMsg\_NetworkStats\)

```csharp
public CDOTAClientMsg_NetworkStats(CDOTAClientMsg_NetworkStats other)
```

#### Parameters

`other` [CDOTAClientMsg\_NetworkStats](Divine.Protobufs.Dota2.CDOTAClientMsg\_NetworkStats.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_NetworkStats_MissedSnapshotRateFieldNumber"></a> MissedSnapshotRateFieldNumber

```csharp
public const int MissedSnapshotRateFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_NetworkStats_TickFieldNumber"></a> TickFieldNumber

```csharp
public const int TickFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_NetworkStats_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_NetworkStats_HasMissedSnapshotRate"></a> HasMissedSnapshotRate

```csharp
public bool HasMissedSnapshotRate { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_NetworkStats_HasTick"></a> HasTick

```csharp
public bool HasTick { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_NetworkStats_MissedSnapshotRate"></a> MissedSnapshotRate

```csharp
public float MissedSnapshotRate { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_NetworkStats_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_NetworkStats> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_NetworkStats](Divine.Protobufs.Dota2.CDOTAClientMsg\_NetworkStats.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_NetworkStats_Tick"></a> Tick

```csharp
public uint Tick { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_NetworkStats_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_NetworkStats_ClearMissedSnapshotRate"></a> ClearMissedSnapshotRate\(\)

```csharp
public void ClearMissedSnapshotRate()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_NetworkStats_ClearTick"></a> ClearTick\(\)

```csharp
public void ClearTick()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_NetworkStats_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_NetworkStats Clone()
```

#### Returns

 [CDOTAClientMsg\_NetworkStats](Divine.Protobufs.Dota2.CDOTAClientMsg\_NetworkStats.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_NetworkStats_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_NetworkStats_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_NetworkStats_"></a> Equals\(CDOTAClientMsg\_NetworkStats\)

```csharp
public bool Equals(CDOTAClientMsg_NetworkStats other)
```

#### Parameters

`other` [CDOTAClientMsg\_NetworkStats](Divine.Protobufs.Dota2.CDOTAClientMsg\_NetworkStats.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_NetworkStats_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_NetworkStats_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_NetworkStats_"></a> MergeFrom\(CDOTAClientMsg\_NetworkStats\)

```csharp
public void MergeFrom(CDOTAClientMsg_NetworkStats other)
```

#### Parameters

`other` [CDOTAClientMsg\_NetworkStats](Divine.Protobufs.Dota2.CDOTAClientMsg\_NetworkStats.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_NetworkStats_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_NetworkStats_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_NetworkStats_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

