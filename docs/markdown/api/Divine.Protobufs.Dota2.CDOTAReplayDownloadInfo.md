# <a id="Divine_Protobufs_Dota2_CDOTAReplayDownloadInfo"></a> Class CDOTAReplayDownloadInfo

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAReplayDownloadInfo : IMessage<CDOTAReplayDownloadInfo>, IEquatable<CDOTAReplayDownloadInfo>, IDeepCloneable<CDOTAReplayDownloadInfo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAReplayDownloadInfo](Divine.Protobufs.Dota2.CDOTAReplayDownloadInfo.md)

#### Implements

IMessage<CDOTAReplayDownloadInfo\>, 
[IEquatable<CDOTAReplayDownloadInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAReplayDownloadInfo\>, 
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
[EnumerableExtensions.In<CDOTAReplayDownloadInfo\>\(CDOTAReplayDownloadInfo, params CDOTAReplayDownloadInfo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAReplayDownloadInfo__ctor"></a> CDOTAReplayDownloadInfo\(\)

```csharp
public CDOTAReplayDownloadInfo()
```

### <a id="Divine_Protobufs_Dota2_CDOTAReplayDownloadInfo__ctor_Divine_Protobufs_Dota2_CDOTAReplayDownloadInfo_"></a> CDOTAReplayDownloadInfo\(CDOTAReplayDownloadInfo\)

```csharp
public CDOTAReplayDownloadInfo(CDOTAReplayDownloadInfo other)
```

#### Parameters

`other` [CDOTAReplayDownloadInfo](Divine.Protobufs.Dota2.CDOTAReplayDownloadInfo.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAReplayDownloadInfo_DescriptionFieldNumber"></a> DescriptionFieldNumber

```csharp
public const int DescriptionFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAReplayDownloadInfo_ExistsOnDiskFieldNumber"></a> ExistsOnDiskFieldNumber

```csharp
public const int ExistsOnDiskFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAReplayDownloadInfo_MatchFieldNumber"></a> MatchFieldNumber

```csharp
public const int MatchFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAReplayDownloadInfo_SizeFieldNumber"></a> SizeFieldNumber

```csharp
public const int SizeFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAReplayDownloadInfo_TagsFieldNumber"></a> TagsFieldNumber

```csharp
public const int TagsFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAReplayDownloadInfo_TitleFieldNumber"></a> TitleFieldNumber

```csharp
public const int TitleFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAReplayDownloadInfo_Description"></a> Description

```csharp
public string Description { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAReplayDownloadInfo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAReplayDownloadInfo_ExistsOnDisk"></a> ExistsOnDisk

```csharp
public bool ExistsOnDisk { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAReplayDownloadInfo_HasDescription"></a> HasDescription

```csharp
public bool HasDescription { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAReplayDownloadInfo_HasExistsOnDisk"></a> HasExistsOnDisk

```csharp
public bool HasExistsOnDisk { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAReplayDownloadInfo_HasSize"></a> HasSize

```csharp
public bool HasSize { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAReplayDownloadInfo_HasTitle"></a> HasTitle

```csharp
public bool HasTitle { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAReplayDownloadInfo_Match"></a> Match

```csharp
public CMsgDOTAMatchMinimal Match { get; set; }
```

#### Property Value

 [CMsgDOTAMatchMinimal](Divine.Protobufs.Dota2.CMsgDOTAMatchMinimal.md)

### <a id="Divine_Protobufs_Dota2_CDOTAReplayDownloadInfo_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAReplayDownloadInfo> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAReplayDownloadInfo](Divine.Protobufs.Dota2.CDOTAReplayDownloadInfo.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAReplayDownloadInfo_Size"></a> Size

```csharp
public uint Size { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAReplayDownloadInfo_Tags"></a> Tags

```csharp
public RepeatedField<string> Tags { get; }
```

#### Property Value

 RepeatedField<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="Divine_Protobufs_Dota2_CDOTAReplayDownloadInfo_Title"></a> Title

```csharp
public string Title { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAReplayDownloadInfo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAReplayDownloadInfo_ClearDescription"></a> ClearDescription\(\)

```csharp
public void ClearDescription()
```

### <a id="Divine_Protobufs_Dota2_CDOTAReplayDownloadInfo_ClearExistsOnDisk"></a> ClearExistsOnDisk\(\)

```csharp
public void ClearExistsOnDisk()
```

### <a id="Divine_Protobufs_Dota2_CDOTAReplayDownloadInfo_ClearSize"></a> ClearSize\(\)

```csharp
public void ClearSize()
```

### <a id="Divine_Protobufs_Dota2_CDOTAReplayDownloadInfo_ClearTitle"></a> ClearTitle\(\)

```csharp
public void ClearTitle()
```

### <a id="Divine_Protobufs_Dota2_CDOTAReplayDownloadInfo_Clone"></a> Clone\(\)

```csharp
public CDOTAReplayDownloadInfo Clone()
```

#### Returns

 [CDOTAReplayDownloadInfo](Divine.Protobufs.Dota2.CDOTAReplayDownloadInfo.md)

### <a id="Divine_Protobufs_Dota2_CDOTAReplayDownloadInfo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAReplayDownloadInfo_Equals_Divine_Protobufs_Dota2_CDOTAReplayDownloadInfo_"></a> Equals\(CDOTAReplayDownloadInfo\)

```csharp
public bool Equals(CDOTAReplayDownloadInfo other)
```

#### Parameters

`other` [CDOTAReplayDownloadInfo](Divine.Protobufs.Dota2.CDOTAReplayDownloadInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAReplayDownloadInfo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAReplayDownloadInfo_MergeFrom_Divine_Protobufs_Dota2_CDOTAReplayDownloadInfo_"></a> MergeFrom\(CDOTAReplayDownloadInfo\)

```csharp
public void MergeFrom(CDOTAReplayDownloadInfo other)
```

#### Parameters

`other` [CDOTAReplayDownloadInfo](Divine.Protobufs.Dota2.CDOTAReplayDownloadInfo.md)

### <a id="Divine_Protobufs_Dota2_CDOTAReplayDownloadInfo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAReplayDownloadInfo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAReplayDownloadInfo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

