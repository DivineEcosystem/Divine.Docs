# <a id="Divine_Protobufs_Dota2_CMsgFlipLobbyTeams"></a> Class CMsgFlipLobbyTeams

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgFlipLobbyTeams : IMessage<CMsgFlipLobbyTeams>, IEquatable<CMsgFlipLobbyTeams>, IDeepCloneable<CMsgFlipLobbyTeams>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgFlipLobbyTeams](Divine.Protobufs.Dota2.CMsgFlipLobbyTeams.md)

#### Implements

IMessage<CMsgFlipLobbyTeams\>, 
[IEquatable<CMsgFlipLobbyTeams\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgFlipLobbyTeams\>, 
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
[EnumerableExtensions.In<CMsgFlipLobbyTeams\>\(CMsgFlipLobbyTeams, params CMsgFlipLobbyTeams\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgFlipLobbyTeams__ctor"></a> CMsgFlipLobbyTeams\(\)

```csharp
public CMsgFlipLobbyTeams()
```

### <a id="Divine_Protobufs_Dota2_CMsgFlipLobbyTeams__ctor_Divine_Protobufs_Dota2_CMsgFlipLobbyTeams_"></a> CMsgFlipLobbyTeams\(CMsgFlipLobbyTeams\)

```csharp
public CMsgFlipLobbyTeams(CMsgFlipLobbyTeams other)
```

#### Parameters

`other` [CMsgFlipLobbyTeams](Divine.Protobufs.Dota2.CMsgFlipLobbyTeams.md)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgFlipLobbyTeams_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgFlipLobbyTeams_Parser"></a> Parser

```csharp
public static MessageParser<CMsgFlipLobbyTeams> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgFlipLobbyTeams](Divine.Protobufs.Dota2.CMsgFlipLobbyTeams.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgFlipLobbyTeams_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgFlipLobbyTeams_Clone"></a> Clone\(\)

```csharp
public CMsgFlipLobbyTeams Clone()
```

#### Returns

 [CMsgFlipLobbyTeams](Divine.Protobufs.Dota2.CMsgFlipLobbyTeams.md)

### <a id="Divine_Protobufs_Dota2_CMsgFlipLobbyTeams_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgFlipLobbyTeams_Equals_Divine_Protobufs_Dota2_CMsgFlipLobbyTeams_"></a> Equals\(CMsgFlipLobbyTeams\)

```csharp
public bool Equals(CMsgFlipLobbyTeams other)
```

#### Parameters

`other` [CMsgFlipLobbyTeams](Divine.Protobufs.Dota2.CMsgFlipLobbyTeams.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgFlipLobbyTeams_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgFlipLobbyTeams_MergeFrom_Divine_Protobufs_Dota2_CMsgFlipLobbyTeams_"></a> MergeFrom\(CMsgFlipLobbyTeams\)

```csharp
public void MergeFrom(CMsgFlipLobbyTeams other)
```

#### Parameters

`other` [CMsgFlipLobbyTeams](Divine.Protobufs.Dota2.CMsgFlipLobbyTeams.md)

### <a id="Divine_Protobufs_Dota2_CMsgFlipLobbyTeams_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgFlipLobbyTeams_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgFlipLobbyTeams_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

