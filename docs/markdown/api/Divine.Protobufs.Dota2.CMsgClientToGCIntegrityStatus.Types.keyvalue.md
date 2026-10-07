# <a id="Divine_Protobufs_Dota2_CMsgClientToGCIntegrityStatus_Types_keyvalue"></a> Class CMsgClientToGCIntegrityStatus.Types.keyvalue

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCIntegrityStatus.Types.keyvalue : IMessage<CMsgClientToGCIntegrityStatus.Types.keyvalue>, IEquatable<CMsgClientToGCIntegrityStatus.Types.keyvalue>, IDeepCloneable<CMsgClientToGCIntegrityStatus.Types.keyvalue>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCIntegrityStatus.Types.keyvalue](Divine.Protobufs.Dota2.CMsgClientToGCIntegrityStatus.Types.keyvalue.md)

#### Implements

IMessage<CMsgClientToGCIntegrityStatus.Types.keyvalue\>, 
[IEquatable<CMsgClientToGCIntegrityStatus.Types.keyvalue\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCIntegrityStatus.Types.keyvalue\>, 
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
[EnumerableExtensions.In<CMsgClientToGCIntegrityStatus.Types.keyvalue\>\(CMsgClientToGCIntegrityStatus.Types.keyvalue, params CMsgClientToGCIntegrityStatus.Types.keyvalue\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCIntegrityStatus_Types_keyvalue__ctor"></a> keyvalue\(\)

```csharp
public keyvalue()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCIntegrityStatus_Types_keyvalue__ctor_Divine_Protobufs_Dota2_CMsgClientToGCIntegrityStatus_Types_keyvalue_"></a> keyvalue\(keyvalue\)

```csharp
public keyvalue(CMsgClientToGCIntegrityStatus.Types.keyvalue other)
```

#### Parameters

`other` [CMsgClientToGCIntegrityStatus](Divine.Protobufs.Dota2.CMsgClientToGCIntegrityStatus.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCIntegrityStatus.Types.md).[keyvalue](Divine.Protobufs.Dota2.CMsgClientToGCIntegrityStatus.Types.keyvalue.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCIntegrityStatus_Types_keyvalue_ExtendedFieldNumber"></a> ExtendedFieldNumber

```csharp
public const int ExtendedFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCIntegrityStatus_Types_keyvalue_IdFieldNumber"></a> IdFieldNumber

```csharp
public const int IdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCIntegrityStatus_Types_keyvalue_StringValueFieldNumber"></a> StringValueFieldNumber

```csharp
public const int StringValueFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCIntegrityStatus_Types_keyvalue_ValueFieldNumber"></a> ValueFieldNumber

```csharp
public const int ValueFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCIntegrityStatus_Types_keyvalue_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCIntegrityStatus_Types_keyvalue_Extended"></a> Extended

```csharp
public uint Extended { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCIntegrityStatus_Types_keyvalue_HasExtended"></a> HasExtended

```csharp
public bool HasExtended { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCIntegrityStatus_Types_keyvalue_HasId"></a> HasId

```csharp
public bool HasId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCIntegrityStatus_Types_keyvalue_HasStringValue"></a> HasStringValue

```csharp
public bool HasStringValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCIntegrityStatus_Types_keyvalue_HasValue"></a> HasValue

```csharp
public bool HasValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCIntegrityStatus_Types_keyvalue_Id"></a> Id

```csharp
public uint Id { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCIntegrityStatus_Types_keyvalue_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCIntegrityStatus.Types.keyvalue> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCIntegrityStatus](Divine.Protobufs.Dota2.CMsgClientToGCIntegrityStatus.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCIntegrityStatus.Types.md).[keyvalue](Divine.Protobufs.Dota2.CMsgClientToGCIntegrityStatus.Types.keyvalue.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCIntegrityStatus_Types_keyvalue_StringValue"></a> StringValue

```csharp
public string StringValue { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCIntegrityStatus_Types_keyvalue_Value"></a> Value

```csharp
public ulong Value { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCIntegrityStatus_Types_keyvalue_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCIntegrityStatus_Types_keyvalue_ClearExtended"></a> ClearExtended\(\)

```csharp
public void ClearExtended()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCIntegrityStatus_Types_keyvalue_ClearId"></a> ClearId\(\)

```csharp
public void ClearId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCIntegrityStatus_Types_keyvalue_ClearStringValue"></a> ClearStringValue\(\)

```csharp
public void ClearStringValue()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCIntegrityStatus_Types_keyvalue_ClearValue"></a> ClearValue\(\)

```csharp
public void ClearValue()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCIntegrityStatus_Types_keyvalue_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCIntegrityStatus.Types.keyvalue Clone()
```

#### Returns

 [CMsgClientToGCIntegrityStatus](Divine.Protobufs.Dota2.CMsgClientToGCIntegrityStatus.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCIntegrityStatus.Types.md).[keyvalue](Divine.Protobufs.Dota2.CMsgClientToGCIntegrityStatus.Types.keyvalue.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCIntegrityStatus_Types_keyvalue_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCIntegrityStatus_Types_keyvalue_Equals_Divine_Protobufs_Dota2_CMsgClientToGCIntegrityStatus_Types_keyvalue_"></a> Equals\(keyvalue\)

```csharp
public bool Equals(CMsgClientToGCIntegrityStatus.Types.keyvalue other)
```

#### Parameters

`other` [CMsgClientToGCIntegrityStatus](Divine.Protobufs.Dota2.CMsgClientToGCIntegrityStatus.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCIntegrityStatus.Types.md).[keyvalue](Divine.Protobufs.Dota2.CMsgClientToGCIntegrityStatus.Types.keyvalue.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCIntegrityStatus_Types_keyvalue_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCIntegrityStatus_Types_keyvalue_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCIntegrityStatus_Types_keyvalue_"></a> MergeFrom\(keyvalue\)

```csharp
public void MergeFrom(CMsgClientToGCIntegrityStatus.Types.keyvalue other)
```

#### Parameters

`other` [CMsgClientToGCIntegrityStatus](Divine.Protobufs.Dota2.CMsgClientToGCIntegrityStatus.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCIntegrityStatus.Types.md).[keyvalue](Divine.Protobufs.Dota2.CMsgClientToGCIntegrityStatus.Types.keyvalue.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCIntegrityStatus_Types_keyvalue_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCIntegrityStatus_Types_keyvalue_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCIntegrityStatus_Types_keyvalue_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

