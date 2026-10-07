# <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_MysteryItemRewardData"></a> Class CMsgDOTAClaimEventActionResponse.Types.MysteryItemRewardData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAClaimEventActionResponse.Types.MysteryItemRewardData : IMessage<CMsgDOTAClaimEventActionResponse.Types.MysteryItemRewardData>, IEquatable<CMsgDOTAClaimEventActionResponse.Types.MysteryItemRewardData>, IDeepCloneable<CMsgDOTAClaimEventActionResponse.Types.MysteryItemRewardData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAClaimEventActionResponse.Types.MysteryItemRewardData](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.Types.MysteryItemRewardData.md)

#### Implements

IMessage<CMsgDOTAClaimEventActionResponse.Types.MysteryItemRewardData\>, 
[IEquatable<CMsgDOTAClaimEventActionResponse.Types.MysteryItemRewardData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAClaimEventActionResponse.Types.MysteryItemRewardData\>, 
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
[EnumerableExtensions.In<CMsgDOTAClaimEventActionResponse.Types.MysteryItemRewardData\>\(CMsgDOTAClaimEventActionResponse.Types.MysteryItemRewardData, params CMsgDOTAClaimEventActionResponse.Types.MysteryItemRewardData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_MysteryItemRewardData__ctor"></a> MysteryItemRewardData\(\)

```csharp
public MysteryItemRewardData()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_MysteryItemRewardData__ctor_Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_MysteryItemRewardData_"></a> MysteryItemRewardData\(MysteryItemRewardData\)

```csharp
public MysteryItemRewardData(CMsgDOTAClaimEventActionResponse.Types.MysteryItemRewardData other)
```

#### Parameters

`other` [CMsgDOTAClaimEventActionResponse](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.Types.md).[MysteryItemRewardData](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.Types.MysteryItemRewardData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_MysteryItemRewardData_ItemCategoryFieldNumber"></a> ItemCategoryFieldNumber

```csharp
public const int ItemCategoryFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_MysteryItemRewardData_ItemDefFieldNumber"></a> ItemDefFieldNumber

```csharp
public const int ItemDefFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_MysteryItemRewardData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_MysteryItemRewardData_HasItemCategory"></a> HasItemCategory

```csharp
public bool HasItemCategory { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_MysteryItemRewardData_HasItemDef"></a> HasItemDef

```csharp
public bool HasItemDef { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_MysteryItemRewardData_ItemCategory"></a> ItemCategory

```csharp
public uint ItemCategory { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_MysteryItemRewardData_ItemDef"></a> ItemDef

```csharp
public uint ItemDef { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_MysteryItemRewardData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAClaimEventActionResponse.Types.MysteryItemRewardData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAClaimEventActionResponse](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.Types.md).[MysteryItemRewardData](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.Types.MysteryItemRewardData.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_MysteryItemRewardData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_MysteryItemRewardData_ClearItemCategory"></a> ClearItemCategory\(\)

```csharp
public void ClearItemCategory()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_MysteryItemRewardData_ClearItemDef"></a> ClearItemDef\(\)

```csharp
public void ClearItemDef()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_MysteryItemRewardData_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAClaimEventActionResponse.Types.MysteryItemRewardData Clone()
```

#### Returns

 [CMsgDOTAClaimEventActionResponse](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.Types.md).[MysteryItemRewardData](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.Types.MysteryItemRewardData.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_MysteryItemRewardData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_MysteryItemRewardData_Equals_Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_MysteryItemRewardData_"></a> Equals\(MysteryItemRewardData\)

```csharp
public bool Equals(CMsgDOTAClaimEventActionResponse.Types.MysteryItemRewardData other)
```

#### Parameters

`other` [CMsgDOTAClaimEventActionResponse](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.Types.md).[MysteryItemRewardData](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.Types.MysteryItemRewardData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_MysteryItemRewardData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_MysteryItemRewardData_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_MysteryItemRewardData_"></a> MergeFrom\(MysteryItemRewardData\)

```csharp
public void MergeFrom(CMsgDOTAClaimEventActionResponse.Types.MysteryItemRewardData other)
```

#### Parameters

`other` [CMsgDOTAClaimEventActionResponse](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.Types.md).[MysteryItemRewardData](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.Types.MysteryItemRewardData.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_MysteryItemRewardData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_MysteryItemRewardData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_MysteryItemRewardData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

