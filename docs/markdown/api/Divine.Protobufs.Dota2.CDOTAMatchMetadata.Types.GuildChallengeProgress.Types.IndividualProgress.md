# <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_GuildChallengeProgress_Types_IndividualProgress"></a> Class CDOTAMatchMetadata.Types.GuildChallengeProgress.Types.IndividualProgress

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAMatchMetadata.Types.GuildChallengeProgress.Types.IndividualProgress : IMessage<CDOTAMatchMetadata.Types.GuildChallengeProgress.Types.IndividualProgress>, IEquatable<CDOTAMatchMetadata.Types.GuildChallengeProgress.Types.IndividualProgress>, IDeepCloneable<CDOTAMatchMetadata.Types.GuildChallengeProgress.Types.IndividualProgress>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAMatchMetadata.Types.GuildChallengeProgress.Types.IndividualProgress](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.GuildChallengeProgress.Types.IndividualProgress.md)

#### Implements

IMessage<CDOTAMatchMetadata.Types.GuildChallengeProgress.Types.IndividualProgress\>, 
[IEquatable<CDOTAMatchMetadata.Types.GuildChallengeProgress.Types.IndividualProgress\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAMatchMetadata.Types.GuildChallengeProgress.Types.IndividualProgress\>, 
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
[EnumerableExtensions.In<CDOTAMatchMetadata.Types.GuildChallengeProgress.Types.IndividualProgress\>\(CDOTAMatchMetadata.Types.GuildChallengeProgress.Types.IndividualProgress, params CDOTAMatchMetadata.Types.GuildChallengeProgress.Types.IndividualProgress\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_GuildChallengeProgress_Types_IndividualProgress__ctor"></a> IndividualProgress\(\)

```csharp
public IndividualProgress()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_GuildChallengeProgress_Types_IndividualProgress__ctor_Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_GuildChallengeProgress_Types_IndividualProgress_"></a> IndividualProgress\(IndividualProgress\)

```csharp
public IndividualProgress(CDOTAMatchMetadata.Types.GuildChallengeProgress.Types.IndividualProgress other)
```

#### Parameters

`other` [CDOTAMatchMetadata](Divine.Protobufs.Dota2.CDOTAMatchMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.md).[GuildChallengeProgress](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.GuildChallengeProgress.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.GuildChallengeProgress.Types.md).[IndividualProgress](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.GuildChallengeProgress.Types.IndividualProgress.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_GuildChallengeProgress_Types_IndividualProgress_PlayerSlotFieldNumber"></a> PlayerSlotFieldNumber

```csharp
public const int PlayerSlotFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_GuildChallengeProgress_Types_IndividualProgress_ProgressFieldNumber"></a> ProgressFieldNumber

```csharp
public const int ProgressFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_GuildChallengeProgress_Types_IndividualProgress_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_GuildChallengeProgress_Types_IndividualProgress_HasPlayerSlot"></a> HasPlayerSlot

```csharp
public bool HasPlayerSlot { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_GuildChallengeProgress_Types_IndividualProgress_HasProgress"></a> HasProgress

```csharp
public bool HasProgress { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_GuildChallengeProgress_Types_IndividualProgress_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAMatchMetadata.Types.GuildChallengeProgress.Types.IndividualProgress> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAMatchMetadata](Divine.Protobufs.Dota2.CDOTAMatchMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.md).[GuildChallengeProgress](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.GuildChallengeProgress.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.GuildChallengeProgress.Types.md).[IndividualProgress](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.GuildChallengeProgress.Types.IndividualProgress.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_GuildChallengeProgress_Types_IndividualProgress_PlayerSlot"></a> PlayerSlot

```csharp
public uint PlayerSlot { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_GuildChallengeProgress_Types_IndividualProgress_Progress"></a> Progress

```csharp
public uint Progress { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_GuildChallengeProgress_Types_IndividualProgress_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_GuildChallengeProgress_Types_IndividualProgress_ClearPlayerSlot"></a> ClearPlayerSlot\(\)

```csharp
public void ClearPlayerSlot()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_GuildChallengeProgress_Types_IndividualProgress_ClearProgress"></a> ClearProgress\(\)

```csharp
public void ClearProgress()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_GuildChallengeProgress_Types_IndividualProgress_Clone"></a> Clone\(\)

```csharp
public CDOTAMatchMetadata.Types.GuildChallengeProgress.Types.IndividualProgress Clone()
```

#### Returns

 [CDOTAMatchMetadata](Divine.Protobufs.Dota2.CDOTAMatchMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.md).[GuildChallengeProgress](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.GuildChallengeProgress.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.GuildChallengeProgress.Types.md).[IndividualProgress](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.GuildChallengeProgress.Types.IndividualProgress.md)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_GuildChallengeProgress_Types_IndividualProgress_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_GuildChallengeProgress_Types_IndividualProgress_Equals_Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_GuildChallengeProgress_Types_IndividualProgress_"></a> Equals\(IndividualProgress\)

```csharp
public bool Equals(CDOTAMatchMetadata.Types.GuildChallengeProgress.Types.IndividualProgress other)
```

#### Parameters

`other` [CDOTAMatchMetadata](Divine.Protobufs.Dota2.CDOTAMatchMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.md).[GuildChallengeProgress](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.GuildChallengeProgress.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.GuildChallengeProgress.Types.md).[IndividualProgress](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.GuildChallengeProgress.Types.IndividualProgress.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_GuildChallengeProgress_Types_IndividualProgress_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_GuildChallengeProgress_Types_IndividualProgress_MergeFrom_Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_GuildChallengeProgress_Types_IndividualProgress_"></a> MergeFrom\(IndividualProgress\)

```csharp
public void MergeFrom(CDOTAMatchMetadata.Types.GuildChallengeProgress.Types.IndividualProgress other)
```

#### Parameters

`other` [CDOTAMatchMetadata](Divine.Protobufs.Dota2.CDOTAMatchMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.md).[GuildChallengeProgress](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.GuildChallengeProgress.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.GuildChallengeProgress.Types.md).[IndividualProgress](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.GuildChallengeProgress.Types.IndividualProgress.md)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_GuildChallengeProgress_Types_IndividualProgress_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_GuildChallengeProgress_Types_IndividualProgress_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_GuildChallengeProgress_Types_IndividualProgress_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

