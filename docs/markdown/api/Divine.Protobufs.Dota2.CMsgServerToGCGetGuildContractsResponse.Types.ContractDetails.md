# <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Types_ContractDetails"></a> Class CMsgServerToGCGetGuildContractsResponse.Types.ContractDetails

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgServerToGCGetGuildContractsResponse.Types.ContractDetails : IMessage<CMsgServerToGCGetGuildContractsResponse.Types.ContractDetails>, IEquatable<CMsgServerToGCGetGuildContractsResponse.Types.ContractDetails>, IDeepCloneable<CMsgServerToGCGetGuildContractsResponse.Types.ContractDetails>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgServerToGCGetGuildContractsResponse.Types.ContractDetails](Divine.Protobufs.Dota2.CMsgServerToGCGetGuildContractsResponse.Types.ContractDetails.md)

#### Implements

IMessage<CMsgServerToGCGetGuildContractsResponse.Types.ContractDetails\>, 
[IEquatable<CMsgServerToGCGetGuildContractsResponse.Types.ContractDetails\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgServerToGCGetGuildContractsResponse.Types.ContractDetails\>, 
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
[EnumerableExtensions.In<CMsgServerToGCGetGuildContractsResponse.Types.ContractDetails\>\(CMsgServerToGCGetGuildContractsResponse.Types.ContractDetails, params CMsgServerToGCGetGuildContractsResponse.Types.ContractDetails\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Types_ContractDetails__ctor"></a> ContractDetails\(\)

```csharp
public ContractDetails()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Types_ContractDetails__ctor_Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Types_ContractDetails_"></a> ContractDetails\(ContractDetails\)

```csharp
public ContractDetails(CMsgServerToGCGetGuildContractsResponse.Types.ContractDetails other)
```

#### Parameters

`other` [CMsgServerToGCGetGuildContractsResponse](Divine.Protobufs.Dota2.CMsgServerToGCGetGuildContractsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgServerToGCGetGuildContractsResponse.Types.md).[ContractDetails](Divine.Protobufs.Dota2.CMsgServerToGCGetGuildContractsResponse.Types.ContractDetails.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Types_ContractDetails_ChallengeInstanceIdFieldNumber"></a> ChallengeInstanceIdFieldNumber

```csharp
public const int ChallengeInstanceIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Types_ContractDetails_ChallengeParameterFieldNumber"></a> ChallengeParameterFieldNumber

```csharp
public const int ChallengeParameterFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Types_ContractDetails_ContractIdFieldNumber"></a> ContractIdFieldNumber

```csharp
public const int ContractIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Types_ContractDetails_ContractSlotFieldNumber"></a> ContractSlotFieldNumber

```csharp
public const int ContractSlotFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Types_ContractDetails_ContractStarsFieldNumber"></a> ContractStarsFieldNumber

```csharp
public const int ContractStarsFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Types_ContractDetails_ChallengeInstanceId"></a> ChallengeInstanceId

```csharp
public uint ChallengeInstanceId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Types_ContractDetails_ChallengeParameter"></a> ChallengeParameter

```csharp
public uint ChallengeParameter { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Types_ContractDetails_ContractId"></a> ContractId

```csharp
public ulong ContractId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Types_ContractDetails_ContractSlot"></a> ContractSlot

```csharp
public uint ContractSlot { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Types_ContractDetails_ContractStars"></a> ContractStars

```csharp
public uint ContractStars { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Types_ContractDetails_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Types_ContractDetails_HasChallengeInstanceId"></a> HasChallengeInstanceId

```csharp
public bool HasChallengeInstanceId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Types_ContractDetails_HasChallengeParameter"></a> HasChallengeParameter

```csharp
public bool HasChallengeParameter { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Types_ContractDetails_HasContractId"></a> HasContractId

```csharp
public bool HasContractId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Types_ContractDetails_HasContractSlot"></a> HasContractSlot

```csharp
public bool HasContractSlot { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Types_ContractDetails_HasContractStars"></a> HasContractStars

```csharp
public bool HasContractStars { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Types_ContractDetails_Parser"></a> Parser

```csharp
public static MessageParser<CMsgServerToGCGetGuildContractsResponse.Types.ContractDetails> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgServerToGCGetGuildContractsResponse](Divine.Protobufs.Dota2.CMsgServerToGCGetGuildContractsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgServerToGCGetGuildContractsResponse.Types.md).[ContractDetails](Divine.Protobufs.Dota2.CMsgServerToGCGetGuildContractsResponse.Types.ContractDetails.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Types_ContractDetails_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Types_ContractDetails_ClearChallengeInstanceId"></a> ClearChallengeInstanceId\(\)

```csharp
public void ClearChallengeInstanceId()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Types_ContractDetails_ClearChallengeParameter"></a> ClearChallengeParameter\(\)

```csharp
public void ClearChallengeParameter()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Types_ContractDetails_ClearContractId"></a> ClearContractId\(\)

```csharp
public void ClearContractId()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Types_ContractDetails_ClearContractSlot"></a> ClearContractSlot\(\)

```csharp
public void ClearContractSlot()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Types_ContractDetails_ClearContractStars"></a> ClearContractStars\(\)

```csharp
public void ClearContractStars()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Types_ContractDetails_Clone"></a> Clone\(\)

```csharp
public CMsgServerToGCGetGuildContractsResponse.Types.ContractDetails Clone()
```

#### Returns

 [CMsgServerToGCGetGuildContractsResponse](Divine.Protobufs.Dota2.CMsgServerToGCGetGuildContractsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgServerToGCGetGuildContractsResponse.Types.md).[ContractDetails](Divine.Protobufs.Dota2.CMsgServerToGCGetGuildContractsResponse.Types.ContractDetails.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Types_ContractDetails_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Types_ContractDetails_Equals_Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Types_ContractDetails_"></a> Equals\(ContractDetails\)

```csharp
public bool Equals(CMsgServerToGCGetGuildContractsResponse.Types.ContractDetails other)
```

#### Parameters

`other` [CMsgServerToGCGetGuildContractsResponse](Divine.Protobufs.Dota2.CMsgServerToGCGetGuildContractsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgServerToGCGetGuildContractsResponse.Types.md).[ContractDetails](Divine.Protobufs.Dota2.CMsgServerToGCGetGuildContractsResponse.Types.ContractDetails.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Types_ContractDetails_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Types_ContractDetails_MergeFrom_Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Types_ContractDetails_"></a> MergeFrom\(ContractDetails\)

```csharp
public void MergeFrom(CMsgServerToGCGetGuildContractsResponse.Types.ContractDetails other)
```

#### Parameters

`other` [CMsgServerToGCGetGuildContractsResponse](Divine.Protobufs.Dota2.CMsgServerToGCGetGuildContractsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgServerToGCGetGuildContractsResponse.Types.md).[ContractDetails](Divine.Protobufs.Dota2.CMsgServerToGCGetGuildContractsResponse.Types.ContractDetails.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Types_ContractDetails_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Types_ContractDetails_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Types_ContractDetails_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

