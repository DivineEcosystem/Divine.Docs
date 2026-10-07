# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SpecialAbility"></a> Class CDOTAClientMsg\_SpecialAbility

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_SpecialAbility : IMessage<CDOTAClientMsg_SpecialAbility>, IEquatable<CDOTAClientMsg_SpecialAbility>, IDeepCloneable<CDOTAClientMsg_SpecialAbility>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_SpecialAbility](Divine.Protobufs.Dota2.CDOTAClientMsg\_SpecialAbility.md)

#### Implements

IMessage<CDOTAClientMsg\_SpecialAbility\>, 
[IEquatable<CDOTAClientMsg\_SpecialAbility\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_SpecialAbility\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_SpecialAbility\>\(CDOTAClientMsg\_SpecialAbility, params CDOTAClientMsg\_SpecialAbility\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SpecialAbility__ctor"></a> CDOTAClientMsg\_SpecialAbility\(\)

```csharp
public CDOTAClientMsg_SpecialAbility()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SpecialAbility__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_SpecialAbility_"></a> CDOTAClientMsg\_SpecialAbility\(CDOTAClientMsg\_SpecialAbility\)

```csharp
public CDOTAClientMsg_SpecialAbility(CDOTAClientMsg_SpecialAbility other)
```

#### Parameters

`other` [CDOTAClientMsg\_SpecialAbility](Divine.Protobufs.Dota2.CDOTAClientMsg\_SpecialAbility.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SpecialAbility_AbilityIndexFieldNumber"></a> AbilityIndexFieldNumber

```csharp
public const int AbilityIndexFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SpecialAbility_TargetEntindexFieldNumber"></a> TargetEntindexFieldNumber

```csharp
public const int TargetEntindexFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SpecialAbility_AbilityIndex"></a> AbilityIndex

```csharp
public uint AbilityIndex { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SpecialAbility_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SpecialAbility_HasAbilityIndex"></a> HasAbilityIndex

```csharp
public bool HasAbilityIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SpecialAbility_HasTargetEntindex"></a> HasTargetEntindex

```csharp
public bool HasTargetEntindex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SpecialAbility_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_SpecialAbility> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_SpecialAbility](Divine.Protobufs.Dota2.CDOTAClientMsg\_SpecialAbility.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SpecialAbility_TargetEntindex"></a> TargetEntindex

```csharp
public int TargetEntindex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SpecialAbility_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SpecialAbility_ClearAbilityIndex"></a> ClearAbilityIndex\(\)

```csharp
public void ClearAbilityIndex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SpecialAbility_ClearTargetEntindex"></a> ClearTargetEntindex\(\)

```csharp
public void ClearTargetEntindex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SpecialAbility_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_SpecialAbility Clone()
```

#### Returns

 [CDOTAClientMsg\_SpecialAbility](Divine.Protobufs.Dota2.CDOTAClientMsg\_SpecialAbility.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SpecialAbility_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SpecialAbility_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_SpecialAbility_"></a> Equals\(CDOTAClientMsg\_SpecialAbility\)

```csharp
public bool Equals(CDOTAClientMsg_SpecialAbility other)
```

#### Parameters

`other` [CDOTAClientMsg\_SpecialAbility](Divine.Protobufs.Dota2.CDOTAClientMsg\_SpecialAbility.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SpecialAbility_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SpecialAbility_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_SpecialAbility_"></a> MergeFrom\(CDOTAClientMsg\_SpecialAbility\)

```csharp
public void MergeFrom(CDOTAClientMsg_SpecialAbility other)
```

#### Parameters

`other` [CDOTAClientMsg\_SpecialAbility](Divine.Protobufs.Dota2.CDOTAClientMsg\_SpecialAbility.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SpecialAbility_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SpecialAbility_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SpecialAbility_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

