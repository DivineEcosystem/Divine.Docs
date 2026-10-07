# <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimLeaderboardRewardsResponse"></a> Class CMsgClientToGCClaimLeaderboardRewardsResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCClaimLeaderboardRewardsResponse : IMessage<CMsgClientToGCClaimLeaderboardRewardsResponse>, IEquatable<CMsgClientToGCClaimLeaderboardRewardsResponse>, IDeepCloneable<CMsgClientToGCClaimLeaderboardRewardsResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCClaimLeaderboardRewardsResponse](Divine.Protobufs.Dota2.CMsgClientToGCClaimLeaderboardRewardsResponse.md)

#### Implements

IMessage<CMsgClientToGCClaimLeaderboardRewardsResponse\>, 
[IEquatable<CMsgClientToGCClaimLeaderboardRewardsResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCClaimLeaderboardRewardsResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCClaimLeaderboardRewardsResponse\>\(CMsgClientToGCClaimLeaderboardRewardsResponse, params CMsgClientToGCClaimLeaderboardRewardsResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimLeaderboardRewardsResponse__ctor"></a> CMsgClientToGCClaimLeaderboardRewardsResponse\(\)

```csharp
public CMsgClientToGCClaimLeaderboardRewardsResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimLeaderboardRewardsResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCClaimLeaderboardRewardsResponse_"></a> CMsgClientToGCClaimLeaderboardRewardsResponse\(CMsgClientToGCClaimLeaderboardRewardsResponse\)

```csharp
public CMsgClientToGCClaimLeaderboardRewardsResponse(CMsgClientToGCClaimLeaderboardRewardsResponse other)
```

#### Parameters

`other` [CMsgClientToGCClaimLeaderboardRewardsResponse](Divine.Protobufs.Dota2.CMsgClientToGCClaimLeaderboardRewardsResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimLeaderboardRewardsResponse_EventPointsFieldNumber"></a> EventPointsFieldNumber

```csharp
public const int EventPointsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimLeaderboardRewardsResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimLeaderboardRewardsResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimLeaderboardRewardsResponse_EventPoints"></a> EventPoints

```csharp
public uint EventPoints { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimLeaderboardRewardsResponse_HasEventPoints"></a> HasEventPoints

```csharp
public bool HasEventPoints { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimLeaderboardRewardsResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimLeaderboardRewardsResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCClaimLeaderboardRewardsResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCClaimLeaderboardRewardsResponse](Divine.Protobufs.Dota2.CMsgClientToGCClaimLeaderboardRewardsResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimLeaderboardRewardsResponse_Result"></a> Result

```csharp
public CMsgClientToGCClaimLeaderboardRewardsResponse.Types.EResponse Result { get; set; }
```

#### Property Value

 [CMsgClientToGCClaimLeaderboardRewardsResponse](Divine.Protobufs.Dota2.CMsgClientToGCClaimLeaderboardRewardsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCClaimLeaderboardRewardsResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCClaimLeaderboardRewardsResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimLeaderboardRewardsResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimLeaderboardRewardsResponse_ClearEventPoints"></a> ClearEventPoints\(\)

```csharp
public void ClearEventPoints()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimLeaderboardRewardsResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimLeaderboardRewardsResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCClaimLeaderboardRewardsResponse Clone()
```

#### Returns

 [CMsgClientToGCClaimLeaderboardRewardsResponse](Divine.Protobufs.Dota2.CMsgClientToGCClaimLeaderboardRewardsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimLeaderboardRewardsResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimLeaderboardRewardsResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCClaimLeaderboardRewardsResponse_"></a> Equals\(CMsgClientToGCClaimLeaderboardRewardsResponse\)

```csharp
public bool Equals(CMsgClientToGCClaimLeaderboardRewardsResponse other)
```

#### Parameters

`other` [CMsgClientToGCClaimLeaderboardRewardsResponse](Divine.Protobufs.Dota2.CMsgClientToGCClaimLeaderboardRewardsResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimLeaderboardRewardsResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimLeaderboardRewardsResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCClaimLeaderboardRewardsResponse_"></a> MergeFrom\(CMsgClientToGCClaimLeaderboardRewardsResponse\)

```csharp
public void MergeFrom(CMsgClientToGCClaimLeaderboardRewardsResponse other)
```

#### Parameters

`other` [CMsgClientToGCClaimLeaderboardRewardsResponse](Divine.Protobufs.Dota2.CMsgClientToGCClaimLeaderboardRewardsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimLeaderboardRewardsResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimLeaderboardRewardsResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimLeaderboardRewardsResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

