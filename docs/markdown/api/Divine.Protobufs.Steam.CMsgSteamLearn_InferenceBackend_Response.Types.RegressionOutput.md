# <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_RegressionOutput"></a> Class CMsgSteamLearn\_InferenceBackend\_Response.Types.RegressionOutput

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamLearn_InferenceBackend_Response.Types.RegressionOutput : IMessage<CMsgSteamLearn_InferenceBackend_Response.Types.RegressionOutput>, IEquatable<CMsgSteamLearn_InferenceBackend_Response.Types.RegressionOutput>, IDeepCloneable<CMsgSteamLearn_InferenceBackend_Response.Types.RegressionOutput>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamLearn\_InferenceBackend\_Response.Types.RegressionOutput](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.Types.RegressionOutput.md)

#### Implements

IMessage<CMsgSteamLearn\_InferenceBackend\_Response.Types.RegressionOutput\>, 
[IEquatable<CMsgSteamLearn\_InferenceBackend\_Response.Types.RegressionOutput\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamLearn\_InferenceBackend\_Response.Types.RegressionOutput\>, 
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
[EnumerableExtensions.In<CMsgSteamLearn\_InferenceBackend\_Response.Types.RegressionOutput\>\(CMsgSteamLearn\_InferenceBackend\_Response.Types.RegressionOutput, params CMsgSteamLearn\_InferenceBackend\_Response.Types.RegressionOutput\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_RegressionOutput__ctor"></a> RegressionOutput\(\)

```csharp
public RegressionOutput()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_RegressionOutput__ctor_Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_RegressionOutput_"></a> RegressionOutput\(RegressionOutput\)

```csharp
public RegressionOutput(CMsgSteamLearn_InferenceBackend_Response.Types.RegressionOutput other)
```

#### Parameters

`other` [CMsgSteamLearn\_InferenceBackend\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.Types.md).[RegressionOutput](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.Types.RegressionOutput.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_RegressionOutput_ValueFieldNumber"></a> ValueFieldNumber

```csharp
public const int ValueFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_RegressionOutput_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_RegressionOutput_HasValue"></a> HasValue

```csharp
public bool HasValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_RegressionOutput_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamLearn_InferenceBackend_Response.Types.RegressionOutput> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamLearn\_InferenceBackend\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.Types.md).[RegressionOutput](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.Types.RegressionOutput.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_RegressionOutput_Value"></a> Value

```csharp
public float Value { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_RegressionOutput_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_RegressionOutput_ClearValue"></a> ClearValue\(\)

```csharp
public void ClearValue()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_RegressionOutput_Clone"></a> Clone\(\)

```csharp
public CMsgSteamLearn_InferenceBackend_Response.Types.RegressionOutput Clone()
```

#### Returns

 [CMsgSteamLearn\_InferenceBackend\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.Types.md).[RegressionOutput](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.Types.RegressionOutput.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_RegressionOutput_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_RegressionOutput_Equals_Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_RegressionOutput_"></a> Equals\(RegressionOutput\)

```csharp
public bool Equals(CMsgSteamLearn_InferenceBackend_Response.Types.RegressionOutput other)
```

#### Parameters

`other` [CMsgSteamLearn\_InferenceBackend\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.Types.md).[RegressionOutput](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.Types.RegressionOutput.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_RegressionOutput_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_RegressionOutput_MergeFrom_Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_RegressionOutput_"></a> MergeFrom\(RegressionOutput\)

```csharp
public void MergeFrom(CMsgSteamLearn_InferenceBackend_Response.Types.RegressionOutput other)
```

#### Parameters

`other` [CMsgSteamLearn\_InferenceBackend\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.Types.md).[RegressionOutput](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceBackend\_Response.Types.RegressionOutput.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_RegressionOutput_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_RegressionOutput_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceBackend_Response_Types_RegressionOutput_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

