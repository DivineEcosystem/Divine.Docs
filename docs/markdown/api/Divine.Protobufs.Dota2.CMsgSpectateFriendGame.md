# <a id="Divine_Protobufs_Dota2_CMsgSpectateFriendGame"></a> Class CMsgSpectateFriendGame

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSpectateFriendGame : IMessage<CMsgSpectateFriendGame>, IEquatable<CMsgSpectateFriendGame>, IDeepCloneable<CMsgSpectateFriendGame>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSpectateFriendGame](Divine.Protobufs.Dota2.CMsgSpectateFriendGame.md)

#### Implements

IMessage<CMsgSpectateFriendGame\>, 
[IEquatable<CMsgSpectateFriendGame\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSpectateFriendGame\>, 
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
[EnumerableExtensions.In<CMsgSpectateFriendGame\>\(CMsgSpectateFriendGame, params CMsgSpectateFriendGame\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSpectateFriendGame__ctor"></a> CMsgSpectateFriendGame\(\)

```csharp
public CMsgSpectateFriendGame()
```

### <a id="Divine_Protobufs_Dota2_CMsgSpectateFriendGame__ctor_Divine_Protobufs_Dota2_CMsgSpectateFriendGame_"></a> CMsgSpectateFriendGame\(CMsgSpectateFriendGame\)

```csharp
public CMsgSpectateFriendGame(CMsgSpectateFriendGame other)
```

#### Parameters

`other` [CMsgSpectateFriendGame](Divine.Protobufs.Dota2.CMsgSpectateFriendGame.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSpectateFriendGame_LiveFieldNumber"></a> LiveFieldNumber

```csharp
public const int LiveFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSpectateFriendGame_SteamIdFieldNumber"></a> SteamIdFieldNumber

```csharp
public const int SteamIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSpectateFriendGame_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSpectateFriendGame_HasLive"></a> HasLive

```csharp
public bool HasLive { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSpectateFriendGame_HasSteamId"></a> HasSteamId

```csharp
public bool HasSteamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSpectateFriendGame_Live"></a> Live

```csharp
public bool Live { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSpectateFriendGame_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSpectateFriendGame> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSpectateFriendGame](Divine.Protobufs.Dota2.CMsgSpectateFriendGame.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSpectateFriendGame_SteamId"></a> SteamId

```csharp
public ulong SteamId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSpectateFriendGame_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSpectateFriendGame_ClearLive"></a> ClearLive\(\)

```csharp
public void ClearLive()
```

### <a id="Divine_Protobufs_Dota2_CMsgSpectateFriendGame_ClearSteamId"></a> ClearSteamId\(\)

```csharp
public void ClearSteamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSpectateFriendGame_Clone"></a> Clone\(\)

```csharp
public CMsgSpectateFriendGame Clone()
```

#### Returns

 [CMsgSpectateFriendGame](Divine.Protobufs.Dota2.CMsgSpectateFriendGame.md)

### <a id="Divine_Protobufs_Dota2_CMsgSpectateFriendGame_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSpectateFriendGame_Equals_Divine_Protobufs_Dota2_CMsgSpectateFriendGame_"></a> Equals\(CMsgSpectateFriendGame\)

```csharp
public bool Equals(CMsgSpectateFriendGame other)
```

#### Parameters

`other` [CMsgSpectateFriendGame](Divine.Protobufs.Dota2.CMsgSpectateFriendGame.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSpectateFriendGame_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSpectateFriendGame_MergeFrom_Divine_Protobufs_Dota2_CMsgSpectateFriendGame_"></a> MergeFrom\(CMsgSpectateFriendGame\)

```csharp
public void MergeFrom(CMsgSpectateFriendGame other)
```

#### Parameters

`other` [CMsgSpectateFriendGame](Divine.Protobufs.Dota2.CMsgSpectateFriendGame.md)

### <a id="Divine_Protobufs_Dota2_CMsgSpectateFriendGame_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSpectateFriendGame_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSpectateFriendGame_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

