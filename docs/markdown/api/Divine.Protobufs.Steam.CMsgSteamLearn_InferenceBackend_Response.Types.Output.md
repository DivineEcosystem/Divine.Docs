# <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_Output"></a> Class CMsgSteamLearn\_InferenceBackend\_Response.Types.Output

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamLearn_InferenceBackend_Response.Types.Output : IMessage<CMsgSteamLearn_InferenceBackend_Response.Types.Output>, IEquatable<CMsgSteamLearn_InferenceBackend_Response.Types.Output>, IDeepCloneable<CMsgSteamLearn_InferenceBackend_Response.Types.Output>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamLearn\_InferenceBackend\_Response.Types.Output](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.Types.Output.md)

#### Implements

IMessage<CMsgSteamLearn\_InferenceBackend\_Response.Types.Output\>, 
[IEquatable<CMsgSteamLearn\_InferenceBackend\_Response.Types.Output\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamLearn\_InferenceBackend\_Response.Types.Output\>, 
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
[EnumerableExtensions.In<CMsgSteamLearn\_InferenceBackend\_Response.Types.Output\>\(CMsgSteamLearn\_InferenceBackend\_Response.Types.Output, params CMsgSteamLearn\_InferenceBackend\_Response.Types.Output\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_Output__ctor"></a> Output\(\)

```csharp
public Output()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_Output__ctor_Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_Output_"></a> Output\(Output\)

```csharp
public Output(CMsgSteamLearn_InferenceBackend_Response.Types.Output other)
```

#### Parameters

`other` [CMsgSteamLearn\_InferenceBackend\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.Types.md).[Output](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.Types.Output.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_Output_BinaryCrossentropyFieldNumber"></a> BinaryCrossentropyFieldNumber

```csharp
public const int BinaryCrossentropyFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_Output_CategoricalCrossentropyFieldNumber"></a> CategoricalCrossentropyFieldNumber

```csharp
public const int CategoricalCrossentropyFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_Output_MultiBinaryCrossentropyFieldNumber"></a> MultiBinaryCrossentropyFieldNumber

```csharp
public const int MultiBinaryCrossentropyFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_Output_NamedInferenceFieldNumber"></a> NamedInferenceFieldNumber

```csharp
public const int NamedInferenceFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_Output_RegressionFieldNumber"></a> RegressionFieldNumber

```csharp
public const int RegressionFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_Output_BinaryCrossentropy"></a> BinaryCrossentropy

```csharp
public CMsgSteamLearn_InferenceBackend_Response.Types.BinaryCrossEntropyOutput BinaryCrossentropy { get; set; }
```

#### Property Value

 [CMsgSteamLearn\_InferenceBackend\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.Types.md).[BinaryCrossEntropyOutput](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.Types.BinaryCrossEntropyOutput.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_Output_CategoricalCrossentropy"></a> CategoricalCrossentropy

```csharp
public CMsgSteamLearn_InferenceBackend_Response.Types.CategoricalCrossEntropyOutput CategoricalCrossentropy { get; set; }
```

#### Property Value

 [CMsgSteamLearn\_InferenceBackend\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.Types.md).[CategoricalCrossEntropyOutput](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.Types.CategoricalCrossEntropyOutput.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_Output_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_Output_MultiBinaryCrossentropy"></a> MultiBinaryCrossentropy

```csharp
public CMsgSteamLearn_InferenceBackend_Response.Types.MutliBinaryCrossEntropyOutput MultiBinaryCrossentropy { get; set; }
```

#### Property Value

 [CMsgSteamLearn\_InferenceBackend\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.Types.md).[MutliBinaryCrossEntropyOutput](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.Types.MutliBinaryCrossEntropyOutput.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_Output_NamedInference"></a> NamedInference

```csharp
public CMsgSteamLearn_InferenceBackend_Response.Types.NamedInferenceOutput NamedInference { get; set; }
```

#### Property Value

 [CMsgSteamLearn\_InferenceBackend\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.Types.md).[NamedInferenceOutput](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.Types.NamedInferenceOutput.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_Output_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamLearn_InferenceBackend_Response.Types.Output> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamLearn\_InferenceBackend\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.Types.md).[Output](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.Types.Output.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_Output_Regression"></a> Regression

```csharp
public CMsgSteamLearn_InferenceBackend_Response.Types.RegressionOutput Regression { get; set; }
```

#### Property Value

 [CMsgSteamLearn\_InferenceBackend\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.Types.md).[RegressionOutput](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.Types.RegressionOutput.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_Output_ResponseTypeCase"></a> ResponseTypeCase

```csharp
public CMsgSteamLearn_InferenceBackend_Response.Types.Output.ResponseTypeOneofCase ResponseTypeCase { get; }
```

#### Property Value

 [CMsgSteamLearn\_InferenceBackend\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.Types.md).[Output](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.Types.Output.md).[ResponseTypeOneofCase](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.Types.Output.ResponseTypeOneofCase.md)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_Output_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_Output_ClearResponseType"></a> ClearResponseType\(\)

```csharp
public void ClearResponseType()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_Output_Clone"></a> Clone\(\)

```csharp
public CMsgSteamLearn_InferenceBackend_Response.Types.Output Clone()
```

#### Returns

 [CMsgSteamLearn\_InferenceBackend\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.Types.md).[Output](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.Types.Output.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_Output_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_Output_Equals_Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_Output_"></a> Equals\(Output\)

```csharp
public bool Equals(CMsgSteamLearn_InferenceBackend_Response.Types.Output other)
```

#### Parameters

`other` [CMsgSteamLearn\_InferenceBackend\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.Types.md).[Output](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.Types.Output.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_Output_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_Output_MergeFrom_Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_Output_"></a> MergeFrom\(Output\)

```csharp
public void MergeFrom(CMsgSteamLearn_InferenceBackend_Response.Types.Output other)
```

#### Parameters

`other` [CMsgSteamLearn\_InferenceBackend\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.Types.md).[Output](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.Types.Output.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_Output_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_Output_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_Output_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

