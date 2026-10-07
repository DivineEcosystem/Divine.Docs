# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAlert"></a> Class CDOTAClientMsg\_QuickBuyAlert

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_QuickBuyAlert : IMessage<CDOTAClientMsg_QuickBuyAlert>, IEquatable<CDOTAClientMsg_QuickBuyAlert>, IDeepCloneable<CDOTAClientMsg_QuickBuyAlert>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_QuickBuyAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_QuickBuyAlert.md)

#### Implements

IMessage<CDOTAClientMsg\_QuickBuyAlert\>, 
[IEquatable<CDOTAClientMsg\_QuickBuyAlert\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_QuickBuyAlert\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_QuickBuyAlert\>\(CDOTAClientMsg\_QuickBuyAlert, params CDOTAClientMsg\_QuickBuyAlert\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAlert__ctor"></a> CDOTAClientMsg\_QuickBuyAlert\(\)

```csharp
public CDOTAClientMsg_QuickBuyAlert()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAlert__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAlert_"></a> CDOTAClientMsg\_QuickBuyAlert\(CDOTAClientMsg\_QuickBuyAlert\)

```csharp
public CDOTAClientMsg_QuickBuyAlert(CDOTAClientMsg_QuickBuyAlert other)
```

#### Parameters

`other` [CDOTAClientMsg\_QuickBuyAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_QuickBuyAlert.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAlert_GoldCostFieldNumber"></a> GoldCostFieldNumber

```csharp
public const int GoldCostFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAlert_ItemAbilityIdFieldNumber"></a> ItemAbilityIdFieldNumber

```csharp
public const int ItemAbilityIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAlert_ItemCooldownSecondsFieldNumber"></a> ItemCooldownSecondsFieldNumber

```csharp
public const int ItemCooldownSecondsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAlert_ShowBuybackFieldNumber"></a> ShowBuybackFieldNumber

```csharp
public const int ShowBuybackFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAlert_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAlert_GoldCost"></a> GoldCost

```csharp
public int GoldCost { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAlert_HasGoldCost"></a> HasGoldCost

```csharp
public bool HasGoldCost { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAlert_HasItemAbilityId"></a> HasItemAbilityId

```csharp
public bool HasItemAbilityId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAlert_HasItemCooldownSeconds"></a> HasItemCooldownSeconds

```csharp
public bool HasItemCooldownSeconds { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAlert_HasShowBuyback"></a> HasShowBuyback

```csharp
public bool HasShowBuyback { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAlert_ItemAbilityId"></a> ItemAbilityId

```csharp
public int ItemAbilityId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAlert_ItemCooldownSeconds"></a> ItemCooldownSeconds

```csharp
public int ItemCooldownSeconds { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAlert_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_QuickBuyAlert> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_QuickBuyAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_QuickBuyAlert.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAlert_ShowBuyback"></a> ShowBuyback

```csharp
public bool ShowBuyback { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAlert_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAlert_ClearGoldCost"></a> ClearGoldCost\(\)

```csharp
public void ClearGoldCost()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAlert_ClearItemAbilityId"></a> ClearItemAbilityId\(\)

```csharp
public void ClearItemAbilityId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAlert_ClearItemCooldownSeconds"></a> ClearItemCooldownSeconds\(\)

```csharp
public void ClearItemCooldownSeconds()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAlert_ClearShowBuyback"></a> ClearShowBuyback\(\)

```csharp
public void ClearShowBuyback()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAlert_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_QuickBuyAlert Clone()
```

#### Returns

 [CDOTAClientMsg\_QuickBuyAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_QuickBuyAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAlert_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAlert_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAlert_"></a> Equals\(CDOTAClientMsg\_QuickBuyAlert\)

```csharp
public bool Equals(CDOTAClientMsg_QuickBuyAlert other)
```

#### Parameters

`other` [CDOTAClientMsg\_QuickBuyAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_QuickBuyAlert.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAlert_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAlert_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAlert_"></a> MergeFrom\(CDOTAClientMsg\_QuickBuyAlert\)

```csharp
public void MergeFrom(CDOTAClientMsg_QuickBuyAlert other)
```

#### Parameters

`other` [CDOTAClientMsg\_QuickBuyAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_QuickBuyAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAlert_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAlert_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_QuickBuyAlert_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

