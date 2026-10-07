# <a id="Divine_Protobufs_Dota2_CMsgGameDataItemAbilityList_Types_ItemAbilityInfo_Types_Recipe"></a> Class CMsgGameDataItemAbilityList.Types.ItemAbilityInfo.Types.Recipe

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGameDataItemAbilityList.Types.ItemAbilityInfo.Types.Recipe : IMessage<CMsgGameDataItemAbilityList.Types.ItemAbilityInfo.Types.Recipe>, IEquatable<CMsgGameDataItemAbilityList.Types.ItemAbilityInfo.Types.Recipe>, IDeepCloneable<CMsgGameDataItemAbilityList.Types.ItemAbilityInfo.Types.Recipe>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGameDataItemAbilityList.Types.ItemAbilityInfo.Types.Recipe](Divine.Protobufs.Dota2.CMsgGameDataItemAbilityList.Types.ItemAbilityInfo.Types.Recipe.md)

#### Implements

IMessage<CMsgGameDataItemAbilityList.Types.ItemAbilityInfo.Types.Recipe\>, 
[IEquatable<CMsgGameDataItemAbilityList.Types.ItemAbilityInfo.Types.Recipe\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGameDataItemAbilityList.Types.ItemAbilityInfo.Types.Recipe\>, 
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
[EnumerableExtensions.In<CMsgGameDataItemAbilityList.Types.ItemAbilityInfo.Types.Recipe\>\(CMsgGameDataItemAbilityList.Types.ItemAbilityInfo.Types.Recipe, params CMsgGameDataItemAbilityList.Types.ItemAbilityInfo.Types.Recipe\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGameDataItemAbilityList_Types_ItemAbilityInfo_Types_Recipe__ctor"></a> Recipe\(\)

```csharp
public Recipe()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataItemAbilityList_Types_ItemAbilityInfo_Types_Recipe__ctor_Divine_Protobufs_Dota2_CMsgGameDataItemAbilityList_Types_ItemAbilityInfo_Types_Recipe_"></a> Recipe\(Recipe\)

```csharp
public Recipe(CMsgGameDataItemAbilityList.Types.ItemAbilityInfo.Types.Recipe other)
```

#### Parameters

`other` [CMsgGameDataItemAbilityList](Divine.Protobufs.Dota2.CMsgGameDataItemAbilityList.md).[Types](Divine.Protobufs.Dota2.CMsgGameDataItemAbilityList.Types.md).[ItemAbilityInfo](Divine.Protobufs.Dota2.CMsgGameDataItemAbilityList.Types.ItemAbilityInfo.md).[Types](Divine.Protobufs.Dota2.CMsgGameDataItemAbilityList.Types.ItemAbilityInfo.Types.md).[Recipe](Divine.Protobufs.Dota2.CMsgGameDataItemAbilityList.Types.ItemAbilityInfo.Types.Recipe.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGameDataItemAbilityList_Types_ItemAbilityInfo_Types_Recipe_ItemsFieldNumber"></a> ItemsFieldNumber

```csharp
public const int ItemsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGameDataItemAbilityList_Types_ItemAbilityInfo_Types_Recipe_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGameDataItemAbilityList_Types_ItemAbilityInfo_Types_Recipe_Items"></a> Items

```csharp
public RepeatedField<int> Items { get; }
```

#### Property Value

 RepeatedField<[int](https://learn.microsoft.com/dotnet/api/system.int32)\>

### <a id="Divine_Protobufs_Dota2_CMsgGameDataItemAbilityList_Types_ItemAbilityInfo_Types_Recipe_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGameDataItemAbilityList.Types.ItemAbilityInfo.Types.Recipe> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGameDataItemAbilityList](Divine.Protobufs.Dota2.CMsgGameDataItemAbilityList.md).[Types](Divine.Protobufs.Dota2.CMsgGameDataItemAbilityList.Types.md).[ItemAbilityInfo](Divine.Protobufs.Dota2.CMsgGameDataItemAbilityList.Types.ItemAbilityInfo.md).[Types](Divine.Protobufs.Dota2.CMsgGameDataItemAbilityList.Types.ItemAbilityInfo.Types.md).[Recipe](Divine.Protobufs.Dota2.CMsgGameDataItemAbilityList.Types.ItemAbilityInfo.Types.Recipe.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGameDataItemAbilityList_Types_ItemAbilityInfo_Types_Recipe_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataItemAbilityList_Types_ItemAbilityInfo_Types_Recipe_Clone"></a> Clone\(\)

```csharp
public CMsgGameDataItemAbilityList.Types.ItemAbilityInfo.Types.Recipe Clone()
```

#### Returns

 [CMsgGameDataItemAbilityList](Divine.Protobufs.Dota2.CMsgGameDataItemAbilityList.md).[Types](Divine.Protobufs.Dota2.CMsgGameDataItemAbilityList.Types.md).[ItemAbilityInfo](Divine.Protobufs.Dota2.CMsgGameDataItemAbilityList.Types.ItemAbilityInfo.md).[Types](Divine.Protobufs.Dota2.CMsgGameDataItemAbilityList.Types.ItemAbilityInfo.Types.md).[Recipe](Divine.Protobufs.Dota2.CMsgGameDataItemAbilityList.Types.ItemAbilityInfo.Types.Recipe.md)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataItemAbilityList_Types_ItemAbilityInfo_Types_Recipe_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataItemAbilityList_Types_ItemAbilityInfo_Types_Recipe_Equals_Divine_Protobufs_Dota2_CMsgGameDataItemAbilityList_Types_ItemAbilityInfo_Types_Recipe_"></a> Equals\(Recipe\)

```csharp
public bool Equals(CMsgGameDataItemAbilityList.Types.ItemAbilityInfo.Types.Recipe other)
```

#### Parameters

`other` [CMsgGameDataItemAbilityList](Divine.Protobufs.Dota2.CMsgGameDataItemAbilityList.md).[Types](Divine.Protobufs.Dota2.CMsgGameDataItemAbilityList.Types.md).[ItemAbilityInfo](Divine.Protobufs.Dota2.CMsgGameDataItemAbilityList.Types.ItemAbilityInfo.md).[Types](Divine.Protobufs.Dota2.CMsgGameDataItemAbilityList.Types.ItemAbilityInfo.Types.md).[Recipe](Divine.Protobufs.Dota2.CMsgGameDataItemAbilityList.Types.ItemAbilityInfo.Types.Recipe.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataItemAbilityList_Types_ItemAbilityInfo_Types_Recipe_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataItemAbilityList_Types_ItemAbilityInfo_Types_Recipe_MergeFrom_Divine_Protobufs_Dota2_CMsgGameDataItemAbilityList_Types_ItemAbilityInfo_Types_Recipe_"></a> MergeFrom\(Recipe\)

```csharp
public void MergeFrom(CMsgGameDataItemAbilityList.Types.ItemAbilityInfo.Types.Recipe other)
```

#### Parameters

`other` [CMsgGameDataItemAbilityList](Divine.Protobufs.Dota2.CMsgGameDataItemAbilityList.md).[Types](Divine.Protobufs.Dota2.CMsgGameDataItemAbilityList.Types.md).[ItemAbilityInfo](Divine.Protobufs.Dota2.CMsgGameDataItemAbilityList.Types.ItemAbilityInfo.md).[Types](Divine.Protobufs.Dota2.CMsgGameDataItemAbilityList.Types.ItemAbilityInfo.Types.md).[Recipe](Divine.Protobufs.Dota2.CMsgGameDataItemAbilityList.Types.ItemAbilityInfo.Types.Recipe.md)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataItemAbilityList_Types_ItemAbilityInfo_Types_Recipe_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGameDataItemAbilityList_Types_ItemAbilityInfo_Types_Recipe_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataItemAbilityList_Types_ItemAbilityInfo_Types_Recipe_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

