# <a id="Divine_Protobufs_Dota2_NetMessageSplitscreenUserChanged"></a> Class NetMessageSplitscreenUserChanged

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class NetMessageSplitscreenUserChanged : IMessage<NetMessageSplitscreenUserChanged>, IEquatable<NetMessageSplitscreenUserChanged>, IDeepCloneable<NetMessageSplitscreenUserChanged>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[NetMessageSplitscreenUserChanged](Divine.Protobufs.Dota2.NetMessageSplitscreenUserChanged.md)

#### Implements

IMessage<NetMessageSplitscreenUserChanged\>, 
[IEquatable<NetMessageSplitscreenUserChanged\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<NetMessageSplitscreenUserChanged\>, 
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
[EnumerableExtensions.In<NetMessageSplitscreenUserChanged\>\(NetMessageSplitscreenUserChanged, params NetMessageSplitscreenUserChanged\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_NetMessageSplitscreenUserChanged__ctor"></a> NetMessageSplitscreenUserChanged\(\)

```csharp
public NetMessageSplitscreenUserChanged()
```

### <a id="Divine_Protobufs_Dota2_NetMessageSplitscreenUserChanged__ctor_Divine_Protobufs_Dota2_NetMessageSplitscreenUserChanged_"></a> NetMessageSplitscreenUserChanged\(NetMessageSplitscreenUserChanged\)

```csharp
public NetMessageSplitscreenUserChanged(NetMessageSplitscreenUserChanged other)
```

#### Parameters

`other` [NetMessageSplitscreenUserChanged](Divine.Protobufs.Dota2.NetMessageSplitscreenUserChanged.md)

## Fields

### <a id="Divine_Protobufs_Dota2_NetMessageSplitscreenUserChanged_SlotFieldNumber"></a> SlotFieldNumber

```csharp
public const int SlotFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_NetMessageSplitscreenUserChanged_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_NetMessageSplitscreenUserChanged_HasSlot"></a> HasSlot

```csharp
public bool HasSlot { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_NetMessageSplitscreenUserChanged_Parser"></a> Parser

```csharp
public static MessageParser<NetMessageSplitscreenUserChanged> Parser { get; }
```

#### Property Value

 MessageParser<[NetMessageSplitscreenUserChanged](Divine.Protobufs.Dota2.NetMessageSplitscreenUserChanged.md)\>

### <a id="Divine_Protobufs_Dota2_NetMessageSplitscreenUserChanged_Slot"></a> Slot

```csharp
public uint Slot { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_NetMessageSplitscreenUserChanged_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_NetMessageSplitscreenUserChanged_ClearSlot"></a> ClearSlot\(\)

```csharp
public void ClearSlot()
```

### <a id="Divine_Protobufs_Dota2_NetMessageSplitscreenUserChanged_Clone"></a> Clone\(\)

```csharp
public NetMessageSplitscreenUserChanged Clone()
```

#### Returns

 [NetMessageSplitscreenUserChanged](Divine.Protobufs.Dota2.NetMessageSplitscreenUserChanged.md)

### <a id="Divine_Protobufs_Dota2_NetMessageSplitscreenUserChanged_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_NetMessageSplitscreenUserChanged_Equals_Divine_Protobufs_Dota2_NetMessageSplitscreenUserChanged_"></a> Equals\(NetMessageSplitscreenUserChanged\)

```csharp
public bool Equals(NetMessageSplitscreenUserChanged other)
```

#### Parameters

`other` [NetMessageSplitscreenUserChanged](Divine.Protobufs.Dota2.NetMessageSplitscreenUserChanged.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_NetMessageSplitscreenUserChanged_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_NetMessageSplitscreenUserChanged_MergeFrom_Divine_Protobufs_Dota2_NetMessageSplitscreenUserChanged_"></a> MergeFrom\(NetMessageSplitscreenUserChanged\)

```csharp
public void MergeFrom(NetMessageSplitscreenUserChanged other)
```

#### Parameters

`other` [NetMessageSplitscreenUserChanged](Divine.Protobufs.Dota2.NetMessageSplitscreenUserChanged.md)

### <a id="Divine_Protobufs_Dota2_NetMessageSplitscreenUserChanged_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_NetMessageSplitscreenUserChanged_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_NetMessageSplitscreenUserChanged_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

