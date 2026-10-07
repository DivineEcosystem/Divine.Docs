# <a id="Divine_Protobufs_Dota2_CSVCMsg_GameEvent"></a> Class CSVCMsg\_GameEvent

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSVCMsg_GameEvent : IMessage<CSVCMsg_GameEvent>, IEquatable<CSVCMsg_GameEvent>, IDeepCloneable<CSVCMsg_GameEvent>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSVCMsg\_GameEvent](Divine.Protobufs.Dota2.CSVCMsg\_GameEvent.md)

#### Implements

IMessage<CSVCMsg\_GameEvent\>, 
[IEquatable<CSVCMsg\_GameEvent\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSVCMsg\_GameEvent\>, 
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
[EnumerableExtensions.In<CSVCMsg\_GameEvent\>\(CSVCMsg\_GameEvent, params CSVCMsg\_GameEvent\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameEvent__ctor"></a> CSVCMsg\_GameEvent\(\)

```csharp
public CSVCMsg_GameEvent()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameEvent__ctor_Divine_Protobufs_Dota2_CSVCMsg_GameEvent_"></a> CSVCMsg\_GameEvent\(CSVCMsg\_GameEvent\)

```csharp
public CSVCMsg_GameEvent(CSVCMsg_GameEvent other)
```

#### Parameters

`other` [CSVCMsg\_GameEvent](Divine.Protobufs.Dota2.CSVCMsg\_GameEvent.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameEvent_EventidFieldNumber"></a> EventidFieldNumber

```csharp
public const int EventidFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameEvent_EventNameFieldNumber"></a> EventNameFieldNumber

```csharp
public const int EventNameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameEvent_KeysFieldNumber"></a> KeysFieldNumber

```csharp
public const int KeysFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameEvent_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameEvent_Eventid"></a> Eventid

```csharp
public int Eventid { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameEvent_EventName"></a> EventName

```csharp
public string EventName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameEvent_HasEventid"></a> HasEventid

```csharp
public bool HasEventid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameEvent_HasEventName"></a> HasEventName

```csharp
public bool HasEventName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameEvent_Keys"></a> Keys

```csharp
public RepeatedField<CSVCMsg_GameEvent.Types.key_t> Keys { get; }
```

#### Property Value

 RepeatedField<[CSVCMsg\_GameEvent](Divine.Protobufs.Dota2.CSVCMsg\_GameEvent.md).[Types](Divine.Protobufs.Dota2.CSVCMsg\_GameEvent.Types.md).[key\_t](Divine.Protobufs.Dota2.CSVCMsg\_GameEvent.Types.key\_t.md)\>

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameEvent_Parser"></a> Parser

```csharp
public static MessageParser<CSVCMsg_GameEvent> Parser { get; }
```

#### Property Value

 MessageParser<[CSVCMsg\_GameEvent](Divine.Protobufs.Dota2.CSVCMsg\_GameEvent.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameEvent_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameEvent_ClearEventid"></a> ClearEventid\(\)

```csharp
public void ClearEventid()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameEvent_ClearEventName"></a> ClearEventName\(\)

```csharp
public void ClearEventName()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameEvent_Clone"></a> Clone\(\)

```csharp
public CSVCMsg_GameEvent Clone()
```

#### Returns

 [CSVCMsg\_GameEvent](Divine.Protobufs.Dota2.CSVCMsg\_GameEvent.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameEvent_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameEvent_Equals_Divine_Protobufs_Dota2_CSVCMsg_GameEvent_"></a> Equals\(CSVCMsg\_GameEvent\)

```csharp
public bool Equals(CSVCMsg_GameEvent other)
```

#### Parameters

`other` [CSVCMsg\_GameEvent](Divine.Protobufs.Dota2.CSVCMsg\_GameEvent.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameEvent_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameEvent_MergeFrom_Divine_Protobufs_Dota2_CSVCMsg_GameEvent_"></a> MergeFrom\(CSVCMsg\_GameEvent\)

```csharp
public void MergeFrom(CSVCMsg_GameEvent other)
```

#### Parameters

`other` [CSVCMsg\_GameEvent](Divine.Protobufs.Dota2.CSVCMsg\_GameEvent.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameEvent_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameEvent_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameEvent_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

