# <a id="Divine_Protobufs_Dota2_CSubtickMoveStep"></a> Class CSubtickMoveStep

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSubtickMoveStep : IMessage<CSubtickMoveStep>, IEquatable<CSubtickMoveStep>, IDeepCloneable<CSubtickMoveStep>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSubtickMoveStep](Divine.Protobufs.Dota2.CSubtickMoveStep.md)

#### Implements

IMessage<CSubtickMoveStep\>, 
[IEquatable<CSubtickMoveStep\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSubtickMoveStep\>, 
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
[EnumerableExtensions.In<CSubtickMoveStep\>\(CSubtickMoveStep, params CSubtickMoveStep\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSubtickMoveStep__ctor"></a> CSubtickMoveStep\(\)

```csharp
public CSubtickMoveStep()
```

### <a id="Divine_Protobufs_Dota2_CSubtickMoveStep__ctor_Divine_Protobufs_Dota2_CSubtickMoveStep_"></a> CSubtickMoveStep\(CSubtickMoveStep\)

```csharp
public CSubtickMoveStep(CSubtickMoveStep other)
```

#### Parameters

`other` [CSubtickMoveStep](Divine.Protobufs.Dota2.CSubtickMoveStep.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSubtickMoveStep_AnalogForwardDeltaFieldNumber"></a> AnalogForwardDeltaFieldNumber

```csharp
public const int AnalogForwardDeltaFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSubtickMoveStep_AnalogLeftDeltaFieldNumber"></a> AnalogLeftDeltaFieldNumber

```csharp
public const int AnalogLeftDeltaFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSubtickMoveStep_ButtonFieldNumber"></a> ButtonFieldNumber

```csharp
public const int ButtonFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSubtickMoveStep_PitchDeltaFieldNumber"></a> PitchDeltaFieldNumber

```csharp
public const int PitchDeltaFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSubtickMoveStep_PressedFieldNumber"></a> PressedFieldNumber

```csharp
public const int PressedFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSubtickMoveStep_WhenFieldNumber"></a> WhenFieldNumber

```csharp
public const int WhenFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSubtickMoveStep_YawDeltaFieldNumber"></a> YawDeltaFieldNumber

```csharp
public const int YawDeltaFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSubtickMoveStep_AnalogForwardDelta"></a> AnalogForwardDelta

```csharp
public float AnalogForwardDelta { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CSubtickMoveStep_AnalogLeftDelta"></a> AnalogLeftDelta

```csharp
public float AnalogLeftDelta { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CSubtickMoveStep_Button"></a> Button

```csharp
public ulong Button { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CSubtickMoveStep_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSubtickMoveStep_HasAnalogForwardDelta"></a> HasAnalogForwardDelta

```csharp
public bool HasAnalogForwardDelta { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSubtickMoveStep_HasAnalogLeftDelta"></a> HasAnalogLeftDelta

```csharp
public bool HasAnalogLeftDelta { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSubtickMoveStep_HasButton"></a> HasButton

```csharp
public bool HasButton { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSubtickMoveStep_HasPitchDelta"></a> HasPitchDelta

```csharp
public bool HasPitchDelta { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSubtickMoveStep_HasPressed"></a> HasPressed

```csharp
public bool HasPressed { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSubtickMoveStep_HasWhen"></a> HasWhen

```csharp
public bool HasWhen { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSubtickMoveStep_HasYawDelta"></a> HasYawDelta

```csharp
public bool HasYawDelta { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSubtickMoveStep_Parser"></a> Parser

```csharp
public static MessageParser<CSubtickMoveStep> Parser { get; }
```

#### Property Value

 MessageParser<[CSubtickMoveStep](Divine.Protobufs.Dota2.CSubtickMoveStep.md)\>

### <a id="Divine_Protobufs_Dota2_CSubtickMoveStep_PitchDelta"></a> PitchDelta

```csharp
public float PitchDelta { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CSubtickMoveStep_Pressed"></a> Pressed

```csharp
public bool Pressed { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSubtickMoveStep_When"></a> When

```csharp
public float When { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CSubtickMoveStep_YawDelta"></a> YawDelta

```csharp
public float YawDelta { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Protobufs_Dota2_CSubtickMoveStep_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSubtickMoveStep_ClearAnalogForwardDelta"></a> ClearAnalogForwardDelta\(\)

```csharp
public void ClearAnalogForwardDelta()
```

### <a id="Divine_Protobufs_Dota2_CSubtickMoveStep_ClearAnalogLeftDelta"></a> ClearAnalogLeftDelta\(\)

```csharp
public void ClearAnalogLeftDelta()
```

### <a id="Divine_Protobufs_Dota2_CSubtickMoveStep_ClearButton"></a> ClearButton\(\)

```csharp
public void ClearButton()
```

### <a id="Divine_Protobufs_Dota2_CSubtickMoveStep_ClearPitchDelta"></a> ClearPitchDelta\(\)

```csharp
public void ClearPitchDelta()
```

### <a id="Divine_Protobufs_Dota2_CSubtickMoveStep_ClearPressed"></a> ClearPressed\(\)

```csharp
public void ClearPressed()
```

### <a id="Divine_Protobufs_Dota2_CSubtickMoveStep_ClearWhen"></a> ClearWhen\(\)

```csharp
public void ClearWhen()
```

### <a id="Divine_Protobufs_Dota2_CSubtickMoveStep_ClearYawDelta"></a> ClearYawDelta\(\)

```csharp
public void ClearYawDelta()
```

### <a id="Divine_Protobufs_Dota2_CSubtickMoveStep_Clone"></a> Clone\(\)

```csharp
public CSubtickMoveStep Clone()
```

#### Returns

 [CSubtickMoveStep](Divine.Protobufs.Dota2.CSubtickMoveStep.md)

### <a id="Divine_Protobufs_Dota2_CSubtickMoveStep_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSubtickMoveStep_Equals_Divine_Protobufs_Dota2_CSubtickMoveStep_"></a> Equals\(CSubtickMoveStep\)

```csharp
public bool Equals(CSubtickMoveStep other)
```

#### Parameters

`other` [CSubtickMoveStep](Divine.Protobufs.Dota2.CSubtickMoveStep.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSubtickMoveStep_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSubtickMoveStep_MergeFrom_Divine_Protobufs_Dota2_CSubtickMoveStep_"></a> MergeFrom\(CSubtickMoveStep\)

```csharp
public void MergeFrom(CSubtickMoveStep other)
```

#### Parameters

`other` [CSubtickMoveStep](Divine.Protobufs.Dota2.CSubtickMoveStep.md)

### <a id="Divine_Protobufs_Dota2_CSubtickMoveStep_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSubtickMoveStep_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSubtickMoveStep_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

