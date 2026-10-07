# <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetFilteredPlayers"></a> Class CMsgClientToGCGetFilteredPlayers

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCGetFilteredPlayers : IMessage<CMsgClientToGCGetFilteredPlayers>, IEquatable<CMsgClientToGCGetFilteredPlayers>, IDeepCloneable<CMsgClientToGCGetFilteredPlayers>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCGetFilteredPlayers](Divine.Protobufs.Dota2.CMsgClientToGCGetFilteredPlayers.md)

#### Implements

IMessage<CMsgClientToGCGetFilteredPlayers\>, 
[IEquatable<CMsgClientToGCGetFilteredPlayers\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCGetFilteredPlayers\>, 
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
[EnumerableExtensions.In<CMsgClientToGCGetFilteredPlayers\>\(CMsgClientToGCGetFilteredPlayers, params CMsgClientToGCGetFilteredPlayers\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetFilteredPlayers__ctor"></a> CMsgClientToGCGetFilteredPlayers\(\)

```csharp
public CMsgClientToGCGetFilteredPlayers()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetFilteredPlayers__ctor_Divine_Protobufs_Dota2_CMsgClientToGCGetFilteredPlayers_"></a> CMsgClientToGCGetFilteredPlayers\(CMsgClientToGCGetFilteredPlayers\)

```csharp
public CMsgClientToGCGetFilteredPlayers(CMsgClientToGCGetFilteredPlayers other)
```

#### Parameters

`other` [CMsgClientToGCGetFilteredPlayers](Divine.Protobufs.Dota2.CMsgClientToGCGetFilteredPlayers.md)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetFilteredPlayers_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetFilteredPlayers_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCGetFilteredPlayers> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCGetFilteredPlayers](Divine.Protobufs.Dota2.CMsgClientToGCGetFilteredPlayers.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetFilteredPlayers_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetFilteredPlayers_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCGetFilteredPlayers Clone()
```

#### Returns

 [CMsgClientToGCGetFilteredPlayers](Divine.Protobufs.Dota2.CMsgClientToGCGetFilteredPlayers.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetFilteredPlayers_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetFilteredPlayers_Equals_Divine_Protobufs_Dota2_CMsgClientToGCGetFilteredPlayers_"></a> Equals\(CMsgClientToGCGetFilteredPlayers\)

```csharp
public bool Equals(CMsgClientToGCGetFilteredPlayers other)
```

#### Parameters

`other` [CMsgClientToGCGetFilteredPlayers](Divine.Protobufs.Dota2.CMsgClientToGCGetFilteredPlayers.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetFilteredPlayers_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetFilteredPlayers_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCGetFilteredPlayers_"></a> MergeFrom\(CMsgClientToGCGetFilteredPlayers\)

```csharp
public void MergeFrom(CMsgClientToGCGetFilteredPlayers other)
```

#### Parameters

`other` [CMsgClientToGCGetFilteredPlayers](Divine.Protobufs.Dota2.CMsgClientToGCGetFilteredPlayers.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetFilteredPlayers_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetFilteredPlayers_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetFilteredPlayers_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

