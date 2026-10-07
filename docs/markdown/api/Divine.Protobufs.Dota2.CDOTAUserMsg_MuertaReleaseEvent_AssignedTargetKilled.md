# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MuertaReleaseEvent_AssignedTargetKilled"></a> Class CDOTAUserMsg\_MuertaReleaseEvent\_AssignedTargetKilled

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_MuertaReleaseEvent_AssignedTargetKilled : IMessage<CDOTAUserMsg_MuertaReleaseEvent_AssignedTargetKilled>, IEquatable<CDOTAUserMsg_MuertaReleaseEvent_AssignedTargetKilled>, IDeepCloneable<CDOTAUserMsg_MuertaReleaseEvent_AssignedTargetKilled>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_MuertaReleaseEvent\_AssignedTargetKilled](Divine.Protobufs.Dota2.CDOTAUserMsg\_MuertaReleaseEvent\_AssignedTargetKilled.md)

#### Implements

IMessage<CDOTAUserMsg\_MuertaReleaseEvent\_AssignedTargetKilled\>, 
[IEquatable<CDOTAUserMsg\_MuertaReleaseEvent\_AssignedTargetKilled\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_MuertaReleaseEvent\_AssignedTargetKilled\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_MuertaReleaseEvent\_AssignedTargetKilled\>\(CDOTAUserMsg\_MuertaReleaseEvent\_AssignedTargetKilled, params CDOTAUserMsg\_MuertaReleaseEvent\_AssignedTargetKilled\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MuertaReleaseEvent_AssignedTargetKilled__ctor"></a> CDOTAUserMsg\_MuertaReleaseEvent\_AssignedTargetKilled\(\)

```csharp
public CDOTAUserMsg_MuertaReleaseEvent_AssignedTargetKilled()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MuertaReleaseEvent_AssignedTargetKilled__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_MuertaReleaseEvent_AssignedTargetKilled_"></a> CDOTAUserMsg\_MuertaReleaseEvent\_AssignedTargetKilled\(CDOTAUserMsg\_MuertaReleaseEvent\_AssignedTargetKilled\)

```csharp
public CDOTAUserMsg_MuertaReleaseEvent_AssignedTargetKilled(CDOTAUserMsg_MuertaReleaseEvent_AssignedTargetKilled other)
```

#### Parameters

`other` [CDOTAUserMsg\_MuertaReleaseEvent\_AssignedTargetKilled](Divine.Protobufs.Dota2.CDOTAUserMsg\_MuertaReleaseEvent\_AssignedTargetKilled.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MuertaReleaseEvent_AssignedTargetKilled_LastHitFieldNumber"></a> LastHitFieldNumber

```csharp
public const int LastHitFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MuertaReleaseEvent_AssignedTargetKilled_PlayerIdKillerFieldNumber"></a> PlayerIdKillerFieldNumber

```csharp
public const int PlayerIdKillerFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MuertaReleaseEvent_AssignedTargetKilled_PlayerIdTargetFieldNumber"></a> PlayerIdTargetFieldNumber

```csharp
public const int PlayerIdTargetFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MuertaReleaseEvent_AssignedTargetKilled_PointsFieldNumber"></a> PointsFieldNumber

```csharp
public const int PointsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MuertaReleaseEvent_AssignedTargetKilled_PointsTotalFieldNumber"></a> PointsTotalFieldNumber

```csharp
public const int PointsTotalFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MuertaReleaseEvent_AssignedTargetKilled_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MuertaReleaseEvent_AssignedTargetKilled_HasLastHit"></a> HasLastHit

```csharp
public bool HasLastHit { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MuertaReleaseEvent_AssignedTargetKilled_HasPlayerIdKiller"></a> HasPlayerIdKiller

```csharp
public bool HasPlayerIdKiller { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MuertaReleaseEvent_AssignedTargetKilled_HasPlayerIdTarget"></a> HasPlayerIdTarget

```csharp
public bool HasPlayerIdTarget { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MuertaReleaseEvent_AssignedTargetKilled_HasPoints"></a> HasPoints

```csharp
public bool HasPoints { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MuertaReleaseEvent_AssignedTargetKilled_HasPointsTotal"></a> HasPointsTotal

```csharp
public bool HasPointsTotal { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MuertaReleaseEvent_AssignedTargetKilled_LastHit"></a> LastHit

```csharp
public bool LastHit { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MuertaReleaseEvent_AssignedTargetKilled_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_MuertaReleaseEvent_AssignedTargetKilled> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_MuertaReleaseEvent\_AssignedTargetKilled](Divine.Protobufs.Dota2.CDOTAUserMsg\_MuertaReleaseEvent\_AssignedTargetKilled.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MuertaReleaseEvent_AssignedTargetKilled_PlayerIdKiller"></a> PlayerIdKiller

```csharp
public int PlayerIdKiller { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MuertaReleaseEvent_AssignedTargetKilled_PlayerIdTarget"></a> PlayerIdTarget

```csharp
public int PlayerIdTarget { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MuertaReleaseEvent_AssignedTargetKilled_Points"></a> Points

```csharp
public int Points { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MuertaReleaseEvent_AssignedTargetKilled_PointsTotal"></a> PointsTotal

```csharp
public int PointsTotal { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MuertaReleaseEvent_AssignedTargetKilled_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MuertaReleaseEvent_AssignedTargetKilled_ClearLastHit"></a> ClearLastHit\(\)

```csharp
public void ClearLastHit()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MuertaReleaseEvent_AssignedTargetKilled_ClearPlayerIdKiller"></a> ClearPlayerIdKiller\(\)

```csharp
public void ClearPlayerIdKiller()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MuertaReleaseEvent_AssignedTargetKilled_ClearPlayerIdTarget"></a> ClearPlayerIdTarget\(\)

```csharp
public void ClearPlayerIdTarget()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MuertaReleaseEvent_AssignedTargetKilled_ClearPoints"></a> ClearPoints\(\)

```csharp
public void ClearPoints()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MuertaReleaseEvent_AssignedTargetKilled_ClearPointsTotal"></a> ClearPointsTotal\(\)

```csharp
public void ClearPointsTotal()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MuertaReleaseEvent_AssignedTargetKilled_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_MuertaReleaseEvent_AssignedTargetKilled Clone()
```

#### Returns

 [CDOTAUserMsg\_MuertaReleaseEvent\_AssignedTargetKilled](Divine.Protobufs.Dota2.CDOTAUserMsg\_MuertaReleaseEvent\_AssignedTargetKilled.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MuertaReleaseEvent_AssignedTargetKilled_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MuertaReleaseEvent_AssignedTargetKilled_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_MuertaReleaseEvent_AssignedTargetKilled_"></a> Equals\(CDOTAUserMsg\_MuertaReleaseEvent\_AssignedTargetKilled\)

```csharp
public bool Equals(CDOTAUserMsg_MuertaReleaseEvent_AssignedTargetKilled other)
```

#### Parameters

`other` [CDOTAUserMsg\_MuertaReleaseEvent\_AssignedTargetKilled](Divine.Protobufs.Dota2.CDOTAUserMsg\_MuertaReleaseEvent\_AssignedTargetKilled.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MuertaReleaseEvent_AssignedTargetKilled_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MuertaReleaseEvent_AssignedTargetKilled_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_MuertaReleaseEvent_AssignedTargetKilled_"></a> MergeFrom\(CDOTAUserMsg\_MuertaReleaseEvent\_AssignedTargetKilled\)

```csharp
public void MergeFrom(CDOTAUserMsg_MuertaReleaseEvent_AssignedTargetKilled other)
```

#### Parameters

`other` [CDOTAUserMsg\_MuertaReleaseEvent\_AssignedTargetKilled](Divine.Protobufs.Dota2.CDOTAUserMsg\_MuertaReleaseEvent\_AssignedTargetKilled.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MuertaReleaseEvent_AssignedTargetKilled_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MuertaReleaseEvent_AssignedTargetKilled_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MuertaReleaseEvent_AssignedTargetKilled_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

