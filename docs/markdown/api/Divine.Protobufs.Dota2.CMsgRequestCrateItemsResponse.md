# <a id="Divine_Protobufs_Dota2_CMsgRequestCrateItemsResponse"></a> Class CMsgRequestCrateItemsResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgRequestCrateItemsResponse : IMessage<CMsgRequestCrateItemsResponse>, IEquatable<CMsgRequestCrateItemsResponse>, IDeepCloneable<CMsgRequestCrateItemsResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgRequestCrateItemsResponse](Divine.Protobufs.Dota2.CMsgRequestCrateItemsResponse.md)

#### Implements

IMessage<CMsgRequestCrateItemsResponse\>, 
[IEquatable<CMsgRequestCrateItemsResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgRequestCrateItemsResponse\>, 
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
[EnumerableExtensions.In<CMsgRequestCrateItemsResponse\>\(CMsgRequestCrateItemsResponse, params CMsgRequestCrateItemsResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgRequestCrateItemsResponse__ctor"></a> CMsgRequestCrateItemsResponse\(\)

```csharp
public CMsgRequestCrateItemsResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgRequestCrateItemsResponse__ctor_Divine_Protobufs_Dota2_CMsgRequestCrateItemsResponse_"></a> CMsgRequestCrateItemsResponse\(CMsgRequestCrateItemsResponse\)

```csharp
public CMsgRequestCrateItemsResponse(CMsgRequestCrateItemsResponse other)
```

#### Parameters

`other` [CMsgRequestCrateItemsResponse](Divine.Protobufs.Dota2.CMsgRequestCrateItemsResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgRequestCrateItemsResponse_ItemDefsFieldNumber"></a> ItemDefsFieldNumber

```csharp
public const int ItemDefsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgRequestCrateItemsResponse_PeekItemDefsFieldNumber"></a> PeekItemDefsFieldNumber

```csharp
public const int PeekItemDefsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgRequestCrateItemsResponse_PeekItemsFieldNumber"></a> PeekItemsFieldNumber

```csharp
public const int PeekItemsFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgRequestCrateItemsResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgRequestCrateItemsResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgRequestCrateItemsResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgRequestCrateItemsResponse_ItemDefs"></a> ItemDefs

```csharp
public RepeatedField<uint> ItemDefs { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgRequestCrateItemsResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgRequestCrateItemsResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgRequestCrateItemsResponse](Divine.Protobufs.Dota2.CMsgRequestCrateItemsResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgRequestCrateItemsResponse_PeekItemDefs"></a> PeekItemDefs

```csharp
public RepeatedField<uint> PeekItemDefs { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgRequestCrateItemsResponse_PeekItems"></a> PeekItems

```csharp
public RepeatedField<CSOEconItem> PeekItems { get; }
```

#### Property Value

 RepeatedField<[CSOEconItem](Divine.Protobufs.Dota2.CSOEconItem.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgRequestCrateItemsResponse_Response"></a> Response

```csharp
public uint Response { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgRequestCrateItemsResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgRequestCrateItemsResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgRequestCrateItemsResponse_Clone"></a> Clone\(\)

```csharp
public CMsgRequestCrateItemsResponse Clone()
```

#### Returns

 [CMsgRequestCrateItemsResponse](Divine.Protobufs.Dota2.CMsgRequestCrateItemsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgRequestCrateItemsResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgRequestCrateItemsResponse_Equals_Divine_Protobufs_Dota2_CMsgRequestCrateItemsResponse_"></a> Equals\(CMsgRequestCrateItemsResponse\)

```csharp
public bool Equals(CMsgRequestCrateItemsResponse other)
```

#### Parameters

`other` [CMsgRequestCrateItemsResponse](Divine.Protobufs.Dota2.CMsgRequestCrateItemsResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgRequestCrateItemsResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgRequestCrateItemsResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgRequestCrateItemsResponse_"></a> MergeFrom\(CMsgRequestCrateItemsResponse\)

```csharp
public void MergeFrom(CMsgRequestCrateItemsResponse other)
```

#### Parameters

`other` [CMsgRequestCrateItemsResponse](Divine.Protobufs.Dota2.CMsgRequestCrateItemsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgRequestCrateItemsResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgRequestCrateItemsResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgRequestCrateItemsResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

