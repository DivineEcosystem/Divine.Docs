# <a id="Divine_Protobufs_Dota2_CMsgSteamLearnNeutralItemPurchaseV6"></a> Class CMsgSteamLearnNeutralItemPurchaseV6

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamLearnNeutralItemPurchaseV6 : IMessage<CMsgSteamLearnNeutralItemPurchaseV6>, IEquatable<CMsgSteamLearnNeutralItemPurchaseV6>, IDeepCloneable<CMsgSteamLearnNeutralItemPurchaseV6>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamLearnNeutralItemPurchaseV6](Divine.Protobufs.Dota2.CMsgSteamLearnNeutralItemPurchaseV6.md)

#### Implements

IMessage<CMsgSteamLearnNeutralItemPurchaseV6\>, 
[IEquatable<CMsgSteamLearnNeutralItemPurchaseV6\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamLearnNeutralItemPurchaseV6\>, 
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
[EnumerableExtensions.In<CMsgSteamLearnNeutralItemPurchaseV6\>\(CMsgSteamLearnNeutralItemPurchaseV6, params CMsgSteamLearnNeutralItemPurchaseV6\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnNeutralItemPurchaseV6__ctor"></a> CMsgSteamLearnNeutralItemPurchaseV6\(\)

```csharp
public CMsgSteamLearnNeutralItemPurchaseV6()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnNeutralItemPurchaseV6__ctor_Divine_Protobufs_Dota2_CMsgSteamLearnNeutralItemPurchaseV6_"></a> CMsgSteamLearnNeutralItemPurchaseV6\(CMsgSteamLearnNeutralItemPurchaseV6\)

```csharp
public CMsgSteamLearnNeutralItemPurchaseV6(CMsgSteamLearnNeutralItemPurchaseV6 other)
```

#### Parameters

`other` [CMsgSteamLearnNeutralItemPurchaseV6](Divine.Protobufs.Dota2.CMsgSteamLearnNeutralItemPurchaseV6.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnNeutralItemPurchaseV6_EnhancementIdFieldNumber"></a> EnhancementIdFieldNumber

```csharp
public const int EnhancementIdFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnNeutralItemPurchaseV6_EnhancementOptionsFieldNumber"></a> EnhancementOptionsFieldNumber

```csharp
public const int EnhancementOptionsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnNeutralItemPurchaseV6_TierFieldNumber"></a> TierFieldNumber

```csharp
public const int TierFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnNeutralItemPurchaseV6_TrinketIdFieldNumber"></a> TrinketIdFieldNumber

```csharp
public const int TrinketIdFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnNeutralItemPurchaseV6_TrinketOptionsFieldNumber"></a> TrinketOptionsFieldNumber

```csharp
public const int TrinketOptionsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnNeutralItemPurchaseV6_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnNeutralItemPurchaseV6_EnhancementId"></a> EnhancementId

```csharp
public int EnhancementId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnNeutralItemPurchaseV6_EnhancementOptions"></a> EnhancementOptions

```csharp
public RepeatedField<int> EnhancementOptions { get; }
```

#### Property Value

 RepeatedField<[int](https://learn.microsoft.com/dotnet/api/system.int32)\>

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnNeutralItemPurchaseV6_HasEnhancementId"></a> HasEnhancementId

```csharp
public bool HasEnhancementId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnNeutralItemPurchaseV6_HasTier"></a> HasTier

```csharp
public bool HasTier { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnNeutralItemPurchaseV6_HasTrinketId"></a> HasTrinketId

```csharp
public bool HasTrinketId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnNeutralItemPurchaseV6_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamLearnNeutralItemPurchaseV6> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamLearnNeutralItemPurchaseV6](Divine.Protobufs.Dota2.CMsgSteamLearnNeutralItemPurchaseV6.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnNeutralItemPurchaseV6_Tier"></a> Tier

```csharp
public uint Tier { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnNeutralItemPurchaseV6_TrinketId"></a> TrinketId

```csharp
public int TrinketId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnNeutralItemPurchaseV6_TrinketOptions"></a> TrinketOptions

```csharp
public RepeatedField<int> TrinketOptions { get; }
```

#### Property Value

 RepeatedField<[int](https://learn.microsoft.com/dotnet/api/system.int32)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnNeutralItemPurchaseV6_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnNeutralItemPurchaseV6_ClearEnhancementId"></a> ClearEnhancementId\(\)

```csharp
public void ClearEnhancementId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnNeutralItemPurchaseV6_ClearTier"></a> ClearTier\(\)

```csharp
public void ClearTier()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnNeutralItemPurchaseV6_ClearTrinketId"></a> ClearTrinketId\(\)

```csharp
public void ClearTrinketId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnNeutralItemPurchaseV6_Clone"></a> Clone\(\)

```csharp
public CMsgSteamLearnNeutralItemPurchaseV6 Clone()
```

#### Returns

 [CMsgSteamLearnNeutralItemPurchaseV6](Divine.Protobufs.Dota2.CMsgSteamLearnNeutralItemPurchaseV6.md)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnNeutralItemPurchaseV6_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnNeutralItemPurchaseV6_Equals_Divine_Protobufs_Dota2_CMsgSteamLearnNeutralItemPurchaseV6_"></a> Equals\(CMsgSteamLearnNeutralItemPurchaseV6\)

```csharp
public bool Equals(CMsgSteamLearnNeutralItemPurchaseV6 other)
```

#### Parameters

`other` [CMsgSteamLearnNeutralItemPurchaseV6](Divine.Protobufs.Dota2.CMsgSteamLearnNeutralItemPurchaseV6.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnNeutralItemPurchaseV6_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnNeutralItemPurchaseV6_MergeFrom_Divine_Protobufs_Dota2_CMsgSteamLearnNeutralItemPurchaseV6_"></a> MergeFrom\(CMsgSteamLearnNeutralItemPurchaseV6\)

```csharp
public void MergeFrom(CMsgSteamLearnNeutralItemPurchaseV6 other)
```

#### Parameters

`other` [CMsgSteamLearnNeutralItemPurchaseV6](Divine.Protobufs.Dota2.CMsgSteamLearnNeutralItemPurchaseV6.md)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnNeutralItemPurchaseV6_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnNeutralItemPurchaseV6_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnNeutralItemPurchaseV6_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

