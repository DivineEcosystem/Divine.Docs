# <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_DraftTriviaMatchInfo"></a> Class CMsgDraftTrivia.Types.DraftTriviaMatchInfo

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDraftTrivia.Types.DraftTriviaMatchInfo : IMessage<CMsgDraftTrivia.Types.DraftTriviaMatchInfo>, IEquatable<CMsgDraftTrivia.Types.DraftTriviaMatchInfo>, IDeepCloneable<CMsgDraftTrivia.Types.DraftTriviaMatchInfo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDraftTrivia.Types.DraftTriviaMatchInfo](Divine.Protobufs.Dota2.CMsgDraftTrivia.Types.DraftTriviaMatchInfo.md)

#### Implements

IMessage<CMsgDraftTrivia.Types.DraftTriviaMatchInfo\>, 
[IEquatable<CMsgDraftTrivia.Types.DraftTriviaMatchInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDraftTrivia.Types.DraftTriviaMatchInfo\>, 
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
[EnumerableExtensions.In<CMsgDraftTrivia.Types.DraftTriviaMatchInfo\>\(CMsgDraftTrivia.Types.DraftTriviaMatchInfo, params CMsgDraftTrivia.Types.DraftTriviaMatchInfo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_DraftTriviaMatchInfo__ctor"></a> DraftTriviaMatchInfo\(\)

```csharp
public DraftTriviaMatchInfo()
```

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_DraftTriviaMatchInfo__ctor_Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_DraftTriviaMatchInfo_"></a> DraftTriviaMatchInfo\(DraftTriviaMatchInfo\)

```csharp
public DraftTriviaMatchInfo(CMsgDraftTrivia.Types.DraftTriviaMatchInfo other)
```

#### Parameters

`other` [CMsgDraftTrivia](Divine.Protobufs.Dota2.CMsgDraftTrivia.md).[Types](Divine.Protobufs.Dota2.CMsgDraftTrivia.Types.md).[DraftTriviaMatchInfo](Divine.Protobufs.Dota2.CMsgDraftTrivia.Types.DraftTriviaMatchInfo.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_DraftTriviaMatchInfo_DireHeroesFieldNumber"></a> DireHeroesFieldNumber

```csharp
public const int DireHeroesFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_DraftTriviaMatchInfo_RadiantHeroesFieldNumber"></a> RadiantHeroesFieldNumber

```csharp
public const int RadiantHeroesFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_DraftTriviaMatchInfo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_DraftTriviaMatchInfo_DireHeroes"></a> DireHeroes

```csharp
public RepeatedField<CMsgDraftTrivia.Types.DraftTriviaHeroInfo> DireHeroes { get; }
```

#### Property Value

 RepeatedField<[CMsgDraftTrivia](Divine.Protobufs.Dota2.CMsgDraftTrivia.md).[Types](Divine.Protobufs.Dota2.CMsgDraftTrivia.Types.md).[DraftTriviaHeroInfo](Divine.Protobufs.Dota2.CMsgDraftTrivia.Types.DraftTriviaHeroInfo.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_DraftTriviaMatchInfo_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDraftTrivia.Types.DraftTriviaMatchInfo> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDraftTrivia](Divine.Protobufs.Dota2.CMsgDraftTrivia.md).[Types](Divine.Protobufs.Dota2.CMsgDraftTrivia.Types.md).[DraftTriviaMatchInfo](Divine.Protobufs.Dota2.CMsgDraftTrivia.Types.DraftTriviaMatchInfo.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_DraftTriviaMatchInfo_RadiantHeroes"></a> RadiantHeroes

```csharp
public RepeatedField<CMsgDraftTrivia.Types.DraftTriviaHeroInfo> RadiantHeroes { get; }
```

#### Property Value

 RepeatedField<[CMsgDraftTrivia](Divine.Protobufs.Dota2.CMsgDraftTrivia.md).[Types](Divine.Protobufs.Dota2.CMsgDraftTrivia.Types.md).[DraftTriviaHeroInfo](Divine.Protobufs.Dota2.CMsgDraftTrivia.Types.DraftTriviaHeroInfo.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_DraftTriviaMatchInfo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_DraftTriviaMatchInfo_Clone"></a> Clone\(\)

```csharp
public CMsgDraftTrivia.Types.DraftTriviaMatchInfo Clone()
```

#### Returns

 [CMsgDraftTrivia](Divine.Protobufs.Dota2.CMsgDraftTrivia.md).[Types](Divine.Protobufs.Dota2.CMsgDraftTrivia.Types.md).[DraftTriviaMatchInfo](Divine.Protobufs.Dota2.CMsgDraftTrivia.Types.DraftTriviaMatchInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_DraftTriviaMatchInfo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_DraftTriviaMatchInfo_Equals_Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_DraftTriviaMatchInfo_"></a> Equals\(DraftTriviaMatchInfo\)

```csharp
public bool Equals(CMsgDraftTrivia.Types.DraftTriviaMatchInfo other)
```

#### Parameters

`other` [CMsgDraftTrivia](Divine.Protobufs.Dota2.CMsgDraftTrivia.md).[Types](Divine.Protobufs.Dota2.CMsgDraftTrivia.Types.md).[DraftTriviaMatchInfo](Divine.Protobufs.Dota2.CMsgDraftTrivia.Types.DraftTriviaMatchInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_DraftTriviaMatchInfo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_DraftTriviaMatchInfo_MergeFrom_Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_DraftTriviaMatchInfo_"></a> MergeFrom\(DraftTriviaMatchInfo\)

```csharp
public void MergeFrom(CMsgDraftTrivia.Types.DraftTriviaMatchInfo other)
```

#### Parameters

`other` [CMsgDraftTrivia](Divine.Protobufs.Dota2.CMsgDraftTrivia.md).[Types](Divine.Protobufs.Dota2.CMsgDraftTrivia.Types.md).[DraftTriviaMatchInfo](Divine.Protobufs.Dota2.CMsgDraftTrivia.Types.DraftTriviaMatchInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_DraftTriviaMatchInfo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_DraftTriviaMatchInfo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_DraftTriviaMatchInfo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

