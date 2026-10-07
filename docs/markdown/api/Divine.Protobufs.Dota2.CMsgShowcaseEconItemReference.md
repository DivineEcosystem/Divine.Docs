# <a id="Divine_Protobufs_Dota2_CMsgShowcaseEconItemReference"></a> Class CMsgShowcaseEconItemReference

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgShowcaseEconItemReference : IMessage<CMsgShowcaseEconItemReference>, IEquatable<CMsgShowcaseEconItemReference>, IDeepCloneable<CMsgShowcaseEconItemReference>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgShowcaseEconItemReference](Divine.Protobufs.Dota2.CMsgShowcaseEconItemReference.md)

#### Implements

IMessage<CMsgShowcaseEconItemReference\>, 
[IEquatable<CMsgShowcaseEconItemReference\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgShowcaseEconItemReference\>, 
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
[EnumerableExtensions.In<CMsgShowcaseEconItemReference\>\(CMsgShowcaseEconItemReference, params CMsgShowcaseEconItemReference\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseEconItemReference__ctor"></a> CMsgShowcaseEconItemReference\(\)

```csharp
public CMsgShowcaseEconItemReference()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseEconItemReference__ctor_Divine_Protobufs_Dota2_CMsgShowcaseEconItemReference_"></a> CMsgShowcaseEconItemReference\(CMsgShowcaseEconItemReference\)

```csharp
public CMsgShowcaseEconItemReference(CMsgShowcaseEconItemReference other)
```

#### Parameters

`other` [CMsgShowcaseEconItemReference](Divine.Protobufs.Dota2.CMsgShowcaseEconItemReference.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseEconItemReference_DefinitionIndexFieldNumber"></a> DefinitionIndexFieldNumber

```csharp
public const int DefinitionIndexFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseEconItemReference_EquipmentSlotIndexFieldNumber"></a> EquipmentSlotIndexFieldNumber

```csharp
public const int EquipmentSlotIndexFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseEconItemReference_IdFieldNumber"></a> IdFieldNumber

```csharp
public const int IdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseEconItemReference_OriginalIdFieldNumber"></a> OriginalIdFieldNumber

```csharp
public const int OriginalIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseEconItemReference_DefinitionIndex"></a> DefinitionIndex

```csharp
public uint DefinitionIndex { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseEconItemReference_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseEconItemReference_EquipmentSlotIndex"></a> EquipmentSlotIndex

```csharp
public int EquipmentSlotIndex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseEconItemReference_HasDefinitionIndex"></a> HasDefinitionIndex

```csharp
public bool HasDefinitionIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseEconItemReference_HasEquipmentSlotIndex"></a> HasEquipmentSlotIndex

```csharp
public bool HasEquipmentSlotIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseEconItemReference_HasId"></a> HasId

```csharp
public bool HasId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseEconItemReference_HasOriginalId"></a> HasOriginalId

```csharp
public bool HasOriginalId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseEconItemReference_Id"></a> Id

```csharp
public ulong Id { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseEconItemReference_OriginalId"></a> OriginalId

```csharp
public ulong OriginalId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseEconItemReference_Parser"></a> Parser

```csharp
public static MessageParser<CMsgShowcaseEconItemReference> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgShowcaseEconItemReference](Divine.Protobufs.Dota2.CMsgShowcaseEconItemReference.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseEconItemReference_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseEconItemReference_ClearDefinitionIndex"></a> ClearDefinitionIndex\(\)

```csharp
public void ClearDefinitionIndex()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseEconItemReference_ClearEquipmentSlotIndex"></a> ClearEquipmentSlotIndex\(\)

```csharp
public void ClearEquipmentSlotIndex()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseEconItemReference_ClearId"></a> ClearId\(\)

```csharp
public void ClearId()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseEconItemReference_ClearOriginalId"></a> ClearOriginalId\(\)

```csharp
public void ClearOriginalId()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseEconItemReference_Clone"></a> Clone\(\)

```csharp
public CMsgShowcaseEconItemReference Clone()
```

#### Returns

 [CMsgShowcaseEconItemReference](Divine.Protobufs.Dota2.CMsgShowcaseEconItemReference.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseEconItemReference_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseEconItemReference_Equals_Divine_Protobufs_Dota2_CMsgShowcaseEconItemReference_"></a> Equals\(CMsgShowcaseEconItemReference\)

```csharp
public bool Equals(CMsgShowcaseEconItemReference other)
```

#### Parameters

`other` [CMsgShowcaseEconItemReference](Divine.Protobufs.Dota2.CMsgShowcaseEconItemReference.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseEconItemReference_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseEconItemReference_MergeFrom_Divine_Protobufs_Dota2_CMsgShowcaseEconItemReference_"></a> MergeFrom\(CMsgShowcaseEconItemReference\)

```csharp
public void MergeFrom(CMsgShowcaseEconItemReference other)
```

#### Parameters

`other` [CMsgShowcaseEconItemReference](Divine.Protobufs.Dota2.CMsgShowcaseEconItemReference.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseEconItemReference_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseEconItemReference_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseEconItemReference_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

