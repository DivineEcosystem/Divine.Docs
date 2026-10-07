# <a id="Divine_Protobufs_Dota2_CMsgGuildContractSlot"></a> Class CMsgGuildContractSlot

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGuildContractSlot : IMessage<CMsgGuildContractSlot>, IEquatable<CMsgGuildContractSlot>, IDeepCloneable<CMsgGuildContractSlot>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGuildContractSlot](Divine.Protobufs.Dota2.CMsgGuildContractSlot.md)

#### Implements

IMessage<CMsgGuildContractSlot\>, 
[IEquatable<CMsgGuildContractSlot\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGuildContractSlot\>, 
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
[EnumerableExtensions.In<CMsgGuildContractSlot\>\(CMsgGuildContractSlot, params CMsgGuildContractSlot\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGuildContractSlot__ctor"></a> CMsgGuildContractSlot\(\)

```csharp
public CMsgGuildContractSlot()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildContractSlot__ctor_Divine_Protobufs_Dota2_CMsgGuildContractSlot_"></a> CMsgGuildContractSlot\(CMsgGuildContractSlot\)

```csharp
public CMsgGuildContractSlot(CMsgGuildContractSlot other)
```

#### Parameters

`other` [CMsgGuildContractSlot](Divine.Protobufs.Dota2.CMsgGuildContractSlot.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGuildContractSlot_ContractFieldNumber"></a> ContractFieldNumber

```csharp
public const int ContractFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGuildContractSlot_Contract"></a> Contract

```csharp
public CMsgGuildContract Contract { get; set; }
```

#### Property Value

 [CMsgGuildContract](Divine.Protobufs.Dota2.CMsgGuildContract.md)

### <a id="Divine_Protobufs_Dota2_CMsgGuildContractSlot_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGuildContractSlot_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGuildContractSlot> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGuildContractSlot](Divine.Protobufs.Dota2.CMsgGuildContractSlot.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGuildContractSlot_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildContractSlot_Clone"></a> Clone\(\)

```csharp
public CMsgGuildContractSlot Clone()
```

#### Returns

 [CMsgGuildContractSlot](Divine.Protobufs.Dota2.CMsgGuildContractSlot.md)

### <a id="Divine_Protobufs_Dota2_CMsgGuildContractSlot_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildContractSlot_Equals_Divine_Protobufs_Dota2_CMsgGuildContractSlot_"></a> Equals\(CMsgGuildContractSlot\)

```csharp
public bool Equals(CMsgGuildContractSlot other)
```

#### Parameters

`other` [CMsgGuildContractSlot](Divine.Protobufs.Dota2.CMsgGuildContractSlot.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildContractSlot_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildContractSlot_MergeFrom_Divine_Protobufs_Dota2_CMsgGuildContractSlot_"></a> MergeFrom\(CMsgGuildContractSlot\)

```csharp
public void MergeFrom(CMsgGuildContractSlot other)
```

#### Parameters

`other` [CMsgGuildContractSlot](Divine.Protobufs.Dota2.CMsgGuildContractSlot.md)

### <a id="Divine_Protobufs_Dota2_CMsgGuildContractSlot_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGuildContractSlot_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGuildContractSlot_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

