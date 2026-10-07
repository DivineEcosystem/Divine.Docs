# <a id="Divine_Protobufs_Dota2_CMsgUserEventPoints"></a> Class CMsgUserEventPoints

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgUserEventPoints : IMessage<CMsgUserEventPoints>, IEquatable<CMsgUserEventPoints>, IDeepCloneable<CMsgUserEventPoints>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgUserEventPoints](Divine.Protobufs.Dota2.CMsgUserEventPoints.md)

#### Implements

IMessage<CMsgUserEventPoints\>, 
[IEquatable<CMsgUserEventPoints\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgUserEventPoints\>, 
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
[EnumerableExtensions.In<CMsgUserEventPoints\>\(CMsgUserEventPoints, params CMsgUserEventPoints\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgUserEventPoints__ctor"></a> CMsgUserEventPoints\(\)

```csharp
public CMsgUserEventPoints()
```

### <a id="Divine_Protobufs_Dota2_CMsgUserEventPoints__ctor_Divine_Protobufs_Dota2_CMsgUserEventPoints_"></a> CMsgUserEventPoints\(CMsgUserEventPoints\)

```csharp
public CMsgUserEventPoints(CMsgUserEventPoints other)
```

#### Parameters

`other` [CMsgUserEventPoints](Divine.Protobufs.Dota2.CMsgUserEventPoints.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgUserEventPoints_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgUserEventPoints_ActiveSeasonIdFieldNumber"></a> ActiveSeasonIdFieldNumber

```csharp
public const int ActiveSeasonIdFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgUserEventPoints_CompletedActionsFieldNumber"></a> CompletedActionsFieldNumber

```csharp
public const int CompletedActionsFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgUserEventPoints_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgUserEventPoints_OwnedFieldNumber"></a> OwnedFieldNumber

```csharp
public const int OwnedFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgUserEventPoints_PointsFieldNumber"></a> PointsFieldNumber

```csharp
public const int PointsFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgUserEventPoints_PremiumPointsFieldNumber"></a> PremiumPointsFieldNumber

```csharp
public const int PremiumPointsFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgUserEventPoints_TotalPointsFieldNumber"></a> TotalPointsFieldNumber

```csharp
public const int TotalPointsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgUserEventPoints_TotalPremiumPointsFieldNumber"></a> TotalPremiumPointsFieldNumber

```csharp
public const int TotalPremiumPointsFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgUserEventPoints_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgUserEventPoints_ActiveSeasonId"></a> ActiveSeasonId

```csharp
public uint ActiveSeasonId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgUserEventPoints_CompletedActions"></a> CompletedActions

```csharp
public RepeatedField<CMsgEventAction> CompletedActions { get; }
```

#### Property Value

 RepeatedField<[CMsgEventAction](Divine.Protobufs.Dota2.CMsgEventAction.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgUserEventPoints_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgUserEventPoints_EventId"></a> EventId

```csharp
public uint EventId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgUserEventPoints_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgUserEventPoints_HasActiveSeasonId"></a> HasActiveSeasonId

```csharp
public bool HasActiveSeasonId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgUserEventPoints_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgUserEventPoints_HasOwned"></a> HasOwned

```csharp
public bool HasOwned { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgUserEventPoints_HasPoints"></a> HasPoints

```csharp
public bool HasPoints { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgUserEventPoints_HasPremiumPoints"></a> HasPremiumPoints

```csharp
public bool HasPremiumPoints { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgUserEventPoints_HasTotalPoints"></a> HasTotalPoints

```csharp
public bool HasTotalPoints { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgUserEventPoints_HasTotalPremiumPoints"></a> HasTotalPremiumPoints

```csharp
public bool HasTotalPremiumPoints { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgUserEventPoints_Owned"></a> Owned

```csharp
public bool Owned { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgUserEventPoints_Parser"></a> Parser

```csharp
public static MessageParser<CMsgUserEventPoints> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgUserEventPoints](Divine.Protobufs.Dota2.CMsgUserEventPoints.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgUserEventPoints_Points"></a> Points

```csharp
public uint Points { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgUserEventPoints_PremiumPoints"></a> PremiumPoints

```csharp
public uint PremiumPoints { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgUserEventPoints_TotalPoints"></a> TotalPoints

```csharp
public uint TotalPoints { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgUserEventPoints_TotalPremiumPoints"></a> TotalPremiumPoints

```csharp
public uint TotalPremiumPoints { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgUserEventPoints_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgUserEventPoints_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgUserEventPoints_ClearActiveSeasonId"></a> ClearActiveSeasonId\(\)

```csharp
public void ClearActiveSeasonId()
```

### <a id="Divine_Protobufs_Dota2_CMsgUserEventPoints_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgUserEventPoints_ClearOwned"></a> ClearOwned\(\)

```csharp
public void ClearOwned()
```

### <a id="Divine_Protobufs_Dota2_CMsgUserEventPoints_ClearPoints"></a> ClearPoints\(\)

```csharp
public void ClearPoints()
```

### <a id="Divine_Protobufs_Dota2_CMsgUserEventPoints_ClearPremiumPoints"></a> ClearPremiumPoints\(\)

```csharp
public void ClearPremiumPoints()
```

### <a id="Divine_Protobufs_Dota2_CMsgUserEventPoints_ClearTotalPoints"></a> ClearTotalPoints\(\)

```csharp
public void ClearTotalPoints()
```

### <a id="Divine_Protobufs_Dota2_CMsgUserEventPoints_ClearTotalPremiumPoints"></a> ClearTotalPremiumPoints\(\)

```csharp
public void ClearTotalPremiumPoints()
```

### <a id="Divine_Protobufs_Dota2_CMsgUserEventPoints_Clone"></a> Clone\(\)

```csharp
public CMsgUserEventPoints Clone()
```

#### Returns

 [CMsgUserEventPoints](Divine.Protobufs.Dota2.CMsgUserEventPoints.md)

### <a id="Divine_Protobufs_Dota2_CMsgUserEventPoints_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgUserEventPoints_Equals_Divine_Protobufs_Dota2_CMsgUserEventPoints_"></a> Equals\(CMsgUserEventPoints\)

```csharp
public bool Equals(CMsgUserEventPoints other)
```

#### Parameters

`other` [CMsgUserEventPoints](Divine.Protobufs.Dota2.CMsgUserEventPoints.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgUserEventPoints_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgUserEventPoints_MergeFrom_Divine_Protobufs_Dota2_CMsgUserEventPoints_"></a> MergeFrom\(CMsgUserEventPoints\)

```csharp
public void MergeFrom(CMsgUserEventPoints other)
```

#### Parameters

`other` [CMsgUserEventPoints](Divine.Protobufs.Dota2.CMsgUserEventPoints.md)

### <a id="Divine_Protobufs_Dota2_CMsgUserEventPoints_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgUserEventPoints_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgUserEventPoints_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

