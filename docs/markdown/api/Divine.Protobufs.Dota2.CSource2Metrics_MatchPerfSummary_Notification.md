# <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification"></a> Class CSource2Metrics\_MatchPerfSummary\_Notification

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSource2Metrics_MatchPerfSummary_Notification : IMessage<CSource2Metrics_MatchPerfSummary_Notification>, IEquatable<CSource2Metrics_MatchPerfSummary_Notification>, IDeepCloneable<CSource2Metrics_MatchPerfSummary_Notification>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSource2Metrics\_MatchPerfSummary\_Notification](Divine.Protobufs.Dota2.CSource2Metrics\_MatchPerfSummary\_Notification.md)

#### Implements

IMessage<CSource2Metrics\_MatchPerfSummary\_Notification\>, 
[IEquatable<CSource2Metrics\_MatchPerfSummary\_Notification\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSource2Metrics\_MatchPerfSummary\_Notification\>, 
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
[EnumerableExtensions.In<CSource2Metrics\_MatchPerfSummary\_Notification\>\(CSource2Metrics\_MatchPerfSummary\_Notification, params CSource2Metrics\_MatchPerfSummary\_Notification\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification__ctor"></a> CSource2Metrics\_MatchPerfSummary\_Notification\(\)

```csharp
public CSource2Metrics_MatchPerfSummary_Notification()
```

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification__ctor_Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_"></a> CSource2Metrics\_MatchPerfSummary\_Notification\(CSource2Metrics\_MatchPerfSummary\_Notification\)

```csharp
public CSource2Metrics_MatchPerfSummary_Notification(CSource2Metrics_MatchPerfSummary_Notification other)
```

#### Parameters

`other` [CSource2Metrics\_MatchPerfSummary\_Notification](Divine.Protobufs.Dota2.CSource2Metrics\_MatchPerfSummary\_Notification.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_AppidFieldNumber"></a> AppidFieldNumber

```csharp
public const int AppidFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_ClientsFieldNumber"></a> ClientsFieldNumber

```csharp
public const int ClientsFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_GameModeFieldNumber"></a> GameModeFieldNumber

```csharp
public const int GameModeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_MapFieldNumber"></a> MapFieldNumber

```csharp
public const int MapFieldNumber = 20
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_ServerBuildIdFieldNumber"></a> ServerBuildIdFieldNumber

```csharp
public const int ServerBuildIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_ServerPopidFieldNumber"></a> ServerPopidFieldNumber

```csharp
public const int ServerPopidFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_ServerProfileFieldNumber"></a> ServerProfileFieldNumber

```csharp
public const int ServerProfileFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_Appid"></a> Appid

```csharp
public uint Appid { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_Clients"></a> Clients

```csharp
public RepeatedField<CSource2Metrics_MatchPerfSummary_Notification.Types.Client> Clients { get; }
```

#### Property Value

 RepeatedField<[CSource2Metrics\_MatchPerfSummary\_Notification](Divine.Protobufs.Dota2.CSource2Metrics\_MatchPerfSummary\_Notification.md).[Types](Divine.Protobufs.Dota2.CSource2Metrics\_MatchPerfSummary\_Notification.Types.md).[Client](Divine.Protobufs.Dota2.CSource2Metrics\_MatchPerfSummary\_Notification.Types.Client.md)\>

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_GameMode"></a> GameMode

```csharp
public string GameMode { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_HasAppid"></a> HasAppid

```csharp
public bool HasAppid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_HasGameMode"></a> HasGameMode

```csharp
public bool HasGameMode { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_HasMap"></a> HasMap

```csharp
public bool HasMap { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_HasServerBuildId"></a> HasServerBuildId

```csharp
public bool HasServerBuildId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_HasServerPopid"></a> HasServerPopid

```csharp
public bool HasServerPopid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_Map"></a> Map

```csharp
public string Map { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_Parser"></a> Parser

```csharp
public static MessageParser<CSource2Metrics_MatchPerfSummary_Notification> Parser { get; }
```

#### Property Value

 MessageParser<[CSource2Metrics\_MatchPerfSummary\_Notification](Divine.Protobufs.Dota2.CSource2Metrics\_MatchPerfSummary\_Notification.md)\>

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_ServerBuildId"></a> ServerBuildId

```csharp
public uint ServerBuildId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_ServerPopid"></a> ServerPopid

```csharp
public uint ServerPopid { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_ServerProfile"></a> ServerProfile

```csharp
public CMsgSource2VProfLiteReport ServerProfile { get; set; }
```

#### Property Value

 [CMsgSource2VProfLiteReport](Divine.Protobufs.Dota2.CMsgSource2VProfLiteReport.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_ClearAppid"></a> ClearAppid\(\)

```csharp
public void ClearAppid()
```

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_ClearGameMode"></a> ClearGameMode\(\)

```csharp
public void ClearGameMode()
```

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_ClearMap"></a> ClearMap\(\)

```csharp
public void ClearMap()
```

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_ClearServerBuildId"></a> ClearServerBuildId\(\)

```csharp
public void ClearServerBuildId()
```

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_ClearServerPopid"></a> ClearServerPopid\(\)

```csharp
public void ClearServerPopid()
```

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_Clone"></a> Clone\(\)

```csharp
public CSource2Metrics_MatchPerfSummary_Notification Clone()
```

#### Returns

 [CSource2Metrics\_MatchPerfSummary\_Notification](Divine.Protobufs.Dota2.CSource2Metrics\_MatchPerfSummary\_Notification.md)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_Equals_Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_"></a> Equals\(CSource2Metrics\_MatchPerfSummary\_Notification\)

```csharp
public bool Equals(CSource2Metrics_MatchPerfSummary_Notification other)
```

#### Parameters

`other` [CSource2Metrics\_MatchPerfSummary\_Notification](Divine.Protobufs.Dota2.CSource2Metrics\_MatchPerfSummary\_Notification.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_MergeFrom_Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_"></a> MergeFrom\(CSource2Metrics\_MatchPerfSummary\_Notification\)

```csharp
public void MergeFrom(CSource2Metrics_MatchPerfSummary_Notification other)
```

#### Parameters

`other` [CSource2Metrics\_MatchPerfSummary\_Notification](Divine.Protobufs.Dota2.CSource2Metrics\_MatchPerfSummary\_Notification.md)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_MatchPerfSummary_Notification_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

