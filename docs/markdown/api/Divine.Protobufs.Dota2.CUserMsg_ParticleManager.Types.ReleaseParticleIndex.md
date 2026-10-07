# <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ReleaseParticleIndex"></a> Class CUserMsg\_ParticleManager.Types.ReleaseParticleIndex

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMsg_ParticleManager.Types.ReleaseParticleIndex : IMessage<CUserMsg_ParticleManager.Types.ReleaseParticleIndex>, IEquatable<CUserMsg_ParticleManager.Types.ReleaseParticleIndex>, IDeepCloneable<CUserMsg_ParticleManager.Types.ReleaseParticleIndex>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMsg\_ParticleManager.Types.ReleaseParticleIndex](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.ReleaseParticleIndex.md)

#### Implements

IMessage<CUserMsg\_ParticleManager.Types.ReleaseParticleIndex\>, 
[IEquatable<CUserMsg\_ParticleManager.Types.ReleaseParticleIndex\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMsg\_ParticleManager.Types.ReleaseParticleIndex\>, 
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
[EnumerableExtensions.In<CUserMsg\_ParticleManager.Types.ReleaseParticleIndex\>\(CUserMsg\_ParticleManager.Types.ReleaseParticleIndex, params CUserMsg\_ParticleManager.Types.ReleaseParticleIndex\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ReleaseParticleIndex__ctor"></a> ReleaseParticleIndex\(\)

```csharp
public ReleaseParticleIndex()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ReleaseParticleIndex__ctor_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ReleaseParticleIndex_"></a> ReleaseParticleIndex\(ReleaseParticleIndex\)

```csharp
public ReleaseParticleIndex(CUserMsg_ParticleManager.Types.ReleaseParticleIndex other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[ReleaseParticleIndex](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.ReleaseParticleIndex.md)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ReleaseParticleIndex_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ReleaseParticleIndex_Parser"></a> Parser

```csharp
public static MessageParser<CUserMsg_ParticleManager.Types.ReleaseParticleIndex> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[ReleaseParticleIndex](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.ReleaseParticleIndex.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ReleaseParticleIndex_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ReleaseParticleIndex_Clone"></a> Clone\(\)

```csharp
public CUserMsg_ParticleManager.Types.ReleaseParticleIndex Clone()
```

#### Returns

 [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[ReleaseParticleIndex](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.ReleaseParticleIndex.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ReleaseParticleIndex_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ReleaseParticleIndex_Equals_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ReleaseParticleIndex_"></a> Equals\(ReleaseParticleIndex\)

```csharp
public bool Equals(CUserMsg_ParticleManager.Types.ReleaseParticleIndex other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[ReleaseParticleIndex](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.ReleaseParticleIndex.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ReleaseParticleIndex_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ReleaseParticleIndex_MergeFrom_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ReleaseParticleIndex_"></a> MergeFrom\(ReleaseParticleIndex\)

```csharp
public void MergeFrom(CUserMsg_ParticleManager.Types.ReleaseParticleIndex other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[ReleaseParticleIndex](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.ReleaseParticleIndex.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ReleaseParticleIndex_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ReleaseParticleIndex_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ReleaseParticleIndex_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

