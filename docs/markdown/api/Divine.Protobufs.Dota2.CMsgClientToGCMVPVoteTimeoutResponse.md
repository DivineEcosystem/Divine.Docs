# <a id="Divine_Protobufs_Dota2_CMsgClientToGCMVPVoteTimeoutResponse"></a> Class CMsgClientToGCMVPVoteTimeoutResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCMVPVoteTimeoutResponse : IMessage<CMsgClientToGCMVPVoteTimeoutResponse>, IEquatable<CMsgClientToGCMVPVoteTimeoutResponse>, IDeepCloneable<CMsgClientToGCMVPVoteTimeoutResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCMVPVoteTimeoutResponse](Divine.Protobufs.Dota2.CMsgClientToGCMVPVoteTimeoutResponse.md)

#### Implements

IMessage<CMsgClientToGCMVPVoteTimeoutResponse\>, 
[IEquatable<CMsgClientToGCMVPVoteTimeoutResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCMVPVoteTimeoutResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCMVPVoteTimeoutResponse\>\(CMsgClientToGCMVPVoteTimeoutResponse, params CMsgClientToGCMVPVoteTimeoutResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMVPVoteTimeoutResponse__ctor"></a> CMsgClientToGCMVPVoteTimeoutResponse\(\)

```csharp
public CMsgClientToGCMVPVoteTimeoutResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMVPVoteTimeoutResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCMVPVoteTimeoutResponse_"></a> CMsgClientToGCMVPVoteTimeoutResponse\(CMsgClientToGCMVPVoteTimeoutResponse\)

```csharp
public CMsgClientToGCMVPVoteTimeoutResponse(CMsgClientToGCMVPVoteTimeoutResponse other)
```

#### Parameters

`other` [CMsgClientToGCMVPVoteTimeoutResponse](Divine.Protobufs.Dota2.CMsgClientToGCMVPVoteTimeoutResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMVPVoteTimeoutResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMVPVoteTimeoutResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMVPVoteTimeoutResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMVPVoteTimeoutResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCMVPVoteTimeoutResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCMVPVoteTimeoutResponse](Divine.Protobufs.Dota2.CMsgClientToGCMVPVoteTimeoutResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMVPVoteTimeoutResponse_Result"></a> Result

```csharp
public bool Result { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMVPVoteTimeoutResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMVPVoteTimeoutResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMVPVoteTimeoutResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCMVPVoteTimeoutResponse Clone()
```

#### Returns

 [CMsgClientToGCMVPVoteTimeoutResponse](Divine.Protobufs.Dota2.CMsgClientToGCMVPVoteTimeoutResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMVPVoteTimeoutResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMVPVoteTimeoutResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCMVPVoteTimeoutResponse_"></a> Equals\(CMsgClientToGCMVPVoteTimeoutResponse\)

```csharp
public bool Equals(CMsgClientToGCMVPVoteTimeoutResponse other)
```

#### Parameters

`other` [CMsgClientToGCMVPVoteTimeoutResponse](Divine.Protobufs.Dota2.CMsgClientToGCMVPVoteTimeoutResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMVPVoteTimeoutResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMVPVoteTimeoutResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCMVPVoteTimeoutResponse_"></a> MergeFrom\(CMsgClientToGCMVPVoteTimeoutResponse\)

```csharp
public void MergeFrom(CMsgClientToGCMVPVoteTimeoutResponse other)
```

#### Parameters

`other` [CMsgClientToGCMVPVoteTimeoutResponse](Divine.Protobufs.Dota2.CMsgClientToGCMVPVoteTimeoutResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMVPVoteTimeoutResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMVPVoteTimeoutResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMVPVoteTimeoutResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

