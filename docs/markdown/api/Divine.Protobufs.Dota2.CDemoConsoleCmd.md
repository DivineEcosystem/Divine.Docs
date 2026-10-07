# <a id="Divine_Protobufs_Dota2_CDemoConsoleCmd"></a> Class CDemoConsoleCmd

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDemoConsoleCmd : IMessage<CDemoConsoleCmd>, IEquatable<CDemoConsoleCmd>, IDeepCloneable<CDemoConsoleCmd>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDemoConsoleCmd](Divine.Protobufs.Dota2.CDemoConsoleCmd.md)

#### Implements

IMessage<CDemoConsoleCmd\>, 
[IEquatable<CDemoConsoleCmd\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDemoConsoleCmd\>, 
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
[EnumerableExtensions.In<CDemoConsoleCmd\>\(CDemoConsoleCmd, params CDemoConsoleCmd\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDemoConsoleCmd__ctor"></a> CDemoConsoleCmd\(\)

```csharp
public CDemoConsoleCmd()
```

### <a id="Divine_Protobufs_Dota2_CDemoConsoleCmd__ctor_Divine_Protobufs_Dota2_CDemoConsoleCmd_"></a> CDemoConsoleCmd\(CDemoConsoleCmd\)

```csharp
public CDemoConsoleCmd(CDemoConsoleCmd other)
```

#### Parameters

`other` [CDemoConsoleCmd](Divine.Protobufs.Dota2.CDemoConsoleCmd.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDemoConsoleCmd_CmdstringFieldNumber"></a> CmdstringFieldNumber

```csharp
public const int CmdstringFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDemoConsoleCmd_Cmdstring"></a> Cmdstring

```csharp
public string Cmdstring { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDemoConsoleCmd_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDemoConsoleCmd_HasCmdstring"></a> HasCmdstring

```csharp
public bool HasCmdstring { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDemoConsoleCmd_Parser"></a> Parser

```csharp
public static MessageParser<CDemoConsoleCmd> Parser { get; }
```

#### Property Value

 MessageParser<[CDemoConsoleCmd](Divine.Protobufs.Dota2.CDemoConsoleCmd.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDemoConsoleCmd_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDemoConsoleCmd_ClearCmdstring"></a> ClearCmdstring\(\)

```csharp
public void ClearCmdstring()
```

### <a id="Divine_Protobufs_Dota2_CDemoConsoleCmd_Clone"></a> Clone\(\)

```csharp
public CDemoConsoleCmd Clone()
```

#### Returns

 [CDemoConsoleCmd](Divine.Protobufs.Dota2.CDemoConsoleCmd.md)

### <a id="Divine_Protobufs_Dota2_CDemoConsoleCmd_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDemoConsoleCmd_Equals_Divine_Protobufs_Dota2_CDemoConsoleCmd_"></a> Equals\(CDemoConsoleCmd\)

```csharp
public bool Equals(CDemoConsoleCmd other)
```

#### Parameters

`other` [CDemoConsoleCmd](Divine.Protobufs.Dota2.CDemoConsoleCmd.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDemoConsoleCmd_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDemoConsoleCmd_MergeFrom_Divine_Protobufs_Dota2_CDemoConsoleCmd_"></a> MergeFrom\(CDemoConsoleCmd\)

```csharp
public void MergeFrom(CDemoConsoleCmd other)
```

#### Parameters

`other` [CDemoConsoleCmd](Divine.Protobufs.Dota2.CDemoConsoleCmd.md)

### <a id="Divine_Protobufs_Dota2_CDemoConsoleCmd_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDemoConsoleCmd_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDemoConsoleCmd_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

