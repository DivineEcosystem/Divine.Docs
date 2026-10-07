# <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ClearModellistOverride"></a> Class CUserMsg\_ParticleManager.Types.ClearModellistOverride

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMsg_ParticleManager.Types.ClearModellistOverride : IMessage<CUserMsg_ParticleManager.Types.ClearModellistOverride>, IEquatable<CUserMsg_ParticleManager.Types.ClearModellistOverride>, IDeepCloneable<CUserMsg_ParticleManager.Types.ClearModellistOverride>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMsg\_ParticleManager.Types.ClearModellistOverride](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.ClearModellistOverride.md)

#### Implements

IMessage<CUserMsg\_ParticleManager.Types.ClearModellistOverride\>, 
[IEquatable<CUserMsg\_ParticleManager.Types.ClearModellistOverride\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMsg\_ParticleManager.Types.ClearModellistOverride\>, 
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
[EnumerableExtensions.In<CUserMsg\_ParticleManager.Types.ClearModellistOverride\>\(CUserMsg\_ParticleManager.Types.ClearModellistOverride, params CUserMsg\_ParticleManager.Types.ClearModellistOverride\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ClearModellistOverride__ctor"></a> ClearModellistOverride\(\)

```csharp
public ClearModellistOverride()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ClearModellistOverride__ctor_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ClearModellistOverride_"></a> ClearModellistOverride\(ClearModellistOverride\)

```csharp
public ClearModellistOverride(CUserMsg_ParticleManager.Types.ClearModellistOverride other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[ClearModellistOverride](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.ClearModellistOverride.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ClearModellistOverride_GroupidFieldNumber"></a> GroupidFieldNumber

```csharp
public const int GroupidFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ClearModellistOverride_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ClearModellistOverride_Groupid"></a> Groupid

```csharp
public uint Groupid { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ClearModellistOverride_HasGroupid"></a> HasGroupid

```csharp
public bool HasGroupid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ClearModellistOverride_Parser"></a> Parser

```csharp
public static MessageParser<CUserMsg_ParticleManager.Types.ClearModellistOverride> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[ClearModellistOverride](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.ClearModellistOverride.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ClearModellistOverride_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ClearModellistOverride_ClearGroupid"></a> ClearGroupid\(\)

```csharp
public void ClearGroupid()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ClearModellistOverride_Clone"></a> Clone\(\)

```csharp
public CUserMsg_ParticleManager.Types.ClearModellistOverride Clone()
```

#### Returns

 [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[ClearModellistOverride](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.ClearModellistOverride.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ClearModellistOverride_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ClearModellistOverride_Equals_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ClearModellistOverride_"></a> Equals\(ClearModellistOverride\)

```csharp
public bool Equals(CUserMsg_ParticleManager.Types.ClearModellistOverride other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[ClearModellistOverride](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.ClearModellistOverride.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ClearModellistOverride_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ClearModellistOverride_MergeFrom_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ClearModellistOverride_"></a> MergeFrom\(ClearModellistOverride\)

```csharp
public void MergeFrom(CUserMsg_ParticleManager.Types.ClearModellistOverride other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[ClearModellistOverride](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.ClearModellistOverride.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ClearModellistOverride_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ClearModellistOverride_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ClearModellistOverride_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

