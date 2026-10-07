# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Interval"></a> Class CDOTAUserMsg\_UnitEvent.Types.Interval

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_UnitEvent.Types.Interval : IMessage<CDOTAUserMsg_UnitEvent.Types.Interval>, IEquatable<CDOTAUserMsg_UnitEvent.Types.Interval>, IDeepCloneable<CDOTAUserMsg_UnitEvent.Types.Interval>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_UnitEvent.Types.Interval](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.Types.Interval.md)

#### Implements

IMessage<CDOTAUserMsg\_UnitEvent.Types.Interval\>, 
[IEquatable<CDOTAUserMsg\_UnitEvent.Types.Interval\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_UnitEvent.Types.Interval\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_UnitEvent.Types.Interval\>\(CDOTAUserMsg\_UnitEvent.Types.Interval, params CDOTAUserMsg\_UnitEvent.Types.Interval\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Interval__ctor"></a> Interval\(\)

```csharp
public Interval()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Interval__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Interval_"></a> Interval\(Interval\)

```csharp
public Interval(CDOTAUserMsg_UnitEvent.Types.Interval other)
```

#### Parameters

`other` [CDOTAUserMsg\_UnitEvent](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.Types.md).[Interval](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.Types.Interval.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Interval_RangeFieldNumber"></a> RangeFieldNumber

```csharp
public const int RangeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Interval_StartFieldNumber"></a> StartFieldNumber

```csharp
public const int StartFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Interval_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Interval_HasRange"></a> HasRange

```csharp
public bool HasRange { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Interval_HasStart"></a> HasStart

```csharp
public bool HasStart { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Interval_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_UnitEvent.Types.Interval> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_UnitEvent](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.Types.md).[Interval](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.Types.Interval.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Interval_Range"></a> Range

```csharp
public float Range { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Interval_Start"></a> Start

```csharp
public float Start { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Interval_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Interval_ClearRange"></a> ClearRange\(\)

```csharp
public void ClearRange()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Interval_ClearStart"></a> ClearStart\(\)

```csharp
public void ClearStart()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Interval_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_UnitEvent.Types.Interval Clone()
```

#### Returns

 [CDOTAUserMsg\_UnitEvent](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.Types.md).[Interval](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.Types.Interval.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Interval_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Interval_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Interval_"></a> Equals\(Interval\)

```csharp
public bool Equals(CDOTAUserMsg_UnitEvent.Types.Interval other)
```

#### Parameters

`other` [CDOTAUserMsg\_UnitEvent](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.Types.md).[Interval](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.Types.Interval.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Interval_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Interval_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Interval_"></a> MergeFrom\(Interval\)

```csharp
public void MergeFrom(CDOTAUserMsg_UnitEvent.Types.Interval other)
```

#### Parameters

`other` [CDOTAUserMsg\_UnitEvent](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.Types.md).[Interval](Divine.Protobufs.Dota2.CDOTAUserMsg\_UnitEvent.Types.Interval.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Interval_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Interval_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UnitEvent_Types_Interval_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

