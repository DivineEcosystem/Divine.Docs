# <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlusWeeklyChallengeResultResponse"></a> Class CMsgClientToGCRequestPlusWeeklyChallengeResultResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCRequestPlusWeeklyChallengeResultResponse : IMessage<CMsgClientToGCRequestPlusWeeklyChallengeResultResponse>, IEquatable<CMsgClientToGCRequestPlusWeeklyChallengeResultResponse>, IDeepCloneable<CMsgClientToGCRequestPlusWeeklyChallengeResultResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCRequestPlusWeeklyChallengeResultResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestPlusWeeklyChallengeResultResponse.md)

#### Implements

IMessage<CMsgClientToGCRequestPlusWeeklyChallengeResultResponse\>, 
[IEquatable<CMsgClientToGCRequestPlusWeeklyChallengeResultResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCRequestPlusWeeklyChallengeResultResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCRequestPlusWeeklyChallengeResultResponse\>\(CMsgClientToGCRequestPlusWeeklyChallengeResultResponse, params CMsgClientToGCRequestPlusWeeklyChallengeResultResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlusWeeklyChallengeResultResponse__ctor"></a> CMsgClientToGCRequestPlusWeeklyChallengeResultResponse\(\)

```csharp
public CMsgClientToGCRequestPlusWeeklyChallengeResultResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlusWeeklyChallengeResultResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCRequestPlusWeeklyChallengeResultResponse_"></a> CMsgClientToGCRequestPlusWeeklyChallengeResultResponse\(CMsgClientToGCRequestPlusWeeklyChallengeResultResponse\)

```csharp
public CMsgClientToGCRequestPlusWeeklyChallengeResultResponse(CMsgClientToGCRequestPlusWeeklyChallengeResultResponse other)
```

#### Parameters

`other` [CMsgClientToGCRequestPlusWeeklyChallengeResultResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestPlusWeeklyChallengeResultResponse.md)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlusWeeklyChallengeResultResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlusWeeklyChallengeResultResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCRequestPlusWeeklyChallengeResultResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCRequestPlusWeeklyChallengeResultResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestPlusWeeklyChallengeResultResponse.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlusWeeklyChallengeResultResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlusWeeklyChallengeResultResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCRequestPlusWeeklyChallengeResultResponse Clone()
```

#### Returns

 [CMsgClientToGCRequestPlusWeeklyChallengeResultResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestPlusWeeklyChallengeResultResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlusWeeklyChallengeResultResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlusWeeklyChallengeResultResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCRequestPlusWeeklyChallengeResultResponse_"></a> Equals\(CMsgClientToGCRequestPlusWeeklyChallengeResultResponse\)

```csharp
public bool Equals(CMsgClientToGCRequestPlusWeeklyChallengeResultResponse other)
```

#### Parameters

`other` [CMsgClientToGCRequestPlusWeeklyChallengeResultResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestPlusWeeklyChallengeResultResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlusWeeklyChallengeResultResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlusWeeklyChallengeResultResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCRequestPlusWeeklyChallengeResultResponse_"></a> MergeFrom\(CMsgClientToGCRequestPlusWeeklyChallengeResultResponse\)

```csharp
public void MergeFrom(CMsgClientToGCRequestPlusWeeklyChallengeResultResponse other)
```

#### Parameters

`other` [CMsgClientToGCRequestPlusWeeklyChallengeResultResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestPlusWeeklyChallengeResultResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlusWeeklyChallengeResultResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlusWeeklyChallengeResultResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlusWeeklyChallengeResultResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

