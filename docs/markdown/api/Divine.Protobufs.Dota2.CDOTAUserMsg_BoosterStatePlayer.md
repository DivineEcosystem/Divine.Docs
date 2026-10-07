# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BoosterStatePlayer"></a> Class CDOTAUserMsg\_BoosterStatePlayer

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_BoosterStatePlayer : IMessage<CDOTAUserMsg_BoosterStatePlayer>, IEquatable<CDOTAUserMsg_BoosterStatePlayer>, IDeepCloneable<CDOTAUserMsg_BoosterStatePlayer>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_BoosterStatePlayer](Divine.Protobufs.Dota2.CDOTAUserMsg\_BoosterStatePlayer.md)

#### Implements

IMessage<CDOTAUserMsg\_BoosterStatePlayer\>, 
[IEquatable<CDOTAUserMsg\_BoosterStatePlayer\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_BoosterStatePlayer\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_BoosterStatePlayer\>\(CDOTAUserMsg\_BoosterStatePlayer, params CDOTAUserMsg\_BoosterStatePlayer\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BoosterStatePlayer__ctor"></a> CDOTAUserMsg\_BoosterStatePlayer\(\)

```csharp
public CDOTAUserMsg_BoosterStatePlayer()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BoosterStatePlayer__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_BoosterStatePlayer_"></a> CDOTAUserMsg\_BoosterStatePlayer\(CDOTAUserMsg\_BoosterStatePlayer\)

```csharp
public CDOTAUserMsg_BoosterStatePlayer(CDOTAUserMsg_BoosterStatePlayer other)
```

#### Parameters

`other` [CDOTAUserMsg\_BoosterStatePlayer](Divine.Protobufs.Dota2.CDOTAUserMsg\_BoosterStatePlayer.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BoosterStatePlayer_BonusFieldNumber"></a> BonusFieldNumber

```csharp
public const int BonusFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BoosterStatePlayer_BonusItemIdFieldNumber"></a> BonusItemIdFieldNumber

```csharp
public const int BonusItemIdFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BoosterStatePlayer_EventBonusFieldNumber"></a> EventBonusFieldNumber

```csharp
public const int EventBonusFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BoosterStatePlayer_EventBonusItemIdFieldNumber"></a> EventBonusItemIdFieldNumber

```csharp
public const int EventBonusItemIdFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BoosterStatePlayer_PlayerIdFieldNumber"></a> PlayerIdFieldNumber

```csharp
public const int PlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BoosterStatePlayer_Bonus"></a> Bonus

```csharp
public float Bonus { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BoosterStatePlayer_BonusItemId"></a> BonusItemId

```csharp
public uint BonusItemId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BoosterStatePlayer_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BoosterStatePlayer_EventBonus"></a> EventBonus

```csharp
public float EventBonus { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BoosterStatePlayer_EventBonusItemId"></a> EventBonusItemId

```csharp
public uint EventBonusItemId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BoosterStatePlayer_HasBonus"></a> HasBonus

```csharp
public bool HasBonus { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BoosterStatePlayer_HasBonusItemId"></a> HasBonusItemId

```csharp
public bool HasBonusItemId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BoosterStatePlayer_HasEventBonus"></a> HasEventBonus

```csharp
public bool HasEventBonus { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BoosterStatePlayer_HasEventBonusItemId"></a> HasEventBonusItemId

```csharp
public bool HasEventBonusItemId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BoosterStatePlayer_HasPlayerId"></a> HasPlayerId

```csharp
public bool HasPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BoosterStatePlayer_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_BoosterStatePlayer> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_BoosterStatePlayer](Divine.Protobufs.Dota2.CDOTAUserMsg\_BoosterStatePlayer.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BoosterStatePlayer_PlayerId"></a> PlayerId

```csharp
public int PlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BoosterStatePlayer_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BoosterStatePlayer_ClearBonus"></a> ClearBonus\(\)

```csharp
public void ClearBonus()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BoosterStatePlayer_ClearBonusItemId"></a> ClearBonusItemId\(\)

```csharp
public void ClearBonusItemId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BoosterStatePlayer_ClearEventBonus"></a> ClearEventBonus\(\)

```csharp
public void ClearEventBonus()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BoosterStatePlayer_ClearEventBonusItemId"></a> ClearEventBonusItemId\(\)

```csharp
public void ClearEventBonusItemId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BoosterStatePlayer_ClearPlayerId"></a> ClearPlayerId\(\)

```csharp
public void ClearPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BoosterStatePlayer_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_BoosterStatePlayer Clone()
```

#### Returns

 [CDOTAUserMsg\_BoosterStatePlayer](Divine.Protobufs.Dota2.CDOTAUserMsg\_BoosterStatePlayer.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BoosterStatePlayer_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BoosterStatePlayer_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_BoosterStatePlayer_"></a> Equals\(CDOTAUserMsg\_BoosterStatePlayer\)

```csharp
public bool Equals(CDOTAUserMsg_BoosterStatePlayer other)
```

#### Parameters

`other` [CDOTAUserMsg\_BoosterStatePlayer](Divine.Protobufs.Dota2.CDOTAUserMsg\_BoosterStatePlayer.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BoosterStatePlayer_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BoosterStatePlayer_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_BoosterStatePlayer_"></a> MergeFrom\(CDOTAUserMsg\_BoosterStatePlayer\)

```csharp
public void MergeFrom(CDOTAUserMsg_BoosterStatePlayer other)
```

#### Parameters

`other` [CDOTAUserMsg\_BoosterStatePlayer](Divine.Protobufs.Dota2.CDOTAUserMsg\_BoosterStatePlayer.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BoosterStatePlayer_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BoosterStatePlayer_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BoosterStatePlayer_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

