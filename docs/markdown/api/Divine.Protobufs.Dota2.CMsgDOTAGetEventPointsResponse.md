# <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPointsResponse"></a> Class CMsgDOTAGetEventPointsResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAGetEventPointsResponse : IMessage<CMsgDOTAGetEventPointsResponse>, IEquatable<CMsgDOTAGetEventPointsResponse>, IDeepCloneable<CMsgDOTAGetEventPointsResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAGetEventPointsResponse](Divine.Protobufs.Dota2.CMsgDOTAGetEventPointsResponse.md)

#### Implements

IMessage<CMsgDOTAGetEventPointsResponse\>, 
[IEquatable<CMsgDOTAGetEventPointsResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAGetEventPointsResponse\>, 
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
[EnumerableExtensions.In<CMsgDOTAGetEventPointsResponse\>\(CMsgDOTAGetEventPointsResponse, params CMsgDOTAGetEventPointsResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPointsResponse__ctor"></a> CMsgDOTAGetEventPointsResponse\(\)

```csharp
public CMsgDOTAGetEventPointsResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPointsResponse__ctor_Divine_Protobufs_Dota2_CMsgDOTAGetEventPointsResponse_"></a> CMsgDOTAGetEventPointsResponse\(CMsgDOTAGetEventPointsResponse\)

```csharp
public CMsgDOTAGetEventPointsResponse(CMsgDOTAGetEventPointsResponse other)
```

#### Parameters

`other` [CMsgDOTAGetEventPointsResponse](Divine.Protobufs.Dota2.CMsgDOTAGetEventPointsResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPointsResponse_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPointsResponse_ActiveSeasonIdFieldNumber"></a> ActiveSeasonIdFieldNumber

```csharp
public const int ActiveSeasonIdFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPointsResponse_AuditActionFieldNumber"></a> AuditActionFieldNumber

```csharp
public const int AuditActionFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPointsResponse_CompletedActionsFieldNumber"></a> CompletedActionsFieldNumber

```csharp
public const int CompletedActionsFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPointsResponse_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPointsResponse_OwnedFieldNumber"></a> OwnedFieldNumber

```csharp
public const int OwnedFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPointsResponse_PointsFieldNumber"></a> PointsFieldNumber

```csharp
public const int PointsFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPointsResponse_PremiumPointsFieldNumber"></a> PremiumPointsFieldNumber

```csharp
public const int PremiumPointsFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPointsResponse_TotalPointsFieldNumber"></a> TotalPointsFieldNumber

```csharp
public const int TotalPointsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPointsResponse_TotalPremiumPointsFieldNumber"></a> TotalPremiumPointsFieldNumber

```csharp
public const int TotalPremiumPointsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPointsResponse_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPointsResponse_ActiveSeasonId"></a> ActiveSeasonId

```csharp
public uint ActiveSeasonId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPointsResponse_AuditAction"></a> AuditAction

```csharp
public uint AuditAction { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPointsResponse_CompletedActions"></a> CompletedActions

```csharp
public RepeatedField<CMsgDOTAGetEventPointsResponse.Types.Action> CompletedActions { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTAGetEventPointsResponse](Divine.Protobufs.Dota2.CMsgDOTAGetEventPointsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAGetEventPointsResponse.Types.md).[Action](Divine.Protobufs.Dota2.CMsgDOTAGetEventPointsResponse.Types.Action.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPointsResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPointsResponse_EventId"></a> EventId

```csharp
public uint EventId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPointsResponse_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPointsResponse_HasActiveSeasonId"></a> HasActiveSeasonId

```csharp
public bool HasActiveSeasonId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPointsResponse_HasAuditAction"></a> HasAuditAction

```csharp
public bool HasAuditAction { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPointsResponse_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPointsResponse_HasOwned"></a> HasOwned

```csharp
public bool HasOwned { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPointsResponse_HasPoints"></a> HasPoints

```csharp
public bool HasPoints { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPointsResponse_HasPremiumPoints"></a> HasPremiumPoints

```csharp
public bool HasPremiumPoints { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPointsResponse_HasTotalPoints"></a> HasTotalPoints

```csharp
public bool HasTotalPoints { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPointsResponse_HasTotalPremiumPoints"></a> HasTotalPremiumPoints

```csharp
public bool HasTotalPremiumPoints { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPointsResponse_Owned"></a> Owned

```csharp
public bool Owned { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPointsResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAGetEventPointsResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAGetEventPointsResponse](Divine.Protobufs.Dota2.CMsgDOTAGetEventPointsResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPointsResponse_Points"></a> Points

```csharp
public uint Points { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPointsResponse_PremiumPoints"></a> PremiumPoints

```csharp
public uint PremiumPoints { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPointsResponse_TotalPoints"></a> TotalPoints

```csharp
public uint TotalPoints { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPointsResponse_TotalPremiumPoints"></a> TotalPremiumPoints

```csharp
public uint TotalPremiumPoints { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPointsResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPointsResponse_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPointsResponse_ClearActiveSeasonId"></a> ClearActiveSeasonId\(\)

```csharp
public void ClearActiveSeasonId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPointsResponse_ClearAuditAction"></a> ClearAuditAction\(\)

```csharp
public void ClearAuditAction()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPointsResponse_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPointsResponse_ClearOwned"></a> ClearOwned\(\)

```csharp
public void ClearOwned()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPointsResponse_ClearPoints"></a> ClearPoints\(\)

```csharp
public void ClearPoints()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPointsResponse_ClearPremiumPoints"></a> ClearPremiumPoints\(\)

```csharp
public void ClearPremiumPoints()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPointsResponse_ClearTotalPoints"></a> ClearTotalPoints\(\)

```csharp
public void ClearTotalPoints()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPointsResponse_ClearTotalPremiumPoints"></a> ClearTotalPremiumPoints\(\)

```csharp
public void ClearTotalPremiumPoints()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPointsResponse_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAGetEventPointsResponse Clone()
```

#### Returns

 [CMsgDOTAGetEventPointsResponse](Divine.Protobufs.Dota2.CMsgDOTAGetEventPointsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPointsResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPointsResponse_Equals_Divine_Protobufs_Dota2_CMsgDOTAGetEventPointsResponse_"></a> Equals\(CMsgDOTAGetEventPointsResponse\)

```csharp
public bool Equals(CMsgDOTAGetEventPointsResponse other)
```

#### Parameters

`other` [CMsgDOTAGetEventPointsResponse](Divine.Protobufs.Dota2.CMsgDOTAGetEventPointsResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPointsResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPointsResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAGetEventPointsResponse_"></a> MergeFrom\(CMsgDOTAGetEventPointsResponse\)

```csharp
public void MergeFrom(CMsgDOTAGetEventPointsResponse other)
```

#### Parameters

`other` [CMsgDOTAGetEventPointsResponse](Divine.Protobufs.Dota2.CMsgDOTAGetEventPointsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPointsResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPointsResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetEventPointsResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

