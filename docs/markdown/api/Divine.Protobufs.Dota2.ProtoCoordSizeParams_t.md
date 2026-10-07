# <a id="Divine_Protobufs_Dota2_ProtoCoordSizeParams_t"></a> Class ProtoCoordSizeParams\_t

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class ProtoCoordSizeParams_t : IMessage<ProtoCoordSizeParams_t>, IEquatable<ProtoCoordSizeParams_t>, IDeepCloneable<ProtoCoordSizeParams_t>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ProtoCoordSizeParams\_t](Divine.Protobufs.Dota2.ProtoCoordSizeParams\_t.md)

#### Implements

IMessage<ProtoCoordSizeParams\_t\>, 
[IEquatable<ProtoCoordSizeParams\_t\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<ProtoCoordSizeParams\_t\>, 
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
[EnumerableExtensions.In<ProtoCoordSizeParams\_t\>\(ProtoCoordSizeParams\_t, params ProtoCoordSizeParams\_t\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_ProtoCoordSizeParams_t__ctor"></a> ProtoCoordSizeParams\_t\(\)

```csharp
public ProtoCoordSizeParams_t()
```

### <a id="Divine_Protobufs_Dota2_ProtoCoordSizeParams_t__ctor_Divine_Protobufs_Dota2_ProtoCoordSizeParams_t_"></a> ProtoCoordSizeParams\_t\(ProtoCoordSizeParams\_t\)

```csharp
public ProtoCoordSizeParams_t(ProtoCoordSizeParams_t other)
```

#### Parameters

`other` [ProtoCoordSizeParams\_t](Divine.Protobufs.Dota2.ProtoCoordSizeParams\_t.md)

## Fields

### <a id="Divine_Protobufs_Dota2_ProtoCoordSizeParams_t_AngleBitsFieldNumber"></a> AngleBitsFieldNumber

```csharp
public const int AngleBitsFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_ProtoCoordSizeParams_t_CoordFractionalBitsFieldNumber"></a> CoordFractionalBitsFieldNumber

```csharp
public const int CoordFractionalBitsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_ProtoCoordSizeParams_t_CoordFractionalBitsMpFieldNumber"></a> CoordFractionalBitsMpFieldNumber

```csharp
public const int CoordFractionalBitsMpFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_ProtoCoordSizeParams_t_CoordIntegerBitsFieldNumber"></a> CoordIntegerBitsFieldNumber

```csharp
public const int CoordIntegerBitsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_ProtoCoordSizeParams_t_CoordIntegerBitsMpFieldNumber"></a> CoordIntegerBitsMpFieldNumber

```csharp
public const int CoordIntegerBitsMpFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_ProtoCoordSizeParams_t_NormalFractionalBitsFieldNumber"></a> NormalFractionalBitsFieldNumber

```csharp
public const int NormalFractionalBitsFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_ProtoCoordSizeParams_t_AngleBits"></a> AngleBits

```csharp
public int AngleBits { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_ProtoCoordSizeParams_t_CoordFractionalBits"></a> CoordFractionalBits

```csharp
public int CoordFractionalBits { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_ProtoCoordSizeParams_t_CoordFractionalBitsMp"></a> CoordFractionalBitsMp

```csharp
public int CoordFractionalBitsMp { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_ProtoCoordSizeParams_t_CoordIntegerBits"></a> CoordIntegerBits

```csharp
public int CoordIntegerBits { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_ProtoCoordSizeParams_t_CoordIntegerBitsMp"></a> CoordIntegerBitsMp

```csharp
public int CoordIntegerBitsMp { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_ProtoCoordSizeParams_t_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_ProtoCoordSizeParams_t_HasAngleBits"></a> HasAngleBits

```csharp
public bool HasAngleBits { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_ProtoCoordSizeParams_t_HasCoordFractionalBits"></a> HasCoordFractionalBits

```csharp
public bool HasCoordFractionalBits { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_ProtoCoordSizeParams_t_HasCoordFractionalBitsMp"></a> HasCoordFractionalBitsMp

```csharp
public bool HasCoordFractionalBitsMp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_ProtoCoordSizeParams_t_HasCoordIntegerBits"></a> HasCoordIntegerBits

```csharp
public bool HasCoordIntegerBits { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_ProtoCoordSizeParams_t_HasCoordIntegerBitsMp"></a> HasCoordIntegerBitsMp

```csharp
public bool HasCoordIntegerBitsMp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_ProtoCoordSizeParams_t_HasNormalFractionalBits"></a> HasNormalFractionalBits

```csharp
public bool HasNormalFractionalBits { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_ProtoCoordSizeParams_t_NormalFractionalBits"></a> NormalFractionalBits

```csharp
public int NormalFractionalBits { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_ProtoCoordSizeParams_t_Parser"></a> Parser

```csharp
public static MessageParser<ProtoCoordSizeParams_t> Parser { get; }
```

#### Property Value

 MessageParser<[ProtoCoordSizeParams\_t](Divine.Protobufs.Dota2.ProtoCoordSizeParams\_t.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_ProtoCoordSizeParams_t_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_ProtoCoordSizeParams_t_ClearAngleBits"></a> ClearAngleBits\(\)

```csharp
public void ClearAngleBits()
```

### <a id="Divine_Protobufs_Dota2_ProtoCoordSizeParams_t_ClearCoordFractionalBits"></a> ClearCoordFractionalBits\(\)

```csharp
public void ClearCoordFractionalBits()
```

### <a id="Divine_Protobufs_Dota2_ProtoCoordSizeParams_t_ClearCoordFractionalBitsMp"></a> ClearCoordFractionalBitsMp\(\)

```csharp
public void ClearCoordFractionalBitsMp()
```

### <a id="Divine_Protobufs_Dota2_ProtoCoordSizeParams_t_ClearCoordIntegerBits"></a> ClearCoordIntegerBits\(\)

```csharp
public void ClearCoordIntegerBits()
```

### <a id="Divine_Protobufs_Dota2_ProtoCoordSizeParams_t_ClearCoordIntegerBitsMp"></a> ClearCoordIntegerBitsMp\(\)

```csharp
public void ClearCoordIntegerBitsMp()
```

### <a id="Divine_Protobufs_Dota2_ProtoCoordSizeParams_t_ClearNormalFractionalBits"></a> ClearNormalFractionalBits\(\)

```csharp
public void ClearNormalFractionalBits()
```

### <a id="Divine_Protobufs_Dota2_ProtoCoordSizeParams_t_Clone"></a> Clone\(\)

```csharp
public ProtoCoordSizeParams_t Clone()
```

#### Returns

 [ProtoCoordSizeParams\_t](Divine.Protobufs.Dota2.ProtoCoordSizeParams\_t.md)

### <a id="Divine_Protobufs_Dota2_ProtoCoordSizeParams_t_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_ProtoCoordSizeParams_t_Equals_Divine_Protobufs_Dota2_ProtoCoordSizeParams_t_"></a> Equals\(ProtoCoordSizeParams\_t\)

```csharp
public bool Equals(ProtoCoordSizeParams_t other)
```

#### Parameters

`other` [ProtoCoordSizeParams\_t](Divine.Protobufs.Dota2.ProtoCoordSizeParams\_t.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_ProtoCoordSizeParams_t_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_ProtoCoordSizeParams_t_MergeFrom_Divine_Protobufs_Dota2_ProtoCoordSizeParams_t_"></a> MergeFrom\(ProtoCoordSizeParams\_t\)

```csharp
public void MergeFrom(ProtoCoordSizeParams_t other)
```

#### Parameters

`other` [ProtoCoordSizeParams\_t](Divine.Protobufs.Dota2.ProtoCoordSizeParams\_t.md)

### <a id="Divine_Protobufs_Dota2_ProtoCoordSizeParams_t_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_ProtoCoordSizeParams_t_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_ProtoCoordSizeParams_t_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

