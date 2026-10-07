# <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetMaterialOverride"></a> Class CUserMsg\_ParticleManager.Types.SetMaterialOverride

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMsg_ParticleManager.Types.SetMaterialOverride : IMessage<CUserMsg_ParticleManager.Types.SetMaterialOverride>, IEquatable<CUserMsg_ParticleManager.Types.SetMaterialOverride>, IDeepCloneable<CUserMsg_ParticleManager.Types.SetMaterialOverride>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMsg\_ParticleManager.Types.SetMaterialOverride](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetMaterialOverride.md)

#### Implements

IMessage<CUserMsg\_ParticleManager.Types.SetMaterialOverride\>, 
[IEquatable<CUserMsg\_ParticleManager.Types.SetMaterialOverride\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMsg\_ParticleManager.Types.SetMaterialOverride\>, 
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
[EnumerableExtensions.In<CUserMsg\_ParticleManager.Types.SetMaterialOverride\>\(CUserMsg\_ParticleManager.Types.SetMaterialOverride, params CUserMsg\_ParticleManager.Types.SetMaterialOverride\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetMaterialOverride__ctor"></a> SetMaterialOverride\(\)

```csharp
public SetMaterialOverride()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetMaterialOverride__ctor_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetMaterialOverride_"></a> SetMaterialOverride\(SetMaterialOverride\)

```csharp
public SetMaterialOverride(CUserMsg_ParticleManager.Types.SetMaterialOverride other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetMaterialOverride](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetMaterialOverride.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetMaterialOverride_IncludeChildrenFieldNumber"></a> IncludeChildrenFieldNumber

```csharp
public const int IncludeChildrenFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetMaterialOverride_MaterialNameFieldNumber"></a> MaterialNameFieldNumber

```csharp
public const int MaterialNameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetMaterialOverride_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetMaterialOverride_HasIncludeChildren"></a> HasIncludeChildren

```csharp
public bool HasIncludeChildren { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetMaterialOverride_HasMaterialName"></a> HasMaterialName

```csharp
public bool HasMaterialName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetMaterialOverride_IncludeChildren"></a> IncludeChildren

```csharp
public bool IncludeChildren { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetMaterialOverride_MaterialName"></a> MaterialName

```csharp
public string MaterialName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetMaterialOverride_Parser"></a> Parser

```csharp
public static MessageParser<CUserMsg_ParticleManager.Types.SetMaterialOverride> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetMaterialOverride](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetMaterialOverride.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetMaterialOverride_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetMaterialOverride_ClearIncludeChildren"></a> ClearIncludeChildren\(\)

```csharp
public void ClearIncludeChildren()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetMaterialOverride_ClearMaterialName"></a> ClearMaterialName\(\)

```csharp
public void ClearMaterialName()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetMaterialOverride_Clone"></a> Clone\(\)

```csharp
public CUserMsg_ParticleManager.Types.SetMaterialOverride Clone()
```

#### Returns

 [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetMaterialOverride](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetMaterialOverride.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetMaterialOverride_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetMaterialOverride_Equals_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetMaterialOverride_"></a> Equals\(SetMaterialOverride\)

```csharp
public bool Equals(CUserMsg_ParticleManager.Types.SetMaterialOverride other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetMaterialOverride](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetMaterialOverride.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetMaterialOverride_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetMaterialOverride_MergeFrom_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetMaterialOverride_"></a> MergeFrom\(SetMaterialOverride\)

```csharp
public void MergeFrom(CUserMsg_ParticleManager.Types.SetMaterialOverride other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetMaterialOverride](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetMaterialOverride.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetMaterialOverride_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetMaterialOverride_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetMaterialOverride_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

