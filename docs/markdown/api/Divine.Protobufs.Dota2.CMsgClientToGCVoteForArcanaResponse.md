# <a id="Divine_Protobufs_Dota2_CMsgClientToGCVoteForArcanaResponse"></a> Class CMsgClientToGCVoteForArcanaResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCVoteForArcanaResponse : IMessage<CMsgClientToGCVoteForArcanaResponse>, IEquatable<CMsgClientToGCVoteForArcanaResponse>, IDeepCloneable<CMsgClientToGCVoteForArcanaResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCVoteForArcanaResponse](Divine.Protobufs.Dota2.CMsgClientToGCVoteForArcanaResponse.md)

#### Implements

IMessage<CMsgClientToGCVoteForArcanaResponse\>, 
[IEquatable<CMsgClientToGCVoteForArcanaResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCVoteForArcanaResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCVoteForArcanaResponse\>\(CMsgClientToGCVoteForArcanaResponse, params CMsgClientToGCVoteForArcanaResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCVoteForArcanaResponse__ctor"></a> CMsgClientToGCVoteForArcanaResponse\(\)

```csharp
public CMsgClientToGCVoteForArcanaResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCVoteForArcanaResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCVoteForArcanaResponse_"></a> CMsgClientToGCVoteForArcanaResponse\(CMsgClientToGCVoteForArcanaResponse\)

```csharp
public CMsgClientToGCVoteForArcanaResponse(CMsgClientToGCVoteForArcanaResponse other)
```

#### Parameters

`other` [CMsgClientToGCVoteForArcanaResponse](Divine.Protobufs.Dota2.CMsgClientToGCVoteForArcanaResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCVoteForArcanaResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCVoteForArcanaResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCVoteForArcanaResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCVoteForArcanaResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCVoteForArcanaResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCVoteForArcanaResponse](Divine.Protobufs.Dota2.CMsgClientToGCVoteForArcanaResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCVoteForArcanaResponse_Result"></a> Result

```csharp
public CMsgClientToGCVoteForArcanaResponse.Types.Result Result { get; set; }
```

#### Property Value

 [CMsgClientToGCVoteForArcanaResponse](Divine.Protobufs.Dota2.CMsgClientToGCVoteForArcanaResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCVoteForArcanaResponse.Types.md).[Result](Divine.Protobufs.Dota2.CMsgClientToGCVoteForArcanaResponse.Types.Result.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCVoteForArcanaResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCVoteForArcanaResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCVoteForArcanaResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCVoteForArcanaResponse Clone()
```

#### Returns

 [CMsgClientToGCVoteForArcanaResponse](Divine.Protobufs.Dota2.CMsgClientToGCVoteForArcanaResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCVoteForArcanaResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCVoteForArcanaResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCVoteForArcanaResponse_"></a> Equals\(CMsgClientToGCVoteForArcanaResponse\)

```csharp
public bool Equals(CMsgClientToGCVoteForArcanaResponse other)
```

#### Parameters

`other` [CMsgClientToGCVoteForArcanaResponse](Divine.Protobufs.Dota2.CMsgClientToGCVoteForArcanaResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCVoteForArcanaResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCVoteForArcanaResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCVoteForArcanaResponse_"></a> MergeFrom\(CMsgClientToGCVoteForArcanaResponse\)

```csharp
public void MergeFrom(CMsgClientToGCVoteForArcanaResponse other)
```

#### Parameters

`other` [CMsgClientToGCVoteForArcanaResponse](Divine.Protobufs.Dota2.CMsgClientToGCVoteForArcanaResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCVoteForArcanaResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCVoteForArcanaResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCVoteForArcanaResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

