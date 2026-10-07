# <a id="Divine_Protobufs_Dota2_CMvpData_Types_MvpDatum_Types_MvpAccolade"></a> Class CMvpData.Types.MvpDatum.Types.MvpAccolade

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMvpData.Types.MvpDatum.Types.MvpAccolade : IMessage<CMvpData.Types.MvpDatum.Types.MvpAccolade>, IEquatable<CMvpData.Types.MvpDatum.Types.MvpAccolade>, IDeepCloneable<CMvpData.Types.MvpDatum.Types.MvpAccolade>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMvpData.Types.MvpDatum.Types.MvpAccolade](Divine.Protobufs.Dota2.CMvpData.Types.MvpDatum.Types.MvpAccolade.md)

#### Implements

IMessage<CMvpData.Types.MvpDatum.Types.MvpAccolade\>, 
[IEquatable<CMvpData.Types.MvpDatum.Types.MvpAccolade\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMvpData.Types.MvpDatum.Types.MvpAccolade\>, 
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
[EnumerableExtensions.In<CMvpData.Types.MvpDatum.Types.MvpAccolade\>\(CMvpData.Types.MvpDatum.Types.MvpAccolade, params CMvpData.Types.MvpDatum.Types.MvpAccolade\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMvpData_Types_MvpDatum_Types_MvpAccolade__ctor"></a> MvpAccolade\(\)

```csharp
public MvpAccolade()
```

### <a id="Divine_Protobufs_Dota2_CMvpData_Types_MvpDatum_Types_MvpAccolade__ctor_Divine_Protobufs_Dota2_CMvpData_Types_MvpDatum_Types_MvpAccolade_"></a> MvpAccolade\(MvpAccolade\)

```csharp
public MvpAccolade(CMvpData.Types.MvpDatum.Types.MvpAccolade other)
```

#### Parameters

`other` [CMvpData](Divine.Protobufs.Dota2.CMvpData.md).[Types](Divine.Protobufs.Dota2.CMvpData.Types.md).[MvpDatum](Divine.Protobufs.Dota2.CMvpData.Types.MvpDatum.md).[Types](Divine.Protobufs.Dota2.CMvpData.Types.MvpDatum.Types.md).[MvpAccolade](Divine.Protobufs.Dota2.CMvpData.Types.MvpDatum.Types.MvpAccolade.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMvpData_Types_MvpDatum_Types_MvpAccolade_DetailValueFieldNumber"></a> DetailValueFieldNumber

```csharp
public const int DetailValueFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMvpData_Types_MvpDatum_Types_MvpAccolade_TypeFieldNumber"></a> TypeFieldNumber

```csharp
public const int TypeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMvpData_Types_MvpDatum_Types_MvpAccolade_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMvpData_Types_MvpDatum_Types_MvpAccolade_DetailValue"></a> DetailValue

```csharp
public float DetailValue { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMvpData_Types_MvpDatum_Types_MvpAccolade_HasDetailValue"></a> HasDetailValue

```csharp
public bool HasDetailValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMvpData_Types_MvpDatum_Types_MvpAccolade_HasType"></a> HasType

```csharp
public bool HasType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMvpData_Types_MvpDatum_Types_MvpAccolade_Parser"></a> Parser

```csharp
public static MessageParser<CMvpData.Types.MvpDatum.Types.MvpAccolade> Parser { get; }
```

#### Property Value

 MessageParser<[CMvpData](Divine.Protobufs.Dota2.CMvpData.md).[Types](Divine.Protobufs.Dota2.CMvpData.Types.md).[MvpDatum](Divine.Protobufs.Dota2.CMvpData.Types.MvpDatum.md).[Types](Divine.Protobufs.Dota2.CMvpData.Types.MvpDatum.Types.md).[MvpAccolade](Divine.Protobufs.Dota2.CMvpData.Types.MvpDatum.Types.MvpAccolade.md)\>

### <a id="Divine_Protobufs_Dota2_CMvpData_Types_MvpDatum_Types_MvpAccolade_Type"></a> Type

```csharp
public CMvpData.Types.MvpDatum.Types.MvpAccolade.Types.MvpAccoladeType Type { get; set; }
```

#### Property Value

 [CMvpData](Divine.Protobufs.Dota2.CMvpData.md).[Types](Divine.Protobufs.Dota2.CMvpData.Types.md).[MvpDatum](Divine.Protobufs.Dota2.CMvpData.Types.MvpDatum.md).[Types](Divine.Protobufs.Dota2.CMvpData.Types.MvpDatum.Types.md).[MvpAccolade](Divine.Protobufs.Dota2.CMvpData.Types.MvpDatum.Types.MvpAccolade.md).[Types](Divine.Protobufs.Dota2.CMvpData.Types.MvpDatum.Types.MvpAccolade.Types.md).[MvpAccoladeType](Divine.Protobufs.Dota2.CMvpData.Types.MvpDatum.Types.MvpAccolade.Types.MvpAccoladeType.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMvpData_Types_MvpDatum_Types_MvpAccolade_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMvpData_Types_MvpDatum_Types_MvpAccolade_ClearDetailValue"></a> ClearDetailValue\(\)

```csharp
public void ClearDetailValue()
```

### <a id="Divine_Protobufs_Dota2_CMvpData_Types_MvpDatum_Types_MvpAccolade_ClearType"></a> ClearType\(\)

```csharp
public void ClearType()
```

### <a id="Divine_Protobufs_Dota2_CMvpData_Types_MvpDatum_Types_MvpAccolade_Clone"></a> Clone\(\)

```csharp
public CMvpData.Types.MvpDatum.Types.MvpAccolade Clone()
```

#### Returns

 [CMvpData](Divine.Protobufs.Dota2.CMvpData.md).[Types](Divine.Protobufs.Dota2.CMvpData.Types.md).[MvpDatum](Divine.Protobufs.Dota2.CMvpData.Types.MvpDatum.md).[Types](Divine.Protobufs.Dota2.CMvpData.Types.MvpDatum.Types.md).[MvpAccolade](Divine.Protobufs.Dota2.CMvpData.Types.MvpDatum.Types.MvpAccolade.md)

### <a id="Divine_Protobufs_Dota2_CMvpData_Types_MvpDatum_Types_MvpAccolade_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMvpData_Types_MvpDatum_Types_MvpAccolade_Equals_Divine_Protobufs_Dota2_CMvpData_Types_MvpDatum_Types_MvpAccolade_"></a> Equals\(MvpAccolade\)

```csharp
public bool Equals(CMvpData.Types.MvpDatum.Types.MvpAccolade other)
```

#### Parameters

`other` [CMvpData](Divine.Protobufs.Dota2.CMvpData.md).[Types](Divine.Protobufs.Dota2.CMvpData.Types.md).[MvpDatum](Divine.Protobufs.Dota2.CMvpData.Types.MvpDatum.md).[Types](Divine.Protobufs.Dota2.CMvpData.Types.MvpDatum.Types.md).[MvpAccolade](Divine.Protobufs.Dota2.CMvpData.Types.MvpDatum.Types.MvpAccolade.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMvpData_Types_MvpDatum_Types_MvpAccolade_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMvpData_Types_MvpDatum_Types_MvpAccolade_MergeFrom_Divine_Protobufs_Dota2_CMvpData_Types_MvpDatum_Types_MvpAccolade_"></a> MergeFrom\(MvpAccolade\)

```csharp
public void MergeFrom(CMvpData.Types.MvpDatum.Types.MvpAccolade other)
```

#### Parameters

`other` [CMvpData](Divine.Protobufs.Dota2.CMvpData.md).[Types](Divine.Protobufs.Dota2.CMvpData.Types.md).[MvpDatum](Divine.Protobufs.Dota2.CMvpData.Types.MvpDatum.md).[Types](Divine.Protobufs.Dota2.CMvpData.Types.MvpDatum.Types.md).[MvpAccolade](Divine.Protobufs.Dota2.CMvpData.Types.MvpDatum.Types.MvpAccolade.md)

### <a id="Divine_Protobufs_Dota2_CMvpData_Types_MvpDatum_Types_MvpAccolade_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMvpData_Types_MvpDatum_Types_MvpAccolade_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMvpData_Types_MvpDatum_Types_MvpAccolade_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

