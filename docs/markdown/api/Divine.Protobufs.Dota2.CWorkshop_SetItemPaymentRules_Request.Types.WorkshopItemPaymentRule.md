# <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_WorkshopItemPaymentRule"></a> Class CWorkshop\_SetItemPaymentRules\_Request.Types.WorkshopItemPaymentRule

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CWorkshop_SetItemPaymentRules_Request.Types.WorkshopItemPaymentRule : IMessage<CWorkshop_SetItemPaymentRules_Request.Types.WorkshopItemPaymentRule>, IEquatable<CWorkshop_SetItemPaymentRules_Request.Types.WorkshopItemPaymentRule>, IDeepCloneable<CWorkshop_SetItemPaymentRules_Request.Types.WorkshopItemPaymentRule>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CWorkshop\_SetItemPaymentRules\_Request.Types.WorkshopItemPaymentRule](Divine.Protobufs.Dota2.CWorkshop\_SetItemPaymentRules\_Request.Types.WorkshopItemPaymentRule.md)

#### Implements

IMessage<CWorkshop\_SetItemPaymentRules\_Request.Types.WorkshopItemPaymentRule\>, 
[IEquatable<CWorkshop\_SetItemPaymentRules\_Request.Types.WorkshopItemPaymentRule\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CWorkshop\_SetItemPaymentRules\_Request.Types.WorkshopItemPaymentRule\>, 
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
[EnumerableExtensions.In<CWorkshop\_SetItemPaymentRules\_Request.Types.WorkshopItemPaymentRule\>\(CWorkshop\_SetItemPaymentRules\_Request.Types.WorkshopItemPaymentRule, params CWorkshop\_SetItemPaymentRules\_Request.Types.WorkshopItemPaymentRule\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_WorkshopItemPaymentRule__ctor"></a> WorkshopItemPaymentRule\(\)

```csharp
public WorkshopItemPaymentRule()
```

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_WorkshopItemPaymentRule__ctor_Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_WorkshopItemPaymentRule_"></a> WorkshopItemPaymentRule\(WorkshopItemPaymentRule\)

```csharp
public WorkshopItemPaymentRule(CWorkshop_SetItemPaymentRules_Request.Types.WorkshopItemPaymentRule other)
```

#### Parameters

`other` [CWorkshop\_SetItemPaymentRules\_Request](Divine.Protobufs.Dota2.CWorkshop\_SetItemPaymentRules\_Request.md).[Types](Divine.Protobufs.Dota2.CWorkshop\_SetItemPaymentRules\_Request.Types.md).[WorkshopItemPaymentRule](Divine.Protobufs.Dota2.CWorkshop\_SetItemPaymentRules\_Request.Types.WorkshopItemPaymentRule.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_WorkshopItemPaymentRule_RevenuePercentageFieldNumber"></a> RevenuePercentageFieldNumber

```csharp
public const int RevenuePercentageFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_WorkshopItemPaymentRule_RuleDescriptionFieldNumber"></a> RuleDescriptionFieldNumber

```csharp
public const int RuleDescriptionFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_WorkshopItemPaymentRule_RuleTypeFieldNumber"></a> RuleTypeFieldNumber

```csharp
public const int RuleTypeFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_WorkshopItemPaymentRule_WorkshopFileIdFieldNumber"></a> WorkshopFileIdFieldNumber

```csharp
public const int WorkshopFileIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_WorkshopItemPaymentRule_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_WorkshopItemPaymentRule_HasRevenuePercentage"></a> HasRevenuePercentage

```csharp
public bool HasRevenuePercentage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_WorkshopItemPaymentRule_HasRuleDescription"></a> HasRuleDescription

```csharp
public bool HasRuleDescription { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_WorkshopItemPaymentRule_HasRuleType"></a> HasRuleType

```csharp
public bool HasRuleType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_WorkshopItemPaymentRule_HasWorkshopFileId"></a> HasWorkshopFileId

```csharp
public bool HasWorkshopFileId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_WorkshopItemPaymentRule_Parser"></a> Parser

```csharp
public static MessageParser<CWorkshop_SetItemPaymentRules_Request.Types.WorkshopItemPaymentRule> Parser { get; }
```

#### Property Value

 MessageParser<[CWorkshop\_SetItemPaymentRules\_Request](Divine.Protobufs.Dota2.CWorkshop\_SetItemPaymentRules\_Request.md).[Types](Divine.Protobufs.Dota2.CWorkshop\_SetItemPaymentRules\_Request.Types.md).[WorkshopItemPaymentRule](Divine.Protobufs.Dota2.CWorkshop\_SetItemPaymentRules\_Request.Types.WorkshopItemPaymentRule.md)\>

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_WorkshopItemPaymentRule_RevenuePercentage"></a> RevenuePercentage

```csharp
public float RevenuePercentage { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_WorkshopItemPaymentRule_RuleDescription"></a> RuleDescription

```csharp
public string RuleDescription { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_WorkshopItemPaymentRule_RuleType"></a> RuleType

```csharp
public uint RuleType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_WorkshopItemPaymentRule_WorkshopFileId"></a> WorkshopFileId

```csharp
public ulong WorkshopFileId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_WorkshopItemPaymentRule_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_WorkshopItemPaymentRule_ClearRevenuePercentage"></a> ClearRevenuePercentage\(\)

```csharp
public void ClearRevenuePercentage()
```

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_WorkshopItemPaymentRule_ClearRuleDescription"></a> ClearRuleDescription\(\)

```csharp
public void ClearRuleDescription()
```

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_WorkshopItemPaymentRule_ClearRuleType"></a> ClearRuleType\(\)

```csharp
public void ClearRuleType()
```

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_WorkshopItemPaymentRule_ClearWorkshopFileId"></a> ClearWorkshopFileId\(\)

```csharp
public void ClearWorkshopFileId()
```

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_WorkshopItemPaymentRule_Clone"></a> Clone\(\)

```csharp
public CWorkshop_SetItemPaymentRules_Request.Types.WorkshopItemPaymentRule Clone()
```

#### Returns

 [CWorkshop\_SetItemPaymentRules\_Request](Divine.Protobufs.Dota2.CWorkshop\_SetItemPaymentRules\_Request.md).[Types](Divine.Protobufs.Dota2.CWorkshop\_SetItemPaymentRules\_Request.Types.md).[WorkshopItemPaymentRule](Divine.Protobufs.Dota2.CWorkshop\_SetItemPaymentRules\_Request.Types.WorkshopItemPaymentRule.md)

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_WorkshopItemPaymentRule_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_WorkshopItemPaymentRule_Equals_Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_WorkshopItemPaymentRule_"></a> Equals\(WorkshopItemPaymentRule\)

```csharp
public bool Equals(CWorkshop_SetItemPaymentRules_Request.Types.WorkshopItemPaymentRule other)
```

#### Parameters

`other` [CWorkshop\_SetItemPaymentRules\_Request](Divine.Protobufs.Dota2.CWorkshop\_SetItemPaymentRules\_Request.md).[Types](Divine.Protobufs.Dota2.CWorkshop\_SetItemPaymentRules\_Request.Types.md).[WorkshopItemPaymentRule](Divine.Protobufs.Dota2.CWorkshop\_SetItemPaymentRules\_Request.Types.WorkshopItemPaymentRule.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_WorkshopItemPaymentRule_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_WorkshopItemPaymentRule_MergeFrom_Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_WorkshopItemPaymentRule_"></a> MergeFrom\(WorkshopItemPaymentRule\)

```csharp
public void MergeFrom(CWorkshop_SetItemPaymentRules_Request.Types.WorkshopItemPaymentRule other)
```

#### Parameters

`other` [CWorkshop\_SetItemPaymentRules\_Request](Divine.Protobufs.Dota2.CWorkshop\_SetItemPaymentRules\_Request.md).[Types](Divine.Protobufs.Dota2.CWorkshop\_SetItemPaymentRules\_Request.Types.md).[WorkshopItemPaymentRule](Divine.Protobufs.Dota2.CWorkshop\_SetItemPaymentRules\_Request.Types.WorkshopItemPaymentRule.md)

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_WorkshopItemPaymentRule_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_WorkshopItemPaymentRule_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_WorkshopItemPaymentRule_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

