# <a id="Divine_Protobufs_Dota2_CSOEconItemTournamentPassport"></a> Class CSOEconItemTournamentPassport

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSOEconItemTournamentPassport : IMessage<CSOEconItemTournamentPassport>, IEquatable<CSOEconItemTournamentPassport>, IDeepCloneable<CSOEconItemTournamentPassport>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSOEconItemTournamentPassport](Divine.Protobufs.Dota2.CSOEconItemTournamentPassport.md)

#### Implements

IMessage<CSOEconItemTournamentPassport\>, 
[IEquatable<CSOEconItemTournamentPassport\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSOEconItemTournamentPassport\>, 
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
[EnumerableExtensions.In<CSOEconItemTournamentPassport\>\(CSOEconItemTournamentPassport, params CSOEconItemTournamentPassport\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSOEconItemTournamentPassport__ctor"></a> CSOEconItemTournamentPassport\(\)

```csharp
public CSOEconItemTournamentPassport()
```

### <a id="Divine_Protobufs_Dota2_CSOEconItemTournamentPassport__ctor_Divine_Protobufs_Dota2_CSOEconItemTournamentPassport_"></a> CSOEconItemTournamentPassport\(CSOEconItemTournamentPassport\)

```csharp
public CSOEconItemTournamentPassport(CSOEconItemTournamentPassport other)
```

#### Parameters

`other` [CSOEconItemTournamentPassport](Divine.Protobufs.Dota2.CSOEconItemTournamentPassport.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSOEconItemTournamentPassport_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSOEconItemTournamentPassport_DefIndexFieldNumber"></a> DefIndexFieldNumber

```csharp
public const int DefIndexFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSOEconItemTournamentPassport_ItemIdFieldNumber"></a> ItemIdFieldNumber

```csharp
public const int ItemIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSOEconItemTournamentPassport_LeagueIdFieldNumber"></a> LeagueIdFieldNumber

```csharp
public const int LeagueIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSOEconItemTournamentPassport_OriginalPurchaserIdFieldNumber"></a> OriginalPurchaserIdFieldNumber

```csharp
public const int OriginalPurchaserIdFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSOEconItemTournamentPassport_PassportsBoughtFieldNumber"></a> PassportsBoughtFieldNumber

```csharp
public const int PassportsBoughtFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSOEconItemTournamentPassport_RewardFlagsFieldNumber"></a> RewardFlagsFieldNumber

```csharp
public const int RewardFlagsFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSOEconItemTournamentPassport_VersionFieldNumber"></a> VersionFieldNumber

```csharp
public const int VersionFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSOEconItemTournamentPassport_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSOEconItemTournamentPassport_DefIndex"></a> DefIndex

```csharp
public uint DefIndex { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSOEconItemTournamentPassport_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSOEconItemTournamentPassport_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSOEconItemTournamentPassport_HasDefIndex"></a> HasDefIndex

```csharp
public bool HasDefIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSOEconItemTournamentPassport_HasItemId"></a> HasItemId

```csharp
public bool HasItemId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSOEconItemTournamentPassport_HasLeagueId"></a> HasLeagueId

```csharp
public bool HasLeagueId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSOEconItemTournamentPassport_HasOriginalPurchaserId"></a> HasOriginalPurchaserId

```csharp
public bool HasOriginalPurchaserId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSOEconItemTournamentPassport_HasPassportsBought"></a> HasPassportsBought

```csharp
public bool HasPassportsBought { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSOEconItemTournamentPassport_HasRewardFlags"></a> HasRewardFlags

```csharp
public bool HasRewardFlags { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSOEconItemTournamentPassport_HasVersion"></a> HasVersion

```csharp
public bool HasVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSOEconItemTournamentPassport_ItemId"></a> ItemId

```csharp
public ulong ItemId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CSOEconItemTournamentPassport_LeagueId"></a> LeagueId

```csharp
public uint LeagueId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSOEconItemTournamentPassport_OriginalPurchaserId"></a> OriginalPurchaserId

```csharp
public uint OriginalPurchaserId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSOEconItemTournamentPassport_Parser"></a> Parser

```csharp
public static MessageParser<CSOEconItemTournamentPassport> Parser { get; }
```

#### Property Value

 MessageParser<[CSOEconItemTournamentPassport](Divine.Protobufs.Dota2.CSOEconItemTournamentPassport.md)\>

### <a id="Divine_Protobufs_Dota2_CSOEconItemTournamentPassport_PassportsBought"></a> PassportsBought

```csharp
public uint PassportsBought { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSOEconItemTournamentPassport_RewardFlags"></a> RewardFlags

```csharp
public uint RewardFlags { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSOEconItemTournamentPassport_Version"></a> Version

```csharp
public uint Version { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CSOEconItemTournamentPassport_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSOEconItemTournamentPassport_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CSOEconItemTournamentPassport_ClearDefIndex"></a> ClearDefIndex\(\)

```csharp
public void ClearDefIndex()
```

### <a id="Divine_Protobufs_Dota2_CSOEconItemTournamentPassport_ClearItemId"></a> ClearItemId\(\)

```csharp
public void ClearItemId()
```

### <a id="Divine_Protobufs_Dota2_CSOEconItemTournamentPassport_ClearLeagueId"></a> ClearLeagueId\(\)

```csharp
public void ClearLeagueId()
```

### <a id="Divine_Protobufs_Dota2_CSOEconItemTournamentPassport_ClearOriginalPurchaserId"></a> ClearOriginalPurchaserId\(\)

```csharp
public void ClearOriginalPurchaserId()
```

### <a id="Divine_Protobufs_Dota2_CSOEconItemTournamentPassport_ClearPassportsBought"></a> ClearPassportsBought\(\)

```csharp
public void ClearPassportsBought()
```

### <a id="Divine_Protobufs_Dota2_CSOEconItemTournamentPassport_ClearRewardFlags"></a> ClearRewardFlags\(\)

```csharp
public void ClearRewardFlags()
```

### <a id="Divine_Protobufs_Dota2_CSOEconItemTournamentPassport_ClearVersion"></a> ClearVersion\(\)

```csharp
public void ClearVersion()
```

### <a id="Divine_Protobufs_Dota2_CSOEconItemTournamentPassport_Clone"></a> Clone\(\)

```csharp
public CSOEconItemTournamentPassport Clone()
```

#### Returns

 [CSOEconItemTournamentPassport](Divine.Protobufs.Dota2.CSOEconItemTournamentPassport.md)

### <a id="Divine_Protobufs_Dota2_CSOEconItemTournamentPassport_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSOEconItemTournamentPassport_Equals_Divine_Protobufs_Dota2_CSOEconItemTournamentPassport_"></a> Equals\(CSOEconItemTournamentPassport\)

```csharp
public bool Equals(CSOEconItemTournamentPassport other)
```

#### Parameters

`other` [CSOEconItemTournamentPassport](Divine.Protobufs.Dota2.CSOEconItemTournamentPassport.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSOEconItemTournamentPassport_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSOEconItemTournamentPassport_MergeFrom_Divine_Protobufs_Dota2_CSOEconItemTournamentPassport_"></a> MergeFrom\(CSOEconItemTournamentPassport\)

```csharp
public void MergeFrom(CSOEconItemTournamentPassport other)
```

#### Parameters

`other` [CSOEconItemTournamentPassport](Divine.Protobufs.Dota2.CSOEconItemTournamentPassport.md)

### <a id="Divine_Protobufs_Dota2_CSOEconItemTournamentPassport_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSOEconItemTournamentPassport_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSOEconItemTournamentPassport_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

