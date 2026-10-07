# <a id="Divine_Protobufs_Dota2_CMsgUpgradeLeagueItem"></a> Class CMsgUpgradeLeagueItem

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgUpgradeLeagueItem : IMessage<CMsgUpgradeLeagueItem>, IEquatable<CMsgUpgradeLeagueItem>, IDeepCloneable<CMsgUpgradeLeagueItem>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgUpgradeLeagueItem](Divine.Protobufs.Dota2.CMsgUpgradeLeagueItem.md)

#### Implements

IMessage<CMsgUpgradeLeagueItem\>, 
[IEquatable<CMsgUpgradeLeagueItem\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgUpgradeLeagueItem\>, 
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
[EnumerableExtensions.In<CMsgUpgradeLeagueItem\>\(CMsgUpgradeLeagueItem, params CMsgUpgradeLeagueItem\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgUpgradeLeagueItem__ctor"></a> CMsgUpgradeLeagueItem\(\)

```csharp
public CMsgUpgradeLeagueItem()
```

### <a id="Divine_Protobufs_Dota2_CMsgUpgradeLeagueItem__ctor_Divine_Protobufs_Dota2_CMsgUpgradeLeagueItem_"></a> CMsgUpgradeLeagueItem\(CMsgUpgradeLeagueItem\)

```csharp
public CMsgUpgradeLeagueItem(CMsgUpgradeLeagueItem other)
```

#### Parameters

`other` [CMsgUpgradeLeagueItem](Divine.Protobufs.Dota2.CMsgUpgradeLeagueItem.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgUpgradeLeagueItem_LeagueIdFieldNumber"></a> LeagueIdFieldNumber

```csharp
public const int LeagueIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgUpgradeLeagueItem_MatchIdFieldNumber"></a> MatchIdFieldNumber

```csharp
public const int MatchIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgUpgradeLeagueItem_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgUpgradeLeagueItem_HasLeagueId"></a> HasLeagueId

```csharp
public bool HasLeagueId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgUpgradeLeagueItem_HasMatchId"></a> HasMatchId

```csharp
public bool HasMatchId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgUpgradeLeagueItem_LeagueId"></a> LeagueId

```csharp
public uint LeagueId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgUpgradeLeagueItem_MatchId"></a> MatchId

```csharp
public ulong MatchId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgUpgradeLeagueItem_Parser"></a> Parser

```csharp
public static MessageParser<CMsgUpgradeLeagueItem> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgUpgradeLeagueItem](Divine.Protobufs.Dota2.CMsgUpgradeLeagueItem.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgUpgradeLeagueItem_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgUpgradeLeagueItem_ClearLeagueId"></a> ClearLeagueId\(\)

```csharp
public void ClearLeagueId()
```

### <a id="Divine_Protobufs_Dota2_CMsgUpgradeLeagueItem_ClearMatchId"></a> ClearMatchId\(\)

```csharp
public void ClearMatchId()
```

### <a id="Divine_Protobufs_Dota2_CMsgUpgradeLeagueItem_Clone"></a> Clone\(\)

```csharp
public CMsgUpgradeLeagueItem Clone()
```

#### Returns

 [CMsgUpgradeLeagueItem](Divine.Protobufs.Dota2.CMsgUpgradeLeagueItem.md)

### <a id="Divine_Protobufs_Dota2_CMsgUpgradeLeagueItem_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgUpgradeLeagueItem_Equals_Divine_Protobufs_Dota2_CMsgUpgradeLeagueItem_"></a> Equals\(CMsgUpgradeLeagueItem\)

```csharp
public bool Equals(CMsgUpgradeLeagueItem other)
```

#### Parameters

`other` [CMsgUpgradeLeagueItem](Divine.Protobufs.Dota2.CMsgUpgradeLeagueItem.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgUpgradeLeagueItem_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgUpgradeLeagueItem_MergeFrom_Divine_Protobufs_Dota2_CMsgUpgradeLeagueItem_"></a> MergeFrom\(CMsgUpgradeLeagueItem\)

```csharp
public void MergeFrom(CMsgUpgradeLeagueItem other)
```

#### Parameters

`other` [CMsgUpgradeLeagueItem](Divine.Protobufs.Dota2.CMsgUpgradeLeagueItem.md)

### <a id="Divine_Protobufs_Dota2_CMsgUpgradeLeagueItem_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgUpgradeLeagueItem_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgUpgradeLeagueItem_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

