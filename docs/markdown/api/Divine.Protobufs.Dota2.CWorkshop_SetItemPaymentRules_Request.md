# <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request"></a> Class CWorkshop\_SetItemPaymentRules\_Request

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CWorkshop_SetItemPaymentRules_Request : IMessage<CWorkshop_SetItemPaymentRules_Request>, IEquatable<CWorkshop_SetItemPaymentRules_Request>, IDeepCloneable<CWorkshop_SetItemPaymentRules_Request>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CWorkshop\_SetItemPaymentRules\_Request](Divine.Protobufs.Dota2.CWorkshop\_SetItemPaymentRules\_Request.md)

#### Implements

IMessage<CWorkshop\_SetItemPaymentRules\_Request\>, 
[IEquatable<CWorkshop\_SetItemPaymentRules\_Request\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CWorkshop\_SetItemPaymentRules\_Request\>, 
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
[EnumerableExtensions.In<CWorkshop\_SetItemPaymentRules\_Request\>\(CWorkshop\_SetItemPaymentRules\_Request, params CWorkshop\_SetItemPaymentRules\_Request\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request__ctor"></a> CWorkshop\_SetItemPaymentRules\_Request\(\)

```csharp
public CWorkshop_SetItemPaymentRules_Request()
```

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request__ctor_Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_"></a> CWorkshop\_SetItemPaymentRules\_Request\(CWorkshop\_SetItemPaymentRules\_Request\)

```csharp
public CWorkshop_SetItemPaymentRules_Request(CWorkshop_SetItemPaymentRules_Request other)
```

#### Parameters

`other` [CWorkshop\_SetItemPaymentRules\_Request](Divine.Protobufs.Dota2.CWorkshop\_SetItemPaymentRules\_Request.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_AppidFieldNumber"></a> AppidFieldNumber

```csharp
public const int AppidFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_AssociatedWorkshopFileForDirectPaymentsFieldNumber"></a> AssociatedWorkshopFileForDirectPaymentsFieldNumber

```csharp
public const int AssociatedWorkshopFileForDirectPaymentsFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_AssociatedWorkshopFilesFieldNumber"></a> AssociatedWorkshopFilesFieldNumber

```csharp
public const int AssociatedWorkshopFilesFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_GameitemidFieldNumber"></a> GameitemidFieldNumber

```csharp
public const int GameitemidFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_MakeWorkshopFilesSubscribableFieldNumber"></a> MakeWorkshopFilesSubscribableFieldNumber

```csharp
public const int MakeWorkshopFilesSubscribableFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_PartnerAccountsFieldNumber"></a> PartnerAccountsFieldNumber

```csharp
public const int PartnerAccountsFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_ValidateOnlyFieldNumber"></a> ValidateOnlyFieldNumber

```csharp
public const int ValidateOnlyFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Appid"></a> Appid

```csharp
public uint Appid { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_AssociatedWorkshopFileForDirectPayments"></a> AssociatedWorkshopFileForDirectPayments

```csharp
public CWorkshop_SetItemPaymentRules_Request.Types.WorkshopDirectPaymentRule AssociatedWorkshopFileForDirectPayments { get; set; }
```

#### Property Value

 [CWorkshop\_SetItemPaymentRules\_Request](Divine.Protobufs.Dota2.CWorkshop\_SetItemPaymentRules\_Request.md).[Types](Divine.Protobufs.Dota2.CWorkshop\_SetItemPaymentRules\_Request.Types.md).[WorkshopDirectPaymentRule](Divine.Protobufs.Dota2.CWorkshop\_SetItemPaymentRules\_Request.Types.WorkshopDirectPaymentRule.md)

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_AssociatedWorkshopFiles"></a> AssociatedWorkshopFiles

```csharp
public RepeatedField<CWorkshop_SetItemPaymentRules_Request.Types.WorkshopItemPaymentRule> AssociatedWorkshopFiles { get; }
```

#### Property Value

 RepeatedField<[CWorkshop\_SetItemPaymentRules\_Request](Divine.Protobufs.Dota2.CWorkshop\_SetItemPaymentRules\_Request.md).[Types](Divine.Protobufs.Dota2.CWorkshop\_SetItemPaymentRules\_Request.Types.md).[WorkshopItemPaymentRule](Divine.Protobufs.Dota2.CWorkshop\_SetItemPaymentRules\_Request.Types.WorkshopItemPaymentRule.md)\>

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Gameitemid"></a> Gameitemid

```csharp
public uint Gameitemid { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_HasAppid"></a> HasAppid

```csharp
public bool HasAppid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_HasGameitemid"></a> HasGameitemid

```csharp
public bool HasGameitemid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_HasMakeWorkshopFilesSubscribable"></a> HasMakeWorkshopFilesSubscribable

```csharp
public bool HasMakeWorkshopFilesSubscribable { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_HasValidateOnly"></a> HasValidateOnly

```csharp
public bool HasValidateOnly { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_MakeWorkshopFilesSubscribable"></a> MakeWorkshopFilesSubscribable

```csharp
public bool MakeWorkshopFilesSubscribable { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Parser"></a> Parser

```csharp
public static MessageParser<CWorkshop_SetItemPaymentRules_Request> Parser { get; }
```

#### Property Value

 MessageParser<[CWorkshop\_SetItemPaymentRules\_Request](Divine.Protobufs.Dota2.CWorkshop\_SetItemPaymentRules\_Request.md)\>

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_PartnerAccounts"></a> PartnerAccounts

```csharp
public RepeatedField<CWorkshop_SetItemPaymentRules_Request.Types.PartnerItemPaymentRule> PartnerAccounts { get; }
```

#### Property Value

 RepeatedField<[CWorkshop\_SetItemPaymentRules\_Request](Divine.Protobufs.Dota2.CWorkshop\_SetItemPaymentRules\_Request.md).[Types](Divine.Protobufs.Dota2.CWorkshop\_SetItemPaymentRules\_Request.Types.md).[PartnerItemPaymentRule](Divine.Protobufs.Dota2.CWorkshop\_SetItemPaymentRules\_Request.Types.PartnerItemPaymentRule.md)\>

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_ValidateOnly"></a> ValidateOnly

```csharp
public bool ValidateOnly { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_ClearAppid"></a> ClearAppid\(\)

```csharp
public void ClearAppid()
```

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_ClearGameitemid"></a> ClearGameitemid\(\)

```csharp
public void ClearGameitemid()
```

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_ClearMakeWorkshopFilesSubscribable"></a> ClearMakeWorkshopFilesSubscribable\(\)

```csharp
public void ClearMakeWorkshopFilesSubscribable()
```

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_ClearValidateOnly"></a> ClearValidateOnly\(\)

```csharp
public void ClearValidateOnly()
```

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Clone"></a> Clone\(\)

```csharp
public CWorkshop_SetItemPaymentRules_Request Clone()
```

#### Returns

 [CWorkshop\_SetItemPaymentRules\_Request](Divine.Protobufs.Dota2.CWorkshop\_SetItemPaymentRules\_Request.md)

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_Equals_Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_"></a> Equals\(CWorkshop\_SetItemPaymentRules\_Request\)

```csharp
public bool Equals(CWorkshop_SetItemPaymentRules_Request other)
```

#### Parameters

`other` [CWorkshop\_SetItemPaymentRules\_Request](Divine.Protobufs.Dota2.CWorkshop\_SetItemPaymentRules\_Request.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_MergeFrom_Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_"></a> MergeFrom\(CWorkshop\_SetItemPaymentRules\_Request\)

```csharp
public void MergeFrom(CWorkshop_SetItemPaymentRules_Request other)
```

#### Parameters

`other` [CWorkshop\_SetItemPaymentRules\_Request](Divine.Protobufs.Dota2.CWorkshop\_SetItemPaymentRules\_Request.md)

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CWorkshop_SetItemPaymentRules_Request_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

