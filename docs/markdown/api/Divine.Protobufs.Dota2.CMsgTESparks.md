# <a id="Divine_Protobufs_Dota2_CMsgTESparks"></a> Class CMsgTESparks

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgTESparks : IMessage<CMsgTESparks>, IEquatable<CMsgTESparks>, IDeepCloneable<CMsgTESparks>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgTESparks](Divine.Protobufs.Dota2.CMsgTESparks.md)

#### Implements

IMessage<CMsgTESparks\>, 
[IEquatable<CMsgTESparks\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgTESparks\>, 
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
[EnumerableExtensions.In<CMsgTESparks\>\(CMsgTESparks, params CMsgTESparks\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgTESparks__ctor"></a> CMsgTESparks\(\)

```csharp
public CMsgTESparks()
```

### <a id="Divine_Protobufs_Dota2_CMsgTESparks__ctor_Divine_Protobufs_Dota2_CMsgTESparks_"></a> CMsgTESparks\(CMsgTESparks\)

```csharp
public CMsgTESparks(CMsgTESparks other)
```

#### Parameters

`other` [CMsgTESparks](Divine.Protobufs.Dota2.CMsgTESparks.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgTESparks_DirectionFieldNumber"></a> DirectionFieldNumber

```csharp
public const int DirectionFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTESparks_LengthFieldNumber"></a> LengthFieldNumber

```csharp
public const int LengthFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTESparks_MagnitudeFieldNumber"></a> MagnitudeFieldNumber

```csharp
public const int MagnitudeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTESparks_OriginFieldNumber"></a> OriginFieldNumber

```csharp
public const int OriginFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgTESparks_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgTESparks_Direction"></a> Direction

```csharp
public CMsgVector Direction { get; set; }
```

#### Property Value

 [CMsgVector](Divine.Protobufs.Dota2.CMsgVector.md)

### <a id="Divine_Protobufs_Dota2_CMsgTESparks_HasLength"></a> HasLength

```csharp
public bool HasLength { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTESparks_HasMagnitude"></a> HasMagnitude

```csharp
public bool HasMagnitude { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTESparks_Length"></a> Length

```csharp
public uint Length { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgTESparks_Magnitude"></a> Magnitude

```csharp
public uint Magnitude { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgTESparks_Origin"></a> Origin

```csharp
public CMsgVector Origin { get; set; }
```

#### Property Value

 [CMsgVector](Divine.Protobufs.Dota2.CMsgVector.md)

### <a id="Divine_Protobufs_Dota2_CMsgTESparks_Parser"></a> Parser

```csharp
public static MessageParser<CMsgTESparks> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgTESparks](Divine.Protobufs.Dota2.CMsgTESparks.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgTESparks_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTESparks_ClearLength"></a> ClearLength\(\)

```csharp
public void ClearLength()
```

### <a id="Divine_Protobufs_Dota2_CMsgTESparks_ClearMagnitude"></a> ClearMagnitude\(\)

```csharp
public void ClearMagnitude()
```

### <a id="Divine_Protobufs_Dota2_CMsgTESparks_Clone"></a> Clone\(\)

```csharp
public CMsgTESparks Clone()
```

#### Returns

 [CMsgTESparks](Divine.Protobufs.Dota2.CMsgTESparks.md)

### <a id="Divine_Protobufs_Dota2_CMsgTESparks_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTESparks_Equals_Divine_Protobufs_Dota2_CMsgTESparks_"></a> Equals\(CMsgTESparks\)

```csharp
public bool Equals(CMsgTESparks other)
```

#### Parameters

`other` [CMsgTESparks](Divine.Protobufs.Dota2.CMsgTESparks.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTESparks_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTESparks_MergeFrom_Divine_Protobufs_Dota2_CMsgTESparks_"></a> MergeFrom\(CMsgTESparks\)

```csharp
public void MergeFrom(CMsgTESparks other)
```

#### Parameters

`other` [CMsgTESparks](Divine.Protobufs.Dota2.CMsgTESparks.md)

### <a id="Divine_Protobufs_Dota2_CMsgTESparks_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgTESparks_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgTESparks_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

