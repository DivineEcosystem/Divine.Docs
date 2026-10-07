# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UpdateLinearProjectileCPData"></a> Class CDOTAUserMsg\_UpdateLinearProjectileCPData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_UpdateLinearProjectileCPData : IMessage<CDOTAUserMsg_UpdateLinearProjectileCPData>, IEquatable<CDOTAUserMsg_UpdateLinearProjectileCPData>, IDeepCloneable<CDOTAUserMsg_UpdateLinearProjectileCPData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_UpdateLinearProjectileCPData](Divine.Protobufs.Dota2.CDOTAUserMsg\_UpdateLinearProjectileCPData.md)

#### Implements

IMessage<CDOTAUserMsg\_UpdateLinearProjectileCPData\>, 
[IEquatable<CDOTAUserMsg\_UpdateLinearProjectileCPData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_UpdateLinearProjectileCPData\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_UpdateLinearProjectileCPData\>\(CDOTAUserMsg\_UpdateLinearProjectileCPData, params CDOTAUserMsg\_UpdateLinearProjectileCPData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UpdateLinearProjectileCPData__ctor"></a> CDOTAUserMsg\_UpdateLinearProjectileCPData\(\)

```csharp
public CDOTAUserMsg_UpdateLinearProjectileCPData()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UpdateLinearProjectileCPData__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_UpdateLinearProjectileCPData_"></a> CDOTAUserMsg\_UpdateLinearProjectileCPData\(CDOTAUserMsg\_UpdateLinearProjectileCPData\)

```csharp
public CDOTAUserMsg_UpdateLinearProjectileCPData(CDOTAUserMsg_UpdateLinearProjectileCPData other)
```

#### Parameters

`other` [CDOTAUserMsg\_UpdateLinearProjectileCPData](Divine.Protobufs.Dota2.CDOTAUserMsg\_UpdateLinearProjectileCPData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UpdateLinearProjectileCPData_ControlPointFieldNumber"></a> ControlPointFieldNumber

```csharp
public const int ControlPointFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UpdateLinearProjectileCPData_HandleFieldNumber"></a> HandleFieldNumber

```csharp
public const int HandleFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UpdateLinearProjectileCPData_VectorFieldNumber"></a> VectorFieldNumber

```csharp
public const int VectorFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UpdateLinearProjectileCPData_ControlPoint"></a> ControlPoint

```csharp
public int ControlPoint { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UpdateLinearProjectileCPData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UpdateLinearProjectileCPData_Handle"></a> Handle

```csharp
public int Handle { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UpdateLinearProjectileCPData_HasControlPoint"></a> HasControlPoint

```csharp
public bool HasControlPoint { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UpdateLinearProjectileCPData_HasHandle"></a> HasHandle

```csharp
public bool HasHandle { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UpdateLinearProjectileCPData_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_UpdateLinearProjectileCPData> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_UpdateLinearProjectileCPData](Divine.Protobufs.Dota2.CDOTAUserMsg\_UpdateLinearProjectileCPData.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UpdateLinearProjectileCPData_Vector"></a> Vector

```csharp
public CMsgVector Vector { get; set; }
```

#### Property Value

 [CMsgVector](Divine.Protobufs.Dota2.CMsgVector.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UpdateLinearProjectileCPData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UpdateLinearProjectileCPData_ClearControlPoint"></a> ClearControlPoint\(\)

```csharp
public void ClearControlPoint()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UpdateLinearProjectileCPData_ClearHandle"></a> ClearHandle\(\)

```csharp
public void ClearHandle()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UpdateLinearProjectileCPData_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_UpdateLinearProjectileCPData Clone()
```

#### Returns

 [CDOTAUserMsg\_UpdateLinearProjectileCPData](Divine.Protobufs.Dota2.CDOTAUserMsg\_UpdateLinearProjectileCPData.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UpdateLinearProjectileCPData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UpdateLinearProjectileCPData_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_UpdateLinearProjectileCPData_"></a> Equals\(CDOTAUserMsg\_UpdateLinearProjectileCPData\)

```csharp
public bool Equals(CDOTAUserMsg_UpdateLinearProjectileCPData other)
```

#### Parameters

`other` [CDOTAUserMsg\_UpdateLinearProjectileCPData](Divine.Protobufs.Dota2.CDOTAUserMsg\_UpdateLinearProjectileCPData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UpdateLinearProjectileCPData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UpdateLinearProjectileCPData_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_UpdateLinearProjectileCPData_"></a> MergeFrom\(CDOTAUserMsg\_UpdateLinearProjectileCPData\)

```csharp
public void MergeFrom(CDOTAUserMsg_UpdateLinearProjectileCPData other)
```

#### Parameters

`other` [CDOTAUserMsg\_UpdateLinearProjectileCPData](Divine.Protobufs.Dota2.CDOTAUserMsg\_UpdateLinearProjectileCPData.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UpdateLinearProjectileCPData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UpdateLinearProjectileCPData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UpdateLinearProjectileCPData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

