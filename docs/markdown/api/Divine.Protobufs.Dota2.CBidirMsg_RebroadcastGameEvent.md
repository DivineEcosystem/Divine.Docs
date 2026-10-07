# <a id="Divine_Protobufs_Dota2_CBidirMsg_RebroadcastGameEvent"></a> Class CBidirMsg\_RebroadcastGameEvent

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CBidirMsg_RebroadcastGameEvent : IMessage<CBidirMsg_RebroadcastGameEvent>, IEquatable<CBidirMsg_RebroadcastGameEvent>, IDeepCloneable<CBidirMsg_RebroadcastGameEvent>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CBidirMsg\_RebroadcastGameEvent](Divine.Protobufs.Dota2.CBidirMsg\_RebroadcastGameEvent.md)

#### Implements

IMessage<CBidirMsg\_RebroadcastGameEvent\>, 
[IEquatable<CBidirMsg\_RebroadcastGameEvent\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CBidirMsg\_RebroadcastGameEvent\>, 
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
[EnumerableExtensions.In<CBidirMsg\_RebroadcastGameEvent\>\(CBidirMsg\_RebroadcastGameEvent, params CBidirMsg\_RebroadcastGameEvent\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CBidirMsg_RebroadcastGameEvent__ctor"></a> CBidirMsg\_RebroadcastGameEvent\(\)

```csharp
public CBidirMsg_RebroadcastGameEvent()
```

### <a id="Divine_Protobufs_Dota2_CBidirMsg_RebroadcastGameEvent__ctor_Divine_Protobufs_Dota2_CBidirMsg_RebroadcastGameEvent_"></a> CBidirMsg\_RebroadcastGameEvent\(CBidirMsg\_RebroadcastGameEvent\)

```csharp
public CBidirMsg_RebroadcastGameEvent(CBidirMsg_RebroadcastGameEvent other)
```

#### Parameters

`other` [CBidirMsg\_RebroadcastGameEvent](Divine.Protobufs.Dota2.CBidirMsg\_RebroadcastGameEvent.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CBidirMsg_RebroadcastGameEvent_BuftypeFieldNumber"></a> BuftypeFieldNumber

```csharp
public const int BuftypeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CBidirMsg_RebroadcastGameEvent_ClientbitcountFieldNumber"></a> ClientbitcountFieldNumber

```csharp
public const int ClientbitcountFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CBidirMsg_RebroadcastGameEvent_PosttoserverFieldNumber"></a> PosttoserverFieldNumber

```csharp
public const int PosttoserverFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CBidirMsg_RebroadcastGameEvent_ReceivingclientsFieldNumber"></a> ReceivingclientsFieldNumber

```csharp
public const int ReceivingclientsFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CBidirMsg_RebroadcastGameEvent_Buftype"></a> Buftype

```csharp
public int Buftype { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CBidirMsg_RebroadcastGameEvent_Clientbitcount"></a> Clientbitcount

```csharp
public uint Clientbitcount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CBidirMsg_RebroadcastGameEvent_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CBidirMsg_RebroadcastGameEvent_HasBuftype"></a> HasBuftype

```csharp
public bool HasBuftype { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CBidirMsg_RebroadcastGameEvent_HasClientbitcount"></a> HasClientbitcount

```csharp
public bool HasClientbitcount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CBidirMsg_RebroadcastGameEvent_HasPosttoserver"></a> HasPosttoserver

```csharp
public bool HasPosttoserver { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CBidirMsg_RebroadcastGameEvent_HasReceivingclients"></a> HasReceivingclients

```csharp
public bool HasReceivingclients { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CBidirMsg_RebroadcastGameEvent_Parser"></a> Parser

```csharp
public static MessageParser<CBidirMsg_RebroadcastGameEvent> Parser { get; }
```

#### Property Value

 MessageParser<[CBidirMsg\_RebroadcastGameEvent](Divine.Protobufs.Dota2.CBidirMsg\_RebroadcastGameEvent.md)\>

### <a id="Divine_Protobufs_Dota2_CBidirMsg_RebroadcastGameEvent_Posttoserver"></a> Posttoserver

```csharp
public bool Posttoserver { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CBidirMsg_RebroadcastGameEvent_Receivingclients"></a> Receivingclients

```csharp
public ulong Receivingclients { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CBidirMsg_RebroadcastGameEvent_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CBidirMsg_RebroadcastGameEvent_ClearBuftype"></a> ClearBuftype\(\)

```csharp
public void ClearBuftype()
```

### <a id="Divine_Protobufs_Dota2_CBidirMsg_RebroadcastGameEvent_ClearClientbitcount"></a> ClearClientbitcount\(\)

```csharp
public void ClearClientbitcount()
```

### <a id="Divine_Protobufs_Dota2_CBidirMsg_RebroadcastGameEvent_ClearPosttoserver"></a> ClearPosttoserver\(\)

```csharp
public void ClearPosttoserver()
```

### <a id="Divine_Protobufs_Dota2_CBidirMsg_RebroadcastGameEvent_ClearReceivingclients"></a> ClearReceivingclients\(\)

```csharp
public void ClearReceivingclients()
```

### <a id="Divine_Protobufs_Dota2_CBidirMsg_RebroadcastGameEvent_Clone"></a> Clone\(\)

```csharp
public CBidirMsg_RebroadcastGameEvent Clone()
```

#### Returns

 [CBidirMsg\_RebroadcastGameEvent](Divine.Protobufs.Dota2.CBidirMsg\_RebroadcastGameEvent.md)

### <a id="Divine_Protobufs_Dota2_CBidirMsg_RebroadcastGameEvent_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CBidirMsg_RebroadcastGameEvent_Equals_Divine_Protobufs_Dota2_CBidirMsg_RebroadcastGameEvent_"></a> Equals\(CBidirMsg\_RebroadcastGameEvent\)

```csharp
public bool Equals(CBidirMsg_RebroadcastGameEvent other)
```

#### Parameters

`other` [CBidirMsg\_RebroadcastGameEvent](Divine.Protobufs.Dota2.CBidirMsg\_RebroadcastGameEvent.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CBidirMsg_RebroadcastGameEvent_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CBidirMsg_RebroadcastGameEvent_MergeFrom_Divine_Protobufs_Dota2_CBidirMsg_RebroadcastGameEvent_"></a> MergeFrom\(CBidirMsg\_RebroadcastGameEvent\)

```csharp
public void MergeFrom(CBidirMsg_RebroadcastGameEvent other)
```

#### Parameters

`other` [CBidirMsg\_RebroadcastGameEvent](Divine.Protobufs.Dota2.CBidirMsg\_RebroadcastGameEvent.md)

### <a id="Divine_Protobufs_Dota2_CBidirMsg_RebroadcastGameEvent_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CBidirMsg_RebroadcastGameEvent_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CBidirMsg_RebroadcastGameEvent_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

