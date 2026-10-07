# <a id="Divine_Protobufs_Dota2_CSVCMsgList_GameEvents_Types_event_t"></a> Class CSVCMsgList\_GameEvents.Types.event\_t

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSVCMsgList_GameEvents.Types.event_t : IMessage<CSVCMsgList_GameEvents.Types.event_t>, IEquatable<CSVCMsgList_GameEvents.Types.event_t>, IDeepCloneable<CSVCMsgList_GameEvents.Types.event_t>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSVCMsgList\_GameEvents.Types.event\_t](Divine.Protobufs.Dota2.CSVCMsgList\_GameEvents.Types.event\_t.md)

#### Implements

IMessage<CSVCMsgList\_GameEvents.Types.event\_t\>, 
[IEquatable<CSVCMsgList\_GameEvents.Types.event\_t\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSVCMsgList\_GameEvents.Types.event\_t\>, 
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
[EnumerableExtensions.In<CSVCMsgList\_GameEvents.Types.event\_t\>\(CSVCMsgList\_GameEvents.Types.event\_t, params CSVCMsgList\_GameEvents.Types.event\_t\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSVCMsgList_GameEvents_Types_event_t__ctor"></a> event\_t\(\)

```csharp
public event_t()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsgList_GameEvents_Types_event_t__ctor_Divine_Protobufs_Dota2_CSVCMsgList_GameEvents_Types_event_t_"></a> event\_t\(event\_t\)

```csharp
public event_t(CSVCMsgList_GameEvents.Types.event_t other)
```

#### Parameters

`other` [CSVCMsgList\_GameEvents](Divine.Protobufs.Dota2.CSVCMsgList\_GameEvents.md).[Types](Divine.Protobufs.Dota2.CSVCMsgList\_GameEvents.Types.md).[event\_t](Divine.Protobufs.Dota2.CSVCMsgList\_GameEvents.Types.event\_t.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSVCMsgList_GameEvents_Types_event_t_EventFieldNumber"></a> EventFieldNumber

```csharp
public const int EventFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsgList_GameEvents_Types_event_t_TickFieldNumber"></a> TickFieldNumber

```csharp
public const int TickFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSVCMsgList_GameEvents_Types_event_t_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSVCMsgList_GameEvents_Types_event_t_Event"></a> Event

```csharp
public CSVCMsg_GameEvent Event { get; set; }
```

#### Property Value

 [CSVCMsg\_GameEvent](Divine.Protobufs.Dota2.CSVCMsg\_GameEvent.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsgList_GameEvents_Types_event_t_HasTick"></a> HasTick

```csharp
public bool HasTick { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsgList_GameEvents_Types_event_t_Parser"></a> Parser

```csharp
public static MessageParser<CSVCMsgList_GameEvents.Types.event_t> Parser { get; }
```

#### Property Value

 MessageParser<[CSVCMsgList\_GameEvents](Divine.Protobufs.Dota2.CSVCMsgList\_GameEvents.md).[Types](Divine.Protobufs.Dota2.CSVCMsgList\_GameEvents.Types.md).[event\_t](Divine.Protobufs.Dota2.CSVCMsgList\_GameEvents.Types.event\_t.md)\>

### <a id="Divine_Protobufs_Dota2_CSVCMsgList_GameEvents_Types_event_t_Tick"></a> Tick

```csharp
public int Tick { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CSVCMsgList_GameEvents_Types_event_t_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsgList_GameEvents_Types_event_t_ClearTick"></a> ClearTick\(\)

```csharp
public void ClearTick()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsgList_GameEvents_Types_event_t_Clone"></a> Clone\(\)

```csharp
public CSVCMsgList_GameEvents.Types.event_t Clone()
```

#### Returns

 [CSVCMsgList\_GameEvents](Divine.Protobufs.Dota2.CSVCMsgList\_GameEvents.md).[Types](Divine.Protobufs.Dota2.CSVCMsgList\_GameEvents.Types.md).[event\_t](Divine.Protobufs.Dota2.CSVCMsgList\_GameEvents.Types.event\_t.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsgList_GameEvents_Types_event_t_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsgList_GameEvents_Types_event_t_Equals_Divine_Protobufs_Dota2_CSVCMsgList_GameEvents_Types_event_t_"></a> Equals\(event\_t\)

```csharp
public bool Equals(CSVCMsgList_GameEvents.Types.event_t other)
```

#### Parameters

`other` [CSVCMsgList\_GameEvents](Divine.Protobufs.Dota2.CSVCMsgList\_GameEvents.md).[Types](Divine.Protobufs.Dota2.CSVCMsgList\_GameEvents.Types.md).[event\_t](Divine.Protobufs.Dota2.CSVCMsgList\_GameEvents.Types.event\_t.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsgList_GameEvents_Types_event_t_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsgList_GameEvents_Types_event_t_MergeFrom_Divine_Protobufs_Dota2_CSVCMsgList_GameEvents_Types_event_t_"></a> MergeFrom\(event\_t\)

```csharp
public void MergeFrom(CSVCMsgList_GameEvents.Types.event_t other)
```

#### Parameters

`other` [CSVCMsgList\_GameEvents](Divine.Protobufs.Dota2.CSVCMsgList\_GameEvents.md).[Types](Divine.Protobufs.Dota2.CSVCMsgList\_GameEvents.Types.md).[event\_t](Divine.Protobufs.Dota2.CSVCMsgList\_GameEvents.Types.event\_t.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsgList_GameEvents_Types_event_t_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSVCMsgList_GameEvents_Types_event_t_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSVCMsgList_GameEvents_Types_event_t_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

