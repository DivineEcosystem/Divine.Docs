# <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingDevModifyTablet"></a> Class CMsgClientToGCFantasyCraftingDevModifyTablet

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCFantasyCraftingDevModifyTablet : IMessage<CMsgClientToGCFantasyCraftingDevModifyTablet>, IEquatable<CMsgClientToGCFantasyCraftingDevModifyTablet>, IDeepCloneable<CMsgClientToGCFantasyCraftingDevModifyTablet>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCFantasyCraftingDevModifyTablet](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingDevModifyTablet.md)

#### Implements

IMessage<CMsgClientToGCFantasyCraftingDevModifyTablet\>, 
[IEquatable<CMsgClientToGCFantasyCraftingDevModifyTablet\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCFantasyCraftingDevModifyTablet\>, 
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
[EnumerableExtensions.In<CMsgClientToGCFantasyCraftingDevModifyTablet\>\(CMsgClientToGCFantasyCraftingDevModifyTablet, params CMsgClientToGCFantasyCraftingDevModifyTablet\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingDevModifyTablet__ctor"></a> CMsgClientToGCFantasyCraftingDevModifyTablet\(\)

```csharp
public CMsgClientToGCFantasyCraftingDevModifyTablet()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingDevModifyTablet__ctor_Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingDevModifyTablet_"></a> CMsgClientToGCFantasyCraftingDevModifyTablet\(CMsgClientToGCFantasyCraftingDevModifyTablet\)

```csharp
public CMsgClientToGCFantasyCraftingDevModifyTablet(CMsgClientToGCFantasyCraftingDevModifyTablet other)
```

#### Parameters

`other` [CMsgClientToGCFantasyCraftingDevModifyTablet](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingDevModifyTablet.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingDevModifyTablet_FantasyLeagueFieldNumber"></a> FantasyLeagueFieldNumber

```csharp
public const int FantasyLeagueFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingDevModifyTablet_FantasyPeriodFieldNumber"></a> FantasyPeriodFieldNumber

```csharp
public const int FantasyPeriodFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingDevModifyTablet_ModifyTokensFieldNumber"></a> ModifyTokensFieldNumber

```csharp
public const int ModifyTokensFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingDevModifyTablet_ResetTabletFieldNumber"></a> ResetTabletFieldNumber

```csharp
public const int ResetTabletFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingDevModifyTablet_UpgradeTabletsFieldNumber"></a> UpgradeTabletsFieldNumber

```csharp
public const int UpgradeTabletsFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingDevModifyTablet_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingDevModifyTablet_FantasyLeague"></a> FantasyLeague

```csharp
public uint FantasyLeague { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingDevModifyTablet_FantasyPeriod"></a> FantasyPeriod

```csharp
public uint FantasyPeriod { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingDevModifyTablet_HasFantasyLeague"></a> HasFantasyLeague

```csharp
public bool HasFantasyLeague { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingDevModifyTablet_HasFantasyPeriod"></a> HasFantasyPeriod

```csharp
public bool HasFantasyPeriod { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingDevModifyTablet_HasModifyTokens"></a> HasModifyTokens

```csharp
public bool HasModifyTokens { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingDevModifyTablet_HasResetTablet"></a> HasResetTablet

```csharp
public bool HasResetTablet { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingDevModifyTablet_HasUpgradeTablets"></a> HasUpgradeTablets

```csharp
public bool HasUpgradeTablets { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingDevModifyTablet_ModifyTokens"></a> ModifyTokens

```csharp
public uint ModifyTokens { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingDevModifyTablet_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCFantasyCraftingDevModifyTablet> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCFantasyCraftingDevModifyTablet](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingDevModifyTablet.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingDevModifyTablet_ResetTablet"></a> ResetTablet

```csharp
public bool ResetTablet { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingDevModifyTablet_UpgradeTablets"></a> UpgradeTablets

```csharp
public bool UpgradeTablets { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingDevModifyTablet_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingDevModifyTablet_ClearFantasyLeague"></a> ClearFantasyLeague\(\)

```csharp
public void ClearFantasyLeague()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingDevModifyTablet_ClearFantasyPeriod"></a> ClearFantasyPeriod\(\)

```csharp
public void ClearFantasyPeriod()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingDevModifyTablet_ClearModifyTokens"></a> ClearModifyTokens\(\)

```csharp
public void ClearModifyTokens()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingDevModifyTablet_ClearResetTablet"></a> ClearResetTablet\(\)

```csharp
public void ClearResetTablet()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingDevModifyTablet_ClearUpgradeTablets"></a> ClearUpgradeTablets\(\)

```csharp
public void ClearUpgradeTablets()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingDevModifyTablet_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCFantasyCraftingDevModifyTablet Clone()
```

#### Returns

 [CMsgClientToGCFantasyCraftingDevModifyTablet](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingDevModifyTablet.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingDevModifyTablet_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingDevModifyTablet_Equals_Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingDevModifyTablet_"></a> Equals\(CMsgClientToGCFantasyCraftingDevModifyTablet\)

```csharp
public bool Equals(CMsgClientToGCFantasyCraftingDevModifyTablet other)
```

#### Parameters

`other` [CMsgClientToGCFantasyCraftingDevModifyTablet](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingDevModifyTablet.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingDevModifyTablet_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingDevModifyTablet_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingDevModifyTablet_"></a> MergeFrom\(CMsgClientToGCFantasyCraftingDevModifyTablet\)

```csharp
public void MergeFrom(CMsgClientToGCFantasyCraftingDevModifyTablet other)
```

#### Parameters

`other` [CMsgClientToGCFantasyCraftingDevModifyTablet](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingDevModifyTablet.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingDevModifyTablet_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingDevModifyTablet_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingDevModifyTablet_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

