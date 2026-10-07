# <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team"></a> Class CDOTAMatchPrivateMetadata.Types.Team

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAMatchPrivateMetadata.Types.Team : IMessage<CDOTAMatchPrivateMetadata.Types.Team>, IEquatable<CDOTAMatchPrivateMetadata.Types.Team>, IDeepCloneable<CDOTAMatchPrivateMetadata.Types.Team>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAMatchPrivateMetadata.Types.Team](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.md)

#### Implements

IMessage<CDOTAMatchPrivateMetadata.Types.Team\>, 
[IEquatable<CDOTAMatchPrivateMetadata.Types.Team\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAMatchPrivateMetadata.Types.Team\>, 
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
[EnumerableExtensions.In<CDOTAMatchPrivateMetadata.Types.Team\>\(CDOTAMatchPrivateMetadata.Types.Team, params CDOTAMatchPrivateMetadata.Types.Team\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team__ctor"></a> Team\(\)

```csharp
public Team()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team__ctor_Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_"></a> Team\(Team\)

```csharp
public Team(CDOTAMatchPrivateMetadata.Types.Team other)
```

#### Parameters

`other` [CDOTAMatchPrivateMetadata](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.md).[Team](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_BuildingsFieldNumber"></a> BuildingsFieldNumber

```csharp
public const int BuildingsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_DotaTeamFieldNumber"></a> DotaTeamFieldNumber

```csharp
public const int DotaTeamFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_PlayersFieldNumber"></a> PlayersFieldNumber

```csharp
public const int PlayersFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Buildings"></a> Buildings

```csharp
public RepeatedField<CDOTAMatchPrivateMetadata.Types.Team.Types.Building> Buildings { get; }
```

#### Property Value

 RepeatedField<[CDOTAMatchPrivateMetadata](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.md).[Team](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.md).[Building](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.Building.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_DotaTeam"></a> DotaTeam

```csharp
public uint DotaTeam { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_HasDotaTeam"></a> HasDotaTeam

```csharp
public bool HasDotaTeam { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAMatchPrivateMetadata.Types.Team> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAMatchPrivateMetadata](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.md).[Team](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Players"></a> Players

```csharp
public RepeatedField<CDOTAMatchPrivateMetadata.Types.Team.Types.Player> Players { get; }
```

#### Property Value

 RepeatedField<[CDOTAMatchPrivateMetadata](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.md).[Team](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.md).[Player](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.Types.Player.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_ClearDotaTeam"></a> ClearDotaTeam\(\)

```csharp
public void ClearDotaTeam()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Clone"></a> Clone\(\)

```csharp
public CDOTAMatchPrivateMetadata.Types.Team Clone()
```

#### Returns

 [CDOTAMatchPrivateMetadata](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.md).[Team](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.md)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_Equals_Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_"></a> Equals\(Team\)

```csharp
public bool Equals(CDOTAMatchPrivateMetadata.Types.Team other)
```

#### Parameters

`other` [CDOTAMatchPrivateMetadata](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.md).[Team](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_MergeFrom_Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_"></a> MergeFrom\(Team\)

```csharp
public void MergeFrom(CDOTAMatchPrivateMetadata.Types.Team other)
```

#### Parameters

`other` [CDOTAMatchPrivateMetadata](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.md).[Types](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.md).[Team](Divine.Protobufs.Dota2.CDOTAMatchPrivateMetadata.Types.Team.md)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAMatchPrivateMetadata_Types_Team_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

