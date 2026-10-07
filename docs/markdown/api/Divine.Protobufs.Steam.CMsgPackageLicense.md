# <a id="Divine_Protobufs_Steam_CMsgPackageLicense"></a> Class CMsgPackageLicense

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgPackageLicense : IMessage<CMsgPackageLicense>, IEquatable<CMsgPackageLicense>, IDeepCloneable<CMsgPackageLicense>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgPackageLicense](Divine.Protobufs.Steam.CMsgPackageLicense.md)

#### Implements

IMessage<CMsgPackageLicense\>, 
[IEquatable<CMsgPackageLicense\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgPackageLicense\>, 
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
[EnumerableExtensions.In<CMsgPackageLicense\>\(CMsgPackageLicense, params CMsgPackageLicense\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgPackageLicense__ctor"></a> CMsgPackageLicense\(\)

```csharp
public CMsgPackageLicense()
```

### <a id="Divine_Protobufs_Steam_CMsgPackageLicense__ctor_Divine_Protobufs_Steam_CMsgPackageLicense_"></a> CMsgPackageLicense\(CMsgPackageLicense\)

```csharp
public CMsgPackageLicense(CMsgPackageLicense other)
```

#### Parameters

`other` [CMsgPackageLicense](Divine.Protobufs.Steam.CMsgPackageLicense.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgPackageLicense_OwnerIdFieldNumber"></a> OwnerIdFieldNumber

```csharp
public const int OwnerIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgPackageLicense_PackageIdFieldNumber"></a> PackageIdFieldNumber

```csharp
public const int PackageIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgPackageLicense_TimeCreatedFieldNumber"></a> TimeCreatedFieldNumber

```csharp
public const int TimeCreatedFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgPackageLicense_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgPackageLicense_HasOwnerId"></a> HasOwnerId

```csharp
public bool HasOwnerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgPackageLicense_HasPackageId"></a> HasPackageId

```csharp
public bool HasPackageId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgPackageLicense_HasTimeCreated"></a> HasTimeCreated

```csharp
public bool HasTimeCreated { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgPackageLicense_OwnerId"></a> OwnerId

```csharp
public uint OwnerId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgPackageLicense_PackageId"></a> PackageId

```csharp
public uint PackageId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgPackageLicense_Parser"></a> Parser

```csharp
public static MessageParser<CMsgPackageLicense> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgPackageLicense](Divine.Protobufs.Steam.CMsgPackageLicense.md)\>

### <a id="Divine_Protobufs_Steam_CMsgPackageLicense_TimeCreated"></a> TimeCreated

```csharp
public uint TimeCreated { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgPackageLicense_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgPackageLicense_ClearOwnerId"></a> ClearOwnerId\(\)

```csharp
public void ClearOwnerId()
```

### <a id="Divine_Protobufs_Steam_CMsgPackageLicense_ClearPackageId"></a> ClearPackageId\(\)

```csharp
public void ClearPackageId()
```

### <a id="Divine_Protobufs_Steam_CMsgPackageLicense_ClearTimeCreated"></a> ClearTimeCreated\(\)

```csharp
public void ClearTimeCreated()
```

### <a id="Divine_Protobufs_Steam_CMsgPackageLicense_Clone"></a> Clone\(\)

```csharp
public CMsgPackageLicense Clone()
```

#### Returns

 [CMsgPackageLicense](Divine.Protobufs.Steam.CMsgPackageLicense.md)

### <a id="Divine_Protobufs_Steam_CMsgPackageLicense_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgPackageLicense_Equals_Divine_Protobufs_Steam_CMsgPackageLicense_"></a> Equals\(CMsgPackageLicense\)

```csharp
public bool Equals(CMsgPackageLicense other)
```

#### Parameters

`other` [CMsgPackageLicense](Divine.Protobufs.Steam.CMsgPackageLicense.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgPackageLicense_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgPackageLicense_MergeFrom_Divine_Protobufs_Steam_CMsgPackageLicense_"></a> MergeFrom\(CMsgPackageLicense\)

```csharp
public void MergeFrom(CMsgPackageLicense other)
```

#### Parameters

`other` [CMsgPackageLicense](Divine.Protobufs.Steam.CMsgPackageLicense.md)

### <a id="Divine_Protobufs_Steam_CMsgPackageLicense_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgPackageLicense_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgPackageLicense_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

