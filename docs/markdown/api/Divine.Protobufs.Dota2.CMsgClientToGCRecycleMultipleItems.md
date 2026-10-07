# <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecycleMultipleItems"></a> Class CMsgClientToGCRecycleMultipleItems

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCRecycleMultipleItems : IMessage<CMsgClientToGCRecycleMultipleItems>, IEquatable<CMsgClientToGCRecycleMultipleItems>, IDeepCloneable<CMsgClientToGCRecycleMultipleItems>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCRecycleMultipleItems](Divine.Protobufs.Dota2.CMsgClientToGCRecycleMultipleItems.md)

#### Implements

IMessage<CMsgClientToGCRecycleMultipleItems\>, 
[IEquatable<CMsgClientToGCRecycleMultipleItems\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCRecycleMultipleItems\>, 
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
[EnumerableExtensions.In<CMsgClientToGCRecycleMultipleItems\>\(CMsgClientToGCRecycleMultipleItems, params CMsgClientToGCRecycleMultipleItems\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecycleMultipleItems__ctor"></a> CMsgClientToGCRecycleMultipleItems\(\)

```csharp
public CMsgClientToGCRecycleMultipleItems()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecycleMultipleItems__ctor_Divine_Protobufs_Dota2_CMsgClientToGCRecycleMultipleItems_"></a> CMsgClientToGCRecycleMultipleItems\(CMsgClientToGCRecycleMultipleItems\)

```csharp
public CMsgClientToGCRecycleMultipleItems(CMsgClientToGCRecycleMultipleItems other)
```

#### Parameters

`other` [CMsgClientToGCRecycleMultipleItems](Divine.Protobufs.Dota2.CMsgClientToGCRecycleMultipleItems.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecycleMultipleItems_ItemsFieldNumber"></a> ItemsFieldNumber

```csharp
public const int ItemsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecycleMultipleItems_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecycleMultipleItems_Items"></a> Items

```csharp
public RepeatedField<CMsgClientToGCRecycleMultipleItems.Types.Item> Items { get; }
```

#### Property Value

 RepeatedField<[CMsgClientToGCRecycleMultipleItems](Divine.Protobufs.Dota2.CMsgClientToGCRecycleMultipleItems.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCRecycleMultipleItems.Types.md).[Item](Divine.Protobufs.Dota2.CMsgClientToGCRecycleMultipleItems.Types.Item.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecycleMultipleItems_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCRecycleMultipleItems> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCRecycleMultipleItems](Divine.Protobufs.Dota2.CMsgClientToGCRecycleMultipleItems.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecycleMultipleItems_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecycleMultipleItems_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCRecycleMultipleItems Clone()
```

#### Returns

 [CMsgClientToGCRecycleMultipleItems](Divine.Protobufs.Dota2.CMsgClientToGCRecycleMultipleItems.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecycleMultipleItems_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecycleMultipleItems_Equals_Divine_Protobufs_Dota2_CMsgClientToGCRecycleMultipleItems_"></a> Equals\(CMsgClientToGCRecycleMultipleItems\)

```csharp
public bool Equals(CMsgClientToGCRecycleMultipleItems other)
```

#### Parameters

`other` [CMsgClientToGCRecycleMultipleItems](Divine.Protobufs.Dota2.CMsgClientToGCRecycleMultipleItems.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecycleMultipleItems_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecycleMultipleItems_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCRecycleMultipleItems_"></a> MergeFrom\(CMsgClientToGCRecycleMultipleItems\)

```csharp
public void MergeFrom(CMsgClientToGCRecycleMultipleItems other)
```

#### Parameters

`other` [CMsgClientToGCRecycleMultipleItems](Divine.Protobufs.Dota2.CMsgClientToGCRecycleMultipleItems.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecycleMultipleItems_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecycleMultipleItems_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecycleMultipleItems_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

