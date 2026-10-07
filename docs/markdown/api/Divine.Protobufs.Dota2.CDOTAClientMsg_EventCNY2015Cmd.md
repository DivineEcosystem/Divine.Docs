# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EventCNY2015Cmd"></a> Class CDOTAClientMsg\_EventCNY2015Cmd

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_EventCNY2015Cmd : IMessage<CDOTAClientMsg_EventCNY2015Cmd>, IEquatable<CDOTAClientMsg_EventCNY2015Cmd>, IDeepCloneable<CDOTAClientMsg_EventCNY2015Cmd>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_EventCNY2015Cmd](Divine.Protobufs.Dota2.CDOTAClientMsg\_EventCNY2015Cmd.md)

#### Implements

IMessage<CDOTAClientMsg\_EventCNY2015Cmd\>, 
[IEquatable<CDOTAClientMsg\_EventCNY2015Cmd\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_EventCNY2015Cmd\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_EventCNY2015Cmd\>\(CDOTAClientMsg\_EventCNY2015Cmd, params CDOTAClientMsg\_EventCNY2015Cmd\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EventCNY2015Cmd__ctor"></a> CDOTAClientMsg\_EventCNY2015Cmd\(\)

```csharp
public CDOTAClientMsg_EventCNY2015Cmd()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EventCNY2015Cmd__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_EventCNY2015Cmd_"></a> CDOTAClientMsg\_EventCNY2015Cmd\(CDOTAClientMsg\_EventCNY2015Cmd\)

```csharp
public CDOTAClientMsg_EventCNY2015Cmd(CDOTAClientMsg_EventCNY2015Cmd other)
```

#### Parameters

`other` [CDOTAClientMsg\_EventCNY2015Cmd](Divine.Protobufs.Dota2.CDOTAClientMsg\_EventCNY2015Cmd.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EventCNY2015Cmd_DataFieldNumber"></a> DataFieldNumber

```csharp
public const int DataFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EventCNY2015Cmd_Data"></a> Data

```csharp
public ByteString Data { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EventCNY2015Cmd_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EventCNY2015Cmd_HasData"></a> HasData

```csharp
public bool HasData { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EventCNY2015Cmd_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_EventCNY2015Cmd> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_EventCNY2015Cmd](Divine.Protobufs.Dota2.CDOTAClientMsg\_EventCNY2015Cmd.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EventCNY2015Cmd_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EventCNY2015Cmd_ClearData"></a> ClearData\(\)

```csharp
public void ClearData()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EventCNY2015Cmd_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_EventCNY2015Cmd Clone()
```

#### Returns

 [CDOTAClientMsg\_EventCNY2015Cmd](Divine.Protobufs.Dota2.CDOTAClientMsg\_EventCNY2015Cmd.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EventCNY2015Cmd_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EventCNY2015Cmd_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_EventCNY2015Cmd_"></a> Equals\(CDOTAClientMsg\_EventCNY2015Cmd\)

```csharp
public bool Equals(CDOTAClientMsg_EventCNY2015Cmd other)
```

#### Parameters

`other` [CDOTAClientMsg\_EventCNY2015Cmd](Divine.Protobufs.Dota2.CDOTAClientMsg\_EventCNY2015Cmd.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EventCNY2015Cmd_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EventCNY2015Cmd_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_EventCNY2015Cmd_"></a> MergeFrom\(CDOTAClientMsg\_EventCNY2015Cmd\)

```csharp
public void MergeFrom(CDOTAClientMsg_EventCNY2015Cmd other)
```

#### Parameters

`other` [CDOTAClientMsg\_EventCNY2015Cmd](Divine.Protobufs.Dota2.CDOTAClientMsg\_EventCNY2015Cmd.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EventCNY2015Cmd_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EventCNY2015Cmd_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EventCNY2015Cmd_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

