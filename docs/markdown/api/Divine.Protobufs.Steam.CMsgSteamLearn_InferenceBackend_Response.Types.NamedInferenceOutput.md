# <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_NamedInferenceOutput"></a> Class CMsgSteamLearn\_InferenceBackend\_Response.Types.NamedInferenceOutput

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamLearn_InferenceBackend_Response.Types.NamedInferenceOutput : IMessage<CMsgSteamLearn_InferenceBackend_Response.Types.NamedInferenceOutput>, IEquatable<CMsgSteamLearn_InferenceBackend_Response.Types.NamedInferenceOutput>, IDeepCloneable<CMsgSteamLearn_InferenceBackend_Response.Types.NamedInferenceOutput>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamLearn\_InferenceBackend\_Response.Types.NamedInferenceOutput](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.Types.NamedInferenceOutput.md)

#### Implements

IMessage<CMsgSteamLearn\_InferenceBackend\_Response.Types.NamedInferenceOutput\>, 
[IEquatable<CMsgSteamLearn\_InferenceBackend\_Response.Types.NamedInferenceOutput\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamLearn\_InferenceBackend\_Response.Types.NamedInferenceOutput\>, 
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
[EnumerableExtensions.In<CMsgSteamLearn\_InferenceBackend\_Response.Types.NamedInferenceOutput\>\(CMsgSteamLearn\_InferenceBackend\_Response.Types.NamedInferenceOutput, params CMsgSteamLearn\_InferenceBackend\_Response.Types.NamedInferenceOutput\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_NamedInferenceOutput__ctor"></a> NamedInferenceOutput\(\)

```csharp
public NamedInferenceOutput()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_NamedInferenceOutput__ctor_Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_NamedInferenceOutput_"></a> NamedInferenceOutput\(NamedInferenceOutput\)

```csharp
public NamedInferenceOutput(CMsgSteamLearn_InferenceBackend_Response.Types.NamedInferenceOutput other)
```

#### Parameters

`other` [CMsgSteamLearn\_InferenceBackend\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.Types.md).[NamedInferenceOutput](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.Types.NamedInferenceOutput.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_NamedInferenceOutput_ValueFieldNumber"></a> ValueFieldNumber

```csharp
public const int ValueFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_NamedInferenceOutput_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_NamedInferenceOutput_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamLearn_InferenceBackend_Response.Types.NamedInferenceOutput> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamLearn\_InferenceBackend\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.Types.md).[NamedInferenceOutput](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.Types.NamedInferenceOutput.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_NamedInferenceOutput_Value"></a> Value

```csharp
public RepeatedField<float> Value { get; }
```

#### Property Value

 RepeatedField<[float](https://learn.microsoft.com/dotnet/api/system.single)\>

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_NamedInferenceOutput_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_NamedInferenceOutput_Clone"></a> Clone\(\)

```csharp
public CMsgSteamLearn_InferenceBackend_Response.Types.NamedInferenceOutput Clone()
```

#### Returns

 [CMsgSteamLearn\_InferenceBackend\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.Types.md).[NamedInferenceOutput](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.Types.NamedInferenceOutput.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_NamedInferenceOutput_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_NamedInferenceOutput_Equals_Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_NamedInferenceOutput_"></a> Equals\(NamedInferenceOutput\)

```csharp
public bool Equals(CMsgSteamLearn_InferenceBackend_Response.Types.NamedInferenceOutput other)
```

#### Parameters

`other` [CMsgSteamLearn\_InferenceBackend\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.Types.md).[NamedInferenceOutput](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.Types.NamedInferenceOutput.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_NamedInferenceOutput_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_NamedInferenceOutput_MergeFrom_Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_NamedInferenceOutput_"></a> MergeFrom\(NamedInferenceOutput\)

```csharp
public void MergeFrom(CMsgSteamLearn_InferenceBackend_Response.Types.NamedInferenceOutput other)
```

#### Parameters

`other` [CMsgSteamLearn\_InferenceBackend\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.Types.md).[NamedInferenceOutput](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.Types.NamedInferenceOutput.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_NamedInferenceOutput_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_NamedInferenceOutput_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_NamedInferenceOutput_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

