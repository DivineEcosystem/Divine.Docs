# <a id="Divine_Protobufs_Dota2_CMsgDPCEventList"></a> Class CMsgDPCEventList

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDPCEventList : IMessage<CMsgDPCEventList>, IEquatable<CMsgDPCEventList>, IDeepCloneable<CMsgDPCEventList>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDPCEventList](Divine.Protobufs.Dota2.CMsgDPCEventList.md)

#### Implements

IMessage<CMsgDPCEventList\>, 
[IEquatable<CMsgDPCEventList\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDPCEventList\>, 
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
[EnumerableExtensions.In<CMsgDPCEventList\>\(CMsgDPCEventList, params CMsgDPCEventList\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDPCEventList__ctor"></a> CMsgDPCEventList\(\)

```csharp
public CMsgDPCEventList()
```

### <a id="Divine_Protobufs_Dota2_CMsgDPCEventList__ctor_Divine_Protobufs_Dota2_CMsgDPCEventList_"></a> CMsgDPCEventList\(CMsgDPCEventList\)

```csharp
public CMsgDPCEventList(CMsgDPCEventList other)
```

#### Parameters

`other` [CMsgDPCEventList](Divine.Protobufs.Dota2.CMsgDPCEventList.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDPCEventList_EventsFieldNumber"></a> EventsFieldNumber

```csharp
public const int EventsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDPCEventList_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDPCEventList_Events"></a> Events

```csharp
public RepeatedField<CMsgDPCEvent> Events { get; }
```

#### Property Value

 RepeatedField<[CMsgDPCEvent](Divine.Protobufs.Dota2.CMsgDPCEvent.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDPCEventList_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDPCEventList> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDPCEventList](Divine.Protobufs.Dota2.CMsgDPCEventList.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDPCEventList_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEventList_Clone"></a> Clone\(\)

```csharp
public CMsgDPCEventList Clone()
```

#### Returns

 [CMsgDPCEventList](Divine.Protobufs.Dota2.CMsgDPCEventList.md)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEventList_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEventList_Equals_Divine_Protobufs_Dota2_CMsgDPCEventList_"></a> Equals\(CMsgDPCEventList\)

```csharp
public bool Equals(CMsgDPCEventList other)
```

#### Parameters

`other` [CMsgDPCEventList](Divine.Protobufs.Dota2.CMsgDPCEventList.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEventList_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEventList_MergeFrom_Divine_Protobufs_Dota2_CMsgDPCEventList_"></a> MergeFrom\(CMsgDPCEventList\)

```csharp
public void MergeFrom(CMsgDPCEventList other)
```

#### Parameters

`other` [CMsgDPCEventList](Divine.Protobufs.Dota2.CMsgDPCEventList.md)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEventList_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDPCEventList_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDPCEventList_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

