# <a id="Divine_Protobufs_Dota2_CUserMessageHapticsManagerPulse"></a> Class CUserMessageHapticsManagerPulse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMessageHapticsManagerPulse : IMessage<CUserMessageHapticsManagerPulse>, IEquatable<CUserMessageHapticsManagerPulse>, IDeepCloneable<CUserMessageHapticsManagerPulse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMessageHapticsManagerPulse](Divine.Protobufs.Dota2.CUserMessageHapticsManagerPulse.md)

#### Implements

IMessage<CUserMessageHapticsManagerPulse\>, 
[IEquatable<CUserMessageHapticsManagerPulse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMessageHapticsManagerPulse\>, 
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
[EnumerableExtensions.In<CUserMessageHapticsManagerPulse\>\(CUserMessageHapticsManagerPulse, params CUserMessageHapticsManagerPulse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMessageHapticsManagerPulse__ctor"></a> CUserMessageHapticsManagerPulse\(\)

```csharp
public CUserMessageHapticsManagerPulse()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageHapticsManagerPulse__ctor_Divine_Protobufs_Dota2_CUserMessageHapticsManagerPulse_"></a> CUserMessageHapticsManagerPulse\(CUserMessageHapticsManagerPulse\)

```csharp
public CUserMessageHapticsManagerPulse(CUserMessageHapticsManagerPulse other)
```

#### Parameters

`other` [CUserMessageHapticsManagerPulse](Divine.Protobufs.Dota2.CUserMessageHapticsManagerPulse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMessageHapticsManagerPulse_EffectAmplitudeFieldNumber"></a> EffectAmplitudeFieldNumber

```csharp
public const int EffectAmplitudeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageHapticsManagerPulse_EffectDurationFieldNumber"></a> EffectDurationFieldNumber

```csharp
public const int EffectDurationFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageHapticsManagerPulse_EffectFrequencyFieldNumber"></a> EffectFrequencyFieldNumber

```csharp
public const int EffectFrequencyFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageHapticsManagerPulse_HandIdFieldNumber"></a> HandIdFieldNumber

```csharp
public const int HandIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMessageHapticsManagerPulse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMessageHapticsManagerPulse_EffectAmplitude"></a> EffectAmplitude

```csharp
public float EffectAmplitude { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CUserMessageHapticsManagerPulse_EffectDuration"></a> EffectDuration

```csharp
public float EffectDuration { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CUserMessageHapticsManagerPulse_EffectFrequency"></a> EffectFrequency

```csharp
public float EffectFrequency { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CUserMessageHapticsManagerPulse_HandId"></a> HandId

```csharp
public int HandId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageHapticsManagerPulse_HasEffectAmplitude"></a> HasEffectAmplitude

```csharp
public bool HasEffectAmplitude { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageHapticsManagerPulse_HasEffectDuration"></a> HasEffectDuration

```csharp
public bool HasEffectDuration { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageHapticsManagerPulse_HasEffectFrequency"></a> HasEffectFrequency

```csharp
public bool HasEffectFrequency { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageHapticsManagerPulse_HasHandId"></a> HasHandId

```csharp
public bool HasHandId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageHapticsManagerPulse_Parser"></a> Parser

```csharp
public static MessageParser<CUserMessageHapticsManagerPulse> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMessageHapticsManagerPulse](Divine.Protobufs.Dota2.CUserMessageHapticsManagerPulse.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMessageHapticsManagerPulse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageHapticsManagerPulse_ClearEffectAmplitude"></a> ClearEffectAmplitude\(\)

```csharp
public void ClearEffectAmplitude()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageHapticsManagerPulse_ClearEffectDuration"></a> ClearEffectDuration\(\)

```csharp
public void ClearEffectDuration()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageHapticsManagerPulse_ClearEffectFrequency"></a> ClearEffectFrequency\(\)

```csharp
public void ClearEffectFrequency()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageHapticsManagerPulse_ClearHandId"></a> ClearHandId\(\)

```csharp
public void ClearHandId()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageHapticsManagerPulse_Clone"></a> Clone\(\)

```csharp
public CUserMessageHapticsManagerPulse Clone()
```

#### Returns

 [CUserMessageHapticsManagerPulse](Divine.Protobufs.Dota2.CUserMessageHapticsManagerPulse.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageHapticsManagerPulse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageHapticsManagerPulse_Equals_Divine_Protobufs_Dota2_CUserMessageHapticsManagerPulse_"></a> Equals\(CUserMessageHapticsManagerPulse\)

```csharp
public bool Equals(CUserMessageHapticsManagerPulse other)
```

#### Parameters

`other` [CUserMessageHapticsManagerPulse](Divine.Protobufs.Dota2.CUserMessageHapticsManagerPulse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageHapticsManagerPulse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageHapticsManagerPulse_MergeFrom_Divine_Protobufs_Dota2_CUserMessageHapticsManagerPulse_"></a> MergeFrom\(CUserMessageHapticsManagerPulse\)

```csharp
public void MergeFrom(CUserMessageHapticsManagerPulse other)
```

#### Parameters

`other` [CUserMessageHapticsManagerPulse](Divine.Protobufs.Dota2.CUserMessageHapticsManagerPulse.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageHapticsManagerPulse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMessageHapticsManagerPulse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessageHapticsManagerPulse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

