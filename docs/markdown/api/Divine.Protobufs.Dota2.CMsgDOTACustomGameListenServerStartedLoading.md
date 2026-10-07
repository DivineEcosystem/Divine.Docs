# <a id="Divine_Protobufs_Dota2_CMsgDOTACustomGameListenServerStartedLoading"></a> Class CMsgDOTACustomGameListenServerStartedLoading

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTACustomGameListenServerStartedLoading : IMessage<CMsgDOTACustomGameListenServerStartedLoading>, IEquatable<CMsgDOTACustomGameListenServerStartedLoading>, IDeepCloneable<CMsgDOTACustomGameListenServerStartedLoading>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTACustomGameListenServerStartedLoading](Divine.Protobufs.Dota2.CMsgDOTACustomGameListenServerStartedLoading.md)

#### Implements

IMessage<CMsgDOTACustomGameListenServerStartedLoading\>, 
[IEquatable<CMsgDOTACustomGameListenServerStartedLoading\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTACustomGameListenServerStartedLoading\>, 
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
[EnumerableExtensions.In<CMsgDOTACustomGameListenServerStartedLoading\>\(CMsgDOTACustomGameListenServerStartedLoading, params CMsgDOTACustomGameListenServerStartedLoading\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTACustomGameListenServerStartedLoading__ctor"></a> CMsgDOTACustomGameListenServerStartedLoading\(\)

```csharp
public CMsgDOTACustomGameListenServerStartedLoading()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACustomGameListenServerStartedLoading__ctor_Divine_Protobufs_Dota2_CMsgDOTACustomGameListenServerStartedLoading_"></a> CMsgDOTACustomGameListenServerStartedLoading\(CMsgDOTACustomGameListenServerStartedLoading\)

```csharp
public CMsgDOTACustomGameListenServerStartedLoading(CMsgDOTACustomGameListenServerStartedLoading other)
```

#### Parameters

`other` [CMsgDOTACustomGameListenServerStartedLoading](Divine.Protobufs.Dota2.CMsgDOTACustomGameListenServerStartedLoading.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTACustomGameListenServerStartedLoading_CustomGameIdFieldNumber"></a> CustomGameIdFieldNumber

```csharp
public const int CustomGameIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACustomGameListenServerStartedLoading_LobbyIdFieldNumber"></a> LobbyIdFieldNumber

```csharp
public const int LobbyIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACustomGameListenServerStartedLoading_LobbyMembersFieldNumber"></a> LobbyMembersFieldNumber

```csharp
public const int LobbyMembersFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACustomGameListenServerStartedLoading_StartTimeFieldNumber"></a> StartTimeFieldNumber

```csharp
public const int StartTimeFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTACustomGameListenServerStartedLoading_CustomGameId"></a> CustomGameId

```csharp
public ulong CustomGameId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACustomGameListenServerStartedLoading_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTACustomGameListenServerStartedLoading_HasCustomGameId"></a> HasCustomGameId

```csharp
public bool HasCustomGameId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACustomGameListenServerStartedLoading_HasLobbyId"></a> HasLobbyId

```csharp
public bool HasLobbyId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACustomGameListenServerStartedLoading_HasStartTime"></a> HasStartTime

```csharp
public bool HasStartTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACustomGameListenServerStartedLoading_LobbyId"></a> LobbyId

```csharp
public ulong LobbyId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACustomGameListenServerStartedLoading_LobbyMembers"></a> LobbyMembers

```csharp
public RepeatedField<uint> LobbyMembers { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTACustomGameListenServerStartedLoading_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTACustomGameListenServerStartedLoading> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTACustomGameListenServerStartedLoading](Divine.Protobufs.Dota2.CMsgDOTACustomGameListenServerStartedLoading.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTACustomGameListenServerStartedLoading_StartTime"></a> StartTime

```csharp
public uint StartTime { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTACustomGameListenServerStartedLoading_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACustomGameListenServerStartedLoading_ClearCustomGameId"></a> ClearCustomGameId\(\)

```csharp
public void ClearCustomGameId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACustomGameListenServerStartedLoading_ClearLobbyId"></a> ClearLobbyId\(\)

```csharp
public void ClearLobbyId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACustomGameListenServerStartedLoading_ClearStartTime"></a> ClearStartTime\(\)

```csharp
public void ClearStartTime()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACustomGameListenServerStartedLoading_Clone"></a> Clone\(\)

```csharp
public CMsgDOTACustomGameListenServerStartedLoading Clone()
```

#### Returns

 [CMsgDOTACustomGameListenServerStartedLoading](Divine.Protobufs.Dota2.CMsgDOTACustomGameListenServerStartedLoading.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACustomGameListenServerStartedLoading_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACustomGameListenServerStartedLoading_Equals_Divine_Protobufs_Dota2_CMsgDOTACustomGameListenServerStartedLoading_"></a> Equals\(CMsgDOTACustomGameListenServerStartedLoading\)

```csharp
public bool Equals(CMsgDOTACustomGameListenServerStartedLoading other)
```

#### Parameters

`other` [CMsgDOTACustomGameListenServerStartedLoading](Divine.Protobufs.Dota2.CMsgDOTACustomGameListenServerStartedLoading.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACustomGameListenServerStartedLoading_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACustomGameListenServerStartedLoading_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTACustomGameListenServerStartedLoading_"></a> MergeFrom\(CMsgDOTACustomGameListenServerStartedLoading\)

```csharp
public void MergeFrom(CMsgDOTACustomGameListenServerStartedLoading other)
```

#### Parameters

`other` [CMsgDOTACustomGameListenServerStartedLoading](Divine.Protobufs.Dota2.CMsgDOTACustomGameListenServerStartedLoading.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACustomGameListenServerStartedLoading_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTACustomGameListenServerStartedLoading_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACustomGameListenServerStartedLoading_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

