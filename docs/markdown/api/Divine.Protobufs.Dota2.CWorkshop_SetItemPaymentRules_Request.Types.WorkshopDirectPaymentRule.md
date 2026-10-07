# <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_WorkshopDirectPaymentRule"></a> Class CWorkshop\_SetItemPaymentRules\_Request.Types.WorkshopDirectPaymentRule

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CWorkshop_SetItemPaymentRules_Request.Types.WorkshopDirectPaymentRule : IMessage<CWorkshop_SetItemPaymentRules_Request.Types.WorkshopDirectPaymentRule>, IEquatable<CWorkshop_SetItemPaymentRules_Request.Types.WorkshopDirectPaymentRule>, IDeepCloneable<CWorkshop_SetItemPaymentRules_Request.Types.WorkshopDirectPaymentRule>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CWorkshop\_SetItemPaymentRules\_Request.Types.WorkshopDirectPaymentRule](Divine.Protobufs.Dota2.CWorkshop\_SetItemPaymentRules\_Request.Types.WorkshopDirectPaymentRule.md)

#### Implements

IMessage<CWorkshop\_SetItemPaymentRules\_Request.Types.WorkshopDirectPaymentRule\>, 
[IEquatable<CWorkshop\_SetItemPaymentRules\_Request.Types.WorkshopDirectPaymentRule\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CWorkshop\_SetItemPaymentRules\_Request.Types.WorkshopDirectPaymentRule\>, 
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
[EnumerableExtensions.In<CWorkshop\_SetItemPaymentRules\_Request.Types.WorkshopDirectPaymentRule\>\(CWorkshop\_SetItemPaymentRules\_Request.Types.WorkshopDirectPaymentRule, params CWorkshop\_SetItemPaymentRules\_Request.Types.WorkshopDirectPaymentRule\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_WorkshopDirectPaymentRule__ctor"></a> WorkshopDirectPaymentRule\(\)

```csharp
public WorkshopDirectPaymentRule()
```

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_WorkshopDirectPaymentRule__ctor_Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_WorkshopDirectPaymentRule_"></a> WorkshopDirectPaymentRule\(WorkshopDirectPaymentRule\)

```csharp
public WorkshopDirectPaymentRule(CWorkshop_SetItemPaymentRules_Request.Types.WorkshopDirectPaymentRule other)
```

#### Parameters

`other` [CWorkshop\_SetItemPaymentRules\_Request](Divine.Protobufs.Dota2.CWorkshop\_SetItemPaymentRules\_Request.md).[Types](Divine.Protobufs.Dota2.CWorkshop\_SetItemPaymentRules\_Request.Types.md).[WorkshopDirectPaymentRule](Divine.Protobufs.Dota2.CWorkshop\_SetItemPaymentRules\_Request.Types.WorkshopDirectPaymentRule.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_WorkshopDirectPaymentRule_RuleDescriptionFieldNumber"></a> RuleDescriptionFieldNumber

```csharp
public const int RuleDescriptionFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_WorkshopDirectPaymentRule_WorkshopFileIdFieldNumber"></a> WorkshopFileIdFieldNumber

```csharp
public const int WorkshopFileIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_WorkshopDirectPaymentRule_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_WorkshopDirectPaymentRule_HasRuleDescription"></a> HasRuleDescription

```csharp
public bool HasRuleDescription { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_WorkshopDirectPaymentRule_HasWorkshopFileId"></a> HasWorkshopFileId

```csharp
public bool HasWorkshopFileId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_WorkshopDirectPaymentRule_Parser"></a> Parser

```csharp
public static MessageParser<CWorkshop_SetItemPaymentRules_Request.Types.WorkshopDirectPaymentRule> Parser { get; }
```

#### Property Value

 MessageParser<[CWorkshop\_SetItemPaymentRules\_Request](Divine.Protobufs.Dota2.CWorkshop\_SetItemPaymentRules\_Request.md).[Types](Divine.Protobufs.Dota2.CWorkshop\_SetItemPaymentRules\_Request.Types.md).[WorkshopDirectPaymentRule](Divine.Protobufs.Dota2.CWorkshop\_SetItemPaymentRules\_Request.Types.WorkshopDirectPaymentRule.md)\>

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_WorkshopDirectPaymentRule_RuleDescription"></a> RuleDescription

```csharp
public string RuleDescription { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_WorkshopDirectPaymentRule_WorkshopFileId"></a> WorkshopFileId

```csharp
public ulong WorkshopFileId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_WorkshopDirectPaymentRule_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_WorkshopDirectPaymentRule_ClearRuleDescription"></a> ClearRuleDescription\(\)

```csharp
public void ClearRuleDescription()
```

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_WorkshopDirectPaymentRule_ClearWorkshopFileId"></a> ClearWorkshopFileId\(\)

```csharp
public void ClearWorkshopFileId()
```

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_WorkshopDirectPaymentRule_Clone"></a> Clone\(\)

```csharp
public CWorkshop_SetItemPaymentRules_Request.Types.WorkshopDirectPaymentRule Clone()
```

#### Returns

 [CWorkshop\_SetItemPaymentRules\_Request](Divine.Protobufs.Dota2.CWorkshop\_SetItemPaymentRules\_Request.md).[Types](Divine.Protobufs.Dota2.CWorkshop\_SetItemPaymentRules\_Request.Types.md).[WorkshopDirectPaymentRule](Divine.Protobufs.Dota2.CWorkshop\_SetItemPaymentRules\_Request.Types.WorkshopDirectPaymentRule.md)

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_WorkshopDirectPaymentRule_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_WorkshopDirectPaymentRule_Equals_Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_WorkshopDirectPaymentRule_"></a> Equals\(WorkshopDirectPaymentRule\)

```csharp
public bool Equals(CWorkshop_SetItemPaymentRules_Request.Types.WorkshopDirectPaymentRule other)
```

#### Parameters

`other` [CWorkshop\_SetItemPaymentRules\_Request](Divine.Protobufs.Dota2.CWorkshop\_SetItemPaymentRules\_Request.md).[Types](Divine.Protobufs.Dota2.CWorkshop\_SetItemPaymentRules\_Request.Types.md).[WorkshopDirectPaymentRule](Divine.Protobufs.Dota2.CWorkshop\_SetItemPaymentRules\_Request.Types.WorkshopDirectPaymentRule.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_WorkshopDirectPaymentRule_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_WorkshopDirectPaymentRule_MergeFrom_Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_WorkshopDirectPaymentRule_"></a> MergeFrom\(WorkshopDirectPaymentRule\)

```csharp
public void MergeFrom(CWorkshop_SetItemPaymentRules_Request.Types.WorkshopDirectPaymentRule other)
```

#### Parameters

`other` [CWorkshop\_SetItemPaymentRules\_Request](Divine.Protobufs.Dota2.CWorkshop\_SetItemPaymentRules\_Request.md).[Types](Divine.Protobufs.Dota2.CWorkshop\_SetItemPaymentRules\_Request.Types.md).[WorkshopDirectPaymentRule](Divine.Protobufs.Dota2.CWorkshop\_SetItemPaymentRules\_Request.Types.WorkshopDirectPaymentRule.md)

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_WorkshopDirectPaymentRule_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_WorkshopDirectPaymentRule_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Types_WorkshopDirectPaymentRule_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

