# <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_TeamNeutralItem"></a> Class CMsgDotaScenario.Types.TeamNeutralItem

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDotaScenario.Types.TeamNeutralItem : IMessage<CMsgDotaScenario.Types.TeamNeutralItem>, IEquatable<CMsgDotaScenario.Types.TeamNeutralItem>, IDeepCloneable<CMsgDotaScenario.Types.TeamNeutralItem>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDotaScenario.Types.TeamNeutralItem](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.TeamNeutralItem.md)

#### Implements

IMessage<CMsgDotaScenario.Types.TeamNeutralItem\>, 
[IEquatable<CMsgDotaScenario.Types.TeamNeutralItem\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDotaScenario.Types.TeamNeutralItem\>, 
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
[EnumerableExtensions.In<CMsgDotaScenario.Types.TeamNeutralItem\>\(CMsgDotaScenario.Types.TeamNeutralItem, params CMsgDotaScenario.Types.TeamNeutralItem\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_TeamNeutralItem__ctor"></a> TeamNeutralItem\(\)

```csharp
public TeamNeutralItem()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_TeamNeutralItem__ctor_Divine_Protobufs_Dota2_CMsgDotaScenario_Types_TeamNeutralItem_"></a> TeamNeutralItem\(TeamNeutralItem\)

```csharp
public TeamNeutralItem(CMsgDotaScenario.Types.TeamNeutralItem other)
```

#### Parameters

`other` [CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[TeamNeutralItem](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.TeamNeutralItem.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_TeamNeutralItem_ConsumedFieldNumber"></a> ConsumedFieldNumber

```csharp
public const int ConsumedFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_TeamNeutralItem_NameFieldNumber"></a> NameFieldNumber

```csharp
public const int NameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_TeamNeutralItem_TierFieldNumber"></a> TierFieldNumber

```csharp
public const int TierFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_TeamNeutralItem_Consumed"></a> Consumed

```csharp
public bool Consumed { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_TeamNeutralItem_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_TeamNeutralItem_HasConsumed"></a> HasConsumed

```csharp
public bool HasConsumed { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_TeamNeutralItem_HasName"></a> HasName

```csharp
public bool HasName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_TeamNeutralItem_HasTier"></a> HasTier

```csharp
public bool HasTier { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_TeamNeutralItem_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_TeamNeutralItem_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDotaScenario.Types.TeamNeutralItem> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[TeamNeutralItem](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.TeamNeutralItem.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_TeamNeutralItem_Tier"></a> Tier

```csharp
public int Tier { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_TeamNeutralItem_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_TeamNeutralItem_ClearConsumed"></a> ClearConsumed\(\)

```csharp
public void ClearConsumed()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_TeamNeutralItem_ClearName"></a> ClearName\(\)

```csharp
public void ClearName()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_TeamNeutralItem_ClearTier"></a> ClearTier\(\)

```csharp
public void ClearTier()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_TeamNeutralItem_Clone"></a> Clone\(\)

```csharp
public CMsgDotaScenario.Types.TeamNeutralItem Clone()
```

#### Returns

 [CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[TeamNeutralItem](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.TeamNeutralItem.md)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_TeamNeutralItem_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_TeamNeutralItem_Equals_Divine_Protobufs_Dota2_CMsgDotaScenario_Types_TeamNeutralItem_"></a> Equals\(TeamNeutralItem\)

```csharp
public bool Equals(CMsgDotaScenario.Types.TeamNeutralItem other)
```

#### Parameters

`other` [CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[TeamNeutralItem](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.TeamNeutralItem.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_TeamNeutralItem_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_TeamNeutralItem_MergeFrom_Divine_Protobufs_Dota2_CMsgDotaScenario_Types_TeamNeutralItem_"></a> MergeFrom\(TeamNeutralItem\)

```csharp
public void MergeFrom(CMsgDotaScenario.Types.TeamNeutralItem other)
```

#### Parameters

`other` [CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[TeamNeutralItem](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.TeamNeutralItem.md)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_TeamNeutralItem_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_TeamNeutralItem_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_TeamNeutralItem_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

