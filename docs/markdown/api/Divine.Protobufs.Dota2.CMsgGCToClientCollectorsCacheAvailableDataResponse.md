# <a id="Divine_Protobufs_Dota2_CMsgGCToClientCollectorsCacheAvailableDataResponse"></a> Class CMsgGCToClientCollectorsCacheAvailableDataResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientCollectorsCacheAvailableDataResponse : IMessage<CMsgGCToClientCollectorsCacheAvailableDataResponse>, IEquatable<CMsgGCToClientCollectorsCacheAvailableDataResponse>, IDeepCloneable<CMsgGCToClientCollectorsCacheAvailableDataResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientCollectorsCacheAvailableDataResponse](Divine.Protobufs.Dota2.CMsgGCToClientCollectorsCacheAvailableDataResponse.md)

#### Implements

IMessage<CMsgGCToClientCollectorsCacheAvailableDataResponse\>, 
[IEquatable<CMsgGCToClientCollectorsCacheAvailableDataResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientCollectorsCacheAvailableDataResponse\>, 
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
[EnumerableExtensions.In<CMsgGCToClientCollectorsCacheAvailableDataResponse\>\(CMsgGCToClientCollectorsCacheAvailableDataResponse, params CMsgGCToClientCollectorsCacheAvailableDataResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCollectorsCacheAvailableDataResponse__ctor"></a> CMsgGCToClientCollectorsCacheAvailableDataResponse\(\)

```csharp
public CMsgGCToClientCollectorsCacheAvailableDataResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCollectorsCacheAvailableDataResponse__ctor_Divine_Protobufs_Dota2_CMsgGCToClientCollectorsCacheAvailableDataResponse_"></a> CMsgGCToClientCollectorsCacheAvailableDataResponse\(CMsgGCToClientCollectorsCacheAvailableDataResponse\)

```csharp
public CMsgGCToClientCollectorsCacheAvailableDataResponse(CMsgGCToClientCollectorsCacheAvailableDataResponse other)
```

#### Parameters

`other` [CMsgGCToClientCollectorsCacheAvailableDataResponse](Divine.Protobufs.Dota2.CMsgGCToClientCollectorsCacheAvailableDataResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCollectorsCacheAvailableDataResponse_VotesFieldNumber"></a> VotesFieldNumber

```csharp
public const int VotesFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCollectorsCacheAvailableDataResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCollectorsCacheAvailableDataResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientCollectorsCacheAvailableDataResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientCollectorsCacheAvailableDataResponse](Divine.Protobufs.Dota2.CMsgGCToClientCollectorsCacheAvailableDataResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCollectorsCacheAvailableDataResponse_Votes"></a> Votes

```csharp
public RepeatedField<CMsgGCToClientCollectorsCacheAvailableDataResponse.Types.Vote> Votes { get; }
```

#### Property Value

 RepeatedField<[CMsgGCToClientCollectorsCacheAvailableDataResponse](Divine.Protobufs.Dota2.CMsgGCToClientCollectorsCacheAvailableDataResponse.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientCollectorsCacheAvailableDataResponse.Types.md).[Vote](Divine.Protobufs.Dota2.CMsgGCToClientCollectorsCacheAvailableDataResponse.Types.Vote.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCollectorsCacheAvailableDataResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCollectorsCacheAvailableDataResponse_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientCollectorsCacheAvailableDataResponse Clone()
```

#### Returns

 [CMsgGCToClientCollectorsCacheAvailableDataResponse](Divine.Protobufs.Dota2.CMsgGCToClientCollectorsCacheAvailableDataResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCollectorsCacheAvailableDataResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCollectorsCacheAvailableDataResponse_Equals_Divine_Protobufs_Dota2_CMsgGCToClientCollectorsCacheAvailableDataResponse_"></a> Equals\(CMsgGCToClientCollectorsCacheAvailableDataResponse\)

```csharp
public bool Equals(CMsgGCToClientCollectorsCacheAvailableDataResponse other)
```

#### Parameters

`other` [CMsgGCToClientCollectorsCacheAvailableDataResponse](Divine.Protobufs.Dota2.CMsgGCToClientCollectorsCacheAvailableDataResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCollectorsCacheAvailableDataResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCollectorsCacheAvailableDataResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientCollectorsCacheAvailableDataResponse_"></a> MergeFrom\(CMsgGCToClientCollectorsCacheAvailableDataResponse\)

```csharp
public void MergeFrom(CMsgGCToClientCollectorsCacheAvailableDataResponse other)
```

#### Parameters

`other` [CMsgGCToClientCollectorsCacheAvailableDataResponse](Divine.Protobufs.Dota2.CMsgGCToClientCollectorsCacheAvailableDataResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCollectorsCacheAvailableDataResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCollectorsCacheAvailableDataResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCollectorsCacheAvailableDataResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

