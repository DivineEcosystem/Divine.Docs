# <a id="Divine_Protobufs_Dota2_CMsgTEGlowSprite"></a> Class CMsgTEGlowSprite

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgTEGlowSprite : IMessage<CMsgTEGlowSprite>, IEquatable<CMsgTEGlowSprite>, IDeepCloneable<CMsgTEGlowSprite>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgTEGlowSprite](Divine.Protobufs.Dota2.CMsgTEGlowSprite.md)

#### Implements

IMessage<CMsgTEGlowSprite\>, 
[IEquatable<CMsgTEGlowSprite\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgTEGlowSprite\>, 
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
[EnumerableExtensions.In<CMsgTEGlowSprite\>\(CMsgTEGlowSprite, params CMsgTEGlowSprite\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgTEGlowSprite__ctor"></a> CMsgTEGlowSprite\(\)

```csharp
public CMsgTEGlowSprite()
```

### <a id="Divine_Protobufs_Dota2_CMsgTEGlowSprite__ctor_Divine_Protobufs_Dota2_CMsgTEGlowSprite_"></a> CMsgTEGlowSprite\(CMsgTEGlowSprite\)

```csharp
public CMsgTEGlowSprite(CMsgTEGlowSprite other)
```

#### Parameters

`other` [CMsgTEGlowSprite](Divine.Protobufs.Dota2.CMsgTEGlowSprite.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgTEGlowSprite_BrightnessFieldNumber"></a> BrightnessFieldNumber

```csharp
public const int BrightnessFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEGlowSprite_LifeFieldNumber"></a> LifeFieldNumber

```csharp
public const int LifeFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEGlowSprite_OriginFieldNumber"></a> OriginFieldNumber

```csharp
public const int OriginFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEGlowSprite_ScaleFieldNumber"></a> ScaleFieldNumber

```csharp
public const int ScaleFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgTEGlowSprite_Brightness"></a> Brightness

```csharp
public uint Brightness { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgTEGlowSprite_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgTEGlowSprite_HasBrightness"></a> HasBrightness

```csharp
public bool HasBrightness { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEGlowSprite_HasLife"></a> HasLife

```csharp
public bool HasLife { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEGlowSprite_HasScale"></a> HasScale

```csharp
public bool HasScale { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEGlowSprite_Life"></a> Life

```csharp
public float Life { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgTEGlowSprite_Origin"></a> Origin

```csharp
public CMsgVector Origin { get; set; }
```

#### Property Value

 [CMsgVector](Divine.Protobufs.Dota2.CMsgVector.md)

### <a id="Divine_Protobufs_Dota2_CMsgTEGlowSprite_Parser"></a> Parser

```csharp
public static MessageParser<CMsgTEGlowSprite> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgTEGlowSprite](Divine.Protobufs.Dota2.CMsgTEGlowSprite.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgTEGlowSprite_Scale"></a> Scale

```csharp
public float Scale { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgTEGlowSprite_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEGlowSprite_ClearBrightness"></a> ClearBrightness\(\)

```csharp
public void ClearBrightness()
```

### <a id="Divine_Protobufs_Dota2_CMsgTEGlowSprite_ClearLife"></a> ClearLife\(\)

```csharp
public void ClearLife()
```

### <a id="Divine_Protobufs_Dota2_CMsgTEGlowSprite_ClearScale"></a> ClearScale\(\)

```csharp
public void ClearScale()
```

### <a id="Divine_Protobufs_Dota2_CMsgTEGlowSprite_Clone"></a> Clone\(\)

```csharp
public CMsgTEGlowSprite Clone()
```

#### Returns

 [CMsgTEGlowSprite](Divine.Protobufs.Dota2.CMsgTEGlowSprite.md)

### <a id="Divine_Protobufs_Dota2_CMsgTEGlowSprite_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEGlowSprite_Equals_Divine_Protobufs_Dota2_CMsgTEGlowSprite_"></a> Equals\(CMsgTEGlowSprite\)

```csharp
public bool Equals(CMsgTEGlowSprite other)
```

#### Parameters

`other` [CMsgTEGlowSprite](Divine.Protobufs.Dota2.CMsgTEGlowSprite.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEGlowSprite_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEGlowSprite_MergeFrom_Divine_Protobufs_Dota2_CMsgTEGlowSprite_"></a> MergeFrom\(CMsgTEGlowSprite\)

```csharp
public void MergeFrom(CMsgTEGlowSprite other)
```

#### Parameters

`other` [CMsgTEGlowSprite](Divine.Protobufs.Dota2.CMsgTEGlowSprite.md)

### <a id="Divine_Protobufs_Dota2_CMsgTEGlowSprite_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgTEGlowSprite_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgTEGlowSprite_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

