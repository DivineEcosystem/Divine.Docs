# <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyParticleNamed"></a> Class CUserMsg\_ParticleManager.Types.DestroyParticleNamed

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMsg_ParticleManager.Types.DestroyParticleNamed : IMessage<CUserMsg_ParticleManager.Types.DestroyParticleNamed>, IEquatable<CUserMsg_ParticleManager.Types.DestroyParticleNamed>, IDeepCloneable<CUserMsg_ParticleManager.Types.DestroyParticleNamed>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMsg\_ParticleManager.Types.DestroyParticleNamed](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.DestroyParticleNamed.md)

#### Implements

IMessage<CUserMsg\_ParticleManager.Types.DestroyParticleNamed\>, 
[IEquatable<CUserMsg\_ParticleManager.Types.DestroyParticleNamed\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMsg\_ParticleManager.Types.DestroyParticleNamed\>, 
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
[EnumerableExtensions.In<CUserMsg\_ParticleManager.Types.DestroyParticleNamed\>\(CUserMsg\_ParticleManager.Types.DestroyParticleNamed, params CUserMsg\_ParticleManager.Types.DestroyParticleNamed\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyParticleNamed__ctor"></a> DestroyParticleNamed\(\)

```csharp
public DestroyParticleNamed()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyParticleNamed__ctor_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyParticleNamed_"></a> DestroyParticleNamed\(DestroyParticleNamed\)

```csharp
public DestroyParticleNamed(CUserMsg_ParticleManager.Types.DestroyParticleNamed other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[DestroyParticleNamed](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.DestroyParticleNamed.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyParticleNamed_DestroyImmediatelyFieldNumber"></a> DestroyImmediatelyFieldNumber

```csharp
public const int DestroyImmediatelyFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyParticleNamed_EntityHandleFieldNumber"></a> EntityHandleFieldNumber

```csharp
public const int EntityHandleFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyParticleNamed_ParticleNameIndexFieldNumber"></a> ParticleNameIndexFieldNumber

```csharp
public const int ParticleNameIndexFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyParticleNamed_PlayEndcapFieldNumber"></a> PlayEndcapFieldNumber

```csharp
public const int PlayEndcapFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyParticleNamed_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyParticleNamed_DestroyImmediately"></a> DestroyImmediately

```csharp
public bool DestroyImmediately { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyParticleNamed_EntityHandle"></a> EntityHandle

```csharp
public uint EntityHandle { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyParticleNamed_HasDestroyImmediately"></a> HasDestroyImmediately

```csharp
public bool HasDestroyImmediately { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyParticleNamed_HasEntityHandle"></a> HasEntityHandle

```csharp
public bool HasEntityHandle { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyParticleNamed_HasParticleNameIndex"></a> HasParticleNameIndex

```csharp
public bool HasParticleNameIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyParticleNamed_HasPlayEndcap"></a> HasPlayEndcap

```csharp
public bool HasPlayEndcap { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyParticleNamed_Parser"></a> Parser

```csharp
public static MessageParser<CUserMsg_ParticleManager.Types.DestroyParticleNamed> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[DestroyParticleNamed](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.DestroyParticleNamed.md)\>

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyParticleNamed_ParticleNameIndex"></a> ParticleNameIndex

```csharp
public ulong ParticleNameIndex { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyParticleNamed_PlayEndcap"></a> PlayEndcap

```csharp
public bool PlayEndcap { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyParticleNamed_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyParticleNamed_ClearDestroyImmediately"></a> ClearDestroyImmediately\(\)

```csharp
public void ClearDestroyImmediately()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyParticleNamed_ClearEntityHandle"></a> ClearEntityHandle\(\)

```csharp
public void ClearEntityHandle()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyParticleNamed_ClearParticleNameIndex"></a> ClearParticleNameIndex\(\)

```csharp
public void ClearParticleNameIndex()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyParticleNamed_ClearPlayEndcap"></a> ClearPlayEndcap\(\)

```csharp
public void ClearPlayEndcap()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyParticleNamed_Clone"></a> Clone\(\)

```csharp
public CUserMsg_ParticleManager.Types.DestroyParticleNamed Clone()
```

#### Returns

 [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[DestroyParticleNamed](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.DestroyParticleNamed.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyParticleNamed_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyParticleNamed_Equals_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyParticleNamed_"></a> Equals\(DestroyParticleNamed\)

```csharp
public bool Equals(CUserMsg_ParticleManager.Types.DestroyParticleNamed other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[DestroyParticleNamed](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.DestroyParticleNamed.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyParticleNamed_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyParticleNamed_MergeFrom_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyParticleNamed_"></a> MergeFrom\(DestroyParticleNamed\)

```csharp
public void MergeFrom(CUserMsg_ParticleManager.Types.DestroyParticleNamed other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[DestroyParticleNamed](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.DestroyParticleNamed.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyParticleNamed_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyParticleNamed_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_DestroyParticleNamed_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

