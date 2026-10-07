# <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleNamedValueContext"></a> Class CUserMsg\_ParticleManager.Types.SetParticleNamedValueContext

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMsg_ParticleManager.Types.SetParticleNamedValueContext : IMessage<CUserMsg_ParticleManager.Types.SetParticleNamedValueContext>, IEquatable<CUserMsg_ParticleManager.Types.SetParticleNamedValueContext>, IDeepCloneable<CUserMsg_ParticleManager.Types.SetParticleNamedValueContext>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMsg\_ParticleManager.Types.SetParticleNamedValueContext](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetParticleNamedValueContext.md)

#### Implements

IMessage<CUserMsg\_ParticleManager.Types.SetParticleNamedValueContext\>, 
[IEquatable<CUserMsg\_ParticleManager.Types.SetParticleNamedValueContext\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMsg\_ParticleManager.Types.SetParticleNamedValueContext\>, 
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
[EnumerableExtensions.In<CUserMsg\_ParticleManager.Types.SetParticleNamedValueContext\>\(CUserMsg\_ParticleManager.Types.SetParticleNamedValueContext, params CUserMsg\_ParticleManager.Types.SetParticleNamedValueContext\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleNamedValueContext__ctor"></a> SetParticleNamedValueContext\(\)

```csharp
public SetParticleNamedValueContext()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleNamedValueContext__ctor_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleNamedValueContext_"></a> SetParticleNamedValueContext\(SetParticleNamedValueContext\)

```csharp
public SetParticleNamedValueContext(CUserMsg_ParticleManager.Types.SetParticleNamedValueContext other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetParticleNamedValueContext](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetParticleNamedValueContext.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleNamedValueContext_EhandleValuesFieldNumber"></a> EhandleValuesFieldNumber

```csharp
public const int EhandleValuesFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleNamedValueContext_FloatValuesFieldNumber"></a> FloatValuesFieldNumber

```csharp
public const int FloatValuesFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleNamedValueContext_TransformValuesFieldNumber"></a> TransformValuesFieldNumber

```csharp
public const int TransformValuesFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleNamedValueContext_VectorValuesFieldNumber"></a> VectorValuesFieldNumber

```csharp
public const int VectorValuesFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleNamedValueContext_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleNamedValueContext_EhandleValues"></a> EhandleValues

```csharp
public RepeatedField<CUserMsg_ParticleManager.Types.SetParticleNamedValueContext.Types.EHandleContext> EhandleValues { get; }
```

#### Property Value

 RepeatedField<[CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetParticleNamedValueContext](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetParticleNamedValueContext.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetParticleNamedValueContext.Types.md).[EHandleContext](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetParticleNamedValueContext.Types.EHandleContext.md)\>

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleNamedValueContext_FloatValues"></a> FloatValues

```csharp
public RepeatedField<CUserMsg_ParticleManager.Types.SetParticleNamedValueContext.Types.FloatContextValue> FloatValues { get; }
```

#### Property Value

 RepeatedField<[CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetParticleNamedValueContext](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetParticleNamedValueContext.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetParticleNamedValueContext.Types.md).[FloatContextValue](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetParticleNamedValueContext.Types.FloatContextValue.md)\>

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleNamedValueContext_Parser"></a> Parser

```csharp
public static MessageParser<CUserMsg_ParticleManager.Types.SetParticleNamedValueContext> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetParticleNamedValueContext](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetParticleNamedValueContext.md)\>

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleNamedValueContext_TransformValues"></a> TransformValues

```csharp
public RepeatedField<CUserMsg_ParticleManager.Types.SetParticleNamedValueContext.Types.TransformContextValue> TransformValues { get; }
```

#### Property Value

 RepeatedField<[CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetParticleNamedValueContext](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetParticleNamedValueContext.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetParticleNamedValueContext.Types.md).[TransformContextValue](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetParticleNamedValueContext.Types.TransformContextValue.md)\>

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleNamedValueContext_VectorValues"></a> VectorValues

```csharp
public RepeatedField<CUserMsg_ParticleManager.Types.SetParticleNamedValueContext.Types.VectorContextValue> VectorValues { get; }
```

#### Property Value

 RepeatedField<[CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetParticleNamedValueContext](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetParticleNamedValueContext.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetParticleNamedValueContext.Types.md).[VectorContextValue](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetParticleNamedValueContext.Types.VectorContextValue.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleNamedValueContext_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleNamedValueContext_Clone"></a> Clone\(\)

```csharp
public CUserMsg_ParticleManager.Types.SetParticleNamedValueContext Clone()
```

#### Returns

 [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetParticleNamedValueContext](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetParticleNamedValueContext.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleNamedValueContext_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleNamedValueContext_Equals_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleNamedValueContext_"></a> Equals\(SetParticleNamedValueContext\)

```csharp
public bool Equals(CUserMsg_ParticleManager.Types.SetParticleNamedValueContext other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetParticleNamedValueContext](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetParticleNamedValueContext.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleNamedValueContext_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleNamedValueContext_MergeFrom_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleNamedValueContext_"></a> MergeFrom\(SetParticleNamedValueContext\)

```csharp
public void MergeFrom(CUserMsg_ParticleManager.Types.SetParticleNamedValueContext other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetParticleNamedValueContext](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetParticleNamedValueContext.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleNamedValueContext_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleNamedValueContext_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleNamedValueContext_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

