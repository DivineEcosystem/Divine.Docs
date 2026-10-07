# <a id="Divine_Protobufs_Dota2_CBidirMsg_RebroadcastSource"></a> Class CBidirMsg\_RebroadcastSource

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CBidirMsg_RebroadcastSource : IMessage<CBidirMsg_RebroadcastSource>, IEquatable<CBidirMsg_RebroadcastSource>, IDeepCloneable<CBidirMsg_RebroadcastSource>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CBidirMsg\_RebroadcastSource](Divine.Protobufs.Dota2.CBidirMsg\_RebroadcastSource.md)

#### Implements

IMessage<CBidirMsg\_RebroadcastSource\>, 
[IEquatable<CBidirMsg\_RebroadcastSource\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CBidirMsg\_RebroadcastSource\>, 
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
[EnumerableExtensions.In<CBidirMsg\_RebroadcastSource\>\(CBidirMsg\_RebroadcastSource, params CBidirMsg\_RebroadcastSource\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CBidirMsg_RebroadcastSource__ctor"></a> CBidirMsg\_RebroadcastSource\(\)

```csharp
public CBidirMsg_RebroadcastSource()
```

### <a id="Divine_Protobufs_Dota2_CBidirMsg_RebroadcastSource__ctor_Divine_Protobufs_Dota2_CBidirMsg_RebroadcastSource_"></a> CBidirMsg\_RebroadcastSource\(CBidirMsg\_RebroadcastSource\)

```csharp
public CBidirMsg_RebroadcastSource(CBidirMsg_RebroadcastSource other)
```

#### Parameters

`other` [CBidirMsg\_RebroadcastSource](Divine.Protobufs.Dota2.CBidirMsg\_RebroadcastSource.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CBidirMsg_RebroadcastSource_EventsourceFieldNumber"></a> EventsourceFieldNumber

```csharp
public const int EventsourceFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CBidirMsg_RebroadcastSource_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CBidirMsg_RebroadcastSource_Eventsource"></a> Eventsource

```csharp
public int Eventsource { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CBidirMsg_RebroadcastSource_HasEventsource"></a> HasEventsource

```csharp
public bool HasEventsource { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CBidirMsg_RebroadcastSource_Parser"></a> Parser

```csharp
public static MessageParser<CBidirMsg_RebroadcastSource> Parser { get; }
```

#### Property Value

 MessageParser<[CBidirMsg\_RebroadcastSource](Divine.Protobufs.Dota2.CBidirMsg\_RebroadcastSource.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CBidirMsg_RebroadcastSource_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CBidirMsg_RebroadcastSource_ClearEventsource"></a> ClearEventsource\(\)

```csharp
public void ClearEventsource()
```

### <a id="Divine_Protobufs_Dota2_CBidirMsg_RebroadcastSource_Clone"></a> Clone\(\)

```csharp
public CBidirMsg_RebroadcastSource Clone()
```

#### Returns

 [CBidirMsg\_RebroadcastSource](Divine.Protobufs.Dota2.CBidirMsg\_RebroadcastSource.md)

### <a id="Divine_Protobufs_Dota2_CBidirMsg_RebroadcastSource_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CBidirMsg_RebroadcastSource_Equals_Divine_Protobufs_Dota2_CBidirMsg_RebroadcastSource_"></a> Equals\(CBidirMsg\_RebroadcastSource\)

```csharp
public bool Equals(CBidirMsg_RebroadcastSource other)
```

#### Parameters

`other` [CBidirMsg\_RebroadcastSource](Divine.Protobufs.Dota2.CBidirMsg\_RebroadcastSource.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CBidirMsg_RebroadcastSource_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CBidirMsg_RebroadcastSource_MergeFrom_Divine_Protobufs_Dota2_CBidirMsg_RebroadcastSource_"></a> MergeFrom\(CBidirMsg\_RebroadcastSource\)

```csharp
public void MergeFrom(CBidirMsg_RebroadcastSource other)
```

#### Parameters

`other` [CBidirMsg\_RebroadcastSource](Divine.Protobufs.Dota2.CBidirMsg\_RebroadcastSource.md)

### <a id="Divine_Protobufs_Dota2_CBidirMsg_RebroadcastSource_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CBidirMsg_RebroadcastSource_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CBidirMsg_RebroadcastSource_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

