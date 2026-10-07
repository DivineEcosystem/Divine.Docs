# <a id="Divine_Protobufs_Dota2_CMsgCandyShopUserData"></a> Class CMsgCandyShopUserData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgCandyShopUserData : IMessage<CMsgCandyShopUserData>, IEquatable<CMsgCandyShopUserData>, IDeepCloneable<CMsgCandyShopUserData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgCandyShopUserData](Divine.Protobufs.Dota2.CMsgCandyShopUserData.md)

#### Implements

IMessage<CMsgCandyShopUserData\>, 
[IEquatable<CMsgCandyShopUserData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgCandyShopUserData\>, 
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
[EnumerableExtensions.In<CMsgCandyShopUserData\>\(CMsgCandyShopUserData, params CMsgCandyShopUserData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopUserData__ctor"></a> CMsgCandyShopUserData\(\)

```csharp
public CMsgCandyShopUserData()
```

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopUserData__ctor_Divine_Protobufs_Dota2_CMsgCandyShopUserData_"></a> CMsgCandyShopUserData\(CMsgCandyShopUserData\)

```csharp
public CMsgCandyShopUserData(CMsgCandyShopUserData other)
```

#### Parameters

`other` [CMsgCandyShopUserData](Divine.Protobufs.Dota2.CMsgCandyShopUserData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopUserData_ActiveRewardMaxFieldNumber"></a> ActiveRewardMaxFieldNumber

```csharp
public const int ActiveRewardMaxFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopUserData_ActiveRewardsFieldNumber"></a> ActiveRewardsFieldNumber

```csharp
public const int ActiveRewardsFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopUserData_ExchangeRecipeMaxFieldNumber"></a> ExchangeRecipeMaxFieldNumber

```csharp
public const int ExchangeRecipeMaxFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopUserData_ExchangeRecipesFieldNumber"></a> ExchangeRecipesFieldNumber

```csharp
public const int ExchangeRecipesFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopUserData_ExchangeResetTimestampFieldNumber"></a> ExchangeResetTimestampFieldNumber

```csharp
public const int ExchangeResetTimestampFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopUserData_InventoryFieldNumber"></a> InventoryFieldNumber

```csharp
public const int InventoryFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopUserData_InventoryMaxFieldNumber"></a> InventoryMaxFieldNumber

```csharp
public const int InventoryMaxFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopUserData_RerollChargesFieldNumber"></a> RerollChargesFieldNumber

```csharp
public const int RerollChargesFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopUserData_RerollChargesMaxFieldNumber"></a> RerollChargesMaxFieldNumber

```csharp
public const int RerollChargesMaxFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopUserData_ActiveRewardMax"></a> ActiveRewardMax

```csharp
public uint ActiveRewardMax { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopUserData_ActiveRewards"></a> ActiveRewards

```csharp
public RepeatedField<CMsgCandyShopReward> ActiveRewards { get; }
```

#### Property Value

 RepeatedField<[CMsgCandyShopReward](Divine.Protobufs.Dota2.CMsgCandyShopReward.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopUserData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopUserData_ExchangeRecipeMax"></a> ExchangeRecipeMax

```csharp
public uint ExchangeRecipeMax { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopUserData_ExchangeRecipes"></a> ExchangeRecipes

```csharp
public RepeatedField<CMsgCandyShopExchangeRecipe> ExchangeRecipes { get; }
```

#### Property Value

 RepeatedField<[CMsgCandyShopExchangeRecipe](Divine.Protobufs.Dota2.CMsgCandyShopExchangeRecipe.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopUserData_ExchangeResetTimestamp"></a> ExchangeResetTimestamp

```csharp
public uint ExchangeResetTimestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopUserData_HasActiveRewardMax"></a> HasActiveRewardMax

```csharp
public bool HasActiveRewardMax { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopUserData_HasExchangeRecipeMax"></a> HasExchangeRecipeMax

```csharp
public bool HasExchangeRecipeMax { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopUserData_HasExchangeResetTimestamp"></a> HasExchangeResetTimestamp

```csharp
public bool HasExchangeResetTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopUserData_HasInventoryMax"></a> HasInventoryMax

```csharp
public bool HasInventoryMax { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopUserData_HasRerollCharges"></a> HasRerollCharges

```csharp
public bool HasRerollCharges { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopUserData_HasRerollChargesMax"></a> HasRerollChargesMax

```csharp
public bool HasRerollChargesMax { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopUserData_Inventory"></a> Inventory

```csharp
public CMsgCandyShopCandyQuantity Inventory { get; set; }
```

#### Property Value

 [CMsgCandyShopCandyQuantity](Divine.Protobufs.Dota2.CMsgCandyShopCandyQuantity.md)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopUserData_InventoryMax"></a> InventoryMax

```csharp
public uint InventoryMax { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopUserData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgCandyShopUserData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgCandyShopUserData](Divine.Protobufs.Dota2.CMsgCandyShopUserData.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopUserData_RerollCharges"></a> RerollCharges

```csharp
public uint RerollCharges { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopUserData_RerollChargesMax"></a> RerollChargesMax

```csharp
public uint RerollChargesMax { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopUserData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopUserData_ClearActiveRewardMax"></a> ClearActiveRewardMax\(\)

```csharp
public void ClearActiveRewardMax()
```

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopUserData_ClearExchangeRecipeMax"></a> ClearExchangeRecipeMax\(\)

```csharp
public void ClearExchangeRecipeMax()
```

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopUserData_ClearExchangeResetTimestamp"></a> ClearExchangeResetTimestamp\(\)

```csharp
public void ClearExchangeResetTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopUserData_ClearInventoryMax"></a> ClearInventoryMax\(\)

```csharp
public void ClearInventoryMax()
```

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopUserData_ClearRerollCharges"></a> ClearRerollCharges\(\)

```csharp
public void ClearRerollCharges()
```

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopUserData_ClearRerollChargesMax"></a> ClearRerollChargesMax\(\)

```csharp
public void ClearRerollChargesMax()
```

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopUserData_Clone"></a> Clone\(\)

```csharp
public CMsgCandyShopUserData Clone()
```

#### Returns

 [CMsgCandyShopUserData](Divine.Protobufs.Dota2.CMsgCandyShopUserData.md)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopUserData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopUserData_Equals_Divine_Protobufs_Dota2_CMsgCandyShopUserData_"></a> Equals\(CMsgCandyShopUserData\)

```csharp
public bool Equals(CMsgCandyShopUserData other)
```

#### Parameters

`other` [CMsgCandyShopUserData](Divine.Protobufs.Dota2.CMsgCandyShopUserData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopUserData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopUserData_MergeFrom_Divine_Protobufs_Dota2_CMsgCandyShopUserData_"></a> MergeFrom\(CMsgCandyShopUserData\)

```csharp
public void MergeFrom(CMsgCandyShopUserData other)
```

#### Parameters

`other` [CMsgCandyShopUserData](Divine.Protobufs.Dota2.CMsgCandyShopUserData.md)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopUserData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopUserData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopUserData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

