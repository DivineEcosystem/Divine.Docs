# <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_ManifestUpdate"></a> Class CNETMsg\_SpawnGroup\_ManifestUpdate

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CNETMsg_SpawnGroup_ManifestUpdate : IMessage<CNETMsg_SpawnGroup_ManifestUpdate>, IEquatable<CNETMsg_SpawnGroup_ManifestUpdate>, IDeepCloneable<CNETMsg_SpawnGroup_ManifestUpdate>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CNETMsg\_SpawnGroup\_ManifestUpdate](Divine.Protobufs.Dota2.CNETMsg\_SpawnGroup\_ManifestUpdate.md)

#### Implements

IMessage<CNETMsg\_SpawnGroup\_ManifestUpdate\>, 
[IEquatable<CNETMsg\_SpawnGroup\_ManifestUpdate\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CNETMsg\_SpawnGroup\_ManifestUpdate\>, 
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
[EnumerableExtensions.In<CNETMsg\_SpawnGroup\_ManifestUpdate\>\(CNETMsg\_SpawnGroup\_ManifestUpdate, params CNETMsg\_SpawnGroup\_ManifestUpdate\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_ManifestUpdate__ctor"></a> CNETMsg\_SpawnGroup\_ManifestUpdate\(\)

```csharp
public CNETMsg_SpawnGroup_ManifestUpdate()
```

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_ManifestUpdate__ctor_Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_ManifestUpdate_"></a> CNETMsg\_SpawnGroup\_ManifestUpdate\(CNETMsg\_SpawnGroup\_ManifestUpdate\)

```csharp
public CNETMsg_SpawnGroup_ManifestUpdate(CNETMsg_SpawnGroup_ManifestUpdate other)
```

#### Parameters

`other` [CNETMsg\_SpawnGroup\_ManifestUpdate](Divine.Protobufs.Dota2.CNETMsg\_SpawnGroup\_ManifestUpdate.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_ManifestUpdate_ManifestincompleteFieldNumber"></a> ManifestincompleteFieldNumber

```csharp
public const int ManifestincompleteFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_ManifestUpdate_SpawngrouphandleFieldNumber"></a> SpawngrouphandleFieldNumber

```csharp
public const int SpawngrouphandleFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_ManifestUpdate_SpawngroupmanifestFieldNumber"></a> SpawngroupmanifestFieldNumber

```csharp
public const int SpawngroupmanifestFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_ManifestUpdate_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_ManifestUpdate_HasManifestincomplete"></a> HasManifestincomplete

```csharp
public bool HasManifestincomplete { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_ManifestUpdate_HasSpawngrouphandle"></a> HasSpawngrouphandle

```csharp
public bool HasSpawngrouphandle { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_ManifestUpdate_HasSpawngroupmanifest"></a> HasSpawngroupmanifest

```csharp
public bool HasSpawngroupmanifest { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_ManifestUpdate_Manifestincomplete"></a> Manifestincomplete

```csharp
public bool Manifestincomplete { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_ManifestUpdate_Parser"></a> Parser

```csharp
public static MessageParser<CNETMsg_SpawnGroup_ManifestUpdate> Parser { get; }
```

#### Property Value

 MessageParser<[CNETMsg\_SpawnGroup\_ManifestUpdate](Divine.Protobufs.Dota2.CNETMsg\_SpawnGroup\_ManifestUpdate.md)\>

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_ManifestUpdate_Spawngrouphandle"></a> Spawngrouphandle

```csharp
public uint Spawngrouphandle { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_ManifestUpdate_Spawngroupmanifest"></a> Spawngroupmanifest

```csharp
public ByteString Spawngroupmanifest { get; set; }
```

#### Property Value

 ByteString

## Methods

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_ManifestUpdate_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_ManifestUpdate_ClearManifestincomplete"></a> ClearManifestincomplete\(\)

```csharp
public void ClearManifestincomplete()
```

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_ManifestUpdate_ClearSpawngrouphandle"></a> ClearSpawngrouphandle\(\)

```csharp
public void ClearSpawngrouphandle()
```

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_ManifestUpdate_ClearSpawngroupmanifest"></a> ClearSpawngroupmanifest\(\)

```csharp
public void ClearSpawngroupmanifest()
```

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_ManifestUpdate_Clone"></a> Clone\(\)

```csharp
public CNETMsg_SpawnGroup_ManifestUpdate Clone()
```

#### Returns

 [CNETMsg\_SpawnGroup\_ManifestUpdate](Divine.Protobufs.Dota2.CNETMsg\_SpawnGroup\_ManifestUpdate.md)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_ManifestUpdate_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_ManifestUpdate_Equals_Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_ManifestUpdate_"></a> Equals\(CNETMsg\_SpawnGroup\_ManifestUpdate\)

```csharp
public bool Equals(CNETMsg_SpawnGroup_ManifestUpdate other)
```

#### Parameters

`other` [CNETMsg\_SpawnGroup\_ManifestUpdate](Divine.Protobufs.Dota2.CNETMsg\_SpawnGroup\_ManifestUpdate.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_ManifestUpdate_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_ManifestUpdate_MergeFrom_Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_ManifestUpdate_"></a> MergeFrom\(CNETMsg\_SpawnGroup\_ManifestUpdate\)

```csharp
public void MergeFrom(CNETMsg_SpawnGroup_ManifestUpdate other)
```

#### Parameters

`other` [CNETMsg\_SpawnGroup\_ManifestUpdate](Divine.Protobufs.Dota2.CNETMsg\_SpawnGroup\_ManifestUpdate.md)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_ManifestUpdate_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_ManifestUpdate_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_ManifestUpdate_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

