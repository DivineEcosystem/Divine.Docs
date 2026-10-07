# <a id="Divine_Protobufs_Steam_CPlayer_GetGameBadgeLevels_Response_Types_Badge"></a> Class CPlayer\_GetGameBadgeLevels\_Response.Types.Badge

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CPlayer_GetGameBadgeLevels_Response.Types.Badge : IMessage<CPlayer_GetGameBadgeLevels_Response.Types.Badge>, IEquatable<CPlayer_GetGameBadgeLevels_Response.Types.Badge>, IDeepCloneable<CPlayer_GetGameBadgeLevels_Response.Types.Badge>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CPlayer\_GetGameBadgeLevels\_Response.Types.Badge](Divine.Protobufs.Steam.CPlayer\_GetGameBadgeLevels\_Response.Types.Badge.md)

#### Implements

IMessage<CPlayer\_GetGameBadgeLevels\_Response.Types.Badge\>, 
[IEquatable<CPlayer\_GetGameBadgeLevels\_Response.Types.Badge\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CPlayer\_GetGameBadgeLevels\_Response.Types.Badge\>, 
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
[EnumerableExtensions.In<CPlayer\_GetGameBadgeLevels\_Response.Types.Badge\>\(CPlayer\_GetGameBadgeLevels\_Response.Types.Badge, params CPlayer\_GetGameBadgeLevels\_Response.Types.Badge\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CPlayer_GetGameBadgeLevels_Response_Types_Badge__ctor"></a> Badge\(\)

```csharp
public Badge()
```

### <a id="Divine_Protobufs_Steam_CPlayer_GetGameBadgeLevels_Response_Types_Badge__ctor_Divine_Protobufs_Steam_CPlayer_GetGameBadgeLevels_Response_Types_Badge_"></a> Badge\(Badge\)

```csharp
public Badge(CPlayer_GetGameBadgeLevels_Response.Types.Badge other)
```

#### Parameters

`other` [CPlayer\_GetGameBadgeLevels\_Response](Divine.Protobufs.Steam.CPlayer\_GetGameBadgeLevels\_Response.md).[Types](Divine.Protobufs.Steam.CPlayer\_GetGameBadgeLevels\_Response.Types.md).[Badge](Divine.Protobufs.Steam.CPlayer\_GetGameBadgeLevels\_Response.Types.Badge.md)

## Fields

### <a id="Divine_Protobufs_Steam_CPlayer_GetGameBadgeLevels_Response_Types_Badge_BorderColorFieldNumber"></a> BorderColorFieldNumber

```csharp
public const int BorderColorFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPlayer_GetGameBadgeLevels_Response_Types_Badge_LevelFieldNumber"></a> LevelFieldNumber

```csharp
public const int LevelFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPlayer_GetGameBadgeLevels_Response_Types_Badge_SeriesFieldNumber"></a> SeriesFieldNumber

```csharp
public const int SeriesFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CPlayer_GetGameBadgeLevels_Response_Types_Badge_BorderColor"></a> BorderColor

```csharp
public uint BorderColor { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CPlayer_GetGameBadgeLevels_Response_Types_Badge_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CPlayer_GetGameBadgeLevels_Response_Types_Badge_HasBorderColor"></a> HasBorderColor

```csharp
public bool HasBorderColor { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPlayer_GetGameBadgeLevels_Response_Types_Badge_HasLevel"></a> HasLevel

```csharp
public bool HasLevel { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPlayer_GetGameBadgeLevels_Response_Types_Badge_HasSeries"></a> HasSeries

```csharp
public bool HasSeries { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPlayer_GetGameBadgeLevels_Response_Types_Badge_Level"></a> Level

```csharp
public int Level { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPlayer_GetGameBadgeLevels_Response_Types_Badge_Parser"></a> Parser

```csharp
public static MessageParser<CPlayer_GetGameBadgeLevels_Response.Types.Badge> Parser { get; }
```

#### Property Value

 MessageParser<[CPlayer\_GetGameBadgeLevels\_Response](Divine.Protobufs.Steam.CPlayer\_GetGameBadgeLevels\_Response.md).[Types](Divine.Protobufs.Steam.CPlayer\_GetGameBadgeLevels\_Response.Types.md).[Badge](Divine.Protobufs.Steam.CPlayer\_GetGameBadgeLevels\_Response.Types.Badge.md)\>

### <a id="Divine_Protobufs_Steam_CPlayer_GetGameBadgeLevels_Response_Types_Badge_Series"></a> Series

```csharp
public int Series { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Steam_CPlayer_GetGameBadgeLevels_Response_Types_Badge_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPlayer_GetGameBadgeLevels_Response_Types_Badge_ClearBorderColor"></a> ClearBorderColor\(\)

```csharp
public void ClearBorderColor()
```

### <a id="Divine_Protobufs_Steam_CPlayer_GetGameBadgeLevels_Response_Types_Badge_ClearLevel"></a> ClearLevel\(\)

```csharp
public void ClearLevel()
```

### <a id="Divine_Protobufs_Steam_CPlayer_GetGameBadgeLevels_Response_Types_Badge_ClearSeries"></a> ClearSeries\(\)

```csharp
public void ClearSeries()
```

### <a id="Divine_Protobufs_Steam_CPlayer_GetGameBadgeLevels_Response_Types_Badge_Clone"></a> Clone\(\)

```csharp
public CPlayer_GetGameBadgeLevels_Response.Types.Badge Clone()
```

#### Returns

 [CPlayer\_GetGameBadgeLevels\_Response](Divine.Protobufs.Steam.CPlayer\_GetGameBadgeLevels\_Response.md).[Types](Divine.Protobufs.Steam.CPlayer\_GetGameBadgeLevels\_Response.Types.md).[Badge](Divine.Protobufs.Steam.CPlayer\_GetGameBadgeLevels\_Response.Types.Badge.md)

### <a id="Divine_Protobufs_Steam_CPlayer_GetGameBadgeLevels_Response_Types_Badge_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPlayer_GetGameBadgeLevels_Response_Types_Badge_Equals_Divine_Protobufs_Steam_CPlayer_GetGameBadgeLevels_Response_Types_Badge_"></a> Equals\(Badge\)

```csharp
public bool Equals(CPlayer_GetGameBadgeLevels_Response.Types.Badge other)
```

#### Parameters

`other` [CPlayer\_GetGameBadgeLevels\_Response](Divine.Protobufs.Steam.CPlayer\_GetGameBadgeLevels\_Response.md).[Types](Divine.Protobufs.Steam.CPlayer\_GetGameBadgeLevels\_Response.Types.md).[Badge](Divine.Protobufs.Steam.CPlayer\_GetGameBadgeLevels\_Response.Types.Badge.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CPlayer_GetGameBadgeLevels_Response_Types_Badge_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CPlayer_GetGameBadgeLevels_Response_Types_Badge_MergeFrom_Divine_Protobufs_Steam_CPlayer_GetGameBadgeLevels_Response_Types_Badge_"></a> MergeFrom\(Badge\)

```csharp
public void MergeFrom(CPlayer_GetGameBadgeLevels_Response.Types.Badge other)
```

#### Parameters

`other` [CPlayer\_GetGameBadgeLevels\_Response](Divine.Protobufs.Steam.CPlayer\_GetGameBadgeLevels\_Response.md).[Types](Divine.Protobufs.Steam.CPlayer\_GetGameBadgeLevels\_Response.Types.md).[Badge](Divine.Protobufs.Steam.CPlayer\_GetGameBadgeLevels\_Response.Types.Badge.md)

### <a id="Divine_Protobufs_Steam_CPlayer_GetGameBadgeLevels_Response_Types_Badge_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CPlayer_GetGameBadgeLevels_Response_Types_Badge_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CPlayer_GetGameBadgeLevels_Response_Types_Badge_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

