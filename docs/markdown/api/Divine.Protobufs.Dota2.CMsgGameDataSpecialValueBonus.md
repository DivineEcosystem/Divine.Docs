# <a id="Divine_Protobufs_Dota2_CMsgGameDataSpecialValueBonus"></a> Class CMsgGameDataSpecialValueBonus

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGameDataSpecialValueBonus : IMessage<CMsgGameDataSpecialValueBonus>, IEquatable<CMsgGameDataSpecialValueBonus>, IDeepCloneable<CMsgGameDataSpecialValueBonus>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGameDataSpecialValueBonus](Divine.Protobufs.Dota2.CMsgGameDataSpecialValueBonus.md)

#### Implements

IMessage<CMsgGameDataSpecialValueBonus\>, 
[IEquatable<CMsgGameDataSpecialValueBonus\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGameDataSpecialValueBonus\>, 
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
[EnumerableExtensions.In<CMsgGameDataSpecialValueBonus\>\(CMsgGameDataSpecialValueBonus, params CMsgGameDataSpecialValueBonus\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGameDataSpecialValueBonus__ctor"></a> CMsgGameDataSpecialValueBonus\(\)

```csharp
public CMsgGameDataSpecialValueBonus()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataSpecialValueBonus__ctor_Divine_Protobufs_Dota2_CMsgGameDataSpecialValueBonus_"></a> CMsgGameDataSpecialValueBonus\(CMsgGameDataSpecialValueBonus\)

```csharp
public CMsgGameDataSpecialValueBonus(CMsgGameDataSpecialValueBonus other)
```

#### Parameters

`other` [CMsgGameDataSpecialValueBonus](Divine.Protobufs.Dota2.CMsgGameDataSpecialValueBonus.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGameDataSpecialValueBonus_NameFieldNumber"></a> NameFieldNumber

```csharp
public const int NameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataSpecialValueBonus_OperationFieldNumber"></a> OperationFieldNumber

```csharp
public const int OperationFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataSpecialValueBonus_ValueFieldNumber"></a> ValueFieldNumber

```csharp
public const int ValueFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGameDataSpecialValueBonus_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGameDataSpecialValueBonus_HasName"></a> HasName

```csharp
public bool HasName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataSpecialValueBonus_HasOperation"></a> HasOperation

```csharp
public bool HasOperation { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataSpecialValueBonus_HasValue"></a> HasValue

```csharp
public bool HasValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataSpecialValueBonus_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataSpecialValueBonus_Operation"></a> Operation

```csharp
public uint Operation { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataSpecialValueBonus_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGameDataSpecialValueBonus> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGameDataSpecialValueBonus](Divine.Protobufs.Dota2.CMsgGameDataSpecialValueBonus.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGameDataSpecialValueBonus_Value"></a> Value

```csharp
public float Value { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGameDataSpecialValueBonus_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataSpecialValueBonus_ClearName"></a> ClearName\(\)

```csharp
public void ClearName()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataSpecialValueBonus_ClearOperation"></a> ClearOperation\(\)

```csharp
public void ClearOperation()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataSpecialValueBonus_ClearValue"></a> ClearValue\(\)

```csharp
public void ClearValue()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataSpecialValueBonus_Clone"></a> Clone\(\)

```csharp
public CMsgGameDataSpecialValueBonus Clone()
```

#### Returns

 [CMsgGameDataSpecialValueBonus](Divine.Protobufs.Dota2.CMsgGameDataSpecialValueBonus.md)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataSpecialValueBonus_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataSpecialValueBonus_Equals_Divine_Protobufs_Dota2_CMsgGameDataSpecialValueBonus_"></a> Equals\(CMsgGameDataSpecialValueBonus\)

```csharp
public bool Equals(CMsgGameDataSpecialValueBonus other)
```

#### Parameters

`other` [CMsgGameDataSpecialValueBonus](Divine.Protobufs.Dota2.CMsgGameDataSpecialValueBonus.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataSpecialValueBonus_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataSpecialValueBonus_MergeFrom_Divine_Protobufs_Dota2_CMsgGameDataSpecialValueBonus_"></a> MergeFrom\(CMsgGameDataSpecialValueBonus\)

```csharp
public void MergeFrom(CMsgGameDataSpecialValueBonus other)
```

#### Parameters

`other` [CMsgGameDataSpecialValueBonus](Divine.Protobufs.Dota2.CMsgGameDataSpecialValueBonus.md)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataSpecialValueBonus_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGameDataSpecialValueBonus_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataSpecialValueBonus_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

