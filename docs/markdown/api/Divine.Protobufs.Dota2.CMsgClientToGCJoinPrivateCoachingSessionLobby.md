# <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPrivateCoachingSessionLobby"></a> Class CMsgClientToGCJoinPrivateCoachingSessionLobby

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCJoinPrivateCoachingSessionLobby : IMessage<CMsgClientToGCJoinPrivateCoachingSessionLobby>, IEquatable<CMsgClientToGCJoinPrivateCoachingSessionLobby>, IDeepCloneable<CMsgClientToGCJoinPrivateCoachingSessionLobby>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCJoinPrivateCoachingSessionLobby](Divine.Protobufs.Dota2.CMsgClientToGCJoinPrivateCoachingSessionLobby.md)

#### Implements

IMessage<CMsgClientToGCJoinPrivateCoachingSessionLobby\>, 
[IEquatable<CMsgClientToGCJoinPrivateCoachingSessionLobby\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCJoinPrivateCoachingSessionLobby\>, 
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
[EnumerableExtensions.In<CMsgClientToGCJoinPrivateCoachingSessionLobby\>\(CMsgClientToGCJoinPrivateCoachingSessionLobby, params CMsgClientToGCJoinPrivateCoachingSessionLobby\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPrivateCoachingSessionLobby__ctor"></a> CMsgClientToGCJoinPrivateCoachingSessionLobby\(\)

```csharp
public CMsgClientToGCJoinPrivateCoachingSessionLobby()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPrivateCoachingSessionLobby__ctor_Divine_Protobufs_Dota2_CMsgClientToGCJoinPrivateCoachingSessionLobby_"></a> CMsgClientToGCJoinPrivateCoachingSessionLobby\(CMsgClientToGCJoinPrivateCoachingSessionLobby\)

```csharp
public CMsgClientToGCJoinPrivateCoachingSessionLobby(CMsgClientToGCJoinPrivateCoachingSessionLobby other)
```

#### Parameters

`other` [CMsgClientToGCJoinPrivateCoachingSessionLobby](Divine.Protobufs.Dota2.CMsgClientToGCJoinPrivateCoachingSessionLobby.md)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPrivateCoachingSessionLobby_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPrivateCoachingSessionLobby_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCJoinPrivateCoachingSessionLobby> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCJoinPrivateCoachingSessionLobby](Divine.Protobufs.Dota2.CMsgClientToGCJoinPrivateCoachingSessionLobby.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPrivateCoachingSessionLobby_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPrivateCoachingSessionLobby_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCJoinPrivateCoachingSessionLobby Clone()
```

#### Returns

 [CMsgClientToGCJoinPrivateCoachingSessionLobby](Divine.Protobufs.Dota2.CMsgClientToGCJoinPrivateCoachingSessionLobby.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPrivateCoachingSessionLobby_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPrivateCoachingSessionLobby_Equals_Divine_Protobufs_Dota2_CMsgClientToGCJoinPrivateCoachingSessionLobby_"></a> Equals\(CMsgClientToGCJoinPrivateCoachingSessionLobby\)

```csharp
public bool Equals(CMsgClientToGCJoinPrivateCoachingSessionLobby other)
```

#### Parameters

`other` [CMsgClientToGCJoinPrivateCoachingSessionLobby](Divine.Protobufs.Dota2.CMsgClientToGCJoinPrivateCoachingSessionLobby.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPrivateCoachingSessionLobby_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPrivateCoachingSessionLobby_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCJoinPrivateCoachingSessionLobby_"></a> MergeFrom\(CMsgClientToGCJoinPrivateCoachingSessionLobby\)

```csharp
public void MergeFrom(CMsgClientToGCJoinPrivateCoachingSessionLobby other)
```

#### Parameters

`other` [CMsgClientToGCJoinPrivateCoachingSessionLobby](Divine.Protobufs.Dota2.CMsgClientToGCJoinPrivateCoachingSessionLobby.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPrivateCoachingSessionLobby_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPrivateCoachingSessionLobby_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPrivateCoachingSessionLobby_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

