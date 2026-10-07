# <a id="Divine_Protobufs_Dota2_CMsgClientToGCHasPlayerVotedForMVP"></a> Class CMsgClientToGCHasPlayerVotedForMVP

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCHasPlayerVotedForMVP : IMessage<CMsgClientToGCHasPlayerVotedForMVP>, IEquatable<CMsgClientToGCHasPlayerVotedForMVP>, IDeepCloneable<CMsgClientToGCHasPlayerVotedForMVP>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCHasPlayerVotedForMVP](Divine.Protobufs.Dota2.CMsgClientToGCHasPlayerVotedForMVP.md)

#### Implements

IMessage<CMsgClientToGCHasPlayerVotedForMVP\>, 
[IEquatable<CMsgClientToGCHasPlayerVotedForMVP\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCHasPlayerVotedForMVP\>, 
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
[EnumerableExtensions.In<CMsgClientToGCHasPlayerVotedForMVP\>\(CMsgClientToGCHasPlayerVotedForMVP, params CMsgClientToGCHasPlayerVotedForMVP\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCHasPlayerVotedForMVP__ctor"></a> CMsgClientToGCHasPlayerVotedForMVP\(\)

```csharp
public CMsgClientToGCHasPlayerVotedForMVP()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCHasPlayerVotedForMVP__ctor_Divine_Protobufs_Dota2_CMsgClientToGCHasPlayerVotedForMVP_"></a> CMsgClientToGCHasPlayerVotedForMVP\(CMsgClientToGCHasPlayerVotedForMVP\)

```csharp
public CMsgClientToGCHasPlayerVotedForMVP(CMsgClientToGCHasPlayerVotedForMVP other)
```

#### Parameters

`other` [CMsgClientToGCHasPlayerVotedForMVP](Divine.Protobufs.Dota2.CMsgClientToGCHasPlayerVotedForMVP.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCHasPlayerVotedForMVP_MatchIdFieldNumber"></a> MatchIdFieldNumber

```csharp
public const int MatchIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCHasPlayerVotedForMVP_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCHasPlayerVotedForMVP_HasMatchId"></a> HasMatchId

```csharp
public bool HasMatchId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCHasPlayerVotedForMVP_MatchId"></a> MatchId

```csharp
public ulong MatchId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCHasPlayerVotedForMVP_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCHasPlayerVotedForMVP> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCHasPlayerVotedForMVP](Divine.Protobufs.Dota2.CMsgClientToGCHasPlayerVotedForMVP.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCHasPlayerVotedForMVP_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCHasPlayerVotedForMVP_ClearMatchId"></a> ClearMatchId\(\)

```csharp
public void ClearMatchId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCHasPlayerVotedForMVP_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCHasPlayerVotedForMVP Clone()
```

#### Returns

 [CMsgClientToGCHasPlayerVotedForMVP](Divine.Protobufs.Dota2.CMsgClientToGCHasPlayerVotedForMVP.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCHasPlayerVotedForMVP_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCHasPlayerVotedForMVP_Equals_Divine_Protobufs_Dota2_CMsgClientToGCHasPlayerVotedForMVP_"></a> Equals\(CMsgClientToGCHasPlayerVotedForMVP\)

```csharp
public bool Equals(CMsgClientToGCHasPlayerVotedForMVP other)
```

#### Parameters

`other` [CMsgClientToGCHasPlayerVotedForMVP](Divine.Protobufs.Dota2.CMsgClientToGCHasPlayerVotedForMVP.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCHasPlayerVotedForMVP_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCHasPlayerVotedForMVP_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCHasPlayerVotedForMVP_"></a> MergeFrom\(CMsgClientToGCHasPlayerVotedForMVP\)

```csharp
public void MergeFrom(CMsgClientToGCHasPlayerVotedForMVP other)
```

#### Parameters

`other` [CMsgClientToGCHasPlayerVotedForMVP](Divine.Protobufs.Dota2.CMsgClientToGCHasPlayerVotedForMVP.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCHasPlayerVotedForMVP_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCHasPlayerVotedForMVP_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCHasPlayerVotedForMVP_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

