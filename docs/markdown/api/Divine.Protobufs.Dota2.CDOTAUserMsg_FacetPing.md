# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FacetPing"></a> Class CDOTAUserMsg\_FacetPing

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_FacetPing : IMessage<CDOTAUserMsg_FacetPing>, IEquatable<CDOTAUserMsg_FacetPing>, IDeepCloneable<CDOTAUserMsg_FacetPing>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_FacetPing](Divine.Protobufs.Dota2.CDOTAUserMsg\_FacetPing.md)

#### Implements

IMessage<CDOTAUserMsg\_FacetPing\>, 
[IEquatable<CDOTAUserMsg\_FacetPing\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_FacetPing\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_FacetPing\>\(CDOTAUserMsg\_FacetPing, params CDOTAUserMsg\_FacetPing\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FacetPing__ctor"></a> CDOTAUserMsg\_FacetPing\(\)

```csharp
public CDOTAUserMsg_FacetPing()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FacetPing__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_FacetPing_"></a> CDOTAUserMsg\_FacetPing\(CDOTAUserMsg\_FacetPing\)

```csharp
public CDOTAUserMsg_FacetPing(CDOTAUserMsg_FacetPing other)
```

#### Parameters

`other` [CDOTAUserMsg\_FacetPing](Divine.Protobufs.Dota2.CDOTAUserMsg\_FacetPing.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FacetPing_AllChatFieldNumber"></a> AllChatFieldNumber

```csharp
public const int AllChatFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FacetPing_EntityIdFieldNumber"></a> EntityIdFieldNumber

```csharp
public const int EntityIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FacetPing_FacetStrhashFieldNumber"></a> FacetStrhashFieldNumber

```csharp
public const int FacetStrhashFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FacetPing_PlayerIdFieldNumber"></a> PlayerIdFieldNumber

```csharp
public const int PlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FacetPing_AllChat"></a> AllChat

```csharp
public bool AllChat { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FacetPing_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FacetPing_EntityId"></a> EntityId

```csharp
public uint EntityId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FacetPing_FacetStrhash"></a> FacetStrhash

```csharp
public uint FacetStrhash { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FacetPing_HasAllChat"></a> HasAllChat

```csharp
public bool HasAllChat { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FacetPing_HasEntityId"></a> HasEntityId

```csharp
public bool HasEntityId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FacetPing_HasFacetStrhash"></a> HasFacetStrhash

```csharp
public bool HasFacetStrhash { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FacetPing_HasPlayerId"></a> HasPlayerId

```csharp
public bool HasPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FacetPing_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_FacetPing> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_FacetPing](Divine.Protobufs.Dota2.CDOTAUserMsg\_FacetPing.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FacetPing_PlayerId"></a> PlayerId

```csharp
public int PlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FacetPing_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FacetPing_ClearAllChat"></a> ClearAllChat\(\)

```csharp
public void ClearAllChat()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FacetPing_ClearEntityId"></a> ClearEntityId\(\)

```csharp
public void ClearEntityId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FacetPing_ClearFacetStrhash"></a> ClearFacetStrhash\(\)

```csharp
public void ClearFacetStrhash()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FacetPing_ClearPlayerId"></a> ClearPlayerId\(\)

```csharp
public void ClearPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FacetPing_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_FacetPing Clone()
```

#### Returns

 [CDOTAUserMsg\_FacetPing](Divine.Protobufs.Dota2.CDOTAUserMsg\_FacetPing.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FacetPing_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FacetPing_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_FacetPing_"></a> Equals\(CDOTAUserMsg\_FacetPing\)

```csharp
public bool Equals(CDOTAUserMsg_FacetPing other)
```

#### Parameters

`other` [CDOTAUserMsg\_FacetPing](Divine.Protobufs.Dota2.CDOTAUserMsg\_FacetPing.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FacetPing_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FacetPing_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_FacetPing_"></a> MergeFrom\(CDOTAUserMsg\_FacetPing\)

```csharp
public void MergeFrom(CDOTAUserMsg_FacetPing other)
```

#### Parameters

`other` [CDOTAUserMsg\_FacetPing](Divine.Protobufs.Dota2.CDOTAUserMsg\_FacetPing.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FacetPing_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FacetPing_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FacetPing_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

