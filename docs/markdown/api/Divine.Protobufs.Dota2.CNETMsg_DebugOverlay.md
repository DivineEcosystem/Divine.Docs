# <a id="Divine_Protobufs_Dota2_CNETMsg_DebugOverlay"></a> Class CNETMsg\_DebugOverlay

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CNETMsg_DebugOverlay : IMessage<CNETMsg_DebugOverlay>, IEquatable<CNETMsg_DebugOverlay>, IDeepCloneable<CNETMsg_DebugOverlay>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CNETMsg\_DebugOverlay](Divine.Protobufs.Dota2.CNETMsg\_DebugOverlay.md)

#### Implements

IMessage<CNETMsg\_DebugOverlay\>, 
[IEquatable<CNETMsg\_DebugOverlay\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CNETMsg\_DebugOverlay\>, 
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
[EnumerableExtensions.In<CNETMsg\_DebugOverlay\>\(CNETMsg\_DebugOverlay, params CNETMsg\_DebugOverlay\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CNETMsg_DebugOverlay__ctor"></a> CNETMsg\_DebugOverlay\(\)

```csharp
public CNETMsg_DebugOverlay()
```

### <a id="Divine_Protobufs_Dota2_CNETMsg_DebugOverlay__ctor_Divine_Protobufs_Dota2_CNETMsg_DebugOverlay_"></a> CNETMsg\_DebugOverlay\(CNETMsg\_DebugOverlay\)

```csharp
public CNETMsg_DebugOverlay(CNETMsg_DebugOverlay other)
```

#### Parameters

`other` [CNETMsg\_DebugOverlay](Divine.Protobufs.Dota2.CNETMsg\_DebugOverlay.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CNETMsg_DebugOverlay_BoolsFieldNumber"></a> BoolsFieldNumber

```csharp
public const int BoolsFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_DebugOverlay_ColorsFieldNumber"></a> ColorsFieldNumber

```csharp
public const int ColorsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_DebugOverlay_DimensionsFieldNumber"></a> DimensionsFieldNumber

```csharp
public const int DimensionsFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_DebugOverlay_EtypeFieldNumber"></a> EtypeFieldNumber

```csharp
public const int EtypeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_DebugOverlay_StringsFieldNumber"></a> StringsFieldNumber

```csharp
public const int StringsFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_DebugOverlay_TimesFieldNumber"></a> TimesFieldNumber

```csharp
public const int TimesFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_DebugOverlay_Uint64SFieldNumber"></a> Uint64SFieldNumber

```csharp
public const int Uint64SFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_DebugOverlay_VectorsFieldNumber"></a> VectorsFieldNumber

```csharp
public const int VectorsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CNETMsg_DebugOverlay_Bools"></a> Bools

```csharp
public RepeatedField<bool> Bools { get; }
```

#### Property Value

 RepeatedField<[bool](https://learn.microsoft.com/dotnet/api/system.boolean)\>

### <a id="Divine_Protobufs_Dota2_CNETMsg_DebugOverlay_Colors"></a> Colors

```csharp
public RepeatedField<CMsgRGBA> Colors { get; }
```

#### Property Value

 RepeatedField<[CMsgRGBA](Divine.Protobufs.Dota2.CMsgRGBA.md)\>

### <a id="Divine_Protobufs_Dota2_CNETMsg_DebugOverlay_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CNETMsg_DebugOverlay_Dimensions"></a> Dimensions

```csharp
public RepeatedField<float> Dimensions { get; }
```

#### Property Value

 RepeatedField<[float](https://learn.microsoft.com/dotnet/api/system.single)\>

### <a id="Divine_Protobufs_Dota2_CNETMsg_DebugOverlay_Etype"></a> Etype

```csharp
public int Etype { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_DebugOverlay_HasEtype"></a> HasEtype

```csharp
public bool HasEtype { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_DebugOverlay_Parser"></a> Parser

```csharp
public static MessageParser<CNETMsg_DebugOverlay> Parser { get; }
```

#### Property Value

 MessageParser<[CNETMsg\_DebugOverlay](Divine.Protobufs.Dota2.CNETMsg\_DebugOverlay.md)\>

### <a id="Divine_Protobufs_Dota2_CNETMsg_DebugOverlay_Strings"></a> Strings

```csharp
public RepeatedField<string> Strings { get; }
```

#### Property Value

 RepeatedField<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="Divine_Protobufs_Dota2_CNETMsg_DebugOverlay_Times"></a> Times

```csharp
public RepeatedField<float> Times { get; }
```

#### Property Value

 RepeatedField<[float](https://learn.microsoft.com/dotnet/api/system.single)\>

### <a id="Divine_Protobufs_Dota2_CNETMsg_DebugOverlay_Uint64S"></a> Uint64S

```csharp
public RepeatedField<ulong> Uint64S { get; }
```

#### Property Value

 RepeatedField<[ulong](https://learn.microsoft.com/dotnet/api/system.uint64)\>

### <a id="Divine_Protobufs_Dota2_CNETMsg_DebugOverlay_Vectors"></a> Vectors

```csharp
public RepeatedField<CMsgVector> Vectors { get; }
```

#### Property Value

 RepeatedField<[CMsgVector](Divine.Protobufs.Dota2.CMsgVector.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CNETMsg_DebugOverlay_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_DebugOverlay_ClearEtype"></a> ClearEtype\(\)

```csharp
public void ClearEtype()
```

### <a id="Divine_Protobufs_Dota2_CNETMsg_DebugOverlay_Clone"></a> Clone\(\)

```csharp
public CNETMsg_DebugOverlay Clone()
```

#### Returns

 [CNETMsg\_DebugOverlay](Divine.Protobufs.Dota2.CNETMsg\_DebugOverlay.md)

### <a id="Divine_Protobufs_Dota2_CNETMsg_DebugOverlay_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_DebugOverlay_Equals_Divine_Protobufs_Dota2_CNETMsg_DebugOverlay_"></a> Equals\(CNETMsg\_DebugOverlay\)

```csharp
public bool Equals(CNETMsg_DebugOverlay other)
```

#### Parameters

`other` [CNETMsg\_DebugOverlay](Divine.Protobufs.Dota2.CNETMsg\_DebugOverlay.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_DebugOverlay_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_DebugOverlay_MergeFrom_Divine_Protobufs_Dota2_CNETMsg_DebugOverlay_"></a> MergeFrom\(CNETMsg\_DebugOverlay\)

```csharp
public void MergeFrom(CNETMsg_DebugOverlay other)
```

#### Parameters

`other` [CNETMsg\_DebugOverlay](Divine.Protobufs.Dota2.CNETMsg\_DebugOverlay.md)

### <a id="Divine_Protobufs_Dota2_CNETMsg_DebugOverlay_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CNETMsg_DebugOverlay_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CNETMsg_DebugOverlay_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

