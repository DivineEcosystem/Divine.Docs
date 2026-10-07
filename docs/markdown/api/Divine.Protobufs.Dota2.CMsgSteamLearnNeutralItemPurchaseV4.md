# <a id="Divine_Protobufs_Dota2_CMsgSteamLearnNeutralItemPurchaseV4"></a> Class CMsgSteamLearnNeutralItemPurchaseV4

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamLearnNeutralItemPurchaseV4 : IMessage<CMsgSteamLearnNeutralItemPurchaseV4>, IEquatable<CMsgSteamLearnNeutralItemPurchaseV4>, IDeepCloneable<CMsgSteamLearnNeutralItemPurchaseV4>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamLearnNeutralItemPurchaseV4](Divine.Protobufs.Dota2.CMsgSteamLearnNeutralItemPurchaseV4.md)

#### Implements

IMessage<CMsgSteamLearnNeutralItemPurchaseV4\>, 
[IEquatable<CMsgSteamLearnNeutralItemPurchaseV4\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamLearnNeutralItemPurchaseV4\>, 
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
[EnumerableExtensions.In<CMsgSteamLearnNeutralItemPurchaseV4\>\(CMsgSteamLearnNeutralItemPurchaseV4, params CMsgSteamLearnNeutralItemPurchaseV4\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnNeutralItemPurchaseV4__ctor"></a> CMsgSteamLearnNeutralItemPurchaseV4\(\)

```csharp
public CMsgSteamLearnNeutralItemPurchaseV4()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnNeutralItemPurchaseV4__ctor_Divine_Protobufs_Dota2_CMsgSteamLearnNeutralItemPurchaseV4_"></a> CMsgSteamLearnNeutralItemPurchaseV4\(CMsgSteamLearnNeutralItemPurchaseV4\)

```csharp
public CMsgSteamLearnNeutralItemPurchaseV4(CMsgSteamLearnNeutralItemPurchaseV4 other)
```

#### Parameters

`other` [CMsgSteamLearnNeutralItemPurchaseV4](Divine.Protobufs.Dota2.CMsgSteamLearnNeutralItemPurchaseV4.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnNeutralItemPurchaseV4_EnhancementIdFieldNumber"></a> EnhancementIdFieldNumber

```csharp
public const int EnhancementIdFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnNeutralItemPurchaseV4_EnhancementOptionsFieldNumber"></a> EnhancementOptionsFieldNumber

```csharp
public const int EnhancementOptionsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnNeutralItemPurchaseV4_TierFieldNumber"></a> TierFieldNumber

```csharp
public const int TierFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnNeutralItemPurchaseV4_TrinketIdFieldNumber"></a> TrinketIdFieldNumber

```csharp
public const int TrinketIdFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnNeutralItemPurchaseV4_TrinketOptionsFieldNumber"></a> TrinketOptionsFieldNumber

```csharp
public const int TrinketOptionsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnNeutralItemPurchaseV4_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnNeutralItemPurchaseV4_EnhancementId"></a> EnhancementId

```csharp
public int EnhancementId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnNeutralItemPurchaseV4_EnhancementOptions"></a> EnhancementOptions

```csharp
public RepeatedField<int> EnhancementOptions { get; }
```

#### Property Value

 RepeatedField<[int](https://learn.microsoft.com/dotnet/api/system.int32)\>

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnNeutralItemPurchaseV4_HasEnhancementId"></a> HasEnhancementId

```csharp
public bool HasEnhancementId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnNeutralItemPurchaseV4_HasTier"></a> HasTier

```csharp
public bool HasTier { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnNeutralItemPurchaseV4_HasTrinketId"></a> HasTrinketId

```csharp
public bool HasTrinketId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnNeutralItemPurchaseV4_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamLearnNeutralItemPurchaseV4> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamLearnNeutralItemPurchaseV4](Divine.Protobufs.Dota2.CMsgSteamLearnNeutralItemPurchaseV4.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnNeutralItemPurchaseV4_Tier"></a> Tier

```csharp
public uint Tier { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnNeutralItemPurchaseV4_TrinketId"></a> TrinketId

```csharp
public int TrinketId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnNeutralItemPurchaseV4_TrinketOptions"></a> TrinketOptions

```csharp
public RepeatedField<int> TrinketOptions { get; }
```

#### Property Value

 RepeatedField<[int](https://learn.microsoft.com/dotnet/api/system.int32)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnNeutralItemPurchaseV4_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnNeutralItemPurchaseV4_ClearEnhancementId"></a> ClearEnhancementId\(\)

```csharp
public void ClearEnhancementId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnNeutralItemPurchaseV4_ClearTier"></a> ClearTier\(\)

```csharp
public void ClearTier()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnNeutralItemPurchaseV4_ClearTrinketId"></a> ClearTrinketId\(\)

```csharp
public void ClearTrinketId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnNeutralItemPurchaseV4_Clone"></a> Clone\(\)

```csharp
public CMsgSteamLearnNeutralItemPurchaseV4 Clone()
```

#### Returns

 [CMsgSteamLearnNeutralItemPurchaseV4](Divine.Protobufs.Dota2.CMsgSteamLearnNeutralItemPurchaseV4.md)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnNeutralItemPurchaseV4_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnNeutralItemPurchaseV4_Equals_Divine_Protobufs_Dota2_CMsgSteamLearnNeutralItemPurchaseV4_"></a> Equals\(CMsgSteamLearnNeutralItemPurchaseV4\)

```csharp
public bool Equals(CMsgSteamLearnNeutralItemPurchaseV4 other)
```

#### Parameters

`other` [CMsgSteamLearnNeutralItemPurchaseV4](Divine.Protobufs.Dota2.CMsgSteamLearnNeutralItemPurchaseV4.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnNeutralItemPurchaseV4_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnNeutralItemPurchaseV4_MergeFrom_Divine_Protobufs_Dota2_CMsgSteamLearnNeutralItemPurchaseV4_"></a> MergeFrom\(CMsgSteamLearnNeutralItemPurchaseV4\)

```csharp
public void MergeFrom(CMsgSteamLearnNeutralItemPurchaseV4 other)
```

#### Parameters

`other` [CMsgSteamLearnNeutralItemPurchaseV4](Divine.Protobufs.Dota2.CMsgSteamLearnNeutralItemPurchaseV4.md)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnNeutralItemPurchaseV4_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnNeutralItemPurchaseV4_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSteamLearnNeutralItemPurchaseV4_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

