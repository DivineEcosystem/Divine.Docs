# <a id="Divine_Protobufs_Dota2_CMsgTEFizz"></a> Class CMsgTEFizz

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgTEFizz : IMessage<CMsgTEFizz>, IEquatable<CMsgTEFizz>, IDeepCloneable<CMsgTEFizz>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgTEFizz](Divine.Protobufs.Dota2.CMsgTEFizz.md)

#### Implements

IMessage<CMsgTEFizz\>, 
[IEquatable<CMsgTEFizz\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgTEFizz\>, 
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
[EnumerableExtensions.In<CMsgTEFizz\>\(CMsgTEFizz, params CMsgTEFizz\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgTEFizz__ctor"></a> CMsgTEFizz\(\)

```csharp
public CMsgTEFizz()
```

### <a id="Divine_Protobufs_Dota2_CMsgTEFizz__ctor_Divine_Protobufs_Dota2_CMsgTEFizz_"></a> CMsgTEFizz\(CMsgTEFizz\)

```csharp
public CMsgTEFizz(CMsgTEFizz other)
```

#### Parameters

`other` [CMsgTEFizz](Divine.Protobufs.Dota2.CMsgTEFizz.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgTEFizz_CurrentFieldNumber"></a> CurrentFieldNumber

```csharp
public const int CurrentFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEFizz_DensityFieldNumber"></a> DensityFieldNumber

```csharp
public const int DensityFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEFizz_EntityFieldNumber"></a> EntityFieldNumber

```csharp
public const int EntityFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgTEFizz_Current"></a> Current

```csharp
public int Current { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEFizz_Density"></a> Density

```csharp
public uint Density { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgTEFizz_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgTEFizz_Entity"></a> Entity

```csharp
public int Entity { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEFizz_HasCurrent"></a> HasCurrent

```csharp
public bool HasCurrent { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEFizz_HasDensity"></a> HasDensity

```csharp
public bool HasDensity { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEFizz_HasEntity"></a> HasEntity

```csharp
public bool HasEntity { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEFizz_Parser"></a> Parser

```csharp
public static MessageParser<CMsgTEFizz> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgTEFizz](Divine.Protobufs.Dota2.CMsgTEFizz.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgTEFizz_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEFizz_ClearCurrent"></a> ClearCurrent\(\)

```csharp
public void ClearCurrent()
```

### <a id="Divine_Protobufs_Dota2_CMsgTEFizz_ClearDensity"></a> ClearDensity\(\)

```csharp
public void ClearDensity()
```

### <a id="Divine_Protobufs_Dota2_CMsgTEFizz_ClearEntity"></a> ClearEntity\(\)

```csharp
public void ClearEntity()
```

### <a id="Divine_Protobufs_Dota2_CMsgTEFizz_Clone"></a> Clone\(\)

```csharp
public CMsgTEFizz Clone()
```

#### Returns

 [CMsgTEFizz](Divine.Protobufs.Dota2.CMsgTEFizz.md)

### <a id="Divine_Protobufs_Dota2_CMsgTEFizz_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEFizz_Equals_Divine_Protobufs_Dota2_CMsgTEFizz_"></a> Equals\(CMsgTEFizz\)

```csharp
public bool Equals(CMsgTEFizz other)
```

#### Parameters

`other` [CMsgTEFizz](Divine.Protobufs.Dota2.CMsgTEFizz.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEFizz_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEFizz_MergeFrom_Divine_Protobufs_Dota2_CMsgTEFizz_"></a> MergeFrom\(CMsgTEFizz\)

```csharp
public void MergeFrom(CMsgTEFizz other)
```

#### Parameters

`other` [CMsgTEFizz](Divine.Protobufs.Dota2.CMsgTEFizz.md)

### <a id="Divine_Protobufs_Dota2_CMsgTEFizz_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgTEFizz_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgTEFizz_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

