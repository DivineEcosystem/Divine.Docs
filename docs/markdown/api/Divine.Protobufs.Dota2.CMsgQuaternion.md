# <a id="Divine_Protobufs_Dota2_CMsgQuaternion"></a> Class CMsgQuaternion

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgQuaternion : IMessage<CMsgQuaternion>, IEquatable<CMsgQuaternion>, IDeepCloneable<CMsgQuaternion>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgQuaternion](Divine.Protobufs.Dota2.CMsgQuaternion.md)

#### Implements

IMessage<CMsgQuaternion\>, 
[IEquatable<CMsgQuaternion\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgQuaternion\>, 
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
[EnumerableExtensions.In<CMsgQuaternion\>\(CMsgQuaternion, params CMsgQuaternion\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgQuaternion__ctor"></a> CMsgQuaternion\(\)

```csharp
public CMsgQuaternion()
```

### <a id="Divine_Protobufs_Dota2_CMsgQuaternion__ctor_Divine_Protobufs_Dota2_CMsgQuaternion_"></a> CMsgQuaternion\(CMsgQuaternion\)

```csharp
public CMsgQuaternion(CMsgQuaternion other)
```

#### Parameters

`other` [CMsgQuaternion](Divine.Protobufs.Dota2.CMsgQuaternion.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgQuaternion_WFieldNumber"></a> WFieldNumber

```csharp
public const int WFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgQuaternion_XFieldNumber"></a> XFieldNumber

```csharp
public const int XFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgQuaternion_YFieldNumber"></a> YFieldNumber

```csharp
public const int YFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgQuaternion_ZFieldNumber"></a> ZFieldNumber

```csharp
public const int ZFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgQuaternion_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgQuaternion_HasW"></a> HasW

```csharp
public bool HasW { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgQuaternion_HasX"></a> HasX

```csharp
public bool HasX { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgQuaternion_HasY"></a> HasY

```csharp
public bool HasY { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgQuaternion_HasZ"></a> HasZ

```csharp
public bool HasZ { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgQuaternion_Parser"></a> Parser

```csharp
public static MessageParser<CMsgQuaternion> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgQuaternion](Divine.Protobufs.Dota2.CMsgQuaternion.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgQuaternion_W"></a> W

```csharp
public float W { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgQuaternion_X"></a> X

```csharp
public float X { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgQuaternion_Y"></a> Y

```csharp
public float Y { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgQuaternion_Z"></a> Z

```csharp
public float Z { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgQuaternion_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgQuaternion_ClearW"></a> ClearW\(\)

```csharp
public void ClearW()
```

### <a id="Divine_Protobufs_Dota2_CMsgQuaternion_ClearX"></a> ClearX\(\)

```csharp
public void ClearX()
```

### <a id="Divine_Protobufs_Dota2_CMsgQuaternion_ClearY"></a> ClearY\(\)

```csharp
public void ClearY()
```

### <a id="Divine_Protobufs_Dota2_CMsgQuaternion_ClearZ"></a> ClearZ\(\)

```csharp
public void ClearZ()
```

### <a id="Divine_Protobufs_Dota2_CMsgQuaternion_Clone"></a> Clone\(\)

```csharp
public CMsgQuaternion Clone()
```

#### Returns

 [CMsgQuaternion](Divine.Protobufs.Dota2.CMsgQuaternion.md)

### <a id="Divine_Protobufs_Dota2_CMsgQuaternion_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgQuaternion_Equals_Divine_Protobufs_Dota2_CMsgQuaternion_"></a> Equals\(CMsgQuaternion\)

```csharp
public bool Equals(CMsgQuaternion other)
```

#### Parameters

`other` [CMsgQuaternion](Divine.Protobufs.Dota2.CMsgQuaternion.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgQuaternion_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgQuaternion_MergeFrom_Divine_Protobufs_Dota2_CMsgQuaternion_"></a> MergeFrom\(CMsgQuaternion\)

```csharp
public void MergeFrom(CMsgQuaternion other)
```

#### Parameters

`other` [CMsgQuaternion](Divine.Protobufs.Dota2.CMsgQuaternion.md)

### <a id="Divine_Protobufs_Dota2_CMsgQuaternion_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgQuaternion_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgQuaternion_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

