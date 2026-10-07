# <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyPhysicsSim"></a> Class CUserMsg\_ParticleManager.Types.DestroyPhysicsSim

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMsg_ParticleManager.Types.DestroyPhysicsSim : IMessage<CUserMsg_ParticleManager.Types.DestroyPhysicsSim>, IEquatable<CUserMsg_ParticleManager.Types.DestroyPhysicsSim>, IDeepCloneable<CUserMsg_ParticleManager.Types.DestroyPhysicsSim>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMsg\_ParticleManager.Types.DestroyPhysicsSim](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.DestroyPhysicsSim.md)

#### Implements

IMessage<CUserMsg\_ParticleManager.Types.DestroyPhysicsSim\>, 
[IEquatable<CUserMsg\_ParticleManager.Types.DestroyPhysicsSim\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMsg\_ParticleManager.Types.DestroyPhysicsSim\>, 
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
[EnumerableExtensions.In<CUserMsg\_ParticleManager.Types.DestroyPhysicsSim\>\(CUserMsg\_ParticleManager.Types.DestroyPhysicsSim, params CUserMsg\_ParticleManager.Types.DestroyPhysicsSim\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyPhysicsSim__ctor"></a> DestroyPhysicsSim\(\)

```csharp
public DestroyPhysicsSim()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyPhysicsSim__ctor_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyPhysicsSim_"></a> DestroyPhysicsSim\(DestroyPhysicsSim\)

```csharp
public DestroyPhysicsSim(CUserMsg_ParticleManager.Types.DestroyPhysicsSim other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[DestroyPhysicsSim](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.DestroyPhysicsSim.md)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyPhysicsSim_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyPhysicsSim_Parser"></a> Parser

```csharp
public static MessageParser<CUserMsg_ParticleManager.Types.DestroyPhysicsSim> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[DestroyPhysicsSim](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.DestroyPhysicsSim.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyPhysicsSim_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyPhysicsSim_Clone"></a> Clone\(\)

```csharp
public CUserMsg_ParticleManager.Types.DestroyPhysicsSim Clone()
```

#### Returns

 [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[DestroyPhysicsSim](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.DestroyPhysicsSim.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyPhysicsSim_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyPhysicsSim_Equals_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyPhysicsSim_"></a> Equals\(DestroyPhysicsSim\)

```csharp
public bool Equals(CUserMsg_ParticleManager.Types.DestroyPhysicsSim other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[DestroyPhysicsSim](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.DestroyPhysicsSim.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyPhysicsSim_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyPhysicsSim_MergeFrom_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyPhysicsSim_"></a> MergeFrom\(DestroyPhysicsSim\)

```csharp
public void MergeFrom(CUserMsg_ParticleManager.Types.DestroyPhysicsSim other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[DestroyPhysicsSim](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.DestroyPhysicsSim.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyPhysicsSim_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyPhysicsSim_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyPhysicsSim_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

