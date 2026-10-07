# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CombatLogBulkData"></a> Class CDOTAUserMsg\_CombatLogBulkData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_CombatLogBulkData : IMessage<CDOTAUserMsg_CombatLogBulkData>, IEquatable<CDOTAUserMsg_CombatLogBulkData>, IDeepCloneable<CDOTAUserMsg_CombatLogBulkData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_CombatLogBulkData](Divine.Protobufs.Dota2.CDOTAUserMsg\_CombatLogBulkData.md)

#### Implements

IMessage<CDOTAUserMsg\_CombatLogBulkData\>, 
[IEquatable<CDOTAUserMsg\_CombatLogBulkData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_CombatLogBulkData\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_CombatLogBulkData\>\(CDOTAUserMsg\_CombatLogBulkData, params CDOTAUserMsg\_CombatLogBulkData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CombatLogBulkData__ctor"></a> CDOTAUserMsg\_CombatLogBulkData\(\)

```csharp
public CDOTAUserMsg_CombatLogBulkData()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CombatLogBulkData__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_CombatLogBulkData_"></a> CDOTAUserMsg\_CombatLogBulkData\(CDOTAUserMsg\_CombatLogBulkData\)

```csharp
public CDOTAUserMsg_CombatLogBulkData(CDOTAUserMsg_CombatLogBulkData other)
```

#### Parameters

`other` [CDOTAUserMsg\_CombatLogBulkData](Divine.Protobufs.Dota2.CDOTAUserMsg\_CombatLogBulkData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CombatLogBulkData_CombatEntriesFieldNumber"></a> CombatEntriesFieldNumber

```csharp
public const int CombatEntriesFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CombatLogBulkData_DurationFieldNumber"></a> DurationFieldNumber

```csharp
public const int DurationFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CombatLogBulkData_PlayerIdFieldNumber"></a> PlayerIdFieldNumber

```csharp
public const int PlayerIdFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CombatLogBulkData_RequestTimeFieldNumber"></a> RequestTimeFieldNumber

```csharp
public const int RequestTimeFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CombatLogBulkData_TimestampFieldNumber"></a> TimestampFieldNumber

```csharp
public const int TimestampFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CombatLogBulkData_CombatEntries"></a> CombatEntries

```csharp
public RepeatedField<CMsgDOTACombatLogEntry> CombatEntries { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTACombatLogEntry](Divine.Protobufs.Dota2.CMsgDOTACombatLogEntry.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CombatLogBulkData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CombatLogBulkData_Duration"></a> Duration

```csharp
public float Duration { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CombatLogBulkData_HasDuration"></a> HasDuration

```csharp
public bool HasDuration { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CombatLogBulkData_HasPlayerId"></a> HasPlayerId

```csharp
public bool HasPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CombatLogBulkData_HasRequestTime"></a> HasRequestTime

```csharp
public bool HasRequestTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CombatLogBulkData_HasTimestamp"></a> HasTimestamp

```csharp
public bool HasTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CombatLogBulkData_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_CombatLogBulkData> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_CombatLogBulkData](Divine.Protobufs.Dota2.CDOTAUserMsg\_CombatLogBulkData.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CombatLogBulkData_PlayerId"></a> PlayerId

```csharp
public int PlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CombatLogBulkData_RequestTime"></a> RequestTime

```csharp
public float RequestTime { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CombatLogBulkData_Timestamp"></a> Timestamp

```csharp
public float Timestamp { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CombatLogBulkData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CombatLogBulkData_ClearDuration"></a> ClearDuration\(\)

```csharp
public void ClearDuration()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CombatLogBulkData_ClearPlayerId"></a> ClearPlayerId\(\)

```csharp
public void ClearPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CombatLogBulkData_ClearRequestTime"></a> ClearRequestTime\(\)

```csharp
public void ClearRequestTime()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CombatLogBulkData_ClearTimestamp"></a> ClearTimestamp\(\)

```csharp
public void ClearTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CombatLogBulkData_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_CombatLogBulkData Clone()
```

#### Returns

 [CDOTAUserMsg\_CombatLogBulkData](Divine.Protobufs.Dota2.CDOTAUserMsg\_CombatLogBulkData.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CombatLogBulkData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CombatLogBulkData_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_CombatLogBulkData_"></a> Equals\(CDOTAUserMsg\_CombatLogBulkData\)

```csharp
public bool Equals(CDOTAUserMsg_CombatLogBulkData other)
```

#### Parameters

`other` [CDOTAUserMsg\_CombatLogBulkData](Divine.Protobufs.Dota2.CDOTAUserMsg\_CombatLogBulkData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CombatLogBulkData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CombatLogBulkData_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_CombatLogBulkData_"></a> MergeFrom\(CDOTAUserMsg\_CombatLogBulkData\)

```csharp
public void MergeFrom(CDOTAUserMsg_CombatLogBulkData other)
```

#### Parameters

`other` [CDOTAUserMsg\_CombatLogBulkData](Divine.Protobufs.Dota2.CDOTAUserMsg\_CombatLogBulkData.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CombatLogBulkData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CombatLogBulkData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CombatLogBulkData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

