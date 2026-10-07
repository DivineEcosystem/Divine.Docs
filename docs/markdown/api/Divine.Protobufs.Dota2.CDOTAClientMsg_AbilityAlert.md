# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityAlert"></a> Class CDOTAClientMsg\_AbilityAlert

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_AbilityAlert : IMessage<CDOTAClientMsg_AbilityAlert>, IEquatable<CDOTAClientMsg_AbilityAlert>, IDeepCloneable<CDOTAClientMsg_AbilityAlert>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_AbilityAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_AbilityAlert.md)

#### Implements

IMessage<CDOTAClientMsg\_AbilityAlert\>, 
[IEquatable<CDOTAClientMsg\_AbilityAlert\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_AbilityAlert\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_AbilityAlert\>\(CDOTAClientMsg\_AbilityAlert, params CDOTAClientMsg\_AbilityAlert\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityAlert__ctor"></a> CDOTAClientMsg\_AbilityAlert\(\)

```csharp
public CDOTAClientMsg_AbilityAlert()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityAlert__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityAlert_"></a> CDOTAClientMsg\_AbilityAlert\(CDOTAClientMsg\_AbilityAlert\)

```csharp
public CDOTAClientMsg_AbilityAlert(CDOTAClientMsg_AbilityAlert other)
```

#### Parameters

`other` [CDOTAClientMsg\_AbilityAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_AbilityAlert.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityAlert_AbilityEntindexFieldNumber"></a> AbilityEntindexFieldNumber

```csharp
public const int AbilityEntindexFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityAlert_AbilityIdFieldNumber"></a> AbilityIdFieldNumber

```csharp
public const int AbilityIdFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityAlert_CtrlHeldFieldNumber"></a> CtrlHeldFieldNumber

```csharp
public const int CtrlHeldFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityAlert_OwnerEntindexFieldNumber"></a> OwnerEntindexFieldNumber

```csharp
public const int OwnerEntindexFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityAlert_PrimaryChargesFieldNumber"></a> PrimaryChargesFieldNumber

```csharp
public const int PrimaryChargesFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityAlert_ReclaimTimeFieldNumber"></a> ReclaimTimeFieldNumber

```csharp
public const int ReclaimTimeFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityAlert_SecondaryChargesFieldNumber"></a> SecondaryChargesFieldNumber

```csharp
public const int SecondaryChargesFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityAlert_AbilityEntindex"></a> AbilityEntindex

```csharp
public uint AbilityEntindex { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityAlert_AbilityId"></a> AbilityId

```csharp
public int AbilityId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityAlert_CtrlHeld"></a> CtrlHeld

```csharp
public bool CtrlHeld { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityAlert_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityAlert_HasAbilityEntindex"></a> HasAbilityEntindex

```csharp
public bool HasAbilityEntindex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityAlert_HasAbilityId"></a> HasAbilityId

```csharp
public bool HasAbilityId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityAlert_HasCtrlHeld"></a> HasCtrlHeld

```csharp
public bool HasCtrlHeld { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityAlert_HasOwnerEntindex"></a> HasOwnerEntindex

```csharp
public bool HasOwnerEntindex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityAlert_HasPrimaryCharges"></a> HasPrimaryCharges

```csharp
public bool HasPrimaryCharges { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityAlert_HasReclaimTime"></a> HasReclaimTime

```csharp
public bool HasReclaimTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityAlert_HasSecondaryCharges"></a> HasSecondaryCharges

```csharp
public bool HasSecondaryCharges { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityAlert_OwnerEntindex"></a> OwnerEntindex

```csharp
public int OwnerEntindex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityAlert_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_AbilityAlert> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_AbilityAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_AbilityAlert.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityAlert_PrimaryCharges"></a> PrimaryCharges

```csharp
public uint PrimaryCharges { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityAlert_ReclaimTime"></a> ReclaimTime

```csharp
public float ReclaimTime { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityAlert_SecondaryCharges"></a> SecondaryCharges

```csharp
public uint SecondaryCharges { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityAlert_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityAlert_ClearAbilityEntindex"></a> ClearAbilityEntindex\(\)

```csharp
public void ClearAbilityEntindex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityAlert_ClearAbilityId"></a> ClearAbilityId\(\)

```csharp
public void ClearAbilityId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityAlert_ClearCtrlHeld"></a> ClearCtrlHeld\(\)

```csharp
public void ClearCtrlHeld()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityAlert_ClearOwnerEntindex"></a> ClearOwnerEntindex\(\)

```csharp
public void ClearOwnerEntindex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityAlert_ClearPrimaryCharges"></a> ClearPrimaryCharges\(\)

```csharp
public void ClearPrimaryCharges()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityAlert_ClearReclaimTime"></a> ClearReclaimTime\(\)

```csharp
public void ClearReclaimTime()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityAlert_ClearSecondaryCharges"></a> ClearSecondaryCharges\(\)

```csharp
public void ClearSecondaryCharges()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityAlert_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_AbilityAlert Clone()
```

#### Returns

 [CDOTAClientMsg\_AbilityAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_AbilityAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityAlert_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityAlert_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityAlert_"></a> Equals\(CDOTAClientMsg\_AbilityAlert\)

```csharp
public bool Equals(CDOTAClientMsg_AbilityAlert other)
```

#### Parameters

`other` [CDOTAClientMsg\_AbilityAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_AbilityAlert.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityAlert_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityAlert_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityAlert_"></a> MergeFrom\(CDOTAClientMsg\_AbilityAlert\)

```csharp
public void MergeFrom(CDOTAClientMsg_AbilityAlert other)
```

#### Parameters

`other` [CDOTAClientMsg\_AbilityAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_AbilityAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityAlert_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityAlert_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityAlert_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

