# <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_Types_RouterQuality"></a> Class CMsgSteamDatagramClientSwitchedPrimary.Types.RouterQuality

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamDatagramClientSwitchedPrimary.Types.RouterQuality : IMessage<CMsgSteamDatagramClientSwitchedPrimary.Types.RouterQuality>, IEquatable<CMsgSteamDatagramClientSwitchedPrimary.Types.RouterQuality>, IDeepCloneable<CMsgSteamDatagramClientSwitchedPrimary.Types.RouterQuality>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamDatagramClientSwitchedPrimary.Types.RouterQuality](Divine.Protobufs.Steam.CMsgSteamDatagramClientSwitchedPrimary.Types.RouterQuality.md)

#### Implements

IMessage<CMsgSteamDatagramClientSwitchedPrimary.Types.RouterQuality\>, 
[IEquatable<CMsgSteamDatagramClientSwitchedPrimary.Types.RouterQuality\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamDatagramClientSwitchedPrimary.Types.RouterQuality\>, 
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
[EnumerableExtensions.In<CMsgSteamDatagramClientSwitchedPrimary.Types.RouterQuality\>\(CMsgSteamDatagramClientSwitchedPrimary.Types.RouterQuality, params CMsgSteamDatagramClientSwitchedPrimary.Types.RouterQuality\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_Types_RouterQuality__ctor"></a> RouterQuality\(\)

```csharp
public RouterQuality()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_Types_RouterQuality__ctor_Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_Types_RouterQuality_"></a> RouterQuality\(RouterQuality\)

```csharp
public RouterQuality(CMsgSteamDatagramClientSwitchedPrimary.Types.RouterQuality other)
```

#### Parameters

`other` [CMsgSteamDatagramClientSwitchedPrimary](Divine.Protobufs.Steam.CMsgSteamDatagramClientSwitchedPrimary.md).[Types](Divine.Protobufs.Steam.CMsgSteamDatagramClientSwitchedPrimary.Types.md).[RouterQuality](Divine.Protobufs.Steam.CMsgSteamDatagramClientSwitchedPrimary.Types.RouterQuality.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_Types_RouterQuality_BackPingFieldNumber"></a> BackPingFieldNumber

```csharp
public const int BackPingFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_Types_RouterQuality_FrontPingFieldNumber"></a> FrontPingFieldNumber

```csharp
public const int FrontPingFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_Types_RouterQuality_ScoreFieldNumber"></a> ScoreFieldNumber

```csharp
public const int ScoreFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_Types_RouterQuality_SecondsUntilDownFieldNumber"></a> SecondsUntilDownFieldNumber

```csharp
public const int SecondsUntilDownFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_Types_RouterQuality_BackPing"></a> BackPing

```csharp
public uint BackPing { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_Types_RouterQuality_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_Types_RouterQuality_FrontPing"></a> FrontPing

```csharp
public uint FrontPing { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_Types_RouterQuality_HasBackPing"></a> HasBackPing

```csharp
public bool HasBackPing { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_Types_RouterQuality_HasFrontPing"></a> HasFrontPing

```csharp
public bool HasFrontPing { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_Types_RouterQuality_HasScore"></a> HasScore

```csharp
public bool HasScore { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_Types_RouterQuality_HasSecondsUntilDown"></a> HasSecondsUntilDown

```csharp
public bool HasSecondsUntilDown { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_Types_RouterQuality_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamDatagramClientSwitchedPrimary.Types.RouterQuality> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamDatagramClientSwitchedPrimary](Divine.Protobufs.Steam.CMsgSteamDatagramClientSwitchedPrimary.md).[Types](Divine.Protobufs.Steam.CMsgSteamDatagramClientSwitchedPrimary.Types.md).[RouterQuality](Divine.Protobufs.Steam.CMsgSteamDatagramClientSwitchedPrimary.Types.RouterQuality.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_Types_RouterQuality_Score"></a> Score

```csharp
public uint Score { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_Types_RouterQuality_SecondsUntilDown"></a> SecondsUntilDown

```csharp
public uint SecondsUntilDown { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_Types_RouterQuality_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_Types_RouterQuality_ClearBackPing"></a> ClearBackPing\(\)

```csharp
public void ClearBackPing()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_Types_RouterQuality_ClearFrontPing"></a> ClearFrontPing\(\)

```csharp
public void ClearFrontPing()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_Types_RouterQuality_ClearScore"></a> ClearScore\(\)

```csharp
public void ClearScore()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_Types_RouterQuality_ClearSecondsUntilDown"></a> ClearSecondsUntilDown\(\)

```csharp
public void ClearSecondsUntilDown()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_Types_RouterQuality_Clone"></a> Clone\(\)

```csharp
public CMsgSteamDatagramClientSwitchedPrimary.Types.RouterQuality Clone()
```

#### Returns

 [CMsgSteamDatagramClientSwitchedPrimary](Divine.Protobufs.Steam.CMsgSteamDatagramClientSwitchedPrimary.md).[Types](Divine.Protobufs.Steam.CMsgSteamDatagramClientSwitchedPrimary.Types.md).[RouterQuality](Divine.Protobufs.Steam.CMsgSteamDatagramClientSwitchedPrimary.Types.RouterQuality.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_Types_RouterQuality_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_Types_RouterQuality_Equals_Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_Types_RouterQuality_"></a> Equals\(RouterQuality\)

```csharp
public bool Equals(CMsgSteamDatagramClientSwitchedPrimary.Types.RouterQuality other)
```

#### Parameters

`other` [CMsgSteamDatagramClientSwitchedPrimary](Divine.Protobufs.Steam.CMsgSteamDatagramClientSwitchedPrimary.md).[Types](Divine.Protobufs.Steam.CMsgSteamDatagramClientSwitchedPrimary.Types.md).[RouterQuality](Divine.Protobufs.Steam.CMsgSteamDatagramClientSwitchedPrimary.Types.RouterQuality.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_Types_RouterQuality_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_Types_RouterQuality_MergeFrom_Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_Types_RouterQuality_"></a> MergeFrom\(RouterQuality\)

```csharp
public void MergeFrom(CMsgSteamDatagramClientSwitchedPrimary.Types.RouterQuality other)
```

#### Parameters

`other` [CMsgSteamDatagramClientSwitchedPrimary](Divine.Protobufs.Steam.CMsgSteamDatagramClientSwitchedPrimary.md).[Types](Divine.Protobufs.Steam.CMsgSteamDatagramClientSwitchedPrimary.Types.md).[RouterQuality](Divine.Protobufs.Steam.CMsgSteamDatagramClientSwitchedPrimary.Types.RouterQuality.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_Types_RouterQuality_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_Types_RouterQuality_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientSwitchedPrimary_Types_RouterQuality_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

