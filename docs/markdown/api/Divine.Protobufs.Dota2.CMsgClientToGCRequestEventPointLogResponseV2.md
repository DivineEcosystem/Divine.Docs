# <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogResponseV2"></a> Class CMsgClientToGCRequestEventPointLogResponseV2

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCRequestEventPointLogResponseV2 : IMessage<CMsgClientToGCRequestEventPointLogResponseV2>, IEquatable<CMsgClientToGCRequestEventPointLogResponseV2>, IDeepCloneable<CMsgClientToGCRequestEventPointLogResponseV2>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCRequestEventPointLogResponseV2](Divine.Protobufs.Dota2.CMsgClientToGCRequestEventPointLogResponseV2.md)

#### Implements

IMessage<CMsgClientToGCRequestEventPointLogResponseV2\>, 
[IEquatable<CMsgClientToGCRequestEventPointLogResponseV2\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCRequestEventPointLogResponseV2\>, 
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
[EnumerableExtensions.In<CMsgClientToGCRequestEventPointLogResponseV2\>\(CMsgClientToGCRequestEventPointLogResponseV2, params CMsgClientToGCRequestEventPointLogResponseV2\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogResponseV2__ctor"></a> CMsgClientToGCRequestEventPointLogResponseV2\(\)

```csharp
public CMsgClientToGCRequestEventPointLogResponseV2()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogResponseV2__ctor_Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogResponseV2_"></a> CMsgClientToGCRequestEventPointLogResponseV2\(CMsgClientToGCRequestEventPointLogResponseV2\)

```csharp
public CMsgClientToGCRequestEventPointLogResponseV2(CMsgClientToGCRequestEventPointLogResponseV2 other)
```

#### Parameters

`other` [CMsgClientToGCRequestEventPointLogResponseV2](Divine.Protobufs.Dota2.CMsgClientToGCRequestEventPointLogResponseV2.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogResponseV2_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogResponseV2_LogEntriesFieldNumber"></a> LogEntriesFieldNumber

```csharp
public const int LogEntriesFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogResponseV2_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogResponseV2_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogResponseV2_EventId"></a> EventId

```csharp
public EEvent EventId { get; set; }
```

#### Property Value

 [EEvent](Divine.Protobufs.Dota2.EEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogResponseV2_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogResponseV2_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogResponseV2_LogEntries"></a> LogEntries

```csharp
public RepeatedField<CMsgClientToGCRequestEventPointLogResponseV2.Types.LogEntry> LogEntries { get; }
```

#### Property Value

 RepeatedField<[CMsgClientToGCRequestEventPointLogResponseV2](Divine.Protobufs.Dota2.CMsgClientToGCRequestEventPointLogResponseV2.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCRequestEventPointLogResponseV2.Types.md).[LogEntry](Divine.Protobufs.Dota2.CMsgClientToGCRequestEventPointLogResponseV2.Types.LogEntry.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogResponseV2_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCRequestEventPointLogResponseV2> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCRequestEventPointLogResponseV2](Divine.Protobufs.Dota2.CMsgClientToGCRequestEventPointLogResponseV2.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogResponseV2_Result"></a> Result

```csharp
public bool Result { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogResponseV2_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogResponseV2_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogResponseV2_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogResponseV2_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCRequestEventPointLogResponseV2 Clone()
```

#### Returns

 [CMsgClientToGCRequestEventPointLogResponseV2](Divine.Protobufs.Dota2.CMsgClientToGCRequestEventPointLogResponseV2.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogResponseV2_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogResponseV2_Equals_Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogResponseV2_"></a> Equals\(CMsgClientToGCRequestEventPointLogResponseV2\)

```csharp
public bool Equals(CMsgClientToGCRequestEventPointLogResponseV2 other)
```

#### Parameters

`other` [CMsgClientToGCRequestEventPointLogResponseV2](Divine.Protobufs.Dota2.CMsgClientToGCRequestEventPointLogResponseV2.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogResponseV2_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogResponseV2_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogResponseV2_"></a> MergeFrom\(CMsgClientToGCRequestEventPointLogResponseV2\)

```csharp
public void MergeFrom(CMsgClientToGCRequestEventPointLogResponseV2 other)
```

#### Parameters

`other` [CMsgClientToGCRequestEventPointLogResponseV2](Divine.Protobufs.Dota2.CMsgClientToGCRequestEventPointLogResponseV2.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogResponseV2_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogResponseV2_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogResponseV2_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

