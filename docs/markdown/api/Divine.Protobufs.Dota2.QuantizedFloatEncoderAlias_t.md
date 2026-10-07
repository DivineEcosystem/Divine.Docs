# <a id="Divine_Protobufs_Dota2_QuantizedFloatEncoderAlias_t"></a> Class QuantizedFloatEncoderAlias\_t

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class QuantizedFloatEncoderAlias_t : IMessage<QuantizedFloatEncoderAlias_t>, IEquatable<QuantizedFloatEncoderAlias_t>, IDeepCloneable<QuantizedFloatEncoderAlias_t>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[QuantizedFloatEncoderAlias\_t](Divine.Protobufs.Dota2.QuantizedFloatEncoderAlias\_t.md)

#### Implements

IMessage<QuantizedFloatEncoderAlias\_t\>, 
[IEquatable<QuantizedFloatEncoderAlias\_t\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<QuantizedFloatEncoderAlias\_t\>, 
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
[EnumerableExtensions.In<QuantizedFloatEncoderAlias\_t\>\(QuantizedFloatEncoderAlias\_t, params QuantizedFloatEncoderAlias\_t\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_QuantizedFloatEncoderAlias_t__ctor"></a> QuantizedFloatEncoderAlias\_t\(\)

```csharp
public QuantizedFloatEncoderAlias_t()
```

### <a id="Divine_Protobufs_Dota2_QuantizedFloatEncoderAlias_t__ctor_Divine_Protobufs_Dota2_QuantizedFloatEncoderAlias_t_"></a> QuantizedFloatEncoderAlias\_t\(QuantizedFloatEncoderAlias\_t\)

```csharp
public QuantizedFloatEncoderAlias_t(QuantizedFloatEncoderAlias_t other)
```

#### Parameters

`other` [QuantizedFloatEncoderAlias\_t](Divine.Protobufs.Dota2.QuantizedFloatEncoderAlias\_t.md)

## Fields

### <a id="Divine_Protobufs_Dota2_QuantizedFloatEncoderAlias_t_BitCountFieldNumber"></a> BitCountFieldNumber

```csharp
public const int BitCountFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_QuantizedFloatEncoderAlias_t_EncodeFlagsFieldNumber"></a> EncodeFlagsFieldNumber

```csharp
public const int EncodeFlagsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_QuantizedFloatEncoderAlias_t_MaxValueFieldNumber"></a> MaxValueFieldNumber

```csharp
public const int MaxValueFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_QuantizedFloatEncoderAlias_t_MinValueFieldNumber"></a> MinValueFieldNumber

```csharp
public const int MinValueFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_QuantizedFloatEncoderAlias_t_NameFieldNumber"></a> NameFieldNumber

```csharp
public const int NameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_QuantizedFloatEncoderAlias_t_ValidateFieldNumber"></a> ValidateFieldNumber

```csharp
public const int ValidateFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_QuantizedFloatEncoderAlias_t_BitCount"></a> BitCount

```csharp
public int BitCount { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_QuantizedFloatEncoderAlias_t_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_QuantizedFloatEncoderAlias_t_EncodeFlags"></a> EncodeFlags

```csharp
public int EncodeFlags { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_QuantizedFloatEncoderAlias_t_HasBitCount"></a> HasBitCount

```csharp
public bool HasBitCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_QuantizedFloatEncoderAlias_t_HasEncodeFlags"></a> HasEncodeFlags

```csharp
public bool HasEncodeFlags { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_QuantizedFloatEncoderAlias_t_HasMaxValue"></a> HasMaxValue

```csharp
public bool HasMaxValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_QuantizedFloatEncoderAlias_t_HasMinValue"></a> HasMinValue

```csharp
public bool HasMinValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_QuantizedFloatEncoderAlias_t_HasName"></a> HasName

```csharp
public bool HasName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_QuantizedFloatEncoderAlias_t_HasValidate"></a> HasValidate

```csharp
public bool HasValidate { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_QuantizedFloatEncoderAlias_t_MaxValue"></a> MaxValue

```csharp
public float MaxValue { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_QuantizedFloatEncoderAlias_t_MinValue"></a> MinValue

```csharp
public float MinValue { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_QuantizedFloatEncoderAlias_t_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_QuantizedFloatEncoderAlias_t_Parser"></a> Parser

```csharp
public static MessageParser<QuantizedFloatEncoderAlias_t> Parser { get; }
```

#### Property Value

 MessageParser<[QuantizedFloatEncoderAlias\_t](Divine.Protobufs.Dota2.QuantizedFloatEncoderAlias\_t.md)\>

### <a id="Divine_Protobufs_Dota2_QuantizedFloatEncoderAlias_t_Validate"></a> Validate

```csharp
public bool Validate { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_QuantizedFloatEncoderAlias_t_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_QuantizedFloatEncoderAlias_t_ClearBitCount"></a> ClearBitCount\(\)

```csharp
public void ClearBitCount()
```

### <a id="Divine_Protobufs_Dota2_QuantizedFloatEncoderAlias_t_ClearEncodeFlags"></a> ClearEncodeFlags\(\)

```csharp
public void ClearEncodeFlags()
```

### <a id="Divine_Protobufs_Dota2_QuantizedFloatEncoderAlias_t_ClearMaxValue"></a> ClearMaxValue\(\)

```csharp
public void ClearMaxValue()
```

### <a id="Divine_Protobufs_Dota2_QuantizedFloatEncoderAlias_t_ClearMinValue"></a> ClearMinValue\(\)

```csharp
public void ClearMinValue()
```

### <a id="Divine_Protobufs_Dota2_QuantizedFloatEncoderAlias_t_ClearName"></a> ClearName\(\)

```csharp
public void ClearName()
```

### <a id="Divine_Protobufs_Dota2_QuantizedFloatEncoderAlias_t_ClearValidate"></a> ClearValidate\(\)

```csharp
public void ClearValidate()
```

### <a id="Divine_Protobufs_Dota2_QuantizedFloatEncoderAlias_t_Clone"></a> Clone\(\)

```csharp
public QuantizedFloatEncoderAlias_t Clone()
```

#### Returns

 [QuantizedFloatEncoderAlias\_t](Divine.Protobufs.Dota2.QuantizedFloatEncoderAlias\_t.md)

### <a id="Divine_Protobufs_Dota2_QuantizedFloatEncoderAlias_t_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_QuantizedFloatEncoderAlias_t_Equals_Divine_Protobufs_Dota2_QuantizedFloatEncoderAlias_t_"></a> Equals\(QuantizedFloatEncoderAlias\_t\)

```csharp
public bool Equals(QuantizedFloatEncoderAlias_t other)
```

#### Parameters

`other` [QuantizedFloatEncoderAlias\_t](Divine.Protobufs.Dota2.QuantizedFloatEncoderAlias\_t.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_QuantizedFloatEncoderAlias_t_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_QuantizedFloatEncoderAlias_t_MergeFrom_Divine_Protobufs_Dota2_QuantizedFloatEncoderAlias_t_"></a> MergeFrom\(QuantizedFloatEncoderAlias\_t\)

```csharp
public void MergeFrom(QuantizedFloatEncoderAlias_t other)
```

#### Parameters

`other` [QuantizedFloatEncoderAlias\_t](Divine.Protobufs.Dota2.QuantizedFloatEncoderAlias\_t.md)

### <a id="Divine_Protobufs_Dota2_QuantizedFloatEncoderAlias_t_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_QuantizedFloatEncoderAlias_t_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_QuantizedFloatEncoderAlias_t_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

