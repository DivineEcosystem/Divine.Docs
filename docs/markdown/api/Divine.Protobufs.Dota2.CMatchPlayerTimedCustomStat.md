# <a id="Divine_Protobufs_Dota2_CMatchPlayerTimedCustomStat"></a> Class CMatchPlayerTimedCustomStat

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMatchPlayerTimedCustomStat : IMessage<CMatchPlayerTimedCustomStat>, IEquatable<CMatchPlayerTimedCustomStat>, IDeepCloneable<CMatchPlayerTimedCustomStat>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMatchPlayerTimedCustomStat](Divine.Protobufs.Dota2.CMatchPlayerTimedCustomStat.md)

#### Implements

IMessage<CMatchPlayerTimedCustomStat\>, 
[IEquatable<CMatchPlayerTimedCustomStat\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMatchPlayerTimedCustomStat\>, 
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
[EnumerableExtensions.In<CMatchPlayerTimedCustomStat\>\(CMatchPlayerTimedCustomStat, params CMatchPlayerTimedCustomStat\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMatchPlayerTimedCustomStat__ctor"></a> CMatchPlayerTimedCustomStat\(\)

```csharp
public CMatchPlayerTimedCustomStat()
```

### <a id="Divine_Protobufs_Dota2_CMatchPlayerTimedCustomStat__ctor_Divine_Protobufs_Dota2_CMatchPlayerTimedCustomStat_"></a> CMatchPlayerTimedCustomStat\(CMatchPlayerTimedCustomStat\)

```csharp
public CMatchPlayerTimedCustomStat(CMatchPlayerTimedCustomStat other)
```

#### Parameters

`other` [CMatchPlayerTimedCustomStat](Divine.Protobufs.Dota2.CMatchPlayerTimedCustomStat.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMatchPlayerTimedCustomStat_StatFieldNumber"></a> StatFieldNumber

```csharp
public const int StatFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMatchPlayerTimedCustomStat_ValueFieldNumber"></a> ValueFieldNumber

```csharp
public const int ValueFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMatchPlayerTimedCustomStat_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMatchPlayerTimedCustomStat_HasStat"></a> HasStat

```csharp
public bool HasStat { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMatchPlayerTimedCustomStat_HasValue"></a> HasValue

```csharp
public bool HasValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMatchPlayerTimedCustomStat_Parser"></a> Parser

```csharp
public static MessageParser<CMatchPlayerTimedCustomStat> Parser { get; }
```

#### Property Value

 MessageParser<[CMatchPlayerTimedCustomStat](Divine.Protobufs.Dota2.CMatchPlayerTimedCustomStat.md)\>

### <a id="Divine_Protobufs_Dota2_CMatchPlayerTimedCustomStat_Stat"></a> Stat

```csharp
public EDOTAMatchPlayerTimeCustomStat Stat { get; set; }
```

#### Property Value

 [EDOTAMatchPlayerTimeCustomStat](Divine.Protobufs.Dota2.EDOTAMatchPlayerTimeCustomStat.md)

### <a id="Divine_Protobufs_Dota2_CMatchPlayerTimedCustomStat_Value"></a> Value

```csharp
public float Value { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Protobufs_Dota2_CMatchPlayerTimedCustomStat_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMatchPlayerTimedCustomStat_ClearStat"></a> ClearStat\(\)

```csharp
public void ClearStat()
```

### <a id="Divine_Protobufs_Dota2_CMatchPlayerTimedCustomStat_ClearValue"></a> ClearValue\(\)

```csharp
public void ClearValue()
```

### <a id="Divine_Protobufs_Dota2_CMatchPlayerTimedCustomStat_Clone"></a> Clone\(\)

```csharp
public CMatchPlayerTimedCustomStat Clone()
```

#### Returns

 [CMatchPlayerTimedCustomStat](Divine.Protobufs.Dota2.CMatchPlayerTimedCustomStat.md)

### <a id="Divine_Protobufs_Dota2_CMatchPlayerTimedCustomStat_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMatchPlayerTimedCustomStat_Equals_Divine_Protobufs_Dota2_CMatchPlayerTimedCustomStat_"></a> Equals\(CMatchPlayerTimedCustomStat\)

```csharp
public bool Equals(CMatchPlayerTimedCustomStat other)
```

#### Parameters

`other` [CMatchPlayerTimedCustomStat](Divine.Protobufs.Dota2.CMatchPlayerTimedCustomStat.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMatchPlayerTimedCustomStat_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMatchPlayerTimedCustomStat_MergeFrom_Divine_Protobufs_Dota2_CMatchPlayerTimedCustomStat_"></a> MergeFrom\(CMatchPlayerTimedCustomStat\)

```csharp
public void MergeFrom(CMatchPlayerTimedCustomStat other)
```

#### Parameters

`other` [CMatchPlayerTimedCustomStat](Divine.Protobufs.Dota2.CMatchPlayerTimedCustomStat.md)

### <a id="Divine_Protobufs_Dota2_CMatchPlayerTimedCustomStat_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMatchPlayerTimedCustomStat_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMatchPlayerTimedCustomStat_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

