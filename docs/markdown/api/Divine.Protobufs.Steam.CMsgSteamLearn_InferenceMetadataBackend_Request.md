# <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadataBackend_Request"></a> Class CMsgSteamLearn\_InferenceMetadataBackend\_Request

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamLearn_InferenceMetadataBackend_Request : IMessage<CMsgSteamLearn_InferenceMetadataBackend_Request>, IEquatable<CMsgSteamLearn_InferenceMetadataBackend_Request>, IDeepCloneable<CMsgSteamLearn_InferenceMetadataBackend_Request>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamLearn\_InferenceMetadataBackend\_Request](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadataBackend\_Request.md)

#### Implements

IMessage<CMsgSteamLearn\_InferenceMetadataBackend\_Request\>, 
[IEquatable<CMsgSteamLearn\_InferenceMetadataBackend\_Request\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamLearn\_InferenceMetadataBackend\_Request\>, 
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
[EnumerableExtensions.In<CMsgSteamLearn\_InferenceMetadataBackend\_Request\>\(CMsgSteamLearn\_InferenceMetadataBackend\_Request, params CMsgSteamLearn\_InferenceMetadataBackend\_Request\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadataBackend_Request__ctor"></a> CMsgSteamLearn\_InferenceMetadataBackend\_Request\(\)

```csharp
public CMsgSteamLearn_InferenceMetadataBackend_Request()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadataBackend_Request__ctor_Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadataBackend_Request_"></a> CMsgSteamLearn\_InferenceMetadataBackend\_Request\(CMsgSteamLearn\_InferenceMetadataBackend\_Request\)

```csharp
public CMsgSteamLearn_InferenceMetadataBackend_Request(CMsgSteamLearn_InferenceMetadataBackend_Request other)
```

#### Parameters

`other` [CMsgSteamLearn\_InferenceMetadataBackend\_Request](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadataBackend\_Request.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadataBackend_Request_FetchIdFieldNumber"></a> FetchIdFieldNumber

```csharp
public const int FetchIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadataBackend_Request_ProjectIdFieldNumber"></a> ProjectIdFieldNumber

```csharp
public const int ProjectIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadataBackend_Request_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadataBackend_Request_FetchId"></a> FetchId

```csharp
public uint FetchId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadataBackend_Request_HasFetchId"></a> HasFetchId

```csharp
public bool HasFetchId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadataBackend_Request_HasProjectId"></a> HasProjectId

```csharp
public bool HasProjectId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadataBackend_Request_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamLearn_InferenceMetadataBackend_Request> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamLearn\_InferenceMetadataBackend\_Request](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadataBackend\_Request.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadataBackend_Request_ProjectId"></a> ProjectId

```csharp
public uint ProjectId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadataBackend_Request_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadataBackend_Request_ClearFetchId"></a> ClearFetchId\(\)

```csharp
public void ClearFetchId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadataBackend_Request_ClearProjectId"></a> ClearProjectId\(\)

```csharp
public void ClearProjectId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadataBackend_Request_Clone"></a> Clone\(\)

```csharp
public CMsgSteamLearn_InferenceMetadataBackend_Request Clone()
```

#### Returns

 [CMsgSteamLearn\_InferenceMetadataBackend\_Request](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadataBackend\_Request.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadataBackend_Request_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadataBackend_Request_Equals_Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadataBackend_Request_"></a> Equals\(CMsgSteamLearn\_InferenceMetadataBackend\_Request\)

```csharp
public bool Equals(CMsgSteamLearn_InferenceMetadataBackend_Request other)
```

#### Parameters

`other` [CMsgSteamLearn\_InferenceMetadataBackend\_Request](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadataBackend\_Request.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadataBackend_Request_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadataBackend_Request_MergeFrom_Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadataBackend_Request_"></a> MergeFrom\(CMsgSteamLearn\_InferenceMetadataBackend\_Request\)

```csharp
public void MergeFrom(CMsgSteamLearn_InferenceMetadataBackend_Request other)
```

#### Parameters

`other` [CMsgSteamLearn\_InferenceMetadataBackend\_Request](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadataBackend\_Request.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadataBackend_Request_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadataBackend_Request_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadataBackend_Request_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

