# <a id="Divine_Protobufs_Dota2_CUserMessageShake"></a> Class CUserMessageShake

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMessageShake : IMessage<CUserMessageShake>, IEquatable<CUserMessageShake>, IDeepCloneable<CUserMessageShake>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMessageShake](Divine.Protobufs.Dota2.CUserMessageShake.md)

#### Implements

IMessage<CUserMessageShake\>, 
[IEquatable<CUserMessageShake\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMessageShake\>, 
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
[EnumerableExtensions.In<CUserMessageShake\>\(CUserMessageShake, params CUserMessageShake\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMessageShake__ctor"></a> CUserMessageShake\(\)

```csharp
public CUserMessageShake()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageShake__ctor_Divine_Protobufs_Dota2_CUserMessageShake_"></a> CUserMessageShake\(CUserMessageShake\)

```csharp
public CUserMessageShake(CUserMessageShake other)
```

#### Parameters

`other` [CUserMessageShake](Divine.Protobufs.Dota2.CUserMessageShake.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMessageShake_AmplitudeFieldNumber"></a> AmplitudeFieldNumber

```csharp
public const int AmplitudeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageShake_CommandFieldNumber"></a> CommandFieldNumber

```csharp
public const int CommandFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageShake_DurationFieldNumber"></a> DurationFieldNumber

```csharp
public const int DurationFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageShake_FrequencyFieldNumber"></a> FrequencyFieldNumber

```csharp
public const int FrequencyFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMessageShake_Amplitude"></a> Amplitude

```csharp
public float Amplitude { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CUserMessageShake_Command"></a> Command

```csharp
public uint Command { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CUserMessageShake_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMessageShake_Duration"></a> Duration

```csharp
public float Duration { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CUserMessageShake_Frequency"></a> Frequency

```csharp
public float Frequency { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CUserMessageShake_HasAmplitude"></a> HasAmplitude

```csharp
public bool HasAmplitude { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageShake_HasCommand"></a> HasCommand

```csharp
public bool HasCommand { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageShake_HasDuration"></a> HasDuration

```csharp
public bool HasDuration { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageShake_HasFrequency"></a> HasFrequency

```csharp
public bool HasFrequency { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageShake_Parser"></a> Parser

```csharp
public static MessageParser<CUserMessageShake> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMessageShake](Divine.Protobufs.Dota2.CUserMessageShake.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMessageShake_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageShake_ClearAmplitude"></a> ClearAmplitude\(\)

```csharp
public void ClearAmplitude()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageShake_ClearCommand"></a> ClearCommand\(\)

```csharp
public void ClearCommand()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageShake_ClearDuration"></a> ClearDuration\(\)

```csharp
public void ClearDuration()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageShake_ClearFrequency"></a> ClearFrequency\(\)

```csharp
public void ClearFrequency()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageShake_Clone"></a> Clone\(\)

```csharp
public CUserMessageShake Clone()
```

#### Returns

 [CUserMessageShake](Divine.Protobufs.Dota2.CUserMessageShake.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageShake_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageShake_Equals_Divine_Protobufs_Dota2_CUserMessageShake_"></a> Equals\(CUserMessageShake\)

```csharp
public bool Equals(CUserMessageShake other)
```

#### Parameters

`other` [CUserMessageShake](Divine.Protobufs.Dota2.CUserMessageShake.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageShake_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageShake_MergeFrom_Divine_Protobufs_Dota2_CUserMessageShake_"></a> MergeFrom\(CUserMessageShake\)

```csharp
public void MergeFrom(CUserMessageShake other)
```

#### Parameters

`other` [CUserMessageShake](Divine.Protobufs.Dota2.CUserMessageShake.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageShake_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMessageShake_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessageShake_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

