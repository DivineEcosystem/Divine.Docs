# <a id="Divine_Protobufs_Dota2_CMsgGCRerollPlayerChallengeResponse"></a> Class CMsgGCRerollPlayerChallengeResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCRerollPlayerChallengeResponse : IMessage<CMsgGCRerollPlayerChallengeResponse>, IEquatable<CMsgGCRerollPlayerChallengeResponse>, IDeepCloneable<CMsgGCRerollPlayerChallengeResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCRerollPlayerChallengeResponse](Divine.Protobufs.Dota2.CMsgGCRerollPlayerChallengeResponse.md)

#### Implements

IMessage<CMsgGCRerollPlayerChallengeResponse\>, 
[IEquatable<CMsgGCRerollPlayerChallengeResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCRerollPlayerChallengeResponse\>, 
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
[EnumerableExtensions.In<CMsgGCRerollPlayerChallengeResponse\>\(CMsgGCRerollPlayerChallengeResponse, params CMsgGCRerollPlayerChallengeResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCRerollPlayerChallengeResponse__ctor"></a> CMsgGCRerollPlayerChallengeResponse\(\)

```csharp
public CMsgGCRerollPlayerChallengeResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCRerollPlayerChallengeResponse__ctor_Divine_Protobufs_Dota2_CMsgGCRerollPlayerChallengeResponse_"></a> CMsgGCRerollPlayerChallengeResponse\(CMsgGCRerollPlayerChallengeResponse\)

```csharp
public CMsgGCRerollPlayerChallengeResponse(CMsgGCRerollPlayerChallengeResponse other)
```

#### Parameters

`other` [CMsgGCRerollPlayerChallengeResponse](Divine.Protobufs.Dota2.CMsgGCRerollPlayerChallengeResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCRerollPlayerChallengeResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCRerollPlayerChallengeResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCRerollPlayerChallengeResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCRerollPlayerChallengeResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCRerollPlayerChallengeResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCRerollPlayerChallengeResponse](Divine.Protobufs.Dota2.CMsgGCRerollPlayerChallengeResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCRerollPlayerChallengeResponse_Result"></a> Result

```csharp
public CMsgGCRerollPlayerChallengeResponse.Types.EResult Result { get; set; }
```

#### Property Value

 [CMsgGCRerollPlayerChallengeResponse](Divine.Protobufs.Dota2.CMsgGCRerollPlayerChallengeResponse.md).[Types](Divine.Protobufs.Dota2.CMsgGCRerollPlayerChallengeResponse.Types.md).[EResult](Divine.Protobufs.Dota2.CMsgGCRerollPlayerChallengeResponse.Types.EResult.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCRerollPlayerChallengeResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCRerollPlayerChallengeResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCRerollPlayerChallengeResponse_Clone"></a> Clone\(\)

```csharp
public CMsgGCRerollPlayerChallengeResponse Clone()
```

#### Returns

 [CMsgGCRerollPlayerChallengeResponse](Divine.Protobufs.Dota2.CMsgGCRerollPlayerChallengeResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCRerollPlayerChallengeResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCRerollPlayerChallengeResponse_Equals_Divine_Protobufs_Dota2_CMsgGCRerollPlayerChallengeResponse_"></a> Equals\(CMsgGCRerollPlayerChallengeResponse\)

```csharp
public bool Equals(CMsgGCRerollPlayerChallengeResponse other)
```

#### Parameters

`other` [CMsgGCRerollPlayerChallengeResponse](Divine.Protobufs.Dota2.CMsgGCRerollPlayerChallengeResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCRerollPlayerChallengeResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCRerollPlayerChallengeResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgGCRerollPlayerChallengeResponse_"></a> MergeFrom\(CMsgGCRerollPlayerChallengeResponse\)

```csharp
public void MergeFrom(CMsgGCRerollPlayerChallengeResponse other)
```

#### Parameters

`other` [CMsgGCRerollPlayerChallengeResponse](Divine.Protobufs.Dota2.CMsgGCRerollPlayerChallengeResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCRerollPlayerChallengeResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCRerollPlayerChallengeResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCRerollPlayerChallengeResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

