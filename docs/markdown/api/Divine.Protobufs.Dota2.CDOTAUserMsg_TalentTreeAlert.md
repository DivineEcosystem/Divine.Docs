# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TalentTreeAlert"></a> Class CDOTAUserMsg\_TalentTreeAlert

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_TalentTreeAlert : IMessage<CDOTAUserMsg_TalentTreeAlert>, IEquatable<CDOTAUserMsg_TalentTreeAlert>, IDeepCloneable<CDOTAUserMsg_TalentTreeAlert>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_TalentTreeAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_TalentTreeAlert.md)

#### Implements

IMessage<CDOTAUserMsg\_TalentTreeAlert\>, 
[IEquatable<CDOTAUserMsg\_TalentTreeAlert\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_TalentTreeAlert\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_TalentTreeAlert\>\(CDOTAUserMsg\_TalentTreeAlert, params CDOTAUserMsg\_TalentTreeAlert\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TalentTreeAlert__ctor"></a> CDOTAUserMsg\_TalentTreeAlert\(\)

```csharp
public CDOTAUserMsg_TalentTreeAlert()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TalentTreeAlert__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_TalentTreeAlert_"></a> CDOTAUserMsg\_TalentTreeAlert\(CDOTAUserMsg\_TalentTreeAlert\)

```csharp
public CDOTAUserMsg_TalentTreeAlert(CDOTAUserMsg_TalentTreeAlert other)
```

#### Parameters

`other` [CDOTAUserMsg\_TalentTreeAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_TalentTreeAlert.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TalentTreeAlert_AbilityIdFieldNumber"></a> AbilityIdFieldNumber

```csharp
public const int AbilityIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TalentTreeAlert_LearnedFieldNumber"></a> LearnedFieldNumber

```csharp
public const int LearnedFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TalentTreeAlert_PlayerIdFieldNumber"></a> PlayerIdFieldNumber

```csharp
public const int PlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TalentTreeAlert_SlotFieldNumber"></a> SlotFieldNumber

```csharp
public const int SlotFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TalentTreeAlert_TargetEntindexFieldNumber"></a> TargetEntindexFieldNumber

```csharp
public const int TargetEntindexFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TalentTreeAlert_AbilityId"></a> AbilityId

```csharp
public int AbilityId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TalentTreeAlert_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TalentTreeAlert_HasAbilityId"></a> HasAbilityId

```csharp
public bool HasAbilityId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TalentTreeAlert_HasLearned"></a> HasLearned

```csharp
public bool HasLearned { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TalentTreeAlert_HasPlayerId"></a> HasPlayerId

```csharp
public bool HasPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TalentTreeAlert_HasSlot"></a> HasSlot

```csharp
public bool HasSlot { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TalentTreeAlert_HasTargetEntindex"></a> HasTargetEntindex

```csharp
public bool HasTargetEntindex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TalentTreeAlert_Learned"></a> Learned

```csharp
public bool Learned { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TalentTreeAlert_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_TalentTreeAlert> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_TalentTreeAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_TalentTreeAlert.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TalentTreeAlert_PlayerId"></a> PlayerId

```csharp
public int PlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TalentTreeAlert_Slot"></a> Slot

```csharp
public int Slot { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TalentTreeAlert_TargetEntindex"></a> TargetEntindex

```csharp
public int TargetEntindex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TalentTreeAlert_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TalentTreeAlert_ClearAbilityId"></a> ClearAbilityId\(\)

```csharp
public void ClearAbilityId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TalentTreeAlert_ClearLearned"></a> ClearLearned\(\)

```csharp
public void ClearLearned()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TalentTreeAlert_ClearPlayerId"></a> ClearPlayerId\(\)

```csharp
public void ClearPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TalentTreeAlert_ClearSlot"></a> ClearSlot\(\)

```csharp
public void ClearSlot()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TalentTreeAlert_ClearTargetEntindex"></a> ClearTargetEntindex\(\)

```csharp
public void ClearTargetEntindex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TalentTreeAlert_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_TalentTreeAlert Clone()
```

#### Returns

 [CDOTAUserMsg\_TalentTreeAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_TalentTreeAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TalentTreeAlert_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TalentTreeAlert_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_TalentTreeAlert_"></a> Equals\(CDOTAUserMsg\_TalentTreeAlert\)

```csharp
public bool Equals(CDOTAUserMsg_TalentTreeAlert other)
```

#### Parameters

`other` [CDOTAUserMsg\_TalentTreeAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_TalentTreeAlert.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TalentTreeAlert_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TalentTreeAlert_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_TalentTreeAlert_"></a> MergeFrom\(CDOTAUserMsg\_TalentTreeAlert\)

```csharp
public void MergeFrom(CDOTAUserMsg_TalentTreeAlert other)
```

#### Parameters

`other` [CDOTAUserMsg\_TalentTreeAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_TalentTreeAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TalentTreeAlert_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TalentTreeAlert_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TalentTreeAlert_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

