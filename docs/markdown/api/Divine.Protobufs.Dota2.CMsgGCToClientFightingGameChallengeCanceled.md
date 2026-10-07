# <a id="Divine_Protobufs_Dota2_CMsgGCToClientFightingGameChallengeCanceled"></a> Class CMsgGCToClientFightingGameChallengeCanceled

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientFightingGameChallengeCanceled : IMessage<CMsgGCToClientFightingGameChallengeCanceled>, IEquatable<CMsgGCToClientFightingGameChallengeCanceled>, IDeepCloneable<CMsgGCToClientFightingGameChallengeCanceled>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientFightingGameChallengeCanceled](Divine.Protobufs.Dota2.CMsgGCToClientFightingGameChallengeCanceled.md)

#### Implements

IMessage<CMsgGCToClientFightingGameChallengeCanceled\>, 
[IEquatable<CMsgGCToClientFightingGameChallengeCanceled\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientFightingGameChallengeCanceled\>, 
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
[EnumerableExtensions.In<CMsgGCToClientFightingGameChallengeCanceled\>\(CMsgGCToClientFightingGameChallengeCanceled, params CMsgGCToClientFightingGameChallengeCanceled\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFightingGameChallengeCanceled__ctor"></a> CMsgGCToClientFightingGameChallengeCanceled\(\)

```csharp
public CMsgGCToClientFightingGameChallengeCanceled()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFightingGameChallengeCanceled__ctor_Divine_Protobufs_Dota2_CMsgGCToClientFightingGameChallengeCanceled_"></a> CMsgGCToClientFightingGameChallengeCanceled\(CMsgGCToClientFightingGameChallengeCanceled\)

```csharp
public CMsgGCToClientFightingGameChallengeCanceled(CMsgGCToClientFightingGameChallengeCanceled other)
```

#### Parameters

`other` [CMsgGCToClientFightingGameChallengeCanceled](Divine.Protobufs.Dota2.CMsgGCToClientFightingGameChallengeCanceled.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFightingGameChallengeCanceled_ChallengerAccountIdFieldNumber"></a> ChallengerAccountIdFieldNumber

```csharp
public const int ChallengerAccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFightingGameChallengeCanceled_ResponderAccountIdFieldNumber"></a> ResponderAccountIdFieldNumber

```csharp
public const int ResponderAccountIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFightingGameChallengeCanceled_ChallengerAccountId"></a> ChallengerAccountId

```csharp
public uint ChallengerAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFightingGameChallengeCanceled_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFightingGameChallengeCanceled_HasChallengerAccountId"></a> HasChallengerAccountId

```csharp
public bool HasChallengerAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFightingGameChallengeCanceled_HasResponderAccountId"></a> HasResponderAccountId

```csharp
public bool HasResponderAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFightingGameChallengeCanceled_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientFightingGameChallengeCanceled> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientFightingGameChallengeCanceled](Divine.Protobufs.Dota2.CMsgGCToClientFightingGameChallengeCanceled.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFightingGameChallengeCanceled_ResponderAccountId"></a> ResponderAccountId

```csharp
public uint ResponderAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFightingGameChallengeCanceled_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFightingGameChallengeCanceled_ClearChallengerAccountId"></a> ClearChallengerAccountId\(\)

```csharp
public void ClearChallengerAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFightingGameChallengeCanceled_ClearResponderAccountId"></a> ClearResponderAccountId\(\)

```csharp
public void ClearResponderAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFightingGameChallengeCanceled_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientFightingGameChallengeCanceled Clone()
```

#### Returns

 [CMsgGCToClientFightingGameChallengeCanceled](Divine.Protobufs.Dota2.CMsgGCToClientFightingGameChallengeCanceled.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFightingGameChallengeCanceled_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFightingGameChallengeCanceled_Equals_Divine_Protobufs_Dota2_CMsgGCToClientFightingGameChallengeCanceled_"></a> Equals\(CMsgGCToClientFightingGameChallengeCanceled\)

```csharp
public bool Equals(CMsgGCToClientFightingGameChallengeCanceled other)
```

#### Parameters

`other` [CMsgGCToClientFightingGameChallengeCanceled](Divine.Protobufs.Dota2.CMsgGCToClientFightingGameChallengeCanceled.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFightingGameChallengeCanceled_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFightingGameChallengeCanceled_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientFightingGameChallengeCanceled_"></a> MergeFrom\(CMsgGCToClientFightingGameChallengeCanceled\)

```csharp
public void MergeFrom(CMsgGCToClientFightingGameChallengeCanceled other)
```

#### Parameters

`other` [CMsgGCToClientFightingGameChallengeCanceled](Divine.Protobufs.Dota2.CMsgGCToClientFightingGameChallengeCanceled.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFightingGameChallengeCanceled_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFightingGameChallengeCanceled_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFightingGameChallengeCanceled_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

