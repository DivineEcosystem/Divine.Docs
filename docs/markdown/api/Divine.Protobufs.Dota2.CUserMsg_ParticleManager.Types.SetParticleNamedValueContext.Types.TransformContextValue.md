# <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleNamedValueContext_Types_TransformContextValue"></a> Class CUserMsg\_ParticleManager.Types.SetParticleNamedValueContext.Types.TransformContextValue

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMsg_ParticleManager.Types.SetParticleNamedValueContext.Types.TransformContextValue : IMessage<CUserMsg_ParticleManager.Types.SetParticleNamedValueContext.Types.TransformContextValue>, IEquatable<CUserMsg_ParticleManager.Types.SetParticleNamedValueContext.Types.TransformContextValue>, IDeepCloneable<CUserMsg_ParticleManager.Types.SetParticleNamedValueContext.Types.TransformContextValue>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMsg\_ParticleManager.Types.SetParticleNamedValueContext.Types.TransformContextValue](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetParticleNamedValueContext.Types.TransformContextValue.md)

#### Implements

IMessage<CUserMsg\_ParticleManager.Types.SetParticleNamedValueContext.Types.TransformContextValue\>, 
[IEquatable<CUserMsg\_ParticleManager.Types.SetParticleNamedValueContext.Types.TransformContextValue\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMsg\_ParticleManager.Types.SetParticleNamedValueContext.Types.TransformContextValue\>, 
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
[EnumerableExtensions.In<CUserMsg\_ParticleManager.Types.SetParticleNamedValueContext.Types.TransformContextValue\>\(CUserMsg\_ParticleManager.Types.SetParticleNamedValueContext.Types.TransformContextValue, params CUserMsg\_ParticleManager.Types.SetParticleNamedValueContext.Types.TransformContextValue\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleNamedValueContext_Types_TransformContextValue__ctor"></a> TransformContextValue\(\)

```csharp
public TransformContextValue()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleNamedValueContext_Types_TransformContextValue__ctor_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleNamedValueContext_Types_TransformContextValue_"></a> TransformContextValue\(TransformContextValue\)

```csharp
public TransformContextValue(CUserMsg_ParticleManager.Types.SetParticleNamedValueContext.Types.TransformContextValue other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetParticleNamedValueContext](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetParticleNamedValueContext.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetParticleNamedValueContext.Types.md).[TransformContextValue](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetParticleNamedValueContext.Types.TransformContextValue.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleNamedValueContext_Types_TransformContextValue_AnglesFieldNumber"></a> AnglesFieldNumber

```csharp
public const int AnglesFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleNamedValueContext_Types_TransformContextValue_TranslationFieldNumber"></a> TranslationFieldNumber

```csharp
public const int TranslationFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleNamedValueContext_Types_TransformContextValue_ValueNameHashFieldNumber"></a> ValueNameHashFieldNumber

```csharp
public const int ValueNameHashFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleNamedValueContext_Types_TransformContextValue_Angles"></a> Angles

```csharp
public CMsgQAngle Angles { get; set; }
```

#### Property Value

 [CMsgQAngle](Divine.Protobufs.Dota2.CMsgQAngle.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleNamedValueContext_Types_TransformContextValue_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleNamedValueContext_Types_TransformContextValue_HasValueNameHash"></a> HasValueNameHash

```csharp
public bool HasValueNameHash { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleNamedValueContext_Types_TransformContextValue_Parser"></a> Parser

```csharp
public static MessageParser<CUserMsg_ParticleManager.Types.SetParticleNamedValueContext.Types.TransformContextValue> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetParticleNamedValueContext](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetParticleNamedValueContext.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetParticleNamedValueContext.Types.md).[TransformContextValue](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetParticleNamedValueContext.Types.TransformContextValue.md)\>

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleNamedValueContext_Types_TransformContextValue_Translation"></a> Translation

```csharp
public CMsgVector Translation { get; set; }
```

#### Property Value

 [CMsgVector](Divine.Protobufs.Dota2.CMsgVector.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleNamedValueContext_Types_TransformContextValue_ValueNameHash"></a> ValueNameHash

```csharp
public uint ValueNameHash { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleNamedValueContext_Types_TransformContextValue_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleNamedValueContext_Types_TransformContextValue_ClearValueNameHash"></a> ClearValueNameHash\(\)

```csharp
public void ClearValueNameHash()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleNamedValueContext_Types_TransformContextValue_Clone"></a> Clone\(\)

```csharp
public CUserMsg_ParticleManager.Types.SetParticleNamedValueContext.Types.TransformContextValue Clone()
```

#### Returns

 [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetParticleNamedValueContext](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetParticleNamedValueContext.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetParticleNamedValueContext.Types.md).[TransformContextValue](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetParticleNamedValueContext.Types.TransformContextValue.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleNamedValueContext_Types_TransformContextValue_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleNamedValueContext_Types_TransformContextValue_Equals_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleNamedValueContext_Types_TransformContextValue_"></a> Equals\(TransformContextValue\)

```csharp
public bool Equals(CUserMsg_ParticleManager.Types.SetParticleNamedValueContext.Types.TransformContextValue other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetParticleNamedValueContext](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetParticleNamedValueContext.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetParticleNamedValueContext.Types.md).[TransformContextValue](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetParticleNamedValueContext.Types.TransformContextValue.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleNamedValueContext_Types_TransformContextValue_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleNamedValueContext_Types_TransformContextValue_MergeFrom_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleNamedValueContext_Types_TransformContextValue_"></a> MergeFrom\(TransformContextValue\)

```csharp
public void MergeFrom(CUserMsg_ParticleManager.Types.SetParticleNamedValueContext.Types.TransformContextValue other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetParticleNamedValueContext](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetParticleNamedValueContext.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetParticleNamedValueContext.Types.md).[TransformContextValue](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetParticleNamedValueContext.Types.TransformContextValue.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleNamedValueContext_Types_TransformContextValue_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleNamedValueContext_Types_TransformContextValue_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleNamedValueContext_Types_TransformContextValue_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

