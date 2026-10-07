# <a id="Divine_Protobufs_Dota2_CMsgSteamLearnServerInfo_Types_ProjectInfo"></a> Class CMsgSteamLearnServerInfo.Types.ProjectInfo

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamLearnServerInfo.Types.ProjectInfo : IMessage<CMsgSteamLearnServerInfo.Types.ProjectInfo>, IEquatable<CMsgSteamLearnServerInfo.Types.ProjectInfo>, IDeepCloneable<CMsgSteamLearnServerInfo.Types.ProjectInfo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamLearnServerInfo.Types.ProjectInfo](Divine.Protobufs.Dota2.CMsgSteamLearnServerInfo.Types.ProjectInfo.md)

#### Implements

IMessage<CMsgSteamLearnServerInfo.Types.ProjectInfo\>, 
[IEquatable<CMsgSteamLearnServerInfo.Types.ProjectInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamLearnServerInfo.Types.ProjectInfo\>, 
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
[EnumerableExtensions.In<CMsgSteamLearnServerInfo.Types.ProjectInfo\>\(CMsgSteamLearnServerInfo.Types.ProjectInfo, params CMsgSteamLearnServerInfo.Types.ProjectInfo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnServerInfo_Types_ProjectInfo__ctor"></a> ProjectInfo\(\)

```csharp
public ProjectInfo()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnServerInfo_Types_ProjectInfo__ctor_Divine_Protobufs_Dota2_CMsgSteamLearnServerInfo_Types_ProjectInfo_"></a> ProjectInfo\(ProjectInfo\)

```csharp
public ProjectInfo(CMsgSteamLearnServerInfo.Types.ProjectInfo other)
```

#### Parameters

`other` [CMsgSteamLearnServerInfo](Divine.Protobufs.Dota2.CMsgSteamLearnServerInfo.md).[Types](Divine.Protobufs.Dota2.CMsgSteamLearnServerInfo.Types.md).[ProjectInfo](Divine.Protobufs.Dota2.CMsgSteamLearnServerInfo.Types.ProjectInfo.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnServerInfo_Types_ProjectInfo_InferencePublishedVersionFieldNumber"></a> InferencePublishedVersionFieldNumber

```csharp
public const int InferencePublishedVersionFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnServerInfo_Types_ProjectInfo_ProjectIdFieldNumber"></a> ProjectIdFieldNumber

```csharp
public const int ProjectIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnServerInfo_Types_ProjectInfo_SnapshotEnabledFieldNumber"></a> SnapshotEnabledFieldNumber

```csharp
public const int SnapshotEnabledFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnServerInfo_Types_ProjectInfo_SnapshotPercentageFieldNumber"></a> SnapshotPercentageFieldNumber

```csharp
public const int SnapshotPercentageFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnServerInfo_Types_ProjectInfo_SnapshotPublishedVersionFieldNumber"></a> SnapshotPublishedVersionFieldNumber

```csharp
public const int SnapshotPublishedVersionFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnServerInfo_Types_ProjectInfo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnServerInfo_Types_ProjectInfo_HasInferencePublishedVersion"></a> HasInferencePublishedVersion

```csharp
public bool HasInferencePublishedVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnServerInfo_Types_ProjectInfo_HasProjectId"></a> HasProjectId

```csharp
public bool HasProjectId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnServerInfo_Types_ProjectInfo_HasSnapshotEnabled"></a> HasSnapshotEnabled

```csharp
public bool HasSnapshotEnabled { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnServerInfo_Types_ProjectInfo_HasSnapshotPercentage"></a> HasSnapshotPercentage

```csharp
public bool HasSnapshotPercentage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnServerInfo_Types_ProjectInfo_HasSnapshotPublishedVersion"></a> HasSnapshotPublishedVersion

```csharp
public bool HasSnapshotPublishedVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnServerInfo_Types_ProjectInfo_InferencePublishedVersion"></a> InferencePublishedVersion

```csharp
public uint InferencePublishedVersion { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnServerInfo_Types_ProjectInfo_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamLearnServerInfo.Types.ProjectInfo> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamLearnServerInfo](Divine.Protobufs.Dota2.CMsgSteamLearnServerInfo.md).[Types](Divine.Protobufs.Dota2.CMsgSteamLearnServerInfo.Types.md).[ProjectInfo](Divine.Protobufs.Dota2.CMsgSteamLearnServerInfo.Types.ProjectInfo.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnServerInfo_Types_ProjectInfo_ProjectId"></a> ProjectId

```csharp
public uint ProjectId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnServerInfo_Types_ProjectInfo_SnapshotEnabled"></a> SnapshotEnabled

```csharp
public bool SnapshotEnabled { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnServerInfo_Types_ProjectInfo_SnapshotPercentage"></a> SnapshotPercentage

```csharp
public uint SnapshotPercentage { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnServerInfo_Types_ProjectInfo_SnapshotPublishedVersion"></a> SnapshotPublishedVersion

```csharp
public uint SnapshotPublishedVersion { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnServerInfo_Types_ProjectInfo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnServerInfo_Types_ProjectInfo_ClearInferencePublishedVersion"></a> ClearInferencePublishedVersion\(\)

```csharp
public void ClearInferencePublishedVersion()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnServerInfo_Types_ProjectInfo_ClearProjectId"></a> ClearProjectId\(\)

```csharp
public void ClearProjectId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnServerInfo_Types_ProjectInfo_ClearSnapshotEnabled"></a> ClearSnapshotEnabled\(\)

```csharp
public void ClearSnapshotEnabled()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnServerInfo_Types_ProjectInfo_ClearSnapshotPercentage"></a> ClearSnapshotPercentage\(\)

```csharp
public void ClearSnapshotPercentage()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnServerInfo_Types_ProjectInfo_ClearSnapshotPublishedVersion"></a> ClearSnapshotPublishedVersion\(\)

```csharp
public void ClearSnapshotPublishedVersion()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnServerInfo_Types_ProjectInfo_Clone"></a> Clone\(\)

```csharp
public CMsgSteamLearnServerInfo.Types.ProjectInfo Clone()
```

#### Returns

 [CMsgSteamLearnServerInfo](Divine.Protobufs.Dota2.CMsgSteamLearnServerInfo.md).[Types](Divine.Protobufs.Dota2.CMsgSteamLearnServerInfo.Types.md).[ProjectInfo](Divine.Protobufs.Dota2.CMsgSteamLearnServerInfo.Types.ProjectInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnServerInfo_Types_ProjectInfo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnServerInfo_Types_ProjectInfo_Equals_Divine_Protobufs_Dota2_CMsgSteamLearnServerInfo_Types_ProjectInfo_"></a> Equals\(ProjectInfo\)

```csharp
public bool Equals(CMsgSteamLearnServerInfo.Types.ProjectInfo other)
```

#### Parameters

`other` [CMsgSteamLearnServerInfo](Divine.Protobufs.Dota2.CMsgSteamLearnServerInfo.md).[Types](Divine.Protobufs.Dota2.CMsgSteamLearnServerInfo.Types.md).[ProjectInfo](Divine.Protobufs.Dota2.CMsgSteamLearnServerInfo.Types.ProjectInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnServerInfo_Types_ProjectInfo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnServerInfo_Types_ProjectInfo_MergeFrom_Divine_Protobufs_Dota2_CMsgSteamLearnServerInfo_Types_ProjectInfo_"></a> MergeFrom\(ProjectInfo\)

```csharp
public void MergeFrom(CMsgSteamLearnServerInfo.Types.ProjectInfo other)
```

#### Parameters

`other` [CMsgSteamLearnServerInfo](Divine.Protobufs.Dota2.CMsgSteamLearnServerInfo.md).[Types](Divine.Protobufs.Dota2.CMsgSteamLearnServerInfo.Types.md).[ProjectInfo](Divine.Protobufs.Dota2.CMsgSteamLearnServerInfo.Types.ProjectInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnServerInfo_Types_ProjectInfo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnServerInfo_Types_ProjectInfo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnServerInfo_Types_ProjectInfo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

