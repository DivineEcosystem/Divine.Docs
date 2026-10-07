# <a id="Divine_Protobufs_Dota2_CMsgClaimEventActionData_ItemGift"></a> Class CMsgClaimEventActionData\_ItemGift

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClaimEventActionData_ItemGift : IMessage<CMsgClaimEventActionData_ItemGift>, IEquatable<CMsgClaimEventActionData_ItemGift>, IDeepCloneable<CMsgClaimEventActionData_ItemGift>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClaimEventActionData\_ItemGift](Divine.Protobufs.Dota2.CMsgClaimEventActionData\_ItemGift.md)

#### Implements

IMessage<CMsgClaimEventActionData\_ItemGift\>, 
[IEquatable<CMsgClaimEventActionData\_ItemGift\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClaimEventActionData\_ItemGift\>, 
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
[EnumerableExtensions.In<CMsgClaimEventActionData\_ItemGift\>\(CMsgClaimEventActionData\_ItemGift, params CMsgClaimEventActionData\_ItemGift\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClaimEventActionData_ItemGift__ctor"></a> CMsgClaimEventActionData\_ItemGift\(\)

```csharp
public CMsgClaimEventActionData_ItemGift()
```

### <a id="Divine_Protobufs_Dota2_CMsgClaimEventActionData_ItemGift__ctor_Divine_Protobufs_Dota2_CMsgClaimEventActionData_ItemGift_"></a> CMsgClaimEventActionData\_ItemGift\(CMsgClaimEventActionData\_ItemGift\)

```csharp
public CMsgClaimEventActionData_ItemGift(CMsgClaimEventActionData_ItemGift other)
```

#### Parameters

`other` [CMsgClaimEventActionData\_ItemGift](Divine.Protobufs.Dota2.CMsgClaimEventActionData\_ItemGift.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClaimEventActionData_ItemGift_GiftMessageFieldNumber"></a> GiftMessageFieldNumber

```csharp
public const int GiftMessageFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClaimEventActionData_ItemGift_GiveToAccountIdFieldNumber"></a> GiveToAccountIdFieldNumber

```csharp
public const int GiveToAccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClaimEventActionData_ItemGift_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClaimEventActionData_ItemGift_GiftMessage"></a> GiftMessage

```csharp
public string GiftMessage { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClaimEventActionData_ItemGift_GiveToAccountId"></a> GiveToAccountId

```csharp
public uint GiveToAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClaimEventActionData_ItemGift_HasGiftMessage"></a> HasGiftMessage

```csharp
public bool HasGiftMessage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClaimEventActionData_ItemGift_HasGiveToAccountId"></a> HasGiveToAccountId

```csharp
public bool HasGiveToAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClaimEventActionData_ItemGift_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClaimEventActionData_ItemGift> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClaimEventActionData\_ItemGift](Divine.Protobufs.Dota2.CMsgClaimEventActionData\_ItemGift.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClaimEventActionData_ItemGift_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClaimEventActionData_ItemGift_ClearGiftMessage"></a> ClearGiftMessage\(\)

```csharp
public void ClearGiftMessage()
```

### <a id="Divine_Protobufs_Dota2_CMsgClaimEventActionData_ItemGift_ClearGiveToAccountId"></a> ClearGiveToAccountId\(\)

```csharp
public void ClearGiveToAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClaimEventActionData_ItemGift_Clone"></a> Clone\(\)

```csharp
public CMsgClaimEventActionData_ItemGift Clone()
```

#### Returns

 [CMsgClaimEventActionData\_ItemGift](Divine.Protobufs.Dota2.CMsgClaimEventActionData\_ItemGift.md)

### <a id="Divine_Protobufs_Dota2_CMsgClaimEventActionData_ItemGift_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClaimEventActionData_ItemGift_Equals_Divine_Protobufs_Dota2_CMsgClaimEventActionData_ItemGift_"></a> Equals\(CMsgClaimEventActionData\_ItemGift\)

```csharp
public bool Equals(CMsgClaimEventActionData_ItemGift other)
```

#### Parameters

`other` [CMsgClaimEventActionData\_ItemGift](Divine.Protobufs.Dota2.CMsgClaimEventActionData\_ItemGift.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClaimEventActionData_ItemGift_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClaimEventActionData_ItemGift_MergeFrom_Divine_Protobufs_Dota2_CMsgClaimEventActionData_ItemGift_"></a> MergeFrom\(CMsgClaimEventActionData\_ItemGift\)

```csharp
public void MergeFrom(CMsgClaimEventActionData_ItemGift other)
```

#### Parameters

`other` [CMsgClaimEventActionData\_ItemGift](Divine.Protobufs.Dota2.CMsgClaimEventActionData\_ItemGift.md)

### <a id="Divine_Protobufs_Dota2_CMsgClaimEventActionData_ItemGift_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClaimEventActionData_ItemGift_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClaimEventActionData_ItemGift_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

