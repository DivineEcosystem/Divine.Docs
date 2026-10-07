# <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemModifier"></a> Class CMsgItemBattlerItemModifier

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgItemBattlerItemModifier : IMessage<CMsgItemBattlerItemModifier>, IEquatable<CMsgItemBattlerItemModifier>, IDeepCloneable<CMsgItemBattlerItemModifier>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgItemBattlerItemModifier](Divine.Protobufs.Dota2.CMsgItemBattlerItemModifier.md)

#### Implements

IMessage<CMsgItemBattlerItemModifier\>, 
[IEquatable<CMsgItemBattlerItemModifier\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgItemBattlerItemModifier\>, 
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
[EnumerableExtensions.In<CMsgItemBattlerItemModifier\>\(CMsgItemBattlerItemModifier, params CMsgItemBattlerItemModifier\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemModifier__ctor"></a> CMsgItemBattlerItemModifier\(\)

```csharp
public CMsgItemBattlerItemModifier()
```

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemModifier__ctor_Divine_Protobufs_Dota2_CMsgItemBattlerItemModifier_"></a> CMsgItemBattlerItemModifier\(CMsgItemBattlerItemModifier\)

```csharp
public CMsgItemBattlerItemModifier(CMsgItemBattlerItemModifier other)
```

#### Parameters

`other` [CMsgItemBattlerItemModifier](Divine.Protobufs.Dota2.CMsgItemBattlerItemModifier.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemModifier_MultiplicativeFieldNumber"></a> MultiplicativeFieldNumber

```csharp
public const int MultiplicativeFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemModifier_TypeFieldNumber"></a> TypeFieldNumber

```csharp
public const int TypeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemModifier_ValueFieldNumber"></a> ValueFieldNumber

```csharp
public const int ValueFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemModifier_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemModifier_HasMultiplicative"></a> HasMultiplicative

```csharp
public bool HasMultiplicative { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemModifier_HasType"></a> HasType

```csharp
public bool HasType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemModifier_HasValue"></a> HasValue

```csharp
public bool HasValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemModifier_Multiplicative"></a> Multiplicative

```csharp
public bool Multiplicative { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemModifier_Parser"></a> Parser

```csharp
public static MessageParser<CMsgItemBattlerItemModifier> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgItemBattlerItemModifier](Divine.Protobufs.Dota2.CMsgItemBattlerItemModifier.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemModifier_Type"></a> Type

```csharp
public uint Type { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemModifier_Value"></a> Value

```csharp
public float Value { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemModifier_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemModifier_ClearMultiplicative"></a> ClearMultiplicative\(\)

```csharp
public void ClearMultiplicative()
```

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemModifier_ClearType"></a> ClearType\(\)

```csharp
public void ClearType()
```

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemModifier_ClearValue"></a> ClearValue\(\)

```csharp
public void ClearValue()
```

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemModifier_Clone"></a> Clone\(\)

```csharp
public CMsgItemBattlerItemModifier Clone()
```

#### Returns

 [CMsgItemBattlerItemModifier](Divine.Protobufs.Dota2.CMsgItemBattlerItemModifier.md)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemModifier_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemModifier_Equals_Divine_Protobufs_Dota2_CMsgItemBattlerItemModifier_"></a> Equals\(CMsgItemBattlerItemModifier\)

```csharp
public bool Equals(CMsgItemBattlerItemModifier other)
```

#### Parameters

`other` [CMsgItemBattlerItemModifier](Divine.Protobufs.Dota2.CMsgItemBattlerItemModifier.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemModifier_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemModifier_MergeFrom_Divine_Protobufs_Dota2_CMsgItemBattlerItemModifier_"></a> MergeFrom\(CMsgItemBattlerItemModifier\)

```csharp
public void MergeFrom(CMsgItemBattlerItemModifier other)
```

#### Parameters

`other` [CMsgItemBattlerItemModifier](Divine.Protobufs.Dota2.CMsgItemBattlerItemModifier.md)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemModifier_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemModifier_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgItemBattlerItemModifier_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

