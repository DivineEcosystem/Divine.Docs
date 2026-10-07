# <a id="Divine_Protobufs_Dota2_CMsgGameDataItems"></a> Class CMsgGameDataItems

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGameDataItems : IMessage<CMsgGameDataItems>, IEquatable<CMsgGameDataItems>, IDeepCloneable<CMsgGameDataItems>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGameDataItems](Divine.Protobufs.Dota2.CMsgGameDataItems.md)

#### Implements

IMessage<CMsgGameDataItems\>, 
[IEquatable<CMsgGameDataItems\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGameDataItems\>, 
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
[EnumerableExtensions.In<CMsgGameDataItems\>\(CMsgGameDataItems, params CMsgGameDataItems\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGameDataItems__ctor"></a> CMsgGameDataItems\(\)

```csharp
public CMsgGameDataItems()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataItems__ctor_Divine_Protobufs_Dota2_CMsgGameDataItems_"></a> CMsgGameDataItems\(CMsgGameDataItems\)

```csharp
public CMsgGameDataItems(CMsgGameDataItems other)
```

#### Parameters

`other` [CMsgGameDataItems](Divine.Protobufs.Dota2.CMsgGameDataItems.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGameDataItems_ItemsFieldNumber"></a> ItemsFieldNumber

```csharp
public const int ItemsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGameDataItems_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGameDataItems_Items"></a> Items

```csharp
public RepeatedField<CMsgGameDataAbilityOrItem> Items { get; }
```

#### Property Value

 RepeatedField<[CMsgGameDataAbilityOrItem](Divine.Protobufs.Dota2.CMsgGameDataAbilityOrItem.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGameDataItems_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGameDataItems> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGameDataItems](Divine.Protobufs.Dota2.CMsgGameDataItems.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGameDataItems_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataItems_Clone"></a> Clone\(\)

```csharp
public CMsgGameDataItems Clone()
```

#### Returns

 [CMsgGameDataItems](Divine.Protobufs.Dota2.CMsgGameDataItems.md)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataItems_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataItems_Equals_Divine_Protobufs_Dota2_CMsgGameDataItems_"></a> Equals\(CMsgGameDataItems\)

```csharp
public bool Equals(CMsgGameDataItems other)
```

#### Parameters

`other` [CMsgGameDataItems](Divine.Protobufs.Dota2.CMsgGameDataItems.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataItems_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataItems_MergeFrom_Divine_Protobufs_Dota2_CMsgGameDataItems_"></a> MergeFrom\(CMsgGameDataItems\)

```csharp
public void MergeFrom(CMsgGameDataItems other)
```

#### Parameters

`other` [CMsgGameDataItems](Divine.Protobufs.Dota2.CMsgGameDataItems.md)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataItems_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGameDataItems_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataItems_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

