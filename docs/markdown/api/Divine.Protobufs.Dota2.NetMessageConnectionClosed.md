# <a id="Divine_Protobufs_Dota2_NetMessageConnectionClosed"></a> Class NetMessageConnectionClosed

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class NetMessageConnectionClosed : IMessage<NetMessageConnectionClosed>, IEquatable<NetMessageConnectionClosed>, IDeepCloneable<NetMessageConnectionClosed>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[NetMessageConnectionClosed](Divine.Protobufs.Dota2.NetMessageConnectionClosed.md)

#### Implements

IMessage<NetMessageConnectionClosed\>, 
[IEquatable<NetMessageConnectionClosed\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<NetMessageConnectionClosed\>, 
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
[EnumerableExtensions.In<NetMessageConnectionClosed\>\(NetMessageConnectionClosed, params NetMessageConnectionClosed\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_NetMessageConnectionClosed__ctor"></a> NetMessageConnectionClosed\(\)

```csharp
public NetMessageConnectionClosed()
```

### <a id="Divine_Protobufs_Dota2_NetMessageConnectionClosed__ctor_Divine_Protobufs_Dota2_NetMessageConnectionClosed_"></a> NetMessageConnectionClosed\(NetMessageConnectionClosed\)

```csharp
public NetMessageConnectionClosed(NetMessageConnectionClosed other)
```

#### Parameters

`other` [NetMessageConnectionClosed](Divine.Protobufs.Dota2.NetMessageConnectionClosed.md)

## Fields

### <a id="Divine_Protobufs_Dota2_NetMessageConnectionClosed_MessageFieldNumber"></a> MessageFieldNumber

```csharp
public const int MessageFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_NetMessageConnectionClosed_ReasonFieldNumber"></a> ReasonFieldNumber

```csharp
public const int ReasonFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_NetMessageConnectionClosed_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_NetMessageConnectionClosed_HasMessage"></a> HasMessage

```csharp
public bool HasMessage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_NetMessageConnectionClosed_HasReason"></a> HasReason

```csharp
public bool HasReason { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_NetMessageConnectionClosed_Message"></a> Message

```csharp
public string Message { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_NetMessageConnectionClosed_Parser"></a> Parser

```csharp
public static MessageParser<NetMessageConnectionClosed> Parser { get; }
```

#### Property Value

 MessageParser<[NetMessageConnectionClosed](Divine.Protobufs.Dota2.NetMessageConnectionClosed.md)\>

### <a id="Divine_Protobufs_Dota2_NetMessageConnectionClosed_Reason"></a> Reason

```csharp
public uint Reason { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_NetMessageConnectionClosed_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_NetMessageConnectionClosed_ClearMessage"></a> ClearMessage\(\)

```csharp
public void ClearMessage()
```

### <a id="Divine_Protobufs_Dota2_NetMessageConnectionClosed_ClearReason"></a> ClearReason\(\)

```csharp
public void ClearReason()
```

### <a id="Divine_Protobufs_Dota2_NetMessageConnectionClosed_Clone"></a> Clone\(\)

```csharp
public NetMessageConnectionClosed Clone()
```

#### Returns

 [NetMessageConnectionClosed](Divine.Protobufs.Dota2.NetMessageConnectionClosed.md)

### <a id="Divine_Protobufs_Dota2_NetMessageConnectionClosed_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_NetMessageConnectionClosed_Equals_Divine_Protobufs_Dota2_NetMessageConnectionClosed_"></a> Equals\(NetMessageConnectionClosed\)

```csharp
public bool Equals(NetMessageConnectionClosed other)
```

#### Parameters

`other` [NetMessageConnectionClosed](Divine.Protobufs.Dota2.NetMessageConnectionClosed.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_NetMessageConnectionClosed_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_NetMessageConnectionClosed_MergeFrom_Divine_Protobufs_Dota2_NetMessageConnectionClosed_"></a> MergeFrom\(NetMessageConnectionClosed\)

```csharp
public void MergeFrom(NetMessageConnectionClosed other)
```

#### Parameters

`other` [NetMessageConnectionClosed](Divine.Protobufs.Dota2.NetMessageConnectionClosed.md)

### <a id="Divine_Protobufs_Dota2_NetMessageConnectionClosed_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_NetMessageConnectionClosed_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_NetMessageConnectionClosed_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

