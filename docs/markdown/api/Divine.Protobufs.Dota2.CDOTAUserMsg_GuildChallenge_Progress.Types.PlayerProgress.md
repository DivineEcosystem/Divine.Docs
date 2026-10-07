# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GuildChallenge_Progress_Types_PlayerProgress"></a> Class CDOTAUserMsg\_GuildChallenge\_Progress.Types.PlayerProgress

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_GuildChallenge_Progress.Types.PlayerProgress : IMessage<CDOTAUserMsg_GuildChallenge_Progress.Types.PlayerProgress>, IEquatable<CDOTAUserMsg_GuildChallenge_Progress.Types.PlayerProgress>, IDeepCloneable<CDOTAUserMsg_GuildChallenge_Progress.Types.PlayerProgress>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_GuildChallenge\_Progress.Types.PlayerProgress](Divine.Protobufs.Dota2.CDOTAUserMsg\_GuildChallenge\_Progress.Types.PlayerProgress.md)

#### Implements

IMessage<CDOTAUserMsg\_GuildChallenge\_Progress.Types.PlayerProgress\>, 
[IEquatable<CDOTAUserMsg\_GuildChallenge\_Progress.Types.PlayerProgress\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_GuildChallenge\_Progress.Types.PlayerProgress\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_GuildChallenge\_Progress.Types.PlayerProgress\>\(CDOTAUserMsg\_GuildChallenge\_Progress.Types.PlayerProgress, params CDOTAUserMsg\_GuildChallenge\_Progress.Types.PlayerProgress\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GuildChallenge_Progress_Types_PlayerProgress__ctor"></a> PlayerProgress\(\)

```csharp
public PlayerProgress()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GuildChallenge_Progress_Types_PlayerProgress__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_GuildChallenge_Progress_Types_PlayerProgress_"></a> PlayerProgress\(PlayerProgress\)

```csharp
public PlayerProgress(CDOTAUserMsg_GuildChallenge_Progress.Types.PlayerProgress other)
```

#### Parameters

`other` [CDOTAUserMsg\_GuildChallenge\_Progress](Divine.Protobufs.Dota2.CDOTAUserMsg\_GuildChallenge\_Progress.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_GuildChallenge\_Progress.Types.md).[PlayerProgress](Divine.Protobufs.Dota2.CDOTAUserMsg\_GuildChallenge\_Progress.Types.PlayerProgress.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GuildChallenge_Progress_Types_PlayerProgress_PlayerIdFieldNumber"></a> PlayerIdFieldNumber

```csharp
public const int PlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GuildChallenge_Progress_Types_PlayerProgress_ProgressFieldNumber"></a> ProgressFieldNumber

```csharp
public const int ProgressFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GuildChallenge_Progress_Types_PlayerProgress_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GuildChallenge_Progress_Types_PlayerProgress_HasPlayerId"></a> HasPlayerId

```csharp
public bool HasPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GuildChallenge_Progress_Types_PlayerProgress_HasProgress"></a> HasProgress

```csharp
public bool HasProgress { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GuildChallenge_Progress_Types_PlayerProgress_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_GuildChallenge_Progress.Types.PlayerProgress> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_GuildChallenge\_Progress](Divine.Protobufs.Dota2.CDOTAUserMsg\_GuildChallenge\_Progress.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_GuildChallenge\_Progress.Types.md).[PlayerProgress](Divine.Protobufs.Dota2.CDOTAUserMsg\_GuildChallenge\_Progress.Types.PlayerProgress.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GuildChallenge_Progress_Types_PlayerProgress_PlayerId"></a> PlayerId

```csharp
public int PlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GuildChallenge_Progress_Types_PlayerProgress_Progress"></a> Progress

```csharp
public uint Progress { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GuildChallenge_Progress_Types_PlayerProgress_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GuildChallenge_Progress_Types_PlayerProgress_ClearPlayerId"></a> ClearPlayerId\(\)

```csharp
public void ClearPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GuildChallenge_Progress_Types_PlayerProgress_ClearProgress"></a> ClearProgress\(\)

```csharp
public void ClearProgress()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GuildChallenge_Progress_Types_PlayerProgress_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_GuildChallenge_Progress.Types.PlayerProgress Clone()
```

#### Returns

 [CDOTAUserMsg\_GuildChallenge\_Progress](Divine.Protobufs.Dota2.CDOTAUserMsg\_GuildChallenge\_Progress.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_GuildChallenge\_Progress.Types.md).[PlayerProgress](Divine.Protobufs.Dota2.CDOTAUserMsg\_GuildChallenge\_Progress.Types.PlayerProgress.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GuildChallenge_Progress_Types_PlayerProgress_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GuildChallenge_Progress_Types_PlayerProgress_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_GuildChallenge_Progress_Types_PlayerProgress_"></a> Equals\(PlayerProgress\)

```csharp
public bool Equals(CDOTAUserMsg_GuildChallenge_Progress.Types.PlayerProgress other)
```

#### Parameters

`other` [CDOTAUserMsg\_GuildChallenge\_Progress](Divine.Protobufs.Dota2.CDOTAUserMsg\_GuildChallenge\_Progress.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_GuildChallenge\_Progress.Types.md).[PlayerProgress](Divine.Protobufs.Dota2.CDOTAUserMsg\_GuildChallenge\_Progress.Types.PlayerProgress.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GuildChallenge_Progress_Types_PlayerProgress_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GuildChallenge_Progress_Types_PlayerProgress_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_GuildChallenge_Progress_Types_PlayerProgress_"></a> MergeFrom\(PlayerProgress\)

```csharp
public void MergeFrom(CDOTAUserMsg_GuildChallenge_Progress.Types.PlayerProgress other)
```

#### Parameters

`other` [CDOTAUserMsg\_GuildChallenge\_Progress](Divine.Protobufs.Dota2.CDOTAUserMsg\_GuildChallenge\_Progress.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_GuildChallenge\_Progress.Types.md).[PlayerProgress](Divine.Protobufs.Dota2.CDOTAUserMsg\_GuildChallenge\_Progress.Types.PlayerProgress.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GuildChallenge_Progress_Types_PlayerProgress_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GuildChallenge_Progress_Types_PlayerProgress_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GuildChallenge_Progress_Types_PlayerProgress_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

