# <a id="Divine_Protobufs_Dota2_CMsgGameDataFacetAbilityBonus"></a> Class CMsgGameDataFacetAbilityBonus

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGameDataFacetAbilityBonus : IMessage<CMsgGameDataFacetAbilityBonus>, IEquatable<CMsgGameDataFacetAbilityBonus>, IDeepCloneable<CMsgGameDataFacetAbilityBonus>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGameDataFacetAbilityBonus](Divine.Protobufs.Dota2.CMsgGameDataFacetAbilityBonus.md)

#### Implements

IMessage<CMsgGameDataFacetAbilityBonus\>, 
[IEquatable<CMsgGameDataFacetAbilityBonus\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGameDataFacetAbilityBonus\>, 
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
[EnumerableExtensions.In<CMsgGameDataFacetAbilityBonus\>\(CMsgGameDataFacetAbilityBonus, params CMsgGameDataFacetAbilityBonus\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGameDataFacetAbilityBonus__ctor"></a> CMsgGameDataFacetAbilityBonus\(\)

```csharp
public CMsgGameDataFacetAbilityBonus()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataFacetAbilityBonus__ctor_Divine_Protobufs_Dota2_CMsgGameDataFacetAbilityBonus_"></a> CMsgGameDataFacetAbilityBonus\(CMsgGameDataFacetAbilityBonus\)

```csharp
public CMsgGameDataFacetAbilityBonus(CMsgGameDataFacetAbilityBonus other)
```

#### Parameters

`other` [CMsgGameDataFacetAbilityBonus](Divine.Protobufs.Dota2.CMsgGameDataFacetAbilityBonus.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGameDataFacetAbilityBonus_NameFieldNumber"></a> NameFieldNumber

```csharp
public const int NameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataFacetAbilityBonus_OperationFieldNumber"></a> OperationFieldNumber

```csharp
public const int OperationFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataFacetAbilityBonus_ValuesFieldNumber"></a> ValuesFieldNumber

```csharp
public const int ValuesFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGameDataFacetAbilityBonus_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGameDataFacetAbilityBonus_HasName"></a> HasName

```csharp
public bool HasName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataFacetAbilityBonus_HasOperation"></a> HasOperation

```csharp
public bool HasOperation { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataFacetAbilityBonus_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataFacetAbilityBonus_Operation"></a> Operation

```csharp
public uint Operation { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataFacetAbilityBonus_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGameDataFacetAbilityBonus> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGameDataFacetAbilityBonus](Divine.Protobufs.Dota2.CMsgGameDataFacetAbilityBonus.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGameDataFacetAbilityBonus_Values"></a> Values

```csharp
public RepeatedField<float> Values { get; }
```

#### Property Value

 RepeatedField<[float](https://learn.microsoft.com/dotnet/api/system.single)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGameDataFacetAbilityBonus_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataFacetAbilityBonus_ClearName"></a> ClearName\(\)

```csharp
public void ClearName()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataFacetAbilityBonus_ClearOperation"></a> ClearOperation\(\)

```csharp
public void ClearOperation()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameDataFacetAbilityBonus_Clone"></a> Clone\(\)

```csharp
public CMsgGameDataFacetAbilityBonus Clone()
```

#### Returns

 [CMsgGameDataFacetAbilityBonus](Divine.Protobufs.Dota2.CMsgGameDataFacetAbilityBonus.md)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataFacetAbilityBonus_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataFacetAbilityBonus_Equals_Divine_Protobufs_Dota2_CMsgGameDataFacetAbilityBonus_"></a> Equals\(CMsgGameDataFacetAbilityBonus\)

```csharp
public bool Equals(CMsgGameDataFacetAbilityBonus other)
```

#### Parameters

`other` [CMsgGameDataFacetAbilityBonus](Divine.Protobufs.Dota2.CMsgGameDataFacetAbilityBonus.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataFacetAbilityBonus_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataFacetAbilityBonus_MergeFrom_Divine_Protobufs_Dota2_CMsgGameDataFacetAbilityBonus_"></a> MergeFrom\(CMsgGameDataFacetAbilityBonus\)

```csharp
public void MergeFrom(CMsgGameDataFacetAbilityBonus other)
```

#### Parameters

`other` [CMsgGameDataFacetAbilityBonus](Divine.Protobufs.Dota2.CMsgGameDataFacetAbilityBonus.md)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataFacetAbilityBonus_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGameDataFacetAbilityBonus_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGameDataFacetAbilityBonus_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

