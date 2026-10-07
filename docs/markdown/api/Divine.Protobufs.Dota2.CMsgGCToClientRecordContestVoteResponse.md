# <a id="Divine_Protobufs_Dota2_CMsgGCToClientRecordContestVoteResponse"></a> Class CMsgGCToClientRecordContestVoteResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientRecordContestVoteResponse : IMessage<CMsgGCToClientRecordContestVoteResponse>, IEquatable<CMsgGCToClientRecordContestVoteResponse>, IDeepCloneable<CMsgGCToClientRecordContestVoteResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientRecordContestVoteResponse](Divine.Protobufs.Dota2.CMsgGCToClientRecordContestVoteResponse.md)

#### Implements

IMessage<CMsgGCToClientRecordContestVoteResponse\>, 
[IEquatable<CMsgGCToClientRecordContestVoteResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientRecordContestVoteResponse\>, 
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
[EnumerableExtensions.In<CMsgGCToClientRecordContestVoteResponse\>\(CMsgGCToClientRecordContestVoteResponse, params CMsgGCToClientRecordContestVoteResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRecordContestVoteResponse__ctor"></a> CMsgGCToClientRecordContestVoteResponse\(\)

```csharp
public CMsgGCToClientRecordContestVoteResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRecordContestVoteResponse__ctor_Divine_Protobufs_Dota2_CMsgGCToClientRecordContestVoteResponse_"></a> CMsgGCToClientRecordContestVoteResponse\(CMsgGCToClientRecordContestVoteResponse\)

```csharp
public CMsgGCToClientRecordContestVoteResponse(CMsgGCToClientRecordContestVoteResponse other)
```

#### Parameters

`other` [CMsgGCToClientRecordContestVoteResponse](Divine.Protobufs.Dota2.CMsgGCToClientRecordContestVoteResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRecordContestVoteResponse_EresultFieldNumber"></a> EresultFieldNumber

```csharp
public const int EresultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRecordContestVoteResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRecordContestVoteResponse_Eresult"></a> Eresult

```csharp
public CMsgGCToClientRecordContestVoteResponse.Types.EResult Eresult { get; set; }
```

#### Property Value

 [CMsgGCToClientRecordContestVoteResponse](Divine.Protobufs.Dota2.CMsgGCToClientRecordContestVoteResponse.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientRecordContestVoteResponse.Types.md).[EResult](Divine.Protobufs.Dota2.CMsgGCToClientRecordContestVoteResponse.Types.EResult.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRecordContestVoteResponse_HasEresult"></a> HasEresult

```csharp
public bool HasEresult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRecordContestVoteResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientRecordContestVoteResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientRecordContestVoteResponse](Divine.Protobufs.Dota2.CMsgGCToClientRecordContestVoteResponse.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRecordContestVoteResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRecordContestVoteResponse_ClearEresult"></a> ClearEresult\(\)

```csharp
public void ClearEresult()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRecordContestVoteResponse_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientRecordContestVoteResponse Clone()
```

#### Returns

 [CMsgGCToClientRecordContestVoteResponse](Divine.Protobufs.Dota2.CMsgGCToClientRecordContestVoteResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRecordContestVoteResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRecordContestVoteResponse_Equals_Divine_Protobufs_Dota2_CMsgGCToClientRecordContestVoteResponse_"></a> Equals\(CMsgGCToClientRecordContestVoteResponse\)

```csharp
public bool Equals(CMsgGCToClientRecordContestVoteResponse other)
```

#### Parameters

`other` [CMsgGCToClientRecordContestVoteResponse](Divine.Protobufs.Dota2.CMsgGCToClientRecordContestVoteResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRecordContestVoteResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRecordContestVoteResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientRecordContestVoteResponse_"></a> MergeFrom\(CMsgGCToClientRecordContestVoteResponse\)

```csharp
public void MergeFrom(CMsgGCToClientRecordContestVoteResponse other)
```

#### Parameters

`other` [CMsgGCToClientRecordContestVoteResponse](Divine.Protobufs.Dota2.CMsgGCToClientRecordContestVoteResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRecordContestVoteResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRecordContestVoteResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRecordContestVoteResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

