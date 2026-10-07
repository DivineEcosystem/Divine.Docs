# <a id="Divine_Protobufs_Dota2_CMsgTEBeamEnts"></a> Class CMsgTEBeamEnts

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgTEBeamEnts : IMessage<CMsgTEBeamEnts>, IEquatable<CMsgTEBeamEnts>, IDeepCloneable<CMsgTEBeamEnts>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgTEBeamEnts](Divine.Protobufs.Dota2.CMsgTEBeamEnts.md)

#### Implements

IMessage<CMsgTEBeamEnts\>, 
[IEquatable<CMsgTEBeamEnts\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgTEBeamEnts\>, 
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
[EnumerableExtensions.In<CMsgTEBeamEnts\>\(CMsgTEBeamEnts, params CMsgTEBeamEnts\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamEnts__ctor"></a> CMsgTEBeamEnts\(\)

```csharp
public CMsgTEBeamEnts()
```

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamEnts__ctor_Divine_Protobufs_Dota2_CMsgTEBeamEnts_"></a> CMsgTEBeamEnts\(CMsgTEBeamEnts\)

```csharp
public CMsgTEBeamEnts(CMsgTEBeamEnts other)
```

#### Parameters

`other` [CMsgTEBeamEnts](Divine.Protobufs.Dota2.CMsgTEBeamEnts.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamEnts_BaseFieldNumber"></a> BaseFieldNumber

```csharp
public const int BaseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamEnts_EndentityFieldNumber"></a> EndentityFieldNumber

```csharp
public const int EndentityFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamEnts_StartentityFieldNumber"></a> StartentityFieldNumber

```csharp
public const int StartentityFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamEnts_Base"></a> Base

```csharp
public CMsgTEBaseBeam Base { get; set; }
```

#### Property Value

 [CMsgTEBaseBeam](Divine.Protobufs.Dota2.CMsgTEBaseBeam.md)

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamEnts_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamEnts_Endentity"></a> Endentity

```csharp
public uint Endentity { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamEnts_HasEndentity"></a> HasEndentity

```csharp
public bool HasEndentity { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamEnts_HasStartentity"></a> HasStartentity

```csharp
public bool HasStartentity { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamEnts_Parser"></a> Parser

```csharp
public static MessageParser<CMsgTEBeamEnts> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgTEBeamEnts](Divine.Protobufs.Dota2.CMsgTEBeamEnts.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamEnts_Startentity"></a> Startentity

```csharp
public uint Startentity { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamEnts_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamEnts_ClearEndentity"></a> ClearEndentity\(\)

```csharp
public void ClearEndentity()
```

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamEnts_ClearStartentity"></a> ClearStartentity\(\)

```csharp
public void ClearStartentity()
```

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamEnts_Clone"></a> Clone\(\)

```csharp
public CMsgTEBeamEnts Clone()
```

#### Returns

 [CMsgTEBeamEnts](Divine.Protobufs.Dota2.CMsgTEBeamEnts.md)

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamEnts_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamEnts_Equals_Divine_Protobufs_Dota2_CMsgTEBeamEnts_"></a> Equals\(CMsgTEBeamEnts\)

```csharp
public bool Equals(CMsgTEBeamEnts other)
```

#### Parameters

`other` [CMsgTEBeamEnts](Divine.Protobufs.Dota2.CMsgTEBeamEnts.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamEnts_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamEnts_MergeFrom_Divine_Protobufs_Dota2_CMsgTEBeamEnts_"></a> MergeFrom\(CMsgTEBeamEnts\)

```csharp
public void MergeFrom(CMsgTEBeamEnts other)
```

#### Parameters

`other` [CMsgTEBeamEnts](Divine.Protobufs.Dota2.CMsgTEBeamEnts.md)

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamEnts_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamEnts_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgTEBeamEnts_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

