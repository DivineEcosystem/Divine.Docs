# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_InnatePing"></a> Class CDOTAUserMsg\_InnatePing

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_InnatePing : IMessage<CDOTAUserMsg_InnatePing>, IEquatable<CDOTAUserMsg_InnatePing>, IDeepCloneable<CDOTAUserMsg_InnatePing>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_InnatePing](Divine.Protobufs.Dota2.CDOTAUserMsg\_InnatePing.md)

#### Implements

IMessage<CDOTAUserMsg\_InnatePing\>, 
[IEquatable<CDOTAUserMsg\_InnatePing\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_InnatePing\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_InnatePing\>\(CDOTAUserMsg\_InnatePing, params CDOTAUserMsg\_InnatePing\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_InnatePing__ctor"></a> CDOTAUserMsg\_InnatePing\(\)

```csharp
public CDOTAUserMsg_InnatePing()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_InnatePing__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_InnatePing_"></a> CDOTAUserMsg\_InnatePing\(CDOTAUserMsg\_InnatePing\)

```csharp
public CDOTAUserMsg_InnatePing(CDOTAUserMsg_InnatePing other)
```

#### Parameters

`other` [CDOTAUserMsg\_InnatePing](Divine.Protobufs.Dota2.CDOTAUserMsg\_InnatePing.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_InnatePing_AllChatFieldNumber"></a> AllChatFieldNumber

```csharp
public const int AllChatFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_InnatePing_EntityIdFieldNumber"></a> EntityIdFieldNumber

```csharp
public const int EntityIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_InnatePing_PlayerIdFieldNumber"></a> PlayerIdFieldNumber

```csharp
public const int PlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_InnatePing_AllChat"></a> AllChat

```csharp
public bool AllChat { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_InnatePing_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_InnatePing_EntityId"></a> EntityId

```csharp
public uint EntityId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_InnatePing_HasAllChat"></a> HasAllChat

```csharp
public bool HasAllChat { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_InnatePing_HasEntityId"></a> HasEntityId

```csharp
public bool HasEntityId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_InnatePing_HasPlayerId"></a> HasPlayerId

```csharp
public bool HasPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_InnatePing_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_InnatePing> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_InnatePing](Divine.Protobufs.Dota2.CDOTAUserMsg\_InnatePing.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_InnatePing_PlayerId"></a> PlayerId

```csharp
public int PlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_InnatePing_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_InnatePing_ClearAllChat"></a> ClearAllChat\(\)

```csharp
public void ClearAllChat()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_InnatePing_ClearEntityId"></a> ClearEntityId\(\)

```csharp
public void ClearEntityId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_InnatePing_ClearPlayerId"></a> ClearPlayerId\(\)

```csharp
public void ClearPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_InnatePing_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_InnatePing Clone()
```

#### Returns

 [CDOTAUserMsg\_InnatePing](Divine.Protobufs.Dota2.CDOTAUserMsg\_InnatePing.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_InnatePing_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_InnatePing_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_InnatePing_"></a> Equals\(CDOTAUserMsg\_InnatePing\)

```csharp
public bool Equals(CDOTAUserMsg_InnatePing other)
```

#### Parameters

`other` [CDOTAUserMsg\_InnatePing](Divine.Protobufs.Dota2.CDOTAUserMsg\_InnatePing.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_InnatePing_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_InnatePing_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_InnatePing_"></a> MergeFrom\(CDOTAUserMsg\_InnatePing\)

```csharp
public void MergeFrom(CDOTAUserMsg_InnatePing other)
```

#### Parameters

`other` [CDOTAUserMsg\_InnatePing](Divine.Protobufs.Dota2.CDOTAUserMsg\_InnatePing.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_InnatePing_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_InnatePing_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_InnatePing_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

