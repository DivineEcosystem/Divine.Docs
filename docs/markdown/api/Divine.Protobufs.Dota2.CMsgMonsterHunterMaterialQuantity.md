# <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMaterialQuantity"></a> Class CMsgMonsterHunterMaterialQuantity

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgMonsterHunterMaterialQuantity : IMessage<CMsgMonsterHunterMaterialQuantity>, IEquatable<CMsgMonsterHunterMaterialQuantity>, IDeepCloneable<CMsgMonsterHunterMaterialQuantity>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgMonsterHunterMaterialQuantity](Divine.Protobufs.Dota2.CMsgMonsterHunterMaterialQuantity.md)

#### Implements

IMessage<CMsgMonsterHunterMaterialQuantity\>, 
[IEquatable<CMsgMonsterHunterMaterialQuantity\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgMonsterHunterMaterialQuantity\>, 
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
[EnumerableExtensions.In<CMsgMonsterHunterMaterialQuantity\>\(CMsgMonsterHunterMaterialQuantity, params CMsgMonsterHunterMaterialQuantity\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMaterialQuantity__ctor"></a> CMsgMonsterHunterMaterialQuantity\(\)

```csharp
public CMsgMonsterHunterMaterialQuantity()
```

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMaterialQuantity__ctor_Divine_Protobufs_Dota2_CMsgMonsterHunterMaterialQuantity_"></a> CMsgMonsterHunterMaterialQuantity\(CMsgMonsterHunterMaterialQuantity\)

```csharp
public CMsgMonsterHunterMaterialQuantity(CMsgMonsterHunterMaterialQuantity other)
```

#### Parameters

`other` [CMsgMonsterHunterMaterialQuantity](Divine.Protobufs.Dota2.CMsgMonsterHunterMaterialQuantity.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMaterialQuantity_MaterialCountsFieldNumber"></a> MaterialCountsFieldNumber

```csharp
public const int MaterialCountsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMaterialQuantity_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMaterialQuantity_MaterialCounts"></a> MaterialCounts

```csharp
public MapField<uint, int> MaterialCounts { get; }
```

#### Property Value

 MapField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32), [int](https://learn.microsoft.com/dotnet/api/system.int32)\>

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMaterialQuantity_Parser"></a> Parser

```csharp
public static MessageParser<CMsgMonsterHunterMaterialQuantity> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgMonsterHunterMaterialQuantity](Divine.Protobufs.Dota2.CMsgMonsterHunterMaterialQuantity.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMaterialQuantity_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMaterialQuantity_Clone"></a> Clone\(\)

```csharp
public CMsgMonsterHunterMaterialQuantity Clone()
```

#### Returns

 [CMsgMonsterHunterMaterialQuantity](Divine.Protobufs.Dota2.CMsgMonsterHunterMaterialQuantity.md)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMaterialQuantity_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMaterialQuantity_Equals_Divine_Protobufs_Dota2_CMsgMonsterHunterMaterialQuantity_"></a> Equals\(CMsgMonsterHunterMaterialQuantity\)

```csharp
public bool Equals(CMsgMonsterHunterMaterialQuantity other)
```

#### Parameters

`other` [CMsgMonsterHunterMaterialQuantity](Divine.Protobufs.Dota2.CMsgMonsterHunterMaterialQuantity.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMaterialQuantity_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMaterialQuantity_MergeFrom_Divine_Protobufs_Dota2_CMsgMonsterHunterMaterialQuantity_"></a> MergeFrom\(CMsgMonsterHunterMaterialQuantity\)

```csharp
public void MergeFrom(CMsgMonsterHunterMaterialQuantity other)
```

#### Parameters

`other` [CMsgMonsterHunterMaterialQuantity](Divine.Protobufs.Dota2.CMsgMonsterHunterMaterialQuantity.md)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMaterialQuantity_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMaterialQuantity_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterMaterialQuantity_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

