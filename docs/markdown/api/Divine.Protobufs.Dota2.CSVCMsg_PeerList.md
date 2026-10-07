# <a id="Divine_Protobufs_Dota2_CSVCMsg_PeerList"></a> Class CSVCMsg\_PeerList

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSVCMsg_PeerList : IMessage<CSVCMsg_PeerList>, IEquatable<CSVCMsg_PeerList>, IDeepCloneable<CSVCMsg_PeerList>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSVCMsg\_PeerList](Divine.Protobufs.Dota2.CSVCMsg\_PeerList.md)

#### Implements

IMessage<CSVCMsg\_PeerList\>, 
[IEquatable<CSVCMsg\_PeerList\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSVCMsg\_PeerList\>, 
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
[EnumerableExtensions.In<CSVCMsg\_PeerList\>\(CSVCMsg\_PeerList, params CSVCMsg\_PeerList\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PeerList__ctor"></a> CSVCMsg\_PeerList\(\)

```csharp
public CSVCMsg_PeerList()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PeerList__ctor_Divine_Protobufs_Dota2_CSVCMsg_PeerList_"></a> CSVCMsg\_PeerList\(CSVCMsg\_PeerList\)

```csharp
public CSVCMsg_PeerList(CSVCMsg_PeerList other)
```

#### Parameters

`other` [CSVCMsg\_PeerList](Divine.Protobufs.Dota2.CSVCMsg\_PeerList.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PeerList_PeerFieldNumber"></a> PeerFieldNumber

```csharp
public const int PeerFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PeerList_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PeerList_Parser"></a> Parser

```csharp
public static MessageParser<CSVCMsg_PeerList> Parser { get; }
```

#### Property Value

 MessageParser<[CSVCMsg\_PeerList](Divine.Protobufs.Dota2.CSVCMsg\_PeerList.md)\>

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PeerList_Peer"></a> Peer

```csharp
public RepeatedField<CMsgServerPeer> Peer { get; }
```

#### Property Value

 RepeatedField<[CMsgServerPeer](Divine.Protobufs.Dota2.CMsgServerPeer.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PeerList_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PeerList_Clone"></a> Clone\(\)

```csharp
public CSVCMsg_PeerList Clone()
```

#### Returns

 [CSVCMsg\_PeerList](Divine.Protobufs.Dota2.CSVCMsg\_PeerList.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PeerList_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PeerList_Equals_Divine_Protobufs_Dota2_CSVCMsg_PeerList_"></a> Equals\(CSVCMsg\_PeerList\)

```csharp
public bool Equals(CSVCMsg_PeerList other)
```

#### Parameters

`other` [CSVCMsg\_PeerList](Divine.Protobufs.Dota2.CSVCMsg\_PeerList.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PeerList_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PeerList_MergeFrom_Divine_Protobufs_Dota2_CSVCMsg_PeerList_"></a> MergeFrom\(CSVCMsg\_PeerList\)

```csharp
public void MergeFrom(CSVCMsg_PeerList other)
```

#### Parameters

`other` [CSVCMsg\_PeerList](Divine.Protobufs.Dota2.CSVCMsg\_PeerList.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PeerList_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PeerList_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PeerList_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

