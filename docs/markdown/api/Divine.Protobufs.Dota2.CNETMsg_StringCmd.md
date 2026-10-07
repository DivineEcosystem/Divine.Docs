# <a id="Divine_Protobufs_Dota2_CNETMsg_StringCmd"></a> Class CNETMsg\_StringCmd

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CNETMsg_StringCmd : IMessage<CNETMsg_StringCmd>, IEquatable<CNETMsg_StringCmd>, IDeepCloneable<CNETMsg_StringCmd>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CNETMsg\_StringCmd](Divine.Protobufs.Dota2.CNETMsg\_StringCmd.md)

#### Implements

IMessage<CNETMsg\_StringCmd\>, 
[IEquatable<CNETMsg\_StringCmd\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CNETMsg\_StringCmd\>, 
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
[EnumerableExtensions.In<CNETMsg\_StringCmd\>\(CNETMsg\_StringCmd, params CNETMsg\_StringCmd\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CNETMsg_StringCmd__ctor"></a> CNETMsg\_StringCmd\(\)

```csharp
public CNETMsg_StringCmd()
```

### <a id="Divine_Protobufs_Dota2_CNETMsg_StringCmd__ctor_Divine_Protobufs_Dota2_CNETMsg_StringCmd_"></a> CNETMsg\_StringCmd\(CNETMsg\_StringCmd\)

```csharp
public CNETMsg_StringCmd(CNETMsg_StringCmd other)
```

#### Parameters

`other` [CNETMsg\_StringCmd](Divine.Protobufs.Dota2.CNETMsg\_StringCmd.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CNETMsg_StringCmd_CommandFieldNumber"></a> CommandFieldNumber

```csharp
public const int CommandFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_StringCmd_PredictionSyncFieldNumber"></a> PredictionSyncFieldNumber

```csharp
public const int PredictionSyncFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CNETMsg_StringCmd_Command"></a> Command

```csharp
public string Command { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CNETMsg_StringCmd_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CNETMsg_StringCmd_HasCommand"></a> HasCommand

```csharp
public bool HasCommand { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_StringCmd_HasPredictionSync"></a> HasPredictionSync

```csharp
public bool HasPredictionSync { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_StringCmd_Parser"></a> Parser

```csharp
public static MessageParser<CNETMsg_StringCmd> Parser { get; }
```

#### Property Value

 MessageParser<[CNETMsg\_StringCmd](Divine.Protobufs.Dota2.CNETMsg\_StringCmd.md)\>

### <a id="Divine_Protobufs_Dota2_CNETMsg_StringCmd_PredictionSync"></a> PredictionSync

```csharp
public uint PredictionSync { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CNETMsg_StringCmd_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_StringCmd_ClearCommand"></a> ClearCommand\(\)

```csharp
public void ClearCommand()
```

### <a id="Divine_Protobufs_Dota2_CNETMsg_StringCmd_ClearPredictionSync"></a> ClearPredictionSync\(\)

```csharp
public void ClearPredictionSync()
```

### <a id="Divine_Protobufs_Dota2_CNETMsg_StringCmd_Clone"></a> Clone\(\)

```csharp
public CNETMsg_StringCmd Clone()
```

#### Returns

 [CNETMsg\_StringCmd](Divine.Protobufs.Dota2.CNETMsg\_StringCmd.md)

### <a id="Divine_Protobufs_Dota2_CNETMsg_StringCmd_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_StringCmd_Equals_Divine_Protobufs_Dota2_CNETMsg_StringCmd_"></a> Equals\(CNETMsg\_StringCmd\)

```csharp
public bool Equals(CNETMsg_StringCmd other)
```

#### Parameters

`other` [CNETMsg\_StringCmd](Divine.Protobufs.Dota2.CNETMsg\_StringCmd.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_StringCmd_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_StringCmd_MergeFrom_Divine_Protobufs_Dota2_CNETMsg_StringCmd_"></a> MergeFrom\(CNETMsg\_StringCmd\)

```csharp
public void MergeFrom(CNETMsg_StringCmd other)
```

#### Parameters

`other` [CNETMsg\_StringCmd](Divine.Protobufs.Dota2.CNETMsg\_StringCmd.md)

### <a id="Divine_Protobufs_Dota2_CNETMsg_StringCmd_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CNETMsg_StringCmd_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CNETMsg_StringCmd_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

