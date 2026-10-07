# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GlobalLightDirection"></a> Class CDOTAUserMsg\_GlobalLightDirection

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_GlobalLightDirection : IMessage<CDOTAUserMsg_GlobalLightDirection>, IEquatable<CDOTAUserMsg_GlobalLightDirection>, IDeepCloneable<CDOTAUserMsg_GlobalLightDirection>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_GlobalLightDirection](Divine.Protobufs.Dota2.CDOTAUserMsg\_GlobalLightDirection.md)

#### Implements

IMessage<CDOTAUserMsg\_GlobalLightDirection\>, 
[IEquatable<CDOTAUserMsg\_GlobalLightDirection\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_GlobalLightDirection\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_GlobalLightDirection\>\(CDOTAUserMsg\_GlobalLightDirection, params CDOTAUserMsg\_GlobalLightDirection\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GlobalLightDirection__ctor"></a> CDOTAUserMsg\_GlobalLightDirection\(\)

```csharp
public CDOTAUserMsg_GlobalLightDirection()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GlobalLightDirection__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_GlobalLightDirection_"></a> CDOTAUserMsg\_GlobalLightDirection\(CDOTAUserMsg\_GlobalLightDirection\)

```csharp
public CDOTAUserMsg_GlobalLightDirection(CDOTAUserMsg_GlobalLightDirection other)
```

#### Parameters

`other` [CDOTAUserMsg\_GlobalLightDirection](Divine.Protobufs.Dota2.CDOTAUserMsg\_GlobalLightDirection.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GlobalLightDirection_DirectionFieldNumber"></a> DirectionFieldNumber

```csharp
public const int DirectionFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GlobalLightDirection_DurationFieldNumber"></a> DurationFieldNumber

```csharp
public const int DurationFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GlobalLightDirection_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GlobalLightDirection_Direction"></a> Direction

```csharp
public CMsgVector Direction { get; set; }
```

#### Property Value

 [CMsgVector](Divine.Protobufs.Dota2.CMsgVector.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GlobalLightDirection_Duration"></a> Duration

```csharp
public float Duration { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GlobalLightDirection_HasDuration"></a> HasDuration

```csharp
public bool HasDuration { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GlobalLightDirection_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_GlobalLightDirection> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_GlobalLightDirection](Divine.Protobufs.Dota2.CDOTAUserMsg\_GlobalLightDirection.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GlobalLightDirection_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GlobalLightDirection_ClearDuration"></a> ClearDuration\(\)

```csharp
public void ClearDuration()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GlobalLightDirection_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_GlobalLightDirection Clone()
```

#### Returns

 [CDOTAUserMsg\_GlobalLightDirection](Divine.Protobufs.Dota2.CDOTAUserMsg\_GlobalLightDirection.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GlobalLightDirection_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GlobalLightDirection_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_GlobalLightDirection_"></a> Equals\(CDOTAUserMsg\_GlobalLightDirection\)

```csharp
public bool Equals(CDOTAUserMsg_GlobalLightDirection other)
```

#### Parameters

`other` [CDOTAUserMsg\_GlobalLightDirection](Divine.Protobufs.Dota2.CDOTAUserMsg\_GlobalLightDirection.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GlobalLightDirection_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GlobalLightDirection_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_GlobalLightDirection_"></a> MergeFrom\(CDOTAUserMsg\_GlobalLightDirection\)

```csharp
public void MergeFrom(CDOTAUserMsg_GlobalLightDirection other)
```

#### Parameters

`other` [CDOTAUserMsg\_GlobalLightDirection](Divine.Protobufs.Dota2.CDOTAUserMsg\_GlobalLightDirection.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GlobalLightDirection_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GlobalLightDirection_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GlobalLightDirection_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

