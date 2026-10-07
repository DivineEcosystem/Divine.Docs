# <a id="Divine_Protobufs_Dota2_CMsgPlayerCard_Types_StatModifier"></a> Class CMsgPlayerCard.Types.StatModifier

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgPlayerCard.Types.StatModifier : IMessage<CMsgPlayerCard.Types.StatModifier>, IEquatable<CMsgPlayerCard.Types.StatModifier>, IDeepCloneable<CMsgPlayerCard.Types.StatModifier>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgPlayerCard.Types.StatModifier](Divine.Protobufs.Dota2.CMsgPlayerCard.Types.StatModifier.md)

#### Implements

IMessage<CMsgPlayerCard.Types.StatModifier\>, 
[IEquatable<CMsgPlayerCard.Types.StatModifier\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgPlayerCard.Types.StatModifier\>, 
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
[EnumerableExtensions.In<CMsgPlayerCard.Types.StatModifier\>\(CMsgPlayerCard.Types.StatModifier, params CMsgPlayerCard.Types.StatModifier\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgPlayerCard_Types_StatModifier__ctor"></a> StatModifier\(\)

```csharp
public StatModifier()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlayerCard_Types_StatModifier__ctor_Divine_Protobufs_Dota2_CMsgPlayerCard_Types_StatModifier_"></a> StatModifier\(StatModifier\)

```csharp
public StatModifier(CMsgPlayerCard.Types.StatModifier other)
```

#### Parameters

`other` [CMsgPlayerCard](Divine.Protobufs.Dota2.CMsgPlayerCard.md).[Types](Divine.Protobufs.Dota2.CMsgPlayerCard.Types.md).[StatModifier](Divine.Protobufs.Dota2.CMsgPlayerCard.Types.StatModifier.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgPlayerCard_Types_StatModifier_StatFieldNumber"></a> StatFieldNumber

```csharp
public const int StatFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerCard_Types_StatModifier_ValueFieldNumber"></a> ValueFieldNumber

```csharp
public const int ValueFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgPlayerCard_Types_StatModifier_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgPlayerCard_Types_StatModifier_HasStat"></a> HasStat

```csharp
public bool HasStat { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerCard_Types_StatModifier_HasValue"></a> HasValue

```csharp
public bool HasValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerCard_Types_StatModifier_Parser"></a> Parser

```csharp
public static MessageParser<CMsgPlayerCard.Types.StatModifier> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgPlayerCard](Divine.Protobufs.Dota2.CMsgPlayerCard.md).[Types](Divine.Protobufs.Dota2.CMsgPlayerCard.Types.md).[StatModifier](Divine.Protobufs.Dota2.CMsgPlayerCard.Types.StatModifier.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgPlayerCard_Types_StatModifier_Stat"></a> Stat

```csharp
public uint Stat { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerCard_Types_StatModifier_Value"></a> Value

```csharp
public uint Value { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgPlayerCard_Types_StatModifier_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerCard_Types_StatModifier_ClearStat"></a> ClearStat\(\)

```csharp
public void ClearStat()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlayerCard_Types_StatModifier_ClearValue"></a> ClearValue\(\)

```csharp
public void ClearValue()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlayerCard_Types_StatModifier_Clone"></a> Clone\(\)

```csharp
public CMsgPlayerCard.Types.StatModifier Clone()
```

#### Returns

 [CMsgPlayerCard](Divine.Protobufs.Dota2.CMsgPlayerCard.md).[Types](Divine.Protobufs.Dota2.CMsgPlayerCard.Types.md).[StatModifier](Divine.Protobufs.Dota2.CMsgPlayerCard.Types.StatModifier.md)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerCard_Types_StatModifier_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerCard_Types_StatModifier_Equals_Divine_Protobufs_Dota2_CMsgPlayerCard_Types_StatModifier_"></a> Equals\(StatModifier\)

```csharp
public bool Equals(CMsgPlayerCard.Types.StatModifier other)
```

#### Parameters

`other` [CMsgPlayerCard](Divine.Protobufs.Dota2.CMsgPlayerCard.md).[Types](Divine.Protobufs.Dota2.CMsgPlayerCard.Types.md).[StatModifier](Divine.Protobufs.Dota2.CMsgPlayerCard.Types.StatModifier.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerCard_Types_StatModifier_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerCard_Types_StatModifier_MergeFrom_Divine_Protobufs_Dota2_CMsgPlayerCard_Types_StatModifier_"></a> MergeFrom\(StatModifier\)

```csharp
public void MergeFrom(CMsgPlayerCard.Types.StatModifier other)
```

#### Parameters

`other` [CMsgPlayerCard](Divine.Protobufs.Dota2.CMsgPlayerCard.md).[Types](Divine.Protobufs.Dota2.CMsgPlayerCard.Types.md).[StatModifier](Divine.Protobufs.Dota2.CMsgPlayerCard.Types.StatModifier.md)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerCard_Types_StatModifier_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgPlayerCard_Types_StatModifier_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerCard_Types_StatModifier_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

