# <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestActiveGuildChallengeResponse"></a> Class CMsgClientToGCRequestActiveGuildChallengeResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCRequestActiveGuildChallengeResponse : IMessage<CMsgClientToGCRequestActiveGuildChallengeResponse>, IEquatable<CMsgClientToGCRequestActiveGuildChallengeResponse>, IDeepCloneable<CMsgClientToGCRequestActiveGuildChallengeResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCRequestActiveGuildChallengeResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestActiveGuildChallengeResponse.md)

#### Implements

IMessage<CMsgClientToGCRequestActiveGuildChallengeResponse\>, 
[IEquatable<CMsgClientToGCRequestActiveGuildChallengeResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCRequestActiveGuildChallengeResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCRequestActiveGuildChallengeResponse\>\(CMsgClientToGCRequestActiveGuildChallengeResponse, params CMsgClientToGCRequestActiveGuildChallengeResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestActiveGuildChallengeResponse__ctor"></a> CMsgClientToGCRequestActiveGuildChallengeResponse\(\)

```csharp
public CMsgClientToGCRequestActiveGuildChallengeResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestActiveGuildChallengeResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCRequestActiveGuildChallengeResponse_"></a> CMsgClientToGCRequestActiveGuildChallengeResponse\(CMsgClientToGCRequestActiveGuildChallengeResponse\)

```csharp
public CMsgClientToGCRequestActiveGuildChallengeResponse(CMsgClientToGCRequestActiveGuildChallengeResponse other)
```

#### Parameters

`other` [CMsgClientToGCRequestActiveGuildChallengeResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestActiveGuildChallengeResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestActiveGuildChallengeResponse_ActiveChallengeFieldNumber"></a> ActiveChallengeFieldNumber

```csharp
public const int ActiveChallengeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestActiveGuildChallengeResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestActiveGuildChallengeResponse_ActiveChallenge"></a> ActiveChallenge

```csharp
public CMsgGuildChallenge ActiveChallenge { get; set; }
```

#### Property Value

 [CMsgGuildChallenge](Divine.Protobufs.Dota2.CMsgGuildChallenge.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestActiveGuildChallengeResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestActiveGuildChallengeResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestActiveGuildChallengeResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCRequestActiveGuildChallengeResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCRequestActiveGuildChallengeResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestActiveGuildChallengeResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestActiveGuildChallengeResponse_Result"></a> Result

```csharp
public CMsgClientToGCRequestActiveGuildChallengeResponse.Types.EResponse Result { get; set; }
```

#### Property Value

 [CMsgClientToGCRequestActiveGuildChallengeResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestActiveGuildChallengeResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCRequestActiveGuildChallengeResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestActiveGuildChallengeResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestActiveGuildChallengeResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestActiveGuildChallengeResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestActiveGuildChallengeResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCRequestActiveGuildChallengeResponse Clone()
```

#### Returns

 [CMsgClientToGCRequestActiveGuildChallengeResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestActiveGuildChallengeResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestActiveGuildChallengeResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestActiveGuildChallengeResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCRequestActiveGuildChallengeResponse_"></a> Equals\(CMsgClientToGCRequestActiveGuildChallengeResponse\)

```csharp
public bool Equals(CMsgClientToGCRequestActiveGuildChallengeResponse other)
```

#### Parameters

`other` [CMsgClientToGCRequestActiveGuildChallengeResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestActiveGuildChallengeResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestActiveGuildChallengeResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestActiveGuildChallengeResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCRequestActiveGuildChallengeResponse_"></a> MergeFrom\(CMsgClientToGCRequestActiveGuildChallengeResponse\)

```csharp
public void MergeFrom(CMsgClientToGCRequestActiveGuildChallengeResponse other)
```

#### Parameters

`other` [CMsgClientToGCRequestActiveGuildChallengeResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestActiveGuildChallengeResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestActiveGuildChallengeResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestActiveGuildChallengeResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestActiveGuildChallengeResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

