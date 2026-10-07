# <a id="Divine_Protobufs_Dota2_CMsgDevNewItemRequest"></a> Class CMsgDevNewItemRequest

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDevNewItemRequest : IMessage<CMsgDevNewItemRequest>, IEquatable<CMsgDevNewItemRequest>, IDeepCloneable<CMsgDevNewItemRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDevNewItemRequest](Divine.Protobufs.Dota2.CMsgDevNewItemRequest.md)

#### Implements

IMessage<CMsgDevNewItemRequest\>, 
[IEquatable<CMsgDevNewItemRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDevNewItemRequest\>, 
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
[EnumerableExtensions.In<CMsgDevNewItemRequest\>\(CMsgDevNewItemRequest, params CMsgDevNewItemRequest\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDevNewItemRequest__ctor"></a> CMsgDevNewItemRequest\(\)

```csharp
public CMsgDevNewItemRequest()
```

### <a id="Divine_Protobufs_Dota2_CMsgDevNewItemRequest__ctor_Divine_Protobufs_Dota2_CMsgDevNewItemRequest_"></a> CMsgDevNewItemRequest\(CMsgDevNewItemRequest\)

```csharp
public CMsgDevNewItemRequest(CMsgDevNewItemRequest other)
```

#### Parameters

`other` [CMsgDevNewItemRequest](Divine.Protobufs.Dota2.CMsgDevNewItemRequest.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDevNewItemRequest_AttrDefNameFieldNumber"></a> AttrDefNameFieldNumber

```csharp
public const int AttrDefNameFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDevNewItemRequest_AttrValueFieldNumber"></a> AttrValueFieldNumber

```csharp
public const int AttrValueFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDevNewItemRequest_ItemDefNameFieldNumber"></a> ItemDefNameFieldNumber

```csharp
public const int ItemDefNameFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDevNewItemRequest_ItemQualityFieldNumber"></a> ItemQualityFieldNumber

```csharp
public const int ItemQualityFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDevNewItemRequest_LootListNameFieldNumber"></a> LootListNameFieldNumber

```csharp
public const int LootListNameFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDevNewItemRequest_AttrDefName"></a> AttrDefName

```csharp
public RepeatedField<string> AttrDefName { get; }
```

#### Property Value

 RepeatedField<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="Divine_Protobufs_Dota2_CMsgDevNewItemRequest_AttrValue"></a> AttrValue

```csharp
public RepeatedField<string> AttrValue { get; }
```

#### Property Value

 RepeatedField<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="Divine_Protobufs_Dota2_CMsgDevNewItemRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDevNewItemRequest_HasItemDefName"></a> HasItemDefName

```csharp
public bool HasItemDefName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDevNewItemRequest_HasItemQuality"></a> HasItemQuality

```csharp
public bool HasItemQuality { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDevNewItemRequest_HasLootListName"></a> HasLootListName

```csharp
public bool HasLootListName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDevNewItemRequest_ItemDefName"></a> ItemDefName

```csharp
public string ItemDefName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDevNewItemRequest_ItemQuality"></a> ItemQuality

```csharp
public uint ItemQuality { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDevNewItemRequest_LootListName"></a> LootListName

```csharp
public string LootListName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDevNewItemRequest_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDevNewItemRequest> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDevNewItemRequest](Divine.Protobufs.Dota2.CMsgDevNewItemRequest.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDevNewItemRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDevNewItemRequest_ClearItemDefName"></a> ClearItemDefName\(\)

```csharp
public void ClearItemDefName()
```

### <a id="Divine_Protobufs_Dota2_CMsgDevNewItemRequest_ClearItemQuality"></a> ClearItemQuality\(\)

```csharp
public void ClearItemQuality()
```

### <a id="Divine_Protobufs_Dota2_CMsgDevNewItemRequest_ClearLootListName"></a> ClearLootListName\(\)

```csharp
public void ClearLootListName()
```

### <a id="Divine_Protobufs_Dota2_CMsgDevNewItemRequest_Clone"></a> Clone\(\)

```csharp
public CMsgDevNewItemRequest Clone()
```

#### Returns

 [CMsgDevNewItemRequest](Divine.Protobufs.Dota2.CMsgDevNewItemRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgDevNewItemRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDevNewItemRequest_Equals_Divine_Protobufs_Dota2_CMsgDevNewItemRequest_"></a> Equals\(CMsgDevNewItemRequest\)

```csharp
public bool Equals(CMsgDevNewItemRequest other)
```

#### Parameters

`other` [CMsgDevNewItemRequest](Divine.Protobufs.Dota2.CMsgDevNewItemRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDevNewItemRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDevNewItemRequest_MergeFrom_Divine_Protobufs_Dota2_CMsgDevNewItemRequest_"></a> MergeFrom\(CMsgDevNewItemRequest\)

```csharp
public void MergeFrom(CMsgDevNewItemRequest other)
```

#### Parameters

`other` [CMsgDevNewItemRequest](Divine.Protobufs.Dota2.CMsgDevNewItemRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgDevNewItemRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDevNewItemRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDevNewItemRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

