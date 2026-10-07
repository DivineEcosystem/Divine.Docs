# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ItemPurchased"></a> Class CDOTAUserMsg\_ItemPurchased

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_ItemPurchased : IMessage<CDOTAUserMsg_ItemPurchased>, IEquatable<CDOTAUserMsg_ItemPurchased>, IDeepCloneable<CDOTAUserMsg_ItemPurchased>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_ItemPurchased](Divine.Protobufs.Dota2.CDOTAUserMsg\_ItemPurchased.md)

#### Implements

IMessage<CDOTAUserMsg\_ItemPurchased\>, 
[IEquatable<CDOTAUserMsg\_ItemPurchased\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_ItemPurchased\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_ItemPurchased\>\(CDOTAUserMsg\_ItemPurchased, params CDOTAUserMsg\_ItemPurchased\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ItemPurchased__ctor"></a> CDOTAUserMsg\_ItemPurchased\(\)

```csharp
public CDOTAUserMsg_ItemPurchased()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ItemPurchased__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_ItemPurchased_"></a> CDOTAUserMsg\_ItemPurchased\(CDOTAUserMsg\_ItemPurchased\)

```csharp
public CDOTAUserMsg_ItemPurchased(CDOTAUserMsg_ItemPurchased other)
```

#### Parameters

`other` [CDOTAUserMsg\_ItemPurchased](Divine.Protobufs.Dota2.CDOTAUserMsg\_ItemPurchased.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ItemPurchased_FromCombineFieldNumber"></a> FromCombineFieldNumber

```csharp
public const int FromCombineFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ItemPurchased_ItemAbilityIdFieldNumber"></a> ItemAbilityIdFieldNumber

```csharp
public const int ItemAbilityIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ItemPurchased_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ItemPurchased_FromCombine"></a> FromCombine

```csharp
public bool FromCombine { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ItemPurchased_HasFromCombine"></a> HasFromCombine

```csharp
public bool HasFromCombine { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ItemPurchased_HasItemAbilityId"></a> HasItemAbilityId

```csharp
public bool HasItemAbilityId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ItemPurchased_ItemAbilityId"></a> ItemAbilityId

```csharp
public int ItemAbilityId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ItemPurchased_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_ItemPurchased> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_ItemPurchased](Divine.Protobufs.Dota2.CDOTAUserMsg\_ItemPurchased.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ItemPurchased_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ItemPurchased_ClearFromCombine"></a> ClearFromCombine\(\)

```csharp
public void ClearFromCombine()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ItemPurchased_ClearItemAbilityId"></a> ClearItemAbilityId\(\)

```csharp
public void ClearItemAbilityId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ItemPurchased_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_ItemPurchased Clone()
```

#### Returns

 [CDOTAUserMsg\_ItemPurchased](Divine.Protobufs.Dota2.CDOTAUserMsg\_ItemPurchased.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ItemPurchased_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ItemPurchased_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_ItemPurchased_"></a> Equals\(CDOTAUserMsg\_ItemPurchased\)

```csharp
public bool Equals(CDOTAUserMsg_ItemPurchased other)
```

#### Parameters

`other` [CDOTAUserMsg\_ItemPurchased](Divine.Protobufs.Dota2.CDOTAUserMsg\_ItemPurchased.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ItemPurchased_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ItemPurchased_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_ItemPurchased_"></a> MergeFrom\(CDOTAUserMsg\_ItemPurchased\)

```csharp
public void MergeFrom(CDOTAUserMsg_ItemPurchased other)
```

#### Parameters

`other` [CDOTAUserMsg\_ItemPurchased](Divine.Protobufs.Dota2.CDOTAUserMsg\_ItemPurchased.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ItemPurchased_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ItemPurchased_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ItemPurchased_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

