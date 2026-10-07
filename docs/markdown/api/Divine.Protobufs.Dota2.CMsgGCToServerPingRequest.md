# <a id="Divine_Protobufs_Dota2_CMsgGCToServerPingRequest"></a> Class CMsgGCToServerPingRequest

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToServerPingRequest : IMessage<CMsgGCToServerPingRequest>, IEquatable<CMsgGCToServerPingRequest>, IDeepCloneable<CMsgGCToServerPingRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToServerPingRequest](Divine.Protobufs.Dota2.CMsgGCToServerPingRequest.md)

#### Implements

IMessage<CMsgGCToServerPingRequest\>, 
[IEquatable<CMsgGCToServerPingRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToServerPingRequest\>, 
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
[EnumerableExtensions.In<CMsgGCToServerPingRequest\>\(CMsgGCToServerPingRequest, params CMsgGCToServerPingRequest\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerPingRequest__ctor"></a> CMsgGCToServerPingRequest\(\)

```csharp
public CMsgGCToServerPingRequest()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerPingRequest__ctor_Divine_Protobufs_Dota2_CMsgGCToServerPingRequest_"></a> CMsgGCToServerPingRequest\(CMsgGCToServerPingRequest\)

```csharp
public CMsgGCToServerPingRequest(CMsgGCToServerPingRequest other)
```

#### Parameters

`other` [CMsgGCToServerPingRequest](Divine.Protobufs.Dota2.CMsgGCToServerPingRequest.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerPingRequest_RequestIdFieldNumber"></a> RequestIdFieldNumber

```csharp
public const int RequestIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerPingRequest_RequestTimeFieldNumber"></a> RequestTimeFieldNumber

```csharp
public const int RequestTimeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerPingRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerPingRequest_HasRequestId"></a> HasRequestId

```csharp
public bool HasRequestId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerPingRequest_HasRequestTime"></a> HasRequestTime

```csharp
public bool HasRequestTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerPingRequest_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToServerPingRequest> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToServerPingRequest](Divine.Protobufs.Dota2.CMsgGCToServerPingRequest.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerPingRequest_RequestId"></a> RequestId

```csharp
public ulong RequestId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerPingRequest_RequestTime"></a> RequestTime

```csharp
public ulong RequestTime { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerPingRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerPingRequest_ClearRequestId"></a> ClearRequestId\(\)

```csharp
public void ClearRequestId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerPingRequest_ClearRequestTime"></a> ClearRequestTime\(\)

```csharp
public void ClearRequestTime()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerPingRequest_Clone"></a> Clone\(\)

```csharp
public CMsgGCToServerPingRequest Clone()
```

#### Returns

 [CMsgGCToServerPingRequest](Divine.Protobufs.Dota2.CMsgGCToServerPingRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerPingRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerPingRequest_Equals_Divine_Protobufs_Dota2_CMsgGCToServerPingRequest_"></a> Equals\(CMsgGCToServerPingRequest\)

```csharp
public bool Equals(CMsgGCToServerPingRequest other)
```

#### Parameters

`other` [CMsgGCToServerPingRequest](Divine.Protobufs.Dota2.CMsgGCToServerPingRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerPingRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerPingRequest_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToServerPingRequest_"></a> MergeFrom\(CMsgGCToServerPingRequest\)

```csharp
public void MergeFrom(CMsgGCToServerPingRequest other)
```

#### Parameters

`other` [CMsgGCToServerPingRequest](Divine.Protobufs.Dota2.CMsgGCToServerPingRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerPingRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerPingRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerPingRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

