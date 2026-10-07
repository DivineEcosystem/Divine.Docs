# <a id="Divine_Protobufs_Dota2_CMsgGuildActiveContracts"></a> Class CMsgGuildActiveContracts

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGuildActiveContracts : IMessage<CMsgGuildActiveContracts>, IEquatable<CMsgGuildActiveContracts>, IDeepCloneable<CMsgGuildActiveContracts>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGuildActiveContracts](Divine.Protobufs.Dota2.CMsgGuildActiveContracts.md)

#### Implements

IMessage<CMsgGuildActiveContracts\>, 
[IEquatable<CMsgGuildActiveContracts\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGuildActiveContracts\>, 
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
[EnumerableExtensions.In<CMsgGuildActiveContracts\>\(CMsgGuildActiveContracts, params CMsgGuildActiveContracts\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGuildActiveContracts__ctor"></a> CMsgGuildActiveContracts\(\)

```csharp
public CMsgGuildActiveContracts()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildActiveContracts__ctor_Divine_Protobufs_Dota2_CMsgGuildActiveContracts_"></a> CMsgGuildActiveContracts\(CMsgGuildActiveContracts\)

```csharp
public CMsgGuildActiveContracts(CMsgGuildActiveContracts other)
```

#### Parameters

`other` [CMsgGuildActiveContracts](Divine.Protobufs.Dota2.CMsgGuildActiveContracts.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGuildActiveContracts_ContractsFieldNumber"></a> ContractsFieldNumber

```csharp
public const int ContractsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildActiveContracts_ContractsRefreshedTimestampFieldNumber"></a> ContractsRefreshedTimestampFieldNumber

```csharp
public const int ContractsRefreshedTimestampFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGuildActiveContracts_Contracts"></a> Contracts

```csharp
public RepeatedField<CMsgGuildContract> Contracts { get; }
```

#### Property Value

 RepeatedField<[CMsgGuildContract](Divine.Protobufs.Dota2.CMsgGuildContract.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGuildActiveContracts_ContractsRefreshedTimestamp"></a> ContractsRefreshedTimestamp

```csharp
public uint ContractsRefreshedTimestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildActiveContracts_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGuildActiveContracts_HasContractsRefreshedTimestamp"></a> HasContractsRefreshedTimestamp

```csharp
public bool HasContractsRefreshedTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildActiveContracts_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGuildActiveContracts> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGuildActiveContracts](Divine.Protobufs.Dota2.CMsgGuildActiveContracts.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGuildActiveContracts_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildActiveContracts_ClearContractsRefreshedTimestamp"></a> ClearContractsRefreshedTimestamp\(\)

```csharp
public void ClearContractsRefreshedTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildActiveContracts_Clone"></a> Clone\(\)

```csharp
public CMsgGuildActiveContracts Clone()
```

#### Returns

 [CMsgGuildActiveContracts](Divine.Protobufs.Dota2.CMsgGuildActiveContracts.md)

### <a id="Divine_Protobufs_Dota2_CMsgGuildActiveContracts_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildActiveContracts_Equals_Divine_Protobufs_Dota2_CMsgGuildActiveContracts_"></a> Equals\(CMsgGuildActiveContracts\)

```csharp
public bool Equals(CMsgGuildActiveContracts other)
```

#### Parameters

`other` [CMsgGuildActiveContracts](Divine.Protobufs.Dota2.CMsgGuildActiveContracts.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildActiveContracts_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildActiveContracts_MergeFrom_Divine_Protobufs_Dota2_CMsgGuildActiveContracts_"></a> MergeFrom\(CMsgGuildActiveContracts\)

```csharp
public void MergeFrom(CMsgGuildActiveContracts other)
```

#### Parameters

`other` [CMsgGuildActiveContracts](Divine.Protobufs.Dota2.CMsgGuildActiveContracts.md)

### <a id="Divine_Protobufs_Dota2_CMsgGuildActiveContracts_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGuildActiveContracts_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGuildActiveContracts_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

