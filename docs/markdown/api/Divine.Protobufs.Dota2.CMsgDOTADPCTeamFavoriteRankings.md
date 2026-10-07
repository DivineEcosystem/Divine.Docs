# <a id="Divine_Protobufs_Dota2_CMsgDOTADPCTeamFavoriteRankings"></a> Class CMsgDOTADPCTeamFavoriteRankings

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTADPCTeamFavoriteRankings : IMessage<CMsgDOTADPCTeamFavoriteRankings>, IEquatable<CMsgDOTADPCTeamFavoriteRankings>, IDeepCloneable<CMsgDOTADPCTeamFavoriteRankings>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTADPCTeamFavoriteRankings](Divine.Protobufs.Dota2.CMsgDOTADPCTeamFavoriteRankings.md)

#### Implements

IMessage<CMsgDOTADPCTeamFavoriteRankings\>, 
[IEquatable<CMsgDOTADPCTeamFavoriteRankings\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTADPCTeamFavoriteRankings\>, 
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
[EnumerableExtensions.In<CMsgDOTADPCTeamFavoriteRankings\>\(CMsgDOTADPCTeamFavoriteRankings, params CMsgDOTADPCTeamFavoriteRankings\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCTeamFavoriteRankings__ctor"></a> CMsgDOTADPCTeamFavoriteRankings\(\)

```csharp
public CMsgDOTADPCTeamFavoriteRankings()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCTeamFavoriteRankings__ctor_Divine_Protobufs_Dota2_CMsgDOTADPCTeamFavoriteRankings_"></a> CMsgDOTADPCTeamFavoriteRankings\(CMsgDOTADPCTeamFavoriteRankings\)

```csharp
public CMsgDOTADPCTeamFavoriteRankings(CMsgDOTADPCTeamFavoriteRankings other)
```

#### Parameters

`other` [CMsgDOTADPCTeamFavoriteRankings](Divine.Protobufs.Dota2.CMsgDOTADPCTeamFavoriteRankings.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCTeamFavoriteRankings_TeamsFieldNumber"></a> TeamsFieldNumber

```csharp
public const int TeamsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCTeamFavoriteRankings_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCTeamFavoriteRankings_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTADPCTeamFavoriteRankings> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTADPCTeamFavoriteRankings](Divine.Protobufs.Dota2.CMsgDOTADPCTeamFavoriteRankings.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCTeamFavoriteRankings_Teams"></a> Teams

```csharp
public RepeatedField<CMsgDOTADPCTeamFavoriteRankings.Types.Team> Teams { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTADPCTeamFavoriteRankings](Divine.Protobufs.Dota2.CMsgDOTADPCTeamFavoriteRankings.md).[Types](Divine.Protobufs.Dota2.CMsgDOTADPCTeamFavoriteRankings.Types.md).[Team](Divine.Protobufs.Dota2.CMsgDOTADPCTeamFavoriteRankings.Types.Team.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCTeamFavoriteRankings_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCTeamFavoriteRankings_Clone"></a> Clone\(\)

```csharp
public CMsgDOTADPCTeamFavoriteRankings Clone()
```

#### Returns

 [CMsgDOTADPCTeamFavoriteRankings](Divine.Protobufs.Dota2.CMsgDOTADPCTeamFavoriteRankings.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCTeamFavoriteRankings_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCTeamFavoriteRankings_Equals_Divine_Protobufs_Dota2_CMsgDOTADPCTeamFavoriteRankings_"></a> Equals\(CMsgDOTADPCTeamFavoriteRankings\)

```csharp
public bool Equals(CMsgDOTADPCTeamFavoriteRankings other)
```

#### Parameters

`other` [CMsgDOTADPCTeamFavoriteRankings](Divine.Protobufs.Dota2.CMsgDOTADPCTeamFavoriteRankings.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCTeamFavoriteRankings_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCTeamFavoriteRankings_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTADPCTeamFavoriteRankings_"></a> MergeFrom\(CMsgDOTADPCTeamFavoriteRankings\)

```csharp
public void MergeFrom(CMsgDOTADPCTeamFavoriteRankings other)
```

#### Parameters

`other` [CMsgDOTADPCTeamFavoriteRankings](Divine.Protobufs.Dota2.CMsgDOTADPCTeamFavoriteRankings.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCTeamFavoriteRankings_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCTeamFavoriteRankings_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCTeamFavoriteRankings_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

