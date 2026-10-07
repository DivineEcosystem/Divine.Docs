# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ESArcanaCombo"></a> Class CDOTAUserMsg\_ESArcanaCombo

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_ESArcanaCombo : IMessage<CDOTAUserMsg_ESArcanaCombo>, IEquatable<CDOTAUserMsg_ESArcanaCombo>, IDeepCloneable<CDOTAUserMsg_ESArcanaCombo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_ESArcanaCombo](Divine.Protobufs.Dota2.CDOTAUserMsg\_ESArcanaCombo.md)

#### Implements

IMessage<CDOTAUserMsg\_ESArcanaCombo\>, 
[IEquatable<CDOTAUserMsg\_ESArcanaCombo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_ESArcanaCombo\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_ESArcanaCombo\>\(CDOTAUserMsg\_ESArcanaCombo, params CDOTAUserMsg\_ESArcanaCombo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ESArcanaCombo__ctor"></a> CDOTAUserMsg\_ESArcanaCombo\(\)

```csharp
public CDOTAUserMsg_ESArcanaCombo()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ESArcanaCombo__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_ESArcanaCombo_"></a> CDOTAUserMsg\_ESArcanaCombo\(CDOTAUserMsg\_ESArcanaCombo\)

```csharp
public CDOTAUserMsg_ESArcanaCombo(CDOTAUserMsg_ESArcanaCombo other)
```

#### Parameters

`other` [CDOTAUserMsg\_ESArcanaCombo](Divine.Protobufs.Dota2.CDOTAUserMsg\_ESArcanaCombo.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ESArcanaCombo_ArcanaLevelFieldNumber"></a> ArcanaLevelFieldNumber

```csharp
public const int ArcanaLevelFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ESArcanaCombo_ComboCountFieldNumber"></a> ComboCountFieldNumber

```csharp
public const int ComboCountFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ESArcanaCombo_EhandleFieldNumber"></a> EhandleFieldNumber

```csharp
public const int EhandleFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ESArcanaCombo_ArcanaLevel"></a> ArcanaLevel

```csharp
public uint ArcanaLevel { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ESArcanaCombo_ComboCount"></a> ComboCount

```csharp
public uint ComboCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ESArcanaCombo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ESArcanaCombo_Ehandle"></a> Ehandle

```csharp
public uint Ehandle { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ESArcanaCombo_HasArcanaLevel"></a> HasArcanaLevel

```csharp
public bool HasArcanaLevel { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ESArcanaCombo_HasComboCount"></a> HasComboCount

```csharp
public bool HasComboCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ESArcanaCombo_HasEhandle"></a> HasEhandle

```csharp
public bool HasEhandle { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ESArcanaCombo_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_ESArcanaCombo> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_ESArcanaCombo](Divine.Protobufs.Dota2.CDOTAUserMsg\_ESArcanaCombo.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ESArcanaCombo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ESArcanaCombo_ClearArcanaLevel"></a> ClearArcanaLevel\(\)

```csharp
public void ClearArcanaLevel()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ESArcanaCombo_ClearComboCount"></a> ClearComboCount\(\)

```csharp
public void ClearComboCount()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ESArcanaCombo_ClearEhandle"></a> ClearEhandle\(\)

```csharp
public void ClearEhandle()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ESArcanaCombo_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_ESArcanaCombo Clone()
```

#### Returns

 [CDOTAUserMsg\_ESArcanaCombo](Divine.Protobufs.Dota2.CDOTAUserMsg\_ESArcanaCombo.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ESArcanaCombo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ESArcanaCombo_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_ESArcanaCombo_"></a> Equals\(CDOTAUserMsg\_ESArcanaCombo\)

```csharp
public bool Equals(CDOTAUserMsg_ESArcanaCombo other)
```

#### Parameters

`other` [CDOTAUserMsg\_ESArcanaCombo](Divine.Protobufs.Dota2.CDOTAUserMsg\_ESArcanaCombo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ESArcanaCombo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ESArcanaCombo_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_ESArcanaCombo_"></a> MergeFrom\(CDOTAUserMsg\_ESArcanaCombo\)

```csharp
public void MergeFrom(CDOTAUserMsg_ESArcanaCombo other)
```

#### Parameters

`other` [CDOTAUserMsg\_ESArcanaCombo](Divine.Protobufs.Dota2.CDOTAUserMsg\_ESArcanaCombo.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ESArcanaCombo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ESArcanaCombo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ESArcanaCombo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

