# <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsRequest"></a> Class CMsgDOTAClientToGCQuickStatsRequest

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAClientToGCQuickStatsRequest : IMessage<CMsgDOTAClientToGCQuickStatsRequest>, IEquatable<CMsgDOTAClientToGCQuickStatsRequest>, IDeepCloneable<CMsgDOTAClientToGCQuickStatsRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAClientToGCQuickStatsRequest](Divine.Protobufs.Dota2.CMsgDOTAClientToGCQuickStatsRequest.md)

#### Implements

IMessage<CMsgDOTAClientToGCQuickStatsRequest\>, 
[IEquatable<CMsgDOTAClientToGCQuickStatsRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAClientToGCQuickStatsRequest\>, 
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
[EnumerableExtensions.In<CMsgDOTAClientToGCQuickStatsRequest\>\(CMsgDOTAClientToGCQuickStatsRequest, params CMsgDOTAClientToGCQuickStatsRequest\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsRequest__ctor"></a> CMsgDOTAClientToGCQuickStatsRequest\(\)

```csharp
public CMsgDOTAClientToGCQuickStatsRequest()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsRequest__ctor_Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsRequest_"></a> CMsgDOTAClientToGCQuickStatsRequest\(CMsgDOTAClientToGCQuickStatsRequest\)

```csharp
public CMsgDOTAClientToGCQuickStatsRequest(CMsgDOTAClientToGCQuickStatsRequest other)
```

#### Parameters

`other` [CMsgDOTAClientToGCQuickStatsRequest](Divine.Protobufs.Dota2.CMsgDOTAClientToGCQuickStatsRequest.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsRequest_HeroIdFieldNumber"></a> HeroIdFieldNumber

```csharp
public const int HeroIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsRequest_ItemIdFieldNumber"></a> ItemIdFieldNumber

```csharp
public const int ItemIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsRequest_LeagueIdFieldNumber"></a> LeagueIdFieldNumber

```csharp
public const int LeagueIdFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsRequest_PlayerAccountIdFieldNumber"></a> PlayerAccountIdFieldNumber

```csharp
public const int PlayerAccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsRequest_HasHeroId"></a> HasHeroId

```csharp
public bool HasHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsRequest_HasItemId"></a> HasItemId

```csharp
public bool HasItemId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsRequest_HasLeagueId"></a> HasLeagueId

```csharp
public bool HasLeagueId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsRequest_HasPlayerAccountId"></a> HasPlayerAccountId

```csharp
public bool HasPlayerAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsRequest_HeroId"></a> HeroId

```csharp
public int HeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsRequest_ItemId"></a> ItemId

```csharp
public int ItemId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsRequest_LeagueId"></a> LeagueId

```csharp
public uint LeagueId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsRequest_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAClientToGCQuickStatsRequest> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAClientToGCQuickStatsRequest](Divine.Protobufs.Dota2.CMsgDOTAClientToGCQuickStatsRequest.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsRequest_PlayerAccountId"></a> PlayerAccountId

```csharp
public uint PlayerAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsRequest_ClearHeroId"></a> ClearHeroId\(\)

```csharp
public void ClearHeroId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsRequest_ClearItemId"></a> ClearItemId\(\)

```csharp
public void ClearItemId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsRequest_ClearLeagueId"></a> ClearLeagueId\(\)

```csharp
public void ClearLeagueId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsRequest_ClearPlayerAccountId"></a> ClearPlayerAccountId\(\)

```csharp
public void ClearPlayerAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsRequest_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAClientToGCQuickStatsRequest Clone()
```

#### Returns

 [CMsgDOTAClientToGCQuickStatsRequest](Divine.Protobufs.Dota2.CMsgDOTAClientToGCQuickStatsRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsRequest_Equals_Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsRequest_"></a> Equals\(CMsgDOTAClientToGCQuickStatsRequest\)

```csharp
public bool Equals(CMsgDOTAClientToGCQuickStatsRequest other)
```

#### Parameters

`other` [CMsgDOTAClientToGCQuickStatsRequest](Divine.Protobufs.Dota2.CMsgDOTAClientToGCQuickStatsRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsRequest_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsRequest_"></a> MergeFrom\(CMsgDOTAClientToGCQuickStatsRequest\)

```csharp
public void MergeFrom(CMsgDOTAClientToGCQuickStatsRequest other)
```

#### Parameters

`other` [CMsgDOTAClientToGCQuickStatsRequest](Divine.Protobufs.Dota2.CMsgDOTAClientToGCQuickStatsRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClientToGCQuickStatsRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

