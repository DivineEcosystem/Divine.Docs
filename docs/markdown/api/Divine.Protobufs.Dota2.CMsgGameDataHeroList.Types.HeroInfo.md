# <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroList_Types_HeroInfo"></a> Class CMsgGameDataHeroList.Types.HeroInfo

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGameDataHeroList.Types.HeroInfo : IMessage<CMsgGameDataHeroList.Types.HeroInfo>, IEquatable<CMsgGameDataHeroList.Types.HeroInfo>, IDeepCloneable<CMsgGameDataHeroList.Types.HeroInfo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGameDataHeroList.Types.HeroInfo](Divine.Protobufs.Dota2.CMsgGameDataHeroList.Types.HeroInfo.md)

#### Implements

IMessage<CMsgGameDataHeroList.Types.HeroInfo\>, 
[IEquatable<CMsgGameDataHeroList.Types.HeroInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGameDataHeroList.Types.HeroInfo\>, 
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
[EnumerableExtensions.In<CMsgGameDataHeroList.Types.HeroInfo\>\(CMsgGameDataHeroList.Types.HeroInfo, params CMsgGameDataHeroList.Types.HeroInfo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroList_Types_HeroInfo__ctor"></a> HeroInfo\(\)

```csharp
public HeroInfo()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroList_Types_HeroInfo__ctor_Divine_Protobufs_Dota2_CMsgGameDataHeroList_Types_HeroInfo_"></a> HeroInfo\(HeroInfo\)

```csharp
public HeroInfo(CMsgGameDataHeroList.Types.HeroInfo other)
```

#### Parameters

`other` [CMsgGameDataHeroList](Divine.Protobufs.Dota2.CMsgGameDataHeroList.md).[Types](Divine.Protobufs.Dota2.CMsgGameDataHeroList.Types.md).[HeroInfo](Divine.Protobufs.Dota2.CMsgGameDataHeroList.Types.HeroInfo.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroList_Types_HeroInfo_ComplexityFieldNumber"></a> ComplexityFieldNumber

```csharp
public const int ComplexityFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroList_Types_HeroInfo_IdFieldNumber"></a> IdFieldNumber

```csharp
public const int IdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroList_Types_HeroInfo_NameEnglishLocFieldNumber"></a> NameEnglishLocFieldNumber

```csharp
public const int NameEnglishLocFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroList_Types_HeroInfo_NameFieldNumber"></a> NameFieldNumber

```csharp
public const int NameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroList_Types_HeroInfo_NameLocFieldNumber"></a> NameLocFieldNumber

```csharp
public const int NameLocFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroList_Types_HeroInfo_PrimaryAttrFieldNumber"></a> PrimaryAttrFieldNumber

```csharp
public const int PrimaryAttrFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroList_Types_HeroInfo_Complexity"></a> Complexity

```csharp
public uint Complexity { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroList_Types_HeroInfo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroList_Types_HeroInfo_HasComplexity"></a> HasComplexity

```csharp
public bool HasComplexity { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroList_Types_HeroInfo_HasId"></a> HasId

```csharp
public bool HasId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroList_Types_HeroInfo_HasName"></a> HasName

```csharp
public bool HasName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroList_Types_HeroInfo_HasNameEnglishLoc"></a> HasNameEnglishLoc

```csharp
public bool HasNameEnglishLoc { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroList_Types_HeroInfo_HasNameLoc"></a> HasNameLoc

```csharp
public bool HasNameLoc { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroList_Types_HeroInfo_HasPrimaryAttr"></a> HasPrimaryAttr

```csharp
public bool HasPrimaryAttr { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroList_Types_HeroInfo_Id"></a> Id

```csharp
public int Id { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroList_Types_HeroInfo_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroList_Types_HeroInfo_NameEnglishLoc"></a> NameEnglishLoc

```csharp
public string NameEnglishLoc { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroList_Types_HeroInfo_NameLoc"></a> NameLoc

```csharp
public string NameLoc { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroList_Types_HeroInfo_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGameDataHeroList.Types.HeroInfo> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGameDataHeroList](Divine.Protobufs.Dota2.CMsgGameDataHeroList.md).[Types](Divine.Protobufs.Dota2.CMsgGameDataHeroList.Types.md).[HeroInfo](Divine.Protobufs.Dota2.CMsgGameDataHeroList.Types.HeroInfo.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroList_Types_HeroInfo_PrimaryAttr"></a> PrimaryAttr

```csharp
public uint PrimaryAttr { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroList_Types_HeroInfo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroList_Types_HeroInfo_ClearComplexity"></a> ClearComplexity\(\)

```csharp
public void ClearComplexity()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroList_Types_HeroInfo_ClearId"></a> ClearId\(\)

```csharp
public void ClearId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroList_Types_HeroInfo_ClearName"></a> ClearName\(\)

```csharp
public void ClearName()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroList_Types_HeroInfo_ClearNameEnglishLoc"></a> ClearNameEnglishLoc\(\)

```csharp
public void ClearNameEnglishLoc()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroList_Types_HeroInfo_ClearNameLoc"></a> ClearNameLoc\(\)

```csharp
public void ClearNameLoc()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroList_Types_HeroInfo_ClearPrimaryAttr"></a> ClearPrimaryAttr\(\)

```csharp
public void ClearPrimaryAttr()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroList_Types_HeroInfo_Clone"></a> Clone\(\)

```csharp
public CMsgGameDataHeroList.Types.HeroInfo Clone()
```

#### Returns

 [CMsgGameDataHeroList](Divine.Protobufs.Dota2.CMsgGameDataHeroList.md).[Types](Divine.Protobufs.Dota2.CMsgGameDataHeroList.Types.md).[HeroInfo](Divine.Protobufs.Dota2.CMsgGameDataHeroList.Types.HeroInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroList_Types_HeroInfo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroList_Types_HeroInfo_Equals_Divine_Protobufs_Dota2_CMsgGameDataHeroList_Types_HeroInfo_"></a> Equals\(HeroInfo\)

```csharp
public bool Equals(CMsgGameDataHeroList.Types.HeroInfo other)
```

#### Parameters

`other` [CMsgGameDataHeroList](Divine.Protobufs.Dota2.CMsgGameDataHeroList.md).[Types](Divine.Protobufs.Dota2.CMsgGameDataHeroList.Types.md).[HeroInfo](Divine.Protobufs.Dota2.CMsgGameDataHeroList.Types.HeroInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroList_Types_HeroInfo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroList_Types_HeroInfo_MergeFrom_Divine_Protobufs_Dota2_CMsgGameDataHeroList_Types_HeroInfo_"></a> MergeFrom\(HeroInfo\)

```csharp
public void MergeFrom(CMsgGameDataHeroList.Types.HeroInfo other)
```

#### Parameters

`other` [CMsgGameDataHeroList](Divine.Protobufs.Dota2.CMsgGameDataHeroList.md).[Types](Divine.Protobufs.Dota2.CMsgGameDataHeroList.Types.md).[HeroInfo](Divine.Protobufs.Dota2.CMsgGameDataHeroList.Types.HeroInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroList_Types_HeroInfo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroList_Types_HeroInfo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroList_Types_HeroInfo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

