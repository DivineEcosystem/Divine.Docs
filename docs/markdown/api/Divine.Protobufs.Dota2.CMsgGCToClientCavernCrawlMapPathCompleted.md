# <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapPathCompleted"></a> Class CMsgGCToClientCavernCrawlMapPathCompleted

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientCavernCrawlMapPathCompleted : IMessage<CMsgGCToClientCavernCrawlMapPathCompleted>, IEquatable<CMsgGCToClientCavernCrawlMapPathCompleted>, IDeepCloneable<CMsgGCToClientCavernCrawlMapPathCompleted>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientCavernCrawlMapPathCompleted](Divine.Protobufs.Dota2.CMsgGCToClientCavernCrawlMapPathCompleted.md)

#### Implements

IMessage<CMsgGCToClientCavernCrawlMapPathCompleted\>, 
[IEquatable<CMsgGCToClientCavernCrawlMapPathCompleted\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientCavernCrawlMapPathCompleted\>, 
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
[EnumerableExtensions.In<CMsgGCToClientCavernCrawlMapPathCompleted\>\(CMsgGCToClientCavernCrawlMapPathCompleted, params CMsgGCToClientCavernCrawlMapPathCompleted\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapPathCompleted__ctor"></a> CMsgGCToClientCavernCrawlMapPathCompleted\(\)

```csharp
public CMsgGCToClientCavernCrawlMapPathCompleted()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapPathCompleted__ctor_Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapPathCompleted_"></a> CMsgGCToClientCavernCrawlMapPathCompleted\(CMsgGCToClientCavernCrawlMapPathCompleted\)

```csharp
public CMsgGCToClientCavernCrawlMapPathCompleted(CMsgGCToClientCavernCrawlMapPathCompleted other)
```

#### Parameters

`other` [CMsgGCToClientCavernCrawlMapPathCompleted](Divine.Protobufs.Dota2.CMsgGCToClientCavernCrawlMapPathCompleted.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapPathCompleted_CompletedPathsFieldNumber"></a> CompletedPathsFieldNumber

```csharp
public const int CompletedPathsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapPathCompleted_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapPathCompleted_HeroIdCompletedFieldNumber"></a> HeroIdCompletedFieldNumber

```csharp
public const int HeroIdCompletedFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapPathCompleted_MapVariantFieldNumber"></a> MapVariantFieldNumber

```csharp
public const int MapVariantFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapPathCompleted_CompletedPaths"></a> CompletedPaths

```csharp
public RepeatedField<CMsgGCToClientCavernCrawlMapPathCompleted.Types.CompletedPathInfo> CompletedPaths { get; }
```

#### Property Value

 RepeatedField<[CMsgGCToClientCavernCrawlMapPathCompleted](Divine.Protobufs.Dota2.CMsgGCToClientCavernCrawlMapPathCompleted.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientCavernCrawlMapPathCompleted.Types.md).[CompletedPathInfo](Divine.Protobufs.Dota2.CMsgGCToClientCavernCrawlMapPathCompleted.Types.CompletedPathInfo.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapPathCompleted_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapPathCompleted_EventId"></a> EventId

```csharp
public uint EventId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapPathCompleted_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapPathCompleted_HasHeroIdCompleted"></a> HasHeroIdCompleted

```csharp
public bool HasHeroIdCompleted { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapPathCompleted_HasMapVariant"></a> HasMapVariant

```csharp
public bool HasMapVariant { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapPathCompleted_HeroIdCompleted"></a> HeroIdCompleted

```csharp
public int HeroIdCompleted { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapPathCompleted_MapVariant"></a> MapVariant

```csharp
public uint MapVariant { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapPathCompleted_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientCavernCrawlMapPathCompleted> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientCavernCrawlMapPathCompleted](Divine.Protobufs.Dota2.CMsgGCToClientCavernCrawlMapPathCompleted.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapPathCompleted_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapPathCompleted_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapPathCompleted_ClearHeroIdCompleted"></a> ClearHeroIdCompleted\(\)

```csharp
public void ClearHeroIdCompleted()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapPathCompleted_ClearMapVariant"></a> ClearMapVariant\(\)

```csharp
public void ClearMapVariant()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapPathCompleted_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientCavernCrawlMapPathCompleted Clone()
```

#### Returns

 [CMsgGCToClientCavernCrawlMapPathCompleted](Divine.Protobufs.Dota2.CMsgGCToClientCavernCrawlMapPathCompleted.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapPathCompleted_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapPathCompleted_Equals_Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapPathCompleted_"></a> Equals\(CMsgGCToClientCavernCrawlMapPathCompleted\)

```csharp
public bool Equals(CMsgGCToClientCavernCrawlMapPathCompleted other)
```

#### Parameters

`other` [CMsgGCToClientCavernCrawlMapPathCompleted](Divine.Protobufs.Dota2.CMsgGCToClientCavernCrawlMapPathCompleted.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapPathCompleted_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapPathCompleted_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapPathCompleted_"></a> MergeFrom\(CMsgGCToClientCavernCrawlMapPathCompleted\)

```csharp
public void MergeFrom(CMsgGCToClientCavernCrawlMapPathCompleted other)
```

#### Parameters

`other` [CMsgGCToClientCavernCrawlMapPathCompleted](Divine.Protobufs.Dota2.CMsgGCToClientCavernCrawlMapPathCompleted.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapPathCompleted_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapPathCompleted_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapPathCompleted_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

