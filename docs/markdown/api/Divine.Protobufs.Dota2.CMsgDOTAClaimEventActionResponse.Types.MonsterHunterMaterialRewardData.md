# <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_MonsterHunterMaterialRewardData"></a> Class CMsgDOTAClaimEventActionResponse.Types.MonsterHunterMaterialRewardData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAClaimEventActionResponse.Types.MonsterHunterMaterialRewardData : IMessage<CMsgDOTAClaimEventActionResponse.Types.MonsterHunterMaterialRewardData>, IEquatable<CMsgDOTAClaimEventActionResponse.Types.MonsterHunterMaterialRewardData>, IDeepCloneable<CMsgDOTAClaimEventActionResponse.Types.MonsterHunterMaterialRewardData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAClaimEventActionResponse.Types.MonsterHunterMaterialRewardData](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.Types.MonsterHunterMaterialRewardData.md)

#### Implements

IMessage<CMsgDOTAClaimEventActionResponse.Types.MonsterHunterMaterialRewardData\>, 
[IEquatable<CMsgDOTAClaimEventActionResponse.Types.MonsterHunterMaterialRewardData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAClaimEventActionResponse.Types.MonsterHunterMaterialRewardData\>, 
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
[EnumerableExtensions.In<CMsgDOTAClaimEventActionResponse.Types.MonsterHunterMaterialRewardData\>\(CMsgDOTAClaimEventActionResponse.Types.MonsterHunterMaterialRewardData, params CMsgDOTAClaimEventActionResponse.Types.MonsterHunterMaterialRewardData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_MonsterHunterMaterialRewardData__ctor"></a> MonsterHunterMaterialRewardData\(\)

```csharp
public MonsterHunterMaterialRewardData()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_MonsterHunterMaterialRewardData__ctor_Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_MonsterHunterMaterialRewardData_"></a> MonsterHunterMaterialRewardData\(MonsterHunterMaterialRewardData\)

```csharp
public MonsterHunterMaterialRewardData(CMsgDOTAClaimEventActionResponse.Types.MonsterHunterMaterialRewardData other)
```

#### Parameters

`other` [CMsgDOTAClaimEventActionResponse](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.Types.md).[MonsterHunterMaterialRewardData](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.Types.MonsterHunterMaterialRewardData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_MonsterHunterMaterialRewardData_MaterialsFieldNumber"></a> MaterialsFieldNumber

```csharp
public const int MaterialsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_MonsterHunterMaterialRewardData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_MonsterHunterMaterialRewardData_Materials"></a> Materials

```csharp
public RepeatedField<CMsgDOTAClaimEventActionResponse.Types.MonsterHunterMaterialRewardData.Types.MaterialQuantity> Materials { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTAClaimEventActionResponse](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.Types.md).[MonsterHunterMaterialRewardData](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.Types.MonsterHunterMaterialRewardData.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.Types.MonsterHunterMaterialRewardData.Types.md).[MaterialQuantity](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.Types.MonsterHunterMaterialRewardData.Types.MaterialQuantity.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_MonsterHunterMaterialRewardData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAClaimEventActionResponse.Types.MonsterHunterMaterialRewardData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAClaimEventActionResponse](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.Types.md).[MonsterHunterMaterialRewardData](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.Types.MonsterHunterMaterialRewardData.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_MonsterHunterMaterialRewardData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_MonsterHunterMaterialRewardData_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAClaimEventActionResponse.Types.MonsterHunterMaterialRewardData Clone()
```

#### Returns

 [CMsgDOTAClaimEventActionResponse](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.Types.md).[MonsterHunterMaterialRewardData](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.Types.MonsterHunterMaterialRewardData.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_MonsterHunterMaterialRewardData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_MonsterHunterMaterialRewardData_Equals_Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_MonsterHunterMaterialRewardData_"></a> Equals\(MonsterHunterMaterialRewardData\)

```csharp
public bool Equals(CMsgDOTAClaimEventActionResponse.Types.MonsterHunterMaterialRewardData other)
```

#### Parameters

`other` [CMsgDOTAClaimEventActionResponse](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.Types.md).[MonsterHunterMaterialRewardData](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.Types.MonsterHunterMaterialRewardData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_MonsterHunterMaterialRewardData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_MonsterHunterMaterialRewardData_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_MonsterHunterMaterialRewardData_"></a> MergeFrom\(MonsterHunterMaterialRewardData\)

```csharp
public void MergeFrom(CMsgDOTAClaimEventActionResponse.Types.MonsterHunterMaterialRewardData other)
```

#### Parameters

`other` [CMsgDOTAClaimEventActionResponse](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.Types.md).[MonsterHunterMaterialRewardData](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.Types.MonsterHunterMaterialRewardData.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_MonsterHunterMaterialRewardData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_MonsterHunterMaterialRewardData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAClaimEventActionResponse_Types_MonsterHunterMaterialRewardData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

