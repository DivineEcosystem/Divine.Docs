# <a id="Divine_Protobufs_Dota2_CMsgClientToGCSelectGuildContractResponse"></a> Class CMsgClientToGCSelectGuildContractResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCSelectGuildContractResponse : IMessage<CMsgClientToGCSelectGuildContractResponse>, IEquatable<CMsgClientToGCSelectGuildContractResponse>, IDeepCloneable<CMsgClientToGCSelectGuildContractResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCSelectGuildContractResponse](Divine.Protobufs.Dota2.CMsgClientToGCSelectGuildContractResponse.md)

#### Implements

IMessage<CMsgClientToGCSelectGuildContractResponse\>, 
[IEquatable<CMsgClientToGCSelectGuildContractResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCSelectGuildContractResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCSelectGuildContractResponse\>\(CMsgClientToGCSelectGuildContractResponse, params CMsgClientToGCSelectGuildContractResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSelectGuildContractResponse__ctor"></a> CMsgClientToGCSelectGuildContractResponse\(\)

```csharp
public CMsgClientToGCSelectGuildContractResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSelectGuildContractResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCSelectGuildContractResponse_"></a> CMsgClientToGCSelectGuildContractResponse\(CMsgClientToGCSelectGuildContractResponse\)

```csharp
public CMsgClientToGCSelectGuildContractResponse(CMsgClientToGCSelectGuildContractResponse other)
```

#### Parameters

`other` [CMsgClientToGCSelectGuildContractResponse](Divine.Protobufs.Dota2.CMsgClientToGCSelectGuildContractResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSelectGuildContractResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSelectGuildContractResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSelectGuildContractResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSelectGuildContractResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCSelectGuildContractResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCSelectGuildContractResponse](Divine.Protobufs.Dota2.CMsgClientToGCSelectGuildContractResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSelectGuildContractResponse_Result"></a> Result

```csharp
public CMsgClientToGCSelectGuildContractResponse.Types.EResponse Result { get; set; }
```

#### Property Value

 [CMsgClientToGCSelectGuildContractResponse](Divine.Protobufs.Dota2.CMsgClientToGCSelectGuildContractResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCSelectGuildContractResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCSelectGuildContractResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSelectGuildContractResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSelectGuildContractResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSelectGuildContractResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCSelectGuildContractResponse Clone()
```

#### Returns

 [CMsgClientToGCSelectGuildContractResponse](Divine.Protobufs.Dota2.CMsgClientToGCSelectGuildContractResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSelectGuildContractResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSelectGuildContractResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCSelectGuildContractResponse_"></a> Equals\(CMsgClientToGCSelectGuildContractResponse\)

```csharp
public bool Equals(CMsgClientToGCSelectGuildContractResponse other)
```

#### Parameters

`other` [CMsgClientToGCSelectGuildContractResponse](Divine.Protobufs.Dota2.CMsgClientToGCSelectGuildContractResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSelectGuildContractResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSelectGuildContractResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCSelectGuildContractResponse_"></a> MergeFrom\(CMsgClientToGCSelectGuildContractResponse\)

```csharp
public void MergeFrom(CMsgClientToGCSelectGuildContractResponse other)
```

#### Parameters

`other` [CMsgClientToGCSelectGuildContractResponse](Divine.Protobufs.Dota2.CMsgClientToGCSelectGuildContractResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSelectGuildContractResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSelectGuildContractResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSelectGuildContractResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

