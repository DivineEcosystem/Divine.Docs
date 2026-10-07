# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_DotaBloodImpact"></a> Class CDOTAUserMsg\_TE\_DotaBloodImpact

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_TE_DotaBloodImpact : IMessage<CDOTAUserMsg_TE_DotaBloodImpact>, IEquatable<CDOTAUserMsg_TE_DotaBloodImpact>, IDeepCloneable<CDOTAUserMsg_TE_DotaBloodImpact>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_TE\_DotaBloodImpact](Divine.Protobufs.Dota2.CDOTAUserMsg\_TE\_DotaBloodImpact.md)

#### Implements

IMessage<CDOTAUserMsg\_TE\_DotaBloodImpact\>, 
[IEquatable<CDOTAUserMsg\_TE\_DotaBloodImpact\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_TE\_DotaBloodImpact\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_TE\_DotaBloodImpact\>\(CDOTAUserMsg\_TE\_DotaBloodImpact, params CDOTAUserMsg\_TE\_DotaBloodImpact\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_DotaBloodImpact__ctor"></a> CDOTAUserMsg\_TE\_DotaBloodImpact\(\)

```csharp
public CDOTAUserMsg_TE_DotaBloodImpact()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_DotaBloodImpact__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_TE_DotaBloodImpact_"></a> CDOTAUserMsg\_TE\_DotaBloodImpact\(CDOTAUserMsg\_TE\_DotaBloodImpact\)

```csharp
public CDOTAUserMsg_TE_DotaBloodImpact(CDOTAUserMsg_TE_DotaBloodImpact other)
```

#### Parameters

`other` [CDOTAUserMsg\_TE\_DotaBloodImpact](Divine.Protobufs.Dota2.CDOTAUserMsg\_TE\_DotaBloodImpact.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_DotaBloodImpact_EntityFieldNumber"></a> EntityFieldNumber

```csharp
public const int EntityFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_DotaBloodImpact_ScaleFieldNumber"></a> ScaleFieldNumber

```csharp
public const int ScaleFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_DotaBloodImpact_XnormalFieldNumber"></a> XnormalFieldNumber

```csharp
public const int XnormalFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_DotaBloodImpact_YnormalFieldNumber"></a> YnormalFieldNumber

```csharp
public const int YnormalFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_DotaBloodImpact_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_DotaBloodImpact_Entity"></a> Entity

```csharp
public uint Entity { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_DotaBloodImpact_HasEntity"></a> HasEntity

```csharp
public bool HasEntity { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_DotaBloodImpact_HasScale"></a> HasScale

```csharp
public bool HasScale { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_DotaBloodImpact_HasXnormal"></a> HasXnormal

```csharp
public bool HasXnormal { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_DotaBloodImpact_HasYnormal"></a> HasYnormal

```csharp
public bool HasYnormal { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_DotaBloodImpact_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_TE_DotaBloodImpact> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_TE\_DotaBloodImpact](Divine.Protobufs.Dota2.CDOTAUserMsg\_TE\_DotaBloodImpact.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_DotaBloodImpact_Scale"></a> Scale

```csharp
public float Scale { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_DotaBloodImpact_Xnormal"></a> Xnormal

```csharp
public float Xnormal { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_DotaBloodImpact_Ynormal"></a> Ynormal

```csharp
public float Ynormal { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_DotaBloodImpact_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_DotaBloodImpact_ClearEntity"></a> ClearEntity\(\)

```csharp
public void ClearEntity()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_DotaBloodImpact_ClearScale"></a> ClearScale\(\)

```csharp
public void ClearScale()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_DotaBloodImpact_ClearXnormal"></a> ClearXnormal\(\)

```csharp
public void ClearXnormal()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_DotaBloodImpact_ClearYnormal"></a> ClearYnormal\(\)

```csharp
public void ClearYnormal()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_DotaBloodImpact_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_TE_DotaBloodImpact Clone()
```

#### Returns

 [CDOTAUserMsg\_TE\_DotaBloodImpact](Divine.Protobufs.Dota2.CDOTAUserMsg\_TE\_DotaBloodImpact.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_DotaBloodImpact_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_DotaBloodImpact_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_TE_DotaBloodImpact_"></a> Equals\(CDOTAUserMsg\_TE\_DotaBloodImpact\)

```csharp
public bool Equals(CDOTAUserMsg_TE_DotaBloodImpact other)
```

#### Parameters

`other` [CDOTAUserMsg\_TE\_DotaBloodImpact](Divine.Protobufs.Dota2.CDOTAUserMsg\_TE\_DotaBloodImpact.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_DotaBloodImpact_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_DotaBloodImpact_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_TE_DotaBloodImpact_"></a> MergeFrom\(CDOTAUserMsg\_TE\_DotaBloodImpact\)

```csharp
public void MergeFrom(CDOTAUserMsg_TE_DotaBloodImpact other)
```

#### Parameters

`other` [CDOTAUserMsg\_TE\_DotaBloodImpact](Divine.Protobufs.Dota2.CDOTAUserMsg\_TE\_DotaBloodImpact.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_DotaBloodImpact_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_DotaBloodImpact_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_DotaBloodImpact_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

