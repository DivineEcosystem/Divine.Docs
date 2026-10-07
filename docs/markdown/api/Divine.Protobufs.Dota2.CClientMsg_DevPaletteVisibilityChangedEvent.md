# <a id="Divine_Protobufs_Dota2_CClientMsg_DevPaletteVisibilityChangedEvent"></a> Class CClientMsg\_DevPaletteVisibilityChangedEvent

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CClientMsg_DevPaletteVisibilityChangedEvent : IMessage<CClientMsg_DevPaletteVisibilityChangedEvent>, IEquatable<CClientMsg_DevPaletteVisibilityChangedEvent>, IDeepCloneable<CClientMsg_DevPaletteVisibilityChangedEvent>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CClientMsg\_DevPaletteVisibilityChangedEvent](Divine.Protobufs.Dota2.CClientMsg\_DevPaletteVisibilityChangedEvent.md)

#### Implements

IMessage<CClientMsg\_DevPaletteVisibilityChangedEvent\>, 
[IEquatable<CClientMsg\_DevPaletteVisibilityChangedEvent\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CClientMsg\_DevPaletteVisibilityChangedEvent\>, 
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
[EnumerableExtensions.In<CClientMsg\_DevPaletteVisibilityChangedEvent\>\(CClientMsg\_DevPaletteVisibilityChangedEvent, params CClientMsg\_DevPaletteVisibilityChangedEvent\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CClientMsg_DevPaletteVisibilityChangedEvent__ctor"></a> CClientMsg\_DevPaletteVisibilityChangedEvent\(\)

```csharp
public CClientMsg_DevPaletteVisibilityChangedEvent()
```

### <a id="Divine_Protobufs_Dota2_CClientMsg_DevPaletteVisibilityChangedEvent__ctor_Divine_Protobufs_Dota2_CClientMsg_DevPaletteVisibilityChangedEvent_"></a> CClientMsg\_DevPaletteVisibilityChangedEvent\(CClientMsg\_DevPaletteVisibilityChangedEvent\)

```csharp
public CClientMsg_DevPaletteVisibilityChangedEvent(CClientMsg_DevPaletteVisibilityChangedEvent other)
```

#### Parameters

`other` [CClientMsg\_DevPaletteVisibilityChangedEvent](Divine.Protobufs.Dota2.CClientMsg\_DevPaletteVisibilityChangedEvent.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CClientMsg_DevPaletteVisibilityChangedEvent_VisibleFieldNumber"></a> VisibleFieldNumber

```csharp
public const int VisibleFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CClientMsg_DevPaletteVisibilityChangedEvent_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CClientMsg_DevPaletteVisibilityChangedEvent_HasVisible"></a> HasVisible

```csharp
public bool HasVisible { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CClientMsg_DevPaletteVisibilityChangedEvent_Parser"></a> Parser

```csharp
public static MessageParser<CClientMsg_DevPaletteVisibilityChangedEvent> Parser { get; }
```

#### Property Value

 MessageParser<[CClientMsg\_DevPaletteVisibilityChangedEvent](Divine.Protobufs.Dota2.CClientMsg\_DevPaletteVisibilityChangedEvent.md)\>

### <a id="Divine_Protobufs_Dota2_CClientMsg_DevPaletteVisibilityChangedEvent_Visible"></a> Visible

```csharp
public bool Visible { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CClientMsg_DevPaletteVisibilityChangedEvent_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CClientMsg_DevPaletteVisibilityChangedEvent_ClearVisible"></a> ClearVisible\(\)

```csharp
public void ClearVisible()
```

### <a id="Divine_Protobufs_Dota2_CClientMsg_DevPaletteVisibilityChangedEvent_Clone"></a> Clone\(\)

```csharp
public CClientMsg_DevPaletteVisibilityChangedEvent Clone()
```

#### Returns

 [CClientMsg\_DevPaletteVisibilityChangedEvent](Divine.Protobufs.Dota2.CClientMsg\_DevPaletteVisibilityChangedEvent.md)

### <a id="Divine_Protobufs_Dota2_CClientMsg_DevPaletteVisibilityChangedEvent_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CClientMsg_DevPaletteVisibilityChangedEvent_Equals_Divine_Protobufs_Dota2_CClientMsg_DevPaletteVisibilityChangedEvent_"></a> Equals\(CClientMsg\_DevPaletteVisibilityChangedEvent\)

```csharp
public bool Equals(CClientMsg_DevPaletteVisibilityChangedEvent other)
```

#### Parameters

`other` [CClientMsg\_DevPaletteVisibilityChangedEvent](Divine.Protobufs.Dota2.CClientMsg\_DevPaletteVisibilityChangedEvent.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CClientMsg_DevPaletteVisibilityChangedEvent_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CClientMsg_DevPaletteVisibilityChangedEvent_MergeFrom_Divine_Protobufs_Dota2_CClientMsg_DevPaletteVisibilityChangedEvent_"></a> MergeFrom\(CClientMsg\_DevPaletteVisibilityChangedEvent\)

```csharp
public void MergeFrom(CClientMsg_DevPaletteVisibilityChangedEvent other)
```

#### Parameters

`other` [CClientMsg\_DevPaletteVisibilityChangedEvent](Divine.Protobufs.Dota2.CClientMsg\_DevPaletteVisibilityChangedEvent.md)

### <a id="Divine_Protobufs_Dota2_CClientMsg_DevPaletteVisibilityChangedEvent_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CClientMsg_DevPaletteVisibilityChangedEvent_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CClientMsg_DevPaletteVisibilityChangedEvent_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

