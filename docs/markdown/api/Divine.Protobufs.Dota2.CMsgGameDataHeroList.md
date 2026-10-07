# <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroList"></a> Class CMsgGameDataHeroList

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGameDataHeroList : IMessage<CMsgGameDataHeroList>, IEquatable<CMsgGameDataHeroList>, IDeepCloneable<CMsgGameDataHeroList>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGameDataHeroList](Divine.Protobufs.Dota2.CMsgGameDataHeroList.md)

#### Implements

IMessage<CMsgGameDataHeroList\>, 
[IEquatable<CMsgGameDataHeroList\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGameDataHeroList\>, 
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
[EnumerableExtensions.In<CMsgGameDataHeroList\>\(CMsgGameDataHeroList, params CMsgGameDataHeroList\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroList__ctor"></a> CMsgGameDataHeroList\(\)

```csharp
public CMsgGameDataHeroList()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroList__ctor_Divine_Protobufs_Dota2_CMsgGameDataHeroList_"></a> CMsgGameDataHeroList\(CMsgGameDataHeroList\)

```csharp
public CMsgGameDataHeroList(CMsgGameDataHeroList other)
```

#### Parameters

`other` [CMsgGameDataHeroList](Divine.Protobufs.Dota2.CMsgGameDataHeroList.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroList_HeroesFieldNumber"></a> HeroesFieldNumber

```csharp
public const int HeroesFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroList_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroList_Heroes"></a> Heroes

```csharp
public RepeatedField<CMsgGameDataHeroList.Types.HeroInfo> Heroes { get; }
```

#### Property Value

 RepeatedField<[CMsgGameDataHeroList](Divine.Protobufs.Dota2.CMsgGameDataHeroList.md).[Types](Divine.Protobufs.Dota2.CMsgGameDataHeroList.Types.md).[HeroInfo](Divine.Protobufs.Dota2.CMsgGameDataHeroList.Types.HeroInfo.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroList_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGameDataHeroList> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGameDataHeroList](Divine.Protobufs.Dota2.CMsgGameDataHeroList.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroList_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroList_Clone"></a> Clone\(\)

```csharp
public CMsgGameDataHeroList Clone()
```

#### Returns

 [CMsgGameDataHeroList](Divine.Protobufs.Dota2.CMsgGameDataHeroList.md)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroList_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroList_Equals_Divine_Protobufs_Dota2_CMsgGameDataHeroList_"></a> Equals\(CMsgGameDataHeroList\)

```csharp
public bool Equals(CMsgGameDataHeroList other)
```

#### Parameters

`other` [CMsgGameDataHeroList](Divine.Protobufs.Dota2.CMsgGameDataHeroList.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroList_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroList_MergeFrom_Divine_Protobufs_Dota2_CMsgGameDataHeroList_"></a> MergeFrom\(CMsgGameDataHeroList\)

```csharp
public void MergeFrom(CMsgGameDataHeroList other)
```

#### Parameters

`other` [CMsgGameDataHeroList](Divine.Protobufs.Dota2.CMsgGameDataHeroList.md)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroList_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroList_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataHeroList_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

