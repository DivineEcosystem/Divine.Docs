# <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreatePlayerCardPack"></a> Class CMsgClientToGCCreatePlayerCardPack

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCCreatePlayerCardPack : IMessage<CMsgClientToGCCreatePlayerCardPack>, IEquatable<CMsgClientToGCCreatePlayerCardPack>, IDeepCloneable<CMsgClientToGCCreatePlayerCardPack>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCCreatePlayerCardPack](Divine.Protobufs.Dota2.CMsgClientToGCCreatePlayerCardPack.md)

#### Implements

IMessage<CMsgClientToGCCreatePlayerCardPack\>, 
[IEquatable<CMsgClientToGCCreatePlayerCardPack\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCCreatePlayerCardPack\>, 
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
[EnumerableExtensions.In<CMsgClientToGCCreatePlayerCardPack\>\(CMsgClientToGCCreatePlayerCardPack, params CMsgClientToGCCreatePlayerCardPack\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreatePlayerCardPack__ctor"></a> CMsgClientToGCCreatePlayerCardPack\(\)

```csharp
public CMsgClientToGCCreatePlayerCardPack()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreatePlayerCardPack__ctor_Divine_Protobufs_Dota2_CMsgClientToGCCreatePlayerCardPack_"></a> CMsgClientToGCCreatePlayerCardPack\(CMsgClientToGCCreatePlayerCardPack\)

```csharp
public CMsgClientToGCCreatePlayerCardPack(CMsgClientToGCCreatePlayerCardPack other)
```

#### Parameters

`other` [CMsgClientToGCCreatePlayerCardPack](Divine.Protobufs.Dota2.CMsgClientToGCCreatePlayerCardPack.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreatePlayerCardPack_CardDustItemIdFieldNumber"></a> CardDustItemIdFieldNumber

```csharp
public const int CardDustItemIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreatePlayerCardPack_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreatePlayerCardPack_PremiumPackFieldNumber"></a> PremiumPackFieldNumber

```csharp
public const int PremiumPackFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreatePlayerCardPack_CardDustItemId"></a> CardDustItemId

```csharp
public ulong CardDustItemId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreatePlayerCardPack_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreatePlayerCardPack_EventId"></a> EventId

```csharp
public uint EventId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreatePlayerCardPack_HasCardDustItemId"></a> HasCardDustItemId

```csharp
public bool HasCardDustItemId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreatePlayerCardPack_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreatePlayerCardPack_HasPremiumPack"></a> HasPremiumPack

```csharp
public bool HasPremiumPack { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreatePlayerCardPack_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCCreatePlayerCardPack> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCCreatePlayerCardPack](Divine.Protobufs.Dota2.CMsgClientToGCCreatePlayerCardPack.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreatePlayerCardPack_PremiumPack"></a> PremiumPack

```csharp
public bool PremiumPack { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreatePlayerCardPack_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreatePlayerCardPack_ClearCardDustItemId"></a> ClearCardDustItemId\(\)

```csharp
public void ClearCardDustItemId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreatePlayerCardPack_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreatePlayerCardPack_ClearPremiumPack"></a> ClearPremiumPack\(\)

```csharp
public void ClearPremiumPack()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreatePlayerCardPack_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCCreatePlayerCardPack Clone()
```

#### Returns

 [CMsgClientToGCCreatePlayerCardPack](Divine.Protobufs.Dota2.CMsgClientToGCCreatePlayerCardPack.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreatePlayerCardPack_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreatePlayerCardPack_Equals_Divine_Protobufs_Dota2_CMsgClientToGCCreatePlayerCardPack_"></a> Equals\(CMsgClientToGCCreatePlayerCardPack\)

```csharp
public bool Equals(CMsgClientToGCCreatePlayerCardPack other)
```

#### Parameters

`other` [CMsgClientToGCCreatePlayerCardPack](Divine.Protobufs.Dota2.CMsgClientToGCCreatePlayerCardPack.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreatePlayerCardPack_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreatePlayerCardPack_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCCreatePlayerCardPack_"></a> MergeFrom\(CMsgClientToGCCreatePlayerCardPack\)

```csharp
public void MergeFrom(CMsgClientToGCCreatePlayerCardPack other)
```

#### Parameters

`other` [CMsgClientToGCCreatePlayerCardPack](Divine.Protobufs.Dota2.CMsgClientToGCCreatePlayerCardPack.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreatePlayerCardPack_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreatePlayerCardPack_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreatePlayerCardPack_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

