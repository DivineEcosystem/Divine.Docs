# <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse"></a> Class CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse : IMessage<CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse>, IEquatable<CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse>, IDeepCloneable<CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse.md)

#### Implements

IMessage<CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse\>, 
[IEquatable<CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse\>\(CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse, params CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse__ctor"></a> CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse\(\)

```csharp
public CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse_"></a> CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse\(CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse\)

```csharp
public CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse(CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse other)
```

#### Parameters

`other` [CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse_AvailableMapVariantsMaskFieldNumber"></a> AvailableMapVariantsMaskFieldNumber

```csharp
public const int AvailableMapVariantsMaskFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse_MapVariantsFieldNumber"></a> MapVariantsFieldNumber

```csharp
public const int MapVariantsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse_AvailableMapVariantsMask"></a> AvailableMapVariantsMask

```csharp
public uint AvailableMapVariantsMask { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse_HasAvailableMapVariantsMask"></a> HasAvailableMapVariantsMask

```csharp
public bool HasAvailableMapVariantsMask { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse_MapVariants"></a> MapVariants

```csharp
public RepeatedField<CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse.Types.MapVariant> MapVariants { get; }
```

#### Property Value

 RepeatedField<[CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse.Types.md).[MapVariant](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse.Types.MapVariant.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse_Result"></a> Result

```csharp
public CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse.Types.Result Result { get; set; }
```

#### Property Value

 [CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse.Types.md).[Result](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse.Types.Result.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse_ClearAvailableMapVariantsMask"></a> ClearAvailableMapVariantsMask\(\)

```csharp
public void ClearAvailableMapVariantsMask()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse Clone()
```

#### Returns

 [CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse_"></a> Equals\(CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse\)

```csharp
public bool Equals(CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse other)
```

#### Parameters

`other` [CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse_"></a> MergeFrom\(CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse\)

```csharp
public void MergeFrom(CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse other)
```

#### Parameters

`other` [CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlGetClaimedRoomCountResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

