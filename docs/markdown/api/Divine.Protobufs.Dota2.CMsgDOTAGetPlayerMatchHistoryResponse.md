# <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse"></a> Class CMsgDOTAGetPlayerMatchHistoryResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAGetPlayerMatchHistoryResponse : IMessage<CMsgDOTAGetPlayerMatchHistoryResponse>, IEquatable<CMsgDOTAGetPlayerMatchHistoryResponse>, IDeepCloneable<CMsgDOTAGetPlayerMatchHistoryResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAGetPlayerMatchHistoryResponse](Divine.Protobufs.Dota2.CMsgDOTAGetPlayerMatchHistoryResponse.md)

#### Implements

IMessage<CMsgDOTAGetPlayerMatchHistoryResponse\>, 
[IEquatable<CMsgDOTAGetPlayerMatchHistoryResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAGetPlayerMatchHistoryResponse\>, 
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
[EnumerableExtensions.In<CMsgDOTAGetPlayerMatchHistoryResponse\>\(CMsgDOTAGetPlayerMatchHistoryResponse, params CMsgDOTAGetPlayerMatchHistoryResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse__ctor"></a> CMsgDOTAGetPlayerMatchHistoryResponse\(\)

```csharp
public CMsgDOTAGetPlayerMatchHistoryResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse__ctor_Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_"></a> CMsgDOTAGetPlayerMatchHistoryResponse\(CMsgDOTAGetPlayerMatchHistoryResponse\)

```csharp
public CMsgDOTAGetPlayerMatchHistoryResponse(CMsgDOTAGetPlayerMatchHistoryResponse other)
```

#### Parameters

`other` [CMsgDOTAGetPlayerMatchHistoryResponse](Divine.Protobufs.Dota2.CMsgDOTAGetPlayerMatchHistoryResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_MatchesFieldNumber"></a> MatchesFieldNumber

```csharp
public const int MatchesFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_RequestIdFieldNumber"></a> RequestIdFieldNumber

```csharp
public const int RequestIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_HasRequestId"></a> HasRequestId

```csharp
public bool HasRequestId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Matches"></a> Matches

```csharp
public RepeatedField<CMsgDOTAGetPlayerMatchHistoryResponse.Types.Match> Matches { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTAGetPlayerMatchHistoryResponse](Divine.Protobufs.Dota2.CMsgDOTAGetPlayerMatchHistoryResponse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAGetPlayerMatchHistoryResponse.Types.md).[Match](Divine.Protobufs.Dota2.CMsgDOTAGetPlayerMatchHistoryResponse.Types.Match.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAGetPlayerMatchHistoryResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAGetPlayerMatchHistoryResponse](Divine.Protobufs.Dota2.CMsgDOTAGetPlayerMatchHistoryResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_RequestId"></a> RequestId

```csharp
public uint RequestId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_ClearRequestId"></a> ClearRequestId\(\)

```csharp
public void ClearRequestId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAGetPlayerMatchHistoryResponse Clone()
```

#### Returns

 [CMsgDOTAGetPlayerMatchHistoryResponse](Divine.Protobufs.Dota2.CMsgDOTAGetPlayerMatchHistoryResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_Equals_Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_"></a> Equals\(CMsgDOTAGetPlayerMatchHistoryResponse\)

```csharp
public bool Equals(CMsgDOTAGetPlayerMatchHistoryResponse other)
```

#### Parameters

`other` [CMsgDOTAGetPlayerMatchHistoryResponse](Divine.Protobufs.Dota2.CMsgDOTAGetPlayerMatchHistoryResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_"></a> MergeFrom\(CMsgDOTAGetPlayerMatchHistoryResponse\)

```csharp
public void MergeFrom(CMsgDOTAGetPlayerMatchHistoryResponse other)
```

#### Parameters

`other` [CMsgDOTAGetPlayerMatchHistoryResponse](Divine.Protobufs.Dota2.CMsgDOTAGetPlayerMatchHistoryResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPlayerMatchHistoryResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

