# <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyCloseBroadcastChannel"></a> Class CMsgPracticeLobbyCloseBroadcastChannel

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgPracticeLobbyCloseBroadcastChannel : IMessage<CMsgPracticeLobbyCloseBroadcastChannel>, IEquatable<CMsgPracticeLobbyCloseBroadcastChannel>, IDeepCloneable<CMsgPracticeLobbyCloseBroadcastChannel>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgPracticeLobbyCloseBroadcastChannel](Divine.Protobufs.Dota2.CMsgPracticeLobbyCloseBroadcastChannel.md)

#### Implements

IMessage<CMsgPracticeLobbyCloseBroadcastChannel\>, 
[IEquatable<CMsgPracticeLobbyCloseBroadcastChannel\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgPracticeLobbyCloseBroadcastChannel\>, 
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
[EnumerableExtensions.In<CMsgPracticeLobbyCloseBroadcastChannel\>\(CMsgPracticeLobbyCloseBroadcastChannel, params CMsgPracticeLobbyCloseBroadcastChannel\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyCloseBroadcastChannel__ctor"></a> CMsgPracticeLobbyCloseBroadcastChannel\(\)

```csharp
public CMsgPracticeLobbyCloseBroadcastChannel()
```

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyCloseBroadcastChannel__ctor_Divine_Protobufs_Dota2_CMsgPracticeLobbyCloseBroadcastChannel_"></a> CMsgPracticeLobbyCloseBroadcastChannel\(CMsgPracticeLobbyCloseBroadcastChannel\)

```csharp
public CMsgPracticeLobbyCloseBroadcastChannel(CMsgPracticeLobbyCloseBroadcastChannel other)
```

#### Parameters

`other` [CMsgPracticeLobbyCloseBroadcastChannel](Divine.Protobufs.Dota2.CMsgPracticeLobbyCloseBroadcastChannel.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyCloseBroadcastChannel_ChannelFieldNumber"></a> ChannelFieldNumber

```csharp
public const int ChannelFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyCloseBroadcastChannel_Channel"></a> Channel

```csharp
public uint Channel { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyCloseBroadcastChannel_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyCloseBroadcastChannel_HasChannel"></a> HasChannel

```csharp
public bool HasChannel { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyCloseBroadcastChannel_Parser"></a> Parser

```csharp
public static MessageParser<CMsgPracticeLobbyCloseBroadcastChannel> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgPracticeLobbyCloseBroadcastChannel](Divine.Protobufs.Dota2.CMsgPracticeLobbyCloseBroadcastChannel.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyCloseBroadcastChannel_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyCloseBroadcastChannel_ClearChannel"></a> ClearChannel\(\)

```csharp
public void ClearChannel()
```

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyCloseBroadcastChannel_Clone"></a> Clone\(\)

```csharp
public CMsgPracticeLobbyCloseBroadcastChannel Clone()
```

#### Returns

 [CMsgPracticeLobbyCloseBroadcastChannel](Divine.Protobufs.Dota2.CMsgPracticeLobbyCloseBroadcastChannel.md)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyCloseBroadcastChannel_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyCloseBroadcastChannel_Equals_Divine_Protobufs_Dota2_CMsgPracticeLobbyCloseBroadcastChannel_"></a> Equals\(CMsgPracticeLobbyCloseBroadcastChannel\)

```csharp
public bool Equals(CMsgPracticeLobbyCloseBroadcastChannel other)
```

#### Parameters

`other` [CMsgPracticeLobbyCloseBroadcastChannel](Divine.Protobufs.Dota2.CMsgPracticeLobbyCloseBroadcastChannel.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyCloseBroadcastChannel_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyCloseBroadcastChannel_MergeFrom_Divine_Protobufs_Dota2_CMsgPracticeLobbyCloseBroadcastChannel_"></a> MergeFrom\(CMsgPracticeLobbyCloseBroadcastChannel\)

```csharp
public void MergeFrom(CMsgPracticeLobbyCloseBroadcastChannel other)
```

#### Parameters

`other` [CMsgPracticeLobbyCloseBroadcastChannel](Divine.Protobufs.Dota2.CMsgPracticeLobbyCloseBroadcastChannel.md)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyCloseBroadcastChannel_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyCloseBroadcastChannel_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyCloseBroadcastChannel_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

