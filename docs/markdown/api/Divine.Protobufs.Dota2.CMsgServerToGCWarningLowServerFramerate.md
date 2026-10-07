# <a id="Divine_Protobufs_Dota2_CMsgServerToGCWarningLowServerFramerate"></a> Class CMsgServerToGCWarningLowServerFramerate

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgServerToGCWarningLowServerFramerate : IMessage<CMsgServerToGCWarningLowServerFramerate>, IEquatable<CMsgServerToGCWarningLowServerFramerate>, IDeepCloneable<CMsgServerToGCWarningLowServerFramerate>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgServerToGCWarningLowServerFramerate](Divine.Protobufs.Dota2.CMsgServerToGCWarningLowServerFramerate.md)

#### Implements

IMessage<CMsgServerToGCWarningLowServerFramerate\>, 
[IEquatable<CMsgServerToGCWarningLowServerFramerate\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgServerToGCWarningLowServerFramerate\>, 
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
[EnumerableExtensions.In<CMsgServerToGCWarningLowServerFramerate\>\(CMsgServerToGCWarningLowServerFramerate, params CMsgServerToGCWarningLowServerFramerate\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCWarningLowServerFramerate__ctor"></a> CMsgServerToGCWarningLowServerFramerate\(\)

```csharp
public CMsgServerToGCWarningLowServerFramerate()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCWarningLowServerFramerate__ctor_Divine_Protobufs_Dota2_CMsgServerToGCWarningLowServerFramerate_"></a> CMsgServerToGCWarningLowServerFramerate\(CMsgServerToGCWarningLowServerFramerate\)

```csharp
public CMsgServerToGCWarningLowServerFramerate(CMsgServerToGCWarningLowServerFramerate other)
```

#### Parameters

`other` [CMsgServerToGCWarningLowServerFramerate](Divine.Protobufs.Dota2.CMsgServerToGCWarningLowServerFramerate.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCWarningLowServerFramerate_BotScriptIdDireFieldNumber"></a> BotScriptIdDireFieldNumber

```csharp
public const int BotScriptIdDireFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCWarningLowServerFramerate_BotScriptIdRadiantFieldNumber"></a> BotScriptIdRadiantFieldNumber

```csharp
public const int BotScriptIdRadiantFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCWarningLowServerFramerate_CustomGameIdFieldNumber"></a> CustomGameIdFieldNumber

```csharp
public const int CustomGameIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCWarningLowServerFramerate_MatchIdFieldNumber"></a> MatchIdFieldNumber

```csharp
public const int MatchIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCWarningLowServerFramerate_TicksPerIntervalAverageFieldNumber"></a> TicksPerIntervalAverageFieldNumber

```csharp
public const int TicksPerIntervalAverageFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCWarningLowServerFramerate_BotScriptIdDire"></a> BotScriptIdDire

```csharp
public ulong BotScriptIdDire { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCWarningLowServerFramerate_BotScriptIdRadiant"></a> BotScriptIdRadiant

```csharp
public ulong BotScriptIdRadiant { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCWarningLowServerFramerate_CustomGameId"></a> CustomGameId

```csharp
public ulong CustomGameId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCWarningLowServerFramerate_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCWarningLowServerFramerate_HasBotScriptIdDire"></a> HasBotScriptIdDire

```csharp
public bool HasBotScriptIdDire { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCWarningLowServerFramerate_HasBotScriptIdRadiant"></a> HasBotScriptIdRadiant

```csharp
public bool HasBotScriptIdRadiant { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCWarningLowServerFramerate_HasCustomGameId"></a> HasCustomGameId

```csharp
public bool HasCustomGameId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCWarningLowServerFramerate_HasMatchId"></a> HasMatchId

```csharp
public bool HasMatchId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCWarningLowServerFramerate_HasTicksPerIntervalAverage"></a> HasTicksPerIntervalAverage

```csharp
public bool HasTicksPerIntervalAverage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCWarningLowServerFramerate_MatchId"></a> MatchId

```csharp
public ulong MatchId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCWarningLowServerFramerate_Parser"></a> Parser

```csharp
public static MessageParser<CMsgServerToGCWarningLowServerFramerate> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgServerToGCWarningLowServerFramerate](Divine.Protobufs.Dota2.CMsgServerToGCWarningLowServerFramerate.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCWarningLowServerFramerate_TicksPerIntervalAverage"></a> TicksPerIntervalAverage

```csharp
public float TicksPerIntervalAverage { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCWarningLowServerFramerate_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCWarningLowServerFramerate_ClearBotScriptIdDire"></a> ClearBotScriptIdDire\(\)

```csharp
public void ClearBotScriptIdDire()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCWarningLowServerFramerate_ClearBotScriptIdRadiant"></a> ClearBotScriptIdRadiant\(\)

```csharp
public void ClearBotScriptIdRadiant()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCWarningLowServerFramerate_ClearCustomGameId"></a> ClearCustomGameId\(\)

```csharp
public void ClearCustomGameId()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCWarningLowServerFramerate_ClearMatchId"></a> ClearMatchId\(\)

```csharp
public void ClearMatchId()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCWarningLowServerFramerate_ClearTicksPerIntervalAverage"></a> ClearTicksPerIntervalAverage\(\)

```csharp
public void ClearTicksPerIntervalAverage()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCWarningLowServerFramerate_Clone"></a> Clone\(\)

```csharp
public CMsgServerToGCWarningLowServerFramerate Clone()
```

#### Returns

 [CMsgServerToGCWarningLowServerFramerate](Divine.Protobufs.Dota2.CMsgServerToGCWarningLowServerFramerate.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCWarningLowServerFramerate_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCWarningLowServerFramerate_Equals_Divine_Protobufs_Dota2_CMsgServerToGCWarningLowServerFramerate_"></a> Equals\(CMsgServerToGCWarningLowServerFramerate\)

```csharp
public bool Equals(CMsgServerToGCWarningLowServerFramerate other)
```

#### Parameters

`other` [CMsgServerToGCWarningLowServerFramerate](Divine.Protobufs.Dota2.CMsgServerToGCWarningLowServerFramerate.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCWarningLowServerFramerate_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCWarningLowServerFramerate_MergeFrom_Divine_Protobufs_Dota2_CMsgServerToGCWarningLowServerFramerate_"></a> MergeFrom\(CMsgServerToGCWarningLowServerFramerate\)

```csharp
public void MergeFrom(CMsgServerToGCWarningLowServerFramerate other)
```

#### Parameters

`other` [CMsgServerToGCWarningLowServerFramerate](Divine.Protobufs.Dota2.CMsgServerToGCWarningLowServerFramerate.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCWarningLowServerFramerate_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCWarningLowServerFramerate_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCWarningLowServerFramerate_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

