# <a id="Divine_Protobufs_Dota2_CMsgReadyUpStatus"></a> Class CMsgReadyUpStatus

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgReadyUpStatus : IMessage<CMsgReadyUpStatus>, IEquatable<CMsgReadyUpStatus>, IDeepCloneable<CMsgReadyUpStatus>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgReadyUpStatus](Divine.Protobufs.Dota2.CMsgReadyUpStatus.md)

#### Implements

IMessage<CMsgReadyUpStatus\>, 
[IEquatable<CMsgReadyUpStatus\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgReadyUpStatus\>, 
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
[EnumerableExtensions.In<CMsgReadyUpStatus\>\(CMsgReadyUpStatus, params CMsgReadyUpStatus\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgReadyUpStatus__ctor"></a> CMsgReadyUpStatus\(\)

```csharp
public CMsgReadyUpStatus()
```

### <a id="Divine_Protobufs_Dota2_CMsgReadyUpStatus__ctor_Divine_Protobufs_Dota2_CMsgReadyUpStatus_"></a> CMsgReadyUpStatus\(CMsgReadyUpStatus\)

```csharp
public CMsgReadyUpStatus(CMsgReadyUpStatus other)
```

#### Parameters

`other` [CMsgReadyUpStatus](Divine.Protobufs.Dota2.CMsgReadyUpStatus.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgReadyUpStatus_AcceptedIdsFieldNumber"></a> AcceptedIdsFieldNumber

```csharp
public const int AcceptedIdsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgReadyUpStatus_AcceptedIndicesFieldNumber"></a> AcceptedIndicesFieldNumber

```csharp
public const int AcceptedIndicesFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgReadyUpStatus_DeclinedIdsFieldNumber"></a> DeclinedIdsFieldNumber

```csharp
public const int DeclinedIdsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgReadyUpStatus_DeclinedIndicesFieldNumber"></a> DeclinedIndicesFieldNumber

```csharp
public const int DeclinedIndicesFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgReadyUpStatus_LobbyIdFieldNumber"></a> LobbyIdFieldNumber

```csharp
public const int LobbyIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgReadyUpStatus_LocalReadyStateFieldNumber"></a> LocalReadyStateFieldNumber

```csharp
public const int LocalReadyStateFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgReadyUpStatus_AcceptedIds"></a> AcceptedIds

```csharp
public RepeatedField<uint> AcceptedIds { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgReadyUpStatus_AcceptedIndices"></a> AcceptedIndices

```csharp
public RepeatedField<uint> AcceptedIndices { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgReadyUpStatus_DeclinedIds"></a> DeclinedIds

```csharp
public RepeatedField<uint> DeclinedIds { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgReadyUpStatus_DeclinedIndices"></a> DeclinedIndices

```csharp
public RepeatedField<uint> DeclinedIndices { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgReadyUpStatus_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgReadyUpStatus_HasLobbyId"></a> HasLobbyId

```csharp
public bool HasLobbyId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgReadyUpStatus_HasLocalReadyState"></a> HasLocalReadyState

```csharp
public bool HasLocalReadyState { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgReadyUpStatus_LobbyId"></a> LobbyId

```csharp
public ulong LobbyId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgReadyUpStatus_LocalReadyState"></a> LocalReadyState

```csharp
public DOTALobbyReadyState LocalReadyState { get; set; }
```

#### Property Value

 [DOTALobbyReadyState](Divine.Protobufs.Dota2.DOTALobbyReadyState.md)

### <a id="Divine_Protobufs_Dota2_CMsgReadyUpStatus_Parser"></a> Parser

```csharp
public static MessageParser<CMsgReadyUpStatus> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgReadyUpStatus](Divine.Protobufs.Dota2.CMsgReadyUpStatus.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgReadyUpStatus_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgReadyUpStatus_ClearLobbyId"></a> ClearLobbyId\(\)

```csharp
public void ClearLobbyId()
```

### <a id="Divine_Protobufs_Dota2_CMsgReadyUpStatus_ClearLocalReadyState"></a> ClearLocalReadyState\(\)

```csharp
public void ClearLocalReadyState()
```

### <a id="Divine_Protobufs_Dota2_CMsgReadyUpStatus_Clone"></a> Clone\(\)

```csharp
public CMsgReadyUpStatus Clone()
```

#### Returns

 [CMsgReadyUpStatus](Divine.Protobufs.Dota2.CMsgReadyUpStatus.md)

### <a id="Divine_Protobufs_Dota2_CMsgReadyUpStatus_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgReadyUpStatus_Equals_Divine_Protobufs_Dota2_CMsgReadyUpStatus_"></a> Equals\(CMsgReadyUpStatus\)

```csharp
public bool Equals(CMsgReadyUpStatus other)
```

#### Parameters

`other` [CMsgReadyUpStatus](Divine.Protobufs.Dota2.CMsgReadyUpStatus.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgReadyUpStatus_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgReadyUpStatus_MergeFrom_Divine_Protobufs_Dota2_CMsgReadyUpStatus_"></a> MergeFrom\(CMsgReadyUpStatus\)

```csharp
public void MergeFrom(CMsgReadyUpStatus other)
```

#### Parameters

`other` [CMsgReadyUpStatus](Divine.Protobufs.Dota2.CMsgReadyUpStatus.md)

### <a id="Divine_Protobufs_Dota2_CMsgReadyUpStatus_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgReadyUpStatus_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgReadyUpStatus_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

