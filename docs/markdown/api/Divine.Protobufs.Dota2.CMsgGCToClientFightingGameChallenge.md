# <a id="Divine_Protobufs_Dota2_CMsgGCToClientFightingGameChallenge"></a> Class CMsgGCToClientFightingGameChallenge

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientFightingGameChallenge : IMessage<CMsgGCToClientFightingGameChallenge>, IEquatable<CMsgGCToClientFightingGameChallenge>, IDeepCloneable<CMsgGCToClientFightingGameChallenge>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientFightingGameChallenge](Divine.Protobufs.Dota2.CMsgGCToClientFightingGameChallenge.md)

#### Implements

IMessage<CMsgGCToClientFightingGameChallenge\>, 
[IEquatable<CMsgGCToClientFightingGameChallenge\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientFightingGameChallenge\>, 
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
[EnumerableExtensions.In<CMsgGCToClientFightingGameChallenge\>\(CMsgGCToClientFightingGameChallenge, params CMsgGCToClientFightingGameChallenge\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFightingGameChallenge__ctor"></a> CMsgGCToClientFightingGameChallenge\(\)

```csharp
public CMsgGCToClientFightingGameChallenge()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFightingGameChallenge__ctor_Divine_Protobufs_Dota2_CMsgGCToClientFightingGameChallenge_"></a> CMsgGCToClientFightingGameChallenge\(CMsgGCToClientFightingGameChallenge\)

```csharp
public CMsgGCToClientFightingGameChallenge(CMsgGCToClientFightingGameChallenge other)
```

#### Parameters

`other` [CMsgGCToClientFightingGameChallenge](Divine.Protobufs.Dota2.CMsgGCToClientFightingGameChallenge.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFightingGameChallenge_ChallengerAccountIdFieldNumber"></a> ChallengerAccountIdFieldNumber

```csharp
public const int ChallengerAccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFightingGameChallenge_ChallengerAccountId"></a> ChallengerAccountId

```csharp
public uint ChallengerAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFightingGameChallenge_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFightingGameChallenge_HasChallengerAccountId"></a> HasChallengerAccountId

```csharp
public bool HasChallengerAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFightingGameChallenge_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientFightingGameChallenge> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientFightingGameChallenge](Divine.Protobufs.Dota2.CMsgGCToClientFightingGameChallenge.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFightingGameChallenge_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFightingGameChallenge_ClearChallengerAccountId"></a> ClearChallengerAccountId\(\)

```csharp
public void ClearChallengerAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFightingGameChallenge_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientFightingGameChallenge Clone()
```

#### Returns

 [CMsgGCToClientFightingGameChallenge](Divine.Protobufs.Dota2.CMsgGCToClientFightingGameChallenge.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFightingGameChallenge_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFightingGameChallenge_Equals_Divine_Protobufs_Dota2_CMsgGCToClientFightingGameChallenge_"></a> Equals\(CMsgGCToClientFightingGameChallenge\)

```csharp
public bool Equals(CMsgGCToClientFightingGameChallenge other)
```

#### Parameters

`other` [CMsgGCToClientFightingGameChallenge](Divine.Protobufs.Dota2.CMsgGCToClientFightingGameChallenge.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFightingGameChallenge_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFightingGameChallenge_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientFightingGameChallenge_"></a> MergeFrom\(CMsgGCToClientFightingGameChallenge\)

```csharp
public void MergeFrom(CMsgGCToClientFightingGameChallenge other)
```

#### Parameters

`other` [CMsgGCToClientFightingGameChallenge](Divine.Protobufs.Dota2.CMsgGCToClientFightingGameChallenge.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFightingGameChallenge_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFightingGameChallenge_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFightingGameChallenge_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

