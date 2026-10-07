# <a id="Divine_Protobufs_Dota2_CSODOTAServerStaticLobby"></a> Class CSODOTAServerStaticLobby

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSODOTAServerStaticLobby : IMessage<CSODOTAServerStaticLobby>, IEquatable<CSODOTAServerStaticLobby>, IDeepCloneable<CSODOTAServerStaticLobby>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSODOTAServerStaticLobby](Divine.Protobufs.Dota2.CSODOTAServerStaticLobby.md)

#### Implements

IMessage<CSODOTAServerStaticLobby\>, 
[IEquatable<CSODOTAServerStaticLobby\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSODOTAServerStaticLobby\>, 
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
[EnumerableExtensions.In<CSODOTAServerStaticLobby\>\(CSODOTAServerStaticLobby, params CSODOTAServerStaticLobby\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSODOTAServerStaticLobby__ctor"></a> CSODOTAServerStaticLobby\(\)

```csharp
public CSODOTAServerStaticLobby()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAServerStaticLobby__ctor_Divine_Protobufs_Dota2_CSODOTAServerStaticLobby_"></a> CSODOTAServerStaticLobby\(CSODOTAServerStaticLobby\)

```csharp
public CSODOTAServerStaticLobby(CSODOTAServerStaticLobby other)
```

#### Parameters

`other` [CSODOTAServerStaticLobby](Divine.Protobufs.Dota2.CSODOTAServerStaticLobby.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSODOTAServerStaticLobby_AllMembersFieldNumber"></a> AllMembersFieldNumber

```csharp
public const int AllMembersFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAServerStaticLobby_BroadcastUrlFieldNumber"></a> BroadcastUrlFieldNumber

```csharp
public const int BroadcastUrlFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAServerStaticLobby_LobbyEventPointsFieldNumber"></a> LobbyEventPointsFieldNumber

```csharp
public const int LobbyEventPointsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAServerStaticLobby_PostPatchStrategyTimeBufferFieldNumber"></a> PostPatchStrategyTimeBufferFieldNumber

```csharp
public const int PostPatchStrategyTimeBufferFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSODOTAServerStaticLobby_AllMembers"></a> AllMembers

```csharp
public RepeatedField<CSODOTAServerStaticLobbyMember> AllMembers { get; }
```

#### Property Value

 RepeatedField<[CSODOTAServerStaticLobbyMember](Divine.Protobufs.Dota2.CSODOTAServerStaticLobbyMember.md)\>

### <a id="Divine_Protobufs_Dota2_CSODOTAServerStaticLobby_BroadcastUrl"></a> BroadcastUrl

```csharp
public string BroadcastUrl { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSODOTAServerStaticLobby_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSODOTAServerStaticLobby_HasBroadcastUrl"></a> HasBroadcastUrl

```csharp
public bool HasBroadcastUrl { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAServerStaticLobby_HasPostPatchStrategyTimeBuffer"></a> HasPostPatchStrategyTimeBuffer

```csharp
public bool HasPostPatchStrategyTimeBuffer { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAServerStaticLobby_LobbyEventPoints"></a> LobbyEventPoints

```csharp
public RepeatedField<CMsgLobbyEventPoints> LobbyEventPoints { get; }
```

#### Property Value

 RepeatedField<[CMsgLobbyEventPoints](Divine.Protobufs.Dota2.CMsgLobbyEventPoints.md)\>

### <a id="Divine_Protobufs_Dota2_CSODOTAServerStaticLobby_Parser"></a> Parser

```csharp
public static MessageParser<CSODOTAServerStaticLobby> Parser { get; }
```

#### Property Value

 MessageParser<[CSODOTAServerStaticLobby](Divine.Protobufs.Dota2.CSODOTAServerStaticLobby.md)\>

### <a id="Divine_Protobufs_Dota2_CSODOTAServerStaticLobby_PostPatchStrategyTimeBuffer"></a> PostPatchStrategyTimeBuffer

```csharp
public float PostPatchStrategyTimeBuffer { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Protobufs_Dota2_CSODOTAServerStaticLobby_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAServerStaticLobby_ClearBroadcastUrl"></a> ClearBroadcastUrl\(\)

```csharp
public void ClearBroadcastUrl()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAServerStaticLobby_ClearPostPatchStrategyTimeBuffer"></a> ClearPostPatchStrategyTimeBuffer\(\)

```csharp
public void ClearPostPatchStrategyTimeBuffer()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAServerStaticLobby_Clone"></a> Clone\(\)

```csharp
public CSODOTAServerStaticLobby Clone()
```

#### Returns

 [CSODOTAServerStaticLobby](Divine.Protobufs.Dota2.CSODOTAServerStaticLobby.md)

### <a id="Divine_Protobufs_Dota2_CSODOTAServerStaticLobby_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAServerStaticLobby_Equals_Divine_Protobufs_Dota2_CSODOTAServerStaticLobby_"></a> Equals\(CSODOTAServerStaticLobby\)

```csharp
public bool Equals(CSODOTAServerStaticLobby other)
```

#### Parameters

`other` [CSODOTAServerStaticLobby](Divine.Protobufs.Dota2.CSODOTAServerStaticLobby.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAServerStaticLobby_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAServerStaticLobby_MergeFrom_Divine_Protobufs_Dota2_CSODOTAServerStaticLobby_"></a> MergeFrom\(CSODOTAServerStaticLobby\)

```csharp
public void MergeFrom(CSODOTAServerStaticLobby other)
```

#### Parameters

`other` [CSODOTAServerStaticLobby](Divine.Protobufs.Dota2.CSODOTAServerStaticLobby.md)

### <a id="Divine_Protobufs_Dota2_CSODOTAServerStaticLobby_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSODOTAServerStaticLobby_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSODOTAServerStaticLobby_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

