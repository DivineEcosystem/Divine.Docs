# <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevGrantMaterials"></a> Class CMsgClientToGCMonsterHunterDevGrantMaterials

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCMonsterHunterDevGrantMaterials : IMessage<CMsgClientToGCMonsterHunterDevGrantMaterials>, IEquatable<CMsgClientToGCMonsterHunterDevGrantMaterials>, IDeepCloneable<CMsgClientToGCMonsterHunterDevGrantMaterials>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCMonsterHunterDevGrantMaterials](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterDevGrantMaterials.md)

#### Implements

IMessage<CMsgClientToGCMonsterHunterDevGrantMaterials\>, 
[IEquatable<CMsgClientToGCMonsterHunterDevGrantMaterials\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCMonsterHunterDevGrantMaterials\>, 
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
[EnumerableExtensions.In<CMsgClientToGCMonsterHunterDevGrantMaterials\>\(CMsgClientToGCMonsterHunterDevGrantMaterials, params CMsgClientToGCMonsterHunterDevGrantMaterials\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevGrantMaterials__ctor"></a> CMsgClientToGCMonsterHunterDevGrantMaterials\(\)

```csharp
public CMsgClientToGCMonsterHunterDevGrantMaterials()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevGrantMaterials__ctor_Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevGrantMaterials_"></a> CMsgClientToGCMonsterHunterDevGrantMaterials\(CMsgClientToGCMonsterHunterDevGrantMaterials\)

```csharp
public CMsgClientToGCMonsterHunterDevGrantMaterials(CMsgClientToGCMonsterHunterDevGrantMaterials other)
```

#### Parameters

`other` [CMsgClientToGCMonsterHunterDevGrantMaterials](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterDevGrantMaterials.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevGrantMaterials_MaterialQuantityFieldNumber"></a> MaterialQuantityFieldNumber

```csharp
public const int MaterialQuantityFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevGrantMaterials_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevGrantMaterials_MaterialQuantity"></a> MaterialQuantity

```csharp
public CMsgMonsterHunterMaterialQuantity MaterialQuantity { get; set; }
```

#### Property Value

 [CMsgMonsterHunterMaterialQuantity](Divine.Protobufs.Dota2.CMsgMonsterHunterMaterialQuantity.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevGrantMaterials_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCMonsterHunterDevGrantMaterials> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCMonsterHunterDevGrantMaterials](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterDevGrantMaterials.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevGrantMaterials_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevGrantMaterials_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCMonsterHunterDevGrantMaterials Clone()
```

#### Returns

 [CMsgClientToGCMonsterHunterDevGrantMaterials](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterDevGrantMaterials.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevGrantMaterials_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevGrantMaterials_Equals_Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevGrantMaterials_"></a> Equals\(CMsgClientToGCMonsterHunterDevGrantMaterials\)

```csharp
public bool Equals(CMsgClientToGCMonsterHunterDevGrantMaterials other)
```

#### Parameters

`other` [CMsgClientToGCMonsterHunterDevGrantMaterials](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterDevGrantMaterials.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevGrantMaterials_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevGrantMaterials_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevGrantMaterials_"></a> MergeFrom\(CMsgClientToGCMonsterHunterDevGrantMaterials\)

```csharp
public void MergeFrom(CMsgClientToGCMonsterHunterDevGrantMaterials other)
```

#### Parameters

`other` [CMsgClientToGCMonsterHunterDevGrantMaterials](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterDevGrantMaterials.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevGrantMaterials_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevGrantMaterials_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevGrantMaterials_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

