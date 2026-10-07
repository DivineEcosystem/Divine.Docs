# <a id="Divine_Protobufs_Dota2_CMsgClearEntityDecalsEvent"></a> Class CMsgClearEntityDecalsEvent

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClearEntityDecalsEvent : IMessage<CMsgClearEntityDecalsEvent>, IEquatable<CMsgClearEntityDecalsEvent>, IDeepCloneable<CMsgClearEntityDecalsEvent>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClearEntityDecalsEvent](Divine.Protobufs.Dota2.CMsgClearEntityDecalsEvent.md)

#### Implements

IMessage<CMsgClearEntityDecalsEvent\>, 
[IEquatable<CMsgClearEntityDecalsEvent\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClearEntityDecalsEvent\>, 
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
[EnumerableExtensions.In<CMsgClearEntityDecalsEvent\>\(CMsgClearEntityDecalsEvent, params CMsgClearEntityDecalsEvent\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClearEntityDecalsEvent__ctor"></a> CMsgClearEntityDecalsEvent\(\)

```csharp
public CMsgClearEntityDecalsEvent()
```

### <a id="Divine_Protobufs_Dota2_CMsgClearEntityDecalsEvent__ctor_Divine_Protobufs_Dota2_CMsgClearEntityDecalsEvent_"></a> CMsgClearEntityDecalsEvent\(CMsgClearEntityDecalsEvent\)

```csharp
public CMsgClearEntityDecalsEvent(CMsgClearEntityDecalsEvent other)
```

#### Parameters

`other` [CMsgClearEntityDecalsEvent](Divine.Protobufs.Dota2.CMsgClearEntityDecalsEvent.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClearEntityDecalsEvent_FlagstoclearFieldNumber"></a> FlagstoclearFieldNumber

```csharp
public const int FlagstoclearFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClearEntityDecalsEvent_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClearEntityDecalsEvent_Flagstoclear"></a> Flagstoclear

```csharp
public uint Flagstoclear { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClearEntityDecalsEvent_HasFlagstoclear"></a> HasFlagstoclear

```csharp
public bool HasFlagstoclear { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClearEntityDecalsEvent_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClearEntityDecalsEvent> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClearEntityDecalsEvent](Divine.Protobufs.Dota2.CMsgClearEntityDecalsEvent.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClearEntityDecalsEvent_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClearEntityDecalsEvent_ClearFlagstoclear"></a> ClearFlagstoclear\(\)

```csharp
public void ClearFlagstoclear()
```

### <a id="Divine_Protobufs_Dota2_CMsgClearEntityDecalsEvent_Clone"></a> Clone\(\)

```csharp
public CMsgClearEntityDecalsEvent Clone()
```

#### Returns

 [CMsgClearEntityDecalsEvent](Divine.Protobufs.Dota2.CMsgClearEntityDecalsEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgClearEntityDecalsEvent_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClearEntityDecalsEvent_Equals_Divine_Protobufs_Dota2_CMsgClearEntityDecalsEvent_"></a> Equals\(CMsgClearEntityDecalsEvent\)

```csharp
public bool Equals(CMsgClearEntityDecalsEvent other)
```

#### Parameters

`other` [CMsgClearEntityDecalsEvent](Divine.Protobufs.Dota2.CMsgClearEntityDecalsEvent.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClearEntityDecalsEvent_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClearEntityDecalsEvent_MergeFrom_Divine_Protobufs_Dota2_CMsgClearEntityDecalsEvent_"></a> MergeFrom\(CMsgClearEntityDecalsEvent\)

```csharp
public void MergeFrom(CMsgClearEntityDecalsEvent other)
```

#### Parameters

`other` [CMsgClearEntityDecalsEvent](Divine.Protobufs.Dota2.CMsgClearEntityDecalsEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgClearEntityDecalsEvent_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClearEntityDecalsEvent_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClearEntityDecalsEvent_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

