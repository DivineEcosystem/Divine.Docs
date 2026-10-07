# <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTablets_Types_TeamChoice"></a> Class CMsgClientToGCFantasyCraftingGenerateTablets.Types.TeamChoice

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCFantasyCraftingGenerateTablets.Types.TeamChoice : IMessage<CMsgClientToGCFantasyCraftingGenerateTablets.Types.TeamChoice>, IEquatable<CMsgClientToGCFantasyCraftingGenerateTablets.Types.TeamChoice>, IDeepCloneable<CMsgClientToGCFantasyCraftingGenerateTablets.Types.TeamChoice>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCFantasyCraftingGenerateTablets.Types.TeamChoice](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingGenerateTablets.Types.TeamChoice.md)

#### Implements

IMessage<CMsgClientToGCFantasyCraftingGenerateTablets.Types.TeamChoice\>, 
[IEquatable<CMsgClientToGCFantasyCraftingGenerateTablets.Types.TeamChoice\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCFantasyCraftingGenerateTablets.Types.TeamChoice\>, 
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
[EnumerableExtensions.In<CMsgClientToGCFantasyCraftingGenerateTablets.Types.TeamChoice\>\(CMsgClientToGCFantasyCraftingGenerateTablets.Types.TeamChoice, params CMsgClientToGCFantasyCraftingGenerateTablets.Types.TeamChoice\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTablets_Types_TeamChoice__ctor"></a> TeamChoice\(\)

```csharp
public TeamChoice()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTablets_Types_TeamChoice__ctor_Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTablets_Types_TeamChoice_"></a> TeamChoice\(TeamChoice\)

```csharp
public TeamChoice(CMsgClientToGCFantasyCraftingGenerateTablets.Types.TeamChoice other)
```

#### Parameters

`other` [CMsgClientToGCFantasyCraftingGenerateTablets](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingGenerateTablets.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingGenerateTablets.Types.md).[TeamChoice](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingGenerateTablets.Types.TeamChoice.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTablets_Types_TeamChoice_FantasyRoleFieldNumber"></a> FantasyRoleFieldNumber

```csharp
public const int FantasyRoleFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTablets_Types_TeamChoice_TeamIdFieldNumber"></a> TeamIdFieldNumber

```csharp
public const int TeamIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTablets_Types_TeamChoice_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTablets_Types_TeamChoice_FantasyRole"></a> FantasyRole

```csharp
public Fantasy_Roles FantasyRole { get; set; }
```

#### Property Value

 [Fantasy\_Roles](Divine.Protobufs.Dota2.Fantasy\_Roles.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTablets_Types_TeamChoice_HasFantasyRole"></a> HasFantasyRole

```csharp
public bool HasFantasyRole { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTablets_Types_TeamChoice_HasTeamId"></a> HasTeamId

```csharp
public bool HasTeamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTablets_Types_TeamChoice_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCFantasyCraftingGenerateTablets.Types.TeamChoice> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCFantasyCraftingGenerateTablets](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingGenerateTablets.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingGenerateTablets.Types.md).[TeamChoice](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingGenerateTablets.Types.TeamChoice.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTablets_Types_TeamChoice_TeamId"></a> TeamId

```csharp
public uint TeamId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTablets_Types_TeamChoice_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTablets_Types_TeamChoice_ClearFantasyRole"></a> ClearFantasyRole\(\)

```csharp
public void ClearFantasyRole()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTablets_Types_TeamChoice_ClearTeamId"></a> ClearTeamId\(\)

```csharp
public void ClearTeamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTablets_Types_TeamChoice_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCFantasyCraftingGenerateTablets.Types.TeamChoice Clone()
```

#### Returns

 [CMsgClientToGCFantasyCraftingGenerateTablets](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingGenerateTablets.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingGenerateTablets.Types.md).[TeamChoice](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingGenerateTablets.Types.TeamChoice.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTablets_Types_TeamChoice_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTablets_Types_TeamChoice_Equals_Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTablets_Types_TeamChoice_"></a> Equals\(TeamChoice\)

```csharp
public bool Equals(CMsgClientToGCFantasyCraftingGenerateTablets.Types.TeamChoice other)
```

#### Parameters

`other` [CMsgClientToGCFantasyCraftingGenerateTablets](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingGenerateTablets.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingGenerateTablets.Types.md).[TeamChoice](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingGenerateTablets.Types.TeamChoice.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTablets_Types_TeamChoice_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTablets_Types_TeamChoice_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTablets_Types_TeamChoice_"></a> MergeFrom\(TeamChoice\)

```csharp
public void MergeFrom(CMsgClientToGCFantasyCraftingGenerateTablets.Types.TeamChoice other)
```

#### Parameters

`other` [CMsgClientToGCFantasyCraftingGenerateTablets](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingGenerateTablets.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingGenerateTablets.Types.md).[TeamChoice](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingGenerateTablets.Types.TeamChoice.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTablets_Types_TeamChoice_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTablets_Types_TeamChoice_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTablets_Types_TeamChoice_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

