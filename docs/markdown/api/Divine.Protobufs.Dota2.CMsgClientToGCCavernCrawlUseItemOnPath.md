# <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnPath"></a> Class CMsgClientToGCCavernCrawlUseItemOnPath

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCCavernCrawlUseItemOnPath : IMessage<CMsgClientToGCCavernCrawlUseItemOnPath>, IEquatable<CMsgClientToGCCavernCrawlUseItemOnPath>, IDeepCloneable<CMsgClientToGCCavernCrawlUseItemOnPath>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCCavernCrawlUseItemOnPath](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlUseItemOnPath.md)

#### Implements

IMessage<CMsgClientToGCCavernCrawlUseItemOnPath\>, 
[IEquatable<CMsgClientToGCCavernCrawlUseItemOnPath\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCCavernCrawlUseItemOnPath\>, 
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
[EnumerableExtensions.In<CMsgClientToGCCavernCrawlUseItemOnPath\>\(CMsgClientToGCCavernCrawlUseItemOnPath, params CMsgClientToGCCavernCrawlUseItemOnPath\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnPath__ctor"></a> CMsgClientToGCCavernCrawlUseItemOnPath\(\)

```csharp
public CMsgClientToGCCavernCrawlUseItemOnPath()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnPath__ctor_Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnPath_"></a> CMsgClientToGCCavernCrawlUseItemOnPath\(CMsgClientToGCCavernCrawlUseItemOnPath\)

```csharp
public CMsgClientToGCCavernCrawlUseItemOnPath(CMsgClientToGCCavernCrawlUseItemOnPath other)
```

#### Parameters

`other` [CMsgClientToGCCavernCrawlUseItemOnPath](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlUseItemOnPath.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnPath_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnPath_ItemTypeFieldNumber"></a> ItemTypeFieldNumber

```csharp
public const int ItemTypeFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnPath_MapVariantFieldNumber"></a> MapVariantFieldNumber

```csharp
public const int MapVariantFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnPath_PathIdFieldNumber"></a> PathIdFieldNumber

```csharp
public const int PathIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnPath_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnPath_EventId"></a> EventId

```csharp
public uint EventId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnPath_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnPath_HasItemType"></a> HasItemType

```csharp
public bool HasItemType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnPath_HasMapVariant"></a> HasMapVariant

```csharp
public bool HasMapVariant { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnPath_HasPathId"></a> HasPathId

```csharp
public bool HasPathId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnPath_ItemType"></a> ItemType

```csharp
public uint ItemType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnPath_MapVariant"></a> MapVariant

```csharp
public uint MapVariant { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnPath_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCCavernCrawlUseItemOnPath> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCCavernCrawlUseItemOnPath](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlUseItemOnPath.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnPath_PathId"></a> PathId

```csharp
public uint PathId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnPath_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnPath_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnPath_ClearItemType"></a> ClearItemType\(\)

```csharp
public void ClearItemType()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnPath_ClearMapVariant"></a> ClearMapVariant\(\)

```csharp
public void ClearMapVariant()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnPath_ClearPathId"></a> ClearPathId\(\)

```csharp
public void ClearPathId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnPath_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCCavernCrawlUseItemOnPath Clone()
```

#### Returns

 [CMsgClientToGCCavernCrawlUseItemOnPath](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlUseItemOnPath.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnPath_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnPath_Equals_Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnPath_"></a> Equals\(CMsgClientToGCCavernCrawlUseItemOnPath\)

```csharp
public bool Equals(CMsgClientToGCCavernCrawlUseItemOnPath other)
```

#### Parameters

`other` [CMsgClientToGCCavernCrawlUseItemOnPath](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlUseItemOnPath.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnPath_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnPath_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnPath_"></a> MergeFrom\(CMsgClientToGCCavernCrawlUseItemOnPath\)

```csharp
public void MergeFrom(CMsgClientToGCCavernCrawlUseItemOnPath other)
```

#### Parameters

`other` [CMsgClientToGCCavernCrawlUseItemOnPath](Divine.Protobufs.Dota2.CMsgClientToGCCavernCrawlUseItemOnPath.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnPath_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnPath_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCavernCrawlUseItemOnPath_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

