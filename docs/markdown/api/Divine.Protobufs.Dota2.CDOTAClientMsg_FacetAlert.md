# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_FacetAlert"></a> Class CDOTAClientMsg\_FacetAlert

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_FacetAlert : IMessage<CDOTAClientMsg_FacetAlert>, IEquatable<CDOTAClientMsg_FacetAlert>, IDeepCloneable<CDOTAClientMsg_FacetAlert>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_FacetAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_FacetAlert.md)

#### Implements

IMessage<CDOTAClientMsg\_FacetAlert\>, 
[IEquatable<CDOTAClientMsg\_FacetAlert\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_FacetAlert\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_FacetAlert\>\(CDOTAClientMsg\_FacetAlert, params CDOTAClientMsg\_FacetAlert\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_FacetAlert__ctor"></a> CDOTAClientMsg\_FacetAlert\(\)

```csharp
public CDOTAClientMsg_FacetAlert()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_FacetAlert__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_FacetAlert_"></a> CDOTAClientMsg\_FacetAlert\(CDOTAClientMsg\_FacetAlert\)

```csharp
public CDOTAClientMsg_FacetAlert(CDOTAClientMsg_FacetAlert other)
```

#### Parameters

`other` [CDOTAClientMsg\_FacetAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_FacetAlert.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_FacetAlert_CtrlHeldFieldNumber"></a> CtrlHeldFieldNumber

```csharp
public const int CtrlHeldFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_FacetAlert_FacetStrhashFieldNumber"></a> FacetStrhashFieldNumber

```csharp
public const int FacetStrhashFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_FacetAlert_HeroEntindexFieldNumber"></a> HeroEntindexFieldNumber

```csharp
public const int HeroEntindexFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_FacetAlert_CtrlHeld"></a> CtrlHeld

```csharp
public bool CtrlHeld { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_FacetAlert_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_FacetAlert_FacetStrhash"></a> FacetStrhash

```csharp
public uint FacetStrhash { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_FacetAlert_HasCtrlHeld"></a> HasCtrlHeld

```csharp
public bool HasCtrlHeld { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_FacetAlert_HasFacetStrhash"></a> HasFacetStrhash

```csharp
public bool HasFacetStrhash { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_FacetAlert_HasHeroEntindex"></a> HasHeroEntindex

```csharp
public bool HasHeroEntindex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_FacetAlert_HeroEntindex"></a> HeroEntindex

```csharp
public uint HeroEntindex { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_FacetAlert_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_FacetAlert> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_FacetAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_FacetAlert.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_FacetAlert_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_FacetAlert_ClearCtrlHeld"></a> ClearCtrlHeld\(\)

```csharp
public void ClearCtrlHeld()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_FacetAlert_ClearFacetStrhash"></a> ClearFacetStrhash\(\)

```csharp
public void ClearFacetStrhash()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_FacetAlert_ClearHeroEntindex"></a> ClearHeroEntindex\(\)

```csharp
public void ClearHeroEntindex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_FacetAlert_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_FacetAlert Clone()
```

#### Returns

 [CDOTAClientMsg\_FacetAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_FacetAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_FacetAlert_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_FacetAlert_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_FacetAlert_"></a> Equals\(CDOTAClientMsg\_FacetAlert\)

```csharp
public bool Equals(CDOTAClientMsg_FacetAlert other)
```

#### Parameters

`other` [CDOTAClientMsg\_FacetAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_FacetAlert.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_FacetAlert_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_FacetAlert_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_FacetAlert_"></a> MergeFrom\(CDOTAClientMsg\_FacetAlert\)

```csharp
public void MergeFrom(CDOTAClientMsg_FacetAlert other)
```

#### Parameters

`other` [CDOTAClientMsg\_FacetAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_FacetAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_FacetAlert_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_FacetAlert_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_FacetAlert_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

