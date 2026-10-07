# <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClearInventory"></a> Class CMsgClientToGCMonsterHunterDevClearInventory

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCMonsterHunterDevClearInventory : IMessage<CMsgClientToGCMonsterHunterDevClearInventory>, IEquatable<CMsgClientToGCMonsterHunterDevClearInventory>, IDeepCloneable<CMsgClientToGCMonsterHunterDevClearInventory>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCMonsterHunterDevClearInventory](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterDevClearInventory.md)

#### Implements

IMessage<CMsgClientToGCMonsterHunterDevClearInventory\>, 
[IEquatable<CMsgClientToGCMonsterHunterDevClearInventory\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCMonsterHunterDevClearInventory\>, 
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
[EnumerableExtensions.In<CMsgClientToGCMonsterHunterDevClearInventory\>\(CMsgClientToGCMonsterHunterDevClearInventory, params CMsgClientToGCMonsterHunterDevClearInventory\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClearInventory__ctor"></a> CMsgClientToGCMonsterHunterDevClearInventory\(\)

```csharp
public CMsgClientToGCMonsterHunterDevClearInventory()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClearInventory__ctor_Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClearInventory_"></a> CMsgClientToGCMonsterHunterDevClearInventory\(CMsgClientToGCMonsterHunterDevClearInventory\)

```csharp
public CMsgClientToGCMonsterHunterDevClearInventory(CMsgClientToGCMonsterHunterDevClearInventory other)
```

#### Parameters

`other` [CMsgClientToGCMonsterHunterDevClearInventory](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterDevClearInventory.md)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClearInventory_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClearInventory_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCMonsterHunterDevClearInventory> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCMonsterHunterDevClearInventory](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterDevClearInventory.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClearInventory_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClearInventory_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCMonsterHunterDevClearInventory Clone()
```

#### Returns

 [CMsgClientToGCMonsterHunterDevClearInventory](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterDevClearInventory.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClearInventory_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClearInventory_Equals_Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClearInventory_"></a> Equals\(CMsgClientToGCMonsterHunterDevClearInventory\)

```csharp
public bool Equals(CMsgClientToGCMonsterHunterDevClearInventory other)
```

#### Parameters

`other` [CMsgClientToGCMonsterHunterDevClearInventory](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterDevClearInventory.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClearInventory_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClearInventory_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClearInventory_"></a> MergeFrom\(CMsgClientToGCMonsterHunterDevClearInventory\)

```csharp
public void MergeFrom(CMsgClientToGCMonsterHunterDevClearInventory other)
```

#### Parameters

`other` [CMsgClientToGCMonsterHunterDevClearInventory](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterDevClearInventory.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClearInventory_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClearInventory_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevClearInventory_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

