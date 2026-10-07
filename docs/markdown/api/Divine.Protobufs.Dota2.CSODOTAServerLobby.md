# <a id="Divine_Protobufs_Dota2_CSODOTAServerLobby"></a> Class CSODOTAServerLobby

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSODOTAServerLobby : IMessage<CSODOTAServerLobby>, IEquatable<CSODOTAServerLobby>, IDeepCloneable<CSODOTAServerLobby>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSODOTAServerLobby](Divine.Protobufs.Dota2.CSODOTAServerLobby.md)

#### Implements

IMessage<CSODOTAServerLobby\>, 
[IEquatable<CSODOTAServerLobby\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSODOTAServerLobby\>, 
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
[EnumerableExtensions.In<CSODOTAServerLobby\>\(CSODOTAServerLobby, params CSODOTAServerLobby\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSODOTAServerLobby__ctor"></a> CSODOTAServerLobby\(\)

```csharp
public CSODOTAServerLobby()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAServerLobby__ctor_Divine_Protobufs_Dota2_CSODOTAServerLobby_"></a> CSODOTAServerLobby\(CSODOTAServerLobby\)

```csharp
public CSODOTAServerLobby(CSODOTAServerLobby other)
```

#### Parameters

`other` [CSODOTAServerLobby](Divine.Protobufs.Dota2.CSODOTAServerLobby.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSODOTAServerLobby_AllMembersFieldNumber"></a> AllMembersFieldNumber

```csharp
public const int AllMembersFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAServerLobby_BroadcastActiveFieldNumber"></a> BroadcastActiveFieldNumber

```csharp
public const int BroadcastActiveFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAServerLobby_ExtraStartupMessagesFieldNumber"></a> ExtraStartupMessagesFieldNumber

```csharp
public const int ExtraStartupMessagesFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSODOTAServerLobby_AllMembers"></a> AllMembers

```csharp
public RepeatedField<CSODOTAServerLobbyMember> AllMembers { get; }
```

#### Property Value

 RepeatedField<[CSODOTAServerLobbyMember](Divine.Protobufs.Dota2.CSODOTAServerLobbyMember.md)\>

### <a id="Divine_Protobufs_Dota2_CSODOTAServerLobby_BroadcastActive"></a> BroadcastActive

```csharp
public bool BroadcastActive { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAServerLobby_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSODOTAServerLobby_ExtraStartupMessages"></a> ExtraStartupMessages

```csharp
public RepeatedField<CSODOTALobby.Types.CExtraMsg> ExtraStartupMessages { get; }
```

#### Property Value

 RepeatedField<[CSODOTALobby](Divine.Protobufs.Dota2.CSODOTALobby.md).[Types](Divine.Protobufs.Dota2.CSODOTALobby.Types.md).[CExtraMsg](Divine.Protobufs.Dota2.CSODOTALobby.Types.CExtraMsg.md)\>

### <a id="Divine_Protobufs_Dota2_CSODOTAServerLobby_HasBroadcastActive"></a> HasBroadcastActive

```csharp
public bool HasBroadcastActive { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAServerLobby_Parser"></a> Parser

```csharp
public static MessageParser<CSODOTAServerLobby> Parser { get; }
```

#### Property Value

 MessageParser<[CSODOTAServerLobby](Divine.Protobufs.Dota2.CSODOTAServerLobby.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CSODOTAServerLobby_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAServerLobby_ClearBroadcastActive"></a> ClearBroadcastActive\(\)

```csharp
public void ClearBroadcastActive()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAServerLobby_Clone"></a> Clone\(\)

```csharp
public CSODOTAServerLobby Clone()
```

#### Returns

 [CSODOTAServerLobby](Divine.Protobufs.Dota2.CSODOTAServerLobby.md)

### <a id="Divine_Protobufs_Dota2_CSODOTAServerLobby_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAServerLobby_Equals_Divine_Protobufs_Dota2_CSODOTAServerLobby_"></a> Equals\(CSODOTAServerLobby\)

```csharp
public bool Equals(CSODOTAServerLobby other)
```

#### Parameters

`other` [CSODOTAServerLobby](Divine.Protobufs.Dota2.CSODOTAServerLobby.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAServerLobby_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAServerLobby_MergeFrom_Divine_Protobufs_Dota2_CSODOTAServerLobby_"></a> MergeFrom\(CSODOTAServerLobby\)

```csharp
public void MergeFrom(CSODOTAServerLobby other)
```

#### Parameters

`other` [CSODOTAServerLobby](Divine.Protobufs.Dota2.CSODOTAServerLobby.md)

### <a id="Divine_Protobufs_Dota2_CSODOTAServerLobby_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSODOTAServerLobby_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSODOTAServerLobby_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

