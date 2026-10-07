# <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_Player_Types_OverworldRewards"></a> Class CDOTAMatchMetadata.Types.Team.Types.Player.Types.OverworldRewards

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAMatchMetadata.Types.Team.Types.Player.Types.OverworldRewards : IMessage<CDOTAMatchMetadata.Types.Team.Types.Player.Types.OverworldRewards>, IEquatable<CDOTAMatchMetadata.Types.Team.Types.Player.Types.OverworldRewards>, IDeepCloneable<CDOTAMatchMetadata.Types.Team.Types.Player.Types.OverworldRewards>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAMatchMetadata.Types.Team.Types.Player.Types.OverworldRewards](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.Player.Types.OverworldRewards.md)

#### Implements

IMessage<CDOTAMatchMetadata.Types.Team.Types.Player.Types.OverworldRewards\>, 
[IEquatable<CDOTAMatchMetadata.Types.Team.Types.Player.Types.OverworldRewards\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAMatchMetadata.Types.Team.Types.Player.Types.OverworldRewards\>, 
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
[EnumerableExtensions.In<CDOTAMatchMetadata.Types.Team.Types.Player.Types.OverworldRewards\>\(CDOTAMatchMetadata.Types.Team.Types.Player.Types.OverworldRewards, params CDOTAMatchMetadata.Types.Team.Types.Player.Types.OverworldRewards\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_Player_Types_OverworldRewards__ctor"></a> OverworldRewards\(\)

```csharp
public OverworldRewards()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_Player_Types_OverworldRewards__ctor_Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_Player_Types_OverworldRewards_"></a> OverworldRewards\(OverworldRewards\)

```csharp
public OverworldRewards(CDOTAMatchMetadata.Types.Team.Types.Player.Types.OverworldRewards other)
```

#### Parameters

`other` [CDOTAMatchMetadata](Divine.Protobufs.Dota2.CDOTAMatchMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.md).[Team](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.md).[Player](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.Player.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.Player.Types.md).[OverworldRewards](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.Player.Types.OverworldRewards.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_Player_Types_OverworldRewards_OverworldIdFieldNumber"></a> OverworldIdFieldNumber

```csharp
public const int OverworldIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_Player_Types_OverworldRewards_TokensFieldNumber"></a> TokensFieldNumber

```csharp
public const int TokensFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_Player_Types_OverworldRewards_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_Player_Types_OverworldRewards_HasOverworldId"></a> HasOverworldId

```csharp
public bool HasOverworldId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_Player_Types_OverworldRewards_OverworldId"></a> OverworldId

```csharp
public uint OverworldId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_Player_Types_OverworldRewards_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAMatchMetadata.Types.Team.Types.Player.Types.OverworldRewards> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAMatchMetadata](Divine.Protobufs.Dota2.CDOTAMatchMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.md).[Team](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.md).[Player](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.Player.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.Player.Types.md).[OverworldRewards](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.Player.Types.OverworldRewards.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_Player_Types_OverworldRewards_Tokens"></a> Tokens

```csharp
public CMsgOverworldTokenQuantity Tokens { get; set; }
```

#### Property Value

 [CMsgOverworldTokenQuantity](Divine.Protobufs.Dota2.CMsgOverworldTokenQuantity.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_Player_Types_OverworldRewards_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_Player_Types_OverworldRewards_ClearOverworldId"></a> ClearOverworldId\(\)

```csharp
public void ClearOverworldId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_Player_Types_OverworldRewards_Clone"></a> Clone\(\)

```csharp
public CDOTAMatchMetadata.Types.Team.Types.Player.Types.OverworldRewards Clone()
```

#### Returns

 [CDOTAMatchMetadata](Divine.Protobufs.Dota2.CDOTAMatchMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.md).[Team](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.md).[Player](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.Player.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.Player.Types.md).[OverworldRewards](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.Player.Types.OverworldRewards.md)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_Player_Types_OverworldRewards_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_Player_Types_OverworldRewards_Equals_Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_Player_Types_OverworldRewards_"></a> Equals\(OverworldRewards\)

```csharp
public bool Equals(CDOTAMatchMetadata.Types.Team.Types.Player.Types.OverworldRewards other)
```

#### Parameters

`other` [CDOTAMatchMetadata](Divine.Protobufs.Dota2.CDOTAMatchMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.md).[Team](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.md).[Player](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.Player.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.Player.Types.md).[OverworldRewards](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.Player.Types.OverworldRewards.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_Player_Types_OverworldRewards_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_Player_Types_OverworldRewards_MergeFrom_Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_Player_Types_OverworldRewards_"></a> MergeFrom\(OverworldRewards\)

```csharp
public void MergeFrom(CDOTAMatchMetadata.Types.Team.Types.Player.Types.OverworldRewards other)
```

#### Parameters

`other` [CDOTAMatchMetadata](Divine.Protobufs.Dota2.CDOTAMatchMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.md).[Team](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.md).[Player](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.Player.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.Player.Types.md).[OverworldRewards](Divine.Protobufs.Dota2.CDOTAMatchMetadata.Types.Team.Types.Player.Types.OverworldRewards.md)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_Player_Types_OverworldRewards_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_Player_Types_OverworldRewards_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchMetadata_Types_Team_Types_Player_Types_OverworldRewards_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

