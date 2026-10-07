# <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseCancelResponse"></a> Class CMsgGCStorePurchaseCancelResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCStorePurchaseCancelResponse : IMessage<CMsgGCStorePurchaseCancelResponse>, IEquatable<CMsgGCStorePurchaseCancelResponse>, IDeepCloneable<CMsgGCStorePurchaseCancelResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCStorePurchaseCancelResponse](Divine.Protobufs.Dota2.CMsgGCStorePurchaseCancelResponse.md)

#### Implements

IMessage<CMsgGCStorePurchaseCancelResponse\>, 
[IEquatable<CMsgGCStorePurchaseCancelResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCStorePurchaseCancelResponse\>, 
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
[EnumerableExtensions.In<CMsgGCStorePurchaseCancelResponse\>\(CMsgGCStorePurchaseCancelResponse, params CMsgGCStorePurchaseCancelResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseCancelResponse__ctor"></a> CMsgGCStorePurchaseCancelResponse\(\)

```csharp
public CMsgGCStorePurchaseCancelResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseCancelResponse__ctor_Divine_Protobufs_Dota2_CMsgGCStorePurchaseCancelResponse_"></a> CMsgGCStorePurchaseCancelResponse\(CMsgGCStorePurchaseCancelResponse\)

```csharp
public CMsgGCStorePurchaseCancelResponse(CMsgGCStorePurchaseCancelResponse other)
```

#### Parameters

`other` [CMsgGCStorePurchaseCancelResponse](Divine.Protobufs.Dota2.CMsgGCStorePurchaseCancelResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseCancelResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseCancelResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseCancelResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseCancelResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCStorePurchaseCancelResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCStorePurchaseCancelResponse](Divine.Protobufs.Dota2.CMsgGCStorePurchaseCancelResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseCancelResponse_Result"></a> Result

```csharp
public uint Result { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseCancelResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseCancelResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseCancelResponse_Clone"></a> Clone\(\)

```csharp
public CMsgGCStorePurchaseCancelResponse Clone()
```

#### Returns

 [CMsgGCStorePurchaseCancelResponse](Divine.Protobufs.Dota2.CMsgGCStorePurchaseCancelResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseCancelResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseCancelResponse_Equals_Divine_Protobufs_Dota2_CMsgGCStorePurchaseCancelResponse_"></a> Equals\(CMsgGCStorePurchaseCancelResponse\)

```csharp
public bool Equals(CMsgGCStorePurchaseCancelResponse other)
```

#### Parameters

`other` [CMsgGCStorePurchaseCancelResponse](Divine.Protobufs.Dota2.CMsgGCStorePurchaseCancelResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseCancelResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseCancelResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgGCStorePurchaseCancelResponse_"></a> MergeFrom\(CMsgGCStorePurchaseCancelResponse\)

```csharp
public void MergeFrom(CMsgGCStorePurchaseCancelResponse other)
```

#### Parameters

`other` [CMsgGCStorePurchaseCancelResponse](Divine.Protobufs.Dota2.CMsgGCStorePurchaseCancelResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseCancelResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseCancelResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseCancelResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

