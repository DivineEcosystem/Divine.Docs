# <a id="Divine_Protobufs_Dota2_CMsgEventActionGrantLootListRewardData"></a> Class CMsgEventActionGrantLootListRewardData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgEventActionGrantLootListRewardData : IMessage<CMsgEventActionGrantLootListRewardData>, IEquatable<CMsgEventActionGrantLootListRewardData>, IDeepCloneable<CMsgEventActionGrantLootListRewardData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgEventActionGrantLootListRewardData](Divine.Protobufs.Dota2.CMsgEventActionGrantLootListRewardData.md)

#### Implements

IMessage<CMsgEventActionGrantLootListRewardData\>, 
[IEquatable<CMsgEventActionGrantLootListRewardData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgEventActionGrantLootListRewardData\>, 
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
[EnumerableExtensions.In<CMsgEventActionGrantLootListRewardData\>\(CMsgEventActionGrantLootListRewardData, params CMsgEventActionGrantLootListRewardData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgEventActionGrantLootListRewardData__ctor"></a> CMsgEventActionGrantLootListRewardData\(\)

```csharp
public CMsgEventActionGrantLootListRewardData()
```

### <a id="Divine_Protobufs_Dota2_CMsgEventActionGrantLootListRewardData__ctor_Divine_Protobufs_Dota2_CMsgEventActionGrantLootListRewardData_"></a> CMsgEventActionGrantLootListRewardData\(CMsgEventActionGrantLootListRewardData\)

```csharp
public CMsgEventActionGrantLootListRewardData(CMsgEventActionGrantLootListRewardData other)
```

#### Parameters

`other` [CMsgEventActionGrantLootListRewardData](Divine.Protobufs.Dota2.CMsgEventActionGrantLootListRewardData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgEventActionGrantLootListRewardData_ItemDefFieldNumber"></a> ItemDefFieldNumber

```csharp
public const int ItemDefFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgEventActionGrantLootListRewardData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgEventActionGrantLootListRewardData_ItemDef"></a> ItemDef

```csharp
public RepeatedField<uint> ItemDef { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgEventActionGrantLootListRewardData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgEventActionGrantLootListRewardData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgEventActionGrantLootListRewardData](Divine.Protobufs.Dota2.CMsgEventActionGrantLootListRewardData.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgEventActionGrantLootListRewardData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgEventActionGrantLootListRewardData_Clone"></a> Clone\(\)

```csharp
public CMsgEventActionGrantLootListRewardData Clone()
```

#### Returns

 [CMsgEventActionGrantLootListRewardData](Divine.Protobufs.Dota2.CMsgEventActionGrantLootListRewardData.md)

### <a id="Divine_Protobufs_Dota2_CMsgEventActionGrantLootListRewardData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgEventActionGrantLootListRewardData_Equals_Divine_Protobufs_Dota2_CMsgEventActionGrantLootListRewardData_"></a> Equals\(CMsgEventActionGrantLootListRewardData\)

```csharp
public bool Equals(CMsgEventActionGrantLootListRewardData other)
```

#### Parameters

`other` [CMsgEventActionGrantLootListRewardData](Divine.Protobufs.Dota2.CMsgEventActionGrantLootListRewardData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgEventActionGrantLootListRewardData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgEventActionGrantLootListRewardData_MergeFrom_Divine_Protobufs_Dota2_CMsgEventActionGrantLootListRewardData_"></a> MergeFrom\(CMsgEventActionGrantLootListRewardData\)

```csharp
public void MergeFrom(CMsgEventActionGrantLootListRewardData other)
```

#### Parameters

`other` [CMsgEventActionGrantLootListRewardData](Divine.Protobufs.Dota2.CMsgEventActionGrantLootListRewardData.md)

### <a id="Divine_Protobufs_Dota2_CMsgEventActionGrantLootListRewardData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgEventActionGrantLootListRewardData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgEventActionGrantLootListRewardData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

