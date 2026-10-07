# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QuickBuyAlert"></a> Class CDOTAUserMsg\_QuickBuyAlert

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_QuickBuyAlert : IMessage<CDOTAUserMsg_QuickBuyAlert>, IEquatable<CDOTAUserMsg_QuickBuyAlert>, IDeepCloneable<CDOTAUserMsg_QuickBuyAlert>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_QuickBuyAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_QuickBuyAlert.md)

#### Implements

IMessage<CDOTAUserMsg\_QuickBuyAlert\>, 
[IEquatable<CDOTAUserMsg\_QuickBuyAlert\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_QuickBuyAlert\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_QuickBuyAlert\>\(CDOTAUserMsg\_QuickBuyAlert, params CDOTAUserMsg\_QuickBuyAlert\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QuickBuyAlert__ctor"></a> CDOTAUserMsg\_QuickBuyAlert\(\)

```csharp
public CDOTAUserMsg_QuickBuyAlert()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QuickBuyAlert__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_QuickBuyAlert_"></a> CDOTAUserMsg\_QuickBuyAlert\(CDOTAUserMsg\_QuickBuyAlert\)

```csharp
public CDOTAUserMsg_QuickBuyAlert(CDOTAUserMsg_QuickBuyAlert other)
```

#### Parameters

`other` [CDOTAUserMsg\_QuickBuyAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_QuickBuyAlert.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QuickBuyAlert_GoldCostFieldNumber"></a> GoldCostFieldNumber

```csharp
public const int GoldCostFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QuickBuyAlert_ItemAbilityIdFieldNumber"></a> ItemAbilityIdFieldNumber

```csharp
public const int ItemAbilityIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QuickBuyAlert_ItemCooldownSecondsFieldNumber"></a> ItemCooldownSecondsFieldNumber

```csharp
public const int ItemCooldownSecondsFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QuickBuyAlert_PlayerIdFieldNumber"></a> PlayerIdFieldNumber

```csharp
public const int PlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QuickBuyAlert_ShowBuybackFieldNumber"></a> ShowBuybackFieldNumber

```csharp
public const int ShowBuybackFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QuickBuyAlert_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QuickBuyAlert_GoldCost"></a> GoldCost

```csharp
public int GoldCost { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QuickBuyAlert_HasGoldCost"></a> HasGoldCost

```csharp
public bool HasGoldCost { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QuickBuyAlert_HasItemAbilityId"></a> HasItemAbilityId

```csharp
public bool HasItemAbilityId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QuickBuyAlert_HasItemCooldownSeconds"></a> HasItemCooldownSeconds

```csharp
public bool HasItemCooldownSeconds { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QuickBuyAlert_HasPlayerId"></a> HasPlayerId

```csharp
public bool HasPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QuickBuyAlert_HasShowBuyback"></a> HasShowBuyback

```csharp
public bool HasShowBuyback { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QuickBuyAlert_ItemAbilityId"></a> ItemAbilityId

```csharp
public int ItemAbilityId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QuickBuyAlert_ItemCooldownSeconds"></a> ItemCooldownSeconds

```csharp
public int ItemCooldownSeconds { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QuickBuyAlert_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_QuickBuyAlert> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_QuickBuyAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_QuickBuyAlert.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QuickBuyAlert_PlayerId"></a> PlayerId

```csharp
public int PlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QuickBuyAlert_ShowBuyback"></a> ShowBuyback

```csharp
public bool ShowBuyback { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QuickBuyAlert_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QuickBuyAlert_ClearGoldCost"></a> ClearGoldCost\(\)

```csharp
public void ClearGoldCost()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QuickBuyAlert_ClearItemAbilityId"></a> ClearItemAbilityId\(\)

```csharp
public void ClearItemAbilityId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QuickBuyAlert_ClearItemCooldownSeconds"></a> ClearItemCooldownSeconds\(\)

```csharp
public void ClearItemCooldownSeconds()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QuickBuyAlert_ClearPlayerId"></a> ClearPlayerId\(\)

```csharp
public void ClearPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QuickBuyAlert_ClearShowBuyback"></a> ClearShowBuyback\(\)

```csharp
public void ClearShowBuyback()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QuickBuyAlert_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_QuickBuyAlert Clone()
```

#### Returns

 [CDOTAUserMsg\_QuickBuyAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_QuickBuyAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QuickBuyAlert_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QuickBuyAlert_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_QuickBuyAlert_"></a> Equals\(CDOTAUserMsg\_QuickBuyAlert\)

```csharp
public bool Equals(CDOTAUserMsg_QuickBuyAlert other)
```

#### Parameters

`other` [CDOTAUserMsg\_QuickBuyAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_QuickBuyAlert.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QuickBuyAlert_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QuickBuyAlert_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_QuickBuyAlert_"></a> MergeFrom\(CDOTAUserMsg\_QuickBuyAlert\)

```csharp
public void MergeFrom(CDOTAUserMsg_QuickBuyAlert other)
```

#### Parameters

`other` [CDOTAUserMsg\_QuickBuyAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_QuickBuyAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QuickBuyAlert_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QuickBuyAlert_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_QuickBuyAlert_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

