# <a id="Divine_Protobufs_Dota2_CMatchAdditionalUnitInventory"></a> Class CMatchAdditionalUnitInventory

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMatchAdditionalUnitInventory : IMessage<CMatchAdditionalUnitInventory>, IEquatable<CMatchAdditionalUnitInventory>, IDeepCloneable<CMatchAdditionalUnitInventory>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMatchAdditionalUnitInventory](Divine.Protobufs.Dota2.CMatchAdditionalUnitInventory.md)

#### Implements

IMessage<CMatchAdditionalUnitInventory\>, 
[IEquatable<CMatchAdditionalUnitInventory\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMatchAdditionalUnitInventory\>, 
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
[EnumerableExtensions.In<CMatchAdditionalUnitInventory\>\(CMatchAdditionalUnitInventory, params CMatchAdditionalUnitInventory\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMatchAdditionalUnitInventory__ctor"></a> CMatchAdditionalUnitInventory\(\)

```csharp
public CMatchAdditionalUnitInventory()
```

### <a id="Divine_Protobufs_Dota2_CMatchAdditionalUnitInventory__ctor_Divine_Protobufs_Dota2_CMatchAdditionalUnitInventory_"></a> CMatchAdditionalUnitInventory\(CMatchAdditionalUnitInventory\)

```csharp
public CMatchAdditionalUnitInventory(CMatchAdditionalUnitInventory other)
```

#### Parameters

`other` [CMatchAdditionalUnitInventory](Divine.Protobufs.Dota2.CMatchAdditionalUnitInventory.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMatchAdditionalUnitInventory_ItemsFieldNumber"></a> ItemsFieldNumber

```csharp
public const int ItemsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMatchAdditionalUnitInventory_UnitNameFieldNumber"></a> UnitNameFieldNumber

```csharp
public const int UnitNameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMatchAdditionalUnitInventory_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMatchAdditionalUnitInventory_HasUnitName"></a> HasUnitName

```csharp
public bool HasUnitName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMatchAdditionalUnitInventory_Items"></a> Items

```csharp
public RepeatedField<int> Items { get; }
```

#### Property Value

 RepeatedField<[int](https://learn.microsoft.com/dotnet/api/system.int32)\>

### <a id="Divine_Protobufs_Dota2_CMatchAdditionalUnitInventory_Parser"></a> Parser

```csharp
public static MessageParser<CMatchAdditionalUnitInventory> Parser { get; }
```

#### Property Value

 MessageParser<[CMatchAdditionalUnitInventory](Divine.Protobufs.Dota2.CMatchAdditionalUnitInventory.md)\>

### <a id="Divine_Protobufs_Dota2_CMatchAdditionalUnitInventory_UnitName"></a> UnitName

```csharp
public string UnitName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Dota2_CMatchAdditionalUnitInventory_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMatchAdditionalUnitInventory_ClearUnitName"></a> ClearUnitName\(\)

```csharp
public void ClearUnitName()
```

### <a id="Divine_Protobufs_Dota2_CMatchAdditionalUnitInventory_Clone"></a> Clone\(\)

```csharp
public CMatchAdditionalUnitInventory Clone()
```

#### Returns

 [CMatchAdditionalUnitInventory](Divine.Protobufs.Dota2.CMatchAdditionalUnitInventory.md)

### <a id="Divine_Protobufs_Dota2_CMatchAdditionalUnitInventory_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMatchAdditionalUnitInventory_Equals_Divine_Protobufs_Dota2_CMatchAdditionalUnitInventory_"></a> Equals\(CMatchAdditionalUnitInventory\)

```csharp
public bool Equals(CMatchAdditionalUnitInventory other)
```

#### Parameters

`other` [CMatchAdditionalUnitInventory](Divine.Protobufs.Dota2.CMatchAdditionalUnitInventory.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMatchAdditionalUnitInventory_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMatchAdditionalUnitInventory_MergeFrom_Divine_Protobufs_Dota2_CMatchAdditionalUnitInventory_"></a> MergeFrom\(CMatchAdditionalUnitInventory\)

```csharp
public void MergeFrom(CMatchAdditionalUnitInventory other)
```

#### Parameters

`other` [CMatchAdditionalUnitInventory](Divine.Protobufs.Dota2.CMatchAdditionalUnitInventory.md)

### <a id="Divine_Protobufs_Dota2_CMatchAdditionalUnitInventory_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMatchAdditionalUnitInventory_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMatchAdditionalUnitInventory_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

