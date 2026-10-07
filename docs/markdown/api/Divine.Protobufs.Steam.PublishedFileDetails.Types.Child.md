# <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Child"></a> Class PublishedFileDetails.Types.Child

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class PublishedFileDetails.Types.Child : IMessage<PublishedFileDetails.Types.Child>, IEquatable<PublishedFileDetails.Types.Child>, IDeepCloneable<PublishedFileDetails.Types.Child>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[PublishedFileDetails.Types.Child](Divine.Protobufs.Steam.PublishedFileDetails.Types.Child.md)

#### Implements

IMessage<PublishedFileDetails.Types.Child\>, 
[IEquatable<PublishedFileDetails.Types.Child\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<PublishedFileDetails.Types.Child\>, 
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
[EnumerableExtensions.In<PublishedFileDetails.Types.Child\>\(PublishedFileDetails.Types.Child, params PublishedFileDetails.Types.Child\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Child__ctor"></a> Child\(\)

```csharp
public Child()
```

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Child__ctor_Divine_Protobufs_Steam_PublishedFileDetails_Types_Child_"></a> Child\(Child\)

```csharp
public Child(PublishedFileDetails.Types.Child other)
```

#### Parameters

`other` [PublishedFileDetails](Divine.Protobufs.Steam.PublishedFileDetails.md).[Types](Divine.Protobufs.Steam.PublishedFileDetails.Types.md).[Child](Divine.Protobufs.Steam.PublishedFileDetails.Types.Child.md)

## Fields

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Child_FileTypeFieldNumber"></a> FileTypeFieldNumber

```csharp
public const int FileTypeFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Child_PublishedfileidFieldNumber"></a> PublishedfileidFieldNumber

```csharp
public const int PublishedfileidFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Child_SortorderFieldNumber"></a> SortorderFieldNumber

```csharp
public const int SortorderFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Child_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Child_FileType"></a> FileType

```csharp
public uint FileType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Child_HasFileType"></a> HasFileType

```csharp
public bool HasFileType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Child_HasPublishedfileid"></a> HasPublishedfileid

```csharp
public bool HasPublishedfileid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Child_HasSortorder"></a> HasSortorder

```csharp
public bool HasSortorder { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Child_Parser"></a> Parser

```csharp
public static MessageParser<PublishedFileDetails.Types.Child> Parser { get; }
```

#### Property Value

 MessageParser<[PublishedFileDetails](Divine.Protobufs.Steam.PublishedFileDetails.md).[Types](Divine.Protobufs.Steam.PublishedFileDetails.Types.md).[Child](Divine.Protobufs.Steam.PublishedFileDetails.Types.Child.md)\>

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Child_Publishedfileid"></a> Publishedfileid

```csharp
public ulong Publishedfileid { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Child_Sortorder"></a> Sortorder

```csharp
public uint Sortorder { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Child_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Child_ClearFileType"></a> ClearFileType\(\)

```csharp
public void ClearFileType()
```

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Child_ClearPublishedfileid"></a> ClearPublishedfileid\(\)

```csharp
public void ClearPublishedfileid()
```

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Child_ClearSortorder"></a> ClearSortorder\(\)

```csharp
public void ClearSortorder()
```

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Child_Clone"></a> Clone\(\)

```csharp
public PublishedFileDetails.Types.Child Clone()
```

#### Returns

 [PublishedFileDetails](Divine.Protobufs.Steam.PublishedFileDetails.md).[Types](Divine.Protobufs.Steam.PublishedFileDetails.Types.md).[Child](Divine.Protobufs.Steam.PublishedFileDetails.Types.Child.md)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Child_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Child_Equals_Divine_Protobufs_Steam_PublishedFileDetails_Types_Child_"></a> Equals\(Child\)

```csharp
public bool Equals(PublishedFileDetails.Types.Child other)
```

#### Parameters

`other` [PublishedFileDetails](Divine.Protobufs.Steam.PublishedFileDetails.md).[Types](Divine.Protobufs.Steam.PublishedFileDetails.Types.md).[Child](Divine.Protobufs.Steam.PublishedFileDetails.Types.Child.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Child_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Child_MergeFrom_Divine_Protobufs_Steam_PublishedFileDetails_Types_Child_"></a> MergeFrom\(Child\)

```csharp
public void MergeFrom(PublishedFileDetails.Types.Child other)
```

#### Parameters

`other` [PublishedFileDetails](Divine.Protobufs.Steam.PublishedFileDetails.md).[Types](Divine.Protobufs.Steam.PublishedFileDetails.Types.md).[Child](Divine.Protobufs.Steam.PublishedFileDetails.Types.Child.md)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Child_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Child_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_Child_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

