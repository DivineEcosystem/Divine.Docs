# <a id="Divine_Protobufs_Dota2_CMsgClearDecalsForEntityEvent"></a> Class CMsgClearDecalsForEntityEvent

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClearDecalsForEntityEvent : IMessage<CMsgClearDecalsForEntityEvent>, IEquatable<CMsgClearDecalsForEntityEvent>, IDeepCloneable<CMsgClearDecalsForEntityEvent>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClearDecalsForEntityEvent](Divine.Protobufs.Dota2.CMsgClearDecalsForEntityEvent.md)

#### Implements

IMessage<CMsgClearDecalsForEntityEvent\>, 
[IEquatable<CMsgClearDecalsForEntityEvent\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClearDecalsForEntityEvent\>, 
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
[EnumerableExtensions.In<CMsgClearDecalsForEntityEvent\>\(CMsgClearDecalsForEntityEvent, params CMsgClearDecalsForEntityEvent\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClearDecalsForEntityEvent__ctor"></a> CMsgClearDecalsForEntityEvent\(\)

```csharp
public CMsgClearDecalsForEntityEvent()
```

### <a id="Divine_Protobufs_Dota2_CMsgClearDecalsForEntityEvent__ctor_Divine_Protobufs_Dota2_CMsgClearDecalsForEntityEvent_"></a> CMsgClearDecalsForEntityEvent\(CMsgClearDecalsForEntityEvent\)

```csharp
public CMsgClearDecalsForEntityEvent(CMsgClearDecalsForEntityEvent other)
```

#### Parameters

`other` [CMsgClearDecalsForEntityEvent](Divine.Protobufs.Dota2.CMsgClearDecalsForEntityEvent.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClearDecalsForEntityEvent_EntityhandleFieldNumber"></a> EntityhandleFieldNumber

```csharp
public const int EntityhandleFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClearDecalsForEntityEvent_FlagstoclearFieldNumber"></a> FlagstoclearFieldNumber

```csharp
public const int FlagstoclearFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClearDecalsForEntityEvent_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClearDecalsForEntityEvent_Entityhandle"></a> Entityhandle

```csharp
public uint Entityhandle { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClearDecalsForEntityEvent_Flagstoclear"></a> Flagstoclear

```csharp
public uint Flagstoclear { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClearDecalsForEntityEvent_HasEntityhandle"></a> HasEntityhandle

```csharp
public bool HasEntityhandle { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClearDecalsForEntityEvent_HasFlagstoclear"></a> HasFlagstoclear

```csharp
public bool HasFlagstoclear { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClearDecalsForEntityEvent_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClearDecalsForEntityEvent> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClearDecalsForEntityEvent](Divine.Protobufs.Dota2.CMsgClearDecalsForEntityEvent.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClearDecalsForEntityEvent_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClearDecalsForEntityEvent_ClearEntityhandle"></a> ClearEntityhandle\(\)

```csharp
public void ClearEntityhandle()
```

### <a id="Divine_Protobufs_Dota2_CMsgClearDecalsForEntityEvent_ClearFlagstoclear"></a> ClearFlagstoclear\(\)

```csharp
public void ClearFlagstoclear()
```

### <a id="Divine_Protobufs_Dota2_CMsgClearDecalsForEntityEvent_Clone"></a> Clone\(\)

```csharp
public CMsgClearDecalsForEntityEvent Clone()
```

#### Returns

 [CMsgClearDecalsForEntityEvent](Divine.Protobufs.Dota2.CMsgClearDecalsForEntityEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgClearDecalsForEntityEvent_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClearDecalsForEntityEvent_Equals_Divine_Protobufs_Dota2_CMsgClearDecalsForEntityEvent_"></a> Equals\(CMsgClearDecalsForEntityEvent\)

```csharp
public bool Equals(CMsgClearDecalsForEntityEvent other)
```

#### Parameters

`other` [CMsgClearDecalsForEntityEvent](Divine.Protobufs.Dota2.CMsgClearDecalsForEntityEvent.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClearDecalsForEntityEvent_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClearDecalsForEntityEvent_MergeFrom_Divine_Protobufs_Dota2_CMsgClearDecalsForEntityEvent_"></a> MergeFrom\(CMsgClearDecalsForEntityEvent\)

```csharp
public void MergeFrom(CMsgClearDecalsForEntityEvent other)
```

#### Parameters

`other` [CMsgClearDecalsForEntityEvent](Divine.Protobufs.Dota2.CMsgClearDecalsForEntityEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgClearDecalsForEntityEvent_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClearDecalsForEntityEvent_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClearDecalsForEntityEvent_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

