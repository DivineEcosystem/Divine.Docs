# <a id="Divine_Protobufs_Dota2_CMsgPurchaseItemWithEventPointsResponse"></a> Class CMsgPurchaseItemWithEventPointsResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgPurchaseItemWithEventPointsResponse : IMessage<CMsgPurchaseItemWithEventPointsResponse>, IEquatable<CMsgPurchaseItemWithEventPointsResponse>, IDeepCloneable<CMsgPurchaseItemWithEventPointsResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgPurchaseItemWithEventPointsResponse](Divine.Protobufs.Dota2.CMsgPurchaseItemWithEventPointsResponse.md)

#### Implements

IMessage<CMsgPurchaseItemWithEventPointsResponse\>, 
[IEquatable<CMsgPurchaseItemWithEventPointsResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgPurchaseItemWithEventPointsResponse\>, 
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
[EnumerableExtensions.In<CMsgPurchaseItemWithEventPointsResponse\>\(CMsgPurchaseItemWithEventPointsResponse, params CMsgPurchaseItemWithEventPointsResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseItemWithEventPointsResponse__ctor"></a> CMsgPurchaseItemWithEventPointsResponse\(\)

```csharp
public CMsgPurchaseItemWithEventPointsResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseItemWithEventPointsResponse__ctor_Divine_Protobufs_Dota2_CMsgPurchaseItemWithEventPointsResponse_"></a> CMsgPurchaseItemWithEventPointsResponse\(CMsgPurchaseItemWithEventPointsResponse\)

```csharp
public CMsgPurchaseItemWithEventPointsResponse(CMsgPurchaseItemWithEventPointsResponse other)
```

#### Parameters

`other` [CMsgPurchaseItemWithEventPointsResponse](Divine.Protobufs.Dota2.CMsgPurchaseItemWithEventPointsResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseItemWithEventPointsResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseItemWithEventPointsResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseItemWithEventPointsResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseItemWithEventPointsResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgPurchaseItemWithEventPointsResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgPurchaseItemWithEventPointsResponse](Divine.Protobufs.Dota2.CMsgPurchaseItemWithEventPointsResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseItemWithEventPointsResponse_Result"></a> Result

```csharp
public CMsgPurchaseItemWithEventPointsResponse.Types.Result Result { get; set; }
```

#### Property Value

 [CMsgPurchaseItemWithEventPointsResponse](Divine.Protobufs.Dota2.CMsgPurchaseItemWithEventPointsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgPurchaseItemWithEventPointsResponse.Types.md).[Result](Divine.Protobufs.Dota2.CMsgPurchaseItemWithEventPointsResponse.Types.Result.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseItemWithEventPointsResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseItemWithEventPointsResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseItemWithEventPointsResponse_Clone"></a> Clone\(\)

```csharp
public CMsgPurchaseItemWithEventPointsResponse Clone()
```

#### Returns

 [CMsgPurchaseItemWithEventPointsResponse](Divine.Protobufs.Dota2.CMsgPurchaseItemWithEventPointsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseItemWithEventPointsResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseItemWithEventPointsResponse_Equals_Divine_Protobufs_Dota2_CMsgPurchaseItemWithEventPointsResponse_"></a> Equals\(CMsgPurchaseItemWithEventPointsResponse\)

```csharp
public bool Equals(CMsgPurchaseItemWithEventPointsResponse other)
```

#### Parameters

`other` [CMsgPurchaseItemWithEventPointsResponse](Divine.Protobufs.Dota2.CMsgPurchaseItemWithEventPointsResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseItemWithEventPointsResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseItemWithEventPointsResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgPurchaseItemWithEventPointsResponse_"></a> MergeFrom\(CMsgPurchaseItemWithEventPointsResponse\)

```csharp
public void MergeFrom(CMsgPurchaseItemWithEventPointsResponse other)
```

#### Parameters

`other` [CMsgPurchaseItemWithEventPointsResponse](Divine.Protobufs.Dota2.CMsgPurchaseItemWithEventPointsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseItemWithEventPointsResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseItemWithEventPointsResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseItemWithEventPointsResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

