# <a id="Divine_Protobufs_Dota2_CUIFontFilePackagePB"></a> Class CUIFontFilePackagePB

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUIFontFilePackagePB : IMessage<CUIFontFilePackagePB>, IEquatable<CUIFontFilePackagePB>, IDeepCloneable<CUIFontFilePackagePB>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUIFontFilePackagePB](Divine.Protobufs.Dota2.CUIFontFilePackagePB.md)

#### Implements

IMessage<CUIFontFilePackagePB\>, 
[IEquatable<CUIFontFilePackagePB\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUIFontFilePackagePB\>, 
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
[EnumerableExtensions.In<CUIFontFilePackagePB\>\(CUIFontFilePackagePB, params CUIFontFilePackagePB\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUIFontFilePackagePB__ctor"></a> CUIFontFilePackagePB\(\)

```csharp
public CUIFontFilePackagePB()
```

### <a id="Divine_Protobufs_Dota2_CUIFontFilePackagePB__ctor_Divine_Protobufs_Dota2_CUIFontFilePackagePB_"></a> CUIFontFilePackagePB\(CUIFontFilePackagePB\)

```csharp
public CUIFontFilePackagePB(CUIFontFilePackagePB other)
```

#### Parameters

`other` [CUIFontFilePackagePB](Divine.Protobufs.Dota2.CUIFontFilePackagePB.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUIFontFilePackagePB_EncryptedFontFilesFieldNumber"></a> EncryptedFontFilesFieldNumber

```csharp
public const int EncryptedFontFilesFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUIFontFilePackagePB_PackageVersionFieldNumber"></a> PackageVersionFieldNumber

```csharp
public const int PackageVersionFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUIFontFilePackagePB_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUIFontFilePackagePB_EncryptedFontFiles"></a> EncryptedFontFiles

```csharp
public RepeatedField<CUIFontFilePackagePB.Types.CUIEncryptedFontFilePB> EncryptedFontFiles { get; }
```

#### Property Value

 RepeatedField<[CUIFontFilePackagePB](Divine.Protobufs.Dota2.CUIFontFilePackagePB.md).[Types](Divine.Protobufs.Dota2.CUIFontFilePackagePB.Types.md).[CUIEncryptedFontFilePB](Divine.Protobufs.Dota2.CUIFontFilePackagePB.Types.CUIEncryptedFontFilePB.md)\>

### <a id="Divine_Protobufs_Dota2_CUIFontFilePackagePB_HasPackageVersion"></a> HasPackageVersion

```csharp
public bool HasPackageVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUIFontFilePackagePB_PackageVersion"></a> PackageVersion

```csharp
public uint PackageVersion { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CUIFontFilePackagePB_Parser"></a> Parser

```csharp
public static MessageParser<CUIFontFilePackagePB> Parser { get; }
```

#### Property Value

 MessageParser<[CUIFontFilePackagePB](Divine.Protobufs.Dota2.CUIFontFilePackagePB.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CUIFontFilePackagePB_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUIFontFilePackagePB_ClearPackageVersion"></a> ClearPackageVersion\(\)

```csharp
public void ClearPackageVersion()
```

### <a id="Divine_Protobufs_Dota2_CUIFontFilePackagePB_Clone"></a> Clone\(\)

```csharp
public CUIFontFilePackagePB Clone()
```

#### Returns

 [CUIFontFilePackagePB](Divine.Protobufs.Dota2.CUIFontFilePackagePB.md)

### <a id="Divine_Protobufs_Dota2_CUIFontFilePackagePB_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUIFontFilePackagePB_Equals_Divine_Protobufs_Dota2_CUIFontFilePackagePB_"></a> Equals\(CUIFontFilePackagePB\)

```csharp
public bool Equals(CUIFontFilePackagePB other)
```

#### Parameters

`other` [CUIFontFilePackagePB](Divine.Protobufs.Dota2.CUIFontFilePackagePB.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUIFontFilePackagePB_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUIFontFilePackagePB_MergeFrom_Divine_Protobufs_Dota2_CUIFontFilePackagePB_"></a> MergeFrom\(CUIFontFilePackagePB\)

```csharp
public void MergeFrom(CUIFontFilePackagePB other)
```

#### Parameters

`other` [CUIFontFilePackagePB](Divine.Protobufs.Dota2.CUIFontFilePackagePB.md)

### <a id="Divine_Protobufs_Dota2_CUIFontFilePackagePB_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUIFontFilePackagePB_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUIFontFilePackagePB_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

