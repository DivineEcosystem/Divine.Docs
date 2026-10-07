# <a id="Divine_Protobufs_Dota2_CDOTAClientHardwareSpecs"></a> Class CDOTAClientHardwareSpecs

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientHardwareSpecs : IMessage<CDOTAClientHardwareSpecs>, IEquatable<CDOTAClientHardwareSpecs>, IDeepCloneable<CDOTAClientHardwareSpecs>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientHardwareSpecs](Divine.Protobufs.Dota2.CDOTAClientHardwareSpecs.md)

#### Implements

IMessage<CDOTAClientHardwareSpecs\>, 
[IEquatable<CDOTAClientHardwareSpecs\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientHardwareSpecs\>, 
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
[EnumerableExtensions.In<CDOTAClientHardwareSpecs\>\(CDOTAClientHardwareSpecs, params CDOTAClientHardwareSpecs\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientHardwareSpecs__ctor"></a> CDOTAClientHardwareSpecs\(\)

```csharp
public CDOTAClientHardwareSpecs()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientHardwareSpecs__ctor_Divine_Protobufs_Dota2_CDOTAClientHardwareSpecs_"></a> CDOTAClientHardwareSpecs\(CDOTAClientHardwareSpecs\)

```csharp
public CDOTAClientHardwareSpecs(CDOTAClientHardwareSpecs other)
```

#### Parameters

`other` [CDOTAClientHardwareSpecs](Divine.Protobufs.Dota2.CDOTAClientHardwareSpecs.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientHardwareSpecs_CpuCyclesPerSecondFieldNumber"></a> CpuCyclesPerSecondFieldNumber

```csharp
public const int CpuCyclesPerSecondFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientHardwareSpecs_CrcFieldNumber"></a> CrcFieldNumber

```csharp
public const int CrcFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientHardwareSpecs_Is64BitOsFieldNumber"></a> Is64BitOsFieldNumber

```csharp
public const int Is64BitOsFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientHardwareSpecs_LogicalProcessorsFieldNumber"></a> LogicalProcessorsFieldNumber

```csharp
public const int LogicalProcessorsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientHardwareSpecs_PreferNotHostFieldNumber"></a> PreferNotHostFieldNumber

```csharp
public const int PreferNotHostFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientHardwareSpecs_TotalPhysicalMemoryFieldNumber"></a> TotalPhysicalMemoryFieldNumber

```csharp
public const int TotalPhysicalMemoryFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientHardwareSpecs_UploadMeasurementFieldNumber"></a> UploadMeasurementFieldNumber

```csharp
public const int UploadMeasurementFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientHardwareSpecs_CpuCyclesPerSecond"></a> CpuCyclesPerSecond

```csharp
public ulong CpuCyclesPerSecond { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CDOTAClientHardwareSpecs_Crc"></a> Crc

```csharp
public RepeatedField<uint> Crc { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CDOTAClientHardwareSpecs_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientHardwareSpecs_HasCpuCyclesPerSecond"></a> HasCpuCyclesPerSecond

```csharp
public bool HasCpuCyclesPerSecond { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientHardwareSpecs_HasIs64BitOs"></a> HasIs64BitOs

```csharp
public bool HasIs64BitOs { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientHardwareSpecs_HasLogicalProcessors"></a> HasLogicalProcessors

```csharp
public bool HasLogicalProcessors { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientHardwareSpecs_HasPreferNotHost"></a> HasPreferNotHost

```csharp
public bool HasPreferNotHost { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientHardwareSpecs_HasTotalPhysicalMemory"></a> HasTotalPhysicalMemory

```csharp
public bool HasTotalPhysicalMemory { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientHardwareSpecs_HasUploadMeasurement"></a> HasUploadMeasurement

```csharp
public bool HasUploadMeasurement { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientHardwareSpecs_Is64BitOs"></a> Is64BitOs

```csharp
public bool Is64BitOs { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientHardwareSpecs_LogicalProcessors"></a> LogicalProcessors

```csharp
public uint LogicalProcessors { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientHardwareSpecs_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientHardwareSpecs> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientHardwareSpecs](Divine.Protobufs.Dota2.CDOTAClientHardwareSpecs.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAClientHardwareSpecs_PreferNotHost"></a> PreferNotHost

```csharp
public bool PreferNotHost { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientHardwareSpecs_TotalPhysicalMemory"></a> TotalPhysicalMemory

```csharp
public ulong TotalPhysicalMemory { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CDOTAClientHardwareSpecs_UploadMeasurement"></a> UploadMeasurement

```csharp
public ulong UploadMeasurement { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientHardwareSpecs_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientHardwareSpecs_ClearCpuCyclesPerSecond"></a> ClearCpuCyclesPerSecond\(\)

```csharp
public void ClearCpuCyclesPerSecond()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientHardwareSpecs_ClearIs64BitOs"></a> ClearIs64BitOs\(\)

```csharp
public void ClearIs64BitOs()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientHardwareSpecs_ClearLogicalProcessors"></a> ClearLogicalProcessors\(\)

```csharp
public void ClearLogicalProcessors()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientHardwareSpecs_ClearPreferNotHost"></a> ClearPreferNotHost\(\)

```csharp
public void ClearPreferNotHost()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientHardwareSpecs_ClearTotalPhysicalMemory"></a> ClearTotalPhysicalMemory\(\)

```csharp
public void ClearTotalPhysicalMemory()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientHardwareSpecs_ClearUploadMeasurement"></a> ClearUploadMeasurement\(\)

```csharp
public void ClearUploadMeasurement()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientHardwareSpecs_Clone"></a> Clone\(\)

```csharp
public CDOTAClientHardwareSpecs Clone()
```

#### Returns

 [CDOTAClientHardwareSpecs](Divine.Protobufs.Dota2.CDOTAClientHardwareSpecs.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientHardwareSpecs_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientHardwareSpecs_Equals_Divine_Protobufs_Dota2_CDOTAClientHardwareSpecs_"></a> Equals\(CDOTAClientHardwareSpecs\)

```csharp
public bool Equals(CDOTAClientHardwareSpecs other)
```

#### Parameters

`other` [CDOTAClientHardwareSpecs](Divine.Protobufs.Dota2.CDOTAClientHardwareSpecs.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientHardwareSpecs_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientHardwareSpecs_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientHardwareSpecs_"></a> MergeFrom\(CDOTAClientHardwareSpecs\)

```csharp
public void MergeFrom(CDOTAClientHardwareSpecs other)
```

#### Parameters

`other` [CDOTAClientHardwareSpecs](Divine.Protobufs.Dota2.CDOTAClientHardwareSpecs.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientHardwareSpecs_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientHardwareSpecs_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientHardwareSpecs_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

