# <a id="Divine_Protobufs_Dota2_CMsgGCToGCBetaDeleteItems"></a> Class CMsgGCToGCBetaDeleteItems

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToGCBetaDeleteItems : IMessage<CMsgGCToGCBetaDeleteItems>, IEquatable<CMsgGCToGCBetaDeleteItems>, IDeepCloneable<CMsgGCToGCBetaDeleteItems>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToGCBetaDeleteItems](Divine.Protobufs.Dota2.CMsgGCToGCBetaDeleteItems.md)

#### Implements

IMessage<CMsgGCToGCBetaDeleteItems\>, 
[IEquatable<CMsgGCToGCBetaDeleteItems\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToGCBetaDeleteItems\>, 
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
[EnumerableExtensions.In<CMsgGCToGCBetaDeleteItems\>\(CMsgGCToGCBetaDeleteItems, params CMsgGCToGCBetaDeleteItems\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBetaDeleteItems__ctor"></a> CMsgGCToGCBetaDeleteItems\(\)

```csharp
public CMsgGCToGCBetaDeleteItems()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBetaDeleteItems__ctor_Divine_Protobufs_Dota2_CMsgGCToGCBetaDeleteItems_"></a> CMsgGCToGCBetaDeleteItems\(CMsgGCToGCBetaDeleteItems\)

```csharp
public CMsgGCToGCBetaDeleteItems(CMsgGCToGCBetaDeleteItems other)
```

#### Parameters

`other` [CMsgGCToGCBetaDeleteItems](Divine.Protobufs.Dota2.CMsgGCToGCBetaDeleteItems.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBetaDeleteItems_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBetaDeleteItems_ItemDefsFieldNumber"></a> ItemDefsFieldNumber

```csharp
public const int ItemDefsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBetaDeleteItems_ItemIdsFieldNumber"></a> ItemIdsFieldNumber

```csharp
public const int ItemIdsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBetaDeleteItems_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBetaDeleteItems_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBetaDeleteItems_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBetaDeleteItems_ItemDefs"></a> ItemDefs

```csharp
public RepeatedField<uint> ItemDefs { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBetaDeleteItems_ItemIds"></a> ItemIds

```csharp
public RepeatedField<ulong> ItemIds { get; }
```

#### Property Value

 RepeatedField<[ulong](https://learn.microsoft.com/dotnet/api/system.uint64)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBetaDeleteItems_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToGCBetaDeleteItems> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToGCBetaDeleteItems](Divine.Protobufs.Dota2.CMsgGCToGCBetaDeleteItems.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBetaDeleteItems_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBetaDeleteItems_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBetaDeleteItems_Clone"></a> Clone\(\)

```csharp
public CMsgGCToGCBetaDeleteItems Clone()
```

#### Returns

 [CMsgGCToGCBetaDeleteItems](Divine.Protobufs.Dota2.CMsgGCToGCBetaDeleteItems.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBetaDeleteItems_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBetaDeleteItems_Equals_Divine_Protobufs_Dota2_CMsgGCToGCBetaDeleteItems_"></a> Equals\(CMsgGCToGCBetaDeleteItems\)

```csharp
public bool Equals(CMsgGCToGCBetaDeleteItems other)
```

#### Parameters

`other` [CMsgGCToGCBetaDeleteItems](Divine.Protobufs.Dota2.CMsgGCToGCBetaDeleteItems.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBetaDeleteItems_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBetaDeleteItems_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToGCBetaDeleteItems_"></a> MergeFrom\(CMsgGCToGCBetaDeleteItems\)

```csharp
public void MergeFrom(CMsgGCToGCBetaDeleteItems other)
```

#### Parameters

`other` [CMsgGCToGCBetaDeleteItems](Divine.Protobufs.Dota2.CMsgGCToGCBetaDeleteItems.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBetaDeleteItems_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBetaDeleteItems_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCBetaDeleteItems_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

