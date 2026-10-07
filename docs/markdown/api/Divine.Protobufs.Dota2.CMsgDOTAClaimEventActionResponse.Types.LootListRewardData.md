# <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_LootListRewardData"></a> Class CMsgDOTAClaimEventActionResponse.Types.LootListRewardData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAClaimEventActionResponse.Types.LootListRewardData : IMessage<CMsgDOTAClaimEventActionResponse.Types.LootListRewardData>, IEquatable<CMsgDOTAClaimEventActionResponse.Types.LootListRewardData>, IDeepCloneable<CMsgDOTAClaimEventActionResponse.Types.LootListRewardData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAClaimEventActionResponse.Types.LootListRewardData](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.Types.LootListRewardData.md)

#### Implements

IMessage<CMsgDOTAClaimEventActionResponse.Types.LootListRewardData\>, 
[IEquatable<CMsgDOTAClaimEventActionResponse.Types.LootListRewardData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAClaimEventActionResponse.Types.LootListRewardData\>, 
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
[EnumerableExtensions.In<CMsgDOTAClaimEventActionResponse.Types.LootListRewardData\>\(CMsgDOTAClaimEventActionResponse.Types.LootListRewardData, params CMsgDOTAClaimEventActionResponse.Types.LootListRewardData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_LootListRewardData__ctor"></a> LootListRewardData\(\)

```csharp
public LootListRewardData()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_LootListRewardData__ctor_Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_LootListRewardData_"></a> LootListRewardData\(LootListRewardData\)

```csharp
public LootListRewardData(CMsgDOTAClaimEventActionResponse.Types.LootListRewardData other)
```

#### Parameters

`other` [CMsgDOTAClaimEventActionResponse](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.Types.md).[LootListRewardData](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.Types.LootListRewardData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_LootListRewardData_ItemDefFieldNumber"></a> ItemDefFieldNumber

```csharp
public const int ItemDefFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_LootListRewardData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_LootListRewardData_ItemDef"></a> ItemDef

```csharp
public RepeatedField<uint> ItemDef { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_LootListRewardData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAClaimEventActionResponse.Types.LootListRewardData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAClaimEventActionResponse](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.Types.md).[LootListRewardData](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.Types.LootListRewardData.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_LootListRewardData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_LootListRewardData_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAClaimEventActionResponse.Types.LootListRewardData Clone()
```

#### Returns

 [CMsgDOTAClaimEventActionResponse](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.Types.md).[LootListRewardData](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.Types.LootListRewardData.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_LootListRewardData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_LootListRewardData_Equals_Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_LootListRewardData_"></a> Equals\(LootListRewardData\)

```csharp
public bool Equals(CMsgDOTAClaimEventActionResponse.Types.LootListRewardData other)
```

#### Parameters

`other` [CMsgDOTAClaimEventActionResponse](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.Types.md).[LootListRewardData](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.Types.LootListRewardData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_LootListRewardData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_LootListRewardData_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_LootListRewardData_"></a> MergeFrom\(LootListRewardData\)

```csharp
public void MergeFrom(CMsgDOTAClaimEventActionResponse.Types.LootListRewardData other)
```

#### Parameters

`other` [CMsgDOTAClaimEventActionResponse](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.Types.md).[LootListRewardData](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.Types.LootListRewardData.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_LootListRewardData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_LootListRewardData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_LootListRewardData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

