# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OMArcanaCombo"></a> Class CDOTAUserMsg\_OMArcanaCombo

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_OMArcanaCombo : IMessage<CDOTAUserMsg_OMArcanaCombo>, IEquatable<CDOTAUserMsg_OMArcanaCombo>, IDeepCloneable<CDOTAUserMsg_OMArcanaCombo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_OMArcanaCombo](Divine.Protobufs.Dota2.CDOTAUserMsg\_OMArcanaCombo.md)

#### Implements

IMessage<CDOTAUserMsg\_OMArcanaCombo\>, 
[IEquatable<CDOTAUserMsg\_OMArcanaCombo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_OMArcanaCombo\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_OMArcanaCombo\>\(CDOTAUserMsg\_OMArcanaCombo, params CDOTAUserMsg\_OMArcanaCombo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OMArcanaCombo__ctor"></a> CDOTAUserMsg\_OMArcanaCombo\(\)

```csharp
public CDOTAUserMsg_OMArcanaCombo()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OMArcanaCombo__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_OMArcanaCombo_"></a> CDOTAUserMsg\_OMArcanaCombo\(CDOTAUserMsg\_OMArcanaCombo\)

```csharp
public CDOTAUserMsg_OMArcanaCombo(CDOTAUserMsg_OMArcanaCombo other)
```

#### Parameters

`other` [CDOTAUserMsg\_OMArcanaCombo](Divine.Protobufs.Dota2.CDOTAUserMsg\_OMArcanaCombo.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OMArcanaCombo_ArcanaLevelFieldNumber"></a> ArcanaLevelFieldNumber

```csharp
public const int ArcanaLevelFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OMArcanaCombo_EhandleFieldNumber"></a> EhandleFieldNumber

```csharp
public const int EhandleFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OMArcanaCombo_MulticastAmountFieldNumber"></a> MulticastAmountFieldNumber

```csharp
public const int MulticastAmountFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OMArcanaCombo_MulticastChanceFieldNumber"></a> MulticastChanceFieldNumber

```csharp
public const int MulticastChanceFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OMArcanaCombo_ArcanaLevel"></a> ArcanaLevel

```csharp
public uint ArcanaLevel { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OMArcanaCombo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OMArcanaCombo_Ehandle"></a> Ehandle

```csharp
public uint Ehandle { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OMArcanaCombo_HasArcanaLevel"></a> HasArcanaLevel

```csharp
public bool HasArcanaLevel { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OMArcanaCombo_HasEhandle"></a> HasEhandle

```csharp
public bool HasEhandle { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OMArcanaCombo_HasMulticastAmount"></a> HasMulticastAmount

```csharp
public bool HasMulticastAmount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OMArcanaCombo_HasMulticastChance"></a> HasMulticastChance

```csharp
public bool HasMulticastChance { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OMArcanaCombo_MulticastAmount"></a> MulticastAmount

```csharp
public uint MulticastAmount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OMArcanaCombo_MulticastChance"></a> MulticastChance

```csharp
public uint MulticastChance { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OMArcanaCombo_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_OMArcanaCombo> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_OMArcanaCombo](Divine.Protobufs.Dota2.CDOTAUserMsg\_OMArcanaCombo.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OMArcanaCombo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OMArcanaCombo_ClearArcanaLevel"></a> ClearArcanaLevel\(\)

```csharp
public void ClearArcanaLevel()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OMArcanaCombo_ClearEhandle"></a> ClearEhandle\(\)

```csharp
public void ClearEhandle()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OMArcanaCombo_ClearMulticastAmount"></a> ClearMulticastAmount\(\)

```csharp
public void ClearMulticastAmount()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OMArcanaCombo_ClearMulticastChance"></a> ClearMulticastChance\(\)

```csharp
public void ClearMulticastChance()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OMArcanaCombo_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_OMArcanaCombo Clone()
```

#### Returns

 [CDOTAUserMsg\_OMArcanaCombo](Divine.Protobufs.Dota2.CDOTAUserMsg\_OMArcanaCombo.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OMArcanaCombo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OMArcanaCombo_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_OMArcanaCombo_"></a> Equals\(CDOTAUserMsg\_OMArcanaCombo\)

```csharp
public bool Equals(CDOTAUserMsg_OMArcanaCombo other)
```

#### Parameters

`other` [CDOTAUserMsg\_OMArcanaCombo](Divine.Protobufs.Dota2.CDOTAUserMsg\_OMArcanaCombo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OMArcanaCombo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OMArcanaCombo_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_OMArcanaCombo_"></a> MergeFrom\(CDOTAUserMsg\_OMArcanaCombo\)

```csharp
public void MergeFrom(CDOTAUserMsg_OMArcanaCombo other)
```

#### Parameters

`other` [CDOTAUserMsg\_OMArcanaCombo](Divine.Protobufs.Dota2.CDOTAUserMsg\_OMArcanaCombo.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OMArcanaCombo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OMArcanaCombo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OMArcanaCombo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

