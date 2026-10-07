# <a id="Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGift"></a> Class CMsgClientToGCWrapAndDeliverGift

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCWrapAndDeliverGift : IMessage<CMsgClientToGCWrapAndDeliverGift>, IEquatable<CMsgClientToGCWrapAndDeliverGift>, IDeepCloneable<CMsgClientToGCWrapAndDeliverGift>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCWrapAndDeliverGift](Divine.Protobufs.Dota2.CMsgClientToGCWrapAndDeliverGift.md)

#### Implements

IMessage<CMsgClientToGCWrapAndDeliverGift\>, 
[IEquatable<CMsgClientToGCWrapAndDeliverGift\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCWrapAndDeliverGift\>, 
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
[EnumerableExtensions.In<CMsgClientToGCWrapAndDeliverGift\>\(CMsgClientToGCWrapAndDeliverGift, params CMsgClientToGCWrapAndDeliverGift\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGift__ctor"></a> CMsgClientToGCWrapAndDeliverGift\(\)

```csharp
public CMsgClientToGCWrapAndDeliverGift()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGift__ctor_Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGift_"></a> CMsgClientToGCWrapAndDeliverGift\(CMsgClientToGCWrapAndDeliverGift\)

```csharp
public CMsgClientToGCWrapAndDeliverGift(CMsgClientToGCWrapAndDeliverGift other)
```

#### Parameters

`other` [CMsgClientToGCWrapAndDeliverGift](Divine.Protobufs.Dota2.CMsgClientToGCWrapAndDeliverGift.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGift_GiftMessageFieldNumber"></a> GiftMessageFieldNumber

```csharp
public const int GiftMessageFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGift_GiveToAccountIdFieldNumber"></a> GiveToAccountIdFieldNumber

```csharp
public const int GiveToAccountIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGift_ItemIdFieldNumber"></a> ItemIdFieldNumber

```csharp
public const int ItemIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGift_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGift_GiftMessage"></a> GiftMessage

```csharp
public string GiftMessage { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGift_GiveToAccountId"></a> GiveToAccountId

```csharp
public uint GiveToAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGift_HasGiftMessage"></a> HasGiftMessage

```csharp
public bool HasGiftMessage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGift_HasGiveToAccountId"></a> HasGiveToAccountId

```csharp
public bool HasGiveToAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGift_HasItemId"></a> HasItemId

```csharp
public bool HasItemId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGift_ItemId"></a> ItemId

```csharp
public ulong ItemId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGift_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCWrapAndDeliverGift> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCWrapAndDeliverGift](Divine.Protobufs.Dota2.CMsgClientToGCWrapAndDeliverGift.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGift_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGift_ClearGiftMessage"></a> ClearGiftMessage\(\)

```csharp
public void ClearGiftMessage()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGift_ClearGiveToAccountId"></a> ClearGiveToAccountId\(\)

```csharp
public void ClearGiveToAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGift_ClearItemId"></a> ClearItemId\(\)

```csharp
public void ClearItemId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGift_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCWrapAndDeliverGift Clone()
```

#### Returns

 [CMsgClientToGCWrapAndDeliverGift](Divine.Protobufs.Dota2.CMsgClientToGCWrapAndDeliverGift.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGift_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGift_Equals_Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGift_"></a> Equals\(CMsgClientToGCWrapAndDeliverGift\)

```csharp
public bool Equals(CMsgClientToGCWrapAndDeliverGift other)
```

#### Parameters

`other` [CMsgClientToGCWrapAndDeliverGift](Divine.Protobufs.Dota2.CMsgClientToGCWrapAndDeliverGift.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGift_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGift_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGift_"></a> MergeFrom\(CMsgClientToGCWrapAndDeliverGift\)

```csharp
public void MergeFrom(CMsgClientToGCWrapAndDeliverGift other)
```

#### Parameters

`other` [CMsgClientToGCWrapAndDeliverGift](Divine.Protobufs.Dota2.CMsgClientToGCWrapAndDeliverGift.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGift_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGift_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWrapAndDeliverGift_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

