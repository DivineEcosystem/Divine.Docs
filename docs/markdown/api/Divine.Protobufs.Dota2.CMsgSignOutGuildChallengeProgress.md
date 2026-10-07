# <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildChallengeProgress"></a> Class CMsgSignOutGuildChallengeProgress

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSignOutGuildChallengeProgress : IMessage<CMsgSignOutGuildChallengeProgress>, IEquatable<CMsgSignOutGuildChallengeProgress>, IDeepCloneable<CMsgSignOutGuildChallengeProgress>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSignOutGuildChallengeProgress](Divine.Protobufs.Dota2.CMsgSignOutGuildChallengeProgress.md)

#### Implements

IMessage<CMsgSignOutGuildChallengeProgress\>, 
[IEquatable<CMsgSignOutGuildChallengeProgress\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSignOutGuildChallengeProgress\>, 
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
[EnumerableExtensions.In<CMsgSignOutGuildChallengeProgress\>\(CMsgSignOutGuildChallengeProgress, params CMsgSignOutGuildChallengeProgress\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildChallengeProgress__ctor"></a> CMsgSignOutGuildChallengeProgress\(\)

```csharp
public CMsgSignOutGuildChallengeProgress()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildChallengeProgress__ctor_Divine_Protobufs_Dota2_CMsgSignOutGuildChallengeProgress_"></a> CMsgSignOutGuildChallengeProgress\(CMsgSignOutGuildChallengeProgress\)

```csharp
public CMsgSignOutGuildChallengeProgress(CMsgSignOutGuildChallengeProgress other)
```

#### Parameters

`other` [CMsgSignOutGuildChallengeProgress](Divine.Protobufs.Dota2.CMsgSignOutGuildChallengeProgress.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildChallengeProgress_GuildChallengesProgressesFieldNumber"></a> GuildChallengesProgressesFieldNumber

```csharp
public const int GuildChallengesProgressesFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildChallengeProgress_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildChallengeProgress_GuildChallengesProgresses"></a> GuildChallengesProgresses

```csharp
public RepeatedField<CMsgSignOutGuildChallengeProgress.Types.ChallengeProgress> GuildChallengesProgresses { get; }
```

#### Property Value

 RepeatedField<[CMsgSignOutGuildChallengeProgress](Divine.Protobufs.Dota2.CMsgSignOutGuildChallengeProgress.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutGuildChallengeProgress.Types.md).[ChallengeProgress](Divine.Protobufs.Dota2.CMsgSignOutGuildChallengeProgress.Types.ChallengeProgress.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildChallengeProgress_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSignOutGuildChallengeProgress> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSignOutGuildChallengeProgress](Divine.Protobufs.Dota2.CMsgSignOutGuildChallengeProgress.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildChallengeProgress_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildChallengeProgress_Clone"></a> Clone\(\)

```csharp
public CMsgSignOutGuildChallengeProgress Clone()
```

#### Returns

 [CMsgSignOutGuildChallengeProgress](Divine.Protobufs.Dota2.CMsgSignOutGuildChallengeProgress.md)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildChallengeProgress_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildChallengeProgress_Equals_Divine_Protobufs_Dota2_CMsgSignOutGuildChallengeProgress_"></a> Equals\(CMsgSignOutGuildChallengeProgress\)

```csharp
public bool Equals(CMsgSignOutGuildChallengeProgress other)
```

#### Parameters

`other` [CMsgSignOutGuildChallengeProgress](Divine.Protobufs.Dota2.CMsgSignOutGuildChallengeProgress.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildChallengeProgress_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildChallengeProgress_MergeFrom_Divine_Protobufs_Dota2_CMsgSignOutGuildChallengeProgress_"></a> MergeFrom\(CMsgSignOutGuildChallengeProgress\)

```csharp
public void MergeFrom(CMsgSignOutGuildChallengeProgress other)
```

#### Parameters

`other` [CMsgSignOutGuildChallengeProgress](Divine.Protobufs.Dota2.CMsgSignOutGuildChallengeProgress.md)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildChallengeProgress_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildChallengeProgress_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildChallengeProgress_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

