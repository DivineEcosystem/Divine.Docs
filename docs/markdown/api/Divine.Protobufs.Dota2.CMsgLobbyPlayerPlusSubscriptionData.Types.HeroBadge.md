# <a id="Divine_Protobufs_Dota2_CMsgLobbyPlayerPlusSubscriptionData_Types_HeroBadge"></a> Class CMsgLobbyPlayerPlusSubscriptionData.Types.HeroBadge

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgLobbyPlayerPlusSubscriptionData.Types.HeroBadge : IMessage<CMsgLobbyPlayerPlusSubscriptionData.Types.HeroBadge>, IEquatable<CMsgLobbyPlayerPlusSubscriptionData.Types.HeroBadge>, IDeepCloneable<CMsgLobbyPlayerPlusSubscriptionData.Types.HeroBadge>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgLobbyPlayerPlusSubscriptionData.Types.HeroBadge](Divine.Protobufs.Dota2.CMsgLobbyPlayerPlusSubscriptionData.Types.HeroBadge.md)

#### Implements

IMessage<CMsgLobbyPlayerPlusSubscriptionData.Types.HeroBadge\>, 
[IEquatable<CMsgLobbyPlayerPlusSubscriptionData.Types.HeroBadge\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgLobbyPlayerPlusSubscriptionData.Types.HeroBadge\>, 
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
[EnumerableExtensions.In<CMsgLobbyPlayerPlusSubscriptionData.Types.HeroBadge\>\(CMsgLobbyPlayerPlusSubscriptionData.Types.HeroBadge, params CMsgLobbyPlayerPlusSubscriptionData.Types.HeroBadge\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgLobbyPlayerPlusSubscriptionData_Types_HeroBadge__ctor"></a> HeroBadge\(\)

```csharp
public HeroBadge()
```

### <a id="Divine_Protobufs_Dota2_CMsgLobbyPlayerPlusSubscriptionData_Types_HeroBadge__ctor_Divine_Protobufs_Dota2_CMsgLobbyPlayerPlusSubscriptionData_Types_HeroBadge_"></a> HeroBadge\(HeroBadge\)

```csharp
public HeroBadge(CMsgLobbyPlayerPlusSubscriptionData.Types.HeroBadge other)
```

#### Parameters

`other` [CMsgLobbyPlayerPlusSubscriptionData](Divine.Protobufs.Dota2.CMsgLobbyPlayerPlusSubscriptionData.md).[Types](Divine.Protobufs.Dota2.CMsgLobbyPlayerPlusSubscriptionData.Types.md).[HeroBadge](Divine.Protobufs.Dota2.CMsgLobbyPlayerPlusSubscriptionData.Types.HeroBadge.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgLobbyPlayerPlusSubscriptionData_Types_HeroBadge_HeroBadgeXpFieldNumber"></a> HeroBadgeXpFieldNumber

```csharp
public const int HeroBadgeXpFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyPlayerPlusSubscriptionData_Types_HeroBadge_HeroIdFieldNumber"></a> HeroIdFieldNumber

```csharp
public const int HeroIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgLobbyPlayerPlusSubscriptionData_Types_HeroBadge_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgLobbyPlayerPlusSubscriptionData_Types_HeroBadge_HasHeroBadgeXp"></a> HasHeroBadgeXp

```csharp
public bool HasHeroBadgeXp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyPlayerPlusSubscriptionData_Types_HeroBadge_HasHeroId"></a> HasHeroId

```csharp
public bool HasHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyPlayerPlusSubscriptionData_Types_HeroBadge_HeroBadgeXp"></a> HeroBadgeXp

```csharp
public uint HeroBadgeXp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyPlayerPlusSubscriptionData_Types_HeroBadge_HeroId"></a> HeroId

```csharp
public int HeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyPlayerPlusSubscriptionData_Types_HeroBadge_Parser"></a> Parser

```csharp
public static MessageParser<CMsgLobbyPlayerPlusSubscriptionData.Types.HeroBadge> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgLobbyPlayerPlusSubscriptionData](Divine.Protobufs.Dota2.CMsgLobbyPlayerPlusSubscriptionData.md).[Types](Divine.Protobufs.Dota2.CMsgLobbyPlayerPlusSubscriptionData.Types.md).[HeroBadge](Divine.Protobufs.Dota2.CMsgLobbyPlayerPlusSubscriptionData.Types.HeroBadge.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgLobbyPlayerPlusSubscriptionData_Types_HeroBadge_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyPlayerPlusSubscriptionData_Types_HeroBadge_ClearHeroBadgeXp"></a> ClearHeroBadgeXp\(\)

```csharp
public void ClearHeroBadgeXp()
```

### <a id="Divine_Protobufs_Dota2_CMsgLobbyPlayerPlusSubscriptionData_Types_HeroBadge_ClearHeroId"></a> ClearHeroId\(\)

```csharp
public void ClearHeroId()
```

### <a id="Divine_Protobufs_Dota2_CMsgLobbyPlayerPlusSubscriptionData_Types_HeroBadge_Clone"></a> Clone\(\)

```csharp
public CMsgLobbyPlayerPlusSubscriptionData.Types.HeroBadge Clone()
```

#### Returns

 [CMsgLobbyPlayerPlusSubscriptionData](Divine.Protobufs.Dota2.CMsgLobbyPlayerPlusSubscriptionData.md).[Types](Divine.Protobufs.Dota2.CMsgLobbyPlayerPlusSubscriptionData.Types.md).[HeroBadge](Divine.Protobufs.Dota2.CMsgLobbyPlayerPlusSubscriptionData.Types.HeroBadge.md)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyPlayerPlusSubscriptionData_Types_HeroBadge_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyPlayerPlusSubscriptionData_Types_HeroBadge_Equals_Divine_Protobufs_Dota2_CMsgLobbyPlayerPlusSubscriptionData_Types_HeroBadge_"></a> Equals\(HeroBadge\)

```csharp
public bool Equals(CMsgLobbyPlayerPlusSubscriptionData.Types.HeroBadge other)
```

#### Parameters

`other` [CMsgLobbyPlayerPlusSubscriptionData](Divine.Protobufs.Dota2.CMsgLobbyPlayerPlusSubscriptionData.md).[Types](Divine.Protobufs.Dota2.CMsgLobbyPlayerPlusSubscriptionData.Types.md).[HeroBadge](Divine.Protobufs.Dota2.CMsgLobbyPlayerPlusSubscriptionData.Types.HeroBadge.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyPlayerPlusSubscriptionData_Types_HeroBadge_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyPlayerPlusSubscriptionData_Types_HeroBadge_MergeFrom_Divine_Protobufs_Dota2_CMsgLobbyPlayerPlusSubscriptionData_Types_HeroBadge_"></a> MergeFrom\(HeroBadge\)

```csharp
public void MergeFrom(CMsgLobbyPlayerPlusSubscriptionData.Types.HeroBadge other)
```

#### Parameters

`other` [CMsgLobbyPlayerPlusSubscriptionData](Divine.Protobufs.Dota2.CMsgLobbyPlayerPlusSubscriptionData.md).[Types](Divine.Protobufs.Dota2.CMsgLobbyPlayerPlusSubscriptionData.Types.md).[HeroBadge](Divine.Protobufs.Dota2.CMsgLobbyPlayerPlusSubscriptionData.Types.HeroBadge.md)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyPlayerPlusSubscriptionData_Types_HeroBadge_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgLobbyPlayerPlusSubscriptionData_Types_HeroBadge_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyPlayerPlusSubscriptionData_Types_HeroBadge_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

