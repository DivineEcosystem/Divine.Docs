# <a id="Divine_Protobufs_Dota2_CMsgTEDust"></a> Class CMsgTEDust

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgTEDust : IMessage<CMsgTEDust>, IEquatable<CMsgTEDust>, IDeepCloneable<CMsgTEDust>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgTEDust](Divine.Protobufs.Dota2.CMsgTEDust.md)

#### Implements

IMessage<CMsgTEDust\>, 
[IEquatable<CMsgTEDust\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgTEDust\>, 
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
[EnumerableExtensions.In<CMsgTEDust\>\(CMsgTEDust, params CMsgTEDust\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgTEDust__ctor"></a> CMsgTEDust\(\)

```csharp
public CMsgTEDust()
```

### <a id="Divine_Protobufs_Dota2_CMsgTEDust__ctor_Divine_Protobufs_Dota2_CMsgTEDust_"></a> CMsgTEDust\(CMsgTEDust\)

```csharp
public CMsgTEDust(CMsgTEDust other)
```

#### Parameters

`other` [CMsgTEDust](Divine.Protobufs.Dota2.CMsgTEDust.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgTEDust_DirectionFieldNumber"></a> DirectionFieldNumber

```csharp
public const int DirectionFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEDust_OriginFieldNumber"></a> OriginFieldNumber

```csharp
public const int OriginFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEDust_SizeFieldNumber"></a> SizeFieldNumber

```csharp
public const int SizeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEDust_SpeedFieldNumber"></a> SpeedFieldNumber

```csharp
public const int SpeedFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgTEDust_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgTEDust_Direction"></a> Direction

```csharp
public CMsgVector Direction { get; set; }
```

#### Property Value

 [CMsgVector](Divine.Protobufs.Dota2.CMsgVector.md)

### <a id="Divine_Protobufs_Dota2_CMsgTEDust_HasSize"></a> HasSize

```csharp
public bool HasSize { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEDust_HasSpeed"></a> HasSpeed

```csharp
public bool HasSpeed { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEDust_Origin"></a> Origin

```csharp
public CMsgVector Origin { get; set; }
```

#### Property Value

 [CMsgVector](Divine.Protobufs.Dota2.CMsgVector.md)

### <a id="Divine_Protobufs_Dota2_CMsgTEDust_Parser"></a> Parser

```csharp
public static MessageParser<CMsgTEDust> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgTEDust](Divine.Protobufs.Dota2.CMsgTEDust.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgTEDust_Size"></a> Size

```csharp
public float Size { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgTEDust_Speed"></a> Speed

```csharp
public float Speed { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgTEDust_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEDust_ClearSize"></a> ClearSize\(\)

```csharp
public void ClearSize()
```

### <a id="Divine_Protobufs_Dota2_CMsgTEDust_ClearSpeed"></a> ClearSpeed\(\)

```csharp
public void ClearSpeed()
```

### <a id="Divine_Protobufs_Dota2_CMsgTEDust_Clone"></a> Clone\(\)

```csharp
public CMsgTEDust Clone()
```

#### Returns

 [CMsgTEDust](Divine.Protobufs.Dota2.CMsgTEDust.md)

### <a id="Divine_Protobufs_Dota2_CMsgTEDust_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEDust_Equals_Divine_Protobufs_Dota2_CMsgTEDust_"></a> Equals\(CMsgTEDust\)

```csharp
public bool Equals(CMsgTEDust other)
```

#### Parameters

`other` [CMsgTEDust](Divine.Protobufs.Dota2.CMsgTEDust.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEDust_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEDust_MergeFrom_Divine_Protobufs_Dota2_CMsgTEDust_"></a> MergeFrom\(CMsgTEDust\)

```csharp
public void MergeFrom(CMsgTEDust other)
```

#### Parameters

`other` [CMsgTEDust](Divine.Protobufs.Dota2.CMsgTEDust.md)

### <a id="Divine_Protobufs_Dota2_CMsgTEDust_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgTEDust_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgTEDust_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

