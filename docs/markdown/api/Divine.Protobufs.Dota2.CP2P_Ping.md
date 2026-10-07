# <a id="Divine_Protobufs_Dota2_CP2P_Ping"></a> Class CP2P\_Ping

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CP2P_Ping : IMessage<CP2P_Ping>, IEquatable<CP2P_Ping>, IDeepCloneable<CP2P_Ping>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CP2P\_Ping](Divine.Protobufs.Dota2.CP2P\_Ping.md)

#### Implements

IMessage<CP2P\_Ping\>, 
[IEquatable<CP2P\_Ping\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CP2P\_Ping\>, 
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
[EnumerableExtensions.In<CP2P\_Ping\>\(CP2P\_Ping, params CP2P\_Ping\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CP2P_Ping__ctor"></a> CP2P\_Ping\(\)

```csharp
public CP2P_Ping()
```

### <a id="Divine_Protobufs_Dota2_CP2P_Ping__ctor_Divine_Protobufs_Dota2_CP2P_Ping_"></a> CP2P\_Ping\(CP2P\_Ping\)

```csharp
public CP2P_Ping(CP2P_Ping other)
```

#### Parameters

`other` [CP2P\_Ping](Divine.Protobufs.Dota2.CP2P\_Ping.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CP2P_Ping_IsReplyFieldNumber"></a> IsReplyFieldNumber

```csharp
public const int IsReplyFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CP2P_Ping_SendTimeFieldNumber"></a> SendTimeFieldNumber

```csharp
public const int SendTimeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CP2P_Ping_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CP2P_Ping_HasIsReply"></a> HasIsReply

```csharp
public bool HasIsReply { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CP2P_Ping_HasSendTime"></a> HasSendTime

```csharp
public bool HasSendTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CP2P_Ping_IsReply"></a> IsReply

```csharp
public bool IsReply { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CP2P_Ping_Parser"></a> Parser

```csharp
public static MessageParser<CP2P_Ping> Parser { get; }
```

#### Property Value

 MessageParser<[CP2P\_Ping](Divine.Protobufs.Dota2.CP2P\_Ping.md)\>

### <a id="Divine_Protobufs_Dota2_CP2P_Ping_SendTime"></a> SendTime

```csharp
public ulong SendTime { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CP2P_Ping_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CP2P_Ping_ClearIsReply"></a> ClearIsReply\(\)

```csharp
public void ClearIsReply()
```

### <a id="Divine_Protobufs_Dota2_CP2P_Ping_ClearSendTime"></a> ClearSendTime\(\)

```csharp
public void ClearSendTime()
```

### <a id="Divine_Protobufs_Dota2_CP2P_Ping_Clone"></a> Clone\(\)

```csharp
public CP2P_Ping Clone()
```

#### Returns

 [CP2P\_Ping](Divine.Protobufs.Dota2.CP2P\_Ping.md)

### <a id="Divine_Protobufs_Dota2_CP2P_Ping_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CP2P_Ping_Equals_Divine_Protobufs_Dota2_CP2P_Ping_"></a> Equals\(CP2P\_Ping\)

```csharp
public bool Equals(CP2P_Ping other)
```

#### Parameters

`other` [CP2P\_Ping](Divine.Protobufs.Dota2.CP2P\_Ping.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CP2P_Ping_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CP2P_Ping_MergeFrom_Divine_Protobufs_Dota2_CP2P_Ping_"></a> MergeFrom\(CP2P\_Ping\)

```csharp
public void MergeFrom(CP2P_Ping other)
```

#### Parameters

`other` [CP2P\_Ping](Divine.Protobufs.Dota2.CP2P\_Ping.md)

### <a id="Divine_Protobufs_Dota2_CP2P_Ping_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CP2P_Ping_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CP2P_Ping_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

