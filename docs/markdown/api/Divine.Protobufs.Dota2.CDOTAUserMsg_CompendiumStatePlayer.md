# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CompendiumStatePlayer"></a> Class CDOTAUserMsg\_CompendiumStatePlayer

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_CompendiumStatePlayer : IMessage<CDOTAUserMsg_CompendiumStatePlayer>, IEquatable<CDOTAUserMsg_CompendiumStatePlayer>, IDeepCloneable<CDOTAUserMsg_CompendiumStatePlayer>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_CompendiumStatePlayer](Divine.Protobufs.Dota2.CDOTAUserMsg\_CompendiumStatePlayer.md)

#### Implements

IMessage<CDOTAUserMsg\_CompendiumStatePlayer\>, 
[IEquatable<CDOTAUserMsg\_CompendiumStatePlayer\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_CompendiumStatePlayer\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_CompendiumStatePlayer\>\(CDOTAUserMsg\_CompendiumStatePlayer, params CDOTAUserMsg\_CompendiumStatePlayer\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CompendiumStatePlayer__ctor"></a> CDOTAUserMsg\_CompendiumStatePlayer\(\)

```csharp
public CDOTAUserMsg_CompendiumStatePlayer()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CompendiumStatePlayer__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_CompendiumStatePlayer_"></a> CDOTAUserMsg\_CompendiumStatePlayer\(CDOTAUserMsg\_CompendiumStatePlayer\)

```csharp
public CDOTAUserMsg_CompendiumStatePlayer(CDOTAUserMsg_CompendiumStatePlayer other)
```

#### Parameters

`other` [CDOTAUserMsg\_CompendiumStatePlayer](Divine.Protobufs.Dota2.CDOTAUserMsg\_CompendiumStatePlayer.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CompendiumStatePlayer_LevelFieldNumber"></a> LevelFieldNumber

```csharp
public const int LevelFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CompendiumStatePlayer_PlayerIdFieldNumber"></a> PlayerIdFieldNumber

```csharp
public const int PlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CompendiumStatePlayer_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CompendiumStatePlayer_HasLevel"></a> HasLevel

```csharp
public bool HasLevel { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CompendiumStatePlayer_HasPlayerId"></a> HasPlayerId

```csharp
public bool HasPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CompendiumStatePlayer_Level"></a> Level

```csharp
public uint Level { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CompendiumStatePlayer_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_CompendiumStatePlayer> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_CompendiumStatePlayer](Divine.Protobufs.Dota2.CDOTAUserMsg\_CompendiumStatePlayer.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CompendiumStatePlayer_PlayerId"></a> PlayerId

```csharp
public int PlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CompendiumStatePlayer_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CompendiumStatePlayer_ClearLevel"></a> ClearLevel\(\)

```csharp
public void ClearLevel()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CompendiumStatePlayer_ClearPlayerId"></a> ClearPlayerId\(\)

```csharp
public void ClearPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CompendiumStatePlayer_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_CompendiumStatePlayer Clone()
```

#### Returns

 [CDOTAUserMsg\_CompendiumStatePlayer](Divine.Protobufs.Dota2.CDOTAUserMsg\_CompendiumStatePlayer.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CompendiumStatePlayer_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CompendiumStatePlayer_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_CompendiumStatePlayer_"></a> Equals\(CDOTAUserMsg\_CompendiumStatePlayer\)

```csharp
public bool Equals(CDOTAUserMsg_CompendiumStatePlayer other)
```

#### Parameters

`other` [CDOTAUserMsg\_CompendiumStatePlayer](Divine.Protobufs.Dota2.CDOTAUserMsg\_CompendiumStatePlayer.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CompendiumStatePlayer_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CompendiumStatePlayer_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_CompendiumStatePlayer_"></a> MergeFrom\(CDOTAUserMsg\_CompendiumStatePlayer\)

```csharp
public void MergeFrom(CDOTAUserMsg_CompendiumStatePlayer other)
```

#### Parameters

`other` [CDOTAUserMsg\_CompendiumStatePlayer](Divine.Protobufs.Dota2.CDOTAUserMsg\_CompendiumStatePlayer.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CompendiumStatePlayer_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CompendiumStatePlayer_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CompendiumStatePlayer_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

