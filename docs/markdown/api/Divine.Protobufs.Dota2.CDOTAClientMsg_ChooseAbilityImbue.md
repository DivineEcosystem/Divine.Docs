# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseAbilityImbue"></a> Class CDOTAClientMsg\_ChooseAbilityImbue

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_ChooseAbilityImbue : IMessage<CDOTAClientMsg_ChooseAbilityImbue>, IEquatable<CDOTAClientMsg_ChooseAbilityImbue>, IDeepCloneable<CDOTAClientMsg_ChooseAbilityImbue>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_ChooseAbilityImbue](Divine.Protobufs.Dota2.CDOTAClientMsg\_ChooseAbilityImbue.md)

#### Implements

IMessage<CDOTAClientMsg\_ChooseAbilityImbue\>, 
[IEquatable<CDOTAClientMsg\_ChooseAbilityImbue\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_ChooseAbilityImbue\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_ChooseAbilityImbue\>\(CDOTAClientMsg\_ChooseAbilityImbue, params CDOTAClientMsg\_ChooseAbilityImbue\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseAbilityImbue__ctor"></a> CDOTAClientMsg\_ChooseAbilityImbue\(\)

```csharp
public CDOTAClientMsg_ChooseAbilityImbue()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseAbilityImbue__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseAbilityImbue_"></a> CDOTAClientMsg\_ChooseAbilityImbue\(CDOTAClientMsg\_ChooseAbilityImbue\)

```csharp
public CDOTAClientMsg_ChooseAbilityImbue(CDOTAClientMsg_ChooseAbilityImbue other)
```

#### Parameters

`other` [CDOTAClientMsg\_ChooseAbilityImbue](Divine.Protobufs.Dota2.CDOTAClientMsg\_ChooseAbilityImbue.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseAbilityImbue_AbilityToImbueFieldNumber"></a> AbilityToImbueFieldNumber

```csharp
public const int AbilityToImbueFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseAbilityImbue_AbilityToImbue"></a> AbilityToImbue

```csharp
public int AbilityToImbue { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseAbilityImbue_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseAbilityImbue_HasAbilityToImbue"></a> HasAbilityToImbue

```csharp
public bool HasAbilityToImbue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseAbilityImbue_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_ChooseAbilityImbue> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_ChooseAbilityImbue](Divine.Protobufs.Dota2.CDOTAClientMsg\_ChooseAbilityImbue.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseAbilityImbue_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseAbilityImbue_ClearAbilityToImbue"></a> ClearAbilityToImbue\(\)

```csharp
public void ClearAbilityToImbue()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseAbilityImbue_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_ChooseAbilityImbue Clone()
```

#### Returns

 [CDOTAClientMsg\_ChooseAbilityImbue](Divine.Protobufs.Dota2.CDOTAClientMsg\_ChooseAbilityImbue.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseAbilityImbue_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseAbilityImbue_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseAbilityImbue_"></a> Equals\(CDOTAClientMsg\_ChooseAbilityImbue\)

```csharp
public bool Equals(CDOTAClientMsg_ChooseAbilityImbue other)
```

#### Parameters

`other` [CDOTAClientMsg\_ChooseAbilityImbue](Divine.Protobufs.Dota2.CDOTAClientMsg\_ChooseAbilityImbue.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseAbilityImbue_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseAbilityImbue_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseAbilityImbue_"></a> MergeFrom\(CDOTAClientMsg\_ChooseAbilityImbue\)

```csharp
public void MergeFrom(CDOTAClientMsg_ChooseAbilityImbue other)
```

#### Parameters

`other` [CDOTAClientMsg\_ChooseAbilityImbue](Divine.Protobufs.Dota2.CDOTAClientMsg\_ChooseAbilityImbue.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseAbilityImbue_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseAbilityImbue_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseAbilityImbue_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

