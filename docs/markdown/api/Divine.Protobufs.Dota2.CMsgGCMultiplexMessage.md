# <a id="Divine_Protobufs_Dota2_CMsgGCMultiplexMessage"></a> Class CMsgGCMultiplexMessage

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCMultiplexMessage : IMessage<CMsgGCMultiplexMessage>, IEquatable<CMsgGCMultiplexMessage>, IDeepCloneable<CMsgGCMultiplexMessage>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCMultiplexMessage](Divine.Protobufs.Dota2.CMsgGCMultiplexMessage.md)

#### Implements

IMessage<CMsgGCMultiplexMessage\>, 
[IEquatable<CMsgGCMultiplexMessage\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCMultiplexMessage\>, 
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
[EnumerableExtensions.In<CMsgGCMultiplexMessage\>\(CMsgGCMultiplexMessage, params CMsgGCMultiplexMessage\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCMultiplexMessage__ctor"></a> CMsgGCMultiplexMessage\(\)

```csharp
public CMsgGCMultiplexMessage()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCMultiplexMessage__ctor_Divine_Protobufs_Dota2_CMsgGCMultiplexMessage_"></a> CMsgGCMultiplexMessage\(CMsgGCMultiplexMessage\)

```csharp
public CMsgGCMultiplexMessage(CMsgGCMultiplexMessage other)
```

#### Parameters

`other` [CMsgGCMultiplexMessage](Divine.Protobufs.Dota2.CMsgGCMultiplexMessage.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCMultiplexMessage_MsgtypeFieldNumber"></a> MsgtypeFieldNumber

```csharp
public const int MsgtypeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCMultiplexMessage_PayloadFieldNumber"></a> PayloadFieldNumber

```csharp
public const int PayloadFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCMultiplexMessage_SteamidsFieldNumber"></a> SteamidsFieldNumber

```csharp
public const int SteamidsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCMultiplexMessage_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCMultiplexMessage_HasMsgtype"></a> HasMsgtype

```csharp
public bool HasMsgtype { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCMultiplexMessage_HasPayload"></a> HasPayload

```csharp
public bool HasPayload { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCMultiplexMessage_Msgtype"></a> Msgtype

```csharp
public uint Msgtype { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCMultiplexMessage_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCMultiplexMessage> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCMultiplexMessage](Divine.Protobufs.Dota2.CMsgGCMultiplexMessage.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCMultiplexMessage_Payload"></a> Payload

```csharp
public ByteString Payload { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Dota2_CMsgGCMultiplexMessage_Steamids"></a> Steamids

```csharp
public RepeatedField<ulong> Steamids { get; }
```

#### Property Value

 RepeatedField<[ulong](https://learn.microsoft.com/dotnet/api/system.uint64)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCMultiplexMessage_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCMultiplexMessage_ClearMsgtype"></a> ClearMsgtype\(\)

```csharp
public void ClearMsgtype()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCMultiplexMessage_ClearPayload"></a> ClearPayload\(\)

```csharp
public void ClearPayload()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCMultiplexMessage_Clone"></a> Clone\(\)

```csharp
public CMsgGCMultiplexMessage Clone()
```

#### Returns

 [CMsgGCMultiplexMessage](Divine.Protobufs.Dota2.CMsgGCMultiplexMessage.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCMultiplexMessage_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCMultiplexMessage_Equals_Divine_Protobufs_Dota2_CMsgGCMultiplexMessage_"></a> Equals\(CMsgGCMultiplexMessage\)

```csharp
public bool Equals(CMsgGCMultiplexMessage other)
```

#### Parameters

`other` [CMsgGCMultiplexMessage](Divine.Protobufs.Dota2.CMsgGCMultiplexMessage.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCMultiplexMessage_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCMultiplexMessage_MergeFrom_Divine_Protobufs_Dota2_CMsgGCMultiplexMessage_"></a> MergeFrom\(CMsgGCMultiplexMessage\)

```csharp
public void MergeFrom(CMsgGCMultiplexMessage other)
```

#### Parameters

`other` [CMsgGCMultiplexMessage](Divine.Protobufs.Dota2.CMsgGCMultiplexMessage.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCMultiplexMessage_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCMultiplexMessage_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCMultiplexMessage_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

