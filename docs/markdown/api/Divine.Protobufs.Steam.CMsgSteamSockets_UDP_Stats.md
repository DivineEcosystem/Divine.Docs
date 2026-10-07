# <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_Stats"></a> Class CMsgSteamSockets\_UDP\_Stats

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamSockets_UDP_Stats : IMessage<CMsgSteamSockets_UDP_Stats>, IEquatable<CMsgSteamSockets_UDP_Stats>, IDeepCloneable<CMsgSteamSockets_UDP_Stats>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamSockets\_UDP\_Stats](Divine.Protobufs.Steam.CMsgSteamSockets\_UDP\_Stats.md)

#### Implements

IMessage<CMsgSteamSockets\_UDP\_Stats\>, 
[IEquatable<CMsgSteamSockets\_UDP\_Stats\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamSockets\_UDP\_Stats\>, 
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
[EnumerableExtensions.In<CMsgSteamSockets\_UDP\_Stats\>\(CMsgSteamSockets\_UDP\_Stats, params CMsgSteamSockets\_UDP\_Stats\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_Stats__ctor"></a> CMsgSteamSockets\_UDP\_Stats\(\)

```csharp
public CMsgSteamSockets_UDP_Stats()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_Stats__ctor_Divine_Protobufs_Steam_CMsgSteamSockets_UDP_Stats_"></a> CMsgSteamSockets\_UDP\_Stats\(CMsgSteamSockets\_UDP\_Stats\)

```csharp
public CMsgSteamSockets_UDP_Stats(CMsgSteamSockets_UDP_Stats other)
```

#### Parameters

`other` [CMsgSteamSockets\_UDP\_Stats](Divine.Protobufs.Steam.CMsgSteamSockets\_UDP\_Stats.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_Stats_FlagsFieldNumber"></a> FlagsFieldNumber

```csharp
public const int FlagsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_Stats_StatsFieldNumber"></a> StatsFieldNumber

```csharp
public const int StatsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_Stats_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_Stats_Flags"></a> Flags

```csharp
public uint Flags { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_Stats_HasFlags"></a> HasFlags

```csharp
public bool HasFlags { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_Stats_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamSockets_UDP_Stats> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamSockets\_UDP\_Stats](Divine.Protobufs.Steam.CMsgSteamSockets\_UDP\_Stats.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_Stats_Stats"></a> Stats

```csharp
public CMsgSteamDatagramConnectionQuality Stats { get; set; }
```

#### Property Value

 [CMsgSteamDatagramConnectionQuality](Divine.Protobufs.Steam.CMsgSteamDatagramConnectionQuality.md)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_Stats_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_Stats_ClearFlags"></a> ClearFlags\(\)

```csharp
public void ClearFlags()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_Stats_Clone"></a> Clone\(\)

```csharp
public CMsgSteamSockets_UDP_Stats Clone()
```

#### Returns

 [CMsgSteamSockets\_UDP\_Stats](Divine.Protobufs.Steam.CMsgSteamSockets\_UDP\_Stats.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_Stats_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_Stats_Equals_Divine_Protobufs_Steam_CMsgSteamSockets_UDP_Stats_"></a> Equals\(CMsgSteamSockets\_UDP\_Stats\)

```csharp
public bool Equals(CMsgSteamSockets_UDP_Stats other)
```

#### Parameters

`other` [CMsgSteamSockets\_UDP\_Stats](Divine.Protobufs.Steam.CMsgSteamSockets\_UDP\_Stats.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_Stats_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_Stats_MergeFrom_Divine_Protobufs_Steam_CMsgSteamSockets_UDP_Stats_"></a> MergeFrom\(CMsgSteamSockets\_UDP\_Stats\)

```csharp
public void MergeFrom(CMsgSteamSockets_UDP_Stats other)
```

#### Parameters

`other` [CMsgSteamSockets\_UDP\_Stats](Divine.Protobufs.Steam.CMsgSteamSockets\_UDP\_Stats.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_Stats_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_Stats_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamSockets_UDP_Stats_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

