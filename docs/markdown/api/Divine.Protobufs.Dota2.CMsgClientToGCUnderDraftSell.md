# <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftSell"></a> Class CMsgClientToGCUnderDraftSell

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCUnderDraftSell : IMessage<CMsgClientToGCUnderDraftSell>, IEquatable<CMsgClientToGCUnderDraftSell>, IDeepCloneable<CMsgClientToGCUnderDraftSell>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCUnderDraftSell](Divine.Protobufs.Dota2.CMsgClientToGCUnderDraftSell.md)

#### Implements

IMessage<CMsgClientToGCUnderDraftSell\>, 
[IEquatable<CMsgClientToGCUnderDraftSell\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCUnderDraftSell\>, 
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
[EnumerableExtensions.In<CMsgClientToGCUnderDraftSell\>\(CMsgClientToGCUnderDraftSell, params CMsgClientToGCUnderDraftSell\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftSell__ctor"></a> CMsgClientToGCUnderDraftSell\(\)

```csharp
public CMsgClientToGCUnderDraftSell()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftSell__ctor_Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftSell_"></a> CMsgClientToGCUnderDraftSell\(CMsgClientToGCUnderDraftSell\)

```csharp
public CMsgClientToGCUnderDraftSell(CMsgClientToGCUnderDraftSell other)
```

#### Parameters

`other` [CMsgClientToGCUnderDraftSell](Divine.Protobufs.Dota2.CMsgClientToGCUnderDraftSell.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftSell_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftSell_SlotIdFieldNumber"></a> SlotIdFieldNumber

```csharp
public const int SlotIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftSell_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftSell_EventId"></a> EventId

```csharp
public uint EventId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftSell_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftSell_HasSlotId"></a> HasSlotId

```csharp
public bool HasSlotId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftSell_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCUnderDraftSell> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCUnderDraftSell](Divine.Protobufs.Dota2.CMsgClientToGCUnderDraftSell.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftSell_SlotId"></a> SlotId

```csharp
public uint SlotId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftSell_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftSell_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftSell_ClearSlotId"></a> ClearSlotId\(\)

```csharp
public void ClearSlotId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftSell_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCUnderDraftSell Clone()
```

#### Returns

 [CMsgClientToGCUnderDraftSell](Divine.Protobufs.Dota2.CMsgClientToGCUnderDraftSell.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftSell_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftSell_Equals_Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftSell_"></a> Equals\(CMsgClientToGCUnderDraftSell\)

```csharp
public bool Equals(CMsgClientToGCUnderDraftSell other)
```

#### Parameters

`other` [CMsgClientToGCUnderDraftSell](Divine.Protobufs.Dota2.CMsgClientToGCUnderDraftSell.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftSell_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftSell_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftSell_"></a> MergeFrom\(CMsgClientToGCUnderDraftSell\)

```csharp
public void MergeFrom(CMsgClientToGCUnderDraftSell other)
```

#### Parameters

`other` [CMsgClientToGCUnderDraftSell](Divine.Protobufs.Dota2.CMsgClientToGCUnderDraftSell.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftSell_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftSell_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftSell_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

