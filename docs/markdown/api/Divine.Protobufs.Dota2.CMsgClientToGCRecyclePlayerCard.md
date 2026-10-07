# <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecyclePlayerCard"></a> Class CMsgClientToGCRecyclePlayerCard

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCRecyclePlayerCard : IMessage<CMsgClientToGCRecyclePlayerCard>, IEquatable<CMsgClientToGCRecyclePlayerCard>, IDeepCloneable<CMsgClientToGCRecyclePlayerCard>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCRecyclePlayerCard](Divine.Protobufs.Dota2.CMsgClientToGCRecyclePlayerCard.md)

#### Implements

IMessage<CMsgClientToGCRecyclePlayerCard\>, 
[IEquatable<CMsgClientToGCRecyclePlayerCard\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCRecyclePlayerCard\>, 
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
[EnumerableExtensions.In<CMsgClientToGCRecyclePlayerCard\>\(CMsgClientToGCRecyclePlayerCard, params CMsgClientToGCRecyclePlayerCard\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecyclePlayerCard__ctor"></a> CMsgClientToGCRecyclePlayerCard\(\)

```csharp
public CMsgClientToGCRecyclePlayerCard()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecyclePlayerCard__ctor_Divine_Protobufs_Dota2_CMsgClientToGCRecyclePlayerCard_"></a> CMsgClientToGCRecyclePlayerCard\(CMsgClientToGCRecyclePlayerCard\)

```csharp
public CMsgClientToGCRecyclePlayerCard(CMsgClientToGCRecyclePlayerCard other)
```

#### Parameters

`other` [CMsgClientToGCRecyclePlayerCard](Divine.Protobufs.Dota2.CMsgClientToGCRecyclePlayerCard.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecyclePlayerCard_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecyclePlayerCard_PlayerCardItemIdsFieldNumber"></a> PlayerCardItemIdsFieldNumber

```csharp
public const int PlayerCardItemIdsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecyclePlayerCard_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecyclePlayerCard_EventId"></a> EventId

```csharp
public uint EventId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecyclePlayerCard_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecyclePlayerCard_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCRecyclePlayerCard> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCRecyclePlayerCard](Divine.Protobufs.Dota2.CMsgClientToGCRecyclePlayerCard.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecyclePlayerCard_PlayerCardItemIds"></a> PlayerCardItemIds

```csharp
public RepeatedField<ulong> PlayerCardItemIds { get; }
```

#### Property Value

 RepeatedField<[ulong](https://learn.microsoft.com/dotnet/api/system.uint64)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecyclePlayerCard_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecyclePlayerCard_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecyclePlayerCard_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCRecyclePlayerCard Clone()
```

#### Returns

 [CMsgClientToGCRecyclePlayerCard](Divine.Protobufs.Dota2.CMsgClientToGCRecyclePlayerCard.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecyclePlayerCard_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecyclePlayerCard_Equals_Divine_Protobufs_Dota2_CMsgClientToGCRecyclePlayerCard_"></a> Equals\(CMsgClientToGCRecyclePlayerCard\)

```csharp
public bool Equals(CMsgClientToGCRecyclePlayerCard other)
```

#### Parameters

`other` [CMsgClientToGCRecyclePlayerCard](Divine.Protobufs.Dota2.CMsgClientToGCRecyclePlayerCard.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecyclePlayerCard_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecyclePlayerCard_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCRecyclePlayerCard_"></a> MergeFrom\(CMsgClientToGCRecyclePlayerCard\)

```csharp
public void MergeFrom(CMsgClientToGCRecyclePlayerCard other)
```

#### Parameters

`other` [CMsgClientToGCRecyclePlayerCard](Divine.Protobufs.Dota2.CMsgClientToGCRecyclePlayerCard.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecyclePlayerCard_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecyclePlayerCard_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRecyclePlayerCard_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

