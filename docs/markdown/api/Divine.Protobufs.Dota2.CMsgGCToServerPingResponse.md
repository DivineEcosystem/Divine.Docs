# <a id="Divine_Protobufs_Dota2_CMsgGCToServerPingResponse"></a> Class CMsgGCToServerPingResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToServerPingResponse : IMessage<CMsgGCToServerPingResponse>, IEquatable<CMsgGCToServerPingResponse>, IDeepCloneable<CMsgGCToServerPingResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToServerPingResponse](Divine.Protobufs.Dota2.CMsgGCToServerPingResponse.md)

#### Implements

IMessage<CMsgGCToServerPingResponse\>, 
[IEquatable<CMsgGCToServerPingResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToServerPingResponse\>, 
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
[EnumerableExtensions.In<CMsgGCToServerPingResponse\>\(CMsgGCToServerPingResponse, params CMsgGCToServerPingResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerPingResponse__ctor"></a> CMsgGCToServerPingResponse\(\)

```csharp
public CMsgGCToServerPingResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerPingResponse__ctor_Divine_Protobufs_Dota2_CMsgGCToServerPingResponse_"></a> CMsgGCToServerPingResponse\(CMsgGCToServerPingResponse\)

```csharp
public CMsgGCToServerPingResponse(CMsgGCToServerPingResponse other)
```

#### Parameters

`other` [CMsgGCToServerPingResponse](Divine.Protobufs.Dota2.CMsgGCToServerPingResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerPingResponse_ClusterFieldNumber"></a> ClusterFieldNumber

```csharp
public const int ClusterFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerPingResponse_RequestIdFieldNumber"></a> RequestIdFieldNumber

```csharp
public const int RequestIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerPingResponse_RequestTimeFieldNumber"></a> RequestTimeFieldNumber

```csharp
public const int RequestTimeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerPingResponse_Cluster"></a> Cluster

```csharp
public uint Cluster { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerPingResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerPingResponse_HasCluster"></a> HasCluster

```csharp
public bool HasCluster { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerPingResponse_HasRequestId"></a> HasRequestId

```csharp
public bool HasRequestId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerPingResponse_HasRequestTime"></a> HasRequestTime

```csharp
public bool HasRequestTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerPingResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToServerPingResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToServerPingResponse](Divine.Protobufs.Dota2.CMsgGCToServerPingResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerPingResponse_RequestId"></a> RequestId

```csharp
public ulong RequestId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerPingResponse_RequestTime"></a> RequestTime

```csharp
public ulong RequestTime { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerPingResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerPingResponse_ClearCluster"></a> ClearCluster\(\)

```csharp
public void ClearCluster()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerPingResponse_ClearRequestId"></a> ClearRequestId\(\)

```csharp
public void ClearRequestId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerPingResponse_ClearRequestTime"></a> ClearRequestTime\(\)

```csharp
public void ClearRequestTime()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerPingResponse_Clone"></a> Clone\(\)

```csharp
public CMsgGCToServerPingResponse Clone()
```

#### Returns

 [CMsgGCToServerPingResponse](Divine.Protobufs.Dota2.CMsgGCToServerPingResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerPingResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerPingResponse_Equals_Divine_Protobufs_Dota2_CMsgGCToServerPingResponse_"></a> Equals\(CMsgGCToServerPingResponse\)

```csharp
public bool Equals(CMsgGCToServerPingResponse other)
```

#### Parameters

`other` [CMsgGCToServerPingResponse](Divine.Protobufs.Dota2.CMsgGCToServerPingResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerPingResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerPingResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToServerPingResponse_"></a> MergeFrom\(CMsgGCToServerPingResponse\)

```csharp
public void MergeFrom(CMsgGCToServerPingResponse other)
```

#### Parameters

`other` [CMsgGCToServerPingResponse](Divine.Protobufs.Dota2.CMsgGCToServerPingResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerPingResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerPingResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerPingResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

