# <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueAvailableLobbyNodes"></a> Class CMsgDOTALeagueAvailableLobbyNodes

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTALeagueAvailableLobbyNodes : IMessage<CMsgDOTALeagueAvailableLobbyNodes>, IEquatable<CMsgDOTALeagueAvailableLobbyNodes>, IDeepCloneable<CMsgDOTALeagueAvailableLobbyNodes>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTALeagueAvailableLobbyNodes](Divine.Protobufs.Dota2.CMsgDOTALeagueAvailableLobbyNodes.md)

#### Implements

IMessage<CMsgDOTALeagueAvailableLobbyNodes\>, 
[IEquatable<CMsgDOTALeagueAvailableLobbyNodes\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTALeagueAvailableLobbyNodes\>, 
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
[EnumerableExtensions.In<CMsgDOTALeagueAvailableLobbyNodes\>\(CMsgDOTALeagueAvailableLobbyNodes, params CMsgDOTALeagueAvailableLobbyNodes\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueAvailableLobbyNodes__ctor"></a> CMsgDOTALeagueAvailableLobbyNodes\(\)

```csharp
public CMsgDOTALeagueAvailableLobbyNodes()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueAvailableLobbyNodes__ctor_Divine_Protobufs_Dota2_CMsgDOTALeagueAvailableLobbyNodes_"></a> CMsgDOTALeagueAvailableLobbyNodes\(CMsgDOTALeagueAvailableLobbyNodes\)

```csharp
public CMsgDOTALeagueAvailableLobbyNodes(CMsgDOTALeagueAvailableLobbyNodes other)
```

#### Parameters

`other` [CMsgDOTALeagueAvailableLobbyNodes](Divine.Protobufs.Dota2.CMsgDOTALeagueAvailableLobbyNodes.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueAvailableLobbyNodes_NodeInfosFieldNumber"></a> NodeInfosFieldNumber

```csharp
public const int NodeInfosFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueAvailableLobbyNodes_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueAvailableLobbyNodes_NodeInfos"></a> NodeInfos

```csharp
public RepeatedField<CMsgDOTALeagueAvailableLobbyNodes.Types.NodeInfo> NodeInfos { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTALeagueAvailableLobbyNodes](Divine.Protobufs.Dota2.CMsgDOTALeagueAvailableLobbyNodes.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeagueAvailableLobbyNodes.Types.md).[NodeInfo](Divine.Protobufs.Dota2.CMsgDOTALeagueAvailableLobbyNodes.Types.NodeInfo.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueAvailableLobbyNodes_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTALeagueAvailableLobbyNodes> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTALeagueAvailableLobbyNodes](Divine.Protobufs.Dota2.CMsgDOTALeagueAvailableLobbyNodes.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueAvailableLobbyNodes_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueAvailableLobbyNodes_Clone"></a> Clone\(\)

```csharp
public CMsgDOTALeagueAvailableLobbyNodes Clone()
```

#### Returns

 [CMsgDOTALeagueAvailableLobbyNodes](Divine.Protobufs.Dota2.CMsgDOTALeagueAvailableLobbyNodes.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueAvailableLobbyNodes_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueAvailableLobbyNodes_Equals_Divine_Protobufs_Dota2_CMsgDOTALeagueAvailableLobbyNodes_"></a> Equals\(CMsgDOTALeagueAvailableLobbyNodes\)

```csharp
public bool Equals(CMsgDOTALeagueAvailableLobbyNodes other)
```

#### Parameters

`other` [CMsgDOTALeagueAvailableLobbyNodes](Divine.Protobufs.Dota2.CMsgDOTALeagueAvailableLobbyNodes.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueAvailableLobbyNodes_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueAvailableLobbyNodes_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTALeagueAvailableLobbyNodes_"></a> MergeFrom\(CMsgDOTALeagueAvailableLobbyNodes\)

```csharp
public void MergeFrom(CMsgDOTALeagueAvailableLobbyNodes other)
```

#### Parameters

`other` [CMsgDOTALeagueAvailableLobbyNodes](Divine.Protobufs.Dota2.CMsgDOTALeagueAvailableLobbyNodes.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueAvailableLobbyNodes_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueAvailableLobbyNodes_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueAvailableLobbyNodes_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

