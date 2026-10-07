# <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_StringName"></a> Class CDOTAMatchPrivateMetadata.Types.StringName

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAMatchPrivateMetadata.Types.StringName : IMessage<CDOTAMatchPrivateMetadata.Types.StringName>, IEquatable<CDOTAMatchPrivateMetadata.Types.StringName>, IDeepCloneable<CDOTAMatchPrivateMetadata.Types.StringName>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAMatchPrivateMetadata.Types.StringName](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.StringName.md)

#### Implements

IMessage<CDOTAMatchPrivateMetadata.Types.StringName\>, 
[IEquatable<CDOTAMatchPrivateMetadata.Types.StringName\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAMatchPrivateMetadata.Types.StringName\>, 
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
[EnumerableExtensions.In<CDOTAMatchPrivateMetadata.Types.StringName\>\(CDOTAMatchPrivateMetadata.Types.StringName, params CDOTAMatchPrivateMetadata.Types.StringName\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_StringName__ctor"></a> StringName\(\)

```csharp
public StringName()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_StringName__ctor_Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_StringName_"></a> StringName\(StringName\)

```csharp
public StringName(CDOTAMatchPrivateMetadata.Types.StringName other)
```

#### Parameters

`other` [CDOTAMatchPrivateMetadata](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.md).[StringName](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.StringName.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_StringName_IdFieldNumber"></a> IdFieldNumber

```csharp
public const int IdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_StringName_NameFieldNumber"></a> NameFieldNumber

```csharp
public const int NameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_StringName_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_StringName_HasId"></a> HasId

```csharp
public bool HasId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_StringName_HasName"></a> HasName

```csharp
public bool HasName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_StringName_Id"></a> Id

```csharp
public uint Id { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_StringName_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_StringName_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAMatchPrivateMetadata.Types.StringName> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAMatchPrivateMetadata](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.md).[StringName](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.StringName.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_StringName_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_StringName_ClearId"></a> ClearId\(\)

```csharp
public void ClearId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_StringName_ClearName"></a> ClearName\(\)

```csharp
public void ClearName()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_StringName_Clone"></a> Clone\(\)

```csharp
public CDOTAMatchPrivateMetadata.Types.StringName Clone()
```

#### Returns

 [CDOTAMatchPrivateMetadata](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.md).[StringName](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.StringName.md)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_StringName_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_StringName_Equals_Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_StringName_"></a> Equals\(StringName\)

```csharp
public bool Equals(CDOTAMatchPrivateMetadata.Types.StringName other)
```

#### Parameters

`other` [CDOTAMatchPrivateMetadata](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.md).[StringName](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.StringName.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_StringName_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_StringName_MergeFrom_Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_StringName_"></a> MergeFrom\(StringName\)

```csharp
public void MergeFrom(CDOTAMatchPrivateMetadata.Types.StringName other)
```

#### Parameters

`other` [CDOTAMatchPrivateMetadata](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.md).[StringName](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.StringName.md)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_StringName_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_StringName_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_StringName_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

