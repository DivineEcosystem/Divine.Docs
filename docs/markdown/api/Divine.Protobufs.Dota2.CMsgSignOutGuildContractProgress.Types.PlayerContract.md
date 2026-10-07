# <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildContractProgress_Types_PlayerContract"></a> Class CMsgSignOutGuildContractProgress.Types.PlayerContract

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSignOutGuildContractProgress.Types.PlayerContract : IMessage<CMsgSignOutGuildContractProgress.Types.PlayerContract>, IEquatable<CMsgSignOutGuildContractProgress.Types.PlayerContract>, IDeepCloneable<CMsgSignOutGuildContractProgress.Types.PlayerContract>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSignOutGuildContractProgress.Types.PlayerContract](Divine.Protobufs.Dota2.CMsgSignOutGuildContractProgress.Types.PlayerContract.md)

#### Implements

IMessage<CMsgSignOutGuildContractProgress.Types.PlayerContract\>, 
[IEquatable<CMsgSignOutGuildContractProgress.Types.PlayerContract\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSignOutGuildContractProgress.Types.PlayerContract\>, 
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
[EnumerableExtensions.In<CMsgSignOutGuildContractProgress.Types.PlayerContract\>\(CMsgSignOutGuildContractProgress.Types.PlayerContract, params CMsgSignOutGuildContractProgress.Types.PlayerContract\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildContractProgress_Types_PlayerContract__ctor"></a> PlayerContract\(\)

```csharp
public PlayerContract()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildContractProgress_Types_PlayerContract__ctor_Divine_Protobufs_Dota2_CMsgSignOutGuildContractProgress_Types_PlayerContract_"></a> PlayerContract\(PlayerContract\)

```csharp
public PlayerContract(CMsgSignOutGuildContractProgress.Types.PlayerContract other)
```

#### Parameters

`other` [CMsgSignOutGuildContractProgress](Divine.Protobufs.Dota2.CMsgSignOutGuildContractProgress.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutGuildContractProgress.Types.md).[PlayerContract](Divine.Protobufs.Dota2.CMsgSignOutGuildContractProgress.Types.PlayerContract.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildContractProgress_Types_PlayerContract_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildContractProgress_Types_PlayerContract_CompletedContractsFieldNumber"></a> CompletedContractsFieldNumber

```csharp
public const int CompletedContractsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildContractProgress_Types_PlayerContract_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildContractProgress_Types_PlayerContract_CompletedContracts"></a> CompletedContracts

```csharp
public RepeatedField<CMsgSignOutGuildContractProgress.Types.CompletedGuildEventContracts> CompletedContracts { get; }
```

#### Property Value

 RepeatedField<[CMsgSignOutGuildContractProgress](Divine.Protobufs.Dota2.CMsgSignOutGuildContractProgress.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutGuildContractProgress.Types.md).[CompletedGuildEventContracts](Divine.Protobufs.Dota2.CMsgSignOutGuildContractProgress.Types.CompletedGuildEventContracts.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildContractProgress_Types_PlayerContract_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildContractProgress_Types_PlayerContract_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildContractProgress_Types_PlayerContract_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSignOutGuildContractProgress.Types.PlayerContract> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSignOutGuildContractProgress](Divine.Protobufs.Dota2.CMsgSignOutGuildContractProgress.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutGuildContractProgress.Types.md).[PlayerContract](Divine.Protobufs.Dota2.CMsgSignOutGuildContractProgress.Types.PlayerContract.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildContractProgress_Types_PlayerContract_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildContractProgress_Types_PlayerContract_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildContractProgress_Types_PlayerContract_Clone"></a> Clone\(\)

```csharp
public CMsgSignOutGuildContractProgress.Types.PlayerContract Clone()
```

#### Returns

 [CMsgSignOutGuildContractProgress](Divine.Protobufs.Dota2.CMsgSignOutGuildContractProgress.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutGuildContractProgress.Types.md).[PlayerContract](Divine.Protobufs.Dota2.CMsgSignOutGuildContractProgress.Types.PlayerContract.md)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildContractProgress_Types_PlayerContract_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildContractProgress_Types_PlayerContract_Equals_Divine_Protobufs_Dota2_CMsgSignOutGuildContractProgress_Types_PlayerContract_"></a> Equals\(PlayerContract\)

```csharp
public bool Equals(CMsgSignOutGuildContractProgress.Types.PlayerContract other)
```

#### Parameters

`other` [CMsgSignOutGuildContractProgress](Divine.Protobufs.Dota2.CMsgSignOutGuildContractProgress.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutGuildContractProgress.Types.md).[PlayerContract](Divine.Protobufs.Dota2.CMsgSignOutGuildContractProgress.Types.PlayerContract.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildContractProgress_Types_PlayerContract_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildContractProgress_Types_PlayerContract_MergeFrom_Divine_Protobufs_Dota2_CMsgSignOutGuildContractProgress_Types_PlayerContract_"></a> MergeFrom\(PlayerContract\)

```csharp
public void MergeFrom(CMsgSignOutGuildContractProgress.Types.PlayerContract other)
```

#### Parameters

`other` [CMsgSignOutGuildContractProgress](Divine.Protobufs.Dota2.CMsgSignOutGuildContractProgress.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutGuildContractProgress.Types.md).[PlayerContract](Divine.Protobufs.Dota2.CMsgSignOutGuildContractProgress.Types.PlayerContract.md)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildContractProgress_Types_PlayerContract_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildContractProgress_Types_PlayerContract_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildContractProgress_Types_PlayerContract_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

