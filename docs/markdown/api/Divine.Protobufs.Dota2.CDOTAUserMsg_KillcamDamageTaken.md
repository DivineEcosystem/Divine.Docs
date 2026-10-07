# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_KillcamDamageTaken"></a> Class CDOTAUserMsg\_KillcamDamageTaken

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_KillcamDamageTaken : IMessage<CDOTAUserMsg_KillcamDamageTaken>, IEquatable<CDOTAUserMsg_KillcamDamageTaken>, IDeepCloneable<CDOTAUserMsg_KillcamDamageTaken>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_KillcamDamageTaken](Divine.Protobufs.Dota2.CDOTAUserMsg\_KillcamDamageTaken.md)

#### Implements

IMessage<CDOTAUserMsg\_KillcamDamageTaken\>, 
[IEquatable<CDOTAUserMsg\_KillcamDamageTaken\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_KillcamDamageTaken\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_KillcamDamageTaken\>\(CDOTAUserMsg\_KillcamDamageTaken, params CDOTAUserMsg\_KillcamDamageTaken\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_KillcamDamageTaken__ctor"></a> CDOTAUserMsg\_KillcamDamageTaken\(\)

```csharp
public CDOTAUserMsg_KillcamDamageTaken()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_KillcamDamageTaken__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_KillcamDamageTaken_"></a> CDOTAUserMsg\_KillcamDamageTaken\(CDOTAUserMsg\_KillcamDamageTaken\)

```csharp
public CDOTAUserMsg_KillcamDamageTaken(CDOTAUserMsg_KillcamDamageTaken other)
```

#### Parameters

`other` [CDOTAUserMsg\_KillcamDamageTaken](Divine.Protobufs.Dota2.CDOTAUserMsg\_KillcamDamageTaken.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_KillcamDamageTaken_DamageColorFieldNumber"></a> DamageColorFieldNumber

```csharp
public const int DamageColorFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_KillcamDamageTaken_DamageTakenFieldNumber"></a> DamageTakenFieldNumber

```csharp
public const int DamageTakenFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_KillcamDamageTaken_HeroNameFieldNumber"></a> HeroNameFieldNumber

```csharp
public const int HeroNameFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_KillcamDamageTaken_ItemAbilityIdFieldNumber"></a> ItemAbilityIdFieldNumber

```csharp
public const int ItemAbilityIdFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_KillcamDamageTaken_ItemTypeFieldNumber"></a> ItemTypeFieldNumber

```csharp
public const int ItemTypeFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_KillcamDamageTaken_PlayerIdFieldNumber"></a> PlayerIdFieldNumber

```csharp
public const int PlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_KillcamDamageTaken_DamageColor"></a> DamageColor

```csharp
public string DamageColor { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_KillcamDamageTaken_DamageTaken"></a> DamageTaken

```csharp
public uint DamageTaken { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_KillcamDamageTaken_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_KillcamDamageTaken_HasDamageColor"></a> HasDamageColor

```csharp
public bool HasDamageColor { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_KillcamDamageTaken_HasDamageTaken"></a> HasDamageTaken

```csharp
public bool HasDamageTaken { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_KillcamDamageTaken_HasHeroName"></a> HasHeroName

```csharp
public bool HasHeroName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_KillcamDamageTaken_HasItemAbilityId"></a> HasItemAbilityId

```csharp
public bool HasItemAbilityId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_KillcamDamageTaken_HasItemType"></a> HasItemType

```csharp
public bool HasItemType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_KillcamDamageTaken_HasPlayerId"></a> HasPlayerId

```csharp
public bool HasPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_KillcamDamageTaken_HeroName"></a> HeroName

```csharp
public string HeroName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_KillcamDamageTaken_ItemAbilityId"></a> ItemAbilityId

```csharp
public int ItemAbilityId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_KillcamDamageTaken_ItemType"></a> ItemType

```csharp
public uint ItemType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_KillcamDamageTaken_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_KillcamDamageTaken> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_KillcamDamageTaken](Divine.Protobufs.Dota2.CDOTAUserMsg\_KillcamDamageTaken.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_KillcamDamageTaken_PlayerId"></a> PlayerId

```csharp
public int PlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_KillcamDamageTaken_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_KillcamDamageTaken_ClearDamageColor"></a> ClearDamageColor\(\)

```csharp
public void ClearDamageColor()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_KillcamDamageTaken_ClearDamageTaken"></a> ClearDamageTaken\(\)

```csharp
public void ClearDamageTaken()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_KillcamDamageTaken_ClearHeroName"></a> ClearHeroName\(\)

```csharp
public void ClearHeroName()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_KillcamDamageTaken_ClearItemAbilityId"></a> ClearItemAbilityId\(\)

```csharp
public void ClearItemAbilityId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_KillcamDamageTaken_ClearItemType"></a> ClearItemType\(\)

```csharp
public void ClearItemType()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_KillcamDamageTaken_ClearPlayerId"></a> ClearPlayerId\(\)

```csharp
public void ClearPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_KillcamDamageTaken_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_KillcamDamageTaken Clone()
```

#### Returns

 [CDOTAUserMsg\_KillcamDamageTaken](Divine.Protobufs.Dota2.CDOTAUserMsg\_KillcamDamageTaken.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_KillcamDamageTaken_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_KillcamDamageTaken_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_KillcamDamageTaken_"></a> Equals\(CDOTAUserMsg\_KillcamDamageTaken\)

```csharp
public bool Equals(CDOTAUserMsg_KillcamDamageTaken other)
```

#### Parameters

`other` [CDOTAUserMsg\_KillcamDamageTaken](Divine.Protobufs.Dota2.CDOTAUserMsg\_KillcamDamageTaken.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_KillcamDamageTaken_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_KillcamDamageTaken_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_KillcamDamageTaken_"></a> MergeFrom\(CDOTAUserMsg\_KillcamDamageTaken\)

```csharp
public void MergeFrom(CDOTAUserMsg_KillcamDamageTaken other)
```

#### Parameters

`other` [CDOTAUserMsg\_KillcamDamageTaken](Divine.Protobufs.Dota2.CDOTAUserMsg\_KillcamDamageTaken.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_KillcamDamageTaken_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_KillcamDamageTaken_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_KillcamDamageTaken_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

