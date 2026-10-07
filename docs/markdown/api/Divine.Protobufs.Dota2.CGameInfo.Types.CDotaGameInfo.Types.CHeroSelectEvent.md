# <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CDotaGameInfo_Types_CHeroSelectEvent"></a> Class CGameInfo.Types.CDotaGameInfo.Types.CHeroSelectEvent

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CGameInfo.Types.CDotaGameInfo.Types.CHeroSelectEvent : IMessage<CGameInfo.Types.CDotaGameInfo.Types.CHeroSelectEvent>, IEquatable<CGameInfo.Types.CDotaGameInfo.Types.CHeroSelectEvent>, IDeepCloneable<CGameInfo.Types.CDotaGameInfo.Types.CHeroSelectEvent>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CGameInfo.Types.CDotaGameInfo.Types.CHeroSelectEvent](Divine.Protobufs.Dota2.CGameInfo.Types.CDotaGameInfo.Types.CHeroSelectEvent.md)

#### Implements

IMessage<CGameInfo.Types.CDotaGameInfo.Types.CHeroSelectEvent\>, 
[IEquatable<CGameInfo.Types.CDotaGameInfo.Types.CHeroSelectEvent\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CGameInfo.Types.CDotaGameInfo.Types.CHeroSelectEvent\>, 
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
[EnumerableExtensions.In<CGameInfo.Types.CDotaGameInfo.Types.CHeroSelectEvent\>\(CGameInfo.Types.CDotaGameInfo.Types.CHeroSelectEvent, params CGameInfo.Types.CDotaGameInfo.Types.CHeroSelectEvent\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CDotaGameInfo_Types_CHeroSelectEvent__ctor"></a> CHeroSelectEvent\(\)

```csharp
public CHeroSelectEvent()
```

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CDotaGameInfo_Types_CHeroSelectEvent__ctor_Divine_Protobufs_Dota2_CGameInfo_Types_CDotaGameInfo_Types_CHeroSelectEvent_"></a> CHeroSelectEvent\(CHeroSelectEvent\)

```csharp
public CHeroSelectEvent(CGameInfo.Types.CDotaGameInfo.Types.CHeroSelectEvent other)
```

#### Parameters

`other` [CGameInfo](Divine.Protobufs.Dota2.CGameInfo.md).[Types](Divine.Protobufs.Dota2.CGameInfo.Types.md).[CDotaGameInfo](Divine.Protobufs.Dota2.CGameInfo.Types.CDotaGameInfo.md).[Types](Divine.Protobufs.Dota2.CGameInfo.Types.CDotaGameInfo.Types.md).[CHeroSelectEvent](Divine.Protobufs.Dota2.CGameInfo.Types.CDotaGameInfo.Types.CHeroSelectEvent.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CDotaGameInfo_Types_CHeroSelectEvent_HeroIdFieldNumber"></a> HeroIdFieldNumber

```csharp
public const int HeroIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CDotaGameInfo_Types_CHeroSelectEvent_IsPickFieldNumber"></a> IsPickFieldNumber

```csharp
public const int IsPickFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CDotaGameInfo_Types_CHeroSelectEvent_TeamFieldNumber"></a> TeamFieldNumber

```csharp
public const int TeamFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CDotaGameInfo_Types_CHeroSelectEvent_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CDotaGameInfo_Types_CHeroSelectEvent_HasHeroId"></a> HasHeroId

```csharp
public bool HasHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CDotaGameInfo_Types_CHeroSelectEvent_HasIsPick"></a> HasIsPick

```csharp
public bool HasIsPick { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CDotaGameInfo_Types_CHeroSelectEvent_HasTeam"></a> HasTeam

```csharp
public bool HasTeam { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CDotaGameInfo_Types_CHeroSelectEvent_HeroId"></a> HeroId

```csharp
public int HeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CDotaGameInfo_Types_CHeroSelectEvent_IsPick"></a> IsPick

```csharp
public bool IsPick { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CDotaGameInfo_Types_CHeroSelectEvent_Parser"></a> Parser

```csharp
public static MessageParser<CGameInfo.Types.CDotaGameInfo.Types.CHeroSelectEvent> Parser { get; }
```

#### Property Value

 MessageParser<[CGameInfo](Divine.Protobufs.Dota2.CGameInfo.md).[Types](Divine.Protobufs.Dota2.CGameInfo.Types.md).[CDotaGameInfo](Divine.Protobufs.Dota2.CGameInfo.Types.CDotaGameInfo.md).[Types](Divine.Protobufs.Dota2.CGameInfo.Types.CDotaGameInfo.Types.md).[CHeroSelectEvent](Divine.Protobufs.Dota2.CGameInfo.Types.CDotaGameInfo.Types.CHeroSelectEvent.md)\>

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CDotaGameInfo_Types_CHeroSelectEvent_Team"></a> Team

```csharp
public uint Team { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CDotaGameInfo_Types_CHeroSelectEvent_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CDotaGameInfo_Types_CHeroSelectEvent_ClearHeroId"></a> ClearHeroId\(\)

```csharp
public void ClearHeroId()
```

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CDotaGameInfo_Types_CHeroSelectEvent_ClearIsPick"></a> ClearIsPick\(\)

```csharp
public void ClearIsPick()
```

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CDotaGameInfo_Types_CHeroSelectEvent_ClearTeam"></a> ClearTeam\(\)

```csharp
public void ClearTeam()
```

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CDotaGameInfo_Types_CHeroSelectEvent_Clone"></a> Clone\(\)

```csharp
public CGameInfo.Types.CDotaGameInfo.Types.CHeroSelectEvent Clone()
```

#### Returns

 [CGameInfo](Divine.Protobufs.Dota2.CGameInfo.md).[Types](Divine.Protobufs.Dota2.CGameInfo.Types.md).[CDotaGameInfo](Divine.Protobufs.Dota2.CGameInfo.Types.CDotaGameInfo.md).[Types](Divine.Protobufs.Dota2.CGameInfo.Types.CDotaGameInfo.Types.md).[CHeroSelectEvent](Divine.Protobufs.Dota2.CGameInfo.Types.CDotaGameInfo.Types.CHeroSelectEvent.md)

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CDotaGameInfo_Types_CHeroSelectEvent_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CDotaGameInfo_Types_CHeroSelectEvent_Equals_Divine_Protobufs_Dota2_CGameInfo_Types_CDotaGameInfo_Types_CHeroSelectEvent_"></a> Equals\(CHeroSelectEvent\)

```csharp
public bool Equals(CGameInfo.Types.CDotaGameInfo.Types.CHeroSelectEvent other)
```

#### Parameters

`other` [CGameInfo](Divine.Protobufs.Dota2.CGameInfo.md).[Types](Divine.Protobufs.Dota2.CGameInfo.Types.md).[CDotaGameInfo](Divine.Protobufs.Dota2.CGameInfo.Types.CDotaGameInfo.md).[Types](Divine.Protobufs.Dota2.CGameInfo.Types.CDotaGameInfo.Types.md).[CHeroSelectEvent](Divine.Protobufs.Dota2.CGameInfo.Types.CDotaGameInfo.Types.CHeroSelectEvent.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CDotaGameInfo_Types_CHeroSelectEvent_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CDotaGameInfo_Types_CHeroSelectEvent_MergeFrom_Divine_Protobufs_Dota2_CGameInfo_Types_CDotaGameInfo_Types_CHeroSelectEvent_"></a> MergeFrom\(CHeroSelectEvent\)

```csharp
public void MergeFrom(CGameInfo.Types.CDotaGameInfo.Types.CHeroSelectEvent other)
```

#### Parameters

`other` [CGameInfo](Divine.Protobufs.Dota2.CGameInfo.md).[Types](Divine.Protobufs.Dota2.CGameInfo.Types.md).[CDotaGameInfo](Divine.Protobufs.Dota2.CGameInfo.Types.CDotaGameInfo.md).[Types](Divine.Protobufs.Dota2.CGameInfo.Types.CDotaGameInfo.Types.md).[CHeroSelectEvent](Divine.Protobufs.Dota2.CGameInfo.Types.CDotaGameInfo.Types.CHeroSelectEvent.md)

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CDotaGameInfo_Types_CHeroSelectEvent_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CDotaGameInfo_Types_CHeroSelectEvent_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CGameInfo_Types_CDotaGameInfo_Types_CHeroSelectEvent_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

