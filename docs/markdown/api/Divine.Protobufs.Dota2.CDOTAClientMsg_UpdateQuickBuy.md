# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateQuickBuy"></a> Class CDOTAClientMsg\_UpdateQuickBuy

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_UpdateQuickBuy : IMessage<CDOTAClientMsg_UpdateQuickBuy>, IEquatable<CDOTAClientMsg_UpdateQuickBuy>, IDeepCloneable<CDOTAClientMsg_UpdateQuickBuy>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_UpdateQuickBuy](Divine.Protobufs.Dota2.CDOTAClientMsg\_UpdateQuickBuy.md)

#### Implements

IMessage<CDOTAClientMsg\_UpdateQuickBuy\>, 
[IEquatable<CDOTAClientMsg\_UpdateQuickBuy\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_UpdateQuickBuy\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_UpdateQuickBuy\>\(CDOTAClientMsg\_UpdateQuickBuy, params CDOTAClientMsg\_UpdateQuickBuy\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateQuickBuy__ctor"></a> CDOTAClientMsg\_UpdateQuickBuy\(\)

```csharp
public CDOTAClientMsg_UpdateQuickBuy()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateQuickBuy__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateQuickBuy_"></a> CDOTAClientMsg\_UpdateQuickBuy\(CDOTAClientMsg\_UpdateQuickBuy\)

```csharp
public CDOTAClientMsg_UpdateQuickBuy(CDOTAClientMsg_UpdateQuickBuy other)
```

#### Parameters

`other` [CDOTAClientMsg\_UpdateQuickBuy](Divine.Protobufs.Dota2.CDOTAClientMsg\_UpdateQuickBuy.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateQuickBuy_GoalItemAbilityIdsFieldNumber"></a> GoalItemAbilityIdsFieldNumber

```csharp
public const int GoalItemAbilityIdsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateQuickBuy_ItemsFieldNumber"></a> ItemsFieldNumber

```csharp
public const int ItemsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateQuickBuy_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateQuickBuy_GoalItemAbilityIds"></a> GoalItemAbilityIds

```csharp
public RepeatedField<int> GoalItemAbilityIds { get; }
```

#### Property Value

 RepeatedField<[int](https://learn.microsoft.com/dotnet/api/system.int32)\>

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateQuickBuy_Items"></a> Items

```csharp
public RepeatedField<CDOTAClientMsg_UpdateQuickBuyItem> Items { get; }
```

#### Property Value

 RepeatedField<[CDOTAClientMsg\_UpdateQuickBuyItem](Divine.Protobufs.Dota2.CDOTAClientMsg\_UpdateQuickBuyItem.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateQuickBuy_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_UpdateQuickBuy> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_UpdateQuickBuy](Divine.Protobufs.Dota2.CDOTAClientMsg\_UpdateQuickBuy.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateQuickBuy_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateQuickBuy_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_UpdateQuickBuy Clone()
```

#### Returns

 [CDOTAClientMsg\_UpdateQuickBuy](Divine.Protobufs.Dota2.CDOTAClientMsg\_UpdateQuickBuy.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateQuickBuy_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateQuickBuy_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateQuickBuy_"></a> Equals\(CDOTAClientMsg\_UpdateQuickBuy\)

```csharp
public bool Equals(CDOTAClientMsg_UpdateQuickBuy other)
```

#### Parameters

`other` [CDOTAClientMsg\_UpdateQuickBuy](Divine.Protobufs.Dota2.CDOTAClientMsg\_UpdateQuickBuy.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateQuickBuy_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateQuickBuy_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateQuickBuy_"></a> MergeFrom\(CDOTAClientMsg\_UpdateQuickBuy\)

```csharp
public void MergeFrom(CDOTAClientMsg_UpdateQuickBuy other)
```

#### Parameters

`other` [CDOTAClientMsg\_UpdateQuickBuy](Divine.Protobufs.Dota2.CDOTAClientMsg\_UpdateQuickBuy.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateQuickBuy_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateQuickBuy_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateQuickBuy_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

