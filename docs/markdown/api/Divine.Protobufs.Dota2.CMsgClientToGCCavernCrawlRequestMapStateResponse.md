# <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse"></a> Class CMsgClientToGCCavernCrawlRequestMapStateResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCCavernCrawlRequestMapStateResponse : IMessage<CMsgClientToGCCavernCrawlRequestMapStateResponse>, IEquatable<CMsgClientToGCCavernCrawlRequestMapStateResponse>, IDeepCloneable<CMsgClientToGCCavernCrawlRequestMapStateResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCCavernCrawlRequestMapStateResponse](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlRequestMapStateResponse.md)

#### Implements

IMessage<CMsgClientToGCCavernCrawlRequestMapStateResponse\>, 
[IEquatable<CMsgClientToGCCavernCrawlRequestMapStateResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCCavernCrawlRequestMapStateResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCCavernCrawlRequestMapStateResponse\>\(CMsgClientToGCCavernCrawlRequestMapStateResponse, params CMsgClientToGCCavernCrawlRequestMapStateResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse__ctor"></a> CMsgClientToGCCavernCrawlRequestMapStateResponse\(\)

```csharp
public CMsgClientToGCCavernCrawlRequestMapStateResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_"></a> CMsgClientToGCCavernCrawlRequestMapStateResponse\(CMsgClientToGCCavernCrawlRequestMapStateResponse\)

```csharp
public CMsgClientToGCCavernCrawlRequestMapStateResponse(CMsgClientToGCCavernCrawlRequestMapStateResponse other)
```

#### Parameters

`other` [CMsgClientToGCCavernCrawlRequestMapStateResponse](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlRequestMapStateResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_AvailableMapVariantsMaskFieldNumber"></a> AvailableMapVariantsMaskFieldNumber

```csharp
public const int AvailableMapVariantsMaskFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_InventoryItemFieldNumber"></a> InventoryItemFieldNumber

```csharp
public const int InventoryItemFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_MapVariantsFieldNumber"></a> MapVariantsFieldNumber

```csharp
public const int MapVariantsFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_AvailableMapVariantsMask"></a> AvailableMapVariantsMask

```csharp
public uint AvailableMapVariantsMask { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_HasAvailableMapVariantsMask"></a> HasAvailableMapVariantsMask

```csharp
public bool HasAvailableMapVariantsMask { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_InventoryItem"></a> InventoryItem

```csharp
public RepeatedField<CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.InventoryItem> InventoryItem { get; }
```

#### Property Value

 RepeatedField<[CMsgClientToGCCavernCrawlRequestMapStateResponse](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlRequestMapStateResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.md).[InventoryItem](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.InventoryItem.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_MapVariants"></a> MapVariants

```csharp
public RepeatedField<CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.MapVariant> MapVariants { get; }
```

#### Property Value

 RepeatedField<[CMsgClientToGCCavernCrawlRequestMapStateResponse](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlRequestMapStateResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.md).[MapVariant](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.MapVariant.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCCavernCrawlRequestMapStateResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCCavernCrawlRequestMapStateResponse](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlRequestMapStateResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Result"></a> Result

```csharp
public CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.Result Result { get; set; }
```

#### Property Value

 [CMsgClientToGCCavernCrawlRequestMapStateResponse](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlRequestMapStateResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.md).[Result](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlRequestMapStateResponse.Types.Result.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_ClearAvailableMapVariantsMask"></a> ClearAvailableMapVariantsMask\(\)

```csharp
public void ClearAvailableMapVariantsMask()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCCavernCrawlRequestMapStateResponse Clone()
```

#### Returns

 [CMsgClientToGCCavernCrawlRequestMapStateResponse](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlRequestMapStateResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_"></a> Equals\(CMsgClientToGCCavernCrawlRequestMapStateResponse\)

```csharp
public bool Equals(CMsgClientToGCCavernCrawlRequestMapStateResponse other)
```

#### Parameters

`other` [CMsgClientToGCCavernCrawlRequestMapStateResponse](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlRequestMapStateResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_"></a> MergeFrom\(CMsgClientToGCCavernCrawlRequestMapStateResponse\)

```csharp
public void MergeFrom(CMsgClientToGCCavernCrawlRequestMapStateResponse other)
```

#### Parameters

`other` [CMsgClientToGCCavernCrawlRequestMapStateResponse](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlRequestMapStateResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlRequestMapStateResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

