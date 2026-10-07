# <a id="Divine_Protobufs_Dota2_CMsgDOTATeamRoster"></a> Class CMsgDOTATeamRoster

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTATeamRoster : IMessage<CMsgDOTATeamRoster>, IEquatable<CMsgDOTATeamRoster>, IDeepCloneable<CMsgDOTATeamRoster>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTATeamRoster](Divine.Protobufs.Dota2.CMsgDOTATeamRoster.md)

#### Implements

IMessage<CMsgDOTATeamRoster\>, 
[IEquatable<CMsgDOTATeamRoster\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTATeamRoster\>, 
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
[EnumerableExtensions.In<CMsgDOTATeamRoster\>\(CMsgDOTATeamRoster, params CMsgDOTATeamRoster\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamRoster__ctor"></a> CMsgDOTATeamRoster\(\)

```csharp
public CMsgDOTATeamRoster()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamRoster__ctor_Divine_Protobufs_Dota2_CMsgDOTATeamRoster_"></a> CMsgDOTATeamRoster\(CMsgDOTATeamRoster\)

```csharp
public CMsgDOTATeamRoster(CMsgDOTATeamRoster other)
```

#### Parameters

`other` [CMsgDOTATeamRoster](Divine.Protobufs.Dota2.CMsgDOTATeamRoster.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamRoster_CoachAccountIdFieldNumber"></a> CoachAccountIdFieldNumber

```csharp
public const int CoachAccountIdFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamRoster_MemberAccountIdsFieldNumber"></a> MemberAccountIdsFieldNumber

```csharp
public const int MemberAccountIdsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamRoster_TeamIdFieldNumber"></a> TeamIdFieldNumber

```csharp
public const int TeamIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamRoster_TimestampFieldNumber"></a> TimestampFieldNumber

```csharp
public const int TimestampFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamRoster_CoachAccountId"></a> CoachAccountId

```csharp
public uint CoachAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamRoster_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamRoster_HasCoachAccountId"></a> HasCoachAccountId

```csharp
public bool HasCoachAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamRoster_HasTeamId"></a> HasTeamId

```csharp
public bool HasTeamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamRoster_HasTimestamp"></a> HasTimestamp

```csharp
public bool HasTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamRoster_MemberAccountIds"></a> MemberAccountIds

```csharp
public RepeatedField<uint> MemberAccountIds { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamRoster_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTATeamRoster> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTATeamRoster](Divine.Protobufs.Dota2.CMsgDOTATeamRoster.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamRoster_TeamId"></a> TeamId

```csharp
public uint TeamId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamRoster_Timestamp"></a> Timestamp

```csharp
public uint Timestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamRoster_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamRoster_ClearCoachAccountId"></a> ClearCoachAccountId\(\)

```csharp
public void ClearCoachAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamRoster_ClearTeamId"></a> ClearTeamId\(\)

```csharp
public void ClearTeamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamRoster_ClearTimestamp"></a> ClearTimestamp\(\)

```csharp
public void ClearTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamRoster_Clone"></a> Clone\(\)

```csharp
public CMsgDOTATeamRoster Clone()
```

#### Returns

 [CMsgDOTATeamRoster](Divine.Protobufs.Dota2.CMsgDOTATeamRoster.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamRoster_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamRoster_Equals_Divine_Protobufs_Dota2_CMsgDOTATeamRoster_"></a> Equals\(CMsgDOTATeamRoster\)

```csharp
public bool Equals(CMsgDOTATeamRoster other)
```

#### Parameters

`other` [CMsgDOTATeamRoster](Divine.Protobufs.Dota2.CMsgDOTATeamRoster.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamRoster_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamRoster_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTATeamRoster_"></a> MergeFrom\(CMsgDOTATeamRoster\)

```csharp
public void MergeFrom(CMsgDOTATeamRoster other)
```

#### Parameters

`other` [CMsgDOTATeamRoster](Divine.Protobufs.Dota2.CMsgDOTATeamRoster.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamRoster_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamRoster_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamRoster_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

