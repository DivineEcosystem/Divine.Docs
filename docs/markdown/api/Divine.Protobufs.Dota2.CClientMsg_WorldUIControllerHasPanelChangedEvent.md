# <a id="Divine_Protobufs_Dota2_CClientMsg_WorldUIControllerHasPanelChangedEvent"></a> Class CClientMsg\_WorldUIControllerHasPanelChangedEvent

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CClientMsg_WorldUIControllerHasPanelChangedEvent : IMessage<CClientMsg_WorldUIControllerHasPanelChangedEvent>, IEquatable<CClientMsg_WorldUIControllerHasPanelChangedEvent>, IDeepCloneable<CClientMsg_WorldUIControllerHasPanelChangedEvent>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CClientMsg\_WorldUIControllerHasPanelChangedEvent](Divine.Protobufs.Dota2.CClientMsg\_WorldUIControllerHasPanelChangedEvent.md)

#### Implements

IMessage<CClientMsg\_WorldUIControllerHasPanelChangedEvent\>, 
[IEquatable<CClientMsg\_WorldUIControllerHasPanelChangedEvent\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CClientMsg\_WorldUIControllerHasPanelChangedEvent\>, 
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
[EnumerableExtensions.In<CClientMsg\_WorldUIControllerHasPanelChangedEvent\>\(CClientMsg\_WorldUIControllerHasPanelChangedEvent, params CClientMsg\_WorldUIControllerHasPanelChangedEvent\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CClientMsg_WorldUIControllerHasPanelChangedEvent__ctor"></a> CClientMsg\_WorldUIControllerHasPanelChangedEvent\(\)

```csharp
public CClientMsg_WorldUIControllerHasPanelChangedEvent()
```

### <a id="Divine_Protobufs_Dota2_CClientMsg_WorldUIControllerHasPanelChangedEvent__ctor_Divine_Protobufs_Dota2_CClientMsg_WorldUIControllerHasPanelChangedEvent_"></a> CClientMsg\_WorldUIControllerHasPanelChangedEvent\(CClientMsg\_WorldUIControllerHasPanelChangedEvent\)

```csharp
public CClientMsg_WorldUIControllerHasPanelChangedEvent(CClientMsg_WorldUIControllerHasPanelChangedEvent other)
```

#### Parameters

`other` [CClientMsg\_WorldUIControllerHasPanelChangedEvent](Divine.Protobufs.Dota2.CClientMsg\_WorldUIControllerHasPanelChangedEvent.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CClientMsg_WorldUIControllerHasPanelChangedEvent_ClientEhandleFieldNumber"></a> ClientEhandleFieldNumber

```csharp
public const int ClientEhandleFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CClientMsg_WorldUIControllerHasPanelChangedEvent_HasPanelFieldNumber"></a> HasPanelFieldNumber

```csharp
public const int HasPanelFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CClientMsg_WorldUIControllerHasPanelChangedEvent_LiteralHandTypeFieldNumber"></a> LiteralHandTypeFieldNumber

```csharp
public const int LiteralHandTypeFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CClientMsg_WorldUIControllerHasPanelChangedEvent_ClientEhandle"></a> ClientEhandle

```csharp
public uint ClientEhandle { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CClientMsg_WorldUIControllerHasPanelChangedEvent_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CClientMsg_WorldUIControllerHasPanelChangedEvent_HasClientEhandle"></a> HasClientEhandle

```csharp
public bool HasClientEhandle { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CClientMsg_WorldUIControllerHasPanelChangedEvent_HasHasPanel"></a> HasHasPanel

```csharp
public bool HasHasPanel { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CClientMsg_WorldUIControllerHasPanelChangedEvent_HasLiteralHandType"></a> HasLiteralHandType

```csharp
public bool HasLiteralHandType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CClientMsg_WorldUIControllerHasPanelChangedEvent_HasPanel"></a> HasPanel

```csharp
public bool HasPanel { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CClientMsg_WorldUIControllerHasPanelChangedEvent_LiteralHandType"></a> LiteralHandType

```csharp
public uint LiteralHandType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CClientMsg_WorldUIControllerHasPanelChangedEvent_Parser"></a> Parser

```csharp
public static MessageParser<CClientMsg_WorldUIControllerHasPanelChangedEvent> Parser { get; }
```

#### Property Value

 MessageParser<[CClientMsg\_WorldUIControllerHasPanelChangedEvent](Divine.Protobufs.Dota2.CClientMsg\_WorldUIControllerHasPanelChangedEvent.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CClientMsg_WorldUIControllerHasPanelChangedEvent_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CClientMsg_WorldUIControllerHasPanelChangedEvent_ClearClientEhandle"></a> ClearClientEhandle\(\)

```csharp
public void ClearClientEhandle()
```

### <a id="Divine_Protobufs_Dota2_CClientMsg_WorldUIControllerHasPanelChangedEvent_ClearHasPanel"></a> ClearHasPanel\(\)

```csharp
public void ClearHasPanel()
```

### <a id="Divine_Protobufs_Dota2_CClientMsg_WorldUIControllerHasPanelChangedEvent_ClearLiteralHandType"></a> ClearLiteralHandType\(\)

```csharp
public void ClearLiteralHandType()
```

### <a id="Divine_Protobufs_Dota2_CClientMsg_WorldUIControllerHasPanelChangedEvent_Clone"></a> Clone\(\)

```csharp
public CClientMsg_WorldUIControllerHasPanelChangedEvent Clone()
```

#### Returns

 [CClientMsg\_WorldUIControllerHasPanelChangedEvent](Divine.Protobufs.Dota2.CClientMsg\_WorldUIControllerHasPanelChangedEvent.md)

### <a id="Divine_Protobufs_Dota2_CClientMsg_WorldUIControllerHasPanelChangedEvent_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CClientMsg_WorldUIControllerHasPanelChangedEvent_Equals_Divine_Protobufs_Dota2_CClientMsg_WorldUIControllerHasPanelChangedEvent_"></a> Equals\(CClientMsg\_WorldUIControllerHasPanelChangedEvent\)

```csharp
public bool Equals(CClientMsg_WorldUIControllerHasPanelChangedEvent other)
```

#### Parameters

`other` [CClientMsg\_WorldUIControllerHasPanelChangedEvent](Divine.Protobufs.Dota2.CClientMsg\_WorldUIControllerHasPanelChangedEvent.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CClientMsg_WorldUIControllerHasPanelChangedEvent_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CClientMsg_WorldUIControllerHasPanelChangedEvent_MergeFrom_Divine_Protobufs_Dota2_CClientMsg_WorldUIControllerHasPanelChangedEvent_"></a> MergeFrom\(CClientMsg\_WorldUIControllerHasPanelChangedEvent\)

```csharp
public void MergeFrom(CClientMsg_WorldUIControllerHasPanelChangedEvent other)
```

#### Parameters

`other` [CClientMsg\_WorldUIControllerHasPanelChangedEvent](Divine.Protobufs.Dota2.CClientMsg\_WorldUIControllerHasPanelChangedEvent.md)

### <a id="Divine_Protobufs_Dota2_CClientMsg_WorldUIControllerHasPanelChangedEvent_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CClientMsg_WorldUIControllerHasPanelChangedEvent_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CClientMsg_WorldUIControllerHasPanelChangedEvent_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

