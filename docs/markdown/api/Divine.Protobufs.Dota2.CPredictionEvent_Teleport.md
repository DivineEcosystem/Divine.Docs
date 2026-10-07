# <a id="Divine_Protobufs_Dota2_CPredictionEvent_Teleport"></a> Class CPredictionEvent\_Teleport

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CPredictionEvent_Teleport : IMessage<CPredictionEvent_Teleport>, IEquatable<CPredictionEvent_Teleport>, IDeepCloneable<CPredictionEvent_Teleport>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CPredictionEvent\_Teleport](Divine.Protobufs.Dota2.CPredictionEvent\_Teleport.md)

#### Implements

IMessage<CPredictionEvent\_Teleport\>, 
[IEquatable<CPredictionEvent\_Teleport\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CPredictionEvent\_Teleport\>, 
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
[EnumerableExtensions.In<CPredictionEvent\_Teleport\>\(CPredictionEvent\_Teleport, params CPredictionEvent\_Teleport\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CPredictionEvent_Teleport__ctor"></a> CPredictionEvent\_Teleport\(\)

```csharp
public CPredictionEvent_Teleport()
```

### <a id="Divine_Protobufs_Dota2_CPredictionEvent_Teleport__ctor_Divine_Protobufs_Dota2_CPredictionEvent_Teleport_"></a> CPredictionEvent\_Teleport\(CPredictionEvent\_Teleport\)

```csharp
public CPredictionEvent_Teleport(CPredictionEvent_Teleport other)
```

#### Parameters

`other` [CPredictionEvent\_Teleport](Divine.Protobufs.Dota2.CPredictionEvent\_Teleport.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CPredictionEvent_Teleport_AnglesFieldNumber"></a> AnglesFieldNumber

```csharp
public const int AnglesFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CPredictionEvent_Teleport_DropToGroundRangeFieldNumber"></a> DropToGroundRangeFieldNumber

```csharp
public const int DropToGroundRangeFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CPredictionEvent_Teleport_OriginFieldNumber"></a> OriginFieldNumber

```csharp
public const int OriginFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CPredictionEvent_Teleport_VelocityFieldNumber"></a> VelocityFieldNumber

```csharp
public const int VelocityFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CPredictionEvent_Teleport_Angles"></a> Angles

```csharp
public CMsgQAngle Angles { get; set; }
```

#### Property Value

 [CMsgQAngle](Divine.Protobufs.Dota2.CMsgQAngle.md)

### <a id="Divine_Protobufs_Dota2_CPredictionEvent_Teleport_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CPredictionEvent_Teleport_DropToGroundRange"></a> DropToGroundRange

```csharp
public float DropToGroundRange { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CPredictionEvent_Teleport_HasDropToGroundRange"></a> HasDropToGroundRange

```csharp
public bool HasDropToGroundRange { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CPredictionEvent_Teleport_Origin"></a> Origin

```csharp
public CMsgVector Origin { get; set; }
```

#### Property Value

 [CMsgVector](Divine.Protobufs.Dota2.CMsgVector.md)

### <a id="Divine_Protobufs_Dota2_CPredictionEvent_Teleport_Parser"></a> Parser

```csharp
public static MessageParser<CPredictionEvent_Teleport> Parser { get; }
```

#### Property Value

 MessageParser<[CPredictionEvent\_Teleport](Divine.Protobufs.Dota2.CPredictionEvent\_Teleport.md)\>

### <a id="Divine_Protobufs_Dota2_CPredictionEvent_Teleport_Velocity"></a> Velocity

```csharp
public CMsgVector Velocity { get; set; }
```

#### Property Value

 [CMsgVector](Divine.Protobufs.Dota2.CMsgVector.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CPredictionEvent_Teleport_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CPredictionEvent_Teleport_ClearDropToGroundRange"></a> ClearDropToGroundRange\(\)

```csharp
public void ClearDropToGroundRange()
```

### <a id="Divine_Protobufs_Dota2_CPredictionEvent_Teleport_Clone"></a> Clone\(\)

```csharp
public CPredictionEvent_Teleport Clone()
```

#### Returns

 [CPredictionEvent\_Teleport](Divine.Protobufs.Dota2.CPredictionEvent\_Teleport.md)

### <a id="Divine_Protobufs_Dota2_CPredictionEvent_Teleport_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CPredictionEvent_Teleport_Equals_Divine_Protobufs_Dota2_CPredictionEvent_Teleport_"></a> Equals\(CPredictionEvent\_Teleport\)

```csharp
public bool Equals(CPredictionEvent_Teleport other)
```

#### Parameters

`other` [CPredictionEvent\_Teleport](Divine.Protobufs.Dota2.CPredictionEvent\_Teleport.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CPredictionEvent_Teleport_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CPredictionEvent_Teleport_MergeFrom_Divine_Protobufs_Dota2_CPredictionEvent_Teleport_"></a> MergeFrom\(CPredictionEvent\_Teleport\)

```csharp
public void MergeFrom(CPredictionEvent_Teleport other)
```

#### Parameters

`other` [CPredictionEvent\_Teleport](Divine.Protobufs.Dota2.CPredictionEvent\_Teleport.md)

### <a id="Divine_Protobufs_Dota2_CPredictionEvent_Teleport_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CPredictionEvent_Teleport_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CPredictionEvent_Teleport_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

