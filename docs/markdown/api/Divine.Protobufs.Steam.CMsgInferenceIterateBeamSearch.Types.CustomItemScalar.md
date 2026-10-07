# <a id="Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch_Types_CustomItemScalar"></a> Class CMsgInferenceIterateBeamSearch.Types.CustomItemScalar

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgInferenceIterateBeamSearch.Types.CustomItemScalar : IMessage<CMsgInferenceIterateBeamSearch.Types.CustomItemScalar>, IEquatable<CMsgInferenceIterateBeamSearch.Types.CustomItemScalar>, IDeepCloneable<CMsgInferenceIterateBeamSearch.Types.CustomItemScalar>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgInferenceIterateBeamSearch.Types.CustomItemScalar](Divine.Protobufs.Steam.CMsgInferenceIterateBeamSearch.Types.CustomItemScalar.md)

#### Implements

IMessage<CMsgInferenceIterateBeamSearch.Types.CustomItemScalar\>, 
[IEquatable<CMsgInferenceIterateBeamSearch.Types.CustomItemScalar\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgInferenceIterateBeamSearch.Types.CustomItemScalar\>, 
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
[EnumerableExtensions.In<CMsgInferenceIterateBeamSearch.Types.CustomItemScalar\>\(CMsgInferenceIterateBeamSearch.Types.CustomItemScalar, params CMsgInferenceIterateBeamSearch.Types.CustomItemScalar\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch_Types_CustomItemScalar__ctor"></a> CustomItemScalar\(\)

```csharp
public CustomItemScalar()
```

### <a id="Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch_Types_CustomItemScalar__ctor_Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch_Types_CustomItemScalar_"></a> CustomItemScalar\(CustomItemScalar\)

```csharp
public CustomItemScalar(CMsgInferenceIterateBeamSearch.Types.CustomItemScalar other)
```

#### Parameters

`other` [CMsgInferenceIterateBeamSearch](Divine.Protobufs.Steam.CMsgInferenceIterateBeamSearch.md).[Types](Divine.Protobufs.Steam.CMsgInferenceIterateBeamSearch.Types.md).[CustomItemScalar](Divine.Protobufs.Steam.CMsgInferenceIterateBeamSearch.Types.CustomItemScalar.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch_Types_CustomItemScalar_ItemFieldNumber"></a> ItemFieldNumber

```csharp
public const int ItemFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch_Types_CustomItemScalar_ScaleFieldNumber"></a> ScaleFieldNumber

```csharp
public const int ScaleFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch_Types_CustomItemScalar_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch_Types_CustomItemScalar_HasItem"></a> HasItem

```csharp
public bool HasItem { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch_Types_CustomItemScalar_HasScale"></a> HasScale

```csharp
public bool HasScale { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch_Types_CustomItemScalar_Item"></a> Item

```csharp
public uint Item { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch_Types_CustomItemScalar_Parser"></a> Parser

```csharp
public static MessageParser<CMsgInferenceIterateBeamSearch.Types.CustomItemScalar> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgInferenceIterateBeamSearch](Divine.Protobufs.Steam.CMsgInferenceIterateBeamSearch.md).[Types](Divine.Protobufs.Steam.CMsgInferenceIterateBeamSearch.Types.md).[CustomItemScalar](Divine.Protobufs.Steam.CMsgInferenceIterateBeamSearch.Types.CustomItemScalar.md)\>

### <a id="Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch_Types_CustomItemScalar_Scale"></a> Scale

```csharp
public float Scale { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch_Types_CustomItemScalar_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch_Types_CustomItemScalar_ClearItem"></a> ClearItem\(\)

```csharp
public void ClearItem()
```

### <a id="Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch_Types_CustomItemScalar_ClearScale"></a> ClearScale\(\)

```csharp
public void ClearScale()
```

### <a id="Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch_Types_CustomItemScalar_Clone"></a> Clone\(\)

```csharp
public CMsgInferenceIterateBeamSearch.Types.CustomItemScalar Clone()
```

#### Returns

 [CMsgInferenceIterateBeamSearch](Divine.Protobufs.Steam.CMsgInferenceIterateBeamSearch.md).[Types](Divine.Protobufs.Steam.CMsgInferenceIterateBeamSearch.Types.md).[CustomItemScalar](Divine.Protobufs.Steam.CMsgInferenceIterateBeamSearch.Types.CustomItemScalar.md)

### <a id="Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch_Types_CustomItemScalar_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch_Types_CustomItemScalar_Equals_Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch_Types_CustomItemScalar_"></a> Equals\(CustomItemScalar\)

```csharp
public bool Equals(CMsgInferenceIterateBeamSearch.Types.CustomItemScalar other)
```

#### Parameters

`other` [CMsgInferenceIterateBeamSearch](Divine.Protobufs.Steam.CMsgInferenceIterateBeamSearch.md).[Types](Divine.Protobufs.Steam.CMsgInferenceIterateBeamSearch.Types.md).[CustomItemScalar](Divine.Protobufs.Steam.CMsgInferenceIterateBeamSearch.Types.CustomItemScalar.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch_Types_CustomItemScalar_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch_Types_CustomItemScalar_MergeFrom_Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch_Types_CustomItemScalar_"></a> MergeFrom\(CustomItemScalar\)

```csharp
public void MergeFrom(CMsgInferenceIterateBeamSearch.Types.CustomItemScalar other)
```

#### Parameters

`other` [CMsgInferenceIterateBeamSearch](Divine.Protobufs.Steam.CMsgInferenceIterateBeamSearch.md).[Types](Divine.Protobufs.Steam.CMsgInferenceIterateBeamSearch.Types.md).[CustomItemScalar](Divine.Protobufs.Steam.CMsgInferenceIterateBeamSearch.Types.CustomItemScalar.md)

### <a id="Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch_Types_CustomItemScalar_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch_Types_CustomItemScalar_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgInferenceIterateBeamSearch_Types_CustomItemScalar_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

