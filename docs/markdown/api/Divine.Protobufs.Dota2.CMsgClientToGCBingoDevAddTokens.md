# <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevAddTokens"></a> Class CMsgClientToGCBingoDevAddTokens

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCBingoDevAddTokens : IMessage<CMsgClientToGCBingoDevAddTokens>, IEquatable<CMsgClientToGCBingoDevAddTokens>, IDeepCloneable<CMsgClientToGCBingoDevAddTokens>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCBingoDevAddTokens](Divine.Protobufs.Dota2.CMsgClientToGCBingoDevAddTokens.md)

#### Implements

IMessage<CMsgClientToGCBingoDevAddTokens\>, 
[IEquatable<CMsgClientToGCBingoDevAddTokens\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCBingoDevAddTokens\>, 
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
[EnumerableExtensions.In<CMsgClientToGCBingoDevAddTokens\>\(CMsgClientToGCBingoDevAddTokens, params CMsgClientToGCBingoDevAddTokens\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevAddTokens__ctor"></a> CMsgClientToGCBingoDevAddTokens\(\)

```csharp
public CMsgClientToGCBingoDevAddTokens()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevAddTokens__ctor_Divine_Protobufs_Dota2_CMsgClientToGCBingoDevAddTokens_"></a> CMsgClientToGCBingoDevAddTokens\(CMsgClientToGCBingoDevAddTokens\)

```csharp
public CMsgClientToGCBingoDevAddTokens(CMsgClientToGCBingoDevAddTokens other)
```

#### Parameters

`other` [CMsgClientToGCBingoDevAddTokens](Divine.Protobufs.Dota2.CMsgClientToGCBingoDevAddTokens.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevAddTokens_LeagueIdFieldNumber"></a> LeagueIdFieldNumber

```csharp
public const int LeagueIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevAddTokens_LeaguePhaseFieldNumber"></a> LeaguePhaseFieldNumber

```csharp
public const int LeaguePhaseFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevAddTokens_TokenCountFieldNumber"></a> TokenCountFieldNumber

```csharp
public const int TokenCountFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevAddTokens_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevAddTokens_HasLeagueId"></a> HasLeagueId

```csharp
public bool HasLeagueId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevAddTokens_HasLeaguePhase"></a> HasLeaguePhase

```csharp
public bool HasLeaguePhase { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevAddTokens_HasTokenCount"></a> HasTokenCount

```csharp
public bool HasTokenCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevAddTokens_LeagueId"></a> LeagueId

```csharp
public uint LeagueId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevAddTokens_LeaguePhase"></a> LeaguePhase

```csharp
public uint LeaguePhase { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevAddTokens_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCBingoDevAddTokens> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCBingoDevAddTokens](Divine.Protobufs.Dota2.CMsgClientToGCBingoDevAddTokens.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevAddTokens_TokenCount"></a> TokenCount

```csharp
public int TokenCount { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevAddTokens_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevAddTokens_ClearLeagueId"></a> ClearLeagueId\(\)

```csharp
public void ClearLeagueId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevAddTokens_ClearLeaguePhase"></a> ClearLeaguePhase\(\)

```csharp
public void ClearLeaguePhase()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevAddTokens_ClearTokenCount"></a> ClearTokenCount\(\)

```csharp
public void ClearTokenCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevAddTokens_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCBingoDevAddTokens Clone()
```

#### Returns

 [CMsgClientToGCBingoDevAddTokens](Divine.Protobufs.Dota2.CMsgClientToGCBingoDevAddTokens.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevAddTokens_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevAddTokens_Equals_Divine_Protobufs_Dota2_CMsgClientToGCBingoDevAddTokens_"></a> Equals\(CMsgClientToGCBingoDevAddTokens\)

```csharp
public bool Equals(CMsgClientToGCBingoDevAddTokens other)
```

#### Parameters

`other` [CMsgClientToGCBingoDevAddTokens](Divine.Protobufs.Dota2.CMsgClientToGCBingoDevAddTokens.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevAddTokens_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevAddTokens_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCBingoDevAddTokens_"></a> MergeFrom\(CMsgClientToGCBingoDevAddTokens\)

```csharp
public void MergeFrom(CMsgClientToGCBingoDevAddTokens other)
```

#### Parameters

`other` [CMsgClientToGCBingoDevAddTokens](Divine.Protobufs.Dota2.CMsgClientToGCBingoDevAddTokens.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevAddTokens_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevAddTokens_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoDevAddTokens_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

