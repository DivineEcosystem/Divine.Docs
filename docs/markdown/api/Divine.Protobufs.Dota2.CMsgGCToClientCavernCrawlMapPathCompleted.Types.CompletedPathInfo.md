# <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapPathCompleted_Types_CompletedPathInfo"></a> Class CMsgGCToClientCavernCrawlMapPathCompleted.Types.CompletedPathInfo

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientCavernCrawlMapPathCompleted.Types.CompletedPathInfo : IMessage<CMsgGCToClientCavernCrawlMapPathCompleted.Types.CompletedPathInfo>, IEquatable<CMsgGCToClientCavernCrawlMapPathCompleted.Types.CompletedPathInfo>, IDeepCloneable<CMsgGCToClientCavernCrawlMapPathCompleted.Types.CompletedPathInfo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientCavernCrawlMapPathCompleted.Types.CompletedPathInfo](Divine.Protobufs.Dota2.CMsgGCToClientCavernCrawlMapPathCompleted.Types.CompletedPathInfo.md)

#### Implements

IMessage<CMsgGCToClientCavernCrawlMapPathCompleted.Types.CompletedPathInfo\>, 
[IEquatable<CMsgGCToClientCavernCrawlMapPathCompleted.Types.CompletedPathInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientCavernCrawlMapPathCompleted.Types.CompletedPathInfo\>, 
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
[EnumerableExtensions.In<CMsgGCToClientCavernCrawlMapPathCompleted.Types.CompletedPathInfo\>\(CMsgGCToClientCavernCrawlMapPathCompleted.Types.CompletedPathInfo, params CMsgGCToClientCavernCrawlMapPathCompleted.Types.CompletedPathInfo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapPathCompleted_Types_CompletedPathInfo__ctor"></a> CompletedPathInfo\(\)

```csharp
public CompletedPathInfo()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapPathCompleted_Types_CompletedPathInfo__ctor_Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapPathCompleted_Types_CompletedPathInfo_"></a> CompletedPathInfo\(CompletedPathInfo\)

```csharp
public CompletedPathInfo(CMsgGCToClientCavernCrawlMapPathCompleted.Types.CompletedPathInfo other)
```

#### Parameters

`other` [CMsgGCToClientCavernCrawlMapPathCompleted](Divine.Protobufs.Dota2.CMsgGCToClientCavernCrawlMapPathCompleted.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientCavernCrawlMapPathCompleted.Types.md).[CompletedPathInfo](Divine.Protobufs.Dota2.CMsgGCToClientCavernCrawlMapPathCompleted.Types.CompletedPathInfo.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapPathCompleted_Types_CompletedPathInfo_HalfCompletedFieldNumber"></a> HalfCompletedFieldNumber

```csharp
public const int HalfCompletedFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapPathCompleted_Types_CompletedPathInfo_PathIdCompletedFieldNumber"></a> PathIdCompletedFieldNumber

```csharp
public const int PathIdCompletedFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapPathCompleted_Types_CompletedPathInfo_ReceivedUltraRareRewardFieldNumber"></a> ReceivedUltraRareRewardFieldNumber

```csharp
public const int ReceivedUltraRareRewardFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapPathCompleted_Types_CompletedPathInfo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapPathCompleted_Types_CompletedPathInfo_HalfCompleted"></a> HalfCompleted

```csharp
public bool HalfCompleted { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapPathCompleted_Types_CompletedPathInfo_HasHalfCompleted"></a> HasHalfCompleted

```csharp
public bool HasHalfCompleted { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapPathCompleted_Types_CompletedPathInfo_HasPathIdCompleted"></a> HasPathIdCompleted

```csharp
public bool HasPathIdCompleted { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapPathCompleted_Types_CompletedPathInfo_HasReceivedUltraRareReward"></a> HasReceivedUltraRareReward

```csharp
public bool HasReceivedUltraRareReward { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapPathCompleted_Types_CompletedPathInfo_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientCavernCrawlMapPathCompleted.Types.CompletedPathInfo> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientCavernCrawlMapPathCompleted](Divine.Protobufs.Dota2.CMsgGCToClientCavernCrawlMapPathCompleted.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientCavernCrawlMapPathCompleted.Types.md).[CompletedPathInfo](Divine.Protobufs.Dota2.CMsgGCToClientCavernCrawlMapPathCompleted.Types.CompletedPathInfo.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapPathCompleted_Types_CompletedPathInfo_PathIdCompleted"></a> PathIdCompleted

```csharp
public uint PathIdCompleted { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapPathCompleted_Types_CompletedPathInfo_ReceivedUltraRareReward"></a> ReceivedUltraRareReward

```csharp
public bool ReceivedUltraRareReward { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapPathCompleted_Types_CompletedPathInfo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapPathCompleted_Types_CompletedPathInfo_ClearHalfCompleted"></a> ClearHalfCompleted\(\)

```csharp
public void ClearHalfCompleted()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapPathCompleted_Types_CompletedPathInfo_ClearPathIdCompleted"></a> ClearPathIdCompleted\(\)

```csharp
public void ClearPathIdCompleted()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapPathCompleted_Types_CompletedPathInfo_ClearReceivedUltraRareReward"></a> ClearReceivedUltraRareReward\(\)

```csharp
public void ClearReceivedUltraRareReward()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapPathCompleted_Types_CompletedPathInfo_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientCavernCrawlMapPathCompleted.Types.CompletedPathInfo Clone()
```

#### Returns

 [CMsgGCToClientCavernCrawlMapPathCompleted](Divine.Protobufs.Dota2.CMsgGCToClientCavernCrawlMapPathCompleted.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientCavernCrawlMapPathCompleted.Types.md).[CompletedPathInfo](Divine.Protobufs.Dota2.CMsgGCToClientCavernCrawlMapPathCompleted.Types.CompletedPathInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapPathCompleted_Types_CompletedPathInfo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapPathCompleted_Types_CompletedPathInfo_Equals_Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapPathCompleted_Types_CompletedPathInfo_"></a> Equals\(CompletedPathInfo\)

```csharp
public bool Equals(CMsgGCToClientCavernCrawlMapPathCompleted.Types.CompletedPathInfo other)
```

#### Parameters

`other` [CMsgGCToClientCavernCrawlMapPathCompleted](Divine.Protobufs.Dota2.CMsgGCToClientCavernCrawlMapPathCompleted.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientCavernCrawlMapPathCompleted.Types.md).[CompletedPathInfo](Divine.Protobufs.Dota2.CMsgGCToClientCavernCrawlMapPathCompleted.Types.CompletedPathInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapPathCompleted_Types_CompletedPathInfo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapPathCompleted_Types_CompletedPathInfo_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapPathCompleted_Types_CompletedPathInfo_"></a> MergeFrom\(CompletedPathInfo\)

```csharp
public void MergeFrom(CMsgGCToClientCavernCrawlMapPathCompleted.Types.CompletedPathInfo other)
```

#### Parameters

`other` [CMsgGCToClientCavernCrawlMapPathCompleted](Divine.Protobufs.Dota2.CMsgGCToClientCavernCrawlMapPathCompleted.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientCavernCrawlMapPathCompleted.Types.md).[CompletedPathInfo](Divine.Protobufs.Dota2.CMsgGCToClientCavernCrawlMapPathCompleted.Types.CompletedPathInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapPathCompleted_Types_CompletedPathInfo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapPathCompleted_Types_CompletedPathInfo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCavernCrawlMapPathCompleted_Types_CompletedPathInfo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

