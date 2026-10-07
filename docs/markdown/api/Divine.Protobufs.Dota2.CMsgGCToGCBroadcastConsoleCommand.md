# <a id="Divine_Protobufs_Dota2_CMsgGCToGCBroadcastConsoleCommand"></a> Class CMsgGCToGCBroadcastConsoleCommand

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToGCBroadcastConsoleCommand : IMessage<CMsgGCToGCBroadcastConsoleCommand>, IEquatable<CMsgGCToGCBroadcastConsoleCommand>, IDeepCloneable<CMsgGCToGCBroadcastConsoleCommand>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToGCBroadcastConsoleCommand](Divine.Protobufs.Dota2.CMsgGCToGCBroadcastConsoleCommand.md)

#### Implements

IMessage<CMsgGCToGCBroadcastConsoleCommand\>, 
[IEquatable<CMsgGCToGCBroadcastConsoleCommand\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToGCBroadcastConsoleCommand\>, 
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
[EnumerableExtensions.In<CMsgGCToGCBroadcastConsoleCommand\>\(CMsgGCToGCBroadcastConsoleCommand, params CMsgGCToGCBroadcastConsoleCommand\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBroadcastConsoleCommand__ctor"></a> CMsgGCToGCBroadcastConsoleCommand\(\)

```csharp
public CMsgGCToGCBroadcastConsoleCommand()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBroadcastConsoleCommand__ctor_Divine_Protobufs_Dota2_CMsgGCToGCBroadcastConsoleCommand_"></a> CMsgGCToGCBroadcastConsoleCommand\(CMsgGCToGCBroadcastConsoleCommand\)

```csharp
public CMsgGCToGCBroadcastConsoleCommand(CMsgGCToGCBroadcastConsoleCommand other)
```

#### Parameters

`other` [CMsgGCToGCBroadcastConsoleCommand](Divine.Protobufs.Dota2.CMsgGCToGCBroadcastConsoleCommand.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBroadcastConsoleCommand_ConCommandFieldNumber"></a> ConCommandFieldNumber

```csharp
public const int ConCommandFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBroadcastConsoleCommand_OutputInitiatorFieldNumber"></a> OutputInitiatorFieldNumber

```csharp
public const int OutputInitiatorFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBroadcastConsoleCommand_ReportOutputFieldNumber"></a> ReportOutputFieldNumber

```csharp
public const int ReportOutputFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBroadcastConsoleCommand_SenderSourceFieldNumber"></a> SenderSourceFieldNumber

```csharp
public const int SenderSourceFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBroadcastConsoleCommand_SendingGcFieldNumber"></a> SendingGcFieldNumber

```csharp
public const int SendingGcFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBroadcastConsoleCommand_ConCommand"></a> ConCommand

```csharp
public string ConCommand { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBroadcastConsoleCommand_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBroadcastConsoleCommand_HasConCommand"></a> HasConCommand

```csharp
public bool HasConCommand { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBroadcastConsoleCommand_HasOutputInitiator"></a> HasOutputInitiator

```csharp
public bool HasOutputInitiator { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBroadcastConsoleCommand_HasReportOutput"></a> HasReportOutput

```csharp
public bool HasReportOutput { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBroadcastConsoleCommand_HasSenderSource"></a> HasSenderSource

```csharp
public bool HasSenderSource { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBroadcastConsoleCommand_HasSendingGc"></a> HasSendingGc

```csharp
public bool HasSendingGc { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBroadcastConsoleCommand_OutputInitiator"></a> OutputInitiator

```csharp
public string OutputInitiator { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBroadcastConsoleCommand_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToGCBroadcastConsoleCommand> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToGCBroadcastConsoleCommand](Divine.Protobufs.Dota2.CMsgGCToGCBroadcastConsoleCommand.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBroadcastConsoleCommand_ReportOutput"></a> ReportOutput

```csharp
public bool ReportOutput { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBroadcastConsoleCommand_SenderSource"></a> SenderSource

```csharp
public string SenderSource { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBroadcastConsoleCommand_SendingGc"></a> SendingGc

```csharp
public int SendingGc { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBroadcastConsoleCommand_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBroadcastConsoleCommand_ClearConCommand"></a> ClearConCommand\(\)

```csharp
public void ClearConCommand()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBroadcastConsoleCommand_ClearOutputInitiator"></a> ClearOutputInitiator\(\)

```csharp
public void ClearOutputInitiator()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBroadcastConsoleCommand_ClearReportOutput"></a> ClearReportOutput\(\)

```csharp
public void ClearReportOutput()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBroadcastConsoleCommand_ClearSenderSource"></a> ClearSenderSource\(\)

```csharp
public void ClearSenderSource()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBroadcastConsoleCommand_ClearSendingGc"></a> ClearSendingGc\(\)

```csharp
public void ClearSendingGc()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBroadcastConsoleCommand_Clone"></a> Clone\(\)

```csharp
public CMsgGCToGCBroadcastConsoleCommand Clone()
```

#### Returns

 [CMsgGCToGCBroadcastConsoleCommand](Divine.Protobufs.Dota2.CMsgGCToGCBroadcastConsoleCommand.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBroadcastConsoleCommand_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBroadcastConsoleCommand_Equals_Divine_Protobufs_Dota2_CMsgGCToGCBroadcastConsoleCommand_"></a> Equals\(CMsgGCToGCBroadcastConsoleCommand\)

```csharp
public bool Equals(CMsgGCToGCBroadcastConsoleCommand other)
```

#### Parameters

`other` [CMsgGCToGCBroadcastConsoleCommand](Divine.Protobufs.Dota2.CMsgGCToGCBroadcastConsoleCommand.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBroadcastConsoleCommand_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBroadcastConsoleCommand_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToGCBroadcastConsoleCommand_"></a> MergeFrom\(CMsgGCToGCBroadcastConsoleCommand\)

```csharp
public void MergeFrom(CMsgGCToGCBroadcastConsoleCommand other)
```

#### Parameters

`other` [CMsgGCToGCBroadcastConsoleCommand](Divine.Protobufs.Dota2.CMsgGCToGCBroadcastConsoleCommand.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBroadcastConsoleCommand_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBroadcastConsoleCommand_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBroadcastConsoleCommand_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

