# <a id="Divine_Protobufs_Dota2_CMsgTEShatterSurface"></a> Class CMsgTEShatterSurface

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgTEShatterSurface : IMessage<CMsgTEShatterSurface>, IEquatable<CMsgTEShatterSurface>, IDeepCloneable<CMsgTEShatterSurface>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgTEShatterSurface](Divine.Protobufs.Dota2.CMsgTEShatterSurface.md)

#### Implements

IMessage<CMsgTEShatterSurface\>, 
[IEquatable<CMsgTEShatterSurface\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgTEShatterSurface\>, 
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
[EnumerableExtensions.In<CMsgTEShatterSurface\>\(CMsgTEShatterSurface, params CMsgTEShatterSurface\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgTEShatterSurface__ctor"></a> CMsgTEShatterSurface\(\)

```csharp
public CMsgTEShatterSurface()
```

### <a id="Divine_Protobufs_Dota2_CMsgTEShatterSurface__ctor_Divine_Protobufs_Dota2_CMsgTEShatterSurface_"></a> CMsgTEShatterSurface\(CMsgTEShatterSurface\)

```csharp
public CMsgTEShatterSurface(CMsgTEShatterSurface other)
```

#### Parameters

`other` [CMsgTEShatterSurface](Divine.Protobufs.Dota2.CMsgTEShatterSurface.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgTEShatterSurface_AnglesFieldNumber"></a> AnglesFieldNumber

```csharp
public const int AnglesFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEShatterSurface_BackcolorFieldNumber"></a> BackcolorFieldNumber

```csharp
public const int BackcolorFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEShatterSurface_ForceFieldNumber"></a> ForceFieldNumber

```csharp
public const int ForceFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEShatterSurface_ForceposFieldNumber"></a> ForceposFieldNumber

```csharp
public const int ForceposFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEShatterSurface_FrontcolorFieldNumber"></a> FrontcolorFieldNumber

```csharp
public const int FrontcolorFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEShatterSurface_HeightFieldNumber"></a> HeightFieldNumber

```csharp
public const int HeightFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEShatterSurface_OriginFieldNumber"></a> OriginFieldNumber

```csharp
public const int OriginFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEShatterSurface_ShardsizeFieldNumber"></a> ShardsizeFieldNumber

```csharp
public const int ShardsizeFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEShatterSurface_SurfacetypeFieldNumber"></a> SurfacetypeFieldNumber

```csharp
public const int SurfacetypeFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEShatterSurface_WidthFieldNumber"></a> WidthFieldNumber

```csharp
public const int WidthFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgTEShatterSurface_Angles"></a> Angles

```csharp
public CMsgQAngle Angles { get; set; }
```

#### Property Value

 [CMsgQAngle](Divine.Protobufs.Dota2.CMsgQAngle.md)

### <a id="Divine_Protobufs_Dota2_CMsgTEShatterSurface_Backcolor"></a> Backcolor

```csharp
public uint Backcolor { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgTEShatterSurface_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgTEShatterSurface_Force"></a> Force

```csharp
public CMsgVector Force { get; set; }
```

#### Property Value

 [CMsgVector](Divine.Protobufs.Dota2.CMsgVector.md)

### <a id="Divine_Protobufs_Dota2_CMsgTEShatterSurface_Forcepos"></a> Forcepos

```csharp
public CMsgVector Forcepos { get; set; }
```

#### Property Value

 [CMsgVector](Divine.Protobufs.Dota2.CMsgVector.md)

### <a id="Divine_Protobufs_Dota2_CMsgTEShatterSurface_Frontcolor"></a> Frontcolor

```csharp
public uint Frontcolor { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgTEShatterSurface_HasBackcolor"></a> HasBackcolor

```csharp
public bool HasBackcolor { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEShatterSurface_HasFrontcolor"></a> HasFrontcolor

```csharp
public bool HasFrontcolor { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEShatterSurface_HasHeight"></a> HasHeight

```csharp
public bool HasHeight { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEShatterSurface_HasShardsize"></a> HasShardsize

```csharp
public bool HasShardsize { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEShatterSurface_HasSurfacetype"></a> HasSurfacetype

```csharp
public bool HasSurfacetype { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEShatterSurface_HasWidth"></a> HasWidth

```csharp
public bool HasWidth { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEShatterSurface_Height"></a> Height

```csharp
public float Height { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgTEShatterSurface_Origin"></a> Origin

```csharp
public CMsgVector Origin { get; set; }
```

#### Property Value

 [CMsgVector](Divine.Protobufs.Dota2.CMsgVector.md)

### <a id="Divine_Protobufs_Dota2_CMsgTEShatterSurface_Parser"></a> Parser

```csharp
public static MessageParser<CMsgTEShatterSurface> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgTEShatterSurface](Divine.Protobufs.Dota2.CMsgTEShatterSurface.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgTEShatterSurface_Shardsize"></a> Shardsize

```csharp
public float Shardsize { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgTEShatterSurface_Surfacetype"></a> Surfacetype

```csharp
public uint Surfacetype { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgTEShatterSurface_Width"></a> Width

```csharp
public float Width { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgTEShatterSurface_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEShatterSurface_ClearBackcolor"></a> ClearBackcolor\(\)

```csharp
public void ClearBackcolor()
```

### <a id="Divine_Protobufs_Dota2_CMsgTEShatterSurface_ClearFrontcolor"></a> ClearFrontcolor\(\)

```csharp
public void ClearFrontcolor()
```

### <a id="Divine_Protobufs_Dota2_CMsgTEShatterSurface_ClearHeight"></a> ClearHeight\(\)

```csharp
public void ClearHeight()
```

### <a id="Divine_Protobufs_Dota2_CMsgTEShatterSurface_ClearShardsize"></a> ClearShardsize\(\)

```csharp
public void ClearShardsize()
```

### <a id="Divine_Protobufs_Dota2_CMsgTEShatterSurface_ClearSurfacetype"></a> ClearSurfacetype\(\)

```csharp
public void ClearSurfacetype()
```

### <a id="Divine_Protobufs_Dota2_CMsgTEShatterSurface_ClearWidth"></a> ClearWidth\(\)

```csharp
public void ClearWidth()
```

### <a id="Divine_Protobufs_Dota2_CMsgTEShatterSurface_Clone"></a> Clone\(\)

```csharp
public CMsgTEShatterSurface Clone()
```

#### Returns

 [CMsgTEShatterSurface](Divine.Protobufs.Dota2.CMsgTEShatterSurface.md)

### <a id="Divine_Protobufs_Dota2_CMsgTEShatterSurface_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEShatterSurface_Equals_Divine_Protobufs_Dota2_CMsgTEShatterSurface_"></a> Equals\(CMsgTEShatterSurface\)

```csharp
public bool Equals(CMsgTEShatterSurface other)
```

#### Parameters

`other` [CMsgTEShatterSurface](Divine.Protobufs.Dota2.CMsgTEShatterSurface.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEShatterSurface_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEShatterSurface_MergeFrom_Divine_Protobufs_Dota2_CMsgTEShatterSurface_"></a> MergeFrom\(CMsgTEShatterSurface\)

```csharp
public void MergeFrom(CMsgTEShatterSurface other)
```

#### Parameters

`other` [CMsgTEShatterSurface](Divine.Protobufs.Dota2.CMsgTEShatterSurface.md)

### <a id="Divine_Protobufs_Dota2_CMsgTEShatterSurface_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgTEShatterSurface_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgTEShatterSurface_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

