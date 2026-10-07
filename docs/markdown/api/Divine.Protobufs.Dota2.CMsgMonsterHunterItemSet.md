# <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterItemSet"></a> Class CMsgMonsterHunterItemSet

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgMonsterHunterItemSet : IMessage<CMsgMonsterHunterItemSet>, IEquatable<CMsgMonsterHunterItemSet>, IDeepCloneable<CMsgMonsterHunterItemSet>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgMonsterHunterItemSet](Divine.Protobufs.Dota2.CMsgMonsterHunterItemSet.md)

#### Implements

IMessage<CMsgMonsterHunterItemSet\>, 
[IEquatable<CMsgMonsterHunterItemSet\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgMonsterHunterItemSet\>, 
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
[EnumerableExtensions.In<CMsgMonsterHunterItemSet\>\(CMsgMonsterHunterItemSet, params CMsgMonsterHunterItemSet\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterItemSet__ctor"></a> CMsgMonsterHunterItemSet\(\)

```csharp
public CMsgMonsterHunterItemSet()
```

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterItemSet__ctor_Divine_Protobufs_Dota2_CMsgMonsterHunterItemSet_"></a> CMsgMonsterHunterItemSet\(CMsgMonsterHunterItemSet\)

```csharp
public CMsgMonsterHunterItemSet(CMsgMonsterHunterItemSet other)
```

#### Parameters

`other` [CMsgMonsterHunterItemSet](Divine.Protobufs.Dota2.CMsgMonsterHunterItemSet.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterItemSet_EconItemIdFieldNumber"></a> EconItemIdFieldNumber

```csharp
public const int EconItemIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterItemSet_SetIndexFieldNumber"></a> SetIndexFieldNumber

```csharp
public const int SetIndexFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterItemSet_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterItemSet_EconItemId"></a> EconItemId

```csharp
public uint EconItemId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterItemSet_HasEconItemId"></a> HasEconItemId

```csharp
public bool HasEconItemId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterItemSet_HasSetIndex"></a> HasSetIndex

```csharp
public bool HasSetIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterItemSet_Parser"></a> Parser

```csharp
public static MessageParser<CMsgMonsterHunterItemSet> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgMonsterHunterItemSet](Divine.Protobufs.Dota2.CMsgMonsterHunterItemSet.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterItemSet_SetIndex"></a> SetIndex

```csharp
public uint SetIndex { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterItemSet_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterItemSet_ClearEconItemId"></a> ClearEconItemId\(\)

```csharp
public void ClearEconItemId()
```

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterItemSet_ClearSetIndex"></a> ClearSetIndex\(\)

```csharp
public void ClearSetIndex()
```

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterItemSet_Clone"></a> Clone\(\)

```csharp
public CMsgMonsterHunterItemSet Clone()
```

#### Returns

 [CMsgMonsterHunterItemSet](Divine.Protobufs.Dota2.CMsgMonsterHunterItemSet.md)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterItemSet_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterItemSet_Equals_Divine_Protobufs_Dota2_CMsgMonsterHunterItemSet_"></a> Equals\(CMsgMonsterHunterItemSet\)

```csharp
public bool Equals(CMsgMonsterHunterItemSet other)
```

#### Parameters

`other` [CMsgMonsterHunterItemSet](Divine.Protobufs.Dota2.CMsgMonsterHunterItemSet.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterItemSet_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterItemSet_MergeFrom_Divine_Protobufs_Dota2_CMsgMonsterHunterItemSet_"></a> MergeFrom\(CMsgMonsterHunterItemSet\)

```csharp
public void MergeFrom(CMsgMonsterHunterItemSet other)
```

#### Parameters

`other` [CMsgMonsterHunterItemSet](Divine.Protobufs.Dota2.CMsgMonsterHunterItemSet.md)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterItemSet_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterItemSet_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterItemSet_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

