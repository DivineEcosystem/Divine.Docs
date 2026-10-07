# <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_SetCreationTick"></a> Class CNETMsg\_SpawnGroup\_SetCreationTick

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CNETMsg_SpawnGroup_SetCreationTick : IMessage<CNETMsg_SpawnGroup_SetCreationTick>, IEquatable<CNETMsg_SpawnGroup_SetCreationTick>, IDeepCloneable<CNETMsg_SpawnGroup_SetCreationTick>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CNETMsg\_SpawnGroup\_SetCreationTick](Divine.Protobufs.Dota2.CNETMsg\_SpawnGroup\_SetCreationTick.md)

#### Implements

IMessage<CNETMsg\_SpawnGroup\_SetCreationTick\>, 
[IEquatable<CNETMsg\_SpawnGroup\_SetCreationTick\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CNETMsg\_SpawnGroup\_SetCreationTick\>, 
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
[EnumerableExtensions.In<CNETMsg\_SpawnGroup\_SetCreationTick\>\(CNETMsg\_SpawnGroup\_SetCreationTick, params CNETMsg\_SpawnGroup\_SetCreationTick\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_SetCreationTick__ctor"></a> CNETMsg\_SpawnGroup\_SetCreationTick\(\)

```csharp
public CNETMsg_SpawnGroup_SetCreationTick()
```

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_SetCreationTick__ctor_Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_SetCreationTick_"></a> CNETMsg\_SpawnGroup\_SetCreationTick\(CNETMsg\_SpawnGroup\_SetCreationTick\)

```csharp
public CNETMsg_SpawnGroup_SetCreationTick(CNETMsg_SpawnGroup_SetCreationTick other)
```

#### Parameters

`other` [CNETMsg\_SpawnGroup\_SetCreationTick](Divine.Protobufs.Dota2.CNETMsg\_SpawnGroup\_SetCreationTick.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_SetCreationTick_CreationsequenceFieldNumber"></a> CreationsequenceFieldNumber

```csharp
public const int CreationsequenceFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_SetCreationTick_SpawngrouphandleFieldNumber"></a> SpawngrouphandleFieldNumber

```csharp
public const int SpawngrouphandleFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_SetCreationTick_TickcountFieldNumber"></a> TickcountFieldNumber

```csharp
public const int TickcountFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_SetCreationTick_Creationsequence"></a> Creationsequence

```csharp
public uint Creationsequence { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_SetCreationTick_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_SetCreationTick_HasCreationsequence"></a> HasCreationsequence

```csharp
public bool HasCreationsequence { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_SetCreationTick_HasSpawngrouphandle"></a> HasSpawngrouphandle

```csharp
public bool HasSpawngrouphandle { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_SetCreationTick_HasTickcount"></a> HasTickcount

```csharp
public bool HasTickcount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_SetCreationTick_Parser"></a> Parser

```csharp
public static MessageParser<CNETMsg_SpawnGroup_SetCreationTick> Parser { get; }
```

#### Property Value

 MessageParser<[CNETMsg\_SpawnGroup\_SetCreationTick](Divine.Protobufs.Dota2.CNETMsg\_SpawnGroup\_SetCreationTick.md)\>

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_SetCreationTick_Spawngrouphandle"></a> Spawngrouphandle

```csharp
public uint Spawngrouphandle { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_SetCreationTick_Tickcount"></a> Tickcount

```csharp
public int Tickcount { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_SetCreationTick_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_SetCreationTick_ClearCreationsequence"></a> ClearCreationsequence\(\)

```csharp
public void ClearCreationsequence()
```

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_SetCreationTick_ClearSpawngrouphandle"></a> ClearSpawngrouphandle\(\)

```csharp
public void ClearSpawngrouphandle()
```

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_SetCreationTick_ClearTickcount"></a> ClearTickcount\(\)

```csharp
public void ClearTickcount()
```

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_SetCreationTick_Clone"></a> Clone\(\)

```csharp
public CNETMsg_SpawnGroup_SetCreationTick Clone()
```

#### Returns

 [CNETMsg\_SpawnGroup\_SetCreationTick](Divine.Protobufs.Dota2.CNETMsg\_SpawnGroup\_SetCreationTick.md)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_SetCreationTick_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_SetCreationTick_Equals_Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_SetCreationTick_"></a> Equals\(CNETMsg\_SpawnGroup\_SetCreationTick\)

```csharp
public bool Equals(CNETMsg_SpawnGroup_SetCreationTick other)
```

#### Parameters

`other` [CNETMsg\_SpawnGroup\_SetCreationTick](Divine.Protobufs.Dota2.CNETMsg\_SpawnGroup\_SetCreationTick.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_SetCreationTick_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_SetCreationTick_MergeFrom_Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_SetCreationTick_"></a> MergeFrom\(CNETMsg\_SpawnGroup\_SetCreationTick\)

```csharp
public void MergeFrom(CNETMsg_SpawnGroup_SetCreationTick other)
```

#### Parameters

`other` [CNETMsg\_SpawnGroup\_SetCreationTick](Divine.Protobufs.Dota2.CNETMsg\_SpawnGroup\_SetCreationTick.md)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_SetCreationTick_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_SetCreationTick_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_SetCreationTick_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

