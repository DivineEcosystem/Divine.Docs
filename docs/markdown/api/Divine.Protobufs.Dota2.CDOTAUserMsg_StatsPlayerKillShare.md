# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsPlayerKillShare"></a> Class CDOTAUserMsg\_StatsPlayerKillShare

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_StatsPlayerKillShare : IMessage<CDOTAUserMsg_StatsPlayerKillShare>, IEquatable<CDOTAUserMsg_StatsPlayerKillShare>, IDeepCloneable<CDOTAUserMsg_StatsPlayerKillShare>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_StatsPlayerKillShare](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsPlayerKillShare.md)

#### Implements

IMessage<CDOTAUserMsg\_StatsPlayerKillShare\>, 
[IEquatable<CDOTAUserMsg\_StatsPlayerKillShare\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_StatsPlayerKillShare\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_StatsPlayerKillShare\>\(CDOTAUserMsg\_StatsPlayerKillShare, params CDOTAUserMsg\_StatsPlayerKillShare\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsPlayerKillShare__ctor"></a> CDOTAUserMsg\_StatsPlayerKillShare\(\)

```csharp
public CDOTAUserMsg_StatsPlayerKillShare()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsPlayerKillShare__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_StatsPlayerKillShare_"></a> CDOTAUserMsg\_StatsPlayerKillShare\(CDOTAUserMsg\_StatsPlayerKillShare\)

```csharp
public CDOTAUserMsg_StatsPlayerKillShare(CDOTAUserMsg_StatsPlayerKillShare other)
```

#### Parameters

`other` [CDOTAUserMsg\_StatsPlayerKillShare](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsPlayerKillShare.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsPlayerKillShare_HealthPercentFieldNumber"></a> HealthPercentFieldNumber

```csharp
public const int HealthPercentFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsPlayerKillShare_KillSharePercentFieldNumber"></a> KillSharePercentFieldNumber

```csharp
public const int KillSharePercentFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsPlayerKillShare_ManaPercentFieldNumber"></a> ManaPercentFieldNumber

```csharp
public const int ManaPercentFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsPlayerKillShare_PlayerIdFieldNumber"></a> PlayerIdFieldNumber

```csharp
public const int PlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsPlayerKillShare_PlayerLocXFieldNumber"></a> PlayerLocXFieldNumber

```csharp
public const int PlayerLocXFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsPlayerKillShare_PlayerLocYFieldNumber"></a> PlayerLocYFieldNumber

```csharp
public const int PlayerLocYFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsPlayerKillShare_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsPlayerKillShare_HasHealthPercent"></a> HasHealthPercent

```csharp
public bool HasHealthPercent { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsPlayerKillShare_HasKillSharePercent"></a> HasKillSharePercent

```csharp
public bool HasKillSharePercent { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsPlayerKillShare_HasManaPercent"></a> HasManaPercent

```csharp
public bool HasManaPercent { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsPlayerKillShare_HasPlayerId"></a> HasPlayerId

```csharp
public bool HasPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsPlayerKillShare_HasPlayerLocX"></a> HasPlayerLocX

```csharp
public bool HasPlayerLocX { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsPlayerKillShare_HasPlayerLocY"></a> HasPlayerLocY

```csharp
public bool HasPlayerLocY { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsPlayerKillShare_HealthPercent"></a> HealthPercent

```csharp
public float HealthPercent { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsPlayerKillShare_KillSharePercent"></a> KillSharePercent

```csharp
public float KillSharePercent { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsPlayerKillShare_ManaPercent"></a> ManaPercent

```csharp
public float ManaPercent { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsPlayerKillShare_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_StatsPlayerKillShare> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_StatsPlayerKillShare](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsPlayerKillShare.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsPlayerKillShare_PlayerId"></a> PlayerId

```csharp
public int PlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsPlayerKillShare_PlayerLocX"></a> PlayerLocX

```csharp
public float PlayerLocX { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsPlayerKillShare_PlayerLocY"></a> PlayerLocY

```csharp
public float PlayerLocY { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsPlayerKillShare_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsPlayerKillShare_ClearHealthPercent"></a> ClearHealthPercent\(\)

```csharp
public void ClearHealthPercent()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsPlayerKillShare_ClearKillSharePercent"></a> ClearKillSharePercent\(\)

```csharp
public void ClearKillSharePercent()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsPlayerKillShare_ClearManaPercent"></a> ClearManaPercent\(\)

```csharp
public void ClearManaPercent()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsPlayerKillShare_ClearPlayerId"></a> ClearPlayerId\(\)

```csharp
public void ClearPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsPlayerKillShare_ClearPlayerLocX"></a> ClearPlayerLocX\(\)

```csharp
public void ClearPlayerLocX()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsPlayerKillShare_ClearPlayerLocY"></a> ClearPlayerLocY\(\)

```csharp
public void ClearPlayerLocY()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsPlayerKillShare_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_StatsPlayerKillShare Clone()
```

#### Returns

 [CDOTAUserMsg\_StatsPlayerKillShare](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsPlayerKillShare.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsPlayerKillShare_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsPlayerKillShare_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_StatsPlayerKillShare_"></a> Equals\(CDOTAUserMsg\_StatsPlayerKillShare\)

```csharp
public bool Equals(CDOTAUserMsg_StatsPlayerKillShare other)
```

#### Parameters

`other` [CDOTAUserMsg\_StatsPlayerKillShare](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsPlayerKillShare.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsPlayerKillShare_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsPlayerKillShare_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_StatsPlayerKillShare_"></a> MergeFrom\(CDOTAUserMsg\_StatsPlayerKillShare\)

```csharp
public void MergeFrom(CDOTAUserMsg_StatsPlayerKillShare other)
```

#### Parameters

`other` [CDOTAUserMsg\_StatsPlayerKillShare](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsPlayerKillShare.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsPlayerKillShare_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsPlayerKillShare_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsPlayerKillShare_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

