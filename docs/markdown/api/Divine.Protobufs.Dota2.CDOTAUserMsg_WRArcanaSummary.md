# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WRArcanaSummary"></a> Class CDOTAUserMsg\_WRArcanaSummary

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_WRArcanaSummary : IMessage<CDOTAUserMsg_WRArcanaSummary>, IEquatable<CDOTAUserMsg_WRArcanaSummary>, IDeepCloneable<CDOTAUserMsg_WRArcanaSummary>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_WRArcanaSummary](Divine.Protobufs.Dota2.CDOTAUserMsg\_WRArcanaSummary.md)

#### Implements

IMessage<CDOTAUserMsg\_WRArcanaSummary\>, 
[IEquatable<CDOTAUserMsg\_WRArcanaSummary\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_WRArcanaSummary\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_WRArcanaSummary\>\(CDOTAUserMsg\_WRArcanaSummary, params CDOTAUserMsg\_WRArcanaSummary\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WRArcanaSummary__ctor"></a> CDOTAUserMsg\_WRArcanaSummary\(\)

```csharp
public CDOTAUserMsg_WRArcanaSummary()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WRArcanaSummary__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_WRArcanaSummary_"></a> CDOTAUserMsg\_WRArcanaSummary\(CDOTAUserMsg\_WRArcanaSummary\)

```csharp
public CDOTAUserMsg_WRArcanaSummary(CDOTAUserMsg_WRArcanaSummary other)
```

#### Parameters

`other` [CDOTAUserMsg\_WRArcanaSummary](Divine.Protobufs.Dota2.CDOTAUserMsg\_WRArcanaSummary.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WRArcanaSummary_ArcanaLevelFieldNumber"></a> ArcanaLevelFieldNumber

```csharp
public const int ArcanaLevelFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WRArcanaSummary_ArrowsLandedFieldNumber"></a> ArrowsLandedFieldNumber

```csharp
public const int ArrowsLandedFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WRArcanaSummary_DamageDealtFieldNumber"></a> DamageDealtFieldNumber

```csharp
public const int DamageDealtFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WRArcanaSummary_EhandleFieldNumber"></a> EhandleFieldNumber

```csharp
public const int EhandleFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WRArcanaSummary_SuccessFieldNumber"></a> SuccessFieldNumber

```csharp
public const int SuccessFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WRArcanaSummary_TargetEhandleFieldNumber"></a> TargetEhandleFieldNumber

```csharp
public const int TargetEhandleFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WRArcanaSummary_TargetHpFieldNumber"></a> TargetHpFieldNumber

```csharp
public const int TargetHpFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WRArcanaSummary_TargetMaxHpFieldNumber"></a> TargetMaxHpFieldNumber

```csharp
public const int TargetMaxHpFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WRArcanaSummary_ArcanaLevel"></a> ArcanaLevel

```csharp
public uint ArcanaLevel { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WRArcanaSummary_ArrowsLanded"></a> ArrowsLanded

```csharp
public uint ArrowsLanded { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WRArcanaSummary_DamageDealt"></a> DamageDealt

```csharp
public uint DamageDealt { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WRArcanaSummary_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WRArcanaSummary_Ehandle"></a> Ehandle

```csharp
public uint Ehandle { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WRArcanaSummary_HasArcanaLevel"></a> HasArcanaLevel

```csharp
public bool HasArcanaLevel { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WRArcanaSummary_HasArrowsLanded"></a> HasArrowsLanded

```csharp
public bool HasArrowsLanded { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WRArcanaSummary_HasDamageDealt"></a> HasDamageDealt

```csharp
public bool HasDamageDealt { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WRArcanaSummary_HasEhandle"></a> HasEhandle

```csharp
public bool HasEhandle { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WRArcanaSummary_HasSuccess"></a> HasSuccess

```csharp
public bool HasSuccess { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WRArcanaSummary_HasTargetEhandle"></a> HasTargetEhandle

```csharp
public bool HasTargetEhandle { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WRArcanaSummary_HasTargetHp"></a> HasTargetHp

```csharp
public bool HasTargetHp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WRArcanaSummary_HasTargetMaxHp"></a> HasTargetMaxHp

```csharp
public bool HasTargetMaxHp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WRArcanaSummary_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_WRArcanaSummary> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_WRArcanaSummary](Divine.Protobufs.Dota2.CDOTAUserMsg\_WRArcanaSummary.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WRArcanaSummary_Success"></a> Success

```csharp
public bool Success { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WRArcanaSummary_TargetEhandle"></a> TargetEhandle

```csharp
public uint TargetEhandle { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WRArcanaSummary_TargetHp"></a> TargetHp

```csharp
public uint TargetHp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WRArcanaSummary_TargetMaxHp"></a> TargetMaxHp

```csharp
public uint TargetMaxHp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WRArcanaSummary_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WRArcanaSummary_ClearArcanaLevel"></a> ClearArcanaLevel\(\)

```csharp
public void ClearArcanaLevel()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WRArcanaSummary_ClearArrowsLanded"></a> ClearArrowsLanded\(\)

```csharp
public void ClearArrowsLanded()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WRArcanaSummary_ClearDamageDealt"></a> ClearDamageDealt\(\)

```csharp
public void ClearDamageDealt()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WRArcanaSummary_ClearEhandle"></a> ClearEhandle\(\)

```csharp
public void ClearEhandle()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WRArcanaSummary_ClearSuccess"></a> ClearSuccess\(\)

```csharp
public void ClearSuccess()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WRArcanaSummary_ClearTargetEhandle"></a> ClearTargetEhandle\(\)

```csharp
public void ClearTargetEhandle()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WRArcanaSummary_ClearTargetHp"></a> ClearTargetHp\(\)

```csharp
public void ClearTargetHp()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WRArcanaSummary_ClearTargetMaxHp"></a> ClearTargetMaxHp\(\)

```csharp
public void ClearTargetMaxHp()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WRArcanaSummary_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_WRArcanaSummary Clone()
```

#### Returns

 [CDOTAUserMsg\_WRArcanaSummary](Divine.Protobufs.Dota2.CDOTAUserMsg\_WRArcanaSummary.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WRArcanaSummary_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WRArcanaSummary_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_WRArcanaSummary_"></a> Equals\(CDOTAUserMsg\_WRArcanaSummary\)

```csharp
public bool Equals(CDOTAUserMsg_WRArcanaSummary other)
```

#### Parameters

`other` [CDOTAUserMsg\_WRArcanaSummary](Divine.Protobufs.Dota2.CDOTAUserMsg\_WRArcanaSummary.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WRArcanaSummary_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WRArcanaSummary_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_WRArcanaSummary_"></a> MergeFrom\(CDOTAUserMsg\_WRArcanaSummary\)

```csharp
public void MergeFrom(CDOTAUserMsg_WRArcanaSummary other)
```

#### Parameters

`other` [CDOTAUserMsg\_WRArcanaSummary](Divine.Protobufs.Dota2.CDOTAUserMsg\_WRArcanaSummary.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WRArcanaSummary_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WRArcanaSummary_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WRArcanaSummary_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

