# <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateParticleShouldDraw"></a> Class CUserMsg\_ParticleManager.Types.UpdateParticleShouldDraw

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMsg_ParticleManager.Types.UpdateParticleShouldDraw : IMessage<CUserMsg_ParticleManager.Types.UpdateParticleShouldDraw>, IEquatable<CUserMsg_ParticleManager.Types.UpdateParticleShouldDraw>, IDeepCloneable<CUserMsg_ParticleManager.Types.UpdateParticleShouldDraw>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMsg\_ParticleManager.Types.UpdateParticleShouldDraw](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.UpdateParticleShouldDraw.md)

#### Implements

IMessage<CUserMsg\_ParticleManager.Types.UpdateParticleShouldDraw\>, 
[IEquatable<CUserMsg\_ParticleManager.Types.UpdateParticleShouldDraw\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMsg\_ParticleManager.Types.UpdateParticleShouldDraw\>, 
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
[EnumerableExtensions.In<CUserMsg\_ParticleManager.Types.UpdateParticleShouldDraw\>\(CUserMsg\_ParticleManager.Types.UpdateParticleShouldDraw, params CUserMsg\_ParticleManager.Types.UpdateParticleShouldDraw\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateParticleShouldDraw__ctor"></a> UpdateParticleShouldDraw\(\)

```csharp
public UpdateParticleShouldDraw()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateParticleShouldDraw__ctor_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateParticleShouldDraw_"></a> UpdateParticleShouldDraw\(UpdateParticleShouldDraw\)

```csharp
public UpdateParticleShouldDraw(CUserMsg_ParticleManager.Types.UpdateParticleShouldDraw other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[UpdateParticleShouldDraw](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.UpdateParticleShouldDraw.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateParticleShouldDraw_ShouldDrawFieldNumber"></a> ShouldDrawFieldNumber

```csharp
public const int ShouldDrawFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateParticleShouldDraw_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateParticleShouldDraw_HasShouldDraw"></a> HasShouldDraw

```csharp
public bool HasShouldDraw { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateParticleShouldDraw_Parser"></a> Parser

```csharp
public static MessageParser<CUserMsg_ParticleManager.Types.UpdateParticleShouldDraw> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[UpdateParticleShouldDraw](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.UpdateParticleShouldDraw.md)\>

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateParticleShouldDraw_ShouldDraw"></a> ShouldDraw

```csharp
public bool ShouldDraw { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateParticleShouldDraw_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateParticleShouldDraw_ClearShouldDraw"></a> ClearShouldDraw\(\)

```csharp
public void ClearShouldDraw()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateParticleShouldDraw_Clone"></a> Clone\(\)

```csharp
public CUserMsg_ParticleManager.Types.UpdateParticleShouldDraw Clone()
```

#### Returns

 [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[UpdateParticleShouldDraw](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.UpdateParticleShouldDraw.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateParticleShouldDraw_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateParticleShouldDraw_Equals_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateParticleShouldDraw_"></a> Equals\(UpdateParticleShouldDraw\)

```csharp
public bool Equals(CUserMsg_ParticleManager.Types.UpdateParticleShouldDraw other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[UpdateParticleShouldDraw](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.UpdateParticleShouldDraw.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateParticleShouldDraw_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateParticleShouldDraw_MergeFrom_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateParticleShouldDraw_"></a> MergeFrom\(UpdateParticleShouldDraw\)

```csharp
public void MergeFrom(CUserMsg_ParticleManager.Types.UpdateParticleShouldDraw other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[UpdateParticleShouldDraw](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.UpdateParticleShouldDraw.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateParticleShouldDraw_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateParticleShouldDraw_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateParticleShouldDraw_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

