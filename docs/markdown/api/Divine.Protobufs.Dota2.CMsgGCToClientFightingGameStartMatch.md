# <a id="Divine_Protobufs_Dota2_CMsgGCToClientFightingGameStartMatch"></a> Class CMsgGCToClientFightingGameStartMatch

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientFightingGameStartMatch : IMessage<CMsgGCToClientFightingGameStartMatch>, IEquatable<CMsgGCToClientFightingGameStartMatch>, IDeepCloneable<CMsgGCToClientFightingGameStartMatch>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientFightingGameStartMatch](Divine.Protobufs.Dota2.CMsgGCToClientFightingGameStartMatch.md)

#### Implements

IMessage<CMsgGCToClientFightingGameStartMatch\>, 
[IEquatable<CMsgGCToClientFightingGameStartMatch\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientFightingGameStartMatch\>, 
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
[EnumerableExtensions.In<CMsgGCToClientFightingGameStartMatch\>\(CMsgGCToClientFightingGameStartMatch, params CMsgGCToClientFightingGameStartMatch\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFightingGameStartMatch__ctor"></a> CMsgGCToClientFightingGameStartMatch\(\)

```csharp
public CMsgGCToClientFightingGameStartMatch()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFightingGameStartMatch__ctor_Divine_Protobufs_Dota2_CMsgGCToClientFightingGameStartMatch_"></a> CMsgGCToClientFightingGameStartMatch\(CMsgGCToClientFightingGameStartMatch\)

```csharp
public CMsgGCToClientFightingGameStartMatch(CMsgGCToClientFightingGameStartMatch other)
```

#### Parameters

`other` [CMsgGCToClientFightingGameStartMatch](Divine.Protobufs.Dota2.CMsgGCToClientFightingGameStartMatch.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFightingGameStartMatch_ChallengerAccountIdFieldNumber"></a> ChallengerAccountIdFieldNumber

```csharp
public const int ChallengerAccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFightingGameStartMatch_ResponderAccountIdFieldNumber"></a> ResponderAccountIdFieldNumber

```csharp
public const int ResponderAccountIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFightingGameStartMatch_ChallengerAccountId"></a> ChallengerAccountId

```csharp
public uint ChallengerAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFightingGameStartMatch_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFightingGameStartMatch_HasChallengerAccountId"></a> HasChallengerAccountId

```csharp
public bool HasChallengerAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFightingGameStartMatch_HasResponderAccountId"></a> HasResponderAccountId

```csharp
public bool HasResponderAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFightingGameStartMatch_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientFightingGameStartMatch> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientFightingGameStartMatch](Divine.Protobufs.Dota2.CMsgGCToClientFightingGameStartMatch.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFightingGameStartMatch_ResponderAccountId"></a> ResponderAccountId

```csharp
public uint ResponderAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFightingGameStartMatch_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFightingGameStartMatch_ClearChallengerAccountId"></a> ClearChallengerAccountId\(\)

```csharp
public void ClearChallengerAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFightingGameStartMatch_ClearResponderAccountId"></a> ClearResponderAccountId\(\)

```csharp
public void ClearResponderAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFightingGameStartMatch_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientFightingGameStartMatch Clone()
```

#### Returns

 [CMsgGCToClientFightingGameStartMatch](Divine.Protobufs.Dota2.CMsgGCToClientFightingGameStartMatch.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFightingGameStartMatch_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFightingGameStartMatch_Equals_Divine_Protobufs_Dota2_CMsgGCToClientFightingGameStartMatch_"></a> Equals\(CMsgGCToClientFightingGameStartMatch\)

```csharp
public bool Equals(CMsgGCToClientFightingGameStartMatch other)
```

#### Parameters

`other` [CMsgGCToClientFightingGameStartMatch](Divine.Protobufs.Dota2.CMsgGCToClientFightingGameStartMatch.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFightingGameStartMatch_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFightingGameStartMatch_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientFightingGameStartMatch_"></a> MergeFrom\(CMsgGCToClientFightingGameStartMatch\)

```csharp
public void MergeFrom(CMsgGCToClientFightingGameStartMatch other)
```

#### Parameters

`other` [CMsgGCToClientFightingGameStartMatch](Divine.Protobufs.Dota2.CMsgGCToClientFightingGameStartMatch.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFightingGameStartMatch_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFightingGameStartMatch_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFightingGameStartMatch_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

