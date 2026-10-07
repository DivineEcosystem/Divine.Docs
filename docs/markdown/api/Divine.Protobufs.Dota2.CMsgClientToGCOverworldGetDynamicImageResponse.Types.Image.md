# <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImageResponse_Types_Image"></a> Class CMsgClientToGCOverworldGetDynamicImageResponse.Types.Image

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCOverworldGetDynamicImageResponse.Types.Image : IMessage<CMsgClientToGCOverworldGetDynamicImageResponse.Types.Image>, IEquatable<CMsgClientToGCOverworldGetDynamicImageResponse.Types.Image>, IDeepCloneable<CMsgClientToGCOverworldGetDynamicImageResponse.Types.Image>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCOverworldGetDynamicImageResponse.Types.Image](Divine.Protobufs.Dota2.CMsgClientToGCOverworldGetDynamicImageResponse.Types.Image.md)

#### Implements

IMessage<CMsgClientToGCOverworldGetDynamicImageResponse.Types.Image\>, 
[IEquatable<CMsgClientToGCOverworldGetDynamicImageResponse.Types.Image\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCOverworldGetDynamicImageResponse.Types.Image\>, 
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
[EnumerableExtensions.In<CMsgClientToGCOverworldGetDynamicImageResponse.Types.Image\>\(CMsgClientToGCOverworldGetDynamicImageResponse.Types.Image, params CMsgClientToGCOverworldGetDynamicImageResponse.Types.Image\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImageResponse_Types_Image__ctor"></a> Image\(\)

```csharp
public Image()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImageResponse_Types_Image__ctor_Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImageResponse_Types_Image_"></a> Image\(Image\)

```csharp
public Image(CMsgClientToGCOverworldGetDynamicImageResponse.Types.Image other)
```

#### Parameters

`other` [CMsgClientToGCOverworldGetDynamicImageResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldGetDynamicImageResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCOverworldGetDynamicImageResponse.Types.md).[Image](Divine.Protobufs.Dota2.CMsgClientToGCOverworldGetDynamicImageResponse.Types.Image.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImageResponse_Types_Image_FormatFieldNumber"></a> FormatFieldNumber

```csharp
public const int FormatFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImageResponse_Types_Image_HeightFieldNumber"></a> HeightFieldNumber

```csharp
public const int HeightFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImageResponse_Types_Image_ImageBytesFieldNumber"></a> ImageBytesFieldNumber

```csharp
public const int ImageBytesFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImageResponse_Types_Image_WidthFieldNumber"></a> WidthFieldNumber

```csharp
public const int WidthFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImageResponse_Types_Image_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImageResponse_Types_Image_Format"></a> Format

```csharp
public CMsgClientToGCOverworldGetDynamicImageResponse.Types.EDynamicImageFormat Format { get; set; }
```

#### Property Value

 [CMsgClientToGCOverworldGetDynamicImageResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldGetDynamicImageResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCOverworldGetDynamicImageResponse.Types.md).[EDynamicImageFormat](Divine.Protobufs.Dota2.CMsgClientToGCOverworldGetDynamicImageResponse.Types.EDynamicImageFormat.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImageResponse_Types_Image_HasFormat"></a> HasFormat

```csharp
public bool HasFormat { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImageResponse_Types_Image_HasHeight"></a> HasHeight

```csharp
public bool HasHeight { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImageResponse_Types_Image_HasImageBytes"></a> HasImageBytes

```csharp
public bool HasImageBytes { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImageResponse_Types_Image_HasWidth"></a> HasWidth

```csharp
public bool HasWidth { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImageResponse_Types_Image_Height"></a> Height

```csharp
public uint Height { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImageResponse_Types_Image_ImageBytes"></a> ImageBytes

```csharp
public ByteString ImageBytes { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImageResponse_Types_Image_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCOverworldGetDynamicImageResponse.Types.Image> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCOverworldGetDynamicImageResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldGetDynamicImageResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCOverworldGetDynamicImageResponse.Types.md).[Image](Divine.Protobufs.Dota2.CMsgClientToGCOverworldGetDynamicImageResponse.Types.Image.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImageResponse_Types_Image_Width"></a> Width

```csharp
public uint Width { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImageResponse_Types_Image_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImageResponse_Types_Image_ClearFormat"></a> ClearFormat\(\)

```csharp
public void ClearFormat()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImageResponse_Types_Image_ClearHeight"></a> ClearHeight\(\)

```csharp
public void ClearHeight()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImageResponse_Types_Image_ClearImageBytes"></a> ClearImageBytes\(\)

```csharp
public void ClearImageBytes()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImageResponse_Types_Image_ClearWidth"></a> ClearWidth\(\)

```csharp
public void ClearWidth()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImageResponse_Types_Image_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCOverworldGetDynamicImageResponse.Types.Image Clone()
```

#### Returns

 [CMsgClientToGCOverworldGetDynamicImageResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldGetDynamicImageResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCOverworldGetDynamicImageResponse.Types.md).[Image](Divine.Protobufs.Dota2.CMsgClientToGCOverworldGetDynamicImageResponse.Types.Image.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImageResponse_Types_Image_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImageResponse_Types_Image_Equals_Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImageResponse_Types_Image_"></a> Equals\(Image\)

```csharp
public bool Equals(CMsgClientToGCOverworldGetDynamicImageResponse.Types.Image other)
```

#### Parameters

`other` [CMsgClientToGCOverworldGetDynamicImageResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldGetDynamicImageResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCOverworldGetDynamicImageResponse.Types.md).[Image](Divine.Protobufs.Dota2.CMsgClientToGCOverworldGetDynamicImageResponse.Types.Image.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImageResponse_Types_Image_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImageResponse_Types_Image_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImageResponse_Types_Image_"></a> MergeFrom\(Image\)

```csharp
public void MergeFrom(CMsgClientToGCOverworldGetDynamicImageResponse.Types.Image other)
```

#### Parameters

`other` [CMsgClientToGCOverworldGetDynamicImageResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldGetDynamicImageResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCOverworldGetDynamicImageResponse.Types.md).[Image](Divine.Protobufs.Dota2.CMsgClientToGCOverworldGetDynamicImageResponse.Types.Image.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImageResponse_Types_Image_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImageResponse_Types_Image_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImageResponse_Types_Image_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

