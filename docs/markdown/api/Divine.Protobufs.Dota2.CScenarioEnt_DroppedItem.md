# <a id="Divine_Protobufs_Dota2_CScenarioEnt_DroppedItem"></a> Class CScenarioEnt\_DroppedItem

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CScenarioEnt_DroppedItem : IMessage<CScenarioEnt_DroppedItem>, IEquatable<CScenarioEnt_DroppedItem>, IDeepCloneable<CScenarioEnt_DroppedItem>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CScenarioEnt\_DroppedItem](Divine.Protobufs.Dota2.CScenarioEnt\_DroppedItem.md)

#### Implements

IMessage<CScenarioEnt\_DroppedItem\>, 
[IEquatable<CScenarioEnt\_DroppedItem\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CScenarioEnt\_DroppedItem\>, 
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
[EnumerableExtensions.In<CScenarioEnt\_DroppedItem\>\(CScenarioEnt\_DroppedItem, params CScenarioEnt\_DroppedItem\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_DroppedItem__ctor"></a> CScenarioEnt\_DroppedItem\(\)

```csharp
public CScenarioEnt_DroppedItem()
```

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_DroppedItem__ctor_Divine_Protobufs_Dota2_CScenarioEnt_DroppedItem_"></a> CScenarioEnt\_DroppedItem\(CScenarioEnt\_DroppedItem\)

```csharp
public CScenarioEnt_DroppedItem(CScenarioEnt_DroppedItem other)
```

#### Parameters

`other` [CScenarioEnt\_DroppedItem](Divine.Protobufs.Dota2.CScenarioEnt\_DroppedItem.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_DroppedItem_PositionFieldNumber"></a> PositionFieldNumber

```csharp
public const int PositionFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_DroppedItem_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_DroppedItem_Parser"></a> Parser

```csharp
public static MessageParser<CScenarioEnt_DroppedItem> Parser { get; }
```

#### Property Value

 MessageParser<[CScenarioEnt\_DroppedItem](Divine.Protobufs.Dota2.CScenarioEnt\_DroppedItem.md)\>

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_DroppedItem_Position"></a> Position

```csharp
public CScenario_Position Position { get; set; }
```

#### Property Value

 [CScenario\_Position](Divine.Protobufs.Dota2.CScenario\_Position.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_DroppedItem_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_DroppedItem_Clone"></a> Clone\(\)

```csharp
public CScenarioEnt_DroppedItem Clone()
```

#### Returns

 [CScenarioEnt\_DroppedItem](Divine.Protobufs.Dota2.CScenarioEnt\_DroppedItem.md)

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_DroppedItem_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_DroppedItem_Equals_Divine_Protobufs_Dota2_CScenarioEnt_DroppedItem_"></a> Equals\(CScenarioEnt\_DroppedItem\)

```csharp
public bool Equals(CScenarioEnt_DroppedItem other)
```

#### Parameters

`other` [CScenarioEnt\_DroppedItem](Divine.Protobufs.Dota2.CScenarioEnt\_DroppedItem.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_DroppedItem_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_DroppedItem_MergeFrom_Divine_Protobufs_Dota2_CScenarioEnt_DroppedItem_"></a> MergeFrom\(CScenarioEnt\_DroppedItem\)

```csharp
public void MergeFrom(CScenarioEnt_DroppedItem other)
```

#### Parameters

`other` [CScenarioEnt\_DroppedItem](Divine.Protobufs.Dota2.CScenarioEnt\_DroppedItem.md)

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_DroppedItem_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_DroppedItem_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CScenarioEnt_DroppedItem_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

