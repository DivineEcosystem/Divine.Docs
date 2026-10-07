# <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActive"></a> Class CMsgServerToGCCavernCrawlIsHeroActive

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgServerToGCCavernCrawlIsHeroActive : IMessage<CMsgServerToGCCavernCrawlIsHeroActive>, IEquatable<CMsgServerToGCCavernCrawlIsHeroActive>, IDeepCloneable<CMsgServerToGCCavernCrawlIsHeroActive>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgServerToGCCavernCrawlIsHeroActive](Divine.Protobufs.Dota2.CMsgServerToGCCavernCrawlIsHeroActive.md)

#### Implements

IMessage<CMsgServerToGCCavernCrawlIsHeroActive\>, 
[IEquatable<CMsgServerToGCCavernCrawlIsHeroActive\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgServerToGCCavernCrawlIsHeroActive\>, 
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
[EnumerableExtensions.In<CMsgServerToGCCavernCrawlIsHeroActive\>\(CMsgServerToGCCavernCrawlIsHeroActive, params CMsgServerToGCCavernCrawlIsHeroActive\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActive__ctor"></a> CMsgServerToGCCavernCrawlIsHeroActive\(\)

```csharp
public CMsgServerToGCCavernCrawlIsHeroActive()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActive__ctor_Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActive_"></a> CMsgServerToGCCavernCrawlIsHeroActive\(CMsgServerToGCCavernCrawlIsHeroActive\)

```csharp
public CMsgServerToGCCavernCrawlIsHeroActive(CMsgServerToGCCavernCrawlIsHeroActive other)
```

#### Parameters

`other` [CMsgServerToGCCavernCrawlIsHeroActive](Divine.Protobufs.Dota2.CMsgServerToGCCavernCrawlIsHeroActive.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActive_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActive_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActive_HeroIdFieldNumber"></a> HeroIdFieldNumber

```csharp
public const int HeroIdFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActive_PreferredMapVariantFieldNumber"></a> PreferredMapVariantFieldNumber

```csharp
public const int PreferredMapVariantFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActive_TurboModeFieldNumber"></a> TurboModeFieldNumber

```csharp
public const int TurboModeFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActive_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActive_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActive_EventId"></a> EventId

```csharp
public uint EventId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActive_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActive_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActive_HasHeroId"></a> HasHeroId

```csharp
public bool HasHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActive_HasPreferredMapVariant"></a> HasPreferredMapVariant

```csharp
public bool HasPreferredMapVariant { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActive_HasTurboMode"></a> HasTurboMode

```csharp
public bool HasTurboMode { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActive_HeroId"></a> HeroId

```csharp
public int HeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActive_Parser"></a> Parser

```csharp
public static MessageParser<CMsgServerToGCCavernCrawlIsHeroActive> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgServerToGCCavernCrawlIsHeroActive](Divine.Protobufs.Dota2.CMsgServerToGCCavernCrawlIsHeroActive.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActive_PreferredMapVariant"></a> PreferredMapVariant

```csharp
public uint PreferredMapVariant { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActive_TurboMode"></a> TurboMode

```csharp
public bool TurboMode { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActive_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActive_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActive_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActive_ClearHeroId"></a> ClearHeroId\(\)

```csharp
public void ClearHeroId()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActive_ClearPreferredMapVariant"></a> ClearPreferredMapVariant\(\)

```csharp
public void ClearPreferredMapVariant()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActive_ClearTurboMode"></a> ClearTurboMode\(\)

```csharp
public void ClearTurboMode()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActive_Clone"></a> Clone\(\)

```csharp
public CMsgServerToGCCavernCrawlIsHeroActive Clone()
```

#### Returns

 [CMsgServerToGCCavernCrawlIsHeroActive](Divine.Protobufs.Dota2.CMsgServerToGCCavernCrawlIsHeroActive.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActive_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActive_Equals_Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActive_"></a> Equals\(CMsgServerToGCCavernCrawlIsHeroActive\)

```csharp
public bool Equals(CMsgServerToGCCavernCrawlIsHeroActive other)
```

#### Parameters

`other` [CMsgServerToGCCavernCrawlIsHeroActive](Divine.Protobufs.Dota2.CMsgServerToGCCavernCrawlIsHeroActive.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActive_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActive_MergeFrom_Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActive_"></a> MergeFrom\(CMsgServerToGCCavernCrawlIsHeroActive\)

```csharp
public void MergeFrom(CMsgServerToGCCavernCrawlIsHeroActive other)
```

#### Parameters

`other` [CMsgServerToGCCavernCrawlIsHeroActive](Divine.Protobufs.Dota2.CMsgServerToGCCavernCrawlIsHeroActive.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActive_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActive_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCCavernCrawlIsHeroActive_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

