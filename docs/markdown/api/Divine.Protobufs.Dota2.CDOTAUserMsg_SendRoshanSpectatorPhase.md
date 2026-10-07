# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendRoshanSpectatorPhase"></a> Class CDOTAUserMsg\_SendRoshanSpectatorPhase

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_SendRoshanSpectatorPhase : IMessage<CDOTAUserMsg_SendRoshanSpectatorPhase>, IEquatable<CDOTAUserMsg_SendRoshanSpectatorPhase>, IDeepCloneable<CDOTAUserMsg_SendRoshanSpectatorPhase>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_SendRoshanSpectatorPhase](Divine.Protobufs.Dota2.CDOTAUserMsg\_SendRoshanSpectatorPhase.md)

#### Implements

IMessage<CDOTAUserMsg\_SendRoshanSpectatorPhase\>, 
[IEquatable<CDOTAUserMsg\_SendRoshanSpectatorPhase\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_SendRoshanSpectatorPhase\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_SendRoshanSpectatorPhase\>\(CDOTAUserMsg\_SendRoshanSpectatorPhase, params CDOTAUserMsg\_SendRoshanSpectatorPhase\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendRoshanSpectatorPhase__ctor"></a> CDOTAUserMsg\_SendRoshanSpectatorPhase\(\)

```csharp
public CDOTAUserMsg_SendRoshanSpectatorPhase()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendRoshanSpectatorPhase__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_SendRoshanSpectatorPhase_"></a> CDOTAUserMsg\_SendRoshanSpectatorPhase\(CDOTAUserMsg\_SendRoshanSpectatorPhase\)

```csharp
public CDOTAUserMsg_SendRoshanSpectatorPhase(CDOTAUserMsg_SendRoshanSpectatorPhase other)
```

#### Parameters

`other` [CDOTAUserMsg\_SendRoshanSpectatorPhase](Divine.Protobufs.Dota2.CDOTAUserMsg\_SendRoshanSpectatorPhase.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendRoshanSpectatorPhase_PhaseFieldNumber"></a> PhaseFieldNumber

```csharp
public const int PhaseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendRoshanSpectatorPhase_PhaseLengthFieldNumber"></a> PhaseLengthFieldNumber

```csharp
public const int PhaseLengthFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendRoshanSpectatorPhase_PhaseStartTimeFieldNumber"></a> PhaseStartTimeFieldNumber

```csharp
public const int PhaseStartTimeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendRoshanSpectatorPhase_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendRoshanSpectatorPhase_HasPhase"></a> HasPhase

```csharp
public bool HasPhase { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendRoshanSpectatorPhase_HasPhaseLength"></a> HasPhaseLength

```csharp
public bool HasPhaseLength { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendRoshanSpectatorPhase_HasPhaseStartTime"></a> HasPhaseStartTime

```csharp
public bool HasPhaseStartTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendRoshanSpectatorPhase_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_SendRoshanSpectatorPhase> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_SendRoshanSpectatorPhase](Divine.Protobufs.Dota2.CDOTAUserMsg\_SendRoshanSpectatorPhase.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendRoshanSpectatorPhase_Phase"></a> Phase

```csharp
public DOTA_ROSHAN_PHASE Phase { get; set; }
```

#### Property Value

 [DOTA\_ROSHAN\_PHASE](Divine.Protobufs.Dota2.DOTA\_ROSHAN\_PHASE.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendRoshanSpectatorPhase_PhaseLength"></a> PhaseLength

```csharp
public int PhaseLength { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendRoshanSpectatorPhase_PhaseStartTime"></a> PhaseStartTime

```csharp
public int PhaseStartTime { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendRoshanSpectatorPhase_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendRoshanSpectatorPhase_ClearPhase"></a> ClearPhase\(\)

```csharp
public void ClearPhase()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendRoshanSpectatorPhase_ClearPhaseLength"></a> ClearPhaseLength\(\)

```csharp
public void ClearPhaseLength()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendRoshanSpectatorPhase_ClearPhaseStartTime"></a> ClearPhaseStartTime\(\)

```csharp
public void ClearPhaseStartTime()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendRoshanSpectatorPhase_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_SendRoshanSpectatorPhase Clone()
```

#### Returns

 [CDOTAUserMsg\_SendRoshanSpectatorPhase](Divine.Protobufs.Dota2.CDOTAUserMsg\_SendRoshanSpectatorPhase.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendRoshanSpectatorPhase_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendRoshanSpectatorPhase_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_SendRoshanSpectatorPhase_"></a> Equals\(CDOTAUserMsg\_SendRoshanSpectatorPhase\)

```csharp
public bool Equals(CDOTAUserMsg_SendRoshanSpectatorPhase other)
```

#### Parameters

`other` [CDOTAUserMsg\_SendRoshanSpectatorPhase](Divine.Protobufs.Dota2.CDOTAUserMsg\_SendRoshanSpectatorPhase.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendRoshanSpectatorPhase_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendRoshanSpectatorPhase_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_SendRoshanSpectatorPhase_"></a> MergeFrom\(CDOTAUserMsg\_SendRoshanSpectatorPhase\)

```csharp
public void MergeFrom(CDOTAUserMsg_SendRoshanSpectatorPhase other)
```

#### Parameters

`other` [CDOTAUserMsg\_SendRoshanSpectatorPhase](Divine.Protobufs.Dota2.CDOTAUserMsg\_SendRoshanSpectatorPhase.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendRoshanSpectatorPhase_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendRoshanSpectatorPhase_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendRoshanSpectatorPhase_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

