# <a id="Divine_Protobufs_Dota2_CSOEconItemEquipped"></a> Class CSOEconItemEquipped

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSOEconItemEquipped : IMessage<CSOEconItemEquipped>, IEquatable<CSOEconItemEquipped>, IDeepCloneable<CSOEconItemEquipped>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSOEconItemEquipped](Divine.Protobufs.Dota2.CSOEconItemEquipped.md)

#### Implements

IMessage<CSOEconItemEquipped\>, 
[IEquatable<CSOEconItemEquipped\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSOEconItemEquipped\>, 
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
[EnumerableExtensions.In<CSOEconItemEquipped\>\(CSOEconItemEquipped, params CSOEconItemEquipped\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSOEconItemEquipped__ctor"></a> CSOEconItemEquipped\(\)

```csharp
public CSOEconItemEquipped()
```

### <a id="Divine_Protobufs_Dota2_CSOEconItemEquipped__ctor_Divine_Protobufs_Dota2_CSOEconItemEquipped_"></a> CSOEconItemEquipped\(CSOEconItemEquipped\)

```csharp
public CSOEconItemEquipped(CSOEconItemEquipped other)
```

#### Parameters

`other` [CSOEconItemEquipped](Divine.Protobufs.Dota2.CSOEconItemEquipped.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSOEconItemEquipped_NewClassFieldNumber"></a> NewClassFieldNumber

```csharp
public const int NewClassFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSOEconItemEquipped_NewSlotFieldNumber"></a> NewSlotFieldNumber

```csharp
public const int NewSlotFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSOEconItemEquipped_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSOEconItemEquipped_HasNewClass"></a> HasNewClass

```csharp
public bool HasNewClass { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSOEconItemEquipped_HasNewSlot"></a> HasNewSlot

```csharp
public bool HasNewSlot { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSOEconItemEquipped_NewClass"></a> NewClass

```csharp
public uint NewClass { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSOEconItemEquipped_NewSlot"></a> NewSlot

```csharp
public uint NewSlot { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSOEconItemEquipped_Parser"></a> Parser

```csharp
public static MessageParser<CSOEconItemEquipped> Parser { get; }
```

#### Property Value

 MessageParser<[CSOEconItemEquipped](Divine.Protobufs.Dota2.CSOEconItemEquipped.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CSOEconItemEquipped_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSOEconItemEquipped_ClearNewClass"></a> ClearNewClass\(\)

```csharp
public void ClearNewClass()
```

### <a id="Divine_Protobufs_Dota2_CSOEconItemEquipped_ClearNewSlot"></a> ClearNewSlot\(\)

```csharp
public void ClearNewSlot()
```

### <a id="Divine_Protobufs_Dota2_CSOEconItemEquipped_Clone"></a> Clone\(\)

```csharp
public CSOEconItemEquipped Clone()
```

#### Returns

 [CSOEconItemEquipped](Divine.Protobufs.Dota2.CSOEconItemEquipped.md)

### <a id="Divine_Protobufs_Dota2_CSOEconItemEquipped_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSOEconItemEquipped_Equals_Divine_Protobufs_Dota2_CSOEconItemEquipped_"></a> Equals\(CSOEconItemEquipped\)

```csharp
public bool Equals(CSOEconItemEquipped other)
```

#### Parameters

`other` [CSOEconItemEquipped](Divine.Protobufs.Dota2.CSOEconItemEquipped.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSOEconItemEquipped_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSOEconItemEquipped_MergeFrom_Divine_Protobufs_Dota2_CSOEconItemEquipped_"></a> MergeFrom\(CSOEconItemEquipped\)

```csharp
public void MergeFrom(CSOEconItemEquipped other)
```

#### Parameters

`other` [CSOEconItemEquipped](Divine.Protobufs.Dota2.CSOEconItemEquipped.md)

### <a id="Divine_Protobufs_Dota2_CSOEconItemEquipped_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSOEconItemEquipped_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSOEconItemEquipped_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

