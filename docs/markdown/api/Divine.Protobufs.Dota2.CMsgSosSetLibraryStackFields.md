# <a id="Divine_Protobufs_Dota2_CMsgSosSetLibraryStackFields"></a> Class CMsgSosSetLibraryStackFields

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSosSetLibraryStackFields : IMessage<CMsgSosSetLibraryStackFields>, IEquatable<CMsgSosSetLibraryStackFields>, IDeepCloneable<CMsgSosSetLibraryStackFields>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSosSetLibraryStackFields](Divine.Protobufs.Dota2.CMsgSosSetLibraryStackFields.md)

#### Implements

IMessage<CMsgSosSetLibraryStackFields\>, 
[IEquatable<CMsgSosSetLibraryStackFields\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSosSetLibraryStackFields\>, 
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
[EnumerableExtensions.In<CMsgSosSetLibraryStackFields\>\(CMsgSosSetLibraryStackFields, params CMsgSosSetLibraryStackFields\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSosSetLibraryStackFields__ctor"></a> CMsgSosSetLibraryStackFields\(\)

```csharp
public CMsgSosSetLibraryStackFields()
```

### <a id="Divine_Protobufs_Dota2_CMsgSosSetLibraryStackFields__ctor_Divine_Protobufs_Dota2_CMsgSosSetLibraryStackFields_"></a> CMsgSosSetLibraryStackFields\(CMsgSosSetLibraryStackFields\)

```csharp
public CMsgSosSetLibraryStackFields(CMsgSosSetLibraryStackFields other)
```

#### Parameters

`other` [CMsgSosSetLibraryStackFields](Divine.Protobufs.Dota2.CMsgSosSetLibraryStackFields.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSosSetLibraryStackFields_PackedFieldsFieldNumber"></a> PackedFieldsFieldNumber

```csharp
public const int PackedFieldsFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSosSetLibraryStackFields_StackHashFieldNumber"></a> StackHashFieldNumber

```csharp
public const int StackHashFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSosSetLibraryStackFields_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSosSetLibraryStackFields_HasPackedFields"></a> HasPackedFields

```csharp
public bool HasPackedFields { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSosSetLibraryStackFields_HasStackHash"></a> HasStackHash

```csharp
public bool HasStackHash { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSosSetLibraryStackFields_PackedFields"></a> PackedFields

```csharp
public ByteString PackedFields { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Dota2_CMsgSosSetLibraryStackFields_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSosSetLibraryStackFields> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSosSetLibraryStackFields](Divine.Protobufs.Dota2.CMsgSosSetLibraryStackFields.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSosSetLibraryStackFields_StackHash"></a> StackHash

```csharp
public uint StackHash { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSosSetLibraryStackFields_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSosSetLibraryStackFields_ClearPackedFields"></a> ClearPackedFields\(\)

```csharp
public void ClearPackedFields()
```

### <a id="Divine_Protobufs_Dota2_CMsgSosSetLibraryStackFields_ClearStackHash"></a> ClearStackHash\(\)

```csharp
public void ClearStackHash()
```

### <a id="Divine_Protobufs_Dota2_CMsgSosSetLibraryStackFields_Clone"></a> Clone\(\)

```csharp
public CMsgSosSetLibraryStackFields Clone()
```

#### Returns

 [CMsgSosSetLibraryStackFields](Divine.Protobufs.Dota2.CMsgSosSetLibraryStackFields.md)

### <a id="Divine_Protobufs_Dota2_CMsgSosSetLibraryStackFields_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSosSetLibraryStackFields_Equals_Divine_Protobufs_Dota2_CMsgSosSetLibraryStackFields_"></a> Equals\(CMsgSosSetLibraryStackFields\)

```csharp
public bool Equals(CMsgSosSetLibraryStackFields other)
```

#### Parameters

`other` [CMsgSosSetLibraryStackFields](Divine.Protobufs.Dota2.CMsgSosSetLibraryStackFields.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSosSetLibraryStackFields_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSosSetLibraryStackFields_MergeFrom_Divine_Protobufs_Dota2_CMsgSosSetLibraryStackFields_"></a> MergeFrom\(CMsgSosSetLibraryStackFields\)

```csharp
public void MergeFrom(CMsgSosSetLibraryStackFields other)
```

#### Parameters

`other` [CMsgSosSetLibraryStackFields](Divine.Protobufs.Dota2.CMsgSosSetLibraryStackFields.md)

### <a id="Divine_Protobufs_Dota2_CMsgSosSetLibraryStackFields_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSosSetLibraryStackFields_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSosSetLibraryStackFields_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

