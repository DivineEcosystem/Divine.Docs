# <a id="Divine_Protobufs_Dota2_CUserMessageFade"></a> Class CUserMessageFade

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMessageFade : IMessage<CUserMessageFade>, IEquatable<CUserMessageFade>, IDeepCloneable<CUserMessageFade>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMessageFade](Divine.Protobufs.Dota2.CUserMessageFade.md)

#### Implements

IMessage<CUserMessageFade\>, 
[IEquatable<CUserMessageFade\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMessageFade\>, 
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
[EnumerableExtensions.In<CUserMessageFade\>\(CUserMessageFade, params CUserMessageFade\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMessageFade__ctor"></a> CUserMessageFade\(\)

```csharp
public CUserMessageFade()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageFade__ctor_Divine_Protobufs_Dota2_CUserMessageFade_"></a> CUserMessageFade\(CUserMessageFade\)

```csharp
public CUserMessageFade(CUserMessageFade other)
```

#### Parameters

`other` [CUserMessageFade](Divine.Protobufs.Dota2.CUserMessageFade.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMessageFade_ColorFieldNumber"></a> ColorFieldNumber

```csharp
public const int ColorFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageFade_DurationFieldNumber"></a> DurationFieldNumber

```csharp
public const int DurationFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageFade_FlagsFieldNumber"></a> FlagsFieldNumber

```csharp
public const int FlagsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageFade_HoldTimeFieldNumber"></a> HoldTimeFieldNumber

```csharp
public const int HoldTimeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMessageFade_Color"></a> Color

```csharp
public uint Color { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CUserMessageFade_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMessageFade_Duration"></a> Duration

```csharp
public uint Duration { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CUserMessageFade_Flags"></a> Flags

```csharp
public uint Flags { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CUserMessageFade_HasColor"></a> HasColor

```csharp
public bool HasColor { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageFade_HasDuration"></a> HasDuration

```csharp
public bool HasDuration { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageFade_HasFlags"></a> HasFlags

```csharp
public bool HasFlags { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageFade_HasHoldTime"></a> HasHoldTime

```csharp
public bool HasHoldTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageFade_HoldTime"></a> HoldTime

```csharp
public uint HoldTime { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CUserMessageFade_Parser"></a> Parser

```csharp
public static MessageParser<CUserMessageFade> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMessageFade](Divine.Protobufs.Dota2.CUserMessageFade.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMessageFade_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageFade_ClearColor"></a> ClearColor\(\)

```csharp
public void ClearColor()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageFade_ClearDuration"></a> ClearDuration\(\)

```csharp
public void ClearDuration()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageFade_ClearFlags"></a> ClearFlags\(\)

```csharp
public void ClearFlags()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageFade_ClearHoldTime"></a> ClearHoldTime\(\)

```csharp
public void ClearHoldTime()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageFade_Clone"></a> Clone\(\)

```csharp
public CUserMessageFade Clone()
```

#### Returns

 [CUserMessageFade](Divine.Protobufs.Dota2.CUserMessageFade.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageFade_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageFade_Equals_Divine_Protobufs_Dota2_CUserMessageFade_"></a> Equals\(CUserMessageFade\)

```csharp
public bool Equals(CUserMessageFade other)
```

#### Parameters

`other` [CUserMessageFade](Divine.Protobufs.Dota2.CUserMessageFade.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageFade_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageFade_MergeFrom_Divine_Protobufs_Dota2_CUserMessageFade_"></a> MergeFrom\(CUserMessageFade\)

```csharp
public void MergeFrom(CUserMessageFade other)
```

#### Parameters

`other` [CUserMessageFade](Divine.Protobufs.Dota2.CUserMessageFade.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageFade_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMessageFade_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessageFade_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

