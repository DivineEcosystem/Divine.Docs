# <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketReliable"></a> Class CSVCMsg\_PacketReliable

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSVCMsg_PacketReliable : IMessage<CSVCMsg_PacketReliable>, IEquatable<CSVCMsg_PacketReliable>, IDeepCloneable<CSVCMsg_PacketReliable>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSVCMsg\_PacketReliable](Divine.Protobufs.Dota2.CSVCMsg\_PacketReliable.md)

#### Implements

IMessage<CSVCMsg\_PacketReliable\>, 
[IEquatable<CSVCMsg\_PacketReliable\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSVCMsg\_PacketReliable\>, 
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
[EnumerableExtensions.In<CSVCMsg\_PacketReliable\>\(CSVCMsg\_PacketReliable, params CSVCMsg\_PacketReliable\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketReliable__ctor"></a> CSVCMsg\_PacketReliable\(\)

```csharp
public CSVCMsg_PacketReliable()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketReliable__ctor_Divine_Protobufs_Dota2_CSVCMsg_PacketReliable_"></a> CSVCMsg\_PacketReliable\(CSVCMsg\_PacketReliable\)

```csharp
public CSVCMsg_PacketReliable(CSVCMsg_PacketReliable other)
```

#### Parameters

`other` [CSVCMsg\_PacketReliable](Divine.Protobufs.Dota2.CSVCMsg\_PacketReliable.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketReliable_MessagessizeFieldNumber"></a> MessagessizeFieldNumber

```csharp
public const int MessagessizeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketReliable_StateFieldNumber"></a> StateFieldNumber

```csharp
public const int StateFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketReliable_TickFieldNumber"></a> TickFieldNumber

```csharp
public const int TickFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketReliable_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketReliable_HasMessagessize"></a> HasMessagessize

```csharp
public bool HasMessagessize { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketReliable_HasState"></a> HasState

```csharp
public bool HasState { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketReliable_HasTick"></a> HasTick

```csharp
public bool HasTick { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketReliable_Messagessize"></a> Messagessize

```csharp
public int Messagessize { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketReliable_Parser"></a> Parser

```csharp
public static MessageParser<CSVCMsg_PacketReliable> Parser { get; }
```

#### Property Value

 MessageParser<[CSVCMsg\_PacketReliable](Divine.Protobufs.Dota2.CSVCMsg\_PacketReliable.md)\>

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketReliable_State"></a> State

```csharp
public bool State { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketReliable_Tick"></a> Tick

```csharp
public int Tick { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketReliable_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketReliable_ClearMessagessize"></a> ClearMessagessize\(\)

```csharp
public void ClearMessagessize()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketReliable_ClearState"></a> ClearState\(\)

```csharp
public void ClearState()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketReliable_ClearTick"></a> ClearTick\(\)

```csharp
public void ClearTick()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketReliable_Clone"></a> Clone\(\)

```csharp
public CSVCMsg_PacketReliable Clone()
```

#### Returns

 [CSVCMsg\_PacketReliable](Divine.Protobufs.Dota2.CSVCMsg\_PacketReliable.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketReliable_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketReliable_Equals_Divine_Protobufs_Dota2_CSVCMsg_PacketReliable_"></a> Equals\(CSVCMsg\_PacketReliable\)

```csharp
public bool Equals(CSVCMsg_PacketReliable other)
```

#### Parameters

`other` [CSVCMsg\_PacketReliable](Divine.Protobufs.Dota2.CSVCMsg\_PacketReliable.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketReliable_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketReliable_MergeFrom_Divine_Protobufs_Dota2_CSVCMsg_PacketReliable_"></a> MergeFrom\(CSVCMsg\_PacketReliable\)

```csharp
public void MergeFrom(CSVCMsg_PacketReliable other)
```

#### Parameters

`other` [CSVCMsg\_PacketReliable](Divine.Protobufs.Dota2.CSVCMsg\_PacketReliable.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketReliable_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketReliable_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketReliable_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

