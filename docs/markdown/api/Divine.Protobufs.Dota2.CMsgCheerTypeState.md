# <a id="Divine_Protobufs_Dota2_CMsgCheerTypeState"></a> Class CMsgCheerTypeState

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgCheerTypeState : IMessage<CMsgCheerTypeState>, IEquatable<CMsgCheerTypeState>, IDeepCloneable<CMsgCheerTypeState>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgCheerTypeState](Divine.Protobufs.Dota2.CMsgCheerTypeState.md)

#### Implements

IMessage<CMsgCheerTypeState\>, 
[IEquatable<CMsgCheerTypeState\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgCheerTypeState\>, 
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
[EnumerableExtensions.In<CMsgCheerTypeState\>\(CMsgCheerTypeState, params CMsgCheerTypeState\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgCheerTypeState__ctor"></a> CMsgCheerTypeState\(\)

```csharp
public CMsgCheerTypeState()
```

### <a id="Divine_Protobufs_Dota2_CMsgCheerTypeState__ctor_Divine_Protobufs_Dota2_CMsgCheerTypeState_"></a> CMsgCheerTypeState\(CMsgCheerTypeState\)

```csharp
public CMsgCheerTypeState(CMsgCheerTypeState other)
```

#### Parameters

`other` [CMsgCheerTypeState](Divine.Protobufs.Dota2.CMsgCheerTypeState.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgCheerTypeState_CheerCountsFieldNumber"></a> CheerCountsFieldNumber

```csharp
public const int CheerCountsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCheerTypeState_CheerScaleFieldNumber"></a> CheerScaleFieldNumber

```csharp
public const int CheerScaleFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCheerTypeState_MaxPerSecondFieldNumber"></a> MaxPerSecondFieldNumber

```csharp
public const int MaxPerSecondFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCheerTypeState_OverrideScaleFieldNumber"></a> OverrideScaleFieldNumber

```csharp
public const int OverrideScaleFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgCheerTypeState_CheerCounts"></a> CheerCounts

```csharp
public RepeatedField<uint> CheerCounts { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgCheerTypeState_CheerScale"></a> CheerScale

```csharp
public float CheerScale { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgCheerTypeState_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgCheerTypeState_HasCheerScale"></a> HasCheerScale

```csharp
public bool HasCheerScale { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCheerTypeState_HasMaxPerSecond"></a> HasMaxPerSecond

```csharp
public bool HasMaxPerSecond { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCheerTypeState_HasOverrideScale"></a> HasOverrideScale

```csharp
public bool HasOverrideScale { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCheerTypeState_MaxPerSecond"></a> MaxPerSecond

```csharp
public float MaxPerSecond { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgCheerTypeState_OverrideScale"></a> OverrideScale

```csharp
public float OverrideScale { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgCheerTypeState_Parser"></a> Parser

```csharp
public static MessageParser<CMsgCheerTypeState> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgCheerTypeState](Divine.Protobufs.Dota2.CMsgCheerTypeState.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgCheerTypeState_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCheerTypeState_ClearCheerScale"></a> ClearCheerScale\(\)

```csharp
public void ClearCheerScale()
```

### <a id="Divine_Protobufs_Dota2_CMsgCheerTypeState_ClearMaxPerSecond"></a> ClearMaxPerSecond\(\)

```csharp
public void ClearMaxPerSecond()
```

### <a id="Divine_Protobufs_Dota2_CMsgCheerTypeState_ClearOverrideScale"></a> ClearOverrideScale\(\)

```csharp
public void ClearOverrideScale()
```

### <a id="Divine_Protobufs_Dota2_CMsgCheerTypeState_Clone"></a> Clone\(\)

```csharp
public CMsgCheerTypeState Clone()
```

#### Returns

 [CMsgCheerTypeState](Divine.Protobufs.Dota2.CMsgCheerTypeState.md)

### <a id="Divine_Protobufs_Dota2_CMsgCheerTypeState_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCheerTypeState_Equals_Divine_Protobufs_Dota2_CMsgCheerTypeState_"></a> Equals\(CMsgCheerTypeState\)

```csharp
public bool Equals(CMsgCheerTypeState other)
```

#### Parameters

`other` [CMsgCheerTypeState](Divine.Protobufs.Dota2.CMsgCheerTypeState.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCheerTypeState_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCheerTypeState_MergeFrom_Divine_Protobufs_Dota2_CMsgCheerTypeState_"></a> MergeFrom\(CMsgCheerTypeState\)

```csharp
public void MergeFrom(CMsgCheerTypeState other)
```

#### Parameters

`other` [CMsgCheerTypeState](Divine.Protobufs.Dota2.CMsgCheerTypeState.md)

### <a id="Divine_Protobufs_Dota2_CMsgCheerTypeState_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgCheerTypeState_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgCheerTypeState_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

