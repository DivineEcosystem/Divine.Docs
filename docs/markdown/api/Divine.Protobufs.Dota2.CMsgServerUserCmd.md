# <a id="Divine_Protobufs_Dota2_CMsgServerUserCmd"></a> Class CMsgServerUserCmd

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgServerUserCmd : IMessage<CMsgServerUserCmd>, IEquatable<CMsgServerUserCmd>, IDeepCloneable<CMsgServerUserCmd>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgServerUserCmd](Divine.Protobufs.Dota2.CMsgServerUserCmd.md)

#### Implements

IMessage<CMsgServerUserCmd\>, 
[IEquatable<CMsgServerUserCmd\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgServerUserCmd\>, 
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
[EnumerableExtensions.In<CMsgServerUserCmd\>\(CMsgServerUserCmd, params CMsgServerUserCmd\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgServerUserCmd__ctor"></a> CMsgServerUserCmd\(\)

```csharp
public CMsgServerUserCmd()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerUserCmd__ctor_Divine_Protobufs_Dota2_CMsgServerUserCmd_"></a> CMsgServerUserCmd\(CMsgServerUserCmd\)

```csharp
public CMsgServerUserCmd(CMsgServerUserCmd other)
```

#### Parameters

`other` [CMsgServerUserCmd](Divine.Protobufs.Dota2.CMsgServerUserCmd.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgServerUserCmd_ClientTickFieldNumber"></a> ClientTickFieldNumber

```csharp
public const int ClientTickFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerUserCmd_CmdNumberFieldNumber"></a> CmdNumberFieldNumber

```csharp
public const int CmdNumberFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerUserCmd_DataFieldNumber"></a> DataFieldNumber

```csharp
public const int DataFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerUserCmd_DeltaDataFieldNumber"></a> DeltaDataFieldNumber

```csharp
public const int DeltaDataFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerUserCmd_DeltaProcessedFieldNumber"></a> DeltaProcessedFieldNumber

```csharp
public const int DeltaProcessedFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerUserCmd_PlayerSlotFieldNumber"></a> PlayerSlotFieldNumber

```csharp
public const int PlayerSlotFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerUserCmd_ServerTickExecutedFieldNumber"></a> ServerTickExecutedFieldNumber

```csharp
public const int ServerTickExecutedFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgServerUserCmd_ClientTick"></a> ClientTick

```csharp
public int ClientTick { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerUserCmd_CmdNumber"></a> CmdNumber

```csharp
public int CmdNumber { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerUserCmd_Data"></a> Data

```csharp
public ByteString Data { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Dota2_CMsgServerUserCmd_DeltaData"></a> DeltaData

```csharp
public ByteString DeltaData { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Dota2_CMsgServerUserCmd_DeltaProcessed"></a> DeltaProcessed

```csharp
public bool DeltaProcessed { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerUserCmd_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgServerUserCmd_HasClientTick"></a> HasClientTick

```csharp
public bool HasClientTick { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerUserCmd_HasCmdNumber"></a> HasCmdNumber

```csharp
public bool HasCmdNumber { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerUserCmd_HasData"></a> HasData

```csharp
public bool HasData { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerUserCmd_HasDeltaData"></a> HasDeltaData

```csharp
public bool HasDeltaData { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerUserCmd_HasDeltaProcessed"></a> HasDeltaProcessed

```csharp
public bool HasDeltaProcessed { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerUserCmd_HasPlayerSlot"></a> HasPlayerSlot

```csharp
public bool HasPlayerSlot { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerUserCmd_HasServerTickExecuted"></a> HasServerTickExecuted

```csharp
public bool HasServerTickExecuted { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerUserCmd_Parser"></a> Parser

```csharp
public static MessageParser<CMsgServerUserCmd> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgServerUserCmd](Divine.Protobufs.Dota2.CMsgServerUserCmd.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgServerUserCmd_PlayerSlot"></a> PlayerSlot

```csharp
public int PlayerSlot { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerUserCmd_ServerTickExecuted"></a> ServerTickExecuted

```csharp
public int ServerTickExecuted { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgServerUserCmd_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerUserCmd_ClearClientTick"></a> ClearClientTick\(\)

```csharp
public void ClearClientTick()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerUserCmd_ClearCmdNumber"></a> ClearCmdNumber\(\)

```csharp
public void ClearCmdNumber()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerUserCmd_ClearData"></a> ClearData\(\)

```csharp
public void ClearData()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerUserCmd_ClearDeltaData"></a> ClearDeltaData\(\)

```csharp
public void ClearDeltaData()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerUserCmd_ClearDeltaProcessed"></a> ClearDeltaProcessed\(\)

```csharp
public void ClearDeltaProcessed()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerUserCmd_ClearPlayerSlot"></a> ClearPlayerSlot\(\)

```csharp
public void ClearPlayerSlot()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerUserCmd_ClearServerTickExecuted"></a> ClearServerTickExecuted\(\)

```csharp
public void ClearServerTickExecuted()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerUserCmd_Clone"></a> Clone\(\)

```csharp
public CMsgServerUserCmd Clone()
```

#### Returns

 [CMsgServerUserCmd](Divine.Protobufs.Dota2.CMsgServerUserCmd.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerUserCmd_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerUserCmd_Equals_Divine_Protobufs_Dota2_CMsgServerUserCmd_"></a> Equals\(CMsgServerUserCmd\)

```csharp
public bool Equals(CMsgServerUserCmd other)
```

#### Parameters

`other` [CMsgServerUserCmd](Divine.Protobufs.Dota2.CMsgServerUserCmd.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerUserCmd_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerUserCmd_MergeFrom_Divine_Protobufs_Dota2_CMsgServerUserCmd_"></a> MergeFrom\(CMsgServerUserCmd\)

```csharp
public void MergeFrom(CMsgServerUserCmd other)
```

#### Parameters

`other` [CMsgServerUserCmd](Divine.Protobufs.Dota2.CMsgServerUserCmd.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerUserCmd_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgServerUserCmd_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgServerUserCmd_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

