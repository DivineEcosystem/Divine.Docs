# <a id="Divine_Protobufs_Steam_CPlayer_GetLastPlayedTimes_Response_Types_Game"></a> Class CPlayer\_GetLastPlayedTimes\_Response.Types.Game

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CPlayer_GetLastPlayedTimes_Response.Types.Game : IMessage<CPlayer_GetLastPlayedTimes_Response.Types.Game>, IEquatable<CPlayer_GetLastPlayedTimes_Response.Types.Game>, IDeepCloneable<CPlayer_GetLastPlayedTimes_Response.Types.Game>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CPlayer\_GetLastPlayedTimes\_Response.Types.Game](Divine.Protobufs.Steam.CPlayer\_GetLastPlayedTimes\_Response.Types.Game.md)

#### Implements

IMessage<CPlayer\_GetLastPlayedTimes\_Response.Types.Game\>, 
[IEquatable<CPlayer\_GetLastPlayedTimes\_Response.Types.Game\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CPlayer\_GetLastPlayedTimes\_Response.Types.Game\>, 
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
[EnumerableExtensions.In<CPlayer\_GetLastPlayedTimes\_Response.Types.Game\>\(CPlayer\_GetLastPlayedTimes\_Response.Types.Game, params CPlayer\_GetLastPlayedTimes\_Response.Types.Game\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CPlayer_GetLastPlayedTimes_Response_Types_Game__ctor"></a> Game\(\)

```csharp
public Game()
```

### <a id="Divine_Protobufs_Steam_CPlayer_GetLastPlayedTimes_Response_Types_Game__ctor_Divine_Protobufs_Steam_CPlayer_GetLastPlayedTimes_Response_Types_Game_"></a> Game\(Game\)

```csharp
public Game(CPlayer_GetLastPlayedTimes_Response.Types.Game other)
```

#### Parameters

`other` [CPlayer\_GetLastPlayedTimes\_Response](Divine.Protobufs.Steam.CPlayer\_GetLastPlayedTimes\_Response.md).[Types](Divine.Protobufs.Steam.CPlayer\_GetLastPlayedTimes\_Response.Types.md).[Game](Divine.Protobufs.Steam.CPlayer\_GetLastPlayedTimes\_Response.Types.Game.md)

## Fields

### <a id="Divine_Protobufs_Steam_CPlayer_GetLastPlayedTimes_Response_Types_Game_AppidFieldNumber"></a> AppidFieldNumber

```csharp
public const int AppidFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPlayer_GetLastPlayedTimes_Response_Types_Game_FirstPlaytimeFieldNumber"></a> FirstPlaytimeFieldNumber

```csharp
public const int FirstPlaytimeFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPlayer_GetLastPlayedTimes_Response_Types_Game_LastPlaytimeFieldNumber"></a> LastPlaytimeFieldNumber

```csharp
public const int LastPlaytimeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPlayer_GetLastPlayedTimes_Response_Types_Game_Playtime2WeeksFieldNumber"></a> Playtime2WeeksFieldNumber

```csharp
public const int Playtime2WeeksFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPlayer_GetLastPlayedTimes_Response_Types_Game_PlaytimeForeverFieldNumber"></a> PlaytimeForeverFieldNumber

```csharp
public const int PlaytimeForeverFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CPlayer_GetLastPlayedTimes_Response_Types_Game_Appid"></a> Appid

```csharp
public int Appid { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPlayer_GetLastPlayedTimes_Response_Types_Game_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CPlayer_GetLastPlayedTimes_Response_Types_Game_FirstPlaytime"></a> FirstPlaytime

```csharp
public uint FirstPlaytime { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CPlayer_GetLastPlayedTimes_Response_Types_Game_HasAppid"></a> HasAppid

```csharp
public bool HasAppid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPlayer_GetLastPlayedTimes_Response_Types_Game_HasFirstPlaytime"></a> HasFirstPlaytime

```csharp
public bool HasFirstPlaytime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPlayer_GetLastPlayedTimes_Response_Types_Game_HasLastPlaytime"></a> HasLastPlaytime

```csharp
public bool HasLastPlaytime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPlayer_GetLastPlayedTimes_Response_Types_Game_HasPlaytime2Weeks"></a> HasPlaytime2Weeks

```csharp
public bool HasPlaytime2Weeks { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPlayer_GetLastPlayedTimes_Response_Types_Game_HasPlaytimeForever"></a> HasPlaytimeForever

```csharp
public bool HasPlaytimeForever { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPlayer_GetLastPlayedTimes_Response_Types_Game_LastPlaytime"></a> LastPlaytime

```csharp
public uint LastPlaytime { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CPlayer_GetLastPlayedTimes_Response_Types_Game_Parser"></a> Parser

```csharp
public static MessageParser<CPlayer_GetLastPlayedTimes_Response.Types.Game> Parser { get; }
```

#### Property Value

 MessageParser<[CPlayer\_GetLastPlayedTimes\_Response](Divine.Protobufs.Steam.CPlayer\_GetLastPlayedTimes\_Response.md).[Types](Divine.Protobufs.Steam.CPlayer\_GetLastPlayedTimes\_Response.Types.md).[Game](Divine.Protobufs.Steam.CPlayer\_GetLastPlayedTimes\_Response.Types.Game.md)\>

### <a id="Divine_Protobufs_Steam_CPlayer_GetLastPlayedTimes_Response_Types_Game_Playtime2Weeks"></a> Playtime2Weeks

```csharp
public int Playtime2Weeks { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPlayer_GetLastPlayedTimes_Response_Types_Game_PlaytimeForever"></a> PlaytimeForever

```csharp
public int PlaytimeForever { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Steam_CPlayer_GetLastPlayedTimes_Response_Types_Game_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPlayer_GetLastPlayedTimes_Response_Types_Game_ClearAppid"></a> ClearAppid\(\)

```csharp
public void ClearAppid()
```

### <a id="Divine_Protobufs_Steam_CPlayer_GetLastPlayedTimes_Response_Types_Game_ClearFirstPlaytime"></a> ClearFirstPlaytime\(\)

```csharp
public void ClearFirstPlaytime()
```

### <a id="Divine_Protobufs_Steam_CPlayer_GetLastPlayedTimes_Response_Types_Game_ClearLastPlaytime"></a> ClearLastPlaytime\(\)

```csharp
public void ClearLastPlaytime()
```

### <a id="Divine_Protobufs_Steam_CPlayer_GetLastPlayedTimes_Response_Types_Game_ClearPlaytime2Weeks"></a> ClearPlaytime2Weeks\(\)

```csharp
public void ClearPlaytime2Weeks()
```

### <a id="Divine_Protobufs_Steam_CPlayer_GetLastPlayedTimes_Response_Types_Game_ClearPlaytimeForever"></a> ClearPlaytimeForever\(\)

```csharp
public void ClearPlaytimeForever()
```

### <a id="Divine_Protobufs_Steam_CPlayer_GetLastPlayedTimes_Response_Types_Game_Clone"></a> Clone\(\)

```csharp
public CPlayer_GetLastPlayedTimes_Response.Types.Game Clone()
```

#### Returns

 [CPlayer\_GetLastPlayedTimes\_Response](Divine.Protobufs.Steam.CPlayer\_GetLastPlayedTimes\_Response.md).[Types](Divine.Protobufs.Steam.CPlayer\_GetLastPlayedTimes\_Response.Types.md).[Game](Divine.Protobufs.Steam.CPlayer\_GetLastPlayedTimes\_Response.Types.Game.md)

### <a id="Divine_Protobufs_Steam_CPlayer_GetLastPlayedTimes_Response_Types_Game_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPlayer_GetLastPlayedTimes_Response_Types_Game_Equals_Divine_Protobufs_Steam_CPlayer_GetLastPlayedTimes_Response_Types_Game_"></a> Equals\(Game\)

```csharp
public bool Equals(CPlayer_GetLastPlayedTimes_Response.Types.Game other)
```

#### Parameters

`other` [CPlayer\_GetLastPlayedTimes\_Response](Divine.Protobufs.Steam.CPlayer\_GetLastPlayedTimes\_Response.md).[Types](Divine.Protobufs.Steam.CPlayer\_GetLastPlayedTimes\_Response.Types.md).[Game](Divine.Protobufs.Steam.CPlayer\_GetLastPlayedTimes\_Response.Types.Game.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPlayer_GetLastPlayedTimes_Response_Types_Game_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPlayer_GetLastPlayedTimes_Response_Types_Game_MergeFrom_Divine_Protobufs_Steam_CPlayer_GetLastPlayedTimes_Response_Types_Game_"></a> MergeFrom\(Game\)

```csharp
public void MergeFrom(CPlayer_GetLastPlayedTimes_Response.Types.Game other)
```

#### Parameters

`other` [CPlayer\_GetLastPlayedTimes\_Response](Divine.Protobufs.Steam.CPlayer\_GetLastPlayedTimes\_Response.md).[Types](Divine.Protobufs.Steam.CPlayer\_GetLastPlayedTimes\_Response.Types.md).[Game](Divine.Protobufs.Steam.CPlayer\_GetLastPlayedTimes\_Response.Types.Game.md)

### <a id="Divine_Protobufs_Steam_CPlayer_GetLastPlayedTimes_Response_Types_Game_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CPlayer_GetLastPlayedTimes_Response_Types_Game_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CPlayer_GetLastPlayedTimes_Response_Types_Game_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

