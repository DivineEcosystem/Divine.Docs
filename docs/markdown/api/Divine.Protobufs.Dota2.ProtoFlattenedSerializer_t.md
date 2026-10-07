# <a id="Divine_Protobufs_Dota2_ProtoFlattenedSerializer_t"></a> Class ProtoFlattenedSerializer\_t

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class ProtoFlattenedSerializer_t : IMessage<ProtoFlattenedSerializer_t>, IEquatable<ProtoFlattenedSerializer_t>, IDeepCloneable<ProtoFlattenedSerializer_t>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ProtoFlattenedSerializer\_t](Divine.Protobufs.Dota2.ProtoFlattenedSerializer\_t.md)

#### Implements

IMessage<ProtoFlattenedSerializer\_t\>, 
[IEquatable<ProtoFlattenedSerializer\_t\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<ProtoFlattenedSerializer\_t\>, 
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
[EnumerableExtensions.In<ProtoFlattenedSerializer\_t\>\(ProtoFlattenedSerializer\_t, params ProtoFlattenedSerializer\_t\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_ProtoFlattenedSerializer_t__ctor"></a> ProtoFlattenedSerializer\_t\(\)

```csharp
public ProtoFlattenedSerializer_t()
```

### <a id="Divine_Protobufs_Dota2_ProtoFlattenedSerializer_t__ctor_Divine_Protobufs_Dota2_ProtoFlattenedSerializer_t_"></a> ProtoFlattenedSerializer\_t\(ProtoFlattenedSerializer\_t\)

```csharp
public ProtoFlattenedSerializer_t(ProtoFlattenedSerializer_t other)
```

#### Parameters

`other` [ProtoFlattenedSerializer\_t](Divine.Protobufs.Dota2.ProtoFlattenedSerializer\_t.md)

## Fields

### <a id="Divine_Protobufs_Dota2_ProtoFlattenedSerializer_t_FieldsIndexFieldNumber"></a> FieldsIndexFieldNumber

```csharp
public const int FieldsIndexFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_ProtoFlattenedSerializer_t_SerializerNameSymFieldNumber"></a> SerializerNameSymFieldNumber

```csharp
public const int SerializerNameSymFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_ProtoFlattenedSerializer_t_SerializerVersionFieldNumber"></a> SerializerVersionFieldNumber

```csharp
public const int SerializerVersionFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_ProtoFlattenedSerializer_t_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_ProtoFlattenedSerializer_t_FieldsIndex"></a> FieldsIndex

```csharp
public RepeatedField<int> FieldsIndex { get; }
```

#### Property Value

 RepeatedField<[int](https://learn.microsoft.com/dotnet/api/system.int32)\>

### <a id="Divine_Protobufs_Dota2_ProtoFlattenedSerializer_t_HasSerializerNameSym"></a> HasSerializerNameSym

```csharp
public bool HasSerializerNameSym { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_ProtoFlattenedSerializer_t_HasSerializerVersion"></a> HasSerializerVersion

```csharp
public bool HasSerializerVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_ProtoFlattenedSerializer_t_Parser"></a> Parser

```csharp
public static MessageParser<ProtoFlattenedSerializer_t> Parser { get; }
```

#### Property Value

 MessageParser<[ProtoFlattenedSerializer\_t](Divine.Protobufs.Dota2.ProtoFlattenedSerializer\_t.md)\>

### <a id="Divine_Protobufs_Dota2_ProtoFlattenedSerializer_t_SerializerNameSym"></a> SerializerNameSym

```csharp
public int SerializerNameSym { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_ProtoFlattenedSerializer_t_SerializerVersion"></a> SerializerVersion

```csharp
public int SerializerVersion { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_ProtoFlattenedSerializer_t_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_ProtoFlattenedSerializer_t_ClearSerializerNameSym"></a> ClearSerializerNameSym\(\)

```csharp
public void ClearSerializerNameSym()
```

### <a id="Divine_Protobufs_Dota2_ProtoFlattenedSerializer_t_ClearSerializerVersion"></a> ClearSerializerVersion\(\)

```csharp
public void ClearSerializerVersion()
```

### <a id="Divine_Protobufs_Dota2_ProtoFlattenedSerializer_t_Clone"></a> Clone\(\)

```csharp
public ProtoFlattenedSerializer_t Clone()
```

#### Returns

 [ProtoFlattenedSerializer\_t](Divine.Protobufs.Dota2.ProtoFlattenedSerializer\_t.md)

### <a id="Divine_Protobufs_Dota2_ProtoFlattenedSerializer_t_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_ProtoFlattenedSerializer_t_Equals_Divine_Protobufs_Dota2_ProtoFlattenedSerializer_t_"></a> Equals\(ProtoFlattenedSerializer\_t\)

```csharp
public bool Equals(ProtoFlattenedSerializer_t other)
```

#### Parameters

`other` [ProtoFlattenedSerializer\_t](Divine.Protobufs.Dota2.ProtoFlattenedSerializer\_t.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_ProtoFlattenedSerializer_t_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_ProtoFlattenedSerializer_t_MergeFrom_Divine_Protobufs_Dota2_ProtoFlattenedSerializer_t_"></a> MergeFrom\(ProtoFlattenedSerializer\_t\)

```csharp
public void MergeFrom(ProtoFlattenedSerializer_t other)
```

#### Parameters

`other` [ProtoFlattenedSerializer\_t](Divine.Protobufs.Dota2.ProtoFlattenedSerializer\_t.md)

### <a id="Divine_Protobufs_Dota2_ProtoFlattenedSerializer_t_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_ProtoFlattenedSerializer_t_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_ProtoFlattenedSerializer_t_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

