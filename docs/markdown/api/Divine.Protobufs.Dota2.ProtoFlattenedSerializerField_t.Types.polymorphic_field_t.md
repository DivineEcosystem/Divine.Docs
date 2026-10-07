# <a id="Divine_Protobufs_Dota2_ProtoFlattenedSerializerField_t_Types_polymorphic_field_t"></a> Class ProtoFlattenedSerializerField\_t.Types.polymorphic\_field\_t

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class ProtoFlattenedSerializerField_t.Types.polymorphic_field_t : IMessage<ProtoFlattenedSerializerField_t.Types.polymorphic_field_t>, IEquatable<ProtoFlattenedSerializerField_t.Types.polymorphic_field_t>, IDeepCloneable<ProtoFlattenedSerializerField_t.Types.polymorphic_field_t>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ProtoFlattenedSerializerField\_t.Types.polymorphic\_field\_t](Divine.Protobufs.Dota2.ProtoFlattenedSerializerField\_t.Types.polymorphic\_field\_t.md)

#### Implements

IMessage<ProtoFlattenedSerializerField\_t.Types.polymorphic\_field\_t\>, 
[IEquatable<ProtoFlattenedSerializerField\_t.Types.polymorphic\_field\_t\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<ProtoFlattenedSerializerField\_t.Types.polymorphic\_field\_t\>, 
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
[EnumerableExtensions.In<ProtoFlattenedSerializerField\_t.Types.polymorphic\_field\_t\>\(ProtoFlattenedSerializerField\_t.Types.polymorphic\_field\_t, params ProtoFlattenedSerializerField\_t.Types.polymorphic\_field\_t\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_ProtoFlattenedSerializerField_t_Types_polymorphic_field_t__ctor"></a> polymorphic\_field\_t\(\)

```csharp
public polymorphic_field_t()
```

### <a id="Divine_Protobufs_Dota2_ProtoFlattenedSerializerField_t_Types_polymorphic_field_t__ctor_Divine_Protobufs_Dota2_ProtoFlattenedSerializerField_t_Types_polymorphic_field_t_"></a> polymorphic\_field\_t\(polymorphic\_field\_t\)

```csharp
public polymorphic_field_t(ProtoFlattenedSerializerField_t.Types.polymorphic_field_t other)
```

#### Parameters

`other` [ProtoFlattenedSerializerField\_t](Divine.Protobufs.Dota2.ProtoFlattenedSerializerField\_t.md).[Types](Divine.Protobufs.Dota2.ProtoFlattenedSerializerField\_t.Types.md).[polymorphic\_field\_t](Divine.Protobufs.Dota2.ProtoFlattenedSerializerField\_t.Types.polymorphic\_field\_t.md)

## Fields

### <a id="Divine_Protobufs_Dota2_ProtoFlattenedSerializerField_t_Types_polymorphic_field_t_PolymorphicFieldSerializerNameSymFieldNumber"></a> PolymorphicFieldSerializerNameSymFieldNumber

```csharp
public const int PolymorphicFieldSerializerNameSymFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_ProtoFlattenedSerializerField_t_Types_polymorphic_field_t_PolymorphicFieldSerializerVersionFieldNumber"></a> PolymorphicFieldSerializerVersionFieldNumber

```csharp
public const int PolymorphicFieldSerializerVersionFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_ProtoFlattenedSerializerField_t_Types_polymorphic_field_t_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_ProtoFlattenedSerializerField_t_Types_polymorphic_field_t_HasPolymorphicFieldSerializerNameSym"></a> HasPolymorphicFieldSerializerNameSym

```csharp
public bool HasPolymorphicFieldSerializerNameSym { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_ProtoFlattenedSerializerField_t_Types_polymorphic_field_t_HasPolymorphicFieldSerializerVersion"></a> HasPolymorphicFieldSerializerVersion

```csharp
public bool HasPolymorphicFieldSerializerVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_ProtoFlattenedSerializerField_t_Types_polymorphic_field_t_Parser"></a> Parser

```csharp
public static MessageParser<ProtoFlattenedSerializerField_t.Types.polymorphic_field_t> Parser { get; }
```

#### Property Value

 MessageParser<[ProtoFlattenedSerializerField\_t](Divine.Protobufs.Dota2.ProtoFlattenedSerializerField\_t.md).[Types](Divine.Protobufs.Dota2.ProtoFlattenedSerializerField\_t.Types.md).[polymorphic\_field\_t](Divine.Protobufs.Dota2.ProtoFlattenedSerializerField\_t.Types.polymorphic\_field\_t.md)\>

### <a id="Divine_Protobufs_Dota2_ProtoFlattenedSerializerField_t_Types_polymorphic_field_t_PolymorphicFieldSerializerNameSym"></a> PolymorphicFieldSerializerNameSym

```csharp
public int PolymorphicFieldSerializerNameSym { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_ProtoFlattenedSerializerField_t_Types_polymorphic_field_t_PolymorphicFieldSerializerVersion"></a> PolymorphicFieldSerializerVersion

```csharp
public int PolymorphicFieldSerializerVersion { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_ProtoFlattenedSerializerField_t_Types_polymorphic_field_t_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_ProtoFlattenedSerializerField_t_Types_polymorphic_field_t_ClearPolymorphicFieldSerializerNameSym"></a> ClearPolymorphicFieldSerializerNameSym\(\)

```csharp
public void ClearPolymorphicFieldSerializerNameSym()
```

### <a id="Divine_Protobufs_Dota2_ProtoFlattenedSerializerField_t_Types_polymorphic_field_t_ClearPolymorphicFieldSerializerVersion"></a> ClearPolymorphicFieldSerializerVersion\(\)

```csharp
public void ClearPolymorphicFieldSerializerVersion()
```

### <a id="Divine_Protobufs_Dota2_ProtoFlattenedSerializerField_t_Types_polymorphic_field_t_Clone"></a> Clone\(\)

```csharp
public ProtoFlattenedSerializerField_t.Types.polymorphic_field_t Clone()
```

#### Returns

 [ProtoFlattenedSerializerField\_t](Divine.Protobufs.Dota2.ProtoFlattenedSerializerField\_t.md).[Types](Divine.Protobufs.Dota2.ProtoFlattenedSerializerField\_t.Types.md).[polymorphic\_field\_t](Divine.Protobufs.Dota2.ProtoFlattenedSerializerField\_t.Types.polymorphic\_field\_t.md)

### <a id="Divine_Protobufs_Dota2_ProtoFlattenedSerializerField_t_Types_polymorphic_field_t_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_ProtoFlattenedSerializerField_t_Types_polymorphic_field_t_Equals_Divine_Protobufs_Dota2_ProtoFlattenedSerializerField_t_Types_polymorphic_field_t_"></a> Equals\(polymorphic\_field\_t\)

```csharp
public bool Equals(ProtoFlattenedSerializerField_t.Types.polymorphic_field_t other)
```

#### Parameters

`other` [ProtoFlattenedSerializerField\_t](Divine.Protobufs.Dota2.ProtoFlattenedSerializerField\_t.md).[Types](Divine.Protobufs.Dota2.ProtoFlattenedSerializerField\_t.Types.md).[polymorphic\_field\_t](Divine.Protobufs.Dota2.ProtoFlattenedSerializerField\_t.Types.polymorphic\_field\_t.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_ProtoFlattenedSerializerField_t_Types_polymorphic_field_t_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_ProtoFlattenedSerializerField_t_Types_polymorphic_field_t_MergeFrom_Divine_Protobufs_Dota2_ProtoFlattenedSerializerField_t_Types_polymorphic_field_t_"></a> MergeFrom\(polymorphic\_field\_t\)

```csharp
public void MergeFrom(ProtoFlattenedSerializerField_t.Types.polymorphic_field_t other)
```

#### Parameters

`other` [ProtoFlattenedSerializerField\_t](Divine.Protobufs.Dota2.ProtoFlattenedSerializerField\_t.md).[Types](Divine.Protobufs.Dota2.ProtoFlattenedSerializerField\_t.Types.md).[polymorphic\_field\_t](Divine.Protobufs.Dota2.ProtoFlattenedSerializerField\_t.Types.polymorphic\_field\_t.md)

### <a id="Divine_Protobufs_Dota2_ProtoFlattenedSerializerField_t_Types_polymorphic_field_t_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_ProtoFlattenedSerializerField_t_Types_polymorphic_field_t_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_ProtoFlattenedSerializerField_t_Types_polymorphic_field_t_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

