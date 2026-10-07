# <a id="Divine_Protobufs_Dota2_CMsgGCToGCConsoleOutput"></a> Class CMsgGCToGCConsoleOutput

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToGCConsoleOutput : IMessage<CMsgGCToGCConsoleOutput>, IEquatable<CMsgGCToGCConsoleOutput>, IDeepCloneable<CMsgGCToGCConsoleOutput>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToGCConsoleOutput](Divine.Protobufs.Dota2.CMsgGCToGCConsoleOutput.md)

#### Implements

IMessage<CMsgGCToGCConsoleOutput\>, 
[IEquatable<CMsgGCToGCConsoleOutput\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToGCConsoleOutput\>, 
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
[EnumerableExtensions.In<CMsgGCToGCConsoleOutput\>\(CMsgGCToGCConsoleOutput, params CMsgGCToGCConsoleOutput\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCConsoleOutput__ctor"></a> CMsgGCToGCConsoleOutput\(\)

```csharp
public CMsgGCToGCConsoleOutput()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCConsoleOutput__ctor_Divine_Protobufs_Dota2_CMsgGCToGCConsoleOutput_"></a> CMsgGCToGCConsoleOutput\(CMsgGCToGCConsoleOutput\)

```csharp
public CMsgGCToGCConsoleOutput(CMsgGCToGCConsoleOutput other)
```

#### Parameters

`other` [CMsgGCToGCConsoleOutput](Divine.Protobufs.Dota2.CMsgGCToGCConsoleOutput.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCConsoleOutput_InitiatorFieldNumber"></a> InitiatorFieldNumber

```csharp
public const int InitiatorFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCConsoleOutput_IsLastForSourceJobFieldNumber"></a> IsLastForSourceJobFieldNumber

```csharp
public const int IsLastForSourceJobFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCConsoleOutput_MsgsFieldNumber"></a> MsgsFieldNumber

```csharp
public const int MsgsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCConsoleOutput_SendingGcFieldNumber"></a> SendingGcFieldNumber

```csharp
public const int SendingGcFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCConsoleOutput_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCConsoleOutput_HasInitiator"></a> HasInitiator

```csharp
public bool HasInitiator { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCConsoleOutput_HasIsLastForSourceJob"></a> HasIsLastForSourceJob

```csharp
public bool HasIsLastForSourceJob { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCConsoleOutput_HasSendingGc"></a> HasSendingGc

```csharp
public bool HasSendingGc { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCConsoleOutput_Initiator"></a> Initiator

```csharp
public string Initiator { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCConsoleOutput_IsLastForSourceJob"></a> IsLastForSourceJob

```csharp
public bool IsLastForSourceJob { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCConsoleOutput_Msgs"></a> Msgs

```csharp
public RepeatedField<CMsgGCToGCConsoleOutput.Types.OutputLine> Msgs { get; }
```

#### Property Value

 RepeatedField<[CMsgGCToGCConsoleOutput](Divine.Protobufs.Dota2.CMsgGCToGCConsoleOutput.md).[Types](Divine.Protobufs.Dota2.CMsgGCToGCConsoleOutput.Types.md).[OutputLine](Divine.Protobufs.Dota2.CMsgGCToGCConsoleOutput.Types.OutputLine.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCConsoleOutput_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToGCConsoleOutput> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToGCConsoleOutput](Divine.Protobufs.Dota2.CMsgGCToGCConsoleOutput.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCConsoleOutput_SendingGc"></a> SendingGc

```csharp
public int SendingGc { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCConsoleOutput_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCConsoleOutput_ClearInitiator"></a> ClearInitiator\(\)

```csharp
public void ClearInitiator()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCConsoleOutput_ClearIsLastForSourceJob"></a> ClearIsLastForSourceJob\(\)

```csharp
public void ClearIsLastForSourceJob()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCConsoleOutput_ClearSendingGc"></a> ClearSendingGc\(\)

```csharp
public void ClearSendingGc()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCConsoleOutput_Clone"></a> Clone\(\)

```csharp
public CMsgGCToGCConsoleOutput Clone()
```

#### Returns

 [CMsgGCToGCConsoleOutput](Divine.Protobufs.Dota2.CMsgGCToGCConsoleOutput.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCConsoleOutput_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCConsoleOutput_Equals_Divine_Protobufs_Dota2_CMsgGCToGCConsoleOutput_"></a> Equals\(CMsgGCToGCConsoleOutput\)

```csharp
public bool Equals(CMsgGCToGCConsoleOutput other)
```

#### Parameters

`other` [CMsgGCToGCConsoleOutput](Divine.Protobufs.Dota2.CMsgGCToGCConsoleOutput.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCConsoleOutput_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCConsoleOutput_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToGCConsoleOutput_"></a> MergeFrom\(CMsgGCToGCConsoleOutput\)

```csharp
public void MergeFrom(CMsgGCToGCConsoleOutput other)
```

#### Parameters

`other` [CMsgGCToGCConsoleOutput](Divine.Protobufs.Dota2.CMsgGCToGCConsoleOutput.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCConsoleOutput_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCConsoleOutput_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCConsoleOutput_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

