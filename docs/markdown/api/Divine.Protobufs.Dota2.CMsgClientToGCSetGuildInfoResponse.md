# <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildInfoResponse"></a> Class CMsgClientToGCSetGuildInfoResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCSetGuildInfoResponse : IMessage<CMsgClientToGCSetGuildInfoResponse>, IEquatable<CMsgClientToGCSetGuildInfoResponse>, IDeepCloneable<CMsgClientToGCSetGuildInfoResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCSetGuildInfoResponse](Divine.Protobufs.Dota2.CMsgClientToGCSetGuildInfoResponse.md)

#### Implements

IMessage<CMsgClientToGCSetGuildInfoResponse\>, 
[IEquatable<CMsgClientToGCSetGuildInfoResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCSetGuildInfoResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCSetGuildInfoResponse\>\(CMsgClientToGCSetGuildInfoResponse, params CMsgClientToGCSetGuildInfoResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildInfoResponse__ctor"></a> CMsgClientToGCSetGuildInfoResponse\(\)

```csharp
public CMsgClientToGCSetGuildInfoResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildInfoResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCSetGuildInfoResponse_"></a> CMsgClientToGCSetGuildInfoResponse\(CMsgClientToGCSetGuildInfoResponse\)

```csharp
public CMsgClientToGCSetGuildInfoResponse(CMsgClientToGCSetGuildInfoResponse other)
```

#### Parameters

`other` [CMsgClientToGCSetGuildInfoResponse](Divine.Protobufs.Dota2.CMsgClientToGCSetGuildInfoResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildInfoResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildInfoResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildInfoResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildInfoResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCSetGuildInfoResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCSetGuildInfoResponse](Divine.Protobufs.Dota2.CMsgClientToGCSetGuildInfoResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildInfoResponse_Result"></a> Result

```csharp
public CMsgClientToGCSetGuildInfoResponse.Types.EResponse Result { get; set; }
```

#### Property Value

 [CMsgClientToGCSetGuildInfoResponse](Divine.Protobufs.Dota2.CMsgClientToGCSetGuildInfoResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCSetGuildInfoResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCSetGuildInfoResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildInfoResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildInfoResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildInfoResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCSetGuildInfoResponse Clone()
```

#### Returns

 [CMsgClientToGCSetGuildInfoResponse](Divine.Protobufs.Dota2.CMsgClientToGCSetGuildInfoResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildInfoResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildInfoResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCSetGuildInfoResponse_"></a> Equals\(CMsgClientToGCSetGuildInfoResponse\)

```csharp
public bool Equals(CMsgClientToGCSetGuildInfoResponse other)
```

#### Parameters

`other` [CMsgClientToGCSetGuildInfoResponse](Divine.Protobufs.Dota2.CMsgClientToGCSetGuildInfoResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildInfoResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildInfoResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCSetGuildInfoResponse_"></a> MergeFrom\(CMsgClientToGCSetGuildInfoResponse\)

```csharp
public void MergeFrom(CMsgClientToGCSetGuildInfoResponse other)
```

#### Parameters

`other` [CMsgClientToGCSetGuildInfoResponse](Divine.Protobufs.Dota2.CMsgClientToGCSetGuildInfoResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildInfoResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildInfoResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildInfoResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

