# <a id="Divine_Protobufs_Dota2_CMsgTEWorldDecal"></a> Class CMsgTEWorldDecal

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgTEWorldDecal : IMessage<CMsgTEWorldDecal>, IEquatable<CMsgTEWorldDecal>, IDeepCloneable<CMsgTEWorldDecal>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgTEWorldDecal](Divine.Protobufs.Dota2.CMsgTEWorldDecal.md)

#### Implements

IMessage<CMsgTEWorldDecal\>, 
[IEquatable<CMsgTEWorldDecal\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgTEWorldDecal\>, 
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
[EnumerableExtensions.In<CMsgTEWorldDecal\>\(CMsgTEWorldDecal, params CMsgTEWorldDecal\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgTEWorldDecal__ctor"></a> CMsgTEWorldDecal\(\)

```csharp
public CMsgTEWorldDecal()
```

### <a id="Divine_Protobufs_Dota2_CMsgTEWorldDecal__ctor_Divine_Protobufs_Dota2_CMsgTEWorldDecal_"></a> CMsgTEWorldDecal\(CMsgTEWorldDecal\)

```csharp
public CMsgTEWorldDecal(CMsgTEWorldDecal other)
```

#### Parameters

`other` [CMsgTEWorldDecal](Divine.Protobufs.Dota2.CMsgTEWorldDecal.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgTEWorldDecal_IndexFieldNumber"></a> IndexFieldNumber

```csharp
public const int IndexFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEWorldDecal_NormalFieldNumber"></a> NormalFieldNumber

```csharp
public const int NormalFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEWorldDecal_OriginFieldNumber"></a> OriginFieldNumber

```csharp
public const int OriginFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgTEWorldDecal_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgTEWorldDecal_HasIndex"></a> HasIndex

```csharp
public bool HasIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEWorldDecal_Index"></a> Index

```csharp
public uint Index { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgTEWorldDecal_Normal"></a> Normal

```csharp
public CMsgVector Normal { get; set; }
```

#### Property Value

 [CMsgVector](Divine.Protobufs.Dota2.CMsgVector.md)

### <a id="Divine_Protobufs_Dota2_CMsgTEWorldDecal_Origin"></a> Origin

```csharp
public CMsgVector Origin { get; set; }
```

#### Property Value

 [CMsgVector](Divine.Protobufs.Dota2.CMsgVector.md)

### <a id="Divine_Protobufs_Dota2_CMsgTEWorldDecal_Parser"></a> Parser

```csharp
public static MessageParser<CMsgTEWorldDecal> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgTEWorldDecal](Divine.Protobufs.Dota2.CMsgTEWorldDecal.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgTEWorldDecal_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEWorldDecal_ClearIndex"></a> ClearIndex\(\)

```csharp
public void ClearIndex()
```

### <a id="Divine_Protobufs_Dota2_CMsgTEWorldDecal_Clone"></a> Clone\(\)

```csharp
public CMsgTEWorldDecal Clone()
```

#### Returns

 [CMsgTEWorldDecal](Divine.Protobufs.Dota2.CMsgTEWorldDecal.md)

### <a id="Divine_Protobufs_Dota2_CMsgTEWorldDecal_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEWorldDecal_Equals_Divine_Protobufs_Dota2_CMsgTEWorldDecal_"></a> Equals\(CMsgTEWorldDecal\)

```csharp
public bool Equals(CMsgTEWorldDecal other)
```

#### Parameters

`other` [CMsgTEWorldDecal](Divine.Protobufs.Dota2.CMsgTEWorldDecal.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEWorldDecal_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEWorldDecal_MergeFrom_Divine_Protobufs_Dota2_CMsgTEWorldDecal_"></a> MergeFrom\(CMsgTEWorldDecal\)

```csharp
public void MergeFrom(CMsgTEWorldDecal other)
```

#### Parameters

`other` [CMsgTEWorldDecal](Divine.Protobufs.Dota2.CMsgTEWorldDecal.md)

### <a id="Divine_Protobufs_Dota2_CMsgTEWorldDecal_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgTEWorldDecal_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgTEWorldDecal_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

