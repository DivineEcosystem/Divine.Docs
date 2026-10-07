# <a id="Divine_Protobufs_Dota2_CEntityMessageDoSpark"></a> Class CEntityMessageDoSpark

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CEntityMessageDoSpark : IMessage<CEntityMessageDoSpark>, IEquatable<CEntityMessageDoSpark>, IDeepCloneable<CEntityMessageDoSpark>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CEntityMessageDoSpark](Divine.Protobufs.Dota2.CEntityMessageDoSpark.md)

#### Implements

IMessage<CEntityMessageDoSpark\>, 
[IEquatable<CEntityMessageDoSpark\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CEntityMessageDoSpark\>, 
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
[EnumerableExtensions.In<CEntityMessageDoSpark\>\(CEntityMessageDoSpark, params CEntityMessageDoSpark\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CEntityMessageDoSpark__ctor"></a> CEntityMessageDoSpark\(\)

```csharp
public CEntityMessageDoSpark()
```

### <a id="Divine_Protobufs_Dota2_CEntityMessageDoSpark__ctor_Divine_Protobufs_Dota2_CEntityMessageDoSpark_"></a> CEntityMessageDoSpark\(CEntityMessageDoSpark\)

```csharp
public CEntityMessageDoSpark(CEntityMessageDoSpark other)
```

#### Parameters

`other` [CEntityMessageDoSpark](Divine.Protobufs.Dota2.CEntityMessageDoSpark.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CEntityMessageDoSpark_BeamsFieldNumber"></a> BeamsFieldNumber

```csharp
public const int BeamsFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CEntityMessageDoSpark_ColorFieldNumber"></a> ColorFieldNumber

```csharp
public const int ColorFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CEntityMessageDoSpark_DurationFieldNumber"></a> DurationFieldNumber

```csharp
public const int DurationFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CEntityMessageDoSpark_EntityindexFieldNumber"></a> EntityindexFieldNumber

```csharp
public const int EntityindexFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CEntityMessageDoSpark_EntityMsgFieldNumber"></a> EntityMsgFieldNumber

```csharp
public const int EntityMsgFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CEntityMessageDoSpark_OriginFieldNumber"></a> OriginFieldNumber

```csharp
public const int OriginFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CEntityMessageDoSpark_RadiusFieldNumber"></a> RadiusFieldNumber

```csharp
public const int RadiusFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CEntityMessageDoSpark_ThickFieldNumber"></a> ThickFieldNumber

```csharp
public const int ThickFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CEntityMessageDoSpark_Beams"></a> Beams

```csharp
public uint Beams { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CEntityMessageDoSpark_Color"></a> Color

```csharp
public uint Color { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CEntityMessageDoSpark_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CEntityMessageDoSpark_Duration"></a> Duration

```csharp
public float Duration { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CEntityMessageDoSpark_Entityindex"></a> Entityindex

```csharp
public int Entityindex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CEntityMessageDoSpark_EntityMsg"></a> EntityMsg

```csharp
public CEntityMsg EntityMsg { get; set; }
```

#### Property Value

 [CEntityMsg](Divine.Protobufs.Dota2.CEntityMsg.md)

### <a id="Divine_Protobufs_Dota2_CEntityMessageDoSpark_HasBeams"></a> HasBeams

```csharp
public bool HasBeams { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CEntityMessageDoSpark_HasColor"></a> HasColor

```csharp
public bool HasColor { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CEntityMessageDoSpark_HasDuration"></a> HasDuration

```csharp
public bool HasDuration { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CEntityMessageDoSpark_HasEntityindex"></a> HasEntityindex

```csharp
public bool HasEntityindex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CEntityMessageDoSpark_HasRadius"></a> HasRadius

```csharp
public bool HasRadius { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CEntityMessageDoSpark_HasThick"></a> HasThick

```csharp
public bool HasThick { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CEntityMessageDoSpark_Origin"></a> Origin

```csharp
public CMsgVector Origin { get; set; }
```

#### Property Value

 [CMsgVector](Divine.Protobufs.Dota2.CMsgVector.md)

### <a id="Divine_Protobufs_Dota2_CEntityMessageDoSpark_Parser"></a> Parser

```csharp
public static MessageParser<CEntityMessageDoSpark> Parser { get; }
```

#### Property Value

 MessageParser<[CEntityMessageDoSpark](Divine.Protobufs.Dota2.CEntityMessageDoSpark.md)\>

### <a id="Divine_Protobufs_Dota2_CEntityMessageDoSpark_Radius"></a> Radius

```csharp
public float Radius { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CEntityMessageDoSpark_Thick"></a> Thick

```csharp
public float Thick { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Protobufs_Dota2_CEntityMessageDoSpark_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CEntityMessageDoSpark_ClearBeams"></a> ClearBeams\(\)

```csharp
public void ClearBeams()
```

### <a id="Divine_Protobufs_Dota2_CEntityMessageDoSpark_ClearColor"></a> ClearColor\(\)

```csharp
public void ClearColor()
```

### <a id="Divine_Protobufs_Dota2_CEntityMessageDoSpark_ClearDuration"></a> ClearDuration\(\)

```csharp
public void ClearDuration()
```

### <a id="Divine_Protobufs_Dota2_CEntityMessageDoSpark_ClearEntityindex"></a> ClearEntityindex\(\)

```csharp
public void ClearEntityindex()
```

### <a id="Divine_Protobufs_Dota2_CEntityMessageDoSpark_ClearRadius"></a> ClearRadius\(\)

```csharp
public void ClearRadius()
```

### <a id="Divine_Protobufs_Dota2_CEntityMessageDoSpark_ClearThick"></a> ClearThick\(\)

```csharp
public void ClearThick()
```

### <a id="Divine_Protobufs_Dota2_CEntityMessageDoSpark_Clone"></a> Clone\(\)

```csharp
public CEntityMessageDoSpark Clone()
```

#### Returns

 [CEntityMessageDoSpark](Divine.Protobufs.Dota2.CEntityMessageDoSpark.md)

### <a id="Divine_Protobufs_Dota2_CEntityMessageDoSpark_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CEntityMessageDoSpark_Equals_Divine_Protobufs_Dota2_CEntityMessageDoSpark_"></a> Equals\(CEntityMessageDoSpark\)

```csharp
public bool Equals(CEntityMessageDoSpark other)
```

#### Parameters

`other` [CEntityMessageDoSpark](Divine.Protobufs.Dota2.CEntityMessageDoSpark.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CEntityMessageDoSpark_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CEntityMessageDoSpark_MergeFrom_Divine_Protobufs_Dota2_CEntityMessageDoSpark_"></a> MergeFrom\(CEntityMessageDoSpark\)

```csharp
public void MergeFrom(CEntityMessageDoSpark other)
```

#### Parameters

`other` [CEntityMessageDoSpark](Divine.Protobufs.Dota2.CEntityMessageDoSpark.md)

### <a id="Divine_Protobufs_Dota2_CEntityMessageDoSpark_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CEntityMessageDoSpark_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CEntityMessageDoSpark_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

