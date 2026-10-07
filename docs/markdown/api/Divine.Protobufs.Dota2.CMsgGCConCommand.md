# <a id="Divine_Protobufs_Dota2_CMsgGCConCommand"></a> Class CMsgGCConCommand

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCConCommand : IMessage<CMsgGCConCommand>, IEquatable<CMsgGCConCommand>, IDeepCloneable<CMsgGCConCommand>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCConCommand](Divine.Protobufs.Dota2.CMsgGCConCommand.md)

#### Implements

IMessage<CMsgGCConCommand\>, 
[IEquatable<CMsgGCConCommand\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCConCommand\>, 
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
[EnumerableExtensions.In<CMsgGCConCommand\>\(CMsgGCConCommand, params CMsgGCConCommand\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCConCommand__ctor"></a> CMsgGCConCommand\(\)

```csharp
public CMsgGCConCommand()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCConCommand__ctor_Divine_Protobufs_Dota2_CMsgGCConCommand_"></a> CMsgGCConCommand\(CMsgGCConCommand\)

```csharp
public CMsgGCConCommand(CMsgGCConCommand other)
```

#### Parameters

`other` [CMsgGCConCommand](Divine.Protobufs.Dota2.CMsgGCConCommand.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCConCommand_CommandFieldNumber"></a> CommandFieldNumber

```csharp
public const int CommandFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCConCommand_Command"></a> Command

```csharp
public string Command { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCConCommand_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCConCommand_HasCommand"></a> HasCommand

```csharp
public bool HasCommand { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCConCommand_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCConCommand> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCConCommand](Divine.Protobufs.Dota2.CMsgGCConCommand.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCConCommand_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCConCommand_ClearCommand"></a> ClearCommand\(\)

```csharp
public void ClearCommand()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCConCommand_Clone"></a> Clone\(\)

```csharp
public CMsgGCConCommand Clone()
```

#### Returns

 [CMsgGCConCommand](Divine.Protobufs.Dota2.CMsgGCConCommand.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCConCommand_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCConCommand_Equals_Divine_Protobufs_Dota2_CMsgGCConCommand_"></a> Equals\(CMsgGCConCommand\)

```csharp
public bool Equals(CMsgGCConCommand other)
```

#### Parameters

`other` [CMsgGCConCommand](Divine.Protobufs.Dota2.CMsgGCConCommand.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCConCommand_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCConCommand_MergeFrom_Divine_Protobufs_Dota2_CMsgGCConCommand_"></a> MergeFrom\(CMsgGCConCommand\)

```csharp
public void MergeFrom(CMsgGCConCommand other)
```

#### Parameters

`other` [CMsgGCConCommand](Divine.Protobufs.Dota2.CMsgGCConCommand.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCConCommand_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCConCommand_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCConCommand_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

