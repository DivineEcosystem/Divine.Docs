# <a id="Divine_Protobufs_Dota2_CMsgOverworldUserData"></a> Class CMsgOverworldUserData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgOverworldUserData : IMessage<CMsgOverworldUserData>, IEquatable<CMsgOverworldUserData>, IDeepCloneable<CMsgOverworldUserData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgOverworldUserData](Divine.Protobufs.Dota2.CMsgOverworldUserData.md)

#### Implements

IMessage<CMsgOverworldUserData\>, 
[IEquatable<CMsgOverworldUserData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgOverworldUserData\>, 
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
[EnumerableExtensions.In<CMsgOverworldUserData\>\(CMsgOverworldUserData, params CMsgOverworldUserData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgOverworldUserData__ctor"></a> CMsgOverworldUserData\(\)

```csharp
public CMsgOverworldUserData()
```

### <a id="Divine_Protobufs_Dota2_CMsgOverworldUserData__ctor_Divine_Protobufs_Dota2_CMsgOverworldUserData_"></a> CMsgOverworldUserData\(CMsgOverworldUserData\)

```csharp
public CMsgOverworldUserData(CMsgOverworldUserData other)
```

#### Parameters

`other` [CMsgOverworldUserData](Divine.Protobufs.Dota2.CMsgOverworldUserData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgOverworldUserData_CurrentFortuneFieldNumber"></a> CurrentFortuneFieldNumber

```csharp
public const int CurrentFortuneFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldUserData_CurrentNodeIdFieldNumber"></a> CurrentNodeIdFieldNumber

```csharp
public const int CurrentNodeIdFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldUserData_LastRelatedHeroIdFieldNumber"></a> LastRelatedHeroIdFieldNumber

```csharp
public const int LastRelatedHeroIdFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldUserData_MinigameDataFieldNumber"></a> MinigameDataFieldNumber

```csharp
public const int MinigameDataFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldUserData_OverworldNodesFieldNumber"></a> OverworldNodesFieldNumber

```csharp
public const int OverworldNodesFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldUserData_OverworldPathsFieldNumber"></a> OverworldPathsFieldNumber

```csharp
public const int OverworldPathsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldUserData_OverworldVersionFieldNumber"></a> OverworldVersionFieldNumber

```csharp
public const int OverworldVersionFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldUserData_TokenInventoryFieldNumber"></a> TokenInventoryFieldNumber

```csharp
public const int TokenInventoryFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgOverworldUserData_CurrentFortune"></a> CurrentFortune

```csharp
public CMsgOverworldFortune CurrentFortune { get; set; }
```

#### Property Value

 [CMsgOverworldFortune](Divine.Protobufs.Dota2.CMsgOverworldFortune.md)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldUserData_CurrentNodeId"></a> CurrentNodeId

```csharp
public uint CurrentNodeId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldUserData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgOverworldUserData_HasCurrentNodeId"></a> HasCurrentNodeId

```csharp
public bool HasCurrentNodeId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldUserData_HasLastRelatedHeroId"></a> HasLastRelatedHeroId

```csharp
public bool HasLastRelatedHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldUserData_HasOverworldVersion"></a> HasOverworldVersion

```csharp
public bool HasOverworldVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldUserData_LastRelatedHeroId"></a> LastRelatedHeroId

```csharp
public int LastRelatedHeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldUserData_MinigameData"></a> MinigameData

```csharp
public MapField<uint, CMsgOverworldMinigameUserData> MinigameData { get; }
```

#### Property Value

 MapField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32), [CMsgOverworldMinigameUserData](Divine.Protobufs.Dota2.CMsgOverworldMinigameUserData.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgOverworldUserData_OverworldNodes"></a> OverworldNodes

```csharp
public RepeatedField<CMsgOverworldNode> OverworldNodes { get; }
```

#### Property Value

 RepeatedField<[CMsgOverworldNode](Divine.Protobufs.Dota2.CMsgOverworldNode.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgOverworldUserData_OverworldPaths"></a> OverworldPaths

```csharp
public RepeatedField<CMsgOverworldPath> OverworldPaths { get; }
```

#### Property Value

 RepeatedField<[CMsgOverworldPath](Divine.Protobufs.Dota2.CMsgOverworldPath.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgOverworldUserData_OverworldVersion"></a> OverworldVersion

```csharp
public uint OverworldVersion { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldUserData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgOverworldUserData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgOverworldUserData](Divine.Protobufs.Dota2.CMsgOverworldUserData.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgOverworldUserData_TokenInventory"></a> TokenInventory

```csharp
public CMsgOverworldTokenQuantity TokenInventory { get; set; }
```

#### Property Value

 [CMsgOverworldTokenQuantity](Divine.Protobufs.Dota2.CMsgOverworldTokenQuantity.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgOverworldUserData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldUserData_ClearCurrentNodeId"></a> ClearCurrentNodeId\(\)

```csharp
public void ClearCurrentNodeId()
```

### <a id="Divine_Protobufs_Dota2_CMsgOverworldUserData_ClearLastRelatedHeroId"></a> ClearLastRelatedHeroId\(\)

```csharp
public void ClearLastRelatedHeroId()
```

### <a id="Divine_Protobufs_Dota2_CMsgOverworldUserData_ClearOverworldVersion"></a> ClearOverworldVersion\(\)

```csharp
public void ClearOverworldVersion()
```

### <a id="Divine_Protobufs_Dota2_CMsgOverworldUserData_Clone"></a> Clone\(\)

```csharp
public CMsgOverworldUserData Clone()
```

#### Returns

 [CMsgOverworldUserData](Divine.Protobufs.Dota2.CMsgOverworldUserData.md)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldUserData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldUserData_Equals_Divine_Protobufs_Dota2_CMsgOverworldUserData_"></a> Equals\(CMsgOverworldUserData\)

```csharp
public bool Equals(CMsgOverworldUserData other)
```

#### Parameters

`other` [CMsgOverworldUserData](Divine.Protobufs.Dota2.CMsgOverworldUserData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldUserData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldUserData_MergeFrom_Divine_Protobufs_Dota2_CMsgOverworldUserData_"></a> MergeFrom\(CMsgOverworldUserData\)

```csharp
public void MergeFrom(CMsgOverworldUserData other)
```

#### Parameters

`other` [CMsgOverworldUserData](Divine.Protobufs.Dota2.CMsgOverworldUserData.md)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldUserData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgOverworldUserData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldUserData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

