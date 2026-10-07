# <a id="Divine_Protobufs_Dota2_CMsgClearWorldDecalsEvent"></a> Class CMsgClearWorldDecalsEvent

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClearWorldDecalsEvent : IMessage<CMsgClearWorldDecalsEvent>, IEquatable<CMsgClearWorldDecalsEvent>, IDeepCloneable<CMsgClearWorldDecalsEvent>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClearWorldDecalsEvent](Divine.Protobufs.Dota2.CMsgClearWorldDecalsEvent.md)

#### Implements

IMessage<CMsgClearWorldDecalsEvent\>, 
[IEquatable<CMsgClearWorldDecalsEvent\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClearWorldDecalsEvent\>, 
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
[EnumerableExtensions.In<CMsgClearWorldDecalsEvent\>\(CMsgClearWorldDecalsEvent, params CMsgClearWorldDecalsEvent\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClearWorldDecalsEvent__ctor"></a> CMsgClearWorldDecalsEvent\(\)

```csharp
public CMsgClearWorldDecalsEvent()
```

### <a id="Divine_Protobufs_Dota2_CMsgClearWorldDecalsEvent__ctor_Divine_Protobufs_Dota2_CMsgClearWorldDecalsEvent_"></a> CMsgClearWorldDecalsEvent\(CMsgClearWorldDecalsEvent\)

```csharp
public CMsgClearWorldDecalsEvent(CMsgClearWorldDecalsEvent other)
```

#### Parameters

`other` [CMsgClearWorldDecalsEvent](Divine.Protobufs.Dota2.CMsgClearWorldDecalsEvent.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClearWorldDecalsEvent_FlagstoclearFieldNumber"></a> FlagstoclearFieldNumber

```csharp
public const int FlagstoclearFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClearWorldDecalsEvent_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClearWorldDecalsEvent_Flagstoclear"></a> Flagstoclear

```csharp
public uint Flagstoclear { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClearWorldDecalsEvent_HasFlagstoclear"></a> HasFlagstoclear

```csharp
public bool HasFlagstoclear { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClearWorldDecalsEvent_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClearWorldDecalsEvent> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClearWorldDecalsEvent](Divine.Protobufs.Dota2.CMsgClearWorldDecalsEvent.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClearWorldDecalsEvent_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClearWorldDecalsEvent_ClearFlagstoclear"></a> ClearFlagstoclear\(\)

```csharp
public void ClearFlagstoclear()
```

### <a id="Divine_Protobufs_Dota2_CMsgClearWorldDecalsEvent_Clone"></a> Clone\(\)

```csharp
public CMsgClearWorldDecalsEvent Clone()
```

#### Returns

 [CMsgClearWorldDecalsEvent](Divine.Protobufs.Dota2.CMsgClearWorldDecalsEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgClearWorldDecalsEvent_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClearWorldDecalsEvent_Equals_Divine_Protobufs_Dota2_CMsgClearWorldDecalsEvent_"></a> Equals\(CMsgClearWorldDecalsEvent\)

```csharp
public bool Equals(CMsgClearWorldDecalsEvent other)
```

#### Parameters

`other` [CMsgClearWorldDecalsEvent](Divine.Protobufs.Dota2.CMsgClearWorldDecalsEvent.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClearWorldDecalsEvent_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClearWorldDecalsEvent_MergeFrom_Divine_Protobufs_Dota2_CMsgClearWorldDecalsEvent_"></a> MergeFrom\(CMsgClearWorldDecalsEvent\)

```csharp
public void MergeFrom(CMsgClearWorldDecalsEvent other)
```

#### Parameters

`other` [CMsgClearWorldDecalsEvent](Divine.Protobufs.Dota2.CMsgClearWorldDecalsEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgClearWorldDecalsEvent_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClearWorldDecalsEvent_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClearWorldDecalsEvent_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

