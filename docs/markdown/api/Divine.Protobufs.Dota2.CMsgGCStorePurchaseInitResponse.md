# <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseInitResponse"></a> Class CMsgGCStorePurchaseInitResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCStorePurchaseInitResponse : IMessage<CMsgGCStorePurchaseInitResponse>, IEquatable<CMsgGCStorePurchaseInitResponse>, IDeepCloneable<CMsgGCStorePurchaseInitResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCStorePurchaseInitResponse](Divine.Protobufs.Dota2.CMsgGCStorePurchaseInitResponse.md)

#### Implements

IMessage<CMsgGCStorePurchaseInitResponse\>, 
[IEquatable<CMsgGCStorePurchaseInitResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCStorePurchaseInitResponse\>, 
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
[EnumerableExtensions.In<CMsgGCStorePurchaseInitResponse\>\(CMsgGCStorePurchaseInitResponse, params CMsgGCStorePurchaseInitResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseInitResponse__ctor"></a> CMsgGCStorePurchaseInitResponse\(\)

```csharp
public CMsgGCStorePurchaseInitResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseInitResponse__ctor_Divine_Protobufs_Dota2_CMsgGCStorePurchaseInitResponse_"></a> CMsgGCStorePurchaseInitResponse\(CMsgGCStorePurchaseInitResponse\)

```csharp
public CMsgGCStorePurchaseInitResponse(CMsgGCStorePurchaseInitResponse other)
```

#### Parameters

`other` [CMsgGCStorePurchaseInitResponse](Divine.Protobufs.Dota2.CMsgGCStorePurchaseInitResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseInitResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseInitResponse_TxnIdFieldNumber"></a> TxnIdFieldNumber

```csharp
public const int TxnIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseInitResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseInitResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseInitResponse_HasTxnId"></a> HasTxnId

```csharp
public bool HasTxnId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseInitResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCStorePurchaseInitResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCStorePurchaseInitResponse](Divine.Protobufs.Dota2.CMsgGCStorePurchaseInitResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseInitResponse_Result"></a> Result

```csharp
public int Result { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseInitResponse_TxnId"></a> TxnId

```csharp
public ulong TxnId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseInitResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseInitResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseInitResponse_ClearTxnId"></a> ClearTxnId\(\)

```csharp
public void ClearTxnId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseInitResponse_Clone"></a> Clone\(\)

```csharp
public CMsgGCStorePurchaseInitResponse Clone()
```

#### Returns

 [CMsgGCStorePurchaseInitResponse](Divine.Protobufs.Dota2.CMsgGCStorePurchaseInitResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseInitResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseInitResponse_Equals_Divine_Protobufs_Dota2_CMsgGCStorePurchaseInitResponse_"></a> Equals\(CMsgGCStorePurchaseInitResponse\)

```csharp
public bool Equals(CMsgGCStorePurchaseInitResponse other)
```

#### Parameters

`other` [CMsgGCStorePurchaseInitResponse](Divine.Protobufs.Dota2.CMsgGCStorePurchaseInitResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseInitResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseInitResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgGCStorePurchaseInitResponse_"></a> MergeFrom\(CMsgGCStorePurchaseInitResponse\)

```csharp
public void MergeFrom(CMsgGCStorePurchaseInitResponse other)
```

#### Parameters

`other` [CMsgGCStorePurchaseInitResponse](Divine.Protobufs.Dota2.CMsgGCStorePurchaseInitResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseInitResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseInitResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseInitResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

