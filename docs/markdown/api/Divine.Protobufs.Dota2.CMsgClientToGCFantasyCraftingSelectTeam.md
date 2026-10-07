# <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectTeam"></a> Class CMsgClientToGCFantasyCraftingSelectTeam

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCFantasyCraftingSelectTeam : IMessage<CMsgClientToGCFantasyCraftingSelectTeam>, IEquatable<CMsgClientToGCFantasyCraftingSelectTeam>, IDeepCloneable<CMsgClientToGCFantasyCraftingSelectTeam>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCFantasyCraftingSelectTeam](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingSelectTeam.md)

#### Implements

IMessage<CMsgClientToGCFantasyCraftingSelectTeam\>, 
[IEquatable<CMsgClientToGCFantasyCraftingSelectTeam\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCFantasyCraftingSelectTeam\>, 
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
[EnumerableExtensions.In<CMsgClientToGCFantasyCraftingSelectTeam\>\(CMsgClientToGCFantasyCraftingSelectTeam, params CMsgClientToGCFantasyCraftingSelectTeam\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectTeam__ctor"></a> CMsgClientToGCFantasyCraftingSelectTeam\(\)

```csharp
public CMsgClientToGCFantasyCraftingSelectTeam()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectTeam__ctor_Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectTeam_"></a> CMsgClientToGCFantasyCraftingSelectTeam\(CMsgClientToGCFantasyCraftingSelectTeam\)

```csharp
public CMsgClientToGCFantasyCraftingSelectTeam(CMsgClientToGCFantasyCraftingSelectTeam other)
```

#### Parameters

`other` [CMsgClientToGCFantasyCraftingSelectTeam](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingSelectTeam.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectTeam_FantasyLeagueFieldNumber"></a> FantasyLeagueFieldNumber

```csharp
public const int FantasyLeagueFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectTeam_RoleFieldNumber"></a> RoleFieldNumber

```csharp
public const int RoleFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectTeam_TeamIdFieldNumber"></a> TeamIdFieldNumber

```csharp
public const int TeamIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectTeam_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectTeam_FantasyLeague"></a> FantasyLeague

```csharp
public uint FantasyLeague { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectTeam_HasFantasyLeague"></a> HasFantasyLeague

```csharp
public bool HasFantasyLeague { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectTeam_HasRole"></a> HasRole

```csharp
public bool HasRole { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectTeam_HasTeamId"></a> HasTeamId

```csharp
public bool HasTeamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectTeam_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCFantasyCraftingSelectTeam> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCFantasyCraftingSelectTeam](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingSelectTeam.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectTeam_Role"></a> Role

```csharp
public Fantasy_Roles Role { get; set; }
```

#### Property Value

 [Fantasy\_Roles](Divine.Protobufs.Dota2.Fantasy\_Roles.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectTeam_TeamId"></a> TeamId

```csharp
public uint TeamId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectTeam_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectTeam_ClearFantasyLeague"></a> ClearFantasyLeague\(\)

```csharp
public void ClearFantasyLeague()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectTeam_ClearRole"></a> ClearRole\(\)

```csharp
public void ClearRole()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectTeam_ClearTeamId"></a> ClearTeamId\(\)

```csharp
public void ClearTeamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectTeam_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCFantasyCraftingSelectTeam Clone()
```

#### Returns

 [CMsgClientToGCFantasyCraftingSelectTeam](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingSelectTeam.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectTeam_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectTeam_Equals_Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectTeam_"></a> Equals\(CMsgClientToGCFantasyCraftingSelectTeam\)

```csharp
public bool Equals(CMsgClientToGCFantasyCraftingSelectTeam other)
```

#### Parameters

`other` [CMsgClientToGCFantasyCraftingSelectTeam](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingSelectTeam.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectTeam_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectTeam_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectTeam_"></a> MergeFrom\(CMsgClientToGCFantasyCraftingSelectTeam\)

```csharp
public void MergeFrom(CMsgClientToGCFantasyCraftingSelectTeam other)
```

#### Parameters

`other` [CMsgClientToGCFantasyCraftingSelectTeam](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingSelectTeam.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectTeam_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectTeam_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectTeam_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

