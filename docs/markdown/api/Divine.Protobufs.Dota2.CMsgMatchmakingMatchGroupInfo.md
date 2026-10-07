# <a id="Divine_Protobufs_Dota2_CMsgMatchmakingMatchGroupInfo"></a> Class CMsgMatchmakingMatchGroupInfo

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgMatchmakingMatchGroupInfo : IMessage<CMsgMatchmakingMatchGroupInfo>, IEquatable<CMsgMatchmakingMatchGroupInfo>, IDeepCloneable<CMsgMatchmakingMatchGroupInfo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgMatchmakingMatchGroupInfo](Divine.Protobufs.Dota2.CMsgMatchmakingMatchGroupInfo.md)

#### Implements

IMessage<CMsgMatchmakingMatchGroupInfo\>, 
[IEquatable<CMsgMatchmakingMatchGroupInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgMatchmakingMatchGroupInfo\>, 
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
[EnumerableExtensions.In<CMsgMatchmakingMatchGroupInfo\>\(CMsgMatchmakingMatchGroupInfo, params CMsgMatchmakingMatchGroupInfo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgMatchmakingMatchGroupInfo__ctor"></a> CMsgMatchmakingMatchGroupInfo\(\)

```csharp
public CMsgMatchmakingMatchGroupInfo()
```

### <a id="Divine_Protobufs_Dota2_CMsgMatchmakingMatchGroupInfo__ctor_Divine_Protobufs_Dota2_CMsgMatchmakingMatchGroupInfo_"></a> CMsgMatchmakingMatchGroupInfo\(CMsgMatchmakingMatchGroupInfo\)

```csharp
public CMsgMatchmakingMatchGroupInfo(CMsgMatchmakingMatchGroupInfo other)
```

#### Parameters

`other` [CMsgMatchmakingMatchGroupInfo](Divine.Protobufs.Dota2.CMsgMatchmakingMatchGroupInfo.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgMatchmakingMatchGroupInfo_AutoRegionSelectPingPenaltyCustomFieldNumber"></a> AutoRegionSelectPingPenaltyCustomFieldNumber

```csharp
public const int AutoRegionSelectPingPenaltyCustomFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMatchmakingMatchGroupInfo_AutoRegionSelectPingPenaltyFieldNumber"></a> AutoRegionSelectPingPenaltyFieldNumber

```csharp
public const int AutoRegionSelectPingPenaltyFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMatchmakingMatchGroupInfo_PlayersSearchingFieldNumber"></a> PlayersSearchingFieldNumber

```csharp
public const int PlayersSearchingFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMatchmakingMatchGroupInfo_StatusFieldNumber"></a> StatusFieldNumber

```csharp
public const int StatusFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgMatchmakingMatchGroupInfo_AutoRegionSelectPingPenalty"></a> AutoRegionSelectPingPenalty

```csharp
public int AutoRegionSelectPingPenalty { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMatchmakingMatchGroupInfo_AutoRegionSelectPingPenaltyCustom"></a> AutoRegionSelectPingPenaltyCustom

```csharp
public int AutoRegionSelectPingPenaltyCustom { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMatchmakingMatchGroupInfo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgMatchmakingMatchGroupInfo_HasAutoRegionSelectPingPenalty"></a> HasAutoRegionSelectPingPenalty

```csharp
public bool HasAutoRegionSelectPingPenalty { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMatchmakingMatchGroupInfo_HasAutoRegionSelectPingPenaltyCustom"></a> HasAutoRegionSelectPingPenaltyCustom

```csharp
public bool HasAutoRegionSelectPingPenaltyCustom { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMatchmakingMatchGroupInfo_HasPlayersSearching"></a> HasPlayersSearching

```csharp
public bool HasPlayersSearching { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMatchmakingMatchGroupInfo_HasStatus"></a> HasStatus

```csharp
public bool HasStatus { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMatchmakingMatchGroupInfo_Parser"></a> Parser

```csharp
public static MessageParser<CMsgMatchmakingMatchGroupInfo> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgMatchmakingMatchGroupInfo](Divine.Protobufs.Dota2.CMsgMatchmakingMatchGroupInfo.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgMatchmakingMatchGroupInfo_PlayersSearching"></a> PlayersSearching

```csharp
public uint PlayersSearching { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgMatchmakingMatchGroupInfo_Status"></a> Status

```csharp
public EMatchGroupServerStatus Status { get; set; }
```

#### Property Value

 [EMatchGroupServerStatus](Divine.Protobufs.Dota2.EMatchGroupServerStatus.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgMatchmakingMatchGroupInfo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMatchmakingMatchGroupInfo_ClearAutoRegionSelectPingPenalty"></a> ClearAutoRegionSelectPingPenalty\(\)

```csharp
public void ClearAutoRegionSelectPingPenalty()
```

### <a id="Divine_Protobufs_Dota2_CMsgMatchmakingMatchGroupInfo_ClearAutoRegionSelectPingPenaltyCustom"></a> ClearAutoRegionSelectPingPenaltyCustom\(\)

```csharp
public void ClearAutoRegionSelectPingPenaltyCustom()
```

### <a id="Divine_Protobufs_Dota2_CMsgMatchmakingMatchGroupInfo_ClearPlayersSearching"></a> ClearPlayersSearching\(\)

```csharp
public void ClearPlayersSearching()
```

### <a id="Divine_Protobufs_Dota2_CMsgMatchmakingMatchGroupInfo_ClearStatus"></a> ClearStatus\(\)

```csharp
public void ClearStatus()
```

### <a id="Divine_Protobufs_Dota2_CMsgMatchmakingMatchGroupInfo_Clone"></a> Clone\(\)

```csharp
public CMsgMatchmakingMatchGroupInfo Clone()
```

#### Returns

 [CMsgMatchmakingMatchGroupInfo](Divine.Protobufs.Dota2.CMsgMatchmakingMatchGroupInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgMatchmakingMatchGroupInfo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMatchmakingMatchGroupInfo_Equals_Divine_Protobufs_Dota2_CMsgMatchmakingMatchGroupInfo_"></a> Equals\(CMsgMatchmakingMatchGroupInfo\)

```csharp
public bool Equals(CMsgMatchmakingMatchGroupInfo other)
```

#### Parameters

`other` [CMsgMatchmakingMatchGroupInfo](Divine.Protobufs.Dota2.CMsgMatchmakingMatchGroupInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMatchmakingMatchGroupInfo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMatchmakingMatchGroupInfo_MergeFrom_Divine_Protobufs_Dota2_CMsgMatchmakingMatchGroupInfo_"></a> MergeFrom\(CMsgMatchmakingMatchGroupInfo\)

```csharp
public void MergeFrom(CMsgMatchmakingMatchGroupInfo other)
```

#### Parameters

`other` [CMsgMatchmakingMatchGroupInfo](Divine.Protobufs.Dota2.CMsgMatchmakingMatchGroupInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgMatchmakingMatchGroupInfo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgMatchmakingMatchGroupInfo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgMatchmakingMatchGroupInfo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

