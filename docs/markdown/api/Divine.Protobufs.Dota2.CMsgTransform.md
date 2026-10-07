# <a id="Divine_Protobufs_Dota2_CMsgTransform"></a> Class CMsgTransform

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgTransform : IMessage<CMsgTransform>, IEquatable<CMsgTransform>, IDeepCloneable<CMsgTransform>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgTransform](Divine.Protobufs.Dota2.CMsgTransform.md)

#### Implements

IMessage<CMsgTransform\>, 
[IEquatable<CMsgTransform\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgTransform\>, 
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
[EnumerableExtensions.In<CMsgTransform\>\(CMsgTransform, params CMsgTransform\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgTransform__ctor"></a> CMsgTransform\(\)

```csharp
public CMsgTransform()
```

### <a id="Divine_Protobufs_Dota2_CMsgTransform__ctor_Divine_Protobufs_Dota2_CMsgTransform_"></a> CMsgTransform\(CMsgTransform\)

```csharp
public CMsgTransform(CMsgTransform other)
```

#### Parameters

`other` [CMsgTransform](Divine.Protobufs.Dota2.CMsgTransform.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgTransform_OrientationFieldNumber"></a> OrientationFieldNumber

```csharp
public const int OrientationFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTransform_PositionFieldNumber"></a> PositionFieldNumber

```csharp
public const int PositionFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTransform_ScaleFieldNumber"></a> ScaleFieldNumber

```csharp
public const int ScaleFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgTransform_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgTransform_HasScale"></a> HasScale

```csharp
public bool HasScale { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTransform_Orientation"></a> Orientation

```csharp
public CMsgQuaternion Orientation { get; set; }
```

#### Property Value

 [CMsgQuaternion](Divine.Protobufs.Dota2.CMsgQuaternion.md)

### <a id="Divine_Protobufs_Dota2_CMsgTransform_Parser"></a> Parser

```csharp
public static MessageParser<CMsgTransform> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgTransform](Divine.Protobufs.Dota2.CMsgTransform.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgTransform_Position"></a> Position

```csharp
public CMsgVector Position { get; set; }
```

#### Property Value

 [CMsgVector](Divine.Protobufs.Dota2.CMsgVector.md)

### <a id="Divine_Protobufs_Dota2_CMsgTransform_Scale"></a> Scale

```csharp
public float Scale { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgTransform_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTransform_ClearScale"></a> ClearScale\(\)

```csharp
public void ClearScale()
```

### <a id="Divine_Protobufs_Dota2_CMsgTransform_Clone"></a> Clone\(\)

```csharp
public CMsgTransform Clone()
```

#### Returns

 [CMsgTransform](Divine.Protobufs.Dota2.CMsgTransform.md)

### <a id="Divine_Protobufs_Dota2_CMsgTransform_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTransform_Equals_Divine_Protobufs_Dota2_CMsgTransform_"></a> Equals\(CMsgTransform\)

```csharp
public bool Equals(CMsgTransform other)
```

#### Parameters

`other` [CMsgTransform](Divine.Protobufs.Dota2.CMsgTransform.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTransform_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTransform_MergeFrom_Divine_Protobufs_Dota2_CMsgTransform_"></a> MergeFrom\(CMsgTransform\)

```csharp
public void MergeFrom(CMsgTransform other)
```

#### Parameters

`other` [CMsgTransform](Divine.Protobufs.Dota2.CMsgTransform.md)

### <a id="Divine_Protobufs_Dota2_CMsgTransform_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgTransform_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgTransform_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

