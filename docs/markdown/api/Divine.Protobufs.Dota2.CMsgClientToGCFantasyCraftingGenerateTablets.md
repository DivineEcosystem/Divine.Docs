# <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTablets"></a> Class CMsgClientToGCFantasyCraftingGenerateTablets

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCFantasyCraftingGenerateTablets : IMessage<CMsgClientToGCFantasyCraftingGenerateTablets>, IEquatable<CMsgClientToGCFantasyCraftingGenerateTablets>, IDeepCloneable<CMsgClientToGCFantasyCraftingGenerateTablets>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCFantasyCraftingGenerateTablets](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingGenerateTablets.md)

#### Implements

IMessage<CMsgClientToGCFantasyCraftingGenerateTablets\>, 
[IEquatable<CMsgClientToGCFantasyCraftingGenerateTablets\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCFantasyCraftingGenerateTablets\>, 
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
[EnumerableExtensions.In<CMsgClientToGCFantasyCraftingGenerateTablets\>\(CMsgClientToGCFantasyCraftingGenerateTablets, params CMsgClientToGCFantasyCraftingGenerateTablets\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTablets__ctor"></a> CMsgClientToGCFantasyCraftingGenerateTablets\(\)

```csharp
public CMsgClientToGCFantasyCraftingGenerateTablets()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTablets__ctor_Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTablets_"></a> CMsgClientToGCFantasyCraftingGenerateTablets\(CMsgClientToGCFantasyCraftingGenerateTablets\)

```csharp
public CMsgClientToGCFantasyCraftingGenerateTablets(CMsgClientToGCFantasyCraftingGenerateTablets other)
```

#### Parameters

`other` [CMsgClientToGCFantasyCraftingGenerateTablets](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingGenerateTablets.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTablets_AccountIdsFieldNumber"></a> AccountIdsFieldNumber

```csharp
public const int AccountIdsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTablets_FantasyLeagueFieldNumber"></a> FantasyLeagueFieldNumber

```csharp
public const int FantasyLeagueFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTablets_SelectedTeamsFieldNumber"></a> SelectedTeamsFieldNumber

```csharp
public const int SelectedTeamsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTablets_AccountIds"></a> AccountIds

```csharp
public RepeatedField<uint> AccountIds { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTablets_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTablets_FantasyLeague"></a> FantasyLeague

```csharp
public uint FantasyLeague { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTablets_HasFantasyLeague"></a> HasFantasyLeague

```csharp
public bool HasFantasyLeague { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTablets_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCFantasyCraftingGenerateTablets> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCFantasyCraftingGenerateTablets](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingGenerateTablets.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTablets_SelectedTeams"></a> SelectedTeams

```csharp
public RepeatedField<CMsgClientToGCFantasyCraftingGenerateTablets.Types.TeamChoice> SelectedTeams { get; }
```

#### Property Value

 RepeatedField<[CMsgClientToGCFantasyCraftingGenerateTablets](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingGenerateTablets.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingGenerateTablets.Types.md).[TeamChoice](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingGenerateTablets.Types.TeamChoice.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTablets_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTablets_ClearFantasyLeague"></a> ClearFantasyLeague\(\)

```csharp
public void ClearFantasyLeague()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTablets_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCFantasyCraftingGenerateTablets Clone()
```

#### Returns

 [CMsgClientToGCFantasyCraftingGenerateTablets](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingGenerateTablets.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTablets_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTablets_Equals_Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTablets_"></a> Equals\(CMsgClientToGCFantasyCraftingGenerateTablets\)

```csharp
public bool Equals(CMsgClientToGCFantasyCraftingGenerateTablets other)
```

#### Parameters

`other` [CMsgClientToGCFantasyCraftingGenerateTablets](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingGenerateTablets.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTablets_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTablets_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTablets_"></a> MergeFrom\(CMsgClientToGCFantasyCraftingGenerateTablets\)

```csharp
public void MergeFrom(CMsgClientToGCFantasyCraftingGenerateTablets other)
```

#### Parameters

`other` [CMsgClientToGCFantasyCraftingGenerateTablets](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingGenerateTablets.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTablets_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTablets_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTablets_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

