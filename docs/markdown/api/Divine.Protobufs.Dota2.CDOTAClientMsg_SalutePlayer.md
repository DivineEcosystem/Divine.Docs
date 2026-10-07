# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SalutePlayer"></a> Class CDOTAClientMsg\_SalutePlayer

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_SalutePlayer : IMessage<CDOTAClientMsg_SalutePlayer>, IEquatable<CDOTAClientMsg_SalutePlayer>, IDeepCloneable<CDOTAClientMsg_SalutePlayer>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_SalutePlayer](Divine.Protobufs.Dota2.CDOTAClientMsg\_SalutePlayer.md)

#### Implements

IMessage<CDOTAClientMsg\_SalutePlayer\>, 
[IEquatable<CDOTAClientMsg\_SalutePlayer\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_SalutePlayer\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_SalutePlayer\>\(CDOTAClientMsg\_SalutePlayer, params CDOTAClientMsg\_SalutePlayer\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SalutePlayer__ctor"></a> CDOTAClientMsg\_SalutePlayer\(\)

```csharp
public CDOTAClientMsg_SalutePlayer()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SalutePlayer__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_SalutePlayer_"></a> CDOTAClientMsg\_SalutePlayer\(CDOTAClientMsg\_SalutePlayer\)

```csharp
public CDOTAClientMsg_SalutePlayer(CDOTAClientMsg_SalutePlayer other)
```

#### Parameters

`other` [CDOTAClientMsg\_SalutePlayer](Divine.Protobufs.Dota2.CDOTAClientMsg\_SalutePlayer.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SalutePlayer_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SalutePlayer_TargetPlayerIdFieldNumber"></a> TargetPlayerIdFieldNumber

```csharp
public const int TargetPlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SalutePlayer_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SalutePlayer_EventId"></a> EventId

```csharp
public int EventId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SalutePlayer_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SalutePlayer_HasTargetPlayerId"></a> HasTargetPlayerId

```csharp
public bool HasTargetPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SalutePlayer_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_SalutePlayer> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_SalutePlayer](Divine.Protobufs.Dota2.CDOTAClientMsg\_SalutePlayer.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SalutePlayer_TargetPlayerId"></a> TargetPlayerId

```csharp
public int TargetPlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SalutePlayer_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SalutePlayer_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SalutePlayer_ClearTargetPlayerId"></a> ClearTargetPlayerId\(\)

```csharp
public void ClearTargetPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SalutePlayer_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_SalutePlayer Clone()
```

#### Returns

 [CDOTAClientMsg\_SalutePlayer](Divine.Protobufs.Dota2.CDOTAClientMsg\_SalutePlayer.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SalutePlayer_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SalutePlayer_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_SalutePlayer_"></a> Equals\(CDOTAClientMsg\_SalutePlayer\)

```csharp
public bool Equals(CDOTAClientMsg_SalutePlayer other)
```

#### Parameters

`other` [CDOTAClientMsg\_SalutePlayer](Divine.Protobufs.Dota2.CDOTAClientMsg\_SalutePlayer.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SalutePlayer_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SalutePlayer_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_SalutePlayer_"></a> MergeFrom\(CDOTAClientMsg\_SalutePlayer\)

```csharp
public void MergeFrom(CDOTAClientMsg_SalutePlayer other)
```

#### Parameters

`other` [CDOTAClientMsg\_SalutePlayer](Divine.Protobufs.Dota2.CDOTAClientMsg\_SalutePlayer.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SalutePlayer_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SalutePlayer_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SalutePlayer_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

