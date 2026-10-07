# <a id="Divine_Protobufs_Dota2_CMsgHeroAbilityStat"></a> Class CMsgHeroAbilityStat

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgHeroAbilityStat : IMessage<CMsgHeroAbilityStat>, IEquatable<CMsgHeroAbilityStat>, IDeepCloneable<CMsgHeroAbilityStat>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgHeroAbilityStat](Divine.Protobufs.Dota2.CMsgHeroAbilityStat.md)

#### Implements

IMessage<CMsgHeroAbilityStat\>, 
[IEquatable<CMsgHeroAbilityStat\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgHeroAbilityStat\>, 
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
[EnumerableExtensions.In<CMsgHeroAbilityStat\>\(CMsgHeroAbilityStat, params CMsgHeroAbilityStat\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgHeroAbilityStat__ctor"></a> CMsgHeroAbilityStat\(\)

```csharp
public CMsgHeroAbilityStat()
```

### <a id="Divine_Protobufs_Dota2_CMsgHeroAbilityStat__ctor_Divine_Protobufs_Dota2_CMsgHeroAbilityStat_"></a> CMsgHeroAbilityStat\(CMsgHeroAbilityStat\)

```csharp
public CMsgHeroAbilityStat(CMsgHeroAbilityStat other)
```

#### Parameters

`other` [CMsgHeroAbilityStat](Divine.Protobufs.Dota2.CMsgHeroAbilityStat.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgHeroAbilityStat_FloatValueFieldNumber"></a> FloatValueFieldNumber

```csharp
public const int FloatValueFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgHeroAbilityStat_IntValueFieldNumber"></a> IntValueFieldNumber

```csharp
public const int IntValueFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgHeroAbilityStat_StatTypeFieldNumber"></a> StatTypeFieldNumber

```csharp
public const int StatTypeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgHeroAbilityStat_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgHeroAbilityStat_FloatValue"></a> FloatValue

```csharp
public float FloatValue { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgHeroAbilityStat_HasFloatValue"></a> HasFloatValue

```csharp
public bool HasFloatValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgHeroAbilityStat_HasIntValue"></a> HasIntValue

```csharp
public bool HasIntValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgHeroAbilityStat_HasStatType"></a> HasStatType

```csharp
public bool HasStatType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgHeroAbilityStat_IntValue"></a> IntValue

```csharp
public int IntValue { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgHeroAbilityStat_Parser"></a> Parser

```csharp
public static MessageParser<CMsgHeroAbilityStat> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgHeroAbilityStat](Divine.Protobufs.Dota2.CMsgHeroAbilityStat.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgHeroAbilityStat_StatType"></a> StatType

```csharp
public EHeroStatType StatType { get; set; }
```

#### Property Value

 [EHeroStatType](Divine.Protobufs.Dota2.EHeroStatType.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgHeroAbilityStat_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgHeroAbilityStat_ClearFloatValue"></a> ClearFloatValue\(\)

```csharp
public void ClearFloatValue()
```

### <a id="Divine_Protobufs_Dota2_CMsgHeroAbilityStat_ClearIntValue"></a> ClearIntValue\(\)

```csharp
public void ClearIntValue()
```

### <a id="Divine_Protobufs_Dota2_CMsgHeroAbilityStat_ClearStatType"></a> ClearStatType\(\)

```csharp
public void ClearStatType()
```

### <a id="Divine_Protobufs_Dota2_CMsgHeroAbilityStat_Clone"></a> Clone\(\)

```csharp
public CMsgHeroAbilityStat Clone()
```

#### Returns

 [CMsgHeroAbilityStat](Divine.Protobufs.Dota2.CMsgHeroAbilityStat.md)

### <a id="Divine_Protobufs_Dota2_CMsgHeroAbilityStat_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgHeroAbilityStat_Equals_Divine_Protobufs_Dota2_CMsgHeroAbilityStat_"></a> Equals\(CMsgHeroAbilityStat\)

```csharp
public bool Equals(CMsgHeroAbilityStat other)
```

#### Parameters

`other` [CMsgHeroAbilityStat](Divine.Protobufs.Dota2.CMsgHeroAbilityStat.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgHeroAbilityStat_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgHeroAbilityStat_MergeFrom_Divine_Protobufs_Dota2_CMsgHeroAbilityStat_"></a> MergeFrom\(CMsgHeroAbilityStat\)

```csharp
public void MergeFrom(CMsgHeroAbilityStat other)
```

#### Parameters

`other` [CMsgHeroAbilityStat](Divine.Protobufs.Dota2.CMsgHeroAbilityStat.md)

### <a id="Divine_Protobufs_Dota2_CMsgHeroAbilityStat_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgHeroAbilityStat_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgHeroAbilityStat_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

