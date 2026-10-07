# <a id="Divine_Protobufs_Dota2_CMsgDOTAAwardEventPoints_Types_AwardPoints"></a> Class CMsgDOTAAwardEventPoints.Types.AwardPoints

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAAwardEventPoints.Types.AwardPoints : IMessage<CMsgDOTAAwardEventPoints.Types.AwardPoints>, IEquatable<CMsgDOTAAwardEventPoints.Types.AwardPoints>, IDeepCloneable<CMsgDOTAAwardEventPoints.Types.AwardPoints>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAAwardEventPoints.Types.AwardPoints](Divine.Protobufs.Dota2.CMsgDOTAAwardEventPoints.Types.AwardPoints.md)

#### Implements

IMessage<CMsgDOTAAwardEventPoints.Types.AwardPoints\>, 
[IEquatable<CMsgDOTAAwardEventPoints.Types.AwardPoints\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAAwardEventPoints.Types.AwardPoints\>, 
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
[EnumerableExtensions.In<CMsgDOTAAwardEventPoints.Types.AwardPoints\>\(CMsgDOTAAwardEventPoints.Types.AwardPoints, params CMsgDOTAAwardEventPoints.Types.AwardPoints\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAAwardEventPoints_Types_AwardPoints__ctor"></a> AwardPoints\(\)

```csharp
public AwardPoints()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAAwardEventPoints_Types_AwardPoints__ctor_Divine_Protobufs_Dota2_CMsgDOTAAwardEventPoints_Types_AwardPoints_"></a> AwardPoints\(AwardPoints\)

```csharp
public AwardPoints(CMsgDOTAAwardEventPoints.Types.AwardPoints other)
```

#### Parameters

`other` [CMsgDOTAAwardEventPoints](Divine.Protobufs.Dota2.CMsgDOTAAwardEventPoints.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAAwardEventPoints.Types.md).[AwardPoints](Divine.Protobufs.Dota2.CMsgDOTAAwardEventPoints.Types.AwardPoints.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAAwardEventPoints_Types_AwardPoints_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAAwardEventPoints_Types_AwardPoints_EligibleForPeriodicAdjustmentFieldNumber"></a> EligibleForPeriodicAdjustmentFieldNumber

```csharp
public const int EligibleForPeriodicAdjustmentFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAAwardEventPoints_Types_AwardPoints_PointCapPeriodicResourceIdFieldNumber"></a> PointCapPeriodicResourceIdFieldNumber

```csharp
public const int PointCapPeriodicResourceIdFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAAwardEventPoints_Types_AwardPoints_PointsFieldNumber"></a> PointsFieldNumber

```csharp
public const int PointsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAAwardEventPoints_Types_AwardPoints_PremiumPointsFieldNumber"></a> PremiumPointsFieldNumber

```csharp
public const int PremiumPointsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAAwardEventPoints_Types_AwardPoints_TradeBanTimeFieldNumber"></a> TradeBanTimeFieldNumber

```csharp
public const int TradeBanTimeFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAAwardEventPoints_Types_AwardPoints_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAAwardEventPoints_Types_AwardPoints_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAAwardEventPoints_Types_AwardPoints_EligibleForPeriodicAdjustment"></a> EligibleForPeriodicAdjustment

```csharp
public bool EligibleForPeriodicAdjustment { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAAwardEventPoints_Types_AwardPoints_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAAwardEventPoints_Types_AwardPoints_HasEligibleForPeriodicAdjustment"></a> HasEligibleForPeriodicAdjustment

```csharp
public bool HasEligibleForPeriodicAdjustment { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAAwardEventPoints_Types_AwardPoints_HasPointCapPeriodicResourceId"></a> HasPointCapPeriodicResourceId

```csharp
public bool HasPointCapPeriodicResourceId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAAwardEventPoints_Types_AwardPoints_HasPoints"></a> HasPoints

```csharp
public bool HasPoints { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAAwardEventPoints_Types_AwardPoints_HasPremiumPoints"></a> HasPremiumPoints

```csharp
public bool HasPremiumPoints { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAAwardEventPoints_Types_AwardPoints_HasTradeBanTime"></a> HasTradeBanTime

```csharp
public bool HasTradeBanTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAAwardEventPoints_Types_AwardPoints_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAAwardEventPoints.Types.AwardPoints> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAAwardEventPoints](Divine.Protobufs.Dota2.CMsgDOTAAwardEventPoints.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAAwardEventPoints.Types.md).[AwardPoints](Divine.Protobufs.Dota2.CMsgDOTAAwardEventPoints.Types.AwardPoints.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAAwardEventPoints_Types_AwardPoints_PointCapPeriodicResourceId"></a> PointCapPeriodicResourceId

```csharp
public uint PointCapPeriodicResourceId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAAwardEventPoints_Types_AwardPoints_Points"></a> Points

```csharp
public int Points { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAAwardEventPoints_Types_AwardPoints_PremiumPoints"></a> PremiumPoints

```csharp
public int PremiumPoints { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAAwardEventPoints_Types_AwardPoints_TradeBanTime"></a> TradeBanTime

```csharp
public uint TradeBanTime { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAAwardEventPoints_Types_AwardPoints_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAAwardEventPoints_Types_AwardPoints_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAAwardEventPoints_Types_AwardPoints_ClearEligibleForPeriodicAdjustment"></a> ClearEligibleForPeriodicAdjustment\(\)

```csharp
public void ClearEligibleForPeriodicAdjustment()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAAwardEventPoints_Types_AwardPoints_ClearPointCapPeriodicResourceId"></a> ClearPointCapPeriodicResourceId\(\)

```csharp
public void ClearPointCapPeriodicResourceId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAAwardEventPoints_Types_AwardPoints_ClearPoints"></a> ClearPoints\(\)

```csharp
public void ClearPoints()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAAwardEventPoints_Types_AwardPoints_ClearPremiumPoints"></a> ClearPremiumPoints\(\)

```csharp
public void ClearPremiumPoints()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAAwardEventPoints_Types_AwardPoints_ClearTradeBanTime"></a> ClearTradeBanTime\(\)

```csharp
public void ClearTradeBanTime()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAAwardEventPoints_Types_AwardPoints_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAAwardEventPoints.Types.AwardPoints Clone()
```

#### Returns

 [CMsgDOTAAwardEventPoints](Divine.Protobufs.Dota2.CMsgDOTAAwardEventPoints.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAAwardEventPoints.Types.md).[AwardPoints](Divine.Protobufs.Dota2.CMsgDOTAAwardEventPoints.Types.AwardPoints.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAAwardEventPoints_Types_AwardPoints_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAAwardEventPoints_Types_AwardPoints_Equals_Divine_Protobufs_Dota2_CMsgDOTAAwardEventPoints_Types_AwardPoints_"></a> Equals\(AwardPoints\)

```csharp
public bool Equals(CMsgDOTAAwardEventPoints.Types.AwardPoints other)
```

#### Parameters

`other` [CMsgDOTAAwardEventPoints](Divine.Protobufs.Dota2.CMsgDOTAAwardEventPoints.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAAwardEventPoints.Types.md).[AwardPoints](Divine.Protobufs.Dota2.CMsgDOTAAwardEventPoints.Types.AwardPoints.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAAwardEventPoints_Types_AwardPoints_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAAwardEventPoints_Types_AwardPoints_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAAwardEventPoints_Types_AwardPoints_"></a> MergeFrom\(AwardPoints\)

```csharp
public void MergeFrom(CMsgDOTAAwardEventPoints.Types.AwardPoints other)
```

#### Parameters

`other` [CMsgDOTAAwardEventPoints](Divine.Protobufs.Dota2.CMsgDOTAAwardEventPoints.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAAwardEventPoints.Types.md).[AwardPoints](Divine.Protobufs.Dota2.CMsgDOTAAwardEventPoints.Types.AwardPoints.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAAwardEventPoints_Types_AwardPoints_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAAwardEventPoints_Types_AwardPoints_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAAwardEventPoints_Types_AwardPoints_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

