# <a id="Divine_Protobufs_Dota2_CMsgGameDataItemAbilityList"></a> Class CMsgGameDataItemAbilityList

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGameDataItemAbilityList : IMessage<CMsgGameDataItemAbilityList>, IEquatable<CMsgGameDataItemAbilityList>, IDeepCloneable<CMsgGameDataItemAbilityList>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGameDataItemAbilityList](Divine.Protobufs.Dota2.CMsgGameDataItemAbilityList.md)

#### Implements

IMessage<CMsgGameDataItemAbilityList\>, 
[IEquatable<CMsgGameDataItemAbilityList\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGameDataItemAbilityList\>, 
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
[EnumerableExtensions.In<CMsgGameDataItemAbilityList\>\(CMsgGameDataItemAbilityList, params CMsgGameDataItemAbilityList\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGameDataItemAbilityList__ctor"></a> CMsgGameDataItemAbilityList\(\)

```csharp
public CMsgGameDataItemAbilityList()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataItemAbilityList__ctor_Divine_Protobufs_Dota2_CMsgGameDataItemAbilityList_"></a> CMsgGameDataItemAbilityList\(CMsgGameDataItemAbilityList\)

```csharp
public CMsgGameDataItemAbilityList(CMsgGameDataItemAbilityList other)
```

#### Parameters

`other` [CMsgGameDataItemAbilityList](Divine.Protobufs.Dota2.CMsgGameDataItemAbilityList.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGameDataItemAbilityList_ItemabilitiesFieldNumber"></a> ItemabilitiesFieldNumber

```csharp
public const int ItemabilitiesFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGameDataItemAbilityList_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGameDataItemAbilityList_Itemabilities"></a> Itemabilities

```csharp
public RepeatedField<CMsgGameDataItemAbilityList.Types.ItemAbilityInfo> Itemabilities { get; }
```

#### Property Value

 RepeatedField<[CMsgGameDataItemAbilityList](Divine.Protobufs.Dota2.CMsgGameDataItemAbilityList.md).[Types](Divine.Protobufs.Dota2.CMsgGameDataItemAbilityList.Types.md).[ItemAbilityInfo](Divine.Protobufs.Dota2.CMsgGameDataItemAbilityList.Types.ItemAbilityInfo.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGameDataItemAbilityList_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGameDataItemAbilityList> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGameDataItemAbilityList](Divine.Protobufs.Dota2.CMsgGameDataItemAbilityList.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGameDataItemAbilityList_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataItemAbilityList_Clone"></a> Clone\(\)

```csharp
public CMsgGameDataItemAbilityList Clone()
```

#### Returns

 [CMsgGameDataItemAbilityList](Divine.Protobufs.Dota2.CMsgGameDataItemAbilityList.md)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataItemAbilityList_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataItemAbilityList_Equals_Divine_Protobufs_Dota2_CMsgGameDataItemAbilityList_"></a> Equals\(CMsgGameDataItemAbilityList\)

```csharp
public bool Equals(CMsgGameDataItemAbilityList other)
```

#### Parameters

`other` [CMsgGameDataItemAbilityList](Divine.Protobufs.Dota2.CMsgGameDataItemAbilityList.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataItemAbilityList_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataItemAbilityList_MergeFrom_Divine_Protobufs_Dota2_CMsgGameDataItemAbilityList_"></a> MergeFrom\(CMsgGameDataItemAbilityList\)

```csharp
public void MergeFrom(CMsgGameDataItemAbilityList other)
```

#### Parameters

`other` [CMsgGameDataItemAbilityList](Divine.Protobufs.Dota2.CMsgGameDataItemAbilityList.md)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataItemAbilityList_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGameDataItemAbilityList_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataItemAbilityList_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

