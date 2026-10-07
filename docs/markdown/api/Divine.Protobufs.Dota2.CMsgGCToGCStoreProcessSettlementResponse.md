# <a id="Divine_Protobufs_Dota2_CMsgGCToGCStoreProcessSettlementResponse"></a> Class CMsgGCToGCStoreProcessSettlementResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToGCStoreProcessSettlementResponse : IMessage<CMsgGCToGCStoreProcessSettlementResponse>, IEquatable<CMsgGCToGCStoreProcessSettlementResponse>, IDeepCloneable<CMsgGCToGCStoreProcessSettlementResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToGCStoreProcessSettlementResponse](Divine.Protobufs.Dota2.CMsgGCToGCStoreProcessSettlementResponse.md)

#### Implements

IMessage<CMsgGCToGCStoreProcessSettlementResponse\>, 
[IEquatable<CMsgGCToGCStoreProcessSettlementResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToGCStoreProcessSettlementResponse\>, 
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
[EnumerableExtensions.In<CMsgGCToGCStoreProcessSettlementResponse\>\(CMsgGCToGCStoreProcessSettlementResponse, params CMsgGCToGCStoreProcessSettlementResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCStoreProcessSettlementResponse__ctor"></a> CMsgGCToGCStoreProcessSettlementResponse\(\)

```csharp
public CMsgGCToGCStoreProcessSettlementResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCStoreProcessSettlementResponse__ctor_Divine_Protobufs_Dota2_CMsgGCToGCStoreProcessSettlementResponse_"></a> CMsgGCToGCStoreProcessSettlementResponse\(CMsgGCToGCStoreProcessSettlementResponse\)

```csharp
public CMsgGCToGCStoreProcessSettlementResponse(CMsgGCToGCStoreProcessSettlementResponse other)
```

#### Parameters

`other` [CMsgGCToGCStoreProcessSettlementResponse](Divine.Protobufs.Dota2.CMsgGCToGCStoreProcessSettlementResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCStoreProcessSettlementResponse_SuccessFieldNumber"></a> SuccessFieldNumber

```csharp
public const int SuccessFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCStoreProcessSettlementResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCStoreProcessSettlementResponse_HasSuccess"></a> HasSuccess

```csharp
public bool HasSuccess { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCStoreProcessSettlementResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToGCStoreProcessSettlementResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToGCStoreProcessSettlementResponse](Divine.Protobufs.Dota2.CMsgGCToGCStoreProcessSettlementResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCStoreProcessSettlementResponse_Success"></a> Success

```csharp
public bool Success { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCStoreProcessSettlementResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCStoreProcessSettlementResponse_ClearSuccess"></a> ClearSuccess\(\)

```csharp
public void ClearSuccess()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCStoreProcessSettlementResponse_Clone"></a> Clone\(\)

```csharp
public CMsgGCToGCStoreProcessSettlementResponse Clone()
```

#### Returns

 [CMsgGCToGCStoreProcessSettlementResponse](Divine.Protobufs.Dota2.CMsgGCToGCStoreProcessSettlementResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCStoreProcessSettlementResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCStoreProcessSettlementResponse_Equals_Divine_Protobufs_Dota2_CMsgGCToGCStoreProcessSettlementResponse_"></a> Equals\(CMsgGCToGCStoreProcessSettlementResponse\)

```csharp
public bool Equals(CMsgGCToGCStoreProcessSettlementResponse other)
```

#### Parameters

`other` [CMsgGCToGCStoreProcessSettlementResponse](Divine.Protobufs.Dota2.CMsgGCToGCStoreProcessSettlementResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCStoreProcessSettlementResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCStoreProcessSettlementResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToGCStoreProcessSettlementResponse_"></a> MergeFrom\(CMsgGCToGCStoreProcessSettlementResponse\)

```csharp
public void MergeFrom(CMsgGCToGCStoreProcessSettlementResponse other)
```

#### Parameters

`other` [CMsgGCToGCStoreProcessSettlementResponse](Divine.Protobufs.Dota2.CMsgGCToGCStoreProcessSettlementResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCStoreProcessSettlementResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCStoreProcessSettlementResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCStoreProcessSettlementResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

