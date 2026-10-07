# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EnemyItemAlert"></a> Class CDOTAClientMsg\_EnemyItemAlert

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_EnemyItemAlert : IMessage<CDOTAClientMsg_EnemyItemAlert>, IEquatable<CDOTAClientMsg_EnemyItemAlert>, IDeepCloneable<CDOTAClientMsg_EnemyItemAlert>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_EnemyItemAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_EnemyItemAlert.md)

#### Implements

IMessage<CDOTAClientMsg\_EnemyItemAlert\>, 
[IEquatable<CDOTAClientMsg\_EnemyItemAlert\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_EnemyItemAlert\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_EnemyItemAlert\>\(CDOTAClientMsg\_EnemyItemAlert, params CDOTAClientMsg\_EnemyItemAlert\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EnemyItemAlert__ctor"></a> CDOTAClientMsg\_EnemyItemAlert\(\)

```csharp
public CDOTAClientMsg_EnemyItemAlert()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EnemyItemAlert__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_EnemyItemAlert_"></a> CDOTAClientMsg\_EnemyItemAlert\(CDOTAClientMsg\_EnemyItemAlert\)

```csharp
public CDOTAClientMsg_EnemyItemAlert(CDOTAClientMsg_EnemyItemAlert other)
```

#### Parameters

`other` [CDOTAClientMsg\_EnemyItemAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_EnemyItemAlert.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EnemyItemAlert_AbilityIdFieldNumber"></a> AbilityIdFieldNumber

```csharp
public const int AbilityIdFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EnemyItemAlert_ItemEntindexFieldNumber"></a> ItemEntindexFieldNumber

```csharp
public const int ItemEntindexFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EnemyItemAlert_ItemLevelFieldNumber"></a> ItemLevelFieldNumber

```csharp
public const int ItemLevelFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EnemyItemAlert_OwnerEntindexFieldNumber"></a> OwnerEntindexFieldNumber

```csharp
public const int OwnerEntindexFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EnemyItemAlert_PrimaryChargesFieldNumber"></a> PrimaryChargesFieldNumber

```csharp
public const int PrimaryChargesFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EnemyItemAlert_RuneTypeFieldNumber"></a> RuneTypeFieldNumber

```csharp
public const int RuneTypeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EnemyItemAlert_SecondaryChargesFieldNumber"></a> SecondaryChargesFieldNumber

```csharp
public const int SecondaryChargesFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EnemyItemAlert_AbilityId"></a> AbilityId

```csharp
public int AbilityId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EnemyItemAlert_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EnemyItemAlert_HasAbilityId"></a> HasAbilityId

```csharp
public bool HasAbilityId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EnemyItemAlert_HasItemEntindex"></a> HasItemEntindex

```csharp
public bool HasItemEntindex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EnemyItemAlert_HasItemLevel"></a> HasItemLevel

```csharp
public bool HasItemLevel { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EnemyItemAlert_HasOwnerEntindex"></a> HasOwnerEntindex

```csharp
public bool HasOwnerEntindex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EnemyItemAlert_HasPrimaryCharges"></a> HasPrimaryCharges

```csharp
public bool HasPrimaryCharges { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EnemyItemAlert_HasRuneType"></a> HasRuneType

```csharp
public bool HasRuneType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EnemyItemAlert_HasSecondaryCharges"></a> HasSecondaryCharges

```csharp
public bool HasSecondaryCharges { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EnemyItemAlert_ItemEntindex"></a> ItemEntindex

```csharp
public int ItemEntindex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EnemyItemAlert_ItemLevel"></a> ItemLevel

```csharp
public int ItemLevel { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EnemyItemAlert_OwnerEntindex"></a> OwnerEntindex

```csharp
public int OwnerEntindex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EnemyItemAlert_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_EnemyItemAlert> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_EnemyItemAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_EnemyItemAlert.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EnemyItemAlert_PrimaryCharges"></a> PrimaryCharges

```csharp
public int PrimaryCharges { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EnemyItemAlert_RuneType"></a> RuneType

```csharp
public int RuneType { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EnemyItemAlert_SecondaryCharges"></a> SecondaryCharges

```csharp
public int SecondaryCharges { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EnemyItemAlert_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EnemyItemAlert_ClearAbilityId"></a> ClearAbilityId\(\)

```csharp
public void ClearAbilityId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EnemyItemAlert_ClearItemEntindex"></a> ClearItemEntindex\(\)

```csharp
public void ClearItemEntindex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EnemyItemAlert_ClearItemLevel"></a> ClearItemLevel\(\)

```csharp
public void ClearItemLevel()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EnemyItemAlert_ClearOwnerEntindex"></a> ClearOwnerEntindex\(\)

```csharp
public void ClearOwnerEntindex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EnemyItemAlert_ClearPrimaryCharges"></a> ClearPrimaryCharges\(\)

```csharp
public void ClearPrimaryCharges()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EnemyItemAlert_ClearRuneType"></a> ClearRuneType\(\)

```csharp
public void ClearRuneType()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EnemyItemAlert_ClearSecondaryCharges"></a> ClearSecondaryCharges\(\)

```csharp
public void ClearSecondaryCharges()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EnemyItemAlert_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_EnemyItemAlert Clone()
```

#### Returns

 [CDOTAClientMsg\_EnemyItemAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_EnemyItemAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EnemyItemAlert_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EnemyItemAlert_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_EnemyItemAlert_"></a> Equals\(CDOTAClientMsg\_EnemyItemAlert\)

```csharp
public bool Equals(CDOTAClientMsg_EnemyItemAlert other)
```

#### Parameters

`other` [CDOTAClientMsg\_EnemyItemAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_EnemyItemAlert.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EnemyItemAlert_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EnemyItemAlert_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_EnemyItemAlert_"></a> MergeFrom\(CDOTAClientMsg\_EnemyItemAlert\)

```csharp
public void MergeFrom(CDOTAClientMsg_EnemyItemAlert other)
```

#### Parameters

`other` [CDOTAClientMsg\_EnemyItemAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_EnemyItemAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EnemyItemAlert_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EnemyItemAlert_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EnemyItemAlert_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

