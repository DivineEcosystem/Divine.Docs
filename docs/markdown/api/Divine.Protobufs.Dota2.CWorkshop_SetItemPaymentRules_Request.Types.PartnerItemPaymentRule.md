# <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_PartnerItemPaymentRule"></a> Class CWorkshop\_SetItemPaymentRules\_Request.Types.PartnerItemPaymentRule

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CWorkshop_SetItemPaymentRules_Request.Types.PartnerItemPaymentRule : IMessage<CWorkshop_SetItemPaymentRules_Request.Types.PartnerItemPaymentRule>, IEquatable<CWorkshop_SetItemPaymentRules_Request.Types.PartnerItemPaymentRule>, IDeepCloneable<CWorkshop_SetItemPaymentRules_Request.Types.PartnerItemPaymentRule>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CWorkshop\_SetItemPaymentRules\_Request.Types.PartnerItemPaymentRule](Divine.Protobufs.Dota2.CWorkshop\_SetItemPaymentRules\_Request.Types.PartnerItemPaymentRule.md)

#### Implements

IMessage<CWorkshop\_SetItemPaymentRules\_Request.Types.PartnerItemPaymentRule\>, 
[IEquatable<CWorkshop\_SetItemPaymentRules\_Request.Types.PartnerItemPaymentRule\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CWorkshop\_SetItemPaymentRules\_Request.Types.PartnerItemPaymentRule\>, 
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
[EnumerableExtensions.In<CWorkshop\_SetItemPaymentRules\_Request.Types.PartnerItemPaymentRule\>\(CWorkshop\_SetItemPaymentRules\_Request.Types.PartnerItemPaymentRule, params CWorkshop\_SetItemPaymentRules\_Request.Types.PartnerItemPaymentRule\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_PartnerItemPaymentRule__ctor"></a> PartnerItemPaymentRule\(\)

```csharp
public PartnerItemPaymentRule()
```

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_PartnerItemPaymentRule__ctor_Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_PartnerItemPaymentRule_"></a> PartnerItemPaymentRule\(PartnerItemPaymentRule\)

```csharp
public PartnerItemPaymentRule(CWorkshop_SetItemPaymentRules_Request.Types.PartnerItemPaymentRule other)
```

#### Parameters

`other` [CWorkshop\_SetItemPaymentRules\_Request](Divine.Protobufs.Dota2.CWorkshop\_SetItemPaymentRules\_Request.md).[Types](Divine.Protobufs.Dota2.CWorkshop\_SetItemPaymentRules\_Request.Types.md).[PartnerItemPaymentRule](Divine.Protobufs.Dota2.CWorkshop\_SetItemPaymentRules\_Request.Types.PartnerItemPaymentRule.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_PartnerItemPaymentRule_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_PartnerItemPaymentRule_RevenuePercentageFieldNumber"></a> RevenuePercentageFieldNumber

```csharp
public const int RevenuePercentageFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_PartnerItemPaymentRule_RuleDescriptionFieldNumber"></a> RuleDescriptionFieldNumber

```csharp
public const int RuleDescriptionFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_PartnerItemPaymentRule_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_PartnerItemPaymentRule_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_PartnerItemPaymentRule_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_PartnerItemPaymentRule_HasRevenuePercentage"></a> HasRevenuePercentage

```csharp
public bool HasRevenuePercentage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_PartnerItemPaymentRule_HasRuleDescription"></a> HasRuleDescription

```csharp
public bool HasRuleDescription { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_PartnerItemPaymentRule_Parser"></a> Parser

```csharp
public static MessageParser<CWorkshop_SetItemPaymentRules_Request.Types.PartnerItemPaymentRule> Parser { get; }
```

#### Property Value

 MessageParser<[CWorkshop\_SetItemPaymentRules\_Request](Divine.Protobufs.Dota2.CWorkshop\_SetItemPaymentRules\_Request.md).[Types](Divine.Protobufs.Dota2.CWorkshop\_SetItemPaymentRules\_Request.Types.md).[PartnerItemPaymentRule](Divine.Protobufs.Dota2.CWorkshop\_SetItemPaymentRules\_Request.Types.PartnerItemPaymentRule.md)\>

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_PartnerItemPaymentRule_RevenuePercentage"></a> RevenuePercentage

```csharp
public float RevenuePercentage { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_PartnerItemPaymentRule_RuleDescription"></a> RuleDescription

```csharp
public string RuleDescription { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_PartnerItemPaymentRule_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_PartnerItemPaymentRule_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_PartnerItemPaymentRule_ClearRevenuePercentage"></a> ClearRevenuePercentage\(\)

```csharp
public void ClearRevenuePercentage()
```

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_PartnerItemPaymentRule_ClearRuleDescription"></a> ClearRuleDescription\(\)

```csharp
public void ClearRuleDescription()
```

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_PartnerItemPaymentRule_Clone"></a> Clone\(\)

```csharp
public CWorkshop_SetItemPaymentRules_Request.Types.PartnerItemPaymentRule Clone()
```

#### Returns

 [CWorkshop\_SetItemPaymentRules\_Request](Divine.Protobufs.Dota2.CWorkshop\_SetItemPaymentRules\_Request.md).[Types](Divine.Protobufs.Dota2.CWorkshop\_SetItemPaymentRules\_Request.Types.md).[PartnerItemPaymentRule](Divine.Protobufs.Dota2.CWorkshop\_SetItemPaymentRules\_Request.Types.PartnerItemPaymentRule.md)

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_PartnerItemPaymentRule_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_PartnerItemPaymentRule_Equals_Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_PartnerItemPaymentRule_"></a> Equals\(PartnerItemPaymentRule\)

```csharp
public bool Equals(CWorkshop_SetItemPaymentRules_Request.Types.PartnerItemPaymentRule other)
```

#### Parameters

`other` [CWorkshop\_SetItemPaymentRules\_Request](Divine.Protobufs.Dota2.CWorkshop\_SetItemPaymentRules\_Request.md).[Types](Divine.Protobufs.Dota2.CWorkshop\_SetItemPaymentRules\_Request.Types.md).[PartnerItemPaymentRule](Divine.Protobufs.Dota2.CWorkshop\_SetItemPaymentRules\_Request.Types.PartnerItemPaymentRule.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_PartnerItemPaymentRule_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_PartnerItemPaymentRule_MergeFrom_Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_PartnerItemPaymentRule_"></a> MergeFrom\(PartnerItemPaymentRule\)

```csharp
public void MergeFrom(CWorkshop_SetItemPaymentRules_Request.Types.PartnerItemPaymentRule other)
```

#### Parameters

`other` [CWorkshop\_SetItemPaymentRules\_Request](Divine.Protobufs.Dota2.CWorkshop\_SetItemPaymentRules\_Request.md).[Types](Divine.Protobufs.Dota2.CWorkshop\_SetItemPaymentRules\_Request.Types.md).[PartnerItemPaymentRule](Divine.Protobufs.Dota2.CWorkshop\_SetItemPaymentRules\_Request.Types.PartnerItemPaymentRule.md)

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_PartnerItemPaymentRule_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_PartnerItemPaymentRule_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_PartnerItemPaymentRule_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

