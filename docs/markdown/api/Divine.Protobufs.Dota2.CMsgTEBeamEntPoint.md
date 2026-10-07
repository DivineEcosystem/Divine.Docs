# <a id="Divine_Protobufs_Dota2_CMsgTEBeamEntPoint"></a> Class CMsgTEBeamEntPoint

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgTEBeamEntPoint : IMessage<CMsgTEBeamEntPoint>, IEquatable<CMsgTEBeamEntPoint>, IDeepCloneable<CMsgTEBeamEntPoint>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgTEBeamEntPoint](Divine.Protobufs.Dota2.CMsgTEBeamEntPoint.md)

#### Implements

IMessage<CMsgTEBeamEntPoint\>, 
[IEquatable<CMsgTEBeamEntPoint\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgTEBeamEntPoint\>, 
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
[EnumerableExtensions.In<CMsgTEBeamEntPoint\>\(CMsgTEBeamEntPoint, params CMsgTEBeamEntPoint\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamEntPoint__ctor"></a> CMsgTEBeamEntPoint\(\)

```csharp
public CMsgTEBeamEntPoint()
```

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamEntPoint__ctor_Divine_Protobufs_Dota2_CMsgTEBeamEntPoint_"></a> CMsgTEBeamEntPoint\(CMsgTEBeamEntPoint\)

```csharp
public CMsgTEBeamEntPoint(CMsgTEBeamEntPoint other)
```

#### Parameters

`other` [CMsgTEBeamEntPoint](Divine.Protobufs.Dota2.CMsgTEBeamEntPoint.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamEntPoint_BaseFieldNumber"></a> BaseFieldNumber

```csharp
public const int BaseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamEntPoint_EndentityFieldNumber"></a> EndentityFieldNumber

```csharp
public const int EndentityFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamEntPoint_EndFieldNumber"></a> EndFieldNumber

```csharp
public const int EndFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamEntPoint_StartentityFieldNumber"></a> StartentityFieldNumber

```csharp
public const int StartentityFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamEntPoint_StartFieldNumber"></a> StartFieldNumber

```csharp
public const int StartFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamEntPoint_Base"></a> Base

```csharp
public CMsgTEBaseBeam Base { get; set; }
```

#### Property Value

 [CMsgTEBaseBeam](Divine.Protobufs.Dota2.CMsgTEBaseBeam.md)

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamEntPoint_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamEntPoint_End"></a> End

```csharp
public CMsgVector End { get; set; }
```

#### Property Value

 [CMsgVector](Divine.Protobufs.Dota2.CMsgVector.md)

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamEntPoint_Endentity"></a> Endentity

```csharp
public uint Endentity { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamEntPoint_HasEndentity"></a> HasEndentity

```csharp
public bool HasEndentity { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamEntPoint_HasStartentity"></a> HasStartentity

```csharp
public bool HasStartentity { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamEntPoint_Parser"></a> Parser

```csharp
public static MessageParser<CMsgTEBeamEntPoint> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgTEBeamEntPoint](Divine.Protobufs.Dota2.CMsgTEBeamEntPoint.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamEntPoint_Start"></a> Start

```csharp
public CMsgVector Start { get; set; }
```

#### Property Value

 [CMsgVector](Divine.Protobufs.Dota2.CMsgVector.md)

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamEntPoint_Startentity"></a> Startentity

```csharp
public uint Startentity { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamEntPoint_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamEntPoint_ClearEndentity"></a> ClearEndentity\(\)

```csharp
public void ClearEndentity()
```

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamEntPoint_ClearStartentity"></a> ClearStartentity\(\)

```csharp
public void ClearStartentity()
```

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamEntPoint_Clone"></a> Clone\(\)

```csharp
public CMsgTEBeamEntPoint Clone()
```

#### Returns

 [CMsgTEBeamEntPoint](Divine.Protobufs.Dota2.CMsgTEBeamEntPoint.md)

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamEntPoint_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamEntPoint_Equals_Divine_Protobufs_Dota2_CMsgTEBeamEntPoint_"></a> Equals\(CMsgTEBeamEntPoint\)

```csharp
public bool Equals(CMsgTEBeamEntPoint other)
```

#### Parameters

`other` [CMsgTEBeamEntPoint](Divine.Protobufs.Dota2.CMsgTEBeamEntPoint.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamEntPoint_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamEntPoint_MergeFrom_Divine_Protobufs_Dota2_CMsgTEBeamEntPoint_"></a> MergeFrom\(CMsgTEBeamEntPoint\)

```csharp
public void MergeFrom(CMsgTEBeamEntPoint other)
```

#### Parameters

`other` [CMsgTEBeamEntPoint](Divine.Protobufs.Dota2.CMsgTEBeamEntPoint.md)

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamEntPoint_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamEntPoint_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamEntPoint_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

