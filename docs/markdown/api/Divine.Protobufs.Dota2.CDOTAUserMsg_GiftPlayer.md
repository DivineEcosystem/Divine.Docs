# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GiftPlayer"></a> Class CDOTAUserMsg\_GiftPlayer

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_GiftPlayer : IMessage<CDOTAUserMsg_GiftPlayer>, IEquatable<CDOTAUserMsg_GiftPlayer>, IDeepCloneable<CDOTAUserMsg_GiftPlayer>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_GiftPlayer](Divine.Protobufs.Dota2.CDOTAUserMsg\_GiftPlayer.md)

#### Implements

IMessage<CDOTAUserMsg\_GiftPlayer\>, 
[IEquatable<CDOTAUserMsg\_GiftPlayer\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_GiftPlayer\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_GiftPlayer\>\(CDOTAUserMsg\_GiftPlayer, params CDOTAUserMsg\_GiftPlayer\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GiftPlayer__ctor"></a> CDOTAUserMsg\_GiftPlayer\(\)

```csharp
public CDOTAUserMsg_GiftPlayer()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GiftPlayer__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_GiftPlayer_"></a> CDOTAUserMsg\_GiftPlayer\(CDOTAUserMsg\_GiftPlayer\)

```csharp
public CDOTAUserMsg_GiftPlayer(CDOTAUserMsg_GiftPlayer other)
```

#### Parameters

`other` [CDOTAUserMsg\_GiftPlayer](Divine.Protobufs.Dota2.CDOTAUserMsg\_GiftPlayer.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GiftPlayer_GiftItemDefIndexFieldNumber"></a> GiftItemDefIndexFieldNumber

```csharp
public const int GiftItemDefIndexFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GiftPlayer_SourcePlayerIdFieldNumber"></a> SourcePlayerIdFieldNumber

```csharp
public const int SourcePlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GiftPlayer_TargetPlayerIdFieldNumber"></a> TargetPlayerIdFieldNumber

```csharp
public const int TargetPlayerIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GiftPlayer_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GiftPlayer_GiftItemDefIndex"></a> GiftItemDefIndex

```csharp
public uint GiftItemDefIndex { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GiftPlayer_HasGiftItemDefIndex"></a> HasGiftItemDefIndex

```csharp
public bool HasGiftItemDefIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GiftPlayer_HasSourcePlayerId"></a> HasSourcePlayerId

```csharp
public bool HasSourcePlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GiftPlayer_HasTargetPlayerId"></a> HasTargetPlayerId

```csharp
public bool HasTargetPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GiftPlayer_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_GiftPlayer> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_GiftPlayer](Divine.Protobufs.Dota2.CDOTAUserMsg\_GiftPlayer.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GiftPlayer_SourcePlayerId"></a> SourcePlayerId

```csharp
public int SourcePlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GiftPlayer_TargetPlayerId"></a> TargetPlayerId

```csharp
public int TargetPlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GiftPlayer_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GiftPlayer_ClearGiftItemDefIndex"></a> ClearGiftItemDefIndex\(\)

```csharp
public void ClearGiftItemDefIndex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GiftPlayer_ClearSourcePlayerId"></a> ClearSourcePlayerId\(\)

```csharp
public void ClearSourcePlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GiftPlayer_ClearTargetPlayerId"></a> ClearTargetPlayerId\(\)

```csharp
public void ClearTargetPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GiftPlayer_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_GiftPlayer Clone()
```

#### Returns

 [CDOTAUserMsg\_GiftPlayer](Divine.Protobufs.Dota2.CDOTAUserMsg\_GiftPlayer.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GiftPlayer_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GiftPlayer_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_GiftPlayer_"></a> Equals\(CDOTAUserMsg\_GiftPlayer\)

```csharp
public bool Equals(CDOTAUserMsg_GiftPlayer other)
```

#### Parameters

`other` [CDOTAUserMsg\_GiftPlayer](Divine.Protobufs.Dota2.CDOTAUserMsg\_GiftPlayer.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GiftPlayer_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GiftPlayer_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_GiftPlayer_"></a> MergeFrom\(CDOTAUserMsg\_GiftPlayer\)

```csharp
public void MergeFrom(CDOTAUserMsg_GiftPlayer other)
```

#### Parameters

`other` [CDOTAUserMsg\_GiftPlayer](Divine.Protobufs.Dota2.CDOTAUserMsg\_GiftPlayer.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GiftPlayer_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GiftPlayer_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GiftPlayer_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

