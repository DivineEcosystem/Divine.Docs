# <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateParticleSetFrozen"></a> Class CUserMsg\_ParticleManager.Types.UpdateParticleSetFrozen

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMsg_ParticleManager.Types.UpdateParticleSetFrozen : IMessage<CUserMsg_ParticleManager.Types.UpdateParticleSetFrozen>, IEquatable<CUserMsg_ParticleManager.Types.UpdateParticleSetFrozen>, IDeepCloneable<CUserMsg_ParticleManager.Types.UpdateParticleSetFrozen>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMsg\_ParticleManager.Types.UpdateParticleSetFrozen](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.UpdateParticleSetFrozen.md)

#### Implements

IMessage<CUserMsg\_ParticleManager.Types.UpdateParticleSetFrozen\>, 
[IEquatable<CUserMsg\_ParticleManager.Types.UpdateParticleSetFrozen\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMsg\_ParticleManager.Types.UpdateParticleSetFrozen\>, 
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
[EnumerableExtensions.In<CUserMsg\_ParticleManager.Types.UpdateParticleSetFrozen\>\(CUserMsg\_ParticleManager.Types.UpdateParticleSetFrozen, params CUserMsg\_ParticleManager.Types.UpdateParticleSetFrozen\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateParticleSetFrozen__ctor"></a> UpdateParticleSetFrozen\(\)

```csharp
public UpdateParticleSetFrozen()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateParticleSetFrozen__ctor_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateParticleSetFrozen_"></a> UpdateParticleSetFrozen\(UpdateParticleSetFrozen\)

```csharp
public UpdateParticleSetFrozen(CUserMsg_ParticleManager.Types.UpdateParticleSetFrozen other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[UpdateParticleSetFrozen](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.UpdateParticleSetFrozen.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateParticleSetFrozen_SetFrozenFieldNumber"></a> SetFrozenFieldNumber

```csharp
public const int SetFrozenFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateParticleSetFrozen_TransitionDurationFieldNumber"></a> TransitionDurationFieldNumber

```csharp
public const int TransitionDurationFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateParticleSetFrozen_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateParticleSetFrozen_HasSetFrozen"></a> HasSetFrozen

```csharp
public bool HasSetFrozen { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateParticleSetFrozen_HasTransitionDuration"></a> HasTransitionDuration

```csharp
public bool HasTransitionDuration { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateParticleSetFrozen_Parser"></a> Parser

```csharp
public static MessageParser<CUserMsg_ParticleManager.Types.UpdateParticleSetFrozen> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[UpdateParticleSetFrozen](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.UpdateParticleSetFrozen.md)\>

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateParticleSetFrozen_SetFrozen"></a> SetFrozen

```csharp
public bool SetFrozen { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateParticleSetFrozen_TransitionDuration"></a> TransitionDuration

```csharp
public float TransitionDuration { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateParticleSetFrozen_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateParticleSetFrozen_ClearSetFrozen"></a> ClearSetFrozen\(\)

```csharp
public void ClearSetFrozen()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateParticleSetFrozen_ClearTransitionDuration"></a> ClearTransitionDuration\(\)

```csharp
public void ClearTransitionDuration()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateParticleSetFrozen_Clone"></a> Clone\(\)

```csharp
public CUserMsg_ParticleManager.Types.UpdateParticleSetFrozen Clone()
```

#### Returns

 [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[UpdateParticleSetFrozen](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.UpdateParticleSetFrozen.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateParticleSetFrozen_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateParticleSetFrozen_Equals_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateParticleSetFrozen_"></a> Equals\(UpdateParticleSetFrozen\)

```csharp
public bool Equals(CUserMsg_ParticleManager.Types.UpdateParticleSetFrozen other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[UpdateParticleSetFrozen](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.UpdateParticleSetFrozen.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateParticleSetFrozen_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateParticleSetFrozen_MergeFrom_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateParticleSetFrozen_"></a> MergeFrom\(UpdateParticleSetFrozen\)

```csharp
public void MergeFrom(CUserMsg_ParticleManager.Types.UpdateParticleSetFrozen other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[UpdateParticleSetFrozen](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.UpdateParticleSetFrozen.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateParticleSetFrozen_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateParticleSetFrozen_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateParticleSetFrozen_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

