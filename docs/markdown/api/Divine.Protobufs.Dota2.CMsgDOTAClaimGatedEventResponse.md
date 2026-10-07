# <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimGatedEventResponse"></a> Class CMsgDOTAClaimGatedEventResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAClaimGatedEventResponse : IMessage<CMsgDOTAClaimGatedEventResponse>, IEquatable<CMsgDOTAClaimGatedEventResponse>, IDeepCloneable<CMsgDOTAClaimGatedEventResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAClaimGatedEventResponse](Divine.Protobufs.Dota2.CMsgDOTAClaimGatedEventResponse.md)

#### Implements

IMessage<CMsgDOTAClaimGatedEventResponse\>, 
[IEquatable<CMsgDOTAClaimGatedEventResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAClaimGatedEventResponse\>, 
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
[EnumerableExtensions.In<CMsgDOTAClaimGatedEventResponse\>\(CMsgDOTAClaimGatedEventResponse, params CMsgDOTAClaimGatedEventResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimGatedEventResponse__ctor"></a> CMsgDOTAClaimGatedEventResponse\(\)

```csharp
public CMsgDOTAClaimGatedEventResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimGatedEventResponse__ctor_Divine_Protobufs_Dota2_CMsgDOTAClaimGatedEventResponse_"></a> CMsgDOTAClaimGatedEventResponse\(CMsgDOTAClaimGatedEventResponse\)

```csharp
public CMsgDOTAClaimGatedEventResponse(CMsgDOTAClaimGatedEventResponse other)
```

#### Parameters

`other` [CMsgDOTAClaimGatedEventResponse](Divine.Protobufs.Dota2.CMsgDOTAClaimGatedEventResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimGatedEventResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimGatedEventResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimGatedEventResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimGatedEventResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAClaimGatedEventResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAClaimGatedEventResponse](Divine.Protobufs.Dota2.CMsgDOTAClaimGatedEventResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimGatedEventResponse_Result"></a> Result

```csharp
public CMsgDOTAClaimGatedEventResponse.Types.ResultCode Result { get; set; }
```

#### Property Value

 [CMsgDOTAClaimGatedEventResponse](Divine.Protobufs.Dota2.CMsgDOTAClaimGatedEventResponse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAClaimGatedEventResponse.Types.md).[ResultCode](Divine.Protobufs.Dota2.CMsgDOTAClaimGatedEventResponse.Types.ResultCode.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimGatedEventResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimGatedEventResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimGatedEventResponse_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAClaimGatedEventResponse Clone()
```

#### Returns

 [CMsgDOTAClaimGatedEventResponse](Divine.Protobufs.Dota2.CMsgDOTAClaimGatedEventResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimGatedEventResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimGatedEventResponse_Equals_Divine_Protobufs_Dota2_CMsgDOTAClaimGatedEventResponse_"></a> Equals\(CMsgDOTAClaimGatedEventResponse\)

```csharp
public bool Equals(CMsgDOTAClaimGatedEventResponse other)
```

#### Parameters

`other` [CMsgDOTAClaimGatedEventResponse](Divine.Protobufs.Dota2.CMsgDOTAClaimGatedEventResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimGatedEventResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimGatedEventResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAClaimGatedEventResponse_"></a> MergeFrom\(CMsgDOTAClaimGatedEventResponse\)

```csharp
public void MergeFrom(CMsgDOTAClaimGatedEventResponse other)
```

#### Parameters

`other` [CMsgDOTAClaimGatedEventResponse](Divine.Protobufs.Dota2.CMsgDOTAClaimGatedEventResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimGatedEventResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimGatedEventResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimGatedEventResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

