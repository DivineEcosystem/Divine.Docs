# <a id="Divine_Protobufs_Dota2_CCLCMsg_ListenEvents"></a> Class CCLCMsg\_ListenEvents

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CCLCMsg_ListenEvents : IMessage<CCLCMsg_ListenEvents>, IEquatable<CCLCMsg_ListenEvents>, IDeepCloneable<CCLCMsg_ListenEvents>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CCLCMsg\_ListenEvents](Divine.Protobufs.Dota2.CCLCMsg\_ListenEvents.md)

#### Implements

IMessage<CCLCMsg\_ListenEvents\>, 
[IEquatable<CCLCMsg\_ListenEvents\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CCLCMsg\_ListenEvents\>, 
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
[EnumerableExtensions.In<CCLCMsg\_ListenEvents\>\(CCLCMsg\_ListenEvents, params CCLCMsg\_ListenEvents\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CCLCMsg_ListenEvents__ctor"></a> CCLCMsg\_ListenEvents\(\)

```csharp
public CCLCMsg_ListenEvents()
```

### <a id="Divine_Protobufs_Dota2_CCLCMsg_ListenEvents__ctor_Divine_Protobufs_Dota2_CCLCMsg_ListenEvents_"></a> CCLCMsg\_ListenEvents\(CCLCMsg\_ListenEvents\)

```csharp
public CCLCMsg_ListenEvents(CCLCMsg_ListenEvents other)
```

#### Parameters

`other` [CCLCMsg\_ListenEvents](Divine.Protobufs.Dota2.CCLCMsg\_ListenEvents.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CCLCMsg_ListenEvents_EventMaskFieldNumber"></a> EventMaskFieldNumber

```csharp
public const int EventMaskFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CCLCMsg_ListenEvents_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CCLCMsg_ListenEvents_EventMask"></a> EventMask

```csharp
public RepeatedField<uint> EventMask { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CCLCMsg_ListenEvents_Parser"></a> Parser

```csharp
public static MessageParser<CCLCMsg_ListenEvents> Parser { get; }
```

#### Property Value

 MessageParser<[CCLCMsg\_ListenEvents](Divine.Protobufs.Dota2.CCLCMsg\_ListenEvents.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CCLCMsg_ListenEvents_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_ListenEvents_Clone"></a> Clone\(\)

```csharp
public CCLCMsg_ListenEvents Clone()
```

#### Returns

 [CCLCMsg\_ListenEvents](Divine.Protobufs.Dota2.CCLCMsg\_ListenEvents.md)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_ListenEvents_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_ListenEvents_Equals_Divine_Protobufs_Dota2_CCLCMsg_ListenEvents_"></a> Equals\(CCLCMsg\_ListenEvents\)

```csharp
public bool Equals(CCLCMsg_ListenEvents other)
```

#### Parameters

`other` [CCLCMsg\_ListenEvents](Divine.Protobufs.Dota2.CCLCMsg\_ListenEvents.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_ListenEvents_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_ListenEvents_MergeFrom_Divine_Protobufs_Dota2_CCLCMsg_ListenEvents_"></a> MergeFrom\(CCLCMsg\_ListenEvents\)

```csharp
public void MergeFrom(CCLCMsg_ListenEvents other)
```

#### Parameters

`other` [CCLCMsg\_ListenEvents](Divine.Protobufs.Dota2.CCLCMsg\_ListenEvents.md)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_ListenEvents_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CCLCMsg_ListenEvents_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_ListenEvents_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

