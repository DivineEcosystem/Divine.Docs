# <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsPowerUpTelemetryData"></a> Class CMsgClientToGCSurvivorsPowerUpTelemetryData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCSurvivorsPowerUpTelemetryData : IMessage<CMsgClientToGCSurvivorsPowerUpTelemetryData>, IEquatable<CMsgClientToGCSurvivorsPowerUpTelemetryData>, IDeepCloneable<CMsgClientToGCSurvivorsPowerUpTelemetryData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCSurvivorsPowerUpTelemetryData](Divine.Protobufs.Dota2.CMsgClientToGCSurvivorsPowerUpTelemetryData.md)

#### Implements

IMessage<CMsgClientToGCSurvivorsPowerUpTelemetryData\>, 
[IEquatable<CMsgClientToGCSurvivorsPowerUpTelemetryData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCSurvivorsPowerUpTelemetryData\>, 
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
[EnumerableExtensions.In<CMsgClientToGCSurvivorsPowerUpTelemetryData\>\(CMsgClientToGCSurvivorsPowerUpTelemetryData, params CMsgClientToGCSurvivorsPowerUpTelemetryData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsPowerUpTelemetryData__ctor"></a> CMsgClientToGCSurvivorsPowerUpTelemetryData\(\)

```csharp
public CMsgClientToGCSurvivorsPowerUpTelemetryData()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsPowerUpTelemetryData__ctor_Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsPowerUpTelemetryData_"></a> CMsgClientToGCSurvivorsPowerUpTelemetryData\(CMsgClientToGCSurvivorsPowerUpTelemetryData\)

```csharp
public CMsgClientToGCSurvivorsPowerUpTelemetryData(CMsgClientToGCSurvivorsPowerUpTelemetryData other)
```

#### Parameters

`other` [CMsgClientToGCSurvivorsPowerUpTelemetryData](Divine.Protobufs.Dota2.CMsgClientToGCSurvivorsPowerUpTelemetryData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsPowerUpTelemetryData_DpsFieldNumber"></a> DpsFieldNumber

```csharp
public const int DpsFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsPowerUpTelemetryData_HasScepterFieldNumber"></a> HasScepterFieldNumber

```csharp
public const int HasScepterFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsPowerUpTelemetryData_LevelFieldNumber"></a> LevelFieldNumber

```csharp
public const int LevelFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsPowerUpTelemetryData_PowerupIdFieldNumber"></a> PowerupIdFieldNumber

```csharp
public const int PowerupIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsPowerUpTelemetryData_TimeHeldFieldNumber"></a> TimeHeldFieldNumber

```csharp
public const int TimeHeldFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsPowerUpTelemetryData_TimeReceivedFieldNumber"></a> TimeReceivedFieldNumber

```csharp
public const int TimeReceivedFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsPowerUpTelemetryData_TotalDamageFieldNumber"></a> TotalDamageFieldNumber

```csharp
public const int TotalDamageFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsPowerUpTelemetryData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsPowerUpTelemetryData_Dps"></a> Dps

```csharp
public uint Dps { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsPowerUpTelemetryData_HasDps"></a> HasDps

```csharp
public bool HasDps { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsPowerUpTelemetryData_HasHasScepter"></a> HasHasScepter

```csharp
public bool HasHasScepter { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsPowerUpTelemetryData_HasLevel"></a> HasLevel

```csharp
public bool HasLevel { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsPowerUpTelemetryData_HasPowerupId"></a> HasPowerupId

```csharp
public bool HasPowerupId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsPowerUpTelemetryData_HasScepter"></a> HasScepter

```csharp
public uint HasScepter { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsPowerUpTelemetryData_HasTimeHeld"></a> HasTimeHeld

```csharp
public bool HasTimeHeld { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsPowerUpTelemetryData_HasTimeReceived"></a> HasTimeReceived

```csharp
public bool HasTimeReceived { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsPowerUpTelemetryData_HasTotalDamage"></a> HasTotalDamage

```csharp
public bool HasTotalDamage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsPowerUpTelemetryData_Level"></a> Level

```csharp
public uint Level { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsPowerUpTelemetryData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCSurvivorsPowerUpTelemetryData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCSurvivorsPowerUpTelemetryData](Divine.Protobufs.Dota2.CMsgClientToGCSurvivorsPowerUpTelemetryData.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsPowerUpTelemetryData_PowerupId"></a> PowerupId

```csharp
public uint PowerupId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsPowerUpTelemetryData_TimeHeld"></a> TimeHeld

```csharp
public uint TimeHeld { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsPowerUpTelemetryData_TimeReceived"></a> TimeReceived

```csharp
public uint TimeReceived { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsPowerUpTelemetryData_TotalDamage"></a> TotalDamage

```csharp
public ulong TotalDamage { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsPowerUpTelemetryData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsPowerUpTelemetryData_ClearDps"></a> ClearDps\(\)

```csharp
public void ClearDps()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsPowerUpTelemetryData_ClearHasScepter"></a> ClearHasScepter\(\)

```csharp
public void ClearHasScepter()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsPowerUpTelemetryData_ClearLevel"></a> ClearLevel\(\)

```csharp
public void ClearLevel()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsPowerUpTelemetryData_ClearPowerupId"></a> ClearPowerupId\(\)

```csharp
public void ClearPowerupId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsPowerUpTelemetryData_ClearTimeHeld"></a> ClearTimeHeld\(\)

```csharp
public void ClearTimeHeld()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsPowerUpTelemetryData_ClearTimeReceived"></a> ClearTimeReceived\(\)

```csharp
public void ClearTimeReceived()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsPowerUpTelemetryData_ClearTotalDamage"></a> ClearTotalDamage\(\)

```csharp
public void ClearTotalDamage()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsPowerUpTelemetryData_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCSurvivorsPowerUpTelemetryData Clone()
```

#### Returns

 [CMsgClientToGCSurvivorsPowerUpTelemetryData](Divine.Protobufs.Dota2.CMsgClientToGCSurvivorsPowerUpTelemetryData.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsPowerUpTelemetryData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsPowerUpTelemetryData_Equals_Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsPowerUpTelemetryData_"></a> Equals\(CMsgClientToGCSurvivorsPowerUpTelemetryData\)

```csharp
public bool Equals(CMsgClientToGCSurvivorsPowerUpTelemetryData other)
```

#### Parameters

`other` [CMsgClientToGCSurvivorsPowerUpTelemetryData](Divine.Protobufs.Dota2.CMsgClientToGCSurvivorsPowerUpTelemetryData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsPowerUpTelemetryData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsPowerUpTelemetryData_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsPowerUpTelemetryData_"></a> MergeFrom\(CMsgClientToGCSurvivorsPowerUpTelemetryData\)

```csharp
public void MergeFrom(CMsgClientToGCSurvivorsPowerUpTelemetryData other)
```

#### Parameters

`other` [CMsgClientToGCSurvivorsPowerUpTelemetryData](Divine.Protobufs.Dota2.CMsgClientToGCSurvivorsPowerUpTelemetryData.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsPowerUpTelemetryData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsPowerUpTelemetryData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSurvivorsPowerUpTelemetryData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

