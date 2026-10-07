# <a id="Divine_Protobufs_Dota2_CMsgTEDecal"></a> Class CMsgTEDecal

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgTEDecal : IMessage<CMsgTEDecal>, IEquatable<CMsgTEDecal>, IDeepCloneable<CMsgTEDecal>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgTEDecal](Divine.Protobufs.Dota2.CMsgTEDecal.md)

#### Implements

IMessage<CMsgTEDecal\>, 
[IEquatable<CMsgTEDecal\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgTEDecal\>, 
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
[EnumerableExtensions.In<CMsgTEDecal\>\(CMsgTEDecal, params CMsgTEDecal\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgTEDecal__ctor"></a> CMsgTEDecal\(\)

```csharp
public CMsgTEDecal()
```

### <a id="Divine_Protobufs_Dota2_CMsgTEDecal__ctor_Divine_Protobufs_Dota2_CMsgTEDecal_"></a> CMsgTEDecal\(CMsgTEDecal\)

```csharp
public CMsgTEDecal(CMsgTEDecal other)
```

#### Parameters

`other` [CMsgTEDecal](Divine.Protobufs.Dota2.CMsgTEDecal.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgTEDecal_EntityFieldNumber"></a> EntityFieldNumber

```csharp
public const int EntityFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEDecal_HitboxFieldNumber"></a> HitboxFieldNumber

```csharp
public const int HitboxFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEDecal_IndexFieldNumber"></a> IndexFieldNumber

```csharp
public const int IndexFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEDecal_OriginFieldNumber"></a> OriginFieldNumber

```csharp
public const int OriginFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEDecal_StartFieldNumber"></a> StartFieldNumber

```csharp
public const int StartFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgTEDecal_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgTEDecal_Entity"></a> Entity

```csharp
public int Entity { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEDecal_HasEntity"></a> HasEntity

```csharp
public bool HasEntity { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEDecal_HasHitbox"></a> HasHitbox

```csharp
public bool HasHitbox { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEDecal_HasIndex"></a> HasIndex

```csharp
public bool HasIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEDecal_Hitbox"></a> Hitbox

```csharp
public uint Hitbox { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgTEDecal_Index"></a> Index

```csharp
public uint Index { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgTEDecal_Origin"></a> Origin

```csharp
public CMsgVector Origin { get; set; }
```

#### Property Value

 [CMsgVector](Divine.Protobufs.Dota2.CMsgVector.md)

### <a id="Divine_Protobufs_Dota2_CMsgTEDecal_Parser"></a> Parser

```csharp
public static MessageParser<CMsgTEDecal> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgTEDecal](Divine.Protobufs.Dota2.CMsgTEDecal.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgTEDecal_Start"></a> Start

```csharp
public CMsgVector Start { get; set; }
```

#### Property Value

 [CMsgVector](Divine.Protobufs.Dota2.CMsgVector.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgTEDecal_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEDecal_ClearEntity"></a> ClearEntity\(\)

```csharp
public void ClearEntity()
```

### <a id="Divine_Protobufs_Dota2_CMsgTEDecal_ClearHitbox"></a> ClearHitbox\(\)

```csharp
public void ClearHitbox()
```

### <a id="Divine_Protobufs_Dota2_CMsgTEDecal_ClearIndex"></a> ClearIndex\(\)

```csharp
public void ClearIndex()
```

### <a id="Divine_Protobufs_Dota2_CMsgTEDecal_Clone"></a> Clone\(\)

```csharp
public CMsgTEDecal Clone()
```

#### Returns

 [CMsgTEDecal](Divine.Protobufs.Dota2.CMsgTEDecal.md)

### <a id="Divine_Protobufs_Dota2_CMsgTEDecal_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEDecal_Equals_Divine_Protobufs_Dota2_CMsgTEDecal_"></a> Equals\(CMsgTEDecal\)

```csharp
public bool Equals(CMsgTEDecal other)
```

#### Parameters

`other` [CMsgTEDecal](Divine.Protobufs.Dota2.CMsgTEDecal.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEDecal_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEDecal_MergeFrom_Divine_Protobufs_Dota2_CMsgTEDecal_"></a> MergeFrom\(CMsgTEDecal\)

```csharp
public void MergeFrom(CMsgTEDecal other)
```

#### Parameters

`other` [CMsgTEDecal](Divine.Protobufs.Dota2.CMsgTEDecal.md)

### <a id="Divine_Protobufs_Dota2_CMsgTEDecal_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgTEDecal_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgTEDecal_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

