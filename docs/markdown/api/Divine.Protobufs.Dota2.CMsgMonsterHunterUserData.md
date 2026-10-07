# <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterUserData"></a> Class CMsgMonsterHunterUserData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgMonsterHunterUserData : IMessage<CMsgMonsterHunterUserData>, IEquatable<CMsgMonsterHunterUserData>, IDeepCloneable<CMsgMonsterHunterUserData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgMonsterHunterUserData](Divine.Protobufs.Dota2.CMsgMonsterHunterUserData.md)

#### Implements

IMessage<CMsgMonsterHunterUserData\>, 
[IEquatable<CMsgMonsterHunterUserData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgMonsterHunterUserData\>, 
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
[EnumerableExtensions.In<CMsgMonsterHunterUserData\>\(CMsgMonsterHunterUserData, params CMsgMonsterHunterUserData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterUserData__ctor"></a> CMsgMonsterHunterUserData\(\)

```csharp
public CMsgMonsterHunterUserData()
```

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterUserData__ctor_Divine_Protobufs_Dota2_CMsgMonsterHunterUserData_"></a> CMsgMonsterHunterUserData\(CMsgMonsterHunterUserData\)

```csharp
public CMsgMonsterHunterUserData(CMsgMonsterHunterUserData other)
```

#### Parameters

`other` [CMsgMonsterHunterUserData](Divine.Protobufs.Dota2.CMsgMonsterHunterUserData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterUserData_HeroCodexFieldNumber"></a> HeroCodexFieldNumber

```csharp
public const int HeroCodexFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterUserData_MaterialInventoryFieldNumber"></a> MaterialInventoryFieldNumber

```csharp
public const int MaterialInventoryFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterUserData_UnlockedCountFieldNumber"></a> UnlockedCountFieldNumber

```csharp
public const int UnlockedCountFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterUserData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterUserData_HasUnlockedCount"></a> HasUnlockedCount

```csharp
public bool HasUnlockedCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterUserData_HeroCodex"></a> HeroCodex

```csharp
public MapField<int, CMsgMonsterHunterHeroCodexEntry> HeroCodex { get; }
```

#### Property Value

 MapField<[int](https://learn.microsoft.com/dotnet/api/system.int32), [CMsgMonsterHunterHeroCodexEntry](Divine.Protobufs.Dota2.CMsgMonsterHunterHeroCodexEntry.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterUserData_MaterialInventory"></a> MaterialInventory

```csharp
public CMsgMonsterHunterMaterialQuantity MaterialInventory { get; set; }
```

#### Property Value

 [CMsgMonsterHunterMaterialQuantity](Divine.Protobufs.Dota2.CMsgMonsterHunterMaterialQuantity.md)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterUserData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgMonsterHunterUserData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgMonsterHunterUserData](Divine.Protobufs.Dota2.CMsgMonsterHunterUserData.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterUserData_UnlockedCount"></a> UnlockedCount

```csharp
public int UnlockedCount { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterUserData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterUserData_ClearUnlockedCount"></a> ClearUnlockedCount\(\)

```csharp
public void ClearUnlockedCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterUserData_Clone"></a> Clone\(\)

```csharp
public CMsgMonsterHunterUserData Clone()
```

#### Returns

 [CMsgMonsterHunterUserData](Divine.Protobufs.Dota2.CMsgMonsterHunterUserData.md)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterUserData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterUserData_Equals_Divine_Protobufs_Dota2_CMsgMonsterHunterUserData_"></a> Equals\(CMsgMonsterHunterUserData\)

```csharp
public bool Equals(CMsgMonsterHunterUserData other)
```

#### Parameters

`other` [CMsgMonsterHunterUserData](Divine.Protobufs.Dota2.CMsgMonsterHunterUserData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterUserData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterUserData_MergeFrom_Divine_Protobufs_Dota2_CMsgMonsterHunterUserData_"></a> MergeFrom\(CMsgMonsterHunterUserData\)

```csharp
public void MergeFrom(CMsgMonsterHunterUserData other)
```

#### Parameters

`other` [CMsgMonsterHunterUserData](Divine.Protobufs.Dota2.CMsgMonsterHunterUserData.md)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterUserData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterUserData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterUserData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

