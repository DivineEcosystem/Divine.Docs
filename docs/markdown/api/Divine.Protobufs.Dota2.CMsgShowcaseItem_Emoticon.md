# <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Emoticon"></a> Class CMsgShowcaseItem\_Emoticon

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgShowcaseItem_Emoticon : IMessage<CMsgShowcaseItem_Emoticon>, IEquatable<CMsgShowcaseItem_Emoticon>, IDeepCloneable<CMsgShowcaseItem_Emoticon>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgShowcaseItem\_Emoticon](Divine.Protobufs.Dota2.CMsgShowcaseItem\_Emoticon.md)

#### Implements

IMessage<CMsgShowcaseItem\_Emoticon\>, 
[IEquatable<CMsgShowcaseItem\_Emoticon\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgShowcaseItem\_Emoticon\>, 
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
[EnumerableExtensions.In<CMsgShowcaseItem\_Emoticon\>\(CMsgShowcaseItem\_Emoticon, params CMsgShowcaseItem\_Emoticon\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Emoticon__ctor"></a> CMsgShowcaseItem\_Emoticon\(\)

```csharp
public CMsgShowcaseItem_Emoticon()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Emoticon__ctor_Divine_Protobufs_Dota2_CMsgShowcaseItem_Emoticon_"></a> CMsgShowcaseItem\_Emoticon\(CMsgShowcaseItem\_Emoticon\)

```csharp
public CMsgShowcaseItem_Emoticon(CMsgShowcaseItem_Emoticon other)
```

#### Parameters

`other` [CMsgShowcaseItem\_Emoticon](Divine.Protobufs.Dota2.CMsgShowcaseItem\_Emoticon.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Emoticon_DataFieldNumber"></a> DataFieldNumber

```csharp
public const int DataFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Emoticon_EmoticonIdFieldNumber"></a> EmoticonIdFieldNumber

```csharp
public const int EmoticonIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Emoticon_Data"></a> Data

```csharp
public CMsgShowcaseItem_Emoticon.Types.Data Data { get; set; }
```

#### Property Value

 [CMsgShowcaseItem\_Emoticon](Divine.Protobufs.Dota2.CMsgShowcaseItem\_Emoticon.md).[Types](Divine.Protobufs.Dota2.CMsgShowcaseItem\_Emoticon.Types.md).[Data](Divine.Protobufs.Dota2.CMsgShowcaseItem\_Emoticon.Types.Data.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Emoticon_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Emoticon_EmoticonId"></a> EmoticonId

```csharp
public uint EmoticonId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Emoticon_HasEmoticonId"></a> HasEmoticonId

```csharp
public bool HasEmoticonId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Emoticon_Parser"></a> Parser

```csharp
public static MessageParser<CMsgShowcaseItem_Emoticon> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgShowcaseItem\_Emoticon](Divine.Protobufs.Dota2.CMsgShowcaseItem\_Emoticon.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Emoticon_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Emoticon_ClearEmoticonId"></a> ClearEmoticonId\(\)

```csharp
public void ClearEmoticonId()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Emoticon_Clone"></a> Clone\(\)

```csharp
public CMsgShowcaseItem_Emoticon Clone()
```

#### Returns

 [CMsgShowcaseItem\_Emoticon](Divine.Protobufs.Dota2.CMsgShowcaseItem\_Emoticon.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Emoticon_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Emoticon_Equals_Divine_Protobufs_Dota2_CMsgShowcaseItem_Emoticon_"></a> Equals\(CMsgShowcaseItem\_Emoticon\)

```csharp
public bool Equals(CMsgShowcaseItem_Emoticon other)
```

#### Parameters

`other` [CMsgShowcaseItem\_Emoticon](Divine.Protobufs.Dota2.CMsgShowcaseItem\_Emoticon.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Emoticon_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Emoticon_MergeFrom_Divine_Protobufs_Dota2_CMsgShowcaseItem_Emoticon_"></a> MergeFrom\(CMsgShowcaseItem\_Emoticon\)

```csharp
public void MergeFrom(CMsgShowcaseItem_Emoticon other)
```

#### Parameters

`other` [CMsgShowcaseItem\_Emoticon](Divine.Protobufs.Dota2.CMsgShowcaseItem\_Emoticon.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Emoticon_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Emoticon_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Emoticon_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

