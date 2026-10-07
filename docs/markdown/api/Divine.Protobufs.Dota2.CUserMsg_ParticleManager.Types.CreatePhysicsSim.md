# <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_CreatePhysicsSim"></a> Class CUserMsg\_ParticleManager.Types.CreatePhysicsSim

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMsg_ParticleManager.Types.CreatePhysicsSim : IMessage<CUserMsg_ParticleManager.Types.CreatePhysicsSim>, IEquatable<CUserMsg_ParticleManager.Types.CreatePhysicsSim>, IDeepCloneable<CUserMsg_ParticleManager.Types.CreatePhysicsSim>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMsg\_ParticleManager.Types.CreatePhysicsSim](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.CreatePhysicsSim.md)

#### Implements

IMessage<CUserMsg\_ParticleManager.Types.CreatePhysicsSim\>, 
[IEquatable<CUserMsg\_ParticleManager.Types.CreatePhysicsSim\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMsg\_ParticleManager.Types.CreatePhysicsSim\>, 
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
[EnumerableExtensions.In<CUserMsg\_ParticleManager.Types.CreatePhysicsSim\>\(CUserMsg\_ParticleManager.Types.CreatePhysicsSim, params CUserMsg\_ParticleManager.Types.CreatePhysicsSim\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_CreatePhysicsSim__ctor"></a> CreatePhysicsSim\(\)

```csharp
public CreatePhysicsSim()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_CreatePhysicsSim__ctor_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_CreatePhysicsSim_"></a> CreatePhysicsSim\(CreatePhysicsSim\)

```csharp
public CreatePhysicsSim(CUserMsg_ParticleManager.Types.CreatePhysicsSim other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[CreatePhysicsSim](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.CreatePhysicsSim.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_CreatePhysicsSim_MaxParticleCountFieldNumber"></a> MaxParticleCountFieldNumber

```csharp
public const int MaxParticleCountFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_CreatePhysicsSim_PropGroupNameFieldNumber"></a> PropGroupNameFieldNumber

```csharp
public const int PropGroupNameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_CreatePhysicsSim_UseHighQualitySimulationFieldNumber"></a> UseHighQualitySimulationFieldNumber

```csharp
public const int UseHighQualitySimulationFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_CreatePhysicsSim_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_CreatePhysicsSim_HasMaxParticleCount"></a> HasMaxParticleCount

```csharp
public bool HasMaxParticleCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_CreatePhysicsSim_HasPropGroupName"></a> HasPropGroupName

```csharp
public bool HasPropGroupName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_CreatePhysicsSim_HasUseHighQualitySimulation"></a> HasUseHighQualitySimulation

```csharp
public bool HasUseHighQualitySimulation { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_CreatePhysicsSim_MaxParticleCount"></a> MaxParticleCount

```csharp
public uint MaxParticleCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_CreatePhysicsSim_Parser"></a> Parser

```csharp
public static MessageParser<CUserMsg_ParticleManager.Types.CreatePhysicsSim> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[CreatePhysicsSim](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.CreatePhysicsSim.md)\>

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_CreatePhysicsSim_PropGroupName"></a> PropGroupName

```csharp
public string PropGroupName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_CreatePhysicsSim_UseHighQualitySimulation"></a> UseHighQualitySimulation

```csharp
public bool UseHighQualitySimulation { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_CreatePhysicsSim_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_CreatePhysicsSim_ClearMaxParticleCount"></a> ClearMaxParticleCount\(\)

```csharp
public void ClearMaxParticleCount()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_CreatePhysicsSim_ClearPropGroupName"></a> ClearPropGroupName\(\)

```csharp
public void ClearPropGroupName()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_CreatePhysicsSim_ClearUseHighQualitySimulation"></a> ClearUseHighQualitySimulation\(\)

```csharp
public void ClearUseHighQualitySimulation()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_CreatePhysicsSim_Clone"></a> Clone\(\)

```csharp
public CUserMsg_ParticleManager.Types.CreatePhysicsSim Clone()
```

#### Returns

 [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[CreatePhysicsSim](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.CreatePhysicsSim.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_CreatePhysicsSim_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_CreatePhysicsSim_Equals_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_CreatePhysicsSim_"></a> Equals\(CreatePhysicsSim\)

```csharp
public bool Equals(CUserMsg_ParticleManager.Types.CreatePhysicsSim other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[CreatePhysicsSim](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.CreatePhysicsSim.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_CreatePhysicsSim_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_CreatePhysicsSim_MergeFrom_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_CreatePhysicsSim_"></a> MergeFrom\(CreatePhysicsSim\)

```csharp
public void MergeFrom(CUserMsg_ParticleManager.Types.CreatePhysicsSim other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[CreatePhysicsSim](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.CreatePhysicsSim.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_CreatePhysicsSim_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_CreatePhysicsSim_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_CreatePhysicsSim_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

