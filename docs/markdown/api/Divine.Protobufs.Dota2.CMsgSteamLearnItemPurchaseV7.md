# <a id="Divine_Protobufs_Dota2_CMsgSteamLearnItemPurchaseV7"></a> Class CMsgSteamLearnItemPurchaseV7

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamLearnItemPurchaseV7 : IMessage<CMsgSteamLearnItemPurchaseV7>, IEquatable<CMsgSteamLearnItemPurchaseV7>, IDeepCloneable<CMsgSteamLearnItemPurchaseV7>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamLearnItemPurchaseV7](Divine.Protobufs.Dota2.CMsgSteamLearnItemPurchaseV7.md)

#### Implements

IMessage<CMsgSteamLearnItemPurchaseV7\>, 
[IEquatable<CMsgSteamLearnItemPurchaseV7\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamLearnItemPurchaseV7\>, 
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
[EnumerableExtensions.In<CMsgSteamLearnItemPurchaseV7\>\(CMsgSteamLearnItemPurchaseV7, params CMsgSteamLearnItemPurchaseV7\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnItemPurchaseV7__ctor"></a> CMsgSteamLearnItemPurchaseV7\(\)

```csharp
public CMsgSteamLearnItemPurchaseV7()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnItemPurchaseV7__ctor_Divine_Protobufs_Dota2_CMsgSteamLearnItemPurchaseV7_"></a> CMsgSteamLearnItemPurchaseV7\(CMsgSteamLearnItemPurchaseV7\)

```csharp
public CMsgSteamLearnItemPurchaseV7(CMsgSteamLearnItemPurchaseV7 other)
```

#### Parameters

`other` [CMsgSteamLearnItemPurchaseV7](Divine.Protobufs.Dota2.CMsgSteamLearnItemPurchaseV7.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnItemPurchaseV7_ItemIdFieldNumber"></a> ItemIdFieldNumber

```csharp
public const int ItemIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnItemPurchaseV7_PurchaseHistoryFieldNumber"></a> PurchaseHistoryFieldNumber

```csharp
public const int PurchaseHistoryFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnItemPurchaseV7_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnItemPurchaseV7_HasItemId"></a> HasItemId

```csharp
public bool HasItemId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnItemPurchaseV7_ItemId"></a> ItemId

```csharp
public int ItemId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnItemPurchaseV7_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamLearnItemPurchaseV7> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamLearnItemPurchaseV7](Divine.Protobufs.Dota2.CMsgSteamLearnItemPurchaseV7.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnItemPurchaseV7_PurchaseHistory"></a> PurchaseHistory

```csharp
public RepeatedField<int> PurchaseHistory { get; }
```

#### Property Value

 RepeatedField<[int](https://learn.microsoft.com/dotnet/api/system.int32)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnItemPurchaseV7_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnItemPurchaseV7_ClearItemId"></a> ClearItemId\(\)

```csharp
public void ClearItemId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnItemPurchaseV7_Clone"></a> Clone\(\)

```csharp
public CMsgSteamLearnItemPurchaseV7 Clone()
```

#### Returns

 [CMsgSteamLearnItemPurchaseV7](Divine.Protobufs.Dota2.CMsgSteamLearnItemPurchaseV7.md)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnItemPurchaseV7_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnItemPurchaseV7_Equals_Divine_Protobufs_Dota2_CMsgSteamLearnItemPurchaseV7_"></a> Equals\(CMsgSteamLearnItemPurchaseV7\)

```csharp
public bool Equals(CMsgSteamLearnItemPurchaseV7 other)
```

#### Parameters

`other` [CMsgSteamLearnItemPurchaseV7](Divine.Protobufs.Dota2.CMsgSteamLearnItemPurchaseV7.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnItemPurchaseV7_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnItemPurchaseV7_MergeFrom_Divine_Protobufs_Dota2_CMsgSteamLearnItemPurchaseV7_"></a> MergeFrom\(CMsgSteamLearnItemPurchaseV7\)

```csharp
public void MergeFrom(CMsgSteamLearnItemPurchaseV7 other)
```

#### Parameters

`other` [CMsgSteamLearnItemPurchaseV7](Divine.Protobufs.Dota2.CMsgSteamLearnItemPurchaseV7.md)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnItemPurchaseV7_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnItemPurchaseV7_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnItemPurchaseV7_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

