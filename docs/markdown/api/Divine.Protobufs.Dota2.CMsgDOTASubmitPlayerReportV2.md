# <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportV2"></a> Class CMsgDOTASubmitPlayerReportV2

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTASubmitPlayerReportV2 : IMessage<CMsgDOTASubmitPlayerReportV2>, IEquatable<CMsgDOTASubmitPlayerReportV2>, IDeepCloneable<CMsgDOTASubmitPlayerReportV2>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTASubmitPlayerReportV2](Divine.Protobufs.Dota2.CMsgDOTASubmitPlayerReportV2.md)

#### Implements

IMessage<CMsgDOTASubmitPlayerReportV2\>, 
[IEquatable<CMsgDOTASubmitPlayerReportV2\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTASubmitPlayerReportV2\>, 
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
[EnumerableExtensions.In<CMsgDOTASubmitPlayerReportV2\>\(CMsgDOTASubmitPlayerReportV2, params CMsgDOTASubmitPlayerReportV2\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportV2__ctor"></a> CMsgDOTASubmitPlayerReportV2\(\)

```csharp
public CMsgDOTASubmitPlayerReportV2()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportV2__ctor_Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportV2_"></a> CMsgDOTASubmitPlayerReportV2\(CMsgDOTASubmitPlayerReportV2\)

```csharp
public CMsgDOTASubmitPlayerReportV2(CMsgDOTASubmitPlayerReportV2 other)
```

#### Parameters

`other` [CMsgDOTASubmitPlayerReportV2](Divine.Protobufs.Dota2.CMsgDOTASubmitPlayerReportV2.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportV2_DebugMatchIdFieldNumber"></a> DebugMatchIdFieldNumber

```csharp
public const int DebugMatchIdFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportV2_DebugSlotFieldNumber"></a> DebugSlotFieldNumber

```csharp
public const int DebugSlotFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportV2_GameTimeFieldNumber"></a> GameTimeFieldNumber

```csharp
public const int GameTimeFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportV2_LobbyIdFieldNumber"></a> LobbyIdFieldNumber

```csharp
public const int LobbyIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportV2_ReportReasonFieldNumber"></a> ReportReasonFieldNumber

```csharp
public const int ReportReasonFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportV2_TargetAccountIdFieldNumber"></a> TargetAccountIdFieldNumber

```csharp
public const int TargetAccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportV2_DebugMatchId"></a> DebugMatchId

```csharp
public ulong DebugMatchId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportV2_DebugSlot"></a> DebugSlot

```csharp
public uint DebugSlot { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportV2_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportV2_GameTime"></a> GameTime

```csharp
public float GameTime { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportV2_HasDebugMatchId"></a> HasDebugMatchId

```csharp
public bool HasDebugMatchId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportV2_HasDebugSlot"></a> HasDebugSlot

```csharp
public bool HasDebugSlot { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportV2_HasGameTime"></a> HasGameTime

```csharp
public bool HasGameTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportV2_HasLobbyId"></a> HasLobbyId

```csharp
public bool HasLobbyId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportV2_HasTargetAccountId"></a> HasTargetAccountId

```csharp
public bool HasTargetAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportV2_LobbyId"></a> LobbyId

```csharp
public ulong LobbyId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportV2_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTASubmitPlayerReportV2> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTASubmitPlayerReportV2](Divine.Protobufs.Dota2.CMsgDOTASubmitPlayerReportV2.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportV2_ReportReason"></a> ReportReason

```csharp
public RepeatedField<uint> ReportReason { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportV2_TargetAccountId"></a> TargetAccountId

```csharp
public uint TargetAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportV2_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportV2_ClearDebugMatchId"></a> ClearDebugMatchId\(\)

```csharp
public void ClearDebugMatchId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportV2_ClearDebugSlot"></a> ClearDebugSlot\(\)

```csharp
public void ClearDebugSlot()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportV2_ClearGameTime"></a> ClearGameTime\(\)

```csharp
public void ClearGameTime()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportV2_ClearLobbyId"></a> ClearLobbyId\(\)

```csharp
public void ClearLobbyId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportV2_ClearTargetAccountId"></a> ClearTargetAccountId\(\)

```csharp
public void ClearTargetAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportV2_Clone"></a> Clone\(\)

```csharp
public CMsgDOTASubmitPlayerReportV2 Clone()
```

#### Returns

 [CMsgDOTASubmitPlayerReportV2](Divine.Protobufs.Dota2.CMsgDOTASubmitPlayerReportV2.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportV2_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportV2_Equals_Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportV2_"></a> Equals\(CMsgDOTASubmitPlayerReportV2\)

```csharp
public bool Equals(CMsgDOTASubmitPlayerReportV2 other)
```

#### Parameters

`other` [CMsgDOTASubmitPlayerReportV2](Divine.Protobufs.Dota2.CMsgDOTASubmitPlayerReportV2.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportV2_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportV2_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportV2_"></a> MergeFrom\(CMsgDOTASubmitPlayerReportV2\)

```csharp
public void MergeFrom(CMsgDOTASubmitPlayerReportV2 other)
```

#### Parameters

`other` [CMsgDOTASubmitPlayerReportV2](Divine.Protobufs.Dota2.CMsgDOTASubmitPlayerReportV2.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportV2_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportV2_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReportV2_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

