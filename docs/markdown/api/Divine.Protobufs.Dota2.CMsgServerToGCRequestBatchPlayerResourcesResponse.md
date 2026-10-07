# <a id="Divine_Protobufs_Dota2_CMsgServerToGCRequestBatchPlayerResourcesResponse"></a> Class CMsgServerToGCRequestBatchPlayerResourcesResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgServerToGCRequestBatchPlayerResourcesResponse : IMessage<CMsgServerToGCRequestBatchPlayerResourcesResponse>, IEquatable<CMsgServerToGCRequestBatchPlayerResourcesResponse>, IDeepCloneable<CMsgServerToGCRequestBatchPlayerResourcesResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgServerToGCRequestBatchPlayerResourcesResponse](Divine.Protobufs.Dota2.CMsgServerToGCRequestBatchPlayerResourcesResponse.md)

#### Implements

IMessage<CMsgServerToGCRequestBatchPlayerResourcesResponse\>, 
[IEquatable<CMsgServerToGCRequestBatchPlayerResourcesResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgServerToGCRequestBatchPlayerResourcesResponse\>, 
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
[EnumerableExtensions.In<CMsgServerToGCRequestBatchPlayerResourcesResponse\>\(CMsgServerToGCRequestBatchPlayerResourcesResponse, params CMsgServerToGCRequestBatchPlayerResourcesResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRequestBatchPlayerResourcesResponse__ctor"></a> CMsgServerToGCRequestBatchPlayerResourcesResponse\(\)

```csharp
public CMsgServerToGCRequestBatchPlayerResourcesResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRequestBatchPlayerResourcesResponse__ctor_Divine_Protobufs_Dota2_CMsgServerToGCRequestBatchPlayerResourcesResponse_"></a> CMsgServerToGCRequestBatchPlayerResourcesResponse\(CMsgServerToGCRequestBatchPlayerResourcesResponse\)

```csharp
public CMsgServerToGCRequestBatchPlayerResourcesResponse(CMsgServerToGCRequestBatchPlayerResourcesResponse other)
```

#### Parameters

`other` [CMsgServerToGCRequestBatchPlayerResourcesResponse](Divine.Protobufs.Dota2.CMsgServerToGCRequestBatchPlayerResourcesResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRequestBatchPlayerResourcesResponse_ResultsFieldNumber"></a> ResultsFieldNumber

```csharp
public const int ResultsFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRequestBatchPlayerResourcesResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRequestBatchPlayerResourcesResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgServerToGCRequestBatchPlayerResourcesResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgServerToGCRequestBatchPlayerResourcesResponse](Divine.Protobufs.Dota2.CMsgServerToGCRequestBatchPlayerResourcesResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRequestBatchPlayerResourcesResponse_Results"></a> Results

```csharp
public RepeatedField<CMsgServerToGCRequestBatchPlayerResourcesResponse.Types.Result> Results { get; }
```

#### Property Value

 RepeatedField<[CMsgServerToGCRequestBatchPlayerResourcesResponse](Divine.Protobufs.Dota2.CMsgServerToGCRequestBatchPlayerResourcesResponse.md).[Types](Divine.Protobufs.Dota2.CMsgServerToGCRequestBatchPlayerResourcesResponse.Types.md).[Result](Divine.Protobufs.Dota2.CMsgServerToGCRequestBatchPlayerResourcesResponse.Types.Result.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRequestBatchPlayerResourcesResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRequestBatchPlayerResourcesResponse_Clone"></a> Clone\(\)

```csharp
public CMsgServerToGCRequestBatchPlayerResourcesResponse Clone()
```

#### Returns

 [CMsgServerToGCRequestBatchPlayerResourcesResponse](Divine.Protobufs.Dota2.CMsgServerToGCRequestBatchPlayerResourcesResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRequestBatchPlayerResourcesResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRequestBatchPlayerResourcesResponse_Equals_Divine_Protobufs_Dota2_CMsgServerToGCRequestBatchPlayerResourcesResponse_"></a> Equals\(CMsgServerToGCRequestBatchPlayerResourcesResponse\)

```csharp
public bool Equals(CMsgServerToGCRequestBatchPlayerResourcesResponse other)
```

#### Parameters

`other` [CMsgServerToGCRequestBatchPlayerResourcesResponse](Divine.Protobufs.Dota2.CMsgServerToGCRequestBatchPlayerResourcesResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRequestBatchPlayerResourcesResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRequestBatchPlayerResourcesResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgServerToGCRequestBatchPlayerResourcesResponse_"></a> MergeFrom\(CMsgServerToGCRequestBatchPlayerResourcesResponse\)

```csharp
public void MergeFrom(CMsgServerToGCRequestBatchPlayerResourcesResponse other)
```

#### Parameters

`other` [CMsgServerToGCRequestBatchPlayerResourcesResponse](Divine.Protobufs.Dota2.CMsgServerToGCRequestBatchPlayerResourcesResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRequestBatchPlayerResourcesResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRequestBatchPlayerResourcesResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRequestBatchPlayerResourcesResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

