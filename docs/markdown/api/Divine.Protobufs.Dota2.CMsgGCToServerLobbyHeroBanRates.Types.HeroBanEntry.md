# <a id="Divine_Protobufs_Dota2_CMsgGCToServerLobbyHeroBanRates_Types_HeroBanEntry"></a> Class CMsgGCToServerLobbyHeroBanRates.Types.HeroBanEntry

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToServerLobbyHeroBanRates.Types.HeroBanEntry : IMessage<CMsgGCToServerLobbyHeroBanRates.Types.HeroBanEntry>, IEquatable<CMsgGCToServerLobbyHeroBanRates.Types.HeroBanEntry>, IDeepCloneable<CMsgGCToServerLobbyHeroBanRates.Types.HeroBanEntry>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToServerLobbyHeroBanRates.Types.HeroBanEntry](Divine.Protobufs.Dota2.CMsgGCToServerLobbyHeroBanRates.Types.HeroBanEntry.md)

#### Implements

IMessage<CMsgGCToServerLobbyHeroBanRates.Types.HeroBanEntry\>, 
[IEquatable<CMsgGCToServerLobbyHeroBanRates.Types.HeroBanEntry\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToServerLobbyHeroBanRates.Types.HeroBanEntry\>, 
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
[EnumerableExtensions.In<CMsgGCToServerLobbyHeroBanRates.Types.HeroBanEntry\>\(CMsgGCToServerLobbyHeroBanRates.Types.HeroBanEntry, params CMsgGCToServerLobbyHeroBanRates.Types.HeroBanEntry\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerLobbyHeroBanRates_Types_HeroBanEntry__ctor"></a> HeroBanEntry\(\)

```csharp
public HeroBanEntry()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerLobbyHeroBanRates_Types_HeroBanEntry__ctor_Divine_Protobufs_Dota2_CMsgGCToServerLobbyHeroBanRates_Types_HeroBanEntry_"></a> HeroBanEntry\(HeroBanEntry\)

```csharp
public HeroBanEntry(CMsgGCToServerLobbyHeroBanRates.Types.HeroBanEntry other)
```

#### Parameters

`other` [CMsgGCToServerLobbyHeroBanRates](Divine.Protobufs.Dota2.CMsgGCToServerLobbyHeroBanRates.md).[Types](Divine.Protobufs.Dota2.CMsgGCToServerLobbyHeroBanRates.Types.md).[HeroBanEntry](Divine.Protobufs.Dota2.CMsgGCToServerLobbyHeroBanRates.Types.HeroBanEntry.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerLobbyHeroBanRates_Types_HeroBanEntry_BanCountFieldNumber"></a> BanCountFieldNumber

```csharp
public const int BanCountFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerLobbyHeroBanRates_Types_HeroBanEntry_HeroIdFieldNumber"></a> HeroIdFieldNumber

```csharp
public const int HeroIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerLobbyHeroBanRates_Types_HeroBanEntry_PickCountFieldNumber"></a> PickCountFieldNumber

```csharp
public const int PickCountFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerLobbyHeroBanRates_Types_HeroBanEntry_BanCount"></a> BanCount

```csharp
public uint BanCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerLobbyHeroBanRates_Types_HeroBanEntry_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerLobbyHeroBanRates_Types_HeroBanEntry_HasBanCount"></a> HasBanCount

```csharp
public bool HasBanCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerLobbyHeroBanRates_Types_HeroBanEntry_HasHeroId"></a> HasHeroId

```csharp
public bool HasHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerLobbyHeroBanRates_Types_HeroBanEntry_HasPickCount"></a> HasPickCount

```csharp
public bool HasPickCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerLobbyHeroBanRates_Types_HeroBanEntry_HeroId"></a> HeroId

```csharp
public int HeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerLobbyHeroBanRates_Types_HeroBanEntry_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToServerLobbyHeroBanRates.Types.HeroBanEntry> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToServerLobbyHeroBanRates](Divine.Protobufs.Dota2.CMsgGCToServerLobbyHeroBanRates.md).[Types](Divine.Protobufs.Dota2.CMsgGCToServerLobbyHeroBanRates.Types.md).[HeroBanEntry](Divine.Protobufs.Dota2.CMsgGCToServerLobbyHeroBanRates.Types.HeroBanEntry.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerLobbyHeroBanRates_Types_HeroBanEntry_PickCount"></a> PickCount

```csharp
public uint PickCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerLobbyHeroBanRates_Types_HeroBanEntry_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerLobbyHeroBanRates_Types_HeroBanEntry_ClearBanCount"></a> ClearBanCount\(\)

```csharp
public void ClearBanCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerLobbyHeroBanRates_Types_HeroBanEntry_ClearHeroId"></a> ClearHeroId\(\)

```csharp
public void ClearHeroId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerLobbyHeroBanRates_Types_HeroBanEntry_ClearPickCount"></a> ClearPickCount\(\)

```csharp
public void ClearPickCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerLobbyHeroBanRates_Types_HeroBanEntry_Clone"></a> Clone\(\)

```csharp
public CMsgGCToServerLobbyHeroBanRates.Types.HeroBanEntry Clone()
```

#### Returns

 [CMsgGCToServerLobbyHeroBanRates](Divine.Protobufs.Dota2.CMsgGCToServerLobbyHeroBanRates.md).[Types](Divine.Protobufs.Dota2.CMsgGCToServerLobbyHeroBanRates.Types.md).[HeroBanEntry](Divine.Protobufs.Dota2.CMsgGCToServerLobbyHeroBanRates.Types.HeroBanEntry.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerLobbyHeroBanRates_Types_HeroBanEntry_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerLobbyHeroBanRates_Types_HeroBanEntry_Equals_Divine_Protobufs_Dota2_CMsgGCToServerLobbyHeroBanRates_Types_HeroBanEntry_"></a> Equals\(HeroBanEntry\)

```csharp
public bool Equals(CMsgGCToServerLobbyHeroBanRates.Types.HeroBanEntry other)
```

#### Parameters

`other` [CMsgGCToServerLobbyHeroBanRates](Divine.Protobufs.Dota2.CMsgGCToServerLobbyHeroBanRates.md).[Types](Divine.Protobufs.Dota2.CMsgGCToServerLobbyHeroBanRates.Types.md).[HeroBanEntry](Divine.Protobufs.Dota2.CMsgGCToServerLobbyHeroBanRates.Types.HeroBanEntry.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerLobbyHeroBanRates_Types_HeroBanEntry_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerLobbyHeroBanRates_Types_HeroBanEntry_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToServerLobbyHeroBanRates_Types_HeroBanEntry_"></a> MergeFrom\(HeroBanEntry\)

```csharp
public void MergeFrom(CMsgGCToServerLobbyHeroBanRates.Types.HeroBanEntry other)
```

#### Parameters

`other` [CMsgGCToServerLobbyHeroBanRates](Divine.Protobufs.Dota2.CMsgGCToServerLobbyHeroBanRates.md).[Types](Divine.Protobufs.Dota2.CMsgGCToServerLobbyHeroBanRates.Types.md).[HeroBanEntry](Divine.Protobufs.Dota2.CMsgGCToServerLobbyHeroBanRates.Types.HeroBanEntry.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerLobbyHeroBanRates_Types_HeroBanEntry_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerLobbyHeroBanRates_Types_HeroBanEntry_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerLobbyHeroBanRates_Types_HeroBanEntry_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

