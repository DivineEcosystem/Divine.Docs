# <a id="Divine_Protobufs_Dota2_CUserMessageDesiredTimescale"></a> Class CUserMessageDesiredTimescale

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMessageDesiredTimescale : IMessage<CUserMessageDesiredTimescale>, IEquatable<CUserMessageDesiredTimescale>, IDeepCloneable<CUserMessageDesiredTimescale>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMessageDesiredTimescale](Divine.Protobufs.Dota2.CUserMessageDesiredTimescale.md)

#### Implements

IMessage<CUserMessageDesiredTimescale\>, 
[IEquatable<CUserMessageDesiredTimescale\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMessageDesiredTimescale\>, 
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
[EnumerableExtensions.In<CUserMessageDesiredTimescale\>\(CUserMessageDesiredTimescale, params CUserMessageDesiredTimescale\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMessageDesiredTimescale__ctor"></a> CUserMessageDesiredTimescale\(\)

```csharp
public CUserMessageDesiredTimescale()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageDesiredTimescale__ctor_Divine_Protobufs_Dota2_CUserMessageDesiredTimescale_"></a> CUserMessageDesiredTimescale\(CUserMessageDesiredTimescale\)

```csharp
public CUserMessageDesiredTimescale(CUserMessageDesiredTimescale other)
```

#### Parameters

`other` [CUserMessageDesiredTimescale](Divine.Protobufs.Dota2.CUserMessageDesiredTimescale.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMessageDesiredTimescale_AccelerationFieldNumber"></a> AccelerationFieldNumber

```csharp
public const int AccelerationFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageDesiredTimescale_BlenddeltamultiplierFieldNumber"></a> BlenddeltamultiplierFieldNumber

```csharp
public const int BlenddeltamultiplierFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageDesiredTimescale_DesiredFieldNumber"></a> DesiredFieldNumber

```csharp
public const int DesiredFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageDesiredTimescale_MinblendrateFieldNumber"></a> MinblendrateFieldNumber

```csharp
public const int MinblendrateFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMessageDesiredTimescale_Acceleration"></a> Acceleration

```csharp
public float Acceleration { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CUserMessageDesiredTimescale_Blenddeltamultiplier"></a> Blenddeltamultiplier

```csharp
public float Blenddeltamultiplier { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CUserMessageDesiredTimescale_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMessageDesiredTimescale_Desired"></a> Desired

```csharp
public float Desired { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CUserMessageDesiredTimescale_HasAcceleration"></a> HasAcceleration

```csharp
public bool HasAcceleration { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageDesiredTimescale_HasBlenddeltamultiplier"></a> HasBlenddeltamultiplier

```csharp
public bool HasBlenddeltamultiplier { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageDesiredTimescale_HasDesired"></a> HasDesired

```csharp
public bool HasDesired { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageDesiredTimescale_HasMinblendrate"></a> HasMinblendrate

```csharp
public bool HasMinblendrate { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageDesiredTimescale_Minblendrate"></a> Minblendrate

```csharp
public float Minblendrate { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CUserMessageDesiredTimescale_Parser"></a> Parser

```csharp
public static MessageParser<CUserMessageDesiredTimescale> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMessageDesiredTimescale](Divine.Protobufs.Dota2.CUserMessageDesiredTimescale.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMessageDesiredTimescale_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageDesiredTimescale_ClearAcceleration"></a> ClearAcceleration\(\)

```csharp
public void ClearAcceleration()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageDesiredTimescale_ClearBlenddeltamultiplier"></a> ClearBlenddeltamultiplier\(\)

```csharp
public void ClearBlenddeltamultiplier()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageDesiredTimescale_ClearDesired"></a> ClearDesired\(\)

```csharp
public void ClearDesired()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageDesiredTimescale_ClearMinblendrate"></a> ClearMinblendrate\(\)

```csharp
public void ClearMinblendrate()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageDesiredTimescale_Clone"></a> Clone\(\)

```csharp
public CUserMessageDesiredTimescale Clone()
```

#### Returns

 [CUserMessageDesiredTimescale](Divine.Protobufs.Dota2.CUserMessageDesiredTimescale.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageDesiredTimescale_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageDesiredTimescale_Equals_Divine_Protobufs_Dota2_CUserMessageDesiredTimescale_"></a> Equals\(CUserMessageDesiredTimescale\)

```csharp
public bool Equals(CUserMessageDesiredTimescale other)
```

#### Parameters

`other` [CUserMessageDesiredTimescale](Divine.Protobufs.Dota2.CUserMessageDesiredTimescale.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageDesiredTimescale_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageDesiredTimescale_MergeFrom_Divine_Protobufs_Dota2_CUserMessageDesiredTimescale_"></a> MergeFrom\(CUserMessageDesiredTimescale\)

```csharp
public void MergeFrom(CUserMessageDesiredTimescale other)
```

#### Parameters

`other` [CUserMessageDesiredTimescale](Divine.Protobufs.Dota2.CUserMessageDesiredTimescale.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageDesiredTimescale_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMessageDesiredTimescale_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessageDesiredTimescale_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

