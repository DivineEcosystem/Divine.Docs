# <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ParticleFreezeTransitionOverride"></a> Class CUserMsg\_ParticleManager.Types.ParticleFreezeTransitionOverride

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMsg_ParticleManager.Types.ParticleFreezeTransitionOverride : IMessage<CUserMsg_ParticleManager.Types.ParticleFreezeTransitionOverride>, IEquatable<CUserMsg_ParticleManager.Types.ParticleFreezeTransitionOverride>, IDeepCloneable<CUserMsg_ParticleManager.Types.ParticleFreezeTransitionOverride>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMsg\_ParticleManager.Types.ParticleFreezeTransitionOverride](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.ParticleFreezeTransitionOverride.md)

#### Implements

IMessage<CUserMsg\_ParticleManager.Types.ParticleFreezeTransitionOverride\>, 
[IEquatable<CUserMsg\_ParticleManager.Types.ParticleFreezeTransitionOverride\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMsg\_ParticleManager.Types.ParticleFreezeTransitionOverride\>, 
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
[EnumerableExtensions.In<CUserMsg\_ParticleManager.Types.ParticleFreezeTransitionOverride\>\(CUserMsg\_ParticleManager.Types.ParticleFreezeTransitionOverride, params CUserMsg\_ParticleManager.Types.ParticleFreezeTransitionOverride\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ParticleFreezeTransitionOverride__ctor"></a> ParticleFreezeTransitionOverride\(\)

```csharp
public ParticleFreezeTransitionOverride()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ParticleFreezeTransitionOverride__ctor_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ParticleFreezeTransitionOverride_"></a> ParticleFreezeTransitionOverride\(ParticleFreezeTransitionOverride\)

```csharp
public ParticleFreezeTransitionOverride(CUserMsg_ParticleManager.Types.ParticleFreezeTransitionOverride other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[ParticleFreezeTransitionOverride](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.ParticleFreezeTransitionOverride.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ParticleFreezeTransitionOverride_FreezeTransitionOverrideFieldNumber"></a> FreezeTransitionOverrideFieldNumber

```csharp
public const int FreezeTransitionOverrideFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ParticleFreezeTransitionOverride_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ParticleFreezeTransitionOverride_FreezeTransitionOverride"></a> FreezeTransitionOverride

```csharp
public float FreezeTransitionOverride { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ParticleFreezeTransitionOverride_HasFreezeTransitionOverride"></a> HasFreezeTransitionOverride

```csharp
public bool HasFreezeTransitionOverride { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ParticleFreezeTransitionOverride_Parser"></a> Parser

```csharp
public static MessageParser<CUserMsg_ParticleManager.Types.ParticleFreezeTransitionOverride> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[ParticleFreezeTransitionOverride](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.ParticleFreezeTransitionOverride.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ParticleFreezeTransitionOverride_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ParticleFreezeTransitionOverride_ClearFreezeTransitionOverride"></a> ClearFreezeTransitionOverride\(\)

```csharp
public void ClearFreezeTransitionOverride()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ParticleFreezeTransitionOverride_Clone"></a> Clone\(\)

```csharp
public CUserMsg_ParticleManager.Types.ParticleFreezeTransitionOverride Clone()
```

#### Returns

 [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[ParticleFreezeTransitionOverride](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.ParticleFreezeTransitionOverride.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ParticleFreezeTransitionOverride_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ParticleFreezeTransitionOverride_Equals_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ParticleFreezeTransitionOverride_"></a> Equals\(ParticleFreezeTransitionOverride\)

```csharp
public bool Equals(CUserMsg_ParticleManager.Types.ParticleFreezeTransitionOverride other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[ParticleFreezeTransitionOverride](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.ParticleFreezeTransitionOverride.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ParticleFreezeTransitionOverride_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ParticleFreezeTransitionOverride_MergeFrom_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ParticleFreezeTransitionOverride_"></a> MergeFrom\(ParticleFreezeTransitionOverride\)

```csharp
public void MergeFrom(CUserMsg_ParticleManager.Types.ParticleFreezeTransitionOverride other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[ParticleFreezeTransitionOverride](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.ParticleFreezeTransitionOverride.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ParticleFreezeTransitionOverride_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ParticleFreezeTransitionOverride_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ParticleFreezeTransitionOverride_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

