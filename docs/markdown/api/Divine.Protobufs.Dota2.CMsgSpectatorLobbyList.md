# <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyList"></a> Class CMsgSpectatorLobbyList

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSpectatorLobbyList : IMessage<CMsgSpectatorLobbyList>, IEquatable<CMsgSpectatorLobbyList>, IDeepCloneable<CMsgSpectatorLobbyList>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSpectatorLobbyList](Divine.Protobufs.Dota2.CMsgSpectatorLobbyList.md)

#### Implements

IMessage<CMsgSpectatorLobbyList\>, 
[IEquatable<CMsgSpectatorLobbyList\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSpectatorLobbyList\>, 
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
[EnumerableExtensions.In<CMsgSpectatorLobbyList\>\(CMsgSpectatorLobbyList, params CMsgSpectatorLobbyList\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyList__ctor"></a> CMsgSpectatorLobbyList\(\)

```csharp
public CMsgSpectatorLobbyList()
```

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyList__ctor_Divine_Protobufs_Dota2_CMsgSpectatorLobbyList_"></a> CMsgSpectatorLobbyList\(CMsgSpectatorLobbyList\)

```csharp
public CMsgSpectatorLobbyList(CMsgSpectatorLobbyList other)
```

#### Parameters

`other` [CMsgSpectatorLobbyList](Divine.Protobufs.Dota2.CMsgSpectatorLobbyList.md)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyList_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyList_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSpectatorLobbyList> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSpectatorLobbyList](Divine.Protobufs.Dota2.CMsgSpectatorLobbyList.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyList_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyList_Clone"></a> Clone\(\)

```csharp
public CMsgSpectatorLobbyList Clone()
```

#### Returns

 [CMsgSpectatorLobbyList](Divine.Protobufs.Dota2.CMsgSpectatorLobbyList.md)

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyList_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyList_Equals_Divine_Protobufs_Dota2_CMsgSpectatorLobbyList_"></a> Equals\(CMsgSpectatorLobbyList\)

```csharp
public bool Equals(CMsgSpectatorLobbyList other)
```

#### Parameters

`other` [CMsgSpectatorLobbyList](Divine.Protobufs.Dota2.CMsgSpectatorLobbyList.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyList_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyList_MergeFrom_Divine_Protobufs_Dota2_CMsgSpectatorLobbyList_"></a> MergeFrom\(CMsgSpectatorLobbyList\)

```csharp
public void MergeFrom(CMsgSpectatorLobbyList other)
```

#### Parameters

`other` [CMsgSpectatorLobbyList](Divine.Protobufs.Dota2.CMsgSpectatorLobbyList.md)

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyList_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyList_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSpectatorLobbyList_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

