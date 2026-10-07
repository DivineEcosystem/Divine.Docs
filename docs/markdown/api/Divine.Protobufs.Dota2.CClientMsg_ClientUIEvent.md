# <a id="Divine_Protobufs_Dota2_CClientMsg_ClientUIEvent"></a> Class CClientMsg\_ClientUIEvent

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CClientMsg_ClientUIEvent : IMessage<CClientMsg_ClientUIEvent>, IEquatable<CClientMsg_ClientUIEvent>, IDeepCloneable<CClientMsg_ClientUIEvent>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CClientMsg\_ClientUIEvent](Divine.Protobufs.Dota2.CClientMsg\_ClientUIEvent.md)

#### Implements

IMessage<CClientMsg\_ClientUIEvent\>, 
[IEquatable<CClientMsg\_ClientUIEvent\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CClientMsg\_ClientUIEvent\>, 
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
[EnumerableExtensions.In<CClientMsg\_ClientUIEvent\>\(CClientMsg\_ClientUIEvent, params CClientMsg\_ClientUIEvent\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CClientMsg_ClientUIEvent__ctor"></a> CClientMsg\_ClientUIEvent\(\)

```csharp
public CClientMsg_ClientUIEvent()
```

### <a id="Divine_Protobufs_Dota2_CClientMsg_ClientUIEvent__ctor_Divine_Protobufs_Dota2_CClientMsg_ClientUIEvent_"></a> CClientMsg\_ClientUIEvent\(CClientMsg\_ClientUIEvent\)

```csharp
public CClientMsg_ClientUIEvent(CClientMsg_ClientUIEvent other)
```

#### Parameters

`other` [CClientMsg\_ClientUIEvent](Divine.Protobufs.Dota2.CClientMsg\_ClientUIEvent.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CClientMsg_ClientUIEvent_ClientEhandleFieldNumber"></a> ClientEhandleFieldNumber

```csharp
public const int ClientEhandleFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CClientMsg_ClientUIEvent_Data1FieldNumber"></a> Data1FieldNumber

```csharp
public const int Data1FieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CClientMsg_ClientUIEvent_Data2FieldNumber"></a> Data2FieldNumber

```csharp
public const int Data2FieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CClientMsg_ClientUIEvent_EntEhandleFieldNumber"></a> EntEhandleFieldNumber

```csharp
public const int EntEhandleFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CClientMsg_ClientUIEvent_EventFieldNumber"></a> EventFieldNumber

```csharp
public const int EventFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CClientMsg_ClientUIEvent_ClientEhandle"></a> ClientEhandle

```csharp
public uint ClientEhandle { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CClientMsg_ClientUIEvent_Data1"></a> Data1

```csharp
public string Data1 { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CClientMsg_ClientUIEvent_Data2"></a> Data2

```csharp
public string Data2 { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CClientMsg_ClientUIEvent_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CClientMsg_ClientUIEvent_EntEhandle"></a> EntEhandle

```csharp
public uint EntEhandle { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CClientMsg_ClientUIEvent_Event"></a> Event

```csharp
public EClientUIEvent Event { get; set; }
```

#### Property Value

 [EClientUIEvent](Divine.Protobufs.Dota2.EClientUIEvent.md)

### <a id="Divine_Protobufs_Dota2_CClientMsg_ClientUIEvent_HasClientEhandle"></a> HasClientEhandle

```csharp
public bool HasClientEhandle { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CClientMsg_ClientUIEvent_HasData1"></a> HasData1

```csharp
public bool HasData1 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CClientMsg_ClientUIEvent_HasData2"></a> HasData2

```csharp
public bool HasData2 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CClientMsg_ClientUIEvent_HasEntEhandle"></a> HasEntEhandle

```csharp
public bool HasEntEhandle { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CClientMsg_ClientUIEvent_HasEvent"></a> HasEvent

```csharp
public bool HasEvent { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CClientMsg_ClientUIEvent_Parser"></a> Parser

```csharp
public static MessageParser<CClientMsg_ClientUIEvent> Parser { get; }
```

#### Property Value

 MessageParser<[CClientMsg\_ClientUIEvent](Divine.Protobufs.Dota2.CClientMsg\_ClientUIEvent.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CClientMsg_ClientUIEvent_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CClientMsg_ClientUIEvent_ClearClientEhandle"></a> ClearClientEhandle\(\)

```csharp
public void ClearClientEhandle()
```

### <a id="Divine_Protobufs_Dota2_CClientMsg_ClientUIEvent_ClearData1"></a> ClearData1\(\)

```csharp
public void ClearData1()
```

### <a id="Divine_Protobufs_Dota2_CClientMsg_ClientUIEvent_ClearData2"></a> ClearData2\(\)

```csharp
public void ClearData2()
```

### <a id="Divine_Protobufs_Dota2_CClientMsg_ClientUIEvent_ClearEntEhandle"></a> ClearEntEhandle\(\)

```csharp
public void ClearEntEhandle()
```

### <a id="Divine_Protobufs_Dota2_CClientMsg_ClientUIEvent_ClearEvent"></a> ClearEvent\(\)

```csharp
public void ClearEvent()
```

### <a id="Divine_Protobufs_Dota2_CClientMsg_ClientUIEvent_Clone"></a> Clone\(\)

```csharp
public CClientMsg_ClientUIEvent Clone()
```

#### Returns

 [CClientMsg\_ClientUIEvent](Divine.Protobufs.Dota2.CClientMsg\_ClientUIEvent.md)

### <a id="Divine_Protobufs_Dota2_CClientMsg_ClientUIEvent_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CClientMsg_ClientUIEvent_Equals_Divine_Protobufs_Dota2_CClientMsg_ClientUIEvent_"></a> Equals\(CClientMsg\_ClientUIEvent\)

```csharp
public bool Equals(CClientMsg_ClientUIEvent other)
```

#### Parameters

`other` [CClientMsg\_ClientUIEvent](Divine.Protobufs.Dota2.CClientMsg\_ClientUIEvent.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CClientMsg_ClientUIEvent_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CClientMsg_ClientUIEvent_MergeFrom_Divine_Protobufs_Dota2_CClientMsg_ClientUIEvent_"></a> MergeFrom\(CClientMsg\_ClientUIEvent\)

```csharp
public void MergeFrom(CClientMsg_ClientUIEvent other)
```

#### Parameters

`other` [CClientMsg\_ClientUIEvent](Divine.Protobufs.Dota2.CClientMsg\_ClientUIEvent.md)

### <a id="Divine_Protobufs_Dota2_CClientMsg_ClientUIEvent_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CClientMsg_ClientUIEvent_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CClientMsg_ClientUIEvent_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

