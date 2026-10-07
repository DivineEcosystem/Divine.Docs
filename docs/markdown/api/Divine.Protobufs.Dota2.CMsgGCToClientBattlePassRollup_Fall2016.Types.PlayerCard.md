# <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Fall2016_Types_PlayerCard"></a> Class CMsgGCToClientBattlePassRollup\_Fall2016.Types.PlayerCard

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientBattlePassRollup_Fall2016.Types.PlayerCard : IMessage<CMsgGCToClientBattlePassRollup_Fall2016.Types.PlayerCard>, IEquatable<CMsgGCToClientBattlePassRollup_Fall2016.Types.PlayerCard>, IDeepCloneable<CMsgGCToClientBattlePassRollup_Fall2016.Types.PlayerCard>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientBattlePassRollup\_Fall2016.Types.PlayerCard](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_Fall2016.Types.PlayerCard.md)

#### Implements

IMessage<CMsgGCToClientBattlePassRollup\_Fall2016.Types.PlayerCard\>, 
[IEquatable<CMsgGCToClientBattlePassRollup\_Fall2016.Types.PlayerCard\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientBattlePassRollup\_Fall2016.Types.PlayerCard\>, 
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
[EnumerableExtensions.In<CMsgGCToClientBattlePassRollup\_Fall2016.Types.PlayerCard\>\(CMsgGCToClientBattlePassRollup\_Fall2016.Types.PlayerCard, params CMsgGCToClientBattlePassRollup\_Fall2016.Types.PlayerCard\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Fall2016_Types_PlayerCard__ctor"></a> PlayerCard\(\)

```csharp
public PlayerCard()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Fall2016_Types_PlayerCard__ctor_Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Fall2016_Types_PlayerCard_"></a> PlayerCard\(PlayerCard\)

```csharp
public PlayerCard(CMsgGCToClientBattlePassRollup_Fall2016.Types.PlayerCard other)
```

#### Parameters

`other` [CMsgGCToClientBattlePassRollup\_Fall2016](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_Fall2016.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_Fall2016.Types.md).[PlayerCard](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_Fall2016.Types.PlayerCard.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Fall2016_Types_PlayerCard_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Fall2016_Types_PlayerCard_QualityFieldNumber"></a> QualityFieldNumber

```csharp
public const int QualityFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Fall2016_Types_PlayerCard_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Fall2016_Types_PlayerCard_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Fall2016_Types_PlayerCard_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Fall2016_Types_PlayerCard_HasQuality"></a> HasQuality

```csharp
public bool HasQuality { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Fall2016_Types_PlayerCard_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientBattlePassRollup_Fall2016.Types.PlayerCard> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientBattlePassRollup\_Fall2016](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_Fall2016.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_Fall2016.Types.md).[PlayerCard](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_Fall2016.Types.PlayerCard.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Fall2016_Types_PlayerCard_Quality"></a> Quality

```csharp
public uint Quality { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Fall2016_Types_PlayerCard_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Fall2016_Types_PlayerCard_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Fall2016_Types_PlayerCard_ClearQuality"></a> ClearQuality\(\)

```csharp
public void ClearQuality()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Fall2016_Types_PlayerCard_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientBattlePassRollup_Fall2016.Types.PlayerCard Clone()
```

#### Returns

 [CMsgGCToClientBattlePassRollup\_Fall2016](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_Fall2016.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_Fall2016.Types.md).[PlayerCard](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_Fall2016.Types.PlayerCard.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Fall2016_Types_PlayerCard_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Fall2016_Types_PlayerCard_Equals_Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Fall2016_Types_PlayerCard_"></a> Equals\(PlayerCard\)

```csharp
public bool Equals(CMsgGCToClientBattlePassRollup_Fall2016.Types.PlayerCard other)
```

#### Parameters

`other` [CMsgGCToClientBattlePassRollup\_Fall2016](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_Fall2016.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_Fall2016.Types.md).[PlayerCard](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_Fall2016.Types.PlayerCard.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Fall2016_Types_PlayerCard_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Fall2016_Types_PlayerCard_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Fall2016_Types_PlayerCard_"></a> MergeFrom\(PlayerCard\)

```csharp
public void MergeFrom(CMsgGCToClientBattlePassRollup_Fall2016.Types.PlayerCard other)
```

#### Parameters

`other` [CMsgGCToClientBattlePassRollup\_Fall2016](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_Fall2016.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_Fall2016.Types.md).[PlayerCard](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_Fall2016.Types.PlayerCard.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Fall2016_Types_PlayerCard_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Fall2016_Types_PlayerCard_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_Fall2016_Types_PlayerCard_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

