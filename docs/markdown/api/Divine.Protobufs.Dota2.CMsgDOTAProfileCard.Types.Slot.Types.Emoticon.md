# <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Emoticon"></a> Class CMsgDOTAProfileCard.Types.Slot.Types.Emoticon

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAProfileCard.Types.Slot.Types.Emoticon : IMessage<CMsgDOTAProfileCard.Types.Slot.Types.Emoticon>, IEquatable<CMsgDOTAProfileCard.Types.Slot.Types.Emoticon>, IDeepCloneable<CMsgDOTAProfileCard.Types.Slot.Types.Emoticon>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAProfileCard.Types.Slot.Types.Emoticon](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.Types.Emoticon.md)

#### Implements

IMessage<CMsgDOTAProfileCard.Types.Slot.Types.Emoticon\>, 
[IEquatable<CMsgDOTAProfileCard.Types.Slot.Types.Emoticon\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAProfileCard.Types.Slot.Types.Emoticon\>, 
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
[EnumerableExtensions.In<CMsgDOTAProfileCard.Types.Slot.Types.Emoticon\>\(CMsgDOTAProfileCard.Types.Slot.Types.Emoticon, params CMsgDOTAProfileCard.Types.Slot.Types.Emoticon\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Emoticon__ctor"></a> Emoticon\(\)

```csharp
public Emoticon()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Emoticon__ctor_Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Emoticon_"></a> Emoticon\(Emoticon\)

```csharp
public Emoticon(CMsgDOTAProfileCard.Types.Slot.Types.Emoticon other)
```

#### Parameters

`other` [CMsgDOTAProfileCard](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.md).[Slot](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.Types.md).[Emoticon](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.Types.Emoticon.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Emoticon_EmoticonIdFieldNumber"></a> EmoticonIdFieldNumber

```csharp
public const int EmoticonIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Emoticon_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Emoticon_EmoticonId"></a> EmoticonId

```csharp
public uint EmoticonId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Emoticon_HasEmoticonId"></a> HasEmoticonId

```csharp
public bool HasEmoticonId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Emoticon_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAProfileCard.Types.Slot.Types.Emoticon> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAProfileCard](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.md).[Slot](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.Types.md).[Emoticon](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.Types.Emoticon.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Emoticon_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Emoticon_ClearEmoticonId"></a> ClearEmoticonId\(\)

```csharp
public void ClearEmoticonId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Emoticon_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAProfileCard.Types.Slot.Types.Emoticon Clone()
```

#### Returns

 [CMsgDOTAProfileCard](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.md).[Slot](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.Types.md).[Emoticon](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.Types.Emoticon.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Emoticon_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Emoticon_Equals_Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Emoticon_"></a> Equals\(Emoticon\)

```csharp
public bool Equals(CMsgDOTAProfileCard.Types.Slot.Types.Emoticon other)
```

#### Parameters

`other` [CMsgDOTAProfileCard](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.md).[Slot](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.Types.md).[Emoticon](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.Types.Emoticon.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Emoticon_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Emoticon_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Emoticon_"></a> MergeFrom\(Emoticon\)

```csharp
public void MergeFrom(CMsgDOTAProfileCard.Types.Slot.Types.Emoticon other)
```

#### Parameters

`other` [CMsgDOTAProfileCard](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.md).[Slot](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.Types.md).[Emoticon](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.Slot.Types.Emoticon.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Emoticon_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Emoticon_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileCard_Types_Slot_Types_Emoticon_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

