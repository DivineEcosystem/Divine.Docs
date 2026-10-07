# <a id="Divine_Protobufs_Dota2_CAttribute_String"></a> Class CAttribute\_String

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CAttribute_String : IMessage<CAttribute_String>, IEquatable<CAttribute_String>, IDeepCloneable<CAttribute_String>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CAttribute\_String](Divine.Protobufs.Dota2.CAttribute\_String.md)

#### Implements

IMessage<CAttribute\_String\>, 
[IEquatable<CAttribute\_String\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CAttribute\_String\>, 
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
[EnumerableExtensions.In<CAttribute\_String\>\(CAttribute\_String, params CAttribute\_String\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CAttribute_String__ctor"></a> CAttribute\_String\(\)

```csharp
public CAttribute_String()
```

### <a id="Divine_Protobufs_Dota2_CAttribute_String__ctor_Divine_Protobufs_Dota2_CAttribute_String_"></a> CAttribute\_String\(CAttribute\_String\)

```csharp
public CAttribute_String(CAttribute_String other)
```

#### Parameters

`other` [CAttribute\_String](Divine.Protobufs.Dota2.CAttribute\_String.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CAttribute_String_ValueFieldNumber"></a> ValueFieldNumber

```csharp
public const int ValueFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CAttribute_String_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CAttribute_String_HasValue"></a> HasValue

```csharp
public bool HasValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CAttribute_String_Parser"></a> Parser

```csharp
public static MessageParser<CAttribute_String> Parser { get; }
```

#### Property Value

 MessageParser<[CAttribute\_String](Divine.Protobufs.Dota2.CAttribute\_String.md)\>

### <a id="Divine_Protobufs_Dota2_CAttribute_String_Value"></a> Value

```csharp
public string Value { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Dota2_CAttribute_String_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CAttribute_String_ClearValue"></a> ClearValue\(\)

```csharp
public void ClearValue()
```

### <a id="Divine_Protobufs_Dota2_CAttribute_String_Clone"></a> Clone\(\)

```csharp
public CAttribute_String Clone()
```

#### Returns

 [CAttribute\_String](Divine.Protobufs.Dota2.CAttribute\_String.md)

### <a id="Divine_Protobufs_Dota2_CAttribute_String_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CAttribute_String_Equals_Divine_Protobufs_Dota2_CAttribute_String_"></a> Equals\(CAttribute\_String\)

```csharp
public bool Equals(CAttribute_String other)
```

#### Parameters

`other` [CAttribute\_String](Divine.Protobufs.Dota2.CAttribute\_String.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CAttribute_String_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CAttribute_String_MergeFrom_Divine_Protobufs_Dota2_CAttribute_String_"></a> MergeFrom\(CAttribute\_String\)

```csharp
public void MergeFrom(CAttribute_String other)
```

#### Parameters

`other` [CAttribute\_String](Divine.Protobufs.Dota2.CAttribute\_String.md)

### <a id="Divine_Protobufs_Dota2_CAttribute_String_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CAttribute_String_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CAttribute_String_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

