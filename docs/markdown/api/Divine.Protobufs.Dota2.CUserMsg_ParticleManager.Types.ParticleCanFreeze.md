# <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ParticleCanFreeze"></a> Class CUserMsg\_ParticleManager.Types.ParticleCanFreeze

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMsg_ParticleManager.Types.ParticleCanFreeze : IMessage<CUserMsg_ParticleManager.Types.ParticleCanFreeze>, IEquatable<CUserMsg_ParticleManager.Types.ParticleCanFreeze>, IDeepCloneable<CUserMsg_ParticleManager.Types.ParticleCanFreeze>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMsg\_ParticleManager.Types.ParticleCanFreeze](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.ParticleCanFreeze.md)

#### Implements

IMessage<CUserMsg\_ParticleManager.Types.ParticleCanFreeze\>, 
[IEquatable<CUserMsg\_ParticleManager.Types.ParticleCanFreeze\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMsg\_ParticleManager.Types.ParticleCanFreeze\>, 
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
[EnumerableExtensions.In<CUserMsg\_ParticleManager.Types.ParticleCanFreeze\>\(CUserMsg\_ParticleManager.Types.ParticleCanFreeze, params CUserMsg\_ParticleManager.Types.ParticleCanFreeze\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ParticleCanFreeze__ctor"></a> ParticleCanFreeze\(\)

```csharp
public ParticleCanFreeze()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ParticleCanFreeze__ctor_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ParticleCanFreeze_"></a> ParticleCanFreeze\(ParticleCanFreeze\)

```csharp
public ParticleCanFreeze(CUserMsg_ParticleManager.Types.ParticleCanFreeze other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[ParticleCanFreeze](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.ParticleCanFreeze.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ParticleCanFreeze_CanFreezeFieldNumber"></a> CanFreezeFieldNumber

```csharp
public const int CanFreezeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ParticleCanFreeze_CanFreeze"></a> CanFreeze

```csharp
public bool CanFreeze { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ParticleCanFreeze_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ParticleCanFreeze_HasCanFreeze"></a> HasCanFreeze

```csharp
public bool HasCanFreeze { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ParticleCanFreeze_Parser"></a> Parser

```csharp
public static MessageParser<CUserMsg_ParticleManager.Types.ParticleCanFreeze> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[ParticleCanFreeze](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.ParticleCanFreeze.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ParticleCanFreeze_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ParticleCanFreeze_ClearCanFreeze"></a> ClearCanFreeze\(\)

```csharp
public void ClearCanFreeze()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ParticleCanFreeze_Clone"></a> Clone\(\)

```csharp
public CUserMsg_ParticleManager.Types.ParticleCanFreeze Clone()
```

#### Returns

 [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[ParticleCanFreeze](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.ParticleCanFreeze.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ParticleCanFreeze_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ParticleCanFreeze_Equals_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ParticleCanFreeze_"></a> Equals\(ParticleCanFreeze\)

```csharp
public bool Equals(CUserMsg_ParticleManager.Types.ParticleCanFreeze other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[ParticleCanFreeze](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.ParticleCanFreeze.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ParticleCanFreeze_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ParticleCanFreeze_MergeFrom_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ParticleCanFreeze_"></a> MergeFrom\(ParticleCanFreeze\)

```csharp
public void MergeFrom(CUserMsg_ParticleManager.Types.ParticleCanFreeze other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[ParticleCanFreeze](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.ParticleCanFreeze.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ParticleCanFreeze_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ParticleCanFreeze_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ParticleCanFreeze_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

