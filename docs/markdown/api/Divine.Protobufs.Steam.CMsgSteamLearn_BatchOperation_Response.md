# <a id="Divine_Protobufs_Steam_CMsgSteamLearn_BatchOperation_Response"></a> Class CMsgSteamLearn\_BatchOperation\_Response

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamLearn_BatchOperation_Response : IMessage<CMsgSteamLearn_BatchOperation_Response>, IEquatable<CMsgSteamLearn_BatchOperation_Response>, IDeepCloneable<CMsgSteamLearn_BatchOperation_Response>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamLearn\_BatchOperation\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_BatchOperation\_Response.md)

#### Implements

IMessage<CMsgSteamLearn\_BatchOperation\_Response\>, 
[IEquatable<CMsgSteamLearn\_BatchOperation\_Response\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamLearn\_BatchOperation\_Response\>, 
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
[EnumerableExtensions.In<CMsgSteamLearn\_BatchOperation\_Response\>\(CMsgSteamLearn\_BatchOperation\_Response, params CMsgSteamLearn\_BatchOperation\_Response\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_BatchOperation_Response__ctor"></a> CMsgSteamLearn\_BatchOperation\_Response\(\)

```csharp
public CMsgSteamLearn_BatchOperation_Response()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_BatchOperation_Response__ctor_Divine_Protobufs_Steam_CMsgSteamLearn_BatchOperation_Response_"></a> CMsgSteamLearn\_BatchOperation\_Response\(CMsgSteamLearn\_BatchOperation\_Response\)

```csharp
public CMsgSteamLearn_BatchOperation_Response(CMsgSteamLearn_BatchOperation_Response other)
```

#### Parameters

`other` [CMsgSteamLearn\_BatchOperation\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_BatchOperation\_Response.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_BatchOperation_Response_CacheDataResponsesFieldNumber"></a> CacheDataResponsesFieldNumber

```csharp
public const int CacheDataResponsesFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_BatchOperation_Response_InferenceResponsesFieldNumber"></a> InferenceResponsesFieldNumber

```csharp
public const int InferenceResponsesFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_BatchOperation_Response_SnapshotResponsesFieldNumber"></a> SnapshotResponsesFieldNumber

```csharp
public const int SnapshotResponsesFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_BatchOperation_Response_CacheDataResponses"></a> CacheDataResponses

```csharp
public RepeatedField<CMsgSteamLearn_CacheData_Response> CacheDataResponses { get; }
```

#### Property Value

 RepeatedField<[CMsgSteamLearn\_CacheData\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_CacheData\_Response.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_BatchOperation_Response_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_BatchOperation_Response_InferenceResponses"></a> InferenceResponses

```csharp
public RepeatedField<CMsgSteamLearn_Inference_Response> InferenceResponses { get; }
```

#### Property Value

 RepeatedField<[CMsgSteamLearn\_Inference\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_Inference\_Response.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_BatchOperation_Response_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamLearn_BatchOperation_Response> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamLearn\_BatchOperation\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_BatchOperation\_Response.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_BatchOperation_Response_SnapshotResponses"></a> SnapshotResponses

```csharp
public RepeatedField<CMsgSteamLearn_SnapshotProject_Response> SnapshotResponses { get; }
```

#### Property Value

 RepeatedField<[CMsgSteamLearn\_SnapshotProject\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_SnapshotProject\_Response.md)\>

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_BatchOperation_Response_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_BatchOperation_Response_Clone"></a> Clone\(\)

```csharp
public CMsgSteamLearn_BatchOperation_Response Clone()
```

#### Returns

 [CMsgSteamLearn\_BatchOperation\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_BatchOperation\_Response.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_BatchOperation_Response_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_BatchOperation_Response_Equals_Divine_Protobufs_Steam_CMsgSteamLearn_BatchOperation_Response_"></a> Equals\(CMsgSteamLearn\_BatchOperation\_Response\)

```csharp
public bool Equals(CMsgSteamLearn_BatchOperation_Response other)
```

#### Parameters

`other` [CMsgSteamLearn\_BatchOperation\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_BatchOperation\_Response.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_BatchOperation_Response_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_BatchOperation_Response_MergeFrom_Divine_Protobufs_Steam_CMsgSteamLearn_BatchOperation_Response_"></a> MergeFrom\(CMsgSteamLearn\_BatchOperation\_Response\)

```csharp
public void MergeFrom(CMsgSteamLearn_BatchOperation_Response other)
```

#### Parameters

`other` [CMsgSteamLearn\_BatchOperation\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_BatchOperation\_Response.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_BatchOperation_Response_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_BatchOperation_Response_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_BatchOperation_Response_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

