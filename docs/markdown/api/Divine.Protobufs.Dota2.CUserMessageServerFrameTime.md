# <a id="Divine_Protobufs_Dota2_CUserMessageServerFrameTime"></a> Class CUserMessageServerFrameTime

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMessageServerFrameTime : IMessage<CUserMessageServerFrameTime>, IEquatable<CUserMessageServerFrameTime>, IDeepCloneable<CUserMessageServerFrameTime>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMessageServerFrameTime](Divine.Protobufs.Dota2.CUserMessageServerFrameTime.md)

#### Implements

IMessage<CUserMessageServerFrameTime\>, 
[IEquatable<CUserMessageServerFrameTime\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMessageServerFrameTime\>, 
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
[EnumerableExtensions.In<CUserMessageServerFrameTime\>\(CUserMessageServerFrameTime, params CUserMessageServerFrameTime\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMessageServerFrameTime__ctor"></a> CUserMessageServerFrameTime\(\)

```csharp
public CUserMessageServerFrameTime()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageServerFrameTime__ctor_Divine_Protobufs_Dota2_CUserMessageServerFrameTime_"></a> CUserMessageServerFrameTime\(CUserMessageServerFrameTime\)

```csharp
public CUserMessageServerFrameTime(CUserMessageServerFrameTime other)
```

#### Parameters

`other` [CUserMessageServerFrameTime](Divine.Protobufs.Dota2.CUserMessageServerFrameTime.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMessageServerFrameTime_FrameTimeFieldNumber"></a> FrameTimeFieldNumber

```csharp
public const int FrameTimeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMessageServerFrameTime_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMessageServerFrameTime_FrameTime"></a> FrameTime

```csharp
public float FrameTime { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CUserMessageServerFrameTime_HasFrameTime"></a> HasFrameTime

```csharp
public bool HasFrameTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageServerFrameTime_Parser"></a> Parser

```csharp
public static MessageParser<CUserMessageServerFrameTime> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMessageServerFrameTime](Divine.Protobufs.Dota2.CUserMessageServerFrameTime.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMessageServerFrameTime_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageServerFrameTime_ClearFrameTime"></a> ClearFrameTime\(\)

```csharp
public void ClearFrameTime()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageServerFrameTime_Clone"></a> Clone\(\)

```csharp
public CUserMessageServerFrameTime Clone()
```

#### Returns

 [CUserMessageServerFrameTime](Divine.Protobufs.Dota2.CUserMessageServerFrameTime.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageServerFrameTime_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageServerFrameTime_Equals_Divine_Protobufs_Dota2_CUserMessageServerFrameTime_"></a> Equals\(CUserMessageServerFrameTime\)

```csharp
public bool Equals(CUserMessageServerFrameTime other)
```

#### Parameters

`other` [CUserMessageServerFrameTime](Divine.Protobufs.Dota2.CUserMessageServerFrameTime.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageServerFrameTime_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageServerFrameTime_MergeFrom_Divine_Protobufs_Dota2_CUserMessageServerFrameTime_"></a> MergeFrom\(CUserMessageServerFrameTime\)

```csharp
public void MergeFrom(CUserMessageServerFrameTime other)
```

#### Parameters

`other` [CUserMessageServerFrameTime](Divine.Protobufs.Dota2.CUserMessageServerFrameTime.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageServerFrameTime_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMessageServerFrameTime_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessageServerFrameTime_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

