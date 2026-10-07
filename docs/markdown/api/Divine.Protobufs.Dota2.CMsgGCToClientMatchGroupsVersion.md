# <a id="Divine_Protobufs_Dota2_CMsgGCToClientMatchGroupsVersion"></a> Class CMsgGCToClientMatchGroupsVersion

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientMatchGroupsVersion : IMessage<CMsgGCToClientMatchGroupsVersion>, IEquatable<CMsgGCToClientMatchGroupsVersion>, IDeepCloneable<CMsgGCToClientMatchGroupsVersion>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientMatchGroupsVersion](Divine.Protobufs.Dota2.CMsgGCToClientMatchGroupsVersion.md)

#### Implements

IMessage<CMsgGCToClientMatchGroupsVersion\>, 
[IEquatable<CMsgGCToClientMatchGroupsVersion\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientMatchGroupsVersion\>, 
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
[EnumerableExtensions.In<CMsgGCToClientMatchGroupsVersion\>\(CMsgGCToClientMatchGroupsVersion, params CMsgGCToClientMatchGroupsVersion\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMatchGroupsVersion__ctor"></a> CMsgGCToClientMatchGroupsVersion\(\)

```csharp
public CMsgGCToClientMatchGroupsVersion()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMatchGroupsVersion__ctor_Divine_Protobufs_Dota2_CMsgGCToClientMatchGroupsVersion_"></a> CMsgGCToClientMatchGroupsVersion\(CMsgGCToClientMatchGroupsVersion\)

```csharp
public CMsgGCToClientMatchGroupsVersion(CMsgGCToClientMatchGroupsVersion other)
```

#### Parameters

`other` [CMsgGCToClientMatchGroupsVersion](Divine.Protobufs.Dota2.CMsgGCToClientMatchGroupsVersion.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMatchGroupsVersion_MatchgroupsVersionFieldNumber"></a> MatchgroupsVersionFieldNumber

```csharp
public const int MatchgroupsVersionFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMatchGroupsVersion_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMatchGroupsVersion_HasMatchgroupsVersion"></a> HasMatchgroupsVersion

```csharp
public bool HasMatchgroupsVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMatchGroupsVersion_MatchgroupsVersion"></a> MatchgroupsVersion

```csharp
public uint MatchgroupsVersion { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMatchGroupsVersion_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientMatchGroupsVersion> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientMatchGroupsVersion](Divine.Protobufs.Dota2.CMsgGCToClientMatchGroupsVersion.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMatchGroupsVersion_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMatchGroupsVersion_ClearMatchgroupsVersion"></a> ClearMatchgroupsVersion\(\)

```csharp
public void ClearMatchgroupsVersion()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMatchGroupsVersion_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientMatchGroupsVersion Clone()
```

#### Returns

 [CMsgGCToClientMatchGroupsVersion](Divine.Protobufs.Dota2.CMsgGCToClientMatchGroupsVersion.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMatchGroupsVersion_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMatchGroupsVersion_Equals_Divine_Protobufs_Dota2_CMsgGCToClientMatchGroupsVersion_"></a> Equals\(CMsgGCToClientMatchGroupsVersion\)

```csharp
public bool Equals(CMsgGCToClientMatchGroupsVersion other)
```

#### Parameters

`other` [CMsgGCToClientMatchGroupsVersion](Divine.Protobufs.Dota2.CMsgGCToClientMatchGroupsVersion.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMatchGroupsVersion_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMatchGroupsVersion_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientMatchGroupsVersion_"></a> MergeFrom\(CMsgGCToClientMatchGroupsVersion\)

```csharp
public void MergeFrom(CMsgGCToClientMatchGroupsVersion other)
```

#### Parameters

`other` [CMsgGCToClientMatchGroupsVersion](Divine.Protobufs.Dota2.CMsgGCToClientMatchGroupsVersion.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMatchGroupsVersion_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMatchGroupsVersion_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMatchGroupsVersion_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

