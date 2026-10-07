# <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleFoWProperties"></a> Class CUserMsg\_ParticleManager.Types.SetParticleFoWProperties

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMsg_ParticleManager.Types.SetParticleFoWProperties : IMessage<CUserMsg_ParticleManager.Types.SetParticleFoWProperties>, IEquatable<CUserMsg_ParticleManager.Types.SetParticleFoWProperties>, IDeepCloneable<CUserMsg_ParticleManager.Types.SetParticleFoWProperties>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMsg\_ParticleManager.Types.SetParticleFoWProperties](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetParticleFoWProperties.md)

#### Implements

IMessage<CUserMsg\_ParticleManager.Types.SetParticleFoWProperties\>, 
[IEquatable<CUserMsg\_ParticleManager.Types.SetParticleFoWProperties\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMsg\_ParticleManager.Types.SetParticleFoWProperties\>, 
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
[EnumerableExtensions.In<CUserMsg\_ParticleManager.Types.SetParticleFoWProperties\>\(CUserMsg\_ParticleManager.Types.SetParticleFoWProperties, params CUserMsg\_ParticleManager.Types.SetParticleFoWProperties\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleFoWProperties__ctor"></a> SetParticleFoWProperties\(\)

```csharp
public SetParticleFoWProperties()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleFoWProperties__ctor_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleFoWProperties_"></a> SetParticleFoWProperties\(SetParticleFoWProperties\)

```csharp
public SetParticleFoWProperties(CUserMsg_ParticleManager.Types.SetParticleFoWProperties other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetParticleFoWProperties](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetParticleFoWProperties.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleFoWProperties_FowControlPoint2FieldNumber"></a> FowControlPoint2FieldNumber

```csharp
public const int FowControlPoint2FieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleFoWProperties_FowControlPointFieldNumber"></a> FowControlPointFieldNumber

```csharp
public const int FowControlPointFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleFoWProperties_FowRadiusFieldNumber"></a> FowRadiusFieldNumber

```csharp
public const int FowRadiusFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleFoWProperties_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleFoWProperties_FowControlPoint"></a> FowControlPoint

```csharp
public int FowControlPoint { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleFoWProperties_FowControlPoint2"></a> FowControlPoint2

```csharp
public int FowControlPoint2 { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleFoWProperties_FowRadius"></a> FowRadius

```csharp
public float FowRadius { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleFoWProperties_HasFowControlPoint"></a> HasFowControlPoint

```csharp
public bool HasFowControlPoint { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleFoWProperties_HasFowControlPoint2"></a> HasFowControlPoint2

```csharp
public bool HasFowControlPoint2 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleFoWProperties_HasFowRadius"></a> HasFowRadius

```csharp
public bool HasFowRadius { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleFoWProperties_Parser"></a> Parser

```csharp
public static MessageParser<CUserMsg_ParticleManager.Types.SetParticleFoWProperties> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetParticleFoWProperties](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetParticleFoWProperties.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleFoWProperties_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleFoWProperties_ClearFowControlPoint"></a> ClearFowControlPoint\(\)

```csharp
public void ClearFowControlPoint()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleFoWProperties_ClearFowControlPoint2"></a> ClearFowControlPoint2\(\)

```csharp
public void ClearFowControlPoint2()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleFoWProperties_ClearFowRadius"></a> ClearFowRadius\(\)

```csharp
public void ClearFowRadius()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleFoWProperties_Clone"></a> Clone\(\)

```csharp
public CUserMsg_ParticleManager.Types.SetParticleFoWProperties Clone()
```

#### Returns

 [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetParticleFoWProperties](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetParticleFoWProperties.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleFoWProperties_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleFoWProperties_Equals_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleFoWProperties_"></a> Equals\(SetParticleFoWProperties\)

```csharp
public bool Equals(CUserMsg_ParticleManager.Types.SetParticleFoWProperties other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetParticleFoWProperties](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetParticleFoWProperties.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleFoWProperties_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleFoWProperties_MergeFrom_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleFoWProperties_"></a> MergeFrom\(SetParticleFoWProperties\)

```csharp
public void MergeFrom(CUserMsg_ParticleManager.Types.SetParticleFoWProperties other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetParticleFoWProperties](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetParticleFoWProperties.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleFoWProperties_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleFoWProperties_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleFoWProperties_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

