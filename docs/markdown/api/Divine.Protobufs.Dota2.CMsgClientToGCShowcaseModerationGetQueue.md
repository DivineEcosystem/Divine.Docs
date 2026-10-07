# <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationGetQueue"></a> Class CMsgClientToGCShowcaseModerationGetQueue

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCShowcaseModerationGetQueue : IMessage<CMsgClientToGCShowcaseModerationGetQueue>, IEquatable<CMsgClientToGCShowcaseModerationGetQueue>, IDeepCloneable<CMsgClientToGCShowcaseModerationGetQueue>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCShowcaseModerationGetQueue](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseModerationGetQueue.md)

#### Implements

IMessage<CMsgClientToGCShowcaseModerationGetQueue\>, 
[IEquatable<CMsgClientToGCShowcaseModerationGetQueue\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCShowcaseModerationGetQueue\>, 
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
[EnumerableExtensions.In<CMsgClientToGCShowcaseModerationGetQueue\>\(CMsgClientToGCShowcaseModerationGetQueue, params CMsgClientToGCShowcaseModerationGetQueue\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationGetQueue__ctor"></a> CMsgClientToGCShowcaseModerationGetQueue\(\)

```csharp
public CMsgClientToGCShowcaseModerationGetQueue()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationGetQueue__ctor_Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationGetQueue_"></a> CMsgClientToGCShowcaseModerationGetQueue\(CMsgClientToGCShowcaseModerationGetQueue\)

```csharp
public CMsgClientToGCShowcaseModerationGetQueue(CMsgClientToGCShowcaseModerationGetQueue other)
```

#### Parameters

`other` [CMsgClientToGCShowcaseModerationGetQueue](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseModerationGetQueue.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationGetQueue_ResultCountFieldNumber"></a> ResultCountFieldNumber

```csharp
public const int ResultCountFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationGetQueue_StartTimestampFieldNumber"></a> StartTimestampFieldNumber

```csharp
public const int StartTimestampFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationGetQueue_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationGetQueue_HasResultCount"></a> HasResultCount

```csharp
public bool HasResultCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationGetQueue_HasStartTimestamp"></a> HasStartTimestamp

```csharp
public bool HasStartTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationGetQueue_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCShowcaseModerationGetQueue> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCShowcaseModerationGetQueue](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseModerationGetQueue.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationGetQueue_ResultCount"></a> ResultCount

```csharp
public uint ResultCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationGetQueue_StartTimestamp"></a> StartTimestamp

```csharp
public uint StartTimestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationGetQueue_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationGetQueue_ClearResultCount"></a> ClearResultCount\(\)

```csharp
public void ClearResultCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationGetQueue_ClearStartTimestamp"></a> ClearStartTimestamp\(\)

```csharp
public void ClearStartTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationGetQueue_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCShowcaseModerationGetQueue Clone()
```

#### Returns

 [CMsgClientToGCShowcaseModerationGetQueue](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseModerationGetQueue.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationGetQueue_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationGetQueue_Equals_Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationGetQueue_"></a> Equals\(CMsgClientToGCShowcaseModerationGetQueue\)

```csharp
public bool Equals(CMsgClientToGCShowcaseModerationGetQueue other)
```

#### Parameters

`other` [CMsgClientToGCShowcaseModerationGetQueue](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseModerationGetQueue.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationGetQueue_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationGetQueue_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationGetQueue_"></a> MergeFrom\(CMsgClientToGCShowcaseModerationGetQueue\)

```csharp
public void MergeFrom(CMsgClientToGCShowcaseModerationGetQueue other)
```

#### Parameters

`other` [CMsgClientToGCShowcaseModerationGetQueue](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseModerationGetQueue.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationGetQueue_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationGetQueue_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationGetQueue_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

