# <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_Types_alternate_baseline_t"></a> Class CSVCMsg\_PacketEntities.Types.alternate\_baseline\_t

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSVCMsg_PacketEntities.Types.alternate_baseline_t : IMessage<CSVCMsg_PacketEntities.Types.alternate_baseline_t>, IEquatable<CSVCMsg_PacketEntities.Types.alternate_baseline_t>, IDeepCloneable<CSVCMsg_PacketEntities.Types.alternate_baseline_t>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSVCMsg\_PacketEntities.Types.alternate\_baseline\_t](Divine.Protobufs.Dota2.CSVCMsg\_PacketEntities.Types.alternate\_baseline\_t.md)

#### Implements

IMessage<CSVCMsg\_PacketEntities.Types.alternate\_baseline\_t\>, 
[IEquatable<CSVCMsg\_PacketEntities.Types.alternate\_baseline\_t\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSVCMsg\_PacketEntities.Types.alternate\_baseline\_t\>, 
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
[EnumerableExtensions.In<CSVCMsg\_PacketEntities.Types.alternate\_baseline\_t\>\(CSVCMsg\_PacketEntities.Types.alternate\_baseline\_t, params CSVCMsg\_PacketEntities.Types.alternate\_baseline\_t\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_Types_alternate_baseline_t__ctor"></a> alternate\_baseline\_t\(\)

```csharp
public alternate_baseline_t()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_Types_alternate_baseline_t__ctor_Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_Types_alternate_baseline_t_"></a> alternate\_baseline\_t\(alternate\_baseline\_t\)

```csharp
public alternate_baseline_t(CSVCMsg_PacketEntities.Types.alternate_baseline_t other)
```

#### Parameters

`other` [CSVCMsg\_PacketEntities](Divine.Protobufs.Dota2.CSVCMsg\_PacketEntities.md).[Types](Divine.Protobufs.Dota2.CSVCMsg\_PacketEntities.Types.md).[alternate\_baseline\_t](Divine.Protobufs.Dota2.CSVCMsg\_PacketEntities.Types.alternate\_baseline\_t.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_Types_alternate_baseline_t_BaselineIndexFieldNumber"></a> BaselineIndexFieldNumber

```csharp
public const int BaselineIndexFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_Types_alternate_baseline_t_EntityIndexFieldNumber"></a> EntityIndexFieldNumber

```csharp
public const int EntityIndexFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_Types_alternate_baseline_t_BaselineIndex"></a> BaselineIndex

```csharp
public int BaselineIndex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_Types_alternate_baseline_t_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_Types_alternate_baseline_t_EntityIndex"></a> EntityIndex

```csharp
public int EntityIndex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_Types_alternate_baseline_t_HasBaselineIndex"></a> HasBaselineIndex

```csharp
public bool HasBaselineIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_Types_alternate_baseline_t_HasEntityIndex"></a> HasEntityIndex

```csharp
public bool HasEntityIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_Types_alternate_baseline_t_Parser"></a> Parser

```csharp
public static MessageParser<CSVCMsg_PacketEntities.Types.alternate_baseline_t> Parser { get; }
```

#### Property Value

 MessageParser<[CSVCMsg\_PacketEntities](Divine.Protobufs.Dota2.CSVCMsg\_PacketEntities.md).[Types](Divine.Protobufs.Dota2.CSVCMsg\_PacketEntities.Types.md).[alternate\_baseline\_t](Divine.Protobufs.Dota2.CSVCMsg\_PacketEntities.Types.alternate\_baseline\_t.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_Types_alternate_baseline_t_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_Types_alternate_baseline_t_ClearBaselineIndex"></a> ClearBaselineIndex\(\)

```csharp
public void ClearBaselineIndex()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_Types_alternate_baseline_t_ClearEntityIndex"></a> ClearEntityIndex\(\)

```csharp
public void ClearEntityIndex()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_Types_alternate_baseline_t_Clone"></a> Clone\(\)

```csharp
public CSVCMsg_PacketEntities.Types.alternate_baseline_t Clone()
```

#### Returns

 [CSVCMsg\_PacketEntities](Divine.Protobufs.Dota2.CSVCMsg\_PacketEntities.md).[Types](Divine.Protobufs.Dota2.CSVCMsg\_PacketEntities.Types.md).[alternate\_baseline\_t](Divine.Protobufs.Dota2.CSVCMsg\_PacketEntities.Types.alternate\_baseline\_t.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_Types_alternate_baseline_t_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_Types_alternate_baseline_t_Equals_Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_Types_alternate_baseline_t_"></a> Equals\(alternate\_baseline\_t\)

```csharp
public bool Equals(CSVCMsg_PacketEntities.Types.alternate_baseline_t other)
```

#### Parameters

`other` [CSVCMsg\_PacketEntities](Divine.Protobufs.Dota2.CSVCMsg\_PacketEntities.md).[Types](Divine.Protobufs.Dota2.CSVCMsg\_PacketEntities.Types.md).[alternate\_baseline\_t](Divine.Protobufs.Dota2.CSVCMsg\_PacketEntities.Types.alternate\_baseline\_t.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_Types_alternate_baseline_t_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_Types_alternate_baseline_t_MergeFrom_Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_Types_alternate_baseline_t_"></a> MergeFrom\(alternate\_baseline\_t\)

```csharp
public void MergeFrom(CSVCMsg_PacketEntities.Types.alternate_baseline_t other)
```

#### Parameters

`other` [CSVCMsg\_PacketEntities](Divine.Protobufs.Dota2.CSVCMsg\_PacketEntities.md).[Types](Divine.Protobufs.Dota2.CSVCMsg\_PacketEntities.Types.md).[alternate\_baseline\_t](Divine.Protobufs.Dota2.CSVCMsg\_PacketEntities.Types.alternate\_baseline\_t.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_Types_alternate_baseline_t_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_Types_alternate_baseline_t_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_PacketEntities_Types_alternate_baseline_t_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

