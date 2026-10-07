# <a id="Divine_Protobufs_Dota2_CSVCMsgList_GameEvents"></a> Class CSVCMsgList\_GameEvents

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSVCMsgList_GameEvents : IMessage<CSVCMsgList_GameEvents>, IEquatable<CSVCMsgList_GameEvents>, IDeepCloneable<CSVCMsgList_GameEvents>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSVCMsgList\_GameEvents](Divine.Protobufs.Dota2.CSVCMsgList\_GameEvents.md)

#### Implements

IMessage<CSVCMsgList\_GameEvents\>, 
[IEquatable<CSVCMsgList\_GameEvents\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSVCMsgList\_GameEvents\>, 
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
[EnumerableExtensions.In<CSVCMsgList\_GameEvents\>\(CSVCMsgList\_GameEvents, params CSVCMsgList\_GameEvents\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSVCMsgList_GameEvents__ctor"></a> CSVCMsgList\_GameEvents\(\)

```csharp
public CSVCMsgList_GameEvents()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsgList_GameEvents__ctor_Divine_Protobufs_Dota2_CSVCMsgList_GameEvents_"></a> CSVCMsgList\_GameEvents\(CSVCMsgList\_GameEvents\)

```csharp
public CSVCMsgList_GameEvents(CSVCMsgList_GameEvents other)
```

#### Parameters

`other` [CSVCMsgList\_GameEvents](Divine.Protobufs.Dota2.CSVCMsgList\_GameEvents.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSVCMsgList_GameEvents_EventsFieldNumber"></a> EventsFieldNumber

```csharp
public const int EventsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSVCMsgList_GameEvents_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSVCMsgList_GameEvents_Events"></a> Events

```csharp
public RepeatedField<CSVCMsgList_GameEvents.Types.event_t> Events { get; }
```

#### Property Value

 RepeatedField<[CSVCMsgList\_GameEvents](Divine.Protobufs.Dota2.CSVCMsgList\_GameEvents.md).[Types](Divine.Protobufs.Dota2.CSVCMsgList\_GameEvents.Types.md).[event\_t](Divine.Protobufs.Dota2.CSVCMsgList\_GameEvents.Types.event\_t.md)\>

### <a id="Divine_Protobufs_Dota2_CSVCMsgList_GameEvents_Parser"></a> Parser

```csharp
public static MessageParser<CSVCMsgList_GameEvents> Parser { get; }
```

#### Property Value

 MessageParser<[CSVCMsgList\_GameEvents](Divine.Protobufs.Dota2.CSVCMsgList\_GameEvents.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CSVCMsgList_GameEvents_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsgList_GameEvents_Clone"></a> Clone\(\)

```csharp
public CSVCMsgList_GameEvents Clone()
```

#### Returns

 [CSVCMsgList\_GameEvents](Divine.Protobufs.Dota2.CSVCMsgList\_GameEvents.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsgList_GameEvents_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsgList_GameEvents_Equals_Divine_Protobufs_Dota2_CSVCMsgList_GameEvents_"></a> Equals\(CSVCMsgList\_GameEvents\)

```csharp
public bool Equals(CSVCMsgList_GameEvents other)
```

#### Parameters

`other` [CSVCMsgList\_GameEvents](Divine.Protobufs.Dota2.CSVCMsgList\_GameEvents.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsgList_GameEvents_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsgList_GameEvents_MergeFrom_Divine_Protobufs_Dota2_CSVCMsgList_GameEvents_"></a> MergeFrom\(CSVCMsgList\_GameEvents\)

```csharp
public void MergeFrom(CSVCMsgList_GameEvents other)
```

#### Parameters

`other` [CSVCMsgList\_GameEvents](Divine.Protobufs.Dota2.CSVCMsgList\_GameEvents.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsgList_GameEvents_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSVCMsgList_GameEvents_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSVCMsgList_GameEvents_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

