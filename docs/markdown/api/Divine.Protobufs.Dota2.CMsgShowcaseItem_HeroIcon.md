# <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_HeroIcon"></a> Class CMsgShowcaseItem\_HeroIcon

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgShowcaseItem_HeroIcon : IMessage<CMsgShowcaseItem_HeroIcon>, IEquatable<CMsgShowcaseItem_HeroIcon>, IDeepCloneable<CMsgShowcaseItem_HeroIcon>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgShowcaseItem\_HeroIcon](Divine.Protobufs.Dota2.CMsgShowcaseItem\_HeroIcon.md)

#### Implements

IMessage<CMsgShowcaseItem\_HeroIcon\>, 
[IEquatable<CMsgShowcaseItem\_HeroIcon\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgShowcaseItem\_HeroIcon\>, 
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
[EnumerableExtensions.In<CMsgShowcaseItem\_HeroIcon\>\(CMsgShowcaseItem\_HeroIcon, params CMsgShowcaseItem\_HeroIcon\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_HeroIcon__ctor"></a> CMsgShowcaseItem\_HeroIcon\(\)

```csharp
public CMsgShowcaseItem_HeroIcon()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_HeroIcon__ctor_Divine_Protobufs_Dota2_CMsgShowcaseItem_HeroIcon_"></a> CMsgShowcaseItem\_HeroIcon\(CMsgShowcaseItem\_HeroIcon\)

```csharp
public CMsgShowcaseItem_HeroIcon(CMsgShowcaseItem_HeroIcon other)
```

#### Parameters

`other` [CMsgShowcaseItem\_HeroIcon](Divine.Protobufs.Dota2.CMsgShowcaseItem\_HeroIcon.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_HeroIcon_DataFieldNumber"></a> DataFieldNumber

```csharp
public const int DataFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_HeroIcon_EconItemRefFieldNumber"></a> EconItemRefFieldNumber

```csharp
public const int EconItemRefFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_HeroIcon_HeroIdFieldNumber"></a> HeroIdFieldNumber

```csharp
public const int HeroIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_HeroIcon_Data"></a> Data

```csharp
public CMsgShowcaseItem_HeroIcon.Types.Data Data { get; set; }
```

#### Property Value

 [CMsgShowcaseItem\_HeroIcon](Divine.Protobufs.Dota2.CMsgShowcaseItem\_HeroIcon.md).[Types](Divine.Protobufs.Dota2.CMsgShowcaseItem\_HeroIcon.Types.md).[Data](Divine.Protobufs.Dota2.CMsgShowcaseItem\_HeroIcon.Types.Data.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_HeroIcon_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_HeroIcon_EconItemRef"></a> EconItemRef

```csharp
public CMsgShowcaseEconItemReference EconItemRef { get; set; }
```

#### Property Value

 [CMsgShowcaseEconItemReference](Divine.Protobufs.Dota2.CMsgShowcaseEconItemReference.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_HeroIcon_HasHeroId"></a> HasHeroId

```csharp
public bool HasHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_HeroIcon_HeroId"></a> HeroId

```csharp
public int HeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_HeroIcon_Parser"></a> Parser

```csharp
public static MessageParser<CMsgShowcaseItem_HeroIcon> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgShowcaseItem\_HeroIcon](Divine.Protobufs.Dota2.CMsgShowcaseItem\_HeroIcon.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_HeroIcon_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_HeroIcon_ClearHeroId"></a> ClearHeroId\(\)

```csharp
public void ClearHeroId()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_HeroIcon_Clone"></a> Clone\(\)

```csharp
public CMsgShowcaseItem_HeroIcon Clone()
```

#### Returns

 [CMsgShowcaseItem\_HeroIcon](Divine.Protobufs.Dota2.CMsgShowcaseItem\_HeroIcon.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_HeroIcon_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_HeroIcon_Equals_Divine_Protobufs_Dota2_CMsgShowcaseItem_HeroIcon_"></a> Equals\(CMsgShowcaseItem\_HeroIcon\)

```csharp
public bool Equals(CMsgShowcaseItem_HeroIcon other)
```

#### Parameters

`other` [CMsgShowcaseItem\_HeroIcon](Divine.Protobufs.Dota2.CMsgShowcaseItem\_HeroIcon.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_HeroIcon_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_HeroIcon_MergeFrom_Divine_Protobufs_Dota2_CMsgShowcaseItem_HeroIcon_"></a> MergeFrom\(CMsgShowcaseItem\_HeroIcon\)

```csharp
public void MergeFrom(CMsgShowcaseItem_HeroIcon other)
```

#### Parameters

`other` [CMsgShowcaseItem\_HeroIcon](Divine.Protobufs.Dota2.CMsgShowcaseItem\_HeroIcon.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_HeroIcon_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_HeroIcon_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_HeroIcon_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

