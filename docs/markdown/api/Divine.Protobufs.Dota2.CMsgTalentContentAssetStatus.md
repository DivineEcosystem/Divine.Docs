# <a id="Divine_Protobufs_Dota2_CMsgTalentContentAssetStatus"></a> Class CMsgTalentContentAssetStatus

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgTalentContentAssetStatus : IMessage<CMsgTalentContentAssetStatus>, IEquatable<CMsgTalentContentAssetStatus>, IDeepCloneable<CMsgTalentContentAssetStatus>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgTalentContentAssetStatus](Divine.Protobufs.Dota2.CMsgTalentContentAssetStatus.md)

#### Implements

IMessage<CMsgTalentContentAssetStatus\>, 
[IEquatable<CMsgTalentContentAssetStatus\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgTalentContentAssetStatus\>, 
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
[EnumerableExtensions.In<CMsgTalentContentAssetStatus\>\(CMsgTalentContentAssetStatus, params CMsgTalentContentAssetStatus\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgTalentContentAssetStatus__ctor"></a> CMsgTalentContentAssetStatus\(\)

```csharp
public CMsgTalentContentAssetStatus()
```

### <a id="Divine_Protobufs_Dota2_CMsgTalentContentAssetStatus__ctor_Divine_Protobufs_Dota2_CMsgTalentContentAssetStatus_"></a> CMsgTalentContentAssetStatus\(CMsgTalentContentAssetStatus\)

```csharp
public CMsgTalentContentAssetStatus(CMsgTalentContentAssetStatus other)
```

#### Parameters

`other` [CMsgTalentContentAssetStatus](Divine.Protobufs.Dota2.CMsgTalentContentAssetStatus.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgTalentContentAssetStatus_AssetIndexFieldNumber"></a> AssetIndexFieldNumber

```csharp
public const int AssetIndexFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTalentContentAssetStatus_AssetStatusFieldNumber"></a> AssetStatusFieldNumber

```csharp
public const int AssetStatusFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTalentContentAssetStatus_AssetTypeFieldNumber"></a> AssetTypeFieldNumber

```csharp
public const int AssetTypeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTalentContentAssetStatus_RevisionFieldNumber"></a> RevisionFieldNumber

```csharp
public const int RevisionFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgTalentContentAssetStatus_AssetIndex"></a> AssetIndex

```csharp
public uint AssetIndex { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgTalentContentAssetStatus_AssetStatus"></a> AssetStatus

```csharp
public ETalentContentAssetStatus AssetStatus { get; set; }
```

#### Property Value

 [ETalentContentAssetStatus](Divine.Protobufs.Dota2.ETalentContentAssetStatus.md)

### <a id="Divine_Protobufs_Dota2_CMsgTalentContentAssetStatus_AssetType"></a> AssetType

```csharp
public ETalentContentAssetType AssetType { get; set; }
```

#### Property Value

 [ETalentContentAssetType](Divine.Protobufs.Dota2.ETalentContentAssetType.md)

### <a id="Divine_Protobufs_Dota2_CMsgTalentContentAssetStatus_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgTalentContentAssetStatus_HasAssetIndex"></a> HasAssetIndex

```csharp
public bool HasAssetIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTalentContentAssetStatus_HasAssetStatus"></a> HasAssetStatus

```csharp
public bool HasAssetStatus { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTalentContentAssetStatus_HasAssetType"></a> HasAssetType

```csharp
public bool HasAssetType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTalentContentAssetStatus_HasRevision"></a> HasRevision

```csharp
public bool HasRevision { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTalentContentAssetStatus_Parser"></a> Parser

```csharp
public static MessageParser<CMsgTalentContentAssetStatus> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgTalentContentAssetStatus](Divine.Protobufs.Dota2.CMsgTalentContentAssetStatus.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgTalentContentAssetStatus_Revision"></a> Revision

```csharp
public uint Revision { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgTalentContentAssetStatus_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTalentContentAssetStatus_ClearAssetIndex"></a> ClearAssetIndex\(\)

```csharp
public void ClearAssetIndex()
```

### <a id="Divine_Protobufs_Dota2_CMsgTalentContentAssetStatus_ClearAssetStatus"></a> ClearAssetStatus\(\)

```csharp
public void ClearAssetStatus()
```

### <a id="Divine_Protobufs_Dota2_CMsgTalentContentAssetStatus_ClearAssetType"></a> ClearAssetType\(\)

```csharp
public void ClearAssetType()
```

### <a id="Divine_Protobufs_Dota2_CMsgTalentContentAssetStatus_ClearRevision"></a> ClearRevision\(\)

```csharp
public void ClearRevision()
```

### <a id="Divine_Protobufs_Dota2_CMsgTalentContentAssetStatus_Clone"></a> Clone\(\)

```csharp
public CMsgTalentContentAssetStatus Clone()
```

#### Returns

 [CMsgTalentContentAssetStatus](Divine.Protobufs.Dota2.CMsgTalentContentAssetStatus.md)

### <a id="Divine_Protobufs_Dota2_CMsgTalentContentAssetStatus_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTalentContentAssetStatus_Equals_Divine_Protobufs_Dota2_CMsgTalentContentAssetStatus_"></a> Equals\(CMsgTalentContentAssetStatus\)

```csharp
public bool Equals(CMsgTalentContentAssetStatus other)
```

#### Parameters

`other` [CMsgTalentContentAssetStatus](Divine.Protobufs.Dota2.CMsgTalentContentAssetStatus.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTalentContentAssetStatus_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTalentContentAssetStatus_MergeFrom_Divine_Protobufs_Dota2_CMsgTalentContentAssetStatus_"></a> MergeFrom\(CMsgTalentContentAssetStatus\)

```csharp
public void MergeFrom(CMsgTalentContentAssetStatus other)
```

#### Parameters

`other` [CMsgTalentContentAssetStatus](Divine.Protobufs.Dota2.CMsgTalentContentAssetStatus.md)

### <a id="Divine_Protobufs_Dota2_CMsgTalentContentAssetStatus_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgTalentContentAssetStatus_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgTalentContentAssetStatus_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

