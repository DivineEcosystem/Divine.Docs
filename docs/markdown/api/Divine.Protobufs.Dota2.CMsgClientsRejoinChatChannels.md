# <a id="Divine_Protobufs_Dota2_CMsgClientsRejoinChatChannels"></a> Class CMsgClientsRejoinChatChannels

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientsRejoinChatChannels : IMessage<CMsgClientsRejoinChatChannels>, IEquatable<CMsgClientsRejoinChatChannels>, IDeepCloneable<CMsgClientsRejoinChatChannels>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientsRejoinChatChannels](Divine.Protobufs.Dota2.CMsgClientsRejoinChatChannels.md)

#### Implements

IMessage<CMsgClientsRejoinChatChannels\>, 
[IEquatable<CMsgClientsRejoinChatChannels\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientsRejoinChatChannels\>, 
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
[EnumerableExtensions.In<CMsgClientsRejoinChatChannels\>\(CMsgClientsRejoinChatChannels, params CMsgClientsRejoinChatChannels\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientsRejoinChatChannels__ctor"></a> CMsgClientsRejoinChatChannels\(\)

```csharp
public CMsgClientsRejoinChatChannels()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientsRejoinChatChannels__ctor_Divine_Protobufs_Dota2_CMsgClientsRejoinChatChannels_"></a> CMsgClientsRejoinChatChannels\(CMsgClientsRejoinChatChannels\)

```csharp
public CMsgClientsRejoinChatChannels(CMsgClientsRejoinChatChannels other)
```

#### Parameters

`other` [CMsgClientsRejoinChatChannels](Divine.Protobufs.Dota2.CMsgClientsRejoinChatChannels.md)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientsRejoinChatChannels_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientsRejoinChatChannels_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientsRejoinChatChannels> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientsRejoinChatChannels](Divine.Protobufs.Dota2.CMsgClientsRejoinChatChannels.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientsRejoinChatChannels_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientsRejoinChatChannels_Clone"></a> Clone\(\)

```csharp
public CMsgClientsRejoinChatChannels Clone()
```

#### Returns

 [CMsgClientsRejoinChatChannels](Divine.Protobufs.Dota2.CMsgClientsRejoinChatChannels.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientsRejoinChatChannels_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientsRejoinChatChannels_Equals_Divine_Protobufs_Dota2_CMsgClientsRejoinChatChannels_"></a> Equals\(CMsgClientsRejoinChatChannels\)

```csharp
public bool Equals(CMsgClientsRejoinChatChannels other)
```

#### Parameters

`other` [CMsgClientsRejoinChatChannels](Divine.Protobufs.Dota2.CMsgClientsRejoinChatChannels.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientsRejoinChatChannels_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientsRejoinChatChannels_MergeFrom_Divine_Protobufs_Dota2_CMsgClientsRejoinChatChannels_"></a> MergeFrom\(CMsgClientsRejoinChatChannels\)

```csharp
public void MergeFrom(CMsgClientsRejoinChatChannels other)
```

#### Parameters

`other` [CMsgClientsRejoinChatChannels](Divine.Protobufs.Dota2.CMsgClientsRejoinChatChannels.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientsRejoinChatChannels_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientsRejoinChatChannels_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientsRejoinChatChannels_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

