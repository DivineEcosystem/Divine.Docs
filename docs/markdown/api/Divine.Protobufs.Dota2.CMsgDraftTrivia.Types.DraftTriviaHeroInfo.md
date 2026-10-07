# <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_DraftTriviaHeroInfo"></a> Class CMsgDraftTrivia.Types.DraftTriviaHeroInfo

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDraftTrivia.Types.DraftTriviaHeroInfo : IMessage<CMsgDraftTrivia.Types.DraftTriviaHeroInfo>, IEquatable<CMsgDraftTrivia.Types.DraftTriviaHeroInfo>, IDeepCloneable<CMsgDraftTrivia.Types.DraftTriviaHeroInfo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDraftTrivia.Types.DraftTriviaHeroInfo](Divine.Protobufs.Dota2.CMsgDraftTrivia.Types.DraftTriviaHeroInfo.md)

#### Implements

IMessage<CMsgDraftTrivia.Types.DraftTriviaHeroInfo\>, 
[IEquatable<CMsgDraftTrivia.Types.DraftTriviaHeroInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDraftTrivia.Types.DraftTriviaHeroInfo\>, 
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
[EnumerableExtensions.In<CMsgDraftTrivia.Types.DraftTriviaHeroInfo\>\(CMsgDraftTrivia.Types.DraftTriviaHeroInfo, params CMsgDraftTrivia.Types.DraftTriviaHeroInfo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_DraftTriviaHeroInfo__ctor"></a> DraftTriviaHeroInfo\(\)

```csharp
public DraftTriviaHeroInfo()
```

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_DraftTriviaHeroInfo__ctor_Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_DraftTriviaHeroInfo_"></a> DraftTriviaHeroInfo\(DraftTriviaHeroInfo\)

```csharp
public DraftTriviaHeroInfo(CMsgDraftTrivia.Types.DraftTriviaHeroInfo other)
```

#### Parameters

`other` [CMsgDraftTrivia](Divine.Protobufs.Dota2.CMsgDraftTrivia.md).[Types](Divine.Protobufs.Dota2.CMsgDraftTrivia.Types.md).[DraftTriviaHeroInfo](Divine.Protobufs.Dota2.CMsgDraftTrivia.Types.DraftTriviaHeroInfo.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_DraftTriviaHeroInfo_HeroIdFieldNumber"></a> HeroIdFieldNumber

```csharp
public const int HeroIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_DraftTriviaHeroInfo_RoleFieldNumber"></a> RoleFieldNumber

```csharp
public const int RoleFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_DraftTriviaHeroInfo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_DraftTriviaHeroInfo_HasHeroId"></a> HasHeroId

```csharp
public bool HasHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_DraftTriviaHeroInfo_HasRole"></a> HasRole

```csharp
public bool HasRole { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_DraftTriviaHeroInfo_HeroId"></a> HeroId

```csharp
public int HeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_DraftTriviaHeroInfo_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDraftTrivia.Types.DraftTriviaHeroInfo> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDraftTrivia](Divine.Protobufs.Dota2.CMsgDraftTrivia.md).[Types](Divine.Protobufs.Dota2.CMsgDraftTrivia.Types.md).[DraftTriviaHeroInfo](Divine.Protobufs.Dota2.CMsgDraftTrivia.Types.DraftTriviaHeroInfo.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_DraftTriviaHeroInfo_Role"></a> Role

```csharp
public uint Role { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_DraftTriviaHeroInfo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_DraftTriviaHeroInfo_ClearHeroId"></a> ClearHeroId\(\)

```csharp
public void ClearHeroId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_DraftTriviaHeroInfo_ClearRole"></a> ClearRole\(\)

```csharp
public void ClearRole()
```

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_DraftTriviaHeroInfo_Clone"></a> Clone\(\)

```csharp
public CMsgDraftTrivia.Types.DraftTriviaHeroInfo Clone()
```

#### Returns

 [CMsgDraftTrivia](Divine.Protobufs.Dota2.CMsgDraftTrivia.md).[Types](Divine.Protobufs.Dota2.CMsgDraftTrivia.Types.md).[DraftTriviaHeroInfo](Divine.Protobufs.Dota2.CMsgDraftTrivia.Types.DraftTriviaHeroInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_DraftTriviaHeroInfo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_DraftTriviaHeroInfo_Equals_Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_DraftTriviaHeroInfo_"></a> Equals\(DraftTriviaHeroInfo\)

```csharp
public bool Equals(CMsgDraftTrivia.Types.DraftTriviaHeroInfo other)
```

#### Parameters

`other` [CMsgDraftTrivia](Divine.Protobufs.Dota2.CMsgDraftTrivia.md).[Types](Divine.Protobufs.Dota2.CMsgDraftTrivia.Types.md).[DraftTriviaHeroInfo](Divine.Protobufs.Dota2.CMsgDraftTrivia.Types.DraftTriviaHeroInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_DraftTriviaHeroInfo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_DraftTriviaHeroInfo_MergeFrom_Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_DraftTriviaHeroInfo_"></a> MergeFrom\(DraftTriviaHeroInfo\)

```csharp
public void MergeFrom(CMsgDraftTrivia.Types.DraftTriviaHeroInfo other)
```

#### Parameters

`other` [CMsgDraftTrivia](Divine.Protobufs.Dota2.CMsgDraftTrivia.md).[Types](Divine.Protobufs.Dota2.CMsgDraftTrivia.Types.md).[DraftTriviaHeroInfo](Divine.Protobufs.Dota2.CMsgDraftTrivia.Types.DraftTriviaHeroInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_DraftTriviaHeroInfo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_DraftTriviaHeroInfo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDraftTrivia_Types_DraftTriviaHeroInfo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

