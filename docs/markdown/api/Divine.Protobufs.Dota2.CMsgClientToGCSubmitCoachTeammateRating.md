# <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitCoachTeammateRating"></a> Class CMsgClientToGCSubmitCoachTeammateRating

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCSubmitCoachTeammateRating : IMessage<CMsgClientToGCSubmitCoachTeammateRating>, IEquatable<CMsgClientToGCSubmitCoachTeammateRating>, IDeepCloneable<CMsgClientToGCSubmitCoachTeammateRating>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCSubmitCoachTeammateRating](Divine.Protobufs.Dota2.CMsgClientToGCSubmitCoachTeammateRating.md)

#### Implements

IMessage<CMsgClientToGCSubmitCoachTeammateRating\>, 
[IEquatable<CMsgClientToGCSubmitCoachTeammateRating\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCSubmitCoachTeammateRating\>, 
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
[EnumerableExtensions.In<CMsgClientToGCSubmitCoachTeammateRating\>\(CMsgClientToGCSubmitCoachTeammateRating, params CMsgClientToGCSubmitCoachTeammateRating\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitCoachTeammateRating__ctor"></a> CMsgClientToGCSubmitCoachTeammateRating\(\)

```csharp
public CMsgClientToGCSubmitCoachTeammateRating()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitCoachTeammateRating__ctor_Divine_Protobufs_Dota2_CMsgClientToGCSubmitCoachTeammateRating_"></a> CMsgClientToGCSubmitCoachTeammateRating\(CMsgClientToGCSubmitCoachTeammateRating\)

```csharp
public CMsgClientToGCSubmitCoachTeammateRating(CMsgClientToGCSubmitCoachTeammateRating other)
```

#### Parameters

`other` [CMsgClientToGCSubmitCoachTeammateRating](Divine.Protobufs.Dota2.CMsgClientToGCSubmitCoachTeammateRating.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitCoachTeammateRating_CoachAccountIdFieldNumber"></a> CoachAccountIdFieldNumber

```csharp
public const int CoachAccountIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitCoachTeammateRating_MatchIdFieldNumber"></a> MatchIdFieldNumber

```csharp
public const int MatchIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitCoachTeammateRating_RatingFieldNumber"></a> RatingFieldNumber

```csharp
public const int RatingFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitCoachTeammateRating_ReasonFieldNumber"></a> ReasonFieldNumber

```csharp
public const int ReasonFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitCoachTeammateRating_CoachAccountId"></a> CoachAccountId

```csharp
public uint CoachAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitCoachTeammateRating_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitCoachTeammateRating_HasCoachAccountId"></a> HasCoachAccountId

```csharp
public bool HasCoachAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitCoachTeammateRating_HasMatchId"></a> HasMatchId

```csharp
public bool HasMatchId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitCoachTeammateRating_HasRating"></a> HasRating

```csharp
public bool HasRating { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitCoachTeammateRating_HasReason"></a> HasReason

```csharp
public bool HasReason { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitCoachTeammateRating_MatchId"></a> MatchId

```csharp
public ulong MatchId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitCoachTeammateRating_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCSubmitCoachTeammateRating> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCSubmitCoachTeammateRating](Divine.Protobufs.Dota2.CMsgClientToGCSubmitCoachTeammateRating.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitCoachTeammateRating_Rating"></a> Rating

```csharp
public ECoachTeammateRating Rating { get; set; }
```

#### Property Value

 [ECoachTeammateRating](Divine.Protobufs.Dota2.ECoachTeammateRating.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitCoachTeammateRating_Reason"></a> Reason

```csharp
public string Reason { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitCoachTeammateRating_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitCoachTeammateRating_ClearCoachAccountId"></a> ClearCoachAccountId\(\)

```csharp
public void ClearCoachAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitCoachTeammateRating_ClearMatchId"></a> ClearMatchId\(\)

```csharp
public void ClearMatchId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitCoachTeammateRating_ClearRating"></a> ClearRating\(\)

```csharp
public void ClearRating()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitCoachTeammateRating_ClearReason"></a> ClearReason\(\)

```csharp
public void ClearReason()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitCoachTeammateRating_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCSubmitCoachTeammateRating Clone()
```

#### Returns

 [CMsgClientToGCSubmitCoachTeammateRating](Divine.Protobufs.Dota2.CMsgClientToGCSubmitCoachTeammateRating.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitCoachTeammateRating_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitCoachTeammateRating_Equals_Divine_Protobufs_Dota2_CMsgClientToGCSubmitCoachTeammateRating_"></a> Equals\(CMsgClientToGCSubmitCoachTeammateRating\)

```csharp
public bool Equals(CMsgClientToGCSubmitCoachTeammateRating other)
```

#### Parameters

`other` [CMsgClientToGCSubmitCoachTeammateRating](Divine.Protobufs.Dota2.CMsgClientToGCSubmitCoachTeammateRating.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitCoachTeammateRating_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitCoachTeammateRating_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCSubmitCoachTeammateRating_"></a> MergeFrom\(CMsgClientToGCSubmitCoachTeammateRating\)

```csharp
public void MergeFrom(CMsgClientToGCSubmitCoachTeammateRating other)
```

#### Parameters

`other` [CMsgClientToGCSubmitCoachTeammateRating](Divine.Protobufs.Dota2.CMsgClientToGCSubmitCoachTeammateRating.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitCoachTeammateRating_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitCoachTeammateRating_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitCoachTeammateRating_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

