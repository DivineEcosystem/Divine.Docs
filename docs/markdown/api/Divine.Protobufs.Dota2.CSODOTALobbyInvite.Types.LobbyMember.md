# <a id="Divine_Protobufs_Dota2_CSODOTALobbyInvite_Types_LobbyMember"></a> Class CSODOTALobbyInvite.Types.LobbyMember

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSODOTALobbyInvite.Types.LobbyMember : IMessage<CSODOTALobbyInvite.Types.LobbyMember>, IEquatable<CSODOTALobbyInvite.Types.LobbyMember>, IDeepCloneable<CSODOTALobbyInvite.Types.LobbyMember>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSODOTALobbyInvite.Types.LobbyMember](Divine.Protobufs.Dota2.CSODOTALobbyInvite.Types.LobbyMember.md)

#### Implements

IMessage<CSODOTALobbyInvite.Types.LobbyMember\>, 
[IEquatable<CSODOTALobbyInvite.Types.LobbyMember\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSODOTALobbyInvite.Types.LobbyMember\>, 
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
[EnumerableExtensions.In<CSODOTALobbyInvite.Types.LobbyMember\>\(CSODOTALobbyInvite.Types.LobbyMember, params CSODOTALobbyInvite.Types.LobbyMember\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSODOTALobbyInvite_Types_LobbyMember__ctor"></a> LobbyMember\(\)

```csharp
public LobbyMember()
```

### <a id="Divine_Protobufs_Dota2_CSODOTALobbyInvite_Types_LobbyMember__ctor_Divine_Protobufs_Dota2_CSODOTALobbyInvite_Types_LobbyMember_"></a> LobbyMember\(LobbyMember\)

```csharp
public LobbyMember(CSODOTALobbyInvite.Types.LobbyMember other)
```

#### Parameters

`other` [CSODOTALobbyInvite](Divine.Protobufs.Dota2.CSODOTALobbyInvite.md).[Types](Divine.Protobufs.Dota2.CSODOTALobbyInvite.Types.md).[LobbyMember](Divine.Protobufs.Dota2.CSODOTALobbyInvite.Types.LobbyMember.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSODOTALobbyInvite_Types_LobbyMember_NameFieldNumber"></a> NameFieldNumber

```csharp
public const int NameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTALobbyInvite_Types_LobbyMember_SteamIdFieldNumber"></a> SteamIdFieldNumber

```csharp
public const int SteamIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSODOTALobbyInvite_Types_LobbyMember_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSODOTALobbyInvite_Types_LobbyMember_HasName"></a> HasName

```csharp
public bool HasName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTALobbyInvite_Types_LobbyMember_HasSteamId"></a> HasSteamId

```csharp
public bool HasSteamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTALobbyInvite_Types_LobbyMember_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSODOTALobbyInvite_Types_LobbyMember_Parser"></a> Parser

```csharp
public static MessageParser<CSODOTALobbyInvite.Types.LobbyMember> Parser { get; }
```

#### Property Value

 MessageParser<[CSODOTALobbyInvite](Divine.Protobufs.Dota2.CSODOTALobbyInvite.md).[Types](Divine.Protobufs.Dota2.CSODOTALobbyInvite.Types.md).[LobbyMember](Divine.Protobufs.Dota2.CSODOTALobbyInvite.Types.LobbyMember.md)\>

### <a id="Divine_Protobufs_Dota2_CSODOTALobbyInvite_Types_LobbyMember_SteamId"></a> SteamId

```csharp
public ulong SteamId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CSODOTALobbyInvite_Types_LobbyMember_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTALobbyInvite_Types_LobbyMember_ClearName"></a> ClearName\(\)

```csharp
public void ClearName()
```

### <a id="Divine_Protobufs_Dota2_CSODOTALobbyInvite_Types_LobbyMember_ClearSteamId"></a> ClearSteamId\(\)

```csharp
public void ClearSteamId()
```

### <a id="Divine_Protobufs_Dota2_CSODOTALobbyInvite_Types_LobbyMember_Clone"></a> Clone\(\)

```csharp
public CSODOTALobbyInvite.Types.LobbyMember Clone()
```

#### Returns

 [CSODOTALobbyInvite](Divine.Protobufs.Dota2.CSODOTALobbyInvite.md).[Types](Divine.Protobufs.Dota2.CSODOTALobbyInvite.Types.md).[LobbyMember](Divine.Protobufs.Dota2.CSODOTALobbyInvite.Types.LobbyMember.md)

### <a id="Divine_Protobufs_Dota2_CSODOTALobbyInvite_Types_LobbyMember_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTALobbyInvite_Types_LobbyMember_Equals_Divine_Protobufs_Dota2_CSODOTALobbyInvite_Types_LobbyMember_"></a> Equals\(LobbyMember\)

```csharp
public bool Equals(CSODOTALobbyInvite.Types.LobbyMember other)
```

#### Parameters

`other` [CSODOTALobbyInvite](Divine.Protobufs.Dota2.CSODOTALobbyInvite.md).[Types](Divine.Protobufs.Dota2.CSODOTALobbyInvite.Types.md).[LobbyMember](Divine.Protobufs.Dota2.CSODOTALobbyInvite.Types.LobbyMember.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTALobbyInvite_Types_LobbyMember_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTALobbyInvite_Types_LobbyMember_MergeFrom_Divine_Protobufs_Dota2_CSODOTALobbyInvite_Types_LobbyMember_"></a> MergeFrom\(LobbyMember\)

```csharp
public void MergeFrom(CSODOTALobbyInvite.Types.LobbyMember other)
```

#### Parameters

`other` [CSODOTALobbyInvite](Divine.Protobufs.Dota2.CSODOTALobbyInvite.md).[Types](Divine.Protobufs.Dota2.CSODOTALobbyInvite.Types.md).[LobbyMember](Divine.Protobufs.Dota2.CSODOTALobbyInvite.Types.LobbyMember.md)

### <a id="Divine_Protobufs_Dota2_CSODOTALobbyInvite_Types_LobbyMember_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSODOTALobbyInvite_Types_LobbyMember_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSODOTALobbyInvite_Types_LobbyMember_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

