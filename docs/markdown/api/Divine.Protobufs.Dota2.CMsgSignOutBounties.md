# <a id="Divine_Protobufs_Dota2_CMsgSignOutBounties"></a> Class CMsgSignOutBounties

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSignOutBounties : IMessage<CMsgSignOutBounties>, IEquatable<CMsgSignOutBounties>, IDeepCloneable<CMsgSignOutBounties>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSignOutBounties](Divine.Protobufs.Dota2.CMsgSignOutBounties.md)

#### Implements

IMessage<CMsgSignOutBounties\>, 
[IEquatable<CMsgSignOutBounties\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSignOutBounties\>, 
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
[EnumerableExtensions.In<CMsgSignOutBounties\>\(CMsgSignOutBounties, params CMsgSignOutBounties\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBounties__ctor"></a> CMsgSignOutBounties\(\)

```csharp
public CMsgSignOutBounties()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBounties__ctor_Divine_Protobufs_Dota2_CMsgSignOutBounties_"></a> CMsgSignOutBounties\(CMsgSignOutBounties\)

```csharp
public CMsgSignOutBounties(CMsgSignOutBounties other)
```

#### Parameters

`other` [CMsgSignOutBounties](Divine.Protobufs.Dota2.CMsgSignOutBounties.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBounties_BountiesFieldNumber"></a> BountiesFieldNumber

```csharp
public const int BountiesFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBounties_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBounties_MatchIdFieldNumber"></a> MatchIdFieldNumber

```csharp
public const int MatchIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBounties_TimestampFieldNumber"></a> TimestampFieldNumber

```csharp
public const int TimestampFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBounties_Bounties"></a> Bounties

```csharp
public RepeatedField<CMsgSignOutBounties.Types.Bounty> Bounties { get; }
```

#### Property Value

 RepeatedField<[CMsgSignOutBounties](Divine.Protobufs.Dota2.CMsgSignOutBounties.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutBounties.Types.md).[Bounty](Divine.Protobufs.Dota2.CMsgSignOutBounties.Types.Bounty.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBounties_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBounties_EventId"></a> EventId

```csharp
public EEvent EventId { get; set; }
```

#### Property Value

 [EEvent](Divine.Protobufs.Dota2.EEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBounties_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBounties_HasMatchId"></a> HasMatchId

```csharp
public bool HasMatchId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBounties_HasTimestamp"></a> HasTimestamp

```csharp
public bool HasTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBounties_MatchId"></a> MatchId

```csharp
public ulong MatchId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBounties_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSignOutBounties> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSignOutBounties](Divine.Protobufs.Dota2.CMsgSignOutBounties.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBounties_Timestamp"></a> Timestamp

```csharp
public uint Timestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBounties_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBounties_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBounties_ClearMatchId"></a> ClearMatchId\(\)

```csharp
public void ClearMatchId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBounties_ClearTimestamp"></a> ClearTimestamp\(\)

```csharp
public void ClearTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBounties_Clone"></a> Clone\(\)

```csharp
public CMsgSignOutBounties Clone()
```

#### Returns

 [CMsgSignOutBounties](Divine.Protobufs.Dota2.CMsgSignOutBounties.md)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBounties_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBounties_Equals_Divine_Protobufs_Dota2_CMsgSignOutBounties_"></a> Equals\(CMsgSignOutBounties\)

```csharp
public bool Equals(CMsgSignOutBounties other)
```

#### Parameters

`other` [CMsgSignOutBounties](Divine.Protobufs.Dota2.CMsgSignOutBounties.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBounties_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBounties_MergeFrom_Divine_Protobufs_Dota2_CMsgSignOutBounties_"></a> MergeFrom\(CMsgSignOutBounties\)

```csharp
public void MergeFrom(CMsgSignOutBounties other)
```

#### Parameters

`other` [CMsgSignOutBounties](Divine.Protobufs.Dota2.CMsgSignOutBounties.md)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBounties_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBounties_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBounties_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

