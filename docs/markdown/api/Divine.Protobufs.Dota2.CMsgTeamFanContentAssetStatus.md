# <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAssetStatus"></a> Class CMsgTeamFanContentAssetStatus

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgTeamFanContentAssetStatus : IMessage<CMsgTeamFanContentAssetStatus>, IEquatable<CMsgTeamFanContentAssetStatus>, IDeepCloneable<CMsgTeamFanContentAssetStatus>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgTeamFanContentAssetStatus](Divine.Protobufs.Dota2.CMsgTeamFanContentAssetStatus.md)

#### Implements

IMessage<CMsgTeamFanContentAssetStatus\>, 
[IEquatable<CMsgTeamFanContentAssetStatus\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgTeamFanContentAssetStatus\>, 
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
[EnumerableExtensions.In<CMsgTeamFanContentAssetStatus\>\(CMsgTeamFanContentAssetStatus, params CMsgTeamFanContentAssetStatus\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAssetStatus__ctor"></a> CMsgTeamFanContentAssetStatus\(\)

```csharp
public CMsgTeamFanContentAssetStatus()
```

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAssetStatus__ctor_Divine_Protobufs_Dota2_CMsgTeamFanContentAssetStatus_"></a> CMsgTeamFanContentAssetStatus\(CMsgTeamFanContentAssetStatus\)

```csharp
public CMsgTeamFanContentAssetStatus(CMsgTeamFanContentAssetStatus other)
```

#### Parameters

`other` [CMsgTeamFanContentAssetStatus](Divine.Protobufs.Dota2.CMsgTeamFanContentAssetStatus.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAssetStatus_AssetIndexFieldNumber"></a> AssetIndexFieldNumber

```csharp
public const int AssetIndexFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAssetStatus_AssetStatusFieldNumber"></a> AssetStatusFieldNumber

```csharp
public const int AssetStatusFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAssetStatus_AssetTypeFieldNumber"></a> AssetTypeFieldNumber

```csharp
public const int AssetTypeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAssetStatus_CrcFieldNumber"></a> CrcFieldNumber

```csharp
public const int CrcFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAssetStatus_AssetIndex"></a> AssetIndex

```csharp
public uint AssetIndex { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAssetStatus_AssetStatus"></a> AssetStatus

```csharp
public ETeamFanContentAssetStatus AssetStatus { get; set; }
```

#### Property Value

 [ETeamFanContentAssetStatus](Divine.Protobufs.Dota2.ETeamFanContentAssetStatus.md)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAssetStatus_AssetType"></a> AssetType

```csharp
public ETeamFanContentAssetType AssetType { get; set; }
```

#### Property Value

 [ETeamFanContentAssetType](Divine.Protobufs.Dota2.ETeamFanContentAssetType.md)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAssetStatus_Crc"></a> Crc

```csharp
public uint Crc { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAssetStatus_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAssetStatus_HasAssetIndex"></a> HasAssetIndex

```csharp
public bool HasAssetIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAssetStatus_HasAssetStatus"></a> HasAssetStatus

```csharp
public bool HasAssetStatus { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAssetStatus_HasAssetType"></a> HasAssetType

```csharp
public bool HasAssetType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAssetStatus_HasCrc"></a> HasCrc

```csharp
public bool HasCrc { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAssetStatus_Parser"></a> Parser

```csharp
public static MessageParser<CMsgTeamFanContentAssetStatus> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgTeamFanContentAssetStatus](Divine.Protobufs.Dota2.CMsgTeamFanContentAssetStatus.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAssetStatus_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAssetStatus_ClearAssetIndex"></a> ClearAssetIndex\(\)

```csharp
public void ClearAssetIndex()
```

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAssetStatus_ClearAssetStatus"></a> ClearAssetStatus\(\)

```csharp
public void ClearAssetStatus()
```

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAssetStatus_ClearAssetType"></a> ClearAssetType\(\)

```csharp
public void ClearAssetType()
```

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAssetStatus_ClearCrc"></a> ClearCrc\(\)

```csharp
public void ClearCrc()
```

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAssetStatus_Clone"></a> Clone\(\)

```csharp
public CMsgTeamFanContentAssetStatus Clone()
```

#### Returns

 [CMsgTeamFanContentAssetStatus](Divine.Protobufs.Dota2.CMsgTeamFanContentAssetStatus.md)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAssetStatus_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAssetStatus_Equals_Divine_Protobufs_Dota2_CMsgTeamFanContentAssetStatus_"></a> Equals\(CMsgTeamFanContentAssetStatus\)

```csharp
public bool Equals(CMsgTeamFanContentAssetStatus other)
```

#### Parameters

`other` [CMsgTeamFanContentAssetStatus](Divine.Protobufs.Dota2.CMsgTeamFanContentAssetStatus.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAssetStatus_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAssetStatus_MergeFrom_Divine_Protobufs_Dota2_CMsgTeamFanContentAssetStatus_"></a> MergeFrom\(CMsgTeamFanContentAssetStatus\)

```csharp
public void MergeFrom(CMsgTeamFanContentAssetStatus other)
```

#### Parameters

`other` [CMsgTeamFanContentAssetStatus](Divine.Protobufs.Dota2.CMsgTeamFanContentAssetStatus.md)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAssetStatus_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAssetStatus_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAssetStatus_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

