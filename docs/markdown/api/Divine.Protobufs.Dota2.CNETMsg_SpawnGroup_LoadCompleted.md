# <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_LoadCompleted"></a> Class CNETMsg\_SpawnGroup\_LoadCompleted

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CNETMsg_SpawnGroup_LoadCompleted : IMessage<CNETMsg_SpawnGroup_LoadCompleted>, IEquatable<CNETMsg_SpawnGroup_LoadCompleted>, IDeepCloneable<CNETMsg_SpawnGroup_LoadCompleted>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CNETMsg\_SpawnGroup\_LoadCompleted](Divine.Protobufs.Dota2.CNETMsg\_SpawnGroup\_LoadCompleted.md)

#### Implements

IMessage<CNETMsg\_SpawnGroup\_LoadCompleted\>, 
[IEquatable<CNETMsg\_SpawnGroup\_LoadCompleted\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CNETMsg\_SpawnGroup\_LoadCompleted\>, 
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
[EnumerableExtensions.In<CNETMsg\_SpawnGroup\_LoadCompleted\>\(CNETMsg\_SpawnGroup\_LoadCompleted, params CNETMsg\_SpawnGroup\_LoadCompleted\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_LoadCompleted__ctor"></a> CNETMsg\_SpawnGroup\_LoadCompleted\(\)

```csharp
public CNETMsg_SpawnGroup_LoadCompleted()
```

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_LoadCompleted__ctor_Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_LoadCompleted_"></a> CNETMsg\_SpawnGroup\_LoadCompleted\(CNETMsg\_SpawnGroup\_LoadCompleted\)

```csharp
public CNETMsg_SpawnGroup_LoadCompleted(CNETMsg_SpawnGroup_LoadCompleted other)
```

#### Parameters

`other` [CNETMsg\_SpawnGroup\_LoadCompleted](Divine.Protobufs.Dota2.CNETMsg\_SpawnGroup\_LoadCompleted.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_LoadCompleted_SpawngrouphandleFieldNumber"></a> SpawngrouphandleFieldNumber

```csharp
public const int SpawngrouphandleFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_LoadCompleted_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_LoadCompleted_HasSpawngrouphandle"></a> HasSpawngrouphandle

```csharp
public bool HasSpawngrouphandle { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_LoadCompleted_Parser"></a> Parser

```csharp
public static MessageParser<CNETMsg_SpawnGroup_LoadCompleted> Parser { get; }
```

#### Property Value

 MessageParser<[CNETMsg\_SpawnGroup\_LoadCompleted](Divine.Protobufs.Dota2.CNETMsg\_SpawnGroup\_LoadCompleted.md)\>

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_LoadCompleted_Spawngrouphandle"></a> Spawngrouphandle

```csharp
public uint Spawngrouphandle { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_LoadCompleted_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_LoadCompleted_ClearSpawngrouphandle"></a> ClearSpawngrouphandle\(\)

```csharp
public void ClearSpawngrouphandle()
```

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_LoadCompleted_Clone"></a> Clone\(\)

```csharp
public CNETMsg_SpawnGroup_LoadCompleted Clone()
```

#### Returns

 [CNETMsg\_SpawnGroup\_LoadCompleted](Divine.Protobufs.Dota2.CNETMsg\_SpawnGroup\_LoadCompleted.md)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_LoadCompleted_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_LoadCompleted_Equals_Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_LoadCompleted_"></a> Equals\(CNETMsg\_SpawnGroup\_LoadCompleted\)

```csharp
public bool Equals(CNETMsg_SpawnGroup_LoadCompleted other)
```

#### Parameters

`other` [CNETMsg\_SpawnGroup\_LoadCompleted](Divine.Protobufs.Dota2.CNETMsg\_SpawnGroup\_LoadCompleted.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_LoadCompleted_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_LoadCompleted_MergeFrom_Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_LoadCompleted_"></a> MergeFrom\(CNETMsg\_SpawnGroup\_LoadCompleted\)

```csharp
public void MergeFrom(CNETMsg_SpawnGroup_LoadCompleted other)
```

#### Parameters

`other` [CNETMsg\_SpawnGroup\_LoadCompleted](Divine.Protobufs.Dota2.CNETMsg\_SpawnGroup\_LoadCompleted.md)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_LoadCompleted_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_LoadCompleted_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_LoadCompleted_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

