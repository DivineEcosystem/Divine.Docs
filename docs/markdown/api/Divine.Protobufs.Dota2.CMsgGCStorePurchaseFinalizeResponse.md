# <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseFinalizeResponse"></a> Class CMsgGCStorePurchaseFinalizeResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCStorePurchaseFinalizeResponse : IMessage<CMsgGCStorePurchaseFinalizeResponse>, IEquatable<CMsgGCStorePurchaseFinalizeResponse>, IDeepCloneable<CMsgGCStorePurchaseFinalizeResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCStorePurchaseFinalizeResponse](Divine.Protobufs.Dota2.CMsgGCStorePurchaseFinalizeResponse.md)

#### Implements

IMessage<CMsgGCStorePurchaseFinalizeResponse\>, 
[IEquatable<CMsgGCStorePurchaseFinalizeResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCStorePurchaseFinalizeResponse\>, 
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
[EnumerableExtensions.In<CMsgGCStorePurchaseFinalizeResponse\>\(CMsgGCStorePurchaseFinalizeResponse, params CMsgGCStorePurchaseFinalizeResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseFinalizeResponse__ctor"></a> CMsgGCStorePurchaseFinalizeResponse\(\)

```csharp
public CMsgGCStorePurchaseFinalizeResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseFinalizeResponse__ctor_Divine_Protobufs_Dota2_CMsgGCStorePurchaseFinalizeResponse_"></a> CMsgGCStorePurchaseFinalizeResponse\(CMsgGCStorePurchaseFinalizeResponse\)

```csharp
public CMsgGCStorePurchaseFinalizeResponse(CMsgGCStorePurchaseFinalizeResponse other)
```

#### Parameters

`other` [CMsgGCStorePurchaseFinalizeResponse](Divine.Protobufs.Dota2.CMsgGCStorePurchaseFinalizeResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseFinalizeResponse_ItemIdsFieldNumber"></a> ItemIdsFieldNumber

```csharp
public const int ItemIdsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseFinalizeResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseFinalizeResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseFinalizeResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseFinalizeResponse_ItemIds"></a> ItemIds

```csharp
public RepeatedField<ulong> ItemIds { get; }
```

#### Property Value

 RepeatedField<[ulong](https://learn.microsoft.com/dotnet/api/system.uint64)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseFinalizeResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCStorePurchaseFinalizeResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCStorePurchaseFinalizeResponse](Divine.Protobufs.Dota2.CMsgGCStorePurchaseFinalizeResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseFinalizeResponse_Result"></a> Result

```csharp
public uint Result { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseFinalizeResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseFinalizeResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseFinalizeResponse_Clone"></a> Clone\(\)

```csharp
public CMsgGCStorePurchaseFinalizeResponse Clone()
```

#### Returns

 [CMsgGCStorePurchaseFinalizeResponse](Divine.Protobufs.Dota2.CMsgGCStorePurchaseFinalizeResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseFinalizeResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseFinalizeResponse_Equals_Divine_Protobufs_Dota2_CMsgGCStorePurchaseFinalizeResponse_"></a> Equals\(CMsgGCStorePurchaseFinalizeResponse\)

```csharp
public bool Equals(CMsgGCStorePurchaseFinalizeResponse other)
```

#### Parameters

`other` [CMsgGCStorePurchaseFinalizeResponse](Divine.Protobufs.Dota2.CMsgGCStorePurchaseFinalizeResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseFinalizeResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseFinalizeResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgGCStorePurchaseFinalizeResponse_"></a> MergeFrom\(CMsgGCStorePurchaseFinalizeResponse\)

```csharp
public void MergeFrom(CMsgGCStorePurchaseFinalizeResponse other)
```

#### Parameters

`other` [CMsgGCStorePurchaseFinalizeResponse](Divine.Protobufs.Dota2.CMsgGCStorePurchaseFinalizeResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseFinalizeResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseFinalizeResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseFinalizeResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

