# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_TalentTreeAlert"></a> Class CDOTAClientMsg\_TalentTreeAlert

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_TalentTreeAlert : IMessage<CDOTAClientMsg_TalentTreeAlert>, IEquatable<CDOTAClientMsg_TalentTreeAlert>, IDeepCloneable<CDOTAClientMsg_TalentTreeAlert>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_TalentTreeAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_TalentTreeAlert.md)

#### Implements

IMessage<CDOTAClientMsg\_TalentTreeAlert\>, 
[IEquatable<CDOTAClientMsg\_TalentTreeAlert\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_TalentTreeAlert\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_TalentTreeAlert\>\(CDOTAClientMsg\_TalentTreeAlert, params CDOTAClientMsg\_TalentTreeAlert\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_TalentTreeAlert__ctor"></a> CDOTAClientMsg\_TalentTreeAlert\(\)

```csharp
public CDOTAClientMsg_TalentTreeAlert()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_TalentTreeAlert__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_TalentTreeAlert_"></a> CDOTAClientMsg\_TalentTreeAlert\(CDOTAClientMsg\_TalentTreeAlert\)

```csharp
public CDOTAClientMsg_TalentTreeAlert(CDOTAClientMsg_TalentTreeAlert other)
```

#### Parameters

`other` [CDOTAClientMsg\_TalentTreeAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_TalentTreeAlert.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_TalentTreeAlert_AbilityIdFieldNumber"></a> AbilityIdFieldNumber

```csharp
public const int AbilityIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_TalentTreeAlert_LearnedFieldNumber"></a> LearnedFieldNumber

```csharp
public const int LearnedFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_TalentTreeAlert_SlotFieldNumber"></a> SlotFieldNumber

```csharp
public const int SlotFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_TalentTreeAlert_TargetEntindexFieldNumber"></a> TargetEntindexFieldNumber

```csharp
public const int TargetEntindexFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_TalentTreeAlert_AbilityId"></a> AbilityId

```csharp
public int AbilityId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_TalentTreeAlert_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_TalentTreeAlert_HasAbilityId"></a> HasAbilityId

```csharp
public bool HasAbilityId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_TalentTreeAlert_HasLearned"></a> HasLearned

```csharp
public bool HasLearned { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_TalentTreeAlert_HasSlot"></a> HasSlot

```csharp
public bool HasSlot { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_TalentTreeAlert_HasTargetEntindex"></a> HasTargetEntindex

```csharp
public bool HasTargetEntindex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_TalentTreeAlert_Learned"></a> Learned

```csharp
public bool Learned { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_TalentTreeAlert_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_TalentTreeAlert> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_TalentTreeAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_TalentTreeAlert.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_TalentTreeAlert_Slot"></a> Slot

```csharp
public int Slot { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_TalentTreeAlert_TargetEntindex"></a> TargetEntindex

```csharp
public int TargetEntindex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_TalentTreeAlert_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_TalentTreeAlert_ClearAbilityId"></a> ClearAbilityId\(\)

```csharp
public void ClearAbilityId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_TalentTreeAlert_ClearLearned"></a> ClearLearned\(\)

```csharp
public void ClearLearned()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_TalentTreeAlert_ClearSlot"></a> ClearSlot\(\)

```csharp
public void ClearSlot()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_TalentTreeAlert_ClearTargetEntindex"></a> ClearTargetEntindex\(\)

```csharp
public void ClearTargetEntindex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_TalentTreeAlert_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_TalentTreeAlert Clone()
```

#### Returns

 [CDOTAClientMsg\_TalentTreeAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_TalentTreeAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_TalentTreeAlert_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_TalentTreeAlert_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_TalentTreeAlert_"></a> Equals\(CDOTAClientMsg\_TalentTreeAlert\)

```csharp
public bool Equals(CDOTAClientMsg_TalentTreeAlert other)
```

#### Parameters

`other` [CDOTAClientMsg\_TalentTreeAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_TalentTreeAlert.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_TalentTreeAlert_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_TalentTreeAlert_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_TalentTreeAlert_"></a> MergeFrom\(CDOTAClientMsg\_TalentTreeAlert\)

```csharp
public void MergeFrom(CDOTAClientMsg_TalentTreeAlert other)
```

#### Parameters

`other` [CDOTAClientMsg\_TalentTreeAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_TalentTreeAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_TalentTreeAlert_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_TalentTreeAlert_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_TalentTreeAlert_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

