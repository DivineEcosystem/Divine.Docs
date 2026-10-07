# <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterGiftMaterials"></a> Class CMsgClientToGCMonsterHunterGiftMaterials

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCMonsterHunterGiftMaterials : IMessage<CMsgClientToGCMonsterHunterGiftMaterials>, IEquatable<CMsgClientToGCMonsterHunterGiftMaterials>, IDeepCloneable<CMsgClientToGCMonsterHunterGiftMaterials>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCMonsterHunterGiftMaterials](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterGiftMaterials.md)

#### Implements

IMessage<CMsgClientToGCMonsterHunterGiftMaterials\>, 
[IEquatable<CMsgClientToGCMonsterHunterGiftMaterials\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCMonsterHunterGiftMaterials\>, 
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
[EnumerableExtensions.In<CMsgClientToGCMonsterHunterGiftMaterials\>\(CMsgClientToGCMonsterHunterGiftMaterials, params CMsgClientToGCMonsterHunterGiftMaterials\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterGiftMaterials__ctor"></a> CMsgClientToGCMonsterHunterGiftMaterials\(\)

```csharp
public CMsgClientToGCMonsterHunterGiftMaterials()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterGiftMaterials__ctor_Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterGiftMaterials_"></a> CMsgClientToGCMonsterHunterGiftMaterials\(CMsgClientToGCMonsterHunterGiftMaterials\)

```csharp
public CMsgClientToGCMonsterHunterGiftMaterials(CMsgClientToGCMonsterHunterGiftMaterials other)
```

#### Parameters

`other` [CMsgClientToGCMonsterHunterGiftMaterials](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterGiftMaterials.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterGiftMaterials_PeriodicResourceIdFieldNumber"></a> PeriodicResourceIdFieldNumber

```csharp
public const int PeriodicResourceIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterGiftMaterials_RecipientAccountIdFieldNumber"></a> RecipientAccountIdFieldNumber

```csharp
public const int RecipientAccountIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterGiftMaterials_TokenGiftFieldNumber"></a> TokenGiftFieldNumber

```csharp
public const int TokenGiftFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterGiftMaterials_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterGiftMaterials_HasPeriodicResourceId"></a> HasPeriodicResourceId

```csharp
public bool HasPeriodicResourceId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterGiftMaterials_HasRecipientAccountId"></a> HasRecipientAccountId

```csharp
public bool HasRecipientAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterGiftMaterials_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCMonsterHunterGiftMaterials> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCMonsterHunterGiftMaterials](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterGiftMaterials.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterGiftMaterials_PeriodicResourceId"></a> PeriodicResourceId

```csharp
public uint PeriodicResourceId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterGiftMaterials_RecipientAccountId"></a> RecipientAccountId

```csharp
public uint RecipientAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterGiftMaterials_TokenGift"></a> TokenGift

```csharp
public CMsgMonsterHunterMaterialCount TokenGift { get; set; }
```

#### Property Value

 [CMsgMonsterHunterMaterialCount](Divine.Protobufs.Dota2.CMsgMonsterHunterMaterialCount.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterGiftMaterials_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterGiftMaterials_ClearPeriodicResourceId"></a> ClearPeriodicResourceId\(\)

```csharp
public void ClearPeriodicResourceId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterGiftMaterials_ClearRecipientAccountId"></a> ClearRecipientAccountId\(\)

```csharp
public void ClearRecipientAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterGiftMaterials_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCMonsterHunterGiftMaterials Clone()
```

#### Returns

 [CMsgClientToGCMonsterHunterGiftMaterials](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterGiftMaterials.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterGiftMaterials_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterGiftMaterials_Equals_Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterGiftMaterials_"></a> Equals\(CMsgClientToGCMonsterHunterGiftMaterials\)

```csharp
public bool Equals(CMsgClientToGCMonsterHunterGiftMaterials other)
```

#### Parameters

`other` [CMsgClientToGCMonsterHunterGiftMaterials](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterGiftMaterials.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterGiftMaterials_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterGiftMaterials_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterGiftMaterials_"></a> MergeFrom\(CMsgClientToGCMonsterHunterGiftMaterials\)

```csharp
public void MergeFrom(CMsgClientToGCMonsterHunterGiftMaterials other)
```

#### Parameters

`other` [CMsgClientToGCMonsterHunterGiftMaterials](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterGiftMaterials.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterGiftMaterials_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterGiftMaterials_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterGiftMaterials_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

