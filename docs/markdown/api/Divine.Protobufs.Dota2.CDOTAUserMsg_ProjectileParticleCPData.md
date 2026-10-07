# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectileParticleCPData"></a> Class CDOTAUserMsg\_ProjectileParticleCPData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_ProjectileParticleCPData : IMessage<CDOTAUserMsg_ProjectileParticleCPData>, IEquatable<CDOTAUserMsg_ProjectileParticleCPData>, IDeepCloneable<CDOTAUserMsg_ProjectileParticleCPData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_ProjectileParticleCPData](Divine.Protobufs.Dota2.CDOTAUserMsg\_ProjectileParticleCPData.md)

#### Implements

IMessage<CDOTAUserMsg\_ProjectileParticleCPData\>, 
[IEquatable<CDOTAUserMsg\_ProjectileParticleCPData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_ProjectileParticleCPData\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_ProjectileParticleCPData\>\(CDOTAUserMsg\_ProjectileParticleCPData, params CDOTAUserMsg\_ProjectileParticleCPData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectileParticleCPData__ctor"></a> CDOTAUserMsg\_ProjectileParticleCPData\(\)

```csharp
public CDOTAUserMsg_ProjectileParticleCPData()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectileParticleCPData__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectileParticleCPData_"></a> CDOTAUserMsg\_ProjectileParticleCPData\(CDOTAUserMsg\_ProjectileParticleCPData\)

```csharp
public CDOTAUserMsg_ProjectileParticleCPData(CDOTAUserMsg_ProjectileParticleCPData other)
```

#### Parameters

`other` [CDOTAUserMsg\_ProjectileParticleCPData](Divine.Protobufs.Dota2.CDOTAUserMsg\_ProjectileParticleCPData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectileParticleCPData_ControlPointFieldNumber"></a> ControlPointFieldNumber

```csharp
public const int ControlPointFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectileParticleCPData_VectorFieldNumber"></a> VectorFieldNumber

```csharp
public const int VectorFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectileParticleCPData_ControlPoint"></a> ControlPoint

```csharp
public int ControlPoint { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectileParticleCPData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectileParticleCPData_HasControlPoint"></a> HasControlPoint

```csharp
public bool HasControlPoint { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectileParticleCPData_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_ProjectileParticleCPData> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_ProjectileParticleCPData](Divine.Protobufs.Dota2.CDOTAUserMsg\_ProjectileParticleCPData.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectileParticleCPData_Vector"></a> Vector

```csharp
public CMsgVector Vector { get; set; }
```

#### Property Value

 [CMsgVector](Divine.Protobufs.Dota2.CMsgVector.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectileParticleCPData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectileParticleCPData_ClearControlPoint"></a> ClearControlPoint\(\)

```csharp
public void ClearControlPoint()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectileParticleCPData_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_ProjectileParticleCPData Clone()
```

#### Returns

 [CDOTAUserMsg\_ProjectileParticleCPData](Divine.Protobufs.Dota2.CDOTAUserMsg\_ProjectileParticleCPData.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectileParticleCPData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectileParticleCPData_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectileParticleCPData_"></a> Equals\(CDOTAUserMsg\_ProjectileParticleCPData\)

```csharp
public bool Equals(CDOTAUserMsg_ProjectileParticleCPData other)
```

#### Parameters

`other` [CDOTAUserMsg\_ProjectileParticleCPData](Divine.Protobufs.Dota2.CDOTAUserMsg\_ProjectileParticleCPData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectileParticleCPData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectileParticleCPData_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectileParticleCPData_"></a> MergeFrom\(CDOTAUserMsg\_ProjectileParticleCPData\)

```csharp
public void MergeFrom(CDOTAUserMsg_ProjectileParticleCPData other)
```

#### Parameters

`other` [CDOTAUserMsg\_ProjectileParticleCPData](Divine.Protobufs.Dota2.CDOTAUserMsg\_ProjectileParticleCPData.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectileParticleCPData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectileParticleCPData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ProjectileParticleCPData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

