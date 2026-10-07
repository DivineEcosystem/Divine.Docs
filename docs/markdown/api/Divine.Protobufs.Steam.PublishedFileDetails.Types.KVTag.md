# <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_KVTag"></a> Class PublishedFileDetails.Types.KVTag

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class PublishedFileDetails.Types.KVTag : IMessage<PublishedFileDetails.Types.KVTag>, IEquatable<PublishedFileDetails.Types.KVTag>, IDeepCloneable<PublishedFileDetails.Types.KVTag>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[PublishedFileDetails.Types.KVTag](Divine.Protobufs.Steam.PublishedFileDetails.Types.KVTag.md)

#### Implements

IMessage<PublishedFileDetails.Types.KVTag\>, 
[IEquatable<PublishedFileDetails.Types.KVTag\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<PublishedFileDetails.Types.KVTag\>, 
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
[EnumerableExtensions.In<PublishedFileDetails.Types.KVTag\>\(PublishedFileDetails.Types.KVTag, params PublishedFileDetails.Types.KVTag\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_KVTag__ctor"></a> KVTag\(\)

```csharp
public KVTag()
```

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_KVTag__ctor_Divine_Protobufs_Steam_PublishedFileDetails_Types_KVTag_"></a> KVTag\(KVTag\)

```csharp
public KVTag(PublishedFileDetails.Types.KVTag other)
```

#### Parameters

`other` [PublishedFileDetails](Divine.Protobufs.Steam.PublishedFileDetails.md).[Types](Divine.Protobufs.Steam.PublishedFileDetails.Types.md).[KVTag](Divine.Protobufs.Steam.PublishedFileDetails.Types.KVTag.md)

## Fields

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_KVTag_KeyFieldNumber"></a> KeyFieldNumber

```csharp
public const int KeyFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_KVTag_ValueFieldNumber"></a> ValueFieldNumber

```csharp
public const int ValueFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_KVTag_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_KVTag_HasKey"></a> HasKey

```csharp
public bool HasKey { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_KVTag_HasValue"></a> HasValue

```csharp
public bool HasValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_KVTag_Key"></a> Key

```csharp
public string Key { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_KVTag_Parser"></a> Parser

```csharp
public static MessageParser<PublishedFileDetails.Types.KVTag> Parser { get; }
```

#### Property Value

 MessageParser<[PublishedFileDetails](Divine.Protobufs.Steam.PublishedFileDetails.md).[Types](Divine.Protobufs.Steam.PublishedFileDetails.Types.md).[KVTag](Divine.Protobufs.Steam.PublishedFileDetails.Types.KVTag.md)\>

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_KVTag_Value"></a> Value

```csharp
public string Value { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_KVTag_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_KVTag_ClearKey"></a> ClearKey\(\)

```csharp
public void ClearKey()
```

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_KVTag_ClearValue"></a> ClearValue\(\)

```csharp
public void ClearValue()
```

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_KVTag_Clone"></a> Clone\(\)

```csharp
public PublishedFileDetails.Types.KVTag Clone()
```

#### Returns

 [PublishedFileDetails](Divine.Protobufs.Steam.PublishedFileDetails.md).[Types](Divine.Protobufs.Steam.PublishedFileDetails.Types.md).[KVTag](Divine.Protobufs.Steam.PublishedFileDetails.Types.KVTag.md)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_KVTag_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_KVTag_Equals_Divine_Protobufs_Steam_PublishedFileDetails_Types_KVTag_"></a> Equals\(KVTag\)

```csharp
public bool Equals(PublishedFileDetails.Types.KVTag other)
```

#### Parameters

`other` [PublishedFileDetails](Divine.Protobufs.Steam.PublishedFileDetails.md).[Types](Divine.Protobufs.Steam.PublishedFileDetails.Types.md).[KVTag](Divine.Protobufs.Steam.PublishedFileDetails.Types.KVTag.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_KVTag_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_KVTag_MergeFrom_Divine_Protobufs_Steam_PublishedFileDetails_Types_KVTag_"></a> MergeFrom\(KVTag\)

```csharp
public void MergeFrom(PublishedFileDetails.Types.KVTag other)
```

#### Parameters

`other` [PublishedFileDetails](Divine.Protobufs.Steam.PublishedFileDetails.md).[Types](Divine.Protobufs.Steam.PublishedFileDetails.Types.md).[KVTag](Divine.Protobufs.Steam.PublishedFileDetails.Types.KVTag.md)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_KVTag_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_KVTag_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_KVTag_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

