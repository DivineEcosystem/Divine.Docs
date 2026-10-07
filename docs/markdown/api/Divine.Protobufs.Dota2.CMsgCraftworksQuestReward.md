# <a id="Divine_Protobufs_Dota2_CMsgCraftworksQuestReward"></a> Class CMsgCraftworksQuestReward

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgCraftworksQuestReward : IMessage<CMsgCraftworksQuestReward>, IEquatable<CMsgCraftworksQuestReward>, IDeepCloneable<CMsgCraftworksQuestReward>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgCraftworksQuestReward](Divine.Protobufs.Dota2.CMsgCraftworksQuestReward.md)

#### Implements

IMessage<CMsgCraftworksQuestReward\>, 
[IEquatable<CMsgCraftworksQuestReward\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgCraftworksQuestReward\>, 
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
[EnumerableExtensions.In<CMsgCraftworksQuestReward\>\(CMsgCraftworksQuestReward, params CMsgCraftworksQuestReward\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgCraftworksQuestReward__ctor"></a> CMsgCraftworksQuestReward\(\)

```csharp
public CMsgCraftworksQuestReward()
```

### <a id="Divine_Protobufs_Dota2_CMsgCraftworksQuestReward__ctor_Divine_Protobufs_Dota2_CMsgCraftworksQuestReward_"></a> CMsgCraftworksQuestReward\(CMsgCraftworksQuestReward\)

```csharp
public CMsgCraftworksQuestReward(CMsgCraftworksQuestReward other)
```

#### Parameters

`other` [CMsgCraftworksQuestReward](Divine.Protobufs.Dota2.CMsgCraftworksQuestReward.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgCraftworksQuestReward_QuestIdFieldNumber"></a> QuestIdFieldNumber

```csharp
public const int QuestIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCraftworksQuestReward_RewardComponentsFieldNumber"></a> RewardComponentsFieldNumber

```csharp
public const int RewardComponentsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCraftworksQuestReward_StatValueFieldNumber"></a> StatValueFieldNumber

```csharp
public const int StatValueFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgCraftworksQuestReward_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgCraftworksQuestReward_HasQuestId"></a> HasQuestId

```csharp
public bool HasQuestId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCraftworksQuestReward_HasStatValue"></a> HasStatValue

```csharp
public bool HasStatValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCraftworksQuestReward_Parser"></a> Parser

```csharp
public static MessageParser<CMsgCraftworksQuestReward> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgCraftworksQuestReward](Divine.Protobufs.Dota2.CMsgCraftworksQuestReward.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgCraftworksQuestReward_QuestId"></a> QuestId

```csharp
public uint QuestId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgCraftworksQuestReward_RewardComponents"></a> RewardComponents

```csharp
public CMsgCraftworksComponents RewardComponents { get; set; }
```

#### Property Value

 [CMsgCraftworksComponents](Divine.Protobufs.Dota2.CMsgCraftworksComponents.md)

### <a id="Divine_Protobufs_Dota2_CMsgCraftworksQuestReward_StatValue"></a> StatValue

```csharp
public uint StatValue { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgCraftworksQuestReward_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCraftworksQuestReward_ClearQuestId"></a> ClearQuestId\(\)

```csharp
public void ClearQuestId()
```

### <a id="Divine_Protobufs_Dota2_CMsgCraftworksQuestReward_ClearStatValue"></a> ClearStatValue\(\)

```csharp
public void ClearStatValue()
```

### <a id="Divine_Protobufs_Dota2_CMsgCraftworksQuestReward_Clone"></a> Clone\(\)

```csharp
public CMsgCraftworksQuestReward Clone()
```

#### Returns

 [CMsgCraftworksQuestReward](Divine.Protobufs.Dota2.CMsgCraftworksQuestReward.md)

### <a id="Divine_Protobufs_Dota2_CMsgCraftworksQuestReward_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCraftworksQuestReward_Equals_Divine_Protobufs_Dota2_CMsgCraftworksQuestReward_"></a> Equals\(CMsgCraftworksQuestReward\)

```csharp
public bool Equals(CMsgCraftworksQuestReward other)
```

#### Parameters

`other` [CMsgCraftworksQuestReward](Divine.Protobufs.Dota2.CMsgCraftworksQuestReward.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCraftworksQuestReward_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCraftworksQuestReward_MergeFrom_Divine_Protobufs_Dota2_CMsgCraftworksQuestReward_"></a> MergeFrom\(CMsgCraftworksQuestReward\)

```csharp
public void MergeFrom(CMsgCraftworksQuestReward other)
```

#### Parameters

`other` [CMsgCraftworksQuestReward](Divine.Protobufs.Dota2.CMsgCraftworksQuestReward.md)

### <a id="Divine_Protobufs_Dota2_CMsgCraftworksQuestReward_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgCraftworksQuestReward_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgCraftworksQuestReward_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

