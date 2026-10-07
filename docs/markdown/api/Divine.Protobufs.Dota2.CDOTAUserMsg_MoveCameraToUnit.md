# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MoveCameraToUnit"></a> Class CDOTAUserMsg\_MoveCameraToUnit

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_MoveCameraToUnit : IMessage<CDOTAUserMsg_MoveCameraToUnit>, IEquatable<CDOTAUserMsg_MoveCameraToUnit>, IDeepCloneable<CDOTAUserMsg_MoveCameraToUnit>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_MoveCameraToUnit](Divine.Protobufs.Dota2.CDOTAUserMsg\_MoveCameraToUnit.md)

#### Implements

IMessage<CDOTAUserMsg\_MoveCameraToUnit\>, 
[IEquatable<CDOTAUserMsg\_MoveCameraToUnit\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_MoveCameraToUnit\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_MoveCameraToUnit\>\(CDOTAUserMsg\_MoveCameraToUnit, params CDOTAUserMsg\_MoveCameraToUnit\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MoveCameraToUnit__ctor"></a> CDOTAUserMsg\_MoveCameraToUnit\(\)

```csharp
public CDOTAUserMsg_MoveCameraToUnit()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MoveCameraToUnit__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_MoveCameraToUnit_"></a> CDOTAUserMsg\_MoveCameraToUnit\(CDOTAUserMsg\_MoveCameraToUnit\)

```csharp
public CDOTAUserMsg_MoveCameraToUnit(CDOTAUserMsg_MoveCameraToUnit other)
```

#### Parameters

`other` [CDOTAUserMsg\_MoveCameraToUnit](Divine.Protobufs.Dota2.CDOTAUserMsg\_MoveCameraToUnit.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MoveCameraToUnit_UnitEhandleFieldNumber"></a> UnitEhandleFieldNumber

```csharp
public const int UnitEhandleFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MoveCameraToUnit_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MoveCameraToUnit_HasUnitEhandle"></a> HasUnitEhandle

```csharp
public bool HasUnitEhandle { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MoveCameraToUnit_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_MoveCameraToUnit> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_MoveCameraToUnit](Divine.Protobufs.Dota2.CDOTAUserMsg\_MoveCameraToUnit.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MoveCameraToUnit_UnitEhandle"></a> UnitEhandle

```csharp
public uint UnitEhandle { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MoveCameraToUnit_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MoveCameraToUnit_ClearUnitEhandle"></a> ClearUnitEhandle\(\)

```csharp
public void ClearUnitEhandle()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MoveCameraToUnit_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_MoveCameraToUnit Clone()
```

#### Returns

 [CDOTAUserMsg\_MoveCameraToUnit](Divine.Protobufs.Dota2.CDOTAUserMsg\_MoveCameraToUnit.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MoveCameraToUnit_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MoveCameraToUnit_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_MoveCameraToUnit_"></a> Equals\(CDOTAUserMsg\_MoveCameraToUnit\)

```csharp
public bool Equals(CDOTAUserMsg_MoveCameraToUnit other)
```

#### Parameters

`other` [CDOTAUserMsg\_MoveCameraToUnit](Divine.Protobufs.Dota2.CDOTAUserMsg\_MoveCameraToUnit.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MoveCameraToUnit_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MoveCameraToUnit_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_MoveCameraToUnit_"></a> MergeFrom\(CDOTAUserMsg\_MoveCameraToUnit\)

```csharp
public void MergeFrom(CDOTAUserMsg_MoveCameraToUnit other)
```

#### Parameters

`other` [CDOTAUserMsg\_MoveCameraToUnit](Divine.Protobufs.Dota2.CDOTAUserMsg\_MoveCameraToUnit.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MoveCameraToUnit_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MoveCameraToUnit_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MoveCameraToUnit_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

