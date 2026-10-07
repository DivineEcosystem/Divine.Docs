# <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_CavernChallengeResult"></a> Class CDOTAMatchMetadata.Types.Team.Types.CavernChallengeResult

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAMatchMetadata.Types.Team.Types.CavernChallengeResult : IMessage<CDOTAMatchMetadata.Types.Team.Types.CavernChallengeResult>, IEquatable<CDOTAMatchMetadata.Types.Team.Types.CavernChallengeResult>, IDeepCloneable<CDOTAMatchMetadata.Types.Team.Types.CavernChallengeResult>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAMatchMetadata.Types.Team.Types.CavernChallengeResult](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.CavernChallengeResult.md)

#### Implements

IMessage<CDOTAMatchMetadata.Types.Team.Types.CavernChallengeResult\>, 
[IEquatable<CDOTAMatchMetadata.Types.Team.Types.CavernChallengeResult\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAMatchMetadata.Types.Team.Types.CavernChallengeResult\>, 
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
[EnumerableExtensions.In<CDOTAMatchMetadata.Types.Team.Types.CavernChallengeResult\>\(CDOTAMatchMetadata.Types.Team.Types.CavernChallengeResult, params CDOTAMatchMetadata.Types.Team.Types.CavernChallengeResult\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_CavernChallengeResult__ctor"></a> CavernChallengeResult\(\)

```csharp
public CavernChallengeResult()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_CavernChallengeResult__ctor_Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_CavernChallengeResult_"></a> CavernChallengeResult\(CavernChallengeResult\)

```csharp
public CavernChallengeResult(CDOTAMatchMetadata.Types.Team.Types.CavernChallengeResult other)
```

#### Parameters

`other` [CDOTAMatchMetadata](Divine.Protobufs.Dota2.CDOTAMatchMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.md).[Team](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.md).[CavernChallengeResult](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.CavernChallengeResult.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_CavernChallengeResult_ClaimedRoomIdFieldNumber"></a> ClaimedRoomIdFieldNumber

```csharp
public const int ClaimedRoomIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_CavernChallengeResult_CompletedPathIdFieldNumber"></a> CompletedPathIdFieldNumber

```csharp
public const int CompletedPathIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_CavernChallengeResult_ClaimedRoomId"></a> ClaimedRoomId

```csharp
public uint ClaimedRoomId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_CavernChallengeResult_CompletedPathId"></a> CompletedPathId

```csharp
public uint CompletedPathId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_CavernChallengeResult_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_CavernChallengeResult_HasClaimedRoomId"></a> HasClaimedRoomId

```csharp
public bool HasClaimedRoomId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_CavernChallengeResult_HasCompletedPathId"></a> HasCompletedPathId

```csharp
public bool HasCompletedPathId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_CavernChallengeResult_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAMatchMetadata.Types.Team.Types.CavernChallengeResult> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAMatchMetadata](Divine.Protobufs.Dota2.CDOTAMatchMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.md).[Team](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.md).[CavernChallengeResult](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.CavernChallengeResult.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_CavernChallengeResult_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_CavernChallengeResult_ClearClaimedRoomId"></a> ClearClaimedRoomId\(\)

```csharp
public void ClearClaimedRoomId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_CavernChallengeResult_ClearCompletedPathId"></a> ClearCompletedPathId\(\)

```csharp
public void ClearCompletedPathId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_CavernChallengeResult_Clone"></a> Clone\(\)

```csharp
public CDOTAMatchMetadata.Types.Team.Types.CavernChallengeResult Clone()
```

#### Returns

 [CDOTAMatchMetadata](Divine.Protobufs.Dota2.CDOTAMatchMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.md).[Team](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.md).[CavernChallengeResult](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.CavernChallengeResult.md)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_CavernChallengeResult_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_CavernChallengeResult_Equals_Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_CavernChallengeResult_"></a> Equals\(CavernChallengeResult\)

```csharp
public bool Equals(CDOTAMatchMetadata.Types.Team.Types.CavernChallengeResult other)
```

#### Parameters

`other` [CDOTAMatchMetadata](Divine.Protobufs.Dota2.CDOTAMatchMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.md).[Team](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.md).[CavernChallengeResult](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.CavernChallengeResult.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_CavernChallengeResult_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_CavernChallengeResult_MergeFrom_Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_CavernChallengeResult_"></a> MergeFrom\(CavernChallengeResult\)

```csharp
public void MergeFrom(CDOTAMatchMetadata.Types.Team.Types.CavernChallengeResult other)
```

#### Parameters

`other` [CDOTAMatchMetadata](Divine.Protobufs.Dota2.CDOTAMatchMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.md).[Team](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.md).[CavernChallengeResult](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.CavernChallengeResult.md)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_CavernChallengeResult_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_CavernChallengeResult_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_CavernChallengeResult_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

