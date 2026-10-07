# <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateParticleFwd_OBSOLETE"></a> Class CUserMsg\_ParticleManager.Types.UpdateParticleFwd\_OBSOLETE

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMsg_ParticleManager.Types.UpdateParticleFwd_OBSOLETE : IMessage<CUserMsg_ParticleManager.Types.UpdateParticleFwd_OBSOLETE>, IEquatable<CUserMsg_ParticleManager.Types.UpdateParticleFwd_OBSOLETE>, IDeepCloneable<CUserMsg_ParticleManager.Types.UpdateParticleFwd_OBSOLETE>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMsg\_ParticleManager.Types.UpdateParticleFwd\_OBSOLETE](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.UpdateParticleFwd\_OBSOLETE.md)

#### Implements

IMessage<CUserMsg\_ParticleManager.Types.UpdateParticleFwd\_OBSOLETE\>, 
[IEquatable<CUserMsg\_ParticleManager.Types.UpdateParticleFwd\_OBSOLETE\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMsg\_ParticleManager.Types.UpdateParticleFwd\_OBSOLETE\>, 
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
[EnumerableExtensions.In<CUserMsg\_ParticleManager.Types.UpdateParticleFwd\_OBSOLETE\>\(CUserMsg\_ParticleManager.Types.UpdateParticleFwd\_OBSOLETE, params CUserMsg\_ParticleManager.Types.UpdateParticleFwd\_OBSOLETE\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateParticleFwd_OBSOLETE__ctor"></a> UpdateParticleFwd\_OBSOLETE\(\)

```csharp
public UpdateParticleFwd_OBSOLETE()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateParticleFwd_OBSOLETE__ctor_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateParticleFwd_OBSOLETE_"></a> UpdateParticleFwd\_OBSOLETE\(UpdateParticleFwd\_OBSOLETE\)

```csharp
public UpdateParticleFwd_OBSOLETE(CUserMsg_ParticleManager.Types.UpdateParticleFwd_OBSOLETE other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[UpdateParticleFwd\_OBSOLETE](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.UpdateParticleFwd\_OBSOLETE.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateParticleFwd_OBSOLETE_ControlPointFieldNumber"></a> ControlPointFieldNumber

```csharp
public const int ControlPointFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateParticleFwd_OBSOLETE_ForwardFieldNumber"></a> ForwardFieldNumber

```csharp
public const int ForwardFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateParticleFwd_OBSOLETE_ControlPoint"></a> ControlPoint

```csharp
public int ControlPoint { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateParticleFwd_OBSOLETE_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateParticleFwd_OBSOLETE_Forward"></a> Forward

```csharp
public CMsgVector Forward { get; set; }
```

#### Property Value

 [CMsgVector](Divine.Protobufs.Dota2.CMsgVector.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateParticleFwd_OBSOLETE_HasControlPoint"></a> HasControlPoint

```csharp
public bool HasControlPoint { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateParticleFwd_OBSOLETE_Parser"></a> Parser

```csharp
public static MessageParser<CUserMsg_ParticleManager.Types.UpdateParticleFwd_OBSOLETE> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[UpdateParticleFwd\_OBSOLETE](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.UpdateParticleFwd\_OBSOLETE.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateParticleFwd_OBSOLETE_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateParticleFwd_OBSOLETE_ClearControlPoint"></a> ClearControlPoint\(\)

```csharp
public void ClearControlPoint()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateParticleFwd_OBSOLETE_Clone"></a> Clone\(\)

```csharp
public CUserMsg_ParticleManager.Types.UpdateParticleFwd_OBSOLETE Clone()
```

#### Returns

 [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[UpdateParticleFwd\_OBSOLETE](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.UpdateParticleFwd\_OBSOLETE.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateParticleFwd_OBSOLETE_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateParticleFwd_OBSOLETE_Equals_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateParticleFwd_OBSOLETE_"></a> Equals\(UpdateParticleFwd\_OBSOLETE\)

```csharp
public bool Equals(CUserMsg_ParticleManager.Types.UpdateParticleFwd_OBSOLETE other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[UpdateParticleFwd\_OBSOLETE](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.UpdateParticleFwd\_OBSOLETE.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateParticleFwd_OBSOLETE_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateParticleFwd_OBSOLETE_MergeFrom_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateParticleFwd_OBSOLETE_"></a> MergeFrom\(UpdateParticleFwd\_OBSOLETE\)

```csharp
public void MergeFrom(CUserMsg_ParticleManager.Types.UpdateParticleFwd_OBSOLETE other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[UpdateParticleFwd\_OBSOLETE](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.UpdateParticleFwd\_OBSOLETE.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateParticleFwd_OBSOLETE_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateParticleFwd_OBSOLETE_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateParticleFwd_OBSOLETE_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

