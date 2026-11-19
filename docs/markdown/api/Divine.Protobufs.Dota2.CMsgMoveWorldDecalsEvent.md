# <a id="Divine_Protobufs_Dota2_CMsgMoveWorldDecalsEvent"></a> Class CMsgMoveWorldDecalsEvent

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgMoveWorldDecalsEvent : IMessage<CMsgMoveWorldDecalsEvent>, IEquatable<CMsgMoveWorldDecalsEvent>, IDeepCloneable<CMsgMoveWorldDecalsEvent>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgMoveWorldDecalsEvent](Divine.Protobufs.Dota2.CMsgMoveWorldDecalsEvent.md)

#### Implements

IMessage<CMsgMoveWorldDecalsEvent\>, 
[IEquatable<CMsgMoveWorldDecalsEvent\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgMoveWorldDecalsEvent\>, 
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
[EnumerableExtensions.In<CMsgMoveWorldDecalsEvent\>\(CMsgMoveWorldDecalsEvent, params CMsgMoveWorldDecalsEvent\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgMoveWorldDecalsEvent__ctor"></a> CMsgMoveWorldDecalsEvent\(\)

```csharp
public CMsgMoveWorldDecalsEvent()
```

### <a id="Divine_Protobufs_Dota2_CMsgMoveWorldDecalsEvent__ctor_Divine_Protobufs_Dota2_CMsgMoveWorldDecalsEvent_"></a> CMsgMoveWorldDecalsEvent\(CMsgMoveWorldDecalsEvent\)

```csharp
public CMsgMoveWorldDecalsEvent(CMsgMoveWorldDecalsEvent other)
```

#### Parameters

`other` [CMsgMoveWorldDecalsEvent](Divine.Protobufs.Dota2.CMsgMoveWorldDecalsEvent.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgMoveWorldDecalsEvent_MaxsFieldNumber"></a> MaxsFieldNumber

```csharp
public const int MaxsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMoveWorldDecalsEvent_MinsFieldNumber"></a> MinsFieldNumber

```csharp
public const int MinsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMoveWorldDecalsEvent_OffsetFieldNumber"></a> OffsetFieldNumber

```csharp
public const int OffsetFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgMoveWorldDecalsEvent_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgMoveWorldDecalsEvent_Maxs"></a> Maxs

```csharp
public CMsgVector Maxs { get; set; }
```

#### Property Value

 [CMsgVector](Divine.Protobufs.Dota2.CMsgVector.md)

### <a id="Divine_Protobufs_Dota2_CMsgMoveWorldDecalsEvent_Mins"></a> Mins

```csharp
public CMsgVector Mins { get; set; }
```

#### Property Value

 [CMsgVector](Divine.Protobufs.Dota2.CMsgVector.md)

### <a id="Divine_Protobufs_Dota2_CMsgMoveWorldDecalsEvent_Offset"></a> Offset

```csharp
public CMsgVector Offset { get; set; }
```

#### Property Value

 [CMsgVector](Divine.Protobufs.Dota2.CMsgVector.md)

### <a id="Divine_Protobufs_Dota2_CMsgMoveWorldDecalsEvent_Parser"></a> Parser

```csharp
public static MessageParser<CMsgMoveWorldDecalsEvent> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgMoveWorldDecalsEvent](Divine.Protobufs.Dota2.CMsgMoveWorldDecalsEvent.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgMoveWorldDecalsEvent_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMoveWorldDecalsEvent_Clone"></a> Clone\(\)

```csharp
public CMsgMoveWorldDecalsEvent Clone()
```

#### Returns

 [CMsgMoveWorldDecalsEvent](Divine.Protobufs.Dota2.CMsgMoveWorldDecalsEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgMoveWorldDecalsEvent_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMoveWorldDecalsEvent_Equals_Divine_Protobufs_Dota2_CMsgMoveWorldDecalsEvent_"></a> Equals\(CMsgMoveWorldDecalsEvent\)

```csharp
public bool Equals(CMsgMoveWorldDecalsEvent other)
```

#### Parameters

`other` [CMsgMoveWorldDecalsEvent](Divine.Protobufs.Dota2.CMsgMoveWorldDecalsEvent.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMoveWorldDecalsEvent_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMoveWorldDecalsEvent_MergeFrom_Divine_Protobufs_Dota2_CMsgMoveWorldDecalsEvent_"></a> MergeFrom\(CMsgMoveWorldDecalsEvent\)

```csharp
public void MergeFrom(CMsgMoveWorldDecalsEvent other)
```

#### Parameters

`other` [CMsgMoveWorldDecalsEvent](Divine.Protobufs.Dota2.CMsgMoveWorldDecalsEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgMoveWorldDecalsEvent_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgMoveWorldDecalsEvent_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgMoveWorldDecalsEvent_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

