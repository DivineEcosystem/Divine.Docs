# <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ChangeControlPointAttachment"></a> Class CUserMsg\_ParticleManager.Types.ChangeControlPointAttachment

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMsg_ParticleManager.Types.ChangeControlPointAttachment : IMessage<CUserMsg_ParticleManager.Types.ChangeControlPointAttachment>, IEquatable<CUserMsg_ParticleManager.Types.ChangeControlPointAttachment>, IDeepCloneable<CUserMsg_ParticleManager.Types.ChangeControlPointAttachment>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMsg\_ParticleManager.Types.ChangeControlPointAttachment](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.ChangeControlPointAttachment.md)

#### Implements

IMessage<CUserMsg\_ParticleManager.Types.ChangeControlPointAttachment\>, 
[IEquatable<CUserMsg\_ParticleManager.Types.ChangeControlPointAttachment\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMsg\_ParticleManager.Types.ChangeControlPointAttachment\>, 
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
[EnumerableExtensions.In<CUserMsg\_ParticleManager.Types.ChangeControlPointAttachment\>\(CUserMsg\_ParticleManager.Types.ChangeControlPointAttachment, params CUserMsg\_ParticleManager.Types.ChangeControlPointAttachment\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ChangeControlPointAttachment__ctor"></a> ChangeControlPointAttachment\(\)

```csharp
public ChangeControlPointAttachment()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ChangeControlPointAttachment__ctor_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ChangeControlPointAttachment_"></a> ChangeControlPointAttachment\(ChangeControlPointAttachment\)

```csharp
public ChangeControlPointAttachment(CUserMsg_ParticleManager.Types.ChangeControlPointAttachment other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[ChangeControlPointAttachment](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.ChangeControlPointAttachment.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ChangeControlPointAttachment_AttachmentNewFieldNumber"></a> AttachmentNewFieldNumber

```csharp
public const int AttachmentNewFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ChangeControlPointAttachment_AttachmentOldFieldNumber"></a> AttachmentOldFieldNumber

```csharp
public const int AttachmentOldFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ChangeControlPointAttachment_EntityHandleFieldNumber"></a> EntityHandleFieldNumber

```csharp
public const int EntityHandleFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ChangeControlPointAttachment_AttachmentNew"></a> AttachmentNew

```csharp
public int AttachmentNew { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ChangeControlPointAttachment_AttachmentOld"></a> AttachmentOld

```csharp
public int AttachmentOld { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ChangeControlPointAttachment_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ChangeControlPointAttachment_EntityHandle"></a> EntityHandle

```csharp
public uint EntityHandle { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ChangeControlPointAttachment_HasAttachmentNew"></a> HasAttachmentNew

```csharp
public bool HasAttachmentNew { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ChangeControlPointAttachment_HasAttachmentOld"></a> HasAttachmentOld

```csharp
public bool HasAttachmentOld { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ChangeControlPointAttachment_HasEntityHandle"></a> HasEntityHandle

```csharp
public bool HasEntityHandle { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ChangeControlPointAttachment_Parser"></a> Parser

```csharp
public static MessageParser<CUserMsg_ParticleManager.Types.ChangeControlPointAttachment> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[ChangeControlPointAttachment](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.ChangeControlPointAttachment.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ChangeControlPointAttachment_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ChangeControlPointAttachment_ClearAttachmentNew"></a> ClearAttachmentNew\(\)

```csharp
public void ClearAttachmentNew()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ChangeControlPointAttachment_ClearAttachmentOld"></a> ClearAttachmentOld\(\)

```csharp
public void ClearAttachmentOld()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ChangeControlPointAttachment_ClearEntityHandle"></a> ClearEntityHandle\(\)

```csharp
public void ClearEntityHandle()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ChangeControlPointAttachment_Clone"></a> Clone\(\)

```csharp
public CUserMsg_ParticleManager.Types.ChangeControlPointAttachment Clone()
```

#### Returns

 [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[ChangeControlPointAttachment](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.ChangeControlPointAttachment.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ChangeControlPointAttachment_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ChangeControlPointAttachment_Equals_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ChangeControlPointAttachment_"></a> Equals\(ChangeControlPointAttachment\)

```csharp
public bool Equals(CUserMsg_ParticleManager.Types.ChangeControlPointAttachment other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[ChangeControlPointAttachment](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.ChangeControlPointAttachment.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ChangeControlPointAttachment_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ChangeControlPointAttachment_MergeFrom_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ChangeControlPointAttachment_"></a> MergeFrom\(ChangeControlPointAttachment\)

```csharp
public void MergeFrom(CUserMsg_ParticleManager.Types.ChangeControlPointAttachment other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[ChangeControlPointAttachment](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.ChangeControlPointAttachment.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ChangeControlPointAttachment_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ChangeControlPointAttachment_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ChangeControlPointAttachment_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

