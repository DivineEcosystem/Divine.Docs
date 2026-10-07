# <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollConvarResponse"></a> Class CMsgGCToClientPollConvarResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientPollConvarResponse : IMessage<CMsgGCToClientPollConvarResponse>, IEquatable<CMsgGCToClientPollConvarResponse>, IDeepCloneable<CMsgGCToClientPollConvarResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientPollConvarResponse](Divine.Protobufs.Dota2.CMsgGCToClientPollConvarResponse.md)

#### Implements

IMessage<CMsgGCToClientPollConvarResponse\>, 
[IEquatable<CMsgGCToClientPollConvarResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientPollConvarResponse\>, 
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
[EnumerableExtensions.In<CMsgGCToClientPollConvarResponse\>\(CMsgGCToClientPollConvarResponse, params CMsgGCToClientPollConvarResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollConvarResponse__ctor"></a> CMsgGCToClientPollConvarResponse\(\)

```csharp
public CMsgGCToClientPollConvarResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollConvarResponse__ctor_Divine_Protobufs_Dota2_CMsgGCToClientPollConvarResponse_"></a> CMsgGCToClientPollConvarResponse\(CMsgGCToClientPollConvarResponse\)

```csharp
public CMsgGCToClientPollConvarResponse(CMsgGCToClientPollConvarResponse other)
```

#### Parameters

`other` [CMsgGCToClientPollConvarResponse](Divine.Protobufs.Dota2.CMsgGCToClientPollConvarResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollConvarResponse_ConvarValueFieldNumber"></a> ConvarValueFieldNumber

```csharp
public const int ConvarValueFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollConvarResponse_PollIdFieldNumber"></a> PollIdFieldNumber

```csharp
public const int PollIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollConvarResponse_ConvarValue"></a> ConvarValue

```csharp
public string ConvarValue { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollConvarResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollConvarResponse_HasConvarValue"></a> HasConvarValue

```csharp
public bool HasConvarValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollConvarResponse_HasPollId"></a> HasPollId

```csharp
public bool HasPollId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollConvarResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientPollConvarResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientPollConvarResponse](Divine.Protobufs.Dota2.CMsgGCToClientPollConvarResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollConvarResponse_PollId"></a> PollId

```csharp
public uint PollId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollConvarResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollConvarResponse_ClearConvarValue"></a> ClearConvarValue\(\)

```csharp
public void ClearConvarValue()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollConvarResponse_ClearPollId"></a> ClearPollId\(\)

```csharp
public void ClearPollId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollConvarResponse_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientPollConvarResponse Clone()
```

#### Returns

 [CMsgGCToClientPollConvarResponse](Divine.Protobufs.Dota2.CMsgGCToClientPollConvarResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollConvarResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollConvarResponse_Equals_Divine_Protobufs_Dota2_CMsgGCToClientPollConvarResponse_"></a> Equals\(CMsgGCToClientPollConvarResponse\)

```csharp
public bool Equals(CMsgGCToClientPollConvarResponse other)
```

#### Parameters

`other` [CMsgGCToClientPollConvarResponse](Divine.Protobufs.Dota2.CMsgGCToClientPollConvarResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollConvarResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollConvarResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientPollConvarResponse_"></a> MergeFrom\(CMsgGCToClientPollConvarResponse\)

```csharp
public void MergeFrom(CMsgGCToClientPollConvarResponse other)
```

#### Parameters

`other` [CMsgGCToClientPollConvarResponse](Divine.Protobufs.Dota2.CMsgGCToClientPollConvarResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollConvarResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollConvarResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollConvarResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

