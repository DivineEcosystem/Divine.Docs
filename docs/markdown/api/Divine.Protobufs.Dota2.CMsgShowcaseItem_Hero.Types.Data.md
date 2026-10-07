# <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Hero_Types_Data"></a> Class CMsgShowcaseItem\_Hero.Types.Data

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgShowcaseItem_Hero.Types.Data : IMessage<CMsgShowcaseItem_Hero.Types.Data>, IEquatable<CMsgShowcaseItem_Hero.Types.Data>, IDeepCloneable<CMsgShowcaseItem_Hero.Types.Data>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgShowcaseItem\_Hero.Types.Data](Divine.Protobufs.Dota2.CMsgShowcaseItem\_Hero.Types.Data.md)

#### Implements

IMessage<CMsgShowcaseItem\_Hero.Types.Data\>, 
[IEquatable<CMsgShowcaseItem\_Hero.Types.Data\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgShowcaseItem\_Hero.Types.Data\>, 
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
[EnumerableExtensions.In<CMsgShowcaseItem\_Hero.Types.Data\>\(CMsgShowcaseItem\_Hero.Types.Data, params CMsgShowcaseItem\_Hero.Types.Data\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Hero_Types_Data__ctor"></a> Data\(\)

```csharp
public Data()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Hero_Types_Data__ctor_Divine_Protobufs_Dota2_CMsgShowcaseItem_Hero_Types_Data_"></a> Data\(Data\)

```csharp
public Data(CMsgShowcaseItem_Hero.Types.Data other)
```

#### Parameters

`other` [CMsgShowcaseItem\_Hero](Divine.Protobufs.Dota2.CMsgShowcaseItem\_Hero.md).[Types](Divine.Protobufs.Dota2.CMsgShowcaseItem\_Hero.Types.md).[Data](Divine.Protobufs.Dota2.CMsgShowcaseItem\_Hero.Types.Data.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Hero_Types_Data_ActualHeroIdFieldNumber"></a> ActualHeroIdFieldNumber

```csharp
public const int ActualHeroIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Hero_Types_Data_EconItemsFieldNumber"></a> EconItemsFieldNumber

```csharp
public const int EconItemsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Hero_Types_Data_PlusHeroXpFieldNumber"></a> PlusHeroXpFieldNumber

```csharp
public const int PlusHeroXpFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Hero_Types_Data_ActualHeroId"></a> ActualHeroId

```csharp
public int ActualHeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Hero_Types_Data_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Hero_Types_Data_EconItems"></a> EconItems

```csharp
public RepeatedField<CSOEconItem> EconItems { get; }
```

#### Property Value

 RepeatedField<[CSOEconItem](Divine.Protobufs.Dota2.CSOEconItem.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Hero_Types_Data_HasActualHeroId"></a> HasActualHeroId

```csharp
public bool HasActualHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Hero_Types_Data_HasPlusHeroXp"></a> HasPlusHeroXp

```csharp
public bool HasPlusHeroXp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Hero_Types_Data_Parser"></a> Parser

```csharp
public static MessageParser<CMsgShowcaseItem_Hero.Types.Data> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgShowcaseItem\_Hero](Divine.Protobufs.Dota2.CMsgShowcaseItem\_Hero.md).[Types](Divine.Protobufs.Dota2.CMsgShowcaseItem\_Hero.Types.md).[Data](Divine.Protobufs.Dota2.CMsgShowcaseItem\_Hero.Types.Data.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Hero_Types_Data_PlusHeroXp"></a> PlusHeroXp

```csharp
public uint PlusHeroXp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Hero_Types_Data_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Hero_Types_Data_ClearActualHeroId"></a> ClearActualHeroId\(\)

```csharp
public void ClearActualHeroId()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Hero_Types_Data_ClearPlusHeroXp"></a> ClearPlusHeroXp\(\)

```csharp
public void ClearPlusHeroXp()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Hero_Types_Data_Clone"></a> Clone\(\)

```csharp
public CMsgShowcaseItem_Hero.Types.Data Clone()
```

#### Returns

 [CMsgShowcaseItem\_Hero](Divine.Protobufs.Dota2.CMsgShowcaseItem\_Hero.md).[Types](Divine.Protobufs.Dota2.CMsgShowcaseItem\_Hero.Types.md).[Data](Divine.Protobufs.Dota2.CMsgShowcaseItem\_Hero.Types.Data.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Hero_Types_Data_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Hero_Types_Data_Equals_Divine_Protobufs_Dota2_CMsgShowcaseItem_Hero_Types_Data_"></a> Equals\(Data\)

```csharp
public bool Equals(CMsgShowcaseItem_Hero.Types.Data other)
```

#### Parameters

`other` [CMsgShowcaseItem\_Hero](Divine.Protobufs.Dota2.CMsgShowcaseItem\_Hero.md).[Types](Divine.Protobufs.Dota2.CMsgShowcaseItem\_Hero.Types.md).[Data](Divine.Protobufs.Dota2.CMsgShowcaseItem\_Hero.Types.Data.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Hero_Types_Data_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Hero_Types_Data_MergeFrom_Divine_Protobufs_Dota2_CMsgShowcaseItem_Hero_Types_Data_"></a> MergeFrom\(Data\)

```csharp
public void MergeFrom(CMsgShowcaseItem_Hero.Types.Data other)
```

#### Parameters

`other` [CMsgShowcaseItem\_Hero](Divine.Protobufs.Dota2.CMsgShowcaseItem\_Hero.md).[Types](Divine.Protobufs.Dota2.CMsgShowcaseItem\_Hero.Types.md).[Data](Divine.Protobufs.Dota2.CMsgShowcaseItem\_Hero.Types.Data.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Hero_Types_Data_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Hero_Types_Data_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Hero_Types_Data_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

