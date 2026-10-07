# <a id="Divine_Protobufs_Dota2_CUserMessage_RemoteServerCommand"></a> Class CUserMessage\_RemoteServerCommand

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMessage_RemoteServerCommand : IMessage<CUserMessage_RemoteServerCommand>, IEquatable<CUserMessage_RemoteServerCommand>, IDeepCloneable<CUserMessage_RemoteServerCommand>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMessage\_RemoteServerCommand](Divine.Protobufs.Dota2.CUserMessage\_RemoteServerCommand.md)

#### Implements

IMessage<CUserMessage\_RemoteServerCommand\>, 
[IEquatable<CUserMessage\_RemoteServerCommand\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMessage\_RemoteServerCommand\>, 
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
[EnumerableExtensions.In<CUserMessage\_RemoteServerCommand\>\(CUserMessage\_RemoteServerCommand, params CUserMessage\_RemoteServerCommand\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMessage_RemoteServerCommand__ctor"></a> CUserMessage\_RemoteServerCommand\(\)

```csharp
public CUserMessage_RemoteServerCommand()
```

### <a id="Divine_Protobufs_Dota2_CUserMessage_RemoteServerCommand__ctor_Divine_Protobufs_Dota2_CUserMessage_RemoteServerCommand_"></a> CUserMessage\_RemoteServerCommand\(CUserMessage\_RemoteServerCommand\)

```csharp
public CUserMessage_RemoteServerCommand(CUserMessage_RemoteServerCommand other)
```

#### Parameters

`other` [CUserMessage\_RemoteServerCommand](Divine.Protobufs.Dota2.CUserMessage\_RemoteServerCommand.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMessage_RemoteServerCommand_CommandArgsFieldNumber"></a> CommandArgsFieldNumber

```csharp
public const int CommandArgsFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_RemoteServerCommand_CommandStrFieldNumber"></a> CommandStrFieldNumber

```csharp
public const int CommandStrFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_RemoteServerCommand_ConvarFieldNumber"></a> ConvarFieldNumber

```csharp
public const int ConvarFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_RemoteServerCommand_EcommandFieldNumber"></a> EcommandFieldNumber

```csharp
public const int EcommandFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_RemoteServerCommand_ValueFieldNumber"></a> ValueFieldNumber

```csharp
public const int ValueFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMessage_RemoteServerCommand_CommandArgs"></a> CommandArgs

```csharp
public string CommandArgs { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessage_RemoteServerCommand_CommandStr"></a> CommandStr

```csharp
public string CommandStr { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessage_RemoteServerCommand_Convar"></a> Convar

```csharp
public string Convar { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessage_RemoteServerCommand_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMessage_RemoteServerCommand_Ecommand"></a> Ecommand

```csharp
public CUserMessage_RemoteServerCommand.Types.ECommand Ecommand { get; set; }
```

#### Property Value

 [CUserMessage\_RemoteServerCommand](Divine.Protobufs.Dota2.CUserMessage\_RemoteServerCommand.md).[Types](Divine.Protobufs.Dota2.CUserMessage\_RemoteServerCommand.Types.md).[ECommand](Divine.Protobufs.Dota2.CUserMessage\_RemoteServerCommand.Types.ECommand.md)

### <a id="Divine_Protobufs_Dota2_CUserMessage_RemoteServerCommand_HasCommandArgs"></a> HasCommandArgs

```csharp
public bool HasCommandArgs { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_RemoteServerCommand_HasCommandStr"></a> HasCommandStr

```csharp
public bool HasCommandStr { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_RemoteServerCommand_HasConvar"></a> HasConvar

```csharp
public bool HasConvar { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_RemoteServerCommand_HasEcommand"></a> HasEcommand

```csharp
public bool HasEcommand { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_RemoteServerCommand_HasValue"></a> HasValue

```csharp
public bool HasValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_RemoteServerCommand_Parser"></a> Parser

```csharp
public static MessageParser<CUserMessage_RemoteServerCommand> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMessage\_RemoteServerCommand](Divine.Protobufs.Dota2.CUserMessage\_RemoteServerCommand.md)\>

### <a id="Divine_Protobufs_Dota2_CUserMessage_RemoteServerCommand_Value"></a> Value

```csharp
public string Value { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMessage_RemoteServerCommand_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_RemoteServerCommand_ClearCommandArgs"></a> ClearCommandArgs\(\)

```csharp
public void ClearCommandArgs()
```

### <a id="Divine_Protobufs_Dota2_CUserMessage_RemoteServerCommand_ClearCommandStr"></a> ClearCommandStr\(\)

```csharp
public void ClearCommandStr()
```

### <a id="Divine_Protobufs_Dota2_CUserMessage_RemoteServerCommand_ClearConvar"></a> ClearConvar\(\)

```csharp
public void ClearConvar()
```

### <a id="Divine_Protobufs_Dota2_CUserMessage_RemoteServerCommand_ClearEcommand"></a> ClearEcommand\(\)

```csharp
public void ClearEcommand()
```

### <a id="Divine_Protobufs_Dota2_CUserMessage_RemoteServerCommand_ClearValue"></a> ClearValue\(\)

```csharp
public void ClearValue()
```

### <a id="Divine_Protobufs_Dota2_CUserMessage_RemoteServerCommand_Clone"></a> Clone\(\)

```csharp
public CUserMessage_RemoteServerCommand Clone()
```

#### Returns

 [CUserMessage\_RemoteServerCommand](Divine.Protobufs.Dota2.CUserMessage\_RemoteServerCommand.md)

### <a id="Divine_Protobufs_Dota2_CUserMessage_RemoteServerCommand_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_RemoteServerCommand_Equals_Divine_Protobufs_Dota2_CUserMessage_RemoteServerCommand_"></a> Equals\(CUserMessage\_RemoteServerCommand\)

```csharp
public bool Equals(CUserMessage_RemoteServerCommand other)
```

#### Parameters

`other` [CUserMessage\_RemoteServerCommand](Divine.Protobufs.Dota2.CUserMessage\_RemoteServerCommand.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_RemoteServerCommand_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_RemoteServerCommand_MergeFrom_Divine_Protobufs_Dota2_CUserMessage_RemoteServerCommand_"></a> MergeFrom\(CUserMessage\_RemoteServerCommand\)

```csharp
public void MergeFrom(CUserMessage_RemoteServerCommand other)
```

#### Parameters

`other` [CUserMessage\_RemoteServerCommand](Divine.Protobufs.Dota2.CUserMessage\_RemoteServerCommand.md)

### <a id="Divine_Protobufs_Dota2_CUserMessage_RemoteServerCommand_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMessage_RemoteServerCommand_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessage_RemoteServerCommand_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

