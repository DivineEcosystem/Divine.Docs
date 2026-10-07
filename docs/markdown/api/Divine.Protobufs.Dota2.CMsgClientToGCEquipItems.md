# <a id="Divine_Protobufs_Dota2_CMsgClientToGCEquipItems"></a> Class CMsgClientToGCEquipItems

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCEquipItems : IMessage<CMsgClientToGCEquipItems>, IEquatable<CMsgClientToGCEquipItems>, IDeepCloneable<CMsgClientToGCEquipItems>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCEquipItems](Divine.Protobufs.Dota2.CMsgClientToGCEquipItems.md)

#### Implements

IMessage<CMsgClientToGCEquipItems\>, 
[IEquatable<CMsgClientToGCEquipItems\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCEquipItems\>, 
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
[EnumerableExtensions.In<CMsgClientToGCEquipItems\>\(CMsgClientToGCEquipItems, params CMsgClientToGCEquipItems\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCEquipItems__ctor"></a> CMsgClientToGCEquipItems\(\)

```csharp
public CMsgClientToGCEquipItems()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCEquipItems__ctor_Divine_Protobufs_Dota2_CMsgClientToGCEquipItems_"></a> CMsgClientToGCEquipItems\(CMsgClientToGCEquipItems\)

```csharp
public CMsgClientToGCEquipItems(CMsgClientToGCEquipItems other)
```

#### Parameters

`other` [CMsgClientToGCEquipItems](Divine.Protobufs.Dota2.CMsgClientToGCEquipItems.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCEquipItems_EquipsFieldNumber"></a> EquipsFieldNumber

```csharp
public const int EquipsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCEquipItems_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCEquipItems_Equips"></a> Equips

```csharp
public RepeatedField<CMsgAdjustItemEquippedState> Equips { get; }
```

#### Property Value

 RepeatedField<[CMsgAdjustItemEquippedState](Divine.Protobufs.Dota2.CMsgAdjustItemEquippedState.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCEquipItems_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCEquipItems> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCEquipItems](Divine.Protobufs.Dota2.CMsgClientToGCEquipItems.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCEquipItems_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCEquipItems_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCEquipItems Clone()
```

#### Returns

 [CMsgClientToGCEquipItems](Divine.Protobufs.Dota2.CMsgClientToGCEquipItems.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCEquipItems_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCEquipItems_Equals_Divine_Protobufs_Dota2_CMsgClientToGCEquipItems_"></a> Equals\(CMsgClientToGCEquipItems\)

```csharp
public bool Equals(CMsgClientToGCEquipItems other)
```

#### Parameters

`other` [CMsgClientToGCEquipItems](Divine.Protobufs.Dota2.CMsgClientToGCEquipItems.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCEquipItems_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCEquipItems_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCEquipItems_"></a> MergeFrom\(CMsgClientToGCEquipItems\)

```csharp
public void MergeFrom(CMsgClientToGCEquipItems other)
```

#### Parameters

`other` [CMsgClientToGCEquipItems](Divine.Protobufs.Dota2.CMsgClientToGCEquipItems.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCEquipItems_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCEquipItems_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCEquipItems_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

