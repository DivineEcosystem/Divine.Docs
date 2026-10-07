# <a id="Divine_Protobufs_Steam_CMsgSteamLearn_Inference_Response"></a> Class CMsgSteamLearn\_Inference\_Response

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamLearn_Inference_Response : IMessage<CMsgSteamLearn_Inference_Response>, IEquatable<CMsgSteamLearn_Inference_Response>, IDeepCloneable<CMsgSteamLearn_Inference_Response>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamLearn\_Inference\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_Inference\_Response.md)

#### Implements

IMessage<CMsgSteamLearn\_Inference\_Response\>, 
[IEquatable<CMsgSteamLearn\_Inference\_Response\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamLearn\_Inference\_Response\>, 
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
[EnumerableExtensions.In<CMsgSteamLearn\_Inference\_Response\>\(CMsgSteamLearn\_Inference\_Response, params CMsgSteamLearn\_Inference\_Response\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_Inference_Response__ctor"></a> CMsgSteamLearn\_Inference\_Response\(\)

```csharp
public CMsgSteamLearn_Inference_Response()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_Inference_Response__ctor_Divine_Protobufs_Steam_CMsgSteamLearn_Inference_Response_"></a> CMsgSteamLearn\_Inference\_Response\(CMsgSteamLearn\_Inference\_Response\)

```csharp
public CMsgSteamLearn_Inference_Response(CMsgSteamLearn_Inference_Response other)
```

#### Parameters

`other` [CMsgSteamLearn\_Inference\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_Inference\_Response.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_Inference_Response_BackendResponseFieldNumber"></a> BackendResponseFieldNumber

```csharp
public const int BackendResponseFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_Inference_Response_InferenceResultFieldNumber"></a> InferenceResultFieldNumber

```csharp
public const int InferenceResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_Inference_Response_KeysFieldNumber"></a> KeysFieldNumber

```csharp
public const int KeysFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_Inference_Response_BackendResponse"></a> BackendResponse

```csharp
public CMsgSteamLearn_InferenceBackend_Response BackendResponse { get; set; }
```

#### Property Value

 [CMsgSteamLearn\_InferenceBackend\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_Inference_Response_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_Inference_Response_HasInferenceResult"></a> HasInferenceResult

```csharp
public bool HasInferenceResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_Inference_Response_InferenceResult"></a> InferenceResult

```csharp
public ESteamLearnInferenceResult InferenceResult { get; set; }
```

#### Property Value

 [ESteamLearnInferenceResult](Divine.Protobufs.Steam.ESteamLearnInferenceResult.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_Inference_Response_Keys"></a> Keys

```csharp
public RepeatedField<ulong> Keys { get; }
```

#### Property Value

 RepeatedField<[ulong](https://learn.microsoft.com/dotnet/api/system.uint64)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_Inference_Response_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamLearn_Inference_Response> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamLearn\_Inference\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_Inference\_Response.md)\>

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_Inference_Response_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_Inference_Response_ClearInferenceResult"></a> ClearInferenceResult\(\)

```csharp
public void ClearInferenceResult()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_Inference_Response_Clone"></a> Clone\(\)

```csharp
public CMsgSteamLearn_Inference_Response Clone()
```

#### Returns

 [CMsgSteamLearn\_Inference\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_Inference\_Response.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_Inference_Response_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_Inference_Response_Equals_Divine_Protobufs_Steam_CMsgSteamLearn_Inference_Response_"></a> Equals\(CMsgSteamLearn\_Inference\_Response\)

```csharp
public bool Equals(CMsgSteamLearn_Inference_Response other)
```

#### Parameters

`other` [CMsgSteamLearn\_Inference\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_Inference\_Response.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_Inference_Response_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_Inference_Response_MergeFrom_Divine_Protobufs_Steam_CMsgSteamLearn_Inference_Response_"></a> MergeFrom\(CMsgSteamLearn\_Inference\_Response\)

```csharp
public void MergeFrom(CMsgSteamLearn_Inference_Response other)
```

#### Parameters

`other` [CMsgSteamLearn\_Inference\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_Inference\_Response.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_Inference_Response_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_Inference_Response_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_Inference_Response_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

