# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ESArcanaComboSummary"></a> Class CDOTAUserMsg\_ESArcanaComboSummary

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_ESArcanaComboSummary : IMessage<CDOTAUserMsg_ESArcanaComboSummary>, IEquatable<CDOTAUserMsg_ESArcanaComboSummary>, IDeepCloneable<CDOTAUserMsg_ESArcanaComboSummary>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_ESArcanaComboSummary](Divine.Protobufs.Dota2.CDOTAUserMsg\_ESArcanaComboSummary.md)

#### Implements

IMessage<CDOTAUserMsg\_ESArcanaComboSummary\>, 
[IEquatable<CDOTAUserMsg\_ESArcanaComboSummary\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_ESArcanaComboSummary\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_ESArcanaComboSummary\>\(CDOTAUserMsg\_ESArcanaComboSummary, params CDOTAUserMsg\_ESArcanaComboSummary\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ESArcanaComboSummary__ctor"></a> CDOTAUserMsg\_ESArcanaComboSummary\(\)

```csharp
public CDOTAUserMsg_ESArcanaComboSummary()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ESArcanaComboSummary__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_ESArcanaComboSummary_"></a> CDOTAUserMsg\_ESArcanaComboSummary\(CDOTAUserMsg\_ESArcanaComboSummary\)

```csharp
public CDOTAUserMsg_ESArcanaComboSummary(CDOTAUserMsg_ESArcanaComboSummary other)
```

#### Parameters

`other` [CDOTAUserMsg\_ESArcanaComboSummary](Divine.Protobufs.Dota2.CDOTAUserMsg\_ESArcanaComboSummary.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ESArcanaComboSummary_ComboCountFieldNumber"></a> ComboCountFieldNumber

```csharp
public const int ComboCountFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ESArcanaComboSummary_DamageAmountFieldNumber"></a> DamageAmountFieldNumber

```csharp
public const int DamageAmountFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ESArcanaComboSummary_EhandleFieldNumber"></a> EhandleFieldNumber

```csharp
public const int EhandleFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ESArcanaComboSummary_ComboCount"></a> ComboCount

```csharp
public uint ComboCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ESArcanaComboSummary_DamageAmount"></a> DamageAmount

```csharp
public uint DamageAmount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ESArcanaComboSummary_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ESArcanaComboSummary_Ehandle"></a> Ehandle

```csharp
public uint Ehandle { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ESArcanaComboSummary_HasComboCount"></a> HasComboCount

```csharp
public bool HasComboCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ESArcanaComboSummary_HasDamageAmount"></a> HasDamageAmount

```csharp
public bool HasDamageAmount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ESArcanaComboSummary_HasEhandle"></a> HasEhandle

```csharp
public bool HasEhandle { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ESArcanaComboSummary_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_ESArcanaComboSummary> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_ESArcanaComboSummary](Divine.Protobufs.Dota2.CDOTAUserMsg\_ESArcanaComboSummary.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ESArcanaComboSummary_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ESArcanaComboSummary_ClearComboCount"></a> ClearComboCount\(\)

```csharp
public void ClearComboCount()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ESArcanaComboSummary_ClearDamageAmount"></a> ClearDamageAmount\(\)

```csharp
public void ClearDamageAmount()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ESArcanaComboSummary_ClearEhandle"></a> ClearEhandle\(\)

```csharp
public void ClearEhandle()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ESArcanaComboSummary_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_ESArcanaComboSummary Clone()
```

#### Returns

 [CDOTAUserMsg\_ESArcanaComboSummary](Divine.Protobufs.Dota2.CDOTAUserMsg\_ESArcanaComboSummary.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ESArcanaComboSummary_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ESArcanaComboSummary_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_ESArcanaComboSummary_"></a> Equals\(CDOTAUserMsg\_ESArcanaComboSummary\)

```csharp
public bool Equals(CDOTAUserMsg_ESArcanaComboSummary other)
```

#### Parameters

`other` [CDOTAUserMsg\_ESArcanaComboSummary](Divine.Protobufs.Dota2.CDOTAUserMsg\_ESArcanaComboSummary.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ESArcanaComboSummary_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ESArcanaComboSummary_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_ESArcanaComboSummary_"></a> MergeFrom\(CDOTAUserMsg\_ESArcanaComboSummary\)

```csharp
public void MergeFrom(CDOTAUserMsg_ESArcanaComboSummary other)
```

#### Parameters

`other` [CDOTAUserMsg\_ESArcanaComboSummary](Divine.Protobufs.Dota2.CDOTAUserMsg\_ESArcanaComboSummary.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ESArcanaComboSummary_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ESArcanaComboSummary_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ESArcanaComboSummary_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

