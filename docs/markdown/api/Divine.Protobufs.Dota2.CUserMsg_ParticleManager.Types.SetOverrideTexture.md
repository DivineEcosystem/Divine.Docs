# <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetOverrideTexture"></a> Class CUserMsg\_ParticleManager.Types.SetOverrideTexture

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMsg_ParticleManager.Types.SetOverrideTexture : IMessage<CUserMsg_ParticleManager.Types.SetOverrideTexture>, IEquatable<CUserMsg_ParticleManager.Types.SetOverrideTexture>, IDeepCloneable<CUserMsg_ParticleManager.Types.SetOverrideTexture>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMsg\_ParticleManager.Types.SetOverrideTexture](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetOverrideTexture.md)

#### Implements

IMessage<CUserMsg\_ParticleManager.Types.SetOverrideTexture\>, 
[IEquatable<CUserMsg\_ParticleManager.Types.SetOverrideTexture\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMsg\_ParticleManager.Types.SetOverrideTexture\>, 
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
[EnumerableExtensions.In<CUserMsg\_ParticleManager.Types.SetOverrideTexture\>\(CUserMsg\_ParticleManager.Types.SetOverrideTexture, params CUserMsg\_ParticleManager.Types.SetOverrideTexture\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetOverrideTexture__ctor"></a> SetOverrideTexture\(\)

```csharp
public SetOverrideTexture()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetOverrideTexture__ctor_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetOverrideTexture_"></a> SetOverrideTexture\(SetOverrideTexture\)

```csharp
public SetOverrideTexture(CUserMsg_ParticleManager.Types.SetOverrideTexture other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetOverrideTexture](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetOverrideTexture.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetOverrideTexture_TextureNameFieldNumber"></a> TextureNameFieldNumber

```csharp
public const int TextureNameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetOverrideTexture_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetOverrideTexture_HasTextureName"></a> HasTextureName

```csharp
public bool HasTextureName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetOverrideTexture_Parser"></a> Parser

```csharp
public static MessageParser<CUserMsg_ParticleManager.Types.SetOverrideTexture> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetOverrideTexture](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetOverrideTexture.md)\>

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetOverrideTexture_TextureName"></a> TextureName

```csharp
public string TextureName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetOverrideTexture_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetOverrideTexture_ClearTextureName"></a> ClearTextureName\(\)

```csharp
public void ClearTextureName()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetOverrideTexture_Clone"></a> Clone\(\)

```csharp
public CUserMsg_ParticleManager.Types.SetOverrideTexture Clone()
```

#### Returns

 [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetOverrideTexture](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetOverrideTexture.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetOverrideTexture_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetOverrideTexture_Equals_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetOverrideTexture_"></a> Equals\(SetOverrideTexture\)

```csharp
public bool Equals(CUserMsg_ParticleManager.Types.SetOverrideTexture other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetOverrideTexture](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetOverrideTexture.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetOverrideTexture_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetOverrideTexture_MergeFrom_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetOverrideTexture_"></a> MergeFrom\(SetOverrideTexture\)

```csharp
public void MergeFrom(CUserMsg_ParticleManager.Types.SetOverrideTexture other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetOverrideTexture](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetOverrideTexture.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetOverrideTexture_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetOverrideTexture_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetOverrideTexture_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

