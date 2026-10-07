# <a id="Divine_Protobufs_Dota2_CSOEconItemAttribute"></a> Class CSOEconItemAttribute

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSOEconItemAttribute : IMessage<CSOEconItemAttribute>, IEquatable<CSOEconItemAttribute>, IDeepCloneable<CSOEconItemAttribute>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSOEconItemAttribute](Divine.Protobufs.Dota2.CSOEconItemAttribute.md)

#### Implements

IMessage<CSOEconItemAttribute\>, 
[IEquatable<CSOEconItemAttribute\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSOEconItemAttribute\>, 
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
[EnumerableExtensions.In<CSOEconItemAttribute\>\(CSOEconItemAttribute, params CSOEconItemAttribute\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSOEconItemAttribute__ctor"></a> CSOEconItemAttribute\(\)

```csharp
public CSOEconItemAttribute()
```

### <a id="Divine_Protobufs_Dota2_CSOEconItemAttribute__ctor_Divine_Protobufs_Dota2_CSOEconItemAttribute_"></a> CSOEconItemAttribute\(CSOEconItemAttribute\)

```csharp
public CSOEconItemAttribute(CSOEconItemAttribute other)
```

#### Parameters

`other` [CSOEconItemAttribute](Divine.Protobufs.Dota2.CSOEconItemAttribute.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSOEconItemAttribute_DefIndexFieldNumber"></a> DefIndexFieldNumber

```csharp
public const int DefIndexFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSOEconItemAttribute_ValueBytesFieldNumber"></a> ValueBytesFieldNumber

```csharp
public const int ValueBytesFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSOEconItemAttribute_ValueFieldNumber"></a> ValueFieldNumber

```csharp
public const int ValueFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSOEconItemAttribute_DefIndex"></a> DefIndex

```csharp
public uint DefIndex { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSOEconItemAttribute_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSOEconItemAttribute_HasDefIndex"></a> HasDefIndex

```csharp
public bool HasDefIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSOEconItemAttribute_HasValue"></a> HasValue

```csharp
public bool HasValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSOEconItemAttribute_HasValueBytes"></a> HasValueBytes

```csharp
public bool HasValueBytes { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSOEconItemAttribute_Parser"></a> Parser

```csharp
public static MessageParser<CSOEconItemAttribute> Parser { get; }
```

#### Property Value

 MessageParser<[CSOEconItemAttribute](Divine.Protobufs.Dota2.CSOEconItemAttribute.md)\>

### <a id="Divine_Protobufs_Dota2_CSOEconItemAttribute_Value"></a> Value

```csharp
public uint Value { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSOEconItemAttribute_ValueBytes"></a> ValueBytes

```csharp
public ByteString ValueBytes { get; set; }
```

#### Property Value

 ByteString

## Methods

### <a id="Divine_Protobufs_Dota2_CSOEconItemAttribute_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSOEconItemAttribute_ClearDefIndex"></a> ClearDefIndex\(\)

```csharp
public void ClearDefIndex()
```

### <a id="Divine_Protobufs_Dota2_CSOEconItemAttribute_ClearValue"></a> ClearValue\(\)

```csharp
public void ClearValue()
```

### <a id="Divine_Protobufs_Dota2_CSOEconItemAttribute_ClearValueBytes"></a> ClearValueBytes\(\)

```csharp
public void ClearValueBytes()
```

### <a id="Divine_Protobufs_Dota2_CSOEconItemAttribute_Clone"></a> Clone\(\)

```csharp
public CSOEconItemAttribute Clone()
```

#### Returns

 [CSOEconItemAttribute](Divine.Protobufs.Dota2.CSOEconItemAttribute.md)

### <a id="Divine_Protobufs_Dota2_CSOEconItemAttribute_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSOEconItemAttribute_Equals_Divine_Protobufs_Dota2_CSOEconItemAttribute_"></a> Equals\(CSOEconItemAttribute\)

```csharp
public bool Equals(CSOEconItemAttribute other)
```

#### Parameters

`other` [CSOEconItemAttribute](Divine.Protobufs.Dota2.CSOEconItemAttribute.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSOEconItemAttribute_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSOEconItemAttribute_MergeFrom_Divine_Protobufs_Dota2_CSOEconItemAttribute_"></a> MergeFrom\(CSOEconItemAttribute\)

```csharp
public void MergeFrom(CSOEconItemAttribute other)
```

#### Parameters

`other` [CSOEconItemAttribute](Divine.Protobufs.Dota2.CSOEconItemAttribute.md)

### <a id="Divine_Protobufs_Dota2_CSOEconItemAttribute_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSOEconItemAttribute_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSOEconItemAttribute_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

