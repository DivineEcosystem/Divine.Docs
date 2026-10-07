# <a id="Divine_Protobufs_Dota2_CMsgTEBeamRing"></a> Class CMsgTEBeamRing

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgTEBeamRing : IMessage<CMsgTEBeamRing>, IEquatable<CMsgTEBeamRing>, IDeepCloneable<CMsgTEBeamRing>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgTEBeamRing](Divine.Protobufs.Dota2.CMsgTEBeamRing.md)

#### Implements

IMessage<CMsgTEBeamRing\>, 
[IEquatable<CMsgTEBeamRing\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgTEBeamRing\>, 
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
[EnumerableExtensions.In<CMsgTEBeamRing\>\(CMsgTEBeamRing, params CMsgTEBeamRing\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamRing__ctor"></a> CMsgTEBeamRing\(\)

```csharp
public CMsgTEBeamRing()
```

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamRing__ctor_Divine_Protobufs_Dota2_CMsgTEBeamRing_"></a> CMsgTEBeamRing\(CMsgTEBeamRing\)

```csharp
public CMsgTEBeamRing(CMsgTEBeamRing other)
```

#### Parameters

`other` [CMsgTEBeamRing](Divine.Protobufs.Dota2.CMsgTEBeamRing.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamRing_BaseFieldNumber"></a> BaseFieldNumber

```csharp
public const int BaseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamRing_EndentityFieldNumber"></a> EndentityFieldNumber

```csharp
public const int EndentityFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamRing_StartentityFieldNumber"></a> StartentityFieldNumber

```csharp
public const int StartentityFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamRing_Base"></a> Base

```csharp
public CMsgTEBaseBeam Base { get; set; }
```

#### Property Value

 [CMsgTEBaseBeam](Divine.Protobufs.Dota2.CMsgTEBaseBeam.md)

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamRing_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamRing_Endentity"></a> Endentity

```csharp
public uint Endentity { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamRing_HasEndentity"></a> HasEndentity

```csharp
public bool HasEndentity { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamRing_HasStartentity"></a> HasStartentity

```csharp
public bool HasStartentity { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamRing_Parser"></a> Parser

```csharp
public static MessageParser<CMsgTEBeamRing> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgTEBeamRing](Divine.Protobufs.Dota2.CMsgTEBeamRing.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamRing_Startentity"></a> Startentity

```csharp
public uint Startentity { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamRing_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamRing_ClearEndentity"></a> ClearEndentity\(\)

```csharp
public void ClearEndentity()
```

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamRing_ClearStartentity"></a> ClearStartentity\(\)

```csharp
public void ClearStartentity()
```

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamRing_Clone"></a> Clone\(\)

```csharp
public CMsgTEBeamRing Clone()
```

#### Returns

 [CMsgTEBeamRing](Divine.Protobufs.Dota2.CMsgTEBeamRing.md)

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamRing_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamRing_Equals_Divine_Protobufs_Dota2_CMsgTEBeamRing_"></a> Equals\(CMsgTEBeamRing\)

```csharp
public bool Equals(CMsgTEBeamRing other)
```

#### Parameters

`other` [CMsgTEBeamRing](Divine.Protobufs.Dota2.CMsgTEBeamRing.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamRing_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamRing_MergeFrom_Divine_Protobufs_Dota2_CMsgTEBeamRing_"></a> MergeFrom\(CMsgTEBeamRing\)

```csharp
public void MergeFrom(CMsgTEBeamRing other)
```

#### Parameters

`other` [CMsgTEBeamRing](Divine.Protobufs.Dota2.CMsgTEBeamRing.md)

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamRing_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamRing_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamRing_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

