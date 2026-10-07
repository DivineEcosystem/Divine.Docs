# <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Tag"></a> Class PublishedFileDetails.Types.Tag

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class PublishedFileDetails.Types.Tag : IMessage<PublishedFileDetails.Types.Tag>, IEquatable<PublishedFileDetails.Types.Tag>, IDeepCloneable<PublishedFileDetails.Types.Tag>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[PublishedFileDetails.Types.Tag](Divine.Protobufs.Steam.PublishedFileDetails.Types.Tag.md)

#### Implements

IMessage<PublishedFileDetails.Types.Tag\>, 
[IEquatable<PublishedFileDetails.Types.Tag\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<PublishedFileDetails.Types.Tag\>, 
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
[EnumerableExtensions.In<PublishedFileDetails.Types.Tag\>\(PublishedFileDetails.Types.Tag, params PublishedFileDetails.Types.Tag\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Tag__ctor"></a> Tag\(\)

```csharp
public Tag()
```

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Tag__ctor_Divine_Protobufs_Steam_PublishedFileDetails_Types_Tag_"></a> Tag\(Tag\)

```csharp
public Tag(PublishedFileDetails.Types.Tag other)
```

#### Parameters

`other` [PublishedFileDetails](Divine.Protobufs.Steam.PublishedFileDetails.md).[Types](Divine.Protobufs.Steam.PublishedFileDetails.Types.md).[Tag](Divine.Protobufs.Steam.PublishedFileDetails.Types.Tag.md)

## Fields

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Tag_AdminonlyFieldNumber"></a> AdminonlyFieldNumber

```csharp
public const int AdminonlyFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Tag_Tag_FieldNumber"></a> Tag\_FieldNumber

```csharp
public const int Tag_FieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Tag_Adminonly"></a> Adminonly

```csharp
public bool Adminonly { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Tag_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Tag_HasAdminonly"></a> HasAdminonly

```csharp
public bool HasAdminonly { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Tag_HasTag_"></a> HasTag\_

```csharp
public bool HasTag_ { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Tag_Parser"></a> Parser

```csharp
public static MessageParser<PublishedFileDetails.Types.Tag> Parser { get; }
```

#### Property Value

 MessageParser<[PublishedFileDetails](Divine.Protobufs.Steam.PublishedFileDetails.md).[Types](Divine.Protobufs.Steam.PublishedFileDetails.Types.md).[Tag](Divine.Protobufs.Steam.PublishedFileDetails.Types.Tag.md)\>

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Tag_Tag_"></a> Tag\_

```csharp
public string Tag_ { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Tag_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Tag_ClearAdminonly"></a> ClearAdminonly\(\)

```csharp
public void ClearAdminonly()
```

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Tag_ClearTag_"></a> ClearTag\_\(\)

```csharp
public void ClearTag_()
```

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Tag_Clone"></a> Clone\(\)

```csharp
public PublishedFileDetails.Types.Tag Clone()
```

#### Returns

 [PublishedFileDetails](Divine.Protobufs.Steam.PublishedFileDetails.md).[Types](Divine.Protobufs.Steam.PublishedFileDetails.Types.md).[Tag](Divine.Protobufs.Steam.PublishedFileDetails.Types.Tag.md)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Tag_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Tag_Equals_Divine_Protobufs_Steam_PublishedFileDetails_Types_Tag_"></a> Equals\(Tag\)

```csharp
public bool Equals(PublishedFileDetails.Types.Tag other)
```

#### Parameters

`other` [PublishedFileDetails](Divine.Protobufs.Steam.PublishedFileDetails.md).[Types](Divine.Protobufs.Steam.PublishedFileDetails.Types.md).[Tag](Divine.Protobufs.Steam.PublishedFileDetails.Types.Tag.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Tag_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Tag_MergeFrom_Divine_Protobufs_Steam_PublishedFileDetails_Types_Tag_"></a> MergeFrom\(Tag\)

```csharp
public void MergeFrom(PublishedFileDetails.Types.Tag other)
```

#### Parameters

`other` [PublishedFileDetails](Divine.Protobufs.Steam.PublishedFileDetails.md).[Types](Divine.Protobufs.Steam.PublishedFileDetails.Types.md).[Tag](Divine.Protobufs.Steam.PublishedFileDetails.Types.Tag.md)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Tag_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Tag_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Tag_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

