# <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyMVPAwarded"></a> Class CMsgDOTALobbyMVPAwarded

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTALobbyMVPAwarded : IMessage<CMsgDOTALobbyMVPAwarded>, IEquatable<CMsgDOTALobbyMVPAwarded>, IDeepCloneable<CMsgDOTALobbyMVPAwarded>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTALobbyMVPAwarded](Divine.Protobufs.Dota2.CMsgDOTALobbyMVPAwarded.md)

#### Implements

IMessage<CMsgDOTALobbyMVPAwarded\>, 
[IEquatable<CMsgDOTALobbyMVPAwarded\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTALobbyMVPAwarded\>, 
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
[EnumerableExtensions.In<CMsgDOTALobbyMVPAwarded\>\(CMsgDOTALobbyMVPAwarded, params CMsgDOTALobbyMVPAwarded\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyMVPAwarded__ctor"></a> CMsgDOTALobbyMVPAwarded\(\)

```csharp
public CMsgDOTALobbyMVPAwarded()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyMVPAwarded__ctor_Divine_Protobufs_Dota2_CMsgDOTALobbyMVPAwarded_"></a> CMsgDOTALobbyMVPAwarded\(CMsgDOTALobbyMVPAwarded\)

```csharp
public CMsgDOTALobbyMVPAwarded(CMsgDOTALobbyMVPAwarded other)
```

#### Parameters

`other` [CMsgDOTALobbyMVPAwarded](Divine.Protobufs.Dota2.CMsgDOTALobbyMVPAwarded.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyMVPAwarded_MatchIdFieldNumber"></a> MatchIdFieldNumber

```csharp
public const int MatchIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyMVPAwarded_MvpAccountIdFieldNumber"></a> MvpAccountIdFieldNumber

```csharp
public const int MvpAccountIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyMVPAwarded_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyMVPAwarded_HasMatchId"></a> HasMatchId

```csharp
public bool HasMatchId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyMVPAwarded_MatchId"></a> MatchId

```csharp
public ulong MatchId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyMVPAwarded_MvpAccountId"></a> MvpAccountId

```csharp
public RepeatedField<uint> MvpAccountId { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyMVPAwarded_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTALobbyMVPAwarded> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTALobbyMVPAwarded](Divine.Protobufs.Dota2.CMsgDOTALobbyMVPAwarded.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyMVPAwarded_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyMVPAwarded_ClearMatchId"></a> ClearMatchId\(\)

```csharp
public void ClearMatchId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyMVPAwarded_Clone"></a> Clone\(\)

```csharp
public CMsgDOTALobbyMVPAwarded Clone()
```

#### Returns

 [CMsgDOTALobbyMVPAwarded](Divine.Protobufs.Dota2.CMsgDOTALobbyMVPAwarded.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyMVPAwarded_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyMVPAwarded_Equals_Divine_Protobufs_Dota2_CMsgDOTALobbyMVPAwarded_"></a> Equals\(CMsgDOTALobbyMVPAwarded\)

```csharp
public bool Equals(CMsgDOTALobbyMVPAwarded other)
```

#### Parameters

`other` [CMsgDOTALobbyMVPAwarded](Divine.Protobufs.Dota2.CMsgDOTALobbyMVPAwarded.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyMVPAwarded_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyMVPAwarded_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTALobbyMVPAwarded_"></a> MergeFrom\(CMsgDOTALobbyMVPAwarded\)

```csharp
public void MergeFrom(CMsgDOTALobbyMVPAwarded other)
```

#### Parameters

`other` [CMsgDOTALobbyMVPAwarded](Divine.Protobufs.Dota2.CMsgDOTALobbyMVPAwarded.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyMVPAwarded_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyMVPAwarded_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALobbyMVPAwarded_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

