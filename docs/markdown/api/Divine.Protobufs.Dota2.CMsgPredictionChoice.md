# <a id="Divine_Protobufs_Dota2_CMsgPredictionChoice"></a> Class CMsgPredictionChoice

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgPredictionChoice : IMessage<CMsgPredictionChoice>, IEquatable<CMsgPredictionChoice>, IDeepCloneable<CMsgPredictionChoice>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgPredictionChoice](Divine.Protobufs.Dota2.CMsgPredictionChoice.md)

#### Implements

IMessage<CMsgPredictionChoice\>, 
[IEquatable<CMsgPredictionChoice\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgPredictionChoice\>, 
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
[EnumerableExtensions.In<CMsgPredictionChoice\>\(CMsgPredictionChoice, params CMsgPredictionChoice\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgPredictionChoice__ctor"></a> CMsgPredictionChoice\(\)

```csharp
public CMsgPredictionChoice()
```

### <a id="Divine_Protobufs_Dota2_CMsgPredictionChoice__ctor_Divine_Protobufs_Dota2_CMsgPredictionChoice_"></a> CMsgPredictionChoice\(CMsgPredictionChoice\)

```csharp
public CMsgPredictionChoice(CMsgPredictionChoice other)
```

#### Parameters

`other` [CMsgPredictionChoice](Divine.Protobufs.Dota2.CMsgPredictionChoice.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgPredictionChoice_MaxRawValueFieldNumber"></a> MaxRawValueFieldNumber

```csharp
public const int MaxRawValueFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionChoice_MinRawValueFieldNumber"></a> MinRawValueFieldNumber

```csharp
public const int MinRawValueFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionChoice_NameFieldNumber"></a> NameFieldNumber

```csharp
public const int NameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionChoice_ValueFieldNumber"></a> ValueFieldNumber

```csharp
public const int ValueFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgPredictionChoice_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgPredictionChoice_HasMaxRawValue"></a> HasMaxRawValue

```csharp
public bool HasMaxRawValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionChoice_HasMinRawValue"></a> HasMinRawValue

```csharp
public bool HasMinRawValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionChoice_HasName"></a> HasName

```csharp
public bool HasName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionChoice_HasValue"></a> HasValue

```csharp
public bool HasValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionChoice_MaxRawValue"></a> MaxRawValue

```csharp
public uint MaxRawValue { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionChoice_MinRawValue"></a> MinRawValue

```csharp
public uint MinRawValue { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionChoice_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionChoice_Parser"></a> Parser

```csharp
public static MessageParser<CMsgPredictionChoice> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgPredictionChoice](Divine.Protobufs.Dota2.CMsgPredictionChoice.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgPredictionChoice_Value"></a> Value

```csharp
public uint Value { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgPredictionChoice_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionChoice_ClearMaxRawValue"></a> ClearMaxRawValue\(\)

```csharp
public void ClearMaxRawValue()
```

### <a id="Divine_Protobufs_Dota2_CMsgPredictionChoice_ClearMinRawValue"></a> ClearMinRawValue\(\)

```csharp
public void ClearMinRawValue()
```

### <a id="Divine_Protobufs_Dota2_CMsgPredictionChoice_ClearName"></a> ClearName\(\)

```csharp
public void ClearName()
```

### <a id="Divine_Protobufs_Dota2_CMsgPredictionChoice_ClearValue"></a> ClearValue\(\)

```csharp
public void ClearValue()
```

### <a id="Divine_Protobufs_Dota2_CMsgPredictionChoice_Clone"></a> Clone\(\)

```csharp
public CMsgPredictionChoice Clone()
```

#### Returns

 [CMsgPredictionChoice](Divine.Protobufs.Dota2.CMsgPredictionChoice.md)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionChoice_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionChoice_Equals_Divine_Protobufs_Dota2_CMsgPredictionChoice_"></a> Equals\(CMsgPredictionChoice\)

```csharp
public bool Equals(CMsgPredictionChoice other)
```

#### Parameters

`other` [CMsgPredictionChoice](Divine.Protobufs.Dota2.CMsgPredictionChoice.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionChoice_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionChoice_MergeFrom_Divine_Protobufs_Dota2_CMsgPredictionChoice_"></a> MergeFrom\(CMsgPredictionChoice\)

```csharp
public void MergeFrom(CMsgPredictionChoice other)
```

#### Parameters

`other` [CMsgPredictionChoice](Divine.Protobufs.Dota2.CMsgPredictionChoice.md)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionChoice_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgPredictionChoice_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgPredictionChoice_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

