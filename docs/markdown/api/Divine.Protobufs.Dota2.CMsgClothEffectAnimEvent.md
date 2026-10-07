# <a id="Divine_Protobufs_Dota2_CMsgClothEffectAnimEvent"></a> Class CMsgClothEffectAnimEvent

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClothEffectAnimEvent : IMessage<CMsgClothEffectAnimEvent>, IEquatable<CMsgClothEffectAnimEvent>, IDeepCloneable<CMsgClothEffectAnimEvent>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClothEffectAnimEvent](Divine.Protobufs.Dota2.CMsgClothEffectAnimEvent.md)

#### Implements

IMessage<CMsgClothEffectAnimEvent\>, 
[IEquatable<CMsgClothEffectAnimEvent\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClothEffectAnimEvent\>, 
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
[EnumerableExtensions.In<CMsgClothEffectAnimEvent\>\(CMsgClothEffectAnimEvent, params CMsgClothEffectAnimEvent\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClothEffectAnimEvent__ctor"></a> CMsgClothEffectAnimEvent\(\)

```csharp
public CMsgClothEffectAnimEvent()
```

### <a id="Divine_Protobufs_Dota2_CMsgClothEffectAnimEvent__ctor_Divine_Protobufs_Dota2_CMsgClothEffectAnimEvent_"></a> CMsgClothEffectAnimEvent\(CMsgClothEffectAnimEvent\)

```csharp
public CMsgClothEffectAnimEvent(CMsgClothEffectAnimEvent other)
```

#### Parameters

`other` [CMsgClothEffectAnimEvent](Divine.Protobufs.Dota2.CMsgClothEffectAnimEvent.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClothEffectAnimEvent_EffectNameHashFieldNumber"></a> EffectNameHashFieldNumber

```csharp
public const int EffectNameHashFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClothEffectAnimEvent_FlagsFieldNumber"></a> FlagsFieldNumber

```csharp
public const int FlagsFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClothEffectAnimEvent_OperationFieldNumber"></a> OperationFieldNumber

```csharp
public const int OperationFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClothEffectAnimEvent_PteFieldNumber"></a> PteFieldNumber

```csharp
public const int PteFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClothEffectAnimEvent_SourceEntityIndexFieldNumber"></a> SourceEntityIndexFieldNumber

```csharp
public const int SourceEntityIndexFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClothEffectAnimEvent_TagsFieldNumber"></a> TagsFieldNumber

```csharp
public const int TagsFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClothEffectAnimEvent_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClothEffectAnimEvent_EffectNameHash"></a> EffectNameHash

```csharp
public int EffectNameHash { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClothEffectAnimEvent_Flags"></a> Flags

```csharp
public int Flags { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClothEffectAnimEvent_HasEffectNameHash"></a> HasEffectNameHash

```csharp
public bool HasEffectNameHash { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClothEffectAnimEvent_HasFlags"></a> HasFlags

```csharp
public bool HasFlags { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClothEffectAnimEvent_HasOperation"></a> HasOperation

```csharp
public bool HasOperation { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClothEffectAnimEvent_HasSourceEntityIndex"></a> HasSourceEntityIndex

```csharp
public bool HasSourceEntityIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClothEffectAnimEvent_HasTags"></a> HasTags

```csharp
public bool HasTags { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClothEffectAnimEvent_Operation"></a> Operation

```csharp
public int Operation { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClothEffectAnimEvent_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClothEffectAnimEvent> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClothEffectAnimEvent](Divine.Protobufs.Dota2.CMsgClothEffectAnimEvent.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClothEffectAnimEvent_Pte"></a> Pte

```csharp
public CMsgVector Pte { get; set; }
```

#### Property Value

 [CMsgVector](Divine.Protobufs.Dota2.CMsgVector.md)

### <a id="Divine_Protobufs_Dota2_CMsgClothEffectAnimEvent_SourceEntityIndex"></a> SourceEntityIndex

```csharp
public int SourceEntityIndex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClothEffectAnimEvent_Tags"></a> Tags

```csharp
public string Tags { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClothEffectAnimEvent_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClothEffectAnimEvent_ClearEffectNameHash"></a> ClearEffectNameHash\(\)

```csharp
public void ClearEffectNameHash()
```

### <a id="Divine_Protobufs_Dota2_CMsgClothEffectAnimEvent_ClearFlags"></a> ClearFlags\(\)

```csharp
public void ClearFlags()
```

### <a id="Divine_Protobufs_Dota2_CMsgClothEffectAnimEvent_ClearOperation"></a> ClearOperation\(\)

```csharp
public void ClearOperation()
```

### <a id="Divine_Protobufs_Dota2_CMsgClothEffectAnimEvent_ClearSourceEntityIndex"></a> ClearSourceEntityIndex\(\)

```csharp
public void ClearSourceEntityIndex()
```

### <a id="Divine_Protobufs_Dota2_CMsgClothEffectAnimEvent_ClearTags"></a> ClearTags\(\)

```csharp
public void ClearTags()
```

### <a id="Divine_Protobufs_Dota2_CMsgClothEffectAnimEvent_Clone"></a> Clone\(\)

```csharp
public CMsgClothEffectAnimEvent Clone()
```

#### Returns

 [CMsgClothEffectAnimEvent](Divine.Protobufs.Dota2.CMsgClothEffectAnimEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgClothEffectAnimEvent_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClothEffectAnimEvent_Equals_Divine_Protobufs_Dota2_CMsgClothEffectAnimEvent_"></a> Equals\(CMsgClothEffectAnimEvent\)

```csharp
public bool Equals(CMsgClothEffectAnimEvent other)
```

#### Parameters

`other` [CMsgClothEffectAnimEvent](Divine.Protobufs.Dota2.CMsgClothEffectAnimEvent.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClothEffectAnimEvent_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClothEffectAnimEvent_MergeFrom_Divine_Protobufs_Dota2_CMsgClothEffectAnimEvent_"></a> MergeFrom\(CMsgClothEffectAnimEvent\)

```csharp
public void MergeFrom(CMsgClothEffectAnimEvent other)
```

#### Parameters

`other` [CMsgClothEffectAnimEvent](Divine.Protobufs.Dota2.CMsgClothEffectAnimEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgClothEffectAnimEvent_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClothEffectAnimEvent_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClothEffectAnimEvent_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

