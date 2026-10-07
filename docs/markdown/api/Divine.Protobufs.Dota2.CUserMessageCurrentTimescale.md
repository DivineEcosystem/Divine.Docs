# <a id="Divine_Protobufs_Dota2_CUserMessageCurrentTimescale"></a> Class CUserMessageCurrentTimescale

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMessageCurrentTimescale : IMessage<CUserMessageCurrentTimescale>, IEquatable<CUserMessageCurrentTimescale>, IDeepCloneable<CUserMessageCurrentTimescale>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMessageCurrentTimescale](Divine.Protobufs.Dota2.CUserMessageCurrentTimescale.md)

#### Implements

IMessage<CUserMessageCurrentTimescale\>, 
[IEquatable<CUserMessageCurrentTimescale\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMessageCurrentTimescale\>, 
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
[EnumerableExtensions.In<CUserMessageCurrentTimescale\>\(CUserMessageCurrentTimescale, params CUserMessageCurrentTimescale\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMessageCurrentTimescale__ctor"></a> CUserMessageCurrentTimescale\(\)

```csharp
public CUserMessageCurrentTimescale()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageCurrentTimescale__ctor_Divine_Protobufs_Dota2_CUserMessageCurrentTimescale_"></a> CUserMessageCurrentTimescale\(CUserMessageCurrentTimescale\)

```csharp
public CUserMessageCurrentTimescale(CUserMessageCurrentTimescale other)
```

#### Parameters

`other` [CUserMessageCurrentTimescale](Divine.Protobufs.Dota2.CUserMessageCurrentTimescale.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMessageCurrentTimescale_CurrentFieldNumber"></a> CurrentFieldNumber

```csharp
public const int CurrentFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMessageCurrentTimescale_Current"></a> Current

```csharp
public float Current { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CUserMessageCurrentTimescale_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMessageCurrentTimescale_HasCurrent"></a> HasCurrent

```csharp
public bool HasCurrent { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageCurrentTimescale_Parser"></a> Parser

```csharp
public static MessageParser<CUserMessageCurrentTimescale> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMessageCurrentTimescale](Divine.Protobufs.Dota2.CUserMessageCurrentTimescale.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMessageCurrentTimescale_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageCurrentTimescale_ClearCurrent"></a> ClearCurrent\(\)

```csharp
public void ClearCurrent()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageCurrentTimescale_Clone"></a> Clone\(\)

```csharp
public CUserMessageCurrentTimescale Clone()
```

#### Returns

 [CUserMessageCurrentTimescale](Divine.Protobufs.Dota2.CUserMessageCurrentTimescale.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageCurrentTimescale_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageCurrentTimescale_Equals_Divine_Protobufs_Dota2_CUserMessageCurrentTimescale_"></a> Equals\(CUserMessageCurrentTimescale\)

```csharp
public bool Equals(CUserMessageCurrentTimescale other)
```

#### Parameters

`other` [CUserMessageCurrentTimescale](Divine.Protobufs.Dota2.CUserMessageCurrentTimescale.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageCurrentTimescale_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageCurrentTimescale_MergeFrom_Divine_Protobufs_Dota2_CUserMessageCurrentTimescale_"></a> MergeFrom\(CUserMessageCurrentTimescale\)

```csharp
public void MergeFrom(CUserMessageCurrentTimescale other)
```

#### Parameters

`other` [CUserMessageCurrentTimescale](Divine.Protobufs.Dota2.CUserMessageCurrentTimescale.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageCurrentTimescale_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMessageCurrentTimescale_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessageCurrentTimescale_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

