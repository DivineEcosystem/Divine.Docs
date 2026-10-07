# <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlayerCardSpecificPurchaseResponse"></a> Class CMsgClientToGCPlayerCardSpecificPurchaseResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCPlayerCardSpecificPurchaseResponse : IMessage<CMsgClientToGCPlayerCardSpecificPurchaseResponse>, IEquatable<CMsgClientToGCPlayerCardSpecificPurchaseResponse>, IDeepCloneable<CMsgClientToGCPlayerCardSpecificPurchaseResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCPlayerCardSpecificPurchaseResponse](Divine.Protobufs.Dota2.CMsgClientToGCPlayerCardSpecificPurchaseResponse.md)

#### Implements

IMessage<CMsgClientToGCPlayerCardSpecificPurchaseResponse\>, 
[IEquatable<CMsgClientToGCPlayerCardSpecificPurchaseResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCPlayerCardSpecificPurchaseResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCPlayerCardSpecificPurchaseResponse\>\(CMsgClientToGCPlayerCardSpecificPurchaseResponse, params CMsgClientToGCPlayerCardSpecificPurchaseResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlayerCardSpecificPurchaseResponse__ctor"></a> CMsgClientToGCPlayerCardSpecificPurchaseResponse\(\)

```csharp
public CMsgClientToGCPlayerCardSpecificPurchaseResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlayerCardSpecificPurchaseResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCPlayerCardSpecificPurchaseResponse_"></a> CMsgClientToGCPlayerCardSpecificPurchaseResponse\(CMsgClientToGCPlayerCardSpecificPurchaseResponse\)

```csharp
public CMsgClientToGCPlayerCardSpecificPurchaseResponse(CMsgClientToGCPlayerCardSpecificPurchaseResponse other)
```

#### Parameters

`other` [CMsgClientToGCPlayerCardSpecificPurchaseResponse](Divine.Protobufs.Dota2.CMsgClientToGCPlayerCardSpecificPurchaseResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlayerCardSpecificPurchaseResponse_ItemIdFieldNumber"></a> ItemIdFieldNumber

```csharp
public const int ItemIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlayerCardSpecificPurchaseResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlayerCardSpecificPurchaseResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlayerCardSpecificPurchaseResponse_HasItemId"></a> HasItemId

```csharp
public bool HasItemId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlayerCardSpecificPurchaseResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlayerCardSpecificPurchaseResponse_ItemId"></a> ItemId

```csharp
public ulong ItemId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlayerCardSpecificPurchaseResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCPlayerCardSpecificPurchaseResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCPlayerCardSpecificPurchaseResponse](Divine.Protobufs.Dota2.CMsgClientToGCPlayerCardSpecificPurchaseResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlayerCardSpecificPurchaseResponse_Result"></a> Result

```csharp
public CMsgClientToGCPlayerCardSpecificPurchaseResponse.Types.Result Result { get; set; }
```

#### Property Value

 [CMsgClientToGCPlayerCardSpecificPurchaseResponse](Divine.Protobufs.Dota2.CMsgClientToGCPlayerCardSpecificPurchaseResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCPlayerCardSpecificPurchaseResponse.Types.md).[Result](Divine.Protobufs.Dota2.CMsgClientToGCPlayerCardSpecificPurchaseResponse.Types.Result.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlayerCardSpecificPurchaseResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlayerCardSpecificPurchaseResponse_ClearItemId"></a> ClearItemId\(\)

```csharp
public void ClearItemId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlayerCardSpecificPurchaseResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlayerCardSpecificPurchaseResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCPlayerCardSpecificPurchaseResponse Clone()
```

#### Returns

 [CMsgClientToGCPlayerCardSpecificPurchaseResponse](Divine.Protobufs.Dota2.CMsgClientToGCPlayerCardSpecificPurchaseResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlayerCardSpecificPurchaseResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlayerCardSpecificPurchaseResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCPlayerCardSpecificPurchaseResponse_"></a> Equals\(CMsgClientToGCPlayerCardSpecificPurchaseResponse\)

```csharp
public bool Equals(CMsgClientToGCPlayerCardSpecificPurchaseResponse other)
```

#### Parameters

`other` [CMsgClientToGCPlayerCardSpecificPurchaseResponse](Divine.Protobufs.Dota2.CMsgClientToGCPlayerCardSpecificPurchaseResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlayerCardSpecificPurchaseResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlayerCardSpecificPurchaseResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCPlayerCardSpecificPurchaseResponse_"></a> MergeFrom\(CMsgClientToGCPlayerCardSpecificPurchaseResponse\)

```csharp
public void MergeFrom(CMsgClientToGCPlayerCardSpecificPurchaseResponse other)
```

#### Parameters

`other` [CMsgClientToGCPlayerCardSpecificPurchaseResponse](Divine.Protobufs.Dota2.CMsgClientToGCPlayerCardSpecificPurchaseResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlayerCardSpecificPurchaseResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlayerCardSpecificPurchaseResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlayerCardSpecificPurchaseResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

