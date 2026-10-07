# <a id="Divine_Protobufs_Dota2_CPredictionEvent_StringCommand"></a> Class CPredictionEvent\_StringCommand

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CPredictionEvent_StringCommand : IMessage<CPredictionEvent_StringCommand>, IEquatable<CPredictionEvent_StringCommand>, IDeepCloneable<CPredictionEvent_StringCommand>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CPredictionEvent\_StringCommand](Divine.Protobufs.Dota2.CPredictionEvent\_StringCommand.md)

#### Implements

IMessage<CPredictionEvent\_StringCommand\>, 
[IEquatable<CPredictionEvent\_StringCommand\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CPredictionEvent\_StringCommand\>, 
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
[EnumerableExtensions.In<CPredictionEvent\_StringCommand\>\(CPredictionEvent\_StringCommand, params CPredictionEvent\_StringCommand\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CPredictionEvent_StringCommand__ctor"></a> CPredictionEvent\_StringCommand\(\)

```csharp
public CPredictionEvent_StringCommand()
```

### <a id="Divine_Protobufs_Dota2_CPredictionEvent_StringCommand__ctor_Divine_Protobufs_Dota2_CPredictionEvent_StringCommand_"></a> CPredictionEvent\_StringCommand\(CPredictionEvent\_StringCommand\)

```csharp
public CPredictionEvent_StringCommand(CPredictionEvent_StringCommand other)
```

#### Parameters

`other` [CPredictionEvent\_StringCommand](Divine.Protobufs.Dota2.CPredictionEvent\_StringCommand.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CPredictionEvent_StringCommand_CommandFieldNumber"></a> CommandFieldNumber

```csharp
public const int CommandFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CPredictionEvent_StringCommand_Command"></a> Command

```csharp
public string Command { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CPredictionEvent_StringCommand_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CPredictionEvent_StringCommand_HasCommand"></a> HasCommand

```csharp
public bool HasCommand { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CPredictionEvent_StringCommand_Parser"></a> Parser

```csharp
public static MessageParser<CPredictionEvent_StringCommand> Parser { get; }
```

#### Property Value

 MessageParser<[CPredictionEvent\_StringCommand](Divine.Protobufs.Dota2.CPredictionEvent\_StringCommand.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CPredictionEvent_StringCommand_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CPredictionEvent_StringCommand_ClearCommand"></a> ClearCommand\(\)

```csharp
public void ClearCommand()
```

### <a id="Divine_Protobufs_Dota2_CPredictionEvent_StringCommand_Clone"></a> Clone\(\)

```csharp
public CPredictionEvent_StringCommand Clone()
```

#### Returns

 [CPredictionEvent\_StringCommand](Divine.Protobufs.Dota2.CPredictionEvent\_StringCommand.md)

### <a id="Divine_Protobufs_Dota2_CPredictionEvent_StringCommand_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CPredictionEvent_StringCommand_Equals_Divine_Protobufs_Dota2_CPredictionEvent_StringCommand_"></a> Equals\(CPredictionEvent\_StringCommand\)

```csharp
public bool Equals(CPredictionEvent_StringCommand other)
```

#### Parameters

`other` [CPredictionEvent\_StringCommand](Divine.Protobufs.Dota2.CPredictionEvent\_StringCommand.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CPredictionEvent_StringCommand_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CPredictionEvent_StringCommand_MergeFrom_Divine_Protobufs_Dota2_CPredictionEvent_StringCommand_"></a> MergeFrom\(CPredictionEvent\_StringCommand\)

```csharp
public void MergeFrom(CPredictionEvent_StringCommand other)
```

#### Parameters

`other` [CPredictionEvent\_StringCommand](Divine.Protobufs.Dota2.CPredictionEvent\_StringCommand.md)

### <a id="Divine_Protobufs_Dota2_CPredictionEvent_StringCommand_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CPredictionEvent_StringCommand_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CPredictionEvent_StringCommand_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

