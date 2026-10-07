# <a id="Divine_Protobufs_Dota2_CMsgGCMatchDetailsResponse"></a> Class CMsgGCMatchDetailsResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCMatchDetailsResponse : IMessage<CMsgGCMatchDetailsResponse>, IEquatable<CMsgGCMatchDetailsResponse>, IDeepCloneable<CMsgGCMatchDetailsResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCMatchDetailsResponse](Divine.Protobufs.Dota2.CMsgGCMatchDetailsResponse.md)

#### Implements

IMessage<CMsgGCMatchDetailsResponse\>, 
[IEquatable<CMsgGCMatchDetailsResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCMatchDetailsResponse\>, 
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
[EnumerableExtensions.In<CMsgGCMatchDetailsResponse\>\(CMsgGCMatchDetailsResponse, params CMsgGCMatchDetailsResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCMatchDetailsResponse__ctor"></a> CMsgGCMatchDetailsResponse\(\)

```csharp
public CMsgGCMatchDetailsResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCMatchDetailsResponse__ctor_Divine_Protobufs_Dota2_CMsgGCMatchDetailsResponse_"></a> CMsgGCMatchDetailsResponse\(CMsgGCMatchDetailsResponse\)

```csharp
public CMsgGCMatchDetailsResponse(CMsgGCMatchDetailsResponse other)
```

#### Parameters

`other` [CMsgGCMatchDetailsResponse](Divine.Protobufs.Dota2.CMsgGCMatchDetailsResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCMatchDetailsResponse_MatchFieldNumber"></a> MatchFieldNumber

```csharp
public const int MatchFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCMatchDetailsResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCMatchDetailsResponse_VoteFieldNumber"></a> VoteFieldNumber

```csharp
public const int VoteFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCMatchDetailsResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCMatchDetailsResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCMatchDetailsResponse_HasVote"></a> HasVote

```csharp
public bool HasVote { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCMatchDetailsResponse_Match"></a> Match

```csharp
public CMsgDOTAMatch Match { get; set; }
```

#### Property Value

 [CMsgDOTAMatch](Divine.Protobufs.Dota2.CMsgDOTAMatch.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCMatchDetailsResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCMatchDetailsResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCMatchDetailsResponse](Divine.Protobufs.Dota2.CMsgGCMatchDetailsResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCMatchDetailsResponse_Result"></a> Result

```csharp
public uint Result { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCMatchDetailsResponse_Vote"></a> Vote

```csharp
public DOTAMatchVote Vote { get; set; }
```

#### Property Value

 [DOTAMatchVote](Divine.Protobufs.Dota2.DOTAMatchVote.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCMatchDetailsResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCMatchDetailsResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCMatchDetailsResponse_ClearVote"></a> ClearVote\(\)

```csharp
public void ClearVote()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCMatchDetailsResponse_Clone"></a> Clone\(\)

```csharp
public CMsgGCMatchDetailsResponse Clone()
```

#### Returns

 [CMsgGCMatchDetailsResponse](Divine.Protobufs.Dota2.CMsgGCMatchDetailsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCMatchDetailsResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCMatchDetailsResponse_Equals_Divine_Protobufs_Dota2_CMsgGCMatchDetailsResponse_"></a> Equals\(CMsgGCMatchDetailsResponse\)

```csharp
public bool Equals(CMsgGCMatchDetailsResponse other)
```

#### Parameters

`other` [CMsgGCMatchDetailsResponse](Divine.Protobufs.Dota2.CMsgGCMatchDetailsResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCMatchDetailsResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCMatchDetailsResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgGCMatchDetailsResponse_"></a> MergeFrom\(CMsgGCMatchDetailsResponse\)

```csharp
public void MergeFrom(CMsgGCMatchDetailsResponse other)
```

#### Parameters

`other` [CMsgGCMatchDetailsResponse](Divine.Protobufs.Dota2.CMsgGCMatchDetailsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCMatchDetailsResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCMatchDetailsResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCMatchDetailsResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

