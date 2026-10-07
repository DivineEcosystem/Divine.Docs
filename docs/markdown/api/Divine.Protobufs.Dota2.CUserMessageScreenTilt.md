# <a id="Divine_Protobufs_Dota2_CUserMessageScreenTilt"></a> Class CUserMessageScreenTilt

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMessageScreenTilt : IMessage<CUserMessageScreenTilt>, IEquatable<CUserMessageScreenTilt>, IDeepCloneable<CUserMessageScreenTilt>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMessageScreenTilt](Divine.Protobufs.Dota2.CUserMessageScreenTilt.md)

#### Implements

IMessage<CUserMessageScreenTilt\>, 
[IEquatable<CUserMessageScreenTilt\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMessageScreenTilt\>, 
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
[EnumerableExtensions.In<CUserMessageScreenTilt\>\(CUserMessageScreenTilt, params CUserMessageScreenTilt\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMessageScreenTilt__ctor"></a> CUserMessageScreenTilt\(\)

```csharp
public CUserMessageScreenTilt()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageScreenTilt__ctor_Divine_Protobufs_Dota2_CUserMessageScreenTilt_"></a> CUserMessageScreenTilt\(CUserMessageScreenTilt\)

```csharp
public CUserMessageScreenTilt(CUserMessageScreenTilt other)
```

#### Parameters

`other` [CUserMessageScreenTilt](Divine.Protobufs.Dota2.CUserMessageScreenTilt.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMessageScreenTilt_AngleFieldNumber"></a> AngleFieldNumber

```csharp
public const int AngleFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageScreenTilt_CommandFieldNumber"></a> CommandFieldNumber

```csharp
public const int CommandFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageScreenTilt_DurationFieldNumber"></a> DurationFieldNumber

```csharp
public const int DurationFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageScreenTilt_EaseInOutFieldNumber"></a> EaseInOutFieldNumber

```csharp
public const int EaseInOutFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageScreenTilt_TimeFieldNumber"></a> TimeFieldNumber

```csharp
public const int TimeFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMessageScreenTilt_Angle"></a> Angle

```csharp
public CMsgVector Angle { get; set; }
```

#### Property Value

 [CMsgVector](Divine.Protobufs.Dota2.CMsgVector.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageScreenTilt_Command"></a> Command

```csharp
public uint Command { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CUserMessageScreenTilt_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMessageScreenTilt_Duration"></a> Duration

```csharp
public float Duration { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CUserMessageScreenTilt_EaseInOut"></a> EaseInOut

```csharp
public bool EaseInOut { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageScreenTilt_HasCommand"></a> HasCommand

```csharp
public bool HasCommand { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageScreenTilt_HasDuration"></a> HasDuration

```csharp
public bool HasDuration { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageScreenTilt_HasEaseInOut"></a> HasEaseInOut

```csharp
public bool HasEaseInOut { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageScreenTilt_HasTime"></a> HasTime

```csharp
public bool HasTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageScreenTilt_Parser"></a> Parser

```csharp
public static MessageParser<CUserMessageScreenTilt> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMessageScreenTilt](Divine.Protobufs.Dota2.CUserMessageScreenTilt.md)\>

### <a id="Divine_Protobufs_Dota2_CUserMessageScreenTilt_Time"></a> Time

```csharp
public float Time { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMessageScreenTilt_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageScreenTilt_ClearCommand"></a> ClearCommand\(\)

```csharp
public void ClearCommand()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageScreenTilt_ClearDuration"></a> ClearDuration\(\)

```csharp
public void ClearDuration()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageScreenTilt_ClearEaseInOut"></a> ClearEaseInOut\(\)

```csharp
public void ClearEaseInOut()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageScreenTilt_ClearTime"></a> ClearTime\(\)

```csharp
public void ClearTime()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageScreenTilt_Clone"></a> Clone\(\)

```csharp
public CUserMessageScreenTilt Clone()
```

#### Returns

 [CUserMessageScreenTilt](Divine.Protobufs.Dota2.CUserMessageScreenTilt.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageScreenTilt_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageScreenTilt_Equals_Divine_Protobufs_Dota2_CUserMessageScreenTilt_"></a> Equals\(CUserMessageScreenTilt\)

```csharp
public bool Equals(CUserMessageScreenTilt other)
```

#### Parameters

`other` [CUserMessageScreenTilt](Divine.Protobufs.Dota2.CUserMessageScreenTilt.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageScreenTilt_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageScreenTilt_MergeFrom_Divine_Protobufs_Dota2_CUserMessageScreenTilt_"></a> MergeFrom\(CUserMessageScreenTilt\)

```csharp
public void MergeFrom(CUserMessageScreenTilt other)
```

#### Parameters

`other` [CUserMessageScreenTilt](Divine.Protobufs.Dota2.CUserMessageScreenTilt.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageScreenTilt_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMessageScreenTilt_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessageScreenTilt_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

