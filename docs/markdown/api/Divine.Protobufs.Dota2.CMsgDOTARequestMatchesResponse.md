# <a id="Divine_Protobufs_Dota2_CMsgDOTARequestMatchesResponse"></a> Class CMsgDOTARequestMatchesResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTARequestMatchesResponse : IMessage<CMsgDOTARequestMatchesResponse>, IEquatable<CMsgDOTARequestMatchesResponse>, IDeepCloneable<CMsgDOTARequestMatchesResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTARequestMatchesResponse](Divine.Protobufs.Dota2.CMsgDOTARequestMatchesResponse.md)

#### Implements

IMessage<CMsgDOTARequestMatchesResponse\>, 
[IEquatable<CMsgDOTARequestMatchesResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTARequestMatchesResponse\>, 
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
[EnumerableExtensions.In<CMsgDOTARequestMatchesResponse\>\(CMsgDOTARequestMatchesResponse, params CMsgDOTARequestMatchesResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestMatchesResponse__ctor"></a> CMsgDOTARequestMatchesResponse\(\)

```csharp
public CMsgDOTARequestMatchesResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestMatchesResponse__ctor_Divine_Protobufs_Dota2_CMsgDOTARequestMatchesResponse_"></a> CMsgDOTARequestMatchesResponse\(CMsgDOTARequestMatchesResponse\)

```csharp
public CMsgDOTARequestMatchesResponse(CMsgDOTARequestMatchesResponse other)
```

#### Parameters

`other` [CMsgDOTARequestMatchesResponse](Divine.Protobufs.Dota2.CMsgDOTARequestMatchesResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestMatchesResponse_MatchesFieldNumber"></a> MatchesFieldNumber

```csharp
public const int MatchesFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestMatchesResponse_RequestIdFieldNumber"></a> RequestIdFieldNumber

```csharp
public const int RequestIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestMatchesResponse_ResultsRemainingFieldNumber"></a> ResultsRemainingFieldNumber

```csharp
public const int ResultsRemainingFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestMatchesResponse_SeriesFieldNumber"></a> SeriesFieldNumber

```csharp
public const int SeriesFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestMatchesResponse_TotalResultsFieldNumber"></a> TotalResultsFieldNumber

```csharp
public const int TotalResultsFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestMatchesResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestMatchesResponse_HasRequestId"></a> HasRequestId

```csharp
public bool HasRequestId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestMatchesResponse_HasResultsRemaining"></a> HasResultsRemaining

```csharp
public bool HasResultsRemaining { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestMatchesResponse_HasTotalResults"></a> HasTotalResults

```csharp
public bool HasTotalResults { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestMatchesResponse_Matches"></a> Matches

```csharp
public RepeatedField<CMsgDOTAMatch> Matches { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTAMatch](Divine.Protobufs.Dota2.CMsgDOTAMatch.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestMatchesResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTARequestMatchesResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTARequestMatchesResponse](Divine.Protobufs.Dota2.CMsgDOTARequestMatchesResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestMatchesResponse_RequestId"></a> RequestId

```csharp
public uint RequestId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestMatchesResponse_ResultsRemaining"></a> ResultsRemaining

```csharp
public uint ResultsRemaining { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestMatchesResponse_Series"></a> Series

```csharp
public RepeatedField<CMsgDOTARequestMatchesResponse.Types.Series> Series { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTARequestMatchesResponse](Divine.Protobufs.Dota2.CMsgDOTARequestMatchesResponse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARequestMatchesResponse.Types.md).[Series](Divine.Protobufs.Dota2.CMsgDOTARequestMatchesResponse.Types.Series.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestMatchesResponse_TotalResults"></a> TotalResults

```csharp
public uint TotalResults { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestMatchesResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestMatchesResponse_ClearRequestId"></a> ClearRequestId\(\)

```csharp
public void ClearRequestId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestMatchesResponse_ClearResultsRemaining"></a> ClearResultsRemaining\(\)

```csharp
public void ClearResultsRemaining()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestMatchesResponse_ClearTotalResults"></a> ClearTotalResults\(\)

```csharp
public void ClearTotalResults()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestMatchesResponse_Clone"></a> Clone\(\)

```csharp
public CMsgDOTARequestMatchesResponse Clone()
```

#### Returns

 [CMsgDOTARequestMatchesResponse](Divine.Protobufs.Dota2.CMsgDOTARequestMatchesResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestMatchesResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestMatchesResponse_Equals_Divine_Protobufs_Dota2_CMsgDOTARequestMatchesResponse_"></a> Equals\(CMsgDOTARequestMatchesResponse\)

```csharp
public bool Equals(CMsgDOTARequestMatchesResponse other)
```

#### Parameters

`other` [CMsgDOTARequestMatchesResponse](Divine.Protobufs.Dota2.CMsgDOTARequestMatchesResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestMatchesResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestMatchesResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTARequestMatchesResponse_"></a> MergeFrom\(CMsgDOTARequestMatchesResponse\)

```csharp
public void MergeFrom(CMsgDOTARequestMatchesResponse other)
```

#### Parameters

`other` [CMsgDOTARequestMatchesResponse](Divine.Protobufs.Dota2.CMsgDOTARequestMatchesResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestMatchesResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestMatchesResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARequestMatchesResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

