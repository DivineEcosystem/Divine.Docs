# <a id="Divine_Protobufs_Dota2_CSVCMsg_Broadcast_Command"></a> Class CSVCMsg\_Broadcast\_Command

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSVCMsg_Broadcast_Command : IMessage<CSVCMsg_Broadcast_Command>, IEquatable<CSVCMsg_Broadcast_Command>, IDeepCloneable<CSVCMsg_Broadcast_Command>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSVCMsg\_Broadcast\_Command](Divine.Protobufs.Dota2.CSVCMsg\_Broadcast\_Command.md)

#### Implements

IMessage<CSVCMsg\_Broadcast\_Command\>, 
[IEquatable<CSVCMsg\_Broadcast\_Command\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSVCMsg\_Broadcast\_Command\>, 
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
[EnumerableExtensions.In<CSVCMsg\_Broadcast\_Command\>\(CSVCMsg\_Broadcast\_Command, params CSVCMsg\_Broadcast\_Command\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Broadcast_Command__ctor"></a> CSVCMsg\_Broadcast\_Command\(\)

```csharp
public CSVCMsg_Broadcast_Command()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Broadcast_Command__ctor_Divine_Protobufs_Dota2_CSVCMsg_Broadcast_Command_"></a> CSVCMsg\_Broadcast\_Command\(CSVCMsg\_Broadcast\_Command\)

```csharp
public CSVCMsg_Broadcast_Command(CSVCMsg_Broadcast_Command other)
```

#### Parameters

`other` [CSVCMsg\_Broadcast\_Command](Divine.Protobufs.Dota2.CSVCMsg\_Broadcast\_Command.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Broadcast_Command_CmdFieldNumber"></a> CmdFieldNumber

```csharp
public const int CmdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Broadcast_Command_Cmd"></a> Cmd

```csharp
public string Cmd { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Broadcast_Command_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Broadcast_Command_HasCmd"></a> HasCmd

```csharp
public bool HasCmd { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Broadcast_Command_Parser"></a> Parser

```csharp
public static MessageParser<CSVCMsg_Broadcast_Command> Parser { get; }
```

#### Property Value

 MessageParser<[CSVCMsg\_Broadcast\_Command](Divine.Protobufs.Dota2.CSVCMsg\_Broadcast\_Command.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Broadcast_Command_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Broadcast_Command_ClearCmd"></a> ClearCmd\(\)

```csharp
public void ClearCmd()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Broadcast_Command_Clone"></a> Clone\(\)

```csharp
public CSVCMsg_Broadcast_Command Clone()
```

#### Returns

 [CSVCMsg\_Broadcast\_Command](Divine.Protobufs.Dota2.CSVCMsg\_Broadcast\_Command.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Broadcast_Command_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Broadcast_Command_Equals_Divine_Protobufs_Dota2_CSVCMsg_Broadcast_Command_"></a> Equals\(CSVCMsg\_Broadcast\_Command\)

```csharp
public bool Equals(CSVCMsg_Broadcast_Command other)
```

#### Parameters

`other` [CSVCMsg\_Broadcast\_Command](Divine.Protobufs.Dota2.CSVCMsg\_Broadcast\_Command.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Broadcast_Command_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Broadcast_Command_MergeFrom_Divine_Protobufs_Dota2_CSVCMsg_Broadcast_Command_"></a> MergeFrom\(CSVCMsg\_Broadcast\_Command\)

```csharp
public void MergeFrom(CSVCMsg_Broadcast_Command other)
```

#### Parameters

`other` [CSVCMsg\_Broadcast\_Command](Divine.Protobufs.Dota2.CSVCMsg\_Broadcast\_Command.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Broadcast_Command_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Broadcast_Command_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Broadcast_Command_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

