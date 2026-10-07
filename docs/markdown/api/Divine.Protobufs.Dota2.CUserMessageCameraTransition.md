# <a id="Divine_Protobufs_Dota2_CUserMessageCameraTransition"></a> Class CUserMessageCameraTransition

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMessageCameraTransition : IMessage<CUserMessageCameraTransition>, IEquatable<CUserMessageCameraTransition>, IDeepCloneable<CUserMessageCameraTransition>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMessageCameraTransition](Divine.Protobufs.Dota2.CUserMessageCameraTransition.md)

#### Implements

IMessage<CUserMessageCameraTransition\>, 
[IEquatable<CUserMessageCameraTransition\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMessageCameraTransition\>, 
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
[EnumerableExtensions.In<CUserMessageCameraTransition\>\(CUserMessageCameraTransition, params CUserMessageCameraTransition\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMessageCameraTransition__ctor"></a> CUserMessageCameraTransition\(\)

```csharp
public CUserMessageCameraTransition()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageCameraTransition__ctor_Divine_Protobufs_Dota2_CUserMessageCameraTransition_"></a> CUserMessageCameraTransition\(CUserMessageCameraTransition\)

```csharp
public CUserMessageCameraTransition(CUserMessageCameraTransition other)
```

#### Parameters

`other` [CUserMessageCameraTransition](Divine.Protobufs.Dota2.CUserMessageCameraTransition.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMessageCameraTransition_CameraTypeFieldNumber"></a> CameraTypeFieldNumber

```csharp
public const int CameraTypeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageCameraTransition_DurationFieldNumber"></a> DurationFieldNumber

```csharp
public const int DurationFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageCameraTransition_ParamsDataDrivenFieldNumber"></a> ParamsDataDrivenFieldNumber

```csharp
public const int ParamsDataDrivenFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMessageCameraTransition_CameraType"></a> CameraType

```csharp
public uint CameraType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CUserMessageCameraTransition_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMessageCameraTransition_Duration"></a> Duration

```csharp
public float Duration { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CUserMessageCameraTransition_HasCameraType"></a> HasCameraType

```csharp
public bool HasCameraType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageCameraTransition_HasDuration"></a> HasDuration

```csharp
public bool HasDuration { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageCameraTransition_ParamsDataDriven"></a> ParamsDataDriven

```csharp
public CUserMessageCameraTransition.Types.Transition_DataDriven ParamsDataDriven { get; set; }
```

#### Property Value

 [CUserMessageCameraTransition](Divine.Protobufs.Dota2.CUserMessageCameraTransition.md).[Types](Divine.Protobufs.Dota2.CUserMessageCameraTransition.Types.md).[Transition\_DataDriven](Divine.Protobufs.Dota2.CUserMessageCameraTransition.Types.Transition\_DataDriven.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageCameraTransition_Parser"></a> Parser

```csharp
public static MessageParser<CUserMessageCameraTransition> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMessageCameraTransition](Divine.Protobufs.Dota2.CUserMessageCameraTransition.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMessageCameraTransition_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageCameraTransition_ClearCameraType"></a> ClearCameraType\(\)

```csharp
public void ClearCameraType()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageCameraTransition_ClearDuration"></a> ClearDuration\(\)

```csharp
public void ClearDuration()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageCameraTransition_Clone"></a> Clone\(\)

```csharp
public CUserMessageCameraTransition Clone()
```

#### Returns

 [CUserMessageCameraTransition](Divine.Protobufs.Dota2.CUserMessageCameraTransition.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageCameraTransition_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageCameraTransition_Equals_Divine_Protobufs_Dota2_CUserMessageCameraTransition_"></a> Equals\(CUserMessageCameraTransition\)

```csharp
public bool Equals(CUserMessageCameraTransition other)
```

#### Parameters

`other` [CUserMessageCameraTransition](Divine.Protobufs.Dota2.CUserMessageCameraTransition.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageCameraTransition_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageCameraTransition_MergeFrom_Divine_Protobufs_Dota2_CUserMessageCameraTransition_"></a> MergeFrom\(CUserMessageCameraTransition\)

```csharp
public void MergeFrom(CUserMessageCameraTransition other)
```

#### Parameters

`other` [CUserMessageCameraTransition](Divine.Protobufs.Dota2.CUserMessageCameraTransition.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageCameraTransition_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMessageCameraTransition_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessageCameraTransition_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

