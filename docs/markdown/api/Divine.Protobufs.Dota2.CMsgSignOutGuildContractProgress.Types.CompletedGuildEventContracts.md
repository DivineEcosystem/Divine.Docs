# <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildContractProgress_Types_CompletedGuildEventContracts"></a> Class CMsgSignOutGuildContractProgress.Types.CompletedGuildEventContracts

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSignOutGuildContractProgress.Types.CompletedGuildEventContracts : IMessage<CMsgSignOutGuildContractProgress.Types.CompletedGuildEventContracts>, IEquatable<CMsgSignOutGuildContractProgress.Types.CompletedGuildEventContracts>, IDeepCloneable<CMsgSignOutGuildContractProgress.Types.CompletedGuildEventContracts>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSignOutGuildContractProgress.Types.CompletedGuildEventContracts](Divine.Protobufs.Dota2.CMsgSignOutGuildContractProgress.Types.CompletedGuildEventContracts.md)

#### Implements

IMessage<CMsgSignOutGuildContractProgress.Types.CompletedGuildEventContracts\>, 
[IEquatable<CMsgSignOutGuildContractProgress.Types.CompletedGuildEventContracts\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSignOutGuildContractProgress.Types.CompletedGuildEventContracts\>, 
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
[EnumerableExtensions.In<CMsgSignOutGuildContractProgress.Types.CompletedGuildEventContracts\>\(CMsgSignOutGuildContractProgress.Types.CompletedGuildEventContracts, params CMsgSignOutGuildContractProgress.Types.CompletedGuildEventContracts\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildContractProgress_Types_CompletedGuildEventContracts__ctor"></a> CompletedGuildEventContracts\(\)

```csharp
public CompletedGuildEventContracts()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildContractProgress_Types_CompletedGuildEventContracts__ctor_Divine_Protobufs_Dota2_CMsgSignOutGuildContractProgress_Types_CompletedGuildEventContracts_"></a> CompletedGuildEventContracts\(CompletedGuildEventContracts\)

```csharp
public CompletedGuildEventContracts(CMsgSignOutGuildContractProgress.Types.CompletedGuildEventContracts other)
```

#### Parameters

`other` [CMsgSignOutGuildContractProgress](Divine.Protobufs.Dota2.CMsgSignOutGuildContractProgress.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutGuildContractProgress.Types.md).[CompletedGuildEventContracts](Divine.Protobufs.Dota2.CMsgSignOutGuildContractProgress.Types.CompletedGuildEventContracts.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildContractProgress_Types_CompletedGuildEventContracts_ContractsFieldNumber"></a> ContractsFieldNumber

```csharp
public const int ContractsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildContractProgress_Types_CompletedGuildEventContracts_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildContractProgress_Types_CompletedGuildEventContracts_GuildIdFieldNumber"></a> GuildIdFieldNumber

```csharp
public const int GuildIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildContractProgress_Types_CompletedGuildEventContracts_Contracts"></a> Contracts

```csharp
public RepeatedField<ulong> Contracts { get; }
```

#### Property Value

 RepeatedField<[ulong](https://learn.microsoft.com/dotnet/api/system.uint64)\>

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildContractProgress_Types_CompletedGuildEventContracts_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildContractProgress_Types_CompletedGuildEventContracts_EventId"></a> EventId

```csharp
public uint EventId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildContractProgress_Types_CompletedGuildEventContracts_GuildId"></a> GuildId

```csharp
public uint GuildId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildContractProgress_Types_CompletedGuildEventContracts_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildContractProgress_Types_CompletedGuildEventContracts_HasGuildId"></a> HasGuildId

```csharp
public bool HasGuildId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildContractProgress_Types_CompletedGuildEventContracts_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSignOutGuildContractProgress.Types.CompletedGuildEventContracts> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSignOutGuildContractProgress](Divine.Protobufs.Dota2.CMsgSignOutGuildContractProgress.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutGuildContractProgress.Types.md).[CompletedGuildEventContracts](Divine.Protobufs.Dota2.CMsgSignOutGuildContractProgress.Types.CompletedGuildEventContracts.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildContractProgress_Types_CompletedGuildEventContracts_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildContractProgress_Types_CompletedGuildEventContracts_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildContractProgress_Types_CompletedGuildEventContracts_ClearGuildId"></a> ClearGuildId\(\)

```csharp
public void ClearGuildId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildContractProgress_Types_CompletedGuildEventContracts_Clone"></a> Clone\(\)

```csharp
public CMsgSignOutGuildContractProgress.Types.CompletedGuildEventContracts Clone()
```

#### Returns

 [CMsgSignOutGuildContractProgress](Divine.Protobufs.Dota2.CMsgSignOutGuildContractProgress.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutGuildContractProgress.Types.md).[CompletedGuildEventContracts](Divine.Protobufs.Dota2.CMsgSignOutGuildContractProgress.Types.CompletedGuildEventContracts.md)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildContractProgress_Types_CompletedGuildEventContracts_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildContractProgress_Types_CompletedGuildEventContracts_Equals_Divine_Protobufs_Dota2_CMsgSignOutGuildContractProgress_Types_CompletedGuildEventContracts_"></a> Equals\(CompletedGuildEventContracts\)

```csharp
public bool Equals(CMsgSignOutGuildContractProgress.Types.CompletedGuildEventContracts other)
```

#### Parameters

`other` [CMsgSignOutGuildContractProgress](Divine.Protobufs.Dota2.CMsgSignOutGuildContractProgress.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutGuildContractProgress.Types.md).[CompletedGuildEventContracts](Divine.Protobufs.Dota2.CMsgSignOutGuildContractProgress.Types.CompletedGuildEventContracts.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildContractProgress_Types_CompletedGuildEventContracts_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildContractProgress_Types_CompletedGuildEventContracts_MergeFrom_Divine_Protobufs_Dota2_CMsgSignOutGuildContractProgress_Types_CompletedGuildEventContracts_"></a> MergeFrom\(CompletedGuildEventContracts\)

```csharp
public void MergeFrom(CMsgSignOutGuildContractProgress.Types.CompletedGuildEventContracts other)
```

#### Parameters

`other` [CMsgSignOutGuildContractProgress](Divine.Protobufs.Dota2.CMsgSignOutGuildContractProgress.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutGuildContractProgress.Types.md).[CompletedGuildEventContracts](Divine.Protobufs.Dota2.CMsgSignOutGuildContractProgress.Types.CompletedGuildEventContracts.md)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildContractProgress_Types_CompletedGuildEventContracts_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildContractProgress_Types_CompletedGuildEventContracts_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGuildContractProgress_Types_CompletedGuildEventContracts_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

