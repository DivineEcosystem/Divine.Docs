# <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupListResponse_Types_EventInfo"></a> Class CMsgGCToClientBattlePassRollupListResponse.Types.EventInfo

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientBattlePassRollupListResponse.Types.EventInfo : IMessage<CMsgGCToClientBattlePassRollupListResponse.Types.EventInfo>, IEquatable<CMsgGCToClientBattlePassRollupListResponse.Types.EventInfo>, IDeepCloneable<CMsgGCToClientBattlePassRollupListResponse.Types.EventInfo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientBattlePassRollupListResponse.Types.EventInfo](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollupListResponse.Types.EventInfo.md)

#### Implements

IMessage<CMsgGCToClientBattlePassRollupListResponse.Types.EventInfo\>, 
[IEquatable<CMsgGCToClientBattlePassRollupListResponse.Types.EventInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientBattlePassRollupListResponse.Types.EventInfo\>, 
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
[EnumerableExtensions.In<CMsgGCToClientBattlePassRollupListResponse.Types.EventInfo\>\(CMsgGCToClientBattlePassRollupListResponse.Types.EventInfo, params CMsgGCToClientBattlePassRollupListResponse.Types.EventInfo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupListResponse_Types_EventInfo__ctor"></a> EventInfo\(\)

```csharp
public EventInfo()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupListResponse_Types_EventInfo__ctor_Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupListResponse_Types_EventInfo_"></a> EventInfo\(EventInfo\)

```csharp
public EventInfo(CMsgGCToClientBattlePassRollupListResponse.Types.EventInfo other)
```

#### Parameters

`other` [CMsgGCToClientBattlePassRollupListResponse](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollupListResponse.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollupListResponse.Types.md).[EventInfo](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollupListResponse.Types.EventInfo.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupListResponse_Types_EventInfo_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupListResponse_Types_EventInfo_LevelFieldNumber"></a> LevelFieldNumber

```csharp
public const int LevelFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupListResponse_Types_EventInfo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupListResponse_Types_EventInfo_EventId"></a> EventId

```csharp
public uint EventId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupListResponse_Types_EventInfo_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupListResponse_Types_EventInfo_HasLevel"></a> HasLevel

```csharp
public bool HasLevel { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupListResponse_Types_EventInfo_Level"></a> Level

```csharp
public uint Level { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupListResponse_Types_EventInfo_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientBattlePassRollupListResponse.Types.EventInfo> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientBattlePassRollupListResponse](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollupListResponse.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollupListResponse.Types.md).[EventInfo](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollupListResponse.Types.EventInfo.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupListResponse_Types_EventInfo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupListResponse_Types_EventInfo_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupListResponse_Types_EventInfo_ClearLevel"></a> ClearLevel\(\)

```csharp
public void ClearLevel()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupListResponse_Types_EventInfo_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientBattlePassRollupListResponse.Types.EventInfo Clone()
```

#### Returns

 [CMsgGCToClientBattlePassRollupListResponse](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollupListResponse.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollupListResponse.Types.md).[EventInfo](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollupListResponse.Types.EventInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupListResponse_Types_EventInfo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupListResponse_Types_EventInfo_Equals_Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupListResponse_Types_EventInfo_"></a> Equals\(EventInfo\)

```csharp
public bool Equals(CMsgGCToClientBattlePassRollupListResponse.Types.EventInfo other)
```

#### Parameters

`other` [CMsgGCToClientBattlePassRollupListResponse](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollupListResponse.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollupListResponse.Types.md).[EventInfo](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollupListResponse.Types.EventInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupListResponse_Types_EventInfo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupListResponse_Types_EventInfo_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupListResponse_Types_EventInfo_"></a> MergeFrom\(EventInfo\)

```csharp
public void MergeFrom(CMsgGCToClientBattlePassRollupListResponse.Types.EventInfo other)
```

#### Parameters

`other` [CMsgGCToClientBattlePassRollupListResponse](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollupListResponse.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollupListResponse.Types.md).[EventInfo](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollupListResponse.Types.EventInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupListResponse_Types_EventInfo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupListResponse_Types_EventInfo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupListResponse_Types_EventInfo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

