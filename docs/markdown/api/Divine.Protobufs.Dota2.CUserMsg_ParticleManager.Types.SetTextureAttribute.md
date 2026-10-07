# <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetTextureAttribute"></a> Class CUserMsg\_ParticleManager.Types.SetTextureAttribute

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMsg_ParticleManager.Types.SetTextureAttribute : IMessage<CUserMsg_ParticleManager.Types.SetTextureAttribute>, IEquatable<CUserMsg_ParticleManager.Types.SetTextureAttribute>, IDeepCloneable<CUserMsg_ParticleManager.Types.SetTextureAttribute>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMsg\_ParticleManager.Types.SetTextureAttribute](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetTextureAttribute.md)

#### Implements

IMessage<CUserMsg\_ParticleManager.Types.SetTextureAttribute\>, 
[IEquatable<CUserMsg\_ParticleManager.Types.SetTextureAttribute\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMsg\_ParticleManager.Types.SetTextureAttribute\>, 
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
[EnumerableExtensions.In<CUserMsg\_ParticleManager.Types.SetTextureAttribute\>\(CUserMsg\_ParticleManager.Types.SetTextureAttribute, params CUserMsg\_ParticleManager.Types.SetTextureAttribute\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetTextureAttribute__ctor"></a> SetTextureAttribute\(\)

```csharp
public SetTextureAttribute()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetTextureAttribute__ctor_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetTextureAttribute_"></a> SetTextureAttribute\(SetTextureAttribute\)

```csharp
public SetTextureAttribute(CUserMsg_ParticleManager.Types.SetTextureAttribute other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetTextureAttribute](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetTextureAttribute.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetTextureAttribute_AttributeNameFieldNumber"></a> AttributeNameFieldNumber

```csharp
public const int AttributeNameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetTextureAttribute_TextureNameFieldNumber"></a> TextureNameFieldNumber

```csharp
public const int TextureNameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetTextureAttribute_AttributeName"></a> AttributeName

```csharp
public string AttributeName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetTextureAttribute_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetTextureAttribute_HasAttributeName"></a> HasAttributeName

```csharp
public bool HasAttributeName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetTextureAttribute_HasTextureName"></a> HasTextureName

```csharp
public bool HasTextureName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetTextureAttribute_Parser"></a> Parser

```csharp
public static MessageParser<CUserMsg_ParticleManager.Types.SetTextureAttribute> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetTextureAttribute](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetTextureAttribute.md)\>

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetTextureAttribute_TextureName"></a> TextureName

```csharp
public string TextureName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetTextureAttribute_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetTextureAttribute_ClearAttributeName"></a> ClearAttributeName\(\)

```csharp
public void ClearAttributeName()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetTextureAttribute_ClearTextureName"></a> ClearTextureName\(\)

```csharp
public void ClearTextureName()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetTextureAttribute_Clone"></a> Clone\(\)

```csharp
public CUserMsg_ParticleManager.Types.SetTextureAttribute Clone()
```

#### Returns

 [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetTextureAttribute](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetTextureAttribute.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetTextureAttribute_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetTextureAttribute_Equals_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetTextureAttribute_"></a> Equals\(SetTextureAttribute\)

```csharp
public bool Equals(CUserMsg_ParticleManager.Types.SetTextureAttribute other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetTextureAttribute](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetTextureAttribute.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetTextureAttribute_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetTextureAttribute_MergeFrom_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetTextureAttribute_"></a> MergeFrom\(SetTextureAttribute\)

```csharp
public void MergeFrom(CUserMsg_ParticleManager.Types.SetTextureAttribute other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetTextureAttribute](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetTextureAttribute.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetTextureAttribute_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetTextureAttribute_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetTextureAttribute_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

