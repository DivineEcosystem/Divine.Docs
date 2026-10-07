# <a id="Divine_Protobufs_Dota2_CDemoUserCmd"></a> Class CDemoUserCmd

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDemoUserCmd : IMessage<CDemoUserCmd>, IEquatable<CDemoUserCmd>, IDeepCloneable<CDemoUserCmd>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDemoUserCmd](Divine.Protobufs.Dota2.CDemoUserCmd.md)

#### Implements

IMessage<CDemoUserCmd\>, 
[IEquatable<CDemoUserCmd\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDemoUserCmd\>, 
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
[EnumerableExtensions.In<CDemoUserCmd\>\(CDemoUserCmd, params CDemoUserCmd\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDemoUserCmd__ctor"></a> CDemoUserCmd\(\)

```csharp
public CDemoUserCmd()
```

### <a id="Divine_Protobufs_Dota2_CDemoUserCmd__ctor_Divine_Protobufs_Dota2_CDemoUserCmd_"></a> CDemoUserCmd\(CDemoUserCmd\)

```csharp
public CDemoUserCmd(CDemoUserCmd other)
```

#### Parameters

`other` [CDemoUserCmd](Divine.Protobufs.Dota2.CDemoUserCmd.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDemoUserCmd_CmdNumberFieldNumber"></a> CmdNumberFieldNumber

```csharp
public const int CmdNumberFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDemoUserCmd_DataFieldNumber"></a> DataFieldNumber

```csharp
public const int DataFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDemoUserCmd_CmdNumber"></a> CmdNumber

```csharp
public int CmdNumber { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDemoUserCmd_Data"></a> Data

```csharp
public ByteString Data { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Dota2_CDemoUserCmd_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDemoUserCmd_HasCmdNumber"></a> HasCmdNumber

```csharp
public bool HasCmdNumber { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDemoUserCmd_HasData"></a> HasData

```csharp
public bool HasData { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDemoUserCmd_Parser"></a> Parser

```csharp
public static MessageParser<CDemoUserCmd> Parser { get; }
```

#### Property Value

 MessageParser<[CDemoUserCmd](Divine.Protobufs.Dota2.CDemoUserCmd.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDemoUserCmd_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDemoUserCmd_ClearCmdNumber"></a> ClearCmdNumber\(\)

```csharp
public void ClearCmdNumber()
```

### <a id="Divine_Protobufs_Dota2_CDemoUserCmd_ClearData"></a> ClearData\(\)

```csharp
public void ClearData()
```

### <a id="Divine_Protobufs_Dota2_CDemoUserCmd_Clone"></a> Clone\(\)

```csharp
public CDemoUserCmd Clone()
```

#### Returns

 [CDemoUserCmd](Divine.Protobufs.Dota2.CDemoUserCmd.md)

### <a id="Divine_Protobufs_Dota2_CDemoUserCmd_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDemoUserCmd_Equals_Divine_Protobufs_Dota2_CDemoUserCmd_"></a> Equals\(CDemoUserCmd\)

```csharp
public bool Equals(CDemoUserCmd other)
```

#### Parameters

`other` [CDemoUserCmd](Divine.Protobufs.Dota2.CDemoUserCmd.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDemoUserCmd_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDemoUserCmd_MergeFrom_Divine_Protobufs_Dota2_CDemoUserCmd_"></a> MergeFrom\(CDemoUserCmd\)

```csharp
public void MergeFrom(CDemoUserCmd other)
```

#### Parameters

`other` [CDemoUserCmd](Divine.Protobufs.Dota2.CDemoUserCmd.md)

### <a id="Divine_Protobufs_Dota2_CDemoUserCmd_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDemoUserCmd_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDemoUserCmd_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

