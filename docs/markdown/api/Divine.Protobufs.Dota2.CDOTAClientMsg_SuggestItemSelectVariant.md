# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemSelectVariant"></a> Class CDOTAClientMsg\_SuggestItemSelectVariant

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_SuggestItemSelectVariant : IMessage<CDOTAClientMsg_SuggestItemSelectVariant>, IEquatable<CDOTAClientMsg_SuggestItemSelectVariant>, IDeepCloneable<CDOTAClientMsg_SuggestItemSelectVariant>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_SuggestItemSelectVariant](Divine.Protobufs.Dota2.CDOTAClientMsg\_SuggestItemSelectVariant.md)

#### Implements

IMessage<CDOTAClientMsg\_SuggestItemSelectVariant\>, 
[IEquatable<CDOTAClientMsg\_SuggestItemSelectVariant\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_SuggestItemSelectVariant\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_SuggestItemSelectVariant\>\(CDOTAClientMsg\_SuggestItemSelectVariant, params CDOTAClientMsg\_SuggestItemSelectVariant\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemSelectVariant__ctor"></a> CDOTAClientMsg\_SuggestItemSelectVariant\(\)

```csharp
public CDOTAClientMsg_SuggestItemSelectVariant()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemSelectVariant__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemSelectVariant_"></a> CDOTAClientMsg\_SuggestItemSelectVariant\(CDOTAClientMsg\_SuggestItemSelectVariant\)

```csharp
public CDOTAClientMsg_SuggestItemSelectVariant(CDOTAClientMsg_SuggestItemSelectVariant other)
```

#### Parameters

`other` [CDOTAClientMsg\_SuggestItemSelectVariant](Divine.Protobufs.Dota2.CDOTAClientMsg\_SuggestItemSelectVariant.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemSelectVariant_VariantFieldNumber"></a> VariantFieldNumber

```csharp
public const int VariantFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemSelectVariant_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemSelectVariant_HasVariant"></a> HasVariant

```csharp
public bool HasVariant { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemSelectVariant_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_SuggestItemSelectVariant> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_SuggestItemSelectVariant](Divine.Protobufs.Dota2.CDOTAClientMsg\_SuggestItemSelectVariant.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemSelectVariant_Variant"></a> Variant

```csharp
public uint Variant { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemSelectVariant_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemSelectVariant_ClearVariant"></a> ClearVariant\(\)

```csharp
public void ClearVariant()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemSelectVariant_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_SuggestItemSelectVariant Clone()
```

#### Returns

 [CDOTAClientMsg\_SuggestItemSelectVariant](Divine.Protobufs.Dota2.CDOTAClientMsg\_SuggestItemSelectVariant.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemSelectVariant_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemSelectVariant_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemSelectVariant_"></a> Equals\(CDOTAClientMsg\_SuggestItemSelectVariant\)

```csharp
public bool Equals(CDOTAClientMsg_SuggestItemSelectVariant other)
```

#### Parameters

`other` [CDOTAClientMsg\_SuggestItemSelectVariant](Divine.Protobufs.Dota2.CDOTAClientMsg\_SuggestItemSelectVariant.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemSelectVariant_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemSelectVariant_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemSelectVariant_"></a> MergeFrom\(CDOTAClientMsg\_SuggestItemSelectVariant\)

```csharp
public void MergeFrom(CDOTAClientMsg_SuggestItemSelectVariant other)
```

#### Parameters

`other` [CDOTAClientMsg\_SuggestItemSelectVariant](Divine.Protobufs.Dota2.CDOTAClientMsg\_SuggestItemSelectVariant.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemSelectVariant_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemSelectVariant_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemSelectVariant_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

