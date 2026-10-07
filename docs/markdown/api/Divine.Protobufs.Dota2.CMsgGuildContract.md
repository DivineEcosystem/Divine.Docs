# <a id="Divine_Protobufs_Dota2_CMsgGuildContract"></a> Class CMsgGuildContract

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGuildContract : IMessage<CMsgGuildContract>, IEquatable<CMsgGuildContract>, IDeepCloneable<CMsgGuildContract>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGuildContract](Divine.Protobufs.Dota2.CMsgGuildContract.md)

#### Implements

IMessage<CMsgGuildContract\>, 
[IEquatable<CMsgGuildContract\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGuildContract\>, 
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
[EnumerableExtensions.In<CMsgGuildContract\>\(CMsgGuildContract, params CMsgGuildContract\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGuildContract__ctor"></a> CMsgGuildContract\(\)

```csharp
public CMsgGuildContract()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildContract__ctor_Divine_Protobufs_Dota2_CMsgGuildContract_"></a> CMsgGuildContract\(CMsgGuildContract\)

```csharp
public CMsgGuildContract(CMsgGuildContract other)
```

#### Parameters

`other` [CMsgGuildContract](Divine.Protobufs.Dota2.CMsgGuildContract.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGuildContract_AssignedAccountIdFieldNumber"></a> AssignedAccountIdFieldNumber

```csharp
public const int AssignedAccountIdFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildContract_ChallengeInstanceIdFieldNumber"></a> ChallengeInstanceIdFieldNumber

```csharp
public const int ChallengeInstanceIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildContract_ChallengeParameterFieldNumber"></a> ChallengeParameterFieldNumber

```csharp
public const int ChallengeParameterFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildContract_ChallengeTimestampFieldNumber"></a> ChallengeTimestampFieldNumber

```csharp
public const int ChallengeTimestampFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildContract_ContractFlagsFieldNumber"></a> ContractFlagsFieldNumber

```csharp
public const int ContractFlagsFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildContract_ContractIdFieldNumber"></a> ContractIdFieldNumber

```csharp
public const int ContractIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGuildContract_AssignedAccountId"></a> AssignedAccountId

```csharp
public uint AssignedAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildContract_ChallengeInstanceId"></a> ChallengeInstanceId

```csharp
public uint ChallengeInstanceId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildContract_ChallengeParameter"></a> ChallengeParameter

```csharp
public uint ChallengeParameter { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildContract_ChallengeTimestamp"></a> ChallengeTimestamp

```csharp
public uint ChallengeTimestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildContract_ContractFlags"></a> ContractFlags

```csharp
public uint ContractFlags { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildContract_ContractId"></a> ContractId

```csharp
public ulong ContractId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgGuildContract_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGuildContract_HasAssignedAccountId"></a> HasAssignedAccountId

```csharp
public bool HasAssignedAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildContract_HasChallengeInstanceId"></a> HasChallengeInstanceId

```csharp
public bool HasChallengeInstanceId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildContract_HasChallengeParameter"></a> HasChallengeParameter

```csharp
public bool HasChallengeParameter { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildContract_HasChallengeTimestamp"></a> HasChallengeTimestamp

```csharp
public bool HasChallengeTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildContract_HasContractFlags"></a> HasContractFlags

```csharp
public bool HasContractFlags { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildContract_HasContractId"></a> HasContractId

```csharp
public bool HasContractId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildContract_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGuildContract> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGuildContract](Divine.Protobufs.Dota2.CMsgGuildContract.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGuildContract_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildContract_ClearAssignedAccountId"></a> ClearAssignedAccountId\(\)

```csharp
public void ClearAssignedAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildContract_ClearChallengeInstanceId"></a> ClearChallengeInstanceId\(\)

```csharp
public void ClearChallengeInstanceId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildContract_ClearChallengeParameter"></a> ClearChallengeParameter\(\)

```csharp
public void ClearChallengeParameter()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildContract_ClearChallengeTimestamp"></a> ClearChallengeTimestamp\(\)

```csharp
public void ClearChallengeTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildContract_ClearContractFlags"></a> ClearContractFlags\(\)

```csharp
public void ClearContractFlags()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildContract_ClearContractId"></a> ClearContractId\(\)

```csharp
public void ClearContractId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildContract_Clone"></a> Clone\(\)

```csharp
public CMsgGuildContract Clone()
```

#### Returns

 [CMsgGuildContract](Divine.Protobufs.Dota2.CMsgGuildContract.md)

### <a id="Divine_Protobufs_Dota2_CMsgGuildContract_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildContract_Equals_Divine_Protobufs_Dota2_CMsgGuildContract_"></a> Equals\(CMsgGuildContract\)

```csharp
public bool Equals(CMsgGuildContract other)
```

#### Parameters

`other` [CMsgGuildContract](Divine.Protobufs.Dota2.CMsgGuildContract.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildContract_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildContract_MergeFrom_Divine_Protobufs_Dota2_CMsgGuildContract_"></a> MergeFrom\(CMsgGuildContract\)

```csharp
public void MergeFrom(CMsgGuildContract other)
```

#### Parameters

`other` [CMsgGuildContract](Divine.Protobufs.Dota2.CMsgGuildContract.md)

### <a id="Divine_Protobufs_Dota2_CMsgGuildContract_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGuildContract_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGuildContract_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

