# <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportStampedPlayer"></a> Class CMsgDOTAPassportStampedPlayer

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAPassportStampedPlayer : IMessage<CMsgDOTAPassportStampedPlayer>, IEquatable<CMsgDOTAPassportStampedPlayer>, IDeepCloneable<CMsgDOTAPassportStampedPlayer>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAPassportStampedPlayer](Divine.Protobufs.Dota2.CMsgDOTAPassportStampedPlayer.md)

#### Implements

IMessage<CMsgDOTAPassportStampedPlayer\>, 
[IEquatable<CMsgDOTAPassportStampedPlayer\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAPassportStampedPlayer\>, 
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
[EnumerableExtensions.In<CMsgDOTAPassportStampedPlayer\>\(CMsgDOTAPassportStampedPlayer, params CMsgDOTAPassportStampedPlayer\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportStampedPlayer__ctor"></a> CMsgDOTAPassportStampedPlayer\(\)

```csharp
public CMsgDOTAPassportStampedPlayer()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportStampedPlayer__ctor_Divine_Protobufs_Dota2_CMsgDOTAPassportStampedPlayer_"></a> CMsgDOTAPassportStampedPlayer\(CMsgDOTAPassportStampedPlayer\)

```csharp
public CMsgDOTAPassportStampedPlayer(CMsgDOTAPassportStampedPlayer other)
```

#### Parameters

`other` [CMsgDOTAPassportStampedPlayer](Divine.Protobufs.Dota2.CMsgDOTAPassportStampedPlayer.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportStampedPlayer_StampLevelFieldNumber"></a> StampLevelFieldNumber

```csharp
public const int StampLevelFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportStampedPlayer_SteamIdFieldNumber"></a> SteamIdFieldNumber

```csharp
public const int SteamIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportStampedPlayer_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportStampedPlayer_HasStampLevel"></a> HasStampLevel

```csharp
public bool HasStampLevel { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportStampedPlayer_HasSteamId"></a> HasSteamId

```csharp
public bool HasSteamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportStampedPlayer_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAPassportStampedPlayer> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAPassportStampedPlayer](Divine.Protobufs.Dota2.CMsgDOTAPassportStampedPlayer.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportStampedPlayer_StampLevel"></a> StampLevel

```csharp
public uint StampLevel { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportStampedPlayer_SteamId"></a> SteamId

```csharp
public ulong SteamId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportStampedPlayer_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportStampedPlayer_ClearStampLevel"></a> ClearStampLevel\(\)

```csharp
public void ClearStampLevel()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportStampedPlayer_ClearSteamId"></a> ClearSteamId\(\)

```csharp
public void ClearSteamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportStampedPlayer_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAPassportStampedPlayer Clone()
```

#### Returns

 [CMsgDOTAPassportStampedPlayer](Divine.Protobufs.Dota2.CMsgDOTAPassportStampedPlayer.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportStampedPlayer_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportStampedPlayer_Equals_Divine_Protobufs_Dota2_CMsgDOTAPassportStampedPlayer_"></a> Equals\(CMsgDOTAPassportStampedPlayer\)

```csharp
public bool Equals(CMsgDOTAPassportStampedPlayer other)
```

#### Parameters

`other` [CMsgDOTAPassportStampedPlayer](Divine.Protobufs.Dota2.CMsgDOTAPassportStampedPlayer.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportStampedPlayer_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportStampedPlayer_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAPassportStampedPlayer_"></a> MergeFrom\(CMsgDOTAPassportStampedPlayer\)

```csharp
public void MergeFrom(CMsgDOTAPassportStampedPlayer other)
```

#### Parameters

`other` [CMsgDOTAPassportStampedPlayer](Divine.Protobufs.Dota2.CMsgDOTAPassportStampedPlayer.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportStampedPlayer_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportStampedPlayer_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportStampedPlayer_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

