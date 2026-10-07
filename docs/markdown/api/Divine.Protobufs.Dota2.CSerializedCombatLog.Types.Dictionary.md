# <a id="Divine_Protobufs_Dota2_CSerializedCombatLog_Types_Dictionary"></a> Class CSerializedCombatLog.Types.Dictionary

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSerializedCombatLog.Types.Dictionary : IMessage<CSerializedCombatLog.Types.Dictionary>, IEquatable<CSerializedCombatLog.Types.Dictionary>, IDeepCloneable<CSerializedCombatLog.Types.Dictionary>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSerializedCombatLog.Types.Dictionary](Divine.Protobufs.Dota2.CSerializedCombatLog.Types.Dictionary.md)

#### Implements

IMessage<CSerializedCombatLog.Types.Dictionary\>, 
[IEquatable<CSerializedCombatLog.Types.Dictionary\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSerializedCombatLog.Types.Dictionary\>, 
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
[EnumerableExtensions.In<CSerializedCombatLog.Types.Dictionary\>\(CSerializedCombatLog.Types.Dictionary, params CSerializedCombatLog.Types.Dictionary\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSerializedCombatLog_Types_Dictionary__ctor"></a> Dictionary\(\)

```csharp
public Dictionary()
```

### <a id="Divine_Protobufs_Dota2_CSerializedCombatLog_Types_Dictionary__ctor_Divine_Protobufs_Dota2_CSerializedCombatLog_Types_Dictionary_"></a> Dictionary\(Dictionary\)

```csharp
public Dictionary(CSerializedCombatLog.Types.Dictionary other)
```

#### Parameters

`other` [CSerializedCombatLog](Divine.Protobufs.Dota2.CSerializedCombatLog.md).[Types](Divine.Protobufs.Dota2.CSerializedCombatLog.Types.md).[Dictionary](Divine.Protobufs.Dota2.CSerializedCombatLog.Types.Dictionary.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSerializedCombatLog_Types_Dictionary_StringsFieldNumber"></a> StringsFieldNumber

```csharp
public const int StringsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSerializedCombatLog_Types_Dictionary_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSerializedCombatLog_Types_Dictionary_Parser"></a> Parser

```csharp
public static MessageParser<CSerializedCombatLog.Types.Dictionary> Parser { get; }
```

#### Property Value

 MessageParser<[CSerializedCombatLog](Divine.Protobufs.Dota2.CSerializedCombatLog.md).[Types](Divine.Protobufs.Dota2.CSerializedCombatLog.Types.md).[Dictionary](Divine.Protobufs.Dota2.CSerializedCombatLog.Types.Dictionary.md)\>

### <a id="Divine_Protobufs_Dota2_CSerializedCombatLog_Types_Dictionary_Strings"></a> Strings

```csharp
public RepeatedField<CSerializedCombatLog.Types.Dictionary.Types.DictString> Strings { get; }
```

#### Property Value

 RepeatedField<[CSerializedCombatLog](Divine.Protobufs.Dota2.CSerializedCombatLog.md).[Types](Divine.Protobufs.Dota2.CSerializedCombatLog.Types.md).[Dictionary](Divine.Protobufs.Dota2.CSerializedCombatLog.Types.Dictionary.md).[Types](Divine.Protobufs.Dota2.CSerializedCombatLog.Types.Dictionary.Types.md).[DictString](Divine.Protobufs.Dota2.CSerializedCombatLog.Types.Dictionary.Types.DictString.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CSerializedCombatLog_Types_Dictionary_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSerializedCombatLog_Types_Dictionary_Clone"></a> Clone\(\)

```csharp
public CSerializedCombatLog.Types.Dictionary Clone()
```

#### Returns

 [CSerializedCombatLog](Divine.Protobufs.Dota2.CSerializedCombatLog.md).[Types](Divine.Protobufs.Dota2.CSerializedCombatLog.Types.md).[Dictionary](Divine.Protobufs.Dota2.CSerializedCombatLog.Types.Dictionary.md)

### <a id="Divine_Protobufs_Dota2_CSerializedCombatLog_Types_Dictionary_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSerializedCombatLog_Types_Dictionary_Equals_Divine_Protobufs_Dota2_CSerializedCombatLog_Types_Dictionary_"></a> Equals\(Dictionary\)

```csharp
public bool Equals(CSerializedCombatLog.Types.Dictionary other)
```

#### Parameters

`other` [CSerializedCombatLog](Divine.Protobufs.Dota2.CSerializedCombatLog.md).[Types](Divine.Protobufs.Dota2.CSerializedCombatLog.Types.md).[Dictionary](Divine.Protobufs.Dota2.CSerializedCombatLog.Types.Dictionary.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSerializedCombatLog_Types_Dictionary_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSerializedCombatLog_Types_Dictionary_MergeFrom_Divine_Protobufs_Dota2_CSerializedCombatLog_Types_Dictionary_"></a> MergeFrom\(Dictionary\)

```csharp
public void MergeFrom(CSerializedCombatLog.Types.Dictionary other)
```

#### Parameters

`other` [CSerializedCombatLog](Divine.Protobufs.Dota2.CSerializedCombatLog.md).[Types](Divine.Protobufs.Dota2.CSerializedCombatLog.Types.md).[Dictionary](Divine.Protobufs.Dota2.CSerializedCombatLog.Types.Dictionary.md)

### <a id="Divine_Protobufs_Dota2_CSerializedCombatLog_Types_Dictionary_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSerializedCombatLog_Types_Dictionary_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSerializedCombatLog_Types_Dictionary_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

