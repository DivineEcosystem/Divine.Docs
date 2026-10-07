# <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetSceneObjectTintAndDesat"></a> Class CUserMsg\_ParticleManager.Types.SetSceneObjectTintAndDesat

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMsg_ParticleManager.Types.SetSceneObjectTintAndDesat : IMessage<CUserMsg_ParticleManager.Types.SetSceneObjectTintAndDesat>, IEquatable<CUserMsg_ParticleManager.Types.SetSceneObjectTintAndDesat>, IDeepCloneable<CUserMsg_ParticleManager.Types.SetSceneObjectTintAndDesat>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMsg\_ParticleManager.Types.SetSceneObjectTintAndDesat](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetSceneObjectTintAndDesat.md)

#### Implements

IMessage<CUserMsg\_ParticleManager.Types.SetSceneObjectTintAndDesat\>, 
[IEquatable<CUserMsg\_ParticleManager.Types.SetSceneObjectTintAndDesat\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMsg\_ParticleManager.Types.SetSceneObjectTintAndDesat\>, 
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
[EnumerableExtensions.In<CUserMsg\_ParticleManager.Types.SetSceneObjectTintAndDesat\>\(CUserMsg\_ParticleManager.Types.SetSceneObjectTintAndDesat, params CUserMsg\_ParticleManager.Types.SetSceneObjectTintAndDesat\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetSceneObjectTintAndDesat__ctor"></a> SetSceneObjectTintAndDesat\(\)

```csharp
public SetSceneObjectTintAndDesat()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetSceneObjectTintAndDesat__ctor_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetSceneObjectTintAndDesat_"></a> SetSceneObjectTintAndDesat\(SetSceneObjectTintAndDesat\)

```csharp
public SetSceneObjectTintAndDesat(CUserMsg_ParticleManager.Types.SetSceneObjectTintAndDesat other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetSceneObjectTintAndDesat](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetSceneObjectTintAndDesat.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetSceneObjectTintAndDesat_DesatFieldNumber"></a> DesatFieldNumber

```csharp
public const int DesatFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetSceneObjectTintAndDesat_TintFieldNumber"></a> TintFieldNumber

```csharp
public const int TintFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetSceneObjectTintAndDesat_Desat"></a> Desat

```csharp
public float Desat { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetSceneObjectTintAndDesat_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetSceneObjectTintAndDesat_HasDesat"></a> HasDesat

```csharp
public bool HasDesat { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetSceneObjectTintAndDesat_HasTint"></a> HasTint

```csharp
public bool HasTint { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetSceneObjectTintAndDesat_Parser"></a> Parser

```csharp
public static MessageParser<CUserMsg_ParticleManager.Types.SetSceneObjectTintAndDesat> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetSceneObjectTintAndDesat](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetSceneObjectTintAndDesat.md)\>

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetSceneObjectTintAndDesat_Tint"></a> Tint

```csharp
public uint Tint { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetSceneObjectTintAndDesat_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetSceneObjectTintAndDesat_ClearDesat"></a> ClearDesat\(\)

```csharp
public void ClearDesat()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetSceneObjectTintAndDesat_ClearTint"></a> ClearTint\(\)

```csharp
public void ClearTint()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetSceneObjectTintAndDesat_Clone"></a> Clone\(\)

```csharp
public CUserMsg_ParticleManager.Types.SetSceneObjectTintAndDesat Clone()
```

#### Returns

 [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetSceneObjectTintAndDesat](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetSceneObjectTintAndDesat.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetSceneObjectTintAndDesat_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetSceneObjectTintAndDesat_Equals_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetSceneObjectTintAndDesat_"></a> Equals\(SetSceneObjectTintAndDesat\)

```csharp
public bool Equals(CUserMsg_ParticleManager.Types.SetSceneObjectTintAndDesat other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetSceneObjectTintAndDesat](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetSceneObjectTintAndDesat.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetSceneObjectTintAndDesat_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetSceneObjectTintAndDesat_MergeFrom_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetSceneObjectTintAndDesat_"></a> MergeFrom\(SetSceneObjectTintAndDesat\)

```csharp
public void MergeFrom(CUserMsg_ParticleManager.Types.SetSceneObjectTintAndDesat other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetSceneObjectTintAndDesat](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetSceneObjectTintAndDesat.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetSceneObjectTintAndDesat_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetSceneObjectTintAndDesat_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetSceneObjectTintAndDesat_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

