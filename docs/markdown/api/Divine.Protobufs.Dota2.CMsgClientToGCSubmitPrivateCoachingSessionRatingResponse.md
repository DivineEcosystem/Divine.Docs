# <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitPrivateCoachingSessionRatingResponse"></a> Class CMsgClientToGCSubmitPrivateCoachingSessionRatingResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCSubmitPrivateCoachingSessionRatingResponse : IMessage<CMsgClientToGCSubmitPrivateCoachingSessionRatingResponse>, IEquatable<CMsgClientToGCSubmitPrivateCoachingSessionRatingResponse>, IDeepCloneable<CMsgClientToGCSubmitPrivateCoachingSessionRatingResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCSubmitPrivateCoachingSessionRatingResponse](Divine.Protobufs.Dota2.CMsgClientToGCSubmitPrivateCoachingSessionRatingResponse.md)

#### Implements

IMessage<CMsgClientToGCSubmitPrivateCoachingSessionRatingResponse\>, 
[IEquatable<CMsgClientToGCSubmitPrivateCoachingSessionRatingResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCSubmitPrivateCoachingSessionRatingResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCSubmitPrivateCoachingSessionRatingResponse\>\(CMsgClientToGCSubmitPrivateCoachingSessionRatingResponse, params CMsgClientToGCSubmitPrivateCoachingSessionRatingResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitPrivateCoachingSessionRatingResponse__ctor"></a> CMsgClientToGCSubmitPrivateCoachingSessionRatingResponse\(\)

```csharp
public CMsgClientToGCSubmitPrivateCoachingSessionRatingResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitPrivateCoachingSessionRatingResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCSubmitPrivateCoachingSessionRatingResponse_"></a> CMsgClientToGCSubmitPrivateCoachingSessionRatingResponse\(CMsgClientToGCSubmitPrivateCoachingSessionRatingResponse\)

```csharp
public CMsgClientToGCSubmitPrivateCoachingSessionRatingResponse(CMsgClientToGCSubmitPrivateCoachingSessionRatingResponse other)
```

#### Parameters

`other` [CMsgClientToGCSubmitPrivateCoachingSessionRatingResponse](Divine.Protobufs.Dota2.CMsgClientToGCSubmitPrivateCoachingSessionRatingResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitPrivateCoachingSessionRatingResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitPrivateCoachingSessionRatingResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitPrivateCoachingSessionRatingResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitPrivateCoachingSessionRatingResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCSubmitPrivateCoachingSessionRatingResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCSubmitPrivateCoachingSessionRatingResponse](Divine.Protobufs.Dota2.CMsgClientToGCSubmitPrivateCoachingSessionRatingResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitPrivateCoachingSessionRatingResponse_Result"></a> Result

```csharp
public CMsgClientToGCSubmitPrivateCoachingSessionRatingResponse.Types.EResponse Result { get; set; }
```

#### Property Value

 [CMsgClientToGCSubmitPrivateCoachingSessionRatingResponse](Divine.Protobufs.Dota2.CMsgClientToGCSubmitPrivateCoachingSessionRatingResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCSubmitPrivateCoachingSessionRatingResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCSubmitPrivateCoachingSessionRatingResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitPrivateCoachingSessionRatingResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitPrivateCoachingSessionRatingResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitPrivateCoachingSessionRatingResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCSubmitPrivateCoachingSessionRatingResponse Clone()
```

#### Returns

 [CMsgClientToGCSubmitPrivateCoachingSessionRatingResponse](Divine.Protobufs.Dota2.CMsgClientToGCSubmitPrivateCoachingSessionRatingResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitPrivateCoachingSessionRatingResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitPrivateCoachingSessionRatingResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCSubmitPrivateCoachingSessionRatingResponse_"></a> Equals\(CMsgClientToGCSubmitPrivateCoachingSessionRatingResponse\)

```csharp
public bool Equals(CMsgClientToGCSubmitPrivateCoachingSessionRatingResponse other)
```

#### Parameters

`other` [CMsgClientToGCSubmitPrivateCoachingSessionRatingResponse](Divine.Protobufs.Dota2.CMsgClientToGCSubmitPrivateCoachingSessionRatingResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitPrivateCoachingSessionRatingResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitPrivateCoachingSessionRatingResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCSubmitPrivateCoachingSessionRatingResponse_"></a> MergeFrom\(CMsgClientToGCSubmitPrivateCoachingSessionRatingResponse\)

```csharp
public void MergeFrom(CMsgClientToGCSubmitPrivateCoachingSessionRatingResponse other)
```

#### Parameters

`other` [CMsgClientToGCSubmitPrivateCoachingSessionRatingResponse](Divine.Protobufs.Dota2.CMsgClientToGCSubmitPrivateCoachingSessionRatingResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitPrivateCoachingSessionRatingResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitPrivateCoachingSessionRatingResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitPrivateCoachingSessionRatingResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

