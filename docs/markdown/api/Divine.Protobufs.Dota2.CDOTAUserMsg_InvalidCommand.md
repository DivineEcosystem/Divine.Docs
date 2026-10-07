# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_InvalidCommand"></a> Class CDOTAUserMsg\_InvalidCommand

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_InvalidCommand : IMessage<CDOTAUserMsg_InvalidCommand>, IEquatable<CDOTAUserMsg_InvalidCommand>, IDeepCloneable<CDOTAUserMsg_InvalidCommand>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_InvalidCommand](Divine.Protobufs.Dota2.CDOTAUserMsg\_InvalidCommand.md)

#### Implements

IMessage<CDOTAUserMsg\_InvalidCommand\>, 
[IEquatable<CDOTAUserMsg\_InvalidCommand\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_InvalidCommand\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_InvalidCommand\>\(CDOTAUserMsg\_InvalidCommand, params CDOTAUserMsg\_InvalidCommand\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_InvalidCommand__ctor"></a> CDOTAUserMsg\_InvalidCommand\(\)

```csharp
public CDOTAUserMsg_InvalidCommand()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_InvalidCommand__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_InvalidCommand_"></a> CDOTAUserMsg\_InvalidCommand\(CDOTAUserMsg\_InvalidCommand\)

```csharp
public CDOTAUserMsg_InvalidCommand(CDOTAUserMsg_InvalidCommand other)
```

#### Parameters

`other` [CDOTAUserMsg\_InvalidCommand](Divine.Protobufs.Dota2.CDOTAUserMsg\_InvalidCommand.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_InvalidCommand_MessageFieldNumber"></a> MessageFieldNumber

```csharp
public const int MessageFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_InvalidCommand_SequenceNumberFieldNumber"></a> SequenceNumberFieldNumber

```csharp
public const int SequenceNumberFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_InvalidCommand_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_InvalidCommand_HasMessage"></a> HasMessage

```csharp
public bool HasMessage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_InvalidCommand_HasSequenceNumber"></a> HasSequenceNumber

```csharp
public bool HasSequenceNumber { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_InvalidCommand_Message"></a> Message

```csharp
public string Message { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_InvalidCommand_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_InvalidCommand> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_InvalidCommand](Divine.Protobufs.Dota2.CDOTAUserMsg\_InvalidCommand.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_InvalidCommand_SequenceNumber"></a> SequenceNumber

```csharp
public int SequenceNumber { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_InvalidCommand_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_InvalidCommand_ClearMessage"></a> ClearMessage\(\)

```csharp
public void ClearMessage()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_InvalidCommand_ClearSequenceNumber"></a> ClearSequenceNumber\(\)

```csharp
public void ClearSequenceNumber()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_InvalidCommand_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_InvalidCommand Clone()
```

#### Returns

 [CDOTAUserMsg\_InvalidCommand](Divine.Protobufs.Dota2.CDOTAUserMsg\_InvalidCommand.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_InvalidCommand_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_InvalidCommand_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_InvalidCommand_"></a> Equals\(CDOTAUserMsg\_InvalidCommand\)

```csharp
public bool Equals(CDOTAUserMsg_InvalidCommand other)
```

#### Parameters

`other` [CDOTAUserMsg\_InvalidCommand](Divine.Protobufs.Dota2.CDOTAUserMsg\_InvalidCommand.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_InvalidCommand_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_InvalidCommand_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_InvalidCommand_"></a> MergeFrom\(CDOTAUserMsg\_InvalidCommand\)

```csharp
public void MergeFrom(CDOTAUserMsg_InvalidCommand other)
```

#### Parameters

`other` [CDOTAUserMsg\_InvalidCommand](Divine.Protobufs.Dota2.CDOTAUserMsg\_InvalidCommand.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_InvalidCommand_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_InvalidCommand_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_InvalidCommand_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

