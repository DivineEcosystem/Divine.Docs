# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimationEnd"></a> Class CDOTAUserMsg\_TE\_UnitAnimationEnd

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_TE_UnitAnimationEnd : IMessage<CDOTAUserMsg_TE_UnitAnimationEnd>, IEquatable<CDOTAUserMsg_TE_UnitAnimationEnd>, IDeepCloneable<CDOTAUserMsg_TE_UnitAnimationEnd>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_TE\_UnitAnimationEnd](Divine.Protobufs.Dota2.CDOTAUserMsg\_TE\_UnitAnimationEnd.md)

#### Implements

IMessage<CDOTAUserMsg\_TE\_UnitAnimationEnd\>, 
[IEquatable<CDOTAUserMsg\_TE\_UnitAnimationEnd\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_TE\_UnitAnimationEnd\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_TE\_UnitAnimationEnd\>\(CDOTAUserMsg\_TE\_UnitAnimationEnd, params CDOTAUserMsg\_TE\_UnitAnimationEnd\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimationEnd__ctor"></a> CDOTAUserMsg\_TE\_UnitAnimationEnd\(\)

```csharp
public CDOTAUserMsg_TE_UnitAnimationEnd()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimationEnd__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimationEnd_"></a> CDOTAUserMsg\_TE\_UnitAnimationEnd\(CDOTAUserMsg\_TE\_UnitAnimationEnd\)

```csharp
public CDOTAUserMsg_TE_UnitAnimationEnd(CDOTAUserMsg_TE_UnitAnimationEnd other)
```

#### Parameters

`other` [CDOTAUserMsg\_TE\_UnitAnimationEnd](Divine.Protobufs.Dota2.CDOTAUserMsg\_TE\_UnitAnimationEnd.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimationEnd_EntityFieldNumber"></a> EntityFieldNumber

```csharp
public const int EntityFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimationEnd_SnapFieldNumber"></a> SnapFieldNumber

```csharp
public const int SnapFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimationEnd_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimationEnd_Entity"></a> Entity

```csharp
public uint Entity { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimationEnd_HasEntity"></a> HasEntity

```csharp
public bool HasEntity { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimationEnd_HasSnap"></a> HasSnap

```csharp
public bool HasSnap { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimationEnd_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_TE_UnitAnimationEnd> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_TE\_UnitAnimationEnd](Divine.Protobufs.Dota2.CDOTAUserMsg\_TE\_UnitAnimationEnd.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimationEnd_Snap"></a> Snap

```csharp
public bool Snap { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimationEnd_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimationEnd_ClearEntity"></a> ClearEntity\(\)

```csharp
public void ClearEntity()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimationEnd_ClearSnap"></a> ClearSnap\(\)

```csharp
public void ClearSnap()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimationEnd_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_TE_UnitAnimationEnd Clone()
```

#### Returns

 [CDOTAUserMsg\_TE\_UnitAnimationEnd](Divine.Protobufs.Dota2.CDOTAUserMsg\_TE\_UnitAnimationEnd.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimationEnd_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimationEnd_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimationEnd_"></a> Equals\(CDOTAUserMsg\_TE\_UnitAnimationEnd\)

```csharp
public bool Equals(CDOTAUserMsg_TE_UnitAnimationEnd other)
```

#### Parameters

`other` [CDOTAUserMsg\_TE\_UnitAnimationEnd](Divine.Protobufs.Dota2.CDOTAUserMsg\_TE\_UnitAnimationEnd.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimationEnd_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimationEnd_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimationEnd_"></a> MergeFrom\(CDOTAUserMsg\_TE\_UnitAnimationEnd\)

```csharp
public void MergeFrom(CDOTAUserMsg_TE_UnitAnimationEnd other)
```

#### Parameters

`other` [CDOTAUserMsg\_TE\_UnitAnimationEnd](Divine.Protobufs.Dota2.CDOTAUserMsg\_TE\_UnitAnimationEnd.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimationEnd_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimationEnd_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_UnitAnimationEnd_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

