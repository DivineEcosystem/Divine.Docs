# <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyParticle"></a> Class CUserMsg\_ParticleManager.Types.DestroyParticle

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMsg_ParticleManager.Types.DestroyParticle : IMessage<CUserMsg_ParticleManager.Types.DestroyParticle>, IEquatable<CUserMsg_ParticleManager.Types.DestroyParticle>, IDeepCloneable<CUserMsg_ParticleManager.Types.DestroyParticle>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMsg\_ParticleManager.Types.DestroyParticle](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.DestroyParticle.md)

#### Implements

IMessage<CUserMsg\_ParticleManager.Types.DestroyParticle\>, 
[IEquatable<CUserMsg\_ParticleManager.Types.DestroyParticle\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMsg\_ParticleManager.Types.DestroyParticle\>, 
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
[EnumerableExtensions.In<CUserMsg\_ParticleManager.Types.DestroyParticle\>\(CUserMsg\_ParticleManager.Types.DestroyParticle, params CUserMsg\_ParticleManager.Types.DestroyParticle\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyParticle__ctor"></a> DestroyParticle\(\)

```csharp
public DestroyParticle()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyParticle__ctor_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyParticle_"></a> DestroyParticle\(DestroyParticle\)

```csharp
public DestroyParticle(CUserMsg_ParticleManager.Types.DestroyParticle other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[DestroyParticle](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.DestroyParticle.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyParticle_DestroyImmediatelyFieldNumber"></a> DestroyImmediatelyFieldNumber

```csharp
public const int DestroyImmediatelyFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyParticle_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyParticle_DestroyImmediately"></a> DestroyImmediately

```csharp
public bool DestroyImmediately { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyParticle_HasDestroyImmediately"></a> HasDestroyImmediately

```csharp
public bool HasDestroyImmediately { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyParticle_Parser"></a> Parser

```csharp
public static MessageParser<CUserMsg_ParticleManager.Types.DestroyParticle> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[DestroyParticle](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.DestroyParticle.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyParticle_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyParticle_ClearDestroyImmediately"></a> ClearDestroyImmediately\(\)

```csharp
public void ClearDestroyImmediately()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyParticle_Clone"></a> Clone\(\)

```csharp
public CUserMsg_ParticleManager.Types.DestroyParticle Clone()
```

#### Returns

 [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[DestroyParticle](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.DestroyParticle.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyParticle_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyParticle_Equals_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyParticle_"></a> Equals\(DestroyParticle\)

```csharp
public bool Equals(CUserMsg_ParticleManager.Types.DestroyParticle other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[DestroyParticle](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.DestroyParticle.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyParticle_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyParticle_MergeFrom_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyParticle_"></a> MergeFrom\(DestroyParticle\)

```csharp
public void MergeFrom(CUserMsg_ParticleManager.Types.DestroyParticle other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[DestroyParticle](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.DestroyParticle.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyParticle_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyParticle_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyParticle_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

