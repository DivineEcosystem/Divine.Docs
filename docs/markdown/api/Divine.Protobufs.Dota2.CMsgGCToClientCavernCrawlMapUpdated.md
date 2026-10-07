# <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapUpdated"></a> Class CMsgGCToClientCavernCrawlMapUpdated

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientCavernCrawlMapUpdated : IMessage<CMsgGCToClientCavernCrawlMapUpdated>, IEquatable<CMsgGCToClientCavernCrawlMapUpdated>, IDeepCloneable<CMsgGCToClientCavernCrawlMapUpdated>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientCavernCrawlMapUpdated](Divine.Protobufs.Dota2.CMsgGCToClientCavernCrawlMapUpdated.md)

#### Implements

IMessage<CMsgGCToClientCavernCrawlMapUpdated\>, 
[IEquatable<CMsgGCToClientCavernCrawlMapUpdated\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientCavernCrawlMapUpdated\>, 
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
[EnumerableExtensions.In<CMsgGCToClientCavernCrawlMapUpdated\>\(CMsgGCToClientCavernCrawlMapUpdated, params CMsgGCToClientCavernCrawlMapUpdated\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapUpdated__ctor"></a> CMsgGCToClientCavernCrawlMapUpdated\(\)

```csharp
public CMsgGCToClientCavernCrawlMapUpdated()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapUpdated__ctor_Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapUpdated_"></a> CMsgGCToClientCavernCrawlMapUpdated\(CMsgGCToClientCavernCrawlMapUpdated\)

```csharp
public CMsgGCToClientCavernCrawlMapUpdated(CMsgGCToClientCavernCrawlMapUpdated other)
```

#### Parameters

`other` [CMsgGCToClientCavernCrawlMapUpdated](Divine.Protobufs.Dota2.CMsgGCToClientCavernCrawlMapUpdated.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapUpdated_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapUpdated_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapUpdated_EventId"></a> EventId

```csharp
public uint EventId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapUpdated_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapUpdated_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientCavernCrawlMapUpdated> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientCavernCrawlMapUpdated](Divine.Protobufs.Dota2.CMsgGCToClientCavernCrawlMapUpdated.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapUpdated_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapUpdated_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapUpdated_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientCavernCrawlMapUpdated Clone()
```

#### Returns

 [CMsgGCToClientCavernCrawlMapUpdated](Divine.Protobufs.Dota2.CMsgGCToClientCavernCrawlMapUpdated.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapUpdated_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapUpdated_Equals_Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapUpdated_"></a> Equals\(CMsgGCToClientCavernCrawlMapUpdated\)

```csharp
public bool Equals(CMsgGCToClientCavernCrawlMapUpdated other)
```

#### Parameters

`other` [CMsgGCToClientCavernCrawlMapUpdated](Divine.Protobufs.Dota2.CMsgGCToClientCavernCrawlMapUpdated.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapUpdated_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapUpdated_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapUpdated_"></a> MergeFrom\(CMsgGCToClientCavernCrawlMapUpdated\)

```csharp
public void MergeFrom(CMsgGCToClientCavernCrawlMapUpdated other)
```

#### Parameters

`other` [CMsgGCToClientCavernCrawlMapUpdated](Divine.Protobufs.Dota2.CMsgGCToClientCavernCrawlMapUpdated.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapUpdated_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapUpdated_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapUpdated_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

