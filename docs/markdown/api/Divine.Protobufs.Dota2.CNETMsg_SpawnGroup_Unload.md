# <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Unload"></a> Class CNETMsg\_SpawnGroup\_Unload

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CNETMsg_SpawnGroup_Unload : IMessage<CNETMsg_SpawnGroup_Unload>, IEquatable<CNETMsg_SpawnGroup_Unload>, IDeepCloneable<CNETMsg_SpawnGroup_Unload>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CNETMsg\_SpawnGroup\_Unload](Divine.Protobufs.Dota2.CNETMsg\_SpawnGroup\_Unload.md)

#### Implements

IMessage<CNETMsg\_SpawnGroup\_Unload\>, 
[IEquatable<CNETMsg\_SpawnGroup\_Unload\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CNETMsg\_SpawnGroup\_Unload\>, 
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
[EnumerableExtensions.In<CNETMsg\_SpawnGroup\_Unload\>\(CNETMsg\_SpawnGroup\_Unload, params CNETMsg\_SpawnGroup\_Unload\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Unload__ctor"></a> CNETMsg\_SpawnGroup\_Unload\(\)

```csharp
public CNETMsg_SpawnGroup_Unload()
```

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Unload__ctor_Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Unload_"></a> CNETMsg\_SpawnGroup\_Unload\(CNETMsg\_SpawnGroup\_Unload\)

```csharp
public CNETMsg_SpawnGroup_Unload(CNETMsg_SpawnGroup_Unload other)
```

#### Parameters

`other` [CNETMsg\_SpawnGroup\_Unload](Divine.Protobufs.Dota2.CNETMsg\_SpawnGroup\_Unload.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Unload_FlagsFieldNumber"></a> FlagsFieldNumber

```csharp
public const int FlagsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Unload_SpawngrouphandleFieldNumber"></a> SpawngrouphandleFieldNumber

```csharp
public const int SpawngrouphandleFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Unload_TickcountFieldNumber"></a> TickcountFieldNumber

```csharp
public const int TickcountFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Unload_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Unload_Flags"></a> Flags

```csharp
public uint Flags { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Unload_HasFlags"></a> HasFlags

```csharp
public bool HasFlags { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Unload_HasSpawngrouphandle"></a> HasSpawngrouphandle

```csharp
public bool HasSpawngrouphandle { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Unload_HasTickcount"></a> HasTickcount

```csharp
public bool HasTickcount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Unload_Parser"></a> Parser

```csharp
public static MessageParser<CNETMsg_SpawnGroup_Unload> Parser { get; }
```

#### Property Value

 MessageParser<[CNETMsg\_SpawnGroup\_Unload](Divine.Protobufs.Dota2.CNETMsg\_SpawnGroup\_Unload.md)\>

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Unload_Spawngrouphandle"></a> Spawngrouphandle

```csharp
public uint Spawngrouphandle { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Unload_Tickcount"></a> Tickcount

```csharp
public int Tickcount { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Unload_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Unload_ClearFlags"></a> ClearFlags\(\)

```csharp
public void ClearFlags()
```

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Unload_ClearSpawngrouphandle"></a> ClearSpawngrouphandle\(\)

```csharp
public void ClearSpawngrouphandle()
```

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Unload_ClearTickcount"></a> ClearTickcount\(\)

```csharp
public void ClearTickcount()
```

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Unload_Clone"></a> Clone\(\)

```csharp
public CNETMsg_SpawnGroup_Unload Clone()
```

#### Returns

 [CNETMsg\_SpawnGroup\_Unload](Divine.Protobufs.Dota2.CNETMsg\_SpawnGroup\_Unload.md)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Unload_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Unload_Equals_Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Unload_"></a> Equals\(CNETMsg\_SpawnGroup\_Unload\)

```csharp
public bool Equals(CNETMsg_SpawnGroup_Unload other)
```

#### Parameters

`other` [CNETMsg\_SpawnGroup\_Unload](Divine.Protobufs.Dota2.CNETMsg\_SpawnGroup\_Unload.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Unload_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Unload_MergeFrom_Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Unload_"></a> MergeFrom\(CNETMsg\_SpawnGroup\_Unload\)

```csharp
public void MergeFrom(CNETMsg_SpawnGroup_Unload other)
```

#### Parameters

`other` [CNETMsg\_SpawnGroup\_Unload](Divine.Protobufs.Dota2.CNETMsg\_SpawnGroup\_Unload.md)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Unload_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Unload_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Unload_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

