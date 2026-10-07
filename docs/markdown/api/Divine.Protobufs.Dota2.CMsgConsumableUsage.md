# <a id="Divine_Protobufs_Dota2_CMsgConsumableUsage"></a> Class CMsgConsumableUsage

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgConsumableUsage : IMessage<CMsgConsumableUsage>, IEquatable<CMsgConsumableUsage>, IDeepCloneable<CMsgConsumableUsage>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgConsumableUsage](Divine.Protobufs.Dota2.CMsgConsumableUsage.md)

#### Implements

IMessage<CMsgConsumableUsage\>, 
[IEquatable<CMsgConsumableUsage\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgConsumableUsage\>, 
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
[EnumerableExtensions.In<CMsgConsumableUsage\>\(CMsgConsumableUsage, params CMsgConsumableUsage\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgConsumableUsage__ctor"></a> CMsgConsumableUsage\(\)

```csharp
public CMsgConsumableUsage()
```

### <a id="Divine_Protobufs_Dota2_CMsgConsumableUsage__ctor_Divine_Protobufs_Dota2_CMsgConsumableUsage_"></a> CMsgConsumableUsage\(CMsgConsumableUsage\)

```csharp
public CMsgConsumableUsage(CMsgConsumableUsage other)
```

#### Parameters

`other` [CMsgConsumableUsage](Divine.Protobufs.Dota2.CMsgConsumableUsage.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgConsumableUsage_ItemDefFieldNumber"></a> ItemDefFieldNumber

```csharp
public const int ItemDefFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgConsumableUsage_QuantityChangeFieldNumber"></a> QuantityChangeFieldNumber

```csharp
public const int QuantityChangeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgConsumableUsage_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgConsumableUsage_HasItemDef"></a> HasItemDef

```csharp
public bool HasItemDef { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgConsumableUsage_HasQuantityChange"></a> HasQuantityChange

```csharp
public bool HasQuantityChange { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgConsumableUsage_ItemDef"></a> ItemDef

```csharp
public uint ItemDef { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgConsumableUsage_Parser"></a> Parser

```csharp
public static MessageParser<CMsgConsumableUsage> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgConsumableUsage](Divine.Protobufs.Dota2.CMsgConsumableUsage.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgConsumableUsage_QuantityChange"></a> QuantityChange

```csharp
public int QuantityChange { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgConsumableUsage_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgConsumableUsage_ClearItemDef"></a> ClearItemDef\(\)

```csharp
public void ClearItemDef()
```

### <a id="Divine_Protobufs_Dota2_CMsgConsumableUsage_ClearQuantityChange"></a> ClearQuantityChange\(\)

```csharp
public void ClearQuantityChange()
```

### <a id="Divine_Protobufs_Dota2_CMsgConsumableUsage_Clone"></a> Clone\(\)

```csharp
public CMsgConsumableUsage Clone()
```

#### Returns

 [CMsgConsumableUsage](Divine.Protobufs.Dota2.CMsgConsumableUsage.md)

### <a id="Divine_Protobufs_Dota2_CMsgConsumableUsage_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgConsumableUsage_Equals_Divine_Protobufs_Dota2_CMsgConsumableUsage_"></a> Equals\(CMsgConsumableUsage\)

```csharp
public bool Equals(CMsgConsumableUsage other)
```

#### Parameters

`other` [CMsgConsumableUsage](Divine.Protobufs.Dota2.CMsgConsumableUsage.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgConsumableUsage_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgConsumableUsage_MergeFrom_Divine_Protobufs_Dota2_CMsgConsumableUsage_"></a> MergeFrom\(CMsgConsumableUsage\)

```csharp
public void MergeFrom(CMsgConsumableUsage other)
```

#### Parameters

`other` [CMsgConsumableUsage](Divine.Protobufs.Dota2.CMsgConsumableUsage.md)

### <a id="Divine_Protobufs_Dota2_CMsgConsumableUsage_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgConsumableUsage_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgConsumableUsage_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

