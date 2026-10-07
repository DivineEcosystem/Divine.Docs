# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RequestBulkCombatLog"></a> Class CDOTAClientMsg\_RequestBulkCombatLog

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_RequestBulkCombatLog : IMessage<CDOTAClientMsg_RequestBulkCombatLog>, IEquatable<CDOTAClientMsg_RequestBulkCombatLog>, IDeepCloneable<CDOTAClientMsg_RequestBulkCombatLog>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_RequestBulkCombatLog](Divine.Protobufs.Dota2.CDOTAClientMsg\_RequestBulkCombatLog.md)

#### Implements

IMessage<CDOTAClientMsg\_RequestBulkCombatLog\>, 
[IEquatable<CDOTAClientMsg\_RequestBulkCombatLog\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_RequestBulkCombatLog\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_RequestBulkCombatLog\>\(CDOTAClientMsg\_RequestBulkCombatLog, params CDOTAClientMsg\_RequestBulkCombatLog\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RequestBulkCombatLog__ctor"></a> CDOTAClientMsg\_RequestBulkCombatLog\(\)

```csharp
public CDOTAClientMsg_RequestBulkCombatLog()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RequestBulkCombatLog__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_RequestBulkCombatLog_"></a> CDOTAClientMsg\_RequestBulkCombatLog\(CDOTAClientMsg\_RequestBulkCombatLog\)

```csharp
public CDOTAClientMsg_RequestBulkCombatLog(CDOTAClientMsg_RequestBulkCombatLog other)
```

#### Parameters

`other` [CDOTAClientMsg\_RequestBulkCombatLog](Divine.Protobufs.Dota2.CDOTAClientMsg\_RequestBulkCombatLog.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RequestBulkCombatLog_DurationFieldNumber"></a> DurationFieldNumber

```csharp
public const int DurationFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RequestBulkCombatLog_GameTimeFieldNumber"></a> GameTimeFieldNumber

```csharp
public const int GameTimeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RequestBulkCombatLog_PlayerIdFieldNumber"></a> PlayerIdFieldNumber

```csharp
public const int PlayerIdFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RequestBulkCombatLog_RecentPlayerDeathFieldNumber"></a> RecentPlayerDeathFieldNumber

```csharp
public const int RecentPlayerDeathFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RequestBulkCombatLog_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RequestBulkCombatLog_Duration"></a> Duration

```csharp
public float Duration { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RequestBulkCombatLog_GameTime"></a> GameTime

```csharp
public float GameTime { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RequestBulkCombatLog_HasDuration"></a> HasDuration

```csharp
public bool HasDuration { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RequestBulkCombatLog_HasGameTime"></a> HasGameTime

```csharp
public bool HasGameTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RequestBulkCombatLog_HasPlayerId"></a> HasPlayerId

```csharp
public bool HasPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RequestBulkCombatLog_HasRecentPlayerDeath"></a> HasRecentPlayerDeath

```csharp
public bool HasRecentPlayerDeath { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RequestBulkCombatLog_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_RequestBulkCombatLog> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_RequestBulkCombatLog](Divine.Protobufs.Dota2.CDOTAClientMsg\_RequestBulkCombatLog.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RequestBulkCombatLog_PlayerId"></a> PlayerId

```csharp
public int PlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RequestBulkCombatLog_RecentPlayerDeath"></a> RecentPlayerDeath

```csharp
public bool RecentPlayerDeath { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RequestBulkCombatLog_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RequestBulkCombatLog_ClearDuration"></a> ClearDuration\(\)

```csharp
public void ClearDuration()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RequestBulkCombatLog_ClearGameTime"></a> ClearGameTime\(\)

```csharp
public void ClearGameTime()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RequestBulkCombatLog_ClearPlayerId"></a> ClearPlayerId\(\)

```csharp
public void ClearPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RequestBulkCombatLog_ClearRecentPlayerDeath"></a> ClearRecentPlayerDeath\(\)

```csharp
public void ClearRecentPlayerDeath()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RequestBulkCombatLog_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_RequestBulkCombatLog Clone()
```

#### Returns

 [CDOTAClientMsg\_RequestBulkCombatLog](Divine.Protobufs.Dota2.CDOTAClientMsg\_RequestBulkCombatLog.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RequestBulkCombatLog_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RequestBulkCombatLog_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_RequestBulkCombatLog_"></a> Equals\(CDOTAClientMsg\_RequestBulkCombatLog\)

```csharp
public bool Equals(CDOTAClientMsg_RequestBulkCombatLog other)
```

#### Parameters

`other` [CDOTAClientMsg\_RequestBulkCombatLog](Divine.Protobufs.Dota2.CDOTAClientMsg\_RequestBulkCombatLog.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RequestBulkCombatLog_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RequestBulkCombatLog_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_RequestBulkCombatLog_"></a> MergeFrom\(CDOTAClientMsg\_RequestBulkCombatLog\)

```csharp
public void MergeFrom(CDOTAClientMsg_RequestBulkCombatLog other)
```

#### Parameters

`other` [CDOTAClientMsg\_RequestBulkCombatLog](Divine.Protobufs.Dota2.CDOTAClientMsg\_RequestBulkCombatLog.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RequestBulkCombatLog_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RequestBulkCombatLog_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RequestBulkCombatLog_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

