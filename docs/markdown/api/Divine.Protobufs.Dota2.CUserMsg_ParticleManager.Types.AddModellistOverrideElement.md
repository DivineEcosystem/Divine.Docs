# <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_AddModellistOverrideElement"></a> Class CUserMsg\_ParticleManager.Types.AddModellistOverrideElement

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMsg_ParticleManager.Types.AddModellistOverrideElement : IMessage<CUserMsg_ParticleManager.Types.AddModellistOverrideElement>, IEquatable<CUserMsg_ParticleManager.Types.AddModellistOverrideElement>, IDeepCloneable<CUserMsg_ParticleManager.Types.AddModellistOverrideElement>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMsg\_ParticleManager.Types.AddModellistOverrideElement](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.AddModellistOverrideElement.md)

#### Implements

IMessage<CUserMsg\_ParticleManager.Types.AddModellistOverrideElement\>, 
[IEquatable<CUserMsg\_ParticleManager.Types.AddModellistOverrideElement\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMsg\_ParticleManager.Types.AddModellistOverrideElement\>, 
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
[EnumerableExtensions.In<CUserMsg\_ParticleManager.Types.AddModellistOverrideElement\>\(CUserMsg\_ParticleManager.Types.AddModellistOverrideElement, params CUserMsg\_ParticleManager.Types.AddModellistOverrideElement\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_AddModellistOverrideElement__ctor"></a> AddModellistOverrideElement\(\)

```csharp
public AddModellistOverrideElement()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_AddModellistOverrideElement__ctor_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_AddModellistOverrideElement_"></a> AddModellistOverrideElement\(AddModellistOverrideElement\)

```csharp
public AddModellistOverrideElement(CUserMsg_ParticleManager.Types.AddModellistOverrideElement other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[AddModellistOverrideElement](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.AddModellistOverrideElement.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_AddModellistOverrideElement_GroupidFieldNumber"></a> GroupidFieldNumber

```csharp
public const int GroupidFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_AddModellistOverrideElement_ModelNameFieldNumber"></a> ModelNameFieldNumber

```csharp
public const int ModelNameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_AddModellistOverrideElement_SpawnProbabilityFieldNumber"></a> SpawnProbabilityFieldNumber

```csharp
public const int SpawnProbabilityFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_AddModellistOverrideElement_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_AddModellistOverrideElement_Groupid"></a> Groupid

```csharp
public uint Groupid { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_AddModellistOverrideElement_HasGroupid"></a> HasGroupid

```csharp
public bool HasGroupid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_AddModellistOverrideElement_HasModelName"></a> HasModelName

```csharp
public bool HasModelName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_AddModellistOverrideElement_HasSpawnProbability"></a> HasSpawnProbability

```csharp
public bool HasSpawnProbability { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_AddModellistOverrideElement_ModelName"></a> ModelName

```csharp
public string ModelName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_AddModellistOverrideElement_Parser"></a> Parser

```csharp
public static MessageParser<CUserMsg_ParticleManager.Types.AddModellistOverrideElement> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[AddModellistOverrideElement](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.AddModellistOverrideElement.md)\>

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_AddModellistOverrideElement_SpawnProbability"></a> SpawnProbability

```csharp
public float SpawnProbability { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_AddModellistOverrideElement_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_AddModellistOverrideElement_ClearGroupid"></a> ClearGroupid\(\)

```csharp
public void ClearGroupid()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_AddModellistOverrideElement_ClearModelName"></a> ClearModelName\(\)

```csharp
public void ClearModelName()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_AddModellistOverrideElement_ClearSpawnProbability"></a> ClearSpawnProbability\(\)

```csharp
public void ClearSpawnProbability()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_AddModellistOverrideElement_Clone"></a> Clone\(\)

```csharp
public CUserMsg_ParticleManager.Types.AddModellistOverrideElement Clone()
```

#### Returns

 [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[AddModellistOverrideElement](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.AddModellistOverrideElement.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_AddModellistOverrideElement_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_AddModellistOverrideElement_Equals_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_AddModellistOverrideElement_"></a> Equals\(AddModellistOverrideElement\)

```csharp
public bool Equals(CUserMsg_ParticleManager.Types.AddModellistOverrideElement other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[AddModellistOverrideElement](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.AddModellistOverrideElement.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_AddModellistOverrideElement_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_AddModellistOverrideElement_MergeFrom_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_AddModellistOverrideElement_"></a> MergeFrom\(AddModellistOverrideElement\)

```csharp
public void MergeFrom(CUserMsg_ParticleManager.Types.AddModellistOverrideElement other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[AddModellistOverrideElement](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.AddModellistOverrideElement.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_AddModellistOverrideElement_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_AddModellistOverrideElement_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_AddModellistOverrideElement_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

