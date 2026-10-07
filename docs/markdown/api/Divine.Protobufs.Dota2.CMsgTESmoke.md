# <a id="Divine_Protobufs_Dota2_CMsgTESmoke"></a> Class CMsgTESmoke

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgTESmoke : IMessage<CMsgTESmoke>, IEquatable<CMsgTESmoke>, IDeepCloneable<CMsgTESmoke>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgTESmoke](Divine.Protobufs.Dota2.CMsgTESmoke.md)

#### Implements

IMessage<CMsgTESmoke\>, 
[IEquatable<CMsgTESmoke\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgTESmoke\>, 
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
[EnumerableExtensions.In<CMsgTESmoke\>\(CMsgTESmoke, params CMsgTESmoke\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgTESmoke__ctor"></a> CMsgTESmoke\(\)

```csharp
public CMsgTESmoke()
```

### <a id="Divine_Protobufs_Dota2_CMsgTESmoke__ctor_Divine_Protobufs_Dota2_CMsgTESmoke_"></a> CMsgTESmoke\(CMsgTESmoke\)

```csharp
public CMsgTESmoke(CMsgTESmoke other)
```

#### Parameters

`other` [CMsgTESmoke](Divine.Protobufs.Dota2.CMsgTESmoke.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgTESmoke_OriginFieldNumber"></a> OriginFieldNumber

```csharp
public const int OriginFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTESmoke_ScaleFieldNumber"></a> ScaleFieldNumber

```csharp
public const int ScaleFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgTESmoke_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgTESmoke_HasScale"></a> HasScale

```csharp
public bool HasScale { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTESmoke_Origin"></a> Origin

```csharp
public CMsgVector Origin { get; set; }
```

#### Property Value

 [CMsgVector](Divine.Protobufs.Dota2.CMsgVector.md)

### <a id="Divine_Protobufs_Dota2_CMsgTESmoke_Parser"></a> Parser

```csharp
public static MessageParser<CMsgTESmoke> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgTESmoke](Divine.Protobufs.Dota2.CMsgTESmoke.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgTESmoke_Scale"></a> Scale

```csharp
public float Scale { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgTESmoke_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTESmoke_ClearScale"></a> ClearScale\(\)

```csharp
public void ClearScale()
```

### <a id="Divine_Protobufs_Dota2_CMsgTESmoke_Clone"></a> Clone\(\)

```csharp
public CMsgTESmoke Clone()
```

#### Returns

 [CMsgTESmoke](Divine.Protobufs.Dota2.CMsgTESmoke.md)

### <a id="Divine_Protobufs_Dota2_CMsgTESmoke_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTESmoke_Equals_Divine_Protobufs_Dota2_CMsgTESmoke_"></a> Equals\(CMsgTESmoke\)

```csharp
public bool Equals(CMsgTESmoke other)
```

#### Parameters

`other` [CMsgTESmoke](Divine.Protobufs.Dota2.CMsgTESmoke.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTESmoke_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTESmoke_MergeFrom_Divine_Protobufs_Dota2_CMsgTESmoke_"></a> MergeFrom\(CMsgTESmoke\)

```csharp
public void MergeFrom(CMsgTESmoke other)
```

#### Parameters

`other` [CMsgTESmoke](Divine.Protobufs.Dota2.CMsgTESmoke.md)

### <a id="Divine_Protobufs_Dota2_CMsgTESmoke_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgTESmoke_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgTESmoke_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

