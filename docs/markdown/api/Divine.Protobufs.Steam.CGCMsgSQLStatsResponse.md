# <a id="Divine_Protobufs_Steam_CGCMsgSQLStatsResponse"></a> Class CGCMsgSQLStatsResponse

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CGCMsgSQLStatsResponse : IMessage<CGCMsgSQLStatsResponse>, IEquatable<CGCMsgSQLStatsResponse>, IDeepCloneable<CGCMsgSQLStatsResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CGCMsgSQLStatsResponse](Divine.Protobufs.Steam.CGCMsgSQLStatsResponse.md)

#### Implements

IMessage<CGCMsgSQLStatsResponse\>, 
[IEquatable<CGCMsgSQLStatsResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CGCMsgSQLStatsResponse\>, 
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
[EnumerableExtensions.In<CGCMsgSQLStatsResponse\>\(CGCMsgSQLStatsResponse, params CGCMsgSQLStatsResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CGCMsgSQLStatsResponse__ctor"></a> CGCMsgSQLStatsResponse\(\)

```csharp
public CGCMsgSQLStatsResponse()
```

### <a id="Divine_Protobufs_Steam_CGCMsgSQLStatsResponse__ctor_Divine_Protobufs_Steam_CGCMsgSQLStatsResponse_"></a> CGCMsgSQLStatsResponse\(CGCMsgSQLStatsResponse\)

```csharp
public CGCMsgSQLStatsResponse(CGCMsgSQLStatsResponse other)
```

#### Parameters

`other` [CGCMsgSQLStatsResponse](Divine.Protobufs.Steam.CGCMsgSQLStatsResponse.md)

## Fields

### <a id="Divine_Protobufs_Steam_CGCMsgSQLStatsResponse_DeadlockRetriesFieldNumber"></a> DeadlockRetriesFieldNumber

```csharp
public const int DeadlockRetriesFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCMsgSQLStatsResponse_ErrorsFieldNumber"></a> ErrorsFieldNumber

```csharp
public const int ErrorsFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCMsgSQLStatsResponse_NonPreparedStatementsExecutedFieldNumber"></a> NonPreparedStatementsExecutedFieldNumber

```csharp
public const int NonPreparedStatementsExecutedFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCMsgSQLStatsResponse_OperationsSubmittedFieldNumber"></a> OperationsSubmittedFieldNumber

```csharp
public const int OperationsSubmittedFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCMsgSQLStatsResponse_OperationsTimedOutInQueueFieldNumber"></a> OperationsTimedOutInQueueFieldNumber

```csharp
public const int OperationsTimedOutInQueueFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCMsgSQLStatsResponse_PreparedStatementsExecutedFieldNumber"></a> PreparedStatementsExecutedFieldNumber

```csharp
public const int PreparedStatementsExecutedFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCMsgSQLStatsResponse_ThreadsActiveFieldNumber"></a> ThreadsActiveFieldNumber

```csharp
public const int ThreadsActiveFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCMsgSQLStatsResponse_ThreadsConnectedFieldNumber"></a> ThreadsConnectedFieldNumber

```csharp
public const int ThreadsConnectedFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCMsgSQLStatsResponse_ThreadsFieldNumber"></a> ThreadsFieldNumber

```csharp
public const int ThreadsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CGCMsgSQLStatsResponse_DeadlockRetries"></a> DeadlockRetries

```csharp
public uint DeadlockRetries { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CGCMsgSQLStatsResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CGCMsgSQLStatsResponse_Errors"></a> Errors

```csharp
public uint Errors { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CGCMsgSQLStatsResponse_HasDeadlockRetries"></a> HasDeadlockRetries

```csharp
public bool HasDeadlockRetries { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCMsgSQLStatsResponse_HasErrors"></a> HasErrors

```csharp
public bool HasErrors { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCMsgSQLStatsResponse_HasNonPreparedStatementsExecuted"></a> HasNonPreparedStatementsExecuted

```csharp
public bool HasNonPreparedStatementsExecuted { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCMsgSQLStatsResponse_HasOperationsSubmitted"></a> HasOperationsSubmitted

```csharp
public bool HasOperationsSubmitted { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCMsgSQLStatsResponse_HasOperationsTimedOutInQueue"></a> HasOperationsTimedOutInQueue

```csharp
public bool HasOperationsTimedOutInQueue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCMsgSQLStatsResponse_HasPreparedStatementsExecuted"></a> HasPreparedStatementsExecuted

```csharp
public bool HasPreparedStatementsExecuted { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCMsgSQLStatsResponse_HasThreads"></a> HasThreads

```csharp
public bool HasThreads { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCMsgSQLStatsResponse_HasThreadsActive"></a> HasThreadsActive

```csharp
public bool HasThreadsActive { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCMsgSQLStatsResponse_HasThreadsConnected"></a> HasThreadsConnected

```csharp
public bool HasThreadsConnected { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCMsgSQLStatsResponse_NonPreparedStatementsExecuted"></a> NonPreparedStatementsExecuted

```csharp
public uint NonPreparedStatementsExecuted { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CGCMsgSQLStatsResponse_OperationsSubmitted"></a> OperationsSubmitted

```csharp
public uint OperationsSubmitted { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CGCMsgSQLStatsResponse_OperationsTimedOutInQueue"></a> OperationsTimedOutInQueue

```csharp
public uint OperationsTimedOutInQueue { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CGCMsgSQLStatsResponse_Parser"></a> Parser

```csharp
public static MessageParser<CGCMsgSQLStatsResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CGCMsgSQLStatsResponse](Divine.Protobufs.Steam.CGCMsgSQLStatsResponse.md)\>

### <a id="Divine_Protobufs_Steam_CGCMsgSQLStatsResponse_PreparedStatementsExecuted"></a> PreparedStatementsExecuted

```csharp
public uint PreparedStatementsExecuted { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CGCMsgSQLStatsResponse_Threads"></a> Threads

```csharp
public uint Threads { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CGCMsgSQLStatsResponse_ThreadsActive"></a> ThreadsActive

```csharp
public uint ThreadsActive { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CGCMsgSQLStatsResponse_ThreadsConnected"></a> ThreadsConnected

```csharp
public uint ThreadsConnected { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Steam_CGCMsgSQLStatsResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCMsgSQLStatsResponse_ClearDeadlockRetries"></a> ClearDeadlockRetries\(\)

```csharp
public void ClearDeadlockRetries()
```

### <a id="Divine_Protobufs_Steam_CGCMsgSQLStatsResponse_ClearErrors"></a> ClearErrors\(\)

```csharp
public void ClearErrors()
```

### <a id="Divine_Protobufs_Steam_CGCMsgSQLStatsResponse_ClearNonPreparedStatementsExecuted"></a> ClearNonPreparedStatementsExecuted\(\)

```csharp
public void ClearNonPreparedStatementsExecuted()
```

### <a id="Divine_Protobufs_Steam_CGCMsgSQLStatsResponse_ClearOperationsSubmitted"></a> ClearOperationsSubmitted\(\)

```csharp
public void ClearOperationsSubmitted()
```

### <a id="Divine_Protobufs_Steam_CGCMsgSQLStatsResponse_ClearOperationsTimedOutInQueue"></a> ClearOperationsTimedOutInQueue\(\)

```csharp
public void ClearOperationsTimedOutInQueue()
```

### <a id="Divine_Protobufs_Steam_CGCMsgSQLStatsResponse_ClearPreparedStatementsExecuted"></a> ClearPreparedStatementsExecuted\(\)

```csharp
public void ClearPreparedStatementsExecuted()
```

### <a id="Divine_Protobufs_Steam_CGCMsgSQLStatsResponse_ClearThreads"></a> ClearThreads\(\)

```csharp
public void ClearThreads()
```

### <a id="Divine_Protobufs_Steam_CGCMsgSQLStatsResponse_ClearThreadsActive"></a> ClearThreadsActive\(\)

```csharp
public void ClearThreadsActive()
```

### <a id="Divine_Protobufs_Steam_CGCMsgSQLStatsResponse_ClearThreadsConnected"></a> ClearThreadsConnected\(\)

```csharp
public void ClearThreadsConnected()
```

### <a id="Divine_Protobufs_Steam_CGCMsgSQLStatsResponse_Clone"></a> Clone\(\)

```csharp
public CGCMsgSQLStatsResponse Clone()
```

#### Returns

 [CGCMsgSQLStatsResponse](Divine.Protobufs.Steam.CGCMsgSQLStatsResponse.md)

### <a id="Divine_Protobufs_Steam_CGCMsgSQLStatsResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCMsgSQLStatsResponse_Equals_Divine_Protobufs_Steam_CGCMsgSQLStatsResponse_"></a> Equals\(CGCMsgSQLStatsResponse\)

```csharp
public bool Equals(CGCMsgSQLStatsResponse other)
```

#### Parameters

`other` [CGCMsgSQLStatsResponse](Divine.Protobufs.Steam.CGCMsgSQLStatsResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCMsgSQLStatsResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCMsgSQLStatsResponse_MergeFrom_Divine_Protobufs_Steam_CGCMsgSQLStatsResponse_"></a> MergeFrom\(CGCMsgSQLStatsResponse\)

```csharp
public void MergeFrom(CGCMsgSQLStatsResponse other)
```

#### Parameters

`other` [CGCMsgSQLStatsResponse](Divine.Protobufs.Steam.CGCMsgSQLStatsResponse.md)

### <a id="Divine_Protobufs_Steam_CGCMsgSQLStatsResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CGCMsgSQLStatsResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CGCMsgSQLStatsResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

