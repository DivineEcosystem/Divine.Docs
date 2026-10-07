# <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPreGameItemPurchase"></a> Class CMsgSteamLearnPreGameItemPurchase

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamLearnPreGameItemPurchase : IMessage<CMsgSteamLearnPreGameItemPurchase>, IEquatable<CMsgSteamLearnPreGameItemPurchase>, IDeepCloneable<CMsgSteamLearnPreGameItemPurchase>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamLearnPreGameItemPurchase](Divine.Protobufs.Dota2.CMsgSteamLearnPreGameItemPurchase.md)

#### Implements

IMessage<CMsgSteamLearnPreGameItemPurchase\>, 
[IEquatable<CMsgSteamLearnPreGameItemPurchase\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamLearnPreGameItemPurchase\>, 
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
[EnumerableExtensions.In<CMsgSteamLearnPreGameItemPurchase\>\(CMsgSteamLearnPreGameItemPurchase, params CMsgSteamLearnPreGameItemPurchase\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPreGameItemPurchase__ctor"></a> CMsgSteamLearnPreGameItemPurchase\(\)

```csharp
public CMsgSteamLearnPreGameItemPurchase()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPreGameItemPurchase__ctor_Divine_Protobufs_Dota2_CMsgSteamLearnPreGameItemPurchase_"></a> CMsgSteamLearnPreGameItemPurchase\(CMsgSteamLearnPreGameItemPurchase\)

```csharp
public CMsgSteamLearnPreGameItemPurchase(CMsgSteamLearnPreGameItemPurchase other)
```

#### Parameters

`other` [CMsgSteamLearnPreGameItemPurchase](Divine.Protobufs.Dota2.CMsgSteamLearnPreGameItemPurchase.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPreGameItemPurchase_ItemIdFieldNumber"></a> ItemIdFieldNumber

```csharp
public const int ItemIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPreGameItemPurchase_PurchaseHistoryFieldNumber"></a> PurchaseHistoryFieldNumber

```csharp
public const int PurchaseHistoryFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPreGameItemPurchase_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPreGameItemPurchase_HasItemId"></a> HasItemId

```csharp
public bool HasItemId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPreGameItemPurchase_ItemId"></a> ItemId

```csharp
public int ItemId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPreGameItemPurchase_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamLearnPreGameItemPurchase> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamLearnPreGameItemPurchase](Divine.Protobufs.Dota2.CMsgSteamLearnPreGameItemPurchase.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPreGameItemPurchase_PurchaseHistory"></a> PurchaseHistory

```csharp
public RepeatedField<int> PurchaseHistory { get; }
```

#### Property Value

 RepeatedField<[int](https://learn.microsoft.com/dotnet/api/system.int32)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPreGameItemPurchase_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPreGameItemPurchase_ClearItemId"></a> ClearItemId\(\)

```csharp
public void ClearItemId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPreGameItemPurchase_Clone"></a> Clone\(\)

```csharp
public CMsgSteamLearnPreGameItemPurchase Clone()
```

#### Returns

 [CMsgSteamLearnPreGameItemPurchase](Divine.Protobufs.Dota2.CMsgSteamLearnPreGameItemPurchase.md)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPreGameItemPurchase_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPreGameItemPurchase_Equals_Divine_Protobufs_Dota2_CMsgSteamLearnPreGameItemPurchase_"></a> Equals\(CMsgSteamLearnPreGameItemPurchase\)

```csharp
public bool Equals(CMsgSteamLearnPreGameItemPurchase other)
```

#### Parameters

`other` [CMsgSteamLearnPreGameItemPurchase](Divine.Protobufs.Dota2.CMsgSteamLearnPreGameItemPurchase.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPreGameItemPurchase_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPreGameItemPurchase_MergeFrom_Divine_Protobufs_Dota2_CMsgSteamLearnPreGameItemPurchase_"></a> MergeFrom\(CMsgSteamLearnPreGameItemPurchase\)

```csharp
public void MergeFrom(CMsgSteamLearnPreGameItemPurchase other)
```

#### Parameters

`other` [CMsgSteamLearnPreGameItemPurchase](Divine.Protobufs.Dota2.CMsgSteamLearnPreGameItemPurchase.md)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPreGameItemPurchase_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPreGameItemPurchase_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnPreGameItemPurchase_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

