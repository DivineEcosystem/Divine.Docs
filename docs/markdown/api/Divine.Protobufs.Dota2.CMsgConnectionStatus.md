# <a id="Divine_Protobufs_Dota2_CMsgConnectionStatus"></a> Class CMsgConnectionStatus

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgConnectionStatus : IMessage<CMsgConnectionStatus>, IEquatable<CMsgConnectionStatus>, IDeepCloneable<CMsgConnectionStatus>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgConnectionStatus](Divine.Protobufs.Dota2.CMsgConnectionStatus.md)

#### Implements

IMessage<CMsgConnectionStatus\>, 
[IEquatable<CMsgConnectionStatus\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgConnectionStatus\>, 
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
[EnumerableExtensions.In<CMsgConnectionStatus\>\(CMsgConnectionStatus, params CMsgConnectionStatus\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgConnectionStatus__ctor"></a> CMsgConnectionStatus\(\)

```csharp
public CMsgConnectionStatus()
```

### <a id="Divine_Protobufs_Dota2_CMsgConnectionStatus__ctor_Divine_Protobufs_Dota2_CMsgConnectionStatus_"></a> CMsgConnectionStatus\(CMsgConnectionStatus\)

```csharp
public CMsgConnectionStatus(CMsgConnectionStatus other)
```

#### Parameters

`other` [CMsgConnectionStatus](Divine.Protobufs.Dota2.CMsgConnectionStatus.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgConnectionStatus_ClientSessionNeedFieldNumber"></a> ClientSessionNeedFieldNumber

```csharp
public const int ClientSessionNeedFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgConnectionStatus_EstimatedWaitSecondsRemainingFieldNumber"></a> EstimatedWaitSecondsRemainingFieldNumber

```csharp
public const int EstimatedWaitSecondsRemainingFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgConnectionStatus_QueuePositionFieldNumber"></a> QueuePositionFieldNumber

```csharp
public const int QueuePositionFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgConnectionStatus_QueueSizeFieldNumber"></a> QueueSizeFieldNumber

```csharp
public const int QueueSizeFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgConnectionStatus_StatusFieldNumber"></a> StatusFieldNumber

```csharp
public const int StatusFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgConnectionStatus_WaitSecondsFieldNumber"></a> WaitSecondsFieldNumber

```csharp
public const int WaitSecondsFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgConnectionStatus_ClientSessionNeed"></a> ClientSessionNeed

```csharp
public uint ClientSessionNeed { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgConnectionStatus_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgConnectionStatus_EstimatedWaitSecondsRemaining"></a> EstimatedWaitSecondsRemaining

```csharp
public int EstimatedWaitSecondsRemaining { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgConnectionStatus_HasClientSessionNeed"></a> HasClientSessionNeed

```csharp
public bool HasClientSessionNeed { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgConnectionStatus_HasEstimatedWaitSecondsRemaining"></a> HasEstimatedWaitSecondsRemaining

```csharp
public bool HasEstimatedWaitSecondsRemaining { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgConnectionStatus_HasQueuePosition"></a> HasQueuePosition

```csharp
public bool HasQueuePosition { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgConnectionStatus_HasQueueSize"></a> HasQueueSize

```csharp
public bool HasQueueSize { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgConnectionStatus_HasStatus"></a> HasStatus

```csharp
public bool HasStatus { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgConnectionStatus_HasWaitSeconds"></a> HasWaitSeconds

```csharp
public bool HasWaitSeconds { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgConnectionStatus_Parser"></a> Parser

```csharp
public static MessageParser<CMsgConnectionStatus> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgConnectionStatus](Divine.Protobufs.Dota2.CMsgConnectionStatus.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgConnectionStatus_QueuePosition"></a> QueuePosition

```csharp
public int QueuePosition { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgConnectionStatus_QueueSize"></a> QueueSize

```csharp
public int QueueSize { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgConnectionStatus_Status"></a> Status

```csharp
public GCConnectionStatus Status { get; set; }
```

#### Property Value

 [GCConnectionStatus](Divine.Protobufs.Dota2.GCConnectionStatus.md)

### <a id="Divine_Protobufs_Dota2_CMsgConnectionStatus_WaitSeconds"></a> WaitSeconds

```csharp
public int WaitSeconds { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgConnectionStatus_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgConnectionStatus_ClearClientSessionNeed"></a> ClearClientSessionNeed\(\)

```csharp
public void ClearClientSessionNeed()
```

### <a id="Divine_Protobufs_Dota2_CMsgConnectionStatus_ClearEstimatedWaitSecondsRemaining"></a> ClearEstimatedWaitSecondsRemaining\(\)

```csharp
public void ClearEstimatedWaitSecondsRemaining()
```

### <a id="Divine_Protobufs_Dota2_CMsgConnectionStatus_ClearQueuePosition"></a> ClearQueuePosition\(\)

```csharp
public void ClearQueuePosition()
```

### <a id="Divine_Protobufs_Dota2_CMsgConnectionStatus_ClearQueueSize"></a> ClearQueueSize\(\)

```csharp
public void ClearQueueSize()
```

### <a id="Divine_Protobufs_Dota2_CMsgConnectionStatus_ClearStatus"></a> ClearStatus\(\)

```csharp
public void ClearStatus()
```

### <a id="Divine_Protobufs_Dota2_CMsgConnectionStatus_ClearWaitSeconds"></a> ClearWaitSeconds\(\)

```csharp
public void ClearWaitSeconds()
```

### <a id="Divine_Protobufs_Dota2_CMsgConnectionStatus_Clone"></a> Clone\(\)

```csharp
public CMsgConnectionStatus Clone()
```

#### Returns

 [CMsgConnectionStatus](Divine.Protobufs.Dota2.CMsgConnectionStatus.md)

### <a id="Divine_Protobufs_Dota2_CMsgConnectionStatus_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgConnectionStatus_Equals_Divine_Protobufs_Dota2_CMsgConnectionStatus_"></a> Equals\(CMsgConnectionStatus\)

```csharp
public bool Equals(CMsgConnectionStatus other)
```

#### Parameters

`other` [CMsgConnectionStatus](Divine.Protobufs.Dota2.CMsgConnectionStatus.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgConnectionStatus_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgConnectionStatus_MergeFrom_Divine_Protobufs_Dota2_CMsgConnectionStatus_"></a> MergeFrom\(CMsgConnectionStatus\)

```csharp
public void MergeFrom(CMsgConnectionStatus other)
```

#### Parameters

`other` [CMsgConnectionStatus](Divine.Protobufs.Dota2.CMsgConnectionStatus.md)

### <a id="Divine_Protobufs_Dota2_CMsgConnectionStatus_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgConnectionStatus_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgConnectionStatus_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

