# <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetControlPointSnapshot"></a> Class CUserMsg\_ParticleManager.Types.SetControlPointSnapshot

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMsg_ParticleManager.Types.SetControlPointSnapshot : IMessage<CUserMsg_ParticleManager.Types.SetControlPointSnapshot>, IEquatable<CUserMsg_ParticleManager.Types.SetControlPointSnapshot>, IDeepCloneable<CUserMsg_ParticleManager.Types.SetControlPointSnapshot>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMsg\_ParticleManager.Types.SetControlPointSnapshot](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetControlPointSnapshot.md)

#### Implements

IMessage<CUserMsg\_ParticleManager.Types.SetControlPointSnapshot\>, 
[IEquatable<CUserMsg\_ParticleManager.Types.SetControlPointSnapshot\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMsg\_ParticleManager.Types.SetControlPointSnapshot\>, 
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
[EnumerableExtensions.In<CUserMsg\_ParticleManager.Types.SetControlPointSnapshot\>\(CUserMsg\_ParticleManager.Types.SetControlPointSnapshot, params CUserMsg\_ParticleManager.Types.SetControlPointSnapshot\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetControlPointSnapshot__ctor"></a> SetControlPointSnapshot\(\)

```csharp
public SetControlPointSnapshot()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetControlPointSnapshot__ctor_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetControlPointSnapshot_"></a> SetControlPointSnapshot\(SetControlPointSnapshot\)

```csharp
public SetControlPointSnapshot(CUserMsg_ParticleManager.Types.SetControlPointSnapshot other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetControlPointSnapshot](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetControlPointSnapshot.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetControlPointSnapshot_ControlPointFieldNumber"></a> ControlPointFieldNumber

```csharp
public const int ControlPointFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetControlPointSnapshot_SnapshotNameFieldNumber"></a> SnapshotNameFieldNumber

```csharp
public const int SnapshotNameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetControlPointSnapshot_ControlPoint"></a> ControlPoint

```csharp
public int ControlPoint { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetControlPointSnapshot_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetControlPointSnapshot_HasControlPoint"></a> HasControlPoint

```csharp
public bool HasControlPoint { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetControlPointSnapshot_HasSnapshotName"></a> HasSnapshotName

```csharp
public bool HasSnapshotName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetControlPointSnapshot_Parser"></a> Parser

```csharp
public static MessageParser<CUserMsg_ParticleManager.Types.SetControlPointSnapshot> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetControlPointSnapshot](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetControlPointSnapshot.md)\>

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetControlPointSnapshot_SnapshotName"></a> SnapshotName

```csharp
public string SnapshotName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetControlPointSnapshot_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetControlPointSnapshot_ClearControlPoint"></a> ClearControlPoint\(\)

```csharp
public void ClearControlPoint()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetControlPointSnapshot_ClearSnapshotName"></a> ClearSnapshotName\(\)

```csharp
public void ClearSnapshotName()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetControlPointSnapshot_Clone"></a> Clone\(\)

```csharp
public CUserMsg_ParticleManager.Types.SetControlPointSnapshot Clone()
```

#### Returns

 [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetControlPointSnapshot](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetControlPointSnapshot.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetControlPointSnapshot_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetControlPointSnapshot_Equals_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetControlPointSnapshot_"></a> Equals\(SetControlPointSnapshot\)

```csharp
public bool Equals(CUserMsg_ParticleManager.Types.SetControlPointSnapshot other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetControlPointSnapshot](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetControlPointSnapshot.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetControlPointSnapshot_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetControlPointSnapshot_MergeFrom_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetControlPointSnapshot_"></a> MergeFrom\(SetControlPointSnapshot\)

```csharp
public void MergeFrom(CUserMsg_ParticleManager.Types.SetControlPointSnapshot other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetControlPointSnapshot](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetControlPointSnapshot.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetControlPointSnapshot_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetControlPointSnapshot_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetControlPointSnapshot_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

