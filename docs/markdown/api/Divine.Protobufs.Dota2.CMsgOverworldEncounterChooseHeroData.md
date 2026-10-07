# <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterChooseHeroData"></a> Class CMsgOverworldEncounterChooseHeroData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgOverworldEncounterChooseHeroData : IMessage<CMsgOverworldEncounterChooseHeroData>, IEquatable<CMsgOverworldEncounterChooseHeroData>, IDeepCloneable<CMsgOverworldEncounterChooseHeroData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgOverworldEncounterChooseHeroData](Divine.Protobufs.Dota2.CMsgOverworldEncounterChooseHeroData.md)

#### Implements

IMessage<CMsgOverworldEncounterChooseHeroData\>, 
[IEquatable<CMsgOverworldEncounterChooseHeroData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgOverworldEncounterChooseHeroData\>, 
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
[EnumerableExtensions.In<CMsgOverworldEncounterChooseHeroData\>\(CMsgOverworldEncounterChooseHeroData, params CMsgOverworldEncounterChooseHeroData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterChooseHeroData__ctor"></a> CMsgOverworldEncounterChooseHeroData\(\)

```csharp
public CMsgOverworldEncounterChooseHeroData()
```

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterChooseHeroData__ctor_Divine_Protobufs_Dota2_CMsgOverworldEncounterChooseHeroData_"></a> CMsgOverworldEncounterChooseHeroData\(CMsgOverworldEncounterChooseHeroData\)

```csharp
public CMsgOverworldEncounterChooseHeroData(CMsgOverworldEncounterChooseHeroData other)
```

#### Parameters

`other` [CMsgOverworldEncounterChooseHeroData](Divine.Protobufs.Dota2.CMsgOverworldEncounterChooseHeroData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterChooseHeroData_AdditiveFieldNumber"></a> AdditiveFieldNumber

```csharp
public const int AdditiveFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterChooseHeroData_HeroListFieldNumber"></a> HeroListFieldNumber

```csharp
public const int HeroListFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterChooseHeroData_Additive"></a> Additive

```csharp
public bool Additive { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterChooseHeroData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterChooseHeroData_HasAdditive"></a> HasAdditive

```csharp
public bool HasAdditive { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterChooseHeroData_HeroList"></a> HeroList

```csharp
public CMsgOverworldHeroList HeroList { get; set; }
```

#### Property Value

 [CMsgOverworldHeroList](Divine.Protobufs.Dota2.CMsgOverworldHeroList.md)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterChooseHeroData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgOverworldEncounterChooseHeroData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgOverworldEncounterChooseHeroData](Divine.Protobufs.Dota2.CMsgOverworldEncounterChooseHeroData.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterChooseHeroData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterChooseHeroData_ClearAdditive"></a> ClearAdditive\(\)

```csharp
public void ClearAdditive()
```

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterChooseHeroData_Clone"></a> Clone\(\)

```csharp
public CMsgOverworldEncounterChooseHeroData Clone()
```

#### Returns

 [CMsgOverworldEncounterChooseHeroData](Divine.Protobufs.Dota2.CMsgOverworldEncounterChooseHeroData.md)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterChooseHeroData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterChooseHeroData_Equals_Divine_Protobufs_Dota2_CMsgOverworldEncounterChooseHeroData_"></a> Equals\(CMsgOverworldEncounterChooseHeroData\)

```csharp
public bool Equals(CMsgOverworldEncounterChooseHeroData other)
```

#### Parameters

`other` [CMsgOverworldEncounterChooseHeroData](Divine.Protobufs.Dota2.CMsgOverworldEncounterChooseHeroData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterChooseHeroData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterChooseHeroData_MergeFrom_Divine_Protobufs_Dota2_CMsgOverworldEncounterChooseHeroData_"></a> MergeFrom\(CMsgOverworldEncounterChooseHeroData\)

```csharp
public void MergeFrom(CMsgOverworldEncounterChooseHeroData other)
```

#### Parameters

`other` [CMsgOverworldEncounterChooseHeroData](Divine.Protobufs.Dota2.CMsgOverworldEncounterChooseHeroData.md)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterChooseHeroData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterChooseHeroData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldEncounterChooseHeroData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

