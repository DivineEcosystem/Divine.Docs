# <a id="Divine_Protobufs_Dota2_CSerializedCombatLog_Types_Dictionary_Types_DictString"></a> Class CSerializedCombatLog.Types.Dictionary.Types.DictString

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSerializedCombatLog.Types.Dictionary.Types.DictString : IMessage<CSerializedCombatLog.Types.Dictionary.Types.DictString>, IEquatable<CSerializedCombatLog.Types.Dictionary.Types.DictString>, IDeepCloneable<CSerializedCombatLog.Types.Dictionary.Types.DictString>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSerializedCombatLog.Types.Dictionary.Types.DictString](Divine.Protobufs.Dota2.CSerializedCombatLog.Types.Dictionary.Types.DictString.md)

#### Implements

IMessage<CSerializedCombatLog.Types.Dictionary.Types.DictString\>, 
[IEquatable<CSerializedCombatLog.Types.Dictionary.Types.DictString\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSerializedCombatLog.Types.Dictionary.Types.DictString\>, 
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
[EnumerableExtensions.In<CSerializedCombatLog.Types.Dictionary.Types.DictString\>\(CSerializedCombatLog.Types.Dictionary.Types.DictString, params CSerializedCombatLog.Types.Dictionary.Types.DictString\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSerializedCombatLog_Types_Dictionary_Types_DictString__ctor"></a> DictString\(\)

```csharp
public DictString()
```

### <a id="Divine_Protobufs_Dota2_CSerializedCombatLog_Types_Dictionary_Types_DictString__ctor_Divine_Protobufs_Dota2_CSerializedCombatLog_Types_Dictionary_Types_DictString_"></a> DictString\(DictString\)

```csharp
public DictString(CSerializedCombatLog.Types.Dictionary.Types.DictString other)
```

#### Parameters

`other` [CSerializedCombatLog](Divine.Protobufs.Dota2.CSerializedCombatLog.md).[Types](Divine.Protobufs.Dota2.CSerializedCombatLog.Types.md).[Dictionary](Divine.Protobufs.Dota2.CSerializedCombatLog.Types.Dictionary.md).[Types](Divine.Protobufs.Dota2.CSerializedCombatLog.Types.Dictionary.Types.md).[DictString](Divine.Protobufs.Dota2.CSerializedCombatLog.Types.Dictionary.Types.DictString.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSerializedCombatLog_Types_Dictionary_Types_DictString_IdFieldNumber"></a> IdFieldNumber

```csharp
public const int IdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSerializedCombatLog_Types_Dictionary_Types_DictString_ValueFieldNumber"></a> ValueFieldNumber

```csharp
public const int ValueFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSerializedCombatLog_Types_Dictionary_Types_DictString_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSerializedCombatLog_Types_Dictionary_Types_DictString_HasId"></a> HasId

```csharp
public bool HasId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSerializedCombatLog_Types_Dictionary_Types_DictString_HasValue"></a> HasValue

```csharp
public bool HasValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSerializedCombatLog_Types_Dictionary_Types_DictString_Id"></a> Id

```csharp
public uint Id { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSerializedCombatLog_Types_Dictionary_Types_DictString_Parser"></a> Parser

```csharp
public static MessageParser<CSerializedCombatLog.Types.Dictionary.Types.DictString> Parser { get; }
```

#### Property Value

 MessageParser<[CSerializedCombatLog](Divine.Protobufs.Dota2.CSerializedCombatLog.md).[Types](Divine.Protobufs.Dota2.CSerializedCombatLog.Types.md).[Dictionary](Divine.Protobufs.Dota2.CSerializedCombatLog.Types.Dictionary.md).[Types](Divine.Protobufs.Dota2.CSerializedCombatLog.Types.Dictionary.Types.md).[DictString](Divine.Protobufs.Dota2.CSerializedCombatLog.Types.Dictionary.Types.DictString.md)\>

### <a id="Divine_Protobufs_Dota2_CSerializedCombatLog_Types_Dictionary_Types_DictString_Value"></a> Value

```csharp
public string Value { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Dota2_CSerializedCombatLog_Types_Dictionary_Types_DictString_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSerializedCombatLog_Types_Dictionary_Types_DictString_ClearId"></a> ClearId\(\)

```csharp
public void ClearId()
```

### <a id="Divine_Protobufs_Dota2_CSerializedCombatLog_Types_Dictionary_Types_DictString_ClearValue"></a> ClearValue\(\)

```csharp
public void ClearValue()
```

### <a id="Divine_Protobufs_Dota2_CSerializedCombatLog_Types_Dictionary_Types_DictString_Clone"></a> Clone\(\)

```csharp
public CSerializedCombatLog.Types.Dictionary.Types.DictString Clone()
```

#### Returns

 [CSerializedCombatLog](Divine.Protobufs.Dota2.CSerializedCombatLog.md).[Types](Divine.Protobufs.Dota2.CSerializedCombatLog.Types.md).[Dictionary](Divine.Protobufs.Dota2.CSerializedCombatLog.Types.Dictionary.md).[Types](Divine.Protobufs.Dota2.CSerializedCombatLog.Types.Dictionary.Types.md).[DictString](Divine.Protobufs.Dota2.CSerializedCombatLog.Types.Dictionary.Types.DictString.md)

### <a id="Divine_Protobufs_Dota2_CSerializedCombatLog_Types_Dictionary_Types_DictString_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSerializedCombatLog_Types_Dictionary_Types_DictString_Equals_Divine_Protobufs_Dota2_CSerializedCombatLog_Types_Dictionary_Types_DictString_"></a> Equals\(DictString\)

```csharp
public bool Equals(CSerializedCombatLog.Types.Dictionary.Types.DictString other)
```

#### Parameters

`other` [CSerializedCombatLog](Divine.Protobufs.Dota2.CSerializedCombatLog.md).[Types](Divine.Protobufs.Dota2.CSerializedCombatLog.Types.md).[Dictionary](Divine.Protobufs.Dota2.CSerializedCombatLog.Types.Dictionary.md).[Types](Divine.Protobufs.Dota2.CSerializedCombatLog.Types.Dictionary.Types.md).[DictString](Divine.Protobufs.Dota2.CSerializedCombatLog.Types.Dictionary.Types.DictString.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSerializedCombatLog_Types_Dictionary_Types_DictString_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSerializedCombatLog_Types_Dictionary_Types_DictString_MergeFrom_Divine_Protobufs_Dota2_CSerializedCombatLog_Types_Dictionary_Types_DictString_"></a> MergeFrom\(DictString\)

```csharp
public void MergeFrom(CSerializedCombatLog.Types.Dictionary.Types.DictString other)
```

#### Parameters

`other` [CSerializedCombatLog](Divine.Protobufs.Dota2.CSerializedCombatLog.md).[Types](Divine.Protobufs.Dota2.CSerializedCombatLog.Types.md).[Dictionary](Divine.Protobufs.Dota2.CSerializedCombatLog.Types.Dictionary.md).[Types](Divine.Protobufs.Dota2.CSerializedCombatLog.Types.Dictionary.Types.md).[DictString](Divine.Protobufs.Dota2.CSerializedCombatLog.Types.Dictionary.Types.DictString.md)

### <a id="Divine_Protobufs_Dota2_CSerializedCombatLog_Types_Dictionary_Types_DictString_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSerializedCombatLog_Types_Dictionary_Types_DictString_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSerializedCombatLog_Types_Dictionary_Types_DictString_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

