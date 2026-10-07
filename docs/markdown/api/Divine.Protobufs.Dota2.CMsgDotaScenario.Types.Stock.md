# <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Stock"></a> Class CMsgDotaScenario.Types.Stock

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDotaScenario.Types.Stock : IMessage<CMsgDotaScenario.Types.Stock>, IEquatable<CMsgDotaScenario.Types.Stock>, IDeepCloneable<CMsgDotaScenario.Types.Stock>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDotaScenario.Types.Stock](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.Stock.md)

#### Implements

IMessage<CMsgDotaScenario.Types.Stock\>, 
[IEquatable<CMsgDotaScenario.Types.Stock\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDotaScenario.Types.Stock\>, 
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
[EnumerableExtensions.In<CMsgDotaScenario.Types.Stock\>\(CMsgDotaScenario.Types.Stock, params CMsgDotaScenario.Types.Stock\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Stock__ctor"></a> Stock\(\)

```csharp
public Stock()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Stock__ctor_Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Stock_"></a> Stock\(Stock\)

```csharp
public Stock(CMsgDotaScenario.Types.Stock other)
```

#### Parameters

`other` [CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[Stock](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.Stock.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Stock_BonusStockFieldNumber"></a> BonusStockFieldNumber

```csharp
public const int BonusStockFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Stock_CooldownFieldNumber"></a> CooldownFieldNumber

```csharp
public const int CooldownFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Stock_CurrentStockFieldNumber"></a> CurrentStockFieldNumber

```csharp
public const int CurrentStockFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Stock_NameFieldNumber"></a> NameFieldNumber

```csharp
public const int NameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Stock_PlayerIdFieldNumber"></a> PlayerIdFieldNumber

```csharp
public const int PlayerIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Stock_TeamNumberFieldNumber"></a> TeamNumberFieldNumber

```csharp
public const int TeamNumberFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Stock_BonusStock"></a> BonusStock

```csharp
public int BonusStock { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Stock_Cooldown"></a> Cooldown

```csharp
public float Cooldown { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Stock_CurrentStock"></a> CurrentStock

```csharp
public int CurrentStock { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Stock_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Stock_HasBonusStock"></a> HasBonusStock

```csharp
public bool HasBonusStock { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Stock_HasCooldown"></a> HasCooldown

```csharp
public bool HasCooldown { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Stock_HasCurrentStock"></a> HasCurrentStock

```csharp
public bool HasCurrentStock { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Stock_HasName"></a> HasName

```csharp
public bool HasName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Stock_HasPlayerId"></a> HasPlayerId

```csharp
public bool HasPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Stock_HasTeamNumber"></a> HasTeamNumber

```csharp
public bool HasTeamNumber { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Stock_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Stock_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDotaScenario.Types.Stock> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[Stock](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.Stock.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Stock_PlayerId"></a> PlayerId

```csharp
public int PlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Stock_TeamNumber"></a> TeamNumber

```csharp
public int TeamNumber { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Stock_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Stock_ClearBonusStock"></a> ClearBonusStock\(\)

```csharp
public void ClearBonusStock()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Stock_ClearCooldown"></a> ClearCooldown\(\)

```csharp
public void ClearCooldown()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Stock_ClearCurrentStock"></a> ClearCurrentStock\(\)

```csharp
public void ClearCurrentStock()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Stock_ClearName"></a> ClearName\(\)

```csharp
public void ClearName()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Stock_ClearPlayerId"></a> ClearPlayerId\(\)

```csharp
public void ClearPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Stock_ClearTeamNumber"></a> ClearTeamNumber\(\)

```csharp
public void ClearTeamNumber()
```

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Stock_Clone"></a> Clone\(\)

```csharp
public CMsgDotaScenario.Types.Stock Clone()
```

#### Returns

 [CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[Stock](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.Stock.md)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Stock_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Stock_Equals_Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Stock_"></a> Equals\(Stock\)

```csharp
public bool Equals(CMsgDotaScenario.Types.Stock other)
```

#### Parameters

`other` [CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[Stock](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.Stock.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Stock_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Stock_MergeFrom_Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Stock_"></a> MergeFrom\(Stock\)

```csharp
public void MergeFrom(CMsgDotaScenario.Types.Stock other)
```

#### Parameters

`other` [CMsgDotaScenario](Divine.Protobufs.Dota2.CMsgDotaScenario.md).[Types](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.md).[Stock](Divine.Protobufs.Dota2.CMsgDotaScenario.Types.Stock.md)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Stock_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Stock_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDotaScenario_Types_Stock_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

