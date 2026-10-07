# <a id="Divine_Protobufs_Steam_CMsgSteamLearn_BatchOperation_Request"></a> Class CMsgSteamLearn\_BatchOperation\_Request

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamLearn_BatchOperation_Request : IMessage<CMsgSteamLearn_BatchOperation_Request>, IEquatable<CMsgSteamLearn_BatchOperation_Request>, IDeepCloneable<CMsgSteamLearn_BatchOperation_Request>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamLearn\_BatchOperation\_Request](Divine.Protobufs.Steam.CMsgSteamLearn\_BatchOperation\_Request.md)

#### Implements

IMessage<CMsgSteamLearn\_BatchOperation\_Request\>, 
[IEquatable<CMsgSteamLearn\_BatchOperation\_Request\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamLearn\_BatchOperation\_Request\>, 
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
[EnumerableExtensions.In<CMsgSteamLearn\_BatchOperation\_Request\>\(CMsgSteamLearn\_BatchOperation\_Request, params CMsgSteamLearn\_BatchOperation\_Request\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_BatchOperation_Request__ctor"></a> CMsgSteamLearn\_BatchOperation\_Request\(\)

```csharp
public CMsgSteamLearn_BatchOperation_Request()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_BatchOperation_Request__ctor_Divine_Protobufs_Steam_CMsgSteamLearn_BatchOperation_Request_"></a> CMsgSteamLearn\_BatchOperation\_Request\(CMsgSteamLearn\_BatchOperation\_Request\)

```csharp
public CMsgSteamLearn_BatchOperation_Request(CMsgSteamLearn_BatchOperation_Request other)
```

#### Parameters

`other` [CMsgSteamLearn\_BatchOperation\_Request](Divine.Protobufs.Steam.CMsgSteamLearn\_BatchOperation\_Request.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_BatchOperation_Request_CacheDataRequestsFieldNumber"></a> CacheDataRequestsFieldNumber

```csharp
public const int CacheDataRequestsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_BatchOperation_Request_InferenceRequestsFieldNumber"></a> InferenceRequestsFieldNumber

```csharp
public const int InferenceRequestsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_BatchOperation_Request_SnapshotRequestsFieldNumber"></a> SnapshotRequestsFieldNumber

```csharp
public const int SnapshotRequestsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_BatchOperation_Request_CacheDataRequests"></a> CacheDataRequests

```csharp
public RepeatedField<CMsgSteamLearn_CacheData_Request> CacheDataRequests { get; }
```

#### Property Value

 RepeatedField<[CMsgSteamLearn\_CacheData\_Request](Divine.Protobufs.Steam.CMsgSteamLearn\_CacheData\_Request.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_BatchOperation_Request_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_BatchOperation_Request_InferenceRequests"></a> InferenceRequests

```csharp
public RepeatedField<CMsgSteamLearn_Inference_Request> InferenceRequests { get; }
```

#### Property Value

 RepeatedField<[CMsgSteamLearn\_Inference\_Request](Divine.Protobufs.Steam.CMsgSteamLearn\_Inference\_Request.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_BatchOperation_Request_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamLearn_BatchOperation_Request> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamLearn\_BatchOperation\_Request](Divine.Protobufs.Steam.CMsgSteamLearn\_BatchOperation\_Request.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_BatchOperation_Request_SnapshotRequests"></a> SnapshotRequests

```csharp
public RepeatedField<CMsgSteamLearn_SnapshotProject_Request> SnapshotRequests { get; }
```

#### Property Value

 RepeatedField<[CMsgSteamLearn\_SnapshotProject\_Request](Divine.Protobufs.Steam.CMsgSteamLearn\_SnapshotProject\_Request.md)\>

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_BatchOperation_Request_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_BatchOperation_Request_Clone"></a> Clone\(\)

```csharp
public CMsgSteamLearn_BatchOperation_Request Clone()
```

#### Returns

 [CMsgSteamLearn\_BatchOperation\_Request](Divine.Protobufs.Steam.CMsgSteamLearn\_BatchOperation\_Request.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_BatchOperation_Request_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_BatchOperation_Request_Equals_Divine_Protobufs_Steam_CMsgSteamLearn_BatchOperation_Request_"></a> Equals\(CMsgSteamLearn\_BatchOperation\_Request\)

```csharp
public bool Equals(CMsgSteamLearn_BatchOperation_Request other)
```

#### Parameters

`other` [CMsgSteamLearn\_BatchOperation\_Request](Divine.Protobufs.Steam.CMsgSteamLearn\_BatchOperation\_Request.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_BatchOperation_Request_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_BatchOperation_Request_MergeFrom_Divine_Protobufs_Steam_CMsgSteamLearn_BatchOperation_Request_"></a> MergeFrom\(CMsgSteamLearn\_BatchOperation\_Request\)

```csharp
public void MergeFrom(CMsgSteamLearn_BatchOperation_Request other)
```

#### Parameters

`other` [CMsgSteamLearn\_BatchOperation\_Request](Divine.Protobufs.Steam.CMsgSteamLearn\_BatchOperation\_Request.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_BatchOperation_Request_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_BatchOperation_Request_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_BatchOperation_Request_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

