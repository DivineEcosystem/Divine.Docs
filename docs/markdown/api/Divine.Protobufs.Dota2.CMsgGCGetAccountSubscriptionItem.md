# <a id="Divine_Protobufs_Dota2_CMsgGCGetAccountSubscriptionItem"></a> Class CMsgGCGetAccountSubscriptionItem

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCGetAccountSubscriptionItem : IMessage<CMsgGCGetAccountSubscriptionItem>, IEquatable<CMsgGCGetAccountSubscriptionItem>, IDeepCloneable<CMsgGCGetAccountSubscriptionItem>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCGetAccountSubscriptionItem](Divine.Protobufs.Dota2.CMsgGCGetAccountSubscriptionItem.md)

#### Implements

IMessage<CMsgGCGetAccountSubscriptionItem\>, 
[IEquatable<CMsgGCGetAccountSubscriptionItem\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCGetAccountSubscriptionItem\>, 
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
[EnumerableExtensions.In<CMsgGCGetAccountSubscriptionItem\>\(CMsgGCGetAccountSubscriptionItem, params CMsgGCGetAccountSubscriptionItem\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCGetAccountSubscriptionItem__ctor"></a> CMsgGCGetAccountSubscriptionItem\(\)

```csharp
public CMsgGCGetAccountSubscriptionItem()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCGetAccountSubscriptionItem__ctor_Divine_Protobufs_Dota2_CMsgGCGetAccountSubscriptionItem_"></a> CMsgGCGetAccountSubscriptionItem\(CMsgGCGetAccountSubscriptionItem\)

```csharp
public CMsgGCGetAccountSubscriptionItem(CMsgGCGetAccountSubscriptionItem other)
```

#### Parameters

`other` [CMsgGCGetAccountSubscriptionItem](Divine.Protobufs.Dota2.CMsgGCGetAccountSubscriptionItem.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCGetAccountSubscriptionItem_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCGetAccountSubscriptionItem_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetAccountSubscriptionItem_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCGetAccountSubscriptionItem_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetAccountSubscriptionItem_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCGetAccountSubscriptionItem> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCGetAccountSubscriptionItem](Divine.Protobufs.Dota2.CMsgGCGetAccountSubscriptionItem.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCGetAccountSubscriptionItem_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetAccountSubscriptionItem_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCGetAccountSubscriptionItem_Clone"></a> Clone\(\)

```csharp
public CMsgGCGetAccountSubscriptionItem Clone()
```

#### Returns

 [CMsgGCGetAccountSubscriptionItem](Divine.Protobufs.Dota2.CMsgGCGetAccountSubscriptionItem.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetAccountSubscriptionItem_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetAccountSubscriptionItem_Equals_Divine_Protobufs_Dota2_CMsgGCGetAccountSubscriptionItem_"></a> Equals\(CMsgGCGetAccountSubscriptionItem\)

```csharp
public bool Equals(CMsgGCGetAccountSubscriptionItem other)
```

#### Parameters

`other` [CMsgGCGetAccountSubscriptionItem](Divine.Protobufs.Dota2.CMsgGCGetAccountSubscriptionItem.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetAccountSubscriptionItem_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetAccountSubscriptionItem_MergeFrom_Divine_Protobufs_Dota2_CMsgGCGetAccountSubscriptionItem_"></a> MergeFrom\(CMsgGCGetAccountSubscriptionItem\)

```csharp
public void MergeFrom(CMsgGCGetAccountSubscriptionItem other)
```

#### Parameters

`other` [CMsgGCGetAccountSubscriptionItem](Divine.Protobufs.Dota2.CMsgGCGetAccountSubscriptionItem.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetAccountSubscriptionItem_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCGetAccountSubscriptionItem_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetAccountSubscriptionItem_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

