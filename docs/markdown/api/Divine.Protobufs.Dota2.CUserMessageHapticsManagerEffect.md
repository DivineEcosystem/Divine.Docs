# <a id="Divine_Protobufs_Dota2_CUserMessageHapticsManagerEffect"></a> Class CUserMessageHapticsManagerEffect

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMessageHapticsManagerEffect : IMessage<CUserMessageHapticsManagerEffect>, IEquatable<CUserMessageHapticsManagerEffect>, IDeepCloneable<CUserMessageHapticsManagerEffect>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMessageHapticsManagerEffect](Divine.Protobufs.Dota2.CUserMessageHapticsManagerEffect.md)

#### Implements

IMessage<CUserMessageHapticsManagerEffect\>, 
[IEquatable<CUserMessageHapticsManagerEffect\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMessageHapticsManagerEffect\>, 
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
[EnumerableExtensions.In<CUserMessageHapticsManagerEffect\>\(CUserMessageHapticsManagerEffect, params CUserMessageHapticsManagerEffect\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMessageHapticsManagerEffect__ctor"></a> CUserMessageHapticsManagerEffect\(\)

```csharp
public CUserMessageHapticsManagerEffect()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageHapticsManagerEffect__ctor_Divine_Protobufs_Dota2_CUserMessageHapticsManagerEffect_"></a> CUserMessageHapticsManagerEffect\(CUserMessageHapticsManagerEffect\)

```csharp
public CUserMessageHapticsManagerEffect(CUserMessageHapticsManagerEffect other)
```

#### Parameters

`other` [CUserMessageHapticsManagerEffect](Divine.Protobufs.Dota2.CUserMessageHapticsManagerEffect.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMessageHapticsManagerEffect_EffectNameHashCodeFieldNumber"></a> EffectNameHashCodeFieldNumber

```csharp
public const int EffectNameHashCodeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageHapticsManagerEffect_EffectScaleFieldNumber"></a> EffectScaleFieldNumber

```csharp
public const int EffectScaleFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageHapticsManagerEffect_HandIdFieldNumber"></a> HandIdFieldNumber

```csharp
public const int HandIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMessageHapticsManagerEffect_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMessageHapticsManagerEffect_EffectNameHashCode"></a> EffectNameHashCode

```csharp
public uint EffectNameHashCode { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CUserMessageHapticsManagerEffect_EffectScale"></a> EffectScale

```csharp
public float EffectScale { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CUserMessageHapticsManagerEffect_HandId"></a> HandId

```csharp
public int HandId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageHapticsManagerEffect_HasEffectNameHashCode"></a> HasEffectNameHashCode

```csharp
public bool HasEffectNameHashCode { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageHapticsManagerEffect_HasEffectScale"></a> HasEffectScale

```csharp
public bool HasEffectScale { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageHapticsManagerEffect_HasHandId"></a> HasHandId

```csharp
public bool HasHandId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageHapticsManagerEffect_Parser"></a> Parser

```csharp
public static MessageParser<CUserMessageHapticsManagerEffect> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMessageHapticsManagerEffect](Divine.Protobufs.Dota2.CUserMessageHapticsManagerEffect.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMessageHapticsManagerEffect_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageHapticsManagerEffect_ClearEffectNameHashCode"></a> ClearEffectNameHashCode\(\)

```csharp
public void ClearEffectNameHashCode()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageHapticsManagerEffect_ClearEffectScale"></a> ClearEffectScale\(\)

```csharp
public void ClearEffectScale()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageHapticsManagerEffect_ClearHandId"></a> ClearHandId\(\)

```csharp
public void ClearHandId()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageHapticsManagerEffect_Clone"></a> Clone\(\)

```csharp
public CUserMessageHapticsManagerEffect Clone()
```

#### Returns

 [CUserMessageHapticsManagerEffect](Divine.Protobufs.Dota2.CUserMessageHapticsManagerEffect.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageHapticsManagerEffect_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageHapticsManagerEffect_Equals_Divine_Protobufs_Dota2_CUserMessageHapticsManagerEffect_"></a> Equals\(CUserMessageHapticsManagerEffect\)

```csharp
public bool Equals(CUserMessageHapticsManagerEffect other)
```

#### Parameters

`other` [CUserMessageHapticsManagerEffect](Divine.Protobufs.Dota2.CUserMessageHapticsManagerEffect.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageHapticsManagerEffect_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageHapticsManagerEffect_MergeFrom_Divine_Protobufs_Dota2_CUserMessageHapticsManagerEffect_"></a> MergeFrom\(CUserMessageHapticsManagerEffect\)

```csharp
public void MergeFrom(CUserMessageHapticsManagerEffect other)
```

#### Parameters

`other` [CUserMessageHapticsManagerEffect](Divine.Protobufs.Dota2.CUserMessageHapticsManagerEffect.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageHapticsManagerEffect_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMessageHapticsManagerEffect_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessageHapticsManagerEffect_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

