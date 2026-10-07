# <a id="Divine_Protobufs_Dota2_CMsgPartyLeaderWatchGamePrompt"></a> Class CMsgPartyLeaderWatchGamePrompt

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgPartyLeaderWatchGamePrompt : IMessage<CMsgPartyLeaderWatchGamePrompt>, IEquatable<CMsgPartyLeaderWatchGamePrompt>, IDeepCloneable<CMsgPartyLeaderWatchGamePrompt>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgPartyLeaderWatchGamePrompt](Divine.Protobufs.Dota2.CMsgPartyLeaderWatchGamePrompt.md)

#### Implements

IMessage<CMsgPartyLeaderWatchGamePrompt\>, 
[IEquatable<CMsgPartyLeaderWatchGamePrompt\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgPartyLeaderWatchGamePrompt\>, 
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
[EnumerableExtensions.In<CMsgPartyLeaderWatchGamePrompt\>\(CMsgPartyLeaderWatchGamePrompt, params CMsgPartyLeaderWatchGamePrompt\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgPartyLeaderWatchGamePrompt__ctor"></a> CMsgPartyLeaderWatchGamePrompt\(\)

```csharp
public CMsgPartyLeaderWatchGamePrompt()
```

### <a id="Divine_Protobufs_Dota2_CMsgPartyLeaderWatchGamePrompt__ctor_Divine_Protobufs_Dota2_CMsgPartyLeaderWatchGamePrompt_"></a> CMsgPartyLeaderWatchGamePrompt\(CMsgPartyLeaderWatchGamePrompt\)

```csharp
public CMsgPartyLeaderWatchGamePrompt(CMsgPartyLeaderWatchGamePrompt other)
```

#### Parameters

`other` [CMsgPartyLeaderWatchGamePrompt](Divine.Protobufs.Dota2.CMsgPartyLeaderWatchGamePrompt.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgPartyLeaderWatchGamePrompt_GameServerSteamidFieldNumber"></a> GameServerSteamidFieldNumber

```csharp
public const int GameServerSteamidFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgPartyLeaderWatchGamePrompt_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgPartyLeaderWatchGamePrompt_GameServerSteamid"></a> GameServerSteamid

```csharp
public ulong GameServerSteamid { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgPartyLeaderWatchGamePrompt_HasGameServerSteamid"></a> HasGameServerSteamid

```csharp
public bool HasGameServerSteamid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPartyLeaderWatchGamePrompt_Parser"></a> Parser

```csharp
public static MessageParser<CMsgPartyLeaderWatchGamePrompt> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgPartyLeaderWatchGamePrompt](Divine.Protobufs.Dota2.CMsgPartyLeaderWatchGamePrompt.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgPartyLeaderWatchGamePrompt_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPartyLeaderWatchGamePrompt_ClearGameServerSteamid"></a> ClearGameServerSteamid\(\)

```csharp
public void ClearGameServerSteamid()
```

### <a id="Divine_Protobufs_Dota2_CMsgPartyLeaderWatchGamePrompt_Clone"></a> Clone\(\)

```csharp
public CMsgPartyLeaderWatchGamePrompt Clone()
```

#### Returns

 [CMsgPartyLeaderWatchGamePrompt](Divine.Protobufs.Dota2.CMsgPartyLeaderWatchGamePrompt.md)

### <a id="Divine_Protobufs_Dota2_CMsgPartyLeaderWatchGamePrompt_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPartyLeaderWatchGamePrompt_Equals_Divine_Protobufs_Dota2_CMsgPartyLeaderWatchGamePrompt_"></a> Equals\(CMsgPartyLeaderWatchGamePrompt\)

```csharp
public bool Equals(CMsgPartyLeaderWatchGamePrompt other)
```

#### Parameters

`other` [CMsgPartyLeaderWatchGamePrompt](Divine.Protobufs.Dota2.CMsgPartyLeaderWatchGamePrompt.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPartyLeaderWatchGamePrompt_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPartyLeaderWatchGamePrompt_MergeFrom_Divine_Protobufs_Dota2_CMsgPartyLeaderWatchGamePrompt_"></a> MergeFrom\(CMsgPartyLeaderWatchGamePrompt\)

```csharp
public void MergeFrom(CMsgPartyLeaderWatchGamePrompt other)
```

#### Parameters

`other` [CMsgPartyLeaderWatchGamePrompt](Divine.Protobufs.Dota2.CMsgPartyLeaderWatchGamePrompt.md)

### <a id="Divine_Protobufs_Dota2_CMsgPartyLeaderWatchGamePrompt_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgPartyLeaderWatchGamePrompt_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgPartyLeaderWatchGamePrompt_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

