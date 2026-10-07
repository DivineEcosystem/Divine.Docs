# <a id="Divine_Protobufs_Dota2_CMsgAdjustItemEquippedState"></a> Class CMsgAdjustItemEquippedState

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgAdjustItemEquippedState : IMessage<CMsgAdjustItemEquippedState>, IEquatable<CMsgAdjustItemEquippedState>, IDeepCloneable<CMsgAdjustItemEquippedState>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgAdjustItemEquippedState](Divine.Protobufs.Dota2.CMsgAdjustItemEquippedState.md)

#### Implements

IMessage<CMsgAdjustItemEquippedState\>, 
[IEquatable<CMsgAdjustItemEquippedState\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgAdjustItemEquippedState\>, 
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
[EnumerableExtensions.In<CMsgAdjustItemEquippedState\>\(CMsgAdjustItemEquippedState, params CMsgAdjustItemEquippedState\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgAdjustItemEquippedState__ctor"></a> CMsgAdjustItemEquippedState\(\)

```csharp
public CMsgAdjustItemEquippedState()
```

### <a id="Divine_Protobufs_Dota2_CMsgAdjustItemEquippedState__ctor_Divine_Protobufs_Dota2_CMsgAdjustItemEquippedState_"></a> CMsgAdjustItemEquippedState\(CMsgAdjustItemEquippedState\)

```csharp
public CMsgAdjustItemEquippedState(CMsgAdjustItemEquippedState other)
```

#### Parameters

`other` [CMsgAdjustItemEquippedState](Divine.Protobufs.Dota2.CMsgAdjustItemEquippedState.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgAdjustItemEquippedState_ItemIdFieldNumber"></a> ItemIdFieldNumber

```csharp
public const int ItemIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgAdjustItemEquippedState_NewClassFieldNumber"></a> NewClassFieldNumber

```csharp
public const int NewClassFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgAdjustItemEquippedState_NewSlotFieldNumber"></a> NewSlotFieldNumber

```csharp
public const int NewSlotFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgAdjustItemEquippedState_StyleIndexFieldNumber"></a> StyleIndexFieldNumber

```csharp
public const int StyleIndexFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgAdjustItemEquippedState_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgAdjustItemEquippedState_HasItemId"></a> HasItemId

```csharp
public bool HasItemId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgAdjustItemEquippedState_HasNewClass"></a> HasNewClass

```csharp
public bool HasNewClass { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgAdjustItemEquippedState_HasNewSlot"></a> HasNewSlot

```csharp
public bool HasNewSlot { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgAdjustItemEquippedState_HasStyleIndex"></a> HasStyleIndex

```csharp
public bool HasStyleIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgAdjustItemEquippedState_ItemId"></a> ItemId

```csharp
public ulong ItemId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgAdjustItemEquippedState_NewClass"></a> NewClass

```csharp
public uint NewClass { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgAdjustItemEquippedState_NewSlot"></a> NewSlot

```csharp
public uint NewSlot { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgAdjustItemEquippedState_Parser"></a> Parser

```csharp
public static MessageParser<CMsgAdjustItemEquippedState> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgAdjustItemEquippedState](Divine.Protobufs.Dota2.CMsgAdjustItemEquippedState.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgAdjustItemEquippedState_StyleIndex"></a> StyleIndex

```csharp
public uint StyleIndex { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgAdjustItemEquippedState_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgAdjustItemEquippedState_ClearItemId"></a> ClearItemId\(\)

```csharp
public void ClearItemId()
```

### <a id="Divine_Protobufs_Dota2_CMsgAdjustItemEquippedState_ClearNewClass"></a> ClearNewClass\(\)

```csharp
public void ClearNewClass()
```

### <a id="Divine_Protobufs_Dota2_CMsgAdjustItemEquippedState_ClearNewSlot"></a> ClearNewSlot\(\)

```csharp
public void ClearNewSlot()
```

### <a id="Divine_Protobufs_Dota2_CMsgAdjustItemEquippedState_ClearStyleIndex"></a> ClearStyleIndex\(\)

```csharp
public void ClearStyleIndex()
```

### <a id="Divine_Protobufs_Dota2_CMsgAdjustItemEquippedState_Clone"></a> Clone\(\)

```csharp
public CMsgAdjustItemEquippedState Clone()
```

#### Returns

 [CMsgAdjustItemEquippedState](Divine.Protobufs.Dota2.CMsgAdjustItemEquippedState.md)

### <a id="Divine_Protobufs_Dota2_CMsgAdjustItemEquippedState_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgAdjustItemEquippedState_Equals_Divine_Protobufs_Dota2_CMsgAdjustItemEquippedState_"></a> Equals\(CMsgAdjustItemEquippedState\)

```csharp
public bool Equals(CMsgAdjustItemEquippedState other)
```

#### Parameters

`other` [CMsgAdjustItemEquippedState](Divine.Protobufs.Dota2.CMsgAdjustItemEquippedState.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgAdjustItemEquippedState_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgAdjustItemEquippedState_MergeFrom_Divine_Protobufs_Dota2_CMsgAdjustItemEquippedState_"></a> MergeFrom\(CMsgAdjustItemEquippedState\)

```csharp
public void MergeFrom(CMsgAdjustItemEquippedState other)
```

#### Parameters

`other` [CMsgAdjustItemEquippedState](Divine.Protobufs.Dota2.CMsgAdjustItemEquippedState.md)

### <a id="Divine_Protobufs_Dota2_CMsgAdjustItemEquippedState_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgAdjustItemEquippedState_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgAdjustItemEquippedState_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

