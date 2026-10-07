# <a id="Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataResponse"></a> Class CMsgGCRequestStoreSalesDataResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCRequestStoreSalesDataResponse : IMessage<CMsgGCRequestStoreSalesDataResponse>, IEquatable<CMsgGCRequestStoreSalesDataResponse>, IDeepCloneable<CMsgGCRequestStoreSalesDataResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCRequestStoreSalesDataResponse](Divine.Protobufs.Dota2.CMsgGCRequestStoreSalesDataResponse.md)

#### Implements

IMessage<CMsgGCRequestStoreSalesDataResponse\>, 
[IEquatable<CMsgGCRequestStoreSalesDataResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCRequestStoreSalesDataResponse\>, 
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
[EnumerableExtensions.In<CMsgGCRequestStoreSalesDataResponse\>\(CMsgGCRequestStoreSalesDataResponse, params CMsgGCRequestStoreSalesDataResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataResponse__ctor"></a> CMsgGCRequestStoreSalesDataResponse\(\)

```csharp
public CMsgGCRequestStoreSalesDataResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataResponse__ctor_Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataResponse_"></a> CMsgGCRequestStoreSalesDataResponse\(CMsgGCRequestStoreSalesDataResponse\)

```csharp
public CMsgGCRequestStoreSalesDataResponse(CMsgGCRequestStoreSalesDataResponse other)
```

#### Parameters

`other` [CMsgGCRequestStoreSalesDataResponse](Divine.Protobufs.Dota2.CMsgGCRequestStoreSalesDataResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataResponse_ExpirationTimeFieldNumber"></a> ExpirationTimeFieldNumber

```csharp
public const int ExpirationTimeFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataResponse_SalePriceFieldNumber"></a> SalePriceFieldNumber

```csharp
public const int SalePriceFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataResponse_VersionFieldNumber"></a> VersionFieldNumber

```csharp
public const int VersionFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataResponse_ExpirationTime"></a> ExpirationTime

```csharp
public uint ExpirationTime { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataResponse_HasExpirationTime"></a> HasExpirationTime

```csharp
public bool HasExpirationTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataResponse_HasVersion"></a> HasVersion

```csharp
public bool HasVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCRequestStoreSalesDataResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCRequestStoreSalesDataResponse](Divine.Protobufs.Dota2.CMsgGCRequestStoreSalesDataResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataResponse_SalePrice"></a> SalePrice

```csharp
public RepeatedField<CMsgGCRequestStoreSalesDataResponse.Types.Price> SalePrice { get; }
```

#### Property Value

 RepeatedField<[CMsgGCRequestStoreSalesDataResponse](Divine.Protobufs.Dota2.CMsgGCRequestStoreSalesDataResponse.md).[Types](Divine.Protobufs.Dota2.CMsgGCRequestStoreSalesDataResponse.Types.md).[Price](Divine.Protobufs.Dota2.CMsgGCRequestStoreSalesDataResponse.Types.Price.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataResponse_Version"></a> Version

```csharp
public uint Version { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataResponse_ClearExpirationTime"></a> ClearExpirationTime\(\)

```csharp
public void ClearExpirationTime()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataResponse_ClearVersion"></a> ClearVersion\(\)

```csharp
public void ClearVersion()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataResponse_Clone"></a> Clone\(\)

```csharp
public CMsgGCRequestStoreSalesDataResponse Clone()
```

#### Returns

 [CMsgGCRequestStoreSalesDataResponse](Divine.Protobufs.Dota2.CMsgGCRequestStoreSalesDataResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataResponse_Equals_Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataResponse_"></a> Equals\(CMsgGCRequestStoreSalesDataResponse\)

```csharp
public bool Equals(CMsgGCRequestStoreSalesDataResponse other)
```

#### Parameters

`other` [CMsgGCRequestStoreSalesDataResponse](Divine.Protobufs.Dota2.CMsgGCRequestStoreSalesDataResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataResponse_"></a> MergeFrom\(CMsgGCRequestStoreSalesDataResponse\)

```csharp
public void MergeFrom(CMsgGCRequestStoreSalesDataResponse other)
```

#### Parameters

`other` [CMsgGCRequestStoreSalesDataResponse](Divine.Protobufs.Dota2.CMsgGCRequestStoreSalesDataResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

