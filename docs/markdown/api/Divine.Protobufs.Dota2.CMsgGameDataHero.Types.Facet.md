# <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_Types_Facet"></a> Class CMsgGameDataHero.Types.Facet

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGameDataHero.Types.Facet : IMessage<CMsgGameDataHero.Types.Facet>, IEquatable<CMsgGameDataHero.Types.Facet>, IDeepCloneable<CMsgGameDataHero.Types.Facet>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGameDataHero.Types.Facet](Divine.Protobufs.Dota2.CMsgGameDataHero.Types.Facet.md)

#### Implements

IMessage<CMsgGameDataHero.Types.Facet\>, 
[IEquatable<CMsgGameDataHero.Types.Facet\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGameDataHero.Types.Facet\>, 
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
[EnumerableExtensions.In<CMsgGameDataHero.Types.Facet\>\(CMsgGameDataHero.Types.Facet, params CMsgGameDataHero.Types.Facet\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_Types_Facet__ctor"></a> Facet\(\)

```csharp
public Facet()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_Types_Facet__ctor_Divine_Protobufs_Dota2_CMsgGameDataHero_Types_Facet_"></a> Facet\(Facet\)

```csharp
public Facet(CMsgGameDataHero.Types.Facet other)
```

#### Parameters

`other` [CMsgGameDataHero](Divine.Protobufs.Dota2.CMsgGameDataHero.md).[Types](Divine.Protobufs.Dota2.CMsgGameDataHero.Types.md).[Facet](Divine.Protobufs.Dota2.CMsgGameDataHero.Types.Facet.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_Types_Facet_ColorFieldNumber"></a> ColorFieldNumber

```csharp
public const int ColorFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_Types_Facet_DescriptionLocFieldNumber"></a> DescriptionLocFieldNumber

```csharp
public const int DescriptionLocFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_Types_Facet_GradientIdFieldNumber"></a> GradientIdFieldNumber

```csharp
public const int GradientIdFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_Types_Facet_IconFieldNumber"></a> IconFieldNumber

```csharp
public const int IconFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_Types_Facet_IndexFieldNumber"></a> IndexFieldNumber

```csharp
public const int IndexFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_Types_Facet_NameFieldNumber"></a> NameFieldNumber

```csharp
public const int NameFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_Types_Facet_TitleLocFieldNumber"></a> TitleLocFieldNumber

```csharp
public const int TitleLocFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_Types_Facet_Color"></a> Color

```csharp
public uint Color { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_Types_Facet_DescriptionLoc"></a> DescriptionLoc

```csharp
public string DescriptionLoc { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_Types_Facet_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_Types_Facet_GradientId"></a> GradientId

```csharp
public int GradientId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_Types_Facet_HasColor"></a> HasColor

```csharp
public bool HasColor { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_Types_Facet_HasDescriptionLoc"></a> HasDescriptionLoc

```csharp
public bool HasDescriptionLoc { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_Types_Facet_HasGradientId"></a> HasGradientId

```csharp
public bool HasGradientId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_Types_Facet_HasIcon"></a> HasIcon

```csharp
public bool HasIcon { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_Types_Facet_HasIndex"></a> HasIndex

```csharp
public bool HasIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_Types_Facet_HasName"></a> HasName

```csharp
public bool HasName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_Types_Facet_HasTitleLoc"></a> HasTitleLoc

```csharp
public bool HasTitleLoc { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_Types_Facet_Icon"></a> Icon

```csharp
public string Icon { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_Types_Facet_Index"></a> Index

```csharp
public uint Index { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_Types_Facet_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_Types_Facet_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGameDataHero.Types.Facet> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGameDataHero](Divine.Protobufs.Dota2.CMsgGameDataHero.md).[Types](Divine.Protobufs.Dota2.CMsgGameDataHero.Types.md).[Facet](Divine.Protobufs.Dota2.CMsgGameDataHero.Types.Facet.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_Types_Facet_TitleLoc"></a> TitleLoc

```csharp
public string TitleLoc { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_Types_Facet_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_Types_Facet_ClearColor"></a> ClearColor\(\)

```csharp
public void ClearColor()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_Types_Facet_ClearDescriptionLoc"></a> ClearDescriptionLoc\(\)

```csharp
public void ClearDescriptionLoc()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_Types_Facet_ClearGradientId"></a> ClearGradientId\(\)

```csharp
public void ClearGradientId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_Types_Facet_ClearIcon"></a> ClearIcon\(\)

```csharp
public void ClearIcon()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_Types_Facet_ClearIndex"></a> ClearIndex\(\)

```csharp
public void ClearIndex()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_Types_Facet_ClearName"></a> ClearName\(\)

```csharp
public void ClearName()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_Types_Facet_ClearTitleLoc"></a> ClearTitleLoc\(\)

```csharp
public void ClearTitleLoc()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_Types_Facet_Clone"></a> Clone\(\)

```csharp
public CMsgGameDataHero.Types.Facet Clone()
```

#### Returns

 [CMsgGameDataHero](Divine.Protobufs.Dota2.CMsgGameDataHero.md).[Types](Divine.Protobufs.Dota2.CMsgGameDataHero.Types.md).[Facet](Divine.Protobufs.Dota2.CMsgGameDataHero.Types.Facet.md)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_Types_Facet_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_Types_Facet_Equals_Divine_Protobufs_Dota2_CMsgGameDataHero_Types_Facet_"></a> Equals\(Facet\)

```csharp
public bool Equals(CMsgGameDataHero.Types.Facet other)
```

#### Parameters

`other` [CMsgGameDataHero](Divine.Protobufs.Dota2.CMsgGameDataHero.md).[Types](Divine.Protobufs.Dota2.CMsgGameDataHero.Types.md).[Facet](Divine.Protobufs.Dota2.CMsgGameDataHero.Types.Facet.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_Types_Facet_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_Types_Facet_MergeFrom_Divine_Protobufs_Dota2_CMsgGameDataHero_Types_Facet_"></a> MergeFrom\(Facet\)

```csharp
public void MergeFrom(CMsgGameDataHero.Types.Facet other)
```

#### Parameters

`other` [CMsgGameDataHero](Divine.Protobufs.Dota2.CMsgGameDataHero.md).[Types](Divine.Protobufs.Dota2.CMsgGameDataHero.Types.md).[Facet](Divine.Protobufs.Dota2.CMsgGameDataHero.Types.Facet.md)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_Types_Facet_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_Types_Facet_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHero_Types_Facet_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

