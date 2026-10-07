# <a id="Divine_Protobufs_Dota2_CMsg_CVars"></a> Class CMsg\_CVars

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsg_CVars : IMessage<CMsg_CVars>, IEquatable<CMsg_CVars>, IDeepCloneable<CMsg_CVars>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsg\_CVars](Divine.Protobufs.Dota2.CMsg\_CVars.md)

#### Implements

IMessage<CMsg\_CVars\>, 
[IEquatable<CMsg\_CVars\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsg\_CVars\>, 
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
[EnumerableExtensions.In<CMsg\_CVars\>\(CMsg\_CVars, params CMsg\_CVars\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsg_CVars__ctor"></a> CMsg\_CVars\(\)

```csharp
public CMsg_CVars()
```

### <a id="Divine_Protobufs_Dota2_CMsg_CVars__ctor_Divine_Protobufs_Dota2_CMsg_CVars_"></a> CMsg\_CVars\(CMsg\_CVars\)

```csharp
public CMsg_CVars(CMsg_CVars other)
```

#### Parameters

`other` [CMsg\_CVars](Divine.Protobufs.Dota2.CMsg\_CVars.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsg_CVars_CvarsFieldNumber"></a> CvarsFieldNumber

```csharp
public const int CvarsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsg_CVars_Cvars"></a> Cvars

```csharp
public RepeatedField<CMsg_CVars.Types.CVar> Cvars { get; }
```

#### Property Value

 RepeatedField<[CMsg\_CVars](Divine.Protobufs.Dota2.CMsg\_CVars.md).[Types](Divine.Protobufs.Dota2.CMsg\_CVars.Types.md).[CVar](Divine.Protobufs.Dota2.CMsg\_CVars.Types.CVar.md)\>

### <a id="Divine_Protobufs_Dota2_CMsg_CVars_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsg_CVars_Parser"></a> Parser

```csharp
public static MessageParser<CMsg_CVars> Parser { get; }
```

#### Property Value

 MessageParser<[CMsg\_CVars](Divine.Protobufs.Dota2.CMsg\_CVars.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsg_CVars_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsg_CVars_Clone"></a> Clone\(\)

```csharp
public CMsg_CVars Clone()
```

#### Returns

 [CMsg\_CVars](Divine.Protobufs.Dota2.CMsg\_CVars.md)

### <a id="Divine_Protobufs_Dota2_CMsg_CVars_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsg_CVars_Equals_Divine_Protobufs_Dota2_CMsg_CVars_"></a> Equals\(CMsg\_CVars\)

```csharp
public bool Equals(CMsg_CVars other)
```

#### Parameters

`other` [CMsg\_CVars](Divine.Protobufs.Dota2.CMsg\_CVars.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsg_CVars_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsg_CVars_MergeFrom_Divine_Protobufs_Dota2_CMsg_CVars_"></a> MergeFrom\(CMsg\_CVars\)

```csharp
public void MergeFrom(CMsg_CVars other)
```

#### Parameters

`other` [CMsg\_CVars](Divine.Protobufs.Dota2.CMsg\_CVars.md)

### <a id="Divine_Protobufs_Dota2_CMsg_CVars_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsg_CVars_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsg_CVars_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

