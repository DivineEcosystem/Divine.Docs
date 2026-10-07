# <a id="Divine_Protobufs_Dota2_CMsgClientToGCHasPlayerVotedForMVPResponse"></a> Class CMsgClientToGCHasPlayerVotedForMVPResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCHasPlayerVotedForMVPResponse : IMessage<CMsgClientToGCHasPlayerVotedForMVPResponse>, IEquatable<CMsgClientToGCHasPlayerVotedForMVPResponse>, IDeepCloneable<CMsgClientToGCHasPlayerVotedForMVPResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCHasPlayerVotedForMVPResponse](Divine.Protobufs.Dota2.CMsgClientToGCHasPlayerVotedForMVPResponse.md)

#### Implements

IMessage<CMsgClientToGCHasPlayerVotedForMVPResponse\>, 
[IEquatable<CMsgClientToGCHasPlayerVotedForMVPResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCHasPlayerVotedForMVPResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCHasPlayerVotedForMVPResponse\>\(CMsgClientToGCHasPlayerVotedForMVPResponse, params CMsgClientToGCHasPlayerVotedForMVPResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCHasPlayerVotedForMVPResponse__ctor"></a> CMsgClientToGCHasPlayerVotedForMVPResponse\(\)

```csharp
public CMsgClientToGCHasPlayerVotedForMVPResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCHasPlayerVotedForMVPResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCHasPlayerVotedForMVPResponse_"></a> CMsgClientToGCHasPlayerVotedForMVPResponse\(CMsgClientToGCHasPlayerVotedForMVPResponse\)

```csharp
public CMsgClientToGCHasPlayerVotedForMVPResponse(CMsgClientToGCHasPlayerVotedForMVPResponse other)
```

#### Parameters

`other` [CMsgClientToGCHasPlayerVotedForMVPResponse](Divine.Protobufs.Dota2.CMsgClientToGCHasPlayerVotedForMVPResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCHasPlayerVotedForMVPResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCHasPlayerVotedForMVPResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCHasPlayerVotedForMVPResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCHasPlayerVotedForMVPResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCHasPlayerVotedForMVPResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCHasPlayerVotedForMVPResponse](Divine.Protobufs.Dota2.CMsgClientToGCHasPlayerVotedForMVPResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCHasPlayerVotedForMVPResponse_Result"></a> Result

```csharp
public bool Result { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCHasPlayerVotedForMVPResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCHasPlayerVotedForMVPResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCHasPlayerVotedForMVPResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCHasPlayerVotedForMVPResponse Clone()
```

#### Returns

 [CMsgClientToGCHasPlayerVotedForMVPResponse](Divine.Protobufs.Dota2.CMsgClientToGCHasPlayerVotedForMVPResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCHasPlayerVotedForMVPResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCHasPlayerVotedForMVPResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCHasPlayerVotedForMVPResponse_"></a> Equals\(CMsgClientToGCHasPlayerVotedForMVPResponse\)

```csharp
public bool Equals(CMsgClientToGCHasPlayerVotedForMVPResponse other)
```

#### Parameters

`other` [CMsgClientToGCHasPlayerVotedForMVPResponse](Divine.Protobufs.Dota2.CMsgClientToGCHasPlayerVotedForMVPResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCHasPlayerVotedForMVPResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCHasPlayerVotedForMVPResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCHasPlayerVotedForMVPResponse_"></a> MergeFrom\(CMsgClientToGCHasPlayerVotedForMVPResponse\)

```csharp
public void MergeFrom(CMsgClientToGCHasPlayerVotedForMVPResponse other)
```

#### Parameters

`other` [CMsgClientToGCHasPlayerVotedForMVPResponse](Divine.Protobufs.Dota2.CMsgClientToGCHasPlayerVotedForMVPResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCHasPlayerVotedForMVPResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCHasPlayerVotedForMVPResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCHasPlayerVotedForMVPResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

