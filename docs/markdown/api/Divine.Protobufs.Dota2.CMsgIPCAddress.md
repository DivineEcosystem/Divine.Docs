# <a id="Divine_Protobufs_Dota2_CMsgIPCAddress"></a> Class CMsgIPCAddress

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgIPCAddress : IMessage<CMsgIPCAddress>, IEquatable<CMsgIPCAddress>, IDeepCloneable<CMsgIPCAddress>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgIPCAddress](Divine.Protobufs.Dota2.CMsgIPCAddress.md)

#### Implements

IMessage<CMsgIPCAddress\>, 
[IEquatable<CMsgIPCAddress\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgIPCAddress\>, 
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
[EnumerableExtensions.In<CMsgIPCAddress\>\(CMsgIPCAddress, params CMsgIPCAddress\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgIPCAddress__ctor"></a> CMsgIPCAddress\(\)

```csharp
public CMsgIPCAddress()
```

### <a id="Divine_Protobufs_Dota2_CMsgIPCAddress__ctor_Divine_Protobufs_Dota2_CMsgIPCAddress_"></a> CMsgIPCAddress\(CMsgIPCAddress\)

```csharp
public CMsgIPCAddress(CMsgIPCAddress other)
```

#### Parameters

`other` [CMsgIPCAddress](Divine.Protobufs.Dota2.CMsgIPCAddress.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgIPCAddress_ComputerGuidFieldNumber"></a> ComputerGuidFieldNumber

```csharp
public const int ComputerGuidFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgIPCAddress_ProcessIdFieldNumber"></a> ProcessIdFieldNumber

```csharp
public const int ProcessIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgIPCAddress_ComputerGuid"></a> ComputerGuid

```csharp
public ulong ComputerGuid { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgIPCAddress_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgIPCAddress_HasComputerGuid"></a> HasComputerGuid

```csharp
public bool HasComputerGuid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgIPCAddress_HasProcessId"></a> HasProcessId

```csharp
public bool HasProcessId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgIPCAddress_Parser"></a> Parser

```csharp
public static MessageParser<CMsgIPCAddress> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgIPCAddress](Divine.Protobufs.Dota2.CMsgIPCAddress.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgIPCAddress_ProcessId"></a> ProcessId

```csharp
public uint ProcessId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgIPCAddress_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgIPCAddress_ClearComputerGuid"></a> ClearComputerGuid\(\)

```csharp
public void ClearComputerGuid()
```

### <a id="Divine_Protobufs_Dota2_CMsgIPCAddress_ClearProcessId"></a> ClearProcessId\(\)

```csharp
public void ClearProcessId()
```

### <a id="Divine_Protobufs_Dota2_CMsgIPCAddress_Clone"></a> Clone\(\)

```csharp
public CMsgIPCAddress Clone()
```

#### Returns

 [CMsgIPCAddress](Divine.Protobufs.Dota2.CMsgIPCAddress.md)

### <a id="Divine_Protobufs_Dota2_CMsgIPCAddress_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgIPCAddress_Equals_Divine_Protobufs_Dota2_CMsgIPCAddress_"></a> Equals\(CMsgIPCAddress\)

```csharp
public bool Equals(CMsgIPCAddress other)
```

#### Parameters

`other` [CMsgIPCAddress](Divine.Protobufs.Dota2.CMsgIPCAddress.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgIPCAddress_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgIPCAddress_MergeFrom_Divine_Protobufs_Dota2_CMsgIPCAddress_"></a> MergeFrom\(CMsgIPCAddress\)

```csharp
public void MergeFrom(CMsgIPCAddress other)
```

#### Parameters

`other` [CMsgIPCAddress](Divine.Protobufs.Dota2.CMsgIPCAddress.md)

### <a id="Divine_Protobufs_Dota2_CMsgIPCAddress_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgIPCAddress_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgIPCAddress_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

