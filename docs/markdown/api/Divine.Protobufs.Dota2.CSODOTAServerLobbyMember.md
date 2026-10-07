# <a id="Divine_Protobufs_Dota2_CSODOTAServerLobbyMember"></a> Class CSODOTAServerLobbyMember

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSODOTAServerLobbyMember : IMessage<CSODOTAServerLobbyMember>, IEquatable<CSODOTAServerLobbyMember>, IDeepCloneable<CSODOTAServerLobbyMember>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSODOTAServerLobbyMember](Divine.Protobufs.Dota2.CSODOTAServerLobbyMember.md)

#### Implements

IMessage<CSODOTAServerLobbyMember\>, 
[IEquatable<CSODOTAServerLobbyMember\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSODOTAServerLobbyMember\>, 
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
[EnumerableExtensions.In<CSODOTAServerLobbyMember\>\(CSODOTAServerLobbyMember, params CSODOTAServerLobbyMember\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSODOTAServerLobbyMember__ctor"></a> CSODOTAServerLobbyMember\(\)

```csharp
public CSODOTAServerLobbyMember()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAServerLobbyMember__ctor_Divine_Protobufs_Dota2_CSODOTAServerLobbyMember_"></a> CSODOTAServerLobbyMember\(CSODOTAServerLobbyMember\)

```csharp
public CSODOTAServerLobbyMember(CSODOTAServerLobbyMember other)
```

#### Parameters

`other` [CSODOTAServerLobbyMember](Divine.Protobufs.Dota2.CSODOTAServerLobbyMember.md)

## Properties

### <a id="Divine_Protobufs_Dota2_CSODOTAServerLobbyMember_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSODOTAServerLobbyMember_Parser"></a> Parser

```csharp
public static MessageParser<CSODOTAServerLobbyMember> Parser { get; }
```

#### Property Value

 MessageParser<[CSODOTAServerLobbyMember](Divine.Protobufs.Dota2.CSODOTAServerLobbyMember.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CSODOTAServerLobbyMember_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAServerLobbyMember_Clone"></a> Clone\(\)

```csharp
public CSODOTAServerLobbyMember Clone()
```

#### Returns

 [CSODOTAServerLobbyMember](Divine.Protobufs.Dota2.CSODOTAServerLobbyMember.md)

### <a id="Divine_Protobufs_Dota2_CSODOTAServerLobbyMember_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAServerLobbyMember_Equals_Divine_Protobufs_Dota2_CSODOTAServerLobbyMember_"></a> Equals\(CSODOTAServerLobbyMember\)

```csharp
public bool Equals(CSODOTAServerLobbyMember other)
```

#### Parameters

`other` [CSODOTAServerLobbyMember](Divine.Protobufs.Dota2.CSODOTAServerLobbyMember.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAServerLobbyMember_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAServerLobbyMember_MergeFrom_Divine_Protobufs_Dota2_CSODOTAServerLobbyMember_"></a> MergeFrom\(CSODOTAServerLobbyMember\)

```csharp
public void MergeFrom(CSODOTAServerLobbyMember other)
```

#### Parameters

`other` [CSODOTAServerLobbyMember](Divine.Protobufs.Dota2.CSODOTAServerLobbyMember.md)

### <a id="Divine_Protobufs_Dota2_CSODOTAServerLobbyMember_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSODOTAServerLobbyMember_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSODOTAServerLobbyMember_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

