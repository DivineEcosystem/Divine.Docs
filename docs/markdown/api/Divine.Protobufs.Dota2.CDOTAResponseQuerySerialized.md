# <a id="Divine_Protobufs_Dota2_CDOTAResponseQuerySerialized"></a> Class CDOTAResponseQuerySerialized

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAResponseQuerySerialized : IMessage<CDOTAResponseQuerySerialized>, IEquatable<CDOTAResponseQuerySerialized>, IDeepCloneable<CDOTAResponseQuerySerialized>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAResponseQuerySerialized](Divine.Protobufs.Dota2.CDOTAResponseQuerySerialized.md)

#### Implements

IMessage<CDOTAResponseQuerySerialized\>, 
[IEquatable<CDOTAResponseQuerySerialized\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAResponseQuerySerialized\>, 
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
[EnumerableExtensions.In<CDOTAResponseQuerySerialized\>\(CDOTAResponseQuerySerialized, params CDOTAResponseQuerySerialized\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAResponseQuerySerialized__ctor"></a> CDOTAResponseQuerySerialized\(\)

```csharp
public CDOTAResponseQuerySerialized()
```

### <a id="Divine_Protobufs_Dota2_CDOTAResponseQuerySerialized__ctor_Divine_Protobufs_Dota2_CDOTAResponseQuerySerialized_"></a> CDOTAResponseQuerySerialized\(CDOTAResponseQuerySerialized\)

```csharp
public CDOTAResponseQuerySerialized(CDOTAResponseQuerySerialized other)
```

#### Parameters

`other` [CDOTAResponseQuerySerialized](Divine.Protobufs.Dota2.CDOTAResponseQuerySerialized.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAResponseQuerySerialized_FactsFieldNumber"></a> FactsFieldNumber

```csharp
public const int FactsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAResponseQuerySerialized_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAResponseQuerySerialized_Facts"></a> Facts

```csharp
public RepeatedField<CDOTAResponseQuerySerialized.Types.Fact> Facts { get; }
```

#### Property Value

 RepeatedField<[CDOTAResponseQuerySerialized](Divine.Protobufs.Dota2.CDOTAResponseQuerySerialized.md).[Types](Divine.Protobufs.Dota2.CDOTAResponseQuerySerialized.Types.md).[Fact](Divine.Protobufs.Dota2.CDOTAResponseQuerySerialized.Types.Fact.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAResponseQuerySerialized_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAResponseQuerySerialized> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAResponseQuerySerialized](Divine.Protobufs.Dota2.CDOTAResponseQuerySerialized.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAResponseQuerySerialized_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAResponseQuerySerialized_Clone"></a> Clone\(\)

```csharp
public CDOTAResponseQuerySerialized Clone()
```

#### Returns

 [CDOTAResponseQuerySerialized](Divine.Protobufs.Dota2.CDOTAResponseQuerySerialized.md)

### <a id="Divine_Protobufs_Dota2_CDOTAResponseQuerySerialized_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAResponseQuerySerialized_Equals_Divine_Protobufs_Dota2_CDOTAResponseQuerySerialized_"></a> Equals\(CDOTAResponseQuerySerialized\)

```csharp
public bool Equals(CDOTAResponseQuerySerialized other)
```

#### Parameters

`other` [CDOTAResponseQuerySerialized](Divine.Protobufs.Dota2.CDOTAResponseQuerySerialized.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAResponseQuerySerialized_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAResponseQuerySerialized_MergeFrom_Divine_Protobufs_Dota2_CDOTAResponseQuerySerialized_"></a> MergeFrom\(CDOTAResponseQuerySerialized\)

```csharp
public void MergeFrom(CDOTAResponseQuerySerialized other)
```

#### Parameters

`other` [CDOTAResponseQuerySerialized](Divine.Protobufs.Dota2.CDOTAResponseQuerySerialized.md)

### <a id="Divine_Protobufs_Dota2_CDOTAResponseQuerySerialized_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAResponseQuerySerialized_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAResponseQuerySerialized_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

