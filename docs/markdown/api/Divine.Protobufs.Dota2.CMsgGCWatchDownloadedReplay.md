# <a id="Divine_Protobufs_Dota2_CMsgGCWatchDownloadedReplay"></a> Class CMsgGCWatchDownloadedReplay

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCWatchDownloadedReplay : IMessage<CMsgGCWatchDownloadedReplay>, IEquatable<CMsgGCWatchDownloadedReplay>, IDeepCloneable<CMsgGCWatchDownloadedReplay>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCWatchDownloadedReplay](Divine.Protobufs.Dota2.CMsgGCWatchDownloadedReplay.md)

#### Implements

IMessage<CMsgGCWatchDownloadedReplay\>, 
[IEquatable<CMsgGCWatchDownloadedReplay\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCWatchDownloadedReplay\>, 
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
[EnumerableExtensions.In<CMsgGCWatchDownloadedReplay\>\(CMsgGCWatchDownloadedReplay, params CMsgGCWatchDownloadedReplay\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCWatchDownloadedReplay__ctor"></a> CMsgGCWatchDownloadedReplay\(\)

```csharp
public CMsgGCWatchDownloadedReplay()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCWatchDownloadedReplay__ctor_Divine_Protobufs_Dota2_CMsgGCWatchDownloadedReplay_"></a> CMsgGCWatchDownloadedReplay\(CMsgGCWatchDownloadedReplay\)

```csharp
public CMsgGCWatchDownloadedReplay(CMsgGCWatchDownloadedReplay other)
```

#### Parameters

`other` [CMsgGCWatchDownloadedReplay](Divine.Protobufs.Dota2.CMsgGCWatchDownloadedReplay.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCWatchDownloadedReplay_MatchIdFieldNumber"></a> MatchIdFieldNumber

```csharp
public const int MatchIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCWatchDownloadedReplay_WatchTypeFieldNumber"></a> WatchTypeFieldNumber

```csharp
public const int WatchTypeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCWatchDownloadedReplay_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCWatchDownloadedReplay_HasMatchId"></a> HasMatchId

```csharp
public bool HasMatchId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCWatchDownloadedReplay_HasWatchType"></a> HasWatchType

```csharp
public bool HasWatchType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCWatchDownloadedReplay_MatchId"></a> MatchId

```csharp
public ulong MatchId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgGCWatchDownloadedReplay_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCWatchDownloadedReplay> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCWatchDownloadedReplay](Divine.Protobufs.Dota2.CMsgGCWatchDownloadedReplay.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCWatchDownloadedReplay_WatchType"></a> WatchType

```csharp
public DOTA_WatchReplayType WatchType { get; set; }
```

#### Property Value

 [DOTA\_WatchReplayType](Divine.Protobufs.Dota2.DOTA\_WatchReplayType.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCWatchDownloadedReplay_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCWatchDownloadedReplay_ClearMatchId"></a> ClearMatchId\(\)

```csharp
public void ClearMatchId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCWatchDownloadedReplay_ClearWatchType"></a> ClearWatchType\(\)

```csharp
public void ClearWatchType()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCWatchDownloadedReplay_Clone"></a> Clone\(\)

```csharp
public CMsgGCWatchDownloadedReplay Clone()
```

#### Returns

 [CMsgGCWatchDownloadedReplay](Divine.Protobufs.Dota2.CMsgGCWatchDownloadedReplay.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCWatchDownloadedReplay_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCWatchDownloadedReplay_Equals_Divine_Protobufs_Dota2_CMsgGCWatchDownloadedReplay_"></a> Equals\(CMsgGCWatchDownloadedReplay\)

```csharp
public bool Equals(CMsgGCWatchDownloadedReplay other)
```

#### Parameters

`other` [CMsgGCWatchDownloadedReplay](Divine.Protobufs.Dota2.CMsgGCWatchDownloadedReplay.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCWatchDownloadedReplay_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCWatchDownloadedReplay_MergeFrom_Divine_Protobufs_Dota2_CMsgGCWatchDownloadedReplay_"></a> MergeFrom\(CMsgGCWatchDownloadedReplay\)

```csharp
public void MergeFrom(CMsgGCWatchDownloadedReplay other)
```

#### Parameters

`other` [CMsgGCWatchDownloadedReplay](Divine.Protobufs.Dota2.CMsgGCWatchDownloadedReplay.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCWatchDownloadedReplay_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCWatchDownloadedReplay_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCWatchDownloadedReplay_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

