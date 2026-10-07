# <a id="Divine_Protobufs_Dota2_CMsgClientToGCVoteForMVP"></a> Class CMsgClientToGCVoteForMVP

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCVoteForMVP : IMessage<CMsgClientToGCVoteForMVP>, IEquatable<CMsgClientToGCVoteForMVP>, IDeepCloneable<CMsgClientToGCVoteForMVP>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCVoteForMVP](Divine.Protobufs.Dota2.CMsgClientToGCVoteForMVP.md)

#### Implements

IMessage<CMsgClientToGCVoteForMVP\>, 
[IEquatable<CMsgClientToGCVoteForMVP\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCVoteForMVP\>, 
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
[EnumerableExtensions.In<CMsgClientToGCVoteForMVP\>\(CMsgClientToGCVoteForMVP, params CMsgClientToGCVoteForMVP\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCVoteForMVP__ctor"></a> CMsgClientToGCVoteForMVP\(\)

```csharp
public CMsgClientToGCVoteForMVP()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCVoteForMVP__ctor_Divine_Protobufs_Dota2_CMsgClientToGCVoteForMVP_"></a> CMsgClientToGCVoteForMVP\(CMsgClientToGCVoteForMVP\)

```csharp
public CMsgClientToGCVoteForMVP(CMsgClientToGCVoteForMVP other)
```

#### Parameters

`other` [CMsgClientToGCVoteForMVP](Divine.Protobufs.Dota2.CMsgClientToGCVoteForMVP.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCVoteForMVP_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCVoteForMVP_MatchIdFieldNumber"></a> MatchIdFieldNumber

```csharp
public const int MatchIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCVoteForMVP_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCVoteForMVP_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCVoteForMVP_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCVoteForMVP_HasMatchId"></a> HasMatchId

```csharp
public bool HasMatchId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCVoteForMVP_MatchId"></a> MatchId

```csharp
public ulong MatchId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCVoteForMVP_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCVoteForMVP> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCVoteForMVP](Divine.Protobufs.Dota2.CMsgClientToGCVoteForMVP.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCVoteForMVP_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCVoteForMVP_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCVoteForMVP_ClearMatchId"></a> ClearMatchId\(\)

```csharp
public void ClearMatchId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCVoteForMVP_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCVoteForMVP Clone()
```

#### Returns

 [CMsgClientToGCVoteForMVP](Divine.Protobufs.Dota2.CMsgClientToGCVoteForMVP.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCVoteForMVP_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCVoteForMVP_Equals_Divine_Protobufs_Dota2_CMsgClientToGCVoteForMVP_"></a> Equals\(CMsgClientToGCVoteForMVP\)

```csharp
public bool Equals(CMsgClientToGCVoteForMVP other)
```

#### Parameters

`other` [CMsgClientToGCVoteForMVP](Divine.Protobufs.Dota2.CMsgClientToGCVoteForMVP.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCVoteForMVP_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCVoteForMVP_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCVoteForMVP_"></a> MergeFrom\(CMsgClientToGCVoteForMVP\)

```csharp
public void MergeFrom(CMsgClientToGCVoteForMVP other)
```

#### Parameters

`other` [CMsgClientToGCVoteForMVP](Divine.Protobufs.Dota2.CMsgClientToGCVoteForMVP.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCVoteForMVP_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCVoteForMVP_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCVoteForMVP_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

