# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GiftPlayer"></a> Class CDOTAClientMsg\_GiftPlayer

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_GiftPlayer : IMessage<CDOTAClientMsg_GiftPlayer>, IEquatable<CDOTAClientMsg_GiftPlayer>, IDeepCloneable<CDOTAClientMsg_GiftPlayer>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_GiftPlayer](Divine.Protobufs.Dota2.CDOTAClientMsg\_GiftPlayer.md)

#### Implements

IMessage<CDOTAClientMsg\_GiftPlayer\>, 
[IEquatable<CDOTAClientMsg\_GiftPlayer\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_GiftPlayer\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_GiftPlayer\>\(CDOTAClientMsg\_GiftPlayer, params CDOTAClientMsg\_GiftPlayer\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GiftPlayer__ctor"></a> CDOTAClientMsg\_GiftPlayer\(\)

```csharp
public CDOTAClientMsg_GiftPlayer()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GiftPlayer__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_GiftPlayer_"></a> CDOTAClientMsg\_GiftPlayer\(CDOTAClientMsg\_GiftPlayer\)

```csharp
public CDOTAClientMsg_GiftPlayer(CDOTAClientMsg_GiftPlayer other)
```

#### Parameters

`other` [CDOTAClientMsg\_GiftPlayer](Divine.Protobufs.Dota2.CDOTAClientMsg\_GiftPlayer.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GiftPlayer_ItemDefIndexFieldNumber"></a> ItemDefIndexFieldNumber

```csharp
public const int ItemDefIndexFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GiftPlayer_TargetPlayerIdFieldNumber"></a> TargetPlayerIdFieldNumber

```csharp
public const int TargetPlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GiftPlayer_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GiftPlayer_HasItemDefIndex"></a> HasItemDefIndex

```csharp
public bool HasItemDefIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GiftPlayer_HasTargetPlayerId"></a> HasTargetPlayerId

```csharp
public bool HasTargetPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GiftPlayer_ItemDefIndex"></a> ItemDefIndex

```csharp
public uint ItemDefIndex { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GiftPlayer_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_GiftPlayer> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_GiftPlayer](Divine.Protobufs.Dota2.CDOTAClientMsg\_GiftPlayer.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GiftPlayer_TargetPlayerId"></a> TargetPlayerId

```csharp
public int TargetPlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GiftPlayer_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GiftPlayer_ClearItemDefIndex"></a> ClearItemDefIndex\(\)

```csharp
public void ClearItemDefIndex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GiftPlayer_ClearTargetPlayerId"></a> ClearTargetPlayerId\(\)

```csharp
public void ClearTargetPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GiftPlayer_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_GiftPlayer Clone()
```

#### Returns

 [CDOTAClientMsg\_GiftPlayer](Divine.Protobufs.Dota2.CDOTAClientMsg\_GiftPlayer.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GiftPlayer_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GiftPlayer_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_GiftPlayer_"></a> Equals\(CDOTAClientMsg\_GiftPlayer\)

```csharp
public bool Equals(CDOTAClientMsg_GiftPlayer other)
```

#### Parameters

`other` [CDOTAClientMsg\_GiftPlayer](Divine.Protobufs.Dota2.CDOTAClientMsg\_GiftPlayer.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GiftPlayer_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GiftPlayer_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_GiftPlayer_"></a> MergeFrom\(CDOTAClientMsg\_GiftPlayer\)

```csharp
public void MergeFrom(CDOTAClientMsg_GiftPlayer other)
```

#### Parameters

`other` [CDOTAClientMsg\_GiftPlayer](Divine.Protobufs.Dota2.CDOTAClientMsg\_GiftPlayer.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GiftPlayer_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GiftPlayer_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GiftPlayer_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

