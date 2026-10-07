# <a id="Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge"></a> Class CMsgSignOutUpdatePlayerChallenge

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSignOutUpdatePlayerChallenge : IMessage<CMsgSignOutUpdatePlayerChallenge>, IEquatable<CMsgSignOutUpdatePlayerChallenge>, IDeepCloneable<CMsgSignOutUpdatePlayerChallenge>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSignOutUpdatePlayerChallenge](Divine.Protobufs.Dota2.CMsgSignOutUpdatePlayerChallenge.md)

#### Implements

IMessage<CMsgSignOutUpdatePlayerChallenge\>, 
[IEquatable<CMsgSignOutUpdatePlayerChallenge\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSignOutUpdatePlayerChallenge\>, 
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
[EnumerableExtensions.In<CMsgSignOutUpdatePlayerChallenge\>\(CMsgSignOutUpdatePlayerChallenge, params CMsgSignOutUpdatePlayerChallenge\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge__ctor"></a> CMsgSignOutUpdatePlayerChallenge\(\)

```csharp
public CMsgSignOutUpdatePlayerChallenge()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge__ctor_Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge_"></a> CMsgSignOutUpdatePlayerChallenge\(CMsgSignOutUpdatePlayerChallenge\)

```csharp
public CMsgSignOutUpdatePlayerChallenge(CMsgSignOutUpdatePlayerChallenge other)
```

#### Parameters

`other` [CMsgSignOutUpdatePlayerChallenge](Divine.Protobufs.Dota2.CMsgSignOutUpdatePlayerChallenge.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge_CompletedFieldNumber"></a> CompletedFieldNumber

```csharp
public const int CompletedFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge_HeroIdFieldNumber"></a> HeroIdFieldNumber

```csharp
public const int HeroIdFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge_MatchIdFieldNumber"></a> MatchIdFieldNumber

```csharp
public const int MatchIdFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge_RerolledFieldNumber"></a> RerolledFieldNumber

```csharp
public const int RerolledFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge_Completed"></a> Completed

```csharp
public RepeatedField<CMsgSignOutUpdatePlayerChallenge.Types.Challenge> Completed { get; }
```

#### Property Value

 RepeatedField<[CMsgSignOutUpdatePlayerChallenge](Divine.Protobufs.Dota2.CMsgSignOutUpdatePlayerChallenge.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutUpdatePlayerChallenge.Types.md).[Challenge](Divine.Protobufs.Dota2.CMsgSignOutUpdatePlayerChallenge.Types.Challenge.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge_HasHeroId"></a> HasHeroId

```csharp
public bool HasHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge_HasMatchId"></a> HasMatchId

```csharp
public bool HasMatchId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge_HeroId"></a> HeroId

```csharp
public int HeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge_MatchId"></a> MatchId

```csharp
public ulong MatchId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSignOutUpdatePlayerChallenge> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSignOutUpdatePlayerChallenge](Divine.Protobufs.Dota2.CMsgSignOutUpdatePlayerChallenge.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge_Rerolled"></a> Rerolled

```csharp
public RepeatedField<CMsgSignOutUpdatePlayerChallenge.Types.Challenge> Rerolled { get; }
```

#### Property Value

 RepeatedField<[CMsgSignOutUpdatePlayerChallenge](Divine.Protobufs.Dota2.CMsgSignOutUpdatePlayerChallenge.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutUpdatePlayerChallenge.Types.md).[Challenge](Divine.Protobufs.Dota2.CMsgSignOutUpdatePlayerChallenge.Types.Challenge.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge_ClearHeroId"></a> ClearHeroId\(\)

```csharp
public void ClearHeroId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge_ClearMatchId"></a> ClearMatchId\(\)

```csharp
public void ClearMatchId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge_Clone"></a> Clone\(\)

```csharp
public CMsgSignOutUpdatePlayerChallenge Clone()
```

#### Returns

 [CMsgSignOutUpdatePlayerChallenge](Divine.Protobufs.Dota2.CMsgSignOutUpdatePlayerChallenge.md)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge_Equals_Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge_"></a> Equals\(CMsgSignOutUpdatePlayerChallenge\)

```csharp
public bool Equals(CMsgSignOutUpdatePlayerChallenge other)
```

#### Parameters

`other` [CMsgSignOutUpdatePlayerChallenge](Divine.Protobufs.Dota2.CMsgSignOutUpdatePlayerChallenge.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge_MergeFrom_Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge_"></a> MergeFrom\(CMsgSignOutUpdatePlayerChallenge\)

```csharp
public void MergeFrom(CMsgSignOutUpdatePlayerChallenge other)
```

#### Parameters

`other` [CMsgSignOutUpdatePlayerChallenge](Divine.Protobufs.Dota2.CMsgSignOutUpdatePlayerChallenge.md)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutUpdatePlayerChallenge_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

