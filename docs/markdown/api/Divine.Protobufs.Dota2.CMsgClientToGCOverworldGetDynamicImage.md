# <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImage"></a> Class CMsgClientToGCOverworldGetDynamicImage

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCOverworldGetDynamicImage : IMessage<CMsgClientToGCOverworldGetDynamicImage>, IEquatable<CMsgClientToGCOverworldGetDynamicImage>, IDeepCloneable<CMsgClientToGCOverworldGetDynamicImage>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCOverworldGetDynamicImage](Divine.Protobufs.Dota2.CMsgClientToGCOverworldGetDynamicImage.md)

#### Implements

IMessage<CMsgClientToGCOverworldGetDynamicImage\>, 
[IEquatable<CMsgClientToGCOverworldGetDynamicImage\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCOverworldGetDynamicImage\>, 
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
[EnumerableExtensions.In<CMsgClientToGCOverworldGetDynamicImage\>\(CMsgClientToGCOverworldGetDynamicImage, params CMsgClientToGCOverworldGetDynamicImage\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImage__ctor"></a> CMsgClientToGCOverworldGetDynamicImage\(\)

```csharp
public CMsgClientToGCOverworldGetDynamicImage()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImage__ctor_Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImage_"></a> CMsgClientToGCOverworldGetDynamicImage\(CMsgClientToGCOverworldGetDynamicImage\)

```csharp
public CMsgClientToGCOverworldGetDynamicImage(CMsgClientToGCOverworldGetDynamicImage other)
```

#### Parameters

`other` [CMsgClientToGCOverworldGetDynamicImage](Divine.Protobufs.Dota2.CMsgClientToGCOverworldGetDynamicImage.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImage_ImageIdFieldNumber"></a> ImageIdFieldNumber

```csharp
public const int ImageIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImage_LanguageFieldNumber"></a> LanguageFieldNumber

```csharp
public const int LanguageFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImage_MagicFieldNumber"></a> MagicFieldNumber

```csharp
public const int MagicFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImage_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImage_HasImageId"></a> HasImageId

```csharp
public bool HasImageId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImage_HasLanguage"></a> HasLanguage

```csharp
public bool HasLanguage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImage_HasMagic"></a> HasMagic

```csharp
public bool HasMagic { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImage_ImageId"></a> ImageId

```csharp
public uint ImageId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImage_Language"></a> Language

```csharp
public uint Language { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImage_Magic"></a> Magic

```csharp
public uint Magic { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImage_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCOverworldGetDynamicImage> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCOverworldGetDynamicImage](Divine.Protobufs.Dota2.CMsgClientToGCOverworldGetDynamicImage.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImage_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImage_ClearImageId"></a> ClearImageId\(\)

```csharp
public void ClearImageId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImage_ClearLanguage"></a> ClearLanguage\(\)

```csharp
public void ClearLanguage()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImage_ClearMagic"></a> ClearMagic\(\)

```csharp
public void ClearMagic()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImage_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCOverworldGetDynamicImage Clone()
```

#### Returns

 [CMsgClientToGCOverworldGetDynamicImage](Divine.Protobufs.Dota2.CMsgClientToGCOverworldGetDynamicImage.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImage_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImage_Equals_Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImage_"></a> Equals\(CMsgClientToGCOverworldGetDynamicImage\)

```csharp
public bool Equals(CMsgClientToGCOverworldGetDynamicImage other)
```

#### Parameters

`other` [CMsgClientToGCOverworldGetDynamicImage](Divine.Protobufs.Dota2.CMsgClientToGCOverworldGetDynamicImage.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImage_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImage_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImage_"></a> MergeFrom\(CMsgClientToGCOverworldGetDynamicImage\)

```csharp
public void MergeFrom(CMsgClientToGCOverworldGetDynamicImage other)
```

#### Parameters

`other` [CMsgClientToGCOverworldGetDynamicImage](Divine.Protobufs.Dota2.CMsgClientToGCOverworldGetDynamicImage.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImage_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImage_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImage_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

