# <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_BinaryCrossEntropyOutput"></a> Class CMsgSteamLearn\_InferenceBackend\_Response.Types.BinaryCrossEntropyOutput

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamLearn_InferenceBackend_Response.Types.BinaryCrossEntropyOutput : IMessage<CMsgSteamLearn_InferenceBackend_Response.Types.BinaryCrossEntropyOutput>, IEquatable<CMsgSteamLearn_InferenceBackend_Response.Types.BinaryCrossEntropyOutput>, IDeepCloneable<CMsgSteamLearn_InferenceBackend_Response.Types.BinaryCrossEntropyOutput>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamLearn\_InferenceBackend\_Response.Types.BinaryCrossEntropyOutput](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.Types.BinaryCrossEntropyOutput.md)

#### Implements

IMessage<CMsgSteamLearn\_InferenceBackend\_Response.Types.BinaryCrossEntropyOutput\>, 
[IEquatable<CMsgSteamLearn\_InferenceBackend\_Response.Types.BinaryCrossEntropyOutput\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamLearn\_InferenceBackend\_Response.Types.BinaryCrossEntropyOutput\>, 
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
[EnumerableExtensions.In<CMsgSteamLearn\_InferenceBackend\_Response.Types.BinaryCrossEntropyOutput\>\(CMsgSteamLearn\_InferenceBackend\_Response.Types.BinaryCrossEntropyOutput, params CMsgSteamLearn\_InferenceBackend\_Response.Types.BinaryCrossEntropyOutput\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_BinaryCrossEntropyOutput__ctor"></a> BinaryCrossEntropyOutput\(\)

```csharp
public BinaryCrossEntropyOutput()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_BinaryCrossEntropyOutput__ctor_Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_BinaryCrossEntropyOutput_"></a> BinaryCrossEntropyOutput\(BinaryCrossEntropyOutput\)

```csharp
public BinaryCrossEntropyOutput(CMsgSteamLearn_InferenceBackend_Response.Types.BinaryCrossEntropyOutput other)
```

#### Parameters

`other` [CMsgSteamLearn\_InferenceBackend\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.Types.md).[BinaryCrossEntropyOutput](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.Types.BinaryCrossEntropyOutput.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_BinaryCrossEntropyOutput_ValueFieldNumber"></a> ValueFieldNumber

```csharp
public const int ValueFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_BinaryCrossEntropyOutput_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_BinaryCrossEntropyOutput_HasValue"></a> HasValue

```csharp
public bool HasValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_BinaryCrossEntropyOutput_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamLearn_InferenceBackend_Response.Types.BinaryCrossEntropyOutput> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamLearn\_InferenceBackend\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.Types.md).[BinaryCrossEntropyOutput](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.Types.BinaryCrossEntropyOutput.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_BinaryCrossEntropyOutput_Value"></a> Value

```csharp
public float Value { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_BinaryCrossEntropyOutput_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_BinaryCrossEntropyOutput_ClearValue"></a> ClearValue\(\)

```csharp
public void ClearValue()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_BinaryCrossEntropyOutput_Clone"></a> Clone\(\)

```csharp
public CMsgSteamLearn_InferenceBackend_Response.Types.BinaryCrossEntropyOutput Clone()
```

#### Returns

 [CMsgSteamLearn\_InferenceBackend\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.Types.md).[BinaryCrossEntropyOutput](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.Types.BinaryCrossEntropyOutput.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_BinaryCrossEntropyOutput_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_BinaryCrossEntropyOutput_Equals_Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_BinaryCrossEntropyOutput_"></a> Equals\(BinaryCrossEntropyOutput\)

```csharp
public bool Equals(CMsgSteamLearn_InferenceBackend_Response.Types.BinaryCrossEntropyOutput other)
```

#### Parameters

`other` [CMsgSteamLearn\_InferenceBackend\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.Types.md).[BinaryCrossEntropyOutput](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.Types.BinaryCrossEntropyOutput.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_BinaryCrossEntropyOutput_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_BinaryCrossEntropyOutput_MergeFrom_Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_BinaryCrossEntropyOutput_"></a> MergeFrom\(BinaryCrossEntropyOutput\)

```csharp
public void MergeFrom(CMsgSteamLearn_InferenceBackend_Response.Types.BinaryCrossEntropyOutput other)
```

#### Parameters

`other` [CMsgSteamLearn\_InferenceBackend\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.Types.md).[BinaryCrossEntropyOutput](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.Types.BinaryCrossEntropyOutput.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_BinaryCrossEntropyOutput_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_BinaryCrossEntropyOutput_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_BinaryCrossEntropyOutput_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

