# <a id="Divine_Protobufs_Dota2_CUserMessageRequestInventory"></a> Class CUserMessageRequestInventory

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMessageRequestInventory : IMessage<CUserMessageRequestInventory>, IEquatable<CUserMessageRequestInventory>, IDeepCloneable<CUserMessageRequestInventory>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMessageRequestInventory](Divine.Protobufs.Dota2.CUserMessageRequestInventory.md)

#### Implements

IMessage<CUserMessageRequestInventory\>, 
[IEquatable<CUserMessageRequestInventory\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMessageRequestInventory\>, 
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
[EnumerableExtensions.In<CUserMessageRequestInventory\>\(CUserMessageRequestInventory, params CUserMessageRequestInventory\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestInventory__ctor"></a> CUserMessageRequestInventory\(\)

```csharp
public CUserMessageRequestInventory()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestInventory__ctor_Divine_Protobufs_Dota2_CUserMessageRequestInventory_"></a> CUserMessageRequestInventory\(CUserMessageRequestInventory\)

```csharp
public CUserMessageRequestInventory(CUserMessageRequestInventory other)
```

#### Parameters

`other` [CUserMessageRequestInventory](Divine.Protobufs.Dota2.CUserMessageRequestInventory.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestInventory_InventoryFieldNumber"></a> InventoryFieldNumber

```csharp
public const int InventoryFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestInventory_OffsetFieldNumber"></a> OffsetFieldNumber

```csharp
public const int OffsetFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestInventory_OptionsFieldNumber"></a> OptionsFieldNumber

```csharp
public const int OptionsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestInventory_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestInventory_HasInventory"></a> HasInventory

```csharp
public bool HasInventory { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestInventory_HasOffset"></a> HasOffset

```csharp
public bool HasOffset { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestInventory_HasOptions"></a> HasOptions

```csharp
public bool HasOptions { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestInventory_Inventory"></a> Inventory

```csharp
public int Inventory { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestInventory_Offset"></a> Offset

```csharp
public int Offset { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestInventory_Options"></a> Options

```csharp
public int Options { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestInventory_Parser"></a> Parser

```csharp
public static MessageParser<CUserMessageRequestInventory> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMessageRequestInventory](Divine.Protobufs.Dota2.CUserMessageRequestInventory.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestInventory_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestInventory_ClearInventory"></a> ClearInventory\(\)

```csharp
public void ClearInventory()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestInventory_ClearOffset"></a> ClearOffset\(\)

```csharp
public void ClearOffset()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestInventory_ClearOptions"></a> ClearOptions\(\)

```csharp
public void ClearOptions()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestInventory_Clone"></a> Clone\(\)

```csharp
public CUserMessageRequestInventory Clone()
```

#### Returns

 [CUserMessageRequestInventory](Divine.Protobufs.Dota2.CUserMessageRequestInventory.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestInventory_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestInventory_Equals_Divine_Protobufs_Dota2_CUserMessageRequestInventory_"></a> Equals\(CUserMessageRequestInventory\)

```csharp
public bool Equals(CUserMessageRequestInventory other)
```

#### Parameters

`other` [CUserMessageRequestInventory](Divine.Protobufs.Dota2.CUserMessageRequestInventory.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestInventory_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestInventory_MergeFrom_Divine_Protobufs_Dota2_CUserMessageRequestInventory_"></a> MergeFrom\(CUserMessageRequestInventory\)

```csharp
public void MergeFrom(CUserMessageRequestInventory other)
```

#### Parameters

`other` [CUserMessageRequestInventory](Divine.Protobufs.Dota2.CUserMessageRequestInventory.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestInventory_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestInventory_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestInventory_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

